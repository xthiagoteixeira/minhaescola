Imports CrystalDecisions.CrystalReports.Engine
Imports DevExpress.Pdf
Imports DevExpress.XtraPrinting
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Compression
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text
Module mdlMaisEscola
    Private ReadOnly Vector() As Byte = {&H12, &H44, &H16, &HEE, &H88, &H15, &HDD, &H41}

    Public NotInheritable Class Simple3Des

        Private ReadOnly TripleDes As New TripleDESCryptoServiceProvider

        Sub New(ByVal passprog As String)
            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash(passprog, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash(String.Empty, TripleDes.BlockSize \ 8)
        End Sub

        Private Function TruncateHash(
          ByVal key As String,
          ByVal length As Integer) As Byte()

            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.
            Dim keyBytes() As Byte = Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        End Function

    End Class

    '\\ Fim do Temporario

    Private Sub backupBancoDados(NomeArquivo As String)

        Try

            'Cria o DUMP

            Dim Proc As System.Diagnostics.Process = New System.Diagnostics.Process()
            Dim LocalSalvar = String.Format("{0}.sql", NomeArquivo)
            'Dim LocalZipar = String.Format("{0}.zip", NomeArquivo)

            Proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Proc.StartInfo.FileName = "mysqldump.exe"
            'Proc.StartInfo.Arguments = String.Format(" -r {0} --user=admsuporte --password=admauxcli --host={1} -N {2}", LocalSalvar, IP, BD)
            'Proc.StartInfo.Arguments = String.Format(" -r {0} --user=admsuporte --password=admauxcli --host={1} --default-character-set=latin1 -N {2}", LocalSalvar, IP, BD)
            Proc.StartInfo.Arguments = String.Format(" -r {0} --user=admsuporte --password=admauxcli --host={1} --default-character-set=utf8 {2}", LocalSalvar, Preferencias(1), Preferencias(0))

            'Proc.StartInfo.Arguments = String.Format(" -r {0} --user=admsuporte --password=admauxcli --host={1} --default-character-set=utf8 --opt {2}", LocalSalvar, IP, BD)
            'Proc.StartInfo.Arguments = "--user=admsuporte --password=admauxcli --host=" & IP & " --port=3306 --default-character-set=utf8 --databases " & NomeDataBase & " -r " & LocalSalvar

            If Proc.Start() Then
                Proc.WaitForExit()
            End If

            'Comprimir...
            '\\\\\\\arquivoZip(LocalSalvar, LocalZipar)

            'Dim DadosArquivoOriginal As FileInfo = New FileInfo(String.Format("{0}", LocalSalvar))
            'Dim DadosArquivoDestino As FileInfo = New FileInfo(String.Format("{0}", LocalZipar))

            'Deleta o arquivo SQL
            'File.Delete(LocalSalvar)

        Catch ex As Exception
            MsgBox("ERRO:" & ex.Message)

        End Try

    End Sub

    Function Resultado_Porcentagem(Faltas As Double, AC As Double, QtdadeAulas As Double) As String

        If QtdadeAulas = 0 Or Faltas = 0 Then
            Return 0
        ElseIf AC > Faltas Then
            Return 0
        Else
            Dim Retorno As String = ((Faltas - AC) * 100) / QtdadeAulas
            Retorno = Retorno.Replace(",", ".").ToString
            Return Retorno
        End If

    End Function

    Sub Carrega_Fundo()

        Try

            '***Carrega Fundo de Tela
            Dim MeuFundo As String = LeArquivoINI(nome_arquivo_ini, "Ferramentas", "Fundo", MeuFundo)
            If MeuFundo = "0" Or MeuFundo = String.Empty Or MeuFundo = Nothing Then
                frmMaisEscola_Novo.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("Fundo1"), Image)
            ElseIf MeuFundo.Length <= 2 Then
                ' ... Acessa o Resource
                frmMaisEscola_Novo.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("Fundo" & MeuFundo), Image)
            Else
                ' ... Acessa o caminho da imagem
                frmMaisEscola_Novo.BackgroundImage = Image.FromFile(MeuFundo)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub arquivoZip(ByVal sourceFile As String, ByVal destinationFile As String)

        ' make sure the source file is there
        If File.Exists(sourceFile) = False Then
            Throw New FileNotFoundException
        End If

        ' Create the streams and byte arrays needed
        Dim buffer As Byte() = Nothing
        Dim sourceStream As FileStream = Nothing
        Dim destinationStream As FileStream = Nothing
        Dim compressedStream As GZipStream = Nothing

        Try
            ' Read the bytes from the source file into a byte array
            sourceStream = New FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.Read)

            ' Read the source stream values into the buffer
            buffer = New Byte(sourceStream.Length) {}
            Dim checkCounter As Integer = sourceStream.Read(buffer, 0, buffer.Length)

            ' Open the FileStream to write to
            destinationStream = New FileStream(destinationFile, FileMode.OpenOrCreate, FileAccess.Write)

            ' Create a compression stream pointing to the destiantion stream
            compressedStream = New GZipStream(destinationStream, CompressionMode.Compress, True)

            'Now write the compressed data to the destination file
            compressedStream.Write(buffer, 0, buffer.Length)

        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Erro: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Make sure we allways close all streams
            If Not (sourceStream Is Nothing) Then
                sourceStream.Close()
            End If
            If Not (compressedStream Is Nothing) Then
                compressedStream.Close()
            End If
            If Not (destinationStream Is Nothing) Then
                destinationStream.Close()
            End If
        End Try

    End Sub

    Public Sub arquivoUnzip(ByVal sourceFile As String, ByVal destinationFile As String)

        ' make sure the source file is there
        If File.Exists(sourceFile) = False Then
            Throw New FileNotFoundException
        End If

        ' Create the streams and byte arrays needed
        Dim sourceStream As FileStream = Nothing
        Dim destinationStream As FileStream = Nothing
        Dim decompressedStream As GZipStream = Nothing
        Dim quartetBuffer As Byte() = Nothing

        Try
            ' Read in the compressed source stream
            sourceStream = New FileStream(sourceFile, FileMode.Open)

            ' Create a compression stream pointing to the destiantion stream
            decompressedStream = New GZipStream(sourceStream, CompressionMode.Decompress, True)

            ' Read the footer to determine the length of the destiantion file
            quartetBuffer = New Byte(4) {}
            Dim position As Integer = CType(sourceStream.Length, Integer) - 4
            sourceStream.Position = position
            sourceStream.Read(quartetBuffer, 0, 4)
            sourceStream.Position = 0
            Dim checkLength As Integer = BitConverter.ToInt32(quartetBuffer, 0)

            Dim buffer(checkLength + 100) As Byte
            Dim offset As Integer = 0
            Dim total As Integer = 0

            ' Read the compressed data into the buffer
            While True
                Dim bytesRead As Integer = decompressedStream.Read(buffer, offset, 100)
                If bytesRead = 0 Then
                    Exit While
                End If
                offset += bytesRead
                total += bytesRead
            End While

            ' Now write everything to the destination file
            destinationStream = New FileStream(destinationFile, FileMode.Create)
            destinationStream.Write(buffer, 0, total)

            ' and flush everyhting to clean out the buffer
            destinationStream.Flush()

        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "An Error occured during compression", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Make sure we allways close all streams
            If Not (sourceStream Is Nothing) Then
                sourceStream.Close()
            End If
            If Not (decompressedStream Is Nothing) Then
                decompressedStream.Close()
            End If
            If Not (destinationStream Is Nothing) Then
                destinationStream.Close()
            End If
        End Try

    End Sub

    Sub arquivoLog(Categoria As String, Descricao As String)

        If Categoria = "Administrativo" Then
            SQL = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('{0}', '{1}', '1', '{2}');", Descricao, idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
        ElseIf Categoria = "Boletim" Then
            SQL = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('{0}', '{1}', '2', '{2}');", Descricao, idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
        ElseIf Categoria = "Erros" Then
            SQL = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('{0}', '{1}', '3', '{2}');", Descricao, idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
        ElseIf Categoria = "Relatorios" Then
            SQL = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('{0}', '{1}', '4', '{2}');", Descricao, idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
        ElseIf Categoria = "Transferencia" Then
            SQL = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('{0}', '{1}', '5', '{2}');", Descricao, idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
        ElseIf Categoria = "Deliberação 11" Then
            SQL = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('{0}', '{1}', '6', '{2}');", Descricao, idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
        End If
        MySQL_atualiza(SQL)

    End Sub

    Public Function pegaHTML(ByVal URL2)
        ' Retorna o HTML da URL informada
        Dim objWC As New System.Net.WebClient
        Return New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL2))
    End Function

    Sub LiberaPublicacao(Tabela As String)

        ' LIBERA NO boletimweb, PARA SINCRONIZAR...
        Dim SQL = String.Format("UPDATE boletimweb SET sincronizado='1' WHERE tabela='{0}';", Tabela)
        MySQL_atualiza(SQL)

    End Sub

    'Sub CarregaPreferencias()

    '    MeuCore_Configuracao.Configuracao("MaisEscola")

    '    Dim objStream As New FileStream(meucaminhorelatorio & "\cpSystem.dll", FileMode.Open)
    '    Dim Arq As New System.IO.StreamReader(objStream)

    '    Dim linhaTexto As String = Arq.ReadLine
    '    Dim iPref(10) As String
    '    Dim i = 0

    '    While linhaTexto <> Nothing
    '        iPref(i) = linhaTexto
    '        i = i + 1
    '        linhaTexto = Arq.ReadLine
    '    End While

    '    Arq.Close()

    '    BD = iPref(0)
    '    IP = iPref(1)
    '    URL = iPref(2)
    '    REVENDA = iPref(3)
    '    FONE = iPref(4)
    '    BANCO = iPref(5)

    '    CONEXAOBD = String.Format("server={0};user id=admsuporte;password=admauxcli;database={1};Allow User Variables=False;Convert Zero Datetime=true;", IP, BD)

    'End Sub

    ''Sub CarregaPreferencias()

    ''    Dim Retorno As String = MeuCore_Configuracao.ConfiguracaoPreferencias("MaisEscola")
    ''    Dim matriz As String() = Retorno.Split("|")

    ''    CONEXAOBD = matriz(0).ToString
    ''    IP = matriz(1).ToString
    ''    BD = matriz(2).ToString
    ''    URL = matriz(3).ToString
    ''    REVENDA = matriz(4).ToString
    ''    FONE = matriz(5).ToString
    ''    'BANCO = matriz(6).ToString

    ''End Sub

    Sub BoletimWeb_Status(Tabela As String, Status As Integer)
        ' SINCRONIZAR...
        SQL = String.Format("UPDATE boletimweb SET sincronizado='{0}' WHERE tabela='{1}';", Status, Tabela)
        MySQL_atualiza(SQL)

    End Sub

    Public Function consultaBimestre()

        'PUXA O BIMESTRE ATUAL...
        Dim atualBimestre = Format(Date.Now, "MM")

        If atualBimestre <= "05" Then
            atualBimestre = "1"
        ElseIf atualBimestre <= "07" Then
            atualBimestre = "2"
        ElseIf atualBimestre <= "10" Then
            atualBimestre = "3"
        ElseIf atualBimestre <= "12" Then
            atualBimestre = "4"
        End If

        Return atualBimestre

    End Function
    Public Function MySQL_foto(ByVal query As String, ByVal Logotipo_Relatorio As Object, ByVal FileSize As UInt32, ByVal rawData As Object)

        Dim rowsEffected As Integer = 0
        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(query, connection) With {.CommandTimeout = 600}
                connection.Open()
                cmd.Parameters.AddWithValue("@FileName", Logotipo_Relatorio)
                cmd.Parameters.AddWithValue("@FileSize", FileSize)
                cmd.Parameters.AddWithValue("@File", rawData)
                rowsEffected = cmd.ExecuteScalar()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return rowsEffected

    End Function
    Public Function MySQL_atualiza(ByVal query As String) As Integer

        Dim rowsEffected As Integer = 0

        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(query, connection) With {.CommandTimeout = 300}
                connection.Open()

                If query.Contains("LAST_INSERT_ID") Then
                    rowsEffected = cmd.ExecuteScalar
                Else
                    rowsEffected = cmd.ExecuteNonQuery
                End If
                '//SELECT LAST_INSERT_ID() AS idFuncionarios;
            End Using
        Catch ex As Exception
            rowsEffected = -1
            ' MsgBox(ex.Message)

        End Try

        Return rowsEffected

    End Function

    Public Function MySQL_atualiza_funcao(ByVal query As String) As Integer

        Dim CONEXAOATUALIZA = String.Format("DATABASE={0};SERVER={1};user id=root;password=adm2wer435mt", Preferencias(0), Preferencias(1))

        Dim rowsEffected As Integer = 0

        Try
            Using connection As New MySqlConnection(CONEXAOATUALIZA), cmd As New MySqlCommand(query, connection) With {.CommandTimeout = 300}
                connection.Open()

                If query.Contains("LAST_INSERT_ID") Then
                    rowsEffected = cmd.ExecuteScalar
                ElseIf query.Contains("FUNCTION") Then

                    Dim stsResult As Boolean = Nothing
                    Dim has As Integer = Nothing
                    Dim script As New MySqlScript(connection, SQL)
                    script.Delimiter = "$$"
                    Try
                        has = script.Execute()
                        If has > 0 Then stsResult = True
                    Catch ex As MySqlException
                        'MsgBox(ex.Message)
                    Finally
                        script.Delimiter = ";"
                    End Try
                    Return stsResult

                Else
                    rowsEffected = cmd.ExecuteNonQuery
                End If
                '//SELECT LAST_INSERT_ID() AS idFuncionarios;
            End Using
        Catch ex As Exception
            rowsEffected = -1
            'MsgBox(ex.Message)

        End Try

        Return rowsEffected


    End Function

    Public Function MySQL_fotoInsere(ByVal query As String, ByVal Logotipo_Relatorio As Object, ByVal FileSize As UInt32, ByVal rawData As Object)

        Dim rowsEffected As Integer = 0

        Try

            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(query, connection) With {.CommandTimeout = 300}
                connection.Open()
                cmd.Parameters.AddWithValue("@FileName", Logotipo_Relatorio)
                cmd.Parameters.AddWithValue("@FileSize", FileSize)
                cmd.Parameters.AddWithValue("@File", rawData)
                rowsEffected = cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return rowsEffected

    End Function

    Public Function MySQL_fotoAtualiza(ByVal query As String, ByVal Logotipo_Relatorio As Object, ByVal FileSize As UInt32, ByVal rawData As Object)

        Dim rowsEffected As Integer = 0

        Try

            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(query, connection) With {.CommandTimeout = 300}
                connection.Open()
                cmd.Parameters.AddWithValue("@FileName", Logotipo_Relatorio)
                cmd.Parameters.AddWithValue("@FileSize", FileSize)
                cmd.Parameters.AddWithValue("@File", rawData)
                rowsEffected = cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return rowsEffected

    End Function

    Public Function MySQL_datatable(ByVal query As String) As DataTable

        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataTable()

        myData.Clear()
        myData.Columns.Clear()

        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(query, connection) With {.CommandTimeout = 300}
                connection.Open()
                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)
            End Using
        Catch ex As Exception
        End Try

        Return myData

    End Function
    Public Function MySQL_dataset(ByVal query As String) As DataSet

        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataSet()

        myData.Clear()
        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(query, connection) With {.CommandTimeout = 300}
                connection.Open()
                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)
            End Using
        Catch ex As Exception
        End Try
        Return myData

    End Function
    Public Function MySQL_report(ByVal query As String) As DataTable

        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataTable()

        myData.Clear()
        myData.Columns.Clear()

        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(query, connection) With {.CommandTimeout = 900}
                connection.Open()
                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)
            End Using
        Catch ex As Exception
        End Try

        Return myData

    End Function

    Public Function TesteEvasaoEscolar(ByVal codigo As String)

        '// Nao esquecer de trocar NOTAMAXIMA, para que todos enxerguem, caso precise editar aqui.
        If IsNumeric(codigo) Then
            'Se for numero...

            If codigo = "11" Then
                codigo = "TR"
            ElseIf codigo = "12" Then
                codigo = "AB"
            ElseIf codigo = "13" Then
                codigo = "LS"
            ElseIf codigo = "14" Then
                codigo = "LG"
            ElseIf codigo = "15" Then
                codigo = "RE"
            ElseIf codigo = "16" Then
                codigo = "FA"
            ElseIf codigo = "17" Then
                codigo = "DI"
            ElseIf codigo = "18" Then
                codigo = "NA"
            ElseIf codigo = "19" Then
                codigo = "NC"
            ElseIf codigo = "20" Then
                codigo = "DM"
            ElseIf codigo = "21" Then
                codigo = "DT"
            ElseIf codigo = "22" Then
                codigo = "DP"
            ElseIf codigo = "23" Then
                codigo = "NF"
            ElseIf codigo = "24" Then
                codigo = "RM"
            ElseIf codigo = "25" Then
                codigo = "RC"
            ElseIf codigo = "26" Then
                codigo = "CE"
            ElseIf codigo = "27" Then
                codigo = "I"
            ElseIf codigo = "28" Then
                codigo = "R"
            ElseIf codigo = "29" Then
                codigo = "B"
            ElseIf codigo = "30" Then
                codigo = "MB"
            ElseIf codigo = "31" Then
                codigo = "OF"
            ElseIf codigo = "32" Then
                codigo = "CEEX"
            Else
                codigo = codigo
            End If

            Return codigo

        Else
            '...Se for escrita...

            If (codigo = ("TR") Or codigo = ("Tr") Or codigo = ("tr")) Then
                codigo = 11
            ElseIf (codigo = ("AB") Or codigo = ("Ab") Or codigo = ("ab")) Then
                codigo = 12
            ElseIf (codigo = ("LS") Or codigo = ("Ls") Or codigo = ("ls")) Then
                codigo = 13
            ElseIf (codigo = ("LG") Or codigo = ("Lg") Or codigo = ("lg")) Then
                codigo = 14
            ElseIf (codigo = ("RE") Or codigo = ("Re") Or codigo = ("re")) Then
                codigo = 15
            ElseIf (codigo = ("FA") Or codigo = ("Fa") Or codigo = ("fa")) Then
                codigo = 16
            ElseIf (codigo = ("DI") Or codigo = ("Di") Or codigo = ("di")) Then
                codigo = 17
            ElseIf (codigo = ("NA") Or codigo = ("Na") Or codigo = ("na")) Then
                codigo = 18
            ElseIf (codigo = ("NC") Or codigo = ("Nc") Or codigo = ("nc")) Then
                codigo = 19
            ElseIf (codigo = ("DM") Or codigo = ("Dm") Or codigo = ("dm")) Then
                codigo = 20
            ElseIf (codigo = ("DT") Or codigo = ("Dt") Or codigo = ("dt")) Then
                codigo = 21
            ElseIf (codigo = ("DP") Or codigo = ("Dp") Or codigo = ("dp")) Then
                codigo = 22
            ElseIf (codigo = ("NF") Or codigo = ("Nf") Or codigo = ("nf")) Then
                codigo = 23
            ElseIf (codigo = ("RM") Or codigo = ("Rm") Or codigo = ("rm")) Then
                codigo = 24
            ElseIf (codigo = ("RC") Or codigo = ("Rc") Or codigo = ("rc")) Then
                codigo = 25
            ElseIf (codigo = ("CE") Or codigo = ("Ce") Or codigo = ("ce")) Then
                codigo = 26
            ElseIf (codigo = ("I") Or codigo = ("i")) Then
                codigo = 27
            ElseIf (codigo = ("R") Or codigo = ("r")) Then
                codigo = 28
            ElseIf (codigo = ("B") Or codigo = ("b")) Then
                codigo = 29
            ElseIf (codigo = ("MB") Or codigo = ("Mb") Or codigo = ("mb")) Then
                codigo = 30
            ElseIf (codigo = ("OF") Or codigo = ("Of") Or codigo = ("of")) Then
                codigo = 31
            ElseIf (codigo = ("CEEX") Or codigo = ("Ceex")) Then
                codigo = 32
            Else
                codigo = codigo
            End If

            Return codigo

        End If

    End Function

    Public Function TesteEvasaoEscolar_Nome(SituacaoAluno As String)

        Dim Tamanho As String = SituacaoAluno.Length

        If Tamanho <= 2 Then

            If SituacaoAluno.Contains("AB") Then
                SituacaoAluno = "Abandono"
            ElseIf SituacaoAluno.Contains("DI") Then
                SituacaoAluno = "Dispensa Idade"
            ElseIf SituacaoAluno.Contains("DM") Then
                SituacaoAluno = "Dispensa Médica"
            ElseIf SituacaoAluno.Contains("DP") Then
                SituacaoAluno = "Dispensa Prole"
            ElseIf SituacaoAluno.Contains("DT") Then
                SituacaoAluno = "Dispensa Trabalho"
            ElseIf SituacaoAluno.Contains("FA") Then
                SituacaoAluno = "Falecimento"
            ElseIf SituacaoAluno.Contains("LG") Then
                SituacaoAluno = "Licença Gestante"
            ElseIf SituacaoAluno.Contains("LS") Then
                SituacaoAluno = "Licença Saúde"
            ElseIf SituacaoAluno.Contains("NC") Then
                SituacaoAluno = "Não Compareceu"
            ElseIf SituacaoAluno.Contains("NF") Then
                SituacaoAluno = "Não Frequenta"
            ElseIf SituacaoAluno.Contains("RE") Then
                SituacaoAluno = "Reclassificado"
            ElseIf SituacaoAluno.Contains("TR") Then
                SituacaoAluno = "Transferido"
            ElseIf SituacaoAluno.Contains("RM") Then
                SituacaoAluno = "Remanejado"
            ElseIf SituacaoAluno.Contains("RC") Then
                SituacaoAluno = "Reclassificado"
            ElseIf SituacaoAluno.Contains("CE") Then
                SituacaoAluno = "Matrícula Cessada"
            ElseIf SituacaoAluno.Contains("CEEX") Then
                SituacaoAluno = "Cessão por exame"
            Else
                SituacaoAluno = "Frequente"
            End If

        Else

            If SituacaoAluno = "Abandonou" Or SituacaoAluno.Contains("ABAN") Then
                SituacaoAluno = "AB"
            ElseIf SituacaoAluno = "Dispensa Idade" Then
                SituacaoAluno = "DI"
            ElseIf SituacaoAluno = "Dispensa Médica" Then
                SituacaoAluno = "DM"
            ElseIf SituacaoAluno = "Dispensa Prole" Then
                SituacaoAluno = "DP"
            ElseIf SituacaoAluno = "Dispensa Trabalho" Then
                SituacaoAluno = "DT"
            ElseIf SituacaoAluno = "Falecimento" Or SituacaoAluno.Contains("FALE") Then
                SituacaoAluno = "FA"
            ElseIf SituacaoAluno = "Licença Gestante" Then
                SituacaoAluno = "LG"
            ElseIf SituacaoAluno = "Licença Saúde" Then
                SituacaoAluno = "LS"
            ElseIf SituacaoAluno.Contains("Não Comparecimento") Or SituacaoAluno.Contains("NCFP") Or SituacaoAluno.Contains("NCOM") Then
                SituacaoAluno = "NC"
            ElseIf SituacaoAluno = "Não Frequenta" Then
                SituacaoAluno = "NF"
            ElseIf SituacaoAluno = "Reclassificado" Or SituacaoAluno.Contains("RECL") Then
                SituacaoAluno = "RE"
            ElseIf (SituacaoAluno = "Transferido" Or SituacaoAluno.Contains("TR")) And Not SituacaoAluno.Contains("TRANSTORNO") Then
                SituacaoAluno = "TR"
            ElseIf SituacaoAluno = "Remanejado" Or SituacaoAluno.Contains("REMA") Then
                SituacaoAluno = "RM"
            ElseIf SituacaoAluno = "Reclassificado" Or SituacaoAluno.Contains("RECL") Then
                SituacaoAluno = "RC"
            ElseIf SituacaoAluno = "Matrícula Cessada" Then
                SituacaoAluno = "CE"
            ElseIf SituacaoAluno = "Cessão por exame" Then
                SituacaoAluno = "CEEX"
            Else
                SituacaoAluno = "0"
            End If

        End If

        Return SituacaoAluno

    End Function

    Function EvasaoEscolar(ByVal Ano As String, ByVal NroTurma As String, ByVal NroAluno As String) As String

        SQL = String.Format("SELECT status FROM aluno WHERE anovigente='{0}' AND turma='{1}' AND nro='{2}';", Ano, NroTurma, NroAluno)
        Return MySQL_consulta_campo(SQL, "status").ToString

    End Function

    Public Sub MensagemErro(ByVal Mensagem As String, ByVal Form As String, ByVal ErroGeral As Boolean, Tipo As String)

        ' MENSAGEM ERRO !
        Erro_Form = Form
        Erro_Mensagem = Mensagem
        Erro_BotaoTexto = Tipo

        If ErroGeral = True Then
            Erro_Enviar = True
            frmMaisEscola_Novo.WindowState = FormWindowState.Minimized
        Else
            Erro_Enviar = False
        End If
        frmErro.Show()

    End Sub

    ' Usa a função GetPrivateProfileString para obter os valores
    Function LeArquivoINI(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String

        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)

        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)

        Return string_builder.ToString()

    End Function

    ' Retorna o nome do arquivo INI
    Function nomeArquivoINI() As String

        ' Dim nome_arquivo_ini As String = Application.StartupPath
        ' nome_arquivo_ini = nome_arquivo_ini.Substring(0, nome_arquivo_ini.LastIndexOf("\"))
        Dim nome_arquivo_ini As String

        meucaminho = Environment.CurrentDirectory
        meucaminhorelatorio = Mid(meucaminho, 1, 3)
        meucaminhorelatorio = meucaminhorelatorio & "MaisEscola"

        nome_arquivo_ini = meucaminhorelatorio & "\maisescola.ini"

        Return nome_arquivo_ini

    End Function

    Function geraHash(ByVal valor As String) As String

        'Crria um objeto encoding para assegurar o encoding padrão para o texto fonte
        Dim Ue As New UnicodeEncoding()

        'Retorna um array de bytes baseado no texto fonte
        Dim ByteSourceText() As Byte = Ue.GetBytes(valor)

        'Instancia um objeto MD5
        Dim Md5 As New MD5CryptoServiceProvider()

        'Calcula o valor do hash para o texto
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)

        'Converte o valor para o formato string e retorna
        Return Convert.ToBase64String(ByteHash)

    End Function

    'Function Consulta_Turma_BuscaAluno(ByVal nometurma As String) As Integer

    '    'SQL = String.Format("SELECT codigo_trma FROM turma WHERE classe='{0}';", nometurma)
    '    SQL = String.Format("SELECT codigo_trma FROM turma WHERE classe REGEXP '{0}';", nometurma)
    '    Return MySQL_consulta_campo(SQL, "codigo_trma").ToString

    'End Function

    'Function Consulta_Disciplina_BuscaAluno(ByVal nomedisciplina As String) As Integer

    '    SQL = String.Format("SELECT codigo_disc FROM disciplinas WHERE disciplina REGEXP '{0}';", nomedisciplina)
    '    Return MySQL_consulta_campo(SQL, "codigo_disc").ToString

    'End Function


    Function Consulta_Turma(ByVal nometurma As String) As Integer

        'SQL = String.Format("SELECT codigo_trma FROM turma WHERE classe='{0}';", nometurma)
        SQL = String.Format("SELECT codigo_trma FROM turma WHERE classe LIKE '{0}';", nometurma)
        Return MySQL_consulta_campo(SQL, "codigo_trma").ToString

    End Function

    Function Consulta_Disciplina(ByVal nomedisciplina As String) As Integer

        SQL = String.Format("SELECT codigo_disc FROM disciplinas WHERE disciplina LIKE '{0}';", nomedisciplina)
        Return MySQL_consulta_campo(SQL, "codigo_disc").ToString

    End Function

    Function SoLetras(ByVal KeyAscii As Integer) As Integer

        Try
            ''Transformar letras minusculas em Maiúsculas
            'KeyAscii = Asc(UCase(Chr(KeyAscii)))
            ' Intercepta um código ASCII recebido e admite somente letras
            If InStr("abcdefghijklmnopqrstuvwxyz", Chr(KeyAscii)) = 0 Then
                SoLetras = 0
            Else
                SoLetras = KeyAscii
            End If

            ' teclas adicionais permitidas
            If KeyAscii = 8 Then SoLetras = KeyAscii ' Backspace
        Catch ex As Exception

        End Try

        Return SoLetras

    End Function

    Public Function MySQL_consulta_foto(ByVal SQL As String, ByVal Campo As String)

        Dim MinhaImagem As Image

        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataTable()
        Dim r As DataRow

        myData.Clear()
        myData.Columns.Clear()

        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(SQL, connection) With {.CommandTimeout = 30}
                connection.Open()
                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)

                Try
                    r = myData.Rows(0)
                    Dim Retorno = r(Campo)

                    Dim lb() As Byte = Retorno
                    Dim lstr As New MemoryStream(lb)
                    Dim x As Image = Image.FromStream(lstr)
                    MinhaImagem = x

                Catch ex As Exception
                End Try

            End Using

        Catch ex As Exception
        End Try

        Return MinhaImagem

    End Function

    Public Function MySQL_consulta_campo(SQL As String, Campo As String)

        Dim Retorno As String
        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataTable()
        Dim r As DataRow

        myData.Clear()
        myData.Columns.Clear()
        Try

            Try
                Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(SQL, connection) With {.CommandTimeout = 300}
                    connection.Open()
                    myAdapter.SelectCommand = cmd
                    myAdapter.Fill(myData)

                    Try
                        r = myData.Rows(0)
                        Retorno = r(Campo)
                        If (Retorno Is DBNull.Value) Or (Retorno Is Nothing) Or (Retorno = String.Empty) Then
                            Retorno = "0"
                        End If
                    Catch ex As Exception
                        Retorno = "0"
                    End Try
                End Using

            Catch ex As Exception
                Retorno = "0"
                'Retorno = "Sem conexão!"
            End Try
        Catch myerro As MySqlException
            Retorno = "0"
        End Try

        Return Retorno

    End Function

    Public Function MySQL_consulta_login(SQL As String, Campo As String)

        Dim Retorno As String
        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataTable()
        Dim r As DataRow

        myData.Clear()
        myData.Columns.Clear()
        Try

            Try
                Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(SQL, connection) With {.CommandTimeout = 5}
                    connection.Open()
                    myAdapter.SelectCommand = cmd
                    myAdapter.Fill(myData)

                    Try
                        r = myData.Rows(0)
                        Retorno = r(Campo)
                        If (Retorno Is DBNull.Value) Or (Retorno Is Nothing) Or (Retorno = String.Empty) Then
                            Retorno = "0"
                        End If
                    Catch ex As Exception
                    End Try
                End Using

            Catch ex As Exception

                MsgBox("Verifique:" & vbCrLf & "1 - Servidor desligador;" & vbCrLf &
                       "2 - Banco de dados / IP não definido em 'Ferramentas' na tela de login;" & vbCrLf &
                       "3 - Serviços / Firewall do Windows está ativado no Servidor;", MsgBoxStyle.Information,
                       "Sem conexão!")
            End Try
        Catch myerro As MySqlException
            Retorno = "0"
        End Try

        Return Retorno

    End Function

    Public Function MySQL_consulta_campo2(SQL As String, Campo As String)

        Dim Retorno2 As String
        Dim myAdapter2 As New MySqlDataAdapter()
        Dim myData2 As New DataTable()
        Dim r2 As DataRow

        myData2.Clear()
        myData2.Columns.Clear()
        Try

            Try
                Using connection2 As New MySqlConnection(CONEXAOBD), cmd2 As New MySqlCommand(SQL, connection2) With {.CommandTimeout = 300}
                    connection2.Open()
                    myAdapter2.SelectCommand = cmd2
                    myAdapter2.Fill(myData2)

                    Try
                        r2 = myData2.Rows(0)
                        Retorno2 = r2(Campo)
                        If (Retorno2 Is DBNull.Value) Or (Retorno2 Is Nothing) Or (Retorno2 = String.Empty) Then
                            Retorno2 = String.Empty
                        End If
                    Catch ex As Exception
                        Retorno2 = String.Empty
                    End Try
                End Using

            Catch ex As Exception
                Retorno2 = String.Empty
            End Try
        Catch myerro As MySqlException
            Retorno2 = String.Empty
        End Try

        Return Retorno2

    End Function

    Public Function MySQL_consulta_campo3(SQL As String, Campo As String)

        Dim Retorno3 As String
        Dim myAdapter3 As New MySqlDataAdapter()
        Dim myData3 As New DataTable()
        Dim r3 As DataRow

        myData3.Clear()
        myData3.Columns.Clear()
        Try

            Try
                Using connection3 As New MySqlConnection(CONEXAOBD), cmd3 As New MySqlCommand(SQL, connection3) With {.CommandTimeout = 300}
                    connection3.Open()
                    myAdapter3.SelectCommand = cmd3
                    myAdapter3.Fill(myData3)

                    Try
                        r3 = myData3.Rows(0)
                        Retorno3 = r3(Campo)
                        If (Retorno3 Is DBNull.Value) Or (Retorno3 Is Nothing) Or (Retorno3 = String.Empty) Then
                            Retorno3 = String.Empty
                        End If
                    Catch ex As Exception
                        Retorno3 = String.Empty
                    End Try
                End Using

            Catch ex As Exception
                Retorno3 = String.Empty
            End Try
        Catch myerro As MySqlException
            Retorno3 = String.Empty
        End Try

        Return Retorno3

    End Function


    Public Function MySQL_consulta_datagrid(SQL As String) As DataTable

        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataTable()
        myData.Clear()
        myData.Columns.Clear()

        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(SQL, connection) With {.CommandTimeout = 300}
                connection.Open()
                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)
            End Using

        Catch ex As Exception
            MsgBox("Mensagem: " & ex.Message, MsgBoxStyle.Information)
        End Try
        Return myData

    End Function

    Public Function MySQL_consulta_datagrid2(SQL As String) As DataTable

        Dim myAdapter2 As New MySqlDataAdapter()
        Dim myData2 As New DataTable()

        myData2.Clear()
        myData2.Columns.Clear()
        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(SQL, connection) With {.CommandTimeout = 300}
                connection.Open()
                myAdapter2.SelectCommand = cmd
                myAdapter2.Fill(myData2)
            End Using

        Catch ex As Exception
            MsgBox("Mensagem: " & ex.Message, MsgBoxStyle.Information)
        End Try
        Return myData2

    End Function

    Public Function MySQL_combobox(SQL As String) As DataTable

        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataTable()

        myData.Clear()
        myData.Columns.Clear()

        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(SQL, connection) With {.CommandTimeout = 300}
                connection.Open()
                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)
            End Using
        Catch ex As Exception
            Erro_Mensagem = ex.Message
            Dim fErro As New frmErro() With {.MdiParent = frmMaisEscola_Novo}
            fErro.Show()
        End Try
        Return myData

    End Function

    Public Sub Limpar(ByVal controlP As System.Windows.Forms.Control)

        Dim ctl As System.Windows.Forms.Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = String.Empty
            ElseIf ctl.Controls.Count > 0 Then
                Limpar(ctl)
            End If
        Next
    End Sub

    Friend Function meuRPT(ByVal SQL_Nome As String)

        '... Recebe o parametro para o Crystal Reports ...3
        '
        frmRpt_Parametro = SQL_Nome
        crReportDocument = New ReportDocument()

        Dim SQL2 = String.Empty

        If (SQL_Nome = "AdmHistoricoAuxiliar") Then

            SQL2 = String.Format("SELECT CONVERT(CONCAT(LPAD(aluno.nro, 2, '0'), '.', aluno.nome) USING utf8) AS nome, aluno.nro, aluno.ra, aluno.status AS situacao, escola.de, escola.nome AS nomeescola, file.file AS imagem, turma.classe, aluno.anovigente FROM aluno INNER JOIN turma ON (aluno.turma = turma.codigo_trma) , escola INNER JOIN file ON escola.idFile = file.file_id WHERE turma.bloqueado='0' AND aluno.anovigente='{0}';", frmRpt_anovigente)

            '# RELATORIO...
            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\HistoricoAuxiliar.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\HistoricoAuxiliar.rpt")
            Else
                crReportDocument = New HistoricoAuxiliar
            End If

        ElseIf (SQL_Nome = "DE") Then
            SQL2 = "SELECT e.nome AS escola, e.de, e.fones AS fone, e.endereco, f.file AS imagem, td.nome, td.ra, td.turma, td.observacao, td.horarioINICIO, td.horarioFIM, td.op1, td.op2, td.op3, td.op4, td.op5, td.op6, td.op7, td.op8 FROM tempdeclaracao td, escola e, file f WHERE td.idDeclaracao='1';"

            '# RELATORIO...
            '
            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\DE.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\DE.rpt")
            Else
                crReportDocument = New DE
            End If

        ElseIf (SQL_Nome = "AlunosReprovadosATA") Then

            If frmRpt_grupoTurma = 0 Then
                ' ESCOLHE TURMA...
                SQL2 = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, boletim.nro_aluno, boletim.M AS Avaliacao, boletim.F AS Faltas, boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, notasfreq.qtdadeaulas, turma.classe, rpt_atacompl.C1, rpt_atacompl.C2, rpt_atacompl.C3, rpt_atacompl.C4, rpt_atacompl.C5, rpt_atacompl.C6, rpt_atacompl.C7, rpt_atacompl.C8, rpt_atacompl.C9, rpt_atacompl.C10, rpt_atacompl.C11, rpt_atacompl.P1, rpt_atacompl.P2, rpt_atacompl.P3,rpt_atacompl.P4,rpt_atacompl.P5,rpt_atacompl.P6,rpt_atacompl.P7,rpt_atacompl.P8,rpt_atacompl.P9,rpt_atacompl.P10,rpt_atacompl.P11, rpt_atacompl.DataEscolhida FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), rpt_atacompl WHERE notasfreq.anovigente='{0}' AND aluno.anovigente='{0}' AND notasfreq.cod_bimestre='{1}';", frmRpt_anovigente, frmRpt_codigo)
            Else
                ' ESCOLHE TURMA...
                SQL2 = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, boletim.nro_aluno, boletim.M AS Avaliacao, boletim.F AS Faltas,  boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, notasfreq.qtdadeaulas, turma.classe, rpt_atacompl.C1, rpt_atacompl.C2, rpt_atacompl.C3,rpt_atacompl.C4,rpt_atacompl.C5,rpt_atacompl.C6,rpt_atacompl.C7,rpt_atacompl.C8,rpt_atacompl.C9,rpt_atacompl.C10,rpt_atacompl.C11,rpt_atacompl.P1,rpt_atacompl.P2,rpt_atacompl.P3,rpt_atacompl.P4,rpt_atacompl.P5,rpt_atacompl.P6,rpt_atacompl.P7,rpt_atacompl.P8,rpt_atacompl.P9,rpt_atacompl.P10,rpt_atacompl.P11, rpt_atacompl.DataEscolhida FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), rpt_atacompl WHERE notasfreq.anovigente='{0}' AND aluno.anovigente='{0}' AND notasfreq.turma='{1}' AND notasfreq.cod_bimestre='{2}';", frmRpt_anovigente, frmRpt_grupoTurma, frmRpt_codigo)
            End If

            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoReprovadosATA.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoReprovadosATA.rpt")
            Else
                crReportDocument = New ConsolidadoReprovadosATA
            End If

        ElseIf (SQL_Nome = "AlunosReprovadosATA2") Then

            ' ESCOLHE TURMA...
            SQL2 = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, boletim.nro_aluno, boletim.M AS Avaliacao, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, rpt_atacompl.C1, rpt_atacompl.C2, rpt_atacompl.C3,rpt_atacompl.C4,rpt_atacompl.C5,rpt_atacompl.C6,rpt_atacompl.C7,rpt_atacompl.C8,rpt_atacompl.C9,rpt_atacompl.C10,rpt_atacompl.C11,rpt_atacompl.P1,rpt_atacompl.P2,rpt_atacompl.P3,rpt_atacompl.P4,rpt_atacompl.P5,rpt_atacompl.P6,rpt_atacompl.P7,rpt_atacompl.P8,rpt_atacompl.P9,rpt_atacompl.P10,rpt_atacompl.P11, rpt_atacompl.DataEscolhida FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), rpt_atacompl WHERE notasfreq.anovigente='{0}' AND aluno.anovigente='{0}' AND notasfreq.turma='{1}' AND notasfreq.cod_bimestre='{2}';", frmRpt_anovigente, frmRpt_grupoTurma, frmRpt_codigo)

            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoReprovadosATA2.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoReprovadosATA2.rpt")
            Else
                crReportDocument = New ConsolidadoReprovadosATA2
            End If

        ElseIf (SQL_Nome = "Alunos") Then

            Try
                SQL2 = String.Format("SELECT d.disciplina, t.classe, p.nome, CONCAT(p.ra,'-',p.ra_digito) AS ra, r.C1, r.C2, r.C3, r.C4, r.C5,r.C6, r.C7, r.C8, r.C9, r.C10, r.C11, r.P1, r.P2, r.P3, r.P4, r.P5, r.P6, r.P7, r.P8, r.P9, r.P10, r.P11, r.DataEscolhida, r.cod_bimestre, p.anovigente, p.nro, p.status AS situacao FROM disciplinas d, aluno p, turma t, rpt_atacompl r WHERE p.anovigente='{0}' AND d.bloqueado='0' AND p.turma=t.codigo_trma AND t.bloqueado='0' ORDER BY t.classe, p.nro ASC;", frmRpt_anovigente)
            Catch ex As Exception
                SQL2 = String.Format("SELECT d.disciplina, t.classe, p.nome, CONCAT(p.ra,'-',p.ra_digito) AS ra, p.anovigente, p.nro, p.status AS situacao FROM disciplinas d, aluno p, turma t WHERE p.anovigente='{0}' AND p.turma=t.codigo_trma AND t.bloqueado='0' AND d.bloqueado='0' ORDER BY t.classe, p.nro ASC;", frmRpt_anovigente)
            End Try

            Dim vStrMsg As String = MsgBox("Deseja em formato paisagem?", MsgBoxStyle.YesNo, "Mais Escola!")
            If vStrMsg = MsgBoxResult.Yes Then
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ataConvencionalP.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\ataConvencionalP.rpt")
                Else
                    crReportDocument = New ataConvencionalP
                End If
            Else
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ataConvencional.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\ataConvencional.rpt")
                Else
                    crReportDocument = New ataConvencional
                End If
            End If
            '
        ElseIf (SQL_Nome = "CarteirinhaAluno") Then
            SQL2 = String.Format("SELECT aluno.anovigente, aluno.nome AS nome, escola.nome AS escola, file.file AS imagem, CONCAT(aluno.ra,'-',aluno.ra_digito) As ra, aluno.data AS datanascimento, turma.classe AS classe FROM aluno INNER JOIN turma ON turma.codigo_trma = aluno.turma, file, escola WHERE aluno.anovigente='{0}'{1}", frmRpt_anovigente, AlunosGrupo)
            '# RELATORIO
            '
            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\CarteiraEstudanteG.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\CarteiraEstudanteG.rpt")
            Else
                crReportDocument = New CarteiraEstudanteG

            End If

        ElseIf (SQL_Nome = "CarteirinhaTurma") Then

            If frmRpt_grupoTurma = 0 Then
                SQL2 = String.Format("SELECT aluno.anovigente, aluno.nome AS nome, escola.nome AS escola, file.file AS imagem, CONCAT(aluno.ra,'-',aluno.ra_digito) As ra, aluno.data AS datanascimento, turma.classe AS classe FROM aluno INNER JOIN turma ON turma.codigo_trma = aluno.turma, file, escola WHERE aluno.anovigente='{0}';", frmRpt_anovigente)
            Else
                SQL2 = String.Format("SELECT aluno.anovigente, aluno.nome AS nome, escola.nome AS escola, file.file AS imagem, CONCAT(aluno.ra,'-',aluno.ra_digito) As ra, aluno.data AS datanascimento, turma.classe AS classe FROM aluno INNER JOIN turma ON turma.codigo_trma = aluno.turma, file, escola WHERE aluno.anovigente='{0}' AND turma.codigo_trma='{1}';", frmRpt_anovigente, frmRpt_grupoTurma)
            End If

            ' # SQL2 = "SELECT DISTINCT p.nome, e.nome AS escola, f.file AS imagem, CONCAT(p.ra,'-',p.ra_digito) As ra, p.data AS datanascimento, t.classe AS classe FROM aluno p, escola e, turma t, file f WHERE p.turma=t.codigo_trma AND p.anovigente='" & frmRpt_anovigente & "' " & grupoTurmas
            '
            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\CarteiraEstudante.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\CarteiraEstudante.rpt")
            Else
                crReportDocument = New CarteiraEstudante

            End If

        ElseIf (SQL_Nome = "Graficos") Then
            SQL2 = String.Format("SELECT e.de, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.cod_bimestre>='1' AND n.cod_bimestre<='4' AND n.anovigente='{0}';", frmRpt_anovigente)
            '# RELATORIO
            '
            crReportDocument = New Graficos

        ElseIf (SQL_Nome = "TGraficos") Then
            SQL2 = String.Format("SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M AS Avaliacao, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.anovigente='{0}';", frmRpt_anovigente)
            '# RELATORIO
            '
            crReportDocument = New Graficos2

        ElseIf (SQL_Nome = "ABEvasaoEscolar") Then
            SQL2 = String.Format("SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=12 AND n.anovigente='{0}';", frmRpt_anovigente)
            '# RELATORIO
            '
            crReportDocument = New ABEvasaoEscolar

        ElseIf (SQL_Nome = "TREvasaoEscolar") Then
            SQL2 = String.Format("SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=11 AND n.anovigente='{0}';", frmRpt_anovigente)
            '# RELATORIO
            '
            crReportDocument = New TREvasaoEscolar

        ElseIf (SQL_Nome = "LSEvasaoEscolar") Then
            SQL2 = String.Format("SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=13 AND n.anovigente='{0}';", frmRpt_anovigente)
            '# RELATORIO
            '
            crReportDocument = New LSEvasaoEscolar

        ElseIf (SQL_Nome = "LGEvasaoEscolar") Then
            SQL2 = String.Format("SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=14 AND n.anovigente='{0}';", frmRpt_anovigente)
            '# RELATORIO
            '
            crReportDocument = New LGEvasaoEscolar

        ElseIf (SQL_Nome = "REEvasaoEscolar") Then
            SQL2 = String.Format("SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=15 AND n.anovigente='{0}';", frmRpt_anovigente)
            '# RELATORIO
            '
            crReportDocument = New REEvasaoEscolar

        ElseIf (SQL_Nome = "FAEvasaoEscolar") Then
            SQL2 = String.Format("SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M=16 AND n.anovigente='{0}';", frmRpt_anovigente)
            '# RELATORIO
            '
            crReportDocument = New FAEvasaoEscolar

        ElseIf (SQL_Nome = "GrupoPeriodo") Then
            SQL2 = String.Format("SELECT e.de, t.periodo, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.cod_bimestre='{0}' AND t.periodo='{1}' AND n.anovigente='{2}';", frmRpt_codigo, grupoPeriodo, frmRpt_anovigente)
            '# RELATORIO
            If frmRpt_grupoCompara = 0 Then
                If frmRpt_Tipo = "Básico" Then
                    crReportDocument = New Graficos
                ElseIf frmRpt_Tipo = "Detalhado" Then
                    crReportDocument = New GraficosDet
                End If
            Else
                If frmRpt_Tipo = "Basico" Then
                    crReportDocument = New GraficosGPeriodo
                ElseIf frmRpt_Tipo = "Detalhado" Then
                    crReportDocument = New GraficosGPeriodoDet
                End If
            End If

        ElseIf (SQL_Nome = "GrupoTurmas2") Then
            SQL2 = String.Format("SELECT EvasaoEscolarConta(b.M,t.codigo_trma,n.anovigente) AS ResultadoFinal, t.periodo, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.anovigente='{2}' AND n.cod_bimestre='{0}' AND ({1});", frmRpt_codigo, grupoTurmas, frmRpt_anovigente)

            '# RELATORIO
            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\GraficosGTurmasBimestre.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\GraficosGTurmasBimestre.rpt")
            Else
                crReportDocument = New GraficosGTurmasBimestre
            End If

        ElseIf (SQL_Nome = "GrupoTurmas") Then

            If frmRpt_grupoTurma = 0 Then
                SQL2 = String.Format("SELECT e.de, t.periodo, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.S, b.porcentagem, n.qtdadeaulas, EvasaoEscolarConta(b.M,t.codigo_trma,n.anovigente) AS ResultadoFinal FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente='{0}' AND n.cod_bimestre='{1}' AND b.M<11;", frmRpt_anovigente, frmRpt_codigo)
            Else
                SQL2 = String.Format("SELECT e.de, t.periodo, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.S, b.porcentagem, n.qtdadeaulas, EvasaoEscolarConta(b.M,t.codigo_trma,n.anovigente) AS ResultadoFinal FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente='{0}' AND n.cod_bimestre='{1}' AND n.turma='{2}' AND b.M<11;", frmRpt_anovigente, frmRpt_codigo, frmRpt_grupoTurma)
            End If

            'Original _ SQL2 = "SELECT e.de, t.periodo, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M AS Avaliacao, b.F AS Faltas, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND b.M<11 AND n.cod_bimestre='" & frmRpt_grupoBimestre & "' AND n.anovigente='" & grupoAnoVigente & "' AND t.classe IN ('" & grupoTurmas & "');"

            'bkp SQL2 = "SELECT e.de, t.periodo, e.nome AS nomeescola, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M, b.F AS Faltas, b.AC, b.S, b.porcentagem, n.qtdadeaulas, EvasaoEscolarConta(b.M,t.codigo_trma,n.anovigente) AS ResultadoFinal FROM turma t, notasfreq n, boletim b, disciplinas d, escola e WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.cod_bimestre='" & frmRpt_grupoBimestre & "' AND n.anovigente='" & grupoAnoVigente & "';"
            ''# RELATORIO
            '
            If frmRpt_grupoCompara = 0 Then
                If frmRpt_Tipo = "Básico" Then
                    crReportDocument = New Graficos
                ElseIf frmRpt_Tipo = "Detalhado" Then
                    crReportDocument = New GraficosDet
                End If
            Else
                If frmRpt_Tipo = "Básico" Then
                    crReportDocument = New GraficosGTurmas
                ElseIf frmRpt_Tipo = "Detalhado" Then
                    crReportDocument = New GraficosGTurmasDet
                End If
            End If

        ElseIf (SQL_Nome = "ConsolidadoProfessor") Then
            SQL2 = String.Format("SELECT n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.nro_aluno, b.M AS Avaliacao, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas, n.previsaoaulas FROM turma t, notasfreq n, boletim b, disciplinas d, notasfreq_prof nfp WHERE n.cod_nf=b.cod_boletim AND n.cod_nf=nfp.cod_nf AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND nfp.grupo='{0}';", frmRpt_codigo)
            '# RELATORIO
            crReportDocument = New ConsolidadoProfessor

        ElseIf (SQL_Nome = "ReciboProfessor") Then
            SQL2 = "SELECT recibo AS NomeObra, data AS DataDevolucao FROM rpt_recibo;"
            '# RELATORIO
            crReportDocument = New ReciboProfessor

        ElseIf (SQL_Nome = "BoletinsAtraso") Then
            SQL2 = "SELECT " _
                        & " disciplinas.disciplina, " _
                        & " turma.classe, " _
                        & " rpt_bolatraso.cod_bimestre, " _
                        & " rpt_bolatraso.anovigente " _
                        & "FROM " _
                        & " rpt_bolatraso " _
                        & " INNER JOIN turma ON (rpt_bolatraso.turma = turma.codigo_trma) " _
                        & " INNER JOIN disciplinas ON (rpt_bolatraso.disciplina = disciplinas.codigo_disc);"
            '# RELATORIO
            crReportDocument = New BoletinsAtraso

        ElseIf (SQL_Nome = "REsnome") Then
            If frmRpt_grupoTurma = 0 Then
                SQL2 = String.Format("SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente='{0}';", frmRpt_anovigente)
            Else
                SQL2 = String.Format("SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente='{0}' AND n.turma='{1}';", frmRpt_anovigente, frmRpt_grupoTurma)
            End If
            '# RELATORIO
            '
            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoEvasao.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoEvasao.rpt")
            Else
                crReportDocument = New ConsolidadoEvasao
            End If

        ElseIf (SQL_Nome = "FI_Nome") Then
            SQL2 = String.Format("SELECT DISTINCT b.nro_aluno, e.de, e.nome AS nomeescola, e.fones AS fone, e.endereco, f.file AS imagem, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, a.nome AS nome, CONCAT(a.ra,'-',a.ra_digito) AS ra, a.data AS datanascimento, b.M AS Avaliacao, b.F, b.AC, b.porcentagem, n.qtdadeaulas, RM(a.ra,a.ra_digito) AS rm FROM escola e, turma t, notasfreq n, boletim b, disciplinas d, aluno a, file f WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.anovigente=n.anovigente AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND n.anovigente='{0}' AND a.nome='{1}';", frmRpt_anovigente, frmRpt_nome)
            '# RELATORIO
            '
            Dim vStrMsg As String = MsgBox("Deseja em formato paisagem?", MsgBoxStyle.YesNo, "Mais Escola!")
            If vStrMsg = MsgBoxResult.Yes Then
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\FichaAlunoP.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\FichaAlunoP.rpt")
                Else
                    crReportDocument = New FichaAlunoP
                End If
            Else
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\FichaAluno.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\FichaAluno.rpt")
                Else
                    crReportDocument = New FichaAluno
                End If
            End If

        ElseIf (SQL_Nome = "AdmAtribuicao") Or (SQL_Nome = "AdmAtribuicaoSala") Then

            ' Atribuição de Turmas / Disciplinas

            SQL2 = "SELECT " _
                & "usuariodsk.usuario AS Professor_usuario, " _
                & "usuariodsk.nome AS Professor, " _
                & "turma.classe AS Classe, " _
                & "disciplinas.disciplina As Disciplina " _
                & "FROM " _
                & "usuariodsk " _
                & "INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK " _
                & "INNER JOIN turma ON professor_grupos.codigo_trma = turma.codigo_trma " _
                & "INNER JOIN disciplinas ON professor_grupos.codigo_disc = disciplinas.codigo_disc WHERE usuariodsk.cod_prof='1' ORDER BY usuariodsk.usuario, turma.classe, disciplinas.disciplina;"

            If (SQL_Nome = "AdmAtribuicao") Then
                crReportDocument.Load(meucaminhorelatorio & "\reports\AdmAtribuicao.rpt")
            ElseIf (SQL_Nome = "AdmAtribuicaoSala") Then
                crReportDocument = New AdmAtribuicaoSala
            End If

        End If

        SQL_frmRPT = SQL2

        Return SQL2
    End Function

    Public Sub atualizaBD()

        Try

            VERSAO = My.Application.Info.Version.ToString

            'Primeiro checa no BD última vez atualizado
            '
            SQL = "SELECT ferramenta2 FROM preferencias WHERE idPreferencias='1';"
            Dim Retorno = MySQL_consulta_campo(SQL, "ferramenta2")
            If Retorno <> VERSAO Then

                Dim DataHoje As String = DateTime.Now
                DataHoje = Replace(DataHoje, "/", "-")
                DataHoje = Replace(DataHoje, ":", "-")
                DataHoje = Replace(DataHoje, " ", "-")

                'BACKUP do BD
                backupBancoDados(String.Format("{0}\{1}", meucaminhorelatorio, DataHoje))

                ' ***************************************** INICIO DA ATUALIZACAO ...
                '// CREATE E ALTER TABLE
                '// CREATE

                '// INSERT
                '// DROP
                '// DROP FUNCOES
                ' \
                'SQL = "CREATE TABLE aluno_ficha_telefone (`idAlunoFone` int(10) unsigned NOT NULL AUTO_INCREMENT, `tipo` varchar(15) DEFAULT NULL, `fone` varchar(20) DEFAULT NULL, `idAlunoFicha` double DEFAULT NULL, PRIMARY KEY (`idAlunoFone`));"
                SQL = "ALTER TABLE aluno CHANGE COLUMN `nome` `nome` VARCHAR(200) NULL DEFAULT '0';"
                MySQL_atualiza(SQL)
                ' \

                ''// FUNCOES...
                '
                'SQL = "DELIMITER $$ " _
                '    & "CREATE DEFINER=`root`@`localhost` FUNCTION `FotoAluno`(MEUNOME TEXT, MEURA INT) RETURNS blob BEGIN declare MinhaFoto blob;   SELECT file INTO MinhaFoto FROM file INNER JOIN aluno_ficha ON file.file_id = aluno_ficha.file_id WHERE NOME = MEUNOME OR RA = MEURA LIMIT 1;   RETURN MinhaFoto; END$$ " _
                '    & "DELIMITER ;"
                'MySQL_atualiza_funcao(SQL)

                SQL = "DELIMITER $$ " _
                    & "CREATE DEFINER=`root`@`localhost` FUNCTION `QtdadeAlunos`(CodigoTurma INT) RETURNS int(10) BEGIN declare Quantidade int(10); SELECT COUNT(aluno.nro) INTO Quantidade FROM aluno WHERE aluno.anovigente = '2013' AND aluno.turma = CodigoTurma; RETURN Quantidade; END$$ " _
                    & "DELIMITER ;"
                MySQL_atualiza_funcao(SQL)

                SQL = "DELIMITER $$ " _
                    & "CREATE DEFINER=`root`@`localhost` FUNCTION `QtdadeAlunos_NotaBimestre`(`nroAnoVigente` INT,`nroBimestre` TEXT, `nroNota` INT) RETURNS int(11) BEGIN DECLARE QtdadeAlunos INT(5); SELECT COUNT(notasfreq.cod_nf) INTO QtdadeAlunos FROM boletim INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf WHERE notasfreq.anovigente = nroAnoVigente AND notasfreq.cod_bimestre = nroBimestre AND boletim.M = nroNota; RETURN QtdadeAlunos; END$$ " _
                    & "DELIMITER ;"
                MySQL_atualiza_funcao(SQL)

                SQL = "DELIMITER $$ " _
                    & "CREATE DEFINER=`root`@`localhost` FUNCTION `QtdadeAlunos_RF`(`nroAnoVigente` INT,`meuPeriodo` TEXT) RETURNS int(11) BEGIN DECLARE QtdadeAlunos INT(5); SELECT Count(boletim.M) INTO QtdadeAlunos FROM boletim INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf INNER JOIN turma ON notasfreq.turma = turma.codigo_trma WHERE notasfreq.anovigente = nroAnoVigente AND turma.periodo = meuPeriodo AND boletim.porcentagem>=25; RETURN QtdadeAlunos; END$$ " _
                    & "DELIMITER ;"
                MySQL_atualiza_funcao(SQL)

                SQL = "DELIMITER $$ " _
                    & "CREATE DEFINER=`root`@`localhost` FUNCTION `QtdadeAlunos_RR`(`nroAnoVigente` INT,`meuPeriodo` TEXT) RETURNS int(11) BEGIN DECLARE QtdadeAlunos INT(5); SELECT Count(boletim.M) INTO QtdadeAlunos FROM boletim INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf INNER JOIN turma ON notasfreq.turma = turma.codigo_trma WHERE notasfreq.anovigente = nroAnoVigente AND turma.periodo = meuPeriodo AND boletim.M<5; RETURN QtdadeAlunos; END$$ " _
                    & "DELIMITER ;"
                MySQL_atualiza_funcao(SQL)

                SQL = "DELIMITER $$ " _
                    & "CREATE DEFINER=`root`@`localhost` FUNCTION `QtdadeAlunos_Status`(`nroAnoVigente` int, `nroTurma` text) RETURNS int(11) BEGIN   DECLARE QtdadeAlunos INT(5);   SELECT COUNT(nro) INTO QtdadeAlunos FROM aluno WHERE anovigente = nroAnoVigente AND turma = nroTurma; 	RETURN QtdadeAlunos; END$$ " _
                    & "DELIMITER ;"
                MySQL_atualiza_funcao(SQL)

                SQL = "DELIMITER $$ " _
                    & "CREATE DEFINER=`root`@`localhost` FUNCTION `QtdadeAlunos_StatusTurma`(`nroAnoVigente` int,`nroTurma` int, `nroStatus` text) RETURNS int(11) BEGIN   DECLARE QtdadeAlunos INT(5);   SELECT COUNT(nro) INTO QtdadeAlunos FROM aluno WHERE turma = nroTurma AND anovigente = nroAnoVigente AND status = nroStatus; 	RETURN QtdadeAlunos; END$$ " _
                    & "DELIMITER ;"
                MySQL_atualiza_funcao(SQL)

                SQL = "DELIMITER $$ " _
                    & "CREATE DEFINER=`root`@`localhost` FUNCTION `QtdadeNotas`(`AnoVigente` int,`TurmaNro` int,`AlunoNro` int, `Nota` int) RETURNS int(11) BEGIN     DECLARE QtdadeNotas INT(5);     SELECT COUNT(boletim.M) INTO QtdadeNotas FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim WHERE notasfreq.anovigente = AnoVigente AND notasfreq.turma = TurmaNro AND notasfreq.cod_bimestre <> '2AF' AND notasfreq.cod_bimestre <> '4AF' AND boletim.nro_aluno = AlunoNro AND boletim.M < Nota;     RETURN QtdadeNotas;  END$$ " _
                    & "DELIMITER ;"
                MySQL_atualiza_funcao(SQL)

                SQL = "DELIMITER $$ " _
                    & "CREATE DEFINER=`root`@`localhost` FUNCTION `QtdadeNotas_NF`(CodigoBoletim INT) RETURNS int(10) BEGIN    declare Quantidade int(10);    SELECT COUNT(boletim.nro_aluno) INTO Quantidade FROM boletim WHERE boletim.cod_boletim = CodigoBoletim;    RETURN Quantidade;  END$$ " _
                    & "DELIMITER ;"
                MySQL_atualiza_funcao(SQL)

                '\\ ***************************************** FIM DA ATUALIZACAO...

                ' ... ATUALIZA PARA A VERSAO RECENTE...
                SQL = String.Format("UPDATE preferencias SET ferramenta2='{0}' WHERE idPreferencias='1';", VERSAO)
                MySQL_atualiza(SQL)

            End If

        Catch ex As Exception

        End Try

    End Sub

    Sub frmPreview_Padrao(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        Dim Brick As PageInfoBrick = e.Graph.DrawPageInfo(PageInfo.DateTime, "{0:F}", Color.Black, New RectangleF(0, 0, 100, 20), BorderSide.None)
        Brick.LineAlignment = BrickAlignment.Far
        Brick.Alignment = BrickAlignment.Far
        Brick.AutoWidth = True

        Dim brickTitulo As TextBrick = e.Graph.DrawString(frmPreview_Titulo, Color.Black, New RectangleF(0, 0, 500, 40), DevExpress.XtraPrinting.BorderSide.None)
        brickTitulo.Font = New Font("Arial", 16, FontStyle.Bold)
        brickTitulo.StringFormat = New BrickStringFormat(StringAlignment.Center)

    End Sub

    Friend Function meuRPT2(ByVal Modulo As String, ByVal SQL_Nome As String)

        crReportDocument = New ReportDocument()
        SQL_Sub = String.Empty

        If Modulo = "ATA do Conselho" Then

            If (SQL_Nome = "ataConvencional") Then

                If frmRpt_Tipo = "Período" Then
                    SQL = String.Format("SELECT d.disciplina, t.classe, p.nome, CONCAT(p.ra,'-',p.ra_digito) AS ra, r.C1, r.C2, r.C3, r.C4, r.C5,r.C6, r.C7, r.C8, r.C9, r.C10, r.C11, r.P1, r.P2, r.P3, r.P4, r.P5, r.P6, r.P7, r.P8, r.P9, r.P10, r.P11, r.DataEscolhida, r.cod_bimestre, p.anovigente, p.nro, p.status AS situacao FROM disciplinas d, aluno p, turma t, rpt_atacompl r WHERE p.anovigente='{0}' AND t.periodo='{1}' AND d.bloqueado='0' AND p.turma=t.codigo_trma AND t.bloqueado='0' ORDER BY t.classe, p.nro ASC;", frmRpt_anovigente, frmRpt_Parametro)
                ElseIf frmRpt_Tipo = "Turma" Then
                    SQL = String.Format("SELECT d.disciplina, t.classe, p.nome, CONCAT(p.ra,'-',p.ra_digito) AS ra, r.C1, r.C2, r.C3, r.C4, r.C5,r.C6, r.C7, r.C8, r.C9, r.C10, r.C11, r.P1, r.P2, r.P3, r.P4, r.P5, r.P6, r.P7, r.P8, r.P9, r.P10, r.P11, r.DataEscolhida, r.cod_bimestre, p.anovigente, p.nro, p.status AS situacao FROM disciplinas d, aluno p, turma t, rpt_atacompl r WHERE p.anovigente='{0}' AND d.bloqueado='0' AND p.turma=t.codigo_trma AND t.bloqueado='0' AND t.classe='{1}' ORDER BY t.classe, p.nro ASC;", frmRpt_anovigente, frmRpt_Parametro)
                ElseIf frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT d.disciplina, t.classe, p.nome, CONCAT(p.ra,'-',p.ra_digito) AS ra, r.C1, r.C2, r.C3, r.C4, r.C5,r.C6, r.C7, r.C8, r.C9, r.C10, r.C11, r.P1, r.P2, r.P3, r.P4, r.P5, r.P6, r.P7, r.P8, r.P9, r.P10, r.P11, r.DataEscolhida, r.cod_bimestre, p.anovigente, p.nro, p.status AS situacao FROM disciplinas d, aluno p, turma t, rpt_atacompl r WHERE p.anovigente='{0}' AND d.bloqueado='0' AND p.turma=t.codigo_trma AND t.bloqueado='0' ORDER BY t.classe, p.nro ASC;", frmRpt_anovigente)
                End If

                Dim vStrMsg As String = MsgBox("Deseja em formato paisagem?", MsgBoxStyle.YesNo, "Mais Escola!")
                If vStrMsg = MsgBoxResult.Yes Then
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ataConvencionalP.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ataConvencionalP.rpt")
                    Else
                        crReportDocument = New ataConvencionalP
                    End If

                Else
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ataConvencional.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ataConvencional.rpt")
                    Else
                        crReportDocument = New ataConvencional
                    End If
                End If

            ElseIf (SQL_Nome = "ataOficial") Or (SQL_Nome = "ataRendInsatisfatorio") Then

                '... Lentidão mySQL
                If frmRpt_Tipo = "Período" Then
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, boletim.nro_aluno, boletim.M AS Avaliacao, boletim.F AS Faltas, boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, rpt_atacompl.C1, rpt_atacompl.C2, rpt_atacompl.C3,rpt_atacompl.C4,rpt_atacompl.C5,rpt_atacompl.C6,rpt_atacompl.C7,rpt_atacompl.C8,rpt_atacompl.C9,rpt_atacompl.C10,rpt_atacompl.C11,rpt_atacompl.P1,rpt_atacompl.P2,rpt_atacompl.P3,rpt_atacompl.P4,rpt_atacompl.P5,rpt_atacompl.P6,rpt_atacompl.P7,rpt_atacompl.P8,rpt_atacompl.P9,rpt_atacompl.P10,rpt_atacompl.P11, rpt_atacompl.DataEscolhida, notasfreq.qtdadeaulas FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), rpt_atacompl WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND turma.periodo='{2}';", frmRpt_anovigente, frmRpt_bimestre, frmRpt_Parametro)
                ElseIf frmRpt_Tipo = "Turma" Then
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, boletim.nro_aluno, boletim.M AS Avaliacao, boletim.F AS Faltas, boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, rpt_atacompl.C1, rpt_atacompl.C2, rpt_atacompl.C3,rpt_atacompl.C4,rpt_atacompl.C5,rpt_atacompl.C6,rpt_atacompl.C7,rpt_atacompl.C8,rpt_atacompl.C9,rpt_atacompl.C10,rpt_atacompl.C11,rpt_atacompl.P1,rpt_atacompl.P2,rpt_atacompl.P3,rpt_atacompl.P4,rpt_atacompl.P5,rpt_atacompl.P6,rpt_atacompl.P7,rpt_atacompl.P8,rpt_atacompl.P9,rpt_atacompl.P10,rpt_atacompl.P11, rpt_atacompl.DataEscolhida, notasfreq.qtdadeaulas FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), rpt_atacompl WHERE notasfreq.anovigente='{0}' AND aluno.anovigente='{0}' AND notasfreq.cod_bimestre='{1}' AND turma.classe='{2}';", frmRpt_anovigente, frmRpt_bimestre, frmRpt_Parametro)
                ElseIf frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, boletim.nro_aluno, boletim.M AS Avaliacao, boletim.F AS Faltas, boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, rpt_atacompl.C1, rpt_atacompl.C2, rpt_atacompl.C3,rpt_atacompl.C4,rpt_atacompl.C5,rpt_atacompl.C6,rpt_atacompl.C7,rpt_atacompl.C8,rpt_atacompl.C9,rpt_atacompl.C10,rpt_atacompl.C11,rpt_atacompl.P1,rpt_atacompl.P2,rpt_atacompl.P3,rpt_atacompl.P4,rpt_atacompl.P5,rpt_atacompl.P6,rpt_atacompl.P7,rpt_atacompl.P8,rpt_atacompl.P9,rpt_atacompl.P10,rpt_atacompl.P11, rpt_atacompl.DataEscolhida, notasfreq.qtdadeaulas FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), rpt_atacompl WHERE notasfreq.anovigente='{0}' AND aluno.anovigente='{0}' AND notasfreq.cod_bimestre='{1}';", frmRpt_anovigente, frmRpt_bimestre)
                End If

                If (SQL_Nome = "ataOficial") Then
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoReprovadosATA2.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoReprovadosATA2.rpt")
                    Else
                        crReportDocument = New ConsolidadoReprovadosATA2
                    End If

                ElseIf (SQL_Nome = "ataRendInsatisfatorio") Then
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoReprovadosATA.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoReprovadosATA.rpt")
                    Else
                        crReportDocument = New ConsolidadoReprovadosATA
                    End If
                End If
            End If

        ElseIf Modulo = "Carteira de Estudante" Then

            If (SQL_Nome = "Aluno") Then
                SQL = String.Format("SELECT FotoAluno(aluno.nome, aluno.ra) AS Foto, aluno.anovigente, aluno.nome AS nome, escola.nome AS escola, file.file AS imagem, CONCAT(aluno.ra,'-',aluno.ra_digito) As ra, aluno.data AS datanascimento, turma.classe AS classe FROM aluno INNER JOIN turma ON turma.codigo_trma = aluno.turma, file, escola WHERE file.file_id='1' AND aluno.anovigente='{0}' AND ({1})", frmRpt_anovigente, grupoAlunos)

                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\carteiraEstudanteG.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\carteiraEstudanteG.rpt")
                Else
                    crReportDocument = New CarteiraEstudanteG
                End If

            ElseIf (SQL_Nome = "Turma") Then
                SQL = String.Format("SELECT FotoAluno(aluno.nome, aluno.ra) AS Foto, aluno.anovigente, aluno.nome AS nome, escola.nome AS escola, file.file AS imagem, CONCAT(aluno.ra,'-',aluno.ra_digito) As ra, aluno.data AS datanascimento, turma.classe AS classe FROM aluno INNER JOIN turma ON turma.codigo_trma = aluno.turma, file, escola WHERE file.file_id='1' AND aluno.anovigente='{0}' AND ({1})", frmRpt_anovigente, grupoTurmas)

                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\CarteiraEstudante.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\CarteiraEstudante.rpt")
                Else
                    crReportDocument = New CarteiraEstudante
                End If

            End If

        ElseIf (Modulo = "Declaração Escolar") Then

            SQL = "SELECT e.nome AS escola, e.de, e.fones AS fone, e.endereco, f.file AS imagem, td.nome, td.ra, td.turma, td.observacao, td.horarioINICIO, td.horarioFIM, td.op1, td.op2, td.op3, td.op4, td.op5, td.op6, td.op7, td.op8 FROM tempdeclaracao td, escola e, file f WHERE td.idDeclaracao='1';"

            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\DE.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\DE.rpt")
            Else
                crReportDocument = New DE
            End If

        ElseIf (Modulo = "Atribuição") Then

            ' Atribuição de Turmas / Disciplinas
            SQL = "SELECT " _
                & "usuariodsk.usuario AS Professor_usuario, " _
                & "usuariodsk.nome AS Professor, " _
                & "turma.classe AS Classe, " _
                & "disciplinas.disciplina As Disciplina " _
                & "FROM " _
                & "usuariodsk " _
                & "INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK " _
                & "INNER JOIN turma ON professor_grupos.codigo_trma = turma.codigo_trma " _
                & "INNER JOIN disciplinas ON professor_grupos.codigo_disc = disciplinas.codigo_disc WHERE usuariodsk.cod_prof='1' ORDER BY usuariodsk.usuario, turma.classe, disciplinas.disciplina;"
            If (SQL_Nome = "Professor") Then
                crReportDocument = New AdmAtribuicao
            ElseIf (SQL_Nome = "Turma") Then
                crReportDocument = New AdmAtribuicaoSala
            End If

        ElseIf (Modulo = "Deliberação 11") Then

            If frmRpt_Tipo = "Período" Then
                ' Pega somente o: anovigente / turma (delib11_notasfreq)
                SQL = "SELECT " _
                & "delib11_nf.nro_aluno, " _
                & "delib11_nf.turma, " _
                & "delib11_nf.anovigente, " _
                & "delib11_categoria.categoria, " _
                & "delib11_descricao.descricao, " _
                & "turma.classe, " _
                & "aluno.nome, " _
                & "escola.nome AS nomeescola, " _
                & "escola.de, " _
                & "file.file AS imagem " _
                & "FROM " _
                & "delib11_nf " _
                & "INNER JOIN delib11_boletim ON delib11_nf.idDelibNF = delib11_boletim.idDelibNF " _
                & "INNER JOIN delib11_categoria ON delib11_boletim.idDelib_cat = delib11_categoria.idDelib_cat " _
                & "INNER JOIN delib11_descricao ON delib11_boletim.idDelib_des = delib11_descricao.idDelib_des AND delib11_descricao.idDelib_cat = delib11_categoria.idDelib_cat " _
                & "INNER JOIN turma ON turma.codigo_trma = delib11_nf.turma " _
                & "INNER JOIN aluno ON aluno.nro = delib11_nf.nro_aluno AND aluno.turma = delib11_nf.turma AND aluno.anovigente = delib11_nf.anovigente, " _
                & "escola INNER JOIN file ON escola.idFile = file.file_id " _
                & "WHERE delib11_nf.anovigente = '" & frmRpt_anovigente & "' AND turma.periodo='" & frmRpt_grupoTurma & "';"
                '& ";"

                SQL_Sub = String.Format("SELECT boletim.nro_aluno, turma.classe, aluno.nome AS nome, CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, notasfreq.cod_bimestre, notasfreq.anovigente, disciplinas.disciplina, boletim.M, boletim.F AS Faltas, boletim.AC, boletim.porcentagem, notasfreq.qtdadeaulas AS qtdadeaulas, escola.de, escola.nome AS nomeescola, escola.fones AS fone, escola.endereco, file.file AS imagem FROM notasfreq INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim) INNER JOIN aluno ON (notasfreq.turma = aluno.turma) AND (notasfreq.anovigente = aluno.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc), escola INNER JOIN file ON escola.idFile = file.file_id WHERE aluno.anovigente=notasfreq.anovigente AND notasfreq.anovigente='{0}'  AND turma.periodo='{1}';", frmRpt_anovigente, frmRpt_grupoTurma)

            ElseIf frmRpt_Tipo = "Turma" Then

                frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                ' Pega somente o: anovigente / turma (delib11_notasfreq)
                SQL = "SELECT " _
                & "delib11_nf.nro_aluno, " _
                & "delib11_nf.turma, " _
                & "delib11_nf.anovigente, " _
                & "delib11_categoria.categoria, " _
                & "delib11_descricao.descricao, " _
                & "turma.classe, " _
                & "aluno.nome, " _
                & "escola.nome AS nomeescola, " _
                & "escola.de, " _
                & "file.file AS imagem " _
                & "FROM " _
                & "delib11_nf " _
                & "INNER JOIN delib11_boletim ON delib11_nf.idDelibNF = delib11_boletim.idDelibNF " _
                & "INNER JOIN delib11_categoria ON delib11_boletim.idDelib_cat = delib11_categoria.idDelib_cat " _
                & "INNER JOIN delib11_descricao ON delib11_boletim.idDelib_des = delib11_descricao.idDelib_des AND delib11_descricao.idDelib_cat = delib11_categoria.idDelib_cat " _
                & "INNER JOIN turma ON turma.codigo_trma = delib11_nf.turma " _
                & "INNER JOIN aluno ON aluno.nro = delib11_nf.nro_aluno AND aluno.turma = delib11_nf.turma AND aluno.anovigente = delib11_nf.anovigente, " _
                & "escola INNER JOIN file ON escola.idFile = file.file_id " _
                & "WHERE file.file_id='1' AND delib11_nf.anovigente = '" & frmRpt_anovigente & "' AND delib11_nf.turma = '" & frmRpt_grupoTurma & "' " _
                & "GROUP BY delib11_nf.nro_aluno, delib11_categoria.categoria, delib11_descricao.descricao;"

                SQL_Sub = String.Format("SELECT boletim.nro_aluno, turma.classe, aluno.nome AS nome, CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, notasfreq.cod_bimestre, notasfreq.anovigente, disciplinas.disciplina, boletim.M, boletim.F AS Faltas, boletim.AC, boletim.porcentagem, notasfreq.qtdadeaulas AS qtdadeaulas, escola.de, escola.nome AS nomeescola, escola.fones AS fone, escola.endereco, file.file AS imagem FROM notasfreq INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim) INNER JOIN aluno ON (notasfreq.turma = aluno.turma) AND (notasfreq.anovigente = aluno.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc), escola INNER JOIN file ON escola.idFile = file.file_id WHERE file.file_id='1' AND aluno.anovigente=notasfreq.anovigente AND notasfreq.anovigente='{0}' AND turma.codigo_trma='{1}' ORDER BY turma.classe, boletim.nro_aluno;", frmRpt_anovigente, frmRpt_grupoTurma)

            ElseIf frmRpt_Tipo = "TurmaTodas" Then

                ' Pega somente o: anovigente / turma (delib11_notasfreq)
                SQL = "SELECT " _
                & "delib11_nf.nro_aluno, " _
                & "delib11_nf.turma, " _
                & "delib11_nf.anovigente, " _
                & "delib11_categoria.categoria, " _
                & "delib11_descricao.descricao, " _
                & "turma.classe, " _
                & "aluno.nome, " _
                & "escola.nome AS nomeescola, " _
                & "escola.de, " _
                & "file.file AS imagem " _
                & "FROM " _
                & "delib11_nf " _
                & "INNER JOIN delib11_boletim ON delib11_nf.idDelibNF = delib11_boletim.idDelibNF " _
                & "INNER JOIN delib11_categoria ON delib11_boletim.idDelib_cat = delib11_categoria.idDelib_cat " _
                & "INNER JOIN delib11_descricao ON delib11_boletim.idDelib_des = delib11_descricao.idDelib_des AND delib11_descricao.idDelib_cat = delib11_categoria.idDelib_cat " _
                & "INNER JOIN turma ON turma.codigo_trma = delib11_nf.turma " _
                & "INNER JOIN aluno ON aluno.nro = delib11_nf.nro_aluno AND aluno.turma = delib11_nf.turma AND aluno.anovigente = delib11_nf.anovigente, " _
                & "escola INNER JOIN file ON escola.idFile = file.file_id " _
                & "WHERE file.file_id='1' AND delib11_nf.anovigente = '" & frmRpt_anovigente & "' " _
                & "ORDER BY turma.classe, delib11_nf.nro_aluno;"

                SQL_Sub = String.Format("SELECT boletim.nro_aluno, turma.classe, aluno.nome AS nome, CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, notasfreq.cod_bimestre, notasfreq.anovigente, disciplinas.disciplina, boletim.M, boletim.F AS Faltas, boletim.AC, boletim.porcentagem, notasfreq.qtdadeaulas AS qtdadeaulas, escola.de, escola.nome AS nomeescola, escola.fones AS fone, escola.endereco, file.file AS imagem FROM notasfreq INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim) INNER JOIN aluno ON (notasfreq.turma = aluno.turma) AND (notasfreq.anovigente = aluno.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc), escola INNER JOIN file ON escola.idFile = file.file_id WHERE file.file_id='1' AND aluno.anovigente=notasfreq.anovigente AND notasfreq.anovigente='{0}' ORDER BY turma.classe, boletim.nro_aluno;", frmRpt_anovigente)

            End If

            If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\AdmDelib11.rpt")) Then
                crReportDocument.Load(meucaminhorelatorio & "\personalizado\AdmDelib11.rpt")
            Else
                crReportDocument = New AdmDelib11
            End If

        ElseIf (Modulo = "Boletim") Then

            If (SQL_Nome = "Status de Entrega/Usuario") Or (SQL_Nome = "Status de Entrega") Then

                ' StatusEntrega
                '
                SQL = String.Format("SELECT usuariodsk.usuario AS Professor_usuario, usuariodsk.nome AS Professor, turma.classe AS Classe, disciplinas.disciplina As Disciplina, professor_grupos.codigo_trma, professor_grupos.codigo_disc, BoletimCadastrado('{0}', '{1}', professor_grupos.codigo_trma, professor_grupos.codigo_disc) AS Status FROM usuariodsk INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK INNER JOIN turma ON professor_grupos.codigo_trma = turma.codigo_trma INNER JOIN disciplinas ON professor_grupos.codigo_disc = disciplinas.codigo_disc WHERE usuariodsk.cod_prof='1' ORDER BY usuariodsk.usuario, turma.classe, disciplinas.disciplina;", frmRpt_bimestre, frmRpt_anovigente)

                If frmRpt_bimestre = "1" Then
                    If (SQL_Nome = "Status de Entrega/Usuario") Then
                        crReportDocument = New AdmStatusEntrega1
                    ElseIf (SQL_Nome = "Status de Entrega") Then
                        crReportDocument = New AdmStatusEntrega_Status1
                    End If

                ElseIf frmRpt_bimestre = "2" Then
                    If (SQL_Nome = "Status de Entrega/Usuario") Then
                        crReportDocument = New AdmStatusEntrega2
                    ElseIf (SQL_Nome = "Status de Entrega") Then
                        crReportDocument = New AdmStatusEntrega_Status2
                    End If

                ElseIf frmRpt_bimestre = "3" Then
                    If (SQL_Nome = "Status de Entrega/Usuario") Then
                        crReportDocument = New AdmStatusEntrega3
                    ElseIf (SQL_Nome = "Status de Entrega") Then
                        crReportDocument = New AdmStatusEntrega_Status3
                    End If

                ElseIf frmRpt_bimestre = "4" Then
                    If (SQL_Nome = "Status de Entrega/Usuario") Then
                        crReportDocument = New AdmStatusEntrega4
                    ElseIf (SQL_Nome = "Status de Entrega") Then
                        crReportDocument = New AdmStatusEntrega_Status4
                    End If

                ElseIf frmRpt_bimestre = "2AF" Or frmRpt_bimestre = "4AF" Then
                    If (SQL_Nome = "Status de Entrega/Usuario") Then
                        crReportDocument = New AdmStatusEntregaAF
                    ElseIf (SQL_Nome = "Status de Entrega") Then
                        crReportDocument = New AdmStatusEntrega_StatusAF
                    End If
                End If

            ElseIf (SQL_Nome = "Completo") Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = "SELECT boletim.nro_aluno, turma.classe," _
                        & " aluno.nome AS nome," _
                        & " CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra," _
                        & " notasfreq.cod_bimestre," _
                        & " notasfreq.anovigente," _
                        & " disciplinas.disciplina," _
                        & " boletim.M AS Avaliacao," _
                        & " boletim.F AS Faltas," _
                        & " boletim.AC," _
                        & " boletim.porcentagem," _
                        & " notasfreq.qtdadeaulas AS qtdadeaulas," _
                        & " escola.de," _
                        & " escola.nome AS nomeescola," _
                        & " escola.fones AS fone," _
                        & " escola.endereco," _
                        & " file.file AS imagem" _
                        & " FROM" _
                        & " notasfreq" _
                        & " INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim)" _
                        & " INNER JOIN aluno ON (notasfreq.turma = aluno.turma)" _
                        & " AND (notasfreq.anovigente = aluno.anovigente)" _
                        & " AND (boletim.nro_aluno = aluno.nro)" _
                        & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                        & " INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc)," _
                        & " escola INNER JOIN file ON escola.idFile = file.file_id" _
                        & " WHERE aluno.anovigente=notasfreq.anovigente AND notasfreq.anovigente='" & frmRpt_anovigente & "';"
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)

                    SQL = "SELECT boletim.nro_aluno, turma.classe," _
                                    & " aluno.nome AS nome," _
                                    & " CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra," _
                                    & " notasfreq.cod_bimestre," _
                                    & " notasfreq.anovigente," _
                                    & " disciplinas.disciplina," _
                                    & " boletim.M AS Avaliacao," _
                                    & " boletim.F AS Faltas," _
                                    & " boletim.AC," _
                                    & " boletim.porcentagem," _
                                    & " notasfreq.qtdadeaulas AS qtdadeaulas," _
                                    & " escola.de," _
                                    & " escola.nome AS nomeescola," _
                                    & " escola.fones AS fone," _
                                    & " escola.endereco," _
                                    & " file.file AS imagem" _
                                    & " FROM" _
                                    & " notasfreq" _
                                    & " INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim)" _
                                    & " INNER JOIN aluno ON (notasfreq.turma = aluno.turma)" _
                                    & " AND (notasfreq.anovigente = aluno.anovigente)" _
                                    & " AND (boletim.nro_aluno = aluno.nro)" _
                                    & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                                    & " INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc)," _
                                    & " escola INNER JOIN file ON escola.idFile = file.file_id" _
                                    & " WHERE aluno.anovigente=notasfreq.anovigente AND notasfreq.anovigente='" & frmRpt_anovigente & "' AND turma.codigo_trma='" & frmRpt_grupoTurma & "';"
                End If
                crReportDocument = New Boletim

            ElseIf (SQL_Nome = "Simples") Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT f.file AS imagem, e.nome AS nomeescola, e.endereco, e.fones AS fone, b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, a.nome, CONCAT(a.ra,'-',a.ra_digito) AS ra, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, aluno a, escola e, file f WHERE f.file_id= '1' AND n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND a.anovigente=n.anovigente AND n.anovigente='{0}';", frmRpt_anovigente)
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = String.Format("SELECT f.file AS imagem, e.nome AS nomeescola, e.endereco, e.fones AS fone, b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, a.nome, CONCAT(a.ra,'-',a.ra_digito) AS ra, b.M, b.F, b.AC, b.porcentagem, n.qtdadeaulas FROM turma t, notasfreq n, boletim b, disciplinas d, aluno a, escola e, file f WHERE f.file_id= '1' AND n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND a.nro=b.nro_aluno AND a.turma=t.codigo_trma AND a.anovigente=n.anovigente AND n.anovigente='{0}' AND t.codigo_trma='{1}';", frmRpt_anovigente, frmRpt_grupoTurma)
                End If
                crReportDocument = New BoletimCN

            End If
            'FIM BOLETIM

        ElseIf (Modulo = "Consolidado") Then

            If SQL_Nome = "Alunos Reprovados" Then

                If frmRpt_Tipo = "TurmaTodas" Then

                    ' TODAS AS TURMAS...                   
                    SQL = "SELECT boletim.nro_aluno, turma.classe," _
                      & " CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra," _
                      & " aluno.nome," _
                      & " notasfreq.cod_bimestre," _
                      & " notasfreq.anovigente," _
                      & " disciplinas.disciplina," _
                      & " boletim.M AS Avaliacao," _
                      & " boletim.F AS Faltas," _
                      & " boletim.AC," _
                      & " boletim.porcentagem," _
                      & " notasfreq.qtdadeaulas," _
                      & " escola.de," _
                      & " escola.nome AS nomeescola," _
                      & " escola.fones AS fone," _
                      & " escola.endereco," _
                      & " file.file AS imagem" _
                      & " FROM" _
                      & " notasfreq" _
                      & " INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim)" _
                      & " INNER JOIN aluno ON (notasfreq.turma = aluno.turma)" _
                      & " AND (notasfreq.anovigente = aluno.anovigente)" _
                      & " AND (boletim.nro_aluno = aluno.nro)" _
                      & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                      & " INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc)," _
                      & " escola INNER JOIN file ON escola.idFile = file.file_id" _
                      & " WHERE aluno.anovigente=notasfreq.anovigente AND notasfreq.anovigente='" & frmRpt_anovigente & "' AND (boletim.M<5 OR boletim.porcentagem>=25) ORDER BY boletim.nro_aluno ASC;"
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)

                    'TURMA ESCOLHIDA
                    SQL = String.Format("SELECT boletim.nro_aluno, turma.classe, CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, aluno.nome, notasfreq.cod_bimestre, notasfreq.anovigente, disciplinas.disciplina, boletim.M AS Avaliacao, boletim.F AS Faltas, boletim.AC, boletim.porcentagem, notasfreq.qtdadeaulas, escola.de, escola.nome AS nomeescola, escola.fones AS fone, escola.endereco, file.file AS imagem FROM notasfreq INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim) INNER JOIN aluno ON (notasfreq.turma = aluno.turma) AND (notasfreq.anovigente = aluno.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc), escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.anovigente='{1}' AND notasfreq.turma='{0}' AND aluno.anovigente=notasfreq.anovigente AND (boletim.M<5 OR boletim.porcentagem>=25) ORDER BY boletim.nro_aluno ASC;", frmRpt_grupoTurma, frmRpt_anovigente)
                End If

                '# RELATORIO...
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoReprovados.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoReprovados.rpt")
                Else
                    crReportDocument = New ConsolidadoReprovados
                End If

            ElseIf SQL_Nome.Contains("Avaliação Final") = True Then

                If frmRpt_Tipo.Contains("Período") = False Then
                    If frmRpt_Tipo = "TurmaTodas" Then
                        SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, aluno.data AS datanascimento, boletim.nro_aluno, CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, boletim.M, notasfreq.cod_bimestre, RM(aluno.ra,aluno.ra_digito) AS rm, disciplinas.disciplina, notasfreq.anovigente, turma.classe, file.file AS imagem, boletim.S, PorcentagemFinal(notasfreq.anovigente, notasfreq.turma, boletim.nro_aluno) AS porcentagem, ResultadoFinal(boletim.nro_aluno, notasfreq.turma, notasfreq.anovigente, notasfreq.cod_bimestre) AS ResultadoFinal FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHEREaluno.anovigente='{0}' AND notasfreq.anovigente='{1}' AND notasfreq.cod_bimestre='{2}' AND file.file_id='1';", frmRpt_anovigente, frmRpt_anovigente, frmRpt_bimestre)
                    Else
                        frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                        SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, aluno.data AS datanascimento, boletim.nro_aluno, CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, boletim.M, notasfreq.cod_bimestre, RM(aluno.ra,aluno.ra_digito) AS rm, disciplinas.disciplina, notasfreq.anovigente, turma.classe, file.file AS imagem, boletim.S, PorcentagemFinal(notasfreq.anovigente, notasfreq.turma, boletim.nro_aluno) AS porcentagem, ResultadoFinal(boletim.nro_aluno, notasfreq.turma, notasfreq.anovigente, notasfreq.cod_bimestre) AS ResultadoFinal FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE aluno.anovigente='{1}' AND notasfreq.anovigente='{2}' AND notasfreq.cod_bimestre='{3}' AND turma.codigo_trma='{0}' AND file.file_id='1';", frmRpt_grupoTurma, frmRpt_anovigente, frmRpt_anovigente, frmRpt_bimestre)
                    End If
                Else
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, aluno.data AS datanascimento, boletim.nro_aluno, CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, boletim.M, notasfreq.cod_bimestre, RM(aluno.ra,aluno.ra_digito) AS rm, disciplinas.disciplina, notasfreq.anovigente, turma.classe, file.file AS imagem, boletim.S, PorcentagemFinal(notasfreq.anovigente, notasfreq.turma, boletim.nro_aluno) AS porcentagem, ResultadoFinal(boletim.nro_aluno, notasfreq.turma, notasfreq.anovigente, notasfreq.cod_bimestre) AS ResultadoFinal FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE aluno.anovigente='{1}' AND notasfreq.anovigente='{2}' AND notasfreq.cod_bimestre='{3}' AND turma.periodo='{0}' AND file.file_id='1';", frmRpt_grupoTurma, frmRpt_anovigente, frmRpt_anovigente, frmRpt_bimestre)
                End If

                If (SQL_Nome = "Avaliação Final/Turma") Or (SQL_Nome = "Avaliação Final/Período") Then
                    '# RELATORIO
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoAF.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoAF.rpt")
                    Else
                        crReportDocument = New ConsolidadoAF
                    End If
                ElseIf (SQL_Nome = "Avaliação Final - c/ Data de Nascimento") Then
                    '# RELATORIO
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoAFdt.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoAFdt.rpt")
                    Else
                        crReportDocument = New ConsolidadoAFdt
                    End If
                End If

            ElseIf (SQL_Nome = "Completo/Turma") Or (SQL_Nome = "Completo/Período") Then

                If frmRpt_Tipo.Contains("Período") = False Then
                    If frmRpt_Tipo = "TurmaTodas" Then
                        SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, file.file AS imagem, boletim.nro_aluno, boletim.M AS Avaliacao, boletim.F, boletim.AC, boletim.porcentagem, notasfreq.previsaoaulas, notasfreq.qtdadeaulas, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{1}';", frmRpt_anovigente, frmRpt_bimestre)
                    Else
                        frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                        SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, file.file AS imagem, boletim.nro_aluno, boletim.M AS Avaliacao, boletim.F, boletim.AC, boletim.porcentagem, notasfreq.previsaoaulas, notasfreq.qtdadeaulas, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{2}' AND turma.codigo_trma='{1}';", frmRpt_anovigente, frmRpt_grupoTurma, frmRpt_bimestre)
                    End If
                Else
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, file.file AS imagem, boletim.nro_aluno, boletim.M AS Avaliacao, boletim.F, boletim.AC, boletim.porcentagem, notasfreq.previsaoaulas, notasfreq.qtdadeaulas, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.anovigente='{0}' AND notasfreq.cod_bimestre='{2}' AND turma.periodo='{1}';", frmRpt_anovigente, frmRpt_grupoTurma, frmRpt_bimestre)
                End If

                '# RELATORIO
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ConsolidadoCompleto.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\ConsolidadoCompleto.rpt")
                Else
                    crReportDocument = New ConsolidadoCompleto
                End If

            ElseIf SQL_Nome = "Notas e Frequências" Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M AS Avaliacao, b.F, b.AC, b.porcentagem, n.qtdadeaulas, n.previsaoaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND n.anovigente='{0}' AND n.cod_bimestre='{1}';", frmRpt_anovigente, frmRpt_bimestre)
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = String.Format("SELECT b.nro_aluno, n.anovigente, n.cod_bimestre, d.disciplina, t.classe, b.M AS Avaliacao, b.F, b.AC, b.porcentagem, n.qtdadeaulas, n.previsaoaulas FROM turma t, notasfreq n, boletim b, disciplinas d WHERE n.cod_nf=b.cod_boletim AND n.disciplina=d.codigo_disc AND n.turma=t.codigo_trma AND t.codigo_trma='{0}' AND n.anovigente='{1}' AND n.cod_bimestre='{2}';", frmRpt_grupoTurma, frmRpt_anovigente, frmRpt_bimestre)
                End If

                '# RELATORIO
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\Consolidado.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\Consolidado.rpt")
                Else
                    crReportDocument = New Consolidado
                End If

            End If

            'FIM CONSOLIDADO
        ElseIf (Modulo = "Rendimento Escolar") Then

            If SQL_Nome = "Notas" Or SQL_Nome = "Faltas" Then
                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, aluno.ra, boletim.nro_aluno, boletim.M, boletim.F, boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre AS cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, notasfreq.qtdadeaulas, file.file AS imagem FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE aluno.anovigente='{0}' AND notasfreq.anovigente='{0}';", frmRpt_anovigente)
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, aluno.ra, boletim.nro_aluno, boletim.M, boletim.F, boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre AS cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, notasfreq.qtdadeaulas, file.file AS imagem FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.turma='{0}' AND aluno.anovigente='{1}' AND notasfreq.anovigente='{1}';", frmRpt_grupoTurma, frmRpt_anovigente)
                End If

                '# RELATORIO
                If (SQL_Nome = "Notas") Then
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\RendimentoNotas.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\RendimentoNotas.rpt")
                    Else
                        crReportDocument = New RendimentoNotas
                    End If
                ElseIf (SQL_Nome = "Faltas") Then
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\RendimentoFaltas.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\RendimentoFaltas.rpt")
                    Else
                        crReportDocument = New RendimentoFaltas
                    End If
                End If

            ElseIf SQL_Nome = "Completo" Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, aluno.ra, boletim.nro_aluno, boletim.M, boletim.F, boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, notasfreq.qtdadeaulas, file.file AS imagem FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE aluno.anovigente='{0}' AND notasfreq.anovigente='{1}' ORDER BY aluno.ra ASC;", frmRpt_anovigente, frmRpt_anovigente)
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, aluno.ra, boletim.nro_aluno, boletim.M, boletim.F, boletim.AC, boletim.porcentagem, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, notasfreq.qtdadeaulas, file.file AS imagem FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.turma='{0}' AND aluno.anovigente='{1}' AND notasfreq.anovigente='{2}' ORDER BY aluno.ra ASC;", frmRpt_grupoTurma, frmRpt_anovigente, frmRpt_anovigente)
                End If
                '# RELATORIO
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\RendimentoCompleto.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\RendimentoCompleto.rpt")
                Else
                    crReportDocument = New RendimentoCompleto
                End If

            End If

            'FIM RENDIMENTO ESCOLAR
        ElseIf (Modulo = "Ficha Individual") Then
            'PorcentagemFinal(notasfreq.anovigente, notasfreq.turma, boletim.nro_aluno) AS porcentagem
            '
            If frmRpt_Tipo.Contains("Período") = False Then

                If frmRpt_Tipo = "TurmaTodas" Then

                    SQL = "SELECT" _
                   & " escola.de," _
                   & " escola.nome AS nomeescola," _
                   & " escola.fones AS fone," _
                   & " escola.endereco," _
                   & " file.file AS imagem," _
                   & " boletim.nro_aluno, " _
                   & " aluno.nome AS nome," _
                   & " CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra," _
                   & " RM(aluno.ra, aluno.ra_digito) AS rm," _
                   & " aluno.data AS datanascimento," _
                   & " disciplinas.disciplina," _
                   & " turma.classe," _
                   & " boletim.M AS Avaliacao," _
                   & " boletim.F," _
                   & " boletim.AC," _
                   & " boletim.porcentagem," _
                   & " notasfreq.anovigente," _
                   & " notasfreq.cod_bimestre," _
                   & " notasfreq.qtdadeaulas" _
                   & " FROM" _
                   & " disciplinas" _
                   & " INNER JOIN notasfreq ON (disciplinas.codigo_disc = notasfreq.disciplina)" _
                   & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                   & " INNER JOIN aluno ON (notasfreq.turma = aluno.turma) AND (notasfreq.anovigente = aluno.anovigente)" _
                   & " INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim) AND (boletim.nro_aluno = aluno.nro)," _
                   & " escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.anovigente='" & frmRpt_anovigente & "' ORDER BY turma.classe, aluno.nro ASC;"

                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)

                    SQL = "SELECT" _
                   & " escola.de," _
                   & " escola.nome AS nomeescola," _
                   & " escola.fones AS fone," _
                   & " escola.endereco," _
                   & " file.file AS imagem," _
                   & " boletim.nro_aluno, " _
                   & " aluno.nome AS nome," _
                   & " CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra," _
                   & " RM(aluno.ra, aluno.ra_digito) AS rm," _
                   & " aluno.data AS datanascimento," _
                   & " disciplinas.disciplina," _
                   & " turma.classe," _
                   & " boletim.M AS Avaliacao," _
                   & " boletim.F," _
                   & " boletim.AC," _
                   & " boletim.porcentagem," _
                   & " notasfreq.anovigente," _
                   & " notasfreq.cod_bimestre," _
                   & " notasfreq.qtdadeaulas" _
                   & " FROM" _
                   & " disciplinas" _
                   & " INNER JOIN notasfreq ON (disciplinas.codigo_disc = notasfreq.disciplina)" _
                   & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                   & " INNER JOIN aluno ON (notasfreq.turma = aluno.turma) AND (notasfreq.anovigente = aluno.anovigente)" _
                   & " INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim) AND (boletim.nro_aluno = aluno.nro)," _
                   & " escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.anovigente='" & frmRpt_anovigente & "' AND notasfreq.turma='" & frmRpt_grupoTurma & "' ORDER BY turma.classe, aluno.nro ASC;"

                End If

            Else

                SQL = "SELECT" _
                   & " escola.de," _
                   & " escola.nome AS nomeescola," _
                   & " escola.fones AS fone," _
                   & " escola.endereco," _
                   & " file.file AS imagem," _
                   & " boletim.nro_aluno, " _
                   & " aluno.nome AS nome," _
                   & " CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra," _
                   & " RM(aluno.ra, aluno.ra_digito) AS rm," _
                   & " aluno.data AS datanascimento," _
                   & " disciplinas.disciplina," _
                   & " turma.classe," _
                   & " boletim.M AS Avaliacao," _
                   & " boletim.F," _
                   & " boletim.AC," _
                   & " boletim.porcentagem," _
                   & " notasfreq.anovigente," _
                   & " notasfreq.cod_bimestre," _
                   & " notasfreq.qtdadeaulas" _
                   & " FROM" _
                   & " disciplinas" _
                   & " INNER JOIN notasfreq ON (disciplinas.codigo_disc = notasfreq.disciplina)" _
                   & " INNER JOIN turma ON (notasfreq.turma = turma.codigo_trma)" _
                   & " INNER JOIN aluno ON (notasfreq.turma = aluno.turma) AND (notasfreq.anovigente = aluno.anovigente)" _
                   & " INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim) AND (boletim.nro_aluno = aluno.nro)," _
                   & " escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.anovigente='" & frmRpt_anovigente & "' AND turma.periodo='" & frmRpt_grupoTurma & "' ORDER BY turma.classe, aluno.nro ASC;"

            End If

            '#... RELATORIO
            Dim vStrMsg As String = MsgBox("Deseja em formato paisagem?", MsgBoxStyle.YesNo, "Mais Escola!")
            If vStrMsg = MsgBoxResult.Yes Then
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\FichaAlunoP.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\FichaAlunoP.rpt")
                Else
                    crReportDocument = New FichaAlunoP
                End If
            Else
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\FichaAluno.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\FichaAluno.rpt")
                Else
                    crReportDocument = New FichaAluno
                End If
            End If

            'FIM FICHA INDIVIDUAL
        ElseIf (Modulo = "Lista de Alunos") Then

            If SQL_Nome = ("Reunião de Pais e Mestres") Or SQL_Nome = ("Controle Interno/Aula") Or SQL_Nome = ("Controle Interno/Diário") Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT p.anovigente, p.data AS datanascimento, p.nome, t.classe, p.nro, CONCAT(p.ra,'-',p.ra_digito) AS ra, p.status AS situacao FROM aluno p, turma t WHERE p.anovigente='{0}' AND p.turma=t.codigo_trma AND t.bloqueado=0 ORDER BY anovigente, classe, nro ASC;", frmRpt_anovigente)
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = String.Format("SELECT p.anovigente, p.data AS datanascimento, p.nome, t.classe, p.nro, CONCAT(p.ra,'-',p.ra_digito) AS ra, p.status AS situacao FROM aluno p, turma t WHERE p.anovigente='{0}' AND p.turma='{1}' AND p.turma=t.codigo_trma AND t.bloqueado=0 ORDER BY anovigente, classe, nro ASC;", frmRpt_anovigente, frmRpt_grupoTurma)
                End If

                ' # RELATORIO...                
                If (SQL_Nome = "Reunião de Pais e Mestres") Then
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ListaAlunosReuniao.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ListaAlunosReuniao.rpt")
                    Else
                        crReportDocument = New ListaAlunosReuniao
                    End If
                ElseIf (SQL_Nome = "Controle Interno/Aula") Then
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ListaAlunosCIAula.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ListaAlunosCIAula.rpt")
                    Else
                        crReportDocument = New ListaAlunosCIAula
                    End If
                ElseIf (SQL_Nome = "Controle Interno/Diário") Then
                    If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ListaAlunosCIDiario.rpt")) Then
                        crReportDocument.Load(meucaminhorelatorio & "\personalizado\ListaAlunosCIDiario.rpt")
                    Else
                        crReportDocument = New ListaAlunosCIDiario
                    End If
                End If

            ElseIf SQL_Nome = ("Lista de Entrega") Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(aluno.nro, 2, '0'), '.', aluno.nome) USING utf8) AS nome, aluno.status AS S, aluno.nro AS nro_aluno, aluno.ra, escola.de, escola.nome AS nomeescola, file.file AS imagem, disciplinas.disciplina, turma.classe, aluno.anovigente FROM disciplinas, aluno INNER JOIN turma ON (aluno.turma = turma.codigo_trma) , escola INNER JOIN file ON escola.idFile = file.file_id WHERE aluno.anovigente='{0}' AND disciplinas.bloqueado='0';", frmRpt_anovigente)
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(aluno.nro, 2, '0'), '.', aluno.nome) USING utf8) AS nome, aluno.status AS S, aluno.nro AS nro_aluno, aluno.ra, escola.de, escola.nome AS nomeescola, file.file AS imagem, disciplinas.disciplina, turma.classe, aluno.anovigente FROM disciplinas, aluno INNER JOIN turma ON (aluno.turma = turma.codigo_trma) , escola INNER JOIN file ON escola.idFile = file.file_id WHERE aluno.anovigente='{0}' AND disciplinas.bloqueado='0' AND turma.codigo_trma={1};", frmRpt_anovigente, frmRpt_grupoTurma)
                End If
                ' # RELATORIO ...
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ListaEntrega.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\ListaEntrega.rpt")
                Else
                    crReportDocument = New ListaEntrega
                End If

            ElseIf SQL_Nome = ("Lista Piloto") Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT a.anovigente, e.nome AS nomeescola, e.endereco, e.fones AS fone, a.nro, d.disciplina, t.classe, a.nome, a.data AS DataEscolhida, a.status AS situacao, CONCAT(a.ra,'-',a.ra_digito) AS ra FROM turma t, disciplinas d, aluno a, escola e WHERE t.bloqueado='0' AND a.turma=t.codigo_trma AND a.anovigente='{0}';", frmRpt_anovigente)
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = String.Format("SELECT a.anovigente, e.nome AS nomeescola, e.endereco, e.fones AS fone, a.nro, d.disciplina, t.classe, a.nome, a.data AS DataEscolhida, a.status AS situacao, CONCAT(a.ra,'-',a.ra_digito) AS ra FROM turma t, disciplinas d, aluno a, escola e WHERE t.bloqueado='0' AND a.turma=t.codigo_trma AND a.anovigente='{0}' AND t.codigo_trma='{1}';", frmRpt_anovigente, frmRpt_grupoTurma)
                End If
                '# RELATORIO...
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ListaAlunosPiloto.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\ListaAlunosPiloto.rpt")
                Else
                    crReportDocument = New ListaAlunosPiloto
                End If

            ElseIf SQL_Nome = ("Requerimento do Conselho") Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, boletim.nro_aluno, boletim.M, boletim.S, boletim.porcentagem, notasfreq.previsaoaulas, notasfreq.qtdadeaulas, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, file.file AS imagem FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.cod_bimestre='{0}' AND notasfreq.anovigente='{1}' AND aluno.anovigente='{1}';", frmRpt_bimestre, frmRpt_anovigente)
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = String.Format("SELECT CONVERT(CONCAT(LPAD(boletim.nro_aluno, 2, '0'), '.', aluno.nome) USING utf8) AS nome, escola.de, escola.nome AS nomeescola, boletim.nro_aluno, boletim.M, boletim.S, boletim.porcentagem, notasfreq.previsaoaulas, notasfreq.qtdadeaulas, notasfreq.cod_bimestre, disciplinas.disciplina, notasfreq.anovigente, turma.classe, file.file AS imagem FROM boletim LEFT OUTER JOIN notasfreq ON (boletim.cod_boletim = notasfreq.cod_nf) INNER JOIN aluno ON (aluno.turma = notasfreq.turma AND aluno.anovigente = notasfreq.anovigente) AND (boletim.nro_aluno = aluno.nro) INNER JOIN disciplinas ON (notasfreq.disciplina = disciplinas.codigo_disc) INNER JOIN turma ON (aluno.turma = turma.codigo_trma), escola INNER JOIN file ON escola.idFile = file.file_id WHERE notasfreq.turma='{0}' AND notasfreq.cod_bimestre='{1}' AND notasfreq.anovigente='{2}' AND aluno.anovigente='{2}';", frmRpt_grupoTurma, frmRpt_bimestre, frmRpt_anovigente)
                End If
                '# RELATORIO
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ListaAlunosReqCon.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\ListaAlunosReqCon.rpt")
                Else
                    crReportDocument = New ListaAlunosReqCon
                End If

            ElseIf SQL_Nome = ("Completa") Then

                If frmRpt_Tipo = "TurmaTodas" Then
                    SQL = "SELECT RM(aluno.ra,aluno.ra_digito) AS rm," _
                        & "aluno.anovigente AS anovigente, " _
                        & "aluno.nro AS nro_aluno, " _
                        & "aluno.nome AS nome, " _
                        & "aluno.status AS S, " _
                        & "CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, " _
                        & "aluno.data AS datanascimento, " _
                        & "turma.classe AS classe " _
                        & "FROM " _
                        & "aluno " _
                        & "INNER JOIN turma ON aluno.turma = codigo_trma " _
                        & "WHERE turma.bloqueado='0' AND aluno.anovigente='" & frmRpt_anovigente & "';"
                Else
                    frmRpt_grupoTurma = Consulta_Turma(frmRpt_grupoTurma)
                    SQL = "SELECT RM(aluno.ra,aluno.ra_digito) AS rm," _
                       & "aluno.anovigente AS anovigente, " _
                       & "aluno.nro AS nro_aluno, " _
                       & "aluno.nome AS nome, " _
                       & "aluno.status AS S, " _
                       & "CONCAT(aluno.ra,'-',aluno.ra_digito) AS ra, " _
                       & "aluno.data AS datanascimento, " _
                       & "turma.classe AS classe " _
                       & "FROM " _
                       & "aluno " _
                       & "INNER JOIN turma ON aluno.turma = turma.codigo_trma " _
                       & "WHERE turma.bloqueado='0' AND aluno.anovigente='" & frmRpt_anovigente & "' AND turma.codigo_trma='" & frmRpt_grupoTurma & "';"
                End If
                '# RELATORIO...
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\ListaAlunosCompleta.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\ListaAlunosCompleta.rpt")
                Else
                    crReportDocument = New ListaAlunosCompleta
                End If
            End If
            'FIM LISTA DE ALUNOS

        ElseIf (Modulo = "Histórico Escolar") Then

            If SQL_Nome = "Auxiliar" Then

                SQL = "SELECT " _
                      & "notasfreq.anovigente, aluno.nome, turma.classe, " _
                      & "disciplinas.disciplina, notasfreq.cod_bimestre, " _
                      & "boletim.M AS Avaliacao " _
                      & "FROM " _
                      & "aluno " _
                      & "INNER JOIN notasfreq ON notasfreq.turma = aluno.turma AND notasfreq.anovigente = aluno.anovigente " _
                      & "INNER JOIN disciplinas ON disciplinas.codigo_disc = notasfreq.disciplina " _
                      & "INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim AND aluno.nro = boletim.nro_aluno " _
                      & "INNER JOIN turma ON turma.codigo_trma = notasfreq.turma AND turma.codigo_trma = aluno.turma " _
                      & "WHERE (notasfreq.cod_bimestre='4AF' OR notasfreq.cod_bimestre='2AF') AND aluno.nome='" & frmRpt_nome & "' " _
                      & "ORDER BY notasfreq.anovigente ASC, notasfreq.cod_bimestre ASC, turma.classe ASC, disciplinas.disciplina ASC;"
                If (My.Computer.FileSystem.FileExists(meucaminhorelatorio & "\personalizado\HistoricoAuxiliar.rpt")) Then
                    crReportDocument.Load(meucaminhorelatorio & "\personalizado\HistoricoAuxiliar.rpt")
                Else
                    crReportDocument = New HistoricoAuxiliar
                End If

            End If

        End If

        SQL_frmRPT = SQL
        Return SQL

    End Function

    Public Function ExtractTextFromPDF(ByVal filePath As String) As String

        Dim documentText As String

        Try
            Using documentProcessor As New PdfDocumentProcessor()
                documentProcessor.LoadDocument(filePath)
                documentText = documentProcessor.Text

                'documentProcessor.Export(documentText, PdfFormDataFormat.Xml)
            End Using
        Catch
        End Try

        Return documentText

    End Function

    Public Function CarregaPreferencias(MeuSistema As String) As String



        ' CARREGA PREFERENCIAS REVENDA/ BD/ IP/ SITE - LEIA ARQUIVO CPSYSTEM.DLL
        ' MeuSistema = MeuSistema.Replace("", "")

        meucaminho = Mid(meucaminho, 1, 3)

        Dim objStream As New IO.FileStream(String.Format("{0}\{1}\cpSystem.dll", meucaminho, MeuSistema), IO.FileMode.Open)
        Dim Arq As New IO.StreamReader(objStream)
        Dim linhaTexto As String = Arq.ReadLine
        Dim i = 0

        While linhaTexto <> Nothing
            iPref(i) = linhaTexto
            i = i + 1
            linhaTexto = Arq.ReadLine
        End While
        Arq.Close()

        BD = iPref(0)
        IP = iPref(1)
        URL = iPref(2)
        REVENDA = iPref(3)
        FONE = iPref(4)

        CONEXAOBD = String.Format("server={0};user id=admsuporte;password=admauxcli;database={1};Allow User Variables=False;Convert Zero Datetime=true;", IP, BD)
        '& ";Allow User Variables=False" // Allow User Variables=False;Allow Zero Datetime=True

        Return CONEXAOBD


    End Function

    Public Function CarregaPreferencias2() As Array

        Dim Variaveis(5) As String

        Variaveis(0) = BD
        Variaveis(1) = IP
        Variaveis(2) = URL
        Variaveis(3) = REVENDA
        Variaveis(4) = FONE

        Return Variaveis

    End Function

    Public Function MaquinaRegistrar(MeuSistema As String, Nome As String, CNPJ As String, Responsavel As String)

        Dim Retorno

        '' *** Carrega as preferências ***
        'CarregaPreferencias(MeuSistema)

        'Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        'Dim IP_Local = GetIPv4Address().ToString
        'Dim IP_Hostname = Dns.GetHostName
        'Dim Preferencias As Array = CarregaPreferencias2()

        '' Consulta online situação do cliente ...
        'Try
        '    Retorno = WS_MaquinaAutorizada.Registrar(Nome, CNPJ, Responsavel, nics(0).GetPhysicalAddress.ToString, IP_Local, IP_Hostname, MeuSistema, Preferencias(1))
        'Catch ex As Exception

        'End Try

        Return Retorno

    End Function

End Module
