Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.windows.forms

Public Class frmRpt

    Dim crReportDocument1 = New CBTurmas
    Dim crReportDocument21 = New Boletim
    Dim crReportDocument22 = New BoletimSN
    Dim crReportDocument3 = New Consolidado
    Dim crReportDocument33 = New AFConsolidado
    Dim crReportDocument4 = New RAlunos
    Dim crReportDocument5 = New RAlunos2
    Dim crReportDocument44 = New AlunosReprovadosCP
    Dim crReportDocument6 = New Graficos
    Dim crReportDocument66 = New Graficos2

    Dim crReportDocument7 = New ABEvasaoEscolar
    Dim crReportDocument77 = New TREvasaoEscolar
    Dim crReportDocument777 = New LSEvasaoEscolar
    Dim crReportDocument7777 = New LGEvasaoEscolar
    Dim crReportDocument77777 = New REEvasaoEscolar
    Dim crReportDocument777777 = New FAEvasaoEscolar

    Dim BD_OK, IP_OK, imagem_OK

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

    Dim myCommand21 As New MySqlCommand()
    Dim myAdapter21 As New MySqlDataAdapter()
    Dim myData21 As New DataTable()
    Dim r21 As DataRow
    Dim rc21 As Integer
    Dim SQL21 As String

    Dim myCommand22 As New MySqlCommand()
    Dim myAdapter22 As New MySqlDataAdapter()
    Dim myData22 As New DataTable()
    Dim r22 As DataRow
    Dim rc22 As Integer
    Dim SQL22 As String

    Dim myCommand23 As New MySqlCommand()
    Dim myAdapter23 As New MySqlDataAdapter()
    Dim myData23 As New DataTable()
    Dim r23 As DataRow
    Dim rc23 As Integer
    Dim SQL23 As String

    Dim myCommand24 As New MySqlCommand()
    Dim myAdapter24 As New MySqlDataAdapter()
    Dim myData24 As New DataTable()
    Dim r24 As DataRow
    Dim rc24 As Integer
    Dim SQL24 As String

    Private Sub frmRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myData.Clear()
        myData2.Clear()
        myData21.Clear()
        myData22.Clear()

        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")

            BD_OK = BD
            IP_OK = IP

        Catch ex As Exception
        End Try

        myData2.Clear()
        myData.Clear()

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        Try
            conn.Open()
            Try

                'Codigo de Barras - Notas e Frequencia
                If (lbParametro.Text = "NF") Then
                    Me.Text = "Relatório - Notas e Freqüências"
                    SQL2 = "SELECT n.qtdadeaulas, n.previsaoaulas, n.cod_bimestre, d.disciplina, t.classe, c.nro_aluno, c.descricao, n.anovigente FROM " & BD_OK & ".codigobarras c, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE c.cod_nf=n.cod_nf AND n.turma=t.codigo_trma AND n.disciplina=d.codigo_disc;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    'Alunos
                ElseIf (lbParametro.Text = "Alunos") Then
                    Me.Text = "Relatório - Ata do Conselho"
                    SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma ORDER BY nro;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    'Alunos - Assinaturas
                ElseIf (lbParametro.Text = "AlunosAssinatura") Then
                    Me.Text = "Relatório - Ata do Conselho"
                    SQL2 = "SELECT p.anovigente, p.nome, t.classe, p.nro FROM " & BD_OK & ".aluno p, " & BD_OK & ".turma t WHERE p.turma=t.codigo_trma ORDER BY nro;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    'Codigo de Barras - Avaliacao Final
                ElseIf (lbParametro.Text = "SF") Then
                    Me.Text = "Relatório - Avaliação Final"
                    SQL2 = "SELECT n.qtdadeaulas, n.cod_bimestre, d.disciplina, t.classe, c.nro_aluno, c.descricao, n.anovigente FROM " & BD_OK & ".avaliacaofinal c, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE c.cod_nf=n.cod_nf AND n.turma=t.codigo_trma AND n.disciplina=d.codigo_disc;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    'Boletins
                ElseIf (lbParametro.Text = "Boletim") Then
                    Me.Text = "Relatório - Boletins"
                    SQL21 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, a.nome, a.ra, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d, " & BD_OK & ".aluno a WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma ORDER BY nro;"
                    myCommand21.Connection = conn
                    myCommand21.CommandText = SQL21
                    myAdapter21.SelectCommand = myCommand21
                    myAdapter21.Fill(myData21)

                    'BoletinSN
                ElseIf (lbParametro.Text = "BoletimSN") Then
                    Me.Text = "Relatório - Boletins"
                    SQL22 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma;"
                    myCommand22.Connection = conn
                    myCommand22.CommandText = SQL22
                    myAdapter22.SelectCommand = myCommand22
                    myAdapter22.Fill(myData22)

                    'Consolidado
                ElseIf (lbParametro.Text = "Consolidado") Then
                    Me.Text = "Relatório - Consolidado"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    'Gráficos
                ElseIf (lbParametro.Text = "Graficos") Then
                    Me.Text = "Relatório - Gráficos"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    'Gráficos Em Geral
                ElseIf (lbParametro.Text = "TGraficos") Then
                    Me.Text = "Relatório - Gráfico: Escola em Geral"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                ElseIf (lbParametro.Text = "AFConsolidado") Then
                    Me.Text = "Relatório - Avaliação Final"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.S, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".avaliacaofinal b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_nf AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.cod_bimestre=4;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    'Evasao Escolar
                ElseIf (lbParametro.Text = "ABEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=12;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                ElseIf (lbParametro.Text = "TREvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=11;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                ElseIf (lbParametro.Text = "LSEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=13;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                ElseIf (lbParametro.Text = "LGEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=14;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                ElseIf (lbParametro.Text = "REEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=15;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                ElseIf (lbParametro.Text = "FAEvasaoEscolar") Then
                    Me.Text = "Relatório - Gráfico: Evasão Escolar"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=16;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    'Alunos - Reprovados Completo
                ElseIf (lbParametro.Text = "AlunosReprovadosCP") Then
                    Me.Text = "Relatório - Alunos Reprovados"
                    SQL2 = "SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM " & BD_OK & ".turma t, " & BD_OK & ".notasfreq n, " & BD_OK & ".boletim b, " & BD_OK & ".disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<5;"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                End If
            Catch myerro As MySqlException
                'MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            'MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

        'Codigo de Barras - Notas e Frequencias
        If (lbParametro.Text = "NF") Then
            crReportDocument1.Load("CBTurmas.rpt")
            crReportDocument1.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument1

            'Aulas Compensadas
        ElseIf (lbParametro.Text = "AC") Then
            crReportDocument1.Load("CBTurmas.rpt")
            crReportDocument1.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument1

            'Codigo de Barras - Situacao Final
        ElseIf (lbParametro.Text = "SF") Then
            crReportDocument1.Load("CBTurmas.rpt")
            crReportDocument1.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument1

            'Boletim
        ElseIf (lbParametro.Text = "Boletim") Then
            crReportDocument21.Load("Boletim.rpt")
            crReportDocument21.SetDataSource(myData21)
            crViewer.ReportSource = crReportDocument21

            'BoletimSN
        ElseIf (lbParametro.Text = "BoletimSN") Then
            crReportDocument22.Load("BoletimSN.rpt")
            crReportDocument22.SetDataSource(myData22)
            crViewer.ReportSource = crReportDocument22

            'Alunos - Geral
        ElseIf (lbParametro.Text = "Alunos") Then
            crReportDocument4.Load("RAlunos.rpt")
            crReportDocument4.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument4

            'Alunos - Assinaturas
        ElseIf (lbParametro.Text = "AlunosAssinatura") Then
            crReportDocument5.Load("RAlunos2.rpt")
            crReportDocument5.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument5

            'Alunos - Reprovados Completo
        ElseIf (lbParametro.Text = "AlunosReprovadosCP") Then
            crReportDocument44.Load("AlunosReprovadosCP.rpt")
            crReportDocument44.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument44

            'Consolidado
        ElseIf (lbParametro.Text = "Consolidado") Then
            crReportDocument3.Load("Consolidado.rpt")
            crReportDocument3.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument3

            'Graficos
        ElseIf (lbParametro.Text = "Graficos") Then
            crReportDocument6.Load("Graficos.rpt")
            crReportDocument6.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument6

        ElseIf (lbParametro.Text = "TGraficos") Then
            crReportDocument66.Load("Graficos2.rpt")
            crReportDocument66.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument66

        ElseIf (lbParametro.Text = "AFConsolidado") Then
            crReportDocument33.Load("AFConsolidado.rpt")
            crReportDocument33.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument33

        ElseIf (lbParametro.Text = "ABEvasaoEscolar") Then
            crReportDocument7.Load("ABEvasaoEscolar.rpt")
            crReportDocument7.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument7

        ElseIf (lbParametro.Text = "TREvasaoEscolar") Then
            crReportDocument77.Load("TREvasaoEscolar.rpt")
            crReportDocument77.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument77

        ElseIf (lbParametro.Text = "LSEvasaoEscolar") Then
            crReportDocument777.Load("LSEvasaoEscolar.rpt")
            crReportDocument777.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument777

        ElseIf (lbParametro.Text = "LGEvasaoEscolar") Then
            crReportDocument7777.Load("LGEvasaoEscolar.rpt")
            crReportDocument7777.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument7777

        ElseIf (lbParametro.Text = "REEvasaoEscolar") Then
            crReportDocument77777.Load("REEvasaoEscolar.rpt")
            crReportDocument77777.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument77777

        ElseIf (lbParametro.Text = "FAEvasaoEscolar") Then
            crReportDocument777777.Load("FAEvasaoEscolar.rpt")
            crReportDocument777777.SetDataSource(myData2)
            crViewer.ReportSource = crReportDocument777777


        End If

    End Sub

    Private Sub lbParametro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbParametro.Click

    End Sub
End Class