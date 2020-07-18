Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmAMGerenciar
    Dim idAM_t = 0, idAM_p = 0, idAM_c = 0, idAM_e = 0

    Sub Acao_Salvar(Nome As String)

        If Nome = "Estante" Then
            SQL = String.Format("INSERT INTO arquivomorto_estante (estante) VALUES ('{0}');", tbEstante.Text)
        ElseIf Nome = "Prateleira" Then
            SQL = String.Format("INSERT INTO arquivomorto_prateleira (prateleira) VALUES ('{0}');", tbPrateleira.Text)
        ElseIf Nome = "Corredor" Then
            SQL = String.Format("INSERT INTO arquivomorto_corredor (corredor) VALUES ('{0}');", tbCorredor.Text)
        ElseIf Nome = "Tipo de Documento" Then
            SQL = String.Format("INSERT INTO arquivomorto_tipo (tipo) VALUES ('{0}');", tbTipoDoc.Text)
        End If
        MySQL_atualiza(SQL)
        MsgBox("Salvo com sucesso!", MsgBoxStyle.Information, "Arquivo Morto")
    End Sub

    Sub Acao_Excluir(Nome As String, Codigo As Integer)


        If Nome = "Estante" Then

            ' Consulta pra saber se está sendo utilizado...
            SQL = "SELECT COUNT(idAM_e) AS Contador FROM arquivomorto;"
            Dim Contador = MySQL_consulta_campo(SQL, "Contador")
            If Contador > 0 Then
                MsgBox("Item já utilizado no sistema, não foi possível excluir.", MsgBoxStyle.Information, "Em uso")
                Exit Sub
            Else
                SQL = String.Format("DELETE FROM arquivomorto_estante WHERE idAM_e='{0}';", Codigo)
            End If

        ElseIf Nome = "Prateleira" Then

            ' Consulta pra saber se está sendo utilizado...
            SQL = "SELECT COUNT(idAM_p) AS Contador FROM arquivomorto;"
            Dim Contador = MySQL_consulta_campo(SQL, "Contador")
            If Contador > 0 Then
                MsgBox("Item já utilizado no sistema, não foi possível excluir.", MsgBoxStyle.Information, "Em uso")
                Exit Sub
            Else
                SQL = String.Format("DELETE FROM arquivomorto_prateleira WHERE idAM_p='{0}';", Codigo)
            End If

        ElseIf Nome = "Corredor" Then

            ' Consulta pra saber se está sendo utilizado...
            SQL = "SELECT COUNT(idAM_c) AS Contador FROM arquivomorto;"
            Dim Contador = MySQL_consulta_campo(SQL, "Contador")
            If Contador > 0 Then
                MsgBox("Item já utilizado no sistema, não foi possível excluir.", MsgBoxStyle.Information, "Em uso")
                Exit Sub
            Else
                SQL = String.Format("DELETE FROM arquivomorto_corredor WHERE idAM_c='{0}';", Codigo)
            End If

        ElseIf Nome = "Tipo de Documento" Then

            ' Consulta pra saber se está sendo utilizado...
            SQL = "SELECT COUNT(idAM_t) AS Contador FROM arquivomorto_movimentacao;"
            Dim Contador = MySQL_consulta_campo(SQL, "Contador")
            If Contador > 0 Then
                MsgBox("Item já utilizado no sistema, não foi possível excluir.", MsgBoxStyle.Information, "Em uso")
                Exit Sub
            Else
                SQL = String.Format("DELETE FROM arquivomorto_tipo WHERE idAM_t='{0}';", Codigo)
            End If

        End If

        Dim Retorno = MySQL_atualiza(SQL)

        If Retorno = 0 Then
            MsgBox("Não foi possível excluir!", MsgBoxStyle.Information, "Arquivo Morto")
        Else
            MsgBox("Excluído com sucesso!", MsgBoxStyle.Information, "Arquivo Morto")
        End If

        Refresh_Controle(Nome)
    End Sub

    Sub Refresh_Controle(Nome As String)

        If Nome = "Estante" Then
            SQL =
                "SELECT Estante, Bloqueado, Bloqueado AS CodigoBloqueado, idAM_e AS codigoEstante FROM arquivomorto_estante ORDER BY Bloqueado, Estante ASC;"
            gridEstantes.DataSource = Nothing
            gridEstantes.DataSource = MySQL_datatable(SQL)
            RepositoryItemCheckEdit1.ValueChecked = Convert.ToByte(1)
            RepositoryItemCheckEdit1.ValueUnchecked = Convert.ToByte(0)
            viewEstantes.Columns(0).OptionsColumn.AllowEdit = False
            viewEstantes.Columns(1).OptionsColumn.AllowEdit = True
            viewEstantes.Columns(1).ColumnEdit = RepositoryItemCheckEdit1
            viewEstantes.Columns(2).Visible = False
            viewEstantes.Columns(3).Visible = False

        ElseIf Nome = "Prateleira" Then
            SQL =
                "SELECT Prateleira, Bloqueado, Bloqueado AS CodigoBloqueado, idAM_p AS codigoPrateleira FROM arquivomorto_prateleira ORDER BY Bloqueado, Prateleira ASC;"
            gridPrateleiras.DataSource = Nothing
            gridPrateleiras.DataSource = MySQL_datatable(SQL)
            RepositoryItemCheckEdit2.ValueChecked = Convert.ToByte(1)
            RepositoryItemCheckEdit2.ValueUnchecked = Convert.ToByte(0)
            viewPrateleiras.Columns(0).OptionsColumn.AllowEdit = False
            viewPrateleiras.Columns(1).OptionsColumn.AllowEdit = True
            viewPrateleiras.Columns(1).ColumnEdit = RepositoryItemCheckEdit2
            viewPrateleiras.Columns(2).Visible = False
            viewPrateleiras.Columns(3).Visible = False

        ElseIf Nome = "Corredor" Then
            SQL =
                "SELECT Corredor, Bloqueado, Bloqueado AS CodigoBloqueado, idAM_c AS codigoCorredor FROM arquivomorto_corredor ORDER BY Bloqueado, Corredor ASC;"
            gridCorredor.DataSource = Nothing
            gridCorredor.DataSource = MySQL_datatable(SQL)
            RepositoryItemCheckEdit3.ValueChecked = Convert.ToByte(1)
            RepositoryItemCheckEdit3.ValueUnchecked = Convert.ToByte(0)
            viewCorredor.Columns(0).OptionsColumn.AllowEdit = False
            viewCorredor.Columns(1).OptionsColumn.AllowEdit = True
            viewCorredor.Columns(1).ColumnEdit = RepositoryItemCheckEdit3
            viewCorredor.Columns(2).Visible = False
            viewCorredor.Columns(3).Visible = False

        ElseIf Nome = "Tipo de Documento" Then
            SQL =
                "SELECT Tipo, Bloqueado, Bloqueado AS CodigoBloqueado, idAM_t AS codigoTipo FROM arquivomorto_tipo ORDER BY Bloqueado, Tipo ASC;"
            gridTipoDoc.DataSource = Nothing
            gridTipoDoc.DataSource = MySQL_datatable(SQL)
            RepositoryItemCheckEdit4.ValueChecked = Convert.ToByte(1)
            RepositoryItemCheckEdit4.ValueUnchecked = Convert.ToByte(0)
            viewTipoDoc.Columns(0).OptionsColumn.AllowEdit = False
            viewTipoDoc.Columns(1).OptionsColumn.AllowEdit = True
            viewTipoDoc.Columns(1).ColumnEdit = RepositoryItemCheckEdit4
            viewTipoDoc.Columns(2).Visible = False
            viewTipoDoc.Columns(3).Visible = False
        End If
    End Sub

    Private Sub frmAMGerenciar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmAMGerenciar"
        ' Refresh em todos.
        Refresh_Controle("Corredor")
        Refresh_Controle("Estante")
        Refresh_Controle("Prateleira")
        Refresh_Controle("Tipo de Documento")
    End Sub

    Private Sub btSalvar_Corredor_Click(sender As Object, e As EventArgs) Handles btSalvar_Corredor.Click

        If tbCorredor.Text <> String.Empty Then
            Acao_Salvar("Corredor")
            Refresh_Controle("Corredor")
        Else
            MsgBox("Preencher os campos!", MsgBoxStyle.Information, "Arquivo Morto")
        End If
    End Sub

    Private Sub btSalvar_Estantes_Click(sender As Object, e As EventArgs) Handles btSalvar_Estante.Click

        If tbEstante.Text <> String.Empty Then
            Acao_Salvar("Estante")
            Refresh_Controle("Estante")
        Else
            MsgBox("Preencher os campos!", MsgBoxStyle.Information, "Arquivo Morto")
        End If
    End Sub

    Private Sub btSalvar_Prateleira_Click(sender As Object, e As EventArgs) Handles btSalvar_Prateleira.Click

        If tbPrateleira.Text <> String.Empty Then
            Acao_Salvar("Prateleira")
            Refresh_Controle("Prateleira")
        Else
            MsgBox("Preencher os campos!", MsgBoxStyle.Information, "Arquivo Morto")
        End If
    End Sub

    Private Sub btSalvar_Tipo_Click(sender As Object, e As EventArgs) Handles btSalvar_Tipo.Click
        If tbTipoDoc.Text <> String.Empty Then
            Acao_Salvar("Tipo de Documento")
            Refresh_Controle("Tipo de Documento")
        Else
            MsgBox("Preencher os campos!", MsgBoxStyle.Information, "Arquivo Morto")
        End If
    End Sub

    Private Sub viewCorredor_RowClick(sender As Object, e As RowClickEventArgs) Handles viewCorredor.RowClick
        Dim View As GridView = sender
        idAM_c = View.GetRowCellDisplayText(e.RowHandle, View.Columns("codigoCorredor"))
        'btExcluir_Corredor.Enabled = True
    End Sub

    Private Sub viewCorredor_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewCorredor.RowStyle

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

    Private Sub viewEstantes_RowClick(sender As Object, e As RowClickEventArgs) Handles viewEstantes.RowClick
        Dim View As GridView = sender
        idAM_e = View.GetRowCellDisplayText(e.RowHandle, View.Columns("codigoEstante"))
        'btExcluir_Estante.Enabled = True
    End Sub

    Private Sub viewEstantes_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewEstantes.RowStyle

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

    Private Sub viewPrateleiras_RowClick(sender As Object, e As RowClickEventArgs) Handles viewPrateleiras.RowClick
        Dim View As GridView = sender
        idAM_p = View.GetRowCellDisplayText(e.RowHandle, View.Columns("codigoPrateleira"))
        ' btExcluir_Prateleira.Enabled = True
    End Sub

    Private Sub viewPrateleiras_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewPrateleiras.RowStyle

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

    Private Sub viewTipoDoc_RowClick(sender As Object, e As RowClickEventArgs) Handles viewTipoDoc.RowClick
        Dim View As GridView = sender
        idAM_t = View.GetRowCellDisplayText(e.RowHandle, View.Columns("codigoTipo"))
        ' btExcluir_TipoDoc.Enabled = True
    End Sub

    Private Sub viewTipoDoc_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewTipoDoc.RowStyle

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

        viewEstantes.PostEditor()

        Dim info As GridHitInfo = viewEstantes.CalcHitInfo(gridEstantes.PointToClient(Cursor.Position))
        Dim idAM_e = viewEstantes.GetRowCellDisplayText(info.RowHandle, viewEstantes.Columns("codigoEstante"))

        Dim obj As CheckEdit = sender
        If obj.Checked = True Then
            SQL = String.Format("UPDATE arquivomorto_estante SET bloqueado='1' WHERE idAM_e='{0}';", idAM_e)
            MySQL_atualiza(SQL)
        Else
            SQL = String.Format("UPDATE arquivomorto_estante SET bloqueado='0' WHERE idAM_e='{0}';", idAM_e)
            MySQL_atualiza(SQL)
        End If

        Refresh_Controle("Estante")
    End Sub

    Private Sub RepositoryItemCheckEdit2_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemCheckEdit2.CheckedChanged
        viewPrateleiras.PostEditor()

        Dim info As GridHitInfo = viewPrateleiras.CalcHitInfo(gridPrateleiras.PointToClient(Cursor.Position))
        Dim idAM_p = viewPrateleiras.GetRowCellDisplayText(info.RowHandle, viewPrateleiras.Columns("codigoPrateleira"))

        Dim obj As CheckEdit = sender
        If obj.Checked = True Then
            SQL = String.Format("UPDATE arquivomorto_prateleira SET bloqueado='1' WHERE idAM_p='{0}';", idAM_p)
            MySQL_atualiza(SQL)
        Else
            SQL = String.Format("UPDATE arquivomorto_prateleira SET bloqueado='0' WHERE idAM_p='{0}';", idAM_p)
            MySQL_atualiza(SQL)
        End If
        Refresh_Controle("Prateleira")
    End Sub

    Private Sub RepositoryItemCheckEdit3_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemCheckEdit3.CheckedChanged

        viewCorredor.PostEditor()

        Dim info As GridHitInfo = viewCorredor.CalcHitInfo(gridCorredor.PointToClient(Cursor.Position))
        Dim idAM_c = viewCorredor.GetRowCellDisplayText(info.RowHandle, viewCorredor.Columns("codigoCorredor"))

        Dim obj As CheckEdit = sender
        If obj.Checked = True Then
            SQL = String.Format("UPDATE arquivomorto_corredor SET bloqueado='1' WHERE idAM_c='{0}';", idAM_c)
            MySQL_atualiza(SQL)
        Else
            SQL = String.Format("UPDATE arquivomorto_corredor SET bloqueado='0' WHERE idAM_c='{0}';", idAM_c)
            MySQL_atualiza(SQL)
        End If
        Refresh_Controle("Corredor")
    End Sub

    Private Sub RepositoryItemCheckEdit4_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemCheckEdit4.CheckedChanged

        viewTipoDoc.PostEditor()

        Dim info As GridHitInfo = viewTipoDoc.CalcHitInfo(gridTipoDoc.PointToClient(Cursor.Position))
        Dim idAM_t = viewTipoDoc.GetRowCellDisplayText(info.RowHandle, viewTipoDoc.Columns("codigoTipo"))

        Dim obj As CheckEdit = sender
        If obj.Checked = True Then
            SQL = String.Format("UPDATE arquivomorto_tipo SET bloqueado='1' WHERE idAM_t='{0}';", idAM_t)
            MySQL_atualiza(SQL)
        Else
            SQL = String.Format("UPDATE arquivomorto_tipo SET bloqueado='0' WHERE idAM_t='{0}';", idAM_t)
            MySQL_atualiza(SQL)
        End If

        Refresh_Controle("Tipo de Documento")
    End Sub
End Class