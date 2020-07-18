Imports CrystalDecisions.Shared
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRpt_Declaracao
    Dim AlunoRA, Aluno, Turma

    Sub Refresh_Alunos(AnoVigente As String)

        If AnoVigente <> String.Empty Then

            Try
                SQL =
                    String.Format(
                        "SELECT aluno.Nome AS Nome, aluno.Nro, turma.Classe AS Classe, aluno.status AS Status, CONCAT(aluno.ra,'-',aluno.ra_digito) AS RA FROM aluno INNER JOIN turma ON aluno.turma = turma.codigo_trma WHERE aluno.anovigente='{0}' ORDER BY aluno.Nome, turma.Classe ASC;",
                        AnoVigente)
                viewDeclaracao.Columns.Clear()
                gridDeclaracao.DataSource = Nothing
                gridDeclaracao.DataSource = MySQL_consulta_datagrid(SQL)
                viewDeclaracao.Columns(0).Width = 150
                viewDeclaracao.Columns(1).Width = 30
                viewDeclaracao.Columns(2).Width = 80
                viewDeclaracao.Columns(3).Visible = False
                viewDeclaracao.Columns(4).Visible = False
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub frmGerencialDCL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tAno.Value = AnoVigente
        Refresh_Alunos(tAno.Value)
        opcoesDeclaracao.SelectedIndex = "1"
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If Aluno = String.Empty Or AlunoRA = String.Empty Or Turma = String.Empty Then
            MsgBox("Escolha um aluno!", MsgBoxStyle.Information, "Declaração")
            Exit Sub
        End If

        'PRIMEIRO APAGA A LINHA TEMP_DECLARACAO...
        SQL = "DELETE FROM tempdeclaracao WHERE idDeclaracao='1';"
        MySQL_atualiza(SQL)

        'INSERE AS INFORMACOES PARA GERAR DECLARACAO...
        If opcoesDeclaracao.EditValue = 1 Then
            SQL =
                String.Format(
                    "INSERT INTO tempdeclaracao (idDeclaracao, nome, ra, horarioINICIO, horarioFIM, op1, turma, observacao) values('1', '{0}', '{1}', '{2}', '{3}', 'X', '{4}', '{5}');",
                    Aluno, AlunoRA, horarioInicio.Text, horarioFinal.Text, Turma, tbObservacao.Text)
        ElseIf opcoesDeclaracao.EditValue = 2 Then
            SQL =
                String.Format(
                    "INSERT INTO tempdeclaracao (idDeclaracao, nome, ra, op2, turma, observacao) values('1', '{0}', '{1}', 'X', '{2}', '{3}');",
                    Aluno, AlunoRA, Turma, tbObservacao.Text)
        ElseIf opcoesDeclaracao.EditValue = 3 Then
            SQL =
                String.Format(
                    "INSERT INTO tempdeclaracao (idDeclaracao, nome, ra, op3, turma, observacao) values('1', '{0}', '{1}', 'X', '{2}', '{3}');",
                    Aluno, AlunoRA, Turma, tbObservacao.Text)
        ElseIf opcoesDeclaracao.EditValue = 4 Then
            SQL =
                String.Format(
                    "INSERT INTO tempdeclaracao (idDeclaracao, nome, ra, op4, turma, observacao) values('1', '{0}', '{1}', 'X', '{2}', '{3}');",
                    Aluno, AlunoRA, Turma, tbObservacao.Text)
        ElseIf opcoesDeclaracao.EditValue = 5 Then
            SQL =
                String.Format(
                    "INSERT INTO tempdeclaracao (idDeclaracao, nome, ra, op5, turma, observacao) values('1', '{0}', '{1}', 'X', '{2}', '{3}');",
                    Aluno, AlunoRA, Turma, tbObservacao.Text)
            'ElseIf rb6.Checked = True Then
            'SQL = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op6, turma, observacao) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X', '" & cbTurma.Text & "', '" & tbObservacao.Text & "');"
            'ElseIf rb7.Checked = True Then
            'SQL = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op7, turma, observacao) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X', '" & cbTurma.Text & "', '" & tbObservacao.Text & "');"
            ' ElseIf rb8.Checked = True Then
            'SQL = "INSERT INTO tempDeclaracao (idDeclaracao, nome, ra, op8, turma, observacao) values('1', '" & tbNome.Text & "', '" & AlunoRA & "', 'X', '" & cbTurma.Text & "', '" & tbObservacao.Text & "');"
        End If
        MySQL_atualiza(SQL)

        SQL_frmRPT = meuRPT2("Declaração Escolar", String.Empty)

        'frmRpt_Auxiliar.Show()

        ' Exporta pro Word, e assim, possível editar...
        Dim consultaRelatorio01 = MySQL_report(SQL_frmRPT)

        If consultaRelatorio01.Rows.Count = "0" Then

            ' VERIFICA SE FOI PREENCHIDO O ENDEREÇO DA ESCOLA...
            SQL = "SELECT file_id FROM file where file_id='1';"
            Dim Retorno = MySQL_consulta_campo(SQL, "file_id")

            If Retorno = "0" Then
                MsgBox("É necessário preencher o cadastro da escola!", MsgBoxStyle.Information, Sistema)

                Exit Sub
            Else
                MsgBox(String.Format("Não encontramos informações para esta consulta!{0}Verificar: {0}1 - Lista de Alunos disponível no ano pesquisado{0}2 - Todos os campos foram preenchidos", vbCrLf), MsgBoxStyle.Information, Sistema)
                'Me.WindowState = FormWindowState.Minimized

                Exit Sub
            End If
        End If

        crReportDocument.SetDataSource(consultaRelatorio01)

        If SQL_Sub <> String.Empty Then
            crReportDocument.Subreports(0).SetDataSource(MySQL_report(SQL_Sub))
        End If

        'crViewer.ReportSource = crReportDocument


        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptions
        Dim arquivo_Temp

        Try
            arquivo_Temp = meucaminhorelatorio & "\temp_DOC.doc"
            CrFormatTypeOptions = New PdfRtfWordFormatOptions
            CrDiskFileDestinationOptions.DiskFileName = arquivo_Temp
            CrExportOptions = crReportDocument.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.WordForWindows
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            crReportDocument.Export()

            System.Diagnostics.Process.Start(arquivo_Temp)

            'Dim fUtilTexto As New frmUtilTexto(True, arquivo_Temp)
            'fUtilTexto.Show()

        Catch ex As Exception
            MsgBox("Já existe um documento em aberto!", MsgBoxStyle.Information, Sistema)
        End Try


    End Sub

    Private Sub viewDeclaracao_RowClick(sender As Object, e As RowClickEventArgs) Handles viewDeclaracao.RowClick

        'Pega o Nome, RA, Turma
        Dim View As GridView = sender
        Aluno = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Nome"))
        AlunoRA = View.GetRowCellDisplayText(e.RowHandle, View.Columns("RA"))
        Turma = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Classe"))
    End Sub

    Private Sub viewDeclaracao_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewDeclaracao.RowStyle

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
        Refresh_Alunos(tAno.Value)
    End Sub
End Class