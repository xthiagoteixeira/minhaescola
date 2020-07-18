<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFerramentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFerramentas))
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.cbEscola = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSenhaWeb = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuarioWeb = New DevExpress.XtraEditors.TextEdit()
        Me.btEfetuar = New DevExpress.XtraEditors.SimpleButton()
        Me.imagemFundo = New DevExpress.XtraEditors.Controls.ImageSlider()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbFundo = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.cbEscola.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSenhaWeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuarioWeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagemFundo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'cbEscola
        '
        Me.cbEscola.Location = New System.Drawing.Point(369, 445)
        Me.cbEscola.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEscola.Name = "cbEscola"
        Me.cbEscola.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEscola.Properties.Appearance.Options.UseFont = True
        Me.cbEscola.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEscola.Properties.Items.AddRange(New Object() {"Estadual", "Municipal", "Particular"})
        Me.cbEscola.Size = New System.Drawing.Size(152, 26)
        Me.cbEscola.TabIndex = 18
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(310, 449)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 19)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "Escola:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(68, 449)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 19)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Usuário:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(76, 480)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "Senha:"
        '
        'txtSenhaWeb
        '
        Me.txtSenhaWeb.Location = New System.Drawing.Point(135, 478)
        Me.txtSenhaWeb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSenhaWeb.Name = "txtSenhaWeb"
        Me.txtSenhaWeb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhaWeb.Properties.Appearance.Options.UseFont = True
        Me.txtSenhaWeb.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSenhaWeb.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSenhaWeb.Size = New System.Drawing.Size(152, 26)
        Me.txtSenhaWeb.TabIndex = 25
        '
        'txtUsuarioWeb
        '
        Me.txtUsuarioWeb.Location = New System.Drawing.Point(135, 445)
        Me.txtUsuarioWeb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsuarioWeb.Name = "txtUsuarioWeb"
        Me.txtUsuarioWeb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioWeb.Properties.Appearance.Options.UseFont = True
        Me.txtUsuarioWeb.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsuarioWeb.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtUsuarioWeb.Size = New System.Drawing.Size(152, 26)
        Me.txtUsuarioWeb.TabIndex = 24
        '
        'btEfetuar
        '
        Me.btEfetuar.Location = New System.Drawing.Point(428, 478)
        Me.btEfetuar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btEfetuar.Name = "btEfetuar"
        Me.btEfetuar.Size = New System.Drawing.Size(94, 29)
        Me.btEfetuar.TabIndex = 26
        Me.btEfetuar.Text = "Salvar!"
        '
        'imagemFundo
        '
        Me.imagemFundo.AnimationTime = 1200
        Me.imagemFundo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imagemFundo.Appearance.Options.UseFont = True
        Me.imagemFundo.CurrentImageIndex = 0
        Me.imagemFundo.Cursor = System.Windows.Forms.Cursors.Default
        Me.imagemFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images1"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images2"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images3"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images4"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images5"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images6"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images7"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images8"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images9"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images10"), System.Drawing.Image))
        Me.imagemFundo.Images.Add(CType(resources.GetObject("imagemFundo.Images11"), System.Drawing.Image))
        Me.imagemFundo.Location = New System.Drawing.Point(2, 26)
        Me.imagemFundo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imagemFundo.Name = "imagemFundo"
        Me.imagemFundo.Size = New System.Drawing.Size(575, 372)
        Me.imagemFundo.TabIndex = 27
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.imagemFundo)
        Me.GroupControl1.Controls.Add(Me.cbFundo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(579, 426)
        Me.GroupControl1.TabIndex = 28
        Me.GroupControl1.Text = "Plano de Fundo"
        '
        'cbFundo
        '
        Me.cbFundo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbFundo.EditValue = "Fundo 1"
        Me.cbFundo.Location = New System.Drawing.Point(2, 398)
        Me.cbFundo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbFundo.Name = "cbFundo"
        Me.cbFundo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFundo.Properties.Appearance.Options.UseFont = True
        Me.cbFundo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFundo.Properties.Items.AddRange(New Object() {"Fundo 1", "Fundo 2", "Fundo 3", "Fundo 4", "Fundo 5", "Fundo 6", "Fundo 7", "Fundo 8", "Fundo 9", "Fundo 10", "Fundo 11", "Fundo 12", "Personalizar..."})
        Me.cbFundo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbFundo.Size = New System.Drawing.Size(575, 26)
        Me.cbFundo.TabIndex = 29
        '
        'frmFerramentas
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(579, 524)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtSenhaWeb)
        Me.Controls.Add(Me.txtUsuarioWeb)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cbEscola)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btEfetuar)
        Me.Controls.Add(Me.LabelControl4)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFerramentas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ferramentas!"
        CType(Me.cbEscola.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSenhaWeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuarioWeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagemFundo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.cbFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cbEscola As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btEfetuar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSenhaWeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuarioWeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents imagemFundo As DevExpress.XtraEditors.Controls.ImageSlider
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbFundo As DevExpress.XtraEditors.ComboBoxEdit
End Class
