Public Class frmRpt_ATA
    Dim minhaOpcao = String.Empty

    Private Sub frmR_ACCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tAno.Value = AnoVigente
        nroBimestre.Text = consultaBimestre()

        'Tenta ler se já existe cadastrado...
        '
        SQL =
            "SELECT C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11 FROM rpt_atacompl WHERE idReport='1';"

        Dim Consulta = MySQL_datatable(SQL)

        For Each r In Consulta.Rows

            C1.Text = r("C1").ToString
            C2.Text = r("C2").ToString
            C3.Text = r("C3").ToString
            C4.Text = r("C4").ToString
            C5.Text = r("C5").ToString
            C6.Text = r("C6").ToString
            C7.Text = r("C7").ToString
            C8.Text = r("C8").ToString
            C9.Text = r("C9").ToString
            C10.Text = r("C10").ToString
            C11.Text = r("C11").ToString

            P1.Text = r("P1").ToString
            P2.Text = r("P2").ToString
            P3.Text = r("P3").ToString
            P4.Text = r("P4").ToString
            P5.Text = r("P5").ToString
            P6.Text = r("P6").ToString
            P7.Text = r("P7").ToString
            P8.Text = r("P8").ToString
            P9.Text = r("P9").ToString
            P10.Text = r("P10").ToString
            P11.Text = r("P11").ToString

        Next
    End Sub

    Private Sub btVisualizar_Click(sender As Object, e As EventArgs) Handles btVisualizar.Click

        'crReportDocument = Nothing
        Dim bimestre
        Dim MinhaData = dataConselho.Text

        If MinhaData <> String.Empty Then

            If cbAF.Checked = True And nroBimestre.Value = 2 Then
                bimestre = "2AF"
            ElseIf cbAF.Checked = True And nroBimestre.Value = 4 Then
                bimestre = "4AF"
            Else
                bimestre = nroBimestre.Text
            End If

            ' ... Gera a ATA do Conselho...
            SQL = ("DELETE FROM rpt_atacompl WHERE idReport='1';")
            MySQL_atualiza(SQL)

            SQL =
                String.Format(
                    "INSERT INTO rpt_atacompl (idReport, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, DataEscolhida, cod_bimestre) values('1','{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}','{11}','{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}');",
                    C1.Text, C2.Text, C3.Text, C4.Text, C5.Text, C6.Text, C7.Text, C8.Text, C9.Text, C10.Text, C11.Text,
                    P1.Text, P2.Text, P3.Text, P4.Text, P5.Text, P6.Text, P7.Text, P8.Text, P9.Text, P10.Text, P11.Text,
                    dataConselho.Text, nroBimestre.Value)
            MySQL_atualiza(SQL)

            frmRpt_anovigente = tAno.Value
            frmRpt_bimestre = bimestre
            frmRpt_Parametro = cbEscolha.Text

            If cbEscolha.Text = "TODAS AS TURMAS" Then
                frmRpt_tipo = "TurmaTodas"
            End If

            If cbRelatorio.Text = "Simples" Then
                minhaOpcao = "ataConvencional"
            ElseIf cbRelatorio.Text = "Oficial" Then
                minhaOpcao = "ataOficial"
            ElseIf cbRelatorio.Text = "Rendimento Insatisfatório" Then
                minhaOpcao = "ataRendInsatisfatorio"
            End If

            SQL_frmRPT = meuRpt2("ATA do Conselho", minhaOpcao)
            frmRpt_Auxiliar.Show()

        Else
            MsgBox("Data não informada!", MsgBoxStyle.Information, "Informação!")
        End If
    End Sub

    Private Sub cbEscolha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEscolha.SelectedIndexChanged
        btVisualizar.Enabled = True
    End Sub

    Private Sub grupoEscolha_EditValueChanged(sender As Object, e As EventArgs) Handles grupoEscolha.EditValueChanged
        If grupoEscolha.SelectedIndex = 0 Then
            cbEscolha.Enabled = True

            cbEscolha.Properties.Items.Clear()
            cbEscolha.Properties.Items.Add("Manhã")
            cbEscolha.Properties.Items.Add("Tarde")
            cbEscolha.Properties.Items.Add("Noite")
            cbEscolha.Properties.Items.Add("Integral")

            frmRpt_tipo = "Período"
            cbEscolha.Text = String.Empty

        ElseIf grupoEscolha.SelectedIndex = 1 Then
            cbEscolha.Enabled = True

            cbEscolha.Properties.Items.Clear()
            cbEscolha.Properties.Items.Add("TODAS AS TURMAS")
            SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
            Dim Turmas = MySQL_combobox(SQL)
            For Each r In Turmas.Rows
                cbEscolha.Properties.Items.Add(r("classe"))
            Next
            frmRpt_tipo = "Turma"
            cbEscolha.Text = String.Empty

        End If
    End Sub

    Private Sub nroBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles nroBimestre.EditValueChanged

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
End Class