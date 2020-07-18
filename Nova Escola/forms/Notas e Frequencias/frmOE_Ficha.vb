Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmOE_Ficha
    ReadOnly cronometro As New Stopwatch
    Dim consultaRelatorio01, consultaRelatorio02
    Dim crReportDocument = New ReportDocument()

    Sub Visualizar()

        Try

            crViewer.ReportSource = Nothing
            barra.Text = "00:00:00.00"
            cronometro.Reset()
            cronometro.Start()
            tempoBarra.Start()

            barra.Properties.Paused = False

            bwOE.RunWorkerAsync()

        Catch ex As Exception
            MsgBox("Consulta não encontrada!" & vbCrLf & "Mensagem: " & ex.Message, MsgBoxStyle.Information, "Relatório!")
        End Try

    End Sub
    Private Sub btIndicadores_Click(sender As Object, e As EventArgs) Handles btIndicadores.Click

        frmRpt_anovigente = tAnoVigente.Text
        SQL_frmRPT = String.Format("SELECT " _
              & " notasfreq.anovigente AS Ano, (SELECT COUNT(boletim.M) FROM boletim INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf WHERE notasfreq.anovigente='" & frmRpt_anovigente & "' AND boletim.M>=5 AND boletim.M<=10) AS Aprovados,  " _
              & " (SELECT COUNT(boletim.M) FROM boletim INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf WHERE notasfreq.anovigente='" & frmRpt_anovigente & "' AND boletim.M='12') AS Abandonos,  " _
              & " (SELECT COUNT(boletim.M) FROM boletim INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf WHERE notasfreq.anovigente='" & frmRpt_anovigente & "' AND boletim.M<5) AS ReprovadoPorNota,  " _
              & " (SELECT COUNT(boletim.porcentagem) FROM boletim INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf WHERE notasfreq.anovigente='" & frmRpt_anovigente & "' AND boletim.porcentagem>=25) AS ReprovadoPorFrequencia  " _
              & " FROM  " _
              & " boletim  " _
              & " INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf WHERE notasfreq.anovigente='" & frmRpt_anovigente & "';")
        crReportDocument = New OE_Indicadores
        Visualizar()

    End Sub

    Private Sub btDesempenho_Click(sender As Object, e As EventArgs) Handles btDesempenho.Click

        frmRpt_anovigente = tAnoVigente.Text
        SQL_frmRPT = String.Format("SELECT
                        notasfreq.anovigente AS Ano,
                        notasfreq.cod_bimestre AS Bimestre,
                        turma.classe AS Turma,
                        boletim.M AS Avaliacao, 
                        disciplinas.disciplina AS Disciplina
                        FROM
                        boletim
                        INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf
                        INNER JOIN turma ON turma.codigo_trma = notasfreq.turma
                        INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc
                        WHERE
                        notasfreq.anovigente = '{0}' AND
                        boletim.M <= 4;", frmRpt_anovigente)
        crReportDocument = New OE_ProblemasDesempenho
        Visualizar()
    End Sub

    Private Sub btEvolucaoTaxas_Click(sender As Object, e As EventArgs) Handles btEvolucaoTaxas.Click

        frmRpt_anovigente = tAnoVigente.Text
        SQL_frmRPT = String.Format("SELECT DISTINCT cod_bimestre AS Bimestre, " & frmRpt_anovigente & " AS Ano, " _
                & "  QtdadeAlunos_NotaBimestre(" & frmRpt_anovigente & ", cod_bimestre, '12') AS Abandonos FROM notasfreq WHERE anovigente='" & frmRpt_anovigente & "';")
        crReportDocument = New OE_TaxasAbandono
        Visualizar()
    End Sub

    Private Sub btReprovadosPorTurno_Click(sender As Object, e As EventArgs) Handles btReprovadosPorTurno.Click

        frmRpt_anovigente = tAnoVigente.Text
        SQL_frmRPT = String.Format("SELECT DISTINCT turma.periodo AS Periodo, " & frmRpt_anovigente & " AS Ano, " _
                & "  QtdadeAlunos_RR(" & frmRpt_anovigente & ", turma.periodo) AS ReprovadoPorNota, QtdadeAlunos_RF(" & frmRpt_anovigente & ", turma.periodo) AS ReprovadoPorFrequencia " _
                & "  FROM turma;")
        crReportDocument = New OE_ReprovadosTurno
        Visualizar()
    End Sub

    Private Sub btAbandonoPorTurno_Click(sender As Object, e As EventArgs) Handles btAbandonoPorTurno.Click

        frmRpt_anovigente = tAnoVigente.Text
        SQL_frmRPT = String.Format("SELECT DISTINCT turma.classe AS Turma, aluno.anovigente AS Ano, turma.periodo AS Periodo, " _
                        & "  QtdadeAlunos_StatusTurma(" & frmRpt_anovigente & ", aluno.turma, 'AB') AS Abandonos " _
                        & "  From turma INNER Join aluno On aluno.turma = turma.codigo_trma WHERE AnoVigente = '" & frmRpt_anovigente & "' AND turma.bloqueado='0';")
        crReportDocument = New OE_AbandonosTurno
        Visualizar()
    End Sub

    Private Sub frmOE_Ficha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btStatusAlunos_Click_1(sender As Object, e As EventArgs) Handles btStatusAlunos.Click

        frmRpt_anovigente = tAnoVigente.Text
        SQL_frmRPT = String.Format("SELECT DISTINCT turma.classe AS Turma, aluno.anovigente AS Ano, " _
                & "  QtdadeAlunos_StatusTurma(" & frmRpt_anovigente & ", aluno.turma, '0') AS Ativos, " _
                & "  QtdadeAlunos_StatusTurma(" & frmRpt_anovigente & ", aluno.turma, 'TR') AS Transferidos, " _
                & "  QtdadeAlunos_StatusTurma(" & frmRpt_anovigente & ", aluno.turma, 'RM') AS Remanejados " _
                & "  From turma INNER Join aluno On aluno.turma = turma.codigo_trma WHERE AnoVigente = '" & frmRpt_anovigente & "' AND turma.bloqueado='0';")
        crReportDocument = New OE_StatusAlunos
        Visualizar()

    End Sub

    Private Sub bwOE_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOE.DoWork

        consultaRelatorio01 = MySQL_report(SQL_frmRPT)

        ' Se não houver sub-relatório... continua...
        If SQL_Sub <> String.Empty Then
            consultaRelatorio02 = MySQL_report(SQL_Sub)
        End If

    End Sub

    Private Sub frmOE_Ficha_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            crReportDocument.Close()
            crReportDocument.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmTempo_Tick(sender As Object, e As EventArgs) Handles frmTempo.Tick

        ' ... NAO EXISTE RELATORIO...
        frmTempo.Stop()

    End Sub

    Private Sub tempoBarra_Tick(sender As Object, e As EventArgs) Handles tempoBarra.Tick

        If cronometro.IsRunning Then
            'Coloca o tempo total na variável do tipo TimeSpan
            Dim ts As TimeSpan = cronometro.Elapsed

            ' Mostra a informação dividida em Horas, Minutos, Segundo e Milisegundos.
            barra.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        ' Abandonos por Turma
        frmRpt_anovigente = tAnoVigente.Text
        SQL_frmRPT = String.Format("SELECT DISTINCT turma.classe AS Turma, aluno.anovigente AS Ano, turma.periodo AS Periodo, " _
                        & "  QtdadeAlunos_StatusTurma(" & frmRpt_anovigente & ", aluno.turma, 'AB') AS Abandono " _
                        & "  From turma INNER Join aluno On aluno.turma = turma.codigo_trma WHERE AnoVigente = '" & frmRpt_anovigente & "' AND turma.bloqueado='0';")
        crReportDocument = New OE_AbandonosTurma
        Visualizar()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click

    End Sub

    Private Sub bwOE_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwOE.RunWorkerCompleted

        Try
            crReportDocument.SetDataSource(consultaRelatorio01)

            If SQL_Sub <> String.Empty Then
                crReportDocument.Subreports(0).SetDataSource(consultaRelatorio02)
            End If

        Catch ex As Exception

            MsgBox(
                    String.Format(
                        "Não encontramos informações para esta consulta!{0}Verificar: {0}1 - Lista de Alunos disponível no ano pesquisado{0}2 - Todos os campos foram preenchidos",
                        vbCrLf), MsgBoxStyle.Information, Sistema)

            If ex.Message.Contains("OutOfMemoryException") = True Then
                MsgBox("Memória insuficiente no computador, fechar programas que não estão sendo utilizados.",
                           MsgBoxStyle.Information, "Falta de Memória")
            Else
                MsgBox(
                        String.Format(
                            "Não encontramos informações para esta consulta!{0}Verificar: {0}1 - Lista de Alunos disponível no ano pesquisado{0}2 - Todos os campos foram preenchidos",
                            vbCrLf), MsgBoxStyle.Information, Sistema)
            End If

            barra.Properties.Paused = True
            cronometro.Stop()
            frmTempo.Start()
            Exit Sub
        End Try

        crViewer.ReportSource = crReportDocument

        barra.Properties.Paused = True
        cronometro.Stop()
        tempoBarra.Stop()

    End Sub
End Class