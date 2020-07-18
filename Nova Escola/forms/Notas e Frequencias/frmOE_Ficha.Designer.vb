<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOE_Ficha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOE_Ficha))
        Me.bwOE = New System.ComponentModel.BackgroundWorker()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.btAbandonoPorTurno = New DevExpress.XtraEditors.SimpleButton()
        Me.btReprovadosPorTurno = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.btEvolucaoTaxas = New DevExpress.XtraEditors.SimpleButton()
        Me.btDesempenho = New DevExpress.XtraEditors.SimpleButton()
        Me.btIndicadores = New DevExpress.XtraEditors.SimpleButton()
        Me.btStatusAlunos = New DevExpress.XtraEditors.SimpleButton()
        Me.tAnoVigente = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DocumentViewerBarManager1 = New DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PrintPreviewStaticItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
        Me.verticalSpaceItem = New DevExpress.XtraBars.BarStaticItem()
        Me.ProgressBarEditItem1 = New DevExpress.XtraPrinting.Preview.ProgressBarEditItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.PrintPreviewBarItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.PrintPreviewStaticItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
        Me.ZoomTrackBarEditItem1 = New DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem()
        Me.RepositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
        Me.bbiDocumentMap = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiParameters = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiThumbnails = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiFind = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiHighlightEditingFields = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiCustomize = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiOpen = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiSave = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPrint = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPrintDirect = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPageSetup = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiEditPageHF = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiScale = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiHandTool = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiMagnifier = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiZoomOut = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiZoom = New DevExpress.XtraPrinting.Preview.ZoomBarEditItem()
        Me.PrintPreviewRepositoryItemComboBox1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox()
        Me.bbiZoomIn = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowFirstPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowPrevPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowNextPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowLastPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiMultiplePages = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiFillBackground = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiWatermark = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiExportFile = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiSendFile = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiClosePreview = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miFile = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miView = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miPageLayout = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miPageLayoutFacing = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miPageLayoutContinuous = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miToolbars = New DevExpress.XtraBars.BarToolbarsListItem()
        Me.miBackground = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.PrintPreviewBarCheckItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem9 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem10 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem11 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem12 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem13 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem14 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem15 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem16 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem17 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem18 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem19 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.barra = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.tempoBarra = New System.Windows.Forms.Timer(Me.components)
        Me.frmTempo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tAnoVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentViewerBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bwOE
        '
        Me.bwOE.WorkerReportsProgress = True
        Me.bwOE.WorkerSupportsCancellation = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton11)
        Me.GroupControl1.Controls.Add(Me.SimpleButton12)
        Me.GroupControl1.Controls.Add(Me.btAbandonoPorTurno)
        Me.GroupControl1.Controls.Add(Me.btReprovadosPorTurno)
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.SimpleButton6)
        Me.GroupControl1.Controls.Add(Me.btEvolucaoTaxas)
        Me.GroupControl1.Controls.Add(Me.btDesempenho)
        Me.GroupControl1.Controls.Add(Me.btIndicadores)
        Me.GroupControl1.Controls.Add(Me.btStatusAlunos)
        Me.GroupControl1.Controls.Add(Me.tAnoVigente)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(175, 550)
        Me.GroupControl1.TabIndex = 6
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Location = New System.Drawing.Point(12, 323)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(149, 23)
        Me.SimpleButton11.TabIndex = 13
        Me.SimpleButton11.Text = "SimpleButton11"
        Me.SimpleButton11.Visible = False
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Location = New System.Drawing.Point(12, 294)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(149, 23)
        Me.SimpleButton12.TabIndex = 12
        Me.SimpleButton12.Text = "SimpleButton12"
        Me.SimpleButton12.Visible = False
        '
        'btAbandonoPorTurno
        '
        Me.btAbandonoPorTurno.ImageOptions.Image = CType(resources.GetObject("btAbandonoPorTurno.ImageOptions.Image"), System.Drawing.Image)
        Me.btAbandonoPorTurno.Location = New System.Drawing.Point(12, 207)
        Me.btAbandonoPorTurno.Name = "btAbandonoPorTurno"
        Me.btAbandonoPorTurno.Size = New System.Drawing.Size(149, 23)
        Me.btAbandonoPorTurno.TabIndex = 11
        Me.btAbandonoPorTurno.Text = "Abandonos p/ Turno"
        '
        'btReprovadosPorTurno
        '
        Me.btReprovadosPorTurno.ImageOptions.Image = CType(resources.GetObject("btReprovadosPorTurno.ImageOptions.Image"), System.Drawing.Image)
        Me.btReprovadosPorTurno.Location = New System.Drawing.Point(12, 178)
        Me.btReprovadosPorTurno.Name = "btReprovadosPorTurno"
        Me.btReprovadosPorTurno.Size = New System.Drawing.Size(149, 23)
        Me.btReprovadosPorTurno.TabIndex = 10
        Me.btReprovadosPorTurno.Text = "Reprovados p/ Turno"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(12, 265)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(149, 23)
        Me.SimpleButton5.TabIndex = 7
        Me.SimpleButton5.Text = "SimpleButton5"
        Me.SimpleButton5.Visible = False
        '
        'SimpleButton6
        '
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(12, 236)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(149, 23)
        Me.SimpleButton6.TabIndex = 6
        Me.SimpleButton6.Text = "Abandonos p/ Turma"
        '
        'btEvolucaoTaxas
        '
        Me.btEvolucaoTaxas.ImageOptions.Image = CType(resources.GetObject("btEvolucaoTaxas.ImageOptions.Image"), System.Drawing.Image)
        Me.btEvolucaoTaxas.Location = New System.Drawing.Point(12, 149)
        Me.btEvolucaoTaxas.Name = "btEvolucaoTaxas"
        Me.btEvolucaoTaxas.Size = New System.Drawing.Size(149, 23)
        Me.btEvolucaoTaxas.TabIndex = 5
        Me.btEvolucaoTaxas.Text = "Evolução das Taxas"
        '
        'btDesempenho
        '
        Me.btDesempenho.ImageOptions.Image = CType(resources.GetObject("btDesempenho.ImageOptions.Image"), System.Drawing.Image)
        Me.btDesempenho.Location = New System.Drawing.Point(12, 120)
        Me.btDesempenho.Name = "btDesempenho"
        Me.btDesempenho.Size = New System.Drawing.Size(149, 23)
        Me.btDesempenho.TabIndex = 4
        Me.btDesempenho.Text = "Problemas Desempenho"
        '
        'btIndicadores
        '
        Me.btIndicadores.ImageOptions.Image = CType(resources.GetObject("btIndicadores.ImageOptions.Image"), System.Drawing.Image)
        Me.btIndicadores.Location = New System.Drawing.Point(12, 91)
        Me.btIndicadores.Name = "btIndicadores"
        Me.btIndicadores.Size = New System.Drawing.Size(149, 23)
        Me.btIndicadores.TabIndex = 3
        Me.btIndicadores.Text = "Indicadores"
        '
        'btStatusAlunos
        '
        Me.btStatusAlunos.ImageOptions.Image = CType(resources.GetObject("btStatusAlunos.ImageOptions.Image"), System.Drawing.Image)
        Me.btStatusAlunos.Location = New System.Drawing.Point(12, 62)
        Me.btStatusAlunos.Name = "btStatusAlunos"
        Me.btStatusAlunos.Size = New System.Drawing.Size(149, 23)
        Me.btStatusAlunos.TabIndex = 2
        Me.btStatusAlunos.Text = "Status dos Alunos"
        '
        'tAnoVigente
        '
        Me.tAnoVigente.EditValue = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.tAnoVigente.Location = New System.Drawing.Point(68, 31)
        Me.tAnoVigente.Name = "tAnoVigente"
        Me.tAnoVigente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAnoVigente.Properties.MaxValue = New Decimal(New Integer() {2030, 0, 0, 0})
        Me.tAnoVigente.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAnoVigente.Size = New System.Drawing.Size(58, 20)
        Me.tAnoVigente.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(39, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Ano:"
        '
        'DocumentViewerBarManager1
        '
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlTop)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlRight)
        Me.DocumentViewerBarManager1.Form = Me
        Me.DocumentViewerBarManager1.ImageStream = CType(resources.GetObject("DocumentViewerBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.DocumentViewerBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.PrintPreviewStaticItem1, Me.verticalSpaceItem, Me.ProgressBarEditItem1, Me.PrintPreviewBarItem1, Me.PrintPreviewStaticItem2, Me.ZoomTrackBarEditItem1, Me.bbiDocumentMap, Me.bbiParameters, Me.bbiThumbnails, Me.bbiFind, Me.bbiHighlightEditingFields, Me.bbiCustomize, Me.bbiOpen, Me.bbiSave, Me.bbiPrint, Me.bbiPrintDirect, Me.bbiPageSetup, Me.bbiEditPageHF, Me.bbiScale, Me.bbiHandTool, Me.bbiMagnifier, Me.bbiZoomOut, Me.bbiZoom, Me.bbiZoomIn, Me.bbiShowFirstPage, Me.bbiShowPrevPage, Me.bbiShowNextPage, Me.bbiShowLastPage, Me.bbiMultiplePages, Me.bbiFillBackground, Me.bbiWatermark, Me.bbiExportFile, Me.bbiSendFile, Me.bbiClosePreview, Me.miFile, Me.miView, Me.miBackground, Me.miPageLayout, Me.miPageLayoutFacing, Me.miPageLayoutContinuous, Me.miToolbars, Me.PrintPreviewBarCheckItem1, Me.PrintPreviewBarCheckItem2, Me.PrintPreviewBarCheckItem3, Me.PrintPreviewBarCheckItem4, Me.PrintPreviewBarCheckItem5, Me.PrintPreviewBarCheckItem6, Me.PrintPreviewBarCheckItem7, Me.PrintPreviewBarCheckItem8, Me.PrintPreviewBarCheckItem9, Me.PrintPreviewBarCheckItem10, Me.PrintPreviewBarCheckItem11, Me.PrintPreviewBarCheckItem12, Me.PrintPreviewBarCheckItem13, Me.PrintPreviewBarCheckItem14, Me.PrintPreviewBarCheckItem15, Me.PrintPreviewBarCheckItem16, Me.PrintPreviewBarCheckItem17, Me.PrintPreviewBarCheckItem18, Me.PrintPreviewBarCheckItem19})
        Me.DocumentViewerBarManager1.MaxItemId = 60
        Me.DocumentViewerBarManager1.PreviewBar = Nothing
        Me.DocumentViewerBarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemZoomTrackBar1, Me.PrintPreviewRepositoryItemComboBox1})
        Me.DocumentViewerBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(990, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 550)
        Me.barDockControlBottom.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(990, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 550)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(990, 0)
        Me.barDockControlRight.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 550)
        '
        'PrintPreviewStaticItem1
        '
        Me.PrintPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PrintPreviewStaticItem1.Caption = "Nothing"
        Me.PrintPreviewStaticItem1.Id = 0
        Me.PrintPreviewStaticItem1.LeftIndent = 1
        Me.PrintPreviewStaticItem1.Name = "PrintPreviewStaticItem1"
        Me.PrintPreviewStaticItem1.RightIndent = 1
        Me.PrintPreviewStaticItem1.Type = "PageOfPages"
        '
        'verticalSpaceItem
        '
        Me.verticalSpaceItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.verticalSpaceItem.Enabled = False
        Me.verticalSpaceItem.Id = 1
        Me.verticalSpaceItem.Name = "verticalSpaceItem"
        Me.verticalSpaceItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
        '
        'ProgressBarEditItem1
        '
        Me.ProgressBarEditItem1.Edit = Me.RepositoryItemProgressBar1
        Me.ProgressBarEditItem1.EditHeight = 12
        Me.ProgressBarEditItem1.EditWidth = 150
        Me.ProgressBarEditItem1.Id = 2
        Me.ProgressBarEditItem1.Name = "ProgressBarEditItem1"
        Me.ProgressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'PrintPreviewBarItem1
        '
        Me.PrintPreviewBarItem1.Caption = "Stop"
        Me.PrintPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding
        Me.PrintPreviewBarItem1.Enabled = False
        Me.PrintPreviewBarItem1.Hint = "Stop"
        Me.PrintPreviewBarItem1.Id = 3
        Me.PrintPreviewBarItem1.Name = "PrintPreviewBarItem1"
        Me.PrintPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'PrintPreviewStaticItem2
        '
        Me.PrintPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.PrintPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PrintPreviewStaticItem2.Caption = "100%"
        Me.PrintPreviewStaticItem2.Id = 4
        Me.PrintPreviewStaticItem2.Name = "PrintPreviewStaticItem2"
        Me.PrintPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far
        Me.PrintPreviewStaticItem2.Type = "ZoomFactor"
        '
        'ZoomTrackBarEditItem1
        '
        Me.ZoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.ZoomTrackBarEditItem1.Edit = Me.RepositoryItemZoomTrackBar1
        Me.ZoomTrackBarEditItem1.EditValue = 90
        Me.ZoomTrackBarEditItem1.EditWidth = 140
        Me.ZoomTrackBarEditItem1.Enabled = False
        Me.ZoomTrackBarEditItem1.Id = 5
        Me.ZoomTrackBarEditItem1.Name = "ZoomTrackBarEditItem1"
        Me.ZoomTrackBarEditItem1.Range = New Integer() {10, 500}
        '
        'RepositoryItemZoomTrackBar1
        '
        Me.RepositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
        Me.RepositoryItemZoomTrackBar1.AllowFocused = False
        Me.RepositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemZoomTrackBar1.Maximum = 180
        Me.RepositoryItemZoomTrackBar1.Name = "RepositoryItemZoomTrackBar1"
        '
        'bbiDocumentMap
        '
        Me.bbiDocumentMap.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiDocumentMap.Caption = "Document Map"
        Me.bbiDocumentMap.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap
        Me.bbiDocumentMap.Enabled = False
        Me.bbiDocumentMap.Hint = "Document Map"
        Me.bbiDocumentMap.Id = 6
        Me.bbiDocumentMap.Name = "bbiDocumentMap"
        '
        'bbiParameters
        '
        Me.bbiParameters.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiParameters.Caption = "Parameters"
        Me.bbiParameters.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters
        Me.bbiParameters.Enabled = False
        Me.bbiParameters.Hint = "Parameters"
        Me.bbiParameters.Id = 7
        Me.bbiParameters.Name = "bbiParameters"
        '
        'bbiThumbnails
        '
        Me.bbiThumbnails.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiThumbnails.Caption = "Thumbnails"
        Me.bbiThumbnails.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails
        Me.bbiThumbnails.Enabled = False
        Me.bbiThumbnails.Hint = "Thumbnails"
        Me.bbiThumbnails.Id = 8
        Me.bbiThumbnails.Name = "bbiThumbnails"
        '
        'bbiFind
        '
        Me.bbiFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiFind.Caption = "Search"
        Me.bbiFind.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find
        Me.bbiFind.Enabled = False
        Me.bbiFind.Hint = "Search"
        Me.bbiFind.Id = 9
        Me.bbiFind.Name = "bbiFind"
        '
        'bbiHighlightEditingFields
        '
        Me.bbiHighlightEditingFields.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiHighlightEditingFields.Caption = "Editing Fields"
        Me.bbiHighlightEditingFields.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields
        Me.bbiHighlightEditingFields.Enabled = False
        Me.bbiHighlightEditingFields.Hint = "Highlight Editing Fields"
        Me.bbiHighlightEditingFields.Id = 10
        Me.bbiHighlightEditingFields.Name = "bbiHighlightEditingFields"
        '
        'bbiCustomize
        '
        Me.bbiCustomize.Caption = "Customize"
        Me.bbiCustomize.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize
        Me.bbiCustomize.Enabled = False
        Me.bbiCustomize.Hint = "Customize"
        Me.bbiCustomize.Id = 11
        Me.bbiCustomize.Name = "bbiCustomize"
        '
        'bbiOpen
        '
        Me.bbiOpen.Caption = "Open"
        Me.bbiOpen.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open
        Me.bbiOpen.Enabled = False
        Me.bbiOpen.Hint = "Open a document"
        Me.bbiOpen.Id = 12
        Me.bbiOpen.Name = "bbiOpen"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save
        Me.bbiSave.Enabled = False
        Me.bbiSave.Hint = "Save the document"
        Me.bbiSave.Id = 13
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiPrint
        '
        Me.bbiPrint.Caption = "&Print..."
        Me.bbiPrint.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print
        Me.bbiPrint.Enabled = False
        Me.bbiPrint.Hint = "Print"
        Me.bbiPrint.Id = 14
        Me.bbiPrint.Name = "bbiPrint"
        '
        'bbiPrintDirect
        '
        Me.bbiPrintDirect.Caption = "P&rint"
        Me.bbiPrintDirect.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect
        Me.bbiPrintDirect.Enabled = False
        Me.bbiPrintDirect.Hint = "Quick Print"
        Me.bbiPrintDirect.Id = 15
        Me.bbiPrintDirect.Name = "bbiPrintDirect"
        '
        'bbiPageSetup
        '
        Me.bbiPageSetup.Caption = "Page Set&up..."
        Me.bbiPageSetup.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup
        Me.bbiPageSetup.Enabled = False
        Me.bbiPageSetup.Hint = "Page Setup"
        Me.bbiPageSetup.Id = 16
        Me.bbiPageSetup.Name = "bbiPageSetup"
        '
        'bbiEditPageHF
        '
        Me.bbiEditPageHF.Caption = "Header And Footer"
        Me.bbiEditPageHF.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF
        Me.bbiEditPageHF.Enabled = False
        Me.bbiEditPageHF.Hint = "Header And Footer"
        Me.bbiEditPageHF.Id = 17
        Me.bbiEditPageHF.Name = "bbiEditPageHF"
        '
        'bbiScale
        '
        Me.bbiScale.ActAsDropDown = True
        Me.bbiScale.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiScale.Caption = "Scale"
        Me.bbiScale.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
        Me.bbiScale.Enabled = False
        Me.bbiScale.Hint = "Scale"
        Me.bbiScale.Id = 18
        Me.bbiScale.Name = "bbiScale"
        '
        'bbiHandTool
        '
        Me.bbiHandTool.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiHandTool.Caption = "Hand Tool"
        Me.bbiHandTool.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool
        Me.bbiHandTool.Enabled = False
        Me.bbiHandTool.Hint = "Hand Tool"
        Me.bbiHandTool.Id = 19
        Me.bbiHandTool.Name = "bbiHandTool"
        '
        'bbiMagnifier
        '
        Me.bbiMagnifier.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMagnifier.Caption = "Magnifier"
        Me.bbiMagnifier.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier
        Me.bbiMagnifier.Enabled = False
        Me.bbiMagnifier.Hint = "Magnifier"
        Me.bbiMagnifier.Id = 20
        Me.bbiMagnifier.Name = "bbiMagnifier"
        '
        'bbiZoomOut
        '
        Me.bbiZoomOut.Caption = "Zoom Out"
        Me.bbiZoomOut.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut
        Me.bbiZoomOut.Enabled = False
        Me.bbiZoomOut.Hint = "Zoom Out"
        Me.bbiZoomOut.Id = 21
        Me.bbiZoomOut.Name = "bbiZoomOut"
        '
        'bbiZoom
        '
        Me.bbiZoom.Caption = "Zoom"
        Me.bbiZoom.Edit = Me.PrintPreviewRepositoryItemComboBox1
        Me.bbiZoom.EditWidth = 70
        Me.bbiZoom.Enabled = False
        Me.bbiZoom.Hint = "Zoom"
        Me.bbiZoom.Id = 22
        Me.bbiZoom.Name = "bbiZoom"
        '
        'PrintPreviewRepositoryItemComboBox1
        '
        Me.PrintPreviewRepositoryItemComboBox1.AutoComplete = False
        Me.PrintPreviewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPreviewRepositoryItemComboBox1.DropDownRows = 11
        Me.PrintPreviewRepositoryItemComboBox1.Name = "PrintPreviewRepositoryItemComboBox1"
        '
        'bbiZoomIn
        '
        Me.bbiZoomIn.Caption = "Zoom In"
        Me.bbiZoomIn.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn
        Me.bbiZoomIn.Enabled = False
        Me.bbiZoomIn.Hint = "Zoom In"
        Me.bbiZoomIn.Id = 23
        Me.bbiZoomIn.Name = "bbiZoomIn"
        '
        'bbiShowFirstPage
        '
        Me.bbiShowFirstPage.Caption = "First Page"
        Me.bbiShowFirstPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage
        Me.bbiShowFirstPage.Enabled = False
        Me.bbiShowFirstPage.Hint = "First Page"
        Me.bbiShowFirstPage.Id = 24
        Me.bbiShowFirstPage.Name = "bbiShowFirstPage"
        '
        'bbiShowPrevPage
        '
        Me.bbiShowPrevPage.Caption = "Previous Page"
        Me.bbiShowPrevPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
        Me.bbiShowPrevPage.Enabled = False
        Me.bbiShowPrevPage.Hint = "Previous Page"
        Me.bbiShowPrevPage.Id = 25
        Me.bbiShowPrevPage.Name = "bbiShowPrevPage"
        '
        'bbiShowNextPage
        '
        Me.bbiShowNextPage.Caption = "Next Page"
        Me.bbiShowNextPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
        Me.bbiShowNextPage.Enabled = False
        Me.bbiShowNextPage.Hint = "Next Page"
        Me.bbiShowNextPage.Id = 26
        Me.bbiShowNextPage.Name = "bbiShowNextPage"
        '
        'bbiShowLastPage
        '
        Me.bbiShowLastPage.Caption = "Last Page"
        Me.bbiShowLastPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage
        Me.bbiShowLastPage.Enabled = False
        Me.bbiShowLastPage.Hint = "Last Page"
        Me.bbiShowLastPage.Id = 27
        Me.bbiShowLastPage.Name = "bbiShowLastPage"
        '
        'bbiMultiplePages
        '
        Me.bbiMultiplePages.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiMultiplePages.Caption = "Multiple Pages"
        Me.bbiMultiplePages.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
        Me.bbiMultiplePages.Enabled = False
        Me.bbiMultiplePages.Hint = "Multiple Pages"
        Me.bbiMultiplePages.Id = 28
        Me.bbiMultiplePages.Name = "bbiMultiplePages"
        '
        'bbiFillBackground
        '
        Me.bbiFillBackground.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiFillBackground.Caption = "&Color..."
        Me.bbiFillBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground
        Me.bbiFillBackground.Enabled = False
        Me.bbiFillBackground.Hint = "Background"
        Me.bbiFillBackground.Id = 29
        Me.bbiFillBackground.Name = "bbiFillBackground"
        '
        'bbiWatermark
        '
        Me.bbiWatermark.Caption = "&Watermark..."
        Me.bbiWatermark.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark
        Me.bbiWatermark.Enabled = False
        Me.bbiWatermark.Hint = "Watermark"
        Me.bbiWatermark.Id = 30
        Me.bbiWatermark.Name = "bbiWatermark"
        '
        'bbiExportFile
        '
        Me.bbiExportFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiExportFile.Caption = "Export Document..."
        Me.bbiExportFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile
        Me.bbiExportFile.Enabled = False
        Me.bbiExportFile.Hint = "Export Document..."
        Me.bbiExportFile.Id = 31
        Me.bbiExportFile.Name = "bbiExportFile"
        '
        'bbiSendFile
        '
        Me.bbiSendFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiSendFile.Caption = "Send via E-Mail..."
        Me.bbiSendFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile
        Me.bbiSendFile.Enabled = False
        Me.bbiSendFile.Hint = "Send via E-Mail..."
        Me.bbiSendFile.Id = 32
        Me.bbiSendFile.Name = "bbiSendFile"
        '
        'bbiClosePreview
        '
        Me.bbiClosePreview.Caption = "E&xit"
        Me.bbiClosePreview.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview
        Me.bbiClosePreview.Enabled = False
        Me.bbiClosePreview.Hint = "Close Preview"
        Me.bbiClosePreview.Id = 33
        Me.bbiClosePreview.Name = "bbiClosePreview"
        '
        'miFile
        '
        Me.miFile.Caption = "&File"
        Me.miFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File
        Me.miFile.Id = 34
        Me.miFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPageSetup), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrintDirect), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSendFile), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiClosePreview, True)})
        Me.miFile.Name = "miFile"
        '
        'miView
        '
        Me.miView.Caption = "&View"
        Me.miView.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View
        Me.miView.Id = 35
        Me.miView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayout, True), New DevExpress.XtraBars.LinkPersistInfo(Me.miToolbars, True)})
        Me.miView.Name = "miView"
        '
        'miPageLayout
        '
        Me.miPageLayout.Caption = "&Page Layout"
        Me.miPageLayout.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout
        Me.miPageLayout.Id = 37
        Me.miPageLayout.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayoutFacing), New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayoutContinuous)})
        Me.miPageLayout.Name = "miPageLayout"
        '
        'miPageLayoutFacing
        '
        Me.miPageLayoutFacing.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.miPageLayoutFacing.Caption = "&Facing"
        Me.miPageLayoutFacing.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing
        Me.miPageLayoutFacing.Enabled = False
        Me.miPageLayoutFacing.GroupIndex = 100
        Me.miPageLayoutFacing.Id = 38
        Me.miPageLayoutFacing.Name = "miPageLayoutFacing"
        '
        'miPageLayoutContinuous
        '
        Me.miPageLayoutContinuous.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.miPageLayoutContinuous.Caption = "&Continuous"
        Me.miPageLayoutContinuous.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous
        Me.miPageLayoutContinuous.Enabled = False
        Me.miPageLayoutContinuous.GroupIndex = 100
        Me.miPageLayoutContinuous.Id = 39
        Me.miPageLayoutContinuous.Name = "miPageLayoutContinuous"
        '
        'miToolbars
        '
        Me.miToolbars.Caption = "Bars"
        Me.miToolbars.Id = 40
        Me.miToolbars.Name = "miToolbars"
        '
        'miBackground
        '
        Me.miBackground.Caption = "&Background"
        Me.miBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background
        Me.miBackground.Id = 36
        Me.miBackground.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFillBackground), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiWatermark)})
        Me.miBackground.Name = "miBackground"
        '
        'PrintPreviewBarCheckItem1
        '
        Me.PrintPreviewBarCheckItem1.BindableChecked = True
        Me.PrintPreviewBarCheckItem1.Caption = "PDF File"
        Me.PrintPreviewBarCheckItem1.Checked = True
        Me.PrintPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf
        Me.PrintPreviewBarCheckItem1.Enabled = False
        Me.PrintPreviewBarCheckItem1.GroupIndex = 2
        Me.PrintPreviewBarCheckItem1.Hint = "PDF File"
        Me.PrintPreviewBarCheckItem1.Id = 41
        Me.PrintPreviewBarCheckItem1.Name = "PrintPreviewBarCheckItem1"
        '
        'PrintPreviewBarCheckItem2
        '
        Me.PrintPreviewBarCheckItem2.Caption = "HTML File"
        Me.PrintPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm
        Me.PrintPreviewBarCheckItem2.Enabled = False
        Me.PrintPreviewBarCheckItem2.GroupIndex = 2
        Me.PrintPreviewBarCheckItem2.Hint = "HTML File"
        Me.PrintPreviewBarCheckItem2.Id = 42
        Me.PrintPreviewBarCheckItem2.Name = "PrintPreviewBarCheckItem2"
        '
        'PrintPreviewBarCheckItem3
        '
        Me.PrintPreviewBarCheckItem3.Caption = "MHT File"
        Me.PrintPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht
        Me.PrintPreviewBarCheckItem3.Enabled = False
        Me.PrintPreviewBarCheckItem3.GroupIndex = 2
        Me.PrintPreviewBarCheckItem3.Hint = "MHT File"
        Me.PrintPreviewBarCheckItem3.Id = 43
        Me.PrintPreviewBarCheckItem3.Name = "PrintPreviewBarCheckItem3"
        '
        'PrintPreviewBarCheckItem4
        '
        Me.PrintPreviewBarCheckItem4.Caption = "RTF File"
        Me.PrintPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf
        Me.PrintPreviewBarCheckItem4.Enabled = False
        Me.PrintPreviewBarCheckItem4.GroupIndex = 2
        Me.PrintPreviewBarCheckItem4.Hint = "RTF File"
        Me.PrintPreviewBarCheckItem4.Id = 44
        Me.PrintPreviewBarCheckItem4.Name = "PrintPreviewBarCheckItem4"
        '
        'PrintPreviewBarCheckItem5
        '
        Me.PrintPreviewBarCheckItem5.Caption = "DOCX File"
        Me.PrintPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportDocx
        Me.PrintPreviewBarCheckItem5.Enabled = False
        Me.PrintPreviewBarCheckItem5.GroupIndex = 2
        Me.PrintPreviewBarCheckItem5.Hint = "DOCX File"
        Me.PrintPreviewBarCheckItem5.Id = 45
        Me.PrintPreviewBarCheckItem5.Name = "PrintPreviewBarCheckItem5"
        '
        'PrintPreviewBarCheckItem6
        '
        Me.PrintPreviewBarCheckItem6.Caption = "XLS File"
        Me.PrintPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls
        Me.PrintPreviewBarCheckItem6.Enabled = False
        Me.PrintPreviewBarCheckItem6.GroupIndex = 2
        Me.PrintPreviewBarCheckItem6.Hint = "XLS File"
        Me.PrintPreviewBarCheckItem6.Id = 46
        Me.PrintPreviewBarCheckItem6.Name = "PrintPreviewBarCheckItem6"
        '
        'PrintPreviewBarCheckItem7
        '
        Me.PrintPreviewBarCheckItem7.Caption = "XLSX File"
        Me.PrintPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx
        Me.PrintPreviewBarCheckItem7.Enabled = False
        Me.PrintPreviewBarCheckItem7.GroupIndex = 2
        Me.PrintPreviewBarCheckItem7.Hint = "XLSX File"
        Me.PrintPreviewBarCheckItem7.Id = 47
        Me.PrintPreviewBarCheckItem7.Name = "PrintPreviewBarCheckItem7"
        '
        'PrintPreviewBarCheckItem8
        '
        Me.PrintPreviewBarCheckItem8.Caption = "CSV File"
        Me.PrintPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv
        Me.PrintPreviewBarCheckItem8.Enabled = False
        Me.PrintPreviewBarCheckItem8.GroupIndex = 2
        Me.PrintPreviewBarCheckItem8.Hint = "CSV File"
        Me.PrintPreviewBarCheckItem8.Id = 48
        Me.PrintPreviewBarCheckItem8.Name = "PrintPreviewBarCheckItem8"
        '
        'PrintPreviewBarCheckItem9
        '
        Me.PrintPreviewBarCheckItem9.Caption = "Text File"
        Me.PrintPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt
        Me.PrintPreviewBarCheckItem9.Enabled = False
        Me.PrintPreviewBarCheckItem9.GroupIndex = 2
        Me.PrintPreviewBarCheckItem9.Hint = "Text File"
        Me.PrintPreviewBarCheckItem9.Id = 49
        Me.PrintPreviewBarCheckItem9.Name = "PrintPreviewBarCheckItem9"
        '
        'PrintPreviewBarCheckItem10
        '
        Me.PrintPreviewBarCheckItem10.Caption = "Image File"
        Me.PrintPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic
        Me.PrintPreviewBarCheckItem10.Enabled = False
        Me.PrintPreviewBarCheckItem10.GroupIndex = 2
        Me.PrintPreviewBarCheckItem10.Hint = "Image File"
        Me.PrintPreviewBarCheckItem10.Id = 50
        Me.PrintPreviewBarCheckItem10.Name = "PrintPreviewBarCheckItem10"
        '
        'PrintPreviewBarCheckItem11
        '
        Me.PrintPreviewBarCheckItem11.BindableChecked = True
        Me.PrintPreviewBarCheckItem11.Caption = "PDF File"
        Me.PrintPreviewBarCheckItem11.Checked = True
        Me.PrintPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf
        Me.PrintPreviewBarCheckItem11.Enabled = False
        Me.PrintPreviewBarCheckItem11.GroupIndex = 1
        Me.PrintPreviewBarCheckItem11.Hint = "PDF File"
        Me.PrintPreviewBarCheckItem11.Id = 51
        Me.PrintPreviewBarCheckItem11.Name = "PrintPreviewBarCheckItem11"
        '
        'PrintPreviewBarCheckItem12
        '
        Me.PrintPreviewBarCheckItem12.Caption = "MHT File"
        Me.PrintPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht
        Me.PrintPreviewBarCheckItem12.Enabled = False
        Me.PrintPreviewBarCheckItem12.GroupIndex = 1
        Me.PrintPreviewBarCheckItem12.Hint = "MHT File"
        Me.PrintPreviewBarCheckItem12.Id = 52
        Me.PrintPreviewBarCheckItem12.Name = "PrintPreviewBarCheckItem12"
        '
        'PrintPreviewBarCheckItem13
        '
        Me.PrintPreviewBarCheckItem13.Caption = "RTF File"
        Me.PrintPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf
        Me.PrintPreviewBarCheckItem13.Enabled = False
        Me.PrintPreviewBarCheckItem13.GroupIndex = 1
        Me.PrintPreviewBarCheckItem13.Hint = "RTF File"
        Me.PrintPreviewBarCheckItem13.Id = 53
        Me.PrintPreviewBarCheckItem13.Name = "PrintPreviewBarCheckItem13"
        '
        'PrintPreviewBarCheckItem14
        '
        Me.PrintPreviewBarCheckItem14.Caption = "DOCX File"
        Me.PrintPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendDocx
        Me.PrintPreviewBarCheckItem14.Enabled = False
        Me.PrintPreviewBarCheckItem14.GroupIndex = 1
        Me.PrintPreviewBarCheckItem14.Hint = "DOCX File"
        Me.PrintPreviewBarCheckItem14.Id = 54
        Me.PrintPreviewBarCheckItem14.Name = "PrintPreviewBarCheckItem14"
        '
        'PrintPreviewBarCheckItem15
        '
        Me.PrintPreviewBarCheckItem15.Caption = "XLS File"
        Me.PrintPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls
        Me.PrintPreviewBarCheckItem15.Enabled = False
        Me.PrintPreviewBarCheckItem15.GroupIndex = 1
        Me.PrintPreviewBarCheckItem15.Hint = "XLS File"
        Me.PrintPreviewBarCheckItem15.Id = 55
        Me.PrintPreviewBarCheckItem15.Name = "PrintPreviewBarCheckItem15"
        '
        'PrintPreviewBarCheckItem16
        '
        Me.PrintPreviewBarCheckItem16.Caption = "XLSX File"
        Me.PrintPreviewBarCheckItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx
        Me.PrintPreviewBarCheckItem16.Enabled = False
        Me.PrintPreviewBarCheckItem16.GroupIndex = 1
        Me.PrintPreviewBarCheckItem16.Hint = "XLSX File"
        Me.PrintPreviewBarCheckItem16.Id = 56
        Me.PrintPreviewBarCheckItem16.Name = "PrintPreviewBarCheckItem16"
        '
        'PrintPreviewBarCheckItem17
        '
        Me.PrintPreviewBarCheckItem17.Caption = "CSV File"
        Me.PrintPreviewBarCheckItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv
        Me.PrintPreviewBarCheckItem17.Enabled = False
        Me.PrintPreviewBarCheckItem17.GroupIndex = 1
        Me.PrintPreviewBarCheckItem17.Hint = "CSV File"
        Me.PrintPreviewBarCheckItem17.Id = 57
        Me.PrintPreviewBarCheckItem17.Name = "PrintPreviewBarCheckItem17"
        '
        'PrintPreviewBarCheckItem18
        '
        Me.PrintPreviewBarCheckItem18.Caption = "Text File"
        Me.PrintPreviewBarCheckItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt
        Me.PrintPreviewBarCheckItem18.Enabled = False
        Me.PrintPreviewBarCheckItem18.GroupIndex = 1
        Me.PrintPreviewBarCheckItem18.Hint = "Text File"
        Me.PrintPreviewBarCheckItem18.Id = 58
        Me.PrintPreviewBarCheckItem18.Name = "PrintPreviewBarCheckItem18"
        '
        'PrintPreviewBarCheckItem19
        '
        Me.PrintPreviewBarCheckItem19.Caption = "Image File"
        Me.PrintPreviewBarCheckItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic
        Me.PrintPreviewBarCheckItem19.Enabled = False
        Me.PrintPreviewBarCheckItem19.GroupIndex = 1
        Me.PrintPreviewBarCheckItem19.Hint = "Image File"
        Me.PrintPreviewBarCheckItem19.Id = 59
        Me.PrintPreviewBarCheckItem19.Name = "PrintPreviewBarCheckItem19"
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(175, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.ShowCloseButton = False
        Me.crViewer.ShowGroupTreeButton = False
        Me.crViewer.ShowLogo = False
        Me.crViewer.ShowParameterPanelButton = False
        Me.crViewer.Size = New System.Drawing.Size(815, 532)
        Me.crViewer.TabIndex = 29
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.EditValue = "00:00"
        Me.barra.Location = New System.Drawing.Point(175, 532)
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
        Me.barra.Size = New System.Drawing.Size(815, 18)
        Me.barra.TabIndex = 30
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
        'frmOE_Ficha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 550)
        Me.Controls.Add(Me.crViewer)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmOE_Ficha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orientador Educacional "
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tAnoVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentViewerBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bwOE As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAbandonoPorTurno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btReprovadosPorTurno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEvolucaoTaxas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btDesempenho As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btIndicadores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btStatusAlunos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tAnoVigente As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DocumentViewerBarManager1 As DevExpress.XtraPrinting.Preview.DocumentViewerBarManager
    Friend WithEvents bbiDocumentMap As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiParameters As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiThumbnails As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiFind As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiHighlightEditingFields As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiCustomize As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiOpen As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiSave As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPrint As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPrintDirect As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPageSetup As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiEditPageHF As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiScale As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiHandTool As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiMagnifier As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiZoomOut As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiZoom As DevExpress.XtraPrinting.Preview.ZoomBarEditItem
    Friend WithEvents PrintPreviewRepositoryItemComboBox1 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
    Friend WithEvents bbiZoomIn As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowFirstPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowPrevPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowNextPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowLastPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiMultiplePages As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiFillBackground As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiWatermark As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiExportFile As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiSendFile As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiClosePreview As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents PrintPreviewStaticItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
    Friend WithEvents verticalSpaceItem As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ProgressBarEditItem1 As DevExpress.XtraPrinting.Preview.ProgressBarEditItem
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents PrintPreviewBarItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents PrintPreviewStaticItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
    Friend WithEvents ZoomTrackBarEditItem1 As DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem
    Friend WithEvents RepositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents miFile As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents miView As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents miPageLayout As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents miPageLayoutFacing As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents miPageLayoutContinuous As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents miToolbars As DevExpress.XtraBars.BarToolbarsListItem
    Friend WithEvents miBackground As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents PrintPreviewBarCheckItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem5 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem6 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem7 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem8 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem9 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem10 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem11 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem12 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem13 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem14 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem15 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem16 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem17 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem18 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem19 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents barra As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents tempoBarra As Timer
    Friend WithEvents frmTempo As Timer
End Class
