<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt_Auxiliar
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
    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpt_Auxiliar))
        Me.frmTempo = New System.Windows.Forms.Timer(Me.components)
        Me.barra = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.bwRelatorio = New System.ComponentModel.BackgroundWorker()
        Me.tempoBarra = New System.Windows.Forms.Timer(Me.components)
        Me.bwBarra = New System.ComponentModel.BackgroundWorker()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.barra.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'frmTempo
        '
        Me.frmTempo.Interval = 300
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.EditValue = "00:00"
        Me.barra.Location = New System.Drawing.Point(0, 543)
        Me.barra.Name = "barra"
        Me.barra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.barra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.barra.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.barra.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.barra.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.barra.Properties.DisplayFormat.FormatString = "d"
        Me.barra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.EditFormat.FormatString = "d"
        Me.barra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.Paused = true
        Me.barra.Properties.ShowTitle = true
        Me.barra.Size = New System.Drawing.Size(684, 18)
        Me.barra.TabIndex = 5
        '
        'bwRelatorio
        '
        Me.bwRelatorio.WorkerReportsProgress = true
        Me.bwRelatorio.WorkerSupportsCancellation = true
        '
        'tempoBarra
        '
        Me.tempoBarra.Enabled = true
        Me.tempoBarra.Interval = 50
        '
        'bwBarra
        '
        Me.bwBarra.WorkerReportsProgress = true
        Me.bwBarra.WorkerSupportsCancellation = true
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.Size = New System.Drawing.Size(684, 543)
        Me.crViewer.TabIndex = 6
        '
        'frmRpt_Auxiliar
        '
        Me.Appearance.Options.UseFont = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.crViewer)
        Me.Controls.Add(Me.barra)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRpt_Auxiliar"
        Me.ShowMdiChildCaptionInParentTitle = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Escola! - Relatório"
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents frmTempo As System.Windows.Forms.Timer
    ' Public WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents barra As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents bwRelatorio As System.ComponentModel.BackgroundWorker
    Friend WithEvents tempoBarra As System.Windows.Forms.Timer
    Friend WithEvents bwBarra As System.ComponentModel.BackgroundWorker
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
