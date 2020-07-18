<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerencial2
    Inherits System.Windows.Forms.Form

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
    Private Sub InitializeComponent()
        Me.tbUsuario = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbSenha = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbSenha2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btEfetivar = New System.Windows.Forms.Button
        Me.rbnovo = New System.Windows.Forms.RadioButton
        Me.rbAlterar = New System.Windows.Forms.RadioButton
        Me.rbRetirar = New System.Windows.Forms.RadioButton
        Me.cbUsuario = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(81, 8)
        Me.tbUsuario.MaxLength = 30
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(146, 20)
        Me.tbUsuario.TabIndex = 149
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Usuário:"
        '
        'tbSenha
        '
        Me.tbSenha.Location = New System.Drawing.Point(81, 37)
        Me.tbSenha.MaxLength = 30
        Me.tbSenha.Name = "tbSenha"
        Me.tbSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbSenha.Size = New System.Drawing.Size(146, 20)
        Me.tbSenha.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Senha:"
        '
        'tbSenha2
        '
        Me.tbSenha2.Location = New System.Drawing.Point(81, 67)
        Me.tbSenha2.MaxLength = 30
        Me.tbSenha2.Name = "tbSenha2"
        Me.tbSenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbSenha2.Size = New System.Drawing.Size(146, 20)
        Me.tbSenha2.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "R. Senha:"
        '
        'btEfetivar
        '
        Me.btEfetivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEfetivar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEfetivar.Location = New System.Drawing.Point(126, 93)
        Me.btEfetivar.Name = "btEfetivar"
        Me.btEfetivar.Size = New System.Drawing.Size(152, 22)
        Me.btEfetivar.TabIndex = 204
        Me.btEfetivar.Text = "Efetivar Alterações"
        Me.btEfetivar.UseVisualStyleBackColor = True
        '
        'rbnovo
        '
        Me.rbnovo.AutoSize = True
        Me.rbnovo.Checked = True
        Me.rbnovo.Location = New System.Drawing.Point(269, 21)
        Me.rbnovo.Name = "rbnovo"
        Me.rbnovo.Size = New System.Drawing.Size(90, 17)
        Me.rbnovo.TabIndex = 205
        Me.rbnovo.TabStop = True
        Me.rbnovo.Text = "Novo Usuário"
        Me.rbnovo.UseVisualStyleBackColor = True
        '
        'rbAlterar
        '
        Me.rbAlterar.AutoSize = True
        Me.rbAlterar.Location = New System.Drawing.Point(269, 43)
        Me.rbAlterar.Name = "rbAlterar"
        Me.rbAlterar.Size = New System.Drawing.Size(89, 17)
        Me.rbAlterar.TabIndex = 206
        Me.rbAlterar.Text = "Alterar Senha"
        Me.rbAlterar.UseVisualStyleBackColor = True
        '
        'rbRetirar
        '
        Me.rbRetirar.AutoSize = True
        Me.rbRetirar.Location = New System.Drawing.Point(269, 65)
        Me.rbRetirar.Name = "rbRetirar"
        Me.rbRetirar.Size = New System.Drawing.Size(95, 17)
        Me.rbRetirar.TabIndex = 207
        Me.rbRetirar.Text = "Retirar Usuário"
        Me.rbRetirar.UseVisualStyleBackColor = True
        '
        'cbUsuario
        '
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(81, 7)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(146, 21)
        Me.cbUsuario.TabIndex = 208
        '
        'frmGerencial2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 124)
        Me.Controls.Add(Me.cbUsuario)
        Me.Controls.Add(Me.rbRetirar)
        Me.Controls.Add(Me.rbAlterar)
        Me.Controls.Add(Me.rbnovo)
        Me.Controls.Add(Me.btEfetivar)
        Me.Controls.Add(Me.tbSenha2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbSenha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGerencial2"
        Me.Text = "Nova Escola - Usuários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSenha2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btEfetivar As System.Windows.Forms.Button
    Friend WithEvents rbnovo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlterar As System.Windows.Forms.RadioButton
    Friend WithEvents rbRetirar As System.Windows.Forms.RadioButton
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
End Class
