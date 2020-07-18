Imports System.ComponentModel

Public Class frmRpt_Auxiliar
    Dim consultaRelatorio01, consultaRelatorio02

    Dim SQL As String
    Dim SQL_Sub As String
    Dim ReadOnly cronometro As New Stopwatch

    Private Sub frmRpt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            crReportDocument.Close()
            crReportDocument.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmRpt_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Mostrar sempre na frente de todos em aberto.
        Me.TopMost = "True"

        If SQL_frmRPT <> String.Empty Then

            crViewer.ReportSource = Nothing

            barra.Text = "00:00:00.00"
            cronometro.Reset()

            cronometro.Start()

            barra.Properties.Paused = False
            tempoBarra.Start()

            bwRelatorio.RunWorkerAsync()

        End If
    End Sub

    Private Sub frmTempo_Tick(sender As Object, e As EventArgs) Handles frmTempo.Tick

        ' ... NAO EXISTE RELATORIO...
        frmTempo.Stop()
        Me.Close()
    End Sub

    Private Sub bwRelatorio_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwRelatorio.DoWork

        consultaRelatorio01 = MySQL_report(SQL_frmRPT)

        ' Se não houver sub-relatório... continua...
        If SQL_Sub <> String.Empty Then
            consultaRelatorio02 = MySQL_report(SQL_Sub)
        End If

    End Sub

    Private Sub bwRelatorio_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwRelatorio.RunWorkerCompleted

        If consultaRelatorio01.Rows.Count = "0" Then

            '... VERIFICA SE FOI PREENCHIDO O ENDEREÇO DA ESCOLA...
            SQL = "SELECT file_id FROM file where file_id='1';"
            Dim Retorno = MySQL_consulta_campo(SQL, "file_id")

            If Retorno = "0" Then

                cronometro.Stop()
                tempoBarra.Stop()

                frmTempo.Stop()
                Exit Sub

            Else
                cronometro.Stop()
                tempoBarra.Stop()

                MsgBox(String.Format("Não encontramos informações para esta consulta!{0}Verificar: {0}1 - Lista de Alunos disponível no ano pesquisado{0}2 - Todos os campos foram preenchidos",
                        vbCrLf), MsgBoxStyle.Information, Sistema & " Bimestre: " & consultaBimestre() & " Ano Vigente: " & AnoVigente)
                Me.WindowState = FormWindowState.Minimized
                frmTempo.Start()
                Exit Sub

            End If
        End If

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

            Me.WindowState = FormWindowState.Minimized
            cronometro.Stop()
            frmTempo.Start()
            Exit Sub
        End Try

        crViewer.ReportSource = crReportDocument

        barra.Properties.Paused = True
        cronometro.Stop()
        tempoBarra.Stop()
    End Sub

    Private Sub crViewer_Load(sender As Object, e As EventArgs) Handles crViewer.Load

    End Sub

    Private Sub tempoBarra_Tick(sender As Object, e As EventArgs) Handles tempoBarra.Tick

        If cronometro.IsRunning Then
            'Coloca o tempo total na variável do tipo TimeSpan
            Dim ts As TimeSpan = cronometro.Elapsed

            ' Mostra a informação dividida em Horas, Minutos, Segundo e Milisegundos.
            barra.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds,
                                       ts.Milliseconds / 10)
        End If
    End Sub
End Class