Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.IO

Public Class frmImpBoletim2

    Dim turma, disciplina
    Dim contadorT = 0

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

    Dim myCommand3 As New MySqlCommand()
    Dim myAdapter3 As New MySqlDataAdapter()
    Dim myData3 As New DataTable()
    Dim r3 As DataRow
    Dim SQL3 As String

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()
    Dim r4 As DataRow
    Dim SQL4 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()
    Dim r5 As DataRow
    Dim SQL5 As String

    Dim myCommand6 As New MySqlCommand()
    Dim myAdapter6 As New MySqlDataAdapter()
    Dim myData6 As New DataTable()
    Dim r6 As DataRow
    Dim SQL6 As String

    Dim myCommand10 As New MySqlCommand()
    Dim myAdapter10 As New MySqlDataAdapter()
    Dim myData10 As New DataTable()
    Dim r10 As DataRow
    Dim SQL10 As String

    Dim contadorTurmas = 0
    Dim contadorDisciplinas = 0

    Dim mydrive

    Private Sub frmImpBoletim2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

        Me.Size = New System.Drawing.Size(402, 209)

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                SQL = "SELECT * FROM " & BD_OK & ".disciplinas WHERE disciplina<>'-' ORDER BY disciplina ASC;"
                SQL2 = "SELECT * FROM " & BD_OK & ".turma WHERE bloqueado = 0 ORDER BY classe;"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                myCommand2.Connection = conn
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)


                Try
                    r2 = myData2.Rows(0)
                    r = myData.Rows(0)

                Catch ex As Exception

                End Try


                cbDisciplina.Items.Clear()
                cbTurma.Items.Clear()

                For Each r In myData.Rows
                    cbDisciplina.Items.Add(r("disciplina"))
                Next

                For Each r2 In myData2.Rows
                    If (r2("bloqueado") = 0) Then
                        cbTurma.Items.Add(r2("classe"))
                    End If
                Next

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

        For Each drive As IO.DriveInfo In My.Computer.FileSystem.Drives
            cbDrivers.Items.Add(drive)
        Next drive

    End Sub

    Private Sub btAddTurmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddTurmas.Click
        If cbTurma.Text = "" Then

            MsgBox("Escolha uma turma!", MsgBoxStyle.Critical)

        Else

            contadorTurmas += 1

            'Adiciona na listbox
            lbTurmas.Items.Add(cbTurma.Text)

            'Remove no Combobox
            cbTurma.Items.Remove(cbTurma.Text)
        End If
        contadorT = contadorT + 1


    End Sub

    Private Sub btAddDisciplinas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddDisciplinas.Click
        If cbDisciplina.Text = "" Then

            MsgBox("Escolha uma disciplina!", MsgBoxStyle.Critical)

        Else

            contadorDisciplinas += 1
            'Adiciona na listbox
            lbDisciplinas.Items.Add(cbDisciplina.Text)

            'Remove no Combobox
            cbDisciplina.Items.Remove(cbDisciplina.Text)

        End If

    End Sub

    Private Sub btDelTurmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelTurmas.Click

        contadorTurmas -= 1

        'Adiciona no Combox
        cbTurma.Items.Add(lbTurmas.SelectedItem)

        'Remove da lista
        lbTurmas.Items.Remove(lbTurmas.SelectedItem)

    End Sub

    Private Sub btDelDisciplinas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelDisciplinas.Click

        contadorDisciplinas -= 1

        'Adiciona no Combox
        cbDisciplina.Items.Add(lbDisciplinas.SelectedItem)

        'Remove da lista
        lbDisciplinas.Items.Remove(lbDisciplinas.SelectedItem)

    End Sub

    Private Sub frmImpBoletim2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If contadorDisciplinas = 0 Then
            btDelDisciplinas.Enabled = False
        Else
            btDelDisciplinas.Enabled = True
        End If

        If contadorTurmas = 0 Then
            btDelTurmas.Enabled = False
        Else
            btDelTurmas.Enabled = True
        End If


    End Sub

    Private Sub btDelTurmas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btDelTurmas.Click

        If contadorDisciplinas = 0 Then
            btDelDisciplinas.Enabled = False
        Else
            btDelDisciplinas.Enabled = True
        End If

        If contadorTurmas = 0 Then
            btDelTurmas.Enabled = False
        Else
            btDelTurmas.Enabled = True
        End If

    End Sub

    Private Sub btDelDisciplinas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btDelDisciplinas.Click

        If contadorDisciplinas = 0 Then
            btDelDisciplinas.Enabled = False
        Else
            btDelDisciplinas.Enabled = True
        End If

        If contadorTurmas = 0 Then
            btDelTurmas.Enabled = False
        Else
            btDelTurmas.Enabled = True
        End If

    End Sub

    Private Sub CheckBoxX2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAvancadas.CheckedChanged
        If cbAvancadas.Checked = True Then
            Me.Size = New System.Drawing.Size(800, 209)
            btCarregar.Enabled = False

        Else
            Me.Size = New System.Drawing.Size(402, 209)
            btCarregar.Enabled = True

        End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCarregar.Click

        Dim myTexto
        Dim ano, turma

        If (My.Computer.FileSystem.DirectoryExists("" & mydrive & "" & tAno.Value) = False) Then
            'CRIA AS DIRETORIO ANO
            Dim AnoCriar = "" & mydrive & "" & tAno.Value
            My.Computer.FileSystem.CreateDirectory(AnoCriar)
            ' FIM CRIAR DIRETORIO ANO
        End If

        pBarra.Text = "Copiando Programa..."
        pBarra.Maximum = 3
        pBarra.Value = 0

        'Copiando o arquivo
        Try
            FileCopy("Mais Escola Professor.exe", "" & mydrive & "Mais Escola Professor.exe")
        Catch ex As Exception
        End Try

        Dim myTexto20, myTexto30

        Dim ArqTurmas = "" & mydrive & "" & tAno.Value & "\turmas2.txt"
        Dim ArqTurmas2 = "" & mydrive & "" & tAno.Value & "\turmas.txt"

        Dim ArqDisciplinas = "" & mydrive & "" & tAno.Value & "\disciplinas2.txt"
        Dim ArqDisciplinas2 = "" & mydrive & "" & tAno.Value & "\disciplinas.txt"

        pBarra.Text = "Copiando Turmas..."
        pBarra.Maximum = 3
        pBarra.Value = 1

        'Verifica se HABILITA por e-mail
        Dim ArqMail = "" & mydrive & "" & tAno.Value & "\m.txt"
        If cbMail.Checked = True Then
            Try
                Dim objStreamMail As New System.IO.FileStream(ArqMail, IO.FileMode.Create)
            Catch ex As Exception
            End Try
        Else
            Try
                File.Delete(ArqMail)
            Catch ex As Exception
            End Try
        End If
        'Fim

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn20 As MySqlConnection
        conn20 = New MySqlConnection()
        conn20.ConnectionString = CONEXAOBD

        Try
            conn20.Open()
            Try
                SQL5 = "SELECT classe, codigo_trma FROM turma WHERE bloqueado=0 ORDER BY classe ASC;"

                myCommand5.Connection = conn20
                myCommand5.CommandText = SQL5
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)

                Try
                    Dim objStream20 As New System.IO.FileStream(ArqTurmas, IO.FileMode.Create)
                    Dim Arq20 As New System.IO.StreamWriter(objStream20)

                    r5 = myData5.Rows(0)

                    For Each r5 In myData5.Rows
                        myTexto20 = r5("classe")
                        Arq20.WriteLine(myTexto20)
                    Next
                    Arq20.WriteLine("FIMTURMAS")
                    Arq20.Close()

                    'MsgBox("Arquivo gravado!", MsgBoxStyle.Information, "Confirmação")

                Catch ex As Exception
                    MsgBox("Desculpe, não foi possível criar o arquivo.", MsgBoxStyle.Critical, "Disco inválido!")
                    'pCerto.Visible = False
                    'pErrado.Visible = True
                End Try

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)

            End Try
            conn20.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)

        Finally
            conn20.Dispose()
        End Try

        pBarra.Text = "Copiando Disciplinas..."
        pBarra.Maximum = 3
        pBarra.Value = 2

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn2 As MySqlConnection
        conn2 = New MySqlConnection()
        conn2.ConnectionString = CONEXAOBD

        Try
            conn2.Open()
            Try
                SQL6 = "SELECT disciplina FROM disciplinas WHERE disciplina<>'-' ORDER BY disciplina"

                myCommand6.Connection = conn2
                myCommand6.CommandText = SQL6
                myAdapter6.SelectCommand = myCommand6
                myAdapter6.Fill(myData6)

                Try

                    Dim objStream30 As New System.IO.FileStream(ArqDisciplinas, IO.FileMode.Create)
                    Dim Arq30 As New System.IO.StreamWriter(objStream30)

                    r6 = myData6.Rows(0)

                    For Each r In myData.Rows
                        myTexto30 = r("disciplina")
                        Arq30.WriteLine(myTexto30)
                    Next
                    Arq30.WriteLine("FIMDISCIPLINAS")
                    Arq30.Close()

                    'pCerto.Visible = True
                    'pErrado.Visible = False
                    btCarregar.Enabled = False

                Catch ex As Exception
                    MsgBox("Desculpe, não foi possível criar o arquivo.", MsgBoxStyle.Critical, "Disco inválido!")

                End Try

            Catch myerro As MySqlException
                '  MsgBox("Erro de leitura no banco de dados : " & myerro.Message)

            End Try
            conn2.Close()
        Catch myerro As MySqlException
            ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)

        Finally
            conn2.Dispose()
        End Try

        ' // codifica os arquivos
        criaChave("me")
        Codifica(ArqTurmas, ArqTurmas2)
        criaChave("me")
        Codifica(ArqDisciplinas, ArqDisciplinas2)
        ' // fim de codificar arquivos

        ' // apaga arquivos temporarios e coloca no normal
        File.Delete(ArqTurmas)
        File.Delete(ArqDisciplinas)
        ' // fim

        If cbAlunos.Checked = True Then

            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CRIAR OS ARQUIVOS SOMENTE PARA TURMAS E DISCIPLINAS //////////////////////////////////
            pBarra.Text = "Copiando Lista Piloto..."
            pBarra.Maximum = 3
            pBarra.Value = 2

            Try
                Dim nturma
                For Each r5 In myData5.Rows

                    myData3.Clear()
                    'Tenta puxar a lista para o programa...
                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD

                    Try
                        conn.Open()
                        Try
                            Try
                                nturma = CInt(r5("codigo_trma"))
                                ano = CInt(tAno.Value)
                                myTexto = r5("classe")

                                'CRIA AS TURMAS
                                turma = "" & mydrive & "" & tAno.Value & "\" & "" & myTexto
                                My.Computer.FileSystem.CreateDirectory(turma)
                                ' FIM CRIAR AS TURMAS

                                Dim ArqAlunos, ArqAlunos2
                                ArqAlunos = "" & mydrive & "" & ano & "\" & myTexto & "\" & myTexto & "a.txt"
                                ArqAlunos2 = "" & mydrive & "" & ano & "\" & myTexto & "\" & myTexto & "a.temp"

                                Dim objStreamT As New System.IO.FileStream(ArqAlunos, IO.FileMode.Create)
                                Dim Arq As New System.IO.StreamWriter(objStreamT)
                                Dim myTextoF = ""
                                Dim myTextoF2 = ""
                                Dim iContador = 1
                                Dim AlunoFinal As Integer = 0
                                Dim AlunoNaoExiste = 0

                                SQL3 = "SELECT DISTINCT nro, status FROM aluno a WHERE turma='" & nturma & "' AND anovigente='" & ano & "' ORDER BY nro DESC"
                                myCommand3.Connection = conn
                                myCommand3.CommandText = SQL3
                                myAdapter3.SelectCommand = myCommand3
                                myAdapter3.Fill(myData3)
                                Try
                                    r3 = myData3.Rows(0)
                                    AlunoFinal = r3("nro")
                                Catch ex As Exception
                                    'MsgBox("123333 :" & ex.Message)
                                End Try


                                For iContador = 1 To AlunoFinal

                                    AlunoNaoExiste = 0
                                    myTextoF2 = Nothing

                                    Try
                                        myData10.Clear()
                                        SQL10 = "SELECT DISTINCT nro, status FROM aluno a WHERE nro='" & iContador & "' AND turma='" & nturma & "' AND anovigente='" & ano & "';"
                                        myCommand10.Connection = conn
                                        myCommand10.CommandText = SQL10
                                        myAdapter10.SelectCommand = myCommand10
                                        myAdapter10.Fill(myData10)
                                    Catch ex As RowNotInTableException
                                    End Try

                                    Try
                                        r10 = myData10.Rows(0)
                                        myTextoF2 = r10("status")
                                    Catch ex As IndexOutOfRangeException
                                        AlunoNaoExiste = 1
                                    End Try

                                    If (myTextoF2 = "0") Then
                                        myTextoF = "0"
                                    ElseIf myTextoF2 = Nothing Then
                                        AlunoNaoExiste = 1
                                    Else
                                        myTextoF = myTextoF2
                                    End If

                                    If AlunoNaoExiste = 1 Then
                                        myTextoF = "NC"
                                    End If
                                    Arq.WriteLine(myTextoF)

                                Next
                                Arq.Close()

                                criaChave("me")
                                Codifica(ArqAlunos, ArqAlunos2)
                                File.Delete(ArqAlunos)
                                File.Move(ArqAlunos2, ArqAlunos)

                                Try
                                    'retorna o tamanho em bytes
                                    Dim FileTamanho As FileInfo = New FileInfo(ArqAlunos)
                                    If FileTamanho.Length = "8" Then
                                        File.Delete(ArqAlunos)
                                    End If
                                Catch ex As Exception
                                End Try

                            Catch myerro As Exception
                                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)

                            End Try
                            'MessageBox.Show("Conexão aberta com sucesso")
                            conn.Close()
                        Catch myerro As Exception
                            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                        Finally
                            conn.Dispose()
                        End Try

                    Catch ex As Exception
                    End Try

                    'Fim

                Next

                'pCerto.Visible = True
                'pErrado.Visible = False
                btCarregar.Enabled = False

            Catch ex As Exception
                MsgBox("Desculpe, não foi possível criar o arquivo.", MsgBoxStyle.Critical, "Disco inválido!")
                'pCerto.Visible = False
                'pErrado.Visible = True
            End Try
        End If

        pBarra.Text = "Finalizado!"
        pBarra.Maximum = 3
        pBarra.Value = 3

        MsgBox("Turmas e Disciplinas gravadas com sucesso!", MsgBoxStyle.Information, "Confirmação")

    End Sub

    Private Sub btRefazer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRefazer.Click
        If MsgBox("Deseja refazer os arquivos do Boletim Móvel?", MsgBoxStyle.YesNo, "Boletim Móvel") = MsgBoxResult.Yes Then

            btAvancado.Enabled = True
            'pCerto.Visible = False
            'pErrado.Visible = True
            btAvancado.Enabled = True
            btCarregar.Enabled = True
            pNao.Visible = False

            Try
                File.Delete("" & cbDrivers.Text & "turmas.txt")
            Catch ex As Exception
            End Try

            Try
                File.Delete("" & cbDrivers.Text & "disciplinas.txt")
            Catch ex As Exception
            End Try

            pBarra.Text = "Feito!"
        Else
            MsgBox("Nada feito!", MsgBoxStyle.Information)
        End If

        If btCarregar.Enabled = False Then
            cbAvancadas.Enabled = False
        Else
            cbAvancadas.Enabled = True
        End If

    End Sub

    Private Sub btFechar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAvancado.Click

        If (contadorDisciplinas <> 0) Or (contadorTurmas <> 0) Then

            pBarra.Text = "Copiando Programa..."
            pBarra.Maximum = 3
            pBarra.Value = 0

            'Verifica se HABILITA por e-mail
            Dim ArqMail = "" & mydrive & "" & tAno.Value & "\m.txt"
            If cbMail.Checked = True Then
                Try
                    Dim objStreamMail As New System.IO.FileStream(ArqMail, IO.FileMode.Create)
                Catch ex As Exception
                End Try
            Else
                Try
                    File.Delete(ArqMail)
                Catch ex As Exception
                End Try
            End If

            'Copiando o arquivo
            Try
                FileCopy("Mais Escola Professor.exe", "" & mydrive & "\Mais Escola Professor.exe")
            Catch ex As FileNotFoundException
            End Try

            'ANTIGO...
            Try
                File.Delete("" & cbDrivers.Text & "turmas.txt")
            Catch ex As Exception
            End Try

            Try
                File.Delete("" & cbDrivers.Text & "disciplinas.txt")
            Catch ex As Exception
            End Try

            'NOVO...
            Try
                File.Delete("" & cbDrivers.Text & "" & tAno.Value & "\turmas.txt")
            Catch ex As Exception
            End Try

            Try
                File.Delete("" & cbDrivers.Text & "" & tAno.Value & "\disciplinas.txt")
            Catch ex As Exception
            End Try

            myData3.Clear()
            myData4.Clear()

            Dim myTexto
            Dim i
            Dim turma, k

            If (My.Computer.FileSystem.DirectoryExists("" & mydrive & "" & tAno.Value) = False) Then
                'CRIA AS DIRETORIO ANO
                Dim AnoCriar = "" & mydrive & "" & tAno.Value
                My.Computer.FileSystem.CreateDirectory(AnoCriar)
                ' FIM CRIAR DIRETORIO ANO
            End If

            'CRIA AS TURMAS
            Dim cdturmas
            For i = 0 To lbTurmas.Items.Count - 1
                cdturmas = lbTurmas.Items(i)
                turma = "" & mydrive & "" & tAno.Value & "\" & "" & cdturmas
                My.Computer.FileSystem.CreateDirectory(turma)
            Next
            ' FIM CRIAR AS TURMAS

            'CRIA AS DISCIPLINAS
            Dim cdDisciplinasT, cdTurmasT
            For i = 0 To lbTurmas.Items.Count - 1
                cdTurmasT = lbTurmas.Items(i)
                ' localiza as disciplinas...
                For k = 0 To lbDisciplinas.Items.Count - 1
                    cdDisciplinasT = lbDisciplinas.Items(k)
                    disciplina = "" & mydrive & "" & tAno.Value & "\" & cdTurmasT & "\" & cdDisciplinasT
                    My.Computer.FileSystem.CreateDirectory(disciplina)
                Next
            Next
            ' FIM CRIA AS DISCIPLINAS

            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CRIAR OS ARQUIVOS SOMENTE PARA TURMAS E DISCIPLINAS //////////////////////////////////
            pBarra.Text = "Copiando Turmas..."
            pBarra.Maximum = 3
            pBarra.Value = 1

            Dim ArqTurmas, ArqTurmas2 As String
            ArqTurmas = "" & mydrive & "" & tAno.Value & "\turmas.txt"
            ArqTurmas2 = "" & mydrive & "" & tAno.Value & "\turmas.temp"
            Dim objStreamT As New System.IO.FileStream(ArqTurmas, IO.FileMode.Create)
            Dim ArqT As New System.IO.StreamWriter(objStreamT)


            Dim nturma
            Dim fimTurmas = lbTurmas.Items.Count - 1

            For i = 0 To fimTurmas
                myTexto = lbTurmas.Items.Item(i)
                ArqT.WriteLine(myTexto)
            Next
            ArqT.WriteLine("FIMTURMAS")
            ArqT.Close()

            criaChave("me")
            Codifica(ArqTurmas, ArqTurmas2)
            File.Delete(ArqTurmas)
            File.Move(ArqTurmas2, ArqTurmas)
            'FIM DAS TURMAS PERSONALIZADAS...

            If cbAlunos.Checked = True Then

                Try
                    For i = 0 To fimTurmas
                        myData3.Clear()
                        myData4.Clear()

                        Dim AlunoFinal = 0
                        myTexto = lbTurmas.Items.Item(i)

                        ' ARQUIVO DA LISTA PILOTO...
                        Dim ArqAlunos, ArqAlunos2
                        ArqAlunos = "" & mydrive & "" & tAno.Value & "\" & myTexto & "\" & myTexto & "a.txt"
                        ArqAlunos2 = "" & mydrive & "" & tAno.Value & "\" & myTexto & "\" & myTexto & "a.temp"
                        Dim objStreamT2 As New System.IO.FileStream(ArqAlunos, IO.FileMode.Create)
                        Dim ArqA As New System.IO.StreamWriter(objStreamT2)

                        Try

                            'Tenta puxar a lista para o programa...
                            Dim conn As MySqlConnection
                            conn = New MySqlConnection()
                            conn.ConnectionString = CONEXAOBD

                            Try
                                conn.Open()
                                Try
                                    SQL4 = "SELECT classe, codigo_trma FROM turma t WHERE classe='" & myTexto & "'"
                                    myCommand4.Connection = conn
                                    myCommand4.CommandText = SQL4
                                    myAdapter4.SelectCommand = myCommand4
                                    myAdapter4.Fill(myData4)

                                    Try
                                        r4 = myData4.Rows(0)
                                        nturma = r4("codigo_trma")

                                        myData3.Clear()
                                        SQL3 = "SELECT nro, status FROM aluno a WHERE turma=" & nturma & " AND anovigente=" & tAno.Value & " ORDER BY nro DESC;"
                                        myCommand3.Connection = conn
                                        myCommand3.CommandText = SQL3
                                        myAdapter3.SelectCommand = myCommand3
                                        myAdapter3.Fill(myData3)

                                        r3 = myData3.Rows(0)
                                        AlunoFinal = r3("nro")

                                        Dim myTextoF = ""
                                        Dim myTextoF2 = ""
                                        Dim iContador = 1

                                        For iContador = 1 To AlunoFinal

                                            Dim AlunoNaoExiste = 0
                                            Try
                                                myData3.Clear()
                                                SQL3 = "SELECT nro, status FROM aluno a WHERE nro=" & iContador & " AND turma=" & nturma & " AND anovigente=" & tAno.Value & ";"
                                                myCommand3.Connection = conn
                                                myCommand3.CommandText = SQL3
                                                myAdapter3.SelectCommand = myCommand3
                                                myAdapter3.Fill(myData3)
                                                r3 = myData3.Rows(0)
                                                myTextoF2 = r3("status")
                                            Catch ex As Exception
                                                AlunoNaoExiste = 1
                                            End Try

                                            If (myTextoF2 = "") Or (myTextoF2 = " ") Or (myTextoF2 = "0") Then
                                                myTextoF = "0"
                                            Else
                                                myTextoF = r3("status")
                                            End If

                                            If AlunoNaoExiste = 1 Then
                                                myTextoF = "NC"
                                            End If
                                            ArqA.WriteLine(myTextoF)
                                        Next

                                    Catch myerro As MySqlException
                                        'MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                                    End Try
                                    ' MessageBox.Show("Conexão aberta com sucesso")
                                    conn.Close()
                                Catch myerro As MySqlException
                                    'MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                                Finally
                                    conn.Dispose()
                                End Try

                            Catch ex As Exception
                                'MsgBox("Erro de leitura no banco de dados : " & ex.Message)
                            End Try
                        Catch ex As Exception
                            'MsgBox("Erro de leitura no banco de dados : " & ex.Message)
                        End Try
                        ' Fim()

                        ' FIM DE UMA LISTA PILOTO...
                        ArqA.Close()

                        criaChave("me")
                        Codifica(ArqAlunos, ArqAlunos2)
                        File.Delete(ArqAlunos)
                        File.Move(ArqAlunos2, ArqAlunos)

                        Try
                            'retorna o tamanho em bytes
                            Dim FileTamanho As FileInfo = New FileInfo(ArqAlunos)
                            If FileTamanho.Length = "8" Then
                                File.Delete(ArqAlunos)
                            End If
                        Catch ex As Exception
                        End Try

                    Next

                    'pCerto.Visible = True
                    'pErrado.Visible = False
                    btCarregar.Enabled = False

                Catch ex As Exception
                    MsgBox("Desculpe, não foi possível criar o arquivo da Lista Piloto." & vbCrLf & "" & ex.Message, MsgBoxStyle.Critical, "Disco inválido!")
                    'pCerto.Visible = False
                    'pErrado.Visible = True

                End Try
            End If
            '###############################################FIM DA LISTA PILOTO...

            pBarra.Text = "Copiando Disciplinas..."
            pBarra.Maximum = 3
            pBarra.Value = 2

            Try
                Dim minhaDisciplina As String
                Dim ArqDisciplinas, ArqDisciplinas2 As String
                ArqDisciplinas = "" & mydrive & "" & tAno.Value & "\disciplinas.txt"
                ArqDisciplinas2 = "" & mydrive & "" & tAno.Value & "\disciplinas.temp"

                Dim Arq2 As IO.StreamWriter
                Arq2 = New IO.StreamWriter(ArqDisciplinas)

                Dim fimDisciplinas = lbDisciplinas.Items.Count - 1

                For i = 0 To fimDisciplinas

                    If i = fimDisciplinas Then
                        minhaDisciplina = lbDisciplinas.Items.Item(i)
                        Arq2.WriteLine(minhaDisciplina)
                        Arq2.WriteLine("FIMDISCIPLINAS")
                    Else
                        minhaDisciplina = lbDisciplinas.Items.Item(i)
                        Arq2.WriteLine(minhaDisciplina)
                    End If

                Next
                Arq2.Close()

                criaChave("me")
                Codifica(ArqDisciplinas, ArqDisciplinas2)
                File.Delete(ArqDisciplinas)
                File.Move(ArqDisciplinas2, ArqDisciplinas)


                btCarregar.Enabled = False

                MsgBox("Turmas e Disciplinas gravadas com sucesso!", MsgBoxStyle.Information, "Confirmação")

                pBarra.Text = "Finalizado!"
                pBarra.Maximum = 3
                pBarra.Value = 3

            Catch ex As Exception
                MsgBox("Desculpe, não foi possível criar o arquivo.", MsgBoxStyle.Critical, "Disco inválido!")
                pBarra.Text = "Finalizado!"
                pBarra.Maximum = 3
                pBarra.Value = 3
            End Try
            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ FIM /////////////////////////////////

            Me.Close()
        Else
            MsgBox("Não há turmas e/ou disciplinas adicionadas na lista!", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDrivers.SelectedIndexChanged
        mydrive = cbDrivers.Text
        cbAvancadas.Enabled = True

        If (My.Computer.FileSystem.FileExists("" & mydrive & tAno.Value & "\turmas.txt") = False) And (My.Computer.FileSystem.FileExists("" & mydrive & tAno.Value & "\disciplinas.txt") = False) Then
            'MsgBox("Lista de turmas não foram encontradas", MsgBoxStyle.Information)
            pNao.Visible = True
            pSim.Visible = False

            'pCerto.Visible = False
            'pErrado.Visible = True
            btCarregar.Enabled = True
        Else
            pNao.Visible = False
            pSim.Visible = True

            pBarra.Text = "Disco: " & cbDrivers.Text & " já carregado!"
            btCarregar.Enabled = False
        End If

        If btCarregar.Enabled = False Then
            cbAvancadas.Enabled = False
        Else
            cbAvancadas.Enabled = True
        End If

    End Sub

    Private Sub cbTurma_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbTurma.KeyPress
        If IsNumeric(cbTurma.Text) Then
            MsgBox("Não é possível digitar, favor escolher uma turma!", MsgBoxStyle.Critical, "Atenção!")
        Else
            MsgBox("Não é possível digitar, favor escolher uma turma!", MsgBoxStyle.Critical, "Atenção!")
        End If
        cbTurma.Text = ""
    End Sub

    Private Sub cbTurma_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

    End Sub

    Private Sub cbDisciplina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbDisciplina.KeyPress
        If IsInputChar(cbDisciplina.Text) Then
            MsgBox("Não é possível digitar, favor escolher uma disciplina!", MsgBoxStyle.Critical, "Atenção!")
        Else
            MsgBox("Não é possível digitar, favor escolher uma disciplina!", MsgBoxStyle.Critical, "Atenção!")
        End If
        cbDisciplina.Text = ""
    End Sub

    Private Sub cbDisciplina_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged

    End Sub
End Class