Imports MySql.Data.MySqlClient
Imports Mais_Escola

Public Class frmManAluno

    Dim professorno
    Dim nomeAntigo
    Dim discno = 0

    Private Sub tbDisciplina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTurma.SelectedIndexChanged

        Try
            myData3.Clear()
            myData4.Clear()
            myData5.Clear()
            myData7.Clear()

            '''' ESTADO CAPTURA NUMERO ''''
            ''''''''''''CARREGA INICIALMENTE''''''''''''
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try

                    SQL4 = "SELECT * FROM turma WHERE classe='" & tbTurma.Text & "';"
                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)
                    r4 = myData4.Rows(0)
                    discno = r4("codigo_trma")

                    SQL5 = "SELECT * FROM aluno WHERE turma='" & discno & "' AND anovigente='" & tAno.Value & "' ORDER BY nro DESC"
                    myCommand5.Connection = conn
                    myCommand5.CommandText = SQL5
                    myAdapter5.SelectCommand = myCommand5
                    myAdapter5.Fill(myData5)
                    r5 = myData5.Rows(0)
                    tbCodigo.Maximum = r5("nro")

                    SQL3 = "SELECT * FROM aluno WHERE nro='" & tbCodigo.Value & "' AND turma='" & discno & "' AND anovigente='" & tAno.Value & "';"
                    myCommand3.Connection = conn
                    myCommand3.CommandText = SQL3
                    myAdapter3.SelectCommand = myCommand3
                    myAdapter3.Fill(myData3)
                    r3 = myData3.Rows(0)
                    tbAluno.Text = r3("nome")
                    nomeAntigo = tbAluno.Text

                    Try
                        myData7.Clear()
                        SQL7 = "SELECT * FROM bolsas WHERE nro='" & tbCodigo.Value & "' AND codigo_trma='" & discno & "' AND ano='" & tAno.Value & "';"
                        myCommand7.Connection = conn
                        myCommand7.CommandText = SQL7
                        myAdapter7.SelectCommand = myCommand7
                        myAdapter7.Fill(myData7)

                        Try
                            r7 = myData7.Rows(0)
                            If r7("tipo") = "BVJ" Then
                                rbBF.Checked = False
                                rbBVJ.Checked = True
                            ElseIf r7("tipo") = "BF" Then
                                rbBF.Checked = True
                                rbBVJ.Checked = False
                            Else
                                rbBF.Checked = False
                                rbBVJ.Checked = False
                            End If
                        Catch ex As IndexOutOfRangeException
                        End Try

                    Catch ex As IndexOutOfRangeException
                        rbBF.Checked = False
                        rbBVJ.Checked = False
                    End Try

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

            tbCodigo.Enabled = True
            tbAluno.Enabled = True

        Catch myerro As Exception
            MsgBox("Desculpe, não foi encontrado esta lista!", MsgBoxStyle.Critical, "Atenção!")
            tbAluno.Text = ""
            tbCodigo.Enabled = False

        End Try

    End Sub

    Private Sub tbCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCodigo.ValueChanged

        nomeAntigo = tbAluno.Text

        myData6.Clear()

        Try

            Try
                '''' ESTADO CAPTURA NUMERO ''''
                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn2 As MySqlConnection
                conn2 = New MySqlConnection()
                conn2.ConnectionString = CONEXAOBD

                conn2.Open()
                Try
                    'myCommand4.Connection = conn
                    'myCommand4.CommandText = SQL4
                    'myAdapter4.SelectCommand = myCommand4
                    'myAdapter4.Fill(myData4)

                    SQL6 = "SELECT * FROM aluno WHERE turma='" & discno & "' AND nro='" & tbCodigo.Value & "' AND anovigente='" & tAno.Value & "';"

                    myCommand6.Connection = conn2
                    myCommand6.CommandText = SQL6
                    myAdapter6.SelectCommand = myCommand6
                    myAdapter6.Fill(myData6)

                    r6 = myData6.Rows(0)

                    tbAluno.Text = r6("nome")
                    'btAvancado.Enabled = True

                Catch myerro As MySqlException
                End Try
                conn2.Close()
                conn2.Dispose()

            Catch myerro As MySqlException
            Finally
            End Try
        Catch ex As IndexOutOfRangeException
        End Try
    End Sub

    Private Sub frmManProfessor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                myData.Clear()
                SQL = "SELECT * FROM " & BD_OK & ".turma where bloqueado=0 ORDER BY classe"
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                r = myData.Rows(0)

                'Puxa a cidade
                For Each r In myData.Rows
                    If (r("bloqueado") = 0) Then
                        tbTurma.Items.Add(r("classe"))
                    End If
                Next


            Catch myerro As MySqlException
                '    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        If tbCodigo.Text = "" Then

            MsgBox("Não foi possível alterar, é necessário existir um aluno para que seja feita a alteração.", MsgBoxStyle.Critical, "Atenção!")

        Else

            ' DATA
            Dim SacarData As DateTime = DateTime.Now
            Dim data

            data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")
            'SacarData = FormatDateTime(data, DateFormat.ShortDate)
            ' FIM DATA

            If MsgBox("Efetuar a alteração de: " & tbCodigo.Text & " ?", MsgBoxStyle.YesNo, "Alteração") = Windows.Forms.DialogResult.No Then
                MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                Exit Sub
            Else

                ''''INICIA ALTERACAO''''
                Dim AlunoTrava = 0
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = CONEXAOBD

                Dim professorno
                professorno = tbCodigo.Text


                Try
                    conn.Open()
                    Try
                        myData2.Clear()
                        SQL2 = "SELECT * FROM aluno WHERE nro='" & tbCodigo.Value & "' AND turma='" & discno & "' AND anovigente='" & tAno.Value & "';"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)
                        Try
                            r2 = myData2.Rows(0)
                        Catch ex As Exception
                            AlunoTrava = 1
                        End Try

                        If AlunoTrava = 1 Then

                            MsgBox("Não foi possível completar a alteração, o aluno informado não existe.", MsgBoxStyle.Critical, "Alteração")
                            Exit Sub
                            Exit Try

                        Else

                            Dim procura
                            procura = r2("codigo_aluno")

                            ''''''''''''' INICIA A ATUALIZACAO '''''''''''''
                            myData3.Clear()
                            SQL3 = "UPDATE aluno SET nome='" & tbAluno.Text & "', turma=" & discno & ", nro=" & tbCodigo.Value & " WHERE codigo_aluno='" & procura & "' AND anovigente='" & tAno.Value & "';"
                            atualizaMySQL(SQL3)

                            ' PEGA QUAL É A BOLSA
                            ' BF - BOLSA FAMILIA
                            ' BVJ - BOLSA BENEFICIO VARIAVEL JOVEM
                            '

                            Dim TipoBolsa = ""

                            If rbBF.Checked = True Then
                                TipoBolsa = "BF"

                            ElseIf rbBVJ.Checked = True Then
                                TipoBolsa = "BVJ"

                            End If

                            Try

                                myData3.Clear()
                                SQL3 = "UPDATE bolsas SET tipo='" & TipoBolsa & "'  WHERE codigo_trma='" & discno & "' AND nro='" & tbCodigo.Value & "' AND ano='" & tAno.Value & "';"
                                atualizaMySQL(SQL3)
                                r3 = myData3.Rows(0)

                            Catch ex As Exception

                                myData3.Clear()
                                SQL3 = "INSERT INTO bolsas (tipo, codigo_trma, nro, ano) values('" & TipoBolsa & "', '" & discno & "', '" & tbCodigo.Value & "', '" & tAno.Value & "');"
                                atualizaMySQL(SQL3)

                            End Try
                            '
                            ' FIM DAS BOLSAS...

                            MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")

                        End If
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


            End If
        End If

    End Sub

End Class