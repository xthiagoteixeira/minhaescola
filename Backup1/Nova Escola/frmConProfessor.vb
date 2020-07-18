Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConProfessor

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim SQL As String

    Private Sub frmConprofessor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        SQL = "SELECT p.codigo_aluno, p.nro, p.nome, d.classe FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma d WHERE p.turma=d.codigo_trma ORDER BY codigo_aluno;"

        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                DGProfessor.DataSource = myData

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub DGProfessor_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DGProfessor.Navigate

    End Sub
End Class