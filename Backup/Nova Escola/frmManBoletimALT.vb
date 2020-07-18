Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.Data.SqlClient

Public Class frmManBoletimALT

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

    Dim myCommand22 As New MySqlCommand()
    Dim myAdapter22 As New MySqlDataAdapter()
    Dim myData22 As New DataTable()

    Dim r22 As DataRow
    Dim rc22 As Integer
    Dim SQL22 As String

    Dim myCommand222 As New MySqlCommand()
    Dim myAdapter222 As New MySqlDataAdapter()
    Dim myData222 As New DataTable()

    Dim r222 As DataRow
    Dim rc222 As Integer
    Dim SQL222 As String

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

    Dim SQL5 As String
    Dim estadono
    Dim BD_OK, IP_OK, imagem_OK

    Private dv As DataView
    Private cm As CurrencyManager
    Private Sub frmConVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")



            BD_OK = BD
            IP_OK = IP



        Catch ex As Exception
        End Try

        '''''''''''''CARREGA INICIALMENTE''''''''''''
        Dim conn As MySqlConnection
        conn = New MySqlConnection()

        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        SQL = "SELECT b.nro_aluno, b.M, b.F, b.AC, b.S, t.fundamental FROM " & BD_OK & ".boletim b, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE b.cod_boletim=n.cod_nf AND t.codigo_trma=n.turma AND d.codigo_disc=n.disciplina AND b.cod_boletim=" & XBoletim.Text & ";"

        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                myData.Columns(0).ColumnName = "Nro"
                myData.Columns(1).ColumnName = "Avaliação"
                myData.Columns(2).ColumnName = "Faltas"
                myData.Columns(3).ColumnName = "AC"
                myData.Columns(4).ColumnName = "Recuperação"
                myData.Columns(5).ColumnMapping = MappingType.Hidden
                DGBoletim.DataSource = myData

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

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        If (tbMedia.Text = "" Or tbFaltas.Text = "" Or tbSN.Text = "") Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else

            If (tbSN.Text = "S" Or tbSN.Text = "N") Then

                Dim cidade
                Dim trava = 0

                Dim SacarData As DateTime = DateTime.Now
                Dim data

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                cidade = tbMedia.Text()

                Dim conn2 As MySqlConnection
                conn2 = New MySqlConnection()
                conn2.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                Try
                    conn2.Open()
                    Try

                        Dim cbarras
                        Dim cMedia, cFalta, cSN
                        Dim sMedia, sFalta

                        cMedia = tbMedia.Text
                        cFalta = tbFaltas.Text
                        cSN = tbSN.Text

                        'Codigo de Barras
                        If cMedia.Length = "1" Then
                            sMedia = "*" & tbMedia.Text & "  "
                        Else
                            sMedia = "*" & tbMedia.Text & " "
                        End If

                        If cFalta.Length = "1" Then
                            sFalta = "" & tbFaltas.Text & "  "
                        Else
                            sFalta = "" & tbFaltas.Text & " "
                        End If

                        cbarras = "" & sMedia & "" & sFalta & "" & tbSN.Text & "*"


                        SQL2 = "UPDATE " & BD_OK & ".codigobarras SET descricao='" & cbarras & "' WHERE cod_nf=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text
                        myCommand2.Connection = conn2
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        Dim porcentagem As Integer
                        Dim F, AULAS

                        F = tbFaltas.Text
                        AULAS = qtdadeaulas.Text
                        porcentagem = ((F * 100) / AULAS)


                        If tbMedia.Text = "TR" Or tbMedia.Text = "Tr" Or tbMedia.Text = "tr" Then
                            tbMedia.Text = "11"

                        ElseIf tbMedia.Text = "AB" Or tbMedia.Text = "Ab" Or tbMedia.Text = "ab" Then
                            tbMedia.Text = "12"

                        ElseIf tbMedia.Text = "LS" Or tbMedia.Text = "Ls" Or tbMedia.Text = "ls" Then
                            tbMedia.Text = "13"

                        ElseIf tbMedia.Text = "LG" Or tbMedia.Text = "Lg" Or tbMedia.Text = "lg" Then
                            tbMedia.Text = "14"

                        ElseIf tbMedia.Text = "RE" Or tbMedia.Text = "Re" Or tbMedia.Text = "re" Then
                            tbMedia.Text = "15"

                        ElseIf tbMedia.Text = "FA" Or tbMedia.Text = "Fa" Or tbMedia.Text = "fa" Then
                            tbMedia.Text = "16"
                        End If

                        SQL5 = "UPDATE " & BD_OK & ".boletim SET F=" & tbFaltas.Text & ", M=" & tbMedia.Text & ", S='" & tbSN.Text & "', porcentagem='" & porcentagem & "' WHERE cod_boletim=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text
                        myCommand5.Connection = conn2
                        myCommand5.CommandText = SQL5
                        myAdapter5.SelectCommand = myCommand5
                        myAdapter5.Fill(myData5)

                        MsgBox("Aluno " & lbCodigo.Text & " foi atualizado com sucesso!", MsgBoxStyle.Information, "Atualizado")

                        lbCodigo.Text = ""
                        tbMedia.Text = ""
                        tbFaltas.Text = ""
                        tbAC.Text = ""
                        tbSN.Text = ""

                        myData.Clear()
                        myData.Columns.Clear()

                        SQL = "SELECT b.nro_aluno, b.M, b.F, b.AC, b.S FROM " & BD_OK & ".boletim b, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE b.cod_boletim=n.cod_nf AND t.codigo_trma=n.turma AND d.codigo_disc=n.disciplina AND b.cod_boletim=" & XBoletim.Text & ";"
                        myCommand.Connection = conn2
                        myCommand.CommandText = SQL
                        myAdapter.SelectCommand = myCommand
                        myAdapter.Fill(myData)
                        myData.Columns(0).ColumnName = "Nro"
                        myData.Columns(1).ColumnName = "Avaliação"
                        myData.Columns(2).ColumnName = "Faltas"
                        myData.Columns(3).ColumnName = "AC"
                        myData.Columns(4).ColumnName = "Recuperação"
                        ' myData.Columns(5).ColumnMapping = MappingType.Hidden
                        DGBoletim.DataSource = myData


                    Catch myerro As MySqlException
                        MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                    End Try
                    '           MessageBox.Show("Conexão aberta com sucesso")
                    conn2.Close()

                Catch myerro As MySqlException
                    MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Finally
                    conn2.Dispose()
                End Try
                ' FIM DA CONEXAO
            Else
                MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
                tbSN.Focus()
                Exit Sub

            End If
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Hide()

    End Sub

    Private Sub btAdicionarFUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionarFUN.Click
        If (tbMedia.Text = "" Or tbSN.Text = "") Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else


            If (tbSN.Text = "S" Or tbSN.Text = "N") Then

                Dim cidade
                Dim trava = 0

                Dim SacarData As DateTime = DateTime.Now
                Dim data

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                cidade = tbMedia.Text()
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                Try
                    conn.Open()
                    Try


                        If tbMedia.Text = "TR" Or tbMedia.Text = "Tr" Or tbMedia.Text = "tr" Then
                            tbMedia.Text = "11"

                        ElseIf tbMedia.Text = "AB" Or tbMedia.Text = "Ab" Or tbMedia.Text = "ab" Then
                            tbMedia.Text = "12"

                        ElseIf tbMedia.Text = "LS" Or tbMedia.Text = "Ls" Or tbMedia.Text = "ls" Then
                            tbMedia.Text = "13"

                        ElseIf tbMedia.Text = "LG" Or tbMedia.Text = "Lg" Or tbMedia.Text = "lg" Then
                            tbMedia.Text = "14"

                        ElseIf tbMedia.Text = "RE" Or tbMedia.Text = "Re" Or tbMedia.Text = "re" Then
                            tbMedia.Text = "15"
                        End If

                        'SQL3 = "INSERT INTO " & BD_OK & ".boletim (cod_boletim, nro_aluno, M, F, S) values(" & lbBoletim.Text & "," & lbCodigo.Text & ", '" & tbMedia.Text & "', " & tbFaltas.Text & ", '" & tbSN.Text & "');"
                        SQL3 = "UPDATE " & BD_OK & ".boletim SET M='" & tbMedia.Text & "', S='" & tbSN.Text & "' WHERE cod_boletim='" & XBoletim.Text & "' AND nro_aluno='" & lbCodigo.Text & "';"

                        myCommand3.Connection = conn
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)


                        Dim cbarras

                        Dim cMedia, cSN
                        Dim sMedia

                        cMedia = tbMedia.Text

                        cSN = tbSN.Text

                        'Codigo de Barras                    'Espaços a Inserir
                        If cMedia.Length = "1" Then
                            sMedia = "*" & tbMedia.Text & "  "
                        Else
                            sMedia = "*" & tbMedia.Text & " "
                        End If

                        'If cFalta.Length = "1" Then
                        '    sFalta = "" & tbFaltas.Text & "  "
                        'Else
                        '    sFalta = "" & tbFaltas.Text & " "
                        'End If

                        cbarras = "" & sMedia & "" & tbSN.Text & "*"


                        'SQL2 = "INSERT INTO " & BD_OK & ".codigobarras (cod_nf, nro_aluno, descricao) values(" & lbBoletim.Text & ", " & lbCodigo.Text & ", '" & cbarras & "');"
                        SQL2 = "UPDATE " & BD_OK & ".boletim SET M='" & tbMedia.Text & "', S='" & tbSN.Text & "' WHERE cod_boletim=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text

                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        myData2.Clear()
                        SQL2 = "UPDATE " & BD_OK & ".codigobarras SET descricao='" & cbarras & "' WHERE cod_nf=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        MsgBox("Aluno " & lbCodigo.Text & " foi atualizado com sucesso!", MsgBoxStyle.Information, "Atualizado")

                        lbCodigo.Text = ""
                        tbMedia.Text = ""
                        tbFaltas.Text = ""
                        tbAC.Text = ""
                        tbSN.Text = ""

                        myData.Clear()
                        myData.Columns.Clear()

                        SQL = "SELECT b.nro_aluno, b.M, b.F, b.AC, b.S FROM " & BD_OK & ".boletim b, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE b.cod_boletim=n.cod_nf AND t.codigo_trma=n.turma AND d.codigo_disc=n.disciplina AND b.cod_boletim=" & XBoletim.Text & ";"
                        myCommand.Connection = conn
                        myCommand.CommandText = SQL
                        myAdapter.SelectCommand = myCommand
                        myAdapter.Fill(myData)
                        myData.Columns(0).ColumnName = "Nro"
                        myData.Columns(1).ColumnName = "Avaliação"
                        myData.Columns(2).ColumnName = "Faltas"
                        myData.Columns(3).ColumnName = "AC"
                        myData.Columns(4).ColumnName = "Recuperação"
                        '  myData.Columns(5).ColumnMapping = MappingType.Hidden
                        DGBoletim.DataSource = myData

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
                ' FIM DA CONEXAO
            Else
                MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
                tbSN.Focus()
                Exit Sub

            End If
        End If


    End Sub

    Private Sub DGBoletim_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGBoletim.MouseUp
        rc = DGBoletim.CurrentRowIndex
        r = myData.Rows(rc)

        lbCodigo.Text = ""
        tbMedia.Text = ""
        tbFaltas.Text = ""
        tbAC.Text = ""
        tbSN.Text = ""

        lbCodigo.Text = r("Nro")
        tbMedia.Text = r("Avaliação")
        tbFaltas.Text = r("Faltas")
        tbAC.Text = r("AC")
        tbSN.Text = r("Recuperação")
    End Sub

    Private Sub btAdicionar234_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar234.Click
        If (tbMedia.Text = "" Or tbFaltas.Text = "" Or tbSN.Text = "" Or tbAC.Text = "") Then
            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)
        Else

            myData.Clear()
            myData2.Clear()
            myData5.Clear()
            myData4.Clear()

            If (tbSN.Text = "S" Or tbSN.Text = "N") Then

                Dim cidade
                Dim trava = 0

                Dim SacarData As DateTime = DateTime.Now
                Dim data

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                cidade = tbMedia.Text()

                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                Try
                    conn.Open()
                    Try


                        Dim cbarras

                        Dim cMedia, cFalta, cSN
                        Dim sMedia, sFalta, cAC, sAC

                        cMedia = tbMedia.Text
                        cFalta = tbFaltas.Text
                        cSN = tbSN.Text
                        cAC = tbAC.Text

                        'Codigo de Barras                    'Espaços a Inserir
                        If cMedia.Length = "1" Then
                            sMedia = "*" & tbMedia.Text & "  "
                        Else
                            sMedia = "*" & tbMedia.Text & " "
                        End If

                        If cFalta.Length = "1" Then
                            sFalta = "" & tbFaltas.Text & "  "
                        Else
                            sFalta = "" & tbFaltas.Text & " "
                        End If

                        If cAC.Length = "1" Then
                            sAC = "" & tbAC.Text & " "
                        Else
                            sAC = "" & tbAC.Text & ""
                        End If

                        cbarras = "" & sMedia & "" & sFalta & "" & sAC & "" & tbSN.Text & "*"


                        If tbMedia.Text = "TR" Or tbMedia.Text = "Tr" Or tbMedia.Text = "tr" Then
                            tbMedia.Text = "11"

                        ElseIf tbMedia.Text = "AB" Or tbMedia.Text = "Ab" Or tbMedia.Text = "ab" Then
                            tbMedia.Text = "12"

                        ElseIf tbMedia.Text = "LS" Or tbMedia.Text = "Ls" Or tbMedia.Text = "ls" Then
                            tbMedia.Text = "13"

                        ElseIf tbMedia.Text = "LG" Or tbMedia.Text = "Lg" Or tbMedia.Text = "lg" Then
                            tbMedia.Text = "14"

                        ElseIf tbMedia.Text = "RE" Or tbMedia.Text = "Re" Or tbMedia.Text = "re" Then
                            tbMedia.Text = "15"

                        ElseIf tbMedia.Text = "FA" Or tbMedia.Text = "Fa" Or tbMedia.Text = "fa" Then
                            tbMedia.Text = "16"
                        End If

                        SQL2 = "UPDATE " & BD_OK & ".codigobarras SET descricao='" & cbarras & "' WHERE cod_nf=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text
                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        Dim porcentagem, F, AULAS As Integer

                        F = tbFaltas.Text
                        AULAS = qtdadeaulas.Text

                        porcentagem = ((F * 100) / AULAS)

                        SQL5 = "UPDATE " & BD_OK & ".boletim SET F=" & tbFaltas.Text & ", AC=" & tbAC.Text & ", M=" & tbMedia.Text & ", S='" & tbSN.Text & "', porcentagem=" & porcentagem & " WHERE cod_boletim=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text
                        myCommand5.Connection = conn
                        myCommand5.CommandText = SQL5
                        myAdapter5.SelectCommand = myCommand5
                        myAdapter5.Fill(myData5)

                        MsgBox("Aluno " & lbCodigo.Text & " foi atualizado com sucesso!", MsgBoxStyle.Information, "Atualizado")

                        tbMedia.Text = ""
                        tbAC.Text = ""
                        tbFaltas.Text = ""
                        tbSN.Text = ""


                        myData.Clear()
                        myData.Columns.Clear()

                        SQL = "SELECT b.nro_aluno, b.M, b.F, b.AC, b.S FROM " & BD_OK & ".boletim b, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE b.cod_boletim=n.cod_nf AND t.codigo_trma=n.turma AND d.codigo_disc=n.disciplina AND b.cod_boletim=" & XBoletim.Text & ";"
                        myCommand.Connection = conn
                        myCommand.CommandText = SQL
                        myAdapter.SelectCommand = myCommand
                        myAdapter.Fill(myData)
                        myData.Columns(0).ColumnName = "Nro"
                        myData.Columns(1).ColumnName = "Avaliação"
                        myData.Columns(2).ColumnName = "Faltas"
                        myData.Columns(3).ColumnName = "AC"
                        myData.Columns(4).ColumnName = "Recuperação"
                        '  myData.Columns(5).ColumnMapping = MappingType.Hidden
                        DGBoletim.DataSource = myData



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
                ' FIM DA CONEXAO
            Else
                MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
                tbSN.Focus()
                Exit Sub

            End If

        End If

    End Sub

    Private Sub btEJA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEJA.Click


        If (tbMedia.Text = "" Or tbSN.Text = "") Then

            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)

        Else

            If (tbSN.Text = "S" Or tbSN.Text = "N") Then

                Dim cidade
                Dim trava = 0

                Dim SacarData As DateTime = DateTime.Now
                Dim data

                data = Format(SacarData, "yyyy-MM-dd hh:mm:ss")

                cidade = tbMedia.Text()

                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                Try
                    conn.Open()
                    Try

                        SQL = "SELECT * FROM " & BD_OK & ".avaliacaofinal WHERE cod_nf=" & XBoletim.Text & " ORDER BY nro_aluno DESC"
                        myCommand.Connection = conn
                        myCommand.CommandText = SQL
                        myAdapter.SelectCommand = myCommand
                        myAdapter.Fill(myData)
                        r = myData.Rows(0)


                        If tbMedia.Text = "TR" Or tbMedia.Text = "Tr" Or tbMedia.Text = "tr" Then
                            tbMedia.Text = "11"

                        ElseIf tbMedia.Text = "AB" Or tbMedia.Text = "Ab" Or tbMedia.Text = "ab" Then
                            tbMedia.Text = "12"

                        ElseIf tbMedia.Text = "LS" Or tbMedia.Text = "Ls" Or tbMedia.Text = "ls" Then
                            tbMedia.Text = "13"

                        ElseIf tbMedia.Text = "LG" Or tbMedia.Text = "Lg" Or tbMedia.Text = "lg" Then
                            tbMedia.Text = "14"

                        ElseIf tbMedia.Text = "RE" Or tbMedia.Text = "Re" Or tbMedia.Text = "re" Then
                            tbMedia.Text = "15"
                        End If

                        'SQL3 = "INSERT INTO " & BD_OK & ".boletim (cod_boletim, nro_aluno, M, F, S) values(" & lbBoletim.Text & "," & lbCodigo.Text & ", '" & tbMedia.Text & "', " & tbFaltas.Text & ", '" & tbSN.Text & "');"
                        SQL3 = "UPDATE " & BD_OK & ".avaliacaofinal SET M='" & tbMedia.Text & "', S='" & tbSN.Text & "' WHERE cod_nf='" & XBoletim.Text & "' AND nro_aluno='" & lbCodigo.Text & "';"

                        myCommand3.Connection = conn
                        myCommand3.CommandText = SQL3
                        myAdapter3.SelectCommand = myCommand3
                        myAdapter3.Fill(myData3)


                        Dim cbarras

                        Dim cMedia, cSN
                        Dim sMedia

                        cMedia = tbMedia.Text

                        cSN = tbSN.Text

                        'Codigo de Barras                    'Espaços a Inserir
                        If cMedia.Length = "1" Then
                            sMedia = "*" & tbMedia.Text & "  "
                        Else
                            sMedia = "*" & tbMedia.Text & " "
                        End If

                        'If cFalta.Length = "1" Then
                        '    sFalta = "" & tbFaltas.Text & "  "
                        'Else
                        '    sFalta = "" & tbFaltas.Text & " "
                        'End If

                        cbarras = "" & sMedia & "" & tbSN.Text & "*"


                        'SQL2 = "INSERT INTO " & BD_OK & ".codigobarras (cod_nf, nro_aluno, descricao) values(" & lbBoletim.Text & ", " & lbCodigo.Text & ", '" & cbarras & "');"
                        SQL2 = "UPDATE " & BD_OK & ".avaliacaofinal SET descricao='" & cbarras & "' WHERE cod_nf=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text

                        myCommand2.Connection = conn
                        myCommand2.CommandText = SQL2
                        myAdapter2.SelectCommand = myCommand2
                        myAdapter2.Fill(myData2)

                        ' SQL22 = "UPDATE " & BD_OK & ".boletim SET descricao='" & cbarras & "' WHERE cod_nf=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text
                        SQL22 = "UPDATE " & BD_OK & ".boletim SET F=" & tbFaltas.Text & ", AC=" & tbAC.Text & ", M=" & tbMedia.Text & ", S='" & tbSN.Text & "' WHERE cod_boletim=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text

                        myCommand22.Connection = conn
                        myCommand22.CommandText = SQL22
                        myAdapter22.SelectCommand = myCommand22
                        myAdapter22.Fill(myData22)

                        ' SQL22 = "UPDATE " & BD_OK & ".boletim SET descricao='" & cbarras & "' WHERE cod_nf=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text
                        SQL222 = "UPDATE " & BD_OK & ".codigobarras SET descricao='" & cbarras & "' WHERE cod_nf=" & XBoletim.Text & " AND nro_aluno=" & lbCodigo.Text

                        myCommand222.Connection = conn
                        myCommand222.CommandText = SQL222
                        myAdapter222.SelectCommand = myCommand222
                        myAdapter222.Fill(myData222)


                        'MsgBox("Aluno " & lbCodigo.Text & " foi atualizado com sucesso!", MsgBoxStyle.Information, "Atualizado")

                        tbMedia.Text = ""
                        tbAC.Text = ""
                        tbFaltas.Text = ""
                        tbSN.Text = ""


                        myData.Clear()
                        myData.Columns.Clear()

                        SQL = "SELECT b.nro_aluno, b.M, b.F, b.AC, b.S FROM " & BD_OK & ".boletim b, " & BD_OK & ".notasfreq n, " & BD_OK & ".turma t, " & BD_OK & ".disciplinas d WHERE b.cod_boletim=n.cod_nf AND t.codigo_trma=n.turma AND d.codigo_disc=n.disciplina AND b.cod_boletim=" & XBoletim.Text & ";"
                        myCommand.Connection = conn
                        myCommand.CommandText = SQL
                        myAdapter.SelectCommand = myCommand
                        myAdapter.Fill(myData)
                        myData.Columns(0).ColumnName = "Nro"
                        myData.Columns(1).ColumnName = "Avaliação"
                        myData.Columns(2).ColumnName = "Faltas"
                        myData.Columns(3).ColumnName = "AC"
                        myData.Columns(4).ColumnName = "Recuperação"
                        '  myData.Columns(5).ColumnMapping = MappingType.Hidden
                        DGBoletim.DataSource = myData


                        
                        tbMedia.Focus()


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
                ' FIM DA CONEXAO
            Else
                MsgBox("Por favor, verifique os campos.", MsgBoxStyle.Critical, "Atenção!")
                tbSN.Focus()
                Exit Sub

            End If
        End If

    End Sub
End Class