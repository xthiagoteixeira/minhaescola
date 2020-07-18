Public Class frmManGerarAF

    Dim NroMaximoAluno As Integer
    Dim nroturma
    Dim EuCliquei = False
    Dim r As DataRow

    Sub Mostra_DataGrid()

        SQL = String.Format("SELECT turma.classe AS Turma, disciplinas.disciplina AS Disciplina FROM notasfreq INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc INNER JOIN turma ON notasfreq.turma = turma.codigo_trma WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='4' AND turma.classe='{1}';", tAno.Value, cbTurma.Text)
        Dim MinhaDataGrid As DataTable = MySQL_datatable(SQL)
        DGAvaliacaoFinal.DataSource = Nothing
        DGAvaliacaoFinal.DataSource = MinhaDataGrid
        Try
            r = MinhaDataGrid.Rows(0)
            'btEfetuar.Enabled = True

        Catch ex As Exception
            MsgBox("Nenhum boletim 4º bimestre encontrado!", MsgBoxStyle.Information, "Não encontrado!")
            ' btEfetuar.Enabled = False
        End Try


    End Sub

    Public Sub ConsultaAF()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim Sql = String.Format("SELECT * FROM turma WHERE bloqueado='0' AND classe='{0}';", cbTurma.Text)
        nroturma = MySQL_consulta_campo(Sql, "codigo_trma")

        Sql = String.Format("SELECT nro FROM aluno WHERE turma='{0}' ORDER BY nro DESC;", nroturma)
        NroMaximoAluno = MySQL_consulta_campo(Sql, "nro")


        '\\\\\\\\\\\\\\ CHECA SE EXISTE ////////////////////
        Sql = String.Format("SELECT * from notasfreq WHERE turma='{0}' AND cod_bimestre='4AF' AND anovigente='{1}';", nroturma, tAno.Value)
        Dim Existe = MySQL_consulta_campo(Sql, "cod_nf")

        If Existe <> "0" Then
            If MsgBox(String.Format("Já foi gerado 4º Avaliação Final para: [ {0} - {1}] deseja continuar?", cbTurma.Text, tAno.Value), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                btEfetuar.Enabled = True
            Else
                btEfetuar.Enabled = False
            End If
        Else
            btEfetuar.Enabled = True
        End If

    End Sub

    Private Sub frmManAulasPrevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = AnoVigente
        Dim SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
        'cbTurma.Properties.Items.Clear()
        cbTurma.Properties.DataSource = MySQL_datatable(SQL)
        cbTurma.Properties.DisplayMember = "classe"

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btEfetuar.Click
        Dim DataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")

        If cbTurma.Text = String.Empty Then
            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)
        Else

            ' APAGA TURMA 4AF PARA GERAR
            Dim Sql = String.Format("DELETE FROM notasfreq WHERE anovigente='{1}' AND cod_bimestre='4AF' AND turma='{0}';", nroturma, tAno.Value)
            MySQL_atualiza(Sql)

            ' Pega apenas o 4º bimestre como referencia...
            Sql = String.Format("SELECT cod_nf, disciplina FROM notasfreq WHERE anovigente='{1}' AND cod_bimestre='4' AND turma='{0}' ORDER BY disciplina ASC;", nroturma, tAno.Value)
            Dim MinhaDisciplina = MySQL_datatable(Sql)

            For Each r In MinhaDisciplina.Rows

                Dim disciplina = r("disciplina").ToString

                'Cria NOTAS_FREQ...
                Dim Sql2 = String.Format("INSERT INTO notasfreq (turma, disciplina, cod_bimestre, qtdadeaulas, previsaoaulas, anovigente, dt_criacao, dt_atualizacao) values('{0}','{1}', '4AF', '0', '0', '{2}', '{3}', '{3}'); SELECT LAST_INSERT_ID() AS cod_nf;", nroturma, disciplina, tAno.Value, DataHoje)
                Dim vBO = MySQL_atualiza(Sql2)

                Dim SQL3 = String.Format("SELECT boletim.nro_aluno AS Nro, AVG(boletim.M) AS AV FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim WHERE notasfreq.anovigente='{0}' AND notasfreq.turma='{1}' AND notasfreq.disciplina='{2}' GROUP BY (boletim.nro_aluno) ORDER BY boletim.nro_aluno ASC;", tAno.Value, nroturma, disciplina)
                Dim MeuBoletim = MySQL_datatable(SQL3)

                For Each r2 In MeuBoletim.Rows
                    Dim Sql4 = String.Format("INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S) values('{0}', '{1}','{2}', '0', '0', '1');", vBO, r2("Nro").ToString, CInt(r2("AV").ToString))
                    MySQL_atualiza(Sql4)
                Next

            Next

            Sql = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Gerou 4a Avaliação Final de: {0}.', '{1}', '1', '{2}');", cbTurma.Text, idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
            MySQL_atualiza(Sql)
            MsgBox("Gerado com sucesso!", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub cbTurma_Click(sender As Object, e As EventArgs) Handles cbTurma.Click
        EuCliquei = True

    End Sub

    Private Sub cbTurma_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbTurma.KeyPress
        e.Handled = True

    End Sub

    Private Sub cbTurma_EditValueChanged(sender As Object, e As EventArgs) Handles cbTurma.EditValueChanged
        If EuCliquei = True Then
            ConsultaAF()
            Mostra_DataGrid()
            EuCliquei = False
        End If

    End Sub

End Class