Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManTurma

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
    Private Sub btAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click


        ' DATA
        Dim SacarData As DateTime = DateTime.Now
        Dim data

        data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")
        'SacarData = FormatDateTime(data, DateFormat.ShortDate)
        ' FIM DATA

        If Not (tbCodigo.Text = "" Or tbClasse.Text = "") Then

            If MsgBox("Efetuar a alteração de: " & tbCodigo.Text & " ?", MsgBoxStyle.YesNo, "Alteração") = Windows.Forms.DialogResult.No Then
                MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                Exit Sub

            Else
                ''''INICIA ALTERACAO''''
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK
                Dim turmano

                turmano = tbCodigo.Text
                SQL = "SELECT * FROM " & BD_OK & ".turma WHERE codigo_trma=" & tbCodigo.Text

                Try
                    conn.Open()
                    Try

                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)
                        r2 = myData2.Rows(0)

                        If r2 Is DBNull.Value Then
                            MsgBox("Não foi possível completar a alteração, a turma informada não existe.", MsgBoxStyle.Critical, "Alteração")
                            Exit Sub
                            Exit Try

                        Else

                            ''''''''''''''''''''''''INICIA A ATUALIZACAO
                            SQL2 = "UPDATE " & BD_OK & ".turma SET classe='" & tbClasse.Text & "', periodo='" & tbPeriodo.Text & "', total_alunos=" & tAlunos.Value & ", anovigente=" & tAnoVigente.Value & ", bloqueado=" & check.Checked & ", fundamental=" & fundamental.Checked & " WHERE codigo_trma=" & tbCodigo.Text & ";"
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
            MsgBox("Não foi possível alterar, é necessário existir um turma para que seja feita a alteração.", MsgBoxStyle.Critical, "Atenção!")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If Not (tbCodigo.Text = "" Or tbClasse.Text = "") Then

            If MsgBox("Efetuar a exclusão de: " & tbClasse.Text & " ?", MsgBoxStyle.YesNo, "Excluir") = Windows.Forms.DialogResult.No Then
                MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                Exit Sub
            Else

                ''''''''''''INICIA EXCLUSAO DE DADOS'
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                SQL = "DELETE FROM " & BD_OK & ".turma WHERE codigo_trma=" & tbCodigo.Text

                Try
                    conn.Open()
                    Try
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)
                        MsgBox("Exclusão completada com sucesso!", MsgBoxStyle.Information, "Exclusão")
                    Catch myerro As MySqlException
                        '  MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                    End Try
                    '           MessageBox.Show("Conexão aberta com sucesso")
                    conn.Close()
                Catch myerro As MySqlException
                    '  MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn.Dispose()
                End Try
            End If
        Else
            MsgBox("Não foi possível excluir, é necessário existir uma turma para que seja efetuada a exclusão.", MsgBoxStyle.Critical, "Atenção!")
        End If
    End Sub

    Private Sub frmManTurma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")


            BD_OK = BD
            IP_OK = IP
        Catch ex As Exception
        End Try

        myData3.Clear()
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        Try
            conn.Open()
            Try
                SQL3 = "SELECT * FROM " & BD_OK & ".turma ORDER BY codigo_trma"
                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)

                SQL5 = "SELECT * FROM " & BD_OK & ".turma ORDER BY classe"
                myCommand5.Connection = conn
                myCommand5.CommandText = SQL5
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)

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
            tbCodigo.Items.Add(r3("codigo_trma"))
        Next

        r5 = myData5.Rows(0)

        'Puxa a cidade
        For Each r5 In myData5.Rows
            tbClasse.Items.Add(r5("classe"))
        Next



    End Sub

    Private Sub tbCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCodigo.SelectedIndexChanged
        myData2.Clear()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        Try
            conn.Open()
            Try
                SQL2 = "SELECT * FROM " & BD_OK & ".turma WHERE codigo_trma=" & tbCodigo.Text
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

        r2 = myData2.Rows(0)

        tbClasse.Text = ""
        tbPeriodo.Text = ""
        tAlunos.Value = "0"
        tAnoVigente.Value = "0"
        fundamental.Checked = False
        check.Checked = False

        tbClasse.Text = r2("classe")
        tbPeriodo.Text = r2("periodo")
        tAlunos.Value = r2("total_alunos")
        tAnoVigente.Value = r2("anovigente")
        fundamental.Checked = r2("fundamental")
        check.Checked = r2("bloqueado")


    End Sub

    Private Sub tbClasse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbClasse.SelectedIndexChanged
        myData2.Clear()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        Try
            conn.Open()
            Try
                SQL2 = "SELECT * FROM " & BD_OK & ".turma WHERE classe='" & tbClasse.Text & "'"
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

        r2 = myData2.Rows(0)

        tbCodigo.Text = ""
        tbPeriodo.Text = ""
        tAlunos.Value = "0"
        tAnoVigente.Value = "0"
        fundamental.Checked = False
        check.Checked = False

        tbCodigo.Text = r2("codigo_trma")
        tbPeriodo.Text = r2("periodo")
        tAlunos.Value = r2("total_alunos")
        tAnoVigente.Value = r2("anovigente")
        fundamental.Checked = r2("fundamental")
        check.Checked = r2("bloqueado")


    End Sub
End Class