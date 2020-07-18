Imports MySql.Data.MySqlClient

Public Class frmManDisciplinas

    Dim EuCliquei = 0

    Private Sub frmCaddisciplina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                myData.Clear()
                myData.Columns.Clear()
                SQL = "SELECT Disciplina, Bloqueado, codigo_disc FROM disciplinas c ORDER BY Disciplina;"
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                myData.Columns(1).ColumnMapping = MappingType.Hidden
                myData.Columns(2).ColumnMapping = MappingType.Hidden
                DGDisciplina.DataSource = Nothing
                DGDisciplina.DataSource = myData

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

    Private Sub DGdisciplina_MouseUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGDisciplina.MouseUp

        EuCliquei = 1

        rc = DGDisciplina.CurrentRowIndex
        r = myData.Rows(rc)

        tbDisciplina.Text = ""
        cbBloqueia.Checked = False

        tbDisciplina.Text = r("disciplina")

        If r("bloqueado") = "0" Then
            cbBloqueia.Checked = False
        Else
            cbBloqueia.Checked = True
        End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        If EuCliquei = 0 Then

            'CADASTRAR disciplina
            If Not tbDisciplina.Text = "" Then

                If MsgBox("Efetuar o cadastro de: " & tbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Cadastro") = Windows.Forms.DialogResult.No Then
                    MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                    Exit Sub
                Else

                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD

                    myData.Clear()
                    myData.Columns.Clear()
                    SQL = "SELECT disciplina FROM disciplinas WHERE disciplina='" & tbDisciplina.Text & "';"
                    myCommand.Connection = conn
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)

                    Try
                        r = myData.Rows(0)
                        If r("disciplina") = tbDisciplina.Text Then
                            MsgBox("Já existe uma disciplina cadastrada, e não é permitida a duplicação", MsgBoxStyle.Critical, "Atenção!")

                            'REFRESH
                            myData.Clear()
                            myData.Columns.Clear()
                            SQL = "SELECT Disciplina, Bloqueado, codigo_disc FROM disciplinas c ORDER BY Disciplina;"
                            myCommand.Connection = conn
                            myCommand.CommandText = SQL
                            myAdapter.SelectCommand = myCommand
                            myAdapter.Fill(myData)
                            myData.Columns(1).ColumnMapping = MappingType.Hidden
                            myData.Columns(2).ColumnMapping = MappingType.Hidden
                            DGDisciplina.DataSource = Nothing
                            DGDisciplina.DataSource = myData

                            conn.Close()
                            conn.Dispose()
                            Exit Sub

                        End If
                    Catch ex As Exception
                    End Try

                    ''''INICIA ALTERACAO''''
                    Try

                        Dim iBloqueia = 0

                        If cbBloqueia.Checked = False Then
                            iBloqueia = 0
                        Else
                            iBloqueia = 1
                        End If

                        ''''''''''''''''''''''''INICIA A CADASTRO
                        Try

                            myData2.Clear()
                            myData2.Columns.Clear()
                            SQL2 = "INSERT INTO disciplinas (disciplina, bloqueado) values('" & tbDisciplina.Text & "', " & iBloqueia & ");"
                            atualizaMySQL(SQL2)

                            MsgBox("Inclusão feita com sucesso!", MsgBoxStyle.Information, "Alteração")

                            myData.Clear()
                            myData.Columns.Clear()
                            SQL = "SELECT Disciplina, Bloqueado, codigo_disc FROM disciplinas c ORDER BY Disciplina;"
                            myCommand.Connection = conn
                            myCommand.CommandText = SQL
                            myAdapter.SelectCommand = myCommand
                            myAdapter.Fill(myData)
                            myData.Columns(1).ColumnMapping = MappingType.Hidden
                            myData.Columns(2).ColumnMapping = MappingType.Hidden
                            DGDisciplina.DataSource = Nothing
                            DGDisciplina.DataSource = myData

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

                End If
            Else
                MsgBox("Não foi possível alterar, é necessário existir um disciplina para que seja feita a alteração.", MsgBoxStyle.Critical, "Atenção!")
            End If

        ElseIf EuCliquei = 1 Then
            EuCliquei = 0

            'ATUALIZAR disciplina
            If Not tbDisciplina.Text = "" Then

                If MsgBox("Efetuar a alteração de: " & tbDisciplina.Text & " ?", MsgBoxStyle.YesNo, "Alteração") = Windows.Forms.DialogResult.No Then
                    MsgBox("Operação Cancelada", MsgBoxStyle.Information, "Cancelada")
                    Exit Sub
                Else

                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = CONEXAOBD

                    'INICIA ALTERACAO
                    Try

                        Dim iBloqueia = 0

                        If cbBloqueia.Checked = False Then
                            iBloqueia = 0
                            tbDisciplina.Text = "-"
                        Else
                            iBloqueia = 1
                            tbDisciplina.Text = "-"
                        End If

                        ''''''''''''''''''''''''INICIA A ATUALIZACAO
                        Dim idisciplina = r("codigo_disc")

                        Try
                            
                            SQL2 = "UPDATE disciplinas SET disciplina='" & tbDisciplina.Text & "', bloqueado=" & iBloqueia & " WHERE codigo_disc=" & idisciplina
                            atualizaMySQL(SQL2)
                            MsgBox("Alteração completada com sucesso!", MsgBoxStyle.Information, "Alteração")

                            myData.Clear()
                            myData.Columns.Clear()
                            SQL = "SELECT Disciplina, Bloqueado, codigo_disc FROM disciplinas c ORDER BY Disciplina;"
                            myCommand.Connection = conn
                            myCommand.CommandText = SQL
                            myAdapter.SelectCommand = myCommand
                            myAdapter.Fill(myData)
                            myData.Columns(1).ColumnMapping = MappingType.Hidden
                            myData.Columns(2).ColumnMapping = MappingType.Hidden
                            DGDisciplina.DataSource = Nothing
                            DGDisciplina.DataSource = myData

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

                End If

            Else

                MsgBox("Não foi possível alterar.", MsgBoxStyle.Critical, "Atenção!")

            End If
        End If

        'Fecha a Janela
        Me.Close()

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub

End Class