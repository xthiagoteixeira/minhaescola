<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSobreEscola
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
        Me.tbEscola = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbDiretoria = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btCadastro = New DevComponents.DotNetBar.ButtonX
        Me.btFinalizar = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'tbEscola
        '
        Me.tbEscola.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEscola.Location = New System.Drawing.Point(77, 9)
        Me.tbEscola.Name = "tbEscola"
        Me.tbEscola.Size = New System.Drawing.Size(224, 22)
        Me.tbEscola.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Escola:"
        '
        'tbDiretoria
        '
        Me.tbDiretoria.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDiretoria.Location = New System.Drawing.Point(77, 35)
        Me.tbDiretoria.Name = "tbDiretoria"
        Me.tbDiretoria.Size = New System.Drawing.Size(224, 22)
        Me.tbDiretoria.TabIndex = 154
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 155
        Me.Label14.Text = "Diretoria:"
        '
        'btCadastro
        '
        Me.btCadastro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCadastro.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCadastro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCadastro.Location = New System.Drawing.Point(145, 63)
        Me.btCadastro.Name = "btCadastro"
        Me.btCadastro.Size = New System.Drawing.Size(75, 23)
        Me.btCadastro.TabIndex = 156
        Me.btCadastro.Text = "Alterar"
        '
        'btFinalizar
        '
        Me.btFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFinalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFinalizar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFinalizar.Location = New System.Drawing.Point(226, 63)
        Me.btFinalizar.Name = "btFinalizar"
        Me.btFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btFinalizar.TabIndex = 157
        Me.btFinalizar.Text = "Finalizar"
        '
        'frmSobreEscola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 94)
        Me.Controls.Add(Me.btFinalizar)
        Me.Controls.Add(Me.btCadastro)
        Me.Controls.Add(Me.tbDiretoria)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbEscola)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmSobreEscola"
        Me.ShowInTaskbar = False
        Me.Text = "Informações da Escola"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbEscola As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbDiretoria As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btCadastro As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFinalizar As DevComponents.DotNetBar.ButtonX
End Class
