Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManDisciplinas

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

    Dim trava = 0
    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click


        ' DATA
        Dim SacarData As DateTime = DateTime.Now
        Dim data



        data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")
        'SacarData = FormatDateTime(data, DateFormat.ShortDate)
        ' FIM DATA

        If Not tbDisciplina.Text = "" Then

            If MsgBox("Efetuar a alteração de: " & tbCodigo.Text & " ?", MsgBoxStyle.YesNo, "Alteração") = Windows.Forms.DialogResult.No Then
                MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                Exit Sub
            Else

                ''''INICIA ALTERACAO''''

                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK
                Dim disciplinano

                disciplinano = tbCodigo.Text
                SQL = "SELECT * FROM " & BD_OK & ".disciplinas WHERE codigo_disc=" & tbCodigo.Text

                Try
                    conn.Open()
                    Try

                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)
                        r2 = myData2.Rows(0)

                        If r2 Is DBNull.Value Then
                            MsgBox("Não foi possível completar a alteração, a disciplina informado não existe.", MsgBoxStyle.Critical, "Alteração")
                            Exit Sub
                            Exit Try

                        Else
                            Dim procura
                            procura = r2("codigo_disc")

                            ''''''''''''''''''''''''INICIA A ATUALIZACAO
                            SQL2 = "UPDATE " & BD_OK & ".disciplinas SET disciplina='" & tbDisciplina.Text & "' WHERE codigo_disc=" & tbCodigo.Text & ";"

                            myCommand3.Connection = conn
                            myCommand3.CommandText = SQL2
                            myAdapter3.SelectCommand = myCommand3
                            myAdapter3.Fill(myData3)
                            MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")

                        End If
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

            End If

        Else

            MsgBox("Não foi possível alterar, é necessário existir um disciplina para que seja feita a alteração.", MsgBoxStyle.Critical, "Atenção!")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If Not (tbCodigo.Text = "") Then

            If MsgBox("Efetuar a exclusão de: " & tbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Excluir") = Windows.Forms.DialogResult.No Then
                MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                Exit Sub

            Else

                ''''''''''''INICIA EXCLUSAO DE DADOS'
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                SQL = "DELETE FROM " & BD_OK & ".disciplinas WHERE codigo_disc=" & tbCodigo.Text

                Try
                    conn.Open()
                    Try

                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        MsgBox("Exclusão completada com sucesso!", MsgBoxStyle.Information, "Exclusão")

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
            End If
        Else
            MsgBox("Não foi possível excluir, é necessário existir uma disciplina para que seja feita a exclusão.", MsgBoxStyle.Critical, "Atenção!")
        End If
    End Sub

 
    Private Sub frmManDisciplinas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")

            BD_OK = BD
            IP_OK = IP

        Catch ex As Exception
        End Try
    End Sub
End Class