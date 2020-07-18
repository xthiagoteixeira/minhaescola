Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmGerencialRPT

    Dim crReportDocument1 = New CBTurmas
    Dim crReportDocument21 = New Boletim
    Dim crReportDocument22 = New BoletimSN
    Dim crReportDocument3 = New Consolidado
    Dim crReportDocument33 = New AFConsolidado
    Dim crReportDocument4 = New RAlunos
    Dim crReportDocument5 = New RAlunos2
    Dim crReportDocument6 = New Graficos
    Dim crReportDocument66 = New Graficos2

    Dim crReportDocument10 = New ABEvasaoEscolar
    Dim crReportDocument11 = New TREvasaoEscolar
    Dim crReportDocument12 = New LGEvasaoEscolar
    Dim crReportDocument13 = New LSEvasaoEscolar
    Dim crReportDocument14 = New REEvasaoEscolar
    Dim crReportDocument15 = New FAEvasaoEscolar

    Dim BD_OK, IP_OK, imagem_OK
    Dim nrodisciplina
    Dim nroturma

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim r As DataRow
    Dim rc As Integer
    Dim SQL As String

    Dim myCommand2 As New MySqlCommand()
    Dim myAdapter2 As New MySqlDataAdapter()
    Dim myData2 As New DataTable()
    Dim r2 As DataRow
    Dim rc2 As Integer
    Dim SQL2 As String

    Dim myCommand3 As New MySqlCommand()
    Dim myAdapter3 As New MySqlDataAdapter()
    Dim myData3 As New DataTable()
    Dim r3 As DataRow
    Dim rc3 As Integer
    Dim SQL3 As String

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()
    Dim r4 As DataRow
    Dim rc4 As Integer
    Dim SQL4 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()
    Dim r5 As DataRow
    Dim rc5 As Integer
    Dim SQL5 As String

    Private Sub cbRelatorio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRelatorio.SelectedIndexChanged

        myData.Clear()
        myData2.Clear()
        myData3.Clear()
        myData4.Clear()
        myData5.Clear()

        tAno.Enabled = False

        If cbRelatorio.Text = "Código de Barras" Then
            cbFiltro.Enabled = True
            cbFiltro.Items.Clear()
            cbFiltro.ResetText()
            cbFiltro.Items.Add("Notas e Freqüências")
            cbFiltro.Items.Add("Avaliação Final")
            btVisualizar.Enabled = False

        ElseIf cbRelatorio.Text = "Ata do Conselho" Then
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
            cbFiltro.Items.Add("Somente Notas")
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
            cbFiltro.Items.Add("Avaliação Final")
            cbFiltro.Items.Add("Geral")
            btVisualizar.Enabled = False
        End If

    End Sub

    Private Sub frmGerencialRPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")
            Dim Imagem As Object = myRegKey2.GetValue("x")


            BD_OK = BD
            IP_OK = IP
            imagem_OK = Imagem


        Catch ex As Exception
        End Try

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        Try
            conn.Open()
            Try
                SQL = "SELECT * FROM " & BD_OK & ".disciplinas ORDER BY disciplina"
                SQL2 = "SELECT * FROM " & BD_OK & ".turma ORDER BY classe"

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

    Private Sub btConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click

        Dim trava = 0
        myData2.Clear()

        'SE ESCOLHER COM FILTRO
        If checkFiltro.Checked = True Then

            If (cbTurma.Text = "") Then
                MsgBox("Verifique os campos!", MsgBoxStyle.Exclamation, "Atenção!")
                Exit Sub

            ElseIf ((cbTurma.Text <> "") Or (cbDisciplina.Text <> "")) And CheckDisciplinas.Checked = False Then

                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                Try
                    conn.Open()
                    Try

                        '================= Código de Barras ================='
                        If cbRelatorio.Text = "Código de Barras" And cbFiltro.Text = "Notas e Freqüências" Then
                            SQL2 = "SELECT n.qtdadeaulas, n.previsaoaulas, n.cod_bimestre, d.disciplina, t.classe, c.nro_aluno, c.descricao, n.anovigente FROM " & BD_OK & ".codigobarras c, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE c.cod_nf=n.cod_nf AND n.turma=t.codigo_trma AND n.disciplina=d.codigo_disc AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument1.Load("CBTurmas.rpt")
                            crReportDocument1.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument1

                        End If

                        If cbRelatorio.Text = "Código de Barras" And cbFiltro.Text = "Avaliação Final" Then
                            SQL2 = "SELECT n.qtdadeaulas, n.cod_bimestre, d.disciplina, t.classe, c.nro_aluno, c.descricao, n.anovigente FROM " & BD_OK & ".avaliacaofinal c, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE c.cod_nf=n.cod_nf AND n.turma=t.codigo_trma AND n.disciplina=d.codigo_disc AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument1.Load("CBTurmas.rpt")
                            crReportDocument1.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument1

                        End If

                        '================= Ata do Conselho ================='
                        If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Completo" Then
                            SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma AND p.turma=" & nroturma & " AND p.anovigente=" & tAno.Value & " ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument4.Load("RAlunos.rpt")
                            crReportDocument4.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument4

                        End If

                        If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Reunião de Pais e Mestres" Then
                            SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma AND p.turma=" & nroturma & " AND p.anovigente=" & tAno.Value & " ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument5.Load("RAlunos2.rpt")
                            crReportDocument5.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument5

                        End If

                        '================= Boletim ================='
                        If cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Completo" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, a.nome, a.ra, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d, " & BD_OK & ".aluno a WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & " ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument21.Load("Boletim.rpt")
                            crReportDocument21.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument21

                        End If

                        If cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Somente Notas" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument22.Load("BoletimSN.rpt")
                            crReportDocument22.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument22

                        End If

                        '================= Gráficos ================='
                        If cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Turmas" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument6.Load("Graficos.rpt")
                            crReportDocument6.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument6

                        End If

                        '================= Consolidado ================='
                        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Geral" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma  AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument3.Load("Consolidado.rpt")
                            crReportDocument3.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument3

                        End If

                        '================= Consolidado ================='
                        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Alunos Reprovados" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma  AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & " AND b.M<5;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument3.Load("Consolidado.rpt")
                            crReportDocument3.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument3

                        End If

                        '================= Consolidado : Avaliação Final ================='
                        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Avaliação Final" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.S, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".avaliacaofinal b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_nf AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma  AND n.disciplina=" & nrodisciplina & " AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument33.Load("AFConsolidado.rpt")
                            crReportDocument33.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument33

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - AB") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=12  AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument10.Load("ABEvasaoEscolar.rpt")
                            crReportDocument10.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument10

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - TR") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=11 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument11.Load("TREvasaoEscolar.rpt")
                            crReportDocument11.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument11

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - LG") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=13 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument12.Load("LGEvasaoEscolar.rpt")
                            crReportDocument12.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument12

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - LS") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=14 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument13.Load("LSEvasaoEscolar.rpt")
                            crReportDocument13.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument13
                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - RE") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=15 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument14.Load("REEvasaoEscolar.rpt")
                            crReportDocument14.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument14

                        End If

                        If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - FA") Then
                            Me.Text = "Relatório - Gráfico: Evasão Escolar"
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=16 AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument15.Load("FAEvasaoEscolar.rpt")
                            crReportDocument15.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument15

                        End If


                        Try
                            r2 = myData2.Rows(0)
                        Catch r2 As IndexOutOfRangeException
                            trava = 1
                        End Try

                    Catch myerro As MySqlException
                        MessageBox.Show("Erro de leitura com o Banco de dados : " & myerro.Message)

                    End Try
                    conn.Close()
                Catch myerro As MySqlException
                    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn.Dispose()
                End Try

                If trava = 1 Then
                    MsgBox("Desculpe, não houve cadastro para a solicitação deste relatório!", MsgBoxStyle.Exclamation, "Atenção!")
                    Exit Sub
                Else
                    frmRpt.Show()
                End If

            ElseIf (cbDisciplina.Text = "Todas" And CheckDisciplinas.Checked = True) Then

                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                Try
                    conn.Open()
                    Try

                        '================= Código de Barras ================='
                        If cbRelatorio.Text = "Código de Barras" And cbFiltro.Text = "Notas e Freqüências" Then
                            SQL2 = "SELECT n.qtdadeaulas, n.previsaoaulas, n.cod_bimestre, d.disciplina, t.classe, c.nro_aluno, c.descricao, n.anovigente FROM " & BD_OK & ".codigobarras c, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE c.cod_nf=n.cod_nf AND n.turma=t.codigo_trma AND n.disciplina=d.codigo_disc AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument1.Load("CBTurmas.rpt")
                            crReportDocument1.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument1

                        End If

                        If cbRelatorio.Text = "Código de Barras" And cbFiltro.Text = "Avaliação Final" Then
                            SQL2 = "SELECT n.qtdadeaulas, n.cod_bimestre, d.disciplina, t.classe, c.nro_aluno, c.descricao, n.anovigente FROM " & BD_OK & ".avaliacaofinal c, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE c.cod_nf=n.cod_nf AND n.turma=t.codigo_trma AND n.disciplina=d.codigo_disc AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument1.Load("CBTurmas.rpt")
                            crReportDocument1.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument1

                        End If

                        '================= Ata do Conselho ================='
                        If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Completo" Then
                            SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & " ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument4.Load("RAlunos.rpt")
                            crReportDocument4.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument4

                        End If

                        If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Reunião de Pais e Mestres" Then
                            SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & " ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument5.Load("RAlunos2.rpt")
                            crReportDocument5.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument5

                        End If

                        '================= Boletim ================='
                        If cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Completo" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, a.nome, a.ra, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d, " & BD_OK & ".aluno a WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & " ORDER BY nro;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument21.Load("Boletim.rpt")
                            crReportDocument21.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument21

                        End If

                        If cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Somente Notas" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument22.Load("BoletimSN.rpt")
                            crReportDocument22.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument22

                        End If

                        '================= Gráficos ================='
                        If cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Turmas" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument6.Load("Graficos.rpt")
                            crReportDocument6.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument6

                        End If

                        '================= Consolidado ================='
                        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Geral" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument3.Load("Consolidado.rpt")
                            crReportDocument3.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument3

                        End If

                        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Alunos Reprovados" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & " AND b.M<5;"
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument3.Load("Consolidado.rpt")
                            crReportDocument3.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument3

                        End If


                        '================= Consolidado ================='
                        If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Avaliação Final" Then
                            SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.S, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".avaliacaofinal b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_nf AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.turma=" & nroturma & " AND n.anovigente=" & tAno.Value & " AND n.cod_bimestre=" & tBimestre.Value & ""
                            myCommand2.Connection = conn
                            myCommand2.CommandText = SQL2
                            myAdapter2.SelectCommand = myCommand2
                            myAdapter2.Fill(myData2)

                            crReportDocument33.Load("AFConsolidado.rpt")
                            crReportDocument33.SetDataSource(myData2)
                            frmRpt.crViewer.ReportSource = crReportDocument33

                        End If

                        Try
                            r2 = myData2.Rows(0)
                        Catch r2 As IndexOutOfRangeException
                            trava = 1
                        End Try

                    Catch myerro As MySqlException
                        MessageBox.Show("Erro de leitura com o Banco de dados : " & myerro.Message)

                    End Try
                    conn.Close()
                Catch myerro As MySqlException
                    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn.Dispose()
                End Try

                If trava = 1 Then
                    MsgBox("Desculpe, não houve cadastro para a solicitação deste relatório!", MsgBoxStyle.Exclamation, "Atenção!")
                    Exit Sub
                Else
                    frmRpt.Show()
                End If
            End If

            '''''''''''''''SE ESCOLHER SEM FILTRO
        Else

            '''''''''''''CARREGA INICIALMENTE''''''''''''
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

            Try
                conn.Open()
                Try

                    '================= Código de Barras ================='
                    If cbRelatorio.Text = "Código de Barras" And cbFiltro.Text = "Notas e Freqüências" Then
                        SQL2 = "SELECT n.qtdadeaulas, n.previsaoaulas, n.cod_bimestre, d.disciplina, t.classe, c.nro_aluno, c.descricao, n.anovigente FROM " & BD_OK & ".codigobarras c, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE c.cod_nf=n.cod_nf AND n.turma=t.codigo_trma AND n.disciplina=d.codigo_disc;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument1.Load("CBTurmas.rpt")
                        crReportDocument1.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument1


                    End If

                    If cbRelatorio.Text = "Código de Barras" And cbFiltro.Text = "Avaliação Final" Then
                        SQL2 = "SELECT n.qtdadeaulas, n.cod_bimestre, d.disciplina, t.classe, c.nro_aluno, c.descricao, n.anovigente FROM " & BD_OK & ".avaliacaofinal c, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE c.cod_nf=n.cod_nf AND n.turma=t.codigo_trma AND n.disciplina=d.codigo_disc;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument1.Load("CBTurmas.rpt")
                        crReportDocument1.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument1


                    End If

                    '================= Ata do Conselho ================='
                    If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Completo" Then
                        SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma ORDER BY nro;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument4.Load("RAlunos.rpt")
                        crReportDocument4.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument4


                    End If

                    If cbRelatorio.Text = "Ata do Conselho" And cbFiltro.Text = "Reunião de Pais e Mestres" Then
                        SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma ORDER BY nro;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument5.Load("RAlunos2.rpt")
                        crReportDocument5.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument5


                    End If

                    '================= Boletim ================='
                    If cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Completo" Then
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, a.nome, a.ra, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d, " & BD_OK & ".aluno a WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma ORDER BY nro;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument21.Load("Boletim.rpt")
                        crReportDocument21.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument21


                    End If

                    If cbRelatorio.Text = "Boletim" And cbFiltro.Text = "Somente Notas" Then
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument22.Load("BoletimSN.rpt")
                        crReportDocument22.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument22


                    End If

                    '================= Gráficos ================='
                    If cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Turmas" Then
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_nf AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument6.Load("Graficos.rpt")
                        crReportDocument6.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument6

                    End If

                    If cbRelatorio.Text = "Gráficos" And cbFiltro.Text = "Escola em Geral" Then
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente=" & tAno.Value & ""
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument66.Load("Graficos2.rpt")
                        crReportDocument66.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument66

                    End If

                    '================= Consolidado ================='
                    If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Geral" Then
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument3.Load("Consolidado.rpt")
                        crReportDocument3.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument3

                    End If

                    '================= Consolidado ================='
                    If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Alunos Reprovados" Then
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<5;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument3.Load("Consolidado.rpt")
                        crReportDocument3.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument3

                    End If

                    '================= Consolidado ================='
                    If cbRelatorio.Text = "Consolidado" And cbFiltro.Text = "Avaliação Final" Then
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.S, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".avaliacaofinal b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_nf AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument33.Load("AFConsolidado.rpt")
                        crReportDocument33.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument33

                    End If


                    If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - AB") Then
                        Me.Text = "Relatório - Gráfico: Evasão Escolar"
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=12;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument10.Load("ABEvasaoEscolar.rpt")
                        crReportDocument10.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument10

                    End If

                    If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - TR") Then
                        Me.Text = "Relatório - Gráfico: Evasão Escolar"
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=11;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument11.Load("TREvasaoEscolar.rpt")
                        crReportDocument11.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument11

                    End If

                    If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - LG") Then
                        Me.Text = "Relatório - Gráfico: Evasão Escolar"
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=13;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument12.Load("LGEvasaoEscolar.rpt")
                        crReportDocument12.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument12

                    End If

                    If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - LS") Then
                        Me.Text = "Relatório - Gráfico: Evasão Escolar"
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=14;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument13.Load("LSEvasaoEscolar.rpt")
                        crReportDocument13.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument13
                    End If

                    If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - RE") Then
                        Me.Text = "Relatório - Gráfico: Evasão Escolar"
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=15;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument14.Load("REEvasaoEscolar.rpt")
                        crReportDocument14.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument14

                    End If

                    If cbRelatorio.Text = "Gráficos" And (cbFiltro.Text = "Evasão Escolar - FA") Then
                        Me.Text = "Relatório - Gráfico: Evasão Escolar"
                        SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=16;"
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        crReportDocument15.Load("FAEvasaoEscolar.rpt")
                        crReportDocument15.SetDataSource(myData2)
                        frmRpt.crViewer.ReportSource = crReportDocument15
                    End If



                    Try
                        r2 = myData2.Rows(0)
                    Catch r2 As IndexOutOfRangeException
                        trava = 1
                    End Try

                Catch myerro As MySqlException
                    MessageBox.Show("Erro de leitura com o Banco de dados : " & myerro.Message)
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try

            If trava = 1 Then
                MsgBox("Desculpe, não houve cadastro para a solicitação deste relatório!", MsgBoxStyle.Exclamation, "Atenção!")
                Exit Sub

            Else
                frmRpt.Show()

            End If


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFiltro.CheckedChanged
        If checkFiltro.Checked = True Then

            If cbDisciplina.Text = "Todas" Then
                cbDisciplina.Enabled = False
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
            CheckDisciplinas.Enabled = True
            CheckDisciplinas.Checked = False



        Else
            cbDisciplina.Enabled = False
            cbTurma.Enabled = False
            tAno.Enabled = False
            tBimestre.Enabled = False
            CheckDisciplinas.Enabled = False
            CheckDisciplinas.Checked = False
            cbDisciplina.Enabled = False
        End If

    End Sub

    Private Sub cbDisciplina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDisciplina.SelectedIndexChanged

        myData5.Clear()

        '''' ESTADO CAPTURA NUMERO ''''
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

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

    Private Sub cbFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltro.SelectedIndexChanged
        tAno.Enabled = False

        If cbFiltro.Text <> "" Then
            btVisualizar.Enabled = True
            checkFiltro.Enabled = True
        End If

        If cbFiltro.Text = "Escola em Geral" Then
            checkFiltro.Enabled = False
            tAno.Enabled = True
        End If

    End Sub

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

        myData3.Clear()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn3 As MySqlConnection

        conn3 = New MySqlConnection()
        conn3.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

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

    Private Sub CheckDisciplinas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDisciplinas.CheckedChanged
        If CheckDisciplinas.Checked = True Then
            cbDisciplina.Enabled = False
            cbDisciplina.Text = "Todas"
        Else
            cbDisciplina.Enabled = True
            cbDisciplina.Text = ""
        End If
    End Sub
End Class