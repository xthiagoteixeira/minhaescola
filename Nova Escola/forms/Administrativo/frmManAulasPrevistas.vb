Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel

Public Class frmManAulasPrevistas

    ReadOnly Boletins_Corrigir(30) As String
    Dim Boletins_CorrigirContador = 0

    Public Delegate Sub IncrementProgressDelegate()

    Public Delegate Sub Delegação(texto As String)

    Public Sub DefinirBarra(texto As String)
        On Error Resume Next
        If barra.InvokeRequired Then
            Dim d As New Delegação(AddressOf DefinirBarra)
            barra.EditValue = barra.Invoke(d, texto)
            barra.Properties.Maximum = Boletins_CorrigirContador

        Else
            barra.EditValue = texto
            barra.Properties.Maximum = Boletins_CorrigirContador

        End If
    End Sub

    Sub Inicializacao()
        Boletins_CorrigirContador = 0
        Array.Clear(Boletins_Corrigir, 0, 30)
    End Sub

    Sub Refresh_Boletins()
        Try
            Dim MeuBimestre

            If cbTurma.Text <> "[EditValue é Nulo]" And tAno.Text <> String.Empty And nroBimestre.Text <> String.Empty Then

                Try
                    If cbAF.Checked = True And nroBimestre.Value = 2 Then
                        MeuBimestre = "2AF"
                    ElseIf cbAF.Checked = True And nroBimestre.Value = 4 Then
                        MeuBimestre = "4AF"
                    Else
                        MeuBimestre = nroBimestre.Value
                    End If

                    Dim Sql = String.Format("SELECT turma.Classe, disciplinas.Disciplina, notasfreq.qtdadeaulas AS Dadas, notasfreq.previsaoaulas AS Previstas, notasfreq.cod_nf AS codnf, notasfreq.turma AS codigoTurma, notasfreq.disciplina AS codigoDisciplina FROM notasfreq INNER JOIN turma ON notasfreq.turma = turma.codigo_trma INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND turma.classe='{2}' ORDER BY turma.classe, disciplinas.disciplina ASC;",
                                tAno.Text, MeuBimestre, cbTurma.Text)
                    gridBoletins.DataSource = Nothing
                    gridBoletins.DataSource = MySQL_datatable(Sql)

                    viewBoletins.Columns(0).OptionsColumn.AllowEdit = False
                    viewBoletins.Columns(1).OptionsColumn.AllowEdit = False
                    viewBoletins.Columns(2).OptionsColumn.AllowEdit = True
                    viewBoletins.Columns(3).OptionsColumn.AllowEdit = True

                    viewBoletins.Columns(2).ColumnEdit = RepositoryItemTextEdit1
                    viewBoletins.Columns(3).ColumnEdit = RepositoryItemTextEdit2

                    viewBoletins.Columns(4).Visible = False
                    viewBoletins.Columns(5).Visible = False
                    viewBoletins.Columns(6).Visible = False

                Catch r As IndexOutOfRangeException
                    MsgBox("Não existe boletim para efetuar alteração!", MsgBoxStyle.Information)
                End Try

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmManAulasPrevistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tAno.Value = AnoVigente
        SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC"
        cbTurma.Properties.DataSource = MySQL_combobox(SQL)
        cbTurma.Properties.DisplayMember = "classe"
    End Sub

    Private Sub tBimestre_TextChanged(sender As Object, e As EventArgs) Handles nroBimestre.TextChanged
        Inicializacao()
        Refresh_Boletins()
    End Sub

    Private Sub tAno_TextChanged(sender As Object, e As EventArgs) Handles tAno.TextChanged
        Inicializacao()
        Refresh_Boletins()
    End Sub

    Private Sub cbTurma_TextChanged(sender As Object, e As EventArgs) Handles cbTurma.TextChanged
        Inicializacao()
        Refresh_Boletins()
    End Sub

    Private Sub viewBoletins_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) _
        Handles viewBoletins.CellValueChanged

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim AulasDadas = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Dadas"))
            Dim AulasPrevistas = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Previstas"))
            Dim CodigoBoletim = View.GetRowCellDisplayText(e.RowHandle, View.Columns("codnf"))

            ' Somente ATUALIZA as Previstas
            SQL = String.Format("UPDATE notasfreq SET qtdadeaulas='{0}', previsaoaulas='{1}' WHERE cod_nf='{2}';",
                                AulasDadas, AulasPrevistas, CodigoBoletim)
            MySQL_atualiza(SQL)

            If View.FocusedColumn.FieldName = "Dadas" Then
                Boletins_Corrigir(Boletins_CorrigirContador) = CodigoBoletim
                Boletins_CorrigirContador += 1
            End If

        End If
    End Sub

    Private Sub bwBoletins_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwBoletins.DoWork
        Dim x = 0

        While (Boletins_Corrigir(x) <> Nothing)

            ' ... Procura quem tem DIFERENTE de zero nas faltas...
            SQL =
                String.Format(
                    "SELECT boletim.nro_aluno AS Nro, boletim.F AS Faltas, notasfreq.qtdadeaulas AS Dadas FROM notasfreq INNER JOIN boletim ON boletim.cod_boletim = notasfreq.cod_nf WHERE notasfreq.cod_nf='{0}' AND boletim.F<>'0' ORDER BY boletim.nro_aluno ASC;",
                    Boletins_Corrigir(x).ToString)
            Dim Retorno = MySQL_datatable(SQL)
            For Each r In Retorno.Rows
                Dim NroAluno = r("Nro").ToString
                Dim AulasDadas = CInt(r("Dadas"))
                Dim Faltas = CInt(r("Faltas"))
                Dim Porcentagem = CInt((Faltas * 100) / AulasDadas)

                Dim SQL2 =
                        String.Format(
                            "UPDATE boletim SET porcentagem='{0}' WHERE cod_boletim='{1}' AND nro_aluno='{2}';",
                            Porcentagem, Boletins_Corrigir(x).ToString, NroAluno)
                MySQL_atualiza(SQL2)
            Next

            x += 1
            DefinirBarra(x)

        End While
    End Sub

    Private Sub bwBoletins_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwBoletins.RunWorkerCompleted

        MsgBox("Concluído com sucesso!", MsgBoxStyle.Information, "Informação")
        barra.Properties.DisplayFormat.FormatString = "Concluído!"
    End Sub

    Private Sub cbAF_CheckedChanged(sender As Object, e As EventArgs) Handles cbAF.CheckedChanged
        If cbAF.Checked = True Then
            nroBimestre.Enabled = False
        Else
            nroBimestre.Enabled = True
        End If
        Refresh_Boletins()
    End Sub

    Private Sub nroBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles nroBimestre.EditValueChanged

        If nroBimestre.Value = "2" Or nroBimestre.Value = "4" Then
            cbAF.Enabled = True
            cbAF.Checked = False
        Else
            cbAF.Enabled = False
            cbAF.Checked = False
        End If
        Refresh_Boletins()
    End Sub

    Private Sub btAtualizar_Click(sender As Object, e As EventArgs) Handles btAtualizar.Click
        If cbTurma.Text <> String.Empty Or Boletins_CorrigirContador > 0 Then
            ' Atualiza...
            bwBoletins.RunWorkerAsync()
        Else
            MsgBox("Não existe boletim para atualizar!", MsgBoxStyle.Information, "Informação")
        End If

    End Sub
End Class