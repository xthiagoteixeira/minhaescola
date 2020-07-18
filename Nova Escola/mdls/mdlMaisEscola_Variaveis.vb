Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text

Module mdlMaisEscola_Variaveis
    '##### ARQUIVOS .INI #####
    Friend Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Friend Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Friend nome_arquivo_ini As String = nomeArquivoINI()
    Friend MaisEscolaINI_Fundo

    Friend SuporteRapido As Process

    Friend SQL_Sub
    Friend SQL
    Friend Preferencias As Array

    'frmAtendimento
    Friend Escola_Sistema
    Friend iUltimoNotasFreqProf As Integer

    'FRM ALUNOS_IMPORTACAO
    Friend importacao_alunos As String

    'MENSAGEM DO SISTEMA
    Friend Erro_Form As String
    Friend Erro_Mensagem As String
    Friend Erro_Enviar As Boolean
    Friend Erro_BotaoTexto As String

    ' frmGerAlunosPublicar
    Friend linha = String.Empty
    Friend contador = 0
    Friend EnvioContadorArquivos = 0
    Friend EnvioContadorDiretorios = 0

    'VARIAVEIS DE SISTEMA
    Friend DataSistema As Date
    Friend Sistema = "Mais Escola!"
    Friend AnoVigente
    Friend Clicou = 0
    Friend CONEXAOBD
    Friend UsuarioSistema
    Friend idUsuarioDSK
    Friend VERSAO
    Friend UsuarioWeb, SenhaWeb
    '
    ' FIM DAS VARIAVEIS DE SISTEMA...

    Friend meuboletim
    Friend meucaminho, meucaminhorelatorio

    'frmCadAlunoCompleta
    Friend fCadAlunoFichaCompleta_RM, fCadAlunoFichaCompleta_Aluno, fCadAlunoFichaCompleta_RA, fCadAlunoFichaCompleta_RAd, fCadAlunoFichaCompleta_Nascimento

    ' CADASTRAR BOLETIM - NOTAS E FREQUENCIAS...
    '
    Friend AnoVigenteNF = 0

    'CADNF => BOLETIM
    Friend nroTurmaAluno = 0

    'frmGDAEMenu
    Friend iAV(100) As String
    Friend iFT(100) As Integer
    Friend iACT(100) As Integer
    Friend iPRT(100) As String
    Friend iTRT(100) As Boolean

    Friend contadorTransf = 1
    Friend nroTotalAlunos = 1
    Friend ifolha = 0
    Friend inicio = 1
    Friend final = 0
    Public travaProcessos = 99
    Friend ControleTransferir = 0
    Friend AulasDadas = 0
    Friend AulasPrevistas = 0

    Friend CodigoSEE = 0
    Friend ControleGDAE = 0
    'FIM frmGDAEMenu

    'frmBWTrazer
    Friend CodigoEscola


    ' FORM GRAFICO : TURMAS : GRUPO
    Friend grupoTurmas
    Friend grupoPeriodo

    ' FORM PROGRESSAO DE DADOS
    Friend pInicio = 0

    ' FORM MANUTENCAO BOLETIM
    Friend ManNF_Global_nro, ManNF_Global_qtaulas, ManNF_Global_AnoVigente As String
    Friend ManNF_Global_Boletim_Existe As Boolean

    ' FORM frmRPT
    Friend frmRpt_Parametro As String
    Friend frmPreview_Titulo As String
    Friend frmRpt_bimestre
    Friend grupoAlunos As String

    Friend frmRpt_existe = True

    Friend frmRpt_Tipo As String
    Friend AlunosGrupo As String = String.Empty
    Friend SQL_frmRPT As String
    Friend frmRpt_grupoCompara

    Friend frmRpt_codigo
    Friend frmRpt_anovigente

    Friend frmRpt_grupoTurma As String
    Friend frmRpt_nome

    ' FORM frmManAulasPrevistas
    Friend Man_AulasPrevistas_nro, Man_AulasPrevistas_qtdade, Man_AulasPrevistas_previsao
    Friend Man_AulasPrevistas_disciplina, Man_AulasPrevistas_turma, Man_AulasPrevistas_nroalunos
    Friend crReportDocument
    Friend reportDocument
    Friend reportDocument_dataset

    'Friend crReportDocument_Sub As String

    ' cria um array de 8-byte para a chave privada
    Friend aChave(7) As Byte

    'preenche o vetor de inicialização com alguns valores aleatórios
    Friend MeuSistema = "MaisEscola"

    ' Friend MeuCore As New cpCore.Core_Chk
    ' Friend MeuCore_Configuracao As New nvCore.Local

    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\Friend MeuCore As New nvCore.Local

    'Friend MeuCore_Configuracao As New nvCore.Local
    'Friend MeuCore_Atualiza As New cpCore.WS_Admin

    Friend NotaMaxima = 31

    Friend ManNF_Global_Disciplina, ManNF_Global_Turma, ManNF_Global_qtaulasprevistas, ManNF_Global_Boletim, BD

    Friend IP, ESTACAO, BANCO, URL, REVENDA, FONE, LICENCA, IP_Nome, CNPJ
    Friend iPref(10) As String

End Module