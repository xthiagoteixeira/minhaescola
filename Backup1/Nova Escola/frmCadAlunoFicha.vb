Imports MySql.Data.MySqlClient

Public Class frmCadAlunoFicha
    Dim iAlunos = 0
    Dim discno = 0
    Dim Procurar = 0
    Dim BusqueiNome = 0
    Dim EuCliqueiTurma = 0
    Dim NomeTira As String
    Dim NovoRM

    Public Function LimparCampos()
       
        txtRM.Text = ""
        txtLivro.Text = ""
        txtFolhas.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        txtCep.Text = ""
        txtCidade.Text = ""
        txtEstado.Text = ""
        txtNascimento.Text = ""
        txtRG.Text = ""
        txtPai.Text = ""
        txtMae.Text = ""
        txtFone.Text = ""
        txtObservacao.Text = ""
        txtDataDesistencia.Text = ""
        txtMotivo.Text = ""

        DGComplemento.DataSource = Nothing

        rbMasculino.Checked = False
        rbFeminino.Checked = False
        rbAtivo.Checked = False
        rbTransferido.Checked = False
        rbDesistencia.Checked = False
        rbPesquisar.Checked = False
        rbAlterar.Checked = False
        NovoRM = 0

    End Function

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEfetuar.Click

        Dim DataNascimento
        Dim DataDesistencia
        Dim DataLancamento
        Dim ESCOLHA_MATRICULA = "", ESCOLHA_SEXO


        If rbPesquisar.Checked = True Then

            ' PESQUISA PELO NOME DO INDIVIDUO...
            If tbAluno.Text = "" Then
                MsgBox("Digite um nome para consultar!", MsgBoxStyle.Critical)

            Else

                iAlunos = 0

                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn3 As MySqlConnection

                conn3 = New MySqlConnection()
                conn3.ConnectionString = CONEXAOBD

                Try
                    conn3.Open()
                    Try
                        myData3.Clear()
                        myData3.Columns.Clear()
                        SQL3 = "SELECT a.nome, t.classe, a.ano, a.num, a.CODIGO, a.CURSO FROM aluno_ficha a, turma t WHERE a.CURSO=t.codigo_trma AND a.nome LIKE '%" & tbAluno.Text & "%' AND a.num>0 ORDER BY a.nome ASC"
                        myCommand3.Connection = conn3
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)

                        For Each r3 In myData3.Rows
                            iAlunos = iAlunos + 1
                        Next

                        If iAlunos = 1 Then

                            Try
                                r3 = myData3.Rows(0)
                            Catch ex As Exception
                            End Try

                            MsgBox("" & iAlunos & " encontrado!", MsgBoxStyle.Information)

                            Dim NomeTira As String = r3("nome")
                            tbAluno.Text = NomeTira.Trim

                            txtRM.Text = r3("CODIGO")
                            'tbCodigo.Value = r3("num")
                            cbTurma.Text = r3("classe")

                            ' preencher campos
                            Try
                                myData4.Clear()
                                myData5.Clear()

                                ' ############# PROCURA NO ALUNO (NORMAL) ####################
                                Dim conn2 As MySqlConnection
                                conn2 = New MySqlConnection()
                                conn2.ConnectionString = CONEXAOBD

                                Try
                                    conn2.Open()
                                    Try
                                        ' PUXA DA TABELA FICHA_ALUNO...
                                        Try
                                            myData7.Clear()
                                            SQL7 = "SELECT * FROM aluno_ficha WHERE CURSO='" & selecionaNomeNroTr & "' AND ANO='" & selecionaNomeAno & "' AND NUM='" & selecionaNomeID & "';"
                                            myCommand7.Connection = conn2
                                            myCommand7.CommandText = SQL7
                                            myAdapter7.SelectCommand = myCommand7
                                            myAdapter7.Fill(myData7)
                                            r7 = myData7.Rows(0)

                                            Try
                                                txtRM.Text = r7("CODIGO")
                                            Catch ex As Exception
                                            End Try

                                        Catch ex As Exception
                                        End Try
                                        ' Fim do aluno_ficha...

                                    Catch myerro As MySqlException
                                        MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                                    End Try
                                    'MessageBox.Show("Conexão aberta com sucesso")
                                    conn2.Close()
                                Catch myerro As MySqlException
                                    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                                Finally
                                    conn2.Dispose()
                                End Try

                                tbCodigo.Enabled = True
                                tbAluno.Enabled = True
                                ' bf.Enabled = True

                            Catch myerro As IndexOutOfRangeException
                                'MsgBox("Desculpe, não foi encontrado esta lista!", MsgBoxStyle.Critical, "Atenção!")
                                'tbAluno.Text = ""
                                'tbCodigo.Enabled = False
                                'btAvancado.Enabled = False

                            End Try
                            ' fim de preencher campos

                        ElseIf iAlunos > 1 Then
                            MsgBox("" & iAlunos & " encontrados!", MsgBoxStyle.Information)
                            frmGerencialNOME.Show()

                        Else
                            MsgBox("Não encontrado!", MsgBoxStyle.Information)
                        End If
                    Catch myerro As MySqlException
                        'MsgBox("Não há registro de RM deste aluno.")
                    End Try
                    '' MessageBox.Show("Conexão aberta com sucesso")
                    conn3.Close()
                Catch myerro As MySqlException
                    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn3.Dispose()
                End Try
            End If

        ElseIf rbAlterar.Checked = True Then
            'ALTERA ALUNO NO ALUNO_FICHA

            If txtNascimento.Text <> "" Then
                DataNascimento = Format(CDate(txtNascimento.Text), "yyyy-MM-dd")
                'txtNascimento.Text = DataNascimento
            Else
                DataNascimento = "1900-01-01"
            End If

            If txtDataDesistencia.Text <> "  /  /" Then
                DataDesistencia = Format(CDate(txtDataDesistencia.Text), "yyyy-MM-dd")
                'txtDataDesistencia.Text = DataDesistencia
            Else
                DataDesistencia = "1900-01-01"
            End If

            If lbLancamento.Text <> "  /  /" Then
                DataLancamento = Format(CDate(lbLancamento.Text), "yyyy-MM-dd")
                'lbLancamento.Text = DataLancamento
            Else
                DataLancamento = "1900-01-01"
            End If

            If rbAtivo.Checked = True Then
                ESCOLHA_MATRICULA = "A"
            ElseIf rbDesistencia.Checked = True Then
                ESCOLHA_MATRICULA = "D"
            ElseIf rbTransferido.Checked = True Then
                ESCOLHA_MATRICULA = "T"
            End If

            If rbMasculino.Checked = True Then
                ESCOLHA_SEXO = "M"
            ElseIf rbFeminino.Checked = True Then
                ESCOLHA_SEXO = "F"
            Else
                ESCOLHA_SEXO = "M"
            End If

            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try

                    'VEJA SE EXISTE O CIDADAO
                    If txtRM.Text <> NovoRM Then

                        myData3.Clear()
                        SQL3 = "UPDATE aluno_ficha SET nome='" & tbAluno.Text & "', endereco='" & txtEndereco.Text & "', bairro='" & txtBairro.Text & "', CEP='" & txtCep.Text & "', cidade='" & txtCidade.Text & "', UF='" & txtEstado.Text & "', DT_NASC='" & DataNascimento & "', RG_NUM='" & txtRG.Text & "', Pai='" & txtPai.Text & "', Pai='" & txtPai.Text & "', Mae='" & txtMae.Text & "', Fone='" & txtFone.Text & "', Fone='" & txtFone.Text & "', Escola_Transferencia='" & txtObservacao.Text & "', SEXO='" & ESCOLHA_SEXO & "', Status_Matricula='" & ESCOLHA_MATRICULA & "', Data_Desistencia='" & DataDesistencia & "', Motivo_Desistencia='" & txtMotivo.Text & "', Livro='" & txtLivro.Text & "', Folhas='" & txtFolhas.Text & "', Data_Matricula='" & DataLancamento & "', NUM='" & tbCodigo.Value & "' WHERE CODIGO='" & txtRM.Text & "';"
                        atualizaMySQL(SQL3)

                    Else

                        ' INSERE O CIDADAO caso nao exista...
                        SQL3 = "INSERT INTO aluno_ficha (CODIGO, nome, endereco, bairro, CEP, cidade, UF, DT_NASC, RG_NUM, Pai, Mae, Fone, Escola_Transferencia, SEXO, Status_Matricula, Data_Desistencia, Motivo_Desistencia, Livro, Folhas, Data_Matricula, NUM, CURSO, ANO) " _
                        & "values('" & txtRM.Text & "', '" & tbAluno.Text & "', '" & txtEndereco.Text & "', '" & txtBairro.Text & "', '" & txtCep.Text & "', '" & txtCidade.Text & "', '" & txtEstado.Text & "', '" & DataNascimento & "', '" & txtRG.Text & "', '" & txtPai.Text & "', '" & txtMae.Text & "', '" & txtFone.Text & "', '" & txtObservacao.Text & "', '" & ESCOLHA_SEXO & "', '" & ESCOLHA_MATRICULA & "', '" & DataDesistencia & "', '" & txtMotivo.Text & "', '" & txtLivro.Text & "', '" & txtFolhas.Text & "', '" & DataLancamento & "', '" & tbCodigo.Value & "', '" & discno & "', '" & tAno.Value & "');"
                        atualizaMySQL(SQL3)

                        NovoRM = 0
                    End If

                    MsgBox("Atualizado com sucesso!", MsgBoxStyle.Information)
                    LimparCampos()

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

        Else
            MsgBox("Por favor, escolha uma operação!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmCadAlunoFicha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

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
            '           MessageBox.Show("Conexão aberta com sucesso")
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

    Private Sub tbCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCodigo.ValueChanged

        'LimparCampos()

        'nomeAntigo = tbAluno.Text

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
                    tbAluno.Text = r6("nome")
                    'btAvancado.Enabled = True

                Catch myerro As MySqlException
                End Try

                '\\\\\ PUXA DA TABELA ALUNO_FICHA ...
                '
                Try
                    myData8.Clear()
                    SQL8 = "SELECT * FROM aluno_ficha WHERE nome LIKE '%" & tbAluno.Text & "%' AND NUM>0;"
                    myCommand8.Connection = conn2
                    myCommand8.CommandText = SQL8
                    myAdapter8.SelectCommand = myCommand8
                    myAdapter8.Fill(myData8)
                    r8 = myData8.Rows(0)
                    txtRM.Text = r8("CODIGO")
                Catch ex As Exception

                    ' SE NAO ENCONTRAR... LIMPA TUDO!
                    LimparCampos()

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

    Private Sub txtRM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRM.TextChanged

        'If iProcura = 1 Then

        iAlunos = 0
        '''''''''''' CARREGA INICIALMENTE ''''''''''''
        Dim NomeAluno As String = selecionaNome.Trim

        'preencher campos
        '
        Try

            myData4.Clear()
            myData5.Clear()

            ' ############# PROCURA NO ALUNO (NORMAL) ####################
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try
                    ' PUXA DA TABELA FICHA_ALUNO...
                    Try
                        myData7.Clear()
                        SQL7 = "SELECT * FROM aluno_ficha WHERE CODIGO='" & txtRM.Text & "';"
                        myCommand7.Connection = conn
                        myCommand7.CommandText = SQL7
                        myAdapter7.SelectCommand = myCommand7
                        myAdapter7.Fill(myData7)
                        r7 = myData7.Rows(0)

                        Try
                            NomeTira = r7("nome")
                            tbAluno.Text = NomeTira.Trim

                        Catch ex As Exception
                        End Try

                        Try
                            txtEndereco.Text = r7("ENDERECO")
                        Catch ex As Exception
                        End Try

                        Try
                            txtBairro.Text = r7("BAIRRO")
                        Catch ex As Exception
                        End Try

                        Try
                            txtCep.Text = r7("CEP")
                        Catch ex As Exception
                        End Try

                        Try
                            txtCidade.Text = r7("CIDADE")
                        Catch ex As Exception
                        End Try

                        Try
                            txtEstado.Text = r7("UF")
                        Catch ex As Exception
                        End Try

                        Try
                            Dim DataNascimento = Format(r7("DT_NASC"), "dd/MM/yyyy")
                            txtNascimento.Text = DataNascimento
                        Catch ex As Exception
                        End Try

                        Try
                            txtRG.Text = r7("RG_NUM")
                        Catch ex As Exception
                        End Try

                        Try
                            txtPai.Text = r7("Pai")
                        Catch ex As Exception
                        End Try

                        Try
                            txtMae.Text = r7("Mae")
                        Catch ex As Exception
                        End Try

                        Try
                            txtFone.Text = r7("FONE")
                        Catch ex As Exception
                        End Try

                        Try
                            txtObservacao.Text = r7("Escola_Transferencia")
                        Catch ex As Exception
                        End Try

                        Try
                            If r7("SEXO") = "M" Then
                                rbMasculino.Checked = True
                                rbFeminino.Checked = False
                            Else
                                rbMasculino.Checked = False
                                rbFeminino.Checked = True
                            End If
                        Catch ex As Exception
                        End Try

                        Try
                            If r7("Status_Matricula") = "A" Then
                                rbAtivo.Checked = True
                                rbDesistencia.Checked = False
                                rbTransferido.Checked = False

                            ElseIf r7("Status_Matricula") = "D" Then
                                rbAtivo.Checked = False
                                rbDesistencia.Checked = True
                                rbTransferido.Checked = False

                            ElseIf r7("Status_Matricula") = "T" Then
                                rbAtivo.Checked = False
                                rbDesistencia.Checked = False
                                rbTransferido.Checked = True

                            End If
                        Catch ex As Exception
                        End Try

                        Try
                            Dim DataNascimento = Format(r7("Data_Desistencia"), "dd/MM/yyyy")
                            txtDataDesistencia.Text = DataNascimento

                        Catch ex As Exception
                        End Try

                        Try
                            txtMotivo.Text = r7("Motivo_Desistencia")

                        Catch ex As Exception
                        End Try

                        Try
                            txtLivro.Text = r7("Livro")
                        Catch ex As Exception
                        End Try

                        Try
                            txtFolhas.Text = r7("Folhas")
                        Catch ex As Exception
                        End Try

                        Try
                            Dim DataNascimento = Format(r7("Data_Matricula"), "dd/MM/yyyy")
                            lbLancamento.Text = DataNascimento

                        Catch ex As Exception
                        End Try

                        'Try
                        '    tbCodigo.Value = r7("NUM")
                        'Catch ex As Exception
                        'End Try

                    Catch ex As Exception
                    End Try
                    ' Fim do aluno_ficha...

                    '''' PROCURA no aluno_ficha_complemento
                    '
                    Try

                        DGComplemento.DataSource = Nothing
                        myData9.Clear()
                        myData9.Columns.Clear()
                        SQL9 = "SELECT afc.Ano AS Ano, t.Classe AS Turma, afc.Observacao AS Observacao FROM aluno_ficha_complemento afc, turma t WHERE t.codigo_trma=afc.Curso AND afc.Codigo='" & txtRM.Text & "';"
                        myCommand9.Connection = conn
                        myCommand9.CommandText = SQL9
                        myAdapter9.SelectCommand = myCommand9
                        myAdapter9.Fill(myData9)
                        DGComplemento.DataSource = myData9
                        DGComplemento.Columns(0).Width = "60"
                        DGComplemento.Columns(1).Width = "100"

                    Catch ex As Exception
                    End Try
                    '
                    ' Fim do aluno_ficha_COMPLEMENTO...

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
            tbCodigo.Enabled = True
            tbAluno.Enabled = True

        Catch myerro As IndexOutOfRangeException
            MsgBox("Desculpe, não foi encontrado esta lista!", MsgBoxStyle.Critical, "Atenção!")
            tbAluno.Text = ""
            tbCodigo.Enabled = False
        End Try
        'Fim de preencher campos

        'End If
    End Sub

    Private Sub frmCadAlunoFicha_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If iProcura = 1 Then

            tAno.Value = selecionaNomeAno
            cbTurma.Text = selecionaNomeTr
            'tbCodigo.Value = selecionaNomeNro
            txtRM.Text = selecionaNomeID


            iProcura = 0
        End If

        If BusqueiNome = 1 Then
            ' PROCURA NOME COMPLETO NO: ALUNO / ALUNO_FICHA / ALUNO_FICHA_COMPLEMENTAR


            BusqueiNome = 0
        End If

    End Sub

    Private Sub tbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        'LimparCampos()

        'If iProcura <> 0 Then



        Dim NomeTurma = cbTurma.Text

        ' BUSQUEI NOME
        BusqueiNome = 1
        Try

            ' ############# PROCURA NO ALUNO (NORMAL) ####################
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try
                    myData4.Clear()
                    SQL4 = "SELECT * FROM turma WHERE classe='" & NomeTurma & "';"
                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)
                    r4 = myData4.Rows(0)
                    discno = r4("codigo_trma")

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

                    myData7.Clear()
                    SQL7 = "SELECT * FROM aluno WHERE nro='" & tbCodigo.Value & "' AND turma='" & discno & "' AND anovigente='" & tAno.Value & "';"
                    myCommand7.Connection = conn
                    myCommand7.CommandText = SQL7
                    myAdapter7.SelectCommand = myCommand7
                    myAdapter7.Fill(myData7)
                    Try
                        r7 = myData7.Rows(0)
                        tbAluno.Text = r7("nome")
                    Catch ex As Exception
                    End Try


                    '\\\\\ PUXA DA TABELA ALUNO_FICHA ...
                    '
                    myData8.Clear()
                    SQL8 = "SELECT * FROM aluno_ficha WHERE nome LIKE '%" & tbAluno.Text & "%' AND NUM>0;"
                    myCommand8.Connection = conn
                    myCommand8.CommandText = SQL8
                    myAdapter8.SelectCommand = myCommand8
                    myAdapter8.Fill(myData8)
                    Try
                        r8 = myData8.Rows(0)
                        txtRM.Text = r8("CODIGO")
                    Catch ex As Exception
                    End Try
                    '
                    ' Fim do aluno_ficha...

                    ' '' '' PUXA DA TABELA FICHA_ALUNO_COMPLEMENTO...
                    '' '' Vai buscar do arquivo MORTO da ESCOLA
                    '' '' // ANO, RM, OBSERVACAO DESTE ALUNO
                    ' ''Try
                    ' ''    DGComplemento.DataSource = Nothing
                    ' ''    myData7.Clear()
                    ' ''    myData7.Columns.Clear()
                    ' ''    SQL7 = "SELECT afc.Ano AS Ano, t.Classe AS Turma, afc.Observacao AS Observacao FROM aluno_ficha_complemento afc, turma t WHERE afc.Curso=t.codigo_trma AND afc.Codigo='" & txtRM.Text & "';"
                    ' ''    myCommand7.Connection = conn
                    ' ''    myCommand7.CommandText = SQL7
                    ' ''    myAdapter7.SelectCommand = myCommand7
                    ' ''    myAdapter7.Fill(myData7)
                    ' ''    r7 = myData7.Rows(0)

                    ' ''Catch ex As Exception
                    ' ''End Try

                    ' ''DGComplemento.DataSource = myData7
                    ' ''DGComplemento.Columns(0).Width = "60"
                    ' ''DGComplemento.Columns(1).Width = "100"

                    '
                    ' Fim do aluno_ficha_COMPLEMENTO...

                Catch myerro As MySqlException
                    'MsgBox("Não há registro de RM deste aluno!")
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try

            'tbCodigo.Enabled = True
            'tbAluno.Enabled = True
            ' bf.Enabled = True

        Catch myerro As Exception
            MsgBox("Desculpe, não foi encontrado a Lista Piloto!", MsgBoxStyle.Critical, "Atenção!")
            'tbAluno.Text = ""
            'tbCodigo.Enabled = False
            ''btAvancado.Enabled = False

        End Try
        'End If

    End Sub

    Private Sub tbAluno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAluno.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            rbPesquisar.Checked = True
            rbAlterar.Checked = False
            btEfetuar.Focus()

        End If
    End Sub

    Private Sub txtEndereco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEndereco.TextChanged

    End Sub

    Private Sub rbAlterar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAlterar.CheckedChanged
        If rbAlterar.Checked = True Then

            If txtRM.Text = "" Then
                lbLancamento.Text = Format(Date.Now, "dd/MM/yyyy")

                ' PEGAR O ULTIMO RM (CODIGO) DE ALUNO_FICHA
                myData3.Clear()
                Dim conn3 As MySqlConnection
                conn3 = New MySqlConnection()
                conn3.ConnectionString = CONEXAOBD

                SQL3 = "SELECT Codigo FROM aluno_ficha ORDER BY Codigo DESC"

                Try
                    conn3.Open()
                    Try
                        myCommand3.Connection = conn3
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)

                        Try
                            r3 = myData3.Rows(0)

                            'If txtRM.Text <> "" Then
                            NovoRM = r3("Codigo") + 1
                            'End If

                        Catch ex As Exception
                            NovoRM = 1
                        End Try
                        txtRM.Text = NovoRM

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

    Private Sub rbPesquisar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPesquisar.CheckedChanged


    End Sub

    Private Sub rbPesquisar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPesquisar.Click
        LimparCampos()
    End Sub
End Class