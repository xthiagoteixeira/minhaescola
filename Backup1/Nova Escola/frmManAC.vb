Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManAC

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim r As DataRow
    Dim SQL As String

    Dim myCommand3 As New MySqlCommand()
    Dim myAdapter3 As New MySqlDataAdapter()
    Dim myData3 As New DataTable()
    Dim SQL3 As String

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()
    Dim r4 As DataRow

    Dim SQL4 As String

    Dim myCommand6 As New MySqlCommand()
    Dim myAdapter6 As New MySqlDataAdapter()
    Dim myData6 As New DataTable()
    Dim r6 As DataRow

    Dim myCommand8 As New MySqlCommand()
    Dim myAdapter8 As New MySqlDataAdapter()
    Dim myData8 As New DataTable()
    Dim r8 As DataRow

    Dim final

    Private Sub frmManAC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
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

                'sql7 = "SELECT * FROM " & BD_OK & ".aluno WHERE disciplina='" & ndisciplina & "'"
                'myCommand7.Connection = conn
                'myCommand7.CommandText = sql7
                'myAdapter7.SelectCommand = myCommand7
                'myAdapter7.Fill(myData7)

                'r7 = myData7.Rows(0)

                'lbProfessor.Text = r7("nome")

                Dim sql8
                sql8 = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim='" & lbBoletim.Text & "'"
                myCommand8.Connection = conn
                myCommand8.CommandText = sql8
                myAdapter8.SelectCommand = myCommand8
                myAdapter8.Fill(myData8)

                r8 = myData8.Rows(0)

                Dim M

                M = r8("M")

                If M = "11" Then
                    tbMedia.Text = "TR"

                ElseIf M = "12" Then
                    tbMedia.Text = "AB"

                ElseIf M = "13" Then
                    tbMedia.Text = "LS"

                ElseIf M = "14" Then
                    tbMedia.Text = "LG"

                ElseIf M = "15" Then
                    tbMedia.Text = "RE"

                ElseIf M = "16" Then
                    tbMedia.Text = "FA"

                ElseIf M = "17" Then
                    tbMedia.Text = "DI"

                ElseIf M = "18" Then
                    tbMedia.Text = "NA"

                ElseIf M = "19" Then
                    tbMedia.Text = "NC"

                Else
                    tbMedia.Text = r8("M")
                End If
                tbFaltas.Text = r8("F")
                tbSN.Text = r8("S")


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
            tbFaltas.Focus()
        End If

        If e.KeyChar = ","c Then
            e.Handled = True
            tbFaltas.Focus()
        End If


    End Sub

    Private Sub tbMedia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMedia.TextChanged

    End Sub

    Private Sub tbFaltas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbFaltas.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tbSN.Focus()
        End If

    End Sub

    Private Sub tbFaltas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFaltas.TextChanged

    End Sub

    Private Sub tbSN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSN.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btAdicionar.Focus()
        End If

    End Sub

    Private Sub tbSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSN.TextChanged

    End Sub

    Private Sub tbAC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tbSN.Focus()
        End If
    End Sub

    Private Sub tbAC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAC.TextChanged

    End Sub

    Private Sub lbCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCodigo.ValueChanged

        myData4.Clear()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                SQL4 = "SELECT * FROM " & BD_OK & ".boletim WHERE nro_aluno=" & lbCodigo.Value & " AND cod_boletim=" & lbBoletim.Text & ""
                myCommand4.Connection = conn
                myCommand4.CommandText = SQL4
                myAdapter4.SelectCommand = myCommand4
                myAdapter4.Fill(myData4)
                Try
                    r4 = myData4.Rows(0)

                Catch r4 As IndexOutOfRangeException
                    lbCodigo.Maximum = lbCodigo.Value - 1

                    'MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
                    'Me.Hide()

                    Exit Sub

                End Try


                tbAC.Focus()

                Dim M, S, AC, F


                M = r4("M")
                F = r4("F")
                AC = r4("AC")
                S = r4("S")

                If M = "11" Then
                    tbMedia.Text = "TR"

                ElseIf M = "12" Then
                    tbMedia.Text = "AB"

                ElseIf M = "13" Then
                    tbMedia.Text = "LS"

                ElseIf M = "14" Then
                    tbMedia.Text = "LG"

                ElseIf M = "15" Then
                    tbMedia.Text = "RE"

                ElseIf M = "16" Then
                    tbMedia.Text = "FA"

                ElseIf M = "17" Then
                    tbMedia.Text = "DI"

                ElseIf M = "18" Then
                    tbMedia.Text = "NA"

                ElseIf M = "19" Then
                    tbMedia.Text = "NC"

                Else
                    tbMedia.Text = r4("M")
                End If

                'tbMedia.Text = M

                tbFaltas.Text = F
                If AC Is DBNull.Value Then
                    tbAC.Text = ""
                Else
                    tbAC.Text = AC
                End If
                tbSN.Text = S



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

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click


        If tbFaltas.Text > qtdadeaulasNF Then
            MsgBox("A Falta não pode ser maior que Aulas Dadas!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If (tbMedia.Text = "" Or tbFaltas.Text = "" Or tbSN.Text = "" Or tbAC.Text = "") Then
            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else
            If (IsNumeric(tbFaltas.Text) = True) Then

                If (IsNumeric(tbAC.Text) = True) Then

                    If (tbSN.Text = "S" Or tbSN.Text = "N" Or tbSN.Text = "1" Or tbSN.Text = "3" Or tbSN.Text = "4") Then

                        Dim cidade, cidadeno

                        Dim SacarData As DateTime = DateTime.Now
                        Dim data

                        data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                        cidade = tbMedia.Text()

                        Dim conn As MySqlConnection
                        conn = New MySqlConnection()
                        conn.ConnectionString = CONEXAOBD

                        Try
                            conn.Open()
                            Try

                                SQL = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim=" & lbBoletim.Text & " ORDER BY nro_aluno DESC"
                                myCommand.Connection = conn
                                myCommand.CommandText = SQL
                                myAdapter.SelectCommand = myCommand
                                myAdapter.Fill(myData)
                                r = myData.Rows(0)
                                final = r("nro_aluno")


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

                                Dim porcentagem, F, AULAS As Integer

                                F = tbFaltas.Text
                                AULAS = qtdade.Text

                                porcentagem = ((F * 100) / AULAS)

                                SQL3 = "UPDATE " & BD_OK & ".boletim SET M=" & tbMedia.Text & ", F=" & tbFaltas.Text & ", AC=" & tbAC.Text & ", S=" & tbSN.Text & ", porcentagem=" & porcentagem & " WHERE cod_boletim=" & lbBoletim.Text & " AND nro_aluno=" & lbCodigo.Value
                                atualizaMySQL(SQL3)

                                ' Dim cbarras

                                Dim cAC, cSN, cMedia
                                Dim cFalta

                                cMedia = tbMedia.Text
                                cFalta = tbFaltas.Text
                                cAC = tbAC.Text
                                cSN = tbSN.Text

                                ''Codigo de Barras                    'Espaços a Inserir
                                'If cMedia.Length = "1" Then
                                '    sMedia = "*" & tbMedia.Text & "  "
                                'Else
                                '    sMedia = "*" & tbMedia.Text & " "
                                'End If

                                'If cFalta.Length = "1" Then
                                '    sFalta = "" & tbFaltas.Text & "  "
                                'Else
                                '    sFalta = "" & tbFaltas.Text & " "
                                'End If

                                'If cAC.Length = "1" Then
                                '    sAC = "" & tbAC.Text & " "
                                'Else
                                '    sAC = "" & tbAC.Text & ""
                                'End If

                                'If cFalta.Length = "1" Then
                                '    sFalta = "" & tbFaltas.Text & "  "
                                'Else
                                '    sFalta = "" & tbFaltas.Text & " "
                                'End If

                                'cbarras = "" & sMedia & "" & sFalta & "" & sAC & "" & tbSN.Text & "*"

                                'SQL2 = "UPDATE " & BD_OK & ".codigobarras2 SET descricao='" & cbarras & "' WHERE cod_nf=" & lbBoletim.Text & " AND nro_aluno=" & lbCodigo.Value

                                'myCommand2.Connection = conn
                                'myCommand2.CommandText = SQL2
                                'myAdapter2.SelectCommand = myCommand2
                                'myAdapter2.Fill(myData2)


                                'MsgBox("Aluno " & lbCodigo.Value & " foi atualizado com sucesso!", MsgBoxStyle.Information, "Atualizado")
                                tbMedia.Text = ""
                                tbFaltas.Text = ""
                                tbAC.Text = ""
                                tbSN.Text = "N"


                                If final < lbCodigo.Value Then
                                    MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
                                    Me.Hide()

                                    Exit Sub
                                    Exit Try


                                End If

                                cidadeno = lbCodigo.Value
                                cidadeno = cidadeno + 1
                                lbCodigo.Value = cidadeno

                                SQL4 = "SELECT * FROM " & BD_OK & ".boletim WHERE nro_aluno=" & lbCodigo.Value & " AND cod_boletim=" & lbBoletim.Text & ""
                                myCommand4.Connection = conn
                                myCommand4.CommandText = SQL4
                                myAdapter4.SelectCommand = myCommand4
                                myAdapter4.Fill(myData4)
                                Try
                                    r4 = myData4.Rows(0)

                                Catch r4 As IndexOutOfRangeException
                                    MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
                                    Me.Hide()

                                    Exit Sub

                                End Try


                                tbAC.Focus()

                                Dim M, S, AC

                                M = r4("M")
                                F = r4("F")
                                AC = r4("AC")
                                S = r4("S")

                                tbMedia.Text = M
                                tbFaltas.Text = F
                                If AC Is DBNull.Value Then
                                    tbAC.Text = ""
                                Else
                                    tbAC.Text = AC
                                End If
                                tbSN.Text = S



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
                Else
                    MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
                    tbAC.Focus()
                    Exit Sub
                End If

            Else
                MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
                tbFaltas.Focus()
                Exit Sub

            End If

        End If


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub
End Class