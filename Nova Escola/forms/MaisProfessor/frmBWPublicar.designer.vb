<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBWPublicar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBWPublicar))
        Me.prTransfere = New System.ComponentModel.BackgroundWorker()
        Me.lbTurma_Data = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.finalCalendario = New DevExpress.XtraEditors.DateEdit()
        Me.inicioCalendario = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btPublicar = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.finalCalendario.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finalCalendario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inicioCalendario.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inicioCalendario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prTransfere
        '
        '
        'lbTurma_Data
        '
        Me.lbTurma_Data.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTurma_Data.Appearance.Options.UseFont = True
        Me.lbTurma_Data.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbTurma_Data.Location = New System.Drawing.Point(292, 86)
        Me.lbTurma_Data.Name = "lbTurma_Data"
        Me.lbTurma_Data.Size = New System.Drawing.Size(69, 16)
        Me.lbTurma_Data.TabIndex = 1
        Me.lbTurma_Data.Text = "00/00/0000"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(170, 86)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(116, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Última publicação:"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.finalCalendario)
        Me.GroupControl2.Controls.Add(Me.inicioCalendario)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(349, 58)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Período de Digitação"
        '
        'finalCalendario
        '
        Me.finalCalendario.EditValue = Nothing
        Me.finalCalendario.Location = New System.Drawing.Point(229, 29)
        Me.finalCalendario.Name = "finalCalendario"
        Me.finalCalendario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.finalCalendario.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.finalCalendario.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "d"
        Me.finalCalendario.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.finalCalendario.Properties.CalendarTimeProperties.EditFormat.FormatString = "d"
        Me.finalCalendario.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.finalCalendario.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.finalCalendario.Size = New System.Drawing.Size(100, 20)
        Me.finalCalendario.TabIndex = 5
        '
        'inicioCalendario
        '
        Me.inicioCalendario.EditValue = Nothing
        Me.inicioCalendario.Location = New System.Drawing.Point(49, 29)
        Me.inicioCalendario.Name = "inicioCalendario"
        Me.inicioCalendario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.inicioCalendario.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.inicioCalendario.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "d"
        Me.inicioCalendario.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.inicioCalendario.Properties.CalendarTimeProperties.EditFormat.FormatString = "d"
        Me.inicioCalendario.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.inicioCalendario.Size = New System.Drawing.Size(100, 20)
        Me.inicioCalendario.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(170, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Término:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(10, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Início:"
        '
        'btPublicar
        '
        Me.btPublicar.Location = New System.Drawing.Point(272, 111)
        Me.btPublicar.Name = "btPublicar"
        Me.btPublicar.Size = New System.Drawing.Size(89, 23)
        Me.btPublicar.TabIndex = 0
        Me.btPublicar.Text = "Publicar!"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(133, 176)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 20)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmBWPublicar
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(370, 137)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lbTurma_Data)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btPublicar)
        Me.Controls.Add(Me.GroupControl2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBWPublicar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Professor! - Publicar"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.finalCalendario.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finalCalendario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inicioCalendario.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inicioCalendario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prTransfere As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbTurma_Data As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btPublicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents inicioCalendario As DevExpress.XtraEditors.DateEdit
    Friend WithEvents finalCalendario As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckBox1 As CheckBox
End Class
