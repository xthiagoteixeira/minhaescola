<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptRelatorioTela
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptRelatorioTela))
        Me.barraRelatorios = New DevExpress.XtraNavBar.NavBarControl()
        Me.navListaAlunos = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navListaAlunos_Completa = New DevExpress.XtraNavBar.NavBarItem()
        Me.navListaAlunos_ControleInterno = New DevExpress.XtraNavBar.NavBarItem()
        Me.navListaAlunos_ListaEntrega = New DevExpress.XtraNavBar.NavBarItem()
        Me.navListaAlunos_ListaPiloto = New DevExpress.XtraNavBar.NavBarItem()
        Me.navListaAlunos_Requerimento = New DevExpress.XtraNavBar.NavBarItem()
        Me.navListaAlunos_ReuniaoPaisMestres = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBoletim = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navBoletim_Consolidado = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBoletim_Simples = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBoletim_StatusEntrega = New DevExpress.XtraNavBar.NavBarItem()
        Me.navBoletim_Deliberacao11 = New DevExpress.XtraNavBar.NavBarItem()
        Me.navConsolidado = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navConsolidado_AlunosReprovados = New DevExpress.XtraNavBar.NavBarItem()
        Me.navConsolidado_AvaliaçãoFinal = New DevExpress.XtraNavBar.NavBarItem()
        Me.navConsolidado_Completo = New DevExpress.XtraNavBar.NavBarItem()
        Me.navConsolidado_NotasFrequencias = New DevExpress.XtraNavBar.NavBarItem()
        Me.navFichaIndividual = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navRendimentoEscolar = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navGraficos = New DevExpress.XtraNavBar.NavBarGroup()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbAF = New DevExpress.XtraEditors.CheckButton()
        Me.pbConsulta = New DevExpress.XtraEditors.PictureEdit()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.tBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gridRelatorio = New DevExpress.XtraGrid.GridControl()
        Me.viewRelatorio = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.barraRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConsulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barraRelatorios
        '
        Me.barraRelatorios.ActiveGroup = Me.navListaAlunos
        Me.barraRelatorios.Appearance.Button.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barraRelatorios.Appearance.Button.Options.UseFont = True
        Me.barraRelatorios.Appearance.ItemActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.barraRelatorios.Appearance.ItemActive.Options.UseFont = True
        Me.barraRelatorios.Appearance.ItemPressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barraRelatorios.Appearance.ItemPressed.Options.UseFont = True
        Me.barraRelatorios.Dock = System.Windows.Forms.DockStyle.Left
        Me.barraRelatorios.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barraRelatorios.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navListaAlunos, Me.navBoletim, Me.navConsolidado, Me.navFichaIndividual, Me.navRendimentoEscolar, Me.navGraficos})
        Me.barraRelatorios.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBoletim_Consolidado, Me.navBoletim_Simples, Me.navBoletim_StatusEntrega, Me.navConsolidado_AlunosReprovados, Me.navConsolidado_AvaliaçãoFinal, Me.navConsolidado_Completo, Me.navConsolidado_NotasFrequencias, Me.navBoletim_Deliberacao11, Me.navListaAlunos_Completa, Me.navListaAlunos_ControleInterno, Me.navListaAlunos_ListaEntrega, Me.navListaAlunos_ListaPiloto, Me.navListaAlunos_Requerimento, Me.navListaAlunos_ReuniaoPaisMestres})
        Me.barraRelatorios.Location = New System.Drawing.Point(0, 0)
        Me.barraRelatorios.Name = "barraRelatorios"
        Me.barraRelatorios.OptionsNavPane.ExpandedWidth = 181
        Me.barraRelatorios.OptionsNavPane.ShowGroupImageInHeader = True
        Me.barraRelatorios.OptionsNavPane.ShowOverflowButton = False
        Me.barraRelatorios.OptionsNavPane.ShowOverflowPanel = False
        Me.barraRelatorios.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.barraRelatorios.Size = New System.Drawing.Size(181, 568)
        Me.barraRelatorios.TabIndex = 1
        Me.barraRelatorios.Text = "barraRelatorios"
        Me.barraRelatorios.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Office 2016 Black")
        '
        'navListaAlunos
        '
        Me.navListaAlunos.Caption = "Alunos"
        Me.navListaAlunos.Expanded = True
        Me.navListaAlunos.ImageOptions.SmallImage = CType(resources.GetObject("navListaAlunos.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navListaAlunos.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navListaAlunos_Completa), New DevExpress.XtraNavBar.NavBarItemLink(Me.navListaAlunos_ControleInterno), New DevExpress.XtraNavBar.NavBarItemLink(Me.navListaAlunos_ListaEntrega), New DevExpress.XtraNavBar.NavBarItemLink(Me.navListaAlunos_ListaPiloto), New DevExpress.XtraNavBar.NavBarItemLink(Me.navListaAlunos_Requerimento), New DevExpress.XtraNavBar.NavBarItemLink(Me.navListaAlunos_ReuniaoPaisMestres)})
        Me.navListaAlunos.Name = "navListaAlunos"
        '
        'navListaAlunos_Completa
        '
        Me.navListaAlunos_Completa.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.navListaAlunos_Completa.AppearanceDisabled.Options.UseFont = True
        Me.navListaAlunos_Completa.AppearanceHotTracked.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.navListaAlunos_Completa.AppearanceHotTracked.Options.UseFont = True
        Me.navListaAlunos_Completa.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.navListaAlunos_Completa.AppearancePressed.Options.UseFont = True
        Me.navListaAlunos_Completa.Caption = "Completa"
        Me.navListaAlunos_Completa.Name = "navListaAlunos_Completa"
        '
        'navListaAlunos_ControleInterno
        '
        Me.navListaAlunos_ControleInterno.AppearancePressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.navListaAlunos_ControleInterno.AppearancePressed.Options.UseFont = True
        Me.navListaAlunos_ControleInterno.Caption = "Controle Interno"
        Me.navListaAlunos_ControleInterno.Name = "navListaAlunos_ControleInterno"
        '
        'navListaAlunos_ListaEntrega
        '
        Me.navListaAlunos_ListaEntrega.Caption = "Lista de Entrega"
        Me.navListaAlunos_ListaEntrega.Name = "navListaAlunos_ListaEntrega"
        '
        'navListaAlunos_ListaPiloto
        '
        Me.navListaAlunos_ListaPiloto.Caption = "Lista Piloto"
        Me.navListaAlunos_ListaPiloto.Name = "navListaAlunos_ListaPiloto"
        '
        'navListaAlunos_Requerimento
        '
        Me.navListaAlunos_Requerimento.Caption = "Requerimento do Conselho"
        Me.navListaAlunos_Requerimento.Name = "navListaAlunos_Requerimento"
        '
        'navListaAlunos_ReuniaoPaisMestres
        '
        Me.navListaAlunos_ReuniaoPaisMestres.Caption = "Reunião de Pais e Mestres"
        Me.navListaAlunos_ReuniaoPaisMestres.Name = "navListaAlunos_ReuniaoPaisMestres"
        '
        'navBoletim
        '
        Me.navBoletim.Caption = "Boletim"
        Me.navBoletim.ImageOptions.SmallImage = CType(resources.GetObject("navBoletim.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navBoletim.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBoletim_Consolidado), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBoletim_Simples), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBoletim_StatusEntrega), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBoletim_Deliberacao11)})
        Me.navBoletim.Name = "navBoletim"
        '
        'navBoletim_Consolidado
        '
        Me.navBoletim_Consolidado.Caption = "Completo"
        Me.navBoletim_Consolidado.Name = "navBoletim_Consolidado"
        '
        'navBoletim_Simples
        '
        Me.navBoletim_Simples.Caption = "Simples"
        Me.navBoletim_Simples.Name = "navBoletim_Simples"
        '
        'navBoletim_StatusEntrega
        '
        Me.navBoletim_StatusEntrega.Caption = "Status de Entrega"
        Me.navBoletim_StatusEntrega.Name = "navBoletim_StatusEntrega"
        '
        'navBoletim_Deliberacao11
        '
        Me.navBoletim_Deliberacao11.Caption = "Deliberação 11"
        Me.navBoletim_Deliberacao11.Name = "navBoletim_Deliberacao11"
        '
        'navConsolidado
        '
        Me.navConsolidado.Caption = "Consolidado"
        Me.navConsolidado.ImageOptions.SmallImage = CType(resources.GetObject("navConsolidado.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navConsolidado.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navConsolidado_AlunosReprovados), New DevExpress.XtraNavBar.NavBarItemLink(Me.navConsolidado_AvaliaçãoFinal), New DevExpress.XtraNavBar.NavBarItemLink(Me.navConsolidado_Completo), New DevExpress.XtraNavBar.NavBarItemLink(Me.navConsolidado_NotasFrequencias)})
        Me.navConsolidado.Name = "navConsolidado"
        '
        'navConsolidado_AlunosReprovados
        '
        Me.navConsolidado_AlunosReprovados.Caption = "Alunos Reprovados"
        Me.navConsolidado_AlunosReprovados.Name = "navConsolidado_AlunosReprovados"
        '
        'navConsolidado_AvaliaçãoFinal
        '
        Me.navConsolidado_AvaliaçãoFinal.Caption = "Avaliação Final"
        Me.navConsolidado_AvaliaçãoFinal.Name = "navConsolidado_AvaliaçãoFinal"
        '
        'navConsolidado_Completo
        '
        Me.navConsolidado_Completo.Caption = "Completo"
        Me.navConsolidado_Completo.Name = "navConsolidado_Completo"
        '
        'navConsolidado_NotasFrequencias
        '
        Me.navConsolidado_NotasFrequencias.Caption = "Notas e Frequências"
        Me.navConsolidado_NotasFrequencias.Name = "navConsolidado_NotasFrequencias"
        '
        'navFichaIndividual
        '
        Me.navFichaIndividual.Caption = "Ficha Individual"
        Me.navFichaIndividual.ImageOptions.SmallImage = CType(resources.GetObject("navFichaIndividual.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navFichaIndividual.Name = "navFichaIndividual"
        '
        'navRendimentoEscolar
        '
        Me.navRendimentoEscolar.Caption = "Rendimento Escolar"
        Me.navRendimentoEscolar.ImageOptions.SmallImage = CType(resources.GetObject("navRendimentoEscolar.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navRendimentoEscolar.Name = "navRendimentoEscolar"
        '
        'navGraficos
        '
        Me.navGraficos.Caption = "Gráficos"
        Me.navGraficos.ImageOptions.SmallImage = CType(resources.GetObject("navGraficos.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.navGraficos.Name = "navGraficos"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(181, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(12, 568)
        Me.SplitterControl1.TabIndex = 2
        Me.SplitterControl1.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.cbAF)
        Me.GroupControl1.Controls.Add(Me.pbConsulta)
        Me.GroupControl1.Controls.Add(Me.btImprimir)
        Me.GroupControl1.Controls.Add(Me.tBimestre)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.tAno)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(193, 471)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(605, 97)
        Me.GroupControl1.TabIndex = 6
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(308, 62)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(124, 20)
        Me.TextEdit1.TabIndex = 36
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(265, 63)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl4.TabIndex = 35
        Me.LabelControl4.Text = "Aluno:"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(308, 32)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Todos", "Manhã", "Tarde", "Noite", "Integral"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(124, 20)
        Me.ComboBoxEdit1.TabIndex = 34
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(254, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Período:"
        '
        'cbAF
        '
        Me.cbAF.Location = New System.Drawing.Point(166, 60)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(82, 23)
        Me.cbAF.TabIndex = 32
        Me.cbAF.Text = "Avaliação Final"
        '
        'pbConsulta
        '
        Me.pbConsulta.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbConsulta.EditValue = CType(resources.GetObject("pbConsulta.EditValue"), Object)
        Me.pbConsulta.Location = New System.Drawing.Point(438, 61)
        Me.pbConsulta.Name = "pbConsulta"
        Me.pbConsulta.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbConsulta.Size = New System.Drawing.Size(22, 22)
        Me.pbConsulta.TabIndex = 29
        '
        'btImprimir
        '
        Me.btImprimir.Location = New System.Drawing.Point(518, 61)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btImprimir.TabIndex = 28
        Me.btImprimir.Text = "Imprimir!"
        '
        'tBimestre
        '
        Me.tBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Location = New System.Drawing.Point(120, 60)
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Properties.Appearance.Options.UseFont = True
        Me.tBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tBimestre.Properties.IsFloatValue = False
        Me.tBimestre.Properties.Mask.EditMask = "N00"
        Me.tBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Size = New System.Drawing.Size(40, 22)
        Me.tBimestre.TabIndex = 26
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(60, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "Bimestre:"
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(92, 30)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = True
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(58, 22)
        Me.tAno.TabIndex = 24
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(60, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 16)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "Ano:"
        '
        'gridRelatorio
        '
        Me.gridRelatorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRelatorio.Location = New System.Drawing.Point(193, 0)
        Me.gridRelatorio.MainView = Me.viewRelatorio
        Me.gridRelatorio.Name = "gridRelatorio"
        Me.gridRelatorio.Size = New System.Drawing.Size(605, 471)
        Me.gridRelatorio.TabIndex = 3
        Me.gridRelatorio.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewRelatorio})
        '
        'viewRelatorio
        '
        Me.viewRelatorio.GridControl = Me.gridRelatorio
        Me.viewRelatorio.Name = "viewRelatorio"
        '
        'frmRptRelatorioTela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(798, 568)
        Me.Controls.Add(Me.gridRelatorio)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.barraRelatorios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptRelatorioTela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meu Relatório!"
        Me.TopMost = True
        CType(Me.barraRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConsulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRelatorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewRelatorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents barraRelatorios As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents navConsolidado As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navConsolidado_AlunosReprovados As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navConsolidado_AvaliaçãoFinal As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navConsolidado_Completo As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navConsolidado_NotasFrequencias As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBoletim As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navBoletim_Consolidado As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBoletim_Simples As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBoletim_StatusEntrega As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navBoletim_Deliberacao11 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navFichaIndividual As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navListaAlunos As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navRendimentoEscolar As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navGraficos As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pbConsulta As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tBimestre As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridRelatorio As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewRelatorio As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckButton
    Friend WithEvents navListaAlunos_Completa As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navListaAlunos_ControleInterno As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navListaAlunos_ListaEntrega As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navListaAlunos_ListaPiloto As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navListaAlunos_Requerimento As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents navListaAlunos_ReuniaoPaisMestres As DevExpress.XtraNavBar.NavBarItem
End Class
