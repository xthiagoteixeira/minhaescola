<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoletimWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoletimWeb))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.openFD = New System.Windows.Forms.OpenFileDialog
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtUsuarioEscola = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtUsuarioProfessor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.txtSenha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cbUsuarioProfessor = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.rbIncluir = New System.Windows.Forms.RadioButton
        Me.rbAlterar = New System.Windows.Forms.RadioButton
        Me.rbBloquear = New System.Windows.Forms.RadioButton
        Me.rbDesbloquear = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(12, 92)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Aplicar!"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(110, 92)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.TabIndex = 3
        Me.ButtonX2.Text = "Fechar"
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 18)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(49, 16)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Usuário:"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(19, 48)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(42, 16)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Senha:"
        '
        'txtUsuarioEscola
        '
        '
        '
        '
        Me.txtUsuarioEscola.Border.Class = "TextBoxBorder"
        Me.txtUsuarioEscola.Location = New System.Drawing.Point(67, 17)
        Me.txtUsuarioEscola.Name = "txtUsuarioEscola"
        Me.txtUsuarioEscola.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuarioEscola.TabIndex = 6
        '
        'txtUsuarioProfessor
        '
        '
        '
        '
        Me.txtUsuarioProfessor.Border.Class = "TextBoxBorder"
        Me.txtUsuarioProfessor.Location = New System.Drawing.Point(191, 17)
        Me.txtUsuarioProfessor.Name = "txtUsuarioProfessor"
        Me.txtUsuarioProfessor.Size = New System.Drawing.Size(119, 20)
        Me.txtUsuarioProfessor.TabIndex = 7
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(178, 18)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(7, 16)
        Me.LabelX3.TabIndex = 8
        Me.LabelX3.Text = "."
        '
        'txtSenha
        '
        '
        '
        '
        Me.txtSenha.Border.Class = "TextBoxBorder"
        Me.txtSenha.Location = New System.Drawing.Point(67, 47)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 9
        '
        'cbUsuarioProfessor
        '
        Me.cbUsuarioProfessor.DisplayMember = "Text"
        Me.cbUsuarioProfessor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbUsuarioProfessor.FormattingEnabled = True
        Me.cbUsuarioProfessor.ItemHeight = 14
        Me.cbUsuarioProfessor.Location = New System.Drawing.Point(191, 17)
        Me.cbUsuarioProfessor.Name = "cbUsuarioProfessor"
        Me.cbUsuarioProfessor.Size = New System.Drawing.Size(119, 20)
        Me.cbUsuarioProfessor.TabIndex = 10
        '
        'rbIncluir
        '
        Me.rbIncluir.AutoSize = True
        Me.rbIncluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIncluir.Location = New System.Drawing.Point(201, 47)
        Me.rbIncluir.Name = "rbIncluir"
        Me.rbIncluir.Size = New System.Drawing.Size(108, 17)
        Me.rbIncluir.TabIndex = 11
        Me.rbIncluir.TabStop = True
        Me.rbIncluir.Text = "Incluir Usuário"
        Me.rbIncluir.UseVisualStyleBackColor = True
        '
        'rbAlterar
        '
        Me.rbAlterar.AutoSize = True
        Me.rbAlterar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlterar.Location = New System.Drawing.Point(201, 66)
        Me.rbAlterar.Name = "rbAlterar"
        Me.rbAlterar.Size = New System.Drawing.Size(104, 17)
        Me.rbAlterar.TabIndex = 12
        Me.rbAlterar.TabStop = True
        Me.rbAlterar.Text = "Alterar Senha"
        Me.rbAlterar.UseVisualStyleBackColor = True
        '
        'rbBloquear
        '
        Me.rbBloquear.AutoSize = True
        Me.rbBloquear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBloquear.Location = New System.Drawing.Point(201, 85)
        Me.rbBloquear.Name = "rbBloquear"
        Me.rbBloquear.Size = New System.Drawing.Size(76, 17)
        Me.rbBloquear.TabIndex = 13
        Me.rbBloquear.TabStop = True
        Me.rbBloquear.Text = "Bloquear"
        Me.rbBloquear.UseVisualStyleBackColor = True
        '
        'rbDesbloquear
        '
        Me.rbDesbloquear.AutoSize = True
        Me.rbDesbloquear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDesbloquear.Location = New System.Drawing.Point(201, 104)
        Me.rbDesbloquear.Name = "rbDesbloquear"
        Me.rbDesbloquear.Size = New System.Drawing.Size(97, 17)
        Me.rbDesbloquear.TabIndex = 14
        Me.rbDesbloquear.TabStop = True
        Me.rbDesbloquear.Text = "Desbloquear"
        Me.rbDesbloquear.UseVisualStyleBackColor = True
        '
        'frmBoletimWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 132)
        Me.Controls.Add(Me.rbDesbloquear)
        Me.Controls.Add(Me.rbBloquear)
        Me.Controls.Add(Me.rbAlterar)
        Me.Controls.Add(Me.rbIncluir)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtUsuarioProfessor)
        Me.Controls.Add(Me.txtUsuarioEscola)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.cbUsuarioProfessor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBoletimWeb"
        Me.ShowInTaskbar = False
        Me.Text = "Mais Escola - Boletim Web!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUsuarioEscola As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsuarioProfessor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSenha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbUsuarioProfessor As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents rbIncluir As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlterar As System.Windows.Forms.RadioButton
    Friend WithEvents rbBloquear As System.Windows.Forms.RadioButton
    Friend WithEvents rbDesbloquear As System.Windows.Forms.RadioButton
End Class
