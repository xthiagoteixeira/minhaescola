Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAdmDelib11Ficha
    Dim _turmaNro
    Dim _turmaNome
    Dim _delibStatus = "Nenhuma", _delibNf = "0"

    'Private Function GetCellAppearance(view As GridView, rowHandle As Integer, column As GridColumn) As AppearanceObject
    '    Dim viewInfo = TryCast(view.GetViewInfo(), GridViewInfo)
    '    Dim cellInfo As GridCellInfo = viewInfo.GetGridCellInfo(rowHandle, column)
    '    If cellInfo Is Nothing Then
    '        Return Nothing
    '    End If
    '    Return cellInfo.Appearance
    'End Function

    Sub Ficha_Aluno_Alinhar()

        Try
            viewFicha.Columns(0).Width = "60"
            viewFicha.Columns(1).Width = "500"
            viewFicha.Columns(2).Visible = False
            viewFicha.Columns(3).Visible = False
            viewFicha.Columns(4).Visible = False
            viewFicha.Columns(5).Visible = False
            viewFicha.Columns(6).Visible = False
            viewFicha.Columns(7).Visible = False
            viewFicha.Columns(8).Visible = False
            viewFicha.Columns(9).Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Sub ConsultaBoletim()

        SQL =
            String.Format(
                "SELECT notasfreq.cod_bimestre AS Bimestre, disciplinas.disciplina AS Disciplina, boletim.M AS M, boletim.F AS F FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc WHERE notasfreq.anovigente='{0}' AND notasfreq.turma='{1}' AND boletim.nro_aluno='{2}' AND boletim.M<5 ORDER BY disciplinas.disciplina, notasfreq.cod_bimestre ASC;",
                tAno.Value, _turmaNro, nrAluno_Delib11.Text)
        gridBoletim.DataSource = Nothing

        gridBoletim.DataSource = MySQL_datatable(SQL)

        viewBoletim.Columns(0).Width = "80"
        viewBoletim.Columns(1).Width = "100"
        viewBoletim.Columns(2).Width = "40"
        viewBoletim.Columns(3).Width = "40"
    End Sub

    Sub Delib11_Preencher(situacao As String, alunoNro As Integer)

        ' Preenche as Categorias...
        '
        SQL = "SELECT idDelib_cat, categoria FROM delib11_categoria ORDER BY idDelib_cat ASC;"
        Dim categorias As DataTable = MySQL_datatable(SQL)
        For Each r In categorias.Rows
            If r("idDelib_cat") = 1 Then
                lbDelib_Cat01.Text = r("categoria")
            ElseIf r("idDelib_cat") = 2 Then
                lbDelib_Cat02.Text = r("categoria")
            ElseIf r("idDelib_cat") = 3 Then
                lbDelib_Cat03.Text = r("categoria")
            ElseIf r("idDelib_cat") = 4 Then
                lbDelib_Cat04.Text = r("categoria")
            End If
        Next

        ' Preenche as Descrições...
        If situacao = "Novo" Then
            SQL = "SELECT idDelib_cat, descricao FROM delib11_descricao ORDER BY idDelib_cat, descricao ASC;"
            Dim Descricao = MySQL_datatable(SQL)
            For Each r In Descricao.Rows
                If r("idDelib_cat") = 1 Then
                    listaDelib11_01.Items.Add(r("descricao"))
                ElseIf r("idDelib_cat") = 2 Then
                    listaDelib11_02.Items.Add(r("descricao"))
                ElseIf r("idDelib_cat") = 3 Then
                    listaDelib11_03.Items.Add(r("descricao"))
                ElseIf r("idDelib_cat") = 4 Then
                    listaDelib11_04.Items.Add(r("descricao"))
                End If
            Next
            ConsultaBoletim()

            ' Checa na Delib11_nf e Delib11_boletim para preencher e deixar ticado...
        ElseIf situacao = "Atualizar" Then

            SQL =
                String.Format(
                    "SELECT idDelibNF FROM delib11_nf WHERE anovigente='{0}' AND turma='{1}' AND nro_aluno='{2}';",
                    tAno.Value, _turmaNro, alunoNro)
            Dim fichaDelib As Object = MySQL_consulta_campo(SQL, "idDelibNF")
            _delibNf = fichaDelib

            SQL =
                "SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao ORDER BY idDelib_cat, descricao ASC;"
            Dim descricao = MySQL_datatable(SQL)

            For Each r In descricao.Rows
                If r("idDelib_cat") = 1 Then
                    SQL =
                        String.Format(
                            "SELECT idDelibNF FROM delib11_boletim WHERE idDelibNF='{0}' AND idDelib_cat='{1}' AND idDelib_des='{2}';",
                            fichaDelib, r("idDelib_cat"), r("idDelib_des"))
                    Dim testaDescricao = MySQL_consulta_campo(SQL, "idDelibNF")
                    If testaDescricao <> "0" Then
                        listaDelib11_01.Items.Add(r("descricao"), True)
                    Else
                        listaDelib11_01.Items.Add(r("descricao"), False)
                    End If
                ElseIf r("idDelib_cat") = 2 Then
                    SQL =
                        String.Format(
                            "SELECT idDelibNF FROM delib11_boletim WHERE idDelibNF='{0}' AND idDelib_cat='{1}' AND idDelib_des='{2}';",
                            fichaDelib, r("idDelib_cat"), r("idDelib_des"))
                    Dim testaDescricao = MySQL_consulta_campo(SQL, "idDelibNF")
                    If testaDescricao <> "0" Then
                        listaDelib11_02.Items.Add(r("descricao"), True)
                    Else
                        listaDelib11_02.Items.Add(r("descricao"), False)
                    End If
                ElseIf r("idDelib_cat") = 3 Then
                    SQL =
                        String.Format(
                            "SELECT idDelibNF FROM delib11_boletim WHERE idDelibNF='{0}' AND idDelib_cat='{1}' AND idDelib_des='{2}';",
                            fichaDelib, r("idDelib_cat"), r("idDelib_des"))
                    Dim testaDescricao = MySQL_consulta_campo(SQL, "idDelibNF")
                    If testaDescricao <> "0" Then
                        listaDelib11_03.Items.Add(r("descricao"), True)
                    Else
                        listaDelib11_03.Items.Add(r("descricao"), False)
                    End If
                ElseIf r("idDelib_cat") = 4 Then
                    SQL =
                        String.Format(
                            "SELECT idDelibNF FROM delib11_boletim WHERE idDelibNF='{0}' AND idDelib_cat='{1}' AND idDelib_des='{2}';",
                            fichaDelib, r("idDelib_cat"), r("idDelib_des"))
                    Dim testaDescricao = MySQL_consulta_campo(SQL, "idDelibNF")
                    If testaDescricao <> "0" Then
                        listaDelib11_04.Items.Add(r("descricao"), True)
                    Else
                        listaDelib11_04.Items.Add(r("descricao"), False)
                    End If
                End If
            Next
            ConsultaBoletim()
        End If
    End Sub

    Sub RefreshTurmas()

        Me.Cursor = Cursors.WaitCursor

        SQL = "SELECT " _
              & "aluno.nro AS Nro, " _
              & "aluno.Nome, " _
              & "aluno.anovigente AS Ano, " _
              & "turma.classe AS Turma, " _
              & "turma.codigo_trma AS NroTurma, " _
              & "aluno.status AS Status, " _
              & "aluno.ra AS RA, " _
              &
              "aluno.ra_digito AS RA_Digito, QtdadeNotas(aluno.anovigente, aluno.turma,aluno.nro,5) AS NotasVermelhas, " _
              & "Delib11Ficha(aluno.anovigente, aluno.turma,aluno.nro) AS FichaNro FROM " _
              & "aluno " _
              & "INNER JOIN turma ON turma.codigo_trma = aluno.turma " _
              & "WHERE aluno.anovigente='" & CInt(tAno.Text) & "' AND turma.classe='" & _turmaNome &
              "' ORDER BY aluno.nro ASC;"
        gridFicha.DataSource = Nothing
        gridFicha.DataSource = MySQL_datatable(SQL)
        Ficha_Aluno_Alinhar()

        Me.Cursor = Cursors.Default
    End Sub

    Sub Inicializacao()

        '  gridFicha.DataSource = Nothing

        tabFichaCompleta.SelectTab(0)

        listaDelib11_01.Items.Clear()
        listaDelib11_02.Items.Clear()
        listaDelib11_03.Items.Clear()
        listaDelib11_04.Items.Clear()
    End Sub

    Private Sub frmAdmDelib11Ficha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Erro_Form = "frmAdmDelib11Ficha"

        tAno.Value = AnoVigente

        SQL = "SELECT categoria FROM delib11_categoria WHERE idDelib11_cat='1';"
        lbDelib_Cat01.Text = MySQL_consulta_campo(SQL, "categoria")

        SQL = "SELECT categoria FROM delib11_categoria WHERE idDelib11_cat='2';"
        lbDelib_Cat02.Text = MySQL_consulta_campo(SQL, "categoria")

        SQL = "SELECT categoria FROM delib11_categoria WHERE idDelib11_cat='3';"
        lbDelib_Cat03.Text = MySQL_consulta_campo(SQL, "categoria")

        SQL = "SELECT categoria FROM delib11_categoria WHERE idDelib11_cat='4';"
        lbDelib_Cat04.Text = MySQL_consulta_campo(SQL, "categoria")

        ' Preencher as Turmas...
        SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe;"
        cbTurma.Properties.DataSource = MySQL_combobox(SQL)
        cbTurma.Properties.DisplayMember = "classe"
    End Sub

    Private Sub listaDelib11_01_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles listaDelib11_01.ItemCheck

        If _delibStatus = "Novo" Then
            'Insere...
            SQL =
                String.Format(
                    "INSERT INTO delib11_nf (anovigente, turma, nro_aluno) VALUES('{0}','{1}','{2}'); SELECT LAST_INSERT_ID() AS idFuncionarios;",
                    tAno.Value, _turmaNro, nrAluno_Delib11.Text)
            Dim novoDelibNf = MySQL_atualiza(SQL)

            ' Código da Categoria / Descrição...'
            SQL =
                String.Format("SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao WHERE descricao='{0}';",
                              listaDelib11_01.Text)
            Dim idDelibDes = MySQL_consulta_campo(SQL, "idDelib_des")
            Dim idDelibCat = MySQL_consulta_campo(SQL, "idDelib_cat")

            SQL =
                String.Format(
                    "INSERT INTO delib11_boletim (idDelibNF, idDelib_cat, idDelib_des, idUsuarioDSK) VALUES('{0}','{1}','{2}','{3}');",
                    novoDelibNf, idDelibCat, idDelibDes, idUsuarioDSK)
            MySQL_atualiza(SQL)

            _delibStatus = "Atualizar"
            _delibNf = novoDelibNf
            RefreshTurmas()

        ElseIf _delibStatus = "Atualizar" Then
            ' Código da Categoria / Descrição...'
            SQL =
                String.Format("SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao WHERE descricao='{0}';",
                              listaDelib11_01.Text)
            Dim idDelibDes = MySQL_consulta_campo(SQL, "idDelib_des")
            Dim idDelibCat = MySQL_consulta_campo(SQL, "idDelib_cat")

            If e.State = CheckState.Checked Then
                SQL =
                    String.Format(
                        "INSERT INTO delib11_boletim (idDelibNF, idDelib_cat, idDelib_des, idUsuarioDSK) VALUES('{0}','{1}','{2}','{3}');",
                        _delibNf, idDelibCat, idDelibDes, idUsuarioDSK)
                MySQL_atualiza(SQL)

            ElseIf e.State = CheckState.Unchecked Then
                SQL =
                    String.Format(
                        "DELETE FROM delib11_boletim WHERE idDelibNF='{0}' AND idDelib_cat='{1}' AND idDelib_des='{2}';",
                        _delibNf, idDelibCat, idDelibDes)
                MySQL_atualiza(SQL)

                SQL = String.Format("SELECT COUNT(idDelibNF) AS DelibNF FROM delib11_boletim WHERE idDelibNF='{0}';",
                                    _delibNf)
                Dim contaRestantes = MySQL_consulta_campo(SQL, "DelibNF")

                If contaRestantes = "0" Then
                    SQL = String.Format("DELETE FROM delib11_nf WHERE idDelibNF='{0}';", _delibNf)
                    MySQL_atualiza(SQL)
                End If

            End If

        End If
    End Sub

    Private Sub listaDelib11_02_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles listaDelib11_02.ItemCheck

        If _delibStatus = "Novo" Then
            'Insere...
            SQL =
                String.Format(
                    "INSERT INTO delib11_nf (anovigente, turma, nro_aluno) VALUES('{0}','{1}','{2}'); SELECT LAST_INSERT_ID() AS idFuncionarios;",
                    tAno.Value, _turmaNro, nrAluno_Delib11.Text)
            Dim novoDelibNf As Integer = MySQL_atualiza(SQL)

            ' Código da Categoria / Descrição...'
            SQL =
                String.Format("SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao WHERE descricao='{0}';",
                              listaDelib11_02.Text)
            Dim idDelibDes As Object = MySQL_consulta_campo(SQL, "idDelib_des")
            Dim idDelibCat As Object = MySQL_consulta_campo(SQL, "idDelib_cat")

            SQL =
                String.Format(
                    "INSERT INTO delib11_boletim (idDelibNF, idDelib_cat, idDelib_des, idUsuarioDSK) VALUES('{0}','{1}','{2}','{3}');",
                    novoDelibNf, idDelibCat, idDelibDes, idUsuarioDSK)
            MySQL_atualiza(SQL)

            _delibStatus = "Atualizar"
            _delibNf = novoDelibNf
            RefreshTurmas()

        ElseIf _delibStatus = "Atualizar" Then
            ' Código da Categoria / Descrição...'
            SQL =
                String.Format("SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao WHERE descricao='{0}';",
                              listaDelib11_02.Text)
            Dim idDelibDes As Object = MySQL_consulta_campo(SQL, "idDelib_des")
            Dim idDelibCat As Object = MySQL_consulta_campo(SQL, "idDelib_cat")

            If e.State = CheckState.Checked Then
                SQL =
                    String.Format(
                        "INSERT INTO delib11_boletim (idDelibNF, idDelib_cat, idDelib_des, idUsuarioDSK) VALUES('{0}','{1}','{2}','{3}');",
                        _delibNf, idDelibCat, idDelibDes, idUsuarioDSK)
                MySQL_atualiza(SQL)
            ElseIf e.State = CheckState.Unchecked Then
                SQL =
                    String.Format(
                        "DELETE FROM delib11_boletim WHERE idDelibNF='{0}' AND idDelib_cat='{1}' AND idDelib_des='{2}';",
                        _delibNf, idDelibCat, idDelibDes)
                MySQL_atualiza(SQL)

                SQL = String.Format("SELECT COUNT(idDelibNF) AS DelibNF FROM delib11_boletim WHERE idDelibNF='{0}';",
                                    _delibNf)
                Dim contaRestantes = MySQL_consulta_campo(SQL, "DelibNF")

                If contaRestantes = "0" Then
                    SQL = String.Format("DELETE FROM delib11_nf WHERE idDelibNF='{0}';", _delibNf)
                    MySQL_atualiza(SQL)
                End If

            End If

        End If
    End Sub

    Private Sub listaDelib11_03_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles listaDelib11_03.ItemCheck

        If _delibStatus = "Novo" Then
            'Insere...
            SQL =
                String.Format(
                    "INSERT INTO delib11_nf (anovigente, turma, nro_aluno) VALUES('{0}','{1}','{2}'); SELECT LAST_INSERT_ID() AS idFuncionarios;",
                    tAno.Value, _turmaNro, nrAluno_Delib11.Text)
            Dim novoDelibNf = MySQL_atualiza(SQL)

            ' Código da Categoria / Descrição...'
            SQL =
                String.Format("SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao WHERE descricao='{0}';",
                              listaDelib11_03.Text)
            Dim idDelibDes As Object = MySQL_consulta_campo(SQL, "idDelib_des")
            Dim idDelibCat As Object = MySQL_consulta_campo(SQL, "idDelib_cat")

            SQL =
                String.Format(
                    "INSERT INTO delib11_boletim (idDelibNF, idDelib_cat, idDelib_des, idUsuarioDSK) VALUES('{0}','{1}','{2}','{3}');",
                    novoDelibNf, idDelibCat, idDelibDes, idUsuarioDSK)
            MySQL_atualiza(SQL)

            _delibStatus = "Atualizar"
            _delibNf = novoDelibNf
            RefreshTurmas()

        ElseIf _delibStatus = "Atualizar" Then
            ' Código da Categoria / Descrição...'
            SQL =
                String.Format("SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao WHERE descricao='{0}';",
                              listaDelib11_03.Text)
            Dim idDelibDes As Object = MySQL_consulta_campo(SQL, "idDelib_des")
            Dim idDelibCat As Object = MySQL_consulta_campo(SQL, "idDelib_cat")

            If e.State = CheckState.Checked Then
                SQL =
                    String.Format(
                        "INSERT INTO delib11_boletim (idDelibNF, idDelib_cat, idDelib_des, idUsuarioDSK) VALUES('{0}','{1}','{2}','{3}');",
                        _delibNf, idDelibCat, idDelibDes, idUsuarioDSK)
                MySQL_atualiza(SQL)
            ElseIf e.State = CheckState.Unchecked Then
                SQL =
                    String.Format(
                        "DELETE FROM delib11_boletim WHERE idDelibNF='{0}' AND idDelib_cat='{1}' AND idDelib_des='{2}';",
                        _delibNf, idDelibCat, idDelibDes)
                MySQL_atualiza(SQL)

                SQL = String.Format("SELECT COUNT(idDelibNF) AS DelibNF FROM delib11_boletim WHERE idDelibNF='{0}';",
                                    _delibNf)
                Dim contaRestantes As Object = MySQL_consulta_campo(SQL, "DelibNF")

                If contaRestantes = "0" Then
                    SQL = String.Format("DELETE FROM delib11_nf WHERE idDelibNF='{0}';", _delibNf)
                    MySQL_atualiza(SQL)
                End If

            End If

        End If
    End Sub

    Private Sub listaDelib11_04_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles listaDelib11_04.ItemCheck

        If _delibStatus = "Novo" Then
            'Insere...
            SQL =
                String.Format(
                    "INSERT INTO delib11_nf (anovigente, turma, nro_aluno) VALUES('{0}','{1}','{2}'); SELECT LAST_INSERT_ID() AS idFuncionarios;",
                    tAno.Value, _turmaNro, nrAluno_Delib11.Text)
            Dim novoDelibNf As Integer = MySQL_atualiza(SQL)

            ' Código da Categoria / Descrição...'
            SQL =
                String.Format("SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao WHERE descricao='{0}';",
                              listaDelib11_04.Text)
            Dim idDelibDes As Object = MySQL_consulta_campo(SQL, "idDelib_des")
            Dim idDelibCat As Object = MySQL_consulta_campo(SQL, "idDelib_cat")

            SQL =
                String.Format(
                    "INSERT INTO delib11_boletim (idDelibNF, idDelib_cat, idDelib_des, idUsuarioDSK) VALUES('{0}','{1}','{2}','{3}');",
                    novoDelibNf, idDelibCat, idDelibDes, idUsuarioDSK)
            MySQL_atualiza(SQL)

            _delibStatus = "Atualizar"
            _delibNf = novoDelibNf
            RefreshTurmas()
        ElseIf _delibStatus = "Atualizar" Then
            ' Código da Categoria / Descrição...'
            SQL =
                String.Format("SELECT idDelib_cat, idDelib_des, descricao FROM delib11_descricao WHERE descricao='{0}';",
                              listaDelib11_04.Text)
            Dim idDelibDes As Object = MySQL_consulta_campo(SQL, "idDelib_des")
            Dim idDelibCat As Object = MySQL_consulta_campo(SQL, "idDelib_cat")

            If e.State = CheckState.Checked Then
                SQL =
                    String.Format(
                        "INSERT INTO delib11_boletim (idDelibNF, idDelib_cat, idDelib_des, idUsuarioDSK) VALUES('{0}','{1}','{2}','{3}');",
                        _delibNf, idDelibCat, idDelibDes, idUsuarioDSK)
                MySQL_atualiza(SQL)

            ElseIf e.State = CheckState.Unchecked Then
                SQL =
                    String.Format(
                        "DELETE FROM delib11_boletim WHERE idDelibNF='{0}' AND idDelib_cat='{1}' AND idDelib_des='{2}';",
                        _delibNf, idDelibCat, idDelibDes)
                MySQL_atualiza(SQL)

                SQL = String.Format("SELECT COUNT(idDelibNF) AS DelibNF FROM delib11_boletim WHERE idDelibNF='{0}';",
                                    _delibNf)
                Dim contaRestantes As Object = MySQL_consulta_campo(SQL, "DelibNF")

                If contaRestantes = "0" Then
                    SQL = String.Format("DELETE FROM delib11_nf WHERE idDelibNF='{0}';", _delibNf)
                    MySQL_atualiza(SQL)
                End If

            End If

        End If
    End Sub

    Private Sub cbTurma_TextChanged(sender As Object, e As EventArgs) Handles cbTurma.TextChanged
    End Sub

    Private Sub viewFicha_RowClick(sender As Object, e As RowClickEventArgs) Handles viewFicha.RowClick

        Inicializacao()

        Dim View As GridView = sender
        Dim NotasVermelhas = View.GetRowCellDisplayText(e.RowHandle, View.Columns("NotasVermelhas"))
        Dim FichaNro As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("FichaNro"))
        Dim row As DataRow = viewFicha.GetDataRow(viewFicha.FocusedRowHandle)

        'Se for Aluno Regular (Sem notas Vermelhas)...
        If NotasVermelhas <> "0" Then
            If FichaNro <> "0" Then
                ' Preenchida...
                _delibStatus = "Atualizar"
            Else
                ' Falta Preencher...
                _delibStatus = "Novo"
            End If
            tbAluno_Delib11.Text = row(1).ToString
            nrAluno_Delib11.Text = row(0).ToString
            tbTurma_delib11.Text = cbTurma.Text
            Delib11_Preencher(_delibStatus, row(0).ToString)
            tabFichaCompleta.SelectTab(1)
        Else
            MsgBox("Este aluno não possue notas vermelhas!", MsgBoxStyle.Information, "Mais Escola!")
        End If
    End Sub

    Private Sub viewFicha_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewFicha.RowStyle

        If (e.RowHandle >= 0) Then
            Dim View As GridView = sender
            Dim NotasVermelhas As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("NotasVermelhas"))

            If NotasVermelhas <> "0" Then
                ' SIM... existe notas vermelhas...
                Dim FichaNro As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("FichaNro"))
                If FichaNro <> "0" Then
                    '... Preenchida...
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.BackColor2 = Color.White
                Else
                    '... Falta Preencher...
                    e.Appearance.BackColor = Color.Yellow
                    e.Appearance.BackColor2 = Color.White
                End If
            Else
                '... NAO existe notas vermelhas...
                e.Appearance.BackColor = Color.LightSkyBlue
                e.Appearance.BackColor2 = Color.White
            End If
        End If
    End Sub

    Private Sub viewBoletim_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewBoletim.RowStyle

        e.Appearance.BackColor = Color.LightSteelBlue
        e.Appearance.BackColor2 = Color.SeaShell
    End Sub

    Private Sub tAno_EditValueChanged(sender As Object, e As EventArgs) Handles tAno.EditValueChanged
        RefreshTurmas()
    End Sub

    Private Sub botaoConfiguracao_Click(sender As Object, e As EventArgs) Handles botaoConfiguracao.Click

        Dim fAdmDelib11 As New FrmAdmDelib11() With {.MdiParent = frmMaisEscola_Novo}
        fAdmDelib11.Show()

    End Sub

    Private Sub cbTurma_EditValueChanged(sender As Object, e As EventArgs) Handles cbTurma.EditValueChanged

        _turmaNome = cbTurma.Text
        _turmaNro = Consulta_Turma(_turmaNome)

        RefreshTurmas()

    End Sub
End Class