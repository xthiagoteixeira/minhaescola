Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManAF

    Dim myCommand6 As New MySqlCommand()
    Dim myAdapter6 As New MySqlDataAdapter()
    Dim myData6 As New DataTable()
    Dim r6 As DataRow

    Private Sub frmManBoletim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

                ''Dim sql8
                ''sql8 = "SELECT * FROM " & BD_OK & ".avaliacaofinal WHERE cod_nf='" & lbBoletim.Text & "' AND nro_aluno=" & lbCodigo.Value & ""
                ''myCommand8.Connection = conn
                ''myCommand8.CommandText = sql8
                ''myAdapter8.SelectCommand = myCommand8
                ''myAdapter8.Fill(myData8)

                ''r8 = myData8.Rows(0)
                ''Dim M
                ''If r8("M") Is DBNull.Value Then
                ''    M = ""
                ''Else

                ''    M = r8("M")
                ''End If

                ''If M = "11" Then
                ''    tbMedia.Text = "TR"

                ''ElseIf M = "12" Then
                ''    tbMedia.Text = "AB"

                ''ElseIf M = "13" Then
                ''    tbMedia.Text = "LS"

                ''ElseIf M = "14" Then
                ''    tbMedia.Text = "LG"

                ''ElseIf M = "15" Then
                ''    tbMedia.Text = "RE"

                ''ElseIf M = "16" Then
                ''    tbMedia.Text = "FA"

                ''ElseIf M = "17" Then
                ''    tbMedia.Text = "DI"
                ''Else
                ''    tbMedia.Text = r8("M")
                ''End If

                ''If r8("S") Is DBNull.Value Then
                ''    tbSN.Text = ""
                ''Else

                ''    tbSN.Text = r8("S")
                ''End If

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
        ''myData4.Clear()

        '''''''''''''''CARREGA INICIALMENTE''''''''''''
        ''Dim conn As MySqlConnection
        ''conn = New MySqlConnection()
        ''conn.ConnectionString = CONEXAOBD

        ''Try
        ''    conn.Open()
        ''    Try

        ''        SQL4 = "SELECT * FROM " & BD_OK & ".avaliacaofinal WHERE nro_aluno='" & lbCodigo.Value & "' AND cod_nf='" & lbBoletim.Text & "'"
        ''        myCommand4.Connection = conn
        ''        myCommand4.CommandText = SQL4
        ''        myAdapter4.SelectCommand = myCommand4
        ''        myAdapter4.Fill(myData4)
        ''        Try
        ''            r4 = myData4.Rows(0)

        ''        Catch r4 As IndexOutOfRangeException
        ''            lbCodigo.Maximum = lbCodigo.Value - 1


        ''            'MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
        ''            'Me.Hide()

        ''            Exit Sub

        ''        End Try


        ''        tbMedia.Focus()

        ''        Dim M, S

        ''        M = r4("M")

        ''        If M = "11" Then
        ''            tbMedia.Text = "TR"

        ''        ElseIf M = "12" Then
        ''            tbMedia.Text = "AB"

        ''        ElseIf M = "13" Then
        ''            tbMedia.Text = "LS"

        ''        ElseIf M = "14" Then
        ''            tbMedia.Text = "LG"

        ''        ElseIf M = "15" Then
        ''            tbMedia.Text = "RE"

        ''        ElseIf M = "16" Then
        ''            tbMedia.Text = "FA"

        ''        ElseIf M = "17" Then
        ''            tbMedia.Text = "DI"

        ''        Else
        ''            tbMedia.Text = r4("M")
        ''        End If

        ''        S = r4("S")

        ''        ' tbMedia.Text = M

        ''        If S <> "0" Then
        ''            tbSN.Text = S
        ''        Else
        ''            tbSN.Text = "N"
        ''        End If



        ''    Catch myerro As MySqlException
        ''        MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
        ''    End Try
        ''    '           MessageBox.Show("Conexão aberta com sucesso")
        ''    conn.Close()
        ''Catch myerro As MySqlException
        ''    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        ''Finally
        ''    conn.Dispose()
        ''End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click


        ''If (tbMedia.Text = "" Or tbSN.Text = "") Then

        ''    MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        ''Else

        ''    If (tbSN.Text = "S" Or tbSN.Text = "N") Then

        ''        Dim cidade, cidadeno
        ''        Dim trava = 0

        ''        Dim SacarData As DateTime = DateTime.Now
        ''        Dim data

        ''        data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

        ''        cidade = tbMedia.Text()

        ''        Dim conn As MySqlConnection
        ''        conn = New MySqlConnection()
        ''        conn.ConnectionString = CONEXAOBD

        ''        Try
        ''            conn.Open()
        ''            Try

        ''                SQL = "SELECT * FROM " & BD_OK & ".avaliacaofinal WHERE cod_nf=" & lbBoletim.Text & " ORDER BY nro_aluno DESC"
        ''                myCommand.Connection = conn
        ''                myCommand.CommandText = SQL
        ''                myAdapter.SelectCommand = myCommand
        ''                myAdapter.Fill(myData)
        ''                r = myData.Rows(0)
        ''                final = r("nro_aluno")

        ''                If tbMedia.Text = "TR" Or tbMedia.Text = "Tr" Or tbMedia.Text = "tr" Then
        ''                    tbMedia.Text = "11"

        ''                ElseIf tbMedia.Text = "AB" Or tbMedia.Text = "Ab" Or tbMedia.Text = "ab" Then
        ''                    tbMedia.Text = "12"

        ''                ElseIf tbMedia.Text = "LS" Or tbMedia.Text = "Ls" Or tbMedia.Text = "ls" Then
        ''                    tbMedia.Text = "13"

        ''                ElseIf tbMedia.Text = "LG" Or tbMedia.Text = "Lg" Or tbMedia.Text = "lg" Then
        ''                    tbMedia.Text = "14"

        ''                ElseIf tbMedia.Text = "RE" Or tbMedia.Text = "Re" Or tbMedia.Text = "re" Then
        ''                    tbMedia.Text = "15"

        ''                ElseIf tbMedia.Text = "FA" Or tbMedia.Text = "Fa" Or tbMedia.Text = "fa" Then
        ''                    tbMedia.Text = "16"

        ''                ElseIf tbMedia.Text = "DI" Or tbMedia.Text = "Di" Or tbMedia.Text = "di" Then
        ''                    tbMedia.Text = "17"

        ' ElseIf tbMedia.Text = "NA" Or tbMedia.Text = "Na" Or tbMedia.Text = "na" Then
        'tbMedia.Text = "18"


        ''                End If

        ''                'SQL3 = "INSERT INTO " & BD_OK & ".boletim (cod_boletim, nro_aluno, M, F, S) values(" & lbBoletim.Text & "," & lbCodigo.Value & ", '" & tbMedia.Text & "', " & tbFaltas.Text & ", '" & tbSN.Text & "');"
        ''                SQL3 = "UPDATE " & BD_OK & ".avaliacaofinal SET M='" & tbMedia.Text & "', S='" & tbSN.Text & "' WHERE cod_nf='" & lbBoletim.Text & "' AND nro_aluno='" & lbCodigo.Value & "';"

        ''                myCommand3.Connection = conn
        ''                myCommand3.CommandText = SQL3
        ''                myAdapter3.SelectCommand = myCommand3
        ''                myAdapter3.Fill(myData3)


        ''                Dim cbarras

        ''                Dim cMedia, cSN
        ''                Dim sMedia

        ''                cMedia = tbMedia.Text

        ''                cSN = tbSN.Text

        ''                'Codigo de Barras                    'Espaços a Inserir
        ''                If cMedia.Length = "1" Then
        ''                    sMedia = "*" & tbMedia.Text & "  "
        ''                Else
        ''                    sMedia = "*" & tbMedia.Text & " "
        ''                End If

        ''                'If cFalta.Length = "1" Then
        ''                '    sFalta = "" & tbFaltas.Text & "  "
        ''                'Else
        ''                '    sFalta = "" & tbFaltas.Text & " "
        ''                'End If

        ''                cbarras = "" & sMedia & "" & tbSN.Text & "*"


        ''                'SQL2 = "INSERT INTO " & BD_OK & ".codigobarras (cod_nf, nro_aluno, descricao) values(" & lbBoletim.Text & ", " & lbCodigo.Value & ", '" & cbarras & "');"
        ''                ''SQL2 = "UPDATE " & BD_OK & ".avaliacaofinal SET descricao='" & cbarras & "' WHERE cod_nf=" & lbBoletim.Text & " AND nro_aluno=" & lbCodigo.Value

        ''                ''myCommand2.Connection = conn
        ''                ''myCommand2.CommandText = SQL2
        ''                ''myAdapter2.SelectCommand = myCommand2
        ''                ''myAdapter2.Fill(myData2)

        ''                'MsgBox("Aluno " & lbCodigo.Value & " foi atualizado com sucesso!", MsgBoxStyle.Information, "Atualizado")
        ''                tbMedia.Text = ""
        ''                tbSN.Text = "N"

        ''                If final = lbCodigo.Value Then
        ''                    MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
        ''                    Me.Hide()

        ''                    Exit Sub
        ''                    Exit Try


        ''                End If

        ''                myData4.Clear()

        ''                cidadeno = lbCodigo.Value
        ''                cidadeno = cidadeno + 1
        ''                lbCodigo.Value = cidadeno

        ''                ''SQL4 = "SELECT * FROM " & BD_OK & ".avaliacaofinal WHERE nro_aluno='" & lbCodigo.Value & "' AND cod_nf='" & lbBoletim.Text & "'"
        ''                ''myCommand4.Connection = conn
        ''                ''myCommand4.CommandText = SQL4
        ''                ''myAdapter4.SelectCommand = myCommand4
        ''                ''myAdapter4.Fill(myData4)
        ''                ''Try
        ''                ''    r4 = myData4.Rows(0)

        ''                ''Catch r4 As IndexOutOfRangeException
        ''                ''    MsgBox("Finalizado as alterações!", MsgBoxStyle.Critical, "Alteração")
        ''                ''    Me.Hide()

        ''                ''    Exit Sub

        ''                ''End Try


        ''                tbMedia.Focus()

        ''                Dim M, S

        ''                M = r4("M")

        ''                S = r4("S")

        ''                tbMedia.Text = M

        ''                If S <> "0" Then
        ''                    tbSN.Text = S
        ''                Else
        ''                    tbSN.Text = "N"
        ''                End If



        ''            Catch myerro As MySqlException
        ''                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
        ''            End Try
        ''            '           MessageBox.Show("Conexão aberta com sucesso")
        ''            conn.Close()

        ''        Catch myerro As MySqlException
        ''            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        ''        Finally
        ''            conn.Dispose()
        ''        End Try
        ''        ' FIM DA CONEXAO
        ''    Else
        ''        MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
        ''        tbSN.Focus()
        ''        Exit Sub

        ''    End If
        ''End If


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFinalizar.Click

        Me.Close()

    End Sub
End Class