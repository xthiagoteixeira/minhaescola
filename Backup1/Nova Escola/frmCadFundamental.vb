Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmCadFundamental

    Dim myCommand3 As New MySqlCommand()
    Dim myAdapter3 As New MySqlDataAdapter()
    Dim myData3 As New DataTable()
    Dim SQL3 As String

    Dim myCommand6 As New MySqlCommand()
    Dim myAdapter6 As New MySqlDataAdapter()
    Dim myData6 As New DataTable()
    Dim r6 As DataRow
    
    Dim myCommand7 As New MySqlCommand()
    Dim myAdapter7 As New MySqlDataAdapter()
    Dim myData7 As New DataTable()
    Dim r7 As DataRow
    Dim sql7

    Dim FINAL, testeMedia

    Public Shared fManBoletimALT As New frmManBoletimALT

    Private Sub frmCadBoletim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'busca disciplina
        Dim disciplina, ndisciplina

        disciplina = lbDisciplina.Text

        Dim SQL6

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

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


                If travaC.Text = 1 Then

                    sql7 = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim=" & lbBoletim.Text & " ORDER BY nro_aluno DESC"
                    myCommand7.Connection = conn
                    myCommand7.CommandText = sql7
                    myAdapter7.SelectCommand = myCommand7
                    myAdapter7.Fill(myData7)

                    r7 = myData7.Rows(0)

                    lbCodigo.Text = r7("nro_aluno")
                    lbCodigo.Text = lbCodigo.Text + 1

                End If

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

        If e.KeyChar = ","c Then
            e.Handled = True
            tbSN.Focus()
        End If

    End Sub

    Private Sub tbMedia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbMedia.LostFocus
        If (tbMedia.Text = "TR" Or tbMedia.Text = "Tr" Or tbMedia.Text = "tr") Then
            testeMedia = 11

        ElseIf (tbMedia.Text = "AB" Or tbMedia.Text = "Ab" Or tbMedia.Text = "ab") Then
            testeMedia = 12

        ElseIf (tbMedia.Text = "LS" Or tbMedia.Text = "Ls" Or tbMedia.Text = "ls") Then
            testeMedia = 13

        ElseIf (tbMedia.Text = "LG" Or tbMedia.Text = "Lg" Or tbMedia.Text = "lg") Then
            testeMedia = 14

        ElseIf (tbMedia.Text = "RE" Or tbMedia.Text = "Re" Or tbMedia.Text = "re") Then
            testeMedia = 15

        ElseIf (tbMedia.Text = "FA" Or tbMedia.Text = "Fa" Or tbMedia.Text = "fa") Then
            testeMedia = 16

        ElseIf (tbMedia.Text = "DI" Or tbMedia.Text = "Di" Or tbMedia.Text = "di") Then
            testeMedia = 17

        ElseIf tbMedia.Text = "NA" Or tbMedia.Text = "Na" Or tbMedia.Text = "na" Then
            testeMedia = 18

        ElseIf tbMedia.Text = "NC" Or tbMedia.Text = "Nc" Or tbMedia.Text = "nc" Then
            testeMedia = 19

        Else

            If Not IsNumeric(tbMedia.Text) Then
                testeMedia = 98
            Else
                testeMedia = tbMedia.Text
            End If

        End If
    End Sub

    Private Sub tbMedia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMedia.TextChanged
        If tbMedia.Text <> "" Then
            btAdicionar.Enabled = False
            btAdicionar.Enabled = True
        Else
            btAdicionar.Enabled = True
            btAdicionar.Enabled = False
        End If

    End Sub

    Private Sub tbSN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSN.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btAdicionar.Focus()
        End If

    End Sub

    Private Sub tbSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSN.TextChanged

    End Sub

    Private Sub lbCodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCodigo.TextChanged
        If lbCodigo.Text > "2" Or lbCodigo.Text > "02" Then
            btVoltar.Enabled = True
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''
        '''' PUXA OS ALUNOS TRANSFERIDOS, ABANDONADOS...
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim status = ""

        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                myData8.Clear()
                ''''' turma esta em branco, verificar... e tbm o ano!
                SQL8 = "SELECT anovigente, status, turma, nro FROM " & BD_OK & ".aluno WHERE turma=" & nroTurmaAluno & " AND nro=" & lbCodigo.Text & " AND anovigente='" & AnoVigenteNF & "';"
                myCommand8.Connection = conn
                myCommand8.CommandText = SQL8
                myAdapter8.SelectCommand = myCommand8
                myAdapter8.Fill(myData8)

                Try
                    r8 = myData8.Rows(0)
                    status = r8("status")
                Catch ex As Exception

                End Try


                If (status = "TR" Or status = "Tr" Or status = "tr") Then
                    tbMedia.Text = "TR"
                    'tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    'tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                ElseIf (status = "AB" Or status = "Ab" Or status = "ab") Then
                    tbMedia.Text = "AB"
                    'tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    'tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                ElseIf (status = "LS" Or status = "Ls" Or status = "ls") Then
                    tbMedia.Text = "LS"
                    'tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    'tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                ElseIf (status = "LG" Or status = "Lg" Or status = "lg") Then
                    tbMedia.Text = "LG"
                    'tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    'tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                ElseIf (status = "RE" Or status = "Re" Or status = "re") Then
                    tbMedia.Text = "RE"
                    'tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    'tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                ElseIf (status = "FA" Or status = "Fa" Or status = "fa") Then
                    tbMedia.Text = "FA"
                    ' tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    'tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                ElseIf (status = "DI" Or status = "Di" Or status = "di") Then
                    tbMedia.Text = "DI"
                    'tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    'tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                ElseIf (status = "NA" Or status = "Na" Or status = "na") Then
                    tbMedia.Text = "NA"
                    ' tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    ' tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                ElseIf (status = "NC" Or status = "Nc" Or status = "nc") Then
                    tbMedia.Text = "NC"
                    ' tbFaltas.Text = "0"
                    'tbAC.Text = "0"
                    tbSN.Text = "S"
                    tbMedia.Enabled = False
                    '  tbFaltas.Enabled = False
                    'tbAC.Enabled = False
                    tbSN.Enabled = False
                    btAdicionar.Focus()

                Else
                    tbMedia.Text = ""
                    'tbFaltas.Text = ""
                    'tbAC.Text = ""
                    tbSN.Text = "N"
                    tbMedia.Enabled = True
                    ' tbFaltas.Enabled = True
                    'tbAC.Enabled = True
                    tbSN.Enabled = True

                End If

            Catch myerro As MySqlException
                'MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

        ''''''''''''''''''''''''''''''' FIM
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        If (tbMedia.Text = "" Or tbSN.Text = "") Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else

            If (tbSN.Text = "S" Or tbSN.Text = "N") Then

                If Not testeMedia < 20 Then

                    MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

                Else

                    Dim cidade
                    Dim cidadeno = 0

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
                    conn.ConnectionString = CONEXAOBD

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

                            ElseIf tbMedia.Text = "DI" Or tbMedia.Text = "Di" Or tbMedia.Text = "di" Then
                                tbMedia.Text = "17"

                            ElseIf tbMedia.Text = "NA" Or tbMedia.Text = "Na" Or tbMedia.Text = "na" Then
                                tbMedia.Text = "18"

                            ElseIf tbMedia.Text = "NC" Or tbMedia.Text = "Nc" Or tbMedia.Text = "nc" Then
                                tbMedia.Text = "19"

                            End If

                            SQL3 = "INSERT INTO " & BD_OK & ".boletim (cod_boletim, nro_aluno, M, S) values (" & lbBoletim.Text & "," & lbCodigo.Text & ", '" & tbMedia.Text & "', '" & tbSN.Text & "')"
                            atualizaMySQL(SQL3)

                            'Dim cbarras
                            Dim cMedia, cSN
                            'Dim sMedia

                            cMedia = tbMedia.Text
                            '  cFalta = tbFaltas.Text
                            cSN = tbSN.Text

                            ''Codigo de Barras                    'Espaços a Inserir
                            'If cMedia.Length = "1" Then
                            '    sMedia = "*" & tbMedia.Text & "  "
                            'Else
                            '    sMedia = "*" & tbMedia.Text & " "
                            'End If

                            ''If cFalta.Length = "1" Then
                            ''    sFalta = "" & tbFaltas.Text & "  "
                            ''Else
                            ''    sFalta = "" & tbFaltas.Text & " "
                            ''End If

                            'cbarras = "" & sMedia & "" & tbSN.Text & "*"

                            'SQL2 = "INSERT INTO " & BD_OK & ".codigobarras (cod_nf, nro_aluno, descricao) values(" & lbBoletim.Text & ", " & lbCodigo.Text & ", '" & cbarras & "');"
                            'myCommand2.Connection = conn
                            'myCommand2.CommandText = SQL2
                            'myAdapter2.SelectCommand = myCommand2
                            'myAdapter2.Fill(myData2)

                            'MsgBox("Aluno " & lbCodigo.Text & " foi cadastrado com sucesso!", MsgBoxStyle.Information, "Cadastrado")
                            tbMedia.Text = ""
                            ' tbFaltas.Text = ""
                            tbSN.Text = "N"

                            'If lBoletim.Text = "4" Then


                            '    SQL5 = "INSERT INTO " & BD_OK & ".avaliacaofinal (cod_nf, nro_aluno) values(" & lbBoletim.Text & ", " & lbCodigo.Text & ");"
                            '    myCommand5.Connection = conn
                            '    myCommand5.CommandText = SQL5
                            '    myAdapter5.SelectCommand = myCommand5
                            '    myAdapter5.Fill(myData5)

                            'End If

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
                End If

                ' FIM DA CONEXAO
            Else
                MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
                tbSN.Focus()
                Exit Sub

            End If

            tbMedia.Focus()
        End If

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVoltar.Click

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

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFinalizar.Click

        If lbCodigo.Text = "1" Then
            MsgBox("É necessário cadastrar pelo menos um aluno neste boletim!", MsgBoxStyle.Exclamation)
            tbMedia.Focus()
            Exit Sub
        End If

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
            Me.Hide()
            Me.Close()
            fManBoletimALT.Show()


        Else

            Me.Hide()
            Me.Close()
        End If


    End Sub

End Class