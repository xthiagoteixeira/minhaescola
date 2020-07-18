Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManNFsf

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

    Dim fundamental, MEUBOLETIM

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
    Dim nf




    Private Sub frmManNFsf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        Dim qtdadeaulas

        If (cbTurma.Text = "" Or cbDisciplina.Text = "") Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else

            Dim fCadBoletim As New frmCadBoletim
            Dim vStrMsg As String = _
            MsgBox("Deseja iniciar alteração de boletim " & tBimestre.Value & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Atenção!")

            If vStrMsg = MsgBoxResult.Yes Then


                Dim trava = 0

                Dim SacarData As DateTime = DateTime.Now
                Dim data

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK
                Dim nbimestre As Integer
                nbimestre = tBimestre.Value

                SQL4 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina='" & nrodisciplina & "' AND cod_bimestre='" & nbimestre & "' AND turma='" & nroturma & "' AND anovigente='" & tAno.Value & "'"

                Try
                    conn.Open()
                    Try
                        myCommand4.Connection = conn
                        myCommand4.CommandText = SQL4
                        myAdapter4.SelectCommand = myCommand4
                        myAdapter4.Fill(myData4)

                        'If r4 Is DBNull.Value Then
                        '    meuboletim = 1
                        'Else
                        '    meuboletim = r4("cod_nf")
                        'End If

                        Try
                            r4 = myData4.Rows(0)

                            nf = r4("cod_nf")
                            qtdadeaulas = r4("qtdadeaulas")


                            'If tBimestre.Value = 1 Then

                            '    Dim fManBoletim As New frmManBoletim

                            '    Dim Disciplina, Turma, Boletim, qtdade

                            '    qtdade = r4("qtdadeaulas")
                            '    Disciplina = cbDisciplina.Text
                            '    Turma = cbTurma.Text
                            '    Boletim = tBimestre.Value

                            '    frmManBoletim.lbDisciplina.Text = Disciplina
                            '    frmManBoletim.lbTurma.Text = Turma
                            '    frmManBoletim.lBoletim.Text = Boletim
                            '    frmManBoletim.qtdade.Text = qtdade
                            '    frmManBoletim.lbBoletim.Text = nf
                            '    frmManBoletim.Show()

                            'Else


                            '    Dim fManBoletim234 As New frmManBoletim234

                            '    Dim Disciplina, Turma, Boletim, qtdade

                            '    qtdade = r4("qtdadeaulas")
                            '    Disciplina = cbDisciplina.Text
                            '    Turma = cbTurma.Text
                            '    Boletim = tBimestre.Value

                            '    frmManBoletim234.lbDisciplina.Text = Disciplina
                            '    frmManBoletim234.lbTurma.Text = Turma
                            '    frmManBoletim234.lBoletim.Text = Boletim
                            '    frmManBoletim234.qtdade.Text = qtdade
                            '    frmManBoletim234.lbBoletim.Text = nf
                            '    frmManBoletim234.Show()


                            'End If



                            'SE NAO FOR FUNDAMENTAL
                            If fundamental = 0 Then

                                If tBimestre.Value = 1 Then

                                    Dim Disciplina, Turma, Boletim

                                    Disciplina = cbDisciplina.Text
                                    Turma = cbTurma.Text
                                    Boletim = tBimestre.Value

                                    frmManBoletim.lbDisciplina.Text = Disciplina
                                    frmManBoletim.lbTurma.Text = Turma
                                    frmManBoletim.lBoletim.Text = Boletim
                                    frmManBoletim.lbBoletim.Text = MEUBOLETIM
                                    frmManBoletim.qtdade.Text = qtdadeaulas
                                    frmManBoletim.Show()

                                    Me.Close()
                                    Me.Hide()

                                Else


                                    Dim Disciplina, Turma, Boletim

                                    Disciplina = cbDisciplina.Text
                                    Turma = cbTurma.Text
                                    Boletim = tBimestre.Value


                                    frmManBoletim234.lbDisciplina.Text = Disciplina
                                    frmManBoletim234.lbTurma.Text = Turma
                                    frmManBoletim234.lBoletim.Text = Boletim
                                    frmManBoletim234.lbBoletim.Text = nf
                                    frmManBoletim234.qtdade.Text = qtdadeaulas

                                    frmManBoletim234.Show()
                                    Me.Close()
                                    Me.Hide()

                                End If
                            End If

                            'SE FOR FUNDAMENTAL
                            If fundamental = 1 Then
                                '1o. BIMESTRE
                                If (tBimestre.Value = 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value = 1 And cbDisciplina.Text = "Ed. Física") Then

                                    Dim Disciplina, Turma, Boletim
                                    Disciplina = cbDisciplina.Text
                                    Turma = cbTurma.Text
                                    Boletim = tBimestre.Value

                                    frmManBoletim.lbDisciplina.Text = Disciplina
                                    frmManBoletim.lbTurma.Text = Turma
                                    frmManBoletim.lBoletim.Text = Boletim
                                    frmManBoletim.lbBoletim.Text = nf
                                    frmManBoletim.qtdade.Text = qtdadeaulas

                                    frmManBoletim.Show()

                                    Me.Close()
                                    Me.Hide()

                                ElseIf tBimestre.Value = 1 Then

                                    Dim Disciplina, Turma, Boletim

                                    Disciplina = cbDisciplina.Text
                                    Turma = cbTurma.Text
                                    Boletim = tBimestre.Value


                                    frmManFundamental.lbDisciplina.Text = Disciplina
                                    frmManFundamental.lbTurma.Text = Turma
                                    frmManFundamental.lBoletim.Text = Boletim
                                    frmManFundamental.lbBoletim.Text = nf
                                    frmManFundamental.qtdade.Text = qtdadeaulas

                                    frmManFundamental.Show()
                                    Me.Close()
                                    Me.Hide()

                                End If

                                '2 3 4o. BIMESTRES
                                If (tBimestre.Value <> 1 And cbDisciplina.Text = "Português") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Artes") Or (tBimestre.Value <> 1 And cbDisciplina.Text = "Ed. Física") Then

                                    Dim Disciplina, Turma, Boletim

                                    Disciplina = cbDisciplina.Text
                                    Turma = cbTurma.Text
                                    Boletim = tBimestre.Value


                                    frmManBoletim234.lbDisciplina.Text = Disciplina
                                    frmManBoletim234.lbTurma.Text = Turma
                                    frmManBoletim234.lBoletim.Text = Boletim
                                    frmManBoletim234.lbBoletim.Text = nf
                                    frmManBoletim234.qtdade.Text = qtdadeaulas

                                    frmManBoletim234.Show()
                                    Me.Close()
                                    Me.Hide()

                                ElseIf tBimestre.Value <> 1 Then

                                    Dim Disciplina, Turma, Boletim

                                    Disciplina = cbDisciplina.Text
                                    Turma = cbTurma.Text
                                    Boletim = tBimestre.Value


                                    'frmManBoletim.lbDisciplina.Text = Disciplina
                                    'frmManBoletim.lbTurma.Text = Turma
                                    'frmManBoletim.lBoletim.Text = Boletim
                                    'frmManBoletim.lbBoletim.Text = nf
                                    'frmManBoletim.qtdade.Text = qtdadeaulas


                                    'frmManFundamental.lbDisciplina.Text = Disciplina
                                    'frmManFundamental.lbTurma.Text = Turma
                                    'frmManFundamental.lBoletim.Text = Boletim
                                    'frmManFundamental.lbBoletim.Text = nf
                                    'frmManFundamental.qtdade.Text = qtdadeaulas

                                    frmManAlunosF.lbDisciplina.Text = Disciplina
                                    frmManAlunosF.lbTurma.Text = Turma
                                    frmManAlunosF.lBoletim.Text = Boletim
                                    frmManAlunosF.lbBoletim.Text = nf
                                    'frmManAlunos.qtdade.Text = qtdadeaulas
                                    frmManAlunosF.Show()

                                    '                                    frmManFundamental.Show()
                                    'frmManBoletim.Show()


                                    Me.Close()
                                    Me.Hide()

                                End If

                            End If




                        Catch r4 As IndexOutOfRangeException

                            MsgBox("Não existe boletim para efetuar alteração!", MsgBoxStyle.Exclamation)
                            Me.Hide()
                            Me.Close()

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
End Class