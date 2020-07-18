
Public Class frmRpt_Consolidado
    Dim meuClique
    Dim Disciplina_Codigo, Turma_Codigo

    Public Sub Refresh_DataGrid()

        SQL = "SELECT" _
           & "  turma.classe AS Turma," _
           & "  disciplinas.disciplina AS Disciplina," _
           & "  notasfreq.cod_bimestre AS Bim," _
           & "  notasfreq_prof.grupo," _
           & "  notasfreq_prof.cod_nf" _
           & " FROM" _
           & " notasfreq" _
           & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
           & " INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc)" _
           & " INNER JOIN notasfreq_prof ON (notasfreq.cod_nf = notasfreq_prof.cod_nf)" _
           & " WHERE notasfreq_prof.grupo='9999';"
        gridConsolidado.DataSource = MySQL_consulta_datagrid2(SQL)

        viewConsolidado.Columns(0).Width = 90
        viewConsolidado.Columns(1).Width = 120
        viewConsolidado.Columns(2).Width = 30
        viewConsolidado.Columns(3).Visible = False
        viewConsolidado.Columns(4).Visible = False

    End Sub

    Private Sub frmGerencialBolMovel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim SQL = "DELETE FROM notasfreq_prof WHERE grupo='9999';"
        MySQL_atualiza(SQL)

    End Sub

    Private Sub frmGerencialBolMovel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tAno.Value = AnoVigente
        nroBimestre.Value = consultaBimestre()

        SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe;"
        cbTurma.Properties.DataSource = MySQL_combobox(SQL)
        cbTurma.Properties.DisplayMember = "classe"

        SQL = "SELECT disciplina FROM disciplinas WHERE bloqueado='0' AND disciplina<>'-' ORDER BY disciplina;"
        cbDisciplina.Properties.DataSource = MySQL_combobox(SQL)
        cbDisciplina.Properties.DisplayMember = "disciplina"

    End Sub

    Private Sub btMais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMais.Click
        Dim MinhaNF As String = "0"
        Dim MeuBimestre

        If cbTurma.Text = String.Empty Then

            MsgBox("Escolha uma turma!", MsgBoxStyle.Information)

        Else

            btImprimir.Enabled = True

            If cbAF.Checked = True And nroBimestre.Value = 2 Then
                MeuBimestre = "2AF"
            ElseIf cbAF.Checked = True And nroBimestre.Value = 4 Then
                MeuBimestre = "4AF"
            Else
                MeuBimestre = nroBimestre.Value
            End If

            Dim SQL = "SELECT notasfreq.anovigente," _
                    & "disciplinas.disciplina, " _
                    & "turma.classe, " _
                    & "notasfreq.cod_bimestre, " _
                    & "notasfreq.cod_nf " _
                    & "FROM " _
                    & "notasfreq " _
                    & "INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma) " _
                    & "INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) " _
                    & "WHERE notasfreq.disciplina='" & Disciplina_Codigo & "' AND notasfreq.turma='" & Turma_Codigo & "' AND notasfreq.anovigente='" & tAno.Value & "' AND notasfreq.cod_bimestre='" & MeuBimestre & "';"
            MinhaNF = MySQL_consulta_campo(SQL, "cod_nf")
            If MinhaNF = 0 Then
                MsgBox("Não possui boletim cadastrado!", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim DataLancamento = Format(Date.Now, "yyyy-MM-dd")
            SQL = "INSERT INTO notasfreq_prof (data_lancamento, grupo, cod_nf) values('" & DataLancamento & "','9999','" & MinhaNF & "');"
            MySQL_atualiza(SQL)
            Refresh_DataGrid()

        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click
        '### MSGBOX SIM E NAO ###
        Dim vStrMsg As String =
         MsgBox("Deseja imprimir?", MsgBoxStyle.YesNo, "Atenção!")
        If vStrMsg = MsgBoxResult.Yes Then
            'PASSA VARIAVEL PARA RPT COM O CODIGO NOVO DO PROFESSOR (GRUPO NOTASFREQ_PROF)
            frmRpt_codigo = 9999
            SQL_frmRPT = meuRPT("ConsolidadoProfessor")

            frmRpt_Auxiliar.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMenos.Click
        Dim SQL = "DELETE FROM notasfreq_prof WHERE cod_nf='" & meuClique & "' AND grupo='9999';"
        MySQL_atualiza(SQL)

        Refresh_DataGrid()

    End Sub

    Private Sub cbAF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged
        If cbAF.Checked = True Then
            nroBimestre.Enabled = False
        Else
            nroBimestre.Enabled = True
        End If
    End Sub

    'Private Sub DGGrupo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGGrupo.CellClick
    '    btMenos.Enabled = True
    '    meuClique = DGGrupo.CurrentRow.Cells(4).Value.ToString
    'End Sub

    Private Sub cbTurma_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbTurma.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbDisciplina_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbDisciplina.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbTurma_TextChanged(sender As Object, e As System.EventArgs) Handles cbTurma.TextChanged
        Turma_Codigo = Consulta_Turma(cbTurma.Text)
    End Sub

    Private Sub nroBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles nroBimestre.EditValueChanged

        If nroBimestre.Value = "2" Or nroBimestre.Value = "4" Then
            cbAF.Enabled = True
            cbAF.Checked = False
        Else
            cbAF.Enabled = False
            cbAF.Checked = False
        End If
    End Sub

    Private Sub cbDisciplina_TextChanged(sender As Object, e As System.EventArgs) Handles cbDisciplina.TextChanged
        Disciplina_Codigo = Consulta_Disciplina(cbDisciplina.Text)
    End Sub
End Class