Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.ReportSource

Public Class frmRpt

    Dim crReportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend grupoCompara
    Friend grupoBimestre

    Private Sub lbParametro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbParametro.TextChanged

        crViewer.ReportSource = Nothing

        Dim BimestreAtual = ""
        myData.Clear()
        myData2.Clear()

        'PUXA O BIMESTRE ATUAL................
        Dim atualBimestre = Format(Date.Now, "MM")

        If atualBimestre <= "05" Then
            BimestreAtual = "1"

        ElseIf atualBimestre <= "07" Then
            BimestreAtual = "2"

        ElseIf atualBimestre <= "10" Then
            BimestreAtual = "3"

        ElseIf atualBimestre <= "12" Then
            BimestreAtual = "4"

        End If

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;Allow User Variables=True;database=" & BD_OK

        Try
            conn.Open()
            Try

                If (lbParametro.Text = "DE") Then
                    Me.Text = "Relatório - Declaração Escolar"
                    SQL2 = "SELECT nome AS nomeescola, de FROM escola;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "Alunos") Then
                    Me.Text = "Relatório - Ata do Conselho"
                    SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro, p.status AS situacao FROM aluno p, turma t WHERE p.turma=t.codigo_trma ORDER BY nro;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'Alunos - Assinaturas
                ElseIf (lbParametro.Text = "AlunosAssinatura") Then
                    Me.Text = "Relatório - Ata do Conselho"
                    SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma ORDER BY nro;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'Boletins
                ElseIf (lbParametro.Text = "Boletim") Then
                    Me.Text = "Relatório - Boletins"
                    SQL2 = "SELECT e.de, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, a.nome, a.ra, b.M AS Avaliacao, b.F AS Faltas, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d, " & BD_OK & ".aluno a, " & BD_OK & ".escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma ORDER BY nro;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'BoletinSN
                ElseIf (lbParametro.Text = "BoletimSN") Then
                    Me.Text = "Relatório - Boletins"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'CONSOLIDADO
                ElseIf (lbParametro.Text = "Consolidado") Then
                    Me.Text = "Relatório - Consolidado"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.cod_bimestre='" & BimestreAtual & "' AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'CONSOLIDADO COMPLETO
                ElseIf (lbParametro.Text = "ConsolidadoCompleto") Then
                    Me.Text = "Relatório - Consolidado Completo"
                    SQL2 = "SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, boletim.nro_aluno, boletim.M, boletim.F, boletim.AC, boletim.porcentagem, notasfreq.previsaoaulas, notasfreq.qtdadeaulas, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola WHERE notasfreq.cod_bimestre='" & BimestreAtual & "' AND notasfreq.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'GRAFICOS
                ElseIf (lbParametro.Text = "Graficos") Then
                    Me.Text = "Relatório - Gráfico: Turmas"
                    SQL2 = "SELECT e.de, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.cod_bimestre>='1' AND n.cod_bimestre<='4' AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'Gráficos Em Geral
                ElseIf (lbParametro.Text = "TGraficos") Then
                    Me.Text = "Relatório - Gráfico: Escola em Geral"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "AFConsolidado") Then
                    Me.Text = "Relatório - Avaliação Final"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.S, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE (n.cod_bimestre='2AF' OR n.cod_bimestre='4AF') AND n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'Evasao Escolar
                ElseIf (lbParametro.Text = "ABEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=12 AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "TREvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=11 AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "LSEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=13 AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "LGEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=14 AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "REEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=15 AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "FAEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=16 AND n.anovigente='" & AnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'BOLSA FAMILIA
                ElseIf (lbParametro.Text = "BolsaVariavelJovem") Then
                    Me.Text = "Relatório - Benefício Variável Jovem!"
                    SQL2 = "SELECT" _
                             & " DISTINCT(BOLSAS.idbolsas)," _
                             & " bolsas.porcentagem," _
                             & " bolsas.bimestre AS cod_bimestre," _
                             & " aluno.nome AS nome," _
                             & " turma.classe," _
                             & " bolsas.ano AS anovigente" _
                             & " FROM" _
                             & " bolsas" _
                             & " INNER JOIN aluno ON (bolsas.codigo_trma = aluno.turma)" _
                             & " AND (bolsas.nro = aluno.nro)" _
                             & " INNER JOIN turma ON (bolsas.codigo_trma = turma.codigo_trma)" _
                             & " WHERE bolsas.tipo='BVJ';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "BolsaFamilia") Then
                    Me.Text = "Relatório - Bolsa Família!"

                    SQL2 = "SELECT" _
                            & " DISTINCT(BOLSAS.idbolsas)," _
                            & " bolsas.porcentagem," _
                            & " bolsas.bimestre AS cod_bimestre," _
                            & " aluno.nome AS nome," _
                            & " turma.classe," _
                            & " bolsas.ano AS anovigente" _
                            & " FROM" _
                            & " bolsas" _
                            & " INNER JOIN aluno ON (bolsas.codigo_trma = aluno.turma)" _
                            & " AND (bolsas.nro = aluno.nro)" _
                            & " INNER JOIN turma ON (bolsas.codigo_trma = turma.codigo_trma)" _
                            & " WHERE bolsas.tipo='BF';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'Gráfico: Turmas por Período
                ElseIf (lbParametro.Text = "GrupoPeriodo") Then
                    Me.Text = "Relatório - Gráfico: Média do Período"
                    SQL2 = "SELECT e.de, t.periodo, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.cod_bimestre='" & grupoBimestre & "' AND t.periodo='" & grupoPeriodo & "' AND n.anovigente='" & grupoAnoVigente & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    'Gráfico: Grupo de Turmas
                ElseIf (lbParametro.Text = "GrupoTurmas") Then
                    Me.Text = "Relatório - Gráfico: Média do Grupo"
                    SQL2 = "SELECT e.de, t.periodo, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.cod_bimestre='" & grupoBimestre & "' AND n.anovigente='" & grupoAnoVigente & "' AND t.classe IN ('" & grupoTurmas & "');"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                ElseIf (lbParametro.Text = "ConsolidadoProfessor") Then
                    Me.Text = "Relatório - Mais Escola Professor!"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas, n.previsaoaulas FROM turma t, notasfreq n, boletim b, disciplinas d, notasfreq_prof nfp WHERE n.cod_nf=b.cod_boletim AND n.cod_nf=nfp.cod_nf AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND nfp.grupo='9999';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                End If

            Catch myerro As Exception
                MsgBox("Não foi encontrado relatório para esta consulta!" & vbCrLf & "Ano Vigente: " & AnoVigente & " Bimestre: " & BimestreAtual, MsgBoxStyle.Information)
                conn.Close()
                conn.Dispose()
                Exit Sub
                
            End Try
            conn.Close()
        Catch myerro As MySqlException
        Finally
            conn.Dispose()
        End Try

        crViewer.ShowRefreshButton = False
        crViewer.ShowCloseButton = False
        crViewer.ShowGroupTreeButton = False

        crViewer.ReportSource = crReportDocument


        If (lbParametro.Text = "DE") Then
            crReportDocument.Load(meucaminho & "\reports\DE.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument
            'crReportDocument.close()

        ElseIf (lbParametro.Text = "Boletim") Then
            crReportDocument.Load(meucaminho & "\reports\Boletim.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument
            'crReportDocument.close()

        ElseIf (lbParametro.Text = "BoletimSN") Then
            crReportDocument.Load(meucaminho & "\BoletimSN.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

            'Alunos - Geral
        ElseIf (lbParametro.Text = "Alunos") Then
            crReportDocument.Load(meucaminho & "\reports\RAlunos.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

            'Alunos - Assinaturas
        ElseIf (lbParametro.Text = "AlunosAssinatura") Then
            crReportDocument.Load(meucaminho & "\reports\RAlunos2.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

            'BOLSA FAMILIA
        ElseIf (lbParametro.Text = "BolsaFamilia") Then
            crReportDocument.Load(meucaminho & "\reports\BolsaFamilia.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

            'BOLSA VARIAVEL JOVEM
        ElseIf (lbParametro.Text = "BolsaVariavelJovem") Then
            crReportDocument.Load(meucaminho & "\reports\BolsaVariavelJovem.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

            'Consolidado
        ElseIf (lbParametro.Text = "Consolidado") Then
            crReportDocument.Load(meucaminho & "\reports\Consolidado.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "ConsolidadoCompleto") Then
            If BimestreAtual = "2AF" Or BimestreAtual = "4AF" Then
                crReportDocument.Load(meucaminho & "\reports\ConsolidadoAF.rpt")
                crReportDocument.SetDataSource(myData2)
                crViewer.ReportSource = crReportDocument
            Else
                crReportDocument.Load(meucaminho & "\reports\ConsolidadoCompleto.rpt")
                crReportDocument.SetDataSource(myData2)
                crViewer.ReportSource = crReportDocument
            End If

            'Graficos
        ElseIf (lbParametro.Text = "Graficos") Then
            crReportDocument.Load(meucaminho & "\reports\Graficos.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "TGraficos") Then
            crReportDocument.Load(meucaminho & "\reports\Graficos2.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "AFConsolidado") Then
            crReportDocument.Load(meucaminho & "\reports\AFConsolidado.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "ABEvasaoEscolar") Then
            crReportDocument.Load(meucaminho & "\reports\ABEvasaoEscolar.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "TREvasaoEscolar") Then
            crReportDocument.Load(meucaminho & "\reports\TREvasaoEscolar.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "LSEvasaoEscolar") Then
            crReportDocument.Load(meucaminho & "\reports\LSEvasaoEscolar.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "LGEvasaoEscolar") Then
            crReportDocument.Load(meucaminho & "\reports\LGEvasaoEscolar.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "REEvasaoEscolar") Then
            crReportDocument.Load(meucaminho & "\reports\REEvasaoEscolar.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "FAEvasaoEscolar") Then
            crReportDocument.Load(meucaminho & "\reports\FAEvasaoEscolar.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "GrupoTurmas") And grupoCompara = 0 Then
            crReportDocument.Load(meucaminho & "\reports\Graficos.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "GrupoPeriodo") And grupoCompara = 0 Then
            crReportDocument.Load(meucaminho & "\reports\Graficos.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "GrupoTurmas") And grupoCompara = 1 Then
            crReportDocument.Load(meucaminho & "\reports\GraficosGTurmas.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "GrupoPeriodo") And grupoCompara = 1 Then
            crReportDocument.Load(meucaminho & "\reports\GraficosGPeriodo.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        ElseIf (lbParametro.Text = "ConsolidadoProfessor") Then
            crReportDocument.Load(meucaminho & "\reports\ConsolidadoProfessor.rpt")
            crReportDocument.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument

        End If

        'crReportDocument.Close()
        'crReportDocument.Dispose()

    End Sub

    Private Sub frmRpt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class