Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data

Public Class frmManUltimoAluno

    Dim nroturma, nrodisciplina
    Dim testeAF, nf

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()

    End Sub

    Private Sub frmManUltimoAluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

        myData.Clear()
        myData2.Clear()

        'busca disciplina
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                SQL = "SELECT * FROM disciplinas ORDER BY disciplina"
                SQL2 = "SELECT * FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"

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

    End Sub

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData2.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''

        Dim conn2 As MySqlConnection

        conn2 = New MySqlConnection()
        conn2.ConnectionString = CONEXAOBD

        SQL2 = "SELECT codigo_trma FROM turma WHERE classe='" & cbTurma.Text & "'"
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

                nroDisciplina = r5("codigo_disc")

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

        If (tBimestre.Value = 1) Or (tBimestre.Value = 3) Then
            cbAF.Enabled = False
        Else
            cbAF.Enabled = True
        End If

        If (tBimestre.Value = 2 And cbAF.Checked = True) Or (tBimestre.Value = 4 And cbAF.Checked = True) Then
            tBimestre.Enabled = False
        Else
            tBimestre.Enabled = True
        End If

    End Sub

    Private Sub cbAF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged
        If cbAF.Checked = True Then
            tBimestre.Enabled = False
        Else
            tBimestre.Enabled = True
        End If
    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click

        If tBimestre.Value = 2 And cbAF.Checked = True Then
            testeAF = "2AF"
        ElseIf tBimestre.Value = 4 And cbAF.Checked = True Then
            testeAF = "4AF"
        Else
            testeAF = tBimestre.Value
        End If


        myData7.Clear()
        myData4.Clear()


        If (cbTurma.Text <> "") Then

            If cbDisciplina.Text = "" Then

                MsgBox("Favor, escolher a disciplina e a turma!", MsgBoxStyle.Information)

            Else

                Dim vStrMsg As String = _
                MsgBox("Deseja excluir o último aluno do: " & testeAF & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Atenção!")

                If vStrMsg = MsgBoxResult.Yes Then

                    Dim SacarData As DateTime = DateTime.Now
                    Dim data

                    data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD
                    Dim nbimestre As Integer

                    nbimestre = tBimestre.Value

                    SQL4 = "SELECT * FROM notasfreq WHERE disciplina='" & nrodisciplina & "' AND cod_bimestre=" & testeAF & " AND turma=" & nroturma & " AND anovigente=" & tAno.Value & ""

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

                                SQL7 = "DELETE FROM boletim WHERE cod_boletim=" & nf & " AND nro_aluno=" & LbCodigo.Text

                                myCommand7.Connection = conn
                                myCommand7.CommandText = SQL7
                                myAdapter7.SelectCommand = myCommand7
                                myAdapter7.Fill(myData7)

                                'myData7.Clear()

                                'SQL7 = "DELETE FROM " & BD_OK & ".boletim WHERE cod_boletim=" & nf
                                'myCommand7.Connection = conn
                                'myCommand7.CommandText = SQL7
                                'myAdapter7.SelectCommand = myCommand7
                                'myAdapter7.Fill(myData7)

                                Me.Size = New System.Drawing.Size(357, 175)
                                MsgBox("O último aluno do boletim " & testeAF & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " foi excluído com sucesso!", MsgBoxStyle.Information, "Informação")

                            Catch ex As IndexOutOfRangeException

                                MsgBox("Não existe boletim cadastrado!", MsgBoxStyle.Exclamation)
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

        Else

            MsgBox("Favor, escolher a disciplina e a turma!", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConsultar.Click

        If tBimestre.Value = 2 And cbAF.Checked = True Then
            testeAF = "2AF"
        ElseIf tBimestre.Value = 4 And cbAF.Checked = True Then
            testeAF = "4AF"
        Else
            testeAF = tBimestre.Value
        End If


        myData7.Clear()
        myData4.Clear()


        If (cbTurma.Text <> "") Then

            If cbDisciplina.Text = "" Then

                MsgBox("Favor, escolher a disciplina e a turma!", MsgBoxStyle.Information)

            Else

                Dim vStrMsg As String = _
                MsgBox("Deseja excluir o último aluno do: " & testeAF & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Atenção!")

                If vStrMsg = MsgBoxResult.Yes Then

                    Dim SacarData As DateTime = DateTime.Now
                    Dim data

                    data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD
                    Dim nbimestre As Integer

                    nbimestre = tBimestre.Value

                    SQL4 = "SELECT * FROM " & BD_OK & ".notasfreq WHERE disciplina='" & nrodisciplina & "' AND cod_bimestre=" & testeAF & " AND turma=" & nroturma & " AND anovigente=" & tAno.Value & ""

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

                                SQL7 = "SELECT * FROM " & BD_OK & ".boletim WHERE cod_boletim=" & nf & " ORDER BY nro_aluno DESC"
                                myCommand7.Connection = conn
                                myCommand7.CommandText = SQL7
                                myAdapter7.SelectCommand = myCommand7
                                myAdapter7.Fill(myData7)

                                r7 = myData7.Rows(0)

                                Me.Size = New System.Drawing.Size(357, 297)

                                LbCodigo.Text = r7("nro_aluno")
                                tbMedia.Text = "" & r7("M")
                                tbFaltas.Text = "" & r7("F")
                                tbAC.Text = "" & r7("AC")
                                tbSN.Text = "" & r7("S")

                                'myData7.Clear()

                                'SQL7 = "DELETE FROM " & BD_OK & ".boletim WHERE cod_boletim=" & nf
                                'myCommand7.Connection = conn
                                'myCommand7.CommandText = SQL7
                                'myAdapter7.SelectCommand = myCommand7
                                'myAdapter7.Fill(myData7)

                                'MsgBox("O boletim " & testeAF & "o. Bimestre - Turma: " & cbTurma.Text & " - Disciplina: " & cbDisciplina.Text & " foi excluído com sucesso!", MsgBoxStyle.Information, "Informação")

                            Catch ex As IndexOutOfRangeException

                                MsgBox("Não existe boletim cadastrado!", MsgBoxStyle.Exclamation)
                                Me.Size = New System.Drawing.Size(357, 175)
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

        Else

            MsgBox("Favor, escolher a disciplina e a turma!", MsgBoxStyle.Information)

        End If

    End Sub
End Class