Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmCadNF

    Public Shared fCad234 As New frmCad234

    Dim turma, disciplina
    Dim trava = 0, travaC = 0
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

    Dim myCommand3 As New MySqlCommand()
    Dim myAdapter3 As New MySqlDataAdapter()
    Dim myData3 As New DataTable()
    Dim r3 As DataRow
    Dim SQL3 As String

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()
    Dim r4 As DataRow
    Dim SQL4 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()
    Dim r5 As DataRow
    Dim SQL5 As String

    Dim myCommand7 As New MySqlCommand()
    Dim myAdapter7 As New MySqlDataAdapter()
    Dim myData7 As New DataTable()
    Dim r7 As DataRow
    Dim SQL7 As String

    Dim myCommand8 As New MySqlCommand()
    Dim myAdapter8 As New MySqlDataAdapter()
    Dim myData8 As New DataTable()
    Dim r8 As DataRow
    Dim SQL8 As String

    Private Sub frmCadNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                SQL = "SELECT * FROM " & BD_OK & ".disciplinas ORDER BY disciplina"
                SQL2 = "SELECT * FROM " & BD_OK & ".turma WHERE bloqueado=0 ORDER BY classe"

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
                    If r("disciplina") <> "-" Then
                        cbDisciplina.Items.Add(r("disciplina"))
                    End If

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


        'If Not tBloqueio.Text = "0" Then

        '    'se for um professor

        '    '''''''''''''CARREGA INICIALMENTE''''''''''''
        '    Dim conn2 As MySqlConnection
        '    conn2 = New MySqlConnection()
        '    conn2.ConnectionString = CONEXAOBD

        '    Try
        '        conn2.Open()
        '        Try
        '            SQL3 = "SELECT p.codigo_aluno, d.disciplina FROM " & BD_OK & ".professor p, " & BD_OK & ".disciplinas d WHERE p.codigo_aluno=d.codigo_disc AND p.codigo_aluno=" & tBloqueio.Text


        '            myCommand3.Connection = conn2
        '            myCommand3.CommandText = SQL3
        '            myAdapter3.SelectCommand = myCommand3
        '            myAdapter3.Fill(myData3)

        '            Dim ndisc
        '            r3 = myData3.Rows(0)
        '            ndisc = r3("disciplina")

        '            cbDisciplina.Items.Clear()
        '            cbDisciplina.Text = ndisc
        '            cbDisciplina.Enabled = False

        '        Catch myerro As MySqlException
        '            MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
        '        End Try
        '        '           MessageBox.Show("Conexão aberta com sucesso")
        '        conn.Close()
        '    Catch myerro As MySqlException
        '        MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        '    Finally
        '        conn.Dispose()
        '    End Try


        'End If


    End Sub

    Private Sub tBimestre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBimestre.ValueChanged
        If tBimestre.Value = 2 Or tBimestre.Value = 4 Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
    End Sub

    Private Sub pQtdade_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pQtdade.ValueChanged

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        Dim ano, bimestre
        AnoVigenteNF = tAno.Value

        If cbAF.Checked = True And tBimestre.Value = 2 Then
            bimestre = "2AF"
        ElseIf cbAF.Checked = True And tBimestre.Value = 4 Then
            bimestre = "4AF"
        Else
            bimestre = tBimestre.Value
        End If

        If Not (cbTurma.Text = "" Or cbDisciplina.Text = "") Then

            myData.Clear()
            myData2.Clear()
            myData3.Clear()
            myData4.Clear()
            myData5.Clear()
            myData6.Clear()
            myData7.Clear()
            myData8.Clear()

            Dim vStrMsg As String = _
            MsgBox("Deseja iniciar o boletim " & tBimestre.Value & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Atenção!")

            If vStrMsg = MsgBoxResult.Yes Then

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

                    Dim conn3 As MySqlConnection
                    conn3 = New MySqlConnection()
                    conn3.ConnectionString = CONEXAOBD
                    Try
                        conn3.Open()
                        Try


                            SQL5 = "INSERT INTO " & BD_OK & ".notasfreq (turma, disciplina, cod_bimestre, qtdadeaulas, previsaoaulas, anovigente) values(" & turma & ",'" & disciplina & "', '" & bimestre & "', '" & tQtdade.Value & "', '" & pQtdade.Value & "', '" & tAno.Value & "');"
                            atualizaMySQL(SQL5)

                            SQL8 = "SELECT * FROM " & BD_OK & ".notasfreq ORDER BY cod_nf DESC"
                            myCommand8.Connection = conn3
                            myCommand8.CommandText = SQL8
                            myAdapter8.SelectCommand = myCommand8
                            myAdapter8.Fill(myData8)

                            r8 = myData8.Rows(0)
                            If r8 Is DBNull.Value Then
                                meuboletim = 1
                            Else
                                meuboletim = r8("cod_nf")
                            End If

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

                Else

                    MsgBox("Já existe um boletim cadastrado!", MsgBoxStyle.Critical, "Atenção!")

                    If (MsgBox("Você deseja continuar com o boletim: " & tBimestre.Value & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                        trava = 1
                        travaC = 1

                    Else
                        Me.Close()
                        Me.Hide()
                        Exit Sub
                    End If

                End If


                If trava = 1 Then

                    'SE NAO FOR FUNDAMENTAL
                    If fundamental = 0 Then

                        If tBimestre.Value = 1 Then

                            Dim Boletim

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = bimestre
                            qtdadeaulas = tQtdade.Value
                            qtdadeaulasNF = qtdadeaulas

                            frmCadBoletim.lbDisciplina.Text = disciplina
                            frmCadBoletim.lbTurma.Text = turma
                            frmCadBoletim.lBoletim.Text = Boletim
                            frmCadBoletim.lbBoletim.Text = meuboletim
                            frmCadBoletim.qtdadeaulas.Text = qtdadeaulas

                            If travaC = 1 Then
                                frmCadBoletim.travaC.Text = travaC
                            End If

                            Me.Close()
                            Me.Hide()
                            frmCadBoletim.Show()

                        Else
                            Dim Boletim

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = bimestre
                            qtdadeaulas = tQtdade.Value

                            NomeDisciplinaNF = disciplina
                            NomeTurmaNF = turma
                            BoletimNF = Boletim
                            meuboletimNF = meuboletim
                            qtdadeaulasNF = qtdadeaulas

                            If travaC = 1 Then
                                frmCad234.travaC.Text = travaC
                            End If

                            Me.Close()
                            Me.Hide()
                            frmCad234.Show()

                        End If
                    End If

                    'SE FOR FUNDAMENTAL
                    If fundamental = -1 Then
                        '1o. BIMESTRE
                        If (tBimestre.Value = 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Ed. Física") Then

                            Dim Boletim

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = bimestre
                            qtdadeaulas = tQtdade.Value
                            qtdadeaulasNF = qtdadeaulas

                            frmCadBoletim.lbDisciplina.Text = disciplina
                            frmCadBoletim.lbTurma.Text = turma
                            frmCadBoletim.lBoletim.Text = Boletim
                            frmCadBoletim.lbBoletim.Text = meuboletim
                            frmCadBoletim.qtdadeaulas.Text = qtdadeaulas

                            If travaC = 1 Then
                                frmCadBoletim.travaC.Text = travaC
                            End If

                            Me.Close()
                            Me.Hide()
                            frmCadBoletim.Show()
                        ElseIf tBimestre.Value = 1 Then

                            Dim Boletim

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = bimestre
                            qtdadeaulas = tQtdade.Value

                            NomeDisciplinaNF = disciplina
                            NomeTurmaNF = turma
                            BoletimNF = Boletim
                            meuboletimNF = meuboletim
                            qtdadeaulasNF = qtdadeaulas

                            frmCadFundamental.lbDisciplina.Text = disciplina
                            frmCadFundamental.lbTurma.Text = turma
                            frmCadFundamental.lBoletim.Text = Boletim
                            frmCadFundamental.lbBoletim.Text = meuboletim

                            If travaC = 1 Then
                                frmCadFundamental.travaC.Text = travaC
                            End If

                            Me.Close()
                            Me.Hide()
                            frmCadFundamental.Show()

                        End If

                        '2 3 4o. BIMESTRES
                        If (tBimestre.Value <> 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Ed. Física") Then

                            Dim Boletim

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = bimestre
                            qtdadeaulas = tQtdade.Value

                            NomeDisciplinaNF = disciplina
                            NomeTurmaNF = turma
                            BoletimNF = Boletim
                            meuboletimNF = meuboletim
                            qtdadeaulasNF = qtdadeaulas

                            frmCad234.lbDisciplina.Text = disciplina
                            frmCad234.lbTurma.Text = turma
                            frmCad234.lBoletim.Text = Boletim
                            frmCad234.lbBoletim.Text = meuboletim
                            frmCad234.qtdadeaulas.Text = qtdadeaulas

                            If travaC = 1 Then
                                frmCad234.travaC.Text = travaC
                            End If

                            Me.Close()
                            Me.Hide()

                            frmCad234.Show()

                        ElseIf tBimestre.Value <> 1 Then

                            Dim Boletim

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = bimestre
                            qtdadeaulas = tQtdade.Value

                            NomeDisciplinaNF = disciplina
                            NomeTurmaNF = turma
                            BoletimNF = Boletim
                            meuboletimNF = meuboletim
                            qtdadeaulasNF = qtdadeaulas

                            frmCadFundamental.lbDisciplina.Text = disciplina
                            frmCadFundamental.lbTurma.Text = turma
                            frmCadFundamental.lBoletim.Text = Boletim
                            frmCadFundamental.lbBoletim.Text = meuboletim

                            If travaC = 1 Then
                                frmCadFundamental.travaC.Text = travaC
                            End If
                            Me.Close()
                            Me.Hide()
                            frmCadFundamental.Show()


                        End If

                    End If


                Else

                    MsgBox("Desculpe, já existe um boletim cadastrado!", MsgBoxStyle.Critical)

                    Me.Close()
                    Me.Hide()
                    Exit Sub

                End If

            End If

        Else

            MsgBox("Favor, escolha a disciplina e a turma para iniciar um novo boletim!", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub cbDisciplina_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged

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

                Dim nrodisciplina

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

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

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

                Dim nroturma
                nroturma = r2("codigo_trma")
                nroTurmaAluno = nroturma
                fundamental = r2("fundamental")

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

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged

        tQtdade.Enabled = True
        pQtdade.Enabled = True

        If (tBimestre.Value = 2 Or tBimestre.Value = 4) And cbAF.Checked = True Then
            tBimestre.Enabled = False
            MsgBox("1 - Aprovado (na disciplina)" & vbCrLf & "3 - Retido por Freqüência Insuficiente (na disciplina)" & vbCrLf & "4 - Retido por Rendimento Insuficiente (na disciplina)", MsgBoxStyle.Information, "Informações de Situação Final")
            tQtdade.Value = 1
            pQtdade.Value = 1
            tQtdade.Enabled = False
            pQtdade.Enabled = False

        End If

        If cbAF.Checked = True Then
            tBimestre.Enabled = False
            EJA = "V"
        Else
            tBimestre.Enabled = True
            EJA = "F"
        End If
    End Sub

End Class