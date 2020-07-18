Imports MySql.Data.MySqlClient

Public Class frmGerencialDCL

    Dim crReportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim AlunoRA
    Dim discno = 0
    Dim iAlunos = 0

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub

    Private Sub frmGerencialDCL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

        'PUXA A LISTA DE TURMAS...
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                myData3.Clear()
                SQL3 = "SELECT * FROM turma where bloqueado=0 ORDER BY classe"
                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)
            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
        r3 = myData3.Rows(0)

        'Puxa a cidade
        For Each r3 In myData3.Rows
            If (r3("bloqueado") = 0) Then
                cbTurma.Items.Add(r3("classe"))
            End If
        Next

    End Sub

    Private Sub rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            HorarioFIM.Enabled = True
            HorarioINICIO.Enabled = True
        Else
            HorarioFIM.Enabled = False
            HorarioINICIO.Enabled = False
        End If
    End Sub

    Private Sub tbCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCodigo.ValueChanged

        Try
            Try
                '''' ESTADO CAPTURA NUMERO ''''
                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn2 As MySqlConnection
                conn2 = New MySqlConnection()
                conn2.ConnectionString = CONEXAOBD

                conn2.Open()

                ' CONSULTA O NOME DO INDIVIDUO...
                Try

                    myData6.Clear()
                    SQL6 = "SELECT * FROM aluno WHERE turma='" & discno & "' AND nro='" & tbCodigo.Value & "' AND anovigente='" & tAno.Value & "';"
                    myCommand6.Connection = conn2
                    myCommand6.CommandText = SQL6
                    myAdapter6.SelectCommand = myCommand6
                    myAdapter6.Fill(myData6)
                    r6 = myData6.Rows(0)
                    tbNome.Text = r6("nome")
                    AlunoRA = r6("ra")
                    'btAvancado.Enabled = True

                Catch myerro As MySqlException
                End Try
                '
                ' Fim do aluno_ficha...

                conn2.Close()
                conn2.Dispose()

            Catch myerro As MySqlException
            Finally
            End Try
        Catch ex As IndexOutOfRangeException
        End Try

    End Sub

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        Dim NomeTurma = cbTurma.Text

        Try

            ' ############# PROCURA NO ALUNO (NORMAL) ####################
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try
                    'PEGANDO O NUMERO DA TURMA...
                    myData4.Clear()
                    SQL4 = "SELECT * FROM turma WHERE classe='" & NomeTurma & "';"
                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)
                    r4 = myData4.Rows(0)
                    discno = r4("codigo_trma")

                    'NUMERO MAXIMO DA TURMA
                    myData5.Clear()
                    SQL5 = "SELECT * FROM aluno WHERE turma='" & discno & "' AND anovigente='" & tAno.Value & "' ORDER BY nro DESC"
                    myCommand5.Connection = conn
                    myCommand5.CommandText = SQL5
                    myAdapter5.SelectCommand = myCommand5
                    myAdapter5.Fill(myData5)
                    Try
                        r5 = myData5.Rows(0)
                        tbCodigo.Maximum = r5("nro")
                    Catch ex As Exception
                    End Try

                    'NOME DO ALUNO...
                    myData7.Clear()
                    SQL7 = "SELECT * FROM aluno WHERE nro='" & tbCodigo.Value & "' AND turma='" & discno & "' AND anovigente='" & tAno.Value & "';"
                    myCommand7.Connection = conn
                    myCommand7.CommandText = SQL7
                    myAdapter7.SelectCommand = myCommand7
                    myAdapter7.Fill(myData7)
                    Try
                        r7 = myData7.Rows(0)
                        tbNome.Text = r7("nome")
                    Catch ex As Exception
                    End Try

                    '
                    ' Fim do aluno...

                Catch myerro As MySqlException
                End Try
                conn.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try

        Catch myerro As Exception
            MsgBox("Desculpe, não foi encontrado a Lista Piloto!", MsgBoxStyle.Critical, "Atenção!")
        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Try
            ' ############# PROCURA NO ALUNO (NORMAL) ####################
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD
            Try
                conn.Open()
                Try

                    'NOME DO ALUNO...
                    myData7.Clear()
                    SQL7 = "SELECT * FROM aluno WHERE nro='" & tbCodigo.Value & "' AND turma='" & discno & "' AND anovigente='" & tAno.Value & "';"
                    myCommand7.Connection = conn
                    myCommand7.CommandText = SQL7
                    myAdapter7.SelectCommand = myCommand7
                    myAdapter7.Fill(myData7)
                    Try
                        r7 = myData7.Rows(0)
                        AlunoRA = r7("ra")
                    Catch ex As Exception
                        AlunoRA = ""
                    End Try

                    'PRIMEIRO APAGA A LINHA TEMPDECLARACAO
                    myData4.Clear()
                    SQL4 = "DELETE FROM tempDeclaracao WHERE idDeclaracao='1';"
                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)

                    'INSERE AS INFORMACOES PARA GERAR DECLARACAO...
                    '

                    myData5.Clear()
                    If rb1.Checked = True Then
                        SQL5 = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, horarioINICIO, horarioFIM, op1) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', '" & HorarioINICIO.Text & "', '" & HorarioFIM.Text & "', 'X');"

                    ElseIf rb2.Checked = True Then
                        SQL5 = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op2) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X');"

                    ElseIf rb3.Checked = True Then
                        SQL5 = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op3) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X');"

                    ElseIf rb4.Checked = True Then
                        SQL5 = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op4) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X');"

                    ElseIf rb5.Checked = True Then
                        SQL5 = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op5) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X');"

                    ElseIf rb6.Checked = True Then
                        SQL5 = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op6) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X');"

                    ElseIf rb7.Checked = True Then
                        SQL5 = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op7) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X');"

                    ElseIf rb8.Checked = True Then
                        SQL5 = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op8) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X');"

                    End If
                    atualizaMySQL(SQL5)
                    '
                    ' Fim...

                    'SELECT...
                    '
                    myData2.Clear()
                    SQL2 = "SELECT e.nome AS escola, e.de, td.nome, td.ra, td.horarioINICIO, td.horarioFIM, td.op1, td.op2, td.op3, td.op4, td.op5, td.op6, td.op7, td.op8 FROM tempDeclaracao td, escola e WHERE idDeclaracao='1';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    crReportDocument.Load(meucaminho & "\reports\DE.rpt")
                    crReportDocument.SetDataSource(myData2)
                    frmRpt.crViewer.ReportSource = crReportDocument
                    frmRpt.Show()

                Catch myerro As MySqlException
                    'MsgBox(myerro.Message)
                End Try
                conn.Close()
            Catch myerro As MySqlException
                'MsgBox(myerro.Message)
            Finally
                conn.Dispose()
            End Try
        Catch myerro As Exception
            'MsgBox(myerro.Message)
        End Try

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pbProcurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbProcurar.Click

        If tbNome.Text = "" Then
            MsgBox("Digite uma palavra para consultar!", MsgBoxStyle.Critical)

        Else

            iAlunos = 0
            myData3.Clear()
            myData3.Columns.Clear()

            '''''''''''''CARREGA INICIALMENTE''''''''''''
            Dim conn3 As MySqlConnection

            conn3 = New MySqlConnection()
            conn3.ConnectionString = CONEXAOBD

            SQL3 = "SELECT a.nome, t.classe, a.anovigente, a.nro, a.codigo_aluno FROM aluno a, turma t WHERE a.turma=t.codigo_trma AND a.nome LIKE '%" & tbNome.Text & "%' ORDER BY a.nome ASC"

            Try
                conn3.Open()
                Try
                    myCommand3.Connection = conn3
                    myCommand3.CommandText = SQL3
                    myAdapter3.SelectCommand = myCommand3
                    myAdapter3.Fill(myData3)

                    For Each r3 In myData3.Rows
                        iAlunos = iAlunos + 1
                    Next

                    If iAlunos = 1 Then
                        lbNome.Text = "" & iAlunos & " encontrado!"
                        lbNome.ForeColor = Color.Blue

                        tbNome.Text = r3("nome")
                        selecionaNomeID = r3("nro")
                        selecionaNomeTr = r3("classe")
                        selecionaNomeAno = r3("anovigente")

                        cbTurma.Text = selecionaNomeTr
                        tAno.Value = selecionaNomeAno

                        'btVisualizar.Enabled = True


                    ElseIf iAlunos > 1 Then
                        lbNome.Text = "" & iAlunos & " encontrados!"
                        lbNome.ForeColor = Color.Blue
                        frmGerencialNOME.Show()

                    Else
                        lbNome.Text = "Não encontrado!"
                        lbNome.ForeColor = Color.Red
                        'btVisualizar.Enabled = False
                    End If


                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn3.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn3.Dispose()
            End Try
        End If

    End Sub

    Private Sub frmGerencialDCL_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Try
            If iProcura = 1 Then
                tbNome.Text = selecionaNome
                cbTurma.Text = selecionaNomeTr
                tAno.Value = selecionaNomeAno

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GroupPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub GroupPanel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupPanel1.MouseMove
        Try
            If iProcura = 1 Then
                tbNome.Text = selecionaNome
                cbTurma.Text = selecionaNomeTr
                tAno.Value = selecionaNomeAno

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tbNome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNome.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True


            If tbNome.Text = "" Then
                MsgBox("Digite uma palavra para consultar!", MsgBoxStyle.Critical)

            Else

                iAlunos = 0
                myData3.Clear()
                myData3.Columns.Clear()

                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn3 As MySqlConnection

                conn3 = New MySqlConnection()
                conn3.ConnectionString = CONEXAOBD

                SQL3 = "SELECT a.nome, t.classe, a.anovigente, a.nro, a.codigo_aluno FROM aluno a, turma t WHERE a.turma=t.codigo_trma AND a.nome LIKE '%" & tbNome.Text & "%' ORDER BY a.nome ASC"

                Try
                    conn3.Open()
                    Try
                        myCommand3.Connection = conn3
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)

                        For Each r3 In myData3.Rows
                            iAlunos = iAlunos + 1
                        Next

                        If iAlunos = 1 Then
                            lbNome.Text = "" & iAlunos & " encontrado!"
                            lbNome.ForeColor = Color.Blue

                            tbNome.Text = r3("nome")
                            selecionaNomeID = r3("nro")
                            selecionaNomeTr = r3("classe")
                            selecionaNomeAno = r3("anovigente")

                            cbTurma.Text = selecionaNomeTr
                            tAno.Value = selecionaNomeAno

                            ' btVisualizar.Enabled = True


                        ElseIf iAlunos > 1 Then
                            lbNome.Text = "" & iAlunos & " encontrados!"
                            lbNome.ForeColor = Color.Blue
                            frmGerencialNOME.Show()

                        Else
                            lbNome.Text = "Não encontrado!"
                            lbNome.ForeColor = Color.Red
                            'btVisualizar.Enabled = False
                        End If


                    Catch myerro As MySqlException
                        MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                    End Try
                    '           MessageBox.Show("Conexão aberta com sucesso")
                    conn3.Close()
                Catch myerro As MySqlException
                    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn3.Dispose()
                End Try
            End If

        End If

    End Sub

    Private Sub tbNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNome.TextChanged

    End Sub
End Class