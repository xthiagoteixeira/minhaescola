Imports System.DBNull
Imports System.Data
Imports System.IO
Imports System
Imports MySql.Data.MySqlClient

Public Class frmPrincipal

    Dim URL_OK, FONE_OK, REVENDA_OK

    Dim info As New cpInfo.psInfo

    Dim ferramenta1
    Dim ferramenta2
    Dim ferramenta4
    Dim ferramenta6

    Public Shared fGDAELogin = New frmGDAELogin
    Public Shared fFerOpcoes = New frmFerOpcoes
    Public Shared fBoletimWeb = New frmBoletimWeb

    Public Shared fGerencialBolMovel = New frmGerencialBolMovel
    Public Shared fGerencialDCL = New frmGerencialDCL
    Public Shared fImpBoletim2 = New frmImpBoletim2

    Public Shared fCadBoletim = New frmCadBoletim
    Public Shared fConBoletim = New frmConBoletim
    Public Shared fManBoletim = New frmManBoletim

    Public Shared fConDisciplinas = New frmConDisciplinas
    Public Shared fManDisciplinas = New frmManDisciplinas

    Public Shared fCadNF = New frmCadNF
    Public Shared fBolsas = New frmBolsas

    Public Shared fCadProfessor = New frmCadAluno
    Public Shared fCadAlunoFicha = New frmCadAlunoFicha
    Public Shared fConProfessor = New frmConProfessor
    Public Shared fManProfessor = New frmManAluno

    Public Shared fConTurma = New frmConturma
    Public Shared fManTurma = New frmManTurma

    Public Shared fGerencial2 = New frmGerencial2
    Public Shared fGerencialRPT = New frmRpt

    Public Shared fManACP = New frmManACP
    Public Shared fManNF = New frmManNF
    Public Shared fManGerarAF = New frmManGerarAF
    Public Shared fManAulasPrevistas = New frmManAulasPrevistas
    Public Shared fManUltimoAluno = New frmManUltimoAluno

    Public Shared fImportarAlunos = New Importacao
    Public Shared fImportarAlunos2 = New Importacao2

    Public Shared fGerenciadorRPT = New frmGerencialRPT
    Public Shared fGerenciadorRPT2 = New frmRptNF
    Public Shared fSobre = New frmSobre
    Public Shared fSobreEscola = New frmSobreEscola
    Public Shared fSobre2 = New frmSobre2

    Private Sub frmMaisEscola_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End

    End Sub

    Private Sub frmMaisEscola_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        meucaminho = My.Computer.FileSystem.CurrentDirectory

        Try
            ' CARREGA AS PREFERENCIAS DO USUARIO / FUNDO DE TELA/ ETC...
            Dim myRegKey3 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("MicroD.Vms")
            myRegKey3 = myRegKey3.OpenSubKey("Classes")
            ferramenta1 = myRegKey3.GetValue("ferramenta1")
            ferramenta2 = myRegKey3.GetValue("ferramenta2")
            ferramenta4 = myRegKey3.GetValue("ferramenta4")

            ' BANCO DE DADOS...
            ferramenta6 = myRegKey3.GetValue("ferramenta6")

        Catch ex As Exception

            ' Preferencias a serem gravadas, caso nao exista
            Dim cRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("MicroD.Vms")
            cRegistryKey = cRegistryKey.CreateSubKey("Classes")
            cRegistryKey.SetValue("ferramenta1", "1")
            cRegistryKey.SetValue("ferramenta2", "")
            cRegistryKey.SetValue("ferramenta3", "1")
            cRegistryKey.SetValue("ferramenta6", "5")

            ferramenta1 = cRegistryKey.GetValue("ferramenta1")
            ferramenta2 = cRegistryKey.GetValue("ferramenta2")
            ferramenta4 = cRegistryKey.GetValue("ferramenta4")

        End Try
        ' FIM DAS PREFERENCIAS

        ' BARRA DE FERRAMENTAS...
        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim URL As Object = myRegKey2.GetValue("site")
            Dim FONE As Object = myRegKey2.GetValue("fone")
            Dim REVENDA As Object = myRegKey2.GetValue("revenda")

            URL_OK = URL
            FONE_OK = FONE
            REVENDA_OK = REVENDA

            StatusBar2.Text = "Mais Escola - Versão " & VERSAO & " | " & URL_OK & " | Revenda: " & REVENDA_OK & " | Atendimento: " & FONE_OK & " | " & Format(Date.Today, "dd/MM/yyyy")

        Catch ex As Exception
        End Try
        ' FIM

        ' #################################### INICIO DO MENU USUARIO
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try

                Try
                    myData.Clear()
                    sql = "SELECT * FROM usuariodsk WHERE usuario='" & UsuarioSistema & "'"
                    myCommand.Connection = conn
                    myCommand.CommandText = sql
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)
                    r = myData.Rows(0)

                Catch ex As Exception
                End Try

                '''''''''''''''''''''''' MENU DO USUARIO
                If r("cod_prof") = 0 Then
                    novaBarra.Visible = True
                    'mNF3.Visible = False

                    nAdministrativo.Visible = True
                    nNF.Visible = True
                    nRelatorios.Visible = True
                    nSobre.Visible = True
                    nAjuda.Visible = True

                Else
                    ' Libera somente para cadastro das notas e relatorios
                    novaBarra.Visible = True
                    nAdministrativo.Visible = False
                    nNF.Visible = True
                    nRelatorios.Visible = True
                    nSobre.Visible = True
                    nAjuda.Visible = True

                End If
                tProfe.Text = r("cod_prof")

            Catch myerro As MySqlException
            End Try
            conn.Close()
        Catch myerro As MySqlException
        Finally
            conn.Dispose()
        End Try

        Try
            Dim URL2 = "http://suporte.isolucao.com.br/medown/processo.txt"
            Dim Procedimento = CInt(pegaHTML(URL2))

            If Procedimento > 0 Or ferramenta6 = 1 Then
                System.Diagnostics.Process.Start(meucaminho & "\Manutencao ME.exe")
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ButtonItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem47.Click
        ppropaganda2.Visible = False

        fImportarAlunos = New Importacao
        fImportarAlunos.MdiParent = Me
        fImportarAlunos.Show()
    End Sub

    Private Sub ButtonItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem48.Click
        ppropaganda2.Visible = False

        fImportarAlunos2 = New Importacao2
        fImportarAlunos2.MdiParent = Me
        fImportarAlunos2.Show()
    End Sub

    Private Sub ButtonItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem44.Click
        ppropaganda2.Visible = False

        fCadProfessor = New frmCadAluno
        fCadProfessor.MdiParent = Me
        fCadProfessor.Show()
    End Sub

    Private Sub ButtonItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem45.Click
        ppropaganda2.Visible = False

        fConProfessor = New frmConProfessor
        fConProfessor.MdiParent = Me
        fConProfessor.Show()
    End Sub

    Private Sub ButtonItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem46.Click
        ppropaganda2.Visible = False

        fManProfessor = New frmManAluno
        fManProfessor.MdiParent = Me
        fManProfessor.Show()
    End Sub

    Private Sub ButtonItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem49.Click
        ppropaganda2.Visible = False

        fCadNF = New frmCadNF
        fCadNF.MdiParent = Me
        fCadNF.Show()
    End Sub

    Private Sub ButtonItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem50.Click
        ppropaganda2.Visible = False

        fConBoletim = New frmConBoletim
        fConBoletim.MdiParent = Me
        fConBoletim.Show()
    End Sub

    Private Sub ButtonItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem52.Click
        ppropaganda2.Visible = False

        Dim b
        b = tProfe.Text

        fManAulasPrevistas = New frmManAulasPrevistas
        fManAulasPrevistas.MdiParent = Me
        fManAulasPrevistas.Show()
    End Sub

    Private Sub ButtonItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem53.Click
        ppropaganda2.Visible = False

        fManACP = New frmManACP
        fManACP.MdiParent = Me
        fManACP.Show()
    End Sub

    Private Sub ButtonItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem54.Click
        ppropaganda2.Visible = False

        Dim b
        b = tProfe.Text
        fManNF = New frmManNF
        fManNF.MdiParent = Me
        fManNF.Show()
    End Sub

    Private Sub ButtonItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem55.Click
        ppropaganda2.Visible = False
        fManUltimoAluno = New frmManUltimoAluno
        fManUltimoAluno.MdiParent = Me
        fManUltimoAluno.Show()
    End Sub

    Private Sub ButtonItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem56.Click
        ppropaganda2.Visible = False

        fManDisciplinas = New frmManDisciplinas
        fManDisciplinas.MdiParent = Me
        fManDisciplinas.Show()
    End Sub

    Private Sub ButtonItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem57.Click
        ppropaganda2.Visible = False

        fConDisciplinas = New frmConDisciplinas
        fConDisciplinas.MdiParent = Me
        fConDisciplinas.Show()
    End Sub

    Private Sub ButtonItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem58.Click
        ppropaganda2.Visible = False

        fManDisciplinas = New frmManDisciplinas
        fManDisciplinas.MdiParent = Me
        fManDisciplinas.Show()
    End Sub

    Private Sub ButtonItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem59.Click
        ppropaganda2.Visible = False

        fManTurma = New frmManTurma
        fManTurma.MdiParent = Me
        fManTurma.Show()
    End Sub

    Private Sub ButtonItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem60.Click
        ppropaganda2.Visible = False

        fConTurma = New frmConturma
        fConTurma.MdiParent = Me
        fConTurma.Show()
    End Sub

    Private Sub ButtonItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem61.Click
        ppropaganda2.Visible = False

        fManTurma = New frmManTurma
        fManTurma.MdiParent = Me
        fManTurma.Show()
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        ppropaganda2.Visible = False

        fGerencial2 = New frmGerencial2
        fGerencial2.MdiParent = Me
        fGerencial2.Show()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        ppropaganda2.Visible = False

        Dim b
        b = tProfe.Text

        fCadNF = New frmCadNF
        fCadNF.MdiParent = Me
         fCadNF.Show()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        ppropaganda2.Visible = False

        fConBoletim = New frmConBoletim
        fConBoletim.MdiParent = Me
        fConBoletim.Show()
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        ppropaganda2.Visible = False

        Dim b
        b = tProfe.Text
        fManNF = New frmManNF
        fManNF.MdiParent = Me
        fManNF.Show()
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        ppropaganda2.Visible = False

        fImpBoletim2 = New frmImpBoletim2
        fImpBoletim2.MdiParent = Me
        fImpBoletim2.Show()
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        ppropaganda2.Visible = False
        System.Diagnostics.Process.Start(meucaminho & "\Mais Escola - Trazer Notas!.exe")

    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        ppropaganda2.Visible = False
        fGDAELogin = New frmGDAELogin
        fGDAELogin.MdiParent = Me
        fGDAELogin.Show()
    End Sub

    Private Sub ACCompleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACCompleto.Click
        ppropaganda2.Visible = False

        Dim w
        w = "Alunos"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub ACReuniaodePais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACReuniaodePais.Click
        ppropaganda2.Visible = False

        Dim w
        w = "AlunosAssinatura"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem31.Click
        ppropaganda2.Visible = False

        Dim w
        w = "ConsolidadoCompleto"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click
        ppropaganda2.Visible = False

        Dim w
        w = "Consolidado"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub ButtonItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem35.Click
        ppropaganda2.Visible = False

        Dim w
        w = "TGraficos"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub ButtonItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem38.Click
        ppropaganda2.Visible = False

        Dim w
        w = "ABEvasaoEscolar"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub ButtonItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem39.Click
        ppropaganda2.Visible = False

        Dim w
        w = "LSEvasaoEscolar"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub ButtonItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem40.Click
        ppropaganda2.Visible = False

        Dim w
        w = "LGEvasaoEscolar"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub ButtonItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem41.Click
        ppropaganda2.Visible = False

        Dim w
        w = "FAEvasaoEscolar"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub ButtonItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem42.Click
        ppropaganda2.Visible = False


        Dim w
        w = "REEvasaoEscolar"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub ButtonItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem43.Click
        ppropaganda2.Visible = False

        Dim w
        w = "TREvasaoEscolar"
        Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        ppropaganda2.Visible = False

        fGerenciadorRPT = New frmGerencialRPT
        fGerenciadorRPT.MdiParent = Me
        fGerenciadorRPT.Show()
    End Sub

    Private Sub Desenvolvedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desenvolvedor.Click
        ppropaganda2.Visible = False

        fSobre = New frmSobre
        fSobre.MdiParent = Me
        fSobre.Show()
    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        ppropaganda2.Visible = False
        fSobreEscola = New frmSobreEscola
        fSobreEscola.MdiParent = Me
        fSobreEscola.Show()
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        ppropaganda2.Visible = False

        fSobre2 = New frmSobre2
        fSobre2.MdiParent = Me
        fSobre2.Show()
    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        System.Diagnostics.Process.Start("http://suporte.isolucao.com.br/medown/Manual.pdf")

    End Sub

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click
        System.Diagnostics.Process.Start("http://www.isolucao.com")
    End Sub

    Private Sub ButtonItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem62.Click
        ppropaganda2.Visible = False

        fManGerarAF = New frmManGerarAF
        fManGerarAF.MdiParent = Me
        fManGerarAF.Show()
    End Sub

    Private Sub ButtonItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ppropaganda2.Visible = False

        Dim w
        w = "AFConsolidado"
        'Clicou = 1

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        ppropaganda2.Visible = False

        fGerenciadorRPT = New frmGerencialRPT
        fGerenciadorRPT.cbRelatorio.Text = "Boletim"
        fGerenciadorRPT.cbRelatorio.Enabled = False
        fGerenciadorRPT.MdiParent = Me
        fGerenciadorRPT.Show()

    End Sub

    Private Sub ButtonItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem64.Click
        ppropaganda2.Visible = False

        fGerenciadorRPT = New frmGerencialRPT
        fGerenciadorRPT.cbRelatorio.Text = "Ficha Individual"
        fGerenciadorRPT.cbRelatorio.Enabled = False
        fGerenciadorRPT.MdiParent = Me
        fGerenciadorRPT.Show()
    End Sub

    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem28.Click

        ppropaganda2.Visible = False

        'Abre a Atualizacao!
        System.Diagnostics.Process.Start(meucaminho & "\Mais Escola - Atualiza!.exe")

    End Sub

    Private Sub ButtonItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem29.Click
        ppropaganda2.Visible = False

        Dim w
        w = "Graficos"
        'Clicou = 1
        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub frmGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmGrupos.Click
        'Gráficos - Grupos
        ppropaganda2.Visible = False

        fGerenciadorRPT2 = New frmRptNF
        fGerenciadorRPT2.MdiParent = Me
        fGerenciadorRPT2.Show()
    End Sub

    Private Sub ButtonItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        System.Diagnostics.Process.Start("http://suporte.isolucao.com.br/medown/ManualProfessor.pdf")
    End Sub

    Private Sub ButtonItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click

        Try
            System.Diagnostics.Process.Start(meucaminho & "\crossloopsetup.exe")
        Catch ex As Exception
            MsgBox("Programa de instalação não encontrado!", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub ButtonItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem65.Click

        Try
            'Para abrir o programa
            Dim cRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software")
            cRegistryKey = cRegistryKey.OpenSubKey("CrossLoop")
            cRegistryKey = cRegistryKey.OpenSubKey("CrossLoopConnect")
            cRegistryKey = cRegistryKey.OpenSubKey("Options")
            Dim ferramentaCrossLoop = cRegistryKey.GetValue("Run")

            'criar arquivo bat.
            Dim arquivoCL = "cl.bat"
            Dim objStreamT As New System.IO.FileStream(arquivoCL, IO.FileMode.Create)
            Dim ArqCL As New System.IO.StreamWriter(objStreamT)
            Dim myTextoF1, myTextoF2, myTextoF3, myTextoF4

            myTextoF1 = "@echo off"
            myTextoF2 = "start " & ferramentaCrossLoop
            myTextoF3 = "cls"
            myTextoF4 = "@exit"

            ArqCL.WriteLine(myTextoF1)
            ArqCL.WriteLine(myTextoF2)
            ArqCL.WriteLine(myTextoF3)
            ArqCL.WriteLine(myTextoF4)
            ArqCL.Close()

            Dim myprocessD As System.Diagnostics.Process = New System.Diagnostics.Process()
            myprocessD.StartInfo.FileName = arquivoCL
            myprocessD.Start()
        Catch ex As Exception
            MsgBox("Programa de suporte não instalado.", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ButtonItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem66.Click
        ppropaganda2.Visible = False

        fGerencialBolMovel = New frmGerencialBolMovel
        fGerencialBolMovel.MdiParent = Me
        fGerencialBolMovel.Show()
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        ppropaganda2.Visible = False
        fFerOpcoes = New frmFerOpcoes
        fFerOpcoes.MdiParent = Me
        fFerOpcoes.Show()
    End Sub

    Private Sub ButtonItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem67.Click
        ppropaganda2.Visible = False
        fBoletimWeb = New frmBoletimWeb
        fBoletimWeb.MdiParent = Me
        fBoletimWeb.Show()
    End Sub

    Private Sub ButtonItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFichaCompleta.Click

        ppropaganda2.Visible = False
        fCadAlunoFicha = New frmCadAlunoFicha
        fCadAlunoFicha.MdiParent = Me
        fCadAlunoFicha.Show()

    End Sub

    Private Sub ButtonItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem69.Click

        ppropaganda2.Visible = False
        fGerencialDCL = New frmGerencialDCL
        fGerencialDCL.MdiParent = Me
        fGerencialDCL.Show()

    End Sub

    Private Sub ButtonItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem32.Click

        ppropaganda2.Visible = False
        fBolsas = New frmBolsas
        fBolsas.MdiParent = Me
        fBolsas.Show()

    End Sub

End Class