<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistro
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNome = New DevExpress.XtraEditors.TextEdit()
        Me.txtResponsavel = New DevExpress.XtraEditors.TextEdit()
        Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.txtCNPJ = New DevExpress.XtraEditors.TextEdit()
        Me.btConfirmar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponsavel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCNPJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(103, 489)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nome:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(108, 512)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "CNPJ:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(63, 535)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Responsável:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(143, 486)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(261, 20)
        Me.txtNome.TabIndex = 1
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(143, 532)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(261, 20)
        Me.txtResponsavel.TabIndex = 3
        '
        'pdfViewer
        '
        Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
        Me.pdfViewer.Name = "pdfViewer"
        Me.pdfViewer.Size = New System.Drawing.Size(574, 468)
        Me.pdfViewer.TabIndex = 7
        Me.pdfViewer.ZoomFactor = 50.0!
        Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.Custom
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Location = New System.Drawing.Point(144, 508)
        Me.txtCNPJ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNPJ.Properties.Appearance.Options.UseFont = True
        Me.txtCNPJ.Properties.Mask.EditMask = "00.000.000/0000-00"
        Me.txtCNPJ.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCNPJ.Size = New System.Drawing.Size(260, 22)
        Me.txtCNPJ.TabIndex = 2
        '
        'btConfirmar
        '
        Me.btConfirmar.ImageOptions.Image = CType(resources.GetObject("btConfirmar.ImageOptions.Image"), System.Drawing.Image)
        Me.btConfirmar.Location = New System.Drawing.Point(425, 530)
        Me.btConfirmar.Name = "btConfirmar"
        Me.btConfirmar.Size = New System.Drawing.Size(95, 23)
        Me.btConfirmar.TabIndex = 4
        Me.btConfirmar.Text = "Aceito!"
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 569)
        Me.Controls.Add(Me.txtCNPJ)
        Me.Controls.Add(Me.pdfViewer)
        Me.Controls.Add(Me.txtResponsavel)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btConfirmar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar Dados"
        Me.TopMost = True
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponsavel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCNPJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btConfirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtResponsavel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pdfViewer As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents txtCNPJ As DevExpress.XtraEditors.TextEdit
End Class
