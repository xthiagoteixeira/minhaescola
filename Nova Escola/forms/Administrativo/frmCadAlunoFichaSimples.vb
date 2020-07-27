Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports MySql.Data.MySqlClient

Public Class frmCadAlunoFichaSimples
    Dim nroFinalLista = 0, nroTurmaAtual, nroAlunoAtual

    Dim delete As New RepositoryItemPictureEdit()
    Dim edit As New RepositoryItemPictureEdit()

    Sub Lista_Alunos()

        If cbTurma.Text <> "[EditValue is null]" And cbTurma.Text <> "[EditValue é Nulo]" Then

            ' Prepara o cadastro, com o último núero da turma disponível.
            nroTurmaAtual = Consulta_Turma(cbTurma.Text)
            Try
                Dim SQL =
                        String.Format("SELECT nro FROM aluno WHERE anovigente='{1}' AND turma='{0}' ORDER BY nro DESC;",
                                      nroTurmaAtual, tAno.Value)
                nroFinalLista = MySQL_consulta_campo(SQL, "nro")
                nroFinalLista = nroFinalLista + 1
                nroAluno.Text = nroFinalLista

            Catch ex As Exception
                nroAluno.Text = "1"
            End Try

            SQL = "SELECT " _
                  & "aluno.Nro, " _
                  & "aluno.Nome, " _
                  & "aluno.ra AS RA, " _
                  & "aluno.ra_digito AS Digito, aluno.data AS Nascimento, " _
                  & "EvasaoEscolar_Nome(aluno.status) AS Status, RM(aluno.ra, aluno.ra_digito) AS RM " _
                  & "FROM " _
                  & "aluno " _
                  & "INNER JOIN turma ON turma.codigo_trma = aluno.turma " _
                  & "WHERE aluno.anovigente='" & tAno.Value & "' AND turma.classe='" & cbTurma.Text &
                  "' ORDER BY aluno.nro ASC;"
            viewAlunos.Columns.Clear()
            gridAlunos.DataSource = Nothing
            gridAlunos.DataSource = MySQL_datatable(SQL)

            viewAlunos.Columns(0).Width = "30"
            viewAlunos.Columns(1).Width = "220"
            viewAlunos.Columns(2).Width = "80"
            viewAlunos.Columns(3).Width = "30"
            viewAlunos.Columns(4).Width = "70"
            viewAlunos.Columns(5).Width = "80"
            viewAlunos.Columns(6).Visible = False

            viewAlunos.Columns(0).OptionsColumn.AllowEdit = False
            viewAlunos.Columns(1).OptionsColumn.AllowEdit = False
            viewAlunos.Columns(2).OptionsColumn.AllowEdit = False
            viewAlunos.Columns(3).OptionsColumn.AllowEdit = False
            viewAlunos.Columns(4).OptionsColumn.AllowEdit = False
            viewAlunos.Columns(5).ColumnEdit = RepositoryItemComboBox1
            viewAlunos.Columns(5).ShowButtonMode = ShowButtonModeEnum.ShowAlways

            ' Preencher as Evasões...
            RepositoryItemComboBox1.Items.Clear()
            RepositoryItemComboBox1.Items.Add("Abandono")
            RepositoryItemComboBox1.Items.Add("Dispensa Idade")
            RepositoryItemComboBox1.Items.Add("Dispensa Médica")
            RepositoryItemComboBox1.Items.Add("Dispensa Prole")
            RepositoryItemComboBox1.Items.Add("Dispensa Trabalho")
            RepositoryItemComboBox1.Items.Add("Falecimento")
            RepositoryItemComboBox1.Items.Add("Frequente")
            RepositoryItemComboBox1.Items.Add("Licença Gestante")
            RepositoryItemComboBox1.Items.Add("Licença Saúde")
            RepositoryItemComboBox1.Items.Add("Matrícula Cessada")
            RepositoryItemComboBox1.Items.Add("Não Compareceu")
            RepositoryItemComboBox1.Items.Add("Não Frequenta")
            RepositoryItemComboBox1.Items.Add("Reclassificado")
            RepositoryItemComboBox1.Items.Add("Remanejado")
            RepositoryItemComboBox1.Items.Add("Transferido")

            ' ''... Adiciona as colunas...
            'Dim col As GridColumn = New GridColumn() With {.ColumnEdit = RepositoryItemButtonEdit1, .Width = 10, .Caption = "", .FieldName = "", .VisibleIndex = 6, .ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways}
            'viewAlunos.Columns.Add(col)asdf

            Dim col = New GridColumn() _
                    With {.ColumnEdit = RepositoryItemButtonEdit1, .Width = 30, .Caption = "Editar", .FieldName = String.Empty,
                    .VisibleIndex = 7, .ShowButtonMode = ShowButtonModeEnum.ShowAlways}
            Dim col2 = New GridColumn() _
                    With {.ColumnEdit = RepositoryItemButtonEdit2, .Width = 30, .Caption = "Excluir", .FieldName = String.Empty,
                    .VisibleIndex = 8, .ShowButtonMode = ShowButtonModeEnum.ShowAlways}
            viewAlunos.Columns.Add(col)
            viewAlunos.Columns.Add(col2)

            btImprimir.Enabled = True


        End If
    End Sub

    Private Sub frmCadAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmCadAlunoFichaSimples"

        tbAluno.Text = String.Empty
        tAno.Value = AnoVigente

        ' Preenche com o nome das turmas...
        Dim SQL = "SELECT classe FROM turma where bloqueado='0' ORDER BY classe"
        cbTurma.Properties.DataSource = MySQL_combobox(SQL)
        cbTurma.Properties.DisplayMember = "classe"
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        Dim SacarData As DateTime = DateTime.Now

        If cbTurma.Text = String.Empty Or tbAluno.Text = String.Empty Or tbRA.Text = String.Empty Or tbRA_Digito.Text = String.Empty Or tbNascimento.Text = String.Empty _
            Then
            MsgBox("Antes de cadastrar, preencha os campos!", MsgBoxStyle.Information, "Atenção!")
        Else

            Dim Ano = CInt(tAno.Value)

            Try

                Dim SQL = String.Format("SELECT * FROM aluno WHERE nro='{0}' AND anovigente='{1}' AND turma='{2}';",
                                        nroAluno.Text, Ano, nroTurmaAluno)
                Dim Resultado = MySQL_consulta_campo(SQL, "codigo_aluno")

                If Resultado = "0" Then

                    SQL =
                        String.Format(
                            "INSERT INTO aluno (nome, turma, nro, anovigente, bf, ra, ra_digito, data, status) values('{0}', '{1}', '{2}', '{3}', '0', '{4}', '{5}', '{6}', '{7}');",
                            tbAluno.Text, nroTurmaAtual, nroAluno.Text, tAno.Value, tbRA.Text, tbRA_Digito.Text,
                            Format(CDate(tbNascimento.Text), "dd/MM/yyyy"), "0")
                    MySQL_atualiza(SQL)

                    MsgBox(String.Format("[ {0} - {1} ] foi cadastrada com sucesso!", nroAluno.Text, tbAluno.Text),
                           MsgBoxStyle.Information, "Cadastrado")
                    tbAluno.Text = String.Empty
                    tbRA.Text = String.Empty
                    tbRA_Digito.Text = String.Empty
                    tbNascimento.Text = String.Empty

                    LiberaPublicacao("aluno")
                    Lista_Alunos()

                Else
                    MsgBox("Já existe um aluno cadastrado, e não é permitida a duplicação!", MsgBoxStyle.Information,
                           "Atenção!")
                End If

            Catch myerro As MySqlException
            End Try

        End If
    End Sub

    Private Sub nroAluno_LostFocus(sender As Object, e As EventArgs) Handles nroAluno.LostFocus

        ' PESQUISA OS DADOS DO ALUNO, SE EXISTIR, NÃO LIBERA O BOTÃO.

        SQL = String.Format("SELECT nome FROM aluno WHERE nro='{0}' AND anovigente='{1}' AND turma='{2}';",
                            nroAluno.Text, tAno.Value, nroTurmaAtual)
        Dim RetornoNome = MySQL_consulta_campo(SQL, "nome")

        If RetornoNome <> "0" Then
            MsgBox("Já existe um aluno com este número!" & vbCrLf & "Nome: [ " & RetornoNome & " ]",
                   MsgBoxStyle.Information, "Aluno já existe!")
            tbAluno.Text = RetornoNome
            btSalvar.Enabled = False
        Else
            tbAluno.Text = String.Empty
            btSalvar.Enabled = True
        End If
    End Sub

    Private Sub cbTurma_TextChanged(sender As Object, e As EventArgs) Handles cbTurma.TextChanged

        'Preenche a Data Grid.
        Lista_Alunos()
    End Sub

    Private Sub RepositoryItemComboBox1_Click(sender As Object, e As EventArgs) Handles RepositoryItemComboBox1.Click

        viewAlunos.PostEditor()
        Dim info As GridHitInfo = viewAlunos.CalcHitInfo(gridAlunos.PointToClient(Cursor.Position))
        nroAlunoAtual = viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("Nro"))
    End Sub

    Private Sub RepositoryItemComboBox1_EditValueChanged(sender As Object, e As EventArgs) _
        Handles RepositoryItemComboBox1.EditValueChanged

        ' Altera o Status do aluno.
        Dim edit As ComboBoxEdit = sender
        SQL =
            String.Format(
                "UPDATE aluno SET status='" & TesteEvasaoEscolar_Nome(edit.EditValue) & "' WHERE anovigente='" &
                tAno.Value & "' AND turma='" & nroTurmaAtual & "' AND nro='" & nroAlunoAtual & "';")
        MySQL_atualiza(SQL)
        Lista_Alunos()
    End Sub

    Private Sub tAno_ValueChanged1(sender As Object, e As EventArgs) Handles tAno.ValueChanged
        Lista_Alunos()
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) _
        Handles RepositoryItemButtonEdit1.Click

        viewAlunos.PostEditor()

        Dim info As GridHitInfo = viewAlunos.CalcHitInfo(gridAlunos.PointToClient(Cursor.Position))
        Dim RM = viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("RM")).ToString

        fCadAlunoFichaCompleta_Aluno =
            viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("Nome")).ToString
        fCadAlunoFichaCompleta_RM = RM
        fCadAlunoFichaCompleta_RA = viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("RA")).ToString
        fCadAlunoFichaCompleta_RAd =
            viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("Digito")).ToString
        fCadAlunoFichaCompleta_Nascimento =
            viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("Nascimento")).ToString

        Dim fCadAlunoFichaCompleta As New frmCadAlunoFichaCompleta(RM) With {.MdiParent = frmPrincipal}
        fCadAlunoFichaCompleta.Show()
    End Sub

    Private Sub viewAlunos_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewAlunos.RowStyle

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim category = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))

            If category = "Frequente" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.White
            Else
                e.Appearance.BackColor = Color.LightYellow
                e.Appearance.BackColor2 = Color.Yellow
            End If
        End If
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        frmPreview_Titulo = "Relatório: Lista de Alunos - " & cbTurma.Text
        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridAlunos}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Private Sub RepositoryItemButtonEdit2_Click(sender As Object, e As EventArgs) _
        Handles RepositoryItemButtonEdit2.Click

        viewAlunos.PostEditor()

        Dim info As GridHitInfo = viewAlunos.CalcHitInfo(gridAlunos.PointToClient(Cursor.Position))
        'codigoBoletim = viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("codigoBoletim"))
        Dim nroAluno = viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("Nro"))

        Dim vStrMsg As DialogResult = MessageBox.Show(("Deseja excluir aluno nº [" & nroAluno & "]?"), "Excluir",
                                                      MessageBoxButtons.YesNo)
        If vStrMsg = DialogResult.Yes Then

            SQL = String.Format("DELETE FROM aluno WHERE anovigente='" & tAno.Value & "' AND turma='" & nroTurmaAtual & "' AND nro='" & nroAluno & "';")
            MySQL_atualiza(SQL)

            Dim RM = viewAlunos.GetRowCellDisplayText(info.RowHandle, viewAlunos.Columns("RM")).ToString
            SQL = "SELECT INSCRICAO, RM FROM aluno_ficha WHERE CODIGO='" & RM & "';"
            Dim INSCRICAO = MySQL_consulta_campo(SQL, "INSCRICAO")

            SQL = String.Format("DELETE FROM aluno_ficha WHERE CODIGO='" & RM & "';")
            MySQL_atualiza(SQL)

            SQL = String.Format("DELETE FROM aluno_ficha_telefone WHERE idAlunoFicha='" & INSCRICAO & "';")
            MySQL_atualiza(SQL)

            Lista_Alunos()

        End If
    End Sub
End Class