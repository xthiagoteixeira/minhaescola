Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports System.ComponentModel

Public Class frmManBoletim
    Dim SQL_Boletim, novoBO, barraTexto

    Dim nroAluno = "1", nroFalta = "0", nroAC = "0", nroAV = "0"
    Dim ReadOnly ManNF_Local_Disciplina
    Dim ReadOnly ManNF_Local_Turma
    Dim ReadOnly ManNF_Local_Boletim
    Dim ManNF_Local_nro
    Dim ReadOnly ManNF_Local_qtaulas
    Dim ReadOnly ManNF_Local_AnoVigente
    Dim ReadOnly ManNF_Local_qtaulasprevistas
    Dim Sala_Media, Aluno_Media, Boletim_Media, Aluno_Faltas, Boletim_Faltas, Sala_Faltas, Sala_Evasao
    Dim clicouTrocarDisciplina = False
    Dim ReadOnly manutencaoIndice(100) As String
    Dim ReadOnly manutencaoMySQL(100) As String
    Dim manutencaoContador = 0
    Dim manutencaoAV = False, manutencaoFT = False, manutencaoAC = False, manutencaoSF = False

    Public Delegate Sub IncrementProgressDelegate()

    Public Delegate Sub Delegação(texto As String)

    Public Delegate Sub Delegação2(Status As String, texto As String)

    Public Sub DefinirBarra(texto As String)
        On Error Resume Next
        If barra.InvokeRequired Then
            Dim d As New Delegação(AddressOf DefinirBarra)
            barra.Text = barra.Invoke(d, texto)
            barra.Properties.Minimum = 0
            barra.Properties.Maximum = novoBO

        Else
            barra.Text = texto
            barra.Properties.Minimum = 0
            barra.Properties.Maximum = novoBO

        End If
    End Sub

    Public Sub New()

        InitializeComponent()

        ManNF_Local_Boletim = ManNF_Global_Boletim
        ManNF_Local_Disciplina = ManNF_Global_Disciplina
        ManNF_Local_Turma = ManNF_Global_Turma
        ManNF_Local_nro = ManNF_Global_nro
        ManNF_Local_qtaulas = ManNF_Global_qtaulas
        ManNF_Local_qtaulasprevistas = ManNF_Global_qtaulasprevistas
        ManNF_Local_AnoVigente = ManNF_Global_AnoVigente
    End Sub

    Private Sub bwAluno_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwAluno.DoWork

        Try
            'Checa o desempenho do aluno, na SALA.
            SQL =
                String.Format(
                    "SELECT AVG(boletim.M) AS AV, AVG(boletim.F) AS FT FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND notasfreq.turma='{2}' AND boletim.nro_aluno='" &
                    nroAluno & "' AND boletim.M<11;", ManNF_Local_AnoVigente, ManNF_Local_Boletim,
                    Consulta_Turma(ManNF_Local_Turma))
            Dim MinhaTabela = MySQL_datatable(SQL)
            Dim r = MinhaTabela.Rows(0)

            Aluno_Media = r("AV").ToString
            Aluno_Faltas = r("FT").ToString

        Catch ex As Exception
            Aluno_Media = "00"
            Aluno_Faltas = "00"
        End Try
    End Sub

    Private Sub bwBoletim_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwBoletim.DoWork

        Try
            'Checa o boletim nesta Disciplina.
            SQL =
                String.Format(
                    "SELECT AVG(boletim.M) AS AV, AVG(boletim.F) AS FT FROM boletim WHERE boletim.cod_boletim='{0}' AND boletim.M<11;",
                    ManNF_Local_nro)
            Dim MinhaTabela = MySQL_datatable(SQL)
            Dim r = MinhaTabela.Rows(0)

            Boletim_Media = r("AV").ToString
            Boletim_Faltas = r("FT").ToString

        Catch ex As Exception
            Boletim_Media = "00"
            Boletim_Faltas = "00"
        End Try
    End Sub

    Private Sub bwSala_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwSala.DoWork

        '... Checa a sala inteira.
        SQL =
            String.Format(
                "SELECT AVG(boletim.M) AS AV, AVG(boletim.F) AS FT FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND notasfreq.turma='{2}' AND boletim.M<11;",
                ManNF_Local_AnoVigente, ManNF_Local_Boletim, Consulta_Turma(ManNF_Local_Turma))
        Dim MinhaTabela = MySQL_datatable(SQL)
        Dim r = MinhaTabela.Rows(0)

        Sala_Media = r("AV").ToString
        Sala_Faltas = r("FT").ToString

        SQL = "SELECT " _
              & "COUNT(aluno.`status`) AS Evasao, " _
              & "turma.classe, " _
              & "turma.bloqueado, " _
              & "aluno.anovigente " _
              & "FROM " _
              & "aluno " _
              & "INNER JOIN turma ON aluno.turma = turma.codigo_trma WHERE aluno.anovigente='" & ManNF_Local_AnoVigente &
              "' AND turma.classe='" & ManNF_Local_Turma & "' AND aluno.status<>'0';"
        Dim MinhaTabela2 = MySQL_datatable(SQL)
        Dim r2 = MinhaTabela2.Rows(0)
        Sala_Evasao = r2("Evasao").ToString
    End Sub

    Private Sub bwAluno_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwAluno.RunWorkerCompleted
        lbAluno_Media.Text = Aluno_Media
        lbAluno_Faltas.Text = Aluno_Faltas
        grupoAluno.Text = "Turma - Aluno nº" & nroAluno
    End Sub

    Private Sub bwBoletim_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwBoletim.RunWorkerCompleted
        lbBoletim_Media.Text = Boletim_Media
        lbBoletim_Faltas.Text = Boletim_Faltas
        grupoSalaDisciplina.Text = "Turma - " & cbDisciplina.Text
    End Sub

    Private Sub bwSala_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwSala.RunWorkerCompleted
        lbSala_Media.Text = Sala_Media
        lbSala_Faltas.Text = Sala_Faltas
        lbSala_Evasao.Text = Sala_Evasao
    End Sub

    Sub Refresh_Boletim(nroBoletim As String)

        If nroBoletim IsNot Nothing Then
            SQL_Boletim = "SELECT " _
                          & "boletim.nro_aluno AS Nro, " _
                          & "aluno.nome AS Nome, " _
                          & "EvasaoEscolar(boletim.M) AS AV, " _
                          & "boletim.F AS FT, " _
                          & "boletim.AC AS AC, boletim.S AS SF, " _
                          & "boletim.porcentagem AS '%', notasfreq.cod_nf AS codigoBoletim " _
                          & "FROM " _
                          & "notasfreq " _
                          & "INNER JOIN aluno ON aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente " _
                          & "INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim AND boletim.nro_aluno = aluno.nro WHERE notasfreq.cod_nf='" &
                          nroBoletim & "' ORDER BY boletim.nro_aluno ASC;"

            viewBoletim.Columns.Clear()
            gridBoletim.DataSource = Nothing
            gridBoletim.DataSource = MySQL_datatable(SQL_Boletim)

            viewBoletim.Columns(0).OptionsColumn.AllowEdit = False
            viewBoletim.Columns(1).OptionsColumn.AllowEdit = False
            viewBoletim.Columns(2).OptionsColumn.AllowEdit = True

            If ManNF_Local_Boletim = "2AF" Or ManNF_Local_Boletim = "4AF" Then
                viewBoletim.Columns(3).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(4).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(5).Visible = True
                viewBoletim.Columns(6).OptionsColumn.AllowEdit = False

                viewBoletim.Columns(2).ColumnEdit = RepositoryItemTextEdit1
                viewBoletim.Columns(3).ColumnEdit = RepositoryItemTextEdit2
                viewBoletim.Columns(4).ColumnEdit = RepositoryItemTextEdit3
                viewBoletim.Columns(5).ColumnEdit = RepositoryItemTextEdit4

                viewBoletim.Columns(0).Width = 20
                viewBoletim.Columns(1).Width = 150
                viewBoletim.Columns(2).Width = 20
                viewBoletim.Columns(3).Width = 20
                viewBoletim.Columns(4).Width = 20
                viewBoletim.Columns(5).Width = 20
                viewBoletim.Columns(6).Width = 20
                viewBoletim.Columns(7).Visible = False

            Else
                viewBoletim.Columns(3).OptionsColumn.AllowEdit = True
                viewBoletim.Columns(4).OptionsColumn.AllowEdit = True
                viewBoletim.Columns(5).Visible = False

                viewBoletim.Columns(2).ColumnEdit = RepositoryItemTextEdit1
                viewBoletim.Columns(3).ColumnEdit = RepositoryItemTextEdit2
                viewBoletim.Columns(4).ColumnEdit = RepositoryItemTextEdit3
                viewBoletim.Columns(6).OptionsColumn.AllowEdit = False

                viewBoletim.Columns(0).Width = 20
                viewBoletim.Columns(1).Width = 150
                viewBoletim.Columns(2).Width = 20
                viewBoletim.Columns(3).Width = 20
                viewBoletim.Columns(4).Width = 20
                viewBoletim.Columns(6).Width = 20
                viewBoletim.Columns(7).Visible = False

            End If

        End If
    End Sub

    Private Sub frmManBoletim_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbTurma.Text = ManNF_Local_Turma
        lbBimestre.Text = ManNF_Local_Boletim
        lbAulasDadas.Text = ManNF_Local_qtaulas
        lbAulasPrevistas.Text = ManNF_Local_qtaulasprevistas
        lbTotalAlunos.Text = nroTotalAlunos & " alunos"
        'Consulta quais disciplinas foram digitadas...
        SQL = "SELECT " _
              & "disciplinas.disciplina AS Disciplina, notasfreq.cod_nf AS codigoNF " _
              & "FROM " _
              & "notasfreq " _
              & "INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc " _
              & "INNER JOIN turma ON notasfreq.turma = turma.codigo_trma WHERE notasfreq.anovigente='" &
              ManNF_Local_AnoVigente & "' AND notasfreq.cod_bimestre='" & ManNF_Local_Boletim & "' AND turma.classe='" &
              ManNF_Local_Turma & "' ORDER BY disciplinas.disciplina ASC;"
        Dim MinhasDisciplinas = MySQL_datatable(SQL)

        cbDisciplina.Properties.Items.Clear()
        For Each r In MinhasDisciplinas.Rows
            cbDisciplina.Properties.Items.Add(r("Disciplina"))
        Next

        ' cbDisciplina.EditValue = ManNF_Local_Disciplina
        lbNomeDisciplina.Text = ManNF_Local_Disciplina
        Refresh_Boletim(ManNF_Local_nro)

        Try
            bwSala.RunWorkerAsync()
            bwBoletim.RunWorkerAsync()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub viewBoletim_RowClick(sender As Object, e As RowClickEventArgs) Handles viewBoletim.RowClick
        Try
            bwAluno.RunWorkerAsync()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub viewBoletim_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewBoletim.RowStyle

        Try
            Dim View As GridView = sender
            Dim NotasVermelhas As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("AV"))

            If NotasVermelhas > 4 Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.White
            Else
                e.Appearance.BackColor = Color.LightSalmon
                e.Appearance.BackColor2 = Color.White
            End If
        Catch ex As Exception
            e.Appearance.BackColor = Color.LightYellow
            e.Appearance.BackColor2 = Color.Yellow
        End Try
    End Sub

    Private Sub cbDisciplina_Click(sender As Object, e As EventArgs) Handles cbDisciplina.Click
        clicouTrocarDisciplina = True
    End Sub

    Private Sub cbDisciplina_TextChanged(sender As Object, e As EventArgs) Handles cbDisciplina.TextChanged

        If clicouTrocarDisciplina = True Then
            Try
                'Consulta quais disciplinas foram digitadas...
                SQL =
                    String.Format(
                        "SELECT notasfreq.cod_nf AS codigoNF FROM notasfreq INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc INNER JOIN turma ON notasfreq.turma = turma.codigo_trma WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND turma.classe='{2}' AND disciplinas.disciplina='{3}' ORDER BY disciplinas.disciplina ASC;",
                        ManNF_Local_AnoVigente, ManNF_Local_Boletim, ManNF_Local_Turma, cbDisciplina.Text)
                ManNF_Local_nro = MySQL_consulta_campo(SQL, "codigoNF")
                Refresh_Boletim(ManNF_Local_nro)
                'bwBoletim.RunWorkerAsync()
            Catch ex As Exception
            End Try
            clicouTrocarDisciplina = False
        End If
    End Sub

    Private Sub RepositoryItemTextEdit1_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles RepositoryItemTextEdit1.KeyPress

        If Escola_Sistema = "Nenhuma" Or Escola_Sistema = "Estadual" Then
            If e.KeyChar = ","c Or e.KeyChar = "."c Then
                e.Handled = False
            End If
        Else
            If e.KeyChar = "," Then
                e.Handled = True
                SendKeys.Send(".")
            End If
        End If
    End Sub

    Private Sub RepositoryItemTextEdit2_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles RepositoryItemTextEdit2.KeyPress

        If e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = False
        End If
    End Sub

    Private Sub btProximo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RepositoryItemTextEdit3_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles RepositoryItemTextEdit3.KeyPress

        If e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = False
        End If
    End Sub

    Private Sub bwSalvar_DoWork(sender As Object, e As DoWorkEventArgs)

        For i = 0 To manutencaoContador
            DefinirBarra(i)

            SQL = manutencaoMySQL(manutencaoIndice(i))
            MySQL_atualiza(SQL)
        Next
    End Sub

    Private Sub bwSalvar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)

        manutencaoContador = 0
        Array.Clear(manutencaoMySQL, 0, 100)
        Array.Clear(manutencaoIndice, 0, 100)

        Refresh_Boletim(ManNF_Local_nro)

        MsgBox("Salvo com sucesso!", MsgBoxStyle.Information, "Sucesso!")
    End Sub

    Private Sub barra_CustomDisplayText(sender As Object, e As CustomDisplayTextEventArgs)
        e.DisplayText = barraTexto
    End Sub

    Private Sub RepositoryItemTextEdit1_Leave(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit1.Leave
        If manutencaoAV = True Then

            Dim View As TextEdit = sender
            If View.EditValue <> String.Empty Then
                barra.Properties.Maximum = 1
                barra.Properties.Minimum = 0

                Dim row As DataRow = viewBoletim.GetDataRow(viewBoletim.FocusedRowHandle)
                nroAluno = row(0).ToString
                nroAV = row(2).ToString
                nroFalta = row(3).ToString
                nroAC = row(4).ToString

                SQL =
                    String.Format(
                        "UPDATE boletim SET M='{0}', F='{1}', AC='{2}', porcentagem='{3}' WHERE cod_boletim='{4}' AND nro_aluno='{5}';",
                        TesteEvasaoEscolar(View.EditValue), nroFalta, nroAC,
                        Resultado_Porcentagem(nroFalta, nroAC, lbAulasDadas.Text), ManNF_Local_nro, nroAluno)
                Dim Retorno = MySQL_atualiza(SQL)

                bwAluno.RunWorkerAsync()
                bwSala.RunWorkerAsync()
                bwBoletim.RunWorkerAsync()
                'Refresh_Boletim(ManNF_Local_nro)
                If Retorno = "0" Then
                    barra.Properties.DisplayFormat.FormatString = "Nº [" & nroAluno.ToString & "] nota NÃO atualizada!"
                Else
                    barra.Properties.DisplayFormat.FormatString = "Nº [" & nroAluno.ToString & "] nota atualizada!"
                    barra.EditValue = 1
                End If
            End If

            manutencaoAV = False
        End If
    End Sub

    Private Sub RepositoryItemTextEdit2_Leave(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit2.Leave
        If manutencaoFT = True Then

            Dim View As TextEdit = sender
            Dim MeuValor = View.EditValue

            If CInt(MeuValor) > CInt(ManNF_Local_qtaulas) Then
                MsgBox("A Falta não pode ser maior que Aulas Dadas!", MsgBoxStyle.Information, "Informação!")
                View.EditValue = 0
            Else

                If View.EditValue < nroAC Then
                    nroAC = 0
                End If

                Dim row As DataRow = viewBoletim.GetDataRow(viewBoletim.FocusedRowHandle)
                nroAluno = row(0).ToString
                nroAV = row(2).ToString
                nroFalta = row(3).ToString
                nroAC = row(4).ToString

                ' ............ Faltas, Porcentagem
                SQL =
                    String.Format(
                        "UPDATE boletim SET F='{0}', AC='{1}', porcentagem='{2}' WHERE cod_boletim='{3}' AND nro_aluno='{4}';",
                        View.EditValue, nroAC, Resultado_Porcentagem(View.EditValue, nroAC, lbAulasDadas.Text),
                        ManNF_Local_nro, nroAluno)
                Dim Retorno = MySQL_atualiza(SQL)

                bwAluno.RunWorkerAsync()
                bwSala.RunWorkerAsync()
                bwBoletim.RunWorkerAsync()
                'Refresh_Boletim(ManNF_Local_nro)

                If Retorno = "0" Then
                    barra.Properties.DisplayFormat.FormatString = String.Format("Nº [{0}] faltas NÃO atualizada!", nroAluno)
                Else
                    barra.Properties.DisplayFormat.FormatString = String.Format("Nº [{0}] faltas atualizada!", nroAluno)
                    barra.EditValue = 1
                End If

            End If
            manutencaoFT = False

        End If
    End Sub

    Private Sub RepositoryItemTextEdit2_Modified(sender As Object, e As EventArgs) _
        Handles RepositoryItemTextEdit2.Modified

        manutencaoFT = True
    End Sub

    Private Sub RepositoryItemTextEdit3_Leave(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit3.Leave

        If manutencaoAC = True Then

            Dim View As TextEdit = sender
            If View.EditValue <> String.Empty Then
                'If CInt(View.EditValue) > CInt(nroFalta) Then
                '    MsgBox("Aulas Compensadas não pode ser maior que Faltas.", MsgBoxStyle.Information, "Informação!")
                '    View.EditValue = 0
                'Else
                Dim row As DataRow = viewBoletim.GetDataRow(viewBoletim.FocusedRowHandle)
                nroAluno = row(0).ToString
                nroAV = row(2).ToString
                nroFalta = row(3).ToString
                nroAC = row(4).ToString

                ' ............ AC / Porcentagem
                SQL =
                    String.Format(
                        "UPDATE boletim SET F='{0}', AC='{1}', porcentagem='{2}' WHERE cod_boletim='{3}' AND nro_aluno='{4}';",
                        nroFalta, View.EditValue, Resultado_Porcentagem(nroFalta, View.EditValue, lbAulasDadas.Text),
                        ManNF_Local_nro, nroAluno)
                Dim Retorno = MySQL_atualiza(SQL)

                bwAluno.RunWorkerAsync()
                bwSala.RunWorkerAsync()
                bwBoletim.RunWorkerAsync()
                'Refresh_Boletim(ManNF_Local_nro)

                If Retorno = "0" Then
                    barra.Properties.DisplayFormat.FormatString = String.Format("Nº [{0}] aulas compensadas NÃO atualizada!", nroAluno)
                Else
                    barra.Properties.DisplayFormat.FormatString = String.Format("Nº [{0}] aulas compensadas atualizada!", nroAluno)
                    barra.EditValue = 1
                End If

                'End If
            End If
            manutencaoAC = False
        End If
    End Sub

    Private Sub RepositoryItemTextEdit3_Modified(sender As Object, e As EventArgs) _
        Handles RepositoryItemTextEdit3.Modified
        manutencaoAC = True
    End Sub

    Private Sub RepositoryItemTextEdit1_Modified(sender As Object, e As EventArgs) _
        Handles RepositoryItemTextEdit1.Modified
        manutencaoAV = True
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        frmPreview_Titulo = "[" & AnoVigente & "] " & lbBimestre.Text & "º bimestre : " & lbTurma.Text & " - " &
                            cbDisciplina.Text
        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridBoletim}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Private Sub RepositoryItemTextEdit4_Leave(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit4.Leave

        If manutencaoSF = True Then

            Dim View As TextEdit = sender
            If View.EditValue <> String.Empty Then
                Dim row As DataRow = viewBoletim.GetDataRow(viewBoletim.FocusedRowHandle)
                nroAluno = row(0).ToString

                ' ............ SF
                SQL = String.Format("UPDATE boletim SET S='{0}' WHERE cod_boletim='{1}' AND nro_aluno='{2}';", View.EditValue, ManNF_Local_nro, nroAluno)
                Dim Retorno = MySQL_atualiza(SQL)

                If Retorno = "0" Then
                    barra.Properties.DisplayFormat.FormatString = String.Format("Nº [{0}] situação final NÃO atualizada!", nroAluno)
                Else
                    barra.Properties.DisplayFormat.FormatString = String.Format("Nº [{0}] situação final atualizada!", nroAluno)
                    barra.EditValue = 1
                End If

            End If
            manutencaoSF = False
        End If

    End Sub

    Private Sub RepositoryItemTextEdit4_Modified(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit4.Modified
        manutencaoSF = True
    End Sub

    Private Sub RepositoryItemTextEdit4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RepositoryItemTextEdit4.KeyPress

        If e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = False
        End If

    End Sub
End Class