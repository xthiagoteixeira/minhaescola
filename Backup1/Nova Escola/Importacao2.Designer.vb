<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Importacao2
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
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.openFD = New System.Windows.Forms.OpenFileDialog
        Me.tAnoVigente = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.btAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.cbExcluir = New DevComponents.DotNetBar.Controls.CheckBoxX
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTurma
        '
        Me.cbTurma.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Location = New System.Drawing.Point(127, 16)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(147, 21)
        Me.cbTurma.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Turma:"
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'tAnoVigente
        '
        Me.tAnoVigente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAnoVigente.Location = New System.Drawing.Point(199, 53)
        Me.tAnoVigente.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.tAnoVigente.Name = "tAnoVigente"
        Me.tAnoVigente.Size = New System.Drawing.Size(54, 21)
        Me.tAnoVigente.TabIndex = 158
        Me.tAnoVigente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAnoVigente.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 14)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Ano vigente:"
        '
        'btAdicionar
        '
        Me.btAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(270, 89)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btAdicionar.TabIndex = 159
        Me.btAdicionar.Text = "Excluir"
        '
        'cbExcluir
        '
        Me.cbExcluir.AutoSize = True
        Me.cbExcluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbExcluir.Location = New System.Drawing.Point(12, 96)
        Me.cbExcluir.Name = "cbExcluir"
        Me.cbExcluir.Size = New System.Drawing.Size(182, 16)
        Me.cbExcluir.TabIndex = 160
        Me.cbExcluir.Text = "Excluir todos do Ano Vigente"
        '
        'Importacao2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 121)
        Me.Controls.Add(Me.cbExcluir)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.tAnoVigente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Importacao2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importação de Alunos - Excluir"
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tAnoVigente As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbExcluir As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
