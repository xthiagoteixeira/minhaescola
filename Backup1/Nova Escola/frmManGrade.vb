Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManGrade

    Dim iBoletins = 0
    Dim testeMedia = 0
    Dim nroDisciplinaD = 0

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()

    End Sub

    Private Sub frmManGrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myData.Clear()
        myData2.Clear()
        myData3.Clear()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                ' // PUXA AQUI QUAIS DISCIPLINAS NO BIMESTRE FORAM CADASTRADAS
                SQL = "SELECT * FROM " & BD_OK & ".notasfreq WHERE cod_bimestre='" & lbBimestre.Text & "' AND turma=" & nroTurmaT & " AND anovigente=" & lbAno.Text

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                'r = myData.Rows(0)

                cbDisciplinas.Items.Clear()

                For Each r In myData.Rows

                    myData2.Clear()

                    Dim minhadisciplina = r("disciplina")

                    SQL2 = "SELECT disciplina FROM " & BD_OK & ".disciplinas WHERE codigo_disc=" & minhadisciplina

                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)

                    If r2("disciplina") <> "-" Then
                        cbDisciplinas.Items.Add(r2("disciplina"))
                    End If

                    iBoletins = iBoletins + 1
                Next

                lBoletins.Text = iBoletins

                '// JOGA PARA A DATAGRID
                SQL3 = "SELECT boletim.nro_aluno AS Nro, aluno.nome AS Nome, disciplinas.disciplina AS Disciplina, boletim.M AS AV, boletim.F AS FT, boletim.AC AS AC, boletim.S AS PR FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma) WHERE notasfreq.turma=" & nroTurmaT & " AND notasfreq.cod_bimestre='" & lbBimestre.Text & "' AND notasfreq.anovigente='" & lbAno.Text & "' AND aluno.anovigente='" & lbAno.Text & "' ORDER BY disciplinas.disciplina, boletim.nro_aluno ASC;"

                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)
                DGBoletim.DataSource = myData3

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

    Private Sub cbDisciplinas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplinas.SelectedIndexChanged

        LbCodigo.Text = "1"
        tbMedia.Text = ""
        tbFaltas.Text = ""
        tbAC.Text = ""
        tbSN.Text = ""

        'lbCodigo.Enabled = False
        tbMedia.Enabled = False
        tbFaltas.Enabled = False
        tbAC.Enabled = False
        tbSN.Enabled = False

        btAtualizar.Enabled = False

    End Sub

    Private Sub cbDisciplinas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDisciplinas.TextChanged

        myData3.Clear()
        myData3.Columns.Clear()
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                '// JOGA PARA A DATAGRID
                SQL3 = "SELECT boletim.nro_aluno AS Nro, aluno.nome AS Nome, disciplinas.disciplina AS Disciplina, boletim.M AS AV, boletim.F AS FT, boletim.AC AS AC, boletim.S AS PR FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma) WHERE notasfreq.turma=" & nroTurmaT & " AND notasfreq.cod_bimestre='" & lbBimestre.Text & "' AND notasfreq.anovigente='" & lbAno.Text & "' AND aluno.anovigente='" & lbAno.Text & "' AND disciplinas.disciplina='" & cbDisciplinas.Text & "' ORDER BY disciplinas.disciplina, boletim.nro_aluno ASC;"
                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)
                DGBoletim.DataSource = myData3

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            'MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub DGBoletim_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGBoletim.MouseUp

        tbMedia.Enabled = True
        tbFaltas.Enabled = True
        tbAC.Enabled = True
        tbSN.Enabled = True

        btAtualizar.Enabled = True

        rc3 = DGBoletim.CurrentRowIndex
        r3 = myData3.Rows(rc3)

        tbMedia.Text = ""
        tbFaltas.Text = ""
        tbAC.Text = ""
        tbSN.Text = ""
        btAtualizar.Enabled = True

        LbCodigo.Text = r3("Nro")

        If r3("AV") = "11" Then
            tbMedia.Text = "TR"

        ElseIf r3("AV") = "12" Then
            tbMedia.Text = "AB"

        ElseIf r3("AV") = "13" Then
            tbMedia.Text = "LS"

        ElseIf r3("AV") = "14" Then
            tbMedia.Text = "LG"

        ElseIf r3("AV") = "15" Then
            tbMedia.Text = "RE"

        ElseIf r3("AV") = "16" Then
            tbMedia.Text = "FA"

        ElseIf r3("AV") = "17" Then
            tbMedia.Text = "DI"

        ElseIf r3("AV") = "18" Then
            tbMedia.Text = "NA"

        ElseIf r3("AV") = "19" Then
            tbMedia.Text = "NC"

        Else
            tbMedia.Text = r3("AV")
        End If

        tbFaltas.Text = r3("FT")
        tbAC.Text = r3("AC")
        tbSN.Text = r3("PR")

        myData6.Clear()
        '// PUXAR O CODIGO DA DISCIPLINA
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                '// JOGA PARA A DATAGRID
                SQL6 = "SELECT * FROM disciplinas WHERE disciplina='" & r3("Disciplina") & "'"

                myCommand6.Connection = conn
                myCommand6.CommandText = SQL6
                myAdapter6.SelectCommand = myCommand6
                myAdapter6.Fill(myData6)
                r6 = myData6.Rows(0)

                nroDisciplinaD = r6("codigo_disc")

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

        '// FIM DE PUXAR O CODIGO
        'cbDisciplinas.Text = r3("Disciplina")
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click

        If (tbMedia.Text = "" Or tbFaltas.Text = "" Or tbSN.Text = "" Or tbAC.Text = "") Then
            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)
        Else

            myData.Clear()
            myData2.Clear()
            myData5.Clear()
            myData4.Clear()

            If (IsNumeric(tbFaltas.Text) = True) Then

                If (IsNumeric(tbAC.Text) = True) Then

                    If (tbSN.Text = "S" Or tbSN.Text = "N" Or tbSN.Text = "1" Or tbSN.Text = "3" Or tbSN.Text = "4") Then

                        If Not testeMedia < 20 Then

                            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

                        Else
                            Dim cidade
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

                                    SQL2 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE cod_bimestre='" & lbBimestre.Text & "' AND turma='" & nroTurmaT & "' AND anovigente=" & lbAno.Text & " AND disciplina=" & nroDisciplinaD
                                    myCommand2.Connection = conn
                                    myCommand2.CommandText = SQL2
                                    myAdapter2.SelectCommand = myCommand2
                                    myAdapter2.Fill(myData2)
                                    r2 = myData2.Rows(0)

                                    Dim porcentagem, F, AULAS, XBoletim As Integer

                                    XBoletim = r2("cod_nf")

                                    '// NECESSARIO PEGAR A QTDADE DE AULAS
                                    F = tbFaltas.Text
                                    AULAS = r2("qtdadeaulas")

                                    porcentagem = ((F * 100) / AULAS)

                                    SQL5 = "UPDATE " & BD_OK & ".boletim SET F=" & tbFaltas.Text & ", AC=" & tbAC.Text & ", M=" & tbMedia.Text & ", S='" & tbSN.Text & "', porcentagem=" & porcentagem & " WHERE cod_boletim=" & XBoletim & " AND nro_aluno=" & LbCodigo.Text
                                    atualizaMySQL(SQL5)

                                    MsgBox("Aluno " & LbCodigo.Text & " foi atualizado com sucesso!", MsgBoxStyle.Information, "Atualizado")

                                    LbCodigo.Text = "1"
                                    tbMedia.Text = ""
                                    tbAC.Text = ""
                                    tbFaltas.Text = ""
                                    tbSN.Text = ""

                                    'lbCodigo.Enabled = False
                                    tbMedia.Enabled = False
                                    tbAC.Enabled = False
                                    tbFaltas.Enabled = False
                                    tbSN.Enabled = False

                                    myData3.Clear()
                                    myData3.Columns.Clear()

                                    '// JOGA PARA A DATAGRID
                                    If cbDisciplinas.Text = "" Then
                                        '\\ PUXA TODAS
                                        SQL3 = "SELECT boletim.nro_aluno AS Nro, aluno.nome AS Nome, disciplinas.disciplina AS Disciplina, boletim.M AS AV, boletim.F AS FT, boletim.AC AS AC, boletim.S AS PR FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma) WHERE notasfreq.turma=" & nroTurmaT & " AND notasfreq.cod_bimestre='" & lbBimestre.Text & "' AND notasfreq.anovigente=" & lbAno.Text & " ORDER BY disciplinas.disciplina, boletim.nro_aluno ASC;"
                                        myCommand3.Connection = conn
                                        myCommand3.CommandText = SQL3
                                        myAdapter3.SelectCommand = myCommand3
                                        myAdapter3.Fill(myData3)
                                        DGBoletim.DataSource = myData3
                                    Else
                                        '\\ PUXA A DISCIPLINA
                                        SQL3 = "SELECT boletim.nro_aluno AS Nro, aluno.nome AS Nome, disciplinas.disciplina AS Disciplina, boletim.M AS AV, boletim.F AS FT, boletim.AC AS AC, boletim.S AS PR FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma) WHERE notasfreq.turma=" & nroTurmaT & " AND notasfreq.cod_bimestre='" & lbBimestre.Text & "' AND notasfreq.anovigente=" & lbAno.Text & " AND disciplinas.disciplina='" & cbDisciplinas.Text & "' ORDER BY boletim.nro_aluno ASC;"
                                        myCommand3.Connection = conn
                                        myCommand3.CommandText = SQL3
                                        myAdapter3.SelectCommand = myCommand3
                                        myAdapter3.Fill(myData3)
                                        DGBoletim.DataSource = myData3
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
                        End If
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

    Private Sub tbMedia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMedia.KeyPress
        If e.KeyChar = ","c Then
            e.Handled = True
            tbFaltas.Focus()
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

        ElseIf (tbMedia.Text = "NA" Or tbMedia.Text = "Na" Or tbMedia.Text = "na") Then
            testeMedia = 18

        ElseIf (tbMedia.Text = "NC" Or tbMedia.Text = "Nc" Or tbMedia.Text = "nc") Then
            testeMedia = 19

        Else

            If Not IsNumeric(tbMedia.Text) Then
                testeMedia = 98
            Else
                testeMedia = tbMedia.Text
            End If

        End If
    End Sub

    Private Sub tbFaltas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbFaltas.KeyPress
        If e.KeyChar = ","c Then
            e.Handled = True
            tbAC.Focus()
        End If
    End Sub

    Private Sub tbAC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAC.KeyPress
        If e.KeyChar = ","c Then
            e.Handled = True
            tbSN.Focus()
        End If
    End Sub
End Class