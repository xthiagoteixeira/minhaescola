<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptRelatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptRelatorio))
        Me.bwConsulta = New System.ComponentModel.BackgroundWorker()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barraFerramentas = New DevExpress.XtraBars.Bar()
        Me.tAno = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.tBimestre = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.cbAF = New DevExpress.XtraBars.BarCheckItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.cbRelatorio = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.cbEstilo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cbFiltro = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.barra = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.tempoBarra = New System.Windows.Forms.Timer(Me.components)
        Me.frmTempo = New System.Windows.Forms.Timer(Me.components)
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemComboBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemComboBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemComboBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemPictureEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemCheckEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMarqueeProgressBar1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.barra.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'bwConsulta
        '
        Me.bwConsulta.WorkerReportsProgress = true
        Me.bwConsulta.WorkerSupportsCancellation = true
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barraFerramentas})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.tAno, Me.BarStaticItem1, Me.tBimestre, Me.cbAF, Me.cbRelatorio, Me.cbEstilo, Me.cbFiltro, Me.BarStaticItem2, Me.BarStaticItem3, Me.BarEditItem1, Me.btBuscar})
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1, Me.RepositoryItemSpinEdit2, Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemMarqueeProgressBar1, Me.RepositoryItemPictureEdit1})
        '
        'barraFerramentas
        '
        Me.barraFerramentas.BarName = "Meu Relatório!"
        Me.barraFerramentas.DockCol = 0
        Me.barraFerramentas.DockRow = 0
        Me.barraFerramentas.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.barraFerramentas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tAno), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.tBimestre), New DevExpress.XtraBars.LinkPersistInfo(Me.cbAF), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.cbRelatorio), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.cbEstilo), New DevExpress.XtraBars.LinkPersistInfo(Me.cbFiltro), New DevExpress.XtraBars.LinkPersistInfo(Me.btBuscar)})
        Me.barraFerramentas.OptionsBar.AllowQuickCustomization = false
        Me.barraFerramentas.Text = "Meu Relatório!"
        '
        'tAno
        '
        Me.tAno.Caption = "2014"
        Me.tAno.Edit = Me.RepositoryItemSpinEdit1
        Me.tAno.EditWidth = 60
        Me.tAno.Id = 0
        Me.tAno.Name = "tAno"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = false
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.IsFloatValue = false
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "N00"
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.NullText = "2014"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Bimestre:"
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'tBimestre
        '
        Me.tBimestre.Caption = "Bimestre"
        Me.tBimestre.Edit = Me.RepositoryItemSpinEdit2
        Me.tBimestre.EditValue = "1"
        Me.tBimestre.EditWidth = 36
        Me.tBimestre.Id = 2
        Me.tBimestre.Name = "tBimestre"
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit2.IsFloatValue = False
        Me.RepositoryItemSpinEdit2.Mask.EditMask = "N00"
        Me.RepositoryItemSpinEdit2.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.RepositoryItemSpinEdit2.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        Me.RepositoryItemSpinEdit2.NullText = "1"
        '
        'cbAF
        '
        Me.cbAF.Caption = "AF"
        Me.cbAF.Description = "Avaliação Final"
        Me.cbAF.Enabled = False
        Me.cbAF.Id = 5
        Me.cbAF.Name = "cbAF"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Relatório:"
        Me.BarStaticItem2.Id = 10
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'cbRelatorio
        '
        Me.cbRelatorio.Caption = "Relatório"
        Me.cbRelatorio.Description = "Relatório"
        Me.cbRelatorio.Edit = Me.RepositoryItemComboBox1
        Me.cbRelatorio.EditWidth = 146
        Me.cbRelatorio.Id = 6
        Me.cbRelatorio.Name = "cbRelatorio"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Boletim", "Consolidado", "Deliberação 11", "Ficha Individual", "Lista de Alunos", "Rendimento Escolar"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Estilo:"
        Me.BarStaticItem3.Id = 11
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'cbEstilo
        '
        Me.cbEstilo.Caption = "Estilo"
        Me.cbEstilo.Description = "Estilo"
        Me.cbEstilo.Edit = Me.RepositoryItemComboBox2
        Me.cbEstilo.EditWidth = 156
        Me.cbEstilo.Enabled = False
        Me.cbEstilo.Id = 7
        Me.cbEstilo.Name = "cbEstilo"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'cbFiltro
        '
        Me.cbFiltro.Caption = "Filtro"
        Me.cbFiltro.Description = "Filtro"
        Me.cbFiltro.Edit = Me.RepositoryItemComboBox3
        Me.cbFiltro.EditWidth = 136
        Me.cbFiltro.Enabled = False
        Me.cbFiltro.Id = 8
        Me.cbFiltro.Name = "cbFiltro"
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'btBuscar
        '
        Me.btBuscar.Caption = "Pesquisar!"
        Me.btBuscar.Id = 13
        Me.btBuscar.ImageOptions.Image = CType(resources.GetObject("btBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btBuscar.ImageOptions.LargeImage = CType(resources.GetObject("btBuscar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btBuscar.Name = "btBuscar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(838, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 561)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(838, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 532)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(838, 29)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 532)
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemPictureEdit1
        Me.BarEditItem1.Id = 12
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        Me.RepositoryItemMarqueeProgressBar1.Paused = True
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.EditValue = "00:00"
        Me.barra.Location = New System.Drawing.Point(0, 543)
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
        Me.barra.Size = New System.Drawing.Size(838, 18)
        Me.barra.TabIndex = 18
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
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 29)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.ShowCloseButton = False
        Me.crViewer.ShowGroupTreeButton = False
        Me.crViewer.ShowLogo = False
        Me.crViewer.ShowParameterPanelButton = False
        Me.crViewer.ShowRefreshButton = False
        Me.crViewer.Size = New System.Drawing.Size(838, 514)
        Me.crViewer.TabIndex = 23
        '
        'frmRptRelatorio
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(838, 561)
        Me.Controls.Add(Me.crViewer)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRptRelatorio"
        Me.ShowMdiChildCaptionInParentTitle = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meu Relatório!"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemComboBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemComboBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemComboBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemPictureEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemCheckEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMarqueeProgressBar1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.barra.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    '   Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents bwConsulta As System.ComponentModel.BackgroundWorker
    ' Private WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barraFerramentas As DevExpress.XtraBars.Bar
    Friend WithEvents tAno As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents tBimestre As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cbAF As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents cbRelatorio As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cbEstilo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cbFiltro As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents barra As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents tempoBarra As System.Windows.Forms.Timer
    Friend WithEvents frmTempo As System.Windows.Forms.Timer
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
