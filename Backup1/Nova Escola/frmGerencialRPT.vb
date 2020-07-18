Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports Mais_Escola
Imports CrystalDecisions.Shared

Public Class frmGerencialRPT

    Dim crReportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim nrodisciplina
    Dim nroturma
    Dim iAlunos = 0

    Private Sub frmGerencialRPT_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If iProcura = 1 Then
                tbNome.Text = selecionaNome
                cbTurma.Text = selecionaNomeTr
                tAno.Value = selecionaNomeAno

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmGerencialRPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = Format(Date.Now, "yyyy")

        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        selecionaNome = ""
        selecionaNomeID = 0
        selecionaNomeTr = ""
        selecionaNomeAno = ""
        selecionaNomeNro = 0
        iProcura = ""

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                SQL = "SELECT * FROM disciplinas ORDER BY disciplina"
                SQL2 = "SELECT * FROM turma WHERE bloqueado=0 ORDER BY classe"

                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                myCommand2.Connection = conn
                myCommand2.CommandText = SQL2
                myAdapter2.SelectCommand = myCommand2
                myAdapter2.Fill(myData2)

                Try
                    r2 = myData2.Rows(0)
                    r = myData.Rows(0)

                Catch ex As Exception
                End Try

                cbDisciplina.Items.Clear()
                cbTurma.Items.Clear()

                For Each r In myData.Rows
                    cbDisciplina.Items.Add(r("disciplina"))
                Next

                For Each r2 In myData2.Rows
                    If (r2("bloqueado") = 0) Then
                        cbTurma.Items.Add(r2("classe"))
                    End If
                Next

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try



    End Sub

    Private Sub pbProcurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbProcurar.Click

        If tbNome.Text = "" Then
            MsgBox("Digite uma palavra para consultar!", MsgBoxStyle.Critical)

        Else

            iAlunos = 0
            myData3.Clear()
            myData3.Columns.Clear()

            '''''''''''''CARREGA INICIALMENTE''''''''''''
            Dim conn3 As MySqlConnection

            conn3 = New MySqlConnection()
            conn3.ConnectionString = CONEXAOBD

            SQL3 = "SELECT a.nome, t.classe, a.anovigente, a.nro, a.codigo_aluno FROM aluno a, turma t WHERE a.turma=t.codigo_trma AND a.nome LIKE '%" & tbNome.Text & "%' ORDER BY a.nome ASC"

            Try
                conn3.Open()
                Try
                    myCommand3.Connection = conn3
                    myCommand3.CommandText = SQL3
                    myAdapter3.SelectCommand = myCommand3
                    myAdapter3.Fill(myData3)

                    For Each r3 In myData3.Rows
                        iAlunos = iAlunos + 1
                    Next

                    If iAlunos = 1 Then
                        lbNome.Text = "" & iAlunos & " encontrado!"
                        lbNome.ForeColor = Color.Blue

                        tbNome.Text = r3("nome")
                        selecionaNomeID = r3("nro")
                        selecionaNomeTr = r3("classe")
                        selecionaNomeAno = r3("anovigente")

                        cbTurma.Text = selecionaNomeTr
                        tAno.Value = selecionaNomeAno

                        btVisualizar.Enabled = True


                    ElseIf iAlunos > 1 Then
                        lbNome.Text = "" & iAlunos & " encontrados!"
                        lbNome.ForeColor = Color.Blue
                        frmGerencialNOME.Show()

                    Else
                        lbNome.Text = "Não encontrado!"
                        lbNome.ForeColor = Color.Red
                        btVisualizar.Enabled = False
                    End If


                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn3.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn3.Dispose()
            End Try
        End If

    End Sub

    Private Sub frmGerencialRPT_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Try
            If iProcura = 1 Then
                tbNome.Text = selecionaNome
                cbTurma.Text = selecionaNomeTr
                tAno.Value = selecionaNomeAno

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tBimestre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBimestre.ValueChanged
        If tBimestre.Value = 2 Or tBimestre.Value = 4 Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click

        Dim bimestre As String

        If cbAF.Checked = True And tBimestre.Value = 2 Then
            bimestre = "2AF"
        ElseIf cbAF.Checked = True And tBimestre.Value = 4 Then
            bimestre = "4AF"
        Else
            bimestre = tBimestre.Value
        End If

        Dim trava = 0
        myData2.Clear()

        '####################################SE ESCOLHER COM FILTRO
        If checkFiltro.Checked = True Then

            If (cbTurma.Text = "") Then
                MsgBox("Verifique os campos!", MsgBoxStyle.Exclamation, "Atenção!")
                Exit Sub

            ElseIf ((cbTurma.Text <> "") Or (cbDisciplina.Text <> "")) And checkDisciplinas.Checked = False Then

                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;Allow User Variables=True;database=" & BD_OK

                Try
                    conn.Open()
                    Try

                        '================= Ata do Conselho ================='
                        If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Completo" Then
                            SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM aluno p, turma t WHERE p.turma=t.codigo_trma AND p.turma=" & nroturma & " AND p.anovigente=" & tAno.Value & " ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\RAlunos.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument
                        End If

                        If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Reunião de Pais e Mestres" Then
                            SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM aluno p, turma t WHERE p.turma=t.codigo_trma AND p.turma=" & nroturma & " AND p.anovigente=" & tAno.Value & " ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\RAlunos2.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument
                        End If

                        ' ''================= Consolidado ================='
                        ''If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Comum" Then
                        ''    SQL2 = "SELECT DISTINCT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma  AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "'"
                        ''    myCommand2.Connection = conn
                        ''    myCommand2.CommandText = SQL2
                        ''    myAdapter2.SelectCommand = myCommand2
                        ''    myAdapter2.Fill(myData2)

                        ''    crReportDocument.Load(meucaminho & "\reports\Consolidado.rpt")
                        ''    crReportDocument.SetDataSource(myData2)
                        ''    frmRpt.crViewer.ReportSource = crReportDocument

                        ''End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - AB") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT DISTINCT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=12  AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "'"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\ABEvasaoEscolar.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - TR") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT DISTINCT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=11 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "'"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\TREvasaoEscolar.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - LG") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT DISTINCT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=13 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "'"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\LGEvasaoEscolar.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - LS") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT DISTINCT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=14 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "'"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\LSEvasaoEscolar.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument
                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - RE") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT DISTINCT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=15 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "'"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\REEvasaoEscolar.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - FA") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT DISTINCT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=16 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "'"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\FAEvasaoEscolar.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument

                        End If


                    Catch myerro As Exception
                        MsgBox("Desculpe, não houve cadastro para a solicitação deste relatório!", MsgBoxStyle.Exclamation, "Atenção")
                        Exit Sub
                    End Try
                    conn.Close()
                Catch myerro As MySqlException
                    'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn.Dispose()
                End Try

                Me.Close()
                frmRpt.Show()

            ElseIf cbDisciplina.Text = "Todas" And checkDisciplinas.Checked = True Then
                '############################ TODAS DISCIPLINAS / CHECAR DISCIPLINAS ##############################
                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;Allow User Variables=True;database=" & BD_OK

                Try
                    conn.Open()
                    Try

                        '================= Ata do Conselho ================='
                        If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Completo" Then
                            SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM aluno p, turma t WHERE p.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "' ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\RAlunos.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument

                        End If

                        If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Reunião de Pais e Mestres" Then
                            SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM aluno p, turma t WHERE p.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "' ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\RAlunos2.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument

                        End If

                        If cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Somente Notas" Then
                            SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma  AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "';"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\BoletimSN.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument

                        End If

                        '================= Gráficos ================='
                        If cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Turmas" Then
                            SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre='" & bimestre & "'"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\Graficos.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument
                        End If

                        '================= Consolidado ================='
                        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Comum" Then
                            'SQL2 = "SELECT DISTINCT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente='" & tAno.Value & "' AND n.cod_bimestre='" & bimestre & "'"
                            SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente='" & tAno.Value & "' AND n.cod_bimestre='" & bimestre & "';"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument.Load(meucaminho & "\reports\Consolidado.rpt")
                            crReportDocument.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument
                        End If

                    Catch myerro As Exception
                        MsgBox("Desculpe, não houve cadastro para a solicitação deste relatório!", MsgBoxStyle.Exclamation, "Atenção")
                        Exit Sub
                    End Try
                    conn.Close()
                Catch myerro As MySqlException
                    ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn.Dispose()
                End Try

                Me.Close()
                frmRpt.Show()
            End If

        Else

            '############################################SE ESCOLHER SEM FILTRO###########################################
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;Allow User Variables=True;database=" & BD_OK

            Try
                conn.Open()
                Try

                    '================= Ata do Conselho ================='
                    If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Completo" Then
                        SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma ORDER BY nro;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\RAlunos.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Reunião de Pais e Mestres" Then
                        SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma ORDER BY nro;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\RAlunos2.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Completo" Then
                        SQL2 = "SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, boletim.nro_aluno, boletim.M, boletim.F, boletim.AC, boletim.S, boletim.porcentagem, notasfreq.cod_bimestre, notasfreq.previsaoaulas, notasfreq.qtdadeaulas, disciplinas.disciplina, notasfreq.anovigente, turma.classe FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola WHERE notasfreq.cod_bimestre='" & bimestre & "' AND notasfreq.anovigente='" & tAno.Value & "';"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        If bimestre = "2AF" Or bimestre = "4AF" Then
                            crReportDocument.Load(meucaminho & "\reports\ConsolidadoAF.rpt")
                        Else
                            crReportDocument.Load(meucaminho & "\reports\ConsolidadoCompleto.rpt")
                        End If

                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                        '================= Boletim ================='
                    ElseIf cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Completo" Then
                        SQL2 = "SELECT boletim.nro_aluno, turma.classe," _
                        & " aluno.nome AS nome," _
                        & " aluno.ra AS ra," _
                        & " notasfreq.cod_bimestre," _
                        & " notasfreq.anovigente," _
                        & " disciplinas.disciplina," _
                        & " boletim.M AS Avaliacao," _
                        & " boletim.F AS Faltas," _
                        & " boletim.porcentagem," _
                        & " notasfreq.qtdadeaulas," _
                        & " escola.de," _
                        & " escola.nome AS nomeescola" _
                        & " FROM" _
                        & " notasfreq" _
                        & " INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim)" _
                        & " INNER JOIN aluno ON (notasfreq.turma = aluno.turma)" _
                        & " AND (notasfreq.anovigente = aluno.anovigente)" _
                        & " AND (boletim.nro_aluno = aluno.nro)" _
                        & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                        & " INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc)," _
                        & " escola" _
                        & " WHERE turma.codigo_trma='" & nroturma & "' AND notasfreq.anovigente='" & tAno.Value & "';"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\Boletim.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Somente Notas - s/ nome" Then
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente=" & CInt(tAno.Value) & " AND n.turma='" & nroturma & "';"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\BoletimSN.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Somente Notas - c/ nome" Then
                        SQL2 = "SELECT b.nro_aluno, e.de, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, a.nome, a.ra, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d, " & BD_OK & ".aluno a, " & BD_OK & ".escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND n.anovigente=" & CInt(tAno.Value) & " AND n.turma='" & nroturma & "' ORDER BY nro;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\BoletimCN.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Nome do Aluno" Then
                        SQL2 = "SELECT b.nro_aluno, e.de, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, a.nome, a.ra, b.M AS Avaliacao, b.F AS Faltas, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, aluno a, escola e WHERE n.anovigente=a.anovigente AND n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND n.anovigente=" & selecionaNomeAno & " AND t.codigo_trma='" & nroturma & "';"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\Boletim.rpt")
                        crReportDocument.SetDataSource(myData2)

                        MsgBox("Aluno: " & selecionaNome & vbCrLf & "Página: " & selecionaNomeNro, MsgBoxStyle.Information, "Boletim do Aluno")
                        frmRpt.crViewer.ReportSource = crReportDocument

                        '================= Gráficos ================='
                    ElseIf cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Turmas" Then
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.cod_bimestre='" & bimestre & "' AND n.anovigente='" & tAno.Value & "';"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\Graficos.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Escola em Geral" Then
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente=" & tAno.Value & ""
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\Graficos2.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - AB") Then
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=12;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\ABEvasaoEscolar.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - TR") Then
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=11;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\TREvasaoEscolar.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument


                    ElseIf cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - LG") Then
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=13;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\LGEvasaoEscolar.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument

                    ElseIf cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - LS") Then
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=14;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\LSEvasaoEscolar.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument


                    ElseIf cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - RE") Then
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=15;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\REEvasaoEscolar.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument


                    ElseIf cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - FA") Then
                        '  Me.Text = "Relatório - Gráfico: Evasão Escolar"
                        SQL2 = "SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=16;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\FAEvasaoEscolar.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument


                        '''''''''''''''''''''''''''''''''''''''''''''''''''
                        ' FICHA INDIVIDUAL DO ALUNO
                        '
                    ElseIf cbRelatorio.Text = "Ficha Individual" And (cbFiltro.Text = "Por Nome") Then
                        SQL2 = "SELECT b.nro_aluno, e.de, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, a.nome, a.ra, a.data AS datanascimento, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM escola e, turma t, notasfreq n, boletim b, disciplinas d, aluno a WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND a.nome='" & tbNome.Text & "'"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\FichaAluno.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument
                        frmRpt.Text = "Relatório - Ficha Individual: Por Aluno"

                    ElseIf cbRelatorio.Text = "Ficha Individual" And (cbFiltro.Text = "Todos") Then
                        SQL2 = "SELECT b.nro_aluno, e.de, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, a.nome, a.ra, a.data AS datanascimento, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM escola e, turma t, notasfreq n, boletim b, disciplinas d, aluno a WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND n.anovigente='" & tAno.Value & "';"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument.Load(meucaminho & "\reports\FichaAluno.rpt")
                        crReportDocument.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument
                        frmRpt.Text = "Relatório - Ficha Individual: Todos"

                    End If


                Catch myerro As Exception
                    MsgBox("Desculpe, não houve cadastro para a solicitação deste relatório!", MsgBoxStyle.Exclamation, "Atenção")
                    'MsgBox(myerro.Message)
                    Exit Sub
                End Try
                'MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try

            ''If trava = 1 Then
            ''    MsgBox("Desculpe, não houve cadastro para a solicitação deste relatório!", MsgBoxStyle.Exclamation, "Atenção!")
            ''    Exit Sub

            ''Else
            ''    Me.Close()
            ''    frmRpt.Show()
            ''End If

            Me.Close()
            frmRpt.Show()
        End If

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub checkFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFiltro.CheckedChanged
        If checkFiltro.Checked = True Then

            If cbDisciplina.Text = "Todas" Then
                cbDisciplina.Enabled = False
                Exit Sub

            ElseIf cbFiltro.Text = "Completo" And cbRelatorio.Text = "Boletim" Then
                tBimestre.Enabled = False
                cbDisciplina.Enabled = True
                cbTurma.Enabled = True
                tAno.Enabled = True
                checkDisciplinas.Enabled = False
                checkDisciplinas.Checked = True
                Exit Sub

            ElseIf cbFiltro.Text = "Somente Notas" And cbRelatorio.Text = "Boletim" Then
                tBimestre.Enabled = False
                cbDisciplina.Enabled = True
                cbTurma.Enabled = True
                tAno.Enabled = True
                checkDisciplinas.Enabled = False
                checkDisciplinas.Checked = True
                tbNome.Text = False
                Exit Sub

            ElseIf cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Completo" Then
                tAno.Enabled = True
                cbTurma.Enabled = False
                tBimestre.Enabled = True
                Exit Sub

            ElseIf cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Alunos Reprovados" Then
                tAno.Enabled = True
                cbTurma.Enabled = True
                tBimestre.Enabled = True
                Exit Sub

            ElseIf cbFiltro.Text = "Completo" Or cbFiltro.Text = "Reunião de Pais e Mestres" Then
                tAno.Enabled = True
                cbTurma.Enabled = True
                Exit Sub

            ElseIf cbFiltro.Text = "Evasão Escolar - AB" Or cbFiltro.Text = "Evasão Escolar - TR" Or cbFiltro.Text = "Evasão Escolar - LG" Or cbFiltro.Text = "Evasão Escolar - LS" Or cbFiltro.Text = "Evasão Escolar - RE" Or cbFiltro.Text = "Evasão Escolar - FA" Then
                tAno.Enabled = True
                tBimestre.Enabled = True
                cbDisciplina.Text = "-"
                cbTurma.Text = "-"

                Exit Sub

            End If

            cbDisciplina.Text = ""
            cbTurma.Text = ""

            cbDisciplina.Enabled = True
            cbTurma.Enabled = True
            tAno.Enabled = True
            tBimestre.Enabled = True
            checkDisciplinas.Enabled = True
            checkDisciplinas.Checked = False

        Else
            cbDisciplina.Enabled = False
            cbTurma.Enabled = False
            tAno.Enabled = False
            tBimestre.Enabled = False
            checkDisciplinas.Enabled = False
            checkDisciplinas.Checked = False
            cbDisciplina.Enabled = False
        End If

    End Sub

    Private Sub checkTurmas_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTurmas.CheckedChanged
        If checkTurmas.Checked = True Then
            cbTurma.Enabled = False
            cbTurma.Text = "Todas"
        Else
            cbTurma.Enabled = True
            cbTurma.Text = ""
        End If

    End Sub

    Private Sub checkDisciplinas_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkDisciplinas.CheckedChanged
        If checkDisciplinas.Checked = True Then
            cbDisciplina.Enabled = False
            cbDisciplina.Text = "Todas"
        Else
            cbDisciplina.Enabled = True
            cbDisciplina.Text = ""
        End If
    End Sub

    Private Sub cbAF_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged
        If cbAF.Checked = True Then
            tBimestre.Enabled = False
        Else
            tBimestre.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRelatorio.SelectedIndexChanged

        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        tAno.Enabled = False
        cbAF.Checked = False
        checkFiltro.Checked = False
        checkDisciplinas.Checked = False
        checkTurmas.Checked = False
        checkFiltro.Enabled = False
        checkDisciplinas.Enabled = False
        checkTurmas.Enabled = False
        cbTurma.Enabled = False
        cbDisciplina.Enabled = False
        tbNome.Enabled = False

        If cbRelatorio.Text = "Ata do Conselho" Then
            cbFiltro.Enabled = True
            cbFiltro.Items.Clear()
            cbFiltro.ResetText()
            cbFiltro.Items.Add("Completo")
            cbFiltro.Items.Add("Reunião de Pais e Mestres")
            btVisualizar.Enabled = False

        ElseIf cbRelatorio.Text = "Boletim" Then
            cbFiltro.Enabled = True
            cbFiltro.Items.Clear()
            cbFiltro.ResetText()
            cbFiltro.Items.Add("Completo")
            cbFiltro.Items.Add("Nome do Aluno")
            cbFiltro.Items.Add("Somente Notas - s/ nome")
            cbFiltro.Items.Add("Somente Notas - c/ nome")

            btVisualizar.Enabled = False

        ElseIf cbRelatorio.Text = "Gráficos" Then
            cbFiltro.Enabled = True
            cbFiltro.Items.Clear()
            cbFiltro.ResetText()
            cbFiltro.Items.Add("Turmas")
            cbFiltro.Items.Add("Escola em Geral")
            cbFiltro.Items.Add("Evasão Escolar - AB")
            cbFiltro.Items.Add("Evasão Escolar - TR")
            cbFiltro.Items.Add("Evasão Escolar - LG")
            cbFiltro.Items.Add("Evasão Escolar - LS")
            cbFiltro.Items.Add("Evasão Escolar - RE")
            cbFiltro.Items.Add("Evasão Escolar - FA")
            btVisualizar.Enabled = False

        ElseIf cbRelatorio.Text = "Consolidado" Then
            cbFiltro.Enabled = True
            cbFiltro.Items.Clear()
            cbFiltro.ResetText()
            cbFiltro.Items.Add("Alunos Reprovados")
            cbFiltro.Items.Add("Completo")
            cbFiltro.Items.Add("Comum")
            btVisualizar.Enabled = False

        ElseIf cbRelatorio.Text = "Ficha Individual" Then
            cbFiltro.Enabled = True
            cbFiltro.Items.Clear()
            cbFiltro.ResetText()
            cbFiltro.Items.Add("Por Nome")
            cbFiltro.Items.Add("Todos")
            btVisualizar.Enabled = False

        ElseIf cbRelatorio.Text = "Declaração Escolar" Then
            cbFiltro.Enabled = True
            cbFiltro.Items.Clear()
            cbFiltro.ResetText()
            cbFiltro.Items.Add("Simples")
            cbFiltro.Items.Add("Aluno Regularmente Matriculado")
            cbFiltro.Items.Add("Aluno Regularmente Matriculado")
            cbFiltro.Items.Add("Aluno Regularmente Matriculado")
            cbFiltro.Items.Add("Aluno Regularmente Matriculado")
            cbFiltro.Items.Add("Aluno Regularmente Matriculado")
            cbFiltro.Items.Add("Aluno Regularmente Matriculado")
            cbFiltro.Items.Add("Aluno Regularmente Matriculado")
            cbFiltro.Items.Add("Aluno Regularmente Matriculado")
            btVisualizar.Enabled = False

        ElseIf cbRelatorio.Text = "Histórico Escolar" Then
            cbFiltro.Enabled = True
            cbFiltro.Items.Clear()
            cbFiltro.ResetText()
            cbFiltro.Items.Add("Por Nome")
            btVisualizar.Enabled = False

        End If

    End Sub

    Private Sub cbFiltro_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltro.SelectedIndexChanged
        tAno.Enabled = False


        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        tAno.Enabled = False
        cbAF.Checked = False
        checkFiltro.Checked = False
        checkDisciplinas.Checked = False
        checkTurmas.Checked = False
        checkFiltro.Enabled = False
        checkDisciplinas.Enabled = False
        checkTurmas.Enabled = False
        cbTurma.Enabled = False
        cbDisciplina.Enabled = False
        tbNome.Enabled = False

        If cbFiltro.Text <> "" Then
            btVisualizar.Enabled = True
            checkFiltro.Enabled = True
        End If

        If cbFiltro.Text = "Escola em Geral" Then
            checkFiltro.Enabled = False
            tAno.Enabled = True
        End If

        If cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Turmas" Then
            checkFiltro.Enabled = False
            tAno.Enabled = True
        End If

        '''''''''''''''''''''''''''''''
        ' FICHA DE ALUNOS

        If cbRelatorio.Text = "Ficha Individual" And cbFiltro.Text = "Por Nome" Then
            checkFiltro.Enabled = False
            tAno.Enabled = False
            cbTurma.Enabled = False
            tbNome.Enabled = True
            pbProcurar.Enabled = True

        End If

        If cbRelatorio.Text = "Ficha Individual" And cbFiltro.Text = "Todos" Then
            checkFiltro.Enabled = False
            tAno.Enabled = True
        End If

        If cbRelatorio.Text = "Histórico Escolar" And cbFiltro.Text = "Por Nome" Then
            checkFiltro.Enabled = False
            tAno.Enabled = True
            cbTurma.Enabled = False

            tbNome.Enabled = True
            pbProcurar.Enabled = True

        End If
        ' FINAL FICHA DE ALUNOS
        '''''''''''''''''''''''''''''''

        If cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Turmas" Then
            tBimestre.Enabled = True

        End If

        '''''''''''''''''''''''''''''''
        ' CONSOLIDADO - COMPLETO
        '
        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Completo" Then
            checkFiltro.Enabled = False
            'checkFiltro.Checked = True
            checkTurmas.Checked = True
            checkTurmas.Enabled = False
            cbTurma.Enabled = False
            checkDisciplinas.Checked = True
            checkDisciplinas.Enabled = False
            tBimestre.Enabled = True
            tAno.Enabled = True

            tbNome.Enabled = False
            pbProcurar.Enabled = False
        End If
        ' FINAL CONSOLIDADO - COMPLETO
        '''''''''''''''''''''''''''''''

        '''''''''''''''''''''''''''''''
        ' CONSOLIDADO - COMUM
        '
        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Comum" Then
            checkFiltro.Enabled = False
            checkFiltro.Checked = True
            checkTurmas.Checked = True
            checkTurmas.Enabled = False
            checkDisciplinas.Checked = True
            checkDisciplinas.Enabled = False
            tBimestre.Enabled = True
            tAno.Enabled = True

            tbNome.Enabled = False
            pbProcurar.Enabled = False
        End If
        ' FINAL CONSOLIDADO - COMUM
        '''''''''''''''''''''''''''''''

        '''''''''''''''''''''''''''''''
        ' BOLETIM

        If cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Completo" Then
            checkFiltro.Enabled = False
            checkFiltro.Checked = False
            tAno.Enabled = True
            cbTurma.Enabled = True
            tBimestre.Enabled = False
            cbAF.Enabled = False
            tbNome.Enabled = False
            pbProcurar.Enabled = False

        End If

        If cbRelatorio.Text = "Boletim" And (cbFiltro.Text = "Somente Notas - c/ nome" Or cbFiltro.Text = "Somente Notas - s/ nome") Then
            checkFiltro.Enabled = False
            checkFiltro.Checked = False
            tAno.Enabled = True
            cbTurma.Enabled = True
            tBimestre.Enabled = False
            cbAF.Enabled = False
            tbNome.Enabled = False
            pbProcurar.Enabled = False

        ElseIf cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Nome do Aluno" Then
            checkFiltro.Enabled = False
            tbNome.Enabled = True
            tAno.Enabled = True
            pbProcurar.Enabled = True
            checkDisciplinas.Checked = True
            checkDisciplinas.Enabled = False
        End If

    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData3.Clear()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn3 As MySqlConnection

        conn3 = New MySqlConnection()
        conn3.ConnectionString = CONEXAOBD

        SQL3 = "SELECT * FROM " & BD_OK & ".turma WHERE classe='" & cbTurma.Text & "'"
        Try
            conn3.Open()
            Try
                myCommand3.Connection = conn3
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)

                r3 = myData3.Rows(0)
                nroturma = r3("codigo_trma")

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn3.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn3.Dispose()
        End Try


    End Sub

    Private Sub ComboBoxEx2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged

        myData5.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        SQL = "SELECT * FROM " & BD_OK & ".disciplinas WHERE disciplina='" & cbDisciplina.Text & "'"

        Try
            conn.Open()
            Try
                myCommand5.Connection = conn
                myCommand5.CommandText = SQL
                myAdapter5.SelectCommand = myCommand5
                myAdapter5.Fill(myData5)

                r5 = myData5.Rows(0)
                nrodisciplina = r5("codigo_disc")

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub TextBoxX1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNome.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True


            If tbNome.Text = "" Then
                MsgBox("Digite uma palavra para consultar!", MsgBoxStyle.Critical)

            Else

                iAlunos = 0
                myData3.Clear()
                myData3.Columns.Clear()

                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn3 As MySqlConnection

                conn3 = New MySqlConnection()
                conn3.ConnectionString = CONEXAOBD

                SQL3 = "SELECT a.nome, t.classe, a.anovigente, a.nro, a.codigo_aluno FROM aluno a, turma t WHERE a.turma=t.codigo_trma AND a.nome LIKE '%" & tbNome.Text & "%' ORDER BY a.nome ASC"

                Try
                    conn3.Open()
                    Try
                        myCommand3.Connection = conn3
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)

                        For Each r3 In myData3.Rows
                            iAlunos = iAlunos + 1
                        Next

                        If iAlunos = 1 Then
                            lbNome.Text = "" & iAlunos & " encontrado!"
                            lbNome.ForeColor = Color.Blue

                            tbNome.Text = r3("nome")
                            selecionaNomeID = r3("nro")
                            selecionaNomeTr = r3("classe")
                            selecionaNomeAno = r3("anovigente")

                            cbTurma.Text = selecionaNomeTr
                            tAno.Value = selecionaNomeAno

                            btVisualizar.Enabled = True


                        ElseIf iAlunos > 1 Then
                            lbNome.Text = "" & iAlunos & " encontrados!"
                            lbNome.ForeColor = Color.Blue
                            frmGerencialNOME.Show()

                        Else
                            lbNome.Text = "Não encontrado!"
                            lbNome.ForeColor = Color.Red
                            btVisualizar.Enabled = False
                        End If


                    Catch myerro As MySqlException
                        MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                    End Try
                    '           MessageBox.Show("Conexão aberta com sucesso")
                    conn3.Close()
                Catch myerro As MySqlException
                    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn3.Dispose()
                End Try
            End If

        End If

    End Sub

    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNome.TextChanged

    End Sub

End Class