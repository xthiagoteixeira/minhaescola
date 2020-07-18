Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManAulasPrevistas

    Dim qtdadeaulas, previsaoaulas, nronf, nroaluno

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

    Dim myCommand6 As New MySqlCommand()
    Dim myAdapter6 As New MySqlDataAdapter()
    Dim myData6 As New DataTable()

    Dim r6 As DataRow
    Dim rc6 As Integer

    Dim SQL6 As String

    Dim myCommand7 As New MySqlCommand()
    Dim myAdapter7 As New MySqlDataAdapter()
    Dim myData7 As New DataTable()

    Dim r7 As DataRow
    Dim rc7 As Integer

    Dim SQL7 As String

    Dim estadono
    Dim BD_OK, IP_OK, imagem_OK

    Private dv As DataView
    Private cm As CurrencyManager

    Dim trava = 0
    Dim nrodisciplina
    Dim nroturma
    Dim meuboletim, nf

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData2.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn2 As MySqlConnection

        conn2 = New MySqlConnection()
        conn2.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        SQL2 = "SELECT codigo_trma FROM " & BD_OK & ".turma WHERE classe='" & cbTurma.Text & "'"
        Try
            conn2.Open()
            Try
                myCommand2.Connection = conn2
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)
                r2 = myData2.Rows(0)
                nroturma = r2("codigo_trma")

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

    Private Sub cbDisciplina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged

        myData5.Clear()
        myData3.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        SQL = "SELECT * FROM " & BD_OK & ".disciplinas WHERE disciplina='" & cbDisciplina.Text & "'"

        Try
            conn.Open()
            Try
                myCommand5.Connection = conn
                myCommand5.CommandText = SQL
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)
                r5 = myData5.Rows(0)

                nrodisciplina = r5("codigo_disc")

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
    End Sub

    Private Sub frmManAulasPrevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        myData.Clear()
        myData.Reset()

        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")

            BD_OK = BD
            IP_OK = IP

        Catch ex As Exception
        End Try

        'busca disciplina
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        Try
            conn.Open()
            Try
                SQL = "SELECT * FROM " & BD_OK & ".disciplinas ORDER BY disciplina"
                SQL2 = "SELECT * FROM " & BD_OK & ".turma ORDER BY classe"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

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

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAulas.TextChanged
        If tAulas.Text <> "00" Then
            btAlterar.Enabled = True

        Else
            btAlterar.Enabled = False

        End If
    End Sub

    Private Sub tbPrevistas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPrevistas.TextChanged
        If tPrevistas.Text <> "00" Then
            btAlterar.Enabled = True

        Else
            btAlterar.Enabled = False

        End If
    End Sub

    Private Sub btConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConsultar.Click

        myData5.Clear()


        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        SQL = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina='" & nrodisciplina & "' AND turma='" & nroturma & "' AND anovigente='" & tAno.Value & "' AND cod_bimestre='" & tBimestre.Value & "'"

        Try
            conn.Open()
            Try
                myCommand5.Connection = conn
                myCommand5.CommandText = SQL
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)
                r5 = myData5.Rows(0)

                qtdadeaulas = r5("qtdadeaulas")
                previsaoaulas = r5("previsaoaulas")
                nronf = r5("cod_nf")


                tAulas.Text = qtdadeaulas
                tPrevistas.Text = previsaoaulas


            Catch r5 As IndexOutOfRangeException
                MsgBox("Não existe boletim para efetuar alteração!", MsgBoxStyle.Exclamation)
                tAulas.Text = "00"
                tPrevistas.Text = "00"

                Me.Hide()
                Me.Close()

                Exit Try
                Exit Sub
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterar.Click
        If tAulas.Text = "00" And tPrevistas.Text = "00" Then

            MsgBox("Favor, verificar o boletim!", MsgBoxStyle.Exclamation)

        Else
            myData.Clear()
            myData3.Clear()

            Dim contador
            Dim conn As MySqlConnection
            Dim nvPrevistas, nvAulas

            conn = New MySqlConnection()
            conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

            Try
                conn.Open()

                Try
                    ' Pega o numero total de alunos
                    SQL = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim='" & nronf & "' ORDER BY nro_aluno DESC"
                    myCommand.Connection = conn
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)
                    r = myData.Rows(0)
                    nroaluno = r("nro_aluno")

                    ' Altera a previsao e o total de aulas
                    SQL3 = "UPDATE " & BD_OK & ".notasfreq SET previsaoaulas='" & tbPrevistas.Text & "', qtdadeaulas='" & tbAulas.Text & "' WHERE cod_nf='" & nronf & "';"
                    myCommand3.Connection = conn
                    myCommand3.CommandText = SQL3
                    myAdapter3.SelectCommand = myCommand3
                    myAdapter3.Fill(myData3)

                    nvAulas = tbAulas.Text
                    nvPrevistas = tbPrevistas.Text

                    For contador = 1 To nroaluno Step 1
                        Dim nrofalta = 0
                        Dim porcentagem As Integer
                        myData2.Clear()
                        myData4.Clear()

                        ' Pega a falta do aluno
                        SQL2 = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim=" & nronf & " AND nro_aluno=" & contador & ";"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)
                        r2 = myData2.Rows(0)

                        nrofalta = r2("F")
                        porcentagem = ((nrofalta * 100) / nvAulas)

                        ' Altera a porcentagem do aluno
                        SQL4 = "UPDATE " & BD_OK & ".boletim SET porcentagem='" & porcentagem & "' WHERE cod_boletim=" & nronf & " AND nro_aluno=" & contador & ";"
                        myCommand4.Connection = conn
                        myCommand4.CommandText = SQL4
                        myAdapter4.SelectCommand = myCommand4
                        myAdapter4.Fill(myData4)

                    Next contador

                    MsgBox("Alterado com sucesso!", MsgBoxStyle.Information)
                    tbPrevistas.Text = ""
                    tbAulas.Text = ""
                    tPrevistas.Text = "00"
                    tAulas.Text = "00"

                Catch myerro As MySqlException
                End Try
                conn.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try


        End If
    End Sub
End Class