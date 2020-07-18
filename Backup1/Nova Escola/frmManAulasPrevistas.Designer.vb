<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManAulasPrevistas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tPrevistas = New System.Windows.Forms.Label
        Me.tAulas = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbPrevistas = New System.Windows.Forms.TextBox
        Me.tbAulas = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbAF = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btConsultar = New DevComponents.DotNetBar.ButtonX
        Me.btAlterar = New DevComponents.DotNetBar.ButtonX
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbDisciplina = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tPrevistas)
        Me.GroupBox1.Controls.Add(Me.tAulas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atual"
        '
        'tPrevistas
        '
        Me.tPrevistas.AutoSize = True
        Me.tPrevistas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPrevistas.ForeColor = System.Drawing.Color.Blue
        Me.tPrevistas.Location = New System.Drawing.Point(133, 47)
        Me.tPrevistas.Name = "tPrevistas"
        Me.tPrevistas.Size = New System.Drawing.Size(25, 14)
        Me.tPrevistas.TabIndex = 166
        Me.tPrevistas.Text = "00"
        '
        'tAulas
        '
        Me.tAulas.AutoSize = True
        Me.tAulas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAulas.ForeColor = System.Drawing.Color.Blue
        Me.tAulas.Location = New System.Drawing.Point(133, 29)
        Me.tAulas.Name = "tAulas"
        Me.tAulas.Size = New System.Drawing.Size(25, 14)
        Me.tAulas.TabIndex = 165
        Me.tAulas.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total de Aulas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Aulas Previstas:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbPrevistas)
        Me.GroupBox2.Controls.Add(Me.tbAulas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(221, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 78)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nova Alteração"
        '
        'tbPrevistas
        '
        Me.tbPrevistas.Location = New System.Drawing.Point(134, 45)
        Me.tbPrevistas.Name = "tbPrevistas"
        Me.tbPrevistas.Size = New System.Drawing.Size(34, 21)
        Me.tbPrevistas.TabIndex = 6
        '
        'tbAulas
        '
        Me.tbAulas.Location = New System.Drawing.Point(134, 21)
        Me.tbAulas.Name = "tbAulas"
        Me.tbAulas.Size = New System.Drawing.Size(34, 21)
        Me.tbAulas.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total de Aulas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 14)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Aulas Previstas:"
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(338, 36)
        Me.tAno.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(59, 21)
        Me.tAno.TabIndex = 163
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(302, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 14)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Ano:"
        '
        'tBimestre
        '
        Me.tBimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Location = New System.Drawing.Point(338, 10)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(34, 21)
        Me.tBimestre.TabIndex = 161
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(271, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Bimestre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 14)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "Turma:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 14)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Disciplina:"
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAF.Location = New System.Drawing.Point(374, 13)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(36, 16)
        Me.cbAF.TabIndex = 166
        Me.cbAF.Text = "AF"
        '
        'btConsultar
        '
        Me.btConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConsultar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConsultar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConsultar.Location = New System.Drawing.Point(171, 69)
        Me.btConsultar.Name = "btConsultar"
        Me.btConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btConsultar.TabIndex = 167
        Me.btConsultar.Text = "Consultar"
        '
        'btAlterar
        '
        Me.btAlterar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAlterar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAlterar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlterar.Location = New System.Drawing.Point(171, 189)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btAlterar.TabIndex = 168
        Me.btAlterar.Text = "Alterar"
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 15
        Me.cbTurma.Location = New System.Drawing.Point(90, 10)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(124, 21)
        Me.cbTurma.TabIndex = 170
        '
        'cbDisciplina
        '
        Me.cbDisciplina.DisplayMember = "Text"
        Me.cbDisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.ItemHeight = 15
        Me.cbDisciplina.Location = New System.Drawing.Point(90, 38)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(124, 21)
        Me.cbDisciplina.TabIndex = 169
        '
        'frmManAulasPrevistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 220)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.btConsultar)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmManAulasPrevistas"
        Me.ShowInTaskbar = False
        Me.Text = "Manutenção - Aulas Previstas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tPrevistas As System.Windows.Forms.Label
    Friend WithEvents tAulas As System.Windows.Forms.Label
    Friend WithEvents tbPrevistas As System.Windows.Forms.TextBox
    Friend WithEvents tbAulas As System.Windows.Forms.TextBox
    Friend WithEvents cbAF As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btConsultar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAlterar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbDisciplina As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
