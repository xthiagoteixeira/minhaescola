Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmCadNF

    Dim turma, disciplina
    Dim turminha, disciplininha
    Dim trava = 0
    Dim fundamental

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

    Dim myCommand8 As New MySqlCommand()
    Dim myAdapter8 As New MySqlDataAdapter()
    Dim myData8 As New DataTable()
    Dim r8 As DataRow
    Dim rc8 As Integer
    Dim SQL8 As String

    Dim BD_OK, IP_OK, imagem_OK
    Dim meuboletim, EJA

    Dim estadono, buscaprofessor


    Private Sub frmCadNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")

            BD_OK = BD
            IP_OK = IP
        Catch ex As Exception
        End Try

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


        'If Not tBloqueio.Text = "0" Then

        '    'se for um professor

        '    '''''''''''''CARREGA INICIALMENTE''''''''''''
        '    Dim conn2 As MySqlConnection
        '    conn2 = New MySqlConnection()
        '    conn2.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

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

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        If Not (cbTurma.Text = "" Or cbDisciplina.Text = "") Then

            myData.Clear()
            myData2.Clear()
            myData3.Clear()
            myData4.Clear()
            myData5.Clear()

            Dim fCadBoletim As New frmCadBoletim
            Dim vStrMsg As String = _
            MsgBox("Deseja iniciar o boletim " & tBimestre.Value & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Atenção!")

            If vStrMsg = MsgBoxResult.Yes Then

                Dim SacarData As DateTime = DateTime.Now
                Dim data

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")


                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

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
                conn2.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                Try
                    conn2.Open()
                    Try
                        Dim ano, bimestre As Integer
                        ano = tAno.Value
                        bimestre = tBimestre.Value

                        SQL7 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina=" & disciplina & " AND turma=" & turma & " AND cod_bimestre=" & bimestre & " AND anovigente=" & ano
                        myCommand7.Connection = conn2
                        myCommand7.CommandText = SQL7
                        myAdapter7.SelectCommand = myCommand7
                        myAdapter7.Fill(myData7)

                        Try
                            r7 = myData7.Rows(0)
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
                    conn3.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK
                    Try
                        conn3.Open()
                        Try


                            SQL5 = "INSERT INTO " & BD_OK & ".notasfreq (turma, disciplina, cod_bimestre, qtdadeaulas, previsaoaulas, anovigente) values(" & turma & ",'" & disciplina & "', '" & tBimestre.Value & "', '" & tQtdade.Value & "', '" & pQtdade.Value & "', '" & tAno.Value & "');"
                            myCommand5.Connection = conn3
                            myCommand5.CommandText = SQL5
                            myAdapter5.SelectCommand = myCommand5
                            myAdapter5.Fill(myData5)

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

                    MsgBox("Desculpe, já existe um boletim cadastrado!", MsgBoxStyle.Critical)

                    Me.Close()
                    Me.Hide()
                    Exit Sub

                End If


                If trava = 1 Then

                    'SE NAO FOR FUNDAMENTAL
                    If fundamental = 0 Then

                        If tBimestre.Value = 1 Then

                            Dim Boletim, qtdadeaulas

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = tBimestre.Value
                            qtdadeaulas = tQtdade.Value

                            frmCadBoletim.lbDisciplina.Text = disciplina
                            frmCadBoletim.lbTurma.Text = turma
                            frmCadBoletim.lBoletim.Text = Boletim
                            frmCadBoletim.lbBoletim.Text = meuboletim
                            frmCadBoletim.qtdadeaulas.Text = qtdadeaulas

                            frmCadBoletim.Show()
                            Me.Close()
                            Me.Hide()

                        Else
                            Dim Boletim, qtdadeaulas

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = tBimestre.Value
                            qtdadeaulas = tQtdade.Value

                            frmCad234.lbDisciplina.Text = disciplina
                            frmCad234.lbTurma.Text = turma
                            frmCad234.lBoletim.Text = Boletim
                            frmCad234.lbBoletim.Text = meuboletim
                            frmCad234.qtdadeaulas.Text = qtdadeaulas
                            frmCad234.EJA.Text = EJA
                            frmCad234.Show()
                            Me.Close()
                            Me.Hide()

                        End If
                    End If

                    'SE FOR FUNDAMENTAL
                    If fundamental = 1 Then
                        '1o. BIMESTRE
                        If (tBimestre.Value = 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Ed. Física") Then

                            Dim Boletim, qtdadeaulas

                            fCadBoletim = New frmCadBoletim


                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = tBimestre.Value
                            qtdadeaulas = tQtdade.Value

                            fCadBoletim.lbDisciplina.Text = disciplina
                            fCadBoletim.lbTurma.Text = turma
                            fCadBoletim.lBoletim.Text = Boletim
                            fCadBoletim.lbBoletim.Text = meuboletim
                            fCadBoletim.qtdadeaulas.Text = qtdadeaulas

                            fCadBoletim.Show()

                            Me.Close()
                            Me.Hide()

                        ElseIf tBimestre.Value = 1 Then

                            Dim Boletim

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = tBimestre.Value
                            '   qtdadeaulas = tQtdade.Value

                            frmCadFundamental.lbDisciplina.Text = disciplina
                            frmCadFundamental.lbTurma.Text = turma
                            frmCadFundamental.lBoletim.Text = Boletim
                            frmCadFundamental.lbBoletim.Text = meuboletim
                            frmCadFundamental.Show()
                            Me.Close()
                            Me.Hide()

                        End If

                        '2 3 4o. BIMESTRES
                        If (tBimestre.Value <> 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Ed. Física") Then

                            Dim Boletim, qtdadeaulas

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = tBimestre.Value
                            qtdadeaulas = tQtdade.Value

                            frmCad234.lbDisciplina.Text = disciplina
                            frmCad234.lbTurma.Text = turma
                            frmCad234.lBoletim.Text = Boletim
                            frmCad234.lbBoletim.Text = meuboletim
                            frmCad234.qtdadeaulas.Text = qtdadeaulas
                            frmCad234.EJA.Text = EJA

                            frmCad234.Show()
                            Me.Close()
                            Me.Hide()

                        ElseIf tBimestre.Value <> 1 Then

                            Dim Boletim

                            disciplina = cbDisciplina.Text
                            turma = cbTurma.Text
                            Boletim = tBimestre.Value
                            '   qtdadeaulas = tQtdade.Value

                            frmCadFundamental.lbDisciplina.Text = disciplina
                            frmCadFundamental.lbTurma.Text = turma
                            frmCadFundamental.lBoletim.Text = Boletim
                            frmCadFundamental.lbBoletim.Text = meuboletim

                            frmCadFundamental.Show()
                            Me.Close()
                            Me.Hide()

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
        conn2.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

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

    Private Sub cbEJA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEJA.CheckedChanged
        If cbEJA.Checked = True Then
            tBimestre.Value = 3
            tBimestre.Enabled = False
            EJA = "V"
        Else
            tBimestre.Value = 1
            tBimestre.Enabled = True
            EJA = "F"
        End If
    End Sub
End Class