Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Module MaisEscola

    'VARIAVEIS DE SISTEMA
    Friend BD_OK
    Friend IP_OK
    Friend IP_GDAE
    Friend AnoVigente
    Friend Clicou = 0
    Friend CONEXAOBD
    Friend UsuarioSistema
    Friend VERSAO
    'FIM DAS VARIAVEIS DE SISTEMA

    Friend Media
    Friend Falta
    Friend AC
    Friend PR
    Friend EJA

    Friend myCommand As New MySqlCommand()
    Friend myAdapter As New MySqlDataAdapter()
    Friend myData As New DataTable()
    Friend r As DataRow
    Friend rc As Integer
    Friend SQL As String

    Friend myCommand2 As New MySqlCommand()
    Friend myAdapter2 As New MySqlDataAdapter()
    Friend myData2 As New DataTable()
    Friend r2 As DataRow
    Friend rc2 As Integer
    Friend SQL2 As String

    Friend myCommand3 As New MySqlCommand()
    Friend myAdapter3 As New MySqlDataAdapter()
    Friend myData3 As New DataTable()
    Friend r3 As DataRow
    Friend rc3 As Integer
    Friend SQL3 As String

    Friend myCommand4 As New MySqlCommand()
    Friend myAdapter4 As New MySqlDataAdapter()
    Friend myData4 As New DataTable()
    Friend r4 As DataRow
    Friend rc4 As Integer
    Friend SQL4 As String

    Friend myCommand5 As New MySqlCommand()
    Friend myAdapter5 As New MySqlDataAdapter()
    Friend myData5 As New DataTable()
    Friend r5 As DataRow
    Friend rc5 As Integer
    Friend SQL5 As String

    Friend myCommand6 As New MySqlCommand()
    Friend myAdapter6 As New MySqlDataAdapter()
    Friend myData6 As New DataTable()
    Friend r6 As DataRow
    Friend rc6 As Integer
    Friend SQL6 As String

    Friend myCommand7 As New MySqlCommand()
    Friend myAdapter7 As New MySqlDataAdapter()
    Friend myData7 As New DataTable()
    Friend r7 As DataRow
    Friend rc7 As Integer
    Friend SQL7 As String

    Friend myCommand8 As New MySqlCommand()
    Friend myAdapter8 As New MySqlDataAdapter()
    Friend myData8 As New DataTable()
    Friend r8 As DataRow
    Friend rc8 As Integer
    Friend SQL8 As String

    Friend myCommand9 As New MySqlCommand()
    Friend myAdapter9 As New MySqlDataAdapter()
    Friend myData9 As New DataTable()
    Friend r9 As DataRow
    Friend rc9 As Integer
    Friend SQL9 As String

    Friend meuboletim
    Friend meucaminho

    'CADASTRAR BOLETIM - NOTAS E FREQUENCIAS
    Friend AnoVigenteNF = 0
    Friend NomeDisciplinaNF
    Friend NomeTurmaNF
    Friend BoletimNF
    Friend meuboletimNF
    Friend qtdadeaulasNF
    Friend qtdadeaulas
    Friend EJANF

    'CADNF => BOLETIM
    Friend nroTurmaAluno = 0

    'frmGDAEMenu
    Friend iAV(0 To 100) As Integer
    Friend iFT(0 To 100) As Integer
    Friend iACT(0 To 100) As Integer
    Friend iPRT(0 To 100) As String
    Friend iTRT(0 To 100) As Boolean

    Friend contadorTransf = 1
    Friend nroTotalAlunos = 1
    Friend ifolha = 0
    Friend inicio = 1
    Friend final = 0
    Public travaProcessos = 99
    Friend ClasseDisciplinaAtual As String
    Friend ControleTransferir = 0
    Friend AulasDadas = 0
    Friend AulasPrevistas = 0

    Friend CodigoSEE = 0
    'FIM frmGDAEMenu

    'frmManGRADE
    Friend nomeDisciplina As String
    Friend nroDisciplina As Integer
    'FIM frmManGRADE

    'frmGerencialNOME
    Friend selecionaNome = ""
    Friend selecionaCodigo As Integer
    Friend selecionaNomeID As Integer
    Friend selecionaNomeTr As String
    Friend selecionaNomeNroTr As Integer
    Friend selecionaNomeAno As String
    Friend selecionaNomeNro As Integer
    Friend iProcura = 0
    'fim frmGERENCIALNOME

    ' FORM GRAFICO : TURMAS : GRUPO
    Friend grupoTurmas
    Friend grupoPeriodo
    Friend grupoAnoVigente

    ' FORM PROGRESSAO DE DADOS
    Friend pInicio = 0

    ' FORM PARA TROCA DE BOLETIM (NF)
    Friend nroBoletim = 0
    Friend nroTurmaT = 0

    ' FORM MANUTENCAO BOLETIM
    Friend nroManNF = 0

    'cria um array de 8-byte para a chave privada
    Public aChave(7) As Byte

    'preenche o vetor de inicialização com alguns valores aleatórios
    Private Vector() As Byte = {&H12, &H44, &H16, &HEE, &H88, &H15, &HDD, &H41}

    Public Function pegaHTML(ByVal URL2)
        ' Retorna o HTML da URL informada
        Dim objWC As New System.Net.WebClient
        Return New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL2))
    End Function

    Sub Codifica(ByVal inName As String, ByVal outName As String)
        Try
            Dim storage(4096) As Byte             'cria um buffer
            Dim totalBytesEscritos As Long = 8  'bytes escritos

            Dim tamanhoPacote As Integer         'determina o numero de bytes escritos de uma vez

            'Declara os arquivos  streams. 
            Dim arqEntrada As New FileStream(inName, FileMode.Open, FileAccess.Read)
            Dim arqSaida As New FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write)
            arqSaida.SetLength(0)

            Dim comprimentoTotalArquivo As Long = arqEntrada.Length       'Define o tamanho do arquivo fonte

            'cria um objeto cripto
            Dim des As New DESCryptoServiceProvider
            Dim crStream As New CryptoStream(arqSaida, des.CreateEncryptor(aChave, Vector), CryptoStreamMode.Write)

            'fluxo de stream
            While totalBytesEscritos < comprimentoTotalArquivo
                tamanhoPacote = arqEntrada.Read(storage, 0, 4096)
                crStream.Write(storage, 0, tamanhoPacote)
                totalBytesEscritos = Convert.ToInt32(totalBytesEscritos + tamanhoPacote / des.BlockSize * des.BlockSize)
            End While

            crStream.Close()
            arqEntrada.Close()
            arqSaida.Close()

        Catch e As Exception
            MsgBox(e.Message)
        End Try

    End Sub

    Sub DeCodifica(ByVal inName As String, ByVal outName As String)

        Try

            Dim storage(4096) As Byte
            Dim totalBytesEscritos As Long = 8
            Dim tamanhoPacote As Integer
            Dim arqEntrada As New FileStream(inName, FileMode.Open, FileAccess.Read)
            Dim arqSaida As New FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write)

            arqSaida.SetLength(0)

            Dim comprimentoTotalArquivo As Long = arqEntrada.Length
            'instancia um objeto para cifrar
            Dim des As New DESCryptoServiceProvider
            Dim crStream As New CryptoStream(arqSaida, des.CreateDecryptor(aChave, Vector), CryptoStreamMode.Write)

            'Dim ex As Exception

            While totalBytesEscritos < comprimentoTotalArquivo
                tamanhoPacote = arqEntrada.Read(storage, 0, 4096)
                crStream.Write(storage, 0, tamanhoPacote)
                totalBytesEscritos = Convert.ToInt32(totalBytesEscritos + tamanhoPacote / des.BlockSize * des.BlockSize)
                Console.WriteLine("Processed {0} bytes, {1} bytes total", tamanhoPacote, totalBytesEscritos)
            End While

            crStream.Close()
            arqEntrada.Close()
            arqSaida.Close()

        Catch e As Exception
            'MsgBox(e.Message & "  Verifique se esta usando a senha correta.")
        End Try

    End Sub

    Sub criaChave(ByVal strKey As String)

        ' array de Byte para tratar a senha
        Dim arrByte(7) As Byte

        Dim AscEncod As New ASCIIEncoding
        Dim i As Integer = 0
        AscEncod.GetBytes(strKey, i, strKey.Length, arrByte, i)

        'obtem o valor do hash da senha
        Dim hashSha As New SHA1CryptoServiceProvider
        Dim arrHash() As Byte = hashSha.ComputeHash(arrByte)

        'poe o valor do hash na chave
        For i = 0 To 7
            aChave(i) = arrHash(i)
        Next i
    End Sub

    Public Function atualizaMySQL(ByVal query As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(CONEXAOBD)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Function

End Module
