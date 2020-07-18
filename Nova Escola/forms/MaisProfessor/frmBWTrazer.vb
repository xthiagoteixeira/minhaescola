Imports Mais_Escola.WS_MaisEscola_Delib11
Imports Mais_Escola.WS_MaisEscola_Web
Imports System.ComponentModel

Public Class frmBWTrazer
    ReadOnly WS_MaisEscola_Web As New Web
    ReadOnly WS_MaisEscola_Delib11 As New Delib11

    Dim SQL As String
    Dim linhaAP, i, linhaStatus
    Dim Liberado = False
    Dim MeuBimestre
    Dim UsuarioWeb
    Dim SenhaWeb
    Dim ContaNroBoletins = 0
    Dim ContaNroDelib11 = 0

    Public Delegate Sub IncrementProgressDelegate()
    'Public Delegate Sub Delegação(ByVal texto As String, m As String)
    Public Delegate Sub Delegação2(Status As String, texto As String)

    'Public Sub DefinirBarra(ByVal texto As String, m As String)
    '    On Error Resume Next
    '    If barra.InvokeRequired Then
    '        Dim d As New Delegação(AddressOf DefinirBarra)
    '        barra.Properties.DisplayFormat.FormatString = barra.Invoke(d, texto)
    '        barra.Properties.Maximum = ContaNroBoletins
    '        barra.EditValue = m
    '    Else
    '        barra.Properties.DisplayFormat.FormatString = texto
    '        barra.Properties.Maximum = ContaNroBoletins
    '        barra.EditValue = m
    '    End If
    'End Sub
    Public Sub DefinirProgresso(Status As String, texto As String)
        On Error Resume Next
        If DGBoletim.InvokeRequired Then
            Dim d As New Delegação2(AddressOf DefinirProgresso)
            If Status = "S" Then
                DGBoletim.Invoke(d, DGBoletim.Rows.Add({ImageList.Images(1), DateTime.Now, texto}))
            Else
                DGBoletim.Invoke(d, DGBoletim.Rows.Add({ImageList.Images(0), DateTime.Now, texto}))
            End If
        Else
            '  barra.Properties.DisplayFormat.FormatString = texto
            If Status = "S" Then
                DGBoletim.Rows.Add({ImageList.Images(1), DateTime.Now, texto})
            Else
                DGBoletim.Rows.Add({ImageList.Images(0), DateTime.Now, texto})
            End If
        End If

        DGBoletim.CurrentCell = DGBoletim.Rows(DGBoletim.Rows.Count - 1).Cells(0)
    End Sub

    Sub TrazerDelib11()

        linhaAP = "Carregando Deliberação 11..."
        DefinirProgresso("S", linhaAP)

        'Pega as turmas disponíveis...
        SQL = "SELECT codigo_trma, classe FROM turma WHERE bloqueado='0';"
        Dim TurmasDisponiveis = MySQL_dataset(SQL)

        For Each r In TurmasDisponiveis.Tables(0).Rows
            Dim CodigoTurma = r("codigo_trma")
            Dim MinhaClasse = r("classe")

            'Consulta pra saber se tem ficha disponível...
            Dim BoletimNF = WS_MaisEscola_Delib11.trazerFicha(UsuarioWeb, SenhaWeb, CodigoEscola, tAno.Value,
                                                              CodigoTurma)

            'Tentar ver o que tem, se não tiver, nada insere.
            Try
                Dim Inseridas = 0
                Dim Atualizadas = 0

                For Each r2 In BoletimNF.Tables(0).Rows

                    Dim MeuAluno = r2("nro_aluno")
                    'Consulta se já tem cadastro
                    SQL = "SELECT idDelibNF FROM delib11_nf WHERE anovigente='" & tAno.Value & "' AND turma='" &
                          CodigoTurma & "' AND nro_aluno='" & MeuAluno & "';"
                    Dim idDelibNF = MySQL_consulta_campo(SQL, "idDelibNF")
                    If idDelibNF = "0" Then
                        'Não existe
                        SQL = "INSERT INTO delib11_nf (anovigente, turma, nro_aluno) VALUES('" & tAno.Value & "','" &
                              CodigoTurma & "','" & MeuAluno & "'); SELECT LAST_INSERT_ID() AS idDelibNF;"
                        idDelibNF = MySQL_atualiza(SQL)

                        Inseridas = Inseridas + 1
                    Else
                        ' APAGA AS QUE TEM ATUAL, E ATUALIZA...
                        SQL = "DELETE FROM delib11_boletim WHERE iddelibnf='" & idDelibNF & "';"
                        MySQL_atualiza(SQL)
                        Atualizadas = Atualizadas + 1
                    End If

                    ' Atualiza e/ou Insere...
                    Dim FichaCompleta = WS_MaisEscola_Delib11.trazerFicha2(UsuarioWeb, SenhaWeb, CodigoEscola,
                                                                           tAno.Value, CodigoTurma, MeuAluno)
                    For Each r3 In FichaCompleta.Tables(0).Rows
                        'Atualiza...
                        SQL = "UPDATE delib11_boletim SET iddelib_cat='" & r3("iddelib_cat") & "' WHERE iddelibnf='" &
                              idDelibNF & "' AND iddelib_des='" & r3("iddelib_des") & "';"
                        Dim Retorno = MySQL_atualiza(SQL)
                        If Retorno = "0" Then
                            ' Insere...
                            SQL = "INSERT INTO delib11_boletim (idDelibNF,iddelib_cat,iddelib_des) VALUES ('" &
                                  idDelibNF & "','" & r3("iddelib_cat") & "','" & r3("iddelib_des") & "');"
                            MySQL_atualiza(SQL)
                        End If
                    Next

                Next

                If Inseridas > 0 Or Atualizadas > 0 Then
                    linhaAP = "[ " & MinhaClasse & " ] - " & Inseridas & " inseridas / " & Atualizadas & " atualizadas."
                    arquivoLog("Deliberação 11", linhaAP)
                    DefinirProgresso("S", linhaAP)
                End If


            Catch ex As Exception
                linhaAP = "Turma: [ " & MinhaClasse & " ] - Nenhuma ficha."
                DefinirProgresso("F", linhaAP)
            End Try

        Next

        linhaAP = "******* FIM DA DELIBERAÇÃO 11 *******"
        DefinirProgresso("S", linhaAP)
    End Sub

    Sub TrazerBoletins()

        Dim r As DataRow
        Dim nro_aluno

        ' Pega todos OS SINCRONIZADOS = 1
        Try
            i = 1

            For Each r In WS_MaisEscola_Web.BW_Professor_NF(UsuarioWeb, SenhaWeb, CodigoEscola, tAno.Value, MeuBimestre).Tables(0).Rows

                'pega o codigo do boletim
                Dim cod_nf = r("cod_nf")
                Dim Minhaclasse = r("classe")
                Dim Minhadisciplina = r("disciplina")
                Dim CodigoTurma = r("CodigoTurma")
                Dim CodigoDisciplina = r("CodigoDisciplina")
                Dim bimestre = r("cod_bimestre")
                Dim ano = r("anovigente")
                Dim qtdadeaulas = r("qtdadeaulas")
                Dim previsaoaulas = r("previsaoaulas")

                'linhaAP = String.Format("Carregando: {0}o. bimestre - Boletim: [ {1} / {2} ] ", bimestre, Minhaclasse,
                '                        Minhadisciplina)
                'linhaStatus = "S"
                'bwTrazer.ReportProgress(i)

                ' VERIFICA SE EXISTE, LOCALMENTE...
                SQL =
                    String.Format(
                        "SELECT cod_nf FROM notasfreq WHERE turma='{0}' AND disciplina='{1}' AND cod_bimestre='{2}' AND anovigente='{3}';",
                        CodigoTurma, CodigoDisciplina, bimestre, ano)
                Dim BoletimExiste = MySQL_consulta_campo(SQL, "cod_nf")

                If BoletimExiste = "0" Then

                    Try
                        ' BOLETIM NAO EXISTE
                        ' Consulta o Codigo NF e Carrega o Boletim
                        Dim rCompleto As DataRow
                        Dim BoletimCompleto = WS_MaisEscola_Web.BW_Professor_NF_Boletim(UsuarioWeb, SenhaWeb,
                                                                                        CodigoEscola, cod_nf)

                        ' Insere no banco (notasfreq)
                        SQL =
                            String.Format(
                                "INSERT INTO notasfreq (cod_bimestre, turma, disciplina, anovigente, qtdadeaulas, previsaoaulas, dt_criacao, dt_atualizacao) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{6}'); SELECT LAST_INSERT_ID() AS cod_nf;",
                                bimestre, CodigoTurma, CodigoDisciplina, ano, qtdadeaulas, previsaoaulas,
                                Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss"))
                        Dim Novo_CodNF = MySQL_atualiza(SQL)

                        For Each rCompleto In BoletimCompleto.Tables(0).Rows

                            nro_aluno = rCompleto("nro_aluno").ToString
                            Try
                                ' Preenche o boletim...
                                '
                                Dim M = CStr(rCompleto("M")).ToString
                                Dim F = rCompleto("F").ToString
                                Dim AC = rCompleto("AC").ToString
                                Dim S = rCompleto("S").ToString

                                ' Insere no banco (boletim)...
                                SQL =
                                    String.Format(
                                        "INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S, porcentagem) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                                        Novo_CodNF, nro_aluno, M.Replace(",", "."), F, AC, S,
                                        Resultado_Porcentagem(F, AC, qtdadeaulas).ToString)
                                MySQL_atualiza(SQL)

                            Catch ex As Exception
                                ' DefinirProgresso("F", "Turma: " & Minhaclasse & " Disciplina: " & Minhadisciplina & " Erro: " &                                                 ex.Message)
                                linhaAP = "Erro! Turma: " & Minhaclasse & " Disciplina: " & Minhadisciplina & " [" &
                                          nro_aluno & "] Mensagem: " & ex.Message
                                linhaStatus = "F"
                                arquivoLog("Boletim", linhaAP)
                                bwTrazer.ReportProgress(i)
                            End Try

                        Next

                        linhaAP = String.Format("Cadastrado: {0}o. bimestre - Boletim: [ {1} / {2} ] ", bimestre,
                                                Minhaclasse, Minhadisciplina)
                        linhaStatus = "S"
                        arquivoLog("Boletim", linhaAP)
                        bwTrazer.ReportProgress(i)
                        'DefinirProgresso("S", linhaAP)

                    Catch ex As Exception
                        'DefinirProgresso("F", "Turma: " & Minhaclasse & " Disciplina: " & Minhadisciplina & " Erro: " & ex.Message)
                        linhaStatus = "F"
                        linhaAP = String.Format("Erro! Turma: {0} Disciplina: {1} [{2}] Mensagem: {3}", Minhaclasse, Minhadisciplina, nro_aluno, ex.Message)
                        arquivoLog("Boletim", linhaAP)
                        bwTrazer.ReportProgress(i)
                    End Try
                    ' FIM DO BOLETIM NÃO EXISTE
                Else

                    Try

                        ' BOLETIM EXISTE
                        ' Consulta o Codigo NF e Carrega o Boletim
                        Dim rCompleto As DataRow
                        Dim BoletimCompleto = WS_MaisEscola_Web.BW_Professor_NF_Boletim(UsuarioWeb, SenhaWeb,
                                                                                        CodigoEscola, cod_nf)

                        For Each rCompleto In BoletimCompleto.Tables(0).Rows
                            ' Preenche o boletim...
                            Try
                                nro_aluno = rCompleto("nro_aluno")
                                Dim M = CStr(rCompleto("M"))
                                Dim F = rCompleto("F")
                                Dim AC = rCompleto("AC")

                                ' ATUALIZA no banco (boletim)...
                                SQL =
                                    String.Format(
                                        "UPDATE boletim SET M='{0}', F='{1}', AC='{2}', S='0', porcentagem='{3}' WHERE cod_boletim='{4}' AND nro_aluno='{5}';",
                                        M.Replace(",", "."), F, AC, Resultado_Porcentagem(F, AC, qtdadeaulas).ToString,
                                        BoletimExiste, nro_aluno)
                                Dim Retorno = MySQL_atualiza(SQL)
                                ' Se não encontrar, insere!
                                If Retorno = 0 Then
                                    SQL =
                                        String.Format(
                                            "INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S, porcentagem) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '0', '{5}');",
                                            BoletimExiste, nro_aluno, M.Replace(",", "."), F, AC,
                                            Resultado_Porcentagem(F, AC, qtdadeaulas).ToString)
                                    MySQL_atualiza(SQL)
                                End If

                            Catch ex As Exception
                                'DefinirProgresso("F", "Turma: " & Minhaclasse & " Disciplina: " & Minhadisciplina & " Erro: " & ex.Message)
                                linhaStatus = "F"
                                linhaAP = "Erro! Turma: " & Minhaclasse & " Disciplina: " & Minhadisciplina & " [" &
                                          nro_aluno & "] Mensagem: " & ex.Message
                                arquivoLog("Boletim", linhaAP)
                                bwTrazer.ReportProgress(i)
                            End Try
                        Next

                        'linhaAP = "-> Atualizado com sucesso!"
                        linhaAP = String.Format("Atualizado: {0}o. bimestre - Boletim: [ {1} / {2} ] ", bimestre,
                                                Minhaclasse, Minhadisciplina)
                        arquivoLog("Boletim", linhaAP)
                        linhaStatus = "S"
                        bwTrazer.ReportProgress(i)
                        'SQL = "UPDATE notasfreq SET dt_atualizacao='" & Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss") &
                        '      "' WHERE cod_nf='" & BoletimExiste & "';"
                        'MySQL_atualiza(SQL)

                        'ATUALIZA AULAS DADAS E PREVISTAS...
                        SQL = String.Format(
                                "UPDATE notasfreq SET qtdadeaulas='{0}', previsaoaulas='{1}', dt_atualizacao='{2}' WHERE cod_nf='{3}';",
                                qtdadeaulas, previsaoaulas, Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss"), BoletimExiste)
                        MySQL_atualiza(SQL)

                    Catch ex As Exception
                        'DefinirProgresso("F", "Turma: " & Minhaclasse & " Disciplina: " & Minhadisciplina & " Erro: " & ex.Message)
                        linhaAP = "Erro! Turma: " & Minhaclasse & " Disciplina: " & Minhadisciplina & " Mensagem: " &
                                  ex.Message
                        arquivoLog("Boletim", linhaAP)
                        linhaStatus = "F"
                        bwTrazer.ReportProgress(i)
                    End Try

                End If
                i = i + 1
            Next
        Catch ex As Exception
            'DefinirProgresso("F", " Erro: " & ex.Message)
            linhaStatus = "F"
            linhaAP = "Erro: " & ex.Message
            arquivoLog("Boletim", linhaAP)
            bwTrazer.ReportProgress(i)
        End Try
    End Sub

    Sub Carrega_NroDelib11()

        ContaNroDelib11 = 0

        ' Consulta quantas Delib11
        ContaNroDelib11 = WS_MaisEscola_Delib11.trazerNro(UsuarioWeb, SenhaWeb, CodigoEscola, CStr(tAno.Value))
        lbNroDelib11.Text = ContaNroDelib11

        If ContaNroDelib11 > 0 Then
            btImportar.Enabled = True
        End If
    End Sub

    Sub Carrega_NroBoletim()

        ContaNroBoletins = 0

        If cbAF.Checked = True Then
            MeuBimestre = tBimestre.Value & "AF"
        Else
            MeuBimestre = tBimestre.Value
        End If

        Liberado = False

        'SQL = "SELECT ferramenta3 FROM preferencias WHERE idPreferencias='1';"
        'UsuarioWeb = MySQL_consulta_campo(SQL, "ferramenta3")

        'SQL = "SELECT ferramenta4 FROM preferencias WHERE idPreferencias='1';"
        'SenhaWeb = MySQL_consulta_campo(SQL, "ferramenta4")

        Try
            'Pega o BD para passar como parametro...
            Dim Morpheus_Web As New Web
            'CodigoEscola = (Morpheus_Web.BW_Ativacao(UsuarioWeb, SenhaWeb))
            ' Consulta quantos boletins tem disponível para trazer.
            ContaNroBoletins = Morpheus_Web.BW_TrazerNotas_NroBoletins(UsuarioWeb, SenhaWeb, CodigoEscola, tAno.Value,
                                                                       MeuBimestre)
            '  Dim Conta02
            ' If Liberado = True Then
            '    Conta02 = Morpheus_Web.BW_TrazerNotas_NroBoletins(UsuarioWeb, SenhaWeb, CodigoEscola, CStr(tAno.Value), MeuBimestre)
            ' End If

            lbNroBoletins.Text = ContaNroBoletins

            ' Libera o botão trazer...
            If ContaNroBoletins = 0 Then
                barra.Properties.DisplayFormat.FormatString = "Nenhum boletim encontrado!"
                pErradoB.Visible = True
                pCertoB.Visible = False
                btImportar.Enabled = False
            ElseIf ContaNroBoletins = 1 Then
                barra.Properties.DisplayFormat.FormatString = ContaNroBoletins & " boletim encontrado!"
                pErradoB.Visible = False
                pCertoB.Visible = True
                btImportar.Enabled = True
            ElseIf ContaNroBoletins > 1 Then
                barra.Properties.DisplayFormat.FormatString = ContaNroBoletins & " boletins encontrado!"
                pErradoB.Visible = False
                pCertoB.Visible = True
                btImportar.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("Favor, verificar a conexão da internet!", MsgBoxStyle.Information, "Internet indisponível!")
        End Try
    End Sub

    Private Sub frmBWTrazer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmBWTrazer"
        tAno.Value = AnoVigente

        'PUXA O BIMESTRE ATUAL................
        Dim atualBimestre = Format(Date.Now, "MM")

        If atualBimestre <= "05" Then
            tBimestre.Value = "1"
        ElseIf atualBimestre <= "07" Then
            tBimestre.Value = "2"
            Liberado = True
        ElseIf atualBimestre <= "10" Then
            tBimestre.Value = "3"
        ElseIf atualBimestre <= "12" Then
            tBimestre.Value = "4"
            Liberado = True
        End If

        Carrega_NroBoletim()
        Carrega_NroDelib11()
    End Sub

    Private Sub btImportar_Click(sender As Object, e As EventArgs) Handles btImportar.Click

        '  MsgBox("Clique em OK, e aguarde...", MsgBoxStyle.Information, "Mais Professor! - Online")

        btImportar.Enabled = False

        linhaAP = "******* MAIS PROFESSOR! - ONLINE *******"
        DefinirProgresso("S", linhaAP)

        pCertoI.Visible = True
        pErradoI.Visible = False

        bwTrazer.RunWorkerAsync()
    End Sub

    Private Sub cbAF_CheckedChanged(sender As Object, e As EventArgs) Handles cbAF.CheckedChanged
        Carrega_NroBoletim()
        Carrega_NroDelib11()
    End Sub

    Private Sub tBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles tBimestre.EditValueChanged

        If (tBimestre.Value = 2 Or tBimestre.Value = 4) Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
        Carrega_NroBoletim()
        Carrega_NroDelib11()
    End Sub

    'Private Sub btImprimir_Click(sender As Object, e As EventArgs)

    '    frmPreview_Titulo = "Mais Professor! Online : Trazer Notas!"

    '    Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = DGBoletim}
    '    AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
    '    Link.CreateDocument()
    '    Link.ShowPreview()

    'End Sub

    Private Sub bwTrazer_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwTrazer.DoWork
        If ContaNroBoletins > 0 Then
            Me.TrazerBoletins()
        End If
        If ContaNroDelib11 > 0 Then
            Me.TrazerDelib11()
        End If
    End Sub

    Private Sub bwTrazer_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) _
        Handles bwTrazer.ProgressChanged
        Invoke(Sub()
                   Me.barra.Properties.DisplayFormat.FormatString = "Boletins: [ " & e.ProgressPercentage & " / " &
                                                                    ContaNroBoletins & " ]"
                   Me.barra.EditValue = e.ProgressPercentage
                   Me.barra.Properties.Maximum = ContaNroBoletins
                   DefinirProgresso(linhaStatus, linhaAP)
               End Sub)
    End Sub

    Private Sub bwTrazer_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwTrazer.RunWorkerCompleted

        pCertoIF.Visible = True
        pErradoIF.Visible = False

        linhaAP = "******* FINALIZADO *******"
        DefinirProgresso("S", linhaAP)

        MsgBox("Concluído com sucesso!", MsgBoxStyle.Information, "Mais Professor! - Online")
        'btImprimir.Enabled = True
    End Sub

    Private Sub tAno_EditValueChanged(sender As Object, e As EventArgs) Handles tAno.EditValueChanged
        Carrega_NroBoletim()
        Carrega_NroDelib11()
    End Sub
End Class