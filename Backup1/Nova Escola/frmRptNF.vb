Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmRptNF

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()
    Dim r5 As DataRow
    Dim SQL5 As String

    Dim contadorTurmas = 0
    Dim montaTurma
    Dim escolheu = 0

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTurmas.CheckedChanged
        escolheu = 0
        'se for turmas...
        cbTurma.Enabled = True
        btMais.Enabled = True
        btMenos.Enabled = True
        cbPeriodo.Enabled = False
        listaTurmas.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPeriodo.CheckedChanged
        escolheu = 0
        'se for periodos...
        cbTurma.Enabled = False
        btMais.Enabled = False
        btMenos.Enabled = False
        cbPeriodo.Enabled = True
        listaTurmas.Enabled = False
    End Sub

    Private Sub frmRptNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

        myData3.Clear()
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                SQL5 = "SELECT classe FROM turma WHERE bloqueado=0 ORDER BY classe"
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

        r5 = myData5.Rows(0)

        'Puxa a cidade
        For Each r5 In myData5.Rows
            cbTurma.Items.Add(r5("classe"))
        Next

    End Sub

    Private Sub btMais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMais.Click
        If cbTurma.Text = "" Then

            MsgBox("Escolha uma turma!", MsgBoxStyle.Critical)

        Else

            contadorTurmas += 1

            If contadorTurmas = 1 Then
                montaTurma += "" & cbTurma.Text
            Else
                montaTurma += "', '" & cbTurma.Text
            End If

            'Adiciona na listbox
            listaTurmas.Items.Add(cbTurma.Text)

            'Remove no Combobox
            cbTurma.Items.Remove(cbTurma.Text)

        End If
    End Sub

    Private Sub btMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMenos.Click

        If contadorTurmas = 0 Then
            MsgBox("A lista está vazia!", MsgBoxStyle.Information)
        Else
            contadorTurmas = 0
            cbTurma.Items.Clear()
            listaTurmas.Items.Clear()
            montaTurma = ""
            For Each r5 In myData5.Rows
                cbTurma.Items.Add(r5("classe"))
            Next

        End If

    End Sub

    Private Sub cbPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPeriodo.SelectedIndexChanged
        escolheu += 1
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        If escolheu > 0 Then

            If rbTurmas.Checked = True Then
                ' se for turmas...
                grupoTurmas = montaTurma
                grupoAnoVigente = tAno.Value

                If cbComparar.Checked = True Then
                    frmRpt.grupoCompara = 1
                Else
                    frmRpt.grupoCompara = 0
                End If

                If cbAF.Checked = True And tBimestre.Value = 2 Then
                    frmRpt.grupoBimestre = "2AF"
                ElseIf cbAF.Checked = True And tBimestre.Value = 4 Then
                    frmRpt.grupoBimestre = "4AF"
                Else
                    frmRpt.grupoBimestre = tBimestre.Value
                End If

                frmRpt.lbParametro.Text = "GrupoTurmas"
                Me.Close()
                frmRpt.Show()

            ElseIf rbPeriodo.Checked = True Then
                ' se for periodo...
                grupoPeriodo = cbPeriodo.Text
                grupoAnoVigente = tAno.Value
                If cbComparar.Checked = True Then
                    frmRpt.grupoCompara = 1
                Else
                    frmRpt.grupoCompara = 0
                End If

                If cbAF.Checked = True And tBimestre.Value = 2 Then
                    frmRpt.grupoBimestre = "2AF"
                ElseIf cbAF.Checked = True And tBimestre.Value = 4 Then
                    frmRpt.grupoBimestre = "4AF"
                Else
                    frmRpt.grupoBimestre = tBimestre.Value
                End If

                frmRpt.lbParametro.Text = "GrupoPeriodo"
                Me.Close()
                frmRpt.Show()

            Else
                'se nao for nenhuma...
                MsgBox("Escolha uma opção!", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Escolha uma opção!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cbAF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged
        If tBimestre.Value = 1 Or tBimestre.Value = 3 Then
            tBimestre.Enabled = True
        Else
            tBimestre.Enabled = False
        End If

    End Sub

    Private Sub tBimestre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBimestre.ValueChanged
        If tBimestre.Value = 2 Or tBimestre.Value = 4 Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
    End Sub

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged
        escolheu += 1
    End Sub
End Class