Imports MySql.Data.MySqlClient

Public Class frmManGerarAF

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim r As DataRow
    Dim SQL As String

    Dim myCommand2 As New MySqlCommand()
    Dim myAdapter2 As New MySqlDataAdapter()
    Dim myData2 As New DataTable()
    Dim r2 As DataRow
    Dim SQL2 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()
    Dim r5 As DataRow
    Dim SQL5 As String

    Dim nDisciplinas = 0

    Dim trava = 0
    Dim nroturma
    Dim meuboletim

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData2.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn2 As MySqlConnection

        conn2 = New MySqlConnection()
        conn2.ConnectionString = CONEXAOBD

        SQL2 = "SELECT codigo_trma FROM " & BD_OK & ".turma WHERE classe='" & cbTurma.Text & "'"
        Try
            conn2.Open()
            Try
                myCommand2.Connection = conn2
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)
                r2 = myData2.Rows(0)
                nroturma = r2("codigo_trma")

                Try
                    '\\\\\\\\\\\\\\ CHECA SE EXISTE ////////////////////
                    myData5.Clear()
                    SQL5 = "SELECT * from notasfreq WHERE turma=" & nroturma & " AND cod_bimestre='4AF' AND anovigente='" & tAno.Value & "';"
                    myCommand5.Connection = conn2
                    myCommand5.CommandText = SQL5
                    myAdapter5.SelectCommand = myCommand5
                    myAdapter5.Fill(myData5)
                    r5 = myData5.Rows(0)
                    trava = 0
                Catch ex As Exception
                    trava = 1
                End Try

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn2.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn2.Dispose()
        End Try

        If trava = 1 Then
            btEfetuar.Enabled = True
            MsgBox("Turma: " & cbTurma.Text & " liberada!")
        Else
            btEfetuar.Enabled = False
            MsgBox("Turma: " & cbTurma.Text & " já foi gerada!")
        End If

    End Sub

    Private Sub frmManAulasPrevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

        myData.Clear()
        myData.Reset()

        'busca disciplina
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                'SQL = "SELECT * FROM " & BD_OK & ".disciplinas ORDER BY disciplina"
                SQL2 = "SELECT * FROM " & BD_OK & ".turma WHERE bloqueado=0 ORDER BY classe ASC;"

                'myCommand.Connection = conn
                'myCommand.CommandText = SQL
                'myAdapter.SelectCommand = myCommand
                'myAdapter.Fill(myData)

                myCommand2.Connection = conn
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
        Try
            r2 = myData2.Rows(0)
            'r = myData.Rows(0)
        Catch ex As Exception
        End Try

        ' cbDisciplina.Items.Clear()
        cbTurma.Items.Clear()

        'For Each r In myData.Rows
        '    cbDisciplina.Items.Add(r("disciplina"))
        'Next

        For Each r2 In myData2.Rows
            If (r2("bloqueado") = 0) Then
                cbTurma.Items.Add(r2("classe"))
            End If

        Next

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEfetuar.Click

        If cbTurma.Text = "" Or (cb1bimestre.Checked = False And cb2bimestre.Checked = False And cb3bimestre.Checked = False And cb4bimestre.Checked = False) Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Exclamation)

        Else

            myData.Clear()
            myData3.Clear()

            Dim iMedia = 0
            Dim i = 0
            Dim k = 0
            Dim j = 0
            Dim iDisciplinas(70) As Integer

            Array.Clear(iDisciplinas, 0, 70)

            'PEGAR CODIGO DAS DISCIPLINAS NO SISTEMA, E JOGA NA VARIAVEL
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try
                    myData.Clear()
                    SQL = "SELECT * FROM " & BD_OK & ".disciplinas ORDER BY disciplina"
                    'SQL2 = "SELECT * FROM " & BD_OK & ".turma ORDER BY classe"

                    myCommand.Connection = conn
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)

                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                'MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try
            Try
                r = myData.Rows(0)
            Catch ex As Exception
            End Try

            For Each r In myData.Rows
                iDisciplinas(nDisciplinas) = r("codigo_disc")
                'iDisciplinas(nDisciplinas) = 3
                nDisciplinas = nDisciplinas + 1
            Next

            'JOGA POR DISCIPLINAS AS VARIAVEIS, E GERA O BOLETIM FINAL
            'Dim contador
            Dim conn2 As MySqlConnection
            'Dim nvAulas

            Dim bimestre1(70)
            Dim bimestre2(70)
            Dim bimestre3(70)
            Dim bimestre4(70)

            Dim n1Boletim As Integer
            Dim n2Boletim As Integer
            Dim n3Boletim As Integer
            Dim n4Boletim As Integer

            Array.Clear(bimestre1, 0, 70)
            Array.Clear(bimestre2, 0, 70)
            Array.Clear(bimestre3, 0, 70)
            Array.Clear(bimestre4, 0, 70)

            conn2 = New MySqlConnection()
            conn2.ConnectionString = CONEXAOBD

            Try
                conn2.Open()
                Try
                    '  For i = 0 To nDisciplinas Step 1
                    For i = 0 To nDisciplinas Step 1
                        pbBar.Maximum = nDisciplinas
                        pbBar.Value = i

                        '\\\\\\\\\\\\\\\\SE ESCOLHER O 1o. BIMESTRE
                        If cb1bimestre.Checked = True Then

                            'PEGA O NUMERO DO BOLETIM
                            Try
                                myData.Clear()
                                SQL = "SELECT * FROM " & BD_OK & ".notasfreq WHERE cod_bimestre='1' AND turma='" & nroturma & "' AND disciplina='" & iDisciplinas(i) & "' AND anovigente='" & tAno.Value & "'"
                                myCommand.Connection = conn2
                                myCommand.CommandText = SQL
                                myAdapter.SelectCommand = myCommand
                                myAdapter.Fill(myData)
                                r = myData.Rows(0)
                                n1Boletim = r("cod_nf")
                            Catch ex As Exception
                                n1Boletim = 0
                            End Try

                            'JOGA NA VARIAVEL DO 1 BIMESTRE
                            If n1Boletim <> 0 Then
                                j = 1
                                Try
                                    myData.Clear()
                                    SQL = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim='" & n1Boletim & "' ORDER BY nro_aluno ASC;"
                                    myCommand.Connection = conn2
                                    myCommand.CommandText = SQL
                                    myAdapter.SelectCommand = myCommand
                                    myAdapter.Fill(myData)

                                    For Each r In myData.Rows
                                        bimestre1(j) = r("M")
                                        j = j + 1
                                    Next
                                Catch ex As Exception
                                End Try
                            End If
                            'FIM
                        End If

                        '\\\\\\\\\\\\\\\\\\\\SE ESCOLHER O 2o. BIMESTRE
                        If cb2bimestre.Checked = True Then

                            'PEGA O NUMERO DO BOLETIM
                            Try
                                myData.Clear()
                                SQL = "SELECT * FROM " & BD_OK & ".notasfreq WHERE cod_bimestre='2' AND turma='" & nroturma & "' AND disciplina='" & iDisciplinas(i) & "' AND anovigente='" & tAno.Value & "'"
                                myCommand.Connection = conn2
                                myCommand.CommandText = SQL
                                myAdapter.SelectCommand = myCommand
                                myAdapter.Fill(myData)
                                r = myData.Rows(0)
                                n2Boletim = r("cod_nf")
                            Catch ex As Exception
                                n2Boletim = 0
                            End Try

                            'JOGA NA VARIAVEL DO 2 BIMESTRE
                            If n2Boletim <> 0 Then
                                j = 1

                                Try
                                    myData.Clear()
                                    SQL = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim='" & n2Boletim & "' ORDER BY nro_aluno ASC;"
                                    myCommand.Connection = conn2
                                    myCommand.CommandText = SQL
                                    myAdapter.SelectCommand = myCommand
                                    myAdapter.Fill(myData)

                                    For Each r In myData.Rows
                                        bimestre2(j) = r("M")
                                        j = j + 1
                                    Next
                                Catch ex As Exception
                                End Try
                            End If
                            'FIM

                        End If

                        '\\\\\\\\\\\\\\\\\\\\\\\\\\SE ESCOLHER O 3o. BIMESTRE
                        If cb3bimestre.Checked = True Then

                            'PEGA O NUMERO DO BOLETIM
                            Try
                                myData.Clear()
                                SQL = "SELECT * FROM " & BD_OK & ".notasfreq WHERE cod_bimestre='3' AND turma='" & nroturma & "' AND disciplina='" & iDisciplinas(i) & "' AND anovigente='" & tAno.Value & "'"
                                myCommand.Connection = conn2
                                myCommand.CommandText = SQL
                                myAdapter.SelectCommand = myCommand
                                myAdapter.Fill(myData)
                                r = myData.Rows(0)
                                n3Boletim = r("cod_nf")
                            Catch ex As Exception
                                n3Boletim = 0
                            End Try

                            'JOGA NA VARIAVEL DO 1 BIMESTRE
                            If n3Boletim <> 0 Then
                                j = 1
                                Try
                                    myData.Clear()
                                    SQL = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim='" & n3Boletim & "' ORDER BY nro_aluno ASC;"
                                    myCommand.Connection = conn2
                                    myCommand.CommandText = SQL
                                    myAdapter.SelectCommand = myCommand
                                    myAdapter.Fill(myData)

                                    For Each r In myData.Rows
                                        bimestre3(j) = r("M")
                                        j = j + 1
                                    Next
                                Catch ex As Exception
                                End Try
                            End If
                            'FIM

                        End If

                        '\\\\\\\\\\\\\\\\\\\\\\\\\\\SE ESCOLHER O 4o. BIMESTRE
                        If cb4bimestre.Checked = True Then

                            'PEGA O NUMERO DO BOLETIM
                            Try
                                myData.Clear()
                                SQL = "SELECT * FROM " & BD_OK & ".notasfreq WHERE cod_bimestre='4' AND turma='" & nroturma & "' AND disciplina='" & iDisciplinas(i) & "' AND anovigente='" & tAno.Value & "'"
                                myCommand.Connection = conn2
                                myCommand.CommandText = SQL
                                myAdapter.SelectCommand = myCommand
                                myAdapter.Fill(myData)
                                r = myData.Rows(0)
                                n4Boletim = r("cod_nf")
                            Catch ex As Exception
                                n4Boletim = 0
                            End Try

                            'JOGA NA VARIAVEL DO 4 BIMESTRE
                            If n4Boletim <> 0 Then
                                j = 1
                                Try
                                    myData.Clear()
                                    SQL = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim='" & n4Boletim & "' ORDER BY nro_aluno ASC;"
                                    myCommand.Connection = conn2
                                    myCommand.CommandText = SQL
                                    myAdapter.SelectCommand = myCommand
                                    myAdapter.Fill(myData)

                                    For Each r In myData.Rows
                                        bimestre4(j) = r("M")
                                        j = j + 1
                                    Next
                                Catch ex As Exception
                                End Try
                            End If
                            'FIM

                        End If

                        'DEPOIS DE PEGAR AS MEDIAS... CRIA O 4AF
                        Try

                            'INSERE NOTASFREQ...
                            myData5.Clear()
                            SQL5 = "INSERT INTO " & BD_OK & ".notasfreq (turma, disciplina, cod_bimestre, qtdadeaulas, previsaoaulas, anovigente) values(" & nroturma & ",'" & iDisciplinas(i) & "', '4AF', '1', '1', '" & tAno.Value & "');"
                            atualizaMySQL(SQL5)

                            'CODIGO DO BOLETIM INSERIDO...
                            myData8.Clear()
                            SQL8 = "SELECT * FROM " & BD_OK & ".notasfreq ORDER BY cod_nf DESC"
                            myCommand8.Connection = conn2
                            myCommand8.CommandText = SQL8
                            myAdapter8.SelectCommand = myCommand8
                            myAdapter8.Fill(myData8)

                            r8 = myData8.Rows(0)
                            If r8 Is DBNull.Value Then
                                meuboletim = 1
                            Else
                                meuboletim = r8("cod_nf")
                            End If
                        Catch ex As Exception
                        End Try

                        'FAZ O CALCULO DA MEDIA E INSERE NO BOLETIM...
                        Try

                            Dim b1 = False
                            Dim b2 = False
                            Dim b3 = False
                            Dim b4 = False

                            iMedia = 0
                            ' A MEDIA QUE SERA CALCULADA APÓS PEGAR AS NOTAS...
                            If n1Boletim <> 0 Then
                                iMedia = iMedia + 1
                            End If

                            If n2Boletim <> 0 Then
                                iMedia = iMedia + 1
                            End If

                            If n3Boletim <> 0 Then
                                iMedia = iMedia + 1
                            End If

                            If n4Boletim <> 0 Then
                                iMedia = iMedia + 1
                            End If

                            For k = 1 To 70 Step 1

                                If bimestre1(k) Is Nothing = True And bimestre2(k) Is Nothing = True And bimestre3(k) Is Nothing = True And bimestre4(k) Is Nothing = True Then
                                    Exit For
                                End If

                                Dim minhaNota As Integer

                                If bimestre1(k) Is Nothing = True And cb1bimestre.Checked = True And b1 = False Then
                                    iMedia = iMedia - 1
                                    b1 = True
                                End If

                                If bimestre2(k) Is Nothing = True And cb2bimestre.Checked = True And b2 = False Then
                                    iMedia = iMedia - 1
                                    b2 = True
                                End If

                                If bimestre3(k) Is Nothing = True And cb3bimestre.Checked = True And b3 = False Then
                                    iMedia = iMedia - 1
                                    b3 = True
                                End If

                                If bimestre4(k) Is Nothing = True And cb4bimestre.Checked = True And b4 = False Then
                                    iMedia = iMedia - 1
                                    b4 = True
                                End If

                                minhaNota = (bimestre1(k) + bimestre2(k) + bimestre3(k) + bimestre4(k) + 0.1) / iMedia
                                Math.Ceiling(minhaNota)

                                'INSERE BOLETIM...
                                myData5.Clear()
                                SQL5 = "INSERT INTO " & BD_OK & ".boletim (nro_aluno, cod_boletim, M, S) values('" & k & "','" & meuboletim & "', '" & minhaNota & "', '1');"
                                atualizaMySQL(SQL5)

                            Next k
                        Catch ex As Exception
                        End Try

                    Next i

                    MsgBox("Gerado com sucesso!", MsgBoxStyle.Information)


                Catch myerro As MySqlException
                End Try
                conn2.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn2.Dispose()
            End Try


        End If
        btEfetuar.Enabled = False

    End Sub
End Class