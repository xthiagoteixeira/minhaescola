Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.IO
Imports System
Imports System.net
Imports System.text
Imports System.Security.Cryptography.X509Certificates


Public Class Importacao

    Inherits System.Windows.Forms.Form

    Dim tempC = 0

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

    Dim travaInsere = 2
    Dim discno, nroturma

    Private Sub Importacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAnoVigente.Value = Format(Date.Now, "yyyy")

        'busca disciplina
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                SQL3 = "SELECT * FROM turma WHERE bloqueado=0 ORDER BY classe"
                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)


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

        r3 = myData3.Rows(0)

        'Puxa a cidade
        For Each r3 In myData3.Rows
            cbTurma.Items.Add(r3("classe"))
        Next

    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        Dim cidade
        Dim trava = 1

        If cbTurma.Text = "" Or lbarquivo.Text = "" Then
            MsgBox("Antes de importar, é necessário escolher o arquivo e a classe!", MsgBoxStyle.Critical, "Atenção!")
        Else
            Dim SacarData As DateTime = DateTime.Now
            Dim data
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")
            cidade = cbTurma.Text
            discno = nroturma

            Try
                conn.Open()
                Try

                    myData4.Clear()
                    SQL4 = "SELECT * FROM aluno WHERE turma='" & discno & "' AND anovigente='" & tAnoVigente.Value & "';"
                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)

                    Try
                        r4 = myData4.Rows(0)
                    Catch r4 As IndexOutOfRangeException
                        trava = 0
                    End Try

                    If trava = 0 Then

                        Dim blnLerDados As Boolean = False
                        Dim Texto As String = ""
                        'Cria um array, colocando o conteúdo de cada linha em indexs diferentes
                        Dim Linha() As String = File.ReadAllLines(lbarquivo.Text, UTF8Encoding.UTF8)
                        'Verifica linha a linha
                        For i As Integer = 0 To Linha.Length - 1

                            Dim codigoCheck As String = Mid(Linha(i), 1, 3)

                            'Se não estiver vazia...
                            If Linha(i) <> "" Then

                                'Verifica o conteúdo
                                If (codigoCheck = "01 ") Or (codigoCheck = "02 ") Or (codigoCheck = "03 ") Or (codigoCheck = "04 ") Or (codigoCheck = "05 ") Then
                                    blnLerDados = True
                                End If

                                'Lê o Conteúdo
                                If (blnLerDados = True) Then

                                    Dim codigo, ra, ra2
                                    Dim nome As String
                                    Dim Status As String
                                    codigo = Mid(Linha(i), 1, 2)
                                    nome = Mid(Linha(i), 5, 40)
                                    ra = Mid(Linha(i), 46, 14)
                                    ra2 = Mid(Linha(i), 65, 10)
                                    Status = Mid(Linha(i), 76, 2)

                                    nome = Trim(nome)
                                    ra = Trim(ra)
                                    ra2 = Trim(ra2)

                                    nome = nome.Replace("'", ".")

                                    If (Status = "TR") Or (Status = "RE") Or (Status = "AB") Or (Status = "LS") Or (Status = "LG") Or (Status = "FA") Then
                                        SQL3 = "INSERT INTO aluno (nome, turma, nro, anovigente, ra, data, status) values('" & nome & "', " & discno & ", " & codigo & ", " & tAnoVigente.Value & ", '" & ra & "', '" & ra2 & "', '" & Status & "');"
                                        atualizaMySQL(SQL3)

                                    Else
                                        SQL3 = "INSERT INTO aluno (nome, turma, nro, anovigente, ra, data) values('" & nome & "', " & discno & ", " & codigo & ", " & tAnoVigente.Value & ", '" & ra & "', '" & ra2 & "');"
                                        atualizaMySQL(SQL3)

                                    End If

                                End If

                            End If


                        Next

                        MsgBox("" & cbTurma.Text & " foi importada com sucesso!", MsgBoxStyle.Information, "Cadastrado")

                    Else
                        MsgBox("Já existe uma turma cadastrada, e não é permitida a duplicação", MsgBoxStyle.Critical, "Atenção!")
                    End If
                Catch myerro As MySqlException
                    MsgBox("Por favor, entre em contato com o suporte!" & vbCrLf & "Mensagem:" & myerro.Message, MsgBoxStyle.Information)
                End Try
                'MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Exit Sub
                Exit Try
            Finally
                conn.Dispose()
            End Try
            ' FIM DA CONEXAO
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        ' apaga os arquivos temporarios da maquina...
        Dim iContador = 0
        Dim temp = 0
        Dim arquivo
        Try
            While (iContador = 0)
                arquivo = "C:\METemp" & temp & ".txt"
                If My.Computer.FileSystem.FileExists(arquivo) Then
                    File.Delete(arquivo)
                    temp = temp + 1
                Else
                    iContador = 1
                End If
            End While
            ' fim de apagar os arquivos temporarios...
        Catch ex As Exception
        End Try

        travaInsere = 2

        Try
            openFD.InitialDirectory = openFD.FileName

        Catch ex As Exception
            openFD.InitialDirectory = "C:\"
        End Try

        openFD.Title = "Abrir arquivo"
        openFD.Filter = "Arquivos de texto|*.txt"
        openFD.ShowDialog()

        MsgBox(openFD.FileName)
        lbarquivo.Text = openFD.FileName

    End Sub

    Private Sub cbTurma_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData2.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn2 As MySqlConnection

        conn2 = New MySqlConnection()
        conn2.ConnectionString = CONEXAOBD

        SQL2 = "SELECT * FROM " & BD_OK & ".turma WHERE classe='" & cbTurma.Text & "'"
        Try
            conn2.Open()
            Try
                myCommand2.Connection = conn2
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)
                r2 = myData2.Rows(0)

                nroturma = r2("codigo_trma")
                nroTurmaAluno = nroturma
                'fundamental = r2("fundamental")

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

    End Sub
End Class