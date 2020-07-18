Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManNF

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

    Dim fundamental, MEUBOLETIM

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

    Dim myCommand6 As New MySqlCommand()
    Dim myAdapter6 As New MySqlDataAdapter()
    Dim myData6 As New DataTable()
    Dim r6 As DataRow
    Dim SQL6 As String

    Dim trava = 0
    Dim nrodisciplina
    Dim nroturma
    Dim nf

    Private Sub frmManNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            If r("disciplina") <> "-" Then
                cbDisciplina.Items.Add(r("disciplina"))
            End If
        Next

        For Each r2 In myData2.Rows
            If (r2("bloqueado") = 0) Then
                cbTurma.Items.Add(r2("classe"))
            End If

        Next


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


        '            Try


        '                SQL5 = "SELECT * FROM " & BD_OK & ".disciplinas WHERE disciplina='" & cbDisciplina.Text & "'"

        '                myCommand5.Connection = conn
        '                myCommand5.CommandText = SQL5
        '                myAdapter5.SelectCommand = myCommand5
        '                myAdapter5.Fill(myData5)

        '                r5 = myData5.Rows(0)
        '                nrodisciplina = r5("codigo_disc")

        '            Catch ex As Exception

        '            End Try


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
                nroturma = r2("codigo_trma")
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

        nroTurmaT = nroturma


    End Sub

    Private Sub cbDisciplina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged

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
        If tBimestre.Value = 2 Or tBimestre.Value = 4 Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
    End Sub

    Private Sub cbEJA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged

        If tBimestre.Value = 1 Or tBimestre.Value = 3 Then
            MsgBox("Atenção! Avaliação Final somente para 2º e 4º bimestre!", MsgBoxStyle.Critical, "Atenção")
            tBimestre.Enabled = True
        Else
            tBimestre.Enabled = False
            MsgBox("1 - Aprovado (na disciplina)" & vbCrLf & "3 - Retido por Freqüência Insuficiente (na disciplina)" & vbCrLf & "4 - Retido por Rendimento Insuficiente (na disciplina)", MsgBoxStyle.Information, "Informações de Situação Final")
        End If

        If cbAF.Checked = True Then
            tBimestre.Enabled = False
        Else
            tBimestre.Enabled = True
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGrade.CheckedChanged

        If cbTurma.Text = "" Then
            MsgBox("É necessário escolher uma turma!", MsgBoxStyle.Critical, "")
        Else
            '\\CHECAR SE TEM O NOME DO ALUNO
            myData6.Clear()
            '''''''''''''CARREGA INICIALMENTE''''''''''''
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            SQL6 = "SELECT * FROM " & BD_OK & ".aluno WHERE turma='" & nroturma & "'"

            Try
                conn.Open()
                Try
                    myCommand6.Connection = conn
                    myCommand6.CommandText = SQL6
                    myAdapter6.SelectCommand = myCommand6
                    myAdapter6.Fill(myData6)

                    Try
                        r6 = myData6.Rows(0)
                    Catch ex As IndexOutOfRangeException
                        MsgBox("A lista de alunos não foi localizado!", MsgBoxStyle.Critical, "Lista piloto não encontrado!")
                        conn.Close()
                        conn.Dispose()

                        cbGrade.Checked = False

                        Exit Try
                        Exit Sub

                    End Try

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

            If cbGrade.Checked = True Then
                cbDisciplina.Enabled = False
                cbDisciplina.Text = "Todas"
            Else
                cbDisciplina.Enabled = True
                cbDisciplina.Text = ""
            End If

        End If
    End Sub

    Private Sub btAdicionar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click


        Dim qtdadeaulas
        Dim minhatrava = 0
        Dim nbimestre

        If cbAF.Checked = True And tBimestre.Value = 2 Then
            nbimestre = "2AF"
        ElseIf cbAF.Checked = True And tBimestre.Value = 4 Then
            nbimestre = "4AF"
        Else
            nbimestre = tBimestre.Value
        End If

        If (cbTurma.Text <> "") Then
            If (cbDisciplina.Text = "") Then
                MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

                If cbGrade.Checked = True Then
                    minhatrava = 1
                Else
                    minhatrava = 0
                End If
            Else
                minhatrava = 1
            End If
        Else
            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)
            minhatrava = 0
        End If

        If minhatrava = 1 Then

            Dim vStrMsg As String = _
            MsgBox("Deseja iniciar alteração de boletim " & tBimestre.Value & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Atenção!")

            If vStrMsg = MsgBoxResult.Yes Then

                Dim SacarData As DateTime = DateTime.Now
                Dim data, nano

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = CONEXAOBD

                nano = CInt(tAno.Value)



                'Try
                conn.Open()
                If cbGrade.Checked = False Then
                    ' CONTINUA PARA A CONSULTA NORMAL
                    myData4.Clear()
                    SQL4 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina=" & nrodisciplina & " AND cod_bimestre='" & nbimestre & "' AND turma=" & nroturma & " AND anovigente=" & nano
                Else
                    myData4.Clear()
                    SQL4 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE cod_bimestre='" & nbimestre & "' AND turma='" & nroturma & "' AND anovigente=" & nano
                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)

                    Try
                        r4 = myData4.Rows(0)
                    Catch ex As IndexOutOfRangeException
                        MsgBox("Desculpe, o boletim não foi localizado!", MsgBoxStyle.Critical, "Boletim não encontrado!")
                        conn.Close()
                        conn.Dispose()

                        Exit Sub
                        Me.Close()
                        Me.Dispose()

                    End Try

                    ' FECHA TUDO E ABRE A NOVA JANELA COM A GRADE DE TODAS AS DISCIPLINAS
                    frmManGrade.lbTurma.Text = cbTurma.Text
                    frmManGrade.lbBimestre.Text = nbimestre
                    frmManGrade.lbAno.Text = nano
                    nroTurmaT = nroturma
                    Me.Close()
                    Me.Hide()
                    frmManGrade.Show()

                    'Exit Try
                    Exit Sub
                End If

                myCommand4.Connection = conn
                myCommand4.CommandText = SQL4
                myAdapter4.SelectCommand = myCommand4
                myAdapter4.Fill(myData4)

                Try
                    r4 = myData4.Rows(0)
                Catch ex As IndexOutOfRangeException
                    MsgBox("Desculpe, o boletim não foi localizado!", MsgBoxStyle.Critical, "Boletim não encontrado!")
                    conn.Close()
                    conn.Dispose()

                    Exit Sub
                    Me.Close()
                    Me.Dispose()

                End Try


                If r4 Is DBNull.Value Then
                    MEUBOLETIM = 1
                Else
                    MEUBOLETIM = r4("cod_nf")
                End If

                nf = r4("cod_nf")
                qtdadeaulas = r4("qtdadeaulas")

                'SE NAO FOR FUNDAMENTAL
                If fundamental = False Then

                    If tBimestre.Value = 1 Then

                        Dim Disciplina, Turma, Boletim

                        Disciplina = cbDisciplina.Text
                        Turma = cbTurma.Text
                        Boletim = tBimestre.Value

                        nroManNF = nf
                        frmManBoletim.lbDisciplina.Text = Disciplina
                        frmManBoletim.lbTurma.Text = Turma
                        frmManBoletim.lBoletim.Text = CInt(nbimestre)
                        frmManBoletim.qtdade.Text = CInt(qtdadeaulas)
                        qtdadeaulasNF = qtdadeaulas

                        Me.Close()
                        Me.Hide()

                        frmManBoletim.Show()

                    Else

                        Dim Disciplina, Turma, Boletim
                        Disciplina = cbDisciplina.Text
                        Turma = cbTurma.Text
                        Boletim = tBimestre.Value

                        nroManNF = nf
                        frmManBoletim234.lbDisciplina.Text = Disciplina
                        frmManBoletim234.lbTurma.Text = Turma
                        frmManBoletim234.lBoletim.Text = nbimestre
                        frmManBoletim234.lbNF.Text = nf
                        'frmManBoletim234.qtdade.Text = qtdadeaulas
                        qtdadeaulasNF = qtdadeaulas
                        Me.Close()
                        Me.Hide()
                        frmManBoletim234.Show()


                    End If
                End If

                'SE FOR FUNDAMENTAL
                If fundamental = True Then

                    '1o. BIMESTRE
                    If (tBimestre.Value = 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Ed. Física") Then

                        Dim Disciplina, Turma, Boletim

                        Disciplina = cbDisciplina.Text
                        Turma = cbTurma.Text
                        Boletim = tBimestre.Value

                        nroManNF = nf
                        frmManBoletim.lbDisciplina.Text = Disciplina
                        frmManBoletim.lbTurma.Text = Turma
                        frmManBoletim.lBoletim.Text = nbimestre
                        'frmManBoletim.qtdade.Text = qtdadeaulas
                        qtdadeaulasNF = qtdadeaulas
                        Me.Close()
                        Me.Hide()
                        frmManBoletim.Show()



                    ElseIf tBimestre.Value = 1 Then

                        Dim Disciplina, Turma, Boletim

                        Disciplina = cbDisciplina.Text
                        Turma = cbTurma.Text
                        Boletim = tBimestre.Value

                        nroManNF = nf
                        frmManFundamental2.lbDisciplina.Text = Disciplina
                        frmManFundamental2.lbTurma.Text = Turma
                        frmManFundamental2.lBoletim.Text = nbimestre
                        'frmManFundamental2.qtdade.Text = qtdadeaulas
                        qtdadeaulasNF = qtdadeaulas

                        Me.Close()
                        Me.Hide()
                        frmManFundamental2.Show()



                    End If

                    '2 3 4o. BIMESTRES
                    If (tBimestre.Value <> 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Ed. Física") Then

                        Dim Disciplina, Turma, Boletim

                        Disciplina = cbDisciplina.Text
                        Turma = cbTurma.Text
                        Boletim = tBimestre.Value

                        nroManNF = nf
                        frmManBoletim234.lbDisciplina.Text = Disciplina
                        frmManBoletim234.lbTurma.Text = Turma
                        frmManBoletim234.lBoletim.Text = nbimestre
                        frmManBoletim234.lbNF.Text = nf
                        'frmManBoletim234.qtdade.Text = qtdadeaulas
                        qtdadeaulasNF = qtdadeaulas

                        Me.Close()
                        Me.Hide()
                        frmManBoletim234.Show()


                    ElseIf tBimestre.Value <> 1 Then

                        Dim Disciplina, Turma, Boletim

                        Disciplina = cbDisciplina.Text
                        Turma = cbTurma.Text
                        Boletim = tBimestre.Value

                        nroManNF = nf
                        frmManFundamental2.lbDisciplina.Text = Disciplina
                        frmManFundamental2.lbTurma.Text = Turma
                        frmManFundamental2.lBoletim.Text = nbimestre
                        'frmManFundamental2.qtdade.Text = qtdadeaulas
                        qtdadeaulasNF = qtdadeaulas

                        Me.Close()
                        Me.Hide()

                        frmManFundamental2.Show()

                    End If
                End If

                conn.Close()
                conn.Dispose()

            End If
        End If



    End Sub
End Class