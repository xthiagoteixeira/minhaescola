Public Class frmCadBoletimTela
    Public Shared fCad234 As New frmCadBoletim
    Dim bimestre
    Dim turma, disciplina, nroDisciplina

    Sub ConsultaAulas()

        bimestre = tBimestre.Value

        Try
            Dim SQL_AD =
                    String.Format(
                        "SELECT qtdadeaulas FROM notasfreq WHERE cod_bimestre='{0}' AND turma='{1}' AND disciplina='{2}' AND anovigente='{3}';",
                        bimestre, nroTurmaAluno, nroDisciplina, tAno.Value)
            tQtdade.Value = MySQL_consulta_campo(SQL_AD, "qtdadeaulas")

            Dim SQL_AP =
                    String.Format(
                        "SELECT previsaoaulas FROM notasfreq WHERE cod_bimestre='{0}' AND turma='{1}' AND disciplina='{2}' AND anovigente='{3}';",
                        bimestre, nroTurmaAluno, nroDisciplina, tAno.Value)
            pQtdade.Value = MySQL_consulta_campo(SQL_AP, "previsaoaulas")

            If pQtdade.Value <> "0" And tQtdade.Value <> "0" Then
                pQtdade.Enabled = False
                tQtdade.Enabled = False
            Else
                pQtdade.Enabled = True
                tQtdade.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCadNF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmCadBoletimTela"

        'PUXA O BIMESTRE ATUAL................
        tBimestre.Value = consultaBimestre()

        ManNF_Global_Boletim_Existe = False

        'DEIXAR COMO PADRAO O ANO
        tAno.Value = AnoVigente

        Dim SQL = "SELECT disciplina FROM disciplinas WHERE bloqueado='0' AND disciplina<>'-' ORDER BY disciplina ASC;"
        cbDisciplina.Properties.DataSource = MySQL_combobox(SQL)
        cbDisciplina.Properties.DisplayMember = "disciplina"

        SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
        cbTurma.Properties.DataSource = MySQL_combobox(SQL)
        cbTurma.Properties.DisplayMember = "classe"

        'Consulta se o professor tem disciplinas/turmas atribuidas...
        '
        '
        SQL = "SELECT DISTINCT " _
              & "turma.classe As Turma " _
              & "FROM " _
              & "usuariodsk " _
              & "INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK " _
              & "INNER JOIN disciplinas ON disciplinas.codigo_disc = professor_grupos.codigo_disc " _
              & "INNER JOIN turma ON turma.codigo_trma = professor_grupos.codigo_trma " _
              & "WHERE usuariodsk.usuario='" & UsuarioSistema & "' ORDER BY turma.classe, disciplinas.disciplina ASC;"
        Dim Teste_UsuarioSistema = MySQL_consulta_campo(SQL, "Turma")

        If Teste_UsuarioSistema <> "0" Then
            cbTurma.Properties.DataSource = MySQL_combobox(SQL)
            cbTurma.Properties.DisplayMember = "Turma"
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim AF_Gerar = False

        If cbAF.Checked = True And tBimestre.Value = 2 Then
            bimestre = "2AF"
            AF_Gerar = True

        ElseIf cbAF.Checked = True And tBimestre.Value = 4 Then
            bimestre = "4AF"
            AF_Gerar = True

        Else
            bimestre = tBimestre.Value
            AF_Gerar = False
        End If

        If Not (cbTurma.Text = String.Empty Or cbDisciplina.Text = String.Empty) Then

            Dim vStrMsg As String =
                    MsgBox(
                        String.Format("Boletim {0}o. Bimestre - Turma: {1} - Disciplina: {2}", bimestre, cbTurma.Text,
                                      cbDisciplina.Text), MsgBoxStyle.YesNo, "Deseja cadastrar o boletim?")

            If vStrMsg = MsgBoxResult.Yes Then

                turma = Consulta_Turma(cbTurma.Text)
                nroTurmaAluno = turma

                disciplina = Consulta_Disciplina(cbDisciplina.Text)

                Dim Sql =
                        String.Format(
                            "SELECT cod_nf FROM notasfreq WHERE disciplina='{0}' AND turma='{1}' AND cod_bimestre='{2}' AND anovigente='{3}';",
                            disciplina, turma, bimestre, tAno.Value)
                meuboletim = MySQL_consulta_campo(Sql, "cod_nf")

                Dim DataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")

                If meuboletim = "0" Then

                    arquivoLog("Boletim",
                               "Cadastrou [" & tAno.Text & "] " & bimestre & "o Bimestre : " & cbTurma.Text & " - " &
                               cbDisciplina.Text)

                    'Sql = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Cadastrou {0}o Bimestre :{1} - {2}', '{3}', '2', '{4}');", tBimestre.Value, cbTurma.Text, cbDisciplina.Text, idUsuarioDSK, DataHoje)
                    'MySQL_atualiza(Sql)

                    Sql =
                        String.Format(
                            "INSERT INTO notasfreq (turma, disciplina, cod_bimestre, qtdadeaulas, previsaoaulas, anovigente, dt_criacao, dt_atualizacao) values({0},'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{6}'); SELECT LAST_INSERT_ID() AS cod_nf;",
                            turma, disciplina, bimestre, tQtdade.Value, pQtdade.Value, tAno.Value, DataHoje)
                    meuboletim = MySQL_atualiza(Sql)
                    ManNF_Global_Boletim_Existe = False

                    If AF_Gerar = True Then
                        '...Verifica se possui 2 ou 4 bimestres digitados no sistema.
                        Sql =
                            String.Format(
                                "SELECT COUNT(cod_nf) AS contadorBoletim FROM notasfreq WHERE anovigente='{2}' AND disciplina='{0}' AND turma='{1}';",
                                disciplina, turma, tAno.Value)
                        Dim MinhaAF = MySQL_consulta_campo(Sql, "contadorBoletim")
                        If MinhaAF = 2 Or MinhaAF = 4 Then

                            ' Verifica se o usuário deseja GERAR a média final...
                            Dim vStrMsgAF As String =
                                    MsgBox(
                                        String.Format(
                                            "Deseja gerar um boletim de Avaliação Final para: Turma: {0} - Disciplina: {1}?",
                                            cbTurma.Text, cbDisciplina.Text), MsgBoxStyle.YesNo, "Avaliação Final")
                            If vStrMsgAF = MsgBoxResult.Yes Then

                                Sql =
                                    String.Format(
                                        "SELECT b.nro_aluno AS NroAluno, AVG(b.M) AS AV, AVG(b.F) AS FT, AVG(b.AC) AS AC, AVG(b.porcentagem) AS porcentagem FROM notasfreq n, boletim b WHERE n.cod_nf=b.cod_boletim AND n.anovigente='{0}' AND n.turma='{1}' AND n.disciplina='{2}' GROUP BY (b.nro_aluno) ORDER BY b.nro_aluno ASC;",
                                        tAno.Value, turma, disciplina)
                                Dim ResultadoAF = MySQL_datatable(Sql)
                                For Each r In ResultadoAF.Rows
                                    Sql =
                                        String.Format(
                                            "INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S, porcentagem) values( '{0}', '{1}', '{2}', '0', '0', '0', '0');",
                                            meuboletim, r("NroAluno"), CInt(r("AV")))
                                    MySQL_atualiza(Sql)
                                Next

                                ManNF_Global_Disciplina = cbDisciplina.Text
                                ManNF_Global_Turma = cbTurma.Text
                                ManNF_Global_Boletim = bimestre
                                ManNF_Global_qtaulas = tQtdade.Value
                                ManNF_Global_nro = meuboletim
                                ManNF_Global_AnoVigente = tAno.Value
                                ManNF_Global_qtaulasprevistas = pQtdade.Value

                                ' Abre a manutenção...
                                Dim fMan234 As New frmManBoletim() With {.MdiParent = frmMaisEscola_Novo}
                                fMan234.Show()
                                Exit Sub

                                'Else

                                '    ManNF_Global_Disciplina = cbDisciplina.Text
                                '    ManNF_Global_Turma = cbTurma.Text
                                '    ManNF_Global_Boletim = bimestre
                                '    ManNF_Global_qtaulas = tQtdade.Value
                                '    ManNF_Global_nro = meuboletim
                                '    ManNF_Global_AnoVigente = tAno.Value
                                '    ManNF_Global_qtaulasprevistas = pQtdade.Value

                                '    Dim fCad234_2 As New frmCadBoletim() With {.MdiParent = frmMaisEscola}
                                '    fCad234_2.Show()

                                '    Me.Close()
                            End If

                        End If
                    End If

                Else

                    If _
                        (MsgBox(
                            String.Format("Boletim: {0}o. Bimestre - Turma: {1} - Disciplina: {2}", bimestre,
                                          cbTurma.Text, cbDisciplina.Text), MsgBoxStyle.YesNo,
                            "Deseja continuar a digitação?") = MsgBoxResult.Yes) Then
                        ManNF_Global_Boletim_Existe = True
                    Else
                        Exit Sub
                    End If

                End If

                ManNF_Global_Disciplina = cbDisciplina.Text
                ManNF_Global_Turma = cbTurma.Text
                ManNF_Global_Boletim = bimestre
                ManNF_Global_qtaulas = tQtdade.Value
                ManNF_Global_nro = meuboletim
                ManNF_Global_AnoVigente = tAno.Value
                ManNF_Global_qtaulasprevistas = pQtdade.Value

                Me.Close()

                Dim fCad234 As New frmCadBoletim() With {.MdiParent = frmMaisEscola_Novo}
                fCad234.Show()

            End If

        End If
    End Sub

    Private Sub cbAF_CheckedChanged(sender As Object, e As EventArgs) Handles cbAF.CheckedChanged

        tQtdade.Enabled = True
        pQtdade.Enabled = True

        If (tBimestre.Value = 2 Or tBimestre.Value = 4) And cbAF.Checked = True Then
            tBimestre.Enabled = False
            MsgBox(
                "1 - Aprovado (na disciplina)" & vbCrLf & "3 - Retido por Freqüência Insuficiente (na disciplina)" &
                vbCrLf & "4 - Retido por Rendimento Insuficiente (na disciplina)", MsgBoxStyle.Information,
                "Informações de Situação Final")
            tQtdade.Value = 0
            pQtdade.Value = 0
            tQtdade.Enabled = False
            pQtdade.Enabled = False

        End If
    End Sub

    Private Sub tAno_EditValueChanged(sender As Object, e As EventArgs) Handles tAno.EditValueChanged
        ConsultaAulas()
    End Sub

    Private Sub cbTurma_TextChanged(sender As Object, e As EventArgs) Handles cbTurma.TextChanged

        If cbTurma.Text <> String.Empty Then

            nroTurmaAluno = Consulta_Turma(cbTurma.Text)
            ConsultaAulas()

            'Consulta se o professor tem disciplinas/turmas atribuidas...
            '
            Dim SQL = "SELECT " _
                      & "disciplinas.disciplina AS Disciplina " _
                      & "FROM " _
                      & "usuariodsk " _
                      & "INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK " _
                      & "INNER JOIN disciplinas ON disciplinas.codigo_disc = professor_grupos.codigo_disc " _
                      & "INNER JOIN turma ON turma.codigo_trma = professor_grupos.codigo_trma " _
                      & "WHERE usuariodsk.usuario='" & UsuarioSistema & "' AND turma.classe='" & cbTurma.Text &
                      "' ORDER BY disciplinas.disciplina ASC;"
            Dim Teste_UsuarioSistema = MySQL_consulta_campo(SQL, "Disciplina")

            If Teste_UsuarioSistema <> "0" Then
                cbDisciplina.Properties.DataSource = MySQL_combobox(SQL)
                cbDisciplina.Properties.DisplayMember = "Disciplina"
            End If

        End If
    End Sub

    Private Sub cbDisciplina_TextChanged(sender As Object, e As EventArgs) Handles cbDisciplina.TextChanged
        If cbDisciplina.Text <> String.Empty Then
            nroDisciplina = Consulta_Disciplina(cbDisciplina.Text)
            ConsultaAulas()
        End If
    End Sub

    Private Sub tBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles tBimestre.EditValueChanged

        If tBimestre.Value = 2 Or tBimestre.Value = 4 Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
        bimestre = tBimestre.Value

        ConsultaAulas()
    End Sub
End Class