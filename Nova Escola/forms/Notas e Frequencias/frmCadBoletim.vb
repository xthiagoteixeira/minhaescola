Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel

Public Class frmCadBoletim
    Dim _
        ManNF_Local_nro,
        ManNF_Local_Disciplina,
        ManNF_Local_Turma,
        ManNF_Local_Boletim,
        ManNF_Local_qtaulas,
        ManNF_Local_AnoVigente,
        ManNF_Local_qtaulasprevistas,
        testeMedia

    Dim NroMaximoAluno = 0
    Dim NaoExisteLista = True
    Dim manutencaoAV = False, manutencaoFT = False, manutencaoAC = False
    Dim nroAluno = "1", nroFalta = "0", nroAC = "0", nroAV = "0"

    Dim Aluno_Media, Aluno_Faltas, Boletim_Media, Boletim_Faltas, Sala_Media, Sala_Faltas

    Sub Refresh_Boletim(AnoVigente, Bimestre, Turma, Disciplina)

        If AnoVigente <> Nothing Then
            Try
                SQL = String.Format(
                        "SELECT boletim.nro_aluno AS Nro, EvasaoEscolar(boletim.M) AS AV, boletim.F, boletim.AC, boletim.S AS SF, boletim.porcentagem AS '%' FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND notasfreq.turma='{2}' AND notasfreq.disciplina='{3}' ORDER BY boletim.nro_aluno ASC;",
                        AnoVigente, Bimestre, Consulta_Turma(Turma), Consulta_Disciplina(Disciplina))
                gridBoletim.DataSource = Nothing
                gridBoletim.DataSource = MySQL_consulta_datagrid2(SQL)

                viewBoletim.Columns(0).OptionsColumn.AllowEdit = False
                viewBoletim.Columns(1).OptionsColumn.AllowEdit = True

                If ManNF_Local_Boletim = "2AF" Or ManNF_Local_Boletim = "4AF" Then
                    viewBoletim.Columns(2).OptionsColumn.AllowEdit = False
                    viewBoletim.Columns(3).OptionsColumn.AllowEdit = False
                    viewBoletim.Columns(4).OptionsColumn.AllowEdit = True

                    viewBoletim.Columns(1).ColumnEdit = RepositoryItemTextEdit1
                    viewBoletim.Columns(2).ColumnEdit = RepositoryItemTextEdit2
                    viewBoletim.Columns(3).ColumnEdit = RepositoryItemTextEdit3
                    viewBoletim.Columns(4).ColumnEdit = RepositoryItemTextEdit4

                    viewBoletim.Columns(5).OptionsColumn.AllowEdit = False

                Else
                    viewBoletim.Columns(2).OptionsColumn.AllowEdit = True
                    viewBoletim.Columns(3).OptionsColumn.AllowEdit = True

                    viewBoletim.Columns(1).ColumnEdit = RepositoryItemTextEdit1
                    viewBoletim.Columns(2).ColumnEdit = RepositoryItemTextEdit2
                    viewBoletim.Columns(3).ColumnEdit = RepositoryItemTextEdit3

                    viewBoletim.Columns(4).Visible = False
                    viewBoletim.Columns(4).OptionsColumn.AllowEdit = True
                    viewBoletim.Columns(5).OptionsColumn.AllowEdit = False

                End If

                If ManNF_Local_Disciplina <> cbDisciplina.Text Then
                    viewBoletim.Columns(1).OptionsColumn.AllowEdit = False
                    viewBoletim.Columns(2).OptionsColumn.AllowEdit = False
                    viewBoletim.Columns(3).OptionsColumn.AllowEdit = False
                End If



            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub frmCadBoletim234_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        If lbCodigo.Text = "1" Then
            'CADASTRA NOTA 0 PARA O ALUNO NUMERO 1
            SQL =
                String.Format(
                    "INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S, porcentagem) values({0}, '1', '0', '0', '0', 'N', '0');",
                    ManNF_Local_nro)
            MySQL_atualiza(SQL)
        End If
    End Sub

    Private Sub frmCad234_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmCadBoletim"

        lbCodigo.Text = "1"

        ManNF_Local_Disciplina = ManNF_Global_Disciplina
        lbDisciplina.Text = ManNF_Local_Disciplina
        grupoSalaDisciplina.Text = "Turma - " & ManNF_Local_Disciplina
        cbDisciplina.Text = ManNF_Local_Disciplina

        ManNF_Local_Turma = ManNF_Global_Turma
        lbTurma.Text = ManNF_Local_Turma

        ManNF_Local_Boletim = ManNF_Global_Boletim
        lbBimestre.Text = ManNF_Local_Boletim

        ManNF_Local_qtaulas = ManNF_Global_qtaulas
        lbAulasDadas.Text = ManNF_Local_qtaulas

        ManNF_Local_qtaulasprevistas = ManNF_Global_qtaulasprevistas
        lbAulasPrevistas.Text = ManNF_Local_qtaulasprevistas

        ManNF_Local_AnoVigente = ManNF_Global_AnoVigente
        ManNF_Local_nro = ManNF_Global_nro

        If (lbBimestre.Text = "4AF" Or lbBimestre.Text = "2AF") Then
            tbMedia.Enabled = True
            tbFaltas.Enabled = False
            tbFaltas.Text = "0"
            tbAC.Enabled = False
            tbAC.Text = "0"
        Else
            tbMedia.Enabled = True
            tbFaltas.Enabled = True
            tbFaltas.Text = "0"
            tbAC.Enabled = True
            tbAC.Text = "0"
        End If

        SQL = "SELECT " _
              & "disciplinas.disciplina AS disciplina " _
              & "FROM " _
              & "notasfreq " _
              & "INNER JOIN turma ON notasfreq.turma = turma.codigo_trma " _
              & "INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc " _
              & "WHERE notasfreq.anovigente='" & ManNF_Local_AnoVigente & "' AND notasfreq.cod_bimestre='" &
              ManNF_Local_Boletim & "' AND turma.classe='" & ManNF_Local_Turma & "';"
        cbDisciplina.Properties.DataSource = MySQL_combobox(SQL)
        cbDisciplina.Properties.DisplayMember = "disciplina"

        'PEGA O ULTIMO ALUNO DA LISTA PILOTO
        SQL = String.Format("SELECT nro FROM aluno WHERE anovigente='{1}' AND turma='{0}' ORDER BY nro DESC",
                            nroTurmaAluno, ManNF_Local_AnoVigente)
        NroMaximoAluno = MySQL_consulta_campo(SQL, "nro").ToString
        lbTotalAlunos.Text = NroMaximoAluno & " alunos."

        SQL = String.Format("SELECT nome FROM aluno WHERE anovigente='{2}' AND turma={0} AND nro={1};", nroTurmaAluno,
                            lbCodigo.Text, ManNF_Local_AnoVigente)
        tbNomeAluno.Text = MySQL_consulta_campo(SQL, "nome").ToString

        SQL = "SELECT " _
              & "COUNT(aluno.`status`) AS Evasao, " _
              & "turma.classe, " _
              & "turma.bloqueado, " _
              & "aluno.anovigente " _
              & "FROM " _
              & "aluno " _
              & "INNER JOIN turma ON aluno.turma = turma.codigo_trma WHERE aluno.anovigente='" & ManNF_Local_AnoVigente &
              "' AND turma.classe='" & ManNF_Local_Turma & "' AND aluno.status<>'0';"
        lbSala_Evasao.Text = MySQL_consulta_campo3(SQL, "Evasao").ToString

        If ManNF_Global_Boletim_Existe = True Then
            SQL = String.Format("SELECT nro_aluno FROM boletim WHERE cod_boletim='{0}' ORDER BY nro_aluno DESC;",
                                ManNF_Local_nro)
            lbCodigo.Text = MySQL_consulta_campo(SQL, "nro_aluno").ToString
            lbCodigo.Text = CInt(lbCodigo.Text) + 1
            grupoAluno.Text = "Turma - Aluno nº" & lbCodigo.Text

            Refresh_Boletim(ManNF_Local_AnoVigente, ManNF_Local_Boletim, ManNF_Local_Turma, ManNF_Local_Disciplina)
        End If

        bwAluno.RunWorkerAsync()
    End Sub

    Private Sub lbCodigo_TextChanged(sender As Object, e As EventArgs) Handles lbCodigo.TextChanged

        If ManNF_Local_AnoVigente <> Nothing Then

            If NroMaximoAluno <> "0" Then
                NaoExisteLista = False
            Else
                NaoExisteLista = True
            End If

            If CInt(lbCodigo.Text) > CInt(NroMaximoAluno) Then
                MsgBox("Todos os alunos foram cadastrados!", MsgBoxStyle.Information)
                tbMedia.Text = "0"
                tbMedia.Enabled = False
                tbFaltas.Enabled = False
                tbFaltas.Text = "0"
                tbAC.Enabled = False
                tbAC.Text = "0"
                tbNomeAluno.Text = "-"
                btSalvar.Enabled = False
                Exit Sub
            End If

            If NaoExisteLista = False Then

                SQL = String.Format("SELECT Status, nome FROM aluno WHERE anovigente='{2}' AND turma={0} AND nro={1};",
                                    nroTurmaAluno, lbCodigo.Text, ManNF_Local_AnoVigente)
                tbMedia.Text = MySQL_consulta_campo(SQL, "Status").ToString

                If Not IsNumeric(tbMedia.Text) Then
                    tbNomeAluno.Text = MySQL_consulta_campo(SQL, "nome").ToString
                    tbFaltas.Text = "0"
                    tbAC.Text = "0"
                    tbMedia.Enabled = False
                    tbFaltas.Enabled = False
                    tbAC.Enabled = False
                    btSalvar.Focus()
                Else
                    tbNomeAluno.Text = MySQL_consulta_campo(SQL, "nome").ToString
                    tbMedia.Enabled = True
                    tbFaltas.Enabled = True
                    tbAC.Enabled = True
                    tbFaltas.Text = "0"
                    tbAC.Text = "0"
                    tbMedia.Focus()
                    tbMedia.Text = String.Empty
                End If

            End If

        End If
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If (IsNumeric(tbFaltas.Text) = True) And (tbMedia.Text <> String.Empty) And (tbFaltas.Text <> String.Empty) Then

            If CInt(tbFaltas.Text) > ManNF_Local_qtaulas Then
                MsgBox("A Falta não pode ser maior que Aulas Dadas!", MsgBoxStyle.Information)
                tbFaltas.Focus()

            Else

                If (IsNumeric(tbAC.Text) = True) Then

                    Dim SF = 0
                    If TesteEvasaoEscolar(tbMedia.Text) < 5 Or TesteEvasaoEscolar(tbMedia.Text) > 10 then
                        SF = 4
                    Else
                        SF = 1
                    End If

                    SQL = String.Format(
                            "INSERT INTO boletim (cod_boletim, nro_aluno, M, F, AC, S, porcentagem) values({0}, {1}, '{2}', {3} , {4}, '{6}', '{5}');",
                            ManNF_Local_nro, lbCodigo.Text, TesteEvasaoEscolar(tbMedia.Text).ToString, tbFaltas.Text,
                            tbAC.Text, Resultado_Porcentagem(tbFaltas.Text, tbAC.Text, lbAulasDadas.Text).ToString, SF)
                    MySQL_atualiza(SQL)

                    tbMedia.Focus()
                    If lbCodigo.Text = "1" Then
                        cbDisciplina.Text = ManNF_Local_Disciplina
                        cbDisciplina.ClosePopup()
                    Else
                        Refresh_Boletim(ManNF_Local_AnoVigente, ManNF_Local_Boletim, ManNF_Local_Turma,
                                        ManNF_Local_Disciplina)
                    End If

                    lbCodigo.Text = CInt(lbCodigo.Text) + 1
                    grupoAluno.Text = "Turma - Aluno nº" & lbCodigo.Text
                    bwAluno.RunWorkerAsync()

                Else
                    MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Information, "Informação!")
                    tbAC.Focus()
                End If
            End If
        Else
            MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Information, "Informação!")
            tbFaltas.Focus()
        End If
    End Sub

    Private Sub tbMedia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMedia.KeyPress

        If lbBimestre.Text = "4AF" Or lbBimestre.Text = "2AF" Then
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                e.Handled = True
                btSalvar.Focus()
            End If

            If Escola_Sistema = "Nenhuma" Or Escola_Sistema = "Estadual" Then
                If e.KeyChar = ","c Then
                    e.Handled = True
                    btSalvar.Focus()
                End If
            Else
                If e.KeyChar = "," Then
                    e.Handled = True
                    SendKeys.Send(".")
                End If
            End If

        Else

            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                e.Handled = True
                tbFaltas.Focus()
            End If

            If Escola_Sistema = "Nenhuma" Or Escola_Sistema = "Estadual" Then
                If e.KeyChar = ","c Then
                    e.Handled = True
                    tbFaltas.Focus()
                End If
            Else
                If e.KeyChar = "," Then
                    e.Handled = True
                    SendKeys.Send(".")
                End If
            End If
        End If
    End Sub

    Private Sub tbAC_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles tbAC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btSalvar.Focus()
        End If
        If e.KeyChar = ","c Then
            e.Handled = True
            btSalvar.Focus()
        End If
    End Sub

    Private Sub tbFaltas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbFaltas.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If tbAC.Enabled = False Then
                btSalvar.Focus()
            Else
                tbAC.Focus()
            End If
        End If

        If e.KeyChar = ","c Then
            e.Handled = True
            If tbAC.Enabled = False Then
                btSalvar.Focus()
            Else
                tbAC.Focus()
            End If
        End If
    End Sub

    Private Sub tbMedia_LostFocus(sender As Object, e As EventArgs) Handles tbMedia.LostFocus
        Try
            testeMedia = TesteEvasaoEscolar(tbMedia.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tbMedia_TextChanged(sender As Object, e As EventArgs) Handles tbMedia.TextChanged
        If tbMedia.Text <> String.Empty Then
            btSalvar.Enabled = True
        Else
            btSalvar.Enabled = False
        End If
    End Sub

    Private Sub viewBoletim_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewBoletim.RowStyle

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim category = View.GetRowCellDisplayText(e.RowHandle, View.Columns("AV"))
            Try
                If category > 4 Then
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

        End If
    End Sub

    Private Sub cbDisciplina_TextChanged(sender As Object, e As EventArgs) Handles cbDisciplina.TextChanged

        If ManNF_Local_Turma <> Nothing Then
            Refresh_Boletim(ManNF_Local_AnoVigente, ManNF_Local_Boletim, ManNF_Local_Turma, cbDisciplina.Text)
        End If
    End Sub

    Private Sub bwAluno_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwAluno.DoWork

        Try
            '... Checa o desempenho do aluno, na SALA.
            SQL =
                String.Format(
                    "SELECT AVG(boletim.M) AS AV, AVG(boletim.F) AS FT FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND notasfreq.turma='{2}' AND boletim.nro_aluno='" &
                    lbCodigo.Text & "' AND boletim.M<11;", ManNF_Local_AnoVigente, ManNF_Local_Boletim,
                    Consulta_Turma(ManNF_Local_Turma))
            Aluno_Media = MySQL_consulta_campo(SQL, "AV").ToString
            Aluno_Faltas = MySQL_consulta_campo(SQL, "FT").ToString
        Catch ex As Exception
            Aluno_Media.Text = "0"
            Aluno_Faltas.Text = "0"
        End Try

        Try
            '... Checa o boletim nesta Disciplina.
            SQL =
                String.Format(
                    "SELECT AVG(boletim.M) AS AV, AVG(boletim.F) AS FT FROM boletim WHERE boletim.cod_boletim='{0}' AND boletim.M<11;",
                    ManNF_Local_nro)
            Boletim_Media = MySQL_consulta_campo2(SQL, "AV").ToString
            Boletim_Faltas = MySQL_consulta_campo2(SQL, "FT").ToString
        Catch ex As Exception
            Boletim_Media = "0"
            Boletim_Faltas.Text = "0"
        End Try


        'Checa a sala inteira.
        SQL =
            String.Format(
                "SELECT AVG(boletim.M) AS AV, AVG(boletim.F) AS FT FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND notasfreq.turma='{2}' AND boletim.M<11;",
                ManNF_Local_AnoVigente, ManNF_Local_Boletim, Consulta_Turma(ManNF_Local_Turma))
        Sala_Media = MySQL_consulta_campo3(SQL, "AV").ToString
        Sala_Faltas = MySQL_consulta_campo3(SQL, "FT").ToString
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

    Private Sub RepositoryItemTextEdit3_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles RepositoryItemTextEdit3.KeyPress

        If e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = False
        End If
    End Sub

    Private Sub RepositoryItemTextEdit1_Leave(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit1.Leave

        If manutencaoAV = True Then
            Dim View As TextEdit = sender
            If View.EditValue <> String.Empty Then

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
                MySQL_atualiza(SQL)

                bwAluno.RunWorkerAsync()
                bwSala.RunWorkerAsync()
                bwBoletim.RunWorkerAsync()
                Refresh_Boletim(ManNF_Local_AnoVigente, ManNF_Local_Boletim, ManNF_Local_Turma, cbDisciplina.Text)

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
                MySQL_atualiza(SQL)

                bwAluno.RunWorkerAsync()
                bwSala.RunWorkerAsync()
                bwBoletim.RunWorkerAsync()
                Refresh_Boletim(ManNF_Local_AnoVigente, ManNF_Local_Boletim, ManNF_Local_Turma, cbDisciplina.Text)

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
                If CInt(View.EditValue) > CInt(nroFalta) Then
                    MsgBox("Aulas Compensadas não pode ser maior que Faltas.", MsgBoxStyle.Information, "Informação!")
                    View.EditValue = 0
                Else

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
                    MySQL_atualiza(SQL)

                    'bwAluno.RunWorkerAsync()
                    'bwSala.RunWorkerAsync()
                    'bwBoletim.RunWorkerAsync()
                    Refresh_Boletim(ManNF_Local_AnoVigente, ManNF_Local_Boletim, ManNF_Local_Turma, cbDisciplina.Text)

                End If
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

    Private Sub bwAluno_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwAluno.RunWorkerCompleted

        lbAluno_Media.Text = Aluno_Media
        lbAluno_Faltas.Text = Aluno_Faltas

        lbBoletim_Media.Text = Boletim_Media
        lbBoletim_Faltas.Text = Boletim_Faltas

        lbSala_Media.Text = Sala_Media
        lbSala_Faltas.Text = Sala_Faltas
    End Sub
End Class