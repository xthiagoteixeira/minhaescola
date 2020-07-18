<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptGrafico
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptGrafico))
        Me.navegadorRelatorio = New DevExpress.XtraNavBar.NavBarControl()
        Me.navRelatorio = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cbRelatorioFiltro = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbRelatorio = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cbTurma = New System.Windows.Forms.ComboBox()
        Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.NavBarGroupControlContainer4 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.tbNome = New System.Windows.Forms.TextBox()
        Me.NavBarGroupControlContainer5 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cbTurmaLista = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.NavBarGroupControlContainer6 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cbEvasao = New System.Windows.Forms.ComboBox()
        Me.navAluno = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navTurma = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navTurmaSelecionar = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navPeriodo = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navEvasao = New DevExpress.XtraNavBar.NavBarGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btVisualizar = New System.Windows.Forms.Button()
        Me.splitPrincipal = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.cbAF = New DevExpress.XtraEditors.CheckButton()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.bwConsulta = New System.ComponentModel.BackgroundWorker()
        Me.barra = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.tempoBarra = New System.Windows.Forms.Timer(Me.components)
        Me.frmTempo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.navegadorRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navegadorRelatorio.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.cbRelatorioFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRelatorio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        Me.NavBarGroupControlContainer3.SuspendLayout()
        Me.NavBarGroupControlContainer4.SuspendLayout()
        Me.NavBarGroupControlContainer5.SuspendLayout()
        CType(Me.cbTurmaLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer6.SuspendLayout()
        CType(Me.splitPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitPrincipal.Panel1.SuspendLayout()
        Me.splitPrincipal.Panel2.SuspendLayout()
        Me.splitPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'navegadorRelatorio
        '
        Me.navegadorRelatorio.ActiveGroup = Me.navRelatorio
        Me.navegadorRelatorio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.navegadorRelatorio.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.navegadorRelatorio.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.navegadorRelatorio.Controls.Add(Me.NavBarGroupControlContainer3)
        Me.navegadorRelatorio.Controls.Add(Me.NavBarGroupControlContainer4)
        Me.navegadorRelatorio.Controls.Add(Me.NavBarGroupControlContainer5)
        Me.navegadorRelatorio.Controls.Add(Me.NavBarGroupControlContainer6)
        Me.navegadorRelatorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navegadorRelatorio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.navegadorRelatorio.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navRelatorio, Me.navAluno, Me.navTurma, Me.navTurmaSelecionar, Me.navPeriodo, Me.navEvasao})
        Me.navegadorRelatorio.Location = New System.Drawing.Point(0, 0)
        Me.navegadorRelatorio.Name = "navegadorRelatorio"
        Me.navegadorRelatorio.OptionsNavPane.ExpandedWidth = 230
        Me.navegadorRelatorio.Size = New System.Drawing.Size(230, 729)
        Me.navegadorRelatorio.TabIndex = 2
        Me.navegadorRelatorio.View = New DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator()
        '
        'navRelatorio
        '
        Me.navRelatorio.Caption = "Relatório"
        Me.navRelatorio.ControlContainer = Me.NavBarGroupControlContainer1
        Me.navRelatorio.Expanded = True
        Me.navRelatorio.GroupClientHeight = 96
        Me.navRelatorio.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navRelatorio.Name = "navRelatorio"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.cbRelatorioFiltro)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.cbRelatorio)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.tAno)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LabelControl2)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(204, 95)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'cbRelatorioFiltro
        '
        Me.cbRelatorioFiltro.Location = New System.Drawing.Point(25, 41)
        Me.cbRelatorioFiltro.Name = "cbRelatorioFiltro"
        Me.cbRelatorioFiltro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRelatorioFiltro.Size = New System.Drawing.Size(156, 20)
        Me.cbRelatorioFiltro.TabIndex = 11
        '
        'cbRelatorio
        '
        Me.cbRelatorio.Location = New System.Drawing.Point(25, 11)
        Me.cbRelatorio.Name = "cbRelatorio"
        Me.cbRelatorio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRelatorio.Properties.Items.AddRange(New Object() {"Básico", "Detalhado"})
        Me.cbRelatorio.Size = New System.Drawing.Size(156, 20)
        Me.cbRelatorio.TabIndex = 10
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(128, 66)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(53, 20)
        Me.tAno.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(51, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Ano Vigente:"
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Controls.Add(Me.cbTurma)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(204, 44)
        Me.NavBarGroupControlContainer2.TabIndex = 1
        '
        'cbTurma
        '
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Location = New System.Drawing.Point(10, 10)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(185, 21)
        Me.cbTurma.TabIndex = 9
        '
        'NavBarGroupControlContainer3
        '
        Me.NavBarGroupControlContainer3.Controls.Add(Me.cbPeriodo)
        Me.NavBarGroupControlContainer3.Name = "NavBarGroupControlContainer3"
        Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(204, 42)
        Me.NavBarGroupControlContainer3.TabIndex = 2
        '
        'cbPeriodo
        '
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite", "Integral", "Intermediário", "Vespertino"})
        Me.cbPeriodo.Location = New System.Drawing.Point(10, 9)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(185, 21)
        Me.cbPeriodo.TabIndex = 9
        '
        'NavBarGroupControlContainer4
        '
        Me.NavBarGroupControlContainer4.Controls.Add(Me.SimpleButton1)
        Me.NavBarGroupControlContainer4.Controls.Add(Me.tbNome)
        Me.NavBarGroupControlContainer4.Name = "NavBarGroupControlContainer4"
        Me.NavBarGroupControlContainer4.Size = New System.Drawing.Size(204, 45)
        Me.NavBarGroupControlContainer4.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.AutoSize = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(168, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton1.TabIndex = 1
        '
        'tbNome
        '
        Me.tbNome.Location = New System.Drawing.Point(17, 10)
        Me.tbNome.Name = "tbNome"
        Me.tbNome.Size = New System.Drawing.Size(149, 21)
        Me.tbNome.TabIndex = 0
        '
        'NavBarGroupControlContainer5
        '
        Me.NavBarGroupControlContainer5.Controls.Add(Me.cbTurmaLista)
        Me.NavBarGroupControlContainer5.Name = "NavBarGroupControlContainer5"
        Me.NavBarGroupControlContainer5.Size = New System.Drawing.Size(204, 197)
        Me.NavBarGroupControlContainer5.TabIndex = 4
        '
        'cbTurmaLista
        '
        Me.cbTurmaLista.CheckOnClick = True
        Me.cbTurmaLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbTurmaLista.Location = New System.Drawing.Point(0, 0)
        Me.cbTurmaLista.Name = "cbTurmaLista"
        Me.cbTurmaLista.Size = New System.Drawing.Size(204, 197)
        Me.cbTurmaLista.TabIndex = 0
        '
        'NavBarGroupControlContainer6
        '
        Me.NavBarGroupControlContainer6.Controls.Add(Me.cbEvasao)
        Me.NavBarGroupControlContainer6.Name = "NavBarGroupControlContainer6"
        Me.NavBarGroupControlContainer6.Size = New System.Drawing.Size(204, 50)
        Me.NavBarGroupControlContainer6.TabIndex = 5
        '
        'cbEvasao
        '
        Me.cbEvasao.FormattingEnabled = True
        Me.cbEvasao.Items.AddRange(New Object() {"Abandono", "Licença Saúde", "Licença Gestante", "Óbitos", "Remanejados", "Transferidos"})
        Me.cbEvasao.Location = New System.Drawing.Point(10, 13)
        Me.cbEvasao.Name = "cbEvasao"
        Me.cbEvasao.Size = New System.Drawing.Size(185, 21)
        Me.cbEvasao.TabIndex = 10
        '
        'navAluno
        '
        Me.navAluno.Caption = "Nome do Aluno"
        Me.navAluno.ControlContainer = Me.NavBarGroupControlContainer4
        Me.navAluno.GroupClientHeight = 46
        Me.navAluno.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navAluno.Name = "navAluno"
        '
        'navTurma
        '
        Me.navTurma.Caption = "Turma - Individual"
        Me.navTurma.ControlContainer = Me.NavBarGroupControlContainer2
        Me.navTurma.GroupClientHeight = 45
        Me.navTurma.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navTurma.Name = "navTurma"
        '
        'navTurmaSelecionar
        '
        Me.navTurmaSelecionar.Caption = "Turma - Selecionar um Grupo"
        Me.navTurmaSelecionar.ControlContainer = Me.NavBarGroupControlContainer5
        Me.navTurmaSelecionar.GroupClientHeight = 198
        Me.navTurmaSelecionar.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navTurmaSelecionar.Name = "navTurmaSelecionar"
        '
        'navPeriodo
        '
        Me.navPeriodo.Caption = "Período"
        Me.navPeriodo.ControlContainer = Me.NavBarGroupControlContainer3
        Me.navPeriodo.GroupClientHeight = 43
        Me.navPeriodo.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navPeriodo.Name = "navPeriodo"
        '
        'navEvasao
        '
        Me.navEvasao.Caption = "Evasão Escolar"
        Me.navEvasao.ControlContainer = Me.NavBarGroupControlContainer6
        Me.navEvasao.GroupClientHeight = 51
        Me.navEvasao.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navEvasao.Name = "navEvasao"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(91, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "º Bimestre"
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.ShowCloseButton = False
        Me.crViewer.ShowGroupTreeButton = False
        Me.crViewer.ShowLogo = False
        Me.crViewer.ShowParameterPanelButton = False
        Me.crViewer.ShowRefreshButton = False
        Me.crViewer.Size = New System.Drawing.Size(865, 795)
        Me.crViewer.TabIndex = 4
        Me.crViewer.ToolPanelWidth = 95
        '
        'btVisualizar
        '
        Me.btVisualizar.Enabled = False
        Me.btVisualizar.Location = New System.Drawing.Point(54, 35)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(126, 23)
        Me.btVisualizar.TabIndex = 0
        Me.btVisualizar.Text = "Visualizar!"
        Me.btVisualizar.UseVisualStyleBackColor = True
        '
        'splitPrincipal
        '
        Me.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitPrincipal.IsSplitterFixed = True
        Me.splitPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.splitPrincipal.Name = "splitPrincipal"
        '
        'splitPrincipal.Panel1
        '
        Me.splitPrincipal.Panel1.Controls.Add(Me.navegadorRelatorio)
        Me.splitPrincipal.Panel1.Controls.Add(Me.Panel1)
        '
        'splitPrincipal.Panel2
        '
        Me.splitPrincipal.Panel2.Controls.Add(Me.crViewer)
        Me.splitPrincipal.Size = New System.Drawing.Size(1099, 795)
        Me.splitPrincipal.SplitterDistance = 230
        Me.splitPrincipal.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tBimestre)
        Me.Panel1.Controls.Add(Me.cbAF)
        Me.Panel1.Controls.Add(Me.btVisualizar)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 729)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 66)
        Me.Panel1.TabIndex = 3
        '
        'tBimestre
        '
        Me.tBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Location = New System.Drawing.Point(55, 10)
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tBimestre.Properties.IsFloatValue = False
        Me.tBimestre.Properties.Mask.EditMask = "N00"
        Me.tBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Size = New System.Drawing.Size(34, 20)
        Me.tBimestre.TabIndex = 7
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Enabled = False
        Me.cbAF.Location = New System.Drawing.Point(157, 9)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(22, 22)
        Me.cbAF.TabIndex = 6
        Me.cbAF.Text = "AF"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 14
        Me.LineShape1.X2 = 213
        Me.LineShape1.Y1 = 48
        Me.LineShape1.Y2 = 48
        '
        'bwConsulta
        '
        Me.bwConsulta.WorkerReportsProgress = True
        Me.bwConsulta.WorkerSupportsCancellation = True
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.EditValue = "00:00"
        Me.barra.Location = New System.Drawing.Point(0, 795)
        Me.barra.Name = "barra"
        Me.barra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.barra.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.DisplayFormat.FormatString = "d"
        Me.barra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.EditFormat.FormatString = "d"
        Me.barra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.Paused = True
        Me.barra.Properties.ShowTitle = True
        Me.barra.Size = New System.Drawing.Size(1099, 18)
        Me.barra.TabIndex = 19
        '
        'tempoBarra
        '
        Me.tempoBarra.Enabled = True
        Me.tempoBarra.Interval = 50
        '
        'frmTempo
        '
        Me.frmTempo.Interval = 300
        '
        'frmRptGrafico
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1099, 813)
        Me.Controls.Add(Me.splitPrincipal)
        Me.Controls.Add(Me.barra)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRptGrafico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meu Gráfico!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.navegadorRelatorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navegadorRelatorio.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.PerformLayout()
        CType(Me.cbRelatorioFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRelatorio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        Me.NavBarGroupControlContainer3.ResumeLayout(False)
        Me.NavBarGroupControlContainer4.ResumeLayout(False)
        Me.NavBarGroupControlContainer4.PerformLayout()
        Me.NavBarGroupControlContainer5.ResumeLayout(False)
        CType(Me.cbTurmaLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer6.ResumeLayout(False)
        Me.splitPrincipal.Panel1.ResumeLayout(False)
        Me.splitPrincipal.Panel2.ResumeLayout(False)
        CType(Me.splitPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitPrincipal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    '   Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents navegadorRelatorio As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents navRelatorio As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navTurma As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents navPeriodo As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer4 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents navAluno As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btVisualizar As System.Windows.Forms.Button
    Friend WithEvents splitPrincipal As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents navEvasao As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents tbNome As System.Windows.Forms.TextBox
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents navTurmaSelecionar As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer5 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer6 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents cbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents bwConsulta As System.ComponentModel.BackgroundWorker
    'Friend WithEvents barraConsulta As DevComponents.DotNetBar.Controls.ProgressBarX
    Private WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbEvasao As System.Windows.Forms.ComboBox
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckButton
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tBimestre As DevExpress.XtraEditors.SpinEdit
    Private WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents cbTurmaLista As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents barra As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents tempoBarra As Timer
    Friend WithEvents frmTempo As Timer
    Friend WithEvents cbRelatorio As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbRelatorioFiltro As DevExpress.XtraEditors.ComboBoxEdit
End Class
