<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Importacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Importacao))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.openFD = New System.Windows.Forms.OpenFileDialog
        Me.lbarquivo = New System.Windows.Forms.TextBox
        Me.tAnoVigente = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Turma:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Arquivo:"
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'lbarquivo
        '
        Me.lbarquivo.Enabled = False
        Me.lbarquivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbarquivo.Location = New System.Drawing.Point(100, 13)
        Me.lbarquivo.Name = "lbarquivo"
        Me.lbarquivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbarquivo.Size = New System.Drawing.Size(147, 21)
        Me.lbarquivo.TabIndex = 155
        Me.lbarquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tAnoVigente
        '
        Me.tAnoVigente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAnoVigente.Location = New System.Drawing.Point(193, 87)
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
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 14)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Ano vigente:"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(12, 122)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.TabIndex = 163
        Me.ButtonX2.Text = "Importar"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.Location = New System.Drawing.Point(229, 122)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX3.TabIndex = 164
        Me.ButtonX3.Text = "Fechar"
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 14
        Me.cbTurma.Location = New System.Drawing.Point(100, 51)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(147, 20)
        Me.cbTurma.TabIndex = 165
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mais_Escola.My.Resources.Resources.lupa_melhor
        Me.PictureBox1.Location = New System.Drawing.Point(253, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Importacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 154)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.tAnoVigente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbarquivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Importacao"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importação de Alunos"
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbarquivo As System.Windows.Forms.TextBox
    Friend WithEvents tAnoVigente As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
