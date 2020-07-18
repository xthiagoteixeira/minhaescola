Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConProfessor

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()

    Dim r As DataRow
    Dim rc As Integer
    Dim SQL As String

    Dim myCommand2 As New MySqlCommand()
    Dim myAdapter2 As New MySqlDataAdapter()
    Dim myData2 As New DataTable()

    Dim r2 As DataRow
    Dim rc2 As Integer
    Dim SQL2 As String

    Dim myCommand3 As New MySqlCommand()
    Dim myAdapter3 As New MySqlDataAdapter()
    Dim myData3 As New DataTable()

    Dim r3 As DataRow
    Dim rc3 As Integer

    Dim SQL3 As String

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()

    Dim r4 As DataRow
    Dim rc4 As Integer

    Dim SQL4 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()

    Dim r5 As DataRow
    Dim rc5 As Integer

    Dim SQL5 As String
    Dim estadono
    Dim BD_OK, IP_OK, imagem_OK

    Private dv As DataView
    Private cm As CurrencyManager
    Private Sub frmConprofessor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")
            Dim Imagem As Object = myRegKey2.GetValue("x")


            BD_OK = BD
            IP_OK = IP
            imagem_OK = Imagem


        Catch ex As Exception
        End Try
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        SQL = "SELECT p.codigo_aluno, p.nro, p.nome, d.classe FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma d WHERE p.turma=d.codigo_trma ORDER BY codigo_aluno;"

        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                DGprofessor.DataSource = myData

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