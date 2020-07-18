Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConAlunos

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim SQL As String

    Private Sub frmConVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        SQL = "select t.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.S FROM " & BD_OK & ".boletim b, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE b.cod_boletim=n.cod_nf AND t.codigo_trma=n.turma AND d.codigo_disc=n.disciplina"

        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                DGVendedor.DataSource = myData

            Catch myerro As MySqlException
                '                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub


    Private Sub DGVendedor_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DGVendedor.Navigate

    End Sub
End Class