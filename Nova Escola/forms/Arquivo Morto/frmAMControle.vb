Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting

Public Class frmAMControle
    Dim ArquivoMorto = "-"
    Dim codigoFicha = 0, codigo_AMe = 0, codigo_AMp = 0, codigo_AMc = 0, codigo_AMt = 0

    Sub Inicializar()

        ArquivoMorto = "-"

        gridMovimentacao.DataSource = Nothing
        'cbLocalizacao_Corredor.EditValue = ""
        'cbLocalizacao_Estante.EditValue = ""
        'cbLocalizacao_Prateleira.EditValue = ""
        cbLocalizar.Text = String.Empty
        'btLocalizacao_Salvar.Enabled = False

        gridPesquisa.DataSource = Nothing
        cbMov_Data.EditValue = String.Empty
        tbMov_Descricao.EditValue = String.Empty
        cbMov_Tipo.EditValue = String.Empty
        btMovimentacao_Salvar.Enabled = False
    End Sub

    Sub campos_FichaLocalizacao(Liberar As Boolean)

        If Liberar = False Then
            'cbLocalizacao_Corredor.Enabled = False
            'cbLocalizacao_Estante.Enabled = False
            'cbLocalizacao_Prateleira.Enabled = False
            tbLocalizacao_Pasta.Enabled = False

            'cbLocalizacao_Corredor.EditValue = ""
            'cbLocalizacao_Estante.EditValue = ""
            'cbLocalizacao_Prateleira.EditValue = ""
            tbLocalizacao_Pasta.EditValue = String.Empty

            'btLocalizacao_Salvar.Enabled = False

        ElseIf Liberar = True Then

            ' cbLocalizacao_Corredor.Enabled = True
            'cbLocalizacao_Estante.Enabled = True
            ' cbLocalizacao_Prateleira.Enabled = True
            tbLocalizacao_Pasta.Enabled = True

            'cbLocalizacao_Corredor.EditValue = ""
            'cbLocalizacao_Estante.EditValue = ""
            'cbLocalizacao_Prateleira.EditValue = ""
            tbLocalizacao_Pasta.EditValue = String.Empty

            'btLocalizacao_Salvar.Enabled = True

        End If
    End Sub

    Sub campos_FichaMovimentacao(Liberar As Boolean)

        If Liberar = False Then
            gridMovimentacao.DataSource = Nothing
            cbMov_Data.Enabled = False
            cbMov_Data.EditValue = String.Empty
            cbMov_Data.ClosePopup()

            cbMov_Tipo.Enabled = False
            cbMov_Tipo.EditValue = String.Empty
            cbMov_Tipo.ClosePopup()

            tbMov_Descricao.Enabled = False
            btMovimentacao_Salvar.Enabled = False

        ElseIf Liberar = True Then
            cbMov_Data.Enabled = True
            cbMov_Data.EditValue = String.Empty
            cbMov_Data.ClosePopup()

            cbMov_Tipo.Enabled = True
            cbMov_Tipo.EditValue = String.Empty
            cbMov_Tipo.ClosePopup()

            tbMov_Descricao.Enabled = True
            btMovimentacao_Salvar.Enabled = True

        End If

        tbMov_Descricao.Text = String.Empty
    End Sub

    Sub Ficha_Aluno(Busca As String, Procurar As String)

        Try
            SQL =
                "SELECT CODIGO AS RM, Nome, date_format(DT_NASC,'%d/%m/%Y') AS Nascimento, ArquivoMorto(INSCRICAO) AS ArquivoMorto, INSCRICAO, ArquivoMorto_corredor(INSCRICAO) AS Corredor, ArquivoMorto_estante(INSCRICAO) AS Estante, ArquivoMorto_prateleira(INSCRICAO) AS Prateleira FROM aluno_ficha"
            If Procurar = "Nascimento" Then
                SQL += String.Format(" WHERE DT_NASC='{0}' ORDER BY CODIGO, Nome ASC;",
                                     Format(CDate(Busca), "yyyy-MM-dd"))
            ElseIf Procurar = "Nome" Then
                SQL += String.Format(" WHERE NOME like '%{0}%' ORDER BY CODIGO, Nome ASC;", Busca)
            ElseIf Procurar = "Mãe" Then
                SQL += String.Format(" WHERE MAE like '%{0}%' ORDER BY CODIGO, Nome ASC;", Busca)
            ElseIf Procurar = "RM" Then
                SQL += String.Format(" WHERE CODIGO like '%{0}%' ORDER BY CODIGO, Nome ASC;", Busca)
            ElseIf Procurar = "RA" Then
                SQL += String.Format(" WHERE RA like '%{0}%' ORDER BY CODIGO, Nome ASC;", Busca)
            ElseIf Procurar = "Todos" Then
                SQL += String.Format(" ORDER BY Nome ASC;")
            End If
            viewPesquisa.Columns.Clear()
            gridPesquisa.DataSource = Nothing
            gridPesquisa.DataSource = MySQL_datatable(SQL)

            ' ... Alinhar
            viewPesquisa.Columns(0).Width = "40"
            viewPesquisa.Columns(1).Width = "160"
            viewPesquisa.Columns(2).Width = "60"
            viewPesquisa.Columns(3).Visible = False
            viewPesquisa.Columns(4).Visible = False

            viewPesquisa.Columns(0).OptionsColumn.AllowEdit = False
            viewPesquisa.Columns(1).OptionsColumn.AllowEdit = False
            viewPesquisa.Columns(2).OptionsColumn.AllowEdit = False

            viewPesquisa.Columns(5).OptionsColumn.AllowEdit = True
            viewPesquisa.Columns(6).OptionsColumn.AllowEdit = True
            viewPesquisa.Columns(7).OptionsColumn.AllowEdit = True

            viewPesquisa.Columns(5).ColumnEdit = RepositoryItemComboBox1
            viewPesquisa.Columns(6).ColumnEdit = RepositoryItemComboBox2
            viewPesquisa.Columns(7).ColumnEdit = RepositoryItemComboBox3

            '' Preenche ArquivoMorto_Prateleira
            SQL = "SELECT prateleira FROM arquivomorto_prateleira WHERE bloqueado='0' ORDER BY prateleira;"
            Dim Prateleira = MySQL_combobox(SQL)
            RepositoryItemComboBox3.Items.Clear()
            For Each r In Prateleira.Rows
                RepositoryItemComboBox3.Items.Add(r("prateleira"))
            Next

            ' Preenche ArquivoMorto_Estante
            SQL = "SELECT estante FROM arquivomorto_estante WHERE bloqueado='0' ORDER BY estante;"
            Dim Estante = MySQL_combobox(SQL)
            RepositoryItemComboBox2.Items.Clear()
            For Each r In Estante.Rows
                RepositoryItemComboBox2.Items.Add(r("estante"))
            Next

            ' Preenche ArquivoMorto_Corredor
            SQL = "SELECT corredor FROM arquivomorto_corredor WHERE bloqueado='0' ORDER BY corredor;"
            Dim Corredor = MySQL_combobox(SQL)
            RepositoryItemComboBox1.Items.Clear()
            For Each r In Corredor.Rows
                RepositoryItemComboBox1.Items.Add(r("corredor"))
            Next

            ' ''... Adiciona as colunas...
            Dim col = New GridColumn() _
                    With {.ColumnEdit = RepositoryItemButtonEdit1, .Width = 30, .Caption = "Editar", .FieldName = String.Empty,
                    .VisibleIndex = 8, .ShowButtonMode = ShowButtonModeEnum.ShowAlways}
            Dim col2 = New GridColumn() _
                    With {.ColumnEdit = RepositoryItemButtonEdit2, .Width = 30, .Caption = "Excluir", .FieldName = String.Empty,
                    .VisibleIndex = 9, .ShowButtonMode = ShowButtonModeEnum.ShowAlways}
            viewPesquisa.Columns.Add(col)
            viewPesquisa.Columns.Add(col2)

        Catch ex As Exception

        End Try
    End Sub

    Sub ArquivoMorto_Movimentacao(numeroArquivoMorto As Integer)
        Try
            ' Preenche a Movimentacao ...
            SQL = String.Format("SELECT arquivomorto_movimentacao.idAM_m AS Codigo, arquivomorto_movimentacao.Data, arquivomorto_tipo.Tipo, arquivomorto_movimentacao.Descricao, usuariodsk.Usuario FROM arquivomorto_movimentacao INNER JOIN arquivomorto_tipo ON arquivomorto_movimentacao.idAM_t = arquivomorto_tipo.idAM_t INNER JOIN usuariodsk ON arquivomorto_movimentacao.idUsuarioDSK = usuariodsk.codigo WHERE arquivomorto_movimentacao.idAM='{0}' ORDER BY arquivomorto_movimentacao.data ASC;",
                    numeroArquivoMorto)
            gridMovimentacao.DataSource = Nothing
            gridMovimentacao.DataSource = MySQL_datatable(SQL)

            'Alinhar...
            viewMovimentacao.Columns(0).Visible = False
            viewMovimentacao.Columns(1).Width = "30"
            viewMovimentacao.Columns(2).Width = "50"
            viewMovimentacao.Columns(3).Width = "100"
            viewMovimentacao.Columns(4).Width = "30"

            campos_FichaMovimentacao(True)
        Catch ex As Exception

        End Try
    End Sub

    'Sub ArquivoMorto_Localizacao(numeroRM As Integer)

    '    ' Preenche a Localização...
    '    ' SQL = String.Format("SELECT arquivomorto.RM, arquivomorto.Pasta, arquivomorto_corredor.corredor AS Corredor, arquivomorto_prateleira.prateleira AS Prateleira, arquivomorto_estante.estante AS Estante, arquivomorto.idAM FROM arquivomorto INNER JOIN arquivomorto_corredor ON arquivomorto.idAM_c = arquivomorto_corredor.idAM_c INNER JOIN arquivomorto_prateleira ON arquivomorto.idAM_p = arquivomorto_prateleira.idAM_p INNER JOIN arquivomorto_estante ON arquivomorto.idAM_e = arquivomorto_estante.idAM_e WHERE arquivomorto.RM='{0}';", numeroRM)
    '    'Dim MeuResultado = MySQL_datatable(SQL)
    '    'Dim r = MeuResultado.Rows(0)

    '    'Corredor
    '    'cbLocalizacao_Corredor.Text = r("Corredor").ToString
    '    'Estante
    '    'cbLocalizacao_Estante.Text = r("Estante").ToString
    '    'Prateleira
    '    ' cbLocalizacao_Prateleira.Text = r("Prateleira").ToString
    '    'Pasta...
    '    ' tbLocalizacao_Pasta.Text = r("Pasta").ToString

    '    ' cbLocalizacao_Estante.ClosePopup()
    '    ' cbLocalizacao_Prateleira.ClosePopup()
    '    'cbLocalizacao_Corredor.ClosePopup()

    '    ''Código do Arquivo Morto
    '    'ArquivoMorto = MySQL_consulta_campo(SQL, "arquivomorto.idAM")
    '    'If ArquivoMorto <> 0 Then
    '    '    ArquivoMorto_Movimentacao(ArquivoMorto)
    '    'End If
    'End Sub

    Private Sub frmAMControle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmAMControle"

        ' Preenche ArquivoMorto_Tipo
        SQL = "SELECT tipo FROM arquivomorto_tipo WHERE bloqueado='0' ORDER BY tipo;"
        cbMov_Tipo.Properties.DataSource = MySQL_combobox(SQL)
        cbMov_Tipo.Properties.DisplayMember = "tipo"

        Ficha_Aluno(String.Empty, "Todos")
    End Sub

    Private Sub cbLocalizar_TextChanged(sender As Object, e As EventArgs) Handles cbLocalizar.TextChanged

        If cbLocalizar.Text = "Nascimento" Then
            tbLocalizar_Pesquisa.Enabled = True
            tbLocalizar_Pesquisa.Properties.Mask.EditMask = "\d?\d?/\d?\d?/\d\d\d\d"
            tbLocalizar_Pesquisa.Text = String.Empty
            tbLocalizar_Pesquisa.Properties.Mask.MaskType = MaskType.Regular

        ElseIf cbLocalizar.Text = "Todos" Then
            tbLocalizar_Pesquisa.Enabled = False
            tbLocalizar_Pesquisa.Properties.Mask.EditMask = String.Empty
            tbLocalizar_Pesquisa.Text = String.Empty
            tbLocalizar_Pesquisa.Properties.Mask.MaskType = MaskType.None
            Ficha_Aluno(String.Empty, "Todos")

        Else
            tbLocalizar_Pesquisa.Enabled = True
            tbLocalizar_Pesquisa.Properties.Mask.EditMask = String.Empty
            tbLocalizar_Pesquisa.Text = String.Empty
            tbLocalizar_Pesquisa.Properties.Mask.MaskType = MaskType.None

        End If
    End Sub

    'Private Sub btSalvar_Click(sender As Object, e As EventArgs)

    '    If tbLocalizacao_Pasta.Text <> "" Then

    '        If ArquivoMorto <> "-" Then
    '            ' Salva e Passa o Número do Arquivo Morto...
    '            SQL = String.Format("UPDATE arquivomorto SET Pasta='{0}', idAM_e='{1}', idAM_p='{2}', idAM_c='{3}' WHERE idAM='{4}';", tbLocalizacao_Pasta.Text, codigo_AMe, codigo_AMp, codigo_AMc, ArquivoMorto)
    '            MySQL_atualiza(SQL)
    '        Else
    '            ' Salva e Passa o Número do Arquivo Morto...
    '            SQL = String.Format("INSERT INTO arquivomorto (RM, Pasta, idAM_e, idAM_p, idAM_c) VALUES('{0}','{1}','{2}','{3}','{4}'); SELECT LAST_INSERT_ID() AS idAM;", codigo_RM, tbLocalizacao_Pasta.Text, codigo_AMe, codigo_AMp, codigo_AMc)
    '            ArquivoMorto = MySQL_atualiza(SQL).ToString
    '        End If

    '        campos_FichaMovimentacao(True)
    '        Ficha_Aluno(tbLocalizar_Pesquisa.Text, cbLocalizar.Text)

    '    Else
    '        MsgBox("Preencher os campos!", MsgBoxStyle.Information, "Controle de Registros")
    '    End If

    'End Sub

    Private Sub btMov_Adicionar_Click(sender As Object, e As EventArgs) Handles btMovimentacao_Salvar.Click

        If ArquivoMorto <> "-" Then
            If tbMov_Descricao.Text = String.Empty Or cbMov_Data.Text = String.Empty Or cbMov_Tipo.Text = String.Empty Then
                MsgBox("Preencher os campos!", MsgBoxStyle.Information, "Controle de Registros")
            Else
                'Pega o código do Arquivo Morto, e adiciona a movimentação.
                SQL =
                    String.Format(
                        "INSERT INTO arquivomorto_movimentacao (idAM, data, idUsuarioDSK, idAM_t, descricao) VALUES('{0}', '{1}', '{2}', '{3}', '{4}');",
                        ArquivoMorto, Format(CDate(cbMov_Data.Text), "yyyy-MM-dd"), idUsuarioDSK, codigo_AMt,
                        tbMov_Descricao.Text)
                MySQL_atualiza(SQL)
                ArquivoMorto_Movimentacao(ArquivoMorto)

            End If
        End If
    End Sub

    Private Sub tbLocalizar_Pesquisa_Click(sender As Object, e As EventArgs) Handles tbLocalizar_Pesquisa.Click
        If tbLocalizar_Pesquisa.Text <> String.Empty Then
            tbLocalizar_Pesquisa.SelectAll()
        End If
    End Sub

    Private Sub tbLocalizar_Pesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles tbLocalizar_Pesquisa.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If tbLocalizar_Pesquisa.Text <> String.Empty And cbLocalizar.Text <> String.Empty Then
                Ficha_Aluno(tbLocalizar_Pesquisa.Text, cbLocalizar.Text)
            Else
                MsgBox("Preencher os campos!", MsgBoxStyle.Information, "Procura")
            End If
        End If
    End Sub

    Private Sub pbPesquisar_Click(sender As Object, e As EventArgs) Handles pbPesquisar.Click

        If tbLocalizar_Pesquisa.Text <> String.Empty And cbLocalizar.Text <> String.Empty Then
            Ficha_Aluno(tbLocalizar_Pesquisa.Text, cbLocalizar.Text)
        Else
            MsgBox("Preencher os campos!", MsgBoxStyle.Information, "Procura")
        End If
    End Sub

    Private Sub viewPesquisa_RowClick(sender As Object, e As RowClickEventArgs) Handles viewPesquisa.RowClick

        Dim View As GridView = sender
        ArquivoMorto = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ArquivoMorto")).ToString
        codigoFicha = View.GetRowCellDisplayText(e.RowHandle, View.Columns("INSCRICAO")).ToString
        Dim nomeAluno = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Nome")).ToString

        grupoMovimentacao.Text = "Movimentação de Documentos - Nome: [ " & nomeAluno & " ]"

        If ArquivoMorto = "-" Then
            campos_FichaMovimentacao(False)
            campos_FichaLocalizacao(True)

        Else
            campos_FichaMovimentacao(True)
            campos_FichaLocalizacao(True)

            ' Refresh Movimentação...
            'ArquivoMorto_Localizacao(codigoFicha)
            ArquivoMorto_Movimentacao(ArquivoMorto)
        End If
    End Sub

    Private Sub viewPesquisa_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewPesquisa.RowStyle

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim category = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ArquivoMorto"))

            If category <> "-" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.White
            Else
                e.Appearance.BackColor = Color.Yellow
                e.Appearance.BackColor2 = Color.White
            End If
        End If
    End Sub

    Private Sub cbMov_Tipo_TextChanged(sender As Object, e As EventArgs) Handles cbMov_Tipo.TextChanged
        SQL = String.Format("SELECT idAM_t, tipo FROM arquivomorto_tipo WHERE bloqueado='0' AND tipo='{0}';", cbMov_Tipo.Text)
        codigo_AMt = MySQL_consulta_campo(SQL, "idAM_t")
    End Sub

    Private Sub viewMovimentacao_RowClick(sender As Object, e As RowClickEventArgs) Handles viewMovimentacao.RowClick

        Dim View As GridView = sender
        Dim CodigoMovimentacao = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Codigo")).ToString

        Dim vStrMsg As String = MsgBox("Deseja excluir este item?", MsgBoxStyle.YesNo, "Movimentação")
        If vStrMsg = MsgBoxResult.Yes Then
            SQL = String.Format("DELETE FROM arquivomorto_movimentacao WHERE idAM_m='{0}';", CodigoMovimentacao)
            MySQL_atualiza(SQL)
            ArquivoMorto_Movimentacao(ArquivoMorto)
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) _
        Handles RepositoryItemButtonEdit1.Click
        ' Mostra a Ficha Completa
        viewPesquisa.PostEditor()

        Dim info As GridHitInfo = viewPesquisa.CalcHitInfo(gridPesquisa.PointToClient(Cursor.Position))
        Dim RM = viewPesquisa.GetRowCellDisplayText(info.RowHandle, viewPesquisa.Columns("RM")).ToString

        fCadAlunoFichaCompleta_RM = RM

        Dim fCadAlunoFichaCompleta As New frmCadAlunoFichaCompleta(RM) With {.MdiParent = frmPrincipal}
        fCadAlunoFichaCompleta.Show()
    End Sub

    Private Sub RepositoryItemButtonEdit2_Click(sender As Object, e As EventArgs) _
        Handles RepositoryItemButtonEdit2.Click

        viewPesquisa.PostEditor()
        Dim info As GridHitInfo = viewPesquisa.CalcHitInfo(gridPesquisa.PointToClient(Cursor.Position))
        Dim nomeAluno = viewPesquisa.GetRowCellDisplayText(info.RowHandle, viewPesquisa.Columns("Nome"))
        Dim INSCRICAO = viewPesquisa.GetRowCellDisplayText(info.RowHandle, viewPesquisa.Columns("INSCRICAO"))

        Dim vStrMsg As DialogResult = MessageBox.Show((String.Format("Deseja excluir o aluno [{0}]?", nomeAluno)), "Excluir",
                                                      MessageBoxButtons.YesNo)
        If vStrMsg = DialogResult.Yes Then

            SQL = String.Format("SELECT file_id FROM aluno_ficha WHERE INSCRICAO='" & INSCRICAO & "';")
            Dim codigoFoto = MySQL_consulta_campo(SQL, "file_id")

            SQL = String.Format("DELETE FROM file WHERE file_id='" & codigoFoto & "';")
            MySQL_atualiza(SQL)
            SQL = String.Format("DELETE FROM arquivomorto WHERE INSCRICAO='" & INSCRICAO & "';")
            MySQL_atualiza(SQL)
            SQL = String.Format("DELETE FROM aluno_ficha WHERE INSCRICAO='" & INSCRICAO & "';")
            MySQL_atualiza(SQL)
            Ficha_Aluno(tbLocalizar_Pesquisa.Text, cbLocalizar.Text)

        End If
    End Sub

    Private Sub RepositoryItemComboBox1_Click(sender As Object, e As EventArgs) Handles RepositoryItemComboBox1.Click
        ' Corredor...
        viewPesquisa.PostEditor()
        Dim info As GridHitInfo = viewPesquisa.CalcHitInfo(gridPesquisa.PointToClient(Cursor.Position))
        codigoFicha = viewPesquisa.GetRowCellDisplayText(info.RowHandle, viewPesquisa.Columns("INSCRICAO"))
    End Sub

    Private Sub RepositoryItemComboBox1_EditValueChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemComboBox1.EditValueChanged

        Dim edit As ComboBoxEdit = sender

        If edit.EditValue <> String.Empty Then

            ' Pega o Código do Corredor...
            SQL = "SELECT idAM_c FROM arquivomorto_corredor WHERE bloqueado='0' AND corredor='" & edit.EditValue & "';"
            Dim codigoCorredor = MySQL_consulta_campo(SQL, "idAM_c")

            ' Tenta Atualizar...
            SQL =
                String.Format(
                    "UPDATE arquivomorto SET idAM_c='" & codigoCorredor & "' WHERE INSCRICAO='" & codigoFicha & "';")
            Dim Retorno = MySQL_atualiza(SQL)
            If Retorno = "0" Then
                ' Insere...
                SQL = "INSERT INTO arquivomorto (INSCRICAO, idAM_c) VALUES ('" & codigoFicha & "','" & codigoCorredor &
                      "');"
                MySQL_atualiza(SQL)
            End If
            Ficha_Aluno(tbLocalizar_Pesquisa.Text, cbLocalizar.Text)

        End If
    End Sub

    Private Sub RepositoryItemComboBox2_Click(sender As Object, e As EventArgs) Handles RepositoryItemComboBox2.Click
        ' Estante...
        viewPesquisa.PostEditor()
        Dim info As GridHitInfo = viewPesquisa.CalcHitInfo(gridPesquisa.PointToClient(Cursor.Position))
        codigoFicha = viewPesquisa.GetRowCellDisplayText(info.RowHandle, viewPesquisa.Columns("INSCRICAO"))
    End Sub

    Private Sub RepositoryItemComboBox2_EditValueChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemComboBox2.EditValueChanged


        Dim edit As ComboBoxEdit = sender

        If edit.EditValue <> String.Empty Then

            ' Pega o Código do Corredor...
            SQL = "SELECT idAM_e FROM arquivomorto_estante WHERE bloqueado='0' AND estante='" & edit.EditValue & "';"
            Dim codigoEstante = MySQL_consulta_campo(SQL, "idAM_e")

            ' Tenta Atualizar...
            SQL =
                String.Format(
                    "UPDATE arquivomorto SET idAM_e='" & codigoEstante & "' WHERE INSCRICAO='" & codigoFicha & "';")
            Dim Retorno = MySQL_atualiza(SQL)
            If Retorno = "0" Then
                ' Insere...
                SQL = "INSERT INTO arquivomorto (INSCRICAO, idAM_e) VALUES ('" & codigoFicha & "','" & codigoEstante &
                      "');"
                MySQL_atualiza(SQL)
            End If
            Ficha_Aluno(tbLocalizar_Pesquisa.Text, cbLocalizar.Text)

        End If
    End Sub

    Private Sub cbMov_Tipo_EditValueChanged(sender As Object, e As EventArgs) Handles cbMov_Tipo.EditValueChanged

    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        frmPreview_Titulo = String.Format("Relatório: Arquivo Morto")

        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridPesquisa}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()

    End Sub

    Private Sub RepositoryItemComboBox3_Click(sender As Object, e As EventArgs) Handles RepositoryItemComboBox3.Click
        viewPesquisa.PostEditor()
        Dim info As GridHitInfo = viewPesquisa.CalcHitInfo(gridPesquisa.PointToClient(Cursor.Position))
        codigoFicha = viewPesquisa.GetRowCellDisplayText(info.RowHandle, viewPesquisa.Columns("INSCRICAO"))
    End Sub

    Private Sub RepositoryItemComboBox3_EditValueChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemComboBox3.EditValueChanged

        Dim edit As ComboBoxEdit = sender

        If edit.EditValue <> String.Empty Then

            ' Pega o Código do Corredor...
            SQL = "SELECT idAM_p FROM arquivomorto_prateleira WHERE bloqueado='0' AND prateleira='" & edit.EditValue &
                  "';"
            Dim codigoPrateleira = MySQL_consulta_campo(SQL, "idAM_p")

            ' Tenta Atualizar...
            SQL =
                String.Format(
                    "UPDATE arquivomorto SET idAM_p='" & codigoPrateleira & "' WHERE INSCRICAO='" & codigoFicha & "';")
            Dim Retorno = MySQL_atualiza(SQL)
            If Retorno = "0" Then
                ' Insere...
                SQL = "INSERT INTO arquivomorto (INSCRICAO, idAM_p) VALUES ('" & codigoFicha & "','" & codigoPrateleira &
                      "');"
                MySQL_atualiza(SQL)
            End If
            Ficha_Aluno(tbLocalizar_Pesquisa.Text, cbLocalizar.Text)

        End If
    End Sub

    Private Sub cbLocalizar_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbLocalizar.SelectedIndexChanged
    End Sub

    Private Sub tbLocalizar_Pesquisa_EditValueChanged(sender As Object, e As EventArgs) _
        Handles tbLocalizar_Pesquisa.EditValueChanged
    End Sub
End Class