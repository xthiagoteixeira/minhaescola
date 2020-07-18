Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.IO
Imports System
Imports System.net
Imports System.text
Imports System.Security.Cryptography.X509Certificates

Public Class Importacao2

    Inherits System.Windows.Forms.Form

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim r As DataRow
    Dim SQL As String

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

    Dim discno
    Private Sub Importacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAnoVigente.Value = Format(Date.Now, "yyyy")

        'Dim drivers() As String = Directory.GetLogicalDrives
        'Dim driver As String
        'Dim tvwNode As TreeNode

        'For Each driver In drivers
        '    tvwNode = TreeView1.Nodes.Add(driver)
        '    tvwNode.Nodes.Add("teste")
        'Next

        'busca disciplina
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

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData.Clear()
        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        SQL = "SELECT * FROM " & BD_OK & ".turma WHERE classe='" & cbTurma.Text & "'"

        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
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


        r = myData.Rows(0)
        discno = r("codigo_trma")
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        If cbTurma.Text = "" Then

            MsgBox("Antes de excluir, é necessário escolher a classe!", MsgBoxStyle.Critical, "Atenção!")

        ElseIf cbTurma.Text = "Todas as turmas" Then

            Dim trava = 1

            myData.Clear()
            myData2.Clear()
            myData3.Clear()
            myData4.Clear()

            Dim conn2 As MySqlConnection
            conn2 = New MySqlConnection()
            conn2.ConnectionString = CONEXAOBD

            Try
                conn2.Open()
                Try

                    SQL4 = "SELECT * FROM " & BD_OK & ".aluno WHERE anovigente=" & tAnoVigente.Value & ""
                    myCommand4.Connection = conn2
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)

                    Try
                        r4 = myData4.Rows(0)
                    Catch r4 As IndexOutOfRangeException
                        trava = 0
                    End Try

                    If trava = 0 Then

                        MsgBox("Não existe alunos cadastrados no ano de " & tAnoVigente.Value & " !", MsgBoxStyle.Exclamation, "Atenção")

                    Else
                        SQL3 = "DELETE FROM aluno WHERE anovigente='" & tAnoVigente.Value & "'"

                        myCommand3.Connection = conn2
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)
                        MsgBox("Cadastro de alunos cancelados!" & vbCrLf & "Ano Vigente: " & tAnoVigente.Value, MsgBoxStyle.Exclamation, "Atenção")
                    End If


                Catch myerro As MySqlException
                    '  MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn2.Close()
            Catch myerro As MySqlException
                ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn2.Dispose()
            End Try
            ' FIM DA CONEXAO


        Else

            Dim cidade
            Dim trava = 1

            Dim SacarData As DateTime = DateTime.Now
            Dim data

            data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

            myData.Clear()
            myData2.Clear()
            myData3.Clear()
            myData4.Clear()

            cidade = cbTurma.Text

            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD
            SQL4 = "SELECT * FROM " & BD_OK & ".aluno WHERE turma=" & discno & " AND anovigente=" & tAnoVigente.Value & ""

            Try
                conn.Open()
                Try

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
                        MsgBox("Não existe alunos cadastrados nesta turma e ano!", MsgBoxStyle.Exclamation, "Atenção")

                    Else
                        SQL3 = "DELETE FROM " & BD_OK & ".aluno WHERE turma=" & discno & " AND anovigente=" & tAnoVigente.Value
                        myCommand3.Connection = conn
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)
                        MsgBox("Cadastro de alunos cancelados!", MsgBoxStyle.Exclamation, "Atenção")

                    End If
                Catch myerro As MySqlException
                    '  MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try
            ' FIM DA CONEXAO
        End If
    End Sub

    Private Sub cbExcluir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbExcluir.CheckedChanged

        If cbExcluir.Checked = True Then
            cbTurma.Enabled = False
            cbTurma.Text = "Todas as turmas"
        Else
            cbTurma.Enabled = True
            cbTurma.Text = ""
        End If

    End Sub
End Class