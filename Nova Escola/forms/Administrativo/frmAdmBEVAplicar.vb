
Imports System.ComponentModel

Public Class frmAdmBevAplicar
    Dim minhaDG As DataTable

    Dim _minhaTurma, _minhaDisciplina, _meuBimestre
    Dim ReadOnly _substCodNf(500)
    Dim ReadOnly _substNroAluno(500)
    Dim ReadOnly _substStatus(500)
    Dim i = 0, NroTotalEncontrados = 0

    Private Sub frmAdmBEVAplicar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmAdmBEVAplicar"

        tAno.Value = AnoVigente
        tBimestre.Text = consultaBimestre()

        SQL = "SELECT disciplina FROM disciplinas WHERE bloqueado='0' AND disciplina<>'-' ORDER BY disciplina ASC;"
        cbDisciplina.Properties.DataSource = MySQL_combobox(SQL)
        cbDisciplina.Properties.DisplayMember = "disciplina"

        SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
        cbTurma.Properties.DataSource = MySQL_combobox(SQL)
        cbTurma.Properties.DisplayMember = "classe"
    End Sub

    Private Sub tBimestre_ValueChanged(sender As Object, e As EventArgs)

        If tBimestre.Value = 2 Or tBimestre.Value = 4 Then
            cbAF.Enabled = True
        Else
            cbAF.Enabled = False
        End If
    End Sub

    Private Sub btAplicar_Click(sender As Object, e As EventArgs) Handles btAplicar.Click


        Dim vStrMsg As String = MsgBox("Deseja substituir as notas atuais pela Evasão Escolar?", MsgBoxStyle.YesNo,
                                       "Informação!")
        If vStrMsg = MsgBoxResult.Yes Then

            btAplicar.Enabled = False
            i = 0
            bwAplicar.RunWorkerAsync()

        End If
        barraConsulta.Properties.Minimum = 0
        barraConsulta.Properties.Maximum = NroTotalEncontrados
    End Sub

    Private Sub cbTodas_CheckedChanged1(sender As Object, e As EventArgs) Handles cbTodas.CheckedChanged
        If cbTodas.Checked = True Then
            cbDisciplina.Enabled = False
        Else
            cbDisciplina.Text = String.Empty
            cbDisciplina.Enabled = True
        End If
    End Sub

    Private Sub cbAF_CheckedChanged1(sender As Object, e As EventArgs) Handles cbAF.CheckedChanged
        If cbAF.Checked = True Then
            tBimestre.Enabled = False
        Else
            tBimestre.Enabled = True
        End If
    End Sub

    Private Sub cbTurma_EditValueChanged(sender As Object, e As EventArgs) Handles cbTurma.EditValueChanged
        ' Pega o número da turma
        '
        _minhaTurma = Consulta_Turma(cbTurma.Text)
    End Sub

    Private Sub cbDisciplina_EditValueChanged(sender As Object, e As EventArgs) Handles cbDisciplina.EditValueChanged
        ' Pega o número da Disciplina
        '
        _minhaDisciplina = Consulta_Disciplina(cbDisciplina.Text)
    End Sub

    Private Sub btPesquisar_Click(sender As Object, e As EventArgs) Handles btPesquisar.Click

        Me.barraConsulta.Properties.DisplayFormat.FormatString = "Pesquisando"

        bwConsulta.RunWorkerAsync()
    End Sub

    Private Sub bwConsulta_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwConsulta.DoWork

        If cbAF.Checked = True Then
            _meuBimestre = tBimestre.Value & "AF"
        Else
            _meuBimestre = tBimestre.Value
        End If

        ' Mostra na datagrid a situação...
        If cbTodas.Checked = True Then
            '.. TODAS as disciplinas...
            SQL = "SELECT " _
                  & "disciplinas.disciplina AS Disciplina, " _
                  & "aluno.nro AS Nro, " _
                  & "aluno.nome AS Nome, " _
                  & "aluno.status AS Status, " _
                  & "EvasaoEscolar(boletim.M) AS AV, " _
                  & "notasfreq.cod_nf AS NF " _
                  & "FROM " _
                  & "aluno " _
                  & "INNER JOIN notasfreq ON aluno.anovigente = notasfreq.anovigente AND aluno.turma = notasfreq.turma " _
                  & "INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim AND boletim.nro_aluno = aluno.nro " _
                  & "INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc " _
                  & "WHERE aluno.anovigente='" & tAno.Value & "' AND notasfreq.cod_bimestre='" & _meuBimestre &
                  "' AND aluno.turma='" & _minhaTurma &
                  "' AND aluno.status<>'0' AND EvasaoEscolar(boletim.M)<>aluno.status ORDER BY disciplina, nro ASC;"
        Else
            '.. SOMENTE a disciplina...
            SQL = "SELECT " _
                  & "disciplinas.disciplina AS Disciplina, " _
                  & "aluno.nro AS Nro, " _
                  & "aluno.nome AS Nome, " _
                  & "aluno.status AS Status, " _
                  & "EvasaoEscolar(boletim.M) AS AV, " _
                  & "notasfreq.cod_nf AS NF " _
                  & "FROM " _
                  & "aluno " _
                  & "INNER JOIN notasfreq ON aluno.anovigente = notasfreq.anovigente AND aluno.turma = notasfreq.turma " _
                  & "INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim AND boletim.nro_aluno = aluno.nro " _
                  & "INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc " _
                  & "WHERE aluno.anovigente='" & tAno.Value & "' AND notasfreq.cod_bimestre='" & _meuBimestre &
                  "' AND aluno.turma='" & _minhaTurma & "' AND notasfreq.disciplina='" & _minhaDisciplina &
                  "' AND aluno.status<>'0' AND EvasaoEscolar(boletim.M)<>aluno.status ORDER BY nro ASC;"
        End If

        If _minhaTurma <> "0" Then

            Array.Clear(_substCodNf, 0, 500)
            Array.Clear(_substNroAluno, 0, 500)
            Array.Clear(_substStatus, 0, 500)

            minhaDG = MySQL_consulta_datagrid2(SQL)

        Else
            btAplicar.Enabled = False
        End If
    End Sub

    Private Sub bwConsulta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwConsulta.RunWorkerCompleted

        Dim i = 0

        gridEvasao.DataSource = Nothing
        gridEvasao.DataSource = minhaDG

        Try
            viewEvasao.Columns(0).Width = 80
            viewEvasao.Columns(1).Width = 20
            viewEvasao.Columns(2).Width = 150
            viewEvasao.Columns(3).Width = 40
            viewEvasao.Columns(4).Width = 30
            viewEvasao.Columns(5).Visible = False
        Catch ex As Exception
        End Try

        For Each r In minhaDG.Rows
            ' Verifica quais são os boletins, que estão em divergencia com a Lista Piloto
            '  r = minhaDG.Rows(i)
            ' If r("AV") <> r("Status") Then
            _substNroAluno(i) = r("Nro")
            _substStatus(i) = r("Status")
            _substCodNf(i) = r("NF")
            '   j = j + 1
            '  End If
            i = i + 1
        Next

        If i <> 0 Then
            btAplicar.Enabled = True
        Else
            btAplicar.Enabled = False
        End If

        Me.barraConsulta.Properties.DisplayFormat.FormatString = String.Format("Encontramos : {0} informações.", i)
        NroTotalEncontrados = i

        'barraConsulta.Value = 100
    End Sub

    Private Sub bwAplicar_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwAplicar.DoWork


        While (_substCodNf(i) <> Nothing)
            Dim Sql As String =
                    String.Format("UPDATE boletim SET M='{0}', F='0' WHERE cod_boletim='{1}' AND nro_aluno='{2}';",
                                  TesteEvasaoEscolar(_substStatus(i)), _substCodNf(i), _substNroAluno(i))
            MySQL_atualiza(Sql)
            i = i + 1
            bwAplicar.ReportProgress(i)

        End While
    End Sub

    Private Sub bwAplicar_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) _
        Handles bwAplicar.ProgressChanged
        Invoke(Sub()
                   Me.barraConsulta.Properties.DisplayFormat.FormatString = "Alterando: [ " & e.ProgressPercentage & " / " &
                                                                            NroTotalEncontrados & " ]"
                   Me.barraConsulta.EditValue = e.ProgressPercentage
               End Sub)
    End Sub

    Private Sub bwAplicar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles bwAplicar.RunWorkerCompleted

        gridEvasao.DataSource = Nothing

        If cbDisciplina.Text <> String.Empty Then
            arquivoLog("Boletim",
                       "Substituiu as notas pela Evasão Escolar de " & tAno.Text & "-" & _meuBimestre & "o bimestre - [" &
                       cbTurma.Text & "] : [" & cbDisciplina.Text & "]")
        Else
            arquivoLog("Boletim",
                       "Substituiu as notas pela Evasão Escolar de " & tAno.Text & "-" & _meuBimestre & "o bimestre - [" &
                       cbTurma.Text & "] : Todas as Disciplinas")
        End If

        If i = 1 Then
            Me.barraConsulta.Properties.DisplayFormat.FormatString = (String.Format("[ {0} ] alteração concluída!", i))

        Else
            Me.barraConsulta.Properties.DisplayFormat.FormatString =
                (String.Format("[ {0} ] alterações concluídas!", i))

        End If
    End Sub
End Class