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
    Dim SQL As String

    Dim myCommand2 As New MySqlCommand()
    Dim myAdapter2 As New MySqlDataAdapter()
    Dim myData2 As New DataTable()
    Dim r2 As DataRow
    Dim SQL2 As String

    Dim myCommand3 As New MySqlCommand()
    Dim myAdapter3 As New MySqlDataAdapter()
    Dim myData3 As New DataTable()
    Dim SQL3 As String

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()
    Dim SQL4 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()
    Dim r5 As DataRow
    Dim SQL5 As String

    Dim nrodisciplina
    Dim nroturma

    Private Sub frmManAulasPrevistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Size = New System.Drawing.Size(436, 134)

        tAno.Value = Format(Date.Now, "yyyy")

        myData.Clear()
        myData.Reset()

        'busca disciplina
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                SQL = "SELECT * FROM " & BD_OK & ".disciplinas ORDER BY disciplina"
                SQL2 = "SELECT * FROM " & BD_OK & ".turma where bloqueado=0 ORDER BY classe"

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

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConsultar.Click

        myData5.Clear()

        Dim bimestre

        If cbAF.Checked = True And tBimestre.Value = 2 Then
            bimestre = "2AF"
        ElseIf cbAF.Checked = True And tBimestre.Value = 4 Then
            bimestre = "4AF"
        Else
            bimestre = tBimestre.Value
        End If

        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        SQL5 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina='" & nrodisciplina & "' AND turma='" & nroturma & "' AND anovigente='" & tAno.Value & "' AND cod_bimestre='" & bimestre & "'"

        Try
            conn.Open()
            Try
                myCommand5.Connection = conn
                myCommand5.CommandText = SQL5
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)

                r5 = myData5.Rows(0)
                qtdadeaulas = r5("qtdadeaulas")
                previsaoaulas = r5("previsaoaulas")
                nronf = r5("cod_nf")


                tAulas.Text = qtdadeaulas
                tPrevistas.Text = previsaoaulas

                Me.Size = New System.Drawing.Size(436, 254)

            Catch r5 As IndexOutOfRangeException
                MsgBox("Não existe boletim para efetuar alteração!", MsgBoxStyle.Exclamation)
                tAulas.Text = "00"
                tPrevistas.Text = "00"
                Me.Close()
                Exit Try
                Exit Sub
            End Try
            ' MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btAlterar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterar.Click
        If tAulas.Text = "00" And tPrevistas.Text = "00" Then

            MsgBox("Favor, verificar o boletim!", MsgBoxStyle.Exclamation)

        Else
            myData.Clear()
            myData3.Clear()

            Dim contador
            Dim conn As MySqlConnection
            Dim nvPrevistas, nvAulas

            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()

                Try
                    ' Pega o numero total de alunos
                    SQL = "SELECT * FROM boletim WHERE cod_boletim='" & nronf & "' ORDER BY nro_aluno DESC"
                    myCommand.Connection = conn
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)
                    r = myData.Rows(0)
                    nroaluno = r("nro_aluno")

                    ' Altera a previsao e o total de aulas
                    SQL3 = "UPDATE notasfreq SET previsaoaulas='" & tbPrevistas.Text & "', qtdadeaulas='" & tbAulas.Text & "' WHERE cod_nf='" & nronf & "';"
                    atualizaMySQL(SQL3)

                    nvAulas = tbAulas.Text
                    nvPrevistas = tbPrevistas.Text

                    For contador = 1 To nroaluno Step 1
                        Dim nrofalta = 0
                        Dim porcentagem As Integer
                        myData2.Clear()
                        myData4.Clear()

                        ' Pega a falta do aluno
                        SQL2 = "SELECT * FROM boletim WHERE cod_boletim=" & nronf & " AND nro_aluno=" & contador & ";"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)
                        r2 = myData2.Rows(0)

                        nrofalta = r2("F")
                        porcentagem = ((nrofalta * 100) / nvAulas)

                        ' Altera a porcentagem do aluno
                        SQL4 = "UPDATE boletim SET porcentagem='" & porcentagem & "' WHERE cod_boletim=" & nronf & " AND nro_aluno=" & contador & ";"
                        atualizaMySQL(SQL4)

                    Next contador

                    Me.Size = New System.Drawing.Size(436, 135)

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

    Private Sub cbTurma_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData2.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn2 As MySqlConnection

        conn2 = New MySqlConnection()
        conn2.ConnectionString = CONEXAOBD

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

    Private Sub cbDisciplina_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged
        myData2.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn2 As MySqlConnection

        conn2 = New MySqlConnection()
        conn2.ConnectionString = CONEXAOBD
        SQL2 = "SELECT codigo_disc FROM " & BD_OK & ".disciplinas WHERE disciplina='" & cbDisciplina.Text & "'"
        Try
            conn2.Open()
            Try
                myCommand2.Connection = conn2
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)
                r2 = myData2.Rows(0)
                nrodisciplina = r2("codigo_disc")

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