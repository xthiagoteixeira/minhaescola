Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports Mais_Escola
Public Class frmGerencialBolMovel
    Dim meuClique
    Dim contadorTurmas = 0
    Dim montaTurma

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click

        myData.Clear()
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                SQL = "DELETE FROM notasfreq_prof WHERE grupo='9999';"
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

            Catch myerro As MySqlException
                '    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
        Me.Close()

    End Sub

    Private Sub cbCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmGerencialBolMovel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        myData.Clear()
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                SQL = "DELETE FROM notasfreq_prof WHERE grupo='9999';"
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

            Catch myerro As MySqlException
                '    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub frmGerencialBolMovel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myData.Clear()
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                SQL = "SELECT * FROM turma WHERE bloqueado=0 ORDER BY classe"
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                r = myData.Rows(0)
                For Each r In myData.Rows
                    If (r("bloqueado") = 0) Then
                        cbTurma.Items.Add(r("classe"))
                    End If
                Next

                myData3.Clear()
                SQL3 = "SELECT * FROM disciplinas ORDER BY disciplina"
                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)

                r3 = myData3.Rows(0)
                For Each r3 In myData3.Rows
                    If (r3("disciplina") <> "-") Then
                        cbDisciplina.Items.Add(r3("disciplina"))
                    End If
                Next

            Catch myerro As MySqlException
                '    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btMais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMais.Click
        Dim MinhaNF = 0
        Dim MeuBimestre = ""

        If cbTurma.Text = "" Then

            MsgBox("Escolha uma turma!", MsgBoxStyle.Critical)

        Else

            ButtonX1.Enabled = True

            If cbAF.Checked = True And tBimestre.Value = 2 Then
                MeuBimestre = "2AF"
            ElseIf cbAF.Checked = True And tBimestre.Value = 4 Then
                MeuBimestre = "4AF"
            Else
                MeuBimestre = tBimestre.Value
            End If

            myData2.Clear()
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = CONEXAOBD

            Try
                conn.Open()
                Try

                    SQL2 = "SELECT notasfreq.anovigente," _
                    & "disciplinas.disciplina, " _
                    & "turma.classe, " _
                    & "notasfreq.cod_bimestre, " _
                    & "notasfreq.cod_nf AS NF " _
                    & "FROM " _
                    & "notasfreq " _
                    & "INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma) " _
                    & "INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) " _
                    & "WHERE disciplinas.disciplina='" & cbDisciplina.Text & "' AND turma.classe='" & cbTurma.Text & "' AND notasfreq.anovigente='" & tAno.Value & "' AND notasfreq.cod_bimestre='" & MeuBimestre & "';"

                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    Try
                        r2 = myData2.Rows(0)
                        MinhaNF = r2("NF")
                    Catch ex As IndexOutOfRangeException
                        MsgBox("Não possui boletim cadastrado!", MsgBoxStyle.Critical)
                        conn.Close()
                        conn.Dispose()
                        Exit Sub
                    End Try

                    'ADICIONA A TURMA/DISCIPLINA NA LISTA...
                    'GrupoTemporario = 99
                    myData.Clear()
                    Dim DataLancamento = Format(Date.Now, "yyyy-MM-dd")
                    SQL = "INSERT INTO notasfreq_prof (data_lancamento, grupo, cod_nf) values('" & DataLancamento & "','9999','" & MinhaNF & "');"
                    atualizaMySQL(SQL)

                    myData4.Clear()
                    SQL4 = "SELECT " _
                    & "  turma.classe AS Turma," _
                    & "  disciplinas.disciplina AS Disciplina," _
                    & "  notasfreq_prof.grupo," _
                    & "  notasfreq_prof.cod_nf" _
                    & " FROM" _
                    & " notasfreq" _
                    & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                    & " INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc)" _
                    & " INNER JOIN notasfreq_prof ON (notasfreq.cod_nf = notasfreq_prof.cod_nf)" _
                    & " WHERE notasfreq_prof.grupo='9999';"

                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)

                    DGGrupo.DataSource = myData4
                    DGGrupo.Columns(0).Width = "90"
                    DGGrupo.Columns(1).Width = "120"
                    DGGrupo.Columns(2).Visible = False
                    DGGrupo.Columns(3).Visible = False

                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        '### MSGBOX SIM E NAO ###
        Dim vStrMsg As String = _
         MsgBox("Deseja imprimir o boletim?", MsgBoxStyle.YesNo, "Atenção!")
        If vStrMsg = MsgBoxResult.Yes Then
            'PASSA VARIAVEL PARA RPT COM O CODIGO NOVO DO PROFESSOR (GRUPO NOTASFREQ_PROF)
            frmRpt.lbParametro.Text = "ConsolidadoProfessor"
            frmRpt.Show()
        End If
    End Sub

    Private Sub btMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMenos.Click

        myData.Clear()
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                SQL = "DELETE FROM notasfreq_prof WHERE cod_nf='" & meuClique & "' AND grupo='9999';"
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                DGGrupo.DataSource = Nothing
                myData4.Clear()
                SQL4 = "SELECT " _
                & "  turma.classe AS Turma," _
                & "  disciplinas.disciplina AS Disciplina," _
                & "  notasfreq_prof.grupo," _
                & "  notasfreq_prof.cod_nf" _
                & " FROM" _
                & " notasfreq" _
                & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                & " INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc)" _
                & " INNER JOIN notasfreq_prof ON (notasfreq.cod_nf = notasfreq_prof.cod_nf)" _
                & " WHERE notasfreq_prof.grupo='9999';"

                myCommand4.Connection = conn
                myCommand4.CommandText = SQL4
                myAdapter4.SelectCommand = myCommand4
                myAdapter4.Fill(myData4)

                DGGrupo.DataSource = myData4
                DGGrupo.Columns(0).Width = "90"
                DGGrupo.Columns(1).Width = "120"
                DGGrupo.Columns(2).Visible = False
                DGGrupo.Columns(3).Visible = False

            Catch myerro As MySqlException
                '    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            'MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub cbAF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAF.CheckedChanged
        If tBimestre.Value = 1 Or tBimestre.Value = 3 Then
            tBimestre.Enabled = True
        Else
            tBimestre.Enabled = False
        End If
    End Sub

    Private Sub DGGrupo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGGrupo.CellClick
        btMenos.Enabled = True
        meuClique = DGGrupo.CurrentRow.Cells(3).Value.ToString

    End Sub
End Class