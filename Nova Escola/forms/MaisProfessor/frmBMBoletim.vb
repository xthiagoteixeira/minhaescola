Imports System.ComponentModel
Imports System.IO

Public Class frmBMBoletim
    Dim mensagem As String

    Dim eBoletim = 0
    Dim mydrive
    Dim trava = 0
    Dim ndisciplina As Integer = 0
    Dim nturma As Integer = 0

    ReadOnly pDisciplinas(9999) As String
    ReadOnly pTurmas(9999) As String
    ReadOnly pBimestre(9999) As String
    ReadOnly pAno(9999) As String

    Dim m = 0
    Dim myturma
    Dim mydisciplinas
    Dim myano

    Dim nboletim = 0

    ReadOnly iTurmas(9999)
    ReadOnly iDisciplinas(9999)
    ReadOnly pBoletim(9999)

    Dim novoBO As Integer = 0
    Dim vBO = 0

    ReadOnly novaDisciplinas(9999) As String
    ReadOnly novaTurmas(9999) As String
    ReadOnly novaBimestre(9999) As String
    ReadOnly novaAno(9999)

    '...................
    'Cadastro dos boletins
    Dim turmaBO, disciplinaBO As Integer
    Dim bimestreBO As String
    Dim anoBO = myano
    Dim driveBO = mydrive
    Dim BoletimNaoEncontrado = 0
    '...................

    Dim pPath As String
    Dim ano As Integer
    Dim bimestre
    Dim turma, disciplina As String
    Dim turma2, disciplina2 As Integer
    Dim biTotal = 0
    Dim ichecaDisciplinas As Integer = 0
    Dim ichecaTurmas As Integer = 0
    Dim linha, linhaAP, DataHoje

    Public Delegate Sub IncrementProgressDelegate()

    Public Delegate Sub Delegação(texto As String)

    Public Delegate Sub Delegação2(Status As String, texto As String)

    Public Sub DefinirBarra(texto As String)
        On Error Resume Next
        If barra.InvokeRequired Then
            Dim d As New Delegação(AddressOf DefinirBarra)
            barra.Properties.DisplayFormat.FormatString = barra.Invoke(d, texto)
            barra.Properties.Maximum = novoBO
            barra.EditValue = m

        Else
            barra.Properties.DisplayFormat.FormatString = texto
            barra.Properties.Maximum = novoBO
            barra.EditValue = m

        End If
    End Sub

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

    Sub InserirRecibo(linha As String, arquivo As String)

        Dim Fa, ArquivoAtual
        Dim fs As Object = CreateObject("Scripting.FileSystemObject")
        Fa = fs.GetFile(arquivo)
        ArquivoAtual = CStr(Fa.DateCreated)
        ArquivoAtual = Format(CDate(ArquivoAtual), "yyyy-MM-dd HH:mm:ss")

        linha = linha.Replace("\", "/")
        SQL = String.Format("INSERT INTO rpt_recibo (recibo, data) VALUES('{0}', '{1}')", linha, ArquivoAtual)
        MySQL_atualiza(SQL)
    End Sub

    Sub EncontrarBoletins()

        If mydrive <> String.Empty Then

            ' barra.Text = "Procurando boletins..."
            'barra.Text = 8
            Dim k = 0
            Dim j = 0
            nboletim = 0

            If eBoletim = 1 Then

                'Checa pela Turma
                For k = 0 To nturma
                    ' Checa pela Disciplina
                    myturma = iTurmas(k)

                    For j = 0 To ndisciplina

                        mydisciplinas = iDisciplinas(j)
                        myano = tAno.Value

                        If tBimestre.Value = "1" Then
                            '// 1 Bimestre
                            If _
                                (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\1.txt", mydrive, myano,
                                                                                 myturma, mydisciplinas)) = True) Then
                                pPath = String.Format("{0}{1}\{2}\{3}\1.txt", mydrive, tAno.Value, myturma,
                                                      mydisciplinas)
                                pBoletim(nboletim) = pPath

                                pBimestre(nboletim) = "1"
                                pDisciplinas(nboletim) = mydisciplinas
                                pTurmas(nboletim) = myturma
                                pAno(nboletim) = myano
                                nboletim = nboletim + 1
                            End If

                        ElseIf tBimestre.Value = "2" Then

                            '// 2 Bimestre
                            If _
                                (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\2.txt", mydrive, myano,
                                                                                 myturma, mydisciplinas)) = True) Then
                                pPath = String.Format("{0}{1}\{2}\{3}\2.txt", mydrive, tAno.Value, myturma,
                                                      mydisciplinas)
                                pBoletim(nboletim) = pPath

                                pBimestre(nboletim) = "2"
                                pDisciplinas(nboletim) = mydisciplinas
                                pTurmas(nboletim) = myturma
                                pAno(nboletim) = myano
                                nboletim = nboletim + 1

                            End If

                            '// 2AF Bimestre
                            If _
                                (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\2AF.txt", mydrive,
                                                                                 myano, myturma, mydisciplinas)) = True) _
                                Then
                                pPath = String.Format("{0}{1}\{2}\{3}\2AF.txt", mydrive, tAno.Value, myturma,
                                                      mydisciplinas)
                                pBoletim(nboletim) = pPath

                                pBimestre(nboletim) = "2AF"
                                pDisciplinas(nboletim) = mydisciplinas
                                pTurmas(nboletim) = myturma
                                pAno(nboletim) = myano
                                nboletim = nboletim + 1

                            End If


                        ElseIf tBimestre.Value = "3" Then

                            '// 3 Bimestre
                            If _
                                (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\3.txt", mydrive, myano,
                                                                                 myturma, mydisciplinas)) = True) Then
                                pPath = String.Format("{0}{1}\{2}\{3}\3.txt", mydrive, tAno.Value, myturma,
                                                      mydisciplinas)
                                pBoletim(nboletim) = pPath

                                pBimestre(nboletim) = "3"
                                pDisciplinas(nboletim) = mydisciplinas
                                pTurmas(nboletim) = myturma
                                pAno(nboletim) = myano
                                nboletim = nboletim + 1
                            End If

                        ElseIf tBimestre.Value = "4" Then

                            '// 4 Bimestre
                            If _
                                (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\4.txt", mydrive, myano,
                                                                                 myturma, mydisciplinas)) = True) Then
                                pPath = String.Format("{0}{1}\{2}\{3}\4.txt", mydrive, tAno.Value, myturma,
                                                      mydisciplinas)
                                pBoletim(nboletim) = pPath

                                pBimestre(nboletim) = "4"
                                pDisciplinas(nboletim) = mydisciplinas
                                pTurmas(nboletim) = myturma
                                pAno(nboletim) = myano
                                nboletim = nboletim + 1
                            End If

                            '// 4AF Bimestre
                            If _
                                (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\4AF.txt", mydrive,
                                                                                 myano, myturma, mydisciplinas)) = True) _
                                Then
                                pPath = String.Format("{0}{1}\{2}\{3}\4AF.txt", mydrive, tAno.Value, myturma,
                                                      mydisciplinas)
                                pBoletim(nboletim) = pPath

                                pBimestre(nboletim) = "4AF"
                                pDisciplinas(nboletim) = mydisciplinas
                                pTurmas(nboletim) = myturma
                                pAno(nboletim) = myano
                                nboletim = nboletim + 1
                            End If
                        End If
                    Next
                Next

                Dim linha = String.Format("{0} boletins encontrados!", nboletim)
                DefinirProgresso("S", linha)

                If nboletim > 0 Then
                    pErradoB.Visible = False
                    pCertoB.Visible = True
                    btTrazer.Enabled = True

                Else
                    pErradoB.Visible = True
                    pCertoB.Visible = False
                    btTrazer.Enabled = False
                End If

                linha = "Finalizado a busca de turmas/disciplinas/boletins!"
                DefinirProgresso("S", linha)

            End If
        End If
    End Sub

    Sub ImportacaoBoletins()

        'Apaga o recibo antigo!
        '
        SQL = "DELETE FROM rpt_recibo WHERE idRecibo>0;"
        MySQL_atualiza(SQL)

        '///////// Inicio a importação propriamente dita (novoBO)... /////////'
        For m = 0 To novoBO

            Dim Texto = String.Empty
            Texto = String.Format("[ {0} / {1} ] boletins", m, novoBO)
            DefinirBarra(Texto)

            mydisciplinas = novaDisciplinas(m)
            myturma = novaTurmas(m)
            myano = novaAno(m)

            '//////////////////////////////  1 Bimestre
            If (novaBimestre(m) = "1") Then
                Dim MinhaLinha As String = String.Format("{0}{1}\{2}\{3}\1.txt", mydrive, myano, myturma, mydisciplinas)
                If _
                    (My.Computer.FileSystem.FileExists(MinhaLinha) = True) And
                    (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\1boletim.txt", mydrive, myano,
                                                                     myturma, mydisciplinas)) = True) Then

                    'Busca o número da Turma e Disciplina
                    vTD(myturma, mydisciplinas)

                    'Bimestre atual
                    bimestreBO = 1

                    anoBO = myano
                    driveBO = mydrive

                    vCADBO(disciplinaBO, turmaBO, bimestreBO, myano, mydrive)

                End If
                '#############/ FIM 1

            ElseIf (novaBimestre(m) = "2") Then
                Dim MinhaLinha As String = String.Format("{0}{1}\{2}\{3}\2.txt", mydrive, myano, myturma, mydisciplinas)
                If _
                    (My.Computer.FileSystem.FileExists(MinhaLinha) = True) And
                    (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\2boletim.txt", mydrive, myano,
                                                                     myturma, mydisciplinas)) = True) Then

                    'Busca o número da Turma e Disciplina
                    vTD(myturma, mydisciplinas)

                    'Bimestre atual
                    bimestreBO = 2

                    anoBO = myano
                    driveBO = mydrive

                    vCADBO(disciplinaBO, turmaBO, bimestreBO, myano, mydrive)

                End If
                '#############/ FIM 2

            ElseIf (novaBimestre(m) = "3") Then
                Dim MinhaLinha As String = String.Format("{0}{1}\{2}\{3}\3.txt", mydrive, myano, myturma, mydisciplinas)
                If _
                    (My.Computer.FileSystem.FileExists(MinhaLinha) = True) And
                    (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\3boletim.txt", mydrive, myano,
                                                                     myturma, mydisciplinas)) = True) Then

                    'Busca o número da Turma e Disciplina
                    vTD(myturma, mydisciplinas)

                    'Bimestre atual
                    bimestreBO = 3

                    anoBO = myano
                    driveBO = mydrive

                    vCADBO(disciplinaBO, turmaBO, bimestreBO, myano, mydrive)

                End If
                '#############/ FIM 3

            ElseIf (novaBimestre(m) = "4") Then
                Dim MinhaLinha As String = String.Format("{0}{1}\{2}\{3}\4.txt", mydrive, myano, myturma, mydisciplinas)
                If _
                    (My.Computer.FileSystem.FileExists(MinhaLinha) = True) And
                    (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\4boletim.txt", mydrive, myano,
                                                                     myturma, mydisciplinas)) = True) Then

                    'Busca o número da Turma e Disciplina
                    vTD(myturma, mydisciplinas)

                    'Bimestre atual
                    bimestreBO = 4

                    anoBO = myano
                    driveBO = mydrive

                    vCADBO(disciplinaBO, turmaBO, bimestreBO, myano, mydrive)

                End If
                '#############/ FIM 4

            ElseIf (novaBimestre(m) = "2AF") Then
                Dim MinhaLinha As String = String.Format("{0}{1}\{2}\{3}\2AF.txt", mydrive, myano, myturma,
                                                         mydisciplinas)
                If _
                    (My.Computer.FileSystem.FileExists(MinhaLinha) = True) And
                    (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\2AFboletim.txt", mydrive, myano,
                                                                     myturma, mydisciplinas)) = True) Then

                    'Busca o número da Turma e Disciplina
                    vTD(myturma, mydisciplinas)

                    'Bimestre atual
                    bimestreBO = "2AF"

                    anoBO = myano
                    driveBO = mydrive

                    vCADBO(disciplinaBO, turmaBO, bimestreBO, myano, mydrive)

                End If
                '#############/ FIM 2AF

            ElseIf (novaBimestre(m) = "4AF") Then
                Dim MinhaLinha As String = String.Format("{0}{1}\{2}\{3}\4AF.txt", mydrive, myano, myturma,
                                                         mydisciplinas)
                If _
                    (My.Computer.FileSystem.FileExists(MinhaLinha) = True) And
                    (My.Computer.FileSystem.FileExists(String.Format("{0}{1}\{2}\{3}\4AFboletim.txt", mydrive, myano,
                                                                     myturma, mydisciplinas)) = True) Then

                    'Busca o número da Turma e Disciplina
                    vTD(myturma, mydisciplinas)

                    'Bimestre atual
                    bimestreBO = "4AF"

                    anoBO = myano
                    driveBO = mydrive

                    vCADBO(disciplinaBO, turmaBO, bimestreBO, myano, mydrive)

                End If
            End If
            '#############/ FIM 4AF
        Next
    End Sub

    Sub vTD(vT As String, vD As String)

        disciplinaBO = Consulta_Disciplina(vD)
        turmaBO = Consulta_Turma(vT)
    End Sub

    Public Sub vCADBO(disciplinaBO, turmaBO, bimestreBO, anoBO, driveBO)

        Dim confBO(300)
        Dim mediaBO(300)
        Dim faltaBO(300)
        Dim compensacaoBO(300)
        Dim prBO(300)

        Dim iconfBO = 0
        Dim imediaBO = 1

        '//////// Puxar Configurações do Boletim...
        Dim tQtdade = 1
        Dim pQtdade = 1
        Dim arquivoo As String = String.Format("{0}{1}\{2}\{3}\{4}.txt", driveBO, anoBO, myturma, mydisciplinas,
                                               bimestreBO)

        Try
            Dim objStreamBO2 As New StreamReader(arquivoo)
            Dim linee As String = objStreamBO2.ReadLine

            While Not linee Is Nothing
                confBO(iconfBO) = linee
                iconfBO = iconfBO + 1
                linee = objStreamBO2.ReadLine
            End While
            tQtdade = confBO(4)
            pQtdade = confBO(5)
            objStreamBO2.Close()
        Catch ex As Exception
            Dim linha = String.Format("{0} - Erro no arquivo! | {1}", arquivoo, ex.Message.ToString())
            DefinirProgresso("F", linha)

            InserirRecibo(linha, arquivoo)
            Exit Sub
        End Try
        '///////// Fim das Configurações do Boletim...

        '//////// Boletim...
        Dim arquivoBoletim As String = String.Format("{0}{1}\{2}\{3}\{4}boletim.txt", driveBO, anoBO, myturma,
                                                     mydisciplinas, bimestreBO)
        Try
            Dim objStreamMEDIA2 As New StreamReader(arquivoBoletim)
            Dim line11 As String = objStreamMEDIA2.ReadLine
            Dim matriz() As String

            While Not line11 Is Nothing
                matriz = line11.Split(";")

                mediaBO(imediaBO) = matriz(1).Trim
                faltaBO(imediaBO) = matriz(2).Trim
                compensacaoBO(imediaBO) = matriz(3).Trim
                prBO(imediaBO) = matriz(4).Trim

                imediaBO = imediaBO + 1
                line11 = objStreamMEDIA2.ReadLine
            End While
            objStreamMEDIA2.Close()
        Catch ex As Exception
            Dim linha = String.Format("{0} - Erro no arquivo! | {1}", arquivoBoletim, ex.Message.ToString())
            DefinirProgresso("F", linha)

            '   If cbRecibo.Checked = True Then
            InserirRecibo(linha, arquivoBoletim)

            Exit Sub
        End Try

        If cbSobreescrever.Checked = False Then

            ' $$$$$$ CASO NAO EXISTA
            SQL =
                String.Format(
                    "INSERT INTO notasfreq (turma, disciplina, cod_bimestre, qtdadeaulas, previsaoaulas, anovigente, dt_criacao, dt_atualizacao) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{6}'); SELECT LAST_INSERT_ID() AS cod_nf;",
                    turmaBO, disciplinaBO, bimestreBO, tQtdade, pQtdade, anoBO, DataHoje)
            vBO = MySQL_atualiza(SQL)
            biTotal = biTotal + 1
            BoletimNaoEncontrado = True


        ElseIf cbSobreescrever.Checked = True Then

            SQL =
                String.Format(
                    "SELECT cod_nf FROM notasfreq WHERE turma='{0}' AND disciplina='{1}' AND anovigente='{2}' AND cod_bimestre='{3}';",
                    turmaBO, disciplinaBO, anoBO, bimestreBO)
            vBO = MySQL_consulta_campo(SQL, "cod_nf")

            ' $$$$$$ CASO EXISTA, UPDATE!
            SQL =
                String.Format(
                    "UPDATE notasfreq SET dt_atualizacao='{3}', qtdadeaulas='{0}', previsaoaulas='{1}' WHERE cod_nf='{2}';",
                    tQtdade, pQtdade, vBO, DataHoje)
            MySQL_atualiza(SQL)
            biTotal = biTotal + 1
            BoletimNaoEncontrado = False

        End If

        '//////// EFETIVAR O CADASTRO...
        Dim F, AC, AULAS As Integer

        If BoletimNaoEncontrado = True Then

            Dim ProblemaBoletim = False

            '########## CADASTRA ############
            For i = 1 To imediaBO - 1
                Try
                    F = faltaBO(i).ToString()
                    AC = compensacaoBO(i).ToString()
                    AULAS = tQtdade.ToString()

                    Dim M As String = mediaBO(i).ToString()
                    M = M.Replace(",", ".").ToString()

                    '//// inicio do mysql notas e frequencias...
                    SQL =
                        String.Format(
                            "INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S, porcentagem) values({0}, {1}, {2}, {3}, {4}, '0', '{5}');",
                            vBO, i, M, faltaBO(i), compensacaoBO(i), Resultado_Porcentagem(F, AC, AULAS).ToString)

                    Dim Retorno = MySQL_atualiza(SQL)
                    If Retorno = -1 Then
                        ProblemaBoletim = True
                        'MsgBox(SQL)
                        Exit For
                    End If
                    '//// fim do mysql notas e frequencias.
                Catch ex As Exception
                    ProblemaBoletim = True
                    'MsgBox(SQL)
                    Exit For
                End Try
            Next

            If ProblemaBoletim = False Then

                Dim arquivolinha As String = String.Format("{0}{1}\{2}\{3}\{4}.txt", driveBO, anoBO, myturma,
                                                           mydisciplinas, bimestreBO)
                Dim linha = String.Format("{0} - Incluído com sucesso!", arquivolinha)
                DefinirProgresso("S", linha)

                InserirRecibo(linha, arquivolinha)

                arquivoLog("Boletim", "Cadastrado via PenDrive " & arquivolinha)

            Else
                'Constatado o erro, apagar nas tabelas: boletim e notasfreq.
                SQL = String.Format("DELETE FROM boletim WHERE cod_boletim='{0}';", vBO)
                MySQL_atualiza(SQL)
                SQL = String.Format("DELETE FROM notasfreq WHERE cod_nf='{0}';", vBO)
                MySQL_atualiza(SQL)

                Dim arquivolinha As String = String.Format("{0}{1}\{2}\{3}\{4}.txt", driveBO, anoBO, myturma,
                                                           mydisciplinas, bimestreBO)
                Dim linha = String.Format("{0} - Erro no arquivo!")
                DefinirProgresso("F", linha)

                '   If cbRecibo.Checked = True Then
                InserirRecibo(linha, arquivolinha)

                arquivoLog("Boletim", "Erro! Cadastro via PenDrive " & arquivolinha)
                'End If
            End If


        ElseIf BoletimNaoEncontrado = False Then

            '########## ATUALIZA ############
            Dim ProblemaBoletim = False

            For i = 1 To imediaBO - 1
                Try
                    F = faltaBO(i)
                    AC = compensacaoBO(i)
                    AULAS = CInt(tQtdade)

                    '//// inicio do mysql notas e frequencias...
                    SQL =
                        String.Format(
                            "UPDATE boletim SET M='{0}', F='{1}', AC='{2}', S='0', porcentagem='{3}' WHERE cod_boletim='{4}' AND nro_aluno='{5}';",
                            mediaBO(i), faltaBO(i), compensacaoBO(i), Resultado_Porcentagem(F, AC, AULAS), vBO, i)
                    Dim Retorno = MySQL_atualiza(SQL)
                    '//// fim do mysql notas e frequencias...
                    If Retorno = 0 Then
                        SQL =
                            String.Format(
                                "INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S, porcentagem) values({0},{1}, {2}, {3}, {4}, '0', {5});",
                                vBO, i, mediaBO(i), faltaBO(i), compensacaoBO(i), Resultado_Porcentagem(F, AC, AULAS))
                        MySQL_atualiza(SQL)
                    End If
                    '//// fim do mysql notas e frequencias.

                Catch ex As Exception
                    ProblemaBoletim = True
                    Exit For
                End Try
            Next

            If ProblemaBoletim = False Then
                Dim arquivolinha As String = String.Format("{0}{1}\{2}\{3}\{4}.txt", driveBO, anoBO, myturma,
                                                           mydisciplinas, bimestreBO)

                If vBO = "0" Then
                    Dim linha = String.Format("{0} - Não existe boletim!", arquivolinha)
                    DefinirProgresso("F", linha)
                Else
                    Dim linha = String.Format("{0} - Atualizado com sucesso!", arquivolinha)
                    DefinirProgresso("S", linha)
                    arquivoLog("Boletim", "Atualizado via PenDrive " & arquivolinha)

                End If

                '  If cbRecibo.Checked = True Then
                InserirRecibo(linha, arquivolinha)
                'End If
            Else
                'Constatado o erro, apagar nas tabelas: boletim e notasfreq.
                SQL = String.Format("DELETE FROM boletim WHERE cod_boletim='{0}';", vBO)
                MySQL_atualiza(SQL)
                SQL = String.Format("DELETE FROM notasfreq WHERE cod_nf='{0}';", vBO)
                MySQL_atualiza(SQL)

                Dim arquivolinha As String = String.Format("{0}{1}\{2}\{3}\{4}.txt", driveBO, anoBO, myturma,
                                                           mydisciplinas, bimestreBO)
                Dim linha = String.Format("{0} - Erro na atualização!", arquivolinha)
                DefinirProgresso("F", linha)

                arquivoLog("Boletim", "Erro! Cadastro via PenDrive " & arquivolinha)

                '  If cbRecibo.Checked = True Then
                InserirRecibo(linha, arquivolinha)
                '   End If
            End If
        End If
        '//////// FIM Efetivar o cadastro do 1/2/3/4º bimestre

        '  If cbImprimirBoletim.Checked = True Then
        Dim DataLancamento = Format(Date.Now, "yyyy-MM-dd")
        SQL = String.Format("INSERT INTO notasfreq_prof (data_lancamento, grupo, cod_nf) values('{0}','{1}','{2}');",
                            DataLancamento, iUltimoNotasFreqProf, vBO)
        MySQL_atualiza(SQL)
        '  End If
    End Sub


    Sub Inicial()

        cbDisco.Properties.Items.Clear()
        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            'Dim tipoDrive = drive.DriveType
            'If tipoDrive = DriveType.Removable Then
            cbDisco.Properties.Items.Add(drive)
            'End If
        Next drive

        pErradoT.Visible = True
        pCertoT.Visible = False

        pErradoD.Visible = True
        pCertoD.Visible = False

        pErradoB.Visible = True
        pCertoB.Visible = False

        pErradoI.Visible = True
        pCertoI.Visible = False

        pErradoIF.Visible = True
        pCertoIF.Visible = False

        btImprimir_Consolidado.Enabled = False
        btImprimir_Recibo.Enabled = False
    End Sub

    Public Sub frmImpBoletim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmBMBoletim"
        Inicial()

        tAno.Value = Format(Date.Now, "yyyy")
        tBimestre.Value = consultaBimestre()

        ' Quantidade de disciplinas...
        SQL = "SELECT disciplina FROM disciplinas WHERE bloqueado='0' AND disciplina<>'-' ORDER BY disciplina ASC;"
        Dim Disciplinas = MySQL_datatable(SQL)
        For Each r In Disciplinas.Rows
            ichecaDisciplinas = ichecaDisciplinas + 1
        Next

        ' Quantidade de turmas...
        SQL = "SELECT * FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
        Dim Turmas = MySQL_datatable(SQL)
        For Each r In Turmas.Rows
            ichecaTurmas = ichecaTurmas + 1
        Next
    End Sub

    Public Sub bkProcesso_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkProcesso.DoWork
        Me.ImportacaoBoletins()
    End Sub

    Private Sub bkProcesso_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bkProcesso.RunWorkerCompleted

        If biTotal = 0 Then
            '  barra.Properties.DisplayFormat.FormatString = "Nenhum boletim cadastrado!"

            '  barra.ForeColor = Color.Lime
            linhaAP = "Nenhum boletim importado!"
            DefinirProgresso("F", linhaAP)

            pCertoI.Visible = False
            pErradoI.Visible = True
            pCertoIF.Visible = True
            pErradoIF.Visible = False
        ElseIf biTotal = 1 Then
            mensagem = String.Format("{0} boletim cadastrado!", biTotal)
            '  barra.Properties.DisplayFormat.FormatString += mensagem
            ' barra.ForeColor = Color.Lime
            linhaAP = String.Format("{0} boletim importado com sucesso...", biTotal)
            DefinirProgresso("S", linhaAP)

            pCertoI.Visible = True
            pCertoIF.Visible = True
            pErradoIF.Visible = False
            pErradoI.Visible = False
        ElseIf biTotal > 1 Then
            mensagem = String.Format("{0} boletins cadastrados!", biTotal)

            '  barra.Properties.DisplayFormat.FormatString += mensagem
            '  barra.ForeColor = Color.Lime
            mensagem = String.Format("{0} boletins importado com sucesso...", biTotal)
            DefinirProgresso("S", mensagem)

            ' barra.Properties.DisplayFormat.FormatString += mensagem
            pCertoI.Visible = True
            pCertoIF.Visible = True
            pErradoI.Visible = False
            pErradoIF.Visible = False
        End If

        linhaAP = "Finalizado a importação de boletins!"
        DefinirProgresso("S", linhaAP)
        btTrazer.Enabled = False
        tAno.Enabled = False
        tBimestre.Enabled = False

        ' ############## PERGUNTA SE PODE IMPRIMIR O QUE O PROFESSOR DIGITOU #####################
        If biTotal > 0 Then
            btImprimir_Consolidado.Enabled = True
            btImprimir_Recibo.Enabled = True

        End If
    End Sub

    Private Sub cbDisco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDisco.SelectedIndexChanged
        mydrive = cbDisco.Text
        Dim ArquivoProfessor = String.Format("{0}{1}\professor.txt", mydrive, tAno.Value)
        Dim ArqDisciplinas = String.Format("{0}{1}\disciplinas.txt", mydrive, tAno.Value)
        Dim ArqTurmas = String.Format("{0}{1}\turmas.txt", mydrive, tAno.Value)
        Dim ProfessorPersonalizado = False

        If _
            Not _
            ((My.Computer.FileSystem.FileExists(ArquivoProfessor) = True) Or
             (My.Computer.FileSystem.FileExists(ArqDisciplinas) = True) Or
             (My.Computer.FileSystem.FileExists(ArqTurmas) = True)) Then
            '   barra.Properties.DisplayFormat.FormatString = "Listas não encontradas!"
            '  MsgBox(barra.Properties.DisplayFormat.FormatString, MsgBoxStyle.Information, "Informação")
            pCertoT.Visible = False
            pCertoD.Visible = False
            pErradoD.Visible = True
            pErradoT.Visible = True
            cbDisco.Enabled = True
            '  barra.Properties.DisplayFormat.FormatString = 0
            Exit Sub
        End If

        If (My.Computer.FileSystem.FileExists(ArquivoProfessor) = True) Then
            ProfessorPersonalizado = True
        Else
            ProfessorPersonalizado = False
        End If

        If ProfessorPersonalizado = False Then

            ' TURMAS.txt e DISCIPLINAS.txt...
            Try
                ' barra.Text = "Checando Turmas..."

                ' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ TURMAS \\\\\\\\\\\\\\\\\\
                Dim objStream As New FileStream(ArqTurmas, FileMode.Open)
                Dim Arq As New StreamReader(objStream)
                Dim linhaTexto As String = Arq.ReadLine
                Dim contador = 0
                Dim Resultado As String

                mensagem = "Procurando turmas..."
                DefinirProgresso("S", mensagem)

                While Not linhaTexto Is Nothing
                    Resultado = Consulta_Turma(linhaTexto)

                    If Resultado = "0" Then
                        contador = contador + 1
                        mensagem = String.Format("{0} - não cadastrada no sistema!{1}", linhaTexto, vbCrLf)
                        DefinirProgresso("F", mensagem)
                    Else
                        iTurmas(nturma) = linhaTexto
                    End If

                    nturma = nturma + 1
                    linhaTexto = Arq.ReadLine
                End While

                If contador = 0 Then
                    linha = String.Format("{0} turmas encontradas!", nturma)
                    DefinirProgresso("S", linha)
                Else
                    linha = String.Format("{0} turma(s) não cadastrada(s) no sistema.", contador)
                    DefinirProgresso("F", linha)
                End If
                linha = "Finalizado a busca de turmas..."
                DefinirProgresso("S", linha)
                Arq.Close()

                '  barra.Text = "Turmas Ok!"
                ' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ FIM DE TURMAS \\\\\\\\\\\\\\\\\\

                '///////////////// DISCIPLINAS ///////////////
                Dim objStream2 As New FileStream(ArqDisciplinas, FileMode.Open)
                Dim Arq2 As New StreamReader(objStream2)
                Dim linhaTexto2 As String = Arq2.ReadLine
                Dim contador2 = 0

                linha = "Procurando disciplinas..."
                DefinirProgresso("S", linha)

                While Not linhaTexto2 Is Nothing

                    ' CLASSE, checa se o que tem no disquete, tem no sistema...
                    Resultado = Consulta_Disciplina(linhaTexto2)

                    If Resultado = "0" Then
                        contador2 = contador2 + 1
                        linha = linhaTexto2 & " - não cadastrada no sistema!"
                        DefinirProgresso("F", linha)

                    Else
                        iDisciplinas(ndisciplina) = linhaTexto2
                    End If

                    ndisciplina = ndisciplina + 1
                    linhaTexto2 = Arq2.ReadLine
                End While

                If contador2 = 0 Then
                    linha = ndisciplina & " disciplinas encontradas!"
                    DefinirProgresso("S", linha)
                Else
                    linha = contador2 & " disciplina(s) não cadastrada(s) no sistema."
                    DefinirProgresso("F", linha)
                End If
                linha = "Finalizado a busca de disciplinas!"
                DefinirProgresso("S", linha)
                Arq2.Close()

                '///////////////// FIM DISCIPLINAS ///////////////

                If (ndisciplina > 0) And (nturma > 0) Then
                    'MsgBox("Lista de turmas e disciplinas foram encontradas", MsgBoxStyle.Information)
                    ' barra.Text = "Listas encontradas!"
                    ' barra.ForeColor = Color.Lime
                    pErradoT.Visible = False
                    pCertoT.Visible = True
                    pErradoD.Visible = False
                    pCertoD.Visible = True
                    cbDisco.Enabled = False
                    eBoletim = 1
                Else
                    'MsgBox("Lista de turmas e disciplinas não foram encontradas", MsgBoxStyle.Information)
                    ' barra.Text = "Listas não encontradas!"
                    '  barra.ForeColor = Color.Red
                    pErradoT.Visible = True
                    pCertoT.Visible = False
                    pErradoD.Visible = True
                    pCertoD.Visible = False
                    cbDisco.Enabled = True
                    eBoletim = 0
                End If

            Catch ex As Exception
                'MsgBox("Desculpe, disco inválido!", MsgBoxStyle.Information, "Informação!")
                ' barra.ForeColor = Color.Red
            End Try
            '/////// FIM DE TURMAS.txt e DISCIPLINAS.txt

        Else
            '...INICIO PROFESSOR.txt

            Try
                '  barra.Text = "Checando Turmas..."
                ' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ TURMAS \\\\\\\\\\\\\\\\\\
                Dim objStream As New FileStream(ArquivoProfessor, FileMode.Open)
                Dim Arq As New StreamReader(objStream)
                Dim linhaTexto As String = Arq.ReadLine
                Dim contador = 0
                Dim contador2 = 0
                Dim Resultado As String
                Dim matriz() As String

                mensagem = "Procurando turmas e disciplinas..."
                DefinirProgresso("S", mensagem)

                While Not linhaTexto Is Nothing

                    matriz = linhaTexto.Split(";")

                    Resultado = Consulta_Turma(matriz(0).Trim)
                    If Resultado = "0" Then
                        contador = contador + 1
                        mensagem = String.Format("{0} - não cadastrada no sistema!", matriz(0).Trim)
                        DefinirProgresso("F", mensagem)
                    Else
                        For i = 0 To contador Step 1
                            If iTurmas(i) = matriz(0).Trim Then
                                iTurmas(i) = matriz(0).Trim
                                Exit For
                            End If
                            If i = contador Then
                                iTurmas(nturma) = matriz(0).Trim
                            End If
                        Next

                    End If

                    Resultado = Consulta_Disciplina(matriz(1).Trim)
                    If Resultado = "0" Then
                        contador2 = contador2 + 1
                        linha = String.Format("{0} - não cadastrada no sistema!", matriz(1).Trim)
                        DefinirProgresso("F", linha)
                    Else

                        For i = 0 To contador2 Step 1
                            'Procura se já existe...
                            Dim procura = 0
                            Dim DisciplinaExiste = False
                            For Each nome In iDisciplinas
                                nome = matriz(1).Trim
                                If nome = iDisciplinas(procura) Then
                                    DisciplinaExiste = True
                                End If
                                procura += 1
                            Next
                            If DisciplinaExiste = False Then
                                iDisciplinas(ndisciplina) = matriz(1).Trim
                                ndisciplina = ndisciplina + 1
                            End If
                        Next

                        'For i = 0 To contador2 Step 1
                        '    If iDisciplinas(i) = matriz(1).Trim Then
                        '        iDisciplinas(i) = matriz(1).Trim
                        '        Exit For
                        '    End If
                        '    If i = contador2 Then
                        '        iDisciplinas(ndisciplina) = matriz(1).Trim
                        '    End If
                        'Next

                    End If

                    nturma = nturma + 1
                    ndisciplina = ndisciplina + 1
                    linhaTexto = Arq.ReadLine
                End While

                'Turmas!
                If contador = 0 Then
                    linha = String.Format("{0} turmas encontradas!", nturma)
                    DefinirProgresso("S", linha)
                Else
                    linha = String.Format("{0} turma(s) não cadastrada(s) no sistema.", contador)
                    DefinirProgresso("F", linha)
                End If

                'Disciplinas
                If contador2 = 0 Then
                    linha = ndisciplina & " disciplinas encontradas!"
                    DefinirProgresso("S", linha)
                Else
                    linha = contador2 & " disciplina(s) não cadastrada(s) no sistema."
                    DefinirProgresso("F", linha)
                End If
                Arq.Close()

                '    barra.Text = "Turmas/Disciplinas Ok!"
                ' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ FIM DE TURMAS/DISCIPLINAS \\\\\\\\\\\\\\\\\\

                If (ndisciplina > 0) And (nturma > 0) Then
                    'MsgBox("Lista de turmas e disciplinas foram encontradas", MsgBoxStyle.Information)
                    '  barra.ForeColor = Color.Lime
                    pErradoT.Visible = False
                    pCertoT.Visible = True
                    pErradoD.Visible = False
                    pCertoD.Visible = True
                    cbDisco.Enabled = False
                    eBoletim = 1
                Else
                    'MsgBox("Lista de turmas e disciplinas não foram encontradas", MsgBoxStyle.Information)
                    '  barra.ForeColor = Color.Red
                    pErradoT.Visible = True
                    pCertoT.Visible = False
                    pErradoD.Visible = True
                    pCertoD.Visible = False
                    cbDisco.Enabled = True
                    eBoletim = 0
                End If

            Catch ex As Exception
                'MsgBox("Desculpe, disco inválido!", MsgBoxStyle.Information, "Informação!")
                ' barra.ForeColor = Color.Red
            End Try

            'FIM PROFESSOR.txt
        End If

        '// ENCONTRAR BOLETINS NO DRIVE
        EncontrarBoletins()
    End Sub

    Private Sub btTrazer_Click(sender As Object, e As EventArgs) Handles btTrazer.Click

        btTrazer.Enabled = False
        DataHoje = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")
        barra.Properties.Minimum = 0

        '... Inicia a localização dos boletins...
        '... ANALISA se já existe boletins já cadastrados...

        If nboletim > 0 Then

            DefinirProgresso("S", "Verificando boletins já existentes...")

            For i = 0 To nboletim - 1

                trava = 0
                disciplina2 = 0
                turma2 = 0

                ano = tAno.Value
                bimestre = pBimestre(i)
                disciplina = pDisciplinas(i)
                turma = pTurmas(i)

                turma2 = Consulta_Turma(turma)
                disciplina2 = Consulta_Disciplina(disciplina)

                SQL =
                    String.Format(
                        "SELECT cod_nf FROM notasfreq WHERE disciplina='{0}' AND turma='{1}' AND cod_bimestre='{2}' AND anovigente='{3}'",
                        disciplina2, turma2, bimestre, ano)
                Dim Existir = MySQL_consulta_campo(SQL, "cod_nf")

                If Existir = "0" Then

                    linha = String.Format("{0} - OK;", pBoletim(i))
                    DefinirProgresso("S", linha)

                    'Joga na String a que serão inseridas no banco de dados
                    novaDisciplinas(novoBO) = disciplina
                    novaTurmas(novoBO) = turma
                    novaBimestre(novoBO) = bimestre
                    novaAno(novoBO) = ano
                    novoBO = novoBO + 1

                Else

                    ' ##################### SOBREESCREVE BANCO DE DADOS #######################
                    If cbSobreescrever.Checked = True Then
                        'Joga na String a que serão inseridas no banco de dados
                        novaDisciplinas(novoBO) = disciplina
                        novaTurmas(novoBO) = turma
                        novaBimestre(novoBO) = bimestre
                        novaAno(novoBO) = ano
                        novoBO = novoBO + 1
                        linha = String.Format("{0} - Encontrado!;", pBoletim(i))
                        DefinirProgresso("S", linha)

                    Else
                        linha = String.Format("{0} - Já existe;", pBoletim(i))
                        DefinirProgresso("F", linha)

                    End If
                End If
            Next

            linhaAP = "Finalizado busca por boletins..."
            DefinirProgresso("S", linhaAP)
        Else
            linhaAP = "Boletim não encontrado!"
            DefinirProgresso("F", linhaAP)
        End If
        '///////// Finalizado a Busca por Boletins //////////'

        '  barra.Properties.DisplayFormat.FormatString = "Importanto boletins..."

        linhaAP = "Importando boletins..."
        DefinirProgresso("S", linhaAP)
        'txtImportacao.AppendText(linhaAP & vbCrLf)

        ' ########################## COLOCA O PROFESSOR EM UM GRUPO NOTASFREQ_PROF #########################
        ' SELECIONA O ULTIMO grupo de NOTAS_FREQ
        '
        '  If cbImprimirBoletim.Checked = True Then

        Dim ultimogrupo
        SQL = "SELECT grupo FROM notasfreq_prof ORDER By GRUPO DESC;"
        ' CONTADOR PROXIMO...
        ultimogrupo = MySQL_consulta_campo(SQL, "grupo")
        Try
            If ultimogrupo = "0" Then
                ultimogrupo = 0
            End If

            iUltimoNotasFreqProf = (CInt(ultimogrupo) + 1)
        Catch ex As Exception
            iUltimoNotasFreqProf = 1
        End Try
        ' ########################## FIM COLOCA O PROFESSOR EM UM GRUPO NOTASFREQ_PROF #########################
        '   End If

        Me.bkProcesso.RunWorkerAsync()
    End Sub

    Private Sub tAno_EditValueChanged(sender As Object, e As EventArgs) Handles tAno.EditValueChanged
        EncontrarBoletins()
    End Sub

    Private Sub tBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles tBimestre.EditValueChanged
        EncontrarBoletins()
    End Sub

    Private Sub btImprimir_Consolidado_Click(sender As Object, e As EventArgs) Handles btImprimir_Consolidado.Click

        '...PASSA VARIAVEL PARA RPT COM O CODIGO NOVO DO PROFESSOR (GRUPO NOTASFREQ_PROF)
        frmRpt_codigo = iUltimoNotasFreqProf
        SQL_frmRPT = meuRPT("ConsolidadoProfessor")
        Dim fRpt As New frmRpt_Auxiliar
        fRpt.Show()
    End Sub

    Private Sub btImprimir_Recibo_Click(sender As Object, e As EventArgs) Handles btImprimir_Recibo.Click

        SQL_frmRPT = meuRPT("ReciboProfessor")
        Dim fRpt2 As New frmRpt_Auxiliar
        fRpt2.Show()
    End Sub
End Class