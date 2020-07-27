Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel

Public Class frmRptGrafico
    Dim r As DataRow

    Dim iAlunos = 0
    Dim bimestre = String.Empty

    Dim Filtro
    ReadOnly cronometro As New Stopwatch
    Dim EncontreiDados As Boolean = False
    Dim CancelouConsulta = False

    Public Sub New(frmRpt_Parametro As String, selecionaNomeAno As String, selecionaNomeNroTr As String,
                   selecionaNomeNro As String, selecionaNome As String)

        If frmRpt_Parametro <> Nothing Then

            InitializeComponent()

            btVisualizar.Enabled = False

            frmRpt_anovigente = selecionaNomeAno
            frmRpt_grupoTurma = selecionaNomeNroTr
            frmRpt_nome = selecionaNome

            SQL_frmRPT = meuRPT(frmRpt_Parametro)

            bwConsulta.RunWorkerAsync()

            MsgBox(String.Format("Página: {0}{1}Aluno: [{2}]", selecionaNomeNro, vbCrLf, selecionaNome),
                   MsgBoxStyle.Information, "Gerando relatório...")

            'barraConsulta.Text = String.Format("Carregando... [{0}]", selecionaNome)
            ' barraConsulta.ProgressType = eProgressItemType.Marquee

            '   frmRpt_Parametro = Nothing

        Else
            InitializeComponent()

        End If
    End Sub

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
    Public Sub PesquisarAluno()

        If tbNome.Text = String.Empty Then
            MsgBox("Digite um nome para consultar!", MsgBoxStyle.Information, "Mais Escola!")
        Else

            iAlunos = 0
            SQL =
                String.Format(
                    "SELECT a.nome AS Nome, t.classe AS Turma, a.anovigente AS Ano, a.nro AS Nro, a.codigo_aluno AS Codigo, t.codigo_trma AS CodigoTurma FROM aluno a, turma t WHERE a.turma=t.codigo_trma AND a.nome LIKE '%{0}%' ORDER BY a.nome, a.anovigente ASC",
                    tbNome.Text)
            Dim MinhaTabela = MySQL_datatable(SQL)
            For Each r In MinhaTabela.Rows
                iAlunos = iAlunos + 1
            Next

            If iAlunos = 1 Then

                frmRpt_anovigente = r("anovigente")
                frmRpt_grupoTurma = r("codigo_trma")

                btVisualizar.Enabled = False

                SQL_frmRPT = meuRPT(frmRpt_Parametro)

                bwConsulta.RunWorkerAsync()

                MsgBox(String.Format("Página: {0}{1}Aluno: [{2}]", r("nro"), vbCrLf, r("nome")), MsgBoxStyle.Information, "Gerando relatório...")

            ElseIf iAlunos > 1 Then

                MsgBox(String.Format("{0} alunos encontrado!", iAlunos), MsgBoxStyle.Information, "Procura de Alunos!")
                '...chama GRADE de Alunos para pesquisa!
                '  Dim fGerencialNOME As New frmRptRelatorioAlunos(SQL, frmRpt_Parametro)
                '  fGerencialNOME.Show()
                '  Me.Close()

            Else

                MsgBox("Não encontrado!", MsgBoxStyle.Information)
                btVisualizar.Enabled = False

            End If


        End If
    End Sub

    Public Sub ZerarDados()

        btVisualizar.Enabled = False
        ' crViewer.ReportSource = Nothing

        iAlunos = 0
        cbRelatorioFiltro.Text = String.Empty
        tbNome.Text = String.Empty
        cbTurma.Text = String.Empty

        Try
            crReportDocument.Close()
            crReportDocument.Dispose()
        Catch ex As Exception
        End Try

        navTurma.Visible = False
        navTurmaSelecionar.Visible = False
        navPeriodo.Visible = False

        'navDeclaracao.Visible = False
        navAluno.Visible = False
        navEvasao.Visible = False

        tBimestre.Enabled = False
    End Sub

    Public Sub RefreshTurmas(TodasAsTurmas As Boolean)

        Dim Turma As DataTable
        SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe"
        Turma = MySQL_combobox(SQL)

        cbTurma.Items.Clear()
        If TodasAsTurmas = True Then
            cbTurma.Items.Add("TODAS AS TURMAS")
        End If

        For Each r In Turma.Rows
            cbTurma.Items.Add(r("classe"))
            cbTurmaLista.Items.Add(r("classe"))
        Next
    End Sub

    Private Sub frmRptRelatorio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If bwConsulta.IsBusy = True Then
            If MsgBox("Deseja cancelar a consulta?", MsgBoxStyle.YesNo, "Consulta em andamento...") = MsgBoxResult.Yes Then

                CancelouConsulta = True
                frmPrincipal.WindowState = FormWindowState.Maximized
            Else
                e.Cancel = True
            End If
        Else
            frmPrincipal.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub frmRptRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Ano Padrão (Atual)
        tAno.Value = AnoVigente

        ' Coloca como padrão, sem nenhuma aba.
        '.navDeclaracao.Visible = False
        navAluno.Visible = False
        navTurma.Visible = False

        navTurmaSelecionar.Visible = False
        navPeriodo.Visible = False
        navEvasao.Visible = False

        '  Me.TopMost = True

        CancelouConsulta = False
    End Sub

    Private Sub cbAF_CheckedChanged(sender As Object, e As EventArgs) Handles cbAF.CheckedChanged

        If (tBimestre.Value = "2" Or tBimestre.Value = "4") And cbAF.Checked = True Then
            tBimestre.Enabled = False
        Else
            tBimestre.Enabled = True
        End If
    End Sub

    Private Sub cbRelatorio_TextChanged(sender As Object, e As EventArgs) Handles cbRelatorio.TextChanged

        ZerarDados()

        cbRelatorioFiltro.Enabled = True
        cbRelatorioFiltro.Properties.Items.Clear()

        If cbRelatorio.Text = "Básico" Then
            cbRelatorioFiltro.Properties.Items.Add("Escola em Geral")
            cbRelatorioFiltro.Properties.Items.Add("Por Período")
            cbRelatorioFiltro.Properties.Items.Add("Por Turma")
            cbRelatorioFiltro.Properties.Items.Add("Evasão Escolar")

        ElseIf cbRelatorio.Text = "Detalhado" Then
            cbRelatorioFiltro.Properties.Items.Add("Por Período")
            cbRelatorioFiltro.Properties.Items.Add("Por Turma")

        End If
    End Sub

    Private Sub btVisualizar_Click(sender As Object, e As EventArgs) Handles btVisualizar.Click

        If Not bwConsulta.IsBusy = True Then

            ZeraCronometro()

            If cbRelatorio.Text = "Básico" And cbRelatorioFiltro.Text = "Evasão Escolar" Then

                If cbEvasao.Text = "Abandono" Then
                    frmRpt_Parametro = "ABEvasaoEscolar"
                ElseIf cbEvasao.Text = "Licença Saúde" Then
                    frmRpt_Parametro = "LSEvasaoEscolar"
                ElseIf cbEvasao.Text = "Licença Gestante" Then
                    frmRpt_Parametro = "LGEvasaoEscolar"
                ElseIf cbEvasao.Text = "Óbitos" Then
                    frmRpt_Parametro = "FAEvasaoEscolar"
                ElseIf cbEvasao.Text = "Remanejados" Then
                    frmRpt_Parametro = "REEvasaoEscolar"
                ElseIf cbEvasao.Text = "Transferidos" Then
                    frmRpt_Parametro = "TREvasaoEscolar"
                End If

            End If


            '\\\ PARAMETROS ///
            If tBimestre.Value = "2" And cbAF.Checked = True Then
                bimestre = "2AF"
            ElseIf tBimestre.Value = "4" And cbAF.Checked = True Then
                bimestre = "4AF"
            Else
                bimestre = tBimestre.Value
            End If

            frmRpt_anovigente = tAno.Value
            frmRpt_codigo = bimestre
            frmRpt_nome = tbNome.Text
            frmRpt_Tipo = cbRelatorio.Text
            grupoPeriodo = cbPeriodo.Text

            If navTurmaSelecionar.Expanded = True Then
                grupoTurmas = String.Empty
                contador = 0
                frmRpt_Parametro = "GrupoTurmas2"
                'Verifica as turmas selecionadas
                For Each item As CheckedListBoxItem In cbTurmaLista.Items
                    If item.CheckState = CheckState.Checked Then
                        If contador > 0 Then
                            grupoTurmas += " OR "
                        End If
                        grupoTurmas += String.Format("t.classe='{0}'", item.Value)
                        contador += 1
                    End If
                Next
                'fim
            End If

            'barraConsulta.Text = "Solicitando..."
            SQL_frmRPT = meuRPT(frmRpt_Parametro)

            ' barraConsulta.Text = "Carregando..."
            ' barraConsulta.ProgressType = eProgressItemType.Marquee

            bwConsulta.RunWorkerAsync()

        Else
            MsgBox("Consulta em andamento...", MsgBoxStyle.Information, "Informação!")
        End If
    End Sub

    Private Sub cbRelatorioFiltro_TextChanged(sender As Object, e As EventArgs) Handles cbRelatorioFiltro.TextChanged

        'navTurma.Visible = False
        'navTurmaSelecionar.Visible = False
        'navPeriodo.Visible = False

        'navDeclaracao.Visible = False
        'navAluno.Visible = False
        'navATA.Visible = False

        'If cbRelatorio.Text = "Básico" Then
        '    cbRelatorioFiltro.Items.Add("Escola em Geral")
        '    cbRelatorioFiltro.Items.Add("Por Período")
        '    cbRelatorioFiltro.Items.Add("Por Turma")
        '    cbRelatorioFiltro.Items.Add("Evasão Escolar")

        'ElseIf cbRelatorio.Text = "Detalhado" Then
        '    cbRelatorioFiltro.Items.Add("Por Período")
        '    cbRelatorioFiltro.Items.Add("Por Turma")

        'End If

        'ZerarDados()

        Filtro = cbRelatorioFiltro.SelectedItem

        If cbRelatorio.Text = "Básico" Then

            If Filtro = ("Escola em Geral") Then
                frmRpt_Parametro = "TGraficos"

            ElseIf Filtro = ("Por Período") Then
                frmRpt_Parametro = "GrupoPeriodo"
                frmRpt_grupoCompara = 0
                tBimestre.Enabled = True

                navPeriodo.Visible = True
                navPeriodo.Expanded = True

            ElseIf Filtro = ("Por Turma") Then
                frmRpt_Parametro = "GrupoTurmas"
                frmRpt_grupoCompara = 0
                tBimestre.Enabled = True

                navTurma.Visible = True
                navTurma.Expanded = False

                'navTurmaSelecionar.Visible = True
                ' navTurmaSelecionar.Expanded = False

                RefreshTurmas(True)

            ElseIf Filtro = ("Evasão Escolar") Then
                tBimestre.Enabled = False

                navEvasao.Visible = True
                navEvasao.Expanded = True

            End If


        ElseIf cbRelatorio.Text = "Detalhado" Then
            tBimestre.Enabled = True

            If Filtro = ("Por Período") Then
                frmRpt_Parametro = "GrupoPeriodo"
                frmRpt_grupoCompara = 0
                tBimestre.Enabled = True

                navPeriodo.Visible = True
                navPeriodo.Expanded = True

            ElseIf Filtro = ("Por Turma") Then
                frmRpt_Parametro = "GrupoTurmas"
                frmRpt_grupoCompara = 0
                tBimestre.Enabled = True

                RefreshTurmas(True)

                navTurma.Visible = True
                navTurma.Expanded = False

                navTurmaSelecionar.Visible = True
                navTurmaSelecionar.Expanded = False

            End If


        End If

        btVisualizar.Enabled = True
    End Sub

    Private Sub cbTurma_TextChanged(sender As Object, e As EventArgs) Handles cbTurma.TextChanged

        If cbTurma.Text = "TODAS AS TURMAS" Then
            frmRpt_grupoTurma = 0
        Else
            frmRpt_grupoTurma = Consulta_Turma(cbTurma.Text)
        End If
        btVisualizar.Enabled = True

    End Sub

    Private Sub bwConsulta_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwConsulta.DoWork

        Dim consultaRelatorio01

        If SQL_frmRPT <> String.Empty Then

            consultaRelatorio01 = MySQL_report(SQL_frmRPT)

            If consultaRelatorio01.Rows.Count = "0" Then
                ' VERIFICA SE FOI PREENCHIDO O ENDEREÇO DA ESCOLA...
                SQL = "SELECT file_id FROM file where file_id='1';"
                Dim Retorno = MySQL_consulta_campo(SQL, "file_id")
                If Retorno = "0" Then
                    cronometro.Stop()
                    tempoBarra.Stop()

                    MsgBox("Clicar no menu Sobre / Escola para preencher o cadastro da escola!", MsgBoxStyle.Information, Sistema)
                    EncontreiDados = False
                    frmTempo.Start()

                    Exit Sub
                Else
                    cronometro.Stop()
                    tempoBarra.Stop()

                    MsgBox(
                        String.Format(
                            "Não encontramos informações para esta consulta!{0}Verificar: {0}1 - Lista de Alunos no ano pesquisado.{0}2 - Todos os campos foram preenchidos.",
                            vbCrLf), MsgBoxStyle.Information, Sistema)
                    EncontreiDados = False
                    Exit Sub
                End If

            Else

                crReportDocument.SetDataSource(consultaRelatorio01)
                If SQL_Sub <> String.Empty Then
                    crReportDocument.Subreports(0).SetDataSource(MySQL_report(SQL_Sub))
                End If
                EncontreiDados = True
            End If

        End If
    End Sub

    Private Sub bwConsulta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwConsulta.RunWorkerCompleted

        If CancelouConsulta = False Then

            If EncontreiDados = True Then
                crViewer.ReportSource = crReportDocument
                barra.Properties.Paused = True
                cronometro.Stop()
                tempoBarra.Stop()
            End If

            btVisualizar.Enabled = True

        End If
    End Sub

    Private Sub tbNome_TextChanged(sender As Object, e As EventArgs) Handles tbNome.TextChanged
        btVisualizar.Enabled = True
    End Sub

    Private Sub cbTurmaLista_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbTurmaLista.SelectedValueChanged
        btVisualizar.Enabled = True
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

    Private Sub tBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles tBimestre.EditValueChanged
        If (tBimestre.Value = "2" Or tBimestre.Value = "4") Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
    End Sub

End Class