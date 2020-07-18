Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting

Public Class frmAdmUsuarios
    Dim trava = 0
    Dim nAdmin = 0
    Dim Disciplina_Numero = 0
    Dim Turma_Numero = 0
    Dim Usuario_Numero_1, Usuario_Numero_2, Usuario_Numero_3
    Dim UsuarioPerfil_Numero = 0

    Public Sub Personalizado_Consulta(Usuario As Integer)

        ' Consulta onde desmarcar...
        SQL = String.Format("SELECT modulo, item FROM usuariodsk_personalizado WHERE idUsuarioDSK='{0}';", Usuario)
        Dim Retorno = MySQL_datatable(SQL)

        For Each r In Retorno.Rows

            If r("modulo") = "Administrativo" Then
                If r("item") = "True" Then
                    checkAdmin.CheckState = CheckState.Unchecked
                Else
                    For i = 0 To checkAdmin_Sub.Items.Count - 1 Step 1
                        If checkAdmin_Sub.Items(i).Value = r("item") Then
                            checkAdmin_Sub.SetItemChecked(i, False)
                        End If
                    Next
                End If
            ElseIf r("modulo") = "ProfessorMovel" Then
                If r("item") = "True" Then
                    checkProfMovel.CheckState = CheckState.Unchecked
                Else
                    For i = 0 To checkProfMovel_Sub.Items.Count - 1 Step 1
                        If checkProfMovel_Sub.Items(i).Value = r("item") Then
                            checkProfMovel_Sub.SetItemChecked(i, False)
                        End If
                    Next
                End If
            ElseIf r("modulo") = "ProfessorOnline" Then
                If r("item") = "True" Then
                    checkProfOnline.CheckState = CheckState.Unchecked
                Else
                    For i = 0 To checkProfOnline_Sub.Items.Count - 1 Step 1
                        If checkProfOnline_Sub.Items(i).Value = r("item") Then
                            checkProfOnline_Sub.SetItemChecked(i, False)
                        End If
                    Next
                End If
            ElseIf r("modulo") = "NotasFrequencia" Then
                If r("item") = "True" Then
                    checkNotasFrequencia.CheckState = CheckState.Unchecked
                Else
                    For i = 0 To checkNotasFrequencia_Sub.Items.Count - 1 Step 1
                        If checkNotasFrequencia_Sub.Items(i).Value = r("item") Then
                            checkNotasFrequencia_Sub.SetItemChecked(i, False)
                        End If
                    Next
                End If
            ElseIf r("modulo") = "Relatorios" Then
                If r("item") = "True" Then
                    checkRelatorios.CheckState = CheckState.Unchecked
                Else
                    For i = 0 To checkRelatorios_Sub.Items.Count - 1 Step 1
                        If checkRelatorios_Sub.Items(i).Value = r("item") Then
                            checkRelatorios_Sub.SetItemChecked(i, False)
                        End If
                    Next
                End If
            End If

        Next
    End Sub

    Public Sub Personalizado_Campos(Liberar As Boolean)

        checkAdmin.Checked = Liberar
        checkAdmin.Enabled = Liberar
        checkAdmin_Sub.Enabled = Liberar

        checkProfMovel.Checked = Liberar
        checkProfMovel.Enabled = Liberar
        checkProfMovel_Sub.Enabled = Liberar

        checkProfOnline.Checked = Liberar
        checkProfOnline.Enabled = Liberar
        checkProfOnline_Sub.Enabled = Liberar

        checkRelatorios.Checked = Liberar
        checkRelatorios.Enabled = Liberar
        checkRelatorios_Sub.Enabled = Liberar

        checkNotasFrequencia.Checked = Liberar
        checkNotasFrequencia.Enabled = Liberar
        checkNotasFrequencia_Sub.Enabled = Liberar
    End Sub

    Public Sub atribuicao(Acao As String)


        If Not (cbTurma.Text = String.Empty Or cbDisciplina.Text = String.Empty Or cbUsuario.Text = String.Empty Or cbUsuario.Text = "-") Then

            If Acao = "RetirarTodasProfessor" Then

                ' Retirar TODAS atribuições do professor...
                SQL = String.Format("DELETE FROM professor_grupos WHERE idUsuarioDSK='{0}';", Usuario_Numero_2)
                Dim Retorno = MySQL_atualiza(SQL)
                If Retorno <> "0" Then
                    MsgBox("Retirado atribuições do professor!", MsgBoxStyle.Information, Sistema)
                Else
                    MsgBox("Nenhuma atribuição encontrada!", MsgBoxStyle.Information, Sistema)
                End If
                Refresh_Atribuicao(True)

            ElseIf Acao = "Atribuir" Then

                ' Checar se existe já cadastrado para este usuario...
                Dim SQL =
                        String.Format(
                            "SELECT usuariodsk.usuario, professor_grupos.codigo_trma, professor_grupos.codigo_disc FROM usuariodsk INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK WHERE professor_grupos.codigo_disc='{0}' AND professor_grupos.codigo_trma='{1}';",
                            Disciplina_Numero, Turma_Numero)
                Dim Teste = MySQL_consulta_campo(SQL, "usuario")
                If Teste <> "0" Then
                    MsgBox(String.Format("Esta turma/disciplina está atribuída para: [ {0} ]!", Teste),
                           MsgBoxStyle.Information, "Operação cancelada")
                Else

                    ' Cadastra a turma, disciplina
                    SQL =
                        String.Format(
                            "INSERT INTO professor_grupos (codigo_disc, codigo_trma, idUsuarioDSK) values ('{0}','{1}', '{2}');",
                            Disciplina_Numero, Turma_Numero, Usuario_Numero_2)
                    Dim Retorno = MySQL_atualiza(SQL)

                    If Retorno <> "0" Then
                        MsgBox("Atribuído com sucesso!", MsgBoxStyle.Information, Sistema)
                    Else
                        MsgBox("Nenhuma atribuição feita!", MsgBoxStyle.Information, Sistema)
                    End If
                End If
                Refresh_Atribuicao(True)

            ElseIf Acao = "Retirar" Then

                SQL =
                    String.Format(
                        "DELETE FROM professor_grupos WHERE codigo_disc='{0}' AND codigo_trma='{1}' AND idUsuarioDSK='{2}';",
                        Disciplina_Numero, Turma_Numero, Usuario_Numero_2)
                Dim Retorno = MySQL_atualiza(SQL)
                If Retorno <> "0" Then
                    MsgBox("Atribuição retirada com sucesso!", MsgBoxStyle.Information, Sistema)
                Else
                    MsgBox("Nenhuma atribuição encontrada!", MsgBoxStyle.Information, Sistema)
                End If
                Refresh_Atribuicao(True)

            End If

            ' LIBERA NO boletimweb, PARA SINCRONIZAR...
            BoletimWeb_Status("professor_grupos", "1")

            'cbUsuario.EditValue = ""
            cbTurma.EditValue = String.Empty
            'cbDisciplina.EditValue = ""

        Else

            If atribuirOpcao.EditValue = 3 Then
                If Acao = "RetirarTodas" Then

                    If _
                        MsgBox(String.Format("Deseja excluir as atribuições de todos os professores?"),
                               MsgBoxStyle.YesNo, "Atenção!") = DialogResult.No Then
                        MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                        Exit Sub
                    Else
                        ' Retirar TODAS atribuição de TODOS os professores...
                        SQL = String.Format("DELETE FROM professor_grupos WHERE idUsuarioDSK>0;")
                        Dim Retorno = MySQL_atualiza(SQL)
                        If Retorno <> "0" Then
                            MsgBox("Retirado atribuição de todos os professores!", MsgBoxStyle.Information, Sistema)
                            Refresh_Atribuicao(True)
                        Else
                            MsgBox("Nenhuma atribuição encontrada!", MsgBoxStyle.Information, Sistema)
                        End If
                    End If

                End If

            Else
                MsgBox("Escolha o professor / turma / disciplina!", MsgBoxStyle.Information, Sistema)
            End If

        End If
    End Sub

    Public Sub Gerenciar_Usuarios(Acao As String)

        If txtUsuarios.Text = "admin" Then
            MsgBox("Usuário não permitido!", MsgBoxStyle.Information, "Informação!")
        ElseIf _
            ((txtSenha.Text <> txtSenha2.Text) Or (txtSenha.Text = String.Empty Or txtSenha2.Text = String.Empty)) And
            Not (Acao = "Excluir") Then
            MsgBox("As senhas não conferem!", MsgBoxStyle.Information, "Informação!")
        Else

            If grupoNivel.EditValue = 1 Then
                nAdmin = 1
            ElseIf grupoNivel.EditValue = 0 Then
                nAdmin = 0
            ElseIf grupoNivel.EditValue = 2 Then
                nAdmin = 2
            ElseIf grupoNivel.EditValue = 3 Then
                nAdmin = 3
            Else
                MsgBox("Escolher um nível de acesso!", MsgBoxStyle.Information, "Informação!")
                Exit Sub
            End If

            ' ============================EFETUA CADASTRO DE UM USUARIO
            If Acao = "Cadastrar" Then

                Dim Sql2 = String.Format("SELECT * FROM usuariodsk WHERE usuario='{0}';", txtUsuarios.Text)
                Dim ExisteUsuario = MySQL_consulta_campo(Sql2, "usuario")

                If ExisteUsuario <> "0" Then
                    'Existe...
                    MsgBox("Já existe um usuário cadastrado!", MsgBoxStyle.Information, Sistema)
                Else
                    ' Não existe...
                    Dim Sql3 =
                            String.Format(
                                "INSERT INTO usuariodsk (usuario, senha, cod_prof, nome) values('{0}','{1}','{2}','{3}');",
                                txtUsuarios.Text, txtSenha.Text, nAdmin, txtNome.Text)
                    MySQL_atualiza(Sql3)

                    Dim DataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")

                    Dim SQL4 =
                            String.Format(
                                "INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Inseriu usuário {0}.', '{1}', '1', '{2}');",
                                txtUsuarios.Text, idUsuarioDSK, DataHoje)
                    Dim Retorno = MySQL_atualiza(SQL4)

                    If Retorno <> "0" Then
                        MsgBox(String.Format("Usuário [{0}] foi cadastrada com sucesso!", txtUsuarios.Text),
                               MsgBoxStyle.Information, "Cadastrado!")
                    Else
                        MsgBox(String.Format("Usuário [{0}] não foi cadastrado!", txtUsuarios.Text),
                               MsgBoxStyle.Information, "Informação")
                    End If

                    If grupoNivel.EditValue = 1 Then
                        cbUsuario.Text = txtUsuarios.Text
                        MsgBox("É importante clicar na aba 'Atribuir'", MsgBoxStyle.Information, "Professor")
                    End If
                    Refresh_Usuarios()
                    Refresh_Atribuicao(False)

                End If
                ' FIM DA CONEXAO

                ' ====================EFETUA ALTERAÇÃO DE UM USUARIO
                '
            ElseIf Acao = "Alterar" Then

                If _
                    MsgBox(String.Format("Alterar a senha de: {0} ?", txtUsuarios.Text), MsgBoxStyle.YesNo, "Alteração") =
                    DialogResult.No Then
                    MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                    Exit Sub
                Else
                    ''''INICIA ALTERACAO''''
                    Dim SQL2 = String.Format("SELECT usuario FROM usuariodsk WHERE usuario='{0}';", txtUsuarios.Text)
                    Dim ExisteUsuario = MySQL_consulta_campo(SQL2, "usuario")

                    If ExisteUsuario <> "0" Then
                        ' INICIA A ATUALIZACAO...
                        '
                        SQL2 =
                            String.Format(
                                "UPDATE usuariodsk SET cod_prof='{0}', senha='{1}', nome='{2}' WHERE usuario='{3}'",
                                nAdmin, txtSenha.Text, txtNome.Text, txtUsuarios.Text)
                        MySQL_atualiza(SQL2)

                        Dim DataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")

                        SQL2 =
                            String.Format(
                                "INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Alterou a senha do usuário {0}.', '{1}', '1', '{2}');",
                                cbUsuario.Text, idUsuarioDSK, DataHoje)
                        Dim Retorno = MySQL_atualiza(SQL2)

                        If Retorno <> "0" Then
                            MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")
                        Else
                            MsgBox("Alteração não foi completada!", MsgBoxStyle.Information, "Informação")
                        End If
                        txtNome.Text = String.Empty
                        txtUsuarios.Text = String.Empty
                        txtSenha.Text = String.Empty
                        txtSenha2.Text = String.Empty
                        Refresh_Atribuicao(True)

                    Else
                        MsgBox("Não foi possível completar a alteração, o usuário informado não existe.",
                               MsgBoxStyle.Information, "Alteração")
                        Exit Sub
                    End If
                End If

            ElseIf Acao = "Excluir" Then

                If _
                    MsgBox(String.Format("Efetuar a exclusão de: {0} ?", txtUsuarios.Text), MsgBoxStyle.YesNo, "Excluir") =
                    DialogResult.No Then
                    MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                    Exit Sub
                Else
                    Dim Sql2 = String.Format("DELETE FROM professor_grupos WHERE idUsuarioDSK='{0}';", Usuario_Numero_1)
                    MySQL_atualiza(Sql2)

                    Sql2 = String.Format("DELETE FROM usuariodsk WHERE codigo='{0}';", Usuario_Numero_1)
                    MySQL_atualiza(Sql2)

                    Dim DataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")
                    Sql2 =
                        String.Format(
                            "INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Excluiu usuário {0}.', '{1}', '1', '{2}');",
                            txtUsuarios.Text, idUsuarioDSK, DataHoje)
                    MySQL_atualiza(Sql2)

                    MsgBox("Exclusão completada com sucesso!", MsgBoxStyle.Information, "Exclusão")
                    Refresh_Usuarios()
                    Refresh_Atribuicao(False)

                End If

            End If

            ' LIBERA NO boletimweb, PARA SINCRONIZAR...
            BoletimWeb_Status("usuariodsk", "1")

        End If
    End Sub

    Public Sub Refresh_Atribuicao(SomenteDataGrid As Boolean)

        Try

            If SomenteDataGrid = False Then
                SQL = "SELECT usuario FROM usuariodsk WHERE cod_prof='1' AND bloqueado='0' ORDER BY usuario ASC;"
                'cbUsuario.Properties.DataSource = Nothing
                cbUsuario.Properties.DataSource = MySQL_combobox(SQL)
                cbUsuario.Properties.DisplayMember = "usuario"
            End If

            ' Refresh no Data Grid
            SQL = "SELECT usuariodsk.usuario AS Usuario, " _
                  & "turma.classe As Turma, " _
                  & "disciplinas.disciplina AS Disciplina, usuariodsk.codigo AS CodigoUsuario " _
                  & "FROM " _
                  & "usuariodsk " _
                  & "INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK " _
                  & "INNER JOIN disciplinas ON disciplinas.codigo_disc = professor_grupos.codigo_disc " _
                  & "INNER JOIN turma ON turma.codigo_trma = professor_grupos.codigo_trma " _
                  & "ORDER BY usuariodsk.usuario, turma.classe, disciplinas.disciplina ASC;"
            gridAtribuicao.DataSource = Nothing
            gridAtribuicao.DataSource = MySQL_consulta_datagrid(SQL)
            viewAtribuicao.Columns(3).Visible = False

        Catch ex As Exception
        End Try
    End Sub

    Public Sub Refresh_Usuarios()

        Try
            SQL =
                "SELECT u.Usuario, u.Nome, p.Perfil, u.Bloqueado, u.Codigo, u.Bloqueado AS CodigoBloqueado, u.cod_prof AS CodigoPerfil FROM usuariodsk u, usuariodsk_perfil p WHERE u.cod_prof=p.idUsuariodsk_perfil ORDER BY bloqueado, usuario ASC;"

            gridUsuarios.DataSource = Nothing
            gridUsuarios.DataSource = MySQL_consulta_datagrid(SQL)

            RepositoryItemCheckEdit1.ValueChecked = Convert.ToByte(1)
            RepositoryItemCheckEdit1.ValueUnchecked = Convert.ToByte(0)

            viewUsuarios.Columns(0).OptionsColumn.AllowEdit = False
            viewUsuarios.Columns(1).OptionsColumn.AllowEdit = False
            viewUsuarios.Columns(2).OptionsColumn.AllowEdit = True

            RepositoryItemComboBox1 = New RepositoryItemComboBox
            viewUsuarios.Columns(2).ColumnEdit = RepositoryItemComboBox1

            RepositoryItemComboBox1.Items.Clear()
            RepositoryItemComboBox1.Items.Add("Coordenador")
            RepositoryItemComboBox1.Items.Add("Professor")
            RepositoryItemComboBox1.Items.Add("Secretaria")
            RepositoryItemComboBox1.Items.Add("Personalizado")

            viewUsuarios.Columns(3).ColumnEdit = RepositoryItemCheckEdit1
            viewUsuarios.Columns(4).Visible = False
            viewUsuarios.Columns(5).Visible = False
            viewUsuarios.Columns(6).Visible = False

        Catch ex As Exception
            'MsgBox("Mensagem: " & ex.Message, MsgBoxStyle.Information, "Informação")
        End Try
    End Sub

    Sub Refresh_Personalizado()

        'Personalizado_Campos(False)

        'SQL = "SELECT u.Usuario, u.Nome, p.Perfil, u.Bloqueado, u.Codigo, u.Bloqueado AS CodigoBloqueado, u.cod_prof AS CodigoPerfil FROM usuariodsk u, usuariodsk_perfil p WHERE u.cod_prof=p.idUsuariodsk_perfil AND p.Perfil='Personalizado' ORDER BY bloqueado, usuario ASC;"

        'gridPersonalizado.DataSource = Nothing
        'gridPersonalizado.DataSource = MySQL_consulta_datagrid(SQL)

        'RepositoryItemCheckEdit2.ValueChecked = Convert.ToByte(1)
        'RepositoryItemCheckEdit2.ValueUnchecked = Convert.ToByte(0)

        'viewPersonalizado.Columns(0).OptionsColumn.AllowEdit = False
        'viewPersonalizado.Columns(1).OptionsColumn.AllowEdit = False
        'viewPersonalizado.Columns(2).OptionsColumn.AllowEdit = True

        'RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        'viewPersonalizado.Columns(2).ColumnEdit = RepositoryItemComboBox2

        'RepositoryItemComboBox2.Items.Clear()
        'RepositoryItemComboBox2.Items.Add("Coordenador")
        'RepositoryItemComboBox2.Items.Add("Professor")
        'RepositoryItemComboBox2.Items.Add("Secretaria")
        'RepositoryItemComboBox2.Items.Add("Personalizado")

        'viewPersonalizado.Columns(3).ColumnEdit = RepositoryItemCheckEdit2
        'viewPersonalizado.Columns(4).Visible = False
        'viewPersonalizado.Columns(5).Visible = False
        'viewPersonalizado.Columns(6).Visible = False
    End Sub

    Private Sub frmGerencial2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Erro_Form = "frmAdmUsuarios"

        Refresh_Usuarios()
        Refresh_Atribuicao(False)
        ' Refresh_Personalizado()

        Dim SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
        cbTurma.Properties.DataSource = Nothing
        cbTurma.Properties.DataSource = MySQL_combobox(SQL)
        cbTurma.Properties.DisplayMember = "classe"

        SQL = "SELECT disciplina FROM disciplinas WHERE bloqueado='0' ORDER BY disciplina ASC;"
        cbDisciplina.Properties.DataSource = Nothing
        cbDisciplina.Properties.DataSource = MySQL_combobox(SQL)
        cbDisciplina.Properties.DisplayMember = "disciplina"
    End Sub

    Private Sub btCadastrar_Click(sender As Object, e As EventArgs) Handles btCadastrar.Click
        Gerenciar_Usuarios("Cadastrar")
    End Sub

    Private Sub btAlterar_Click(sender As Object, e As EventArgs) Handles btAlterar.Click
        Gerenciar_Usuarios("Alterar")
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Gerenciar_Usuarios("Excluir")
    End Sub

    Private Sub cbTurma_TextChanged1(sender As Object, e As EventArgs) Handles cbTurma.TextChanged
        Turma_Numero = Consulta_Turma(cbTurma.Text)
    End Sub

    Private Sub cbDisciplina_TextChanged1(sender As Object, e As EventArgs) Handles cbDisciplina.TextChanged
        Disciplina_Numero = Consulta_Disciplina(cbDisciplina.Text)
    End Sub

    Private Sub viewUsuarios_RowClick(sender As Object, e As RowClickEventArgs) Handles viewUsuarios.RowClick

        Dim View As GridView = sender
        Usuario_Numero_1 = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Codigo"))

        txtUsuarios.Text = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Usuario"))
        txtNome.Text = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Nome"))
        grupoNivel.EditValue = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CodigoPerfil"))

        btAlterar.Enabled = True
        btExcluir.Enabled = True
    End Sub

    Private Sub viewUsuarios_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewUsuarios.RowStyle

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim category = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CodigoBloqueado"))

            If category = "0" Then
                Dim View2 As GridView = sender
                Dim category2 = View2.GetRowCellDisplayText(e.RowHandle, View2.Columns("Perfil"))
                If category2 = "Professor" Then
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.BackColor2 = Color.White
                ElseIf category2 = "Secretaria" Then
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.BackColor2 = Color.White
                ElseIf category2 = "Coordenador" Then
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.BackColor2 = Color.White
                ElseIf category2 = "Personalizado" Then
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.BackColor2 = Color.White
                End If

            Else
                e.Appearance.BackColor = Color.LightSalmon
                e.Appearance.BackColor2 = Color.White
            End If
        End If
    End Sub

    Private Sub txtUsuarios_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtUsuarios.KeyPress
        ' NAO PERMITIR ESPAÇO, E ACENTOS...
        Select Case e.KeyChar
            Case "~"c, "´"c, "ç"c, "/"c, ","c, "^"c, "`"c, "á"c, "Á"c, "é"c, "É"c, "í"c, "Í"c, "ó"c, "Ó"c, "ú"c, "ú"c,
                " "c, "ã"c, "Ã"c, "õ"c, "Õ"c
                e.Handled = True
                SendKeys.Send(String.Empty)
                MsgBox("Caracter não permitido!", MsgBoxStyle.Information, Sistema)
        End Select
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemCheckEdit1.CheckedChanged

        ' USUARIOS...
        viewUsuarios.PostEditor()
        Dim info As GridHitInfo = viewUsuarios.CalcHitInfo(gridUsuarios.PointToClient(Cursor.Position))
        Dim CodigoUsuario = viewUsuarios.GetRowCellDisplayText(info.RowHandle, viewUsuarios.Columns("Codigo"))

        Dim obj As CheckEdit = sender
        If obj.Checked = True Then
            SQL = String.Format("UPDATE usuariodsk SET bloqueado='1' WHERE codigo='{0}';", CodigoUsuario)
            MySQL_atualiza(SQL)
        Else
            SQL = String.Format("UPDATE usuariodsk SET bloqueado='0' WHERE codigo='{0}';", CodigoUsuario)
            MySQL_atualiza(SQL)
        End If

        ' LIBERA NO boletimweb, PARA SINCRONIZAR...
        SQL = "UPDATE boletimweb SET sincronizado='1' WHERE tabela='usuariodsk';"
        MySQL_atualiza(SQL)
        Refresh_Usuarios()
        ' FIM
    End Sub

    Private Sub RepositoryItemComboBox1_Click(sender As Object, e As EventArgs) Handles RepositoryItemComboBox1.Click

        Dim info As GridHitInfo = viewUsuarios.CalcHitInfo(gridUsuarios.PointToClient(Cursor.Position))
        Usuario_Numero_1 = viewUsuarios.GetRowCellDisplayText(info.RowHandle, viewUsuarios.Columns("Codigo"))
        UsuarioPerfil_Numero = viewUsuarios.GetRowCellDisplayText(info.RowHandle, viewUsuarios.Columns("CodigoPerfil"))
    End Sub

    Private Sub RepositoryItemComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles RepositoryItemComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub RepositoryItemComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemComboBox1.SelectedIndexChanged

        Dim edit As ComboBoxEdit = sender
        If edit.EditValue = "Secretaria" Then
            UsuarioPerfil_Numero = 0
        ElseIf edit.EditValue = "Professor" Then
            UsuarioPerfil_Numero = 1
        ElseIf edit.EditValue = "Coordenador" Then
            UsuarioPerfil_Numero = 2
        ElseIf edit.EditValue = "Personalizado" Then
            UsuarioPerfil_Numero = 3
        End If

        SQL = String.Format("UPDATE usuariodsk SET cod_prof='{0}' WHERE codigo='{1}';", UsuarioPerfil_Numero,
                            Usuario_Numero_1)
        MySQL_atualiza(SQL)

        Refresh_Personalizado()
        Refresh_Usuarios()
        Refresh_Atribuicao(True)
    End Sub

    Private Sub viewAtribuicao_RowClick(sender As Object, e As RowClickEventArgs) Handles viewAtribuicao.RowClick

        Dim View As GridView = sender
        Usuario_Numero_2 = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CodigoUsuario"))

        cbUsuario.Text = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Usuario"))
        cbUsuario.ClosePopup()
        cbTurma.Text = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Turma"))
        cbTurma.ClosePopup()
        cbDisciplina.Text = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Disciplina"))
        cbDisciplina.ClosePopup()
    End Sub

    Private Sub btAtribuir_Click(sender As Object, e As EventArgs) Handles btAtribuir.Click

        If atribuirOpcao.EditValue = Nothing Then
            MsgBox("Escolher uma alternativa!", MsgBoxStyle.Information, Sistema)
        ElseIf atribuirOpcao.EditValue = 0 Then
            'Atribuir
            atribuicao("Atribuir")
        ElseIf atribuirOpcao.EditValue = 1 Then
            'Retirar Atribuição
            atribuicao("Retirar")
        ElseIf atribuirOpcao.EditValue = 2 Then
            'Retirar Atribuição deste Professor
            atribuicao("RetirarTodasProfessor")
        ElseIf atribuirOpcao.EditValue = 3 Then
            'Retirar Atribuição TODOS os professores
            atribuicao("RetirarTodas")
        End If
    End Sub

    Private Sub grupoNivel_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles grupoNivel.SelectedIndexChanged
        btAtribuir.Enabled = True
    End Sub

    Private Sub checkAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles checkAdmin.CheckedChanged

        If checkAdmin.Checked = False Then
            For i = 0 To checkAdmin_Sub.Items.Count - 1 Step 1
                checkAdmin_Sub.SetItemChecked(i, True)
            Next
            checkAdmin_Sub.Enabled = False
        Else
            checkAdmin_Sub.Enabled = True
        End If
    End Sub

    Private Sub checkNotasFrequencia_CheckedChanged(sender As Object, e As EventArgs) _
        Handles checkNotasFrequencia.CheckedChanged
        If checkNotasFrequencia.Checked = False Then
            For i = 0 To checkNotasFrequencia_Sub.Items.Count - 1 Step 1
                checkNotasFrequencia_Sub.SetItemChecked(i, True)
            Next
            checkNotasFrequencia_Sub.Enabled = False
        Else
            checkNotasFrequencia_Sub.Enabled = True
        End If
    End Sub

    Private Sub checkProfMovel_CheckedChanged(sender As Object, e As EventArgs) Handles checkProfMovel.CheckedChanged
        If checkProfMovel.Checked = False Then
            For i = 0 To checkProfMovel_Sub.Items.Count - 1 Step 1
                checkProfMovel_Sub.SetItemChecked(i, True)
            Next
            checkProfMovel_Sub.Enabled = False
        Else
            checkProfMovel_Sub.Enabled = True
        End If
    End Sub

    Private Sub checkProfOnline_CheckedChanged(sender As Object, e As EventArgs) Handles checkProfOnline.CheckedChanged
        If checkProfOnline.Checked = False Then
            For i = 0 To checkProfOnline_Sub.Items.Count - 1 Step 1
                checkProfOnline_Sub.SetItemChecked(i, True)
            Next
            checkProfOnline_Sub.Enabled = False
        Else
            checkProfOnline_Sub.Enabled = True
        End If
    End Sub

    Private Sub checkRelatorios_CheckedChanged(sender As Object, e As EventArgs) Handles checkRelatorios.CheckedChanged

        If checkRelatorios.Checked = False Then
            For i = 0 To checkRelatorios_Sub.Items.Count - 1 Step 1
                checkRelatorios_Sub.SetItemChecked(i, True)
            Next
            checkRelatorios_Sub.Enabled = False
        Else
            checkRelatorios_Sub.Enabled = True
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit2_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemCheckEdit2.CheckedChanged
        ' Personalizado...
        '

        viewPersonalizado.PostEditor()
        Dim info As GridHitInfo = viewPersonalizado.CalcHitInfo(gridUsuarios.PointToClient(Cursor.Position))
        Dim CodigoUsuario = viewPersonalizado.GetRowCellDisplayText(info.RowHandle, viewPersonalizado.Columns("Codigo"))

        Dim obj As CheckEdit = sender
        If obj.Checked = True Then
            SQL = String.Format("UPDATE usuariodsk SET bloqueado='1' WHERE codigo='{0}';", CodigoUsuario)
            MySQL_atualiza(SQL)
        Else
            SQL = String.Format("UPDATE usuariodsk SET bloqueado='0' WHERE codigo='{0}';", CodigoUsuario)
            MySQL_atualiza(SQL)
        End If

        ' LIBERA NO boletimweb, PARA SINCRONIZAR...
        SQL = "UPDATE boletimweb SET sincronizado='1' WHERE tabela='usuariodsk';"
        MySQL_atualiza(SQL)
        Refresh_Usuarios()
    End Sub

    Private Sub RepositoryItemComboBox2_Click(sender As Object, e As EventArgs) Handles RepositoryItemComboBox2.Click

        ' Personalizado...
        Dim info As GridHitInfo = viewUsuarios.CalcHitInfo(gridUsuarios.PointToClient(Cursor.Position))
        Usuario_Numero_3 = viewUsuarios.GetRowCellDisplayText(info.RowHandle, viewUsuarios.Columns("Codigo"))
        UsuarioPerfil_Numero = viewUsuarios.GetRowCellDisplayText(info.RowHandle, viewUsuarios.Columns("CodigoPerfil"))
    End Sub

    Private Sub RepositoryItemComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles RepositoryItemComboBox2.KeyPress

        ' Personalizado...
        e.Handled = True
    End Sub

    Private Sub viewPersonalizado_RowClick(sender As Object, e As RowClickEventArgs) Handles viewPersonalizado.RowClick

        ' Personalizado...
        Dim View As GridView = sender
        Usuario_Numero_3 = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Codigo"))
        Personalizado_Campos(False)
        Personalizado_Campos(True)
        Personalizado_Consulta(Usuario_Numero_3)
    End Sub

    Private Sub checkAdmin_Sub_Click(sender As Object, e As EventArgs) Handles checkAdmin_Sub.Click

        ' ADMINISTRATIVO...
        If checkAdmin_Sub.SelectedItem.CheckState = CheckState.Checked Then
            ' Adiciona...
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'Administrativo', '" & checkAdmin_Sub.SelectedItem.Value & "');"
            MySQL_atualiza(SQL)
        Else
            ' Retira...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='Administrativo' AND item='" & checkAdmin_Sub.SelectedItem.Value & "';"
            MySQL_atualiza(SQL)
        End If
    End Sub

    Private Sub checkAdmin_Click(sender As Object, e As EventArgs) Handles checkAdmin.Click

        ' ADMINISTRATIVO...
        If checkAdmin.CheckState = CheckState.Unchecked Then
            ' Retira TODOS os itens...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='Administrativo';"
            MySQL_atualiza(SQL)

        Else
            ' Retira o NAVEGADOR...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='Administrativo';"
            MySQL_atualiza(SQL)

            ' Adiciona o NAVEGADOR
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'Administrativo', '" & checkAdmin.EditValue & "');"
            MySQL_atualiza(SQL)

        End If
    End Sub

    Private Sub RepositoryItemComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemComboBox2.SelectedIndexChanged

        Dim edit As ComboBoxEdit = sender
        If edit.EditValue = "Secretaria" Then
            UsuarioPerfil_Numero = 0
        ElseIf edit.EditValue = "Professor" Then
            UsuarioPerfil_Numero = 1
        ElseIf edit.EditValue = "Coordenador" Then
            UsuarioPerfil_Numero = 2
        ElseIf edit.EditValue = "Personalizado" Then
            UsuarioPerfil_Numero = 3
        End If

        SQL = "UPDATE usuariodsk SET cod_prof='" & UsuarioPerfil_Numero & "' WHERE codigo='" & Usuario_Numero_3 & "';"
        MySQL_atualiza(SQL)

        Refresh_Personalizado()
        Refresh_Usuarios()
        Refresh_Atribuicao(True)
    End Sub

    Private Sub checkProfMovel_Click(sender As Object, e As EventArgs) Handles checkProfMovel.Click

        ' ADMINISTRATIVO...
        If checkProfMovel.CheckState = CheckState.Unchecked Then
            ' Retira TODOS os itens...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='ProfessorMovel';"
            MySQL_atualiza(SQL)

        Else
            ' Retira o NAVEGADOR...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='ProfessorMovel';"
            MySQL_atualiza(SQL)

            ' Adiciona o NAVEGADOR
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'ProfessorMovel', '" & checkProfMovel.EditValue & "');"
            MySQL_atualiza(SQL)

        End If
    End Sub

    Private Sub checkProfMovel_Sub_Click(sender As Object, e As EventArgs) Handles checkProfMovel_Sub.Click

        If checkProfMovel_Sub.SelectedItem.CheckState = CheckState.Checked Then
            ' Adiciona...
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'ProfessorMovel', '" & checkProfMovel_Sub.SelectedItem.Value & "');"
            MySQL_atualiza(SQL)
        Else
            ' Retira...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='ProfessorMovel' AND item='" & checkProfMovel_Sub.SelectedItem.Value & "';"
            MySQL_atualiza(SQL)
        End If
    End Sub

    Private Sub checkProfOnline_Click(sender As Object, e As EventArgs) Handles checkProfOnline.Click

        If checkProfOnline.CheckState = CheckState.Unchecked Then
            ' Retira TODOS os itens...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='ProfessorOnline';"
            MySQL_atualiza(SQL)

        Else
            ' Retira o NAVEGADOR...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='ProfessorOnline';"
            MySQL_atualiza(SQL)

            ' Adiciona o NAVEGADOR
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'ProfessorOnline', '" & checkProfOnline.EditValue & "');"
            MySQL_atualiza(SQL)

        End If
    End Sub

    Private Sub checkProfOnline_Sub_Click(sender As Object, e As EventArgs) Handles checkProfOnline_Sub.Click

        If checkProfOnline_Sub.SelectedItem.CheckState = CheckState.Checked Then
            ' Adiciona...
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'ProfessorOnline', '" & checkProfOnline_Sub.SelectedItem.Value & "');"
            MySQL_atualiza(SQL)
        Else
            ' Retira...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='ProfessorOnline' AND item='" & checkProfOnline_Sub.SelectedItem.Value & "';"
            MySQL_atualiza(SQL)
        End If
    End Sub

    Private Sub checkNotasFrequencia_Click(sender As Object, e As EventArgs) Handles checkNotasFrequencia.Click

        If checkNotasFrequencia.CheckState = CheckState.Unchecked Then
            ' Retira TODOS os itens...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='NotasFrequencia';"
            MySQL_atualiza(SQL)

        Else
            ' Retira o NAVEGADOR...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='NotasFrequencia';"
            MySQL_atualiza(SQL)

            ' Adiciona o NAVEGADOR
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'NotasFrequencia', '" & checkNotasFrequencia.EditValue & "');"
            MySQL_atualiza(SQL)

        End If
    End Sub

    Private Sub checkNotasFrequencia_Sub_Click(sender As Object, e As EventArgs) Handles checkNotasFrequencia_Sub.Click

        If checkNotasFrequencia_Sub.SelectedItem.CheckState = CheckState.Checked Then
            ' Adiciona...
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'NotasFrequencia', '" & checkNotasFrequencia_Sub.SelectedItem.Value & "');"
            MySQL_atualiza(SQL)
        Else
            ' Retira...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='NotasFrequencia' AND item='" & checkNotasFrequencia_Sub.SelectedItem.Value & "';"
            MySQL_atualiza(SQL)
        End If
    End Sub

    Private Sub checkRelatorios_Click(sender As Object, e As EventArgs) Handles checkRelatorios.Click

        If checkRelatorios.CheckState = CheckState.Unchecked Then
            ' Retira TODOS os itens...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='Relatorios';"
            MySQL_atualiza(SQL)

        Else
            ' Retira o NAVEGADOR...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='Relatorios';"
            MySQL_atualiza(SQL)

            ' Adiciona o NAVEGADOR
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'Relatorios', '" & checkRelatorios.EditValue & "');"
            MySQL_atualiza(SQL)

        End If
    End Sub

    Private Sub checkRelatorios_Sub_Click(sender As Object, e As EventArgs) Handles checkRelatorios_Sub.Click

        If checkRelatorios_Sub.SelectedItem.CheckState = CheckState.Checked Then
            ' Adiciona...
            SQL = "INSERT INTO usuariodsk_personalizado (idUsuarioDSK, modulo, item) VALUES ('" & Usuario_Numero_3 &
                  "', 'Relatorios', '" & checkRelatorios_Sub.SelectedItem.Value & "');"
            MySQL_atualiza(SQL)
        Else
            ' Retira...
            SQL = "DELETE FROM usuariodsk_personalizado WHERE idUsuarioDSK='" & Usuario_Numero_3 &
                  "' AND modulo='Relatorios' AND item='" & checkRelatorios_Sub.SelectedItem.Value & "';"
            MySQL_atualiza(SQL)
        End If
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        frmPreview_Titulo = "Relatório: Usuários do Sistema"
        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridUsuarios}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        frmPreview_Titulo = "Relatório: Atribuição de Sala"
        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridAtribuicao}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Private Sub cbUsuario_TextChanged(sender As Object, e As EventArgs) Handles cbUsuario.TextChanged
        Try
            If cbUsuario.Text <> String.Empty And cbUsuario.Text <> Nothing And cbUsuario.Text <> "[EditValue é Nulo]" Then
                SQL = "SELECT codigo FROM usuariodsk WHERE usuario='" & cbUsuario.Text & "';"
                Usuario_Numero_2 = MySQL_consulta_campo(SQL, "codigo")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
