Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting

Public Class frmManBoletimTela
    Dim _minhaTurma
    Dim MeuBimestre = "1", Teste_UsuarioSistema, codigoBoletim
    Dim ReadOnly delete As New RepositoryItemPictureEdit()
    Dim ReadOnly edit As New RepositoryItemPictureEdit()

    Function Consulta_NroAlunos()

        SQL = "SELECT COUNT(nro) AS NroAlunos FROM aluno WHERE anovigente='" & tAno.Text & "' AND turma='" & Consulta_Turma(ManNF_Global_Turma) & "';"
        nroTotalAlunos = MySQL_consulta_campo(SQL, "NroAlunos")

        Return nroTotalAlunos

    End Function

    Sub edit_Click()

        viewBoletim.PostEditor()

        Dim info As GridHitInfo = viewBoletim.CalcHitInfo(gridBoletim.PointToClient(Cursor.Position))

        ManNF_Global_Disciplina = viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("Disciplina"))
        ManNF_Global_Turma = viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("Turma"))
        ManNF_Global_Boletim = MeuBimestre
        ManNF_Global_nro = viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("codigoBoletim"))
        ManNF_Global_qtaulas = viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("Dadas"))
        ManNF_Global_qtaulasprevistas = viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("Previstas"))
        ManNF_Global_AnoVigente = tAno.Value

        arquivoLog("Boletim", "Alterou boletim " & ManNF_Global_AnoVigente & " : " & MeuBimestre & "o. Bimestre - Turma: " &
                   ManNF_Global_Turma & " - Disciplina: " & ManNF_Global_Disciplina & ".")

        ' Insere Últimos Alunos na Lista
        If viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("Notas")) < Consulta_NroAlunos() Then

            Dim NovoAluno As Integer = CInt(viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("Notas")))

            ' Criar Boletins para alunos
            While NovoAluno <> nroTotalAlunos

                NovoAluno = NovoAluno + 1

                SQL = "INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S, porcentagem) values(" & ManNF_Global_nro & ", '" & NovoAluno & "', '0', '0', '0', 'N', '0');"
                MySQL_atualiza(SQL)

            End While

        End If

        Refresh_DataGrid(False)

        Dim fManBoletim As New frmManBoletim() With {.MdiParent = frmMaisEscola_Novo}
        fManBoletim.Show()



    End Sub

    Sub delete_Click()

        viewBoletim.PostEditor()

        Dim info As GridHitInfo = viewBoletim.CalcHitInfo(gridBoletim.PointToClient(Cursor.Position))
        codigoBoletim = viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("codigoBoletim"))
        Dim disciplinaBoletim = viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("Disciplina"))
        Dim turmaBoletim = viewBoletim.GetRowCellDisplayText(info.RowHandle, viewBoletim.Columns("Turma"))

        Dim vStrMsg As DialogResult = MessageBox.Show(("Deseja apagar este boletim?"), "Apagar", MessageBoxButtons.YesNo)
        If vStrMsg = DialogResult.Yes Then
            SQL = String.Format("DELETE FROM boletim WHERE cod_boletim='{0}';", codigoBoletim)
            MySQL_atualiza(SQL)
            SQL = String.Format("DELETE FROM notasfreq WHERE cod_nf='{0}';", codigoBoletim)
            MySQL_atualiza(SQL)
            arquivoLog("Boletim",
                       "Excluiu boletim " & MeuBimestre & "o. Bimestre - Turma: " & turmaBoletim & " - Disciplina: " &
                       disciplinaBoletim & ".")
            If Teste_UsuarioSistema <> "0" Then
                Refresh_DataGrid(True)
            Else
                Refresh_DataGrid(False)
            End If
        End If
    End Sub

    Sub Refresh_DataGrid(Professor As Boolean)

        If (tBimestre.Text = "2" Or tBimestre.Text = "4") And cbAF.Checked = True Then
            MeuBimestre = tBimestre.Text & "AF"
        Else
            MeuBimestre = tBimestre.Text
        End If

        If MeuBimestre <> "0" Then

            If Professor = True Then

                tAno.Enabled = False

                'SOMENTE o professor...
                SQL = "SELECT notasfreq.cod_bimestre AS Bimestre, " _
                      & "turma.classe AS Turma, " _
                      & "disciplinas.disciplina AS Disciplina, " _
                      & "notasfreq.qtdadeaulas AS Dadas, " _
                      & "notasfreq.previsaoaulas AS Previstas, " _
                      & "notasfreq.dt_criacao AS Inclusao, " _
                      & "notasfreq.dt_atualizacao AS Atualizacao, QtdadeNotas_NF(notasfreq.cod_nf) AS Notas, notasfreq.cod_nf AS codigoBoletim " _
                      & "FROM " _
                      & "notasfreq " _
                      & "INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc " _
                      & "INNER JOIN turma ON notasfreq.turma = turma.codigo_trma " _
                      & "INNER JOIN professor_grupos ON professor_grupos.codigo_disc = notasfreq.disciplina AND professor_grupos.codigo_trma = notasfreq.turma " _
                      & "INNER JOIN usuariodsk ON professor_grupos.idUsuarioDSK = usuariodsk.codigo " _
                      & "WHERE notasfreq.anovigente='" & tAno.Text & "' AND notasfreq.cod_bimestre='" & MeuBimestre &
                      "' AND usuariodsk.usuario='" & UsuarioSistema & "' " _
                      & "ORDER BY turma.classe, disciplinas.disciplina ASC;"

            Else
                tAno.Enabled = True

                if cbTodosBimestres.Checked = True Then
                    'Todos os bimestres...
                    SQL = "SELECT notasfreq.cod_bimestre AS Bimestre, " _
                          & "turma.classe AS Turma, " _
                          & "disciplinas.disciplina AS Disciplina, " _
                          & "notasfreq.qtdadeaulas AS Dadas, " _
                          & "notasfreq.previsaoaulas AS Previstas, " _
                          & "notasfreq.dt_criacao AS Inclusao, " _
                          & "notasfreq.dt_atualizacao AS Atualizacao, QtdadeNotas_NF(notasfreq.cod_nf) AS Notas, notasfreq.cod_nf AS codigoBoletim " _
                          & "FROM " _
                          & "notasfreq " _
                          & "INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc " _
                          & "INNER JOIN turma ON notasfreq.turma = turma.codigo_trma " _
                          & "WHERE notasfreq.anovigente='" & tAno.Text & "' AND turma.codigo_trma='" & _minhaTurma & "' " _
                          & "ORDER BY notasfreq.cod_bimestre, turma.classe, disciplinas.disciplina ASC;"

                Else

                    SQL = "SELECT notasfreq.cod_bimestre AS Bimestre, " _
                          & "turma.classe AS Turma, " _
                          & "disciplinas.disciplina AS Disciplina, " _
                          & "notasfreq.qtdadeaulas AS Dadas, " _
                          & "notasfreq.previsaoaulas AS Previstas, " _
                          & "notasfreq.dt_criacao AS Inclusao, " _
                          & "notasfreq.dt_atualizacao AS Atualizacao, QtdadeNotas_NF(notasfreq.cod_nf) AS Notas, notasfreq.cod_nf AS codigoBoletim " _
                          & "FROM " _
                          & "notasfreq " _
                          & "INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc " _
                          & "INNER JOIN turma ON notasfreq.turma = turma.codigo_trma " _
                          & "WHERE notasfreq.anovigente='" & tAno.Text & "' AND notasfreq.cod_bimestre='" & MeuBimestre &
                          "' AND turma.codigo_trma='" & _minhaTurma & "' " _
                          & "ORDER BY turma.classe, disciplinas.disciplina ASC;"

                End If

            End If

            viewBoletim.Columns.Clear()
            gridBoletim.DataSource = Nothing
            gridBoletim.DataSource = MySQL_datatable(SQL)

            '... Alinhar...
            Try
                viewBoletim.Columns(0).Width = 45
                viewBoletim.Columns(1).Width = 45
                viewBoletim.Columns(2).Width = 90
                viewBoletim.Columns(2).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
                viewBoletim.Columns(2).SummaryItem.DisplayFormat = "Total de Aulas = "

                viewBoletim.Columns(3).Width = 40
                viewBoletim.Columns(3).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                viewBoletim.Columns(3).SummaryItem.DisplayFormat = "{0}"

                viewBoletim.Columns(4).Width = 50
                viewBoletim.Columns(4).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                viewBoletim.Columns(4).SummaryItem.DisplayFormat = "{0}"

                viewBoletim.Columns(5).Width = 80
                viewBoletim.Columns(6).Width = 80
                viewBoletim.Columns(7).Width = 30
                viewBoletim.Columns(8).Visible = False

                viewBoletim.Columns(0).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(1).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(2).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(3).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(4).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(5).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(6).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(7).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(8).OptionsColumn.AllowEdit = False
                'viewBoletim.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways

                viewBoletim.Columns(5).DisplayFormat.FormatType = FormatType.DateTime
                viewBoletim.Columns(5).DisplayFormat.FormatString = "g"
                viewBoletim.Columns(6).DisplayFormat.FormatType = FormatType.DateTime
                viewBoletim.Columns(6).DisplayFormat.FormatString = "g"

                AddHandler delete.Click, AddressOf delete_Click
                AddHandler edit.Click, AddressOf edit_Click

                '... Adiciona as colunas...
                Dim col = New GridColumn() _
                        With {.ColumnEdit = edit, .Width = 30, .Caption = "Editar", .FieldName = String.Empty, .VisibleIndex = 9}
                Dim col2 = New GridColumn() _
                        With {.ColumnEdit = delete, .Width = 30, .Caption = "Excluir", .FieldName = String.Empty, .VisibleIndex = 10}
                viewBoletim.Columns.Add(col)
                viewBoletim.Columns.Add(col2)

            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub frmManNF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tAno.Value = AnoVigente


        '... Consulta se o professor tem disciplinas/turmas atribuidas ...
        SQL =
            String.Format(
                "SELECT DISTINCT turma.classe As Turma FROM usuariodsk INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK INNER JOIN disciplinas ON disciplinas.codigo_disc = professor_grupos.codigo_disc INNER JOIN turma ON turma.codigo_trma = professor_grupos.codigo_trma WHERE usuariodsk.cod_prof='1' AND usuariodsk.usuario='{0}' ORDER BY turma.classe, disciplinas.disciplina ASC;",
                UsuarioSistema)
        Teste_UsuarioSistema = MySQL_consulta_campo(SQL, "Turma")

        If Teste_UsuarioSistema <> "0" Then
            Refresh_DataGrid(True)
        Else
            Refresh_DataGrid(False)

            SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
            cbTurma.Properties.DataSource = MySQL_combobox(SQL)
            cbTurma.Properties.DisplayMember = "classe"

        End If
    End Sub

    Private Sub cbAF_CheckedChanged(sender As Object, e As EventArgs) Handles cbAF.CheckedChanged

        If cbAF.Checked = True Then
            tBimestre.Enabled = False
        Else
            tBimestre.Enabled = True
        End If
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        frmPreview_Titulo = String.Format("Relatório: Notas e Frequências - {0}o. Bimestre", MeuBimestre)

        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridBoletim}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Private Sub viewBoletim_RowClick(sender As Object, e As RowClickEventArgs) Handles viewBoletim.RowClick
        viewBoletim.PostEditor()
        Dim View As GridView = sender
        codigoBoletim = View.GetRowCellDisplayText(e.RowHandle, View.Columns("codigoBoletim"))
    End Sub

    Private Sub viewBoletim_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles viewBoletim.CustomRowCellEdit

        If e.Column.Caption = "Editar" Then
            e.RepositoryItem = gridBoletim.RepositoryItems(0)
        ElseIf e.Column.Caption = "Excluir" Then
            e.RepositoryItem = gridBoletim.RepositoryItems(1)
        End If
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click

        edit_Click()
    End Sub

    Private Sub RepositoryItemButtonEdit2_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit2.Click

        delete_Click()
    End Sub

    Private Sub pbConsulta_Click(sender As Object, e As EventArgs) Handles pbConsulta.Click

        If cbTurma.Text <> "Escolha a turma..." Then
            If Teste_UsuarioSistema <> "0" Then
                Refresh_DataGrid(True)
            Else
                Refresh_DataGrid(False)
            End If

            If tBimestre.Text = "2" Or tBimestre.Text = "4" Then
                cbAF.Enabled = True
            Else
                cbAF.Enabled = False
            End If
        Else
            MsgBox("Escolher a turma!", MsgBoxStyle.Information, "Mais Escola!")
        End If

    End Sub

    Private Sub cbTodosBimestres_CheckedChanged(sender As Object, e As EventArgs) Handles cbTodosBimestres.CheckedChanged
        If cbTodosBimestres.Checked = True
            tBimestre.Enabled = False
            cbAF.Enabled = False

        else

            tBimestre.Enabled = True
            cbAF.Enabled = True

        End If
    End Sub

    Private Sub cbTurma_EditValueChanged(sender As Object, e As EventArgs) Handles cbTurma.EditValueChanged

        If cbTurma.Text <> "Escolha a turma..." Then
            ' Pega o número da turma
            '
            _minhaTurma = Consulta_Turma(cbTurma.Text)
        End If
    End Sub

    Private Sub pbConsulta_EditValueChanged(sender As Object, e As EventArgs) Handles pbConsulta.EditValueChanged

    End Sub
End Class