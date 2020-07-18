Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data

Public Class frmGerencial2

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim r As DataRow
    Dim SQL As String

    Dim myCommand2 As New MySqlCommand()
    Dim myAdapter2 As New MySqlDataAdapter()
    Dim myData2 As New DataTable()
    Dim r2 As DataRow
    Dim SQL2 As String

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()
    Dim SQL4 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()
    Dim r5 As DataRow
    Dim SQL5 As String

    Dim admuser As String
    Dim trava = 0

    Private Sub rbRetirar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRetirar.CheckedChanged
        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        tbUsuario.Visible = False
        cbUsuario.Visible = True
        tbSenha.Enabled = False
        tbSenha2.Enabled = False

    End Sub

    Private Sub rbAlterar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAlterar.CheckedChanged
        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        tbUsuario.Visible = False
        cbUsuario.Visible = True
        tbSenha.Enabled = True
        tbSenha2.Enabled = True
    End Sub


    Private Sub rbnovo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnovo.CheckedChanged
        cbUsuario.Visible = False
        tbUsuario.Visible = True
        tbSenha.Enabled = True
        tbSenha2.Enabled = True

    End Sub

    Private Sub frmGerencial2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        SQL5 = "select usuario FROM " & BD_OK & ".usuariodsk ORDER BY usuario"
        ' SQL6 = "select nome FROM " & BD_OK & ".aluno ORDER BY nome"

        Try
            conn.Open()
            Try

                myCommand5.Connection = conn
                myCommand5.CommandText = SQL5
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)

                'myCommand6.Connection = conn
                'myCommand6.CommandText = SQL6
                'myAdapter6.SelectCommand = myCommand6
                'myAdapter6.Fill(myData6)

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

        For Each r5 In myData5.Rows
            cbUsuario.Items.Add(r5("usuario"))
        Next


    End Sub

    Private Sub tbSenha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSenha.KeyPress



    End Sub

    Private Sub tbSenha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSenha.TextChanged

        'Dim senha As String
        'Dim tamanho
        ''Dim ca() As Integer = {"q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "ç", "z", "x", "c", "v", "b", "n", "m"}
        ''Dim cs() As Integer = {"!", "@", "#", "$", "%", "¨", "&", "*", "(", ")", "_", "+", ",", ".", "@"}
        ''Dim no() As Integer = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}
        'Dim ca = "qwertyuiopasdfghjklçzxcvbnm"
        'Dim cs = "!@#$%¨&*()_+,.@"
        'Dim no = "1234567890"
        'Dim ca1 As String
        'Dim cs1 As String
        'Dim no1 As String

        'Dim contador1 = 0, contador2 = 0, contador3 = 0
        'Dim contador11 = 0, contador22 = 0, contador33 = 0

        'senha = tbSenha.Text

        'ca1 = senha.Substring(i, 1)
        'i = i + 1
        'contador1 = InStr("" & ca, ca1)
        'contador11 = contador1 + contador11

        'cs1 = senha.Substring(i2, 1)
        'i2 = i2 + 1
        'contador2 = InStr("" & cs, cs1)
        'contador22 = contador2 + contador22

        'no1 = senha.Substring(i3, 1)
        'i3 = i3 + 1
        'contador3 = InStr("" & no, no1)
        'contador33 = contador3 + contador33


        'MsgBox("" & contador11)
        'MsgBox("" & contador22)
        'MsgBox("" & contador33)


    End Sub

    Private Sub cbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUsuario.SelectedIndexChanged

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        SQL5 = "select usuario, cod_prof FROM " & BD_OK & ".usuariodsk WHERE usuario='" & cbUsuario.Text & "'"

        Try
            conn.Open()
            Try
                myData5.Clear()
                myCommand5.Connection = conn
                myCommand5.CommandText = SQL5
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)
                r5 = myData5.Rows(0)

                If r5("cod_prof") = 0 Then
                    cbAdmin.Checked = True
                Else
                    cbAdmin.Checked = False
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

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        trava = 0

        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        Dim nAdmin = 0

        If cbAdmin.Checked = False Then
            nAdmin = 1

        Else
            nAdmin = 0

        End If

        admuser = tbUsuario.Text

        If tbUsuario.Text = "admin" Or tbUsuario.Text = "suporte" Then
            MsgBox("Usuário não permitido para executar nenhuma ação!", MsgBoxStyle.Critical, "Atenção!")
            Exit Sub

        ElseIf (tbSenha.Text <> tbSenha2.Text) Then
            MsgBox("As senhas não conferem!", MsgBoxStyle.Critical, "Atenção!")
            Exit Sub

        Else

            Dim usuario
            ' ============================EFETUA CADASTRO DE UM USUARIO
            If rbnovo.Checked = True Then
                usuario = tbUsuario.Text
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = CONEXAOBD

                SQL = "SELECT * FROM " & BD_OK & ".usuariodsk WHERE usuario='" & usuario & "'"

                Try
                    conn.Open()
                    Try
                        myCommand.Connection = conn
                        myCommand.CommandText = SQL
                        myAdapter.SelectCommand = myCommand
                        myAdapter.Fill(myData)

                        Try
                            r = myData.Rows(0)
                            If r("usuario") = tbUsuario.Text Then
                                MsgBox("Já existe um usuário cadastrado, e não é permitida a duplicação", MsgBoxStyle.Critical, "Atenção!")
                                trava = 1
                            End If
                        Catch ex As Exception
                        End Try


                        If trava = 0 Then

                            SQL2 = "INSERT INTO " & BD_OK & ".usuariodsk (usuario, senha, cod_prof) values('" & tbUsuario.Text & "','" & tbSenha.Text & "','" & nAdmin & "');"
                            atualizaMySQL(SQL2)

                            MsgBox("Usuário [" & tbUsuario.Text & "] foi cadastrada com sucesso!", MsgBoxStyle.Information, "Cadastrado")
                            tbUsuario.Text = ""
                            tbSenha.Text = ""
                            tbSenha2.Text = ""

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
                ' FIM DA CONEXAO
            End If


            ' ====================EFETUA ALTERAÇÃO DE UM USUARIO
            If rbAlterar.Checked = True Then
                If MsgBox("Alterar a senha de: " & cbUsuario.Text & " ?", MsgBoxStyle.YesNo, "Alteração") = Windows.Forms.DialogResult.No Then
                    MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                    Exit Sub
                Else
                    ''''INICIA ALTERACAO''''

                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD

                    SQL2 = "SELECT * FROM " & BD_OK & ".usuariodsk WHERE usuario='" & cbUsuario.Text & "'"
                    Try
                        conn.Open()
                        Try
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)
                            r2 = myData2.Rows(0)
                            If r2 Is DBNull.Value Then
                                MsgBox("Não foi possível completar a alteração, o usuário informado não existe.", MsgBoxStyle.Critical, "Alteração")
                                Exit Sub
                                Exit Try
                            Else
                                ''''''''''''''''''''''''INICIA A ATUALIZACAO
                                SQL = "UPDATE " & BD_OK & ".usuariodsk SET cod_prof=" & nAdmin & ", senha='" & tbSenha.Text & "' WHERE usuario='" & cbUsuario.Text & "'"
                                atualizaMySQL(SQL)

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

            '==========================RETIRAR USUARIO
            If rbRetirar.Checked = True Then

                If MsgBox("Efetuar a exclusão de: " & cbUsuario.Text & " ?", MsgBoxStyle.YesNo, "Excluir") = Windows.Forms.DialogResult.No Then
                    MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                    Exit Sub
                Else

                    ''''''''''''INICIA EXCLUSAO DE DADOS'
                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD

                    Try
                        conn.Open()
                        Try
                            SQL4 = "DELETE FROM " & BD_OK & ".usuariodsk WHERE usuario='" & cbUsuario.Text & "'"
                            myCommand4.Connection = conn
                            myCommand4.CommandText = SQL4
                            myAdapter4.SelectCommand = myCommand4
                            myAdapter4.Fill(myData4)
                            MsgBox("Exclusão completada com sucesso!", MsgBoxStyle.Information, "Exclusão")

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
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub
End Class