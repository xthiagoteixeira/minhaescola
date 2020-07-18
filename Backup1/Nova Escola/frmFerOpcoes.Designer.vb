<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFerOpcoes
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFerOpcoes))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.cbManualGDAE = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.cbNaoCript = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.tbFundo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.pbProcurar = New System.Windows.Forms.PictureBox
        Me.openFD = New System.Windows.Forms.OpenFileDialog
        Me.tbGdae = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.cbNotaTransf = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.tbNota = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.gpWeb = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtSenhaWeb = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtUsuarioWeb = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        CType(Me.pbProcurar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpWeb.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(383, 106)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Aplicar!"
        '
        'cbManualGDAE
        '
        Me.cbManualGDAE.AutoSize = True
        Me.cbManualGDAE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbManualGDAE.Location = New System.Drawing.Point(12, 14)
        Me.cbManualGDAE.Name = "cbManualGDAE"
        Me.cbManualGDAE.Size = New System.Drawing.Size(219, 16)
        Me.cbManualGDAE.TabIndex = 2
        Me.cbManualGDAE.Text = "Escolher os alunos na transferência"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(383, 135)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.TabIndex = 3
        Me.ButtonX2.Text = "Fechar"
        '
        'cbNaoCript
        '
        Me.cbNaoCript.AutoSize = True
        Me.cbNaoCript.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNaoCript.Location = New System.Drawing.Point(12, 44)
        Me.cbNaoCript.Name = "cbNaoCript"
        Me.cbNaoCript.Size = New System.Drawing.Size(202, 16)
        Me.cbNaoCript.TabIndex = 4
        Me.cbNaoCript.Text = "Importar boletins criptografados"
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(249, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(85, 23)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Fundo de Tela:"
        '
        'tbFundo
        '
        '
        '
        '
        Me.tbFundo.Border.Class = "TextBoxBorder"
        Me.tbFundo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbFundo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFundo.Location = New System.Drawing.Point(336, 11)
        Me.tbFundo.Name = "tbFundo"
        Me.tbFundo.Size = New System.Drawing.Size(94, 21)
        Me.tbFundo.TabIndex = 6
        Me.tbFundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pbProcurar
        '
        Me.pbProcurar.Image = Global.Mais_Escola.My.Resources.Resources.lupa_melhor
        Me.pbProcurar.Location = New System.Drawing.Point(439, 13)
        Me.pbProcurar.Name = "pbProcurar"
        Me.pbProcurar.Size = New System.Drawing.Size(19, 16)
        Me.pbProcurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbProcurar.TabIndex = 10
        Me.pbProcurar.TabStop = False
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'tbGdae
        '
        '
        '
        '
        Me.tbGdae.Border.Class = "TextBoxBorder"
        Me.tbGdae.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbGdae.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGdae.Location = New System.Drawing.Point(337, 40)
        Me.tbGdae.Name = "tbGdae"
        Me.tbGdae.Size = New System.Drawing.Size(93, 21)
        Me.tbGdae.TabIndex = 9
        Me.tbGdae.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(257, 39)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "IP GDAE:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cbNotaTransf
        '
        Me.cbNotaTransf.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNotaTransf.Location = New System.Drawing.Point(12, 68)
        Me.cbNotaTransf.Name = "cbNotaTransf"
        Me.cbNotaTransf.Size = New System.Drawing.Size(119, 23)
        Me.cbNotaTransf.TabIndex = 11
        Me.cbNotaTransf.Text = "Considerar Nota:"
        '
        'tbNota
        '
        '
        '
        '
        Me.tbNota.Border.Class = "TextBoxBorder"
        Me.tbNota.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbNota.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNota.Location = New System.Drawing.Point(132, 70)
        Me.tbNota.Name = "tbNota"
        Me.tbNota.Size = New System.Drawing.Size(29, 21)
        Me.tbNota.TabIndex = 12
        Me.tbNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(167, 69)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(238, 23)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "ao transferir alunos com Evasão Escolar."
        '
        'gpWeb
        '
        Me.gpWeb.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpWeb.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpWeb.Controls.Add(Me.txtSenhaWeb)
        Me.gpWeb.Controls.Add(Me.txtUsuarioWeb)
        Me.gpWeb.Controls.Add(Me.LabelX5)
        Me.gpWeb.Controls.Add(Me.LabelX4)
        Me.gpWeb.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpWeb.Location = New System.Drawing.Point(12, 97)
        Me.gpWeb.Name = "gpWeb"
        Me.gpWeb.Size = New System.Drawing.Size(352, 61)
        '
        '
        '
        Me.gpWeb.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpWeb.Style.BackColorGradientAngle = 90
        Me.gpWeb.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpWeb.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpWeb.Style.BorderBottomWidth = 1
        Me.gpWeb.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpWeb.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpWeb.Style.BorderLeftWidth = 1
        Me.gpWeb.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpWeb.Style.BorderRightWidth = 1
        Me.gpWeb.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpWeb.Style.BorderTopWidth = 1
        Me.gpWeb.Style.CornerDiameter = 4
        Me.gpWeb.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpWeb.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpWeb.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpWeb.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpWeb.TabIndex = 14
        Me.gpWeb.Text = "Configurações Boletim Web"
        '
        'txtSenhaWeb
        '
        '
        '
        '
        Me.txtSenhaWeb.Border.Class = "TextBoxBorder"
        Me.txtSenhaWeb.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSenhaWeb.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhaWeb.Location = New System.Drawing.Point(229, 11)
        Me.txtSenhaWeb.Name = "txtSenhaWeb"
        Me.txtSenhaWeb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaWeb.Size = New System.Drawing.Size(94, 21)
        Me.txtSenhaWeb.TabIndex = 16
        Me.txtSenhaWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUsuarioWeb
        '
        '
        '
        '
        Me.txtUsuarioWeb.Border.Class = "TextBoxBorder"
        Me.txtUsuarioWeb.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtUsuarioWeb.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioWeb.Location = New System.Drawing.Point(57, 9)
        Me.txtUsuarioWeb.Name = "txtUsuarioWeb"
        Me.txtUsuarioWeb.Size = New System.Drawing.Size(94, 21)
        Me.txtUsuarioWeb.TabIndex = 8
        Me.txtUsuarioWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(185, 9)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX5.Size = New System.Drawing.Size(58, 23)
        Me.LabelX5.TabIndex = 15
        Me.LabelX5.Text = "Senha:"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(6, 8)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX4.Size = New System.Drawing.Size(58, 23)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Usuário:"
        '
        'frmFerOpcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 170)
        Me.Controls.Add(Me.gpWeb)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.tbNota)
        Me.Controls.Add(Me.cbNotaTransf)
        Me.Controls.Add(Me.tbGdae)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.pbProcurar)
        Me.Controls.Add(Me.tbFundo)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cbNaoCript)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.cbManualGDAE)
        Me.Controls.Add(Me.ButtonX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFerOpcoes"
        Me.ShowInTaskbar = False
        Me.Text = "Mais Escola - Ferramentas"
        CType(Me.pbProcurar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpWeb.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbManualGDAE As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbNaoCript As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFundo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents pbProcurar As System.Windows.Forms.PictureBox
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbGdae As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbNotaTransf As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tbNota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpWeb As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtSenhaWeb As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsuarioWeb As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
End Class
