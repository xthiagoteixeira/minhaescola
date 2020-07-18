Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports MySql.Data.MySqlClient

Public Class FrmAdmDelib11
    Dim _euCliquei = False

    Dim _nrocategoriaClicada = 0
    Dim _nomecategoriaClicada = String.Empty

    Dim _nrodescricaoClicada = 0
    Dim _nomedescricaoClicada = String.Empty

    Dim _nrocategoriaEscolhida = 0

    Dim _sql As String

    Sub RefreshCategoria(inicializacao As Boolean)

        '//// JOGA PARA A DATAGRID
        _sql = "SELECT categoria, idDelib_cat FROM delib11_categoria ORDER BY categoria ASC;"
        gridCategorias.DataSource = Nothing
        gridCategorias.DataSource = MySQL_consulta_datagrid(_sql)

        ViewCategorias.Columns(0).Width = 300
        ViewCategorias.Columns(1).Visible = False

        If inicializacao = True Then
            Dim _sql2 = "SELECT Categoria FROM delib11_categoria ORDER BY Categoria ASC;"
            cbCategoria.Properties.DataSource = Nothing
            cbCategoria.Properties.DataSource = MySQL_combobox(_sql2)
            cbCategoria.Properties.DisplayMember = "Categoria"
        End If
    End Sub

    Sub RefreshDescricao()

        _sql = "SELECT " _
               & "delib11_descricao.Descricao, " _
               & "delib11_descricao.Bloqueado, " _
               & "delib11_categoria.categoria, " _
               & "delib11_descricao.idDelib_des, " _
               & "delib11_descricao.idDelib_cat, delib11_descricao.Bloqueado AS CodigoBloqueado " _
               & "FROM " _
               & "delib11_categoria " _
               &
               "INNER JOIN delib11_descricao ON delib11_descricao.idDelib_cat = delib11_categoria.idDelib_cat WHERE delib11_categoria.categoria='" &
               cbCategoria.Text & "' ORDER BY delib11_descricao.Bloqueado, delib11_descricao.Descricao ASC;"
        gridDescricao.DataSource = Nothing
        gridDescricao.DataSource = MySQL_consulta_datagrid(_sql)

        RepositoryItemCheckEdit1.ValueChecked = Convert.ToByte(1)
        RepositoryItemCheckEdit1.ValueUnchecked = Convert.ToByte(0)

        ViewDescricao.Columns(0).OptionsColumn.AllowEdit = False
        ViewDescricao.Columns(1).OptionsColumn.AllowEdit = True

        ViewDescricao.Columns(0).Width = "100"
        ViewDescricao.Columns(1).Width = "20"

        ViewDescricao.Columns(2).Visible = False
        ViewDescricao.Columns(3).Visible = False
        ViewDescricao.Columns(4).Visible = False
        ViewDescricao.Columns(5).Visible = False

        ViewDescricao.Columns(1).ColumnEdit = RepositoryItemCheckEdit1
    End Sub

    Private Sub frmAdmDelib11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmAdmDelib11"
        ' Refresh DataGrid
        RefreshCategoria(True)
    End Sub

    Private Sub btAlterarCat_Click(sender As Object, e As EventArgs) Handles btCategoriaAlt.Click

        ' Alterar Categoria...

        If MsgBox("Efetuar a alteração: " & vbCrLf & "De: [" & _nomecategoriaClicada & "] " & vbCrLf & "Para: [" &
                  tbCategoria.Text & "] ?", MsgBoxStyle.YesNo, "Alteração") = DialogResult.No Then
            MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
            Exit Sub
        Else

            ''''INICIA ALTERACAO''''
            Try
                _sql = String.Format("SELECT categoria FROM delib11_categoria WHERE categoria LIKE '{0}';",
                                     tbCategoria.Text)
                Dim nome = MySQL_consulta_campo(_sql, "categoria")
                If nome <> "0" Then
                    MsgBox("Já existe uma categoria cadastrada!", MsgBoxStyle.Information, "Alteração")
                    Exit Sub

                Else

                    _sql = String.Format("UPDATE delib11_categoria SET categoria='{0}' WHERE idDelib_cat='{1}';",
                                         tbCategoria.Text, _nrocategoriaClicada)
                    MySQL_atualiza(_sql)

                    Dim dataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")

                    _sql =
                        String.Format(
                            "INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Alterou a categoria (Delib11): {0} para: {1}', '{2}', '1', '{3}');",
                            _nomecategoriaClicada, tbCategoria.Text, idUsuarioDSK, dataHoje)
                    MySQL_atualiza(_sql)

                    _euCliquei = False
                    tbCategoria.Text = String.Empty

                    ' LIBERA NO boletimweb, PARA SINCRONIZAR...
                    '
                    _sql = "UPDATE boletimweb SET sincronizado='1' WHERE tabela='delib11_categoria';"
                    MySQL_atualiza(_sql)

                    MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")
                    RefreshCategoria(True)

                End If


            Catch myerro As MySqlException
            End Try

        End If
        btCategoriaAlt.Enabled = False
    End Sub

    Private Sub gridCategorias_Click(sender As Object, e As EventArgs) Handles gridCategorias.Click

        Try
            Dim row As DataRow = ViewCategorias.GetDataRow(ViewCategorias.FocusedRowHandle)

            tbCategoria.Text = row(0)
            _nomecategoriaClicada = row(0)
            _nrocategoriaClicada = row(1)

            _euCliquei = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbCategoria_TextChanged(sender As Object, e As EventArgs) Handles cbCategoria.TextChanged

        Try
            _sql = String.Format("SELECT idDelib_cat FROM delib11_categoria WHERE categoria='{0}';", cbCategoria.Text)
            _nrocategoriaEscolhida = MySQL_consulta_campo(_sql, "idDelib_cat")

            RefreshDescricao()
            RefreshCategoria(False)
            btDescricaoCad.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btCadastrarDesc_Click(sender As Object, e As EventArgs) Handles btDescricaoCad.Click

        ' Cadastrar Descrição...
        If Not (tbDescricao.Text = String.Empty) Then

            ' CADASTRO...
            If MsgBox(String.Format("Efetuar o cadastro de: {0} ?", tbDescricao.Text), MsgBoxStyle.YesNo, "Cadastro") =
               DialogResult.No Then
                MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                Exit Sub
            Else
                Try
                    _sql = String.Format("SELECT descricao FROM delib11_descricao WHERE descricao LIKE '{0}';",
                                         tbDescricao.Text)
                    Dim nome = MySQL_consulta_campo(_sql, "descricao")
                    If nome <> "0" Then
                        MsgBox("Já existe uma descrição cadastrada!", MsgBoxStyle.Information, "Cadastro")
                        Exit Sub
                    Else
                        '*** INICIA A ATUALIZACAO...
                        _sql =
                            String.Format(
                                "INSERT INTO delib11_descricao (idDelib_cat, descricao, bloqueado) VALUES ('{0}','{1}', '0');",
                                _nrocategoriaEscolhida, tbDescricao.Text)
                        MySQL_atualiza(_sql)

                        Dim dataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")

                        _sql =
                            String.Format(
                                "INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Cadastrou uma descrição (Delib11): {0}', '{1}', '1', '{2}');",
                                tbDescricao.Text, idUsuarioDSK, dataHoje)
                        MySQL_atualiza(_sql)

                        ' LIBERA NO boletimweb, PARA SINCRONIZAR...
                        '
                        _sql = "UPDATE boletimweb SET sincronizado='1' WHERE tabela='delib11_descricao';"
                        MySQL_atualiza(_sql)

                        MsgBox("Descrição inserida com sucesso!", MsgBoxStyle.Information, "Cadastro")
                    End If
                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
            End If
        Else
            MsgBox("Preencha os campos, por favor.", MsgBoxStyle.Information, "Informação!")
        End If

        tbDescricao.Text = String.Empty
        RefreshDescricao()
        RefreshCategoria(False)
    End Sub

    Private Sub btAlterarDesc_Click(sender As Object, e As EventArgs) Handles btDescricaoAlt.Click

        ' Alterar Descrição...

        If _
            MsgBox(
                String.Format("Efetuar a alteração: {0}De: [{1}] {0}Para: [{2}] ?", vbCrLf, _nomedescricaoClicada,
                              tbDescricao.Text), MsgBoxStyle.YesNo, "Alteração") = DialogResult.No Then
            MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
            Exit Sub
        Else

            ''''INICIA ALTERACAO''''
            _sql = String.Format("SELECT descricao FROM delib11_descricao WHERE descricao LIKE '{0}';", tbDescricao.Text)
            Dim nome = MySQL_consulta_campo(_sql, "descricao")

            If nome <> "0" Then
                MsgBox("Já existe uma descrição cadastrada!", MsgBoxStyle.Information, "Alteração")
                Exit Sub
            Else
                _sql =
                    String.Format(
                        "UPDATE delib11_descricao SET descricao='{0}' WHERE idDelib_des='{1}' AND idDelib_cat='{2}';",
                        tbDescricao.Text, _nrodescricaoClicada, _nrocategoriaEscolhida)
                MySQL_atualiza(_sql)

                Dim dataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")
                _sql =
                    String.Format(
                        "INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Alterou a descrição (Delib11): {0} para: {1}', '{2}', '1', '{3}');",
                        _nomedescricaoClicada, tbDescricao.Text, idUsuarioDSK, dataHoje)
                MySQL_atualiza(_sql)

                tbDescricao.Text = String.Empty

                '... LIBERA NO boletimweb, PARA SINCRONIZAR ...
                BoletimWeb_Status("delib11_descricao", "1")
                MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")
            End If
        End If

        RefreshDescricao()
        RefreshCategoria(False)
    End Sub

    Private Sub ViewDescricao_Click(sender As Object, e As EventArgs) Handles ViewDescricao.Click

        Try
            ViewDescricao.PostEditor()

            Dim info As GridHitInfo = ViewDescricao.CalcHitInfo(gridDescricao.PointToClient(Cursor.Position))
            _nrodescricaoClicada = ViewDescricao.GetRowCellDisplayText(info.RowHandle,
                                                                       ViewDescricao.Columns("idDelib_des"))
            _nomedescricaoClicada = ViewDescricao.GetRowCellDisplayText(info.RowHandle,
                                                                        ViewDescricao.Columns("Descricao"))

            tbDescricao.Text = _nomedescricaoClicada

            btDescricaoAlt.Enabled = True

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ViewDescricao_RowStyle(sender As Object, e As RowStyleEventArgs) Handles ViewDescricao.RowStyle

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim category = View.GetRowCellDisplayText(e.RowHandle, View.Columns("CodigoBloqueado"))
            If category = "0" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.White
            Else
                e.Appearance.BackColor = Color.LightSalmon
                e.Appearance.BackColor2 = Color.White
            End If
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemCheckEdit1.CheckedChanged

        ViewDescricao.PostEditor()

        Dim info As GridHitInfo = ViewDescricao.CalcHitInfo(gridDescricao.PointToClient(Cursor.Position))
        _nrocategoriaEscolhida = ViewDescricao.GetRowCellDisplayText(info.RowHandle,
                                                                     ViewDescricao.Columns("idDelib_cat"))
        _nrodescricaoClicada = ViewDescricao.GetRowCellDisplayText(info.RowHandle, ViewDescricao.Columns("idDelib_des"))

        Dim obj As CheckEdit = sender
        If obj.Checked = False Then
            ' Se estiver bloqueado, e quer desbloquear...
            _sql =
                String.Format(
                    "UPDATE delib11_descricao SET bloqueado='0' WHERE idDelib_des='{0}' AND idDelib_cat='{1}';",
                    _nrodescricaoClicada, _nrocategoriaEscolhida)
            MySQL_atualiza(_sql)
            MsgBox("Desbloqueado com sucesso!", MsgBoxStyle.Information, "Sucesso!")
        Else
            ' Se estiver desbloqueado, e quer bloquear...
            _sql =
                String.Format(
                    "UPDATE delib11_descricao SET bloqueado='1' WHERE idDelib_des='{0}' AND idDelib_cat='{1}';",
                    _nrodescricaoClicada, _nrocategoriaEscolhida)
            MySQL_atualiza(_sql)
            MsgBox("Bloqueado com sucesso!", MsgBoxStyle.Information, "Sucesso!")
        End If

        tbDescricao.Text = String.Empty
        btDescricaoAlt.Enabled = False

        RefreshDescricao()
        RefreshCategoria(False)
    End Sub

    Private Sub ViewCategorias_Click(sender As Object, e As EventArgs) Handles ViewCategorias.Click

        Try
            ViewCategorias.PostEditor()

            Dim info As GridHitInfo = ViewCategorias.CalcHitInfo(gridCategorias.PointToClient(Cursor.Position))
            _nrocategoriaEscolhida = ViewCategorias.GetRowCellDisplayText(info.RowHandle,
                                                                          ViewCategorias.Columns("idDelib_cat"))

            btCategoriaAlt.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
End Class