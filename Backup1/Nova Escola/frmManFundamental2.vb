Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManFundamental2

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

    Dim myCommand8 As New MySqlCommand()
    Dim myAdapter8 As New MySqlDataAdapter()
    Dim myData8 As New DataTable()
    Dim r8 As DataRow

    Dim final

    Private Sub frmManBoletim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'busca disciplina
        Dim disciplina

        disciplina = lbDisciplina.Text
        lbNF.Text = nroManNF
        '  Dim SQL6

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD


        Try
            conn.Open()
            Try
                'SQL6 = "SELECT * FROM " & BD_OK & ".disciplinas WHERE disciplina='" & disciplina & "'"

                'myCommand6.Connection = conn
                'myCommand6.CommandText = SQL6
                'myAdapter6.SelectCommand = myCommand6
                'myAdapter6.Fill(myData6)

                'r6 = myData6.Rows(0)
                'ndisciplina = r6("codigo_disc")

                'sql7 = "SELECT * FROM " & BD_OK & ".aluno WHERE disciplina='" & ndisciplina & "'"
                'myCommand7.Connection = conn
                'myCommand7.CommandText = sql7
                'myAdapter7.SelectCommand = myCommand7
                'myAdapter7.Fill(myData7)

                'r7 = myData7.Rows(0)

                'lbProfessor.Text = r7("nome")

                'lbCodigo.Value = 1

                Dim sql8
                sql8 = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim='" & nroManNF & "'"

                myCommand8.Connection = conn
                myCommand8.CommandText = sql8
                myAdapter8.SelectCommand = myCommand8
                myAdapter8.Fill(myData8)

                r8 = myData8.Rows(0)
                Dim M

                If r8("M") Is DBNull.Value Then
                    M = ""
                Else
                    M = r8("M")
                End If

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

                Else
                    tbMedia.Text = r8("M")
                End If

                If r8("S") Is DBNull.Value Then
                    tbSN.Text = ""
                Else
                    tbSN.Text = r8("S")
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

    Private Sub tbMedia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMedia.TextChanged

    End Sub

    Private Sub tbSN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSN.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btAdicionar.Focus()
        End If

    End Sub

    Private Sub tbSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSN.TextChanged

    End Sub

    Private Sub lbCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCodigo.ValueChanged

        Try

            myData4.Clear()

            '''''''''''''CARREGA INICIALMENTE''''''''''''
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try
                    SQL4 = "SELECT * FROM boletim WHERE nro_aluno='" & lbCodigo.Value & "' AND cod_boletim='" & nroManNF & "'"
                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)
                    Try
                        r4 = myData4.Rows(0)
                    Catch r4 As IndexOutOfRangeException
                        lbCodigo.Maximum = CInt(lbCodigo.Value) - 1
                        Exit Sub
                    End Try
                    tbMedia.Focus()

                    Dim M, fF, S
                    M = ""
                    fF = ""
                    S = ""

                    M = r4("M")

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
                        tbMedia.Text = M
                    End If

                    fF = r4("F")
                    S = r4("S")

                    'tbMedia.Text = M
                    ' tbFaltas.Text = fF
                    tbSN.Text = S


                Catch myerro As Exception
                    ' MsgBox("" & myerro.Message)

                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As Exception
                'MsgBox("" & myerro.Message)
            Finally
                conn.Dispose()
            End Try


        Catch myerro As Exception
            ' MsgBox("" & myerro.Message)

        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        If (tbMedia.Text = "" Or tbSN.Text = "") Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else
            If (tbSN.Text = "S" Or tbSN.Text = "N") Then

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
                        myData.Clear()

                        SQL = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim=" & nroManNF & " ORDER BY nro_aluno DESC"
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

                        End If

                        myData3.Clear()

                        SQL3 = "UPDATE " & BD_OK & ".boletim SET M='" & tbMedia.Text & "', S='" & tbSN.Text & "' WHERE cod_boletim='" & nroManNF & "' AND nro_aluno='" & lbCodigo.Value & "';"
                        atualizaMySQL(SQL3)

                        Dim cbarras
                        Dim cMedia, cSN
                        Dim sMedia

                        cMedia = tbMedia.Text

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


                        myData2.Clear()

                        'SQL2 = "INSERT INTO " & BD_OK & ".codigobarras (cod_nf, nro_aluno, descricao) values(" & lbBoletim.Text & ", " & lbCodigo.Value & ", '" & cbarras & "');"
                        ''SQL2 = "UPDATE " & BD_OK & ".codigobarras SET descricao='" & cbarras & "' WHERE cod_nf=" & lbBoletim.Text & " AND nro_aluno=" & lbCodigo.Value
                        ''myCommand2.Connection = conn
                        ''myCommand2.CommandText = SQL2
                        ''myAdapter2.SelectCommand = myCommand2
                        ''myAdapter2.Fill(myData2)

                        'MsgBox("Aluno " & lbCodigo.Value & " foi atualizado com sucesso!", MsgBoxStyle.Information, "Atualizado")
                        tbMedia.Text = ""
                        tbSN.Text = "N"

                        If (final - 1) < lbCodigo.Value Then
                            MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
                            conn.Close()
                            conn.Dispose()
                            Me.Close()
                            Me.Hide()

                            Exit Sub
                            Exit Try


                        End If

                        cidadeno = lbCodigo.Value
                        cidadeno = cidadeno + 1
                        lbCodigo.Value = cidadeno

                        myData4.Clear()

                        SQL4 = "SELECT * FROM " & BD_OK & ".boletim WHERE nro_aluno=" & lbCodigo.Value & " AND cod_boletim=" & nroManNF
                        myCommand4.Connection = conn
                        myCommand4.CommandText = SQL4
                        myAdapter4.SelectCommand = myCommand4
                        myAdapter4.Fill(myData4)
                        Try
                            r4 = myData4.Rows(0)
                            Dim M, S

                            M = r4("M")

                            S = r4("S")

                            tbMedia.Text = M
                            tbSN.Text = S

                        Catch r4 As IndexOutOfRangeException
                            MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
                            conn.Close()
                            conn.Dispose()
                            Me.Close()
                            Me.Hide()

                            Exit Sub

                        End Try

                        tbMedia.Focus()

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
        End If

    End Sub

    Private Sub btFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFinalizar.Click
        Me.Close()

    End Sub
End Class