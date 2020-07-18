<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManACP
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
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.btAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.cbTodas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbAF = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbDisciplina = New DevComponents.DotNetBar.Controls.ComboBoxEx
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tBimestre
        '
        Me.tBimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Location = New System.Drawing.Point(90, 67)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(38, 21)
        Me.tBimestre.TabIndex = 153
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Bimestre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Turma:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Disciplina:"
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(184, 66)
        Me.tAno.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(58, 21)
        Me.tAno.TabIndex = 157
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2008, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(149, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "Ano:"
        '
        'btAdicionar
        '
        Me.btAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(167, 116)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btAdicionar.TabIndex = 198
        Me.btAdicionar.Text = "Excluir"
        '
        'cbTodas
        '
        Me.cbTodas.AutoSize = True
        Me.cbTodas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTodas.Location = New System.Drawing.Point(16, 101)
        Me.cbTodas.Name = "cbTodas"
        Me.cbTodas.Size = New System.Drawing.Size(131, 16)
        Me.cbTodas.TabIndex = 199
        Me.cbTodas.Text = "Todas as disciplinas"
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Enabled = False
        Me.cbAF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAF.Location = New System.Drawing.Point(16, 123)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(104, 16)
        Me.cbAF.TabIndex = 200
        Me.cbAF.Text = "Avaliação Final"
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 15
        Me.cbTurma.Location = New System.Drawing.Point(90, 13)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(153, 21)
        Me.cbTurma.TabIndex = 202
        '
        'cbDisciplina
        '
        Me.cbDisciplina.DisplayMember = "Text"
        Me.cbDisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.ItemHeight = 15
        Me.cbDisciplina.Location = New System.Drawing.Point(90, 40)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(153, 21)
        Me.cbDisciplina.TabIndex = 201
        '
        'frmManACP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 151)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.cbTodas)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmManACP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Boletim - Manutenção"
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTodas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbAF As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbDisciplina As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
