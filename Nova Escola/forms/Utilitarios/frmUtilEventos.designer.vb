<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilEventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilEventos))
        Me.gridEventos = New DevExpress.XtraGrid.GridControl()
        Me.viewEventos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbData = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbUsuario = New DevExpress.XtraEditors.LookUpEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbData.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridEventos
        '
        Me.gridEventos.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridEventos.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridEventos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridEventos.Location = New System.Drawing.Point(0, 0)
        Me.gridEventos.MainView = Me.viewEventos
        Me.gridEventos.Name = "gridEventos"
        Me.gridEventos.Size = New System.Drawing.Size(710, 369)
        Me.gridEventos.TabIndex = 0
        Me.gridEventos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewEventos})
        '
        'viewEventos
        '
        Me.viewEventos.GridControl = Me.gridEventos
        Me.viewEventos.Name = "viewEventos"
        Me.viewEventos.OptionsBehavior.Editable = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(309, 378)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Data:"
        '
        'cbData
        '
        Me.cbData.EditValue = Nothing
        Me.cbData.Location = New System.Drawing.Point(346, 377)
        Me.cbData.Name = "cbData"
        Me.cbData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbData.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cbData.Size = New System.Drawing.Size(126, 20)
        Me.cbData.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(487, 378)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Usuário:"
        '
        'cbUsuario
        '
        Me.cbUsuario.EditValue = ""
        Me.cbUsuario.Location = New System.Drawing.Point(541, 377)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbUsuario.Properties.NullText = ""
        Me.cbUsuario.Size = New System.Drawing.Size(126, 20)
        Me.cbUsuario.TabIndex = 3
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(677, 375)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(24, 24)
        Me.PictureEdit1.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 376)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Imprimir!"
        '
        'frmGerencialLogs
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(710, 404)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbData)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.gridEventos)
        Me.Controls.Add(Me.cbUsuario)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGerencialLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Escola! - Visualizador de Eventos"
        CType(Me.gridEventos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewEventos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbData.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbData.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbUsuario.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents gridEventos As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewEventos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
