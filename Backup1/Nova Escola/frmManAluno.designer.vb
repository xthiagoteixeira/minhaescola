<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManAluno))
        Me.tbTurma = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbAluno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbCodigo = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.btAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.rbBF = New System.Windows.Forms.RadioButton
        Me.rbBVJ = New System.Windows.Forms.RadioButton
        CType(Me.tbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbTurma
        '
        Me.tbTurma.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTurma.FormattingEnabled = True
        Me.tbTurma.Location = New System.Drawing.Point(167, 7)
        Me.tbTurma.Name = "tbTurma"
        Me.tbTurma.Size = New System.Drawing.Size(134, 21)
        Me.tbTurma.TabIndex = 153
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Turma:"
        '
        'tbAluno
        '
        Me.tbAluno.Enabled = False
        Me.tbAluno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAluno.Location = New System.Drawing.Point(56, 34)
        Me.tbAluno.Name = "tbAluno"
        Me.tbAluno.Size = New System.Drawing.Size(245, 21)
        Me.tbAluno.TabIndex = 151
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Nome:"
        '
        'tbCodigo
        '
        Me.tbCodigo.Enabled = False
        Me.tbCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo.Location = New System.Drawing.Point(44, 8)
        Me.tbCodigo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(39, 21)
        Me.tbCodigo.TabIndex = 155
        Me.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbCodigo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Nro:"
        '
        'btAdicionar
        '
        Me.btAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(226, 90)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btAdicionar.TabIndex = 157
        Me.btAdicionar.Text = "Alterar"
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(246, 62)
        Me.tAno.Maximum = New Decimal(New Integer() {2800, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {2007, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(55, 21)
        Me.tAno.TabIndex = 159
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Ano:"
        '
        'rbBF
        '
        Me.rbBF.AutoSize = True
        Me.rbBF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBF.Location = New System.Drawing.Point(36, 70)
        Me.rbBF.Name = "rbBF"
        Me.rbBF.Size = New System.Drawing.Size(100, 17)
        Me.rbBF.TabIndex = 160
        Me.rbBF.TabStop = True
        Me.rbBF.Text = "Bolsa Família"
        Me.rbBF.UseVisualStyleBackColor = True
        '
        'rbBVJ
        '
        Me.rbBVJ.AutoSize = True
        Me.rbBVJ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBVJ.Location = New System.Drawing.Point(36, 92)
        Me.rbBVJ.Name = "rbBVJ"
        Me.rbBVJ.Size = New System.Drawing.Size(148, 17)
        Me.rbBVJ.TabIndex = 161
        Me.rbBVJ.TabStop = True
        Me.rbBVJ.Text = "Bolsa Variável Jovem"
        Me.rbBVJ.UseVisualStyleBackColor = True
        '
        'frmManAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 121)
        Me.Controls.Add(Me.rbBVJ)
        Me.Controls.Add(Me.rbBF)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTurma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAluno)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmManAluno"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aluno - Manutenção"
        CType(Me.tbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbCodigo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbBF As System.Windows.Forms.RadioButton
    Friend WithEvents rbBVJ As System.Windows.Forms.RadioButton
End Class
