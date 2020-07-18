Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmCadAluno

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

    Private Sub frmCadAluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                SQL3 = "SELECT * FROM " & BD_OK & ".turma where bloqueado=0 ORDER BY classe"
                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)


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

        r3 = myData3.Rows(0)

        'Puxa a cidade
        For Each r3 In myData3.Rows
            If (r3("bloqueado") = 0) Then
                cbTurma.Items.Add(r3("classe"))
            End If
        Next

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        Dim trava = 0

        If cbTurma.Text = "" Or tbProfessor.Text = "" Then

            MsgBox("Antes de cadastrar, preencha os campos!", MsgBoxStyle.Critical, "Atenção!")

        Else

            Dim cidade
            Dim SacarData As DateTime = DateTime.Now
            Dim data

            data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")
            Dim Ano As Integer
            Ano = CInt(tAno.Value)

            myData.Clear()
            myData2.Clear()
            myData3.Clear()
            myData4.Clear()

            cidade = tbProfessor.Text

            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            SQL = "SELECT * FROM aluno WHERE nome='" & cidade & "' AND anovigente='" & Ano & "';"
            SQL4 = "SELECT * FROM turma WHERE classe='" & cbTurma.Text & "';"

            Try
                conn.Open()
                Try
                    myCommand.Connection = conn
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)

                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)

                    Dim turma, numeroaluno, nomedoaluno
                    r4 = myData4.Rows(0)
                    turma = r4("codigo_trma")

                    Try
                        r = myData.Rows(0)
                        nomedoaluno = r("nome")
                    Catch ex As Exception
                        nomedoaluno = "0"
                    End Try

                    Try

                        SQL2 = "SELECT * FROM aluno WHERE anovigente='" & tAno.Value & "' AND turma='" & turma & "' ORDER BY nro DESC"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)
                        r2 = myData2.Rows(0)
                        numeroaluno = CInt(r2("nro"))

                        Dim cadnroAluno = CInt(nroAluno.Value)

                        If (nomedoaluno = tbProfessor.Text) Or (numeroaluno >= cadnroAluno) Then
                            MsgBox("Já existe um aluno cadastrado, e não é permitida a duplicação!", MsgBoxStyle.Critical, "Atenção!")
                            trava = 1
                        End If


                    Catch ex As Exception
                    End Try

                    If trava = 0 Then
                        SQL3 = "INSERT INTO aluno (nome, turma, nro, anovigente, bf) values('" & tbProfessor.Text & "', '" & turma & "', " & nroAluno.Value & ", " & tAno.Value & ", '0');"
                        atualizaMySQL(SQL3)

                        MsgBox("[" & tbProfessor.Text & "] foi cadastrada com sucesso!", MsgBoxStyle.Information, "Cadastrado")
                        tbProfessor.Text = ""
                        cbTurma.Text = ""
                    End If
                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                'MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try
            ' FIM DA CONEXAO
        End If

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()

    End Sub

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData2.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn2 As MySqlConnection

        conn2 = New MySqlConnection()
        conn2.ConnectionString = CONEXAOBD

        SQL2 = "SELECT * FROM turma WHERE classe='" & cbTurma.Text & "'"
        Try
            conn2.Open()
            Try
                myCommand2.Connection = conn2
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)
                r2 = myData2.Rows(0)

                Dim nroturma
                nroturma = r2("codigo_trma")
                nroTurmaAluno = nroturma

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