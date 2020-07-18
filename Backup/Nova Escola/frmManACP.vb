Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManACP

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

    Private Sub frmManACP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        myData7.Clear()
        myData4.Clear()


        If (cbTurma.Text = "" Or cbDisciplina.Text = "") Then

            MsgBox("Favor, escolher a disciplina e a turma!", MsgBoxStyle.Information)

        Else

            Dim fCadBoletim As New frmCadBoletim
            Dim vStrMsg As String = _
            MsgBox("Deseja excluir o boletim " & tBimestre.Value & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Atenção!")

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

                SQL4 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina='" & nrodisciplina & "' AND cod_bimestre=" & nbimestre & " AND turma=" & nroturma & " AND anovigente=" & tAno.Value & ""

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

                            'Dim fManAC As New frmManAC

                            'Dim Disciplina, Turma, Boletim

                            'Disciplina = cbDisciplina.Text
                            'Turma = cbTurma.Text
                            'Boletim = tBimestre.Value

                            'frmManAC.lbDisciplina.Text = Disciplina
                            'frmManAC.lbTurma.Text = Turma
                            'frmManAC.lBoletim.Text = Boletim
                            'frmManAC.lbBoletim.Text = nf
                            'frmManAC.Show()

                            SQL7 = "DELETE FROM " & BD_OK & ".notasfreq WHERE cod_nf=" & nf

                            myCommand7.Connection = conn
                            myCommand7.CommandText = SQL7
                            myAdapter7.SelectCommand = myCommand7
                            myAdapter7.Fill(myData7)

                            myData7.Clear()

                            SQL7 = "DELETE FROM " & BD_OK & ".boletim WHERE cod_boletim=" & nf

                            myCommand7.Connection = conn
                            myCommand7.CommandText = SQL7
                            myAdapter7.SelectCommand = myCommand7
                            myAdapter7.Fill(myData7)

                            MsgBox("O boletim " & tBimestre.Value & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " foi excluído com sucesso!", MsgBoxStyle.Information, "Informação")

                        Catch ex As IndexOutOfRangeException

                            MsgBox("Não existe boletim para efetuar alteração!", MsgBoxStyle.Exclamation)
                            Hide()

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

    Private Sub tBimestre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBimestre.ValueChanged

    End Sub
End Class