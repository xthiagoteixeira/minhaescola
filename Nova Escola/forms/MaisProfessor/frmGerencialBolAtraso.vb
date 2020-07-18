Imports DevExpress.XtraPrinting
Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class frmGerencialBolAtraso
    Dim barra_maximo

    ReadOnly TodasDisciplinas(70)
    Dim contadorDisciplina = 0
    ReadOnly TodasDisciplinasNomes(70)
    Dim contadorDisciplinaNomes = 0
    Dim ContaNroBoletins = 0
    Friend contadorTurma = 0
    Dim bimestre

    'Public Delegate Sub IncrementProgressDelegate()
    'Public Delegate Sub Delegação(ByVal texto As String)

    'Public Sub IncrementProgress()
    '    If Me.InvokeRequired Then
    '        Dim del As New IncrementProgressDelegate(AddressOf IncrementProgress)
    '        Me.Invoke(del)
    '    Else
    '        Me.barra.PerformStep()
    '    End If
    'End Sub

    'Public Sub DefinirTexto(ByVal texto As String)
    '    On Error Resume Next
    '    If barra.InvokeRequired Then
    '        Dim d As New Delegação(AddressOf DefinirTexto)
    '        barra.Text = barra.Invoke(d, texto)
    '        barra.Properties.Maximum = barra_maximo
    '        'barra.Text = barra_valor

    '    Else
    '        barra.Text = texto
    '        barra.Properties.Maximum = barra_maximo
    '        'barra.Text = barra_valor
    '    End If
    'End Sub

    Public Sub AlinharDataGrid()

        'Alinhar...
        viewBoletim.Columns(0).Width = 100
        viewBoletim.Columns(1).Width = 180
    End Sub

    Private Sub frmCondisciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        contadorDisciplina = 0

        'PUXA O BIMESTRE ATUAL................
        nroBimestre.Value = consultaBimestre()
        'DEIXAR COMO PADRAO O ANO
        tAno.Value = AnoVigente

        Try
            SQL = "SELECT * FROM disciplinas WHERE disciplina<>'-' AND bloqueado='0' ORDER BY disciplina ASC;"
            Dim Disciplinas = MySQL_datatable(SQL)
            For Each r In Disciplinas.Rows
                TodasDisciplinas(contadorDisciplina) = (r("codigo_disc"))
                TodasDisciplinasNomes(contadorDisciplinaNomes) = (r("disciplina"))
                contadorDisciplinaNomes = contadorDisciplinaNomes + 1
                contadorDisciplina = contadorDisciplina + 1
            Next

            Const SQL2 = "SELECT * FROM turma WHERE bloqueado='0' ORDER BY classe;"
            Dim Turmas = MySQL_datatable(SQL2)

            cbTurma.Properties.Items.Clear()
            For Each r2 In Turmas.Rows
                cbTurma.Properties.Items.Add(r2("classe"))
                contadorTurma = contadorTurma + 1
            Next

        Catch myerro As MySqlException
            MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
        End Try

        barra.Properties.Maximum = contadorTurma
    End Sub

    Private Sub bwProcesso_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwProcesso.DoWork

        If cbTodas.Checked = False Then

            ' *** SOMENTE UMA TURMA...
            barra_maximo = contadorDisciplina

            For w = 0 To contadorDisciplina

                'Dim texto = String.Format("Analisando: {0} / {1} disciplinas.", barra_valor, barra_maximo)
                'DefinirTexto(texto)
                SQL =
                    String.Format(
                        "SELECT cod_nf, anovigente, cod_bimestre, disciplina, turma FROM notasfreq nf WHERE anovigente='{0}' AND cod_bimestre='{1}' AND disciplina='{2}' AND turma='{3}'",
                        tAno.Value, bimestre, TodasDisciplinas(w), nroTurmaAluno)
                Dim Resultado = MySQL_consulta_campo(SQL, "cod_nf")

                If Resultado = "0" Then
                    'insere turma/disciplina...
                    SQL =
                        String.Format(
                            "INSERT INTO rpt_bolatraso (turma, disciplina, cod_bimestre, anovigente) values ('{0}', '{1}', '{2}', '{3}');",
                            nroTurmaAluno, TodasDisciplinas(w), bimestre, tAno.Value)
                    MySQL_atualiza(SQL)
                End If
                bwProcesso.ReportProgress(w)

            Next

        Else
            ' *** TODAS AS TURMAS...
            Dim x = 0
            Dim t = 1
            'Dim EmAtraso = 0
            barra_maximo = contadorTurma

            Const SQL2 = "SELECT * FROM turma WHERE bloqueado='0' ORDER BY classe;"
            Dim Turmas = MySQL_datatable(SQL2)

            For Each r2 In Turmas.Rows

                nroTurmaAluno = r2("codigo_trma")
                'Dim nometurma = r2("classe")
                'EmAtraso = 0
                'Dim texto = String.Format("Turma: {0} - Analisando: {1} / {2}", nometurma, barra_valor, barra_maximo)
                'DefinirTexto(texto)
                bwProcesso.ReportProgress(t)

                For x = 0 To contadorDisciplina - 1

                    SQL =
                        String.Format(
                            "SELECT cod_nf, anovigente, cod_bimestre, disciplina, turma FROM notasfreq WHERE anovigente='{0}' AND cod_bimestre='{1}' AND disciplina='{2}' AND turma='{3}';",
                            tAno.Value, bimestre, TodasDisciplinas(x), nroTurmaAluno)
                    Dim Resultado = MySQL_consulta_campo(SQL, "cod_nf")

                    If Resultado = "0" Then
                        SQL =
                            String.Format(
                                "INSERT INTO rpt_bolatraso (turma, disciplina, cod_bimestre, anovigente) values ('{0}', '{1}', '{2}', '{3}');",
                                nroTurmaAluno, TodasDisciplinas(x), bimestre, tAno.Value)
                        MySQL_atualiza(SQL)
                    End If

                Next
                t = t + 1
            Next
        End If
    End Sub

    Private Sub bwProcesso_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwProcesso.ProgressChanged

        Invoke(Sub()
                   Me.barra.Properties.DisplayFormat.FormatString = "Analisando: [ " & e.ProgressPercentage & " / " &
                                                             barra_maximo & " ]"
                   Me.barra.EditValue = e.ProgressPercentage
                   Me.barra.Properties.Maximum = barra_maximo
                   Me.barra.Properties.Minimum = 0
               End Sub)

    End Sub

    Private Sub bwProcesso_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwProcesso.RunWorkerCompleted

        '... MOSTRA NA DATAGRID
        SQL = "SELECT " _
              & " turma.classe AS Turma, " _
              & " disciplinas.disciplina AS Disciplina " _
              & "FROM " _
              & " rpt_bolatraso " _
              & " INNER JOIN turma ON (rpt_bolatraso.turma = turma.codigo_trma) " _
              &
              " INNER JOIN disciplinas ON (rpt_bolatraso.disciplina = disciplinas.codigo_disc) ORDER BY turma.classe, disciplinas.disciplina ASC;"
        gridBoletim.DataSource = Nothing
        gridBoletim.DataSource = MySQL_consulta_datagrid(SQL)
        AlinharDataGrid()
        btImprimir.Enabled = True

        ''Dim vStrMsg As String = MsgBox("Deseja imprimir?", MsgBoxStyle.YesNo, "Informação!")
        ''If vStrMsg = MsgBoxResult.Yes Then
        ''    SQL_frmRPT = meuRPT("BoletinsAtraso")
        ''    Dim fRpt As New frmRpt
        ''    fRpt.Show()
        ''    Me.Close()
        ''End If
    End Sub

    Private Sub cbTodas_CheckedChanged(sender As Object, e As EventArgs) Handles cbTodas.CheckedChanged

        If cbTurma.Text = "Todas as Turmas" Then
            cbTurma.Text = String.Empty
            cbTurma.Enabled = True
        Else
            cbTurma.Text = "Todas as Turmas"
            cbTurma.Enabled = False
        End If
    End Sub

    Private Sub btEfetivar_Click(sender As Object, e As EventArgs) Handles btEfetivar.Click

        If cbTurma.Text = String.Empty Then
            MsgBox("Escolha uma turma!", MsgBoxStyle.Information, "Mais Escola!")
        Else
            'APAGA TODOS OS REGISTROS...
            SQL = "DELETE FROM rpt_bolatraso WHERE idBolAtraso>=1;"
            MySQL_atualiza(SQL)

            If cbAF.Checked = True And nroBimestre.Value = 2 Then
                bimestre = "2AF"
            ElseIf cbAF.Checked = True And nroBimestre.Value = 4 Then
                bimestre = "4AF"
            Else
                bimestre = nroBimestre.Value
            End If

            btImprimir.Enabled = False
            bwProcesso.RunWorkerAsync()

        End If
    End Sub

    Private Sub tBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles nroBimestre.EditValueChanged

        If nroBimestre.Text = "2" Or nroBimestre.Text = "4" Then
            cbAF.Enabled = True
            cbAF.Checked = False

        Else
            cbAF.Enabled = False
            cbAF.Checked = False

        End If
    End Sub

    Private Sub cbAF_CheckedChanged(sender As Object, e As EventArgs) Handles cbAF.CheckedChanged

        If cbAF.Checked = True Then
            nroBimestre.Enabled = False

        Else
            nroBimestre.Enabled = True

        End If
    End Sub

    Private Sub cbTurma_TextChanged(sender As Object, e As EventArgs) Handles cbTurma.TextChanged
        If cbTurma.Text <> "Todas as Turmas" Then
            nroTurmaAluno = Consulta_Turma(cbTurma.Text)
        End If
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        frmPreview_Titulo = "Relatório: Boletins em Atraso"

        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridBoletim}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub
End Class