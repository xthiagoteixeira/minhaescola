Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmSobreEscola

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim r As DataRow
    Dim SQL As String

    Dim myCommand2 As New MySqlCommand()
    Dim myAdapter2 As New MySqlDataAdapter()
    Dim myData2 As New DataTable()
    Dim SQL2 As String

    Private Sub frmSobreEscola_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                Try

                    SQL = "CREATE TABLE escola ( `idescola` int(10) unsigned NOT NULL AUTO_INCREMENT, `nome` varchar(45) NOT NULL, `de` varchar(45) NOT NULL, PRIMARY KEY (`idescola`));"
                    myCommand.Connection = conn
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)

                    myData.Clear()
                    SQL = "INSERT INTO escola (`idescola`,`nome`,`de`) VALUES (1,'E E iSolucao Informatica','DIRETORIA DE ENSINO DE RIBEIRAO PRETO');"
                    atualizaMySQL(SQL)

                Catch ex As Exception
                End Try

                SQL = "SELECT * FROM escola"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                r = myData.Rows(0)

                tbEscola.Text = r("nome")
                tbDiretoria.Text = r("de")

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

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCadastro.Click

        If tbDiretoria.Text <> "" And tbEscola.Text <> "" Then

            '''''''''''''CARREGA INICIALMENTE''''''''''''
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try
                    SQL2 = "UPDATE escola SET de='" & tbDiretoria.Text & "', nome='" & tbEscola.Text & "' WHERE idescola=1;"
                    atualizaMySQL(SQL2)
                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                conn.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try
            MsgBox("Atualizado com sucesso!", MsgBoxStyle.Information)
        Else
            MsgBox("Os campos não podem estar em branco!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btFinalizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFinalizar.Click
        Me.Close()

    End Sub
End Class