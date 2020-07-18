Imports MySql.Data.MySqlClient
Imports Mais_Escola

Public Class frmGDAEMenu

    Dim turma, disciplina
    ' Dim turminha, disciplininha
    Dim trava = 0
    Dim fundamental As Integer

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

    Dim iMedia(0 To 100) As Integer
    Dim iFalta(0 To 100) As Integer
    Dim iAC(0 To 100) As Integer
    Dim iPR(0 To 100) As String
    Dim iTr(0 To 100) As Boolean

    Dim tMedia(0 To 100) As Integer
    Dim tFalta(0 To 100) As Integer
    Dim tAC(0 To 100) As Integer
    Dim tPR(0 To 100) As String
    Dim tTr(0 To 100) As Boolean

    Dim iManual(0 To 100) As Boolean

    Dim chk As New DataGridViewCheckBoxColumn


    Public Sub ZerarDados()

        Me.Size = New System.Drawing.Size(267, 191)

        contadorTransf = 1
        nroTotalAlunos = 1
        ifolha = 0
        inicio = 1
        final = 0
        trava = 0

        travaProcessos = 99

        myData3.Clear()
        myData4.Clear()
        myData7.Clear()
        myData8.Clear()
        myData8.Columns.Clear()

        Array.Clear(iMedia, 0, 100)
        Array.Clear(iFalta, 0, 100)
        Array.Clear(iAC, 0, 100)
        Array.Clear(iPR, 0, 100)
        Array.Clear(iTr, 0, 100)

        Array.Clear(iAV, 0, 100)
        Array.Clear(iFT, 0, 100)
        Array.Clear(iACT, 0, 100)
        Array.Clear(iPRT, 0, 100)
        Array.Clear(iTRT, 0, 100)

        btContinuar.Enabled = True

    End Sub

    Private Sub frmGDAEMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

        Me.Size = New System.Drawing.Size(267, 191)

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                myData.Clear()
                myData2.Clear()
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

    Private Sub nroBimestre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBimestre.ValueChanged
        If tBimestre.Value = 2 Or tBimestre.Value = 4 Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
    End Sub

    Private Sub btContinuar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btContinuar.Click

        contadorTransf = 1
        nroTotalAlunos = 1
        ifolha = 0
        inicio = 1
        final = 0
        trava = 0

        travaProcessos = 99

        myData3.Clear()
        myData4.Clear()
        myData7.Clear()
        myData8.Clear()
        myData8.Columns.Clear()

        Array.Clear(iMedia, 0, 100)
        Array.Clear(iFalta, 0, 100)
        Array.Clear(iAC, 0, 100)
        Array.Clear(iPR, 0, 100)
        Array.Clear(iTr, 0, 100)

        Array.Clear(iAV, 0, 100)
        Array.Clear(iFT, 0, 100)
        Array.Clear(iACT, 0, 100)
        Array.Clear(iPRT, 0, 100)
        Array.Clear(iTRT, 0, 100)

        Dim ano
        Dim bimestre = ""

        If (cbAF.Checked = True And tBimestre.Value = 2) Then
            bimestre = "2AF"
        ElseIf (cbAF.Checked = True And tBimestre.Value = 4) Then
            bimestre = "4AF"
        ElseIf (cbAF.Checked = False) Then
            bimestre = tBimestre.Value
        End If

        If Not (cbTurma.Text = "" Or cbDisciplina.Text = "") Then


            Dim SacarData As DateTime = DateTime.Now
            Dim data

            data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")


            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            SQL3 = "SELECT * FROM " & BD_OK & ".turma WHERE classe='" & cbTurma.Text & "'"
            SQL4 = "SELECT * FROM " & BD_OK & ".disciplinas WHERE disciplina='" & cbDisciplina.Text & "'"

            conn.Open()

            Try
                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)
                r3 = myData3.Rows(0)

                turma = r3("codigo_trma")
                fundamental = r3("fundamental")

                myCommand4.Connection = conn
                myCommand4.CommandText = SQL4
                myAdapter4.SelectCommand = myCommand4
                myAdapter4.Fill(myData4)
                r4 = myData4.Rows(0)

                disciplina = r4("codigo_disc")

            Catch myerro As MySqlException
                conn.Close()
            Finally
                conn.Dispose()
            End Try


            Dim conn2 As MySqlConnection
            conn2 = New MySqlConnection()
            conn2.ConnectionString = CONEXAOBD

            Try
                conn2.Open()
                Try

                    ano = tAno.Value

                    SQL7 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina=" & disciplina & " AND turma=" & turma & " AND cod_bimestre='" & bimestre & "' AND anovigente=" & ano
                    myCommand7.Connection = conn2
                    myCommand7.CommandText = SQL7
                    myAdapter7.SelectCommand = myCommand7
                    myAdapter7.Fill(myData7)

                    Try
                        r7 = myData7.Rows(0)
                        meuboletim = r7("cod_nf")
                        txtP.Text = r7("previsaoaulas")
                        txtT.Text = r7("qtdadeaulas")

                    Catch r7 As IndexOutOfRangeException
                        trava = 1
                    End Try

                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()

            Catch myerro As MySqlException
                ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try
            ' FIM DA CONEXAO

            If trava = 1 Then

                MsgBox("Boletim não encontrado!", MsgBoxStyle.Critical, "Atenção!")
                travaProcessos = 99
                myData8.Clear()

                Exit Sub

            Else

                '///////////////////////////////////////////////////////////////////////////////////////
                ' IDENTIFICA QUAL VALOR PARA TRANSFERIR
                'SE NAO FOR FUNDAMENTAL
                If fundamental = 0 Then
                    If tBimestre.Value = 1 Then
                        travaProcessos = 1
                    ElseIf (tBimestre.Value = 2 And cbAF.Checked = True) Or (tBimestre.Value = 4 And cbAF.Checked = True) Then
                        travaProcessos = 3
                    Else
                        travaProcessos = 2
                    End If
                End If

                'SE FOR FUNDAMENTAL
                If fundamental = -1 Then
                    '1o. BIMESTRE
                    If (tBimestre.Value = 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Ed. Física") Then
                        travaProcessos = 1
                    ElseIf tBimestre.Value = 1 Then
                        travaProcessos = 3
                    End If

                    '2 3 4o. BIMESTRES
                    If (tBimestre.Value <> 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Ed. Física") Then
                        travaProcessos = 2
                    ElseIf tBimestre.Value <> 1 Then
                        travaProcessos = 3
                    End If

                End If

                '///////////////////////////////////////////////////////////////////////////////////////
                Dim conn3 As MySqlConnection
                conn3 = New MySqlConnection()
                conn3.ConnectionString = CONEXAOBD
                Try
                    conn3.Open()
                    Try
                        'SQL5 = "INSERT INTO " & BD_OK & ".notasfreq (turma, disciplina, cod_bimestre, qtdadeaulas, previsaoaulas, anovigente) values(" & turma & ",'" & disciplina & "', '" & bimestre & "', '" & tQtdade.Value & "', '" & pQtdade.Value & "', '" & tAno.Value & "');"
                        'myCommand5.Connection = conn3
                        'myCommand5.CommandText = SQL5
                        'myAdapter5.SelectCommand = myCommand5
                        'myAdapter5.Fill(myData5)

                        SQL8 = "SELECT nro_aluno, M, F, AC, S FROM " & BD_OK & ".boletim WHERE cod_boletim='" & meuboletim & "' ORDER BY nro_aluno ASC"
                        myCommand8.Connection = conn3
                        myCommand8.CommandText = SQL8
                        myAdapter8.SelectCommand = myCommand8
                        myAdapter8.Fill(myData8)

                        myData8.Columns(0).ColumnName = "Nro"
                        myData8.Columns(1).ColumnName = "AV"
                        myData8.Columns(2).ColumnName = "FT"
                        myData8.Columns(3).ColumnName = "AC"
                        myData8.Columns(4).ColumnName = "PR"

                        If cbManual.Checked = True Then
                            'Dim iSelecionado
                            'chk.HeaderText = "VF"
                            chk.ThreeState = False
                            DGBoletim.Columns.Add(chk)
                        End If

                        DGBoletim.DataSource = myData8

                        DGBoletim.Columns(0).Width = 30
                        DGBoletim.Columns(1).Width = 30
                        DGBoletim.Columns(2).Width = 30
                        DGBoletim.Columns(3).Width = 30
                        DGBoletim.Columns(4).Width = 30

                        If cbManual.Checked = True Then
                            DGBoletim.Columns(1).DefaultCellStyle.ForeColor = Color.White
                            DGBoletim.Columns(1).DefaultCellStyle.BackColor = Color.SteelBlue

                            DGBoletim.ReadOnly = False
                            DGBoletim.Columns(5).Width = 30
                        End If

                        '/// INDICE DE ALUNOS
                        For Each r8 In myData8.Rows

                            iMedia(nroTotalAlunos) = r8("AV")
                            iFalta(nroTotalAlunos) = r8("FT")
                            iAC(nroTotalAlunos) = r8("AC")
                            iPR(nroTotalAlunos) = r8("PR")

                            If iMedia(nroTotalAlunos) > "10" Then
                                iTr(nroTotalAlunos) = True

                            End If

                            If nroTotalAlunos = 1 Then
                                ifolha = ifolha + 1
                            ElseIf nroTotalAlunos = 11 Then
                                ifolha = ifolha + 1
                            ElseIf nroTotalAlunos = 21 Then
                                ifolha = ifolha + 1
                            ElseIf nroTotalAlunos = 31 Then
                                ifolha = ifolha + 1
                            ElseIf nroTotalAlunos = 41 Then
                                ifolha = ifolha + 1
                            ElseIf nroTotalAlunos = 51 Then
                                ifolha = ifolha + 1
                            End If
                            nroTotalAlunos = nroTotalAlunos + 1
                        Next

                        DGBoletim.Columns(0).DefaultCellStyle.BackColor = Color.DarkGray

                        Me.Size = New System.Drawing.Size(267, 464)
                        btContinuar.Enabled = False

                    Catch myerro As MySqlException
                        MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                    End Try
                    '           MessageBox.Show("Conexão aberta com sucesso")
                    conn3.Close()

                Catch myerro As MySqlException
                    ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn3.Dispose()
                End Try
                ' FIM DA CONEXAO

            End If

        End If

    End Sub

    Private Sub btProcessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcessar.Click

        Dim i = 1
        Dim k = 1

        If cbManual.Checked = False Then
            'SE AUTOMATICO...
            For i = 1 To nroTotalAlunos

                If iTr(i) = False Then
                    iAV(i) = iMedia(i)
                    iFT(i) = iFalta(i)
                    iACT(i) = iAC(i)
                    iPRT(i) = iPR(i)
                    iTRT(i) = False
                Else
                    iAV(i) = iMedia(i)
                    iFT(i) = iFalta(i)
                    iACT(i) = iAC(i)
                    iPRT(i) = iPR(i)
                    iTRT(i) = True

                End If

            Next
        Else
            'SE FOR MANUAL...
            For i = 1 To nroTotalAlunos

                'PRIMEIRO VAMOS COLOCAR NA FILA TEMPORARIA
                If iManual(i) = 0 Then
                    If iTr(i) = False Then
                        tMedia(i) = iMedia(i)
                        tFalta(i) = iFalta(i)
                        tAC(i) = iAC(i)
                        tPR(i) = iPR(i)
                        tTr(i) = False
                    Else
                        tMedia(i) = iMedia(i)
                        tFalta(i) = iFalta(i)
                        tAC(i) = iAC(i)
                        tPR(i) = iPR(i)
                        tTr(i) = True
                    End If
                Else
                    'COLOCA O NUMERO 99 PARA DEPOIS REMOVER
                    If iTr(i) = False Then
                        tMedia(i) = 99
                        tFalta(i) = 99
                        tAC(i) = 99
                        tPR(i) = "99"
                        tTr(i) = False
                    Else
                        tMedia(i) = 99
                        tFalta(i) = 99
                        tAC(i) = 99
                        tPR(i) = "99"
                        tTr(i) = True
                    End If

                End If

            Next
            'FIM DO LAÇO

            'REMOVE OS 99 PARA PODER TRANSFERIR
            For i = 1 To nroTotalAlunos

                If tMedia(k) <> 99 Then

                    If iTr(i) = False Then
                        iAV(i) = tMedia(k)
                        iFT(i) = tFalta(k)
                        iACT(i) = tAC(k)
                        iPRT(i) = tPR(k)
                        iTRT(i) = False
                    Else
                        iAV(i) = tMedia(k)
                        iFT(i) = tFalta(k)
                        iACT(i) = tAC(k)
                        iPRT(i) = tPR(k)
                        iTRT(i) = True
                    End If

                Else
                    k = k + 1
                    'CHECA SE O PROXIMO É 99
                    ' MsgBox(tMedia(k))

                    If tMedia(k) <> 99 Then
                        If iTr(i) = False Then
                            iAV(i) = tMedia(k)
                            iFT(i) = tFalta(k)
                            iACT(i) = tAC(k)
                            iPRT(i) = tPR(k)
                            iTRT(i) = False
                        Else
                            iAV(i) = tMedia(k)
                            iFT(i) = tFalta(k)
                            iACT(i) = tAC(k)
                            iPRT(i) = tPR(k)
                            iTRT(i) = True
                        End If
                    Else
                        k = k + 1
                        If tMedia(k) <> 99 Then

                            If iTr(i) = False Then
                                iAV(i) = tMedia(k)
                                iFT(i) = tFalta(k)
                                iACT(i) = tAC(k)
                                iPRT(i) = tPR(k)
                                iTRT(i) = False
                            Else
                                iAV(i) = tMedia(k)
                                iFT(i) = tFalta(k)
                                iACT(i) = tAC(k)
                                iPRT(i) = tPR(k)
                                iTRT(i) = True
                            End If
                        Else
                            k = k + 1
                            If iTr(i) = False Then
                                iAV(i) = tMedia(k)
                                iFT(i) = tFalta(k)
                                iACT(i) = tAC(k)
                                iPRT(i) = tPR(k)
                                iTRT(i) = False
                            Else
                                iAV(i) = tMedia(k)
                                iFT(i) = tFalta(k)
                                iACT(i) = tAC(k)
                                iPRT(i) = tPR(k)
                                iTRT(i) = True
                            End If
                        End If
                    End If
                End If
                k = k + 1

            Next
            'FIM DO REMOVER 99
        End If

        ClasseDisciplinaAtual = "" & tBimestre.Value & "o. Bimestre - " & cbTurma.Text & " : " & cbDisciplina.Text

        If MsgBox("Você escolheu: " & ClasseDisciplinaAtual & "" & vbCrLf & "Confirma os dados?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            ClasseDisciplinaAtual = Nothing
            ControleTransferir = 0

            AulasPrevistas = 0
            AulasDadas = 0
            Me.Close()
            Me.Hide()
            Exit Sub
        Else
            ClasseDisciplinaAtual = "" & tBimestre.Value & "o. Bimestre - " & cbTurma.Text & " : " & cbDisciplina.Text
            ControleTransferir = 1

            AulasPrevistas = txtP.Text
            AulasDadas = txtT.Text
        End If

        Me.Close()
        Me.Hide()

    End Sub

    Private Sub DGBoletim_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBoletim.CellClick
        If cbManual.Checked = True Then

            If iManual(DGBoletim.CurrentCell.RowIndex + 1) = 0 Then
                If MsgBox("Deseja excluir o aluno [" & DGBoletim.CurrentCell.RowIndex + 1 & "] ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    DGBoletim.Rows(DGBoletim.CurrentCell.RowIndex).DefaultCellStyle.BackColor = Color.Red
                    iManual(DGBoletim.CurrentCell.RowIndex + 1) = 1
                End If
            Else
                If MsgBox("Deseja retornar o aluno [" & DGBoletim.CurrentCell.RowIndex + 1 & "] ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    DGBoletim.Rows(DGBoletim.CurrentCell.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                    DGBoletim.Rows(DGBoletim.CurrentCell.RowIndex).DefaultCellStyle.BackColor = Color.White

                    DGBoletim.Columns(0).DefaultCellStyle.BackColor = Color.DarkGray
                    DGBoletim.Columns(1).DefaultCellStyle.ForeColor = Color.White
                    DGBoletim.Columns(1).DefaultCellStyle.BackColor = Color.SteelBlue
                    iManual(DGBoletim.CurrentCell.RowIndex + 1) = 0
                End If
            End If

        End If
    End Sub

    Private Sub DGBoletim_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBoletim.CellContentClick

    End Sub

    Private Sub cbManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbManual.CheckedChanged

    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged
        If cbAF.Checked = False Then
            tBimestre.Enabled = True
        Else
            tBimestre.Enabled = False
        End If
    End Sub

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        ZerarDados()

    End Sub

    Private Sub cbDisciplina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged

        ZerarDados()

    End Sub
End Class