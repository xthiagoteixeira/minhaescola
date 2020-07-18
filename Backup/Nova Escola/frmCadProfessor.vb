Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmCadProfessor

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

    Dim myCommand3 As New MySqlCommand()
    Dim myAdapter3 As New MySqlDataAdapter()
    Dim myData3 As New DataTable()

    Dim r3 As DataRow
    Dim rc3 As Integer

    Dim SQL3 As String

    Dim myCommand4 As New MySqlCommand()
    Dim myAdapter4 As New MySqlDataAdapter()
    Dim myData4 As New DataTable()

    Dim r4 As DataRow
    Dim rc4 As Integer

    Dim SQL4 As String

    Dim myCommand5 As New MySqlCommand()
    Dim myAdapter5 As New MySqlDataAdapter()
    Dim myData5 As New DataTable()

    Dim r5 As DataRow
    Dim rc5 As Integer
    Dim BD_OK, IP_OK, imagem_OK

    Dim SQL5 As String
    Dim estadono

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        Dim cidadeno = 0
        If cbTurma.Text = "" Or tbProfessor.Text = "" Then

            MsgBox("Antes de cadastrar, preencha os campos!", MsgBoxStyle.Critical, "Atenção!")

        Else

            Dim cidade
            Dim trava = 0

            Dim SacarData As DateTime = DateTime.Now
            Dim data

            data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

            myData.Clear()
            myData2.Clear()
            myData3.Clear()
            myData4.Clear()

            cidade = tbProfessor.Text

            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

            SQL = "SELECT * FROM " & BD_OK & ".aluno WHERE nome='" & cidade & "'"
            SQL2 = "SELECT * FROM " & BD_OK & ".aluno ORDER BY codigo_aluno DESC"
            SQL4 = "SELECT * FROM " & BD_OK & ".turma WHERE classe='" & cbTurma.Text & "'"

            Try
                conn.Open()
                Try
                    myCommand.Connection = conn
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)

                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)

                    myCommand4.Connection = conn
                    myCommand4.CommandText = SQL4
                    myAdapter4.SelectCommand = myCommand4
                    myAdapter4.Fill(myData4)

                    'r4 = myData2.Rows(0)

                    Try
                        r = myData.Rows(0)
                        If r("professor") = tbProfessor.Text Then
                            MsgBox("Já existe um aluno cadastrado, e não é permitida a duplicação", MsgBoxStyle.Critical, "Atenção!")
                            trava = 1
                        End If

                        r2 = myData2.Rows(0)
                        cidadeno = r2("codigo_aluno")
                        cidadeno = cidadeno + 1

                    Catch ex As Exception
                    End Try

                    If trava = 0 Then

                        Dim disciplina
                        r4 = myData4.Rows(0)
                        disciplina = r4("codigo_trma")
                        SQL3 = "INSERT INTO " & BD_OK & ".aluno (codigo_aluno, nome, turma, nro) values(" & cidadeno & ",'" & tbProfessor.Text & "', '" & disciplina & "', " & nroAluno.Value & ");"
                        myCommand3.Connection = conn
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)
                        lbCodigo.Text = cidadeno

                        MsgBox("" & tbProfessor.Text & " foi cadastrada com sucesso!", MsgBoxStyle.Information, "Cadastrado")
                        lbCodigo.Text = ""
                        tbProfessor.Text = ""
                        cbTurma.Text = ""

                    End If
                Catch myerro As MySqlException
                    '  MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                ' MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Finally
                conn.Dispose()
            End Try
            ' FIM DA CONEXAO
        End If

    End Sub

    Private Sub frmCadprofessor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")
            Dim Imagem As Object = myRegKey2.GetValue("x")


            BD_OK = BD
            IP_OK = IP
            imagem_OK = Imagem


        Catch ex As Exception
        End Try

        'busca disciplina
        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        Try
            conn.Open()
            Try
                SQL3 = "SELECT * FROM " & BD_OK & ".turma ORDER BY classe"
                myCommand3.Connection = conn
                myCommand3.CommandText = SQL3
                myAdapter3.SelectCommand = myCommand3
                myAdapter3.Fill(myData3)


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

        r3 = myData3.Rows(0)

        'Puxa a cidade
        For Each r3 In myData3.Rows
            If (r2("bloqueado") = 0) Then
                cbTurma.Items.Add(r3("classe"))
            End If
        Next

    End Sub

    Private Sub cbTurma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTurma.SelectedIndexChanged

    End Sub
End Class