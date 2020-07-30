<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.barraRelatorios = New DevExpress.XtraNavBar.NavBarControl()
        Me.navAdministrativo = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navAdministrativo_Alunos = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_Boletins = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_Disciplinas = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_Turmas = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_Bolsas = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_CopiarColar = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_EditorTexto = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_Planilha = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_Backup = New DevExpress.XtraNavBar.NavBarItem()
        Me.navAdministrativo_Eventos = New DevExpress.XtraNavBar.NavBarItem()
        Me.navNotasFrequencias = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navNotasFrequencias_Cadastro = New DevExpress.XtraNavBar.NavBarItem()
        Me.navNotasFrequencias_Manutenção = New DevExpress.XtraNavBar.NavBarItem()
        Me.navNotasFrequencias_TrazerNotasExcel = New DevExpress.XtraNavBar.NavBarItem()
        Me.navNotasFrequencias_OE = New DevExpress.XtraNavBar.NavBarItem()
        Me.navRelatorios = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navRelatorios_MeuRelatorio = New DevExpress.XtraNavBar.NavBarItem()
        Me.navRelatorios_MeuGrafico = New DevExpress.XtraNavBar.NavBarItem()
        Me.navRelatorios_ATA = New DevExpress.XtraNavBar.NavBarItem()
        Me.navRelatorios_CarteiraEstudante = New DevExpress.XtraNavBar.NavBarItem()
        Me.navRelatorios_DeclaracaoEscolar = New DevExpress.XtraNavBar.NavBarItem()
        Me.navRelatorios_BuscarAluno = New DevExpress.XtraNavBar.NavBarItem()
        Me.navArquivoMorto = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navArquivo_Gerenciar = New DevExpress.XtraNavBar.NavBarItem()
        Me.navArquivo_ControleRegistros = New DevExpress.XtraNavBar.NavBarItem()
        Me.navMaisProfessor_PrepararPen = New DevExpress.XtraNavBar.NavBarItem()
        Me.navMaisProfessor_ImprimirConsolidado = New DevExpress.XtraNavBar.NavBarItem()
        Me.navMaisProfessor_Atribuição = New DevExpress.XtraNavBar.NavBarItem()
        Me.navMaisProfessor_StatusEntrega = New DevExpress.XtraNavBar.NavBarItem()
        Me.navMaisProfessor_TrazerNotasPen = New DevExpress.XtraNavBar.NavBarItem()
        Me.popupAdmAlunos = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.popupAdmAlunos_Importar = New DevExpress.XtraBars.BarButtonItem()
        Me.popupAdmAlunos_FichaAluno = New DevExpress.XtraBars.BarButtonItem()
        Me.popupAdmAlunos_Delib11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.popupAdmBoletins_Cadastro = New DevExpress.XtraBars.BarButtonItem()
        Me.popupAdmBoletins_Manutencao = New DevExpress.XtraBars.BarButtonItem()
        Me.popupAdmBoletins_AulasDadasPrevistas = New DevExpress.XtraBars.BarButtonItem()
        Me.popupAdmBoletins_BoletinsAtraso = New DevExpress.XtraBars.BarButtonItem()
        Me.popupAdmBoletins_GerarAF = New DevExpress.XtraBars.BarButtonItem()
        Me.popupAdmBoletins_AplicarEvasao = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemHypertextLabel1 = New DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel()
        Me.popupMaisProf_Professores = New DevExpress.XtraBars.BarButtonItem()
        Me.popupMaisProf_Turma = New DevExpress.XtraBars.BarButtonItem()
        Me.popupAdmBoletins = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.popupMaisProfAtribuicao = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.bwMaisEscola = New System.ComponentModel.BackgroundWorker()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barraStatus = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barraVersao = New DevExpress.XtraBars.BarStaticItem()
        Me.barraUsuario = New DevExpress.XtraBars.BarStaticItem()
        Me.barraConectado = New DevExpress.XtraBars.BarStaticItem()
        Me.barraComputador = New DevExpress.XtraBars.BarStaticItem()
        Me.btFerramentas = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.btTeamviewer = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.barraRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupAdmAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHypertextLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupAdmBoletins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMaisProfAtribuicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'barraRelatorios
        '
        Me.barraRelatorios.ActiveGroup = Me.navAdministrativo
        Me.barraRelatorios.Appearance.Button.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barraRelatorios.Appearance.Button.Options.UseFont = True
        Me.barraRelatorios.Appearance.ItemActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.barraRelatorios.Appearance.ItemActive.Options.UseFont = True
        Me.barraRelatorios.Appearance.ItemPressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barraRelatorios.Appearance.ItemPressed.Options.UseFont = True
        Me.barraRelatorios.Dock = System.Windows.Forms.DockStyle.Left
        Me.barraRelatorios.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barraRelatorios.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navAdministrativo, Me.navNotasFrequencias, Me.navRelatorios, Me.navArquivoMorto})
        Me.barraRelatorios.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navMaisProfessor_PrepararPen, Me.navMaisProfessor_ImprimirConsolidado, Me.navNotasFrequencias_Cadastro, Me.navNotasFrequencias_Manutenção, Me.navNotasFrequencias_TrazerNotasExcel, Me.navMaisProfessor_Atribuição, Me.navAdministrativo_Alunos, Me.navAdministrativo_Boletins, Me.navAdministrativo_Bolsas, Me.navAdministrativo_Disciplinas, Me.navAdministrativo_CopiarColar, Me.navAdministrativo_EditorTexto, Me.navAdministrativo_Planilha, Me.navAdministrativo_Backup, Me.navAdministrativo_Eventos, Me.navAdministrativo_Turmas, Me.navMaisProfessor_StatusEntrega, Me.navMaisProfessor_TrazerNotasPen, Me.navRelatorios_MeuRelatorio, Me.navRelatorios_MeuGrafico, Me.navRelatorios_ATA, Me.navRelatorios_CarteiraEstudante, Me.navRelatorios_DeclaracaoEscolar, Me.navRelatorios_BuscarAluno, Me.navArquivo_Gerenciar, Me.navArquivo_ControleRegistros, Me.navNotasFrequencias_OE})
        Me.barraRelatorios.Location = New System.Drawing.Point(0, 0)
        Me.barraRelatorios.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.barraRelatorios.Name = "barraRelatorios"
        Me.barraRelatorios.OptionsNavPane.ExpandedWidth = 206
        Me.barraRelatorios.OptionsNavPane.ShowGroupImageInHeader = True
        Me.barraRelatorios.OptionsNavPane.ShowOverflowButton = False
        Me.barraRelatorios.OptionsNavPane.ShowOverflowPanel = False
        Me.barraRelatorios.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.SideBar
        Me.barraRelatorios.Size = New System.Drawing.Size(206, 817)
        Me.barraRelatorios.TabIndex = 2
        Me.barraRelatorios.Text = "barraRelatorios"
        Me.barraRelatorios.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Office 2016 Black")
        '
        'navAdministrativo
        '
        Me.navAdministrativo.Caption = "Administrativo"
        Me.navAdministrativo.Expanded = True
        Me.navAdministrativo.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_Alunos), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_Boletins), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_Disciplinas), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_Turmas), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_Bolsas), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_CopiarColar), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_EditorTexto), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_Planilha), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_Backup), New DevExpress.XtraNavBar.NavBarItemLink(Me.navAdministrativo_Eventos)})
        Me.navAdministrativo.Name = "navAdministrativo"
        '
        'navAdministrativo_Alunos
        '
        Me.navAdministrativo_Alunos.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.navAdministrativo_Alunos.AppearanceDisabled.Options.UseFont = True
        Me.navAdministrativo_Alunos.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.navAdministrativo_Alunos.AppearanceHotTracked.Options.UseFont = True
        Me.navAdministrativo_Alunos.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.navAdministrativo_Alunos.AppearancePressed.Options.UseFont = True
        Me.navAdministrativo_Alunos.Caption = "Alunos"
        Me.navAdministrativo_Alunos.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_Alunos.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_Alunos.Name = "navAdministrativo_Alunos"
        '
        'navAdministrativo_Boletins
        '
        Me.navAdministrativo_Boletins.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.navAdministrativo_Boletins.AppearancePressed.Options.UseFont = True
        Me.navAdministrativo_Boletins.Caption = "Gerenciar Boletins"
        Me.navAdministrativo_Boletins.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_Boletins.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_Boletins.Name = "navAdministrativo_Boletins"
        '
        'navAdministrativo_Disciplinas
        '
        Me.navAdministrativo_Disciplinas.Caption = "Gerenciar Disciplinas"
        Me.navAdministrativo_Disciplinas.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_Disciplinas.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_Disciplinas.Name = "navAdministrativo_Disciplinas"
        '
        'navAdministrativo_Turmas
        '
        Me.navAdministrativo_Turmas.Caption = "Gerenciar Turmas"
        Me.navAdministrativo_Turmas.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_Turmas.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_Turmas.Name = "navAdministrativo_Turmas"
        '
        'navAdministrativo_Bolsas
        '
        Me.navAdministrativo_Bolsas.Caption = "Bolsas de Estudo"
        Me.navAdministrativo_Bolsas.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_Bolsas.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_Bolsas.Name = "navAdministrativo_Bolsas"
        '
        'navAdministrativo_CopiarColar
        '
        Me.navAdministrativo_CopiarColar.Caption = "Copiar/Colar Notas"
        Me.navAdministrativo_CopiarColar.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_CopiarColar.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_CopiarColar.Name = "navAdministrativo_CopiarColar"
        '
        'navAdministrativo_EditorTexto
        '
        Me.navAdministrativo_EditorTexto.Caption = "Editor de Texto"
        Me.navAdministrativo_EditorTexto.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_EditorTexto.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_EditorTexto.Name = "navAdministrativo_EditorTexto"
        '
        'navAdministrativo_Planilha
        '
        Me.navAdministrativo_Planilha.Caption = "Planilha de Texto"
        Me.navAdministrativo_Planilha.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_Planilha.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_Planilha.Name = "navAdministrativo_Planilha"
        '
        'navAdministrativo_Backup
        '
        Me.navAdministrativo_Backup.Caption = "Efetuar Backup"
        Me.navAdministrativo_Backup.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_Backup.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_Backup.Name = "navAdministrativo_Backup"
        '
        'navAdministrativo_Eventos
        '
        Me.navAdministrativo_Eventos.Caption = "Visualizar Eventos"
        Me.navAdministrativo_Eventos.ImageOptions.SmallImage = CType(resources.GetObject("navAdministrativo_Eventos.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navAdministrativo_Eventos.Name = "navAdministrativo_Eventos"
        '
        'navNotasFrequencias
        '
        Me.navNotasFrequencias.Caption = "Notas e Frequência"
        Me.navNotasFrequencias.ImageOptions.SmallImage = CType(resources.GetObject("navNotasFrequencias.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navNotasFrequencias.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navNotasFrequencias_Cadastro), New DevExpress.XtraNavBar.NavBarItemLink(Me.navNotasFrequencias_Manutenção), New DevExpress.XtraNavBar.NavBarItemLink(Me.navNotasFrequencias_TrazerNotasExcel), New DevExpress.XtraNavBar.NavBarItemLink(Me.navNotasFrequencias_OE)})
        Me.navNotasFrequencias.Name = "navNotasFrequencias"
        '
        'navNotasFrequencias_Cadastro
        '
        Me.navNotasFrequencias_Cadastro.Caption = "Cadastro"
        Me.navNotasFrequencias_Cadastro.ImageOptions.SmallImage = CType(resources.GetObject("navNotasFrequencias_Cadastro.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navNotasFrequencias_Cadastro.Name = "navNotasFrequencias_Cadastro"
        '
        'navNotasFrequencias_Manutenção
        '
        Me.navNotasFrequencias_Manutenção.Caption = "Manutenção"
        Me.navNotasFrequencias_Manutenção.ImageOptions.SmallImage = CType(resources.GetObject("navNotasFrequencias_Manutenção.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navNotasFrequencias_Manutenção.Name = "navNotasFrequencias_Manutenção"
        '
        'navNotasFrequencias_TrazerNotasExcel
        '
        Me.navNotasFrequencias_TrazerNotasExcel.Caption = "Trazer Notas em Excel"
        Me.navNotasFrequencias_TrazerNotasExcel.ImageOptions.SmallImage = CType(resources.GetObject("navNotasFrequencias_TrazerNotasExcel.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navNotasFrequencias_TrazerNotasExcel.Name = "navNotasFrequencias_TrazerNotasExcel"
        '
        'navNotasFrequencias_OE
        '
        Me.navNotasFrequencias_OE.Caption = "Orientador Educacional"
        Me.navNotasFrequencias_OE.ImageOptions.SmallImage = CType(resources.GetObject("navNotasFrequencias_OE.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navNotasFrequencias_OE.Name = "navNotasFrequencias_OE"
        '
        'navRelatorios
        '
        Me.navRelatorios.Caption = "Relatórios"
        Me.navRelatorios.ImageOptions.SmallImage = CType(resources.GetObject("navRelatorios.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navRelatorios.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navRelatorios_MeuRelatorio), New DevExpress.XtraNavBar.NavBarItemLink(Me.navRelatorios_MeuGrafico), New DevExpress.XtraNavBar.NavBarItemLink(Me.navRelatorios_ATA), New DevExpress.XtraNavBar.NavBarItemLink(Me.navRelatorios_CarteiraEstudante), New DevExpress.XtraNavBar.NavBarItemLink(Me.navRelatorios_DeclaracaoEscolar), New DevExpress.XtraNavBar.NavBarItemLink(Me.navRelatorios_BuscarAluno)})
        Me.navRelatorios.Name = "navRelatorios"
        '
        'navRelatorios_MeuRelatorio
        '
        Me.navRelatorios_MeuRelatorio.Caption = "Meu Relatório!"
        Me.navRelatorios_MeuRelatorio.ImageOptions.SmallImage = CType(resources.GetObject("navRelatorios_MeuRelatorio.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navRelatorios_MeuRelatorio.Name = "navRelatorios_MeuRelatorio"
        '
        'navRelatorios_MeuGrafico
        '
        Me.navRelatorios_MeuGrafico.Caption = "Meu Gráfico!"
        Me.navRelatorios_MeuGrafico.ImageOptions.SmallImage = CType(resources.GetObject("navRelatorios_MeuGrafico.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navRelatorios_MeuGrafico.Name = "navRelatorios_MeuGrafico"
        '
        'navRelatorios_ATA
        '
        Me.navRelatorios_ATA.Caption = "ATA do Conselho"
        Me.navRelatorios_ATA.ImageOptions.SmallImage = CType(resources.GetObject("navRelatorios_ATA.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navRelatorios_ATA.Name = "navRelatorios_ATA"
        '
        'navRelatorios_CarteiraEstudante
        '
        Me.navRelatorios_CarteiraEstudante.Caption = "Carteira de Estudante"
        Me.navRelatorios_CarteiraEstudante.ImageOptions.SmallImage = CType(resources.GetObject("navRelatorios_CarteiraEstudante.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navRelatorios_CarteiraEstudante.Name = "navRelatorios_CarteiraEstudante"
        '
        'navRelatorios_DeclaracaoEscolar
        '
        Me.navRelatorios_DeclaracaoEscolar.Caption = "Declaração Escolar"
        Me.navRelatorios_DeclaracaoEscolar.ImageOptions.SmallImage = CType(resources.GetObject("navRelatorios_DeclaracaoEscolar.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navRelatorios_DeclaracaoEscolar.Name = "navRelatorios_DeclaracaoEscolar"
        '
        'navRelatorios_BuscarAluno
        '
        Me.navRelatorios_BuscarAluno.Caption = "Buscar Aluno"
        Me.navRelatorios_BuscarAluno.ImageOptions.SmallImage = CType(resources.GetObject("navRelatorios_BuscarAluno.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navRelatorios_BuscarAluno.Name = "navRelatorios_BuscarAluno"
        '
        'navArquivoMorto
        '
        Me.navArquivoMorto.Caption = "Arquivo Morto"
        Me.navArquivoMorto.ImageOptions.SmallImage = CType(resources.GetObject("navArquivoMorto.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navArquivoMorto.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navArquivo_Gerenciar), New DevExpress.XtraNavBar.NavBarItemLink(Me.navArquivo_ControleRegistros)})
        Me.navArquivoMorto.Name = "navArquivoMorto"
        '
        'navArquivo_Gerenciar
        '
        Me.navArquivo_Gerenciar.Caption = "Gerenciar"
        Me.navArquivo_Gerenciar.ImageOptions.SmallImage = CType(resources.GetObject("navArquivo_Gerenciar.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navArquivo_Gerenciar.Name = "navArquivo_Gerenciar"
        '
        'navArquivo_ControleRegistros
        '
        Me.navArquivo_ControleRegistros.Caption = "Controle de Registros"
        Me.navArquivo_ControleRegistros.ImageOptions.SmallImage = CType(resources.GetObject("navArquivo_ControleRegistros.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navArquivo_ControleRegistros.Name = "navArquivo_ControleRegistros"
        '
        'navMaisProfessor_PrepararPen
        '
        Me.navMaisProfessor_PrepararPen.Caption = "Preparar Pen-drive!"
        Me.navMaisProfessor_PrepararPen.ImageOptions.SmallImage = CType(resources.GetObject("navMaisProfessor_PrepararPen.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navMaisProfessor_PrepararPen.Name = "navMaisProfessor_PrepararPen"
        '
        'navMaisProfessor_ImprimirConsolidado
        '
        Me.navMaisProfessor_ImprimirConsolidado.Caption = "Imprimir Consolidado!"
        Me.navMaisProfessor_ImprimirConsolidado.ImageOptions.SmallImage = CType(resources.GetObject("navMaisProfessor_ImprimirConsolidado.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navMaisProfessor_ImprimirConsolidado.Name = "navMaisProfessor_ImprimirConsolidado"
        '
        'navMaisProfessor_Atribuição
        '
        Me.navMaisProfessor_Atribuição.Caption = "Atribuição"
        Me.navMaisProfessor_Atribuição.ImageOptions.SmallImage = CType(resources.GetObject("navMaisProfessor_Atribuição.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navMaisProfessor_Atribuição.Name = "navMaisProfessor_Atribuição"
        '
        'navMaisProfessor_StatusEntrega
        '
        Me.navMaisProfessor_StatusEntrega.Caption = "Status de Entrega"
        Me.navMaisProfessor_StatusEntrega.ImageOptions.SmallImage = CType(resources.GetObject("navMaisProfessor_StatusEntrega.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navMaisProfessor_StatusEntrega.Name = "navMaisProfessor_StatusEntrega"
        '
        'navMaisProfessor_TrazerNotasPen
        '
        Me.navMaisProfessor_TrazerNotasPen.Caption = "Trazer Notas Pen-drive!"
        Me.navMaisProfessor_TrazerNotasPen.ImageOptions.SmallImage = CType(resources.GetObject("navMaisProfessor_TrazerNotasPen.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navMaisProfessor_TrazerNotasPen.Name = "navMaisProfessor_TrazerNotasPen"
        '
        'popupAdmAlunos
        '
        Me.popupAdmAlunos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmAlunos_Importar), New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmAlunos_FichaAluno), New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmAlunos_Delib11)})
        Me.popupAdmAlunos.Manager = Me.BarManager1
        Me.popupAdmAlunos.Name = "popupAdmAlunos"
        '
        'popupAdmAlunos_Importar
        '
        Me.popupAdmAlunos_Importar.Caption = "Importar Relação de Alunos em PDF"
        Me.popupAdmAlunos_Importar.Id = 0
        Me.popupAdmAlunos_Importar.Name = "popupAdmAlunos_Importar"
        '
        'popupAdmAlunos_FichaAluno
        '
        Me.popupAdmAlunos_FichaAluno.Caption = "Ficha do Aluno"
        Me.popupAdmAlunos_FichaAluno.Id = 1
        Me.popupAdmAlunos_FichaAluno.Name = "popupAdmAlunos_FichaAluno"
        '
        'popupAdmAlunos_Delib11
        '
        Me.popupAdmAlunos_Delib11.Caption = "Deliberação 11"
        Me.popupAdmAlunos_Delib11.Id = 2
        Me.popupAdmAlunos_Delib11.Name = "popupAdmAlunos_Delib11"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.popupAdmAlunos_Importar, Me.popupAdmAlunos_FichaAluno, Me.popupAdmAlunos_Delib11, Me.popupAdmBoletins_Cadastro, Me.popupAdmBoletins_Manutencao, Me.popupAdmBoletins_AulasDadasPrevistas, Me.popupAdmBoletins_BoletinsAtraso, Me.popupAdmBoletins_GerarAF, Me.popupAdmBoletins_AplicarEvasao, Me.BarEditItem1, Me.popupMaisProf_Professores, Me.popupMaisProf_Turma})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHypertextLabel1})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.barDockControlTop.Size = New System.Drawing.Size(1105, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 817)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1105, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 817)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1105, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 817)
        '
        'popupAdmBoletins_Cadastro
        '
        Me.popupAdmBoletins_Cadastro.Caption = "Cadastro"
        Me.popupAdmBoletins_Cadastro.Id = 3
        Me.popupAdmBoletins_Cadastro.Name = "popupAdmBoletins_Cadastro"
        '
        'popupAdmBoletins_Manutencao
        '
        Me.popupAdmBoletins_Manutencao.Caption = "Manutenção"
        Me.popupAdmBoletins_Manutencao.Id = 4
        Me.popupAdmBoletins_Manutencao.Name = "popupAdmBoletins_Manutencao"
        '
        'popupAdmBoletins_AulasDadasPrevistas
        '
        Me.popupAdmBoletins_AulasDadasPrevistas.Caption = "Aulas Dadas/Previstas"
        Me.popupAdmBoletins_AulasDadasPrevistas.Id = 5
        Me.popupAdmBoletins_AulasDadasPrevistas.Name = "popupAdmBoletins_AulasDadasPrevistas"
        '
        'popupAdmBoletins_BoletinsAtraso
        '
        Me.popupAdmBoletins_BoletinsAtraso.Caption = "Boletins em Atraso"
        Me.popupAdmBoletins_BoletinsAtraso.Id = 6
        Me.popupAdmBoletins_BoletinsAtraso.Name = "popupAdmBoletins_BoletinsAtraso"
        '
        'popupAdmBoletins_GerarAF
        '
        Me.popupAdmBoletins_GerarAF.Caption = "Gerar Avaliação Final"
        Me.popupAdmBoletins_GerarAF.Id = 7
        Me.popupAdmBoletins_GerarAF.Name = "popupAdmBoletins_GerarAF"
        '
        'popupAdmBoletins_AplicarEvasao
        '
        Me.popupAdmBoletins_AplicarEvasao.Caption = "Aplicar Evasão Escolar"
        Me.popupAdmBoletins_AplicarEvasao.Id = 8
        Me.popupAdmBoletins_AplicarEvasao.Name = "popupAdmBoletins_AplicarEvasao"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemHypertextLabel1
        Me.BarEditItem1.Id = 9
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemHypertextLabel1
        '
        Me.RepositoryItemHypertextLabel1.Name = "RepositoryItemHypertextLabel1"
        '
        'popupMaisProf_Professores
        '
        Me.popupMaisProf_Professores.Caption = "Professores"
        Me.popupMaisProf_Professores.Id = 10
        Me.popupMaisProf_Professores.Name = "popupMaisProf_Professores"
        '
        'popupMaisProf_Turma
        '
        Me.popupMaisProf_Turma.Caption = "Turmas"
        Me.popupMaisProf_Turma.Id = 11
        Me.popupMaisProf_Turma.Name = "popupMaisProf_Turma"
        '
        'popupAdmBoletins
        '
        Me.popupAdmBoletins.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmBoletins_Cadastro), New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmBoletins_Manutencao), New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmBoletins_AulasDadasPrevistas), New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmBoletins_BoletinsAtraso), New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmBoletins_GerarAF), New DevExpress.XtraBars.LinkPersistInfo(Me.popupAdmBoletins_AplicarEvasao)})
        Me.popupAdmBoletins.Manager = Me.BarManager1
        Me.popupAdmBoletins.Name = "popupAdmBoletins"
        '
        'popupMaisProfAtribuicao
        '
        Me.popupMaisProfAtribuicao.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.popupMaisProf_Professores), New DevExpress.XtraBars.LinkPersistInfo(Me.popupMaisProf_Turma)})
        Me.popupMaisProfAtribuicao.Manager = Me.BarManager1
        Me.popupMaisProfAtribuicao.Name = "popupMaisProfAtribuicao"
        '
        'bwMaisEscola
        '
        Me.bwMaisEscola.WorkerReportsProgress = True
        Me.bwMaisEscola.WorkerSupportsCancellation = True
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DisableClose = True
        Me.Bar3.OptionsBar.DisableCustomization = True
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Status bar"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Status bar"
        '
        'barraStatus
        '
        Me.barraStatus.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.barraStatus.DockControls.Add(Me.BarDockControl1)
        Me.barraStatus.DockControls.Add(Me.BarDockControl2)
        Me.barraStatus.DockControls.Add(Me.BarDockControl3)
        Me.barraStatus.DockControls.Add(Me.BarDockControl4)
        Me.barraStatus.Form = Me
        Me.barraStatus.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barraVersao, Me.barraUsuario, Me.barraConectado, Me.barraComputador, Me.btTeamviewer, Me.btFerramentas})
        Me.barraStatus.MaxItemId = 6
        Me.barraStatus.StatusBar = Me.Bar2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Status bar"
        Me.Bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barraVersao), New DevExpress.XtraBars.LinkPersistInfo(Me.barraUsuario), New DevExpress.XtraBars.LinkPersistInfo(Me.barraConectado), New DevExpress.XtraBars.LinkPersistInfo(Me.barraComputador), New DevExpress.XtraBars.LinkPersistInfo(Me.btFerramentas)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DisableClose = True
        Me.Bar2.OptionsBar.DisableCustomization = True
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Status bar"
        '
        'barraVersao
        '
        Me.barraVersao.Caption = "Versão: 18.1.1.1"
        Me.barraVersao.Id = 0
        Me.barraVersao.Name = "barraVersao"
        '
        'barraUsuario
        '
        Me.barraUsuario.Caption = "Usuário: maisescola"
        Me.barraUsuario.Id = 1
        Me.barraUsuario.Name = "barraUsuario"
        '
        'barraConectado
        '
        Me.barraConectado.Caption = "Conectado: localhost"
        Me.barraConectado.Id = 2
        Me.barraConectado.Name = "barraConectado"
        '
        'barraComputador
        '
        Me.barraComputador.Caption = "Meu Computador: localhost"
        Me.barraComputador.Id = 3
        Me.barraComputador.Name = "barraComputador"
        '
        'btFerramentas
        '
        Me.btFerramentas.Id = 5
        Me.btFerramentas.ImageOptions.Image = CType(resources.GetObject("btFerramentas.ImageOptions.Image"), System.Drawing.Image)
        Me.btFerramentas.ImageOptions.LargeImage = CType(resources.GetObject("btFerramentas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btFerramentas.Name = "btFerramentas"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.barraStatus
        Me.BarDockControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BarDockControl1.Size = New System.Drawing.Size(1105, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 817)
        Me.BarDockControl2.Manager = Me.barraStatus
        Me.BarDockControl2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BarDockControl2.Size = New System.Drawing.Size(1105, 24)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.barraStatus
        Me.BarDockControl3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 817)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1105, 0)
        Me.BarDockControl4.Manager = Me.barraStatus
        Me.BarDockControl4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 817)
        '
        'btTeamviewer
        '
        Me.btTeamviewer.Id = 4
        Me.btTeamviewer.ImageOptions.Image = CType(resources.GetObject("btTeamviewer.ImageOptions.Image"), System.Drawing.Image)
        Me.btTeamviewer.Name = "btTeamviewer"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.Mais_Escola.My.Resources.Resources.Fundo3
        Me.ClientSize = New System.Drawing.Size(1105, 841)
        Me.Controls.Add(Me.barraRelatorios)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minha Escola!"
        CType(Me.barraRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupAdmAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHypertextLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupAdmBoletins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMaisProfAtribuicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents barraRelatorios As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents navAdministrativo As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navAdministrativo_Alunos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navAdministrativo_Boletins As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navAdministrativo_Bolsas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navAdministrativo_Disciplinas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navAdministrativo_CopiarColar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navMaisProfessor_PrepararPen As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navMaisProfessor_ImprimirConsolidado As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navMaisProfessor_Atribuição As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navNotasFrequencias As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navNotasFrequencias_Cadastro As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navNotasFrequencias_Manutenção As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navNotasFrequencias_TrazerNotasExcel As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navRelatorios As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navArquivoMorto As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents popupAdmAlunos As DevExpress.XtraBars.PopupMenu
    Friend WithEvents popupAdmBoletins As DevExpress.XtraBars.PopupMenu
    Friend WithEvents navAdministrativo_EditorTexto As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navAdministrativo_Planilha As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navAdministrativo_Backup As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navAdministrativo_Eventos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navAdministrativo_Turmas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents popupAdmAlunos_Importar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupAdmAlunos_FichaAluno As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupAdmAlunos_Delib11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents popupAdmBoletins_Cadastro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupAdmBoletins_Manutencao As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupAdmBoletins_AulasDadasPrevistas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupAdmBoletins_BoletinsAtraso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupAdmBoletins_GerarAF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupAdmBoletins_AplicarEvasao As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemHypertextLabel1 As DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel
    Friend WithEvents navMaisProfessor_StatusEntrega As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navMaisProfessor_TrazerNotasPen As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents popupMaisProf_Professores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupMaisProf_Turma As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popupMaisProfAtribuicao As DevExpress.XtraBars.PopupMenu
    Friend WithEvents navRelatorios_MeuRelatorio As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navRelatorios_MeuGrafico As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navRelatorios_ATA As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navRelatorios_CarteiraEstudante As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navRelatorios_DeclaracaoEscolar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navRelatorios_BuscarAluno As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navArquivo_Gerenciar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navArquivo_ControleRegistros As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bwMaisEscola As System.ComponentModel.BackgroundWorker
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barraStatus As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barraVersao As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barraUsuario As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barraConectado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barraComputador As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btFerramentas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btTeamviewer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents navNotasFrequencias_OE As DevExpress.XtraNavBar.NavBarItem
End Class
