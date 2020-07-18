Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class FrmAdmBolsas
    Dim _discno
    Dim TipoBolsa, TipoBolsa_SemNome

    Public Sub Refresh_DataGrid(Acao As String)

        Try

            If Acao = "Todos" Then

                frmPreview_Titulo = "Relatório: Bolsa de Estudo"

                SQL = "SELECT aluno.Nome, " _
                      & "aluno.Nro, " _
                      & "turma.Classe, " _
                      & "aluno.status AS Status " _
                      & "FROM " _
                      & "aluno " _
                      & "INNER JOIN turma ON aluno.turma = turma.codigo_trma WHERE aluno.anovigente='" & CInt(tAno.Text) &
                      "' " _
                      & "ORDER BY aluno.Nome, turma.Classe ASC;"
                listarBolsaFamilia.Checked = False
                listarBVJ.Checked = False
                listarTodos.Checked = True

                viewBolsa.Columns.Clear()
                gridBolsa.DataSource = Nothing
                gridBolsa.DataSource = MySQL_consulta_datagrid(SQL)
                viewBolsa.Columns(0).Width = 120
                viewBolsa.Columns(1).Width = 20
                viewBolsa.Columns(2).Width = 60
                viewBolsa.Columns(3).Visible = False

            Else

                'Mostra no Grid Control...
                SQL = "SELECT aluno.Nome, " _
                      & "aluno.Nro, " _
                      & "turma.Classe, (100-Porcentagem('" & tAno.Text & "', '" & tBimestre.Text &
                      "', bolsas.codigo_trma, bolsas.nro)) AS '% Freq.', " _
                      & "aluno.status AS Status " _
                      & "FROM " _
                      & "aluno " _
                      & "INNER JOIN bolsas ON aluno.nro = bolsas.nro AND aluno.anovigente = bolsas.ano " _
                      &
                      "INNER JOIN turma ON bolsas.codigo_trma = turma.codigo_trma AND aluno.turma = turma.codigo_trma WHERE bolsas.ano='" &
                      CInt(tAno.Text) & "' AND bolsas.tipo='" & Acao & "' " _
                      & "ORDER BY aluno.Nome, turma.Classe ASC;"

                If Acao = "BF" Then
                    listarTodos.Checked = False
                    listarBVJ.Checked = False
                    listarBolsaFamilia.Checked = True
                    frmPreview_Titulo = String.Format("Relatório: Bolsa Família - {0}o. Bimestre", tBimestre.Text)

                ElseIf Acao = "BVJ" Then
                    listarBolsaFamilia.Checked = False
                    listarTodos.Checked = False
                    listarBVJ.Checked = True
                    frmPreview_Titulo = String.Format("Relatório: Bolsa Variável Jovem - {0}o. Bimestre", tBimestre.Text)

                End If

                viewBolsa.Columns.Clear()
                gridBolsa.DataSource = Nothing
                gridBolsa.DataSource = MySQL_consulta_datagrid(SQL)
                viewBolsa.Columns(0).Width = 120
                viewBolsa.Columns(1).Width = 20
                viewBolsa.Columns(2).Width = 60
                viewBolsa.Columns(3).Width = 20
                viewBolsa.Columns(4).Visible = False

            End If

        Catch ex As Exception
            gridBolsa.DataSource = Nothing

        End Try
    End Sub

    Public Sub PesquisaAluno()

        If lbTurma.Text <> "-" Then

            _discno = Consulta_Turma(lbTurma.Text)

            Dim SQL As String =
                    String.Format("SELECT nro FROM aluno WHERE turma='{0}' AND anovigente='{1}' ORDER BY nro DESC",
                                  _discno, tAno.Value)
            nroCodigo.Properties.MaxValue = MySQL_consulta_campo(SQL, "nro")

            SQL = String.Format("SELECT nome FROM aluno WHERE nro='{0}' AND turma='{1}' AND anovigente='{2}';",
                                nroCodigo.Value, _discno, tAno.Value)
            tbAluno.Text = MySQL_consulta_campo(SQL, "nome")

            SQL = String.Format("SELECT tipo FROM bolsas WHERE nro='{0}' AND codigo_trma='{1}' AND ano='{2}';",
                                nroCodigo.Value, _discno, tAno.Value)
            Dim resultado = MySQL_consulta_campo(SQL, "tipo")

            If resultado = "BVJ" Then
                rgBolsas.SelectedIndex = 1
            ElseIf resultado = "BF" Then
                rgBolsas.SelectedIndex = 0
            Else
                rgBolsas.SelectedIndex = 2
            End If

            nroCodigo.Enabled = True
            tbAluno.Enabled = True
        End If
    End Sub

    Private Sub frmAdmBolsas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmAdmBolsas"
        tAno.Value = AnoVigente
        tBimestre.Value = consultaBimestre()

        Refresh_DataGrid("Todos")
        btImprimir.Enabled = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btEfetuar.Click

        If nroCodigo.Text = "0" Or tbAluno.Text = "0" Or lbTurma.Text = "-" Then
            MsgBox("Preencher os dados", MsgBoxStyle.Information, "Informação")

        Else

            If rgBolsas.SelectedIndex = 0 Then
                TipoBolsa = "BF"
                TipoBolsa_SemNome = "Bolsa Família"
            ElseIf rgBolsas.SelectedIndex = 1 Then
                TipoBolsa = "BVJ"
                TipoBolsa_SemNome = "Bolsa Variável Jovem"
            ElseIf rgBolsas.SelectedIndex = 2 Then
                TipoBolsa = "0"
                TipoBolsa_SemNome = "Sem Bolsa"
            End If

            Select Case _
                MsgBox(String.Format("Alterar o aluno: [ {0} ] para: [ {1} ] ?", tbAluno.Text, TipoBolsa_SemNome),
                       MsgBoxStyle.YesNo, "Alteração")

                Case DialogResult.Yes

                    ' _ TENTA ATUALIZAR...
                    SQL =
                        String.Format(
                            "UPDATE bolsas SET tipo='{0}' WHERE codigo_trma='{1}' AND nro='{2}' AND ano='{3}';",
                            TipoBolsa, _discno, nroCodigo.Value, CInt(tAno.Value))
                    Dim retorno = MySQL_atualiza(SQL)

                    If retorno = 0 Then
                        ' _ SE NAO HOUVER RETORNO, ADICIONA!
                        SQL =
                            String.Format(
                                "INSERT INTO bolsas (tipo, codigo_trma, nro, ano) values('{0}', '{1}', '{2}', '{3}');",
                                TipoBolsa, _discno, nroCodigo.Value, CInt(tAno.Value))
                        MySQL_atualiza(SQL)
                    End If

                    ' APAGA TODOS QUE TEM '0', OU SEJA, NENHUMA BOLSA ...
                    If TipoBolsa = "0" Then
                        SQL = "DELETE FROM bolsas WHERE tipo='0';"
                        MySQL_atualiza(SQL)
                    End If

                    arquivoLog("Administrativo",
                               "Bolsa Escolar " & CInt(tAno.Text) & ": " & nroCodigo.Value & " - " & lbTurma.Text & " [" &
                               TipoBolsa_SemNome & "]")
                    Refresh_DataGrid(TipoBolsa)

            End Select

        End If
    End Sub

    Private Sub listarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles listarTodos.CheckedChanged
        If listarTodos.Checked = True Then
            Refresh_DataGrid("Todos")
            btImprimir.Enabled = True
        End If
    End Sub

    Private Sub listarBVJ_CheckedChanged(sender As Object, e As EventArgs) Handles listarBVJ.CheckedChanged
        If listarBVJ.Checked = True Then
            Refresh_DataGrid("BVJ")
            btImprimir.Enabled = True
        End If
    End Sub

    Private Sub listarBolsaFamilia_CheckedChanged(sender As Object, e As EventArgs) _
        Handles listarBolsaFamilia.CheckedChanged
        If listarBolsaFamilia.Checked = True Then
            Refresh_DataGrid("BF")
            btImprimir.Enabled = True
        End If
    End Sub

    Private Sub viewBolsa_RowClick(sender As Object, e As RowClickEventArgs) Handles viewBolsa.RowClick

        Dim View As GridView = sender
        lbTurma.Text = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Classe"))
        nroCodigo.Text = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Nro"))

        btEfetuar.Enabled = True
    End Sub

    Private Sub viewBolsa_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewBolsa.RowStyle

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim category = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))

            If category = "0" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.White
            Else
                e.Appearance.BackColor = Color.LightYellow
                e.Appearance.BackColor2 = Color.Yellow
            End If
        End If
    End Sub

    Private Sub lbTurma_TextChanged(sender As Object, e As EventArgs) Handles lbTurma.TextChanged
        PesquisaAluno()
    End Sub

    Private Sub cbImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

        frmPreview_Titulo = TipoBolsa_SemNome
        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridBolsa}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()

    End Sub

    Private Sub tAno_EditValueChanged(sender As Object, e As EventArgs) Handles tAno.EditValueChanged
        'PesquisaAluno()
        Refresh_DataGrid("Todos")
    End Sub

    Private Sub nroCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles nroCodigo.EditValueChanged
        PesquisaAluno()
    End Sub

    Private Sub tBimestre_EditValueChanged(sender As Object, e As EventArgs) Handles tBimestre.EditValueChanged

        If listarBolsaFamilia.Checked = True Then
            Refresh_DataGrid("BF")
            btImprimir.Enabled = True
        ElseIf listarBVJ.Checked = True Then
            Refresh_DataGrid("BVJ")
            btImprimir.Enabled = True
        End If
    End Sub
End Class