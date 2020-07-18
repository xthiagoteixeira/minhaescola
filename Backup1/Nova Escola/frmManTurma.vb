Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmManTurma

    Dim meuCliqueID
    Dim EuCliquei = 0

    Function FiguraEuCliquei(ByVal Contador As Integer)
        ''" & Endereco_C_Campo & "','" & Endereco_C_Bairro & "', '" & Endereco_C_CEP & "', '" & Endereco_C_iCidade & "', 'Comercial');"

        If Contador = 0 Then
            pbCodigoCon.Visible = True
            pbCodigoCad.Visible = False
        ElseIf Contador = 1 Then
            pbCodigoCon.Visible = False
            pbCodigoCad.Visible = True
        End If

    End Function

    Function AlinharDataGrid()

        'Alinhar...
        DGTurma.Columns(0).Width = 140
        DGTurma.Columns(1).Width = 140
        DGTurma.Columns(2).Width = 140
        DGTurma.Columns(3).Visible = False

    End Function

    Private Sub frmManTurma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAnoVigente.Value = Format(Date.Now, "yyyy")

        myData3.Clear()
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                SQL5 = "SELECT classe, perido, ano, codigo_trma FROM " & BD_OK & ".turma ORDER BY classe"
                myCommand5.Connection = conn
                myCommand5.CommandText = SQL5
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)
                DGTurma.DataSource = myData5
                AlinharDataGrid()

                'Puxa a CLASSE...
                For Each r5 In myData5.Rows
                    tbClasse.Items.Add(r5("classe"))
                Next

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

    Private Sub tbClasse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbClasse.KeyPress
        If (e.KeyChar = "º"c) Or (e.KeyChar = "ª"c) Or (e.KeyChar = "@"c) Then
            e.Handled = True
            MsgBox("Caracter especial não permitido!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEfetuar.Click


        ' DATA
        Dim SacarData As DateTime = DateTime.Now
        Dim data

        data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")
        'SacarData = FormatDateTime(data, DateFormat.ShortDate)
        ' FIM DATA

        If Not (tbCodigo.Text = "" Or tbClasse.Text = "") Then

            If EuCliquei = 0 Then

                'CADASTRO...
                If MsgBox("Efetuar o cadastro de: " & tbCodigo.Text & " ?", MsgBoxStyle.YesNo, "Alteração") = Windows.Forms.DialogResult.No Then
                    MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                    Exit Sub

                Else

                    ''''INICIA ALTERACAO''''
                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD
                    Dim Nome = ""

                    SQL = "SELECT classe FROM " & BD_OK & ".turma WHERE classe='" & tbClasse.Text & "'"

                    Try
                        conn.Open()
                        Try

                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)
                            Try
                                r2 = myData2.Rows(0)
                                nome = r2("classe")
                            Catch ex As Exception
                            End Try

                            If Nome = tbClasse.Text Then
                                MsgBox("Já existe uma turma cadastrada!", MsgBoxStyle.Critical, "Alteração")
                                conn.Close()
                                conn.Dispose()
                                Exit Sub
                                Exit Try
                            Else
                                ''''''''''''''''''''''''INICIA A ATUALIZACAO
                                SQL2 = "INSERT INTO " & BD_OK & ".turma (classe, periodo, total_alunos, anovigente, bloqueado, fundamental) VALUES ('" & tbClasse.Text & "', '" & tbPeriodo.Text & "', '" & tAlunos.Value & "', '" & tAnoVigente.Value & "', '" & cbBloqueia.Checked & "', '" & fundamental.Checked & "');"
                                atualizaMySQL(SQL2)

                                MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")
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

            Else
                'ALTERA...

                If MsgBox("Efetuar a alteração de: " & tbCodigo.Text & " ?", MsgBoxStyle.YesNo, "Alteração") = Windows.Forms.DialogResult.No Then
                    MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                    Exit Sub

                Else
                    ''''INICIA ALTERACAO''''
                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD
                    Dim turmano

                    turmano = tbCodigo.Text
                    SQL = "SELECT * FROM " & BD_OK & ".turma WHERE codigo_trma=" & tbCodigo.Text & ""

                    Try
                        conn.Open()
                        Try

                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)
                            r2 = myData2.Rows(0)

                            If r2 Is DBNull.Value Then
                                MsgBox("Não foi possível completar a alteração, a turma informada não existe.", MsgBoxStyle.Critical, "Alteração")
                                Exit Sub
                                Exit Try

                            Else

                                ''''''''''''''''''''''''INICIA A ATUALIZACAO
                                SQL2 = "UPDATE " & BD_OK & ".turma SET classe='" & tbClasse.Text & "', periodo='" & tbPeriodo.Text & "', total_alunos=" & tAlunos.Value & ", anovigente=" & tAnoVigente.Value & ", bloqueado=" & cbBloqueia.Checked & ", fundamental=" & fundamental.Checked & " WHERE codigo_trma=" & tbCodigo.Text & ";"
                                atualizaMySQL(SQL2)
                                FiguraEuCliquei(0)
                                EuCliquei = 0
                                MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")

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

            End If

        Else
            MsgBox("Preencha os campos, por favor.", MsgBoxStyle.Critical, "Atenção!")
        End If
    End Sub

    Private Sub DGPagamento_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGTurma.CellClick

        cbBloqueia.Checked = False

        EuCliquei = 1

        meuCliqueID = DGTurma.CurrentRow.Cells(3).Value.ToString
        tbCodigo.Text = meuCliqueID

    End Sub

    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()

    End Sub

    Private Sub tbClasse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbClasse.TextChanged
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                myData2.Clear()
                SQL2 = "SELECT classe FROM " & BD_OK & ".turma WHERE classe='" & tbClasse.Text & "'"
                myCommand2.Connection = conn
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)

                r2 = myData2.Rows(0)

                tbPeriodo.Text = ""
                tAlunos.Value = "0"
                tAnoVigente.Value = "0"
                fundamental.Checked = False
                cbBloqueia.Checked = False

                tbCodigo.Text = r2("codigo_trma")
                tbPeriodo.Text = r2("periodo")
                tAlunos.Value = r2("total_alunos")
                tAnoVigente.Value = r2("anovigente")
                fundamental.Checked = r2("fundamental")
                cbBloqueia.Checked = r2("bloqueado")

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

    Private Sub tbCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCodigo.Click

    End Sub

    Private Sub tbCodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbCodigo.TextChanged

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                myData2.Clear()
                SQL2 = "SELECT * FROM " & BD_OK & ".turma WHERE codigo_trma='" & tbCodigo.Text & "'"
                myCommand2.Connection = conn
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)
                r2 = myData2.Rows(0)

                tbPeriodo.Text = ""
                tAlunos.Value = "0"
                tAnoVigente.Value = "0"
                fundamental.Checked = False
                cbBloqueia.Checked = False

                tbCodigo.Text = r2("codigo_trma")
                tbPeriodo.Text = r2("periodo")
                tAlunos.Value = r2("total_alunos")
                tAnoVigente.Value = r2("anovigente")

                If r2("fundamental") = 0 Then
                    fundamental.Checked = False
                Else
                    fundamental.Checked = True
                End If

                If r2("bloqueado") = 0 Then
                    cbBloqueia.Checked = False
                Else
                    cbBloqueia.Checked = True
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

    Private Sub pbCodigoCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCodigoCon.Click



        If MsgBox("Deseja iniciar modo consulta/alteração?", MsgBoxStyle.YesNo, "Consulta") = Windows.Forms.DialogResult.No Then
            'MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
            EuCliquei = 0
            FiguraEuCliquei(EuCliquei)

        Else
            'MsgBox("Modo Consulta Ativado!", MsgBoxStyle.Information, "Consulta")
            EuCliquei = 1
            FiguraEuCliquei(EuCliquei)
            btEfetuar.Text = "Alterar"
            btEfetuar.Enabled = True

        End If

    End Sub

    Private Sub pbCodigoCad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbCodigoCad.Click

        If MsgBox("Deseja iniciar modo cadastro?", MsgBoxStyle.YesNo, "Consulta") = Windows.Forms.DialogResult.No Then
            'MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
            EuCliquei = 0
            FiguraEuCliquei(EuCliquei)

        Else
            'MsgBox("Modo Consulta Ativado!", MsgBoxStyle.Information, "Consulta")
            EuCliquei = 1
            FiguraEuCliquei(EuCliquei)
            btEfetuar.Text = "Cadastrar"
            btEfetuar.Enabled = True

        End If
    End Sub
End Class