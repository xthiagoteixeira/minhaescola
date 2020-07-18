Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmRpt_CartEstudante
    Dim NomeAluno
    Dim ReadOnly add As New RepositoryItemPictureEdit()

    Sub adicionar_Aluno()

        Dim Existe = False
        viewAlunos.PostEditor()

        Dim info As GridHitInfo = viewAlunos.CalcHitInfo(gridAlunos.PointToClient(Cursor.Position))
        NomeAluno = viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("Nome"))

        ' ESTA DUPLICANDO ainda...
        For i = 0 To cbAlunos.Properties.Items.Count - 1 Step 1
            If cbAlunos.Properties.Items.Item(i).ToString = NomeAluno.ToString Then
                Existe = True
                Exit For
            End If
        Next

        If Existe = False Then
            cbAlunos.Properties.Items.Add(NomeAluno)
        End If

        btVisualizar.Enabled = True
    End Sub

    Public Sub Refresh_Lista(AnoVigente As String)

        Try
            SQL =
                String.Format(
                    "SELECT aluno.Nome AS Nome, aluno.Nro, turma.Classe, aluno.status AS Status FROM aluno INNER JOIN turma ON aluno.turma = turma.codigo_trma WHERE aluno.anovigente='{0}' AND turma.bloqueado=
                    '0' ORDER BY aluno.Nome, turma.Classe ASC;",
                    AnoVigente)

            viewAlunos.Columns.Clear()
            gridAlunos.DataSource = Nothing
            gridAlunos.DataSource = MySQL_consulta_datagrid(SQL)
            viewAlunos.Columns(0).Width = 170
            viewAlunos.Columns(1).Width = 20
            viewAlunos.Columns(2).Width = 80
            viewAlunos.Columns(3).Visible = False

            ' viewAlunos.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways

            AddHandler add.Click, AddressOf adicionar_Aluno

            '... Adiciona a coluna...
            Dim col = New GridColumn() _
                    With {.ColumnEdit = add, .Width = 20, .Caption = "+", .FieldName = String.Empty, .VisibleIndex = 4}
            viewAlunos.Columns.Add(col)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmRptCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tAno.Value = AnoVigente
        grupoAlunos = String.Empty
        grupoTurmas = String.Empty

        ' Turma...
        SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
        Dim MinhasTurmas = MySQL_combobox(SQL)
        cbTurmas.Properties.Items.Clear()
        For Each r In MinhasTurmas.Rows
            cbTurmas.Properties.Items.Add(r("classe"))
        Next

        ' Seleciona Alunos...
        imprimirGrupo.EditValue = "0"

        Refresh_Lista(tAno.Value)
        btVisualizar.Enabled = False
    End Sub

    Private Sub imprimirGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles imprimirGrupo.SelectedIndexChanged

        If imprimirGrupo.SelectedIndex = "0" Then
            cbAlunos.Enabled = True
            cbTurmas.Enabled = False
        ElseIf imprimirGrupo.SelectedIndex = "1" Then
            cbAlunos.Enabled = False
            cbTurmas.Enabled = True
            btVisualizar.Enabled = True

        End If
    End Sub

    Private Sub viewAlunos_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) _
        Handles viewAlunos.CustomRowCellEdit

        If e.Column.Caption = "+" Then
            e.RepositoryItem = gridAlunos.RepositoryItems(0)
        End If
    End Sub

    Private Sub viewAlunos_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewAlunos.RowStyle

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim category = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))

            If category = "0" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.White
            Else
                e.Appearance.BackColor = Color.LightYellow
                e.Appearance.BackColor2 = Color.Yellow
            End If
        End If
    End Sub

    Private Sub tAno_EditValueChanged(sender As Object, e As EventArgs) Handles tAno.EditValueChanged
        Refresh_Lista(CInt(tAno.Value))
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) _
        Handles RepositoryItemButtonEdit1.Click
        adicionar_Aluno()
    End Sub

    Private Sub btVisualizar_Click(sender As Object, e As EventArgs) Handles btVisualizar.Click

        Dim minhaOpcao
        grupoAlunos = String.Empty
        grupoTurmas = String.Empty
        Dim contador = 0

        'Verifica quem está selecionado...
        If imprimirGrupo.SelectedIndex = "0" Then
            contador = 0
            'Alunos...
            For Each item As CheckedListBoxItem In cbAlunos.Properties.Items
                If item.CheckState = CheckState.Checked Then
                    If contador > 0 Then
                        grupoAlunos += " OR "
                    End If
                    grupoAlunos += String.Format("aluno.nome='{0}'", item.Value)
                    contador += 1
                End If
            Next
            minhaOpcao = "Aluno"

        ElseIf imprimirGrupo.SelectedIndex = "1" Then
            contador = 0
            'Turmas...
            For Each item As CheckedListBoxItem In cbTurmas.Properties.Items
                If item.CheckState = CheckState.Checked Then
                    If contador > 0 Then
                        grupoTurmas += " OR "
                    End If
                    grupoTurmas += String.Format("turma.classe='{0}'", item.Value)
                    contador += 1
                End If

            Next
            minhaOpcao = "Turma"

        End If

        frmRpt_anovigente = tAno.Value

        SQL_frmRPT = meuRPT2("Carteira de Estudante", minhaOpcao)
        frmRpt_Auxiliar.Show()
    End Sub

    Private Sub cbTurmas_EditValueChanged(sender As Object, e As EventArgs) Handles cbTurmas.EditValueChanged

    End Sub
End Class