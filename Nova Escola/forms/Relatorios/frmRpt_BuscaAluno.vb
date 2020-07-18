Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel

Public Class frmRpt_BuscaAluno

    Dim Retorno
    Dim MeuAnoVigente, MinhaTurma, MeuNro, MeuNome

    Sub DG_Ferramentas()

        Try
            viewAluno.Columns(0).OptionsColumn.AllowEdit = False
            viewAluno.Columns(1).OptionsColumn.AllowEdit = False
            viewAluno.Columns(2).OptionsColumn.AllowEdit = False
            viewAluno.Columns(3).OptionsColumn.AllowEdit = False
            viewAluno.Columns(4).OptionsColumn.AllowEdit = False
            viewAluno.Columns(5).OptionsColumn.AllowEdit = False
            viewAluno.Columns(6).OptionsColumn.AllowEdit = False
        Catch ex As Exception
        End Try

    End Sub

    Sub DG_Alinhar()

        Try
            viewAluno.Columns(0).Width = "10"
            viewAluno.Columns(1).Width = "40"
            viewAluno.Columns(2).Width = "10"
            viewAluno.Columns(3).Width = "110"
            viewAluno.Columns(4).Width = "35"
            viewAluno.Columns(5).Width = "40"
            viewAluno.Columns(6).Width = "40"
            viewAluno.Columns(7).Visible = False
        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmRpt_BuscaAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub viewAluno_RowClick(sender As Object, e As RowClickEventArgs) Handles viewAluno.RowClick

        ' Pega Informações para o Relatório...
        '
        viewAluno.PostEditor()
        Dim info As GridHitInfo = viewAluno.CalcHitInfo(gridAluno.PointToClient(Cursor.Position))
        MeuAnoVigente = viewAluno.GetRowCellDisplayText(info.RowHandle, viewAluno.Columns("Ano"))
        MinhaTurma = viewAluno.GetRowCellDisplayText(info.RowHandle, viewAluno.Columns("Turma"))
        MeuNro = viewAluno.GetRowCellDisplayText(info.RowHandle, viewAluno.Columns("Nro"))
        MeuNome = viewAluno.GetRowCellDisplayText(info.RowHandle, viewAluno.Columns("Nome"))

    End Sub

    Private Sub viewAluno_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles viewAluno.RowStyle

        ' Diferenciar Alunos Frequentes de Evasão Escolar...
        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim category = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))

            If category = "Frequente" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.White
            Else
                e.Appearance.BackColor = Color.White
                e.Appearance.BackColor2 = Color.Yellow
            End If
        End If

    End Sub

    Private Sub bwAlunos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwAlunos.DoWork


        If checkAnos.Checked = True Then
            '... Ano | Turma | Nro | Nome | RA | RA_Digito | Data Nascimento | Status...
            SQL = String.Format("SELECT aluno.anovigente AS Ano, turma.classe AS Turma, aluno.nro AS Nro, aluno.nome AS Nome, aluno.data AS Nascimento, EvasaoEscolar_Nome(aluno.status) AS Status, RM(aluno.ra, aluno.ra_digito) AS RM, aluno.codigo_aluno AS CodigoAluno FROM aluno INNER JOIN turma ON turma.codigo_trma = aluno.turma ORDER BY aluno.nome ASC;")
            Retorno = MySQL_datatable(SQL)

        Else
            '... Ano | Turma | Nro | Nome | RA | RA_Digito | Data Nascimento | Status...
            SQL = String.Format("SELECT aluno.anovigente AS Ano, turma.classe AS Turma, aluno.nro AS Nro, aluno.nome AS Nome, aluno.data AS Nascimento, EvasaoEscolar_Nome(aluno.status) AS Status, RM(aluno.ra, aluno.ra_digito) AS RM, aluno.codigo_aluno AS CodigoAluno FROM aluno INNER JOIN turma ON turma.codigo_trma = aluno.turma WHERE aluno.anovigente='" & tAno.Text & "' ORDER BY aluno.nome ASC;")
            Retorno = MySQL_datatable(SQL)

        End If


    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub btBuscarAno_Click(sender As Object, e As EventArgs) Handles btBuscarAno.Click

        Try
            barra.Properties.Paused = False

            bwAlunos.RunWorkerAsync()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub checkAnos_CheckedChanged(sender As Object, e As EventArgs) Handles checkAnos.CheckedChanged
        If checkAnos.Checked = True Then
            tAno.Enabled = False
            barra.Properties.Paused = False
            bwAlunos.RunWorkerAsync()
        Else
            tAno.Enabled = True

        End If
    End Sub

    Private Sub btVisualizar_Click(sender As Object, e As EventArgs) Handles btVisualizar.Click

        frmRpt_grupoTurma = MinhaTurma
        frmRpt_anovigente = MeuAnoVigente

        If grupoRelatorio.SelectedIndex = "0" Then
            'Ficha Individual
            frmRpt_Tipo = MinhaTurma
            SQL_frmRPT = meuRPT2("Ficha Individual", "Turma")
            MsgBox("Página: " & MeuNro)

        ElseIf grupoRelatorio.SelectedIndex = "1" Then
            'Boletim Simples
            SQL_frmRPT = meuRPT2("Boletim", "Simples")
            MsgBox("Aluno Nº: " & MeuNro)

        ElseIf grupoRelatorio.SelectedIndex = "2" Then
            'Boletim Completo
            SQL_frmRPT = meuRPT2("Boletim", "Completo")
            MsgBox("Página: " & MeuNro)

        ElseIf grupoRelatorio.SelectedIndex = "3" Then
            ' Histórico Escolar
            frmRpt_nome = MeuNome
            SQL_frmRPT = meuRPT2("Histórico Escolar", "Auxiliar")

        End If
        frmRpt_Auxiliar.Show()

    End Sub

    Private Sub grupoRelatorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grupoRelatorio.SelectedIndexChanged
        btVisualizar.Enabled = True

    End Sub

    Private Sub bwAlunos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwAlunos.RunWorkerCompleted

        gridAluno.DataSource = Retorno

        DG_Alinhar()
        DG_Ferramentas()
        barra.Properties.Paused = True

    End Sub
End Class