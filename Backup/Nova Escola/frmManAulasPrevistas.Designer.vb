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
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbDisciplina = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btAlterar = New System.Windows.Forms.Button
        Me.btConsultar = New System.Windows.Forms.Button
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
        Me.tPrevistas.Location = New System.Drawing.Point(116, 47)
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
        Me.tAulas.Location = New System.Drawing.Point(116, 29)
        Me.tAulas.Name = "tAulas"
        Me.tAulas.Size = New System.Drawing.Size(25, 14)
        Me.tAulas.TabIndex = 165
        Me.tAulas.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total de Aulas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 47)
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
        Me.GroupBox2.Location = New System.Drawing.Point(221, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 78)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nova Alteração"
        '
        'tbPrevistas
        '
        Me.tbPrevistas.Location = New System.Drawing.Point(125, 45)
        Me.tbPrevistas.Name = "tbPrevistas"
        Me.tbPrevistas.Size = New System.Drawing.Size(34, 20)
        Me.tbPrevistas.TabIndex = 6
        '
        'tbAulas
        '
        Me.tbAulas.Location = New System.Drawing.Point(125, 21)
        Me.tbAulas.Name = "tbAulas"
        Me.tbAulas.Size = New System.Drawing.Size(34, 20)
        Me.tbAulas.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total de Aulas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 14)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Aulas Previstas:"
        '
        'tAno
        '
        Me.tAno.Location = New System.Drawing.Point(350, 36)
        Me.tAno.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(50, 20)
        Me.tAno.TabIndex = 163
        Me.tAno.Value = New Decimal(New Integer() {2007, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 14)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Ano:"
        '
        'tBimestre
        '
        Me.tBimestre.Location = New System.Drawing.Point(369, 9)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(31, 20)
        Me.tBimestre.TabIndex = 161
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(302, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Bimestre:"
        '
        'cbTurma
        '
        Me.cbTurma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbTurma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cbTurma.Location = New System.Drawing.Point(89, 9)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(147, 21)
        Me.cbTurma.TabIndex = 159
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
        'cbDisciplina
        '
        Me.cbDisciplina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbDisciplina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cbDisciplina.Location = New System.Drawing.Point(89, 36)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(147, 21)
        Me.cbDisciplina.TabIndex = 157
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
        'btAlterar
        '
        Me.btAlterar.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.btAlterar.Enabled = False
        Me.btAlterar.Location = New System.Drawing.Point(142, 190)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(139, 22)
        Me.btAlterar.TabIndex = 164
        Me.btAlterar.Text = "Efetuar Alterações"
        Me.btAlterar.UseVisualStyleBackColor = True
        '
        'btConsultar
        '
        Me.btConsultar.Location = New System.Drawing.Point(142, 69)
        Me.btConsultar.Name = "btConsultar"
        Me.btConsultar.Size = New System.Drawing.Size(139, 22)
        Me.btConsultar.TabIndex = 165
        Me.btConsultar.Text = "Consultar"
        Me.btConsultar.UseVisualStyleBackColor = True
        '
        'frmManAulasPrevistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 219)
        Me.Controls.Add(Me.btConsultar)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmManAulasPrevistas"
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
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbDisciplina As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btAlterar As System.Windows.Forms.Button
    Friend WithEvents tPrevistas As System.Windows.Forms.Label
    Friend WithEvents tAulas As System.Windows.Forms.Label
    Friend WithEvents tbPrevistas As System.Windows.Forms.TextBox
    Friend WithEvents tbAulas As System.Windows.Forms.TextBox
    Friend WithEvents btConsultar As System.Windows.Forms.Button
End Class
