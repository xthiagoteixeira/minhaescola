Imports System.Net
Imports DevExpress.XtraBars
Imports DevExpress.XtraNavBar
Imports Mais_Escola.WS_MaisEscola_Web

Public Class frmPrincipal

    Public Sub AjustaFundo()

        Try
            BackgroundImageLayout = ImageLayout.None
            BackgroundImageLayout = ImageLayout.Zoom
        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmMaisEscola_Novo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnoVigente = Format(Date.Now, "yyyy")
        bwMaisEscola.RunWorkerAsync()

        ' .... Configurações na barra de Status ....
        Preferencias = CarregaPreferencias2()

        barraVersao.Caption = "Versão: " & My.Application.Info.Version.ToString
        barraUsuario.Caption = "Usuário: " & UsuarioSistema
        barraConectado.Caption = "Conectado: " & Preferencias(1)
        barraComputador.Caption = "Meu Computador: " & Dns.GetHostName


    End Sub

    Private Sub navAdministrativo_Alunos_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_Alunos.LinkClicked
        popupAdmAlunos.ShowPopup(Control.MousePosition)
    End Sub

    Private Sub navAdministrativo_Boletins_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_Boletins.LinkClicked
        popupAdmBoletins.ShowPopup(Control.MousePosition)

    End Sub

    Private Sub navAdministrativo_Backup_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_Backup.LinkClicked
        Dim fAdmFerBackup As New frmUtilBackup() With {.MdiParent = Me}
        fAdmFerBackup.Show()

    End Sub

    Private Sub navAdministrativo_Bolsas_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_Bolsas.LinkClicked
        Dim fAdmBolsas As New FrmAdmBolsas() With {.MdiParent = Me}
        fAdmBolsas.Show()
    End Sub

    Private Sub navAdministrativo_CopiarColar_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_CopiarColar.LinkClicked
        Me.WindowState = FormWindowState.Minimized
        frmCopiarColar.Show()
    End Sub

    Private Sub navAdministrativo_Disciplinas_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_Disciplinas.LinkClicked
        Dim fManDisciplinas As New frmAdmDisciplinas() With {.MdiParent = Me}
        fManDisciplinas.Show()
    End Sub

    Private Sub navAdministrativo_EditorTexto_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_EditorTexto.LinkClicked
        Dim fUtilTexto As New frmUtilTexto(False, String.Empty)
        fUtilTexto.Show()
    End Sub

    Private Sub navAdministrativo_Eventos_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_Eventos.LinkClicked
        Dim fGerencialL As New frmUtilEventos() With {.MdiParent = Me}
        fGerencialL.Show()
    End Sub

    Private Sub navAdministrativo_Planilha_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_Planilha.LinkClicked
        ' Dim fUtilPlanilha As New frmUtilPlanilha()
        frmUtilPlanilha.Show()
    End Sub

    Private Sub navAdministrativo_Turmas_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navAdministrativo_Turmas.LinkClicked
        Dim fManTurma As New frmAdmTurma() With {.MdiParent = Me}
        fManTurma.Show()
    End Sub

    Private Sub frmMaisEscola_Novo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            SuporteRapido.Kill()
        Catch ex As Exception
        End Try
        Try
            Environment.Exit(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub popupAdmAlunos_Importar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmAlunos_Importar.ItemClick
        Dim fImportarAlunos As New frmImpListas() With {.MdiParent = Me}
        fImportarAlunos.Show()
    End Sub

    Private Sub popupAdmAlunos_FichaAluno_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmAlunos_FichaAluno.ItemClick
        Dim fCadAluno As New frmCadAlunoFichaSimples() With {.MdiParent = Me}
        fCadAluno.Show()
    End Sub

    Private Sub popupAdmAlunos_Delib11_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmAlunos_Delib11.ItemClick
        Dim fAdmDelib11Ficha As New frmAdmDelib11Ficha() With {.MdiParent = Me}
        fAdmDelib11Ficha.Show()
    End Sub

    Private Sub popupAdmBoletins_AplicarEvasao_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmBoletins_AplicarEvasao.ItemClick
        '/ Aplicar Evasão Escolar...
        Dim fAdmBEVAplicar As New frmAdmBevAplicar() With {.MdiParent = Me}
        fAdmBEVAplicar.Show()
    End Sub

    Private Sub popupAdmBoletins_AulasDadasPrevistas_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmBoletins_AulasDadasPrevistas.ItemClick
        Dim fManAulasPrevistas As New frmManAulasPrevistas() With {.MdiParent = Me}
        fManAulasPrevistas.Show()
    End Sub

    Private Sub popupAdmBoletins_BoletinsAtraso_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmBoletins_BoletinsAtraso.ItemClick
        Dim fGerencialBolAtraso As New frmGerencialBolAtraso() With {.MdiParent = Me}
        fGerencialBolAtraso.Show()
    End Sub

    Private Sub popupAdmBoletins_Cadastro_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmBoletins_Cadastro.ItemClick
        Dim fCadNF As New frmCadBoletimTela() With {.MdiParent = Me}
        fCadNF.Show()
    End Sub

    Private Sub popupAdmBoletins_GerarAF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmBoletins_GerarAF.ItemClick
        Dim fManGerarAF As New frmManGerarAF() With {.MdiParent = Me}
        fManGerarAF.Show()
    End Sub

    Private Sub popupAdmBoletins_Manutencao_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupAdmBoletins_Manutencao.ItemClick
        Dim fManNF As New frmManBoletimTela() With {.MdiParent = Me}
        fManNF.Show()
    End Sub

    Private Sub popupMaisProf_Turma_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupMaisProf_Turma.ItemClick
        ' Atribuição ( por Sala )
        SQL_frmRPT = meuRPT2("Atribuição", "Turma")
        'Dim fRpt_Auxiliar As New frmRpt_Auxiliar() With {.MdiParent = Me}
        'Me.WindowState = FormWindowState.Minimized
        frmRpt_Auxiliar.Show()
    End Sub

    Private Sub popupMaisProf_Professores_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popupMaisProf_Professores.ItemClick
        ' Atribuição ( por Professores )
        SQL_frmRPT = meuRPT2("Atribuição", "Professor")
        'Dim fRpt_Auxiliar As New frmRpt_Auxiliar() With {.MdiParent = Me}
        'Me.WindowState = FormWindowState.Minimized
        frmRpt_Auxiliar.Show()
    End Sub

    Private Sub navMaisProfessor_Atribuição_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navMaisProfessor_Atribuição.LinkClicked
        popupMaisProfAtribuicao.ShowPopup(Control.MousePosition)
    End Sub

    Private Sub navMaisProfessor_GerenciarUsuarios_LinkClicked(sender As Object, e As NavBarLinkEventArgs)
        Dim fGerencial2 As New frmAdmUsuarios() With {.MdiParent = Me}
        fGerencial2.Show()
    End Sub

    Private Sub navMaisProfessor_ImprimirConsolidado_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navMaisProfessor_ImprimirConsolidado.LinkClicked
        Dim fRpt_Consolidado As New frmRpt_Consolidado() With {.MdiParent = Me}
        fRpt_Consolidado.Show()
    End Sub

    Private Sub navMaisProfessor_PrepararPen_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navMaisProfessor_PrepararPen.LinkClicked
        Dim fBolPreparar As New frmBMPreparar() With {.MdiParent = Me}
        fBolPreparar.Show()
    End Sub

    Private Sub navMaisProfessor_StatusEntrega_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navMaisProfessor_StatusEntrega.LinkClicked
        ' Status de Entrega 
        frmRpt_bimestre = consultaBimestre()

        SQL_frmRPT = meuRPT2("Boletim", "Status de Entrega")
        ' Dim fRpt_Auxiliar As New frmRpt_Auxiliar() With {.MdiParent = Me}
        'Me.WindowState = FormWindowState.Minimized
        frmRpt_Auxiliar.Show()
    End Sub

    Private Sub navMaisProfessor_TrazerNotasOnline_LinkClicked(sender As Object, e As NavBarLinkEventArgs)

    End Sub

    Private Sub navMaisProfessor_TrazerNotasPen_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navMaisProfessor_TrazerNotasPen.LinkClicked
        Dim fTNBoletim As New frmBMBoletim() With {.MdiParent = Me}
        fTNBoletim.Show()

    End Sub

    Private Sub navNotasFrequencias_Cadastro_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navNotasFrequencias_Cadastro.LinkClicked
        Dim fCadNF As New frmCadBoletimTela() With {.MdiParent = Me}
        fCadNF.Show()
    End Sub

    Private Sub navNotasFrequencias_Manutenção_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navNotasFrequencias_Manutenção.LinkClicked
        Dim fManNF As New frmManBoletimTela() With {.MdiParent = Me}
        fManNF.Show()
    End Sub

    Private Sub navNotasFrequencias_TrazerNotasExcel_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navNotasFrequencias_TrazerNotasExcel.LinkClicked
        Dim fImpBoletins As New frmImpExcel() With {.MdiParent = Me}
        fImpBoletins.Show()
    End Sub

    Private Sub navRelatorios_ATA_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navRelatorios_ATA.LinkClicked
        Dim fRpt_ACCompleto As New frmRpt_ATA() With {.MdiParent = Me}
        fRpt_ACCompleto.Show()
    End Sub

    Private Sub navRelatorios_BuscarAluno_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navRelatorios_BuscarAluno.LinkClicked
        Dim fRpt_BuscaAluno As New frmRpt_BuscaAluno() With {.MdiParent = Me}
        fRpt_BuscaAluno.Show()
    End Sub

    Private Sub navRelatorios_CarteiraEstudante_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navRelatorios_CarteiraEstudante.LinkClicked
        Dim fRptCartEstudante As New frmRpt_CartEstudante() With {.MdiParent = Me}
        fRptCartEstudante.Show()
    End Sub

    Private Sub navRelatorios_DeclaracaoEscolar_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navRelatorios_DeclaracaoEscolar.LinkClicked
        Dim fGerencialDCL As New frmRpt_Declaracao() With {.MdiParent = Me}
        fGerencialDCL.Show()
    End Sub

    Private Sub navRelatorios_MeuGrafico_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navRelatorios_MeuGrafico.LinkClicked
        Dim fRptGraficos = New frmRptGrafico(Nothing, "0", "0", "0", "0")
        fRptGraficos.Show()
    End Sub

    Private Sub navRelatorios_MeuRelatorio_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navRelatorios_MeuRelatorio.LinkClicked
        frmRptRelatorio.Show()
    End Sub

    Private Sub navArquivo_ControleRegistros_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navArquivo_ControleRegistros.LinkClicked
        'Arquivo Morto
        Dim fAMControle As New frmAMControle() With {.MdiParent = Me}
        fAMControle.Show()
    End Sub

    Private Sub navArquivo_Gerenciar_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navArquivo_Gerenciar.LinkClicked
        ' Arquivo Morto
        Dim fCadAlunoFichaSimples As New frmCadAlunoFichaSimples() With {.MdiParent = Me}
        fCadAlunoFichaSimples.Show()

    End Sub

    Private Sub bwMaisEscola_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwMaisEscola.DoWork

        ' Checa Versão Atual do BD...
        atualizaBD()

        Try
            '***TIPO DE ESCOLA, PARTICULAR, MUNICIPAL OU ESTADUAL...
            SQL = "SELECT ferramenta3, ferramenta4, ferramenta5 FROM preferencias WHERE idPreferencias='1';"
            Escola_Sistema = MySQL_consulta_campo(SQL, "ferramenta5")
            If Escola_Sistema = "0" Then
                Escola_Sistema = "Nenhuma"
            End If
            UsuarioWeb = MySQL_consulta_campo(SQL, "ferramenta3").ToString
            SenhaWeb = MySQL_consulta_campo(SQL, "ferramenta4").ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMaisEscola_Novo_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        AjustaFundo()

    End Sub

    Private Sub btFerramentas_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btFerramentas.ItemClick
        Dim fFerOpcoes As New frmFerramentas() With {.MdiParent = Me}
        fFerOpcoes.Show()
    End Sub

    Private Sub btTeamviewer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btTeamviewer.ItemClick


    End Sub

    Private Sub navNotasFrequencias_OE_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navNotasFrequencias_OE.LinkClicked
        'Dim fOE_Ficha As New frmOE_Ficha() With {.MdiParent = Me}
        frmOE_Ficha.Show()

    End Sub

    Private Sub barraRelatorios_Click(sender As Object, e As EventArgs) Handles barraRelatorios.Click

    End Sub
End Class