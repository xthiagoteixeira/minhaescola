Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting

Public Class frmAdmDisciplinas

    Dim nrodisciplina_clicada = 0
    Dim nomedisciplina_clicada = String.Empty

    Public Sub RefreshDisciplinas()
        Try
            SQL =
                "SELECT Disciplina, Area, Bloqueado, codigo_disc AS Codigo, Bloqueado AS CodigoBloqueado FROM disciplinas ORDER BY bloqueado, disciplina ASC;"
            gridDisciplinas.DataSource = Nothing
            gridDisciplinas.DataSource = MySQL_datatable(SQL)

            RepositoryItemCheckEdit1.ValueChecked = Convert.ToByte(1)
            RepositoryItemCheckEdit1.ValueUnchecked = Convert.ToByte(0)

            viewDisciplina.Columns(0).OptionsColumn.AllowEdit = False
            viewDisciplina.Columns(1).OptionsColumn.AllowEdit = True
            viewDisciplina.Columns(1).ColumnEdit = RepositoryItemComboBox1

            RepositoryItemComboBox1.Items.Clear()
            RepositoryItemComboBox1.Items.Add("Ciências da Natureza")
            RepositoryItemComboBox1.Items.Add("Ciências Humanas")
            RepositoryItemComboBox1.Items.Add("Linguagens e Códigos")
            RepositoryItemComboBox1.Items.Add("Matemática")
            RepositoryItemComboBox1.Items.Add("Diversificada")
            RepositoryItemComboBox1.Items.Add("Atividades Complementares")

            viewDisciplina.Columns(2).OptionsColumn.AllowEdit = True
            viewDisciplina.Columns(2).ColumnEdit = RepositoryItemCheckEdit1
            viewDisciplina.Columns(3).Visible = False
            viewDisciplina.Columns(4).Visible = False

            btAlterar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmAdmDisciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmAdmDisciplinas"
        RefreshDisciplinas()
    End Sub

    Private Sub btCadastrar_Click(sender As Object, e As EventArgs) Handles btCadastrar.Click

        ' Dim JaExiste = False

        If Not tbDisciplina.Text = String.Empty Then

            If _
                MsgBox(String.Format("Efetuar o cadastro de: {0} ?", tbDisciplina.Text), MsgBoxStyle.YesNo, "Alteração") =
                DialogResult.No Then
                MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                Exit Sub
            Else
                Dim Nome
                Dim Sql = String.Format("SELECT disciplina FROM disciplinas WHERE disciplina LIKE '{0}';",
                                        tbDisciplina.Text)
                Nome = MySQL_consulta_campo(Sql, "disciplina")

                If Nome <> "0" Then
                    MsgBox("Já existe uma disciplina cadastrada!", MsgBoxStyle.Information, "Alteração")
                    Exit Sub
                Else
                    tbDisciplina.Text = Trim(tbDisciplina.Text)
                    Sql = String.Format("INSERT INTO disciplinas (disciplina, bloqueado) VALUES ('{0}', '0');",
                                        tbDisciplina.Text)
                    MySQL_atualiza(Sql)

                    arquivoLog("Administrativo", String.Format("Cadastrou a disciplina: " & tbDisciplina.Text))
                    tbDisciplina.Text = String.Empty

                    ' LIBERA NO boletimweb, PARA SINCRONIZAR...
                    Sql = "UPDATE boletimweb SET sincronizado='1' WHERE tabela='disciplinas';"
                    MySQL_atualiza(Sql)

                    MsgBox("Disciplina inserida com sucesso!", MsgBoxStyle.Information, "Alteração")
                    RefreshDisciplinas()
                End If
            End If
        Else
            MsgBox("Preencha o campo!", MsgBoxStyle.Information, "Informação!")
        End If

        tbDisciplina.Text = String.Empty
    End Sub

    Private Sub btAlterar_Click(sender As Object, e As EventArgs) Handles btAlterar.Click

        If _
            MsgBox(
                String.Format("Efetuar a alteração: {0}De: [{1}] {0}Para: [{2}] ?", vbCrLf, nomedisciplina_clicada,
                              tbDisciplina.Text), MsgBoxStyle.YesNo, "Alteração") = DialogResult.No Then
            MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
            Exit Sub
        Else

            ''''INICIA ALTERACAO''''
            SQL = String.Format("SELECT disciplina FROM disciplinas WHERE disciplina LIKE '{0}';", tbDisciplina.Text)
            Dim Nome = MySQL_consulta_campo(SQL, "disciplina")

            If Nome <> "0" Then
                MsgBox("Já existe uma disciplina cadastrada!", MsgBoxStyle.Information, "Alteração")
                Exit Sub
            Else

                tbDisciplina.Text = Trim(tbDisciplina.Text)
                SQL = String.Format("UPDATE disciplinas SET disciplina='{0}' WHERE codigo_disc='{1}';",
                                    tbDisciplina.Text, nrodisciplina_clicada)
                MySQL_atualiza(SQL)

                arquivoLog("Administrativo",
                           String.Format(
                               "Alterou a disciplina: " & nomedisciplina_clicada & " para: " & tbDisciplina.Text))
                tbDisciplina.Text = String.Empty

                ' LIBERA NO boletimweb, PARA SINCRONIZAR...
                SQL = "UPDATE boletimweb SET sincronizado='1' WHERE tabela='disciplinas';"
                MySQL_atualiza(SQL)

                MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")
                RefreshDisciplinas()

            End If
        End If
    End Sub

    Private Sub viewDisciplina_RowClick(sender As Object, e As RowClickEventArgs) Handles viewDisciplina.RowClick

        Dim View As GridView = sender
        nrodisciplina_clicada = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Codigo"))
        nomedisciplina_clicada = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Disciplina"))

        tbDisciplina.Text = nomedisciplina_clicada
        btAlterar.Enabled = True
    End Sub

    Private Sub viewDisciplina_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewDisciplina.RowStyle

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

        viewDisciplina.PostEditor()

        '  Dim View As GridView = sender
        Dim info As GridHitInfo = viewDisciplina.CalcHitInfo(gridDisciplinas.PointToClient(Cursor.Position))
        nomedisciplina_clicada = viewDisciplina.GetRowCellDisplayText(info.RowHandle,
                                                                      viewDisciplina.Columns("Disciplina"))
        nrodisciplina_clicada = viewDisciplina.GetRowCellDisplayText(info.RowHandle, viewDisciplina.Columns("Codigo"))

        ' Disciplina...
        Dim obj As CheckEdit = sender
        If obj.Checked = True Then

            SQL = String.Format("UPDATE disciplinas SET bloqueado='1' WHERE codigo_disc='{0}';", nrodisciplina_clicada)
            MySQL_atualiza(SQL)
            arquivoLog("Administrativo", String.Format("Bloqueou a disciplina: " & nomedisciplina_clicada))

        Else

            SQL = String.Format("UPDATE disciplinas SET bloqueado='0' WHERE codigo_disc='{0}'", nrodisciplina_clicada)
            MySQL_atualiza(SQL)
            arquivoLog("Administrativo", String.Format("Desbloqueou a disciplina: " & nomedisciplina_clicada))


        End If

        ' LIBERA NO boletimweb, PARA SINCRONIZAR...
        SQL = "UPDATE boletimweb SET sincronizado='1' WHERE tabela='disciplinas';"
        MySQL_atualiza(SQL)
        RefreshDisciplinas()
    End Sub

    Private Sub RepositoryItemComboBox1_Click(sender As Object, e As EventArgs) Handles RepositoryItemComboBox1.Click

        Dim info As GridHitInfo = viewDisciplina.CalcHitInfo(gridDisciplinas.PointToClient(Cursor.Position))
        nrodisciplina_clicada = viewDisciplina.GetRowCellDisplayText(info.RowHandle, viewDisciplina.Columns("Codigo"))
    End Sub

    Private Sub RepositoryItemComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles RepositoryItemComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub RepositoryItemComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemComboBox1.SelectedIndexChanged
        ' Periodo...
        '
        Dim edit As ComboBoxEdit = sender
        SQL = "UPDATE disciplinas SET area='" & edit.EditValue & "' WHERE codigo_disc='" & nrodisciplina_clicada & "';"
        MySQL_atualiza(SQL)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        frmPreview_Titulo = "Relatório: Gerenciar Disciplinas"
        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridDisciplinas}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()

    End Sub
End Class