Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConBoletim

    Public Shared fManBoletimALT As New frmManBoletimALT

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

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()
    Dim r4 As DataRow
    Dim SQL4 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()
    Dim r5 As DataRow
    
    Dim nrodisciplina, nroturma

    Private Sub frmConVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'PUXA O BIMESTRE ATUAL................
        Dim atualBimestre = Format(Date.Now, "MM")

        If atualBimestre <= "05" Then
            tBimestre.Value = "1"
        ElseIf atualBimestre <= "07" Then
            tBimestre.Value = "2"
        ElseIf atualBimestre <= "09" Then
            tBimestre.Value = "3"
        ElseIf atualBimestre <= "12" Then
            tBimestre.Value = "4"
        End If

        'DEIXAR COMO PADRAO O ANO
        tAno.Value = Format(Date.Now, "yyyy")

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
            If r("disciplina") <> "-" Then
                cbDisciplina.Items.Add(r("disciplina"))
            End If
        Next

        For Each r2 In myData2.Rows
            If (r2("bloqueado") = 0) Then
                cbTurma.Items.Add(r2("classe"))
            End If

        Next


    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        If (cbTurma.Text = "" Or cbDisciplina.Text = "") Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else

            Dim vStrMsg As String = _
            MsgBox("Deseja visualizar o boletim - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Atenção!")

            If vStrMsg = MsgBoxResult.Yes Then

                Dim SacarData As DateTime = DateTime.Now
                Dim data, nf

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = CONEXAOBD
                SQL4 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina='" & nrodisciplina & "' AND turma=" & nroturma & " AND cod_bimestre=" & tBimestre.Value & " AND anovigente=" & tAno.Value & ""

                Try
                    conn.Open()
                    Try
                        myCommand4.Connection = conn
                        myCommand4.CommandText = SQL4
                        myAdapter4.SelectCommand = myCommand4
                        myAdapter4.Fill(myData4)

                        Try
                            r4 = myData4.Rows(0)

                            nf = r4("cod_nf")


                            fManBoletimALT = New frmManBoletimALT

                            fManBoletimALT.Height = "261"
                            fManBoletimALT.Width = "502"

                            fManBoletimALT.XBoletim.Text = nf
                            fManBoletimALT.lbDisciplina.Text = nrodisciplina
                            fManBoletimALT.lbTurma.Text = nroturma
                            fManBoletimALT.lBoletim.Text = tBimestre.Value

                            fManBoletimALT.Text = "" & cbTurma.Text & " - " & cbDisciplina.Text & " : " & tBimestre.Value & "o. Bimestre"
                            fManBoletimALT.tbMedia.Enabled = False
                            fManBoletimALT.tbFaltas.Enabled = False
                            fManBoletimALT.tbSN.Enabled = False
                            fManBoletimALT.btAdicionar.Visible = False

                            fManBoletimALT.Show()

                        Catch ex As IndexOutOfRangeException

                            MsgBox("Não existe boletim para visualizar!", MsgBoxStyle.Exclamation)

                            Exit Try
                            Exit Sub


                        End Try
                    Catch myerro As MySqlException
                        MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                    End Try
                    conn.Close()
                Catch myerro As MySqlException
                    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn.Dispose()
                End Try
                ' FIM DA CONEXAO

            End If

        End If



    End Sub

    Private Sub cbAF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged

        If tBimestre.Value = 1 Or tBimestre.Value = 3 Then
            tBimestre.Enabled = True
        Else
            tBimestre.Enabled = False
        End If

        If cbAF.Checked = False Then
            tBimestre.Enabled = True

        End If

    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData2.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn2 As MySqlConnection

        conn2 = New MySqlConnection()
        conn2.ConnectionString = CONEXAOBD

        SQL2 = "SELECT * FROM " & BD_OK & ".turma WHERE classe='" & cbTurma.Text & "'"
        Try
            conn2.Open()
            Try
                myCommand2.Connection = conn2
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)
                r2 = myData2.Rows(0)
                nroturma = r2("codigo_trma")
                'fundamental = r2("fundamental")

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

    Private Sub ComboBoxEx2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged

        myData5.Clear()
        myData3.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

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

    Private Sub tBimestre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBimestre.ValueChanged

        If tBimestre.Value = 1 Or tBimestre.Value = 3 Then
            cbAF.Enabled = False
        Else
            cbAF.Enabled = True
        End If
    End Sub
End Class