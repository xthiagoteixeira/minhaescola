Imports DevExpress.XtraBars
Imports System.ComponentModel

Public Class frmRptRelatorio
    Dim consultaRelatorio01, consultaRelatorio02

    Dim SQL As String
    Dim ReadOnly cronometro As New Stopwatch

    Sub ZeraCronometro()

        Try
            crReportDocument.Close()
            crReportDocument.Dispose()
        Catch ex As Exception
        End Try

        barra.Text = "00:00:00.00"
        cronometro.Reset()

        cronometro.Start()

        barra.Properties.Paused = False
        tempoBarra.Start()
    End Sub

    Private Sub bwConsulta_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwConsulta.DoWork

        consultaRelatorio01 = MySQL_report(SQL_frmRPT)

        ' Se não houver sub-relatório... continua...
        If SQL_Sub <> String.Empty Then
            consultaRelatorio02 = MySQL_report(SQL_Sub)
        End If
    End Sub

    Private Sub bwConsulta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwConsulta.RunWorkerCompleted

        If (consultaRelatorio01 Is Nothing) Or (frmRpt_existe = False) Then

            ' VERIFICA SE FOI PREENCHIDO O ENDEREÇO DA ESCOLA...
            SQL = "SELECT file_id FROM file where file_id='1';"
            Dim Retorno = MySQL_consulta_campo(SQL, "file_id")

            If Retorno = "0" Then
                cronometro.Stop()
                tempoBarra.Stop()

                MsgBox("É necessário preencher o cadastro da escola!", MsgBoxStyle.Information, Sistema)
                ' ABRIR NO MAIS ESCOLA!!
                frmTempo.Start()
                Exit Sub
            Else
                cronometro.Stop()
                tempoBarra.Stop()

                MsgBox(
                    String.Format(
                        "Não encontramos informações para esta consulta!{0}Verificar: {0}1 - Lista de Alunos disponível no ano pesquisado{0}2 - Todos os campos foram preenchidos",
                        vbCrLf), MsgBoxStyle.Information, Sistema)
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

            barra.Properties.Paused = True
            cronometro.Stop()
            tempoBarra.Stop()
            frmTempo.Start()

            If ex.Message.Contains("OutOfMemoryException") = True Then
                MsgBox("Memória insuficiente no computador, fechar programas que não estão sendo utilizados.",
                       MsgBoxStyle.Information, "Falta de Memória")
            Else
                MsgBox(
                    String.Format(
                        "Não encontramos informações para esta consulta!{0}Verificar: {0}1 - Lista de Alunos disponível no ano pesquisado{0}2 - Todos os campos foram preenchidos",
                        vbCrLf), MsgBoxStyle.Information, Sistema)
            End If

            Exit Sub
        End Try

        crViewer.ReportSource = crReportDocument
        'crViewer.Show()

        barra.Properties.Paused = True
        cronometro.Stop()
        tempoBarra.Stop()
    End Sub

    Private Sub cbRelatorio_EditValueChanged(sender As Object, e As EventArgs) Handles cbRelatorio.EditValueChanged

        '... Filtros ...
        RepositoryItemComboBox2.Items.Clear()
        RepositoryItemComboBox3.Items.Clear()

        cbEstilo.Enabled = True
        cbFiltro.Enabled = False

        cbEstilo.EditValue = String.Empty
        cbFiltro.EditValue = String.Empty

        If cbRelatorio.EditValue = "Boletim" Then
            RepositoryItemComboBox2.Items.Add("Completo")
            RepositoryItemComboBox2.Items.Add("Simples")
            RepositoryItemComboBox2.Items.Add("Status de Entrega")
            RepositoryItemComboBox2.Items.Add("Status de Entrega/Usuario")

        ElseIf cbRelatorio.EditValue = "Ficha Individual" Then
            RepositoryItemComboBox2.Items.Add("Turma")
            RepositoryItemComboBox2.Items.Add("Período")

        ElseIf cbRelatorio.EditValue = "Deliberação 11" Then
            RepositoryItemComboBox2.Items.Add("Turma")
            RepositoryItemComboBox2.Items.Add("Período")

        ElseIf cbRelatorio.EditValue = "Consolidado" Then
            RepositoryItemComboBox2.Items.Add("Alunos Reprovados")
            RepositoryItemComboBox2.Items.Add("Avaliação Final/Turma")
            RepositoryItemComboBox2.Items.Add("Avaliação Final/Período")
            RepositoryItemComboBox2.Items.Add("Avaliação Final - c/ Data de Nascimento")
            RepositoryItemComboBox2.Items.Add("Completo/Turma")
            RepositoryItemComboBox2.Items.Add("Completo/Período")
            RepositoryItemComboBox2.Items.Add("Notas e Frequências")

        ElseIf cbRelatorio.EditValue = "Rendimento Escolar" Then
            RepositoryItemComboBox2.Items.Add("Completo")
            RepositoryItemComboBox2.Items.Add("Notas")
            RepositoryItemComboBox2.Items.Add("Faltas")

        ElseIf cbRelatorio.EditValue = "Lista de Alunos" Then
            RepositoryItemComboBox2.Items.Add("Completa")
            RepositoryItemComboBox2.Items.Add("Controle Interno/Aula")
            RepositoryItemComboBox2.Items.Add("Controle Interno/Diário")
            RepositoryItemComboBox2.Items.Add("Lista de Entrega")
            RepositoryItemComboBox2.Items.Add("Lista Piloto")
            RepositoryItemComboBox2.Items.Add("Requerimento do Conselho")
            RepositoryItemComboBox2.Items.Add("Reunião de Pais e Mestres")

        End If
    End Sub

    Private Sub cbEstilo_EditValueChanged(sender As Object, e As EventArgs) Handles cbEstilo.EditValueChanged

        'Estilos
        cbFiltro.Enabled = True
        cbFiltro.EditValue = String.Empty
        RepositoryItemComboBox3.Items.Clear()

        Dim MeuEstilo As String = cbEstilo.EditValue

        If MeuEstilo.Contains("Período") Then
            RepositoryItemComboBox3.Items.Add("Manhã")
            RepositoryItemComboBox3.Items.Add("Tarde")
            RepositoryItemComboBox3.Items.Add("Noite")
            RepositoryItemComboBox3.Items.Add("Integral")

        Else
            RepositoryItemComboBox3.Items.Add("TODAS AS TURMAS")
            SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
            Dim Retorno As DataTable = MySQL_datatable(SQL)
            For Each r In Retorno.Rows
                RepositoryItemComboBox3.Items.Add(r("classe"))
            Next

        End If
    End Sub

    Private Sub btBuscar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btBuscar.ItemClick

        If cbRelatorio.EditValue = String.Empty Or cbEstilo.EditValue = String.Empty Or cbFiltro.EditValue = String.Empty Then
            MsgBox("Preencha os campos!", MsgBoxStyle.Information, "Mais Escola!")

        Else

            Dim Teste_AF As String = cbEstilo.EditValue
            If Teste_AF.Contains("Avaliação Final") And cbAF.Checked = False Then
                MsgBox("Escolher a opção com Avaliação Final no bimestre!", MsgBoxStyle.Information, "Mais Escola!")
                Exit Sub
            End If

            ' Procura Relatório ...

            ZeraCronometro()

            If cbAF.Checked = True Then
                frmRpt_bimestre = tBimestre.EditValue & "AF"
            Else
                frmRpt_bimestre = tBimestre.EditValue
            End If

            frmRpt_anovigente = tAno.EditValue
            frmRpt_grupoTurma = cbFiltro.EditValue

            If cbFiltro.EditValue = "TODAS AS TURMAS" Then
                frmRpt_tipo = "TurmaTodas"
            Else
                frmRpt_Tipo = cbEstilo.EditValue
            End If

            SQL_frmRPT = meuRpt2(cbRelatorio.EditValue, cbEstilo.EditValue)
            Try
                bwConsulta.RunWorkerAsync()
            Catch ex As Exception
                MsgBox("Já existe uma consulta em andamento!", MsgBoxStyle.Information, "Atenção!")
            End Try

        End If
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

    Private Sub frmTempo_Tick(sender As Object, e As EventArgs) Handles frmTempo.Tick
        ' ... NAO EXISTE RELATORIO ...
        frmTempo.Stop()
    End Sub

    Private Sub frmRptRelatorio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            crReportDocument.Close()
            crReportDocument.Dispose()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmRptRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tAno.EditValue = AnoVigente
        tBimestre.EditValue = consultaBimestre()

    End Sub

    Private Sub cbAF_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles cbAF.CheckedChanged

        If cbAF.Checked = True Then
            tBimestre.Enabled = False
        Else
            tBimestre.Enabled = True
        End If

    End Sub

    Private Sub tBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles tBimestre.EditValueChanged

        If tBimestre.EditValue = "2" Or tBimestre.EditValue = "4" Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If

    End Sub
End Class