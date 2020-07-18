Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmCadFundamental

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
    Dim myCommand6 As New MySqlCommand()
    Dim myAdapter6 As New MySqlDataAdapter()
    Dim myData6 As New DataTable()

    Dim r6 As DataRow
    Dim rc6 As Integer
    Dim myCommand7 As New MySqlCommand()
    Dim myAdapter7 As New MySqlDataAdapter()
    Dim myData7 As New DataTable()

    Dim r7 As DataRow
    Dim rc7 As Integer
    Dim BD_OK, IP_OK, imagem_OK

    Dim SQL5 As String
    Dim estadono, FINAL

    Public Shared fManBoletimALT As New frmManBoletimALT


    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        If (tbMedia.Text = "" Or tbSN.Text = "") Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else

            If (tbSN.Text = "S" Or tbSN.Text = "N") Then

                Dim cidade
                Dim cidadeno = 0
                Dim trava = 0

                Dim SacarData As DateTime = DateTime.Now
                Dim data

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                myData.Clear()
                myData2.Clear()
                myData3.Clear()
                myData4.Clear()

                cidade = tbMedia.Text()

                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                Try
                    conn.Open()
                    Try



                        'F = tbFaltas.Text
                        ' AULAS = qtdadeaulas.Text

                        ' porcentagem = ((F * 100) / AULAS)
                        'MsgBox("" & porcentagem)


                        If tbMedia.Text = "TR" Or tbMedia.Text = "Tr" Or tbMedia.Text = "tr" Then
                            tbMedia.Text = "11"

                        ElseIf tbMedia.Text = "AB" Or tbMedia.Text = "Ab" Or tbMedia.Text = "ab" Then
                            tbMedia.Text = "12"

                        ElseIf tbMedia.Text = "LS" Or tbMedia.Text = "Ls" Or tbMedia.Text = "ls" Then
                            tbMedia.Text = "13"

                        ElseIf tbMedia.Text = "LG" Or tbMedia.Text = "Lg" Or tbMedia.Text = "lg" Then
                            tbMedia.Text = "14"

                        ElseIf tbMedia.Text = "RE" Or tbMedia.Text = "Re" Or tbMedia.Text = "re" Then
                            tbMedia.Text = "15"

                        ElseIf tbMedia.Text = "FA" Or tbMedia.Text = "Fa" Or tbMedia.Text = "fa" Then
                            tbMedia.Text = "16"
                        End If

                        SQL3 = "INSERT INTO " & BD_OK & ".boletim (cod_boletim, nro_aluno, M, S) values (" & lbBoletim.Text & "," & lbCodigo.Text & ", '" & tbMedia.Text & "', '" & tbSN.Text & "')"
                        myCommand3.Connection = conn
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)

                        Dim cbarras
                        Dim cMedia, cSN
                        Dim sMedia

                        cMedia = tbMedia.Text
                        '  cFalta = tbFaltas.Text
                        cSN = tbSN.Text

                        'Codigo de Barras                    'Espaços a Inserir
                        If cMedia.Length = "1" Then
                            sMedia = "*" & tbMedia.Text & "  "
                        Else
                            sMedia = "*" & tbMedia.Text & " "
                        End If

                        'If cFalta.Length = "1" Then
                        '    sFalta = "" & tbFaltas.Text & "  "
                        'Else
                        '    sFalta = "" & tbFaltas.Text & " "
                        'End If

                        cbarras = "" & sMedia & "" & tbSN.Text & "*"

                        SQL2 = "INSERT INTO " & BD_OK & ".codigobarras (cod_nf, nro_aluno, descricao) values(" & lbBoletim.Text & ", " & lbCodigo.Text & ", '" & cbarras & "');"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        'MsgBox("Aluno " & lbCodigo.Text & " foi cadastrado com sucesso!", MsgBoxStyle.Information, "Cadastrado")
                        tbMedia.Text = ""
                        ' tbFaltas.Text = ""
                        tbSN.Text = "N"

                        If lBoletim.Text = "4" Then


                            SQL5 = "INSERT INTO " & BD_OK & ".avaliacaofinal (cod_nf, nro_aluno) values(" & lbBoletim.Text & ", " & lbCodigo.Text & ");"
                            myCommand5.Connection = conn
                            myCommand5.CommandText = SQL5
                            myAdapter5.SelectCommand = myCommand5
                            myAdapter5.Fill(myData5)

                        End If

                        If FINAL = lbCodigo.Text Then
                            MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
                            Me.Hide()
                            Me.Close()

                            Exit Sub
                            Exit Try
                        End If

                        cidadeno = lbCodigo.Text
                        cidadeno = cidadeno + 1
                        lbCodigo.Text = cidadeno

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
                ' FIM DA CONEXAO
            Else
                MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
                tbSN.Focus()
                Exit Sub

            End If

            tbMedia.Focus()
        End If


    End Sub

    Private Sub frmCadBoletim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim disciplina, ndisciplina

        disciplina = lbDisciplina.Text

        Dim SQL6

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        SQL6 = "SELECT * FROM " & BD_OK & ".disciplinas WHERE disciplina='" & disciplina & "'"

        Try
            conn.Open()
            Try

                myCommand6.Connection = conn
                myCommand6.CommandText = SQL6
                myAdapter6.SelectCommand = myCommand6
                myAdapter6.Fill(myData6)

                r6 = myData6.Rows(0)
                ndisciplina = r6("codigo_disc")


                'sql7 = "SELECT * FROM " & BD_OK & ".aluno WHERE disciplina='" & ndisciplina & "'"
                'myCommand7.Connection = conn
                'myCommand7.CommandText = sql7
                'myAdapter7.SelectCommand = myCommand7
                'myAdapter7.Fill(myData7)

                'r7 = myData7.Rows(0)

                ''lbProfessor.Text = r7("nome")

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

    Private Sub tbMedia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMedia.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tbSN.Focus()
        End If

    End Sub

    Private Sub tbMedia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMedia.TextChanged
        If tbMedia.Text <> "" Then
            Button1.Enabled = False
            btAdicionar.Enabled = True
        Else
            Button1.Enabled = True
            btAdicionar.Enabled = False
        End If
    End Sub

    Private Sub tbFaltas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
  
    End Sub

    Private Sub tbFaltas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbSN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSN.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btAdicionar.Focus()
        End If

    End Sub

    Private Sub tbSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSN.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If exibeR.Checked = True Then
            fManBoletimALT = New frmManBoletimALT

            fManBoletimALT.Height = "261"
            fManBoletimALT.Width = "502"

            fManBoletimALT.XBoletim.Text = lbBoletim.Text
            fManBoletimALT.lbDisciplina.Text = lbDisciplina.Text
            fManBoletimALT.lbTurma.Text = lbTurma.Text
            fManBoletimALT.lBoletim.Text = lBoletim.Text

            fManBoletimALT.Text = "" & lbTurma.Text & " - " & lbDisciplina.Text & " : " & lBoletim.Text & "o. Bimestre"
            fManBoletimALT.tbMedia.Enabled = False
            fManBoletimALT.tbFaltas.Enabled = False
            fManBoletimALT.tbSN.Enabled = False
            fManBoletimALT.btAdicionar.Visible = False

            fManBoletimALT.Show()
            Me.Hide()
            Me.Close()

        Else

            Me.Hide()
            Me.Close()
        End If


    End Sub

    Private Sub btVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVoltar.Click

        fManBoletimALT = New frmManBoletimALT

        fManBoletimALT.XBoletim.Text = lbBoletim.Text
        fManBoletimALT.lbDisciplina.Text = lbDisciplina.Text
        fManBoletimALT.lbTurma.Text = lbTurma.Text
        fManBoletimALT.lBoletim.Text = lBoletim.Text
        fManBoletimALT.qtdadeaulas.Text = qtdadeaulas.Text

        fManBoletimALT.tbMedia.Enabled = True
        fManBoletimALT.tbFaltas.Enabled = False
        fManBoletimALT.tbAC.Enabled = False
        fManBoletimALT.tbSN.Enabled = True
        fManBoletimALT.btAdicionarFUN.Visible = True

        fManBoletimALT.Show()

    End Sub

    Private Sub lbCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCodigo.Click

    End Sub

    Private Sub lbCodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCodigo.TextChanged
        If lbCodigo.Text > "2" Or lbCodigo.Text > "02" Then
            btVoltar.Enabled = True
        End If
    End Sub
End Class