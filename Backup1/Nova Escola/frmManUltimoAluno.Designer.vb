<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManUltimoAluno
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
        Me.cbAF = New System.Windows.Forms.CheckBox
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbDisciplina = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LbCodigo = New System.Windows.Forms.Label
        Me.tbAC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbSN = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbFaltas = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbMedia = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btExcluir = New System.Windows.Forms.Button
        Me.btFechar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btConsultar = New DevComponents.DotNetBar.ButtonX
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Enabled = False
        Me.cbAF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAF.Location = New System.Drawing.Point(60, 117)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(111, 17)
        Me.cbAF.TabIndex = 206
        Me.cbAF.Text = "Avaliação Final"
        Me.cbAF.UseVisualStyleBackColor = True
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(225, 73)
        Me.tAno.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(56, 21)
        Me.tAno.TabIndex = 205
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(191, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 204
        Me.Label5.Text = "Ano:"
        '
        'tBimestre
        '
        Me.tBimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Location = New System.Drawing.Point(133, 74)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(40, 21)
        Me.tBimestre.TabIndex = 203
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Bimestre:"
        '
        'cbTurma
        '
        Me.cbTurma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbTurma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cbTurma.Location = New System.Drawing.Point(133, 19)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(148, 21)
        Me.cbTurma.TabIndex = 201
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 200
        Me.Label2.Text = "Turma:"
        '
        'cbDisciplina
        '
        Me.cbDisciplina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbDisciplina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cbDisciplina.Location = New System.Drawing.Point(133, 46)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(148, 21)
        Me.cbDisciplina.TabIndex = 199
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "Disciplina:"
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LbCodigo.CausesValidation = False
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.Blue
        Me.LbCodigo.Location = New System.Drawing.Point(35, 209)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(16, 14)
        Me.LbCodigo.TabIndex = 215
        Me.LbCodigo.Text = "1"
        '
        'tbAC
        '
        Me.tbAC.Enabled = False
        Me.tbAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAC.Location = New System.Drawing.Point(202, 206)
        Me.tbAC.Name = "tbAC"
        Me.tbAC.Size = New System.Drawing.Size(37, 21)
        Me.tbAC.TabIndex = 209
        Me.tbAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.CausesValidation = False
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(209, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 14)
        Me.Label4.TabIndex = 214
        Me.Label4.Text = "AC"
        '
        'tbSN
        '
        Me.tbSN.Enabled = False
        Me.tbSN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSN.Location = New System.Drawing.Point(276, 206)
        Me.tbSN.Name = "tbSN"
        Me.tbSN.Size = New System.Drawing.Size(37, 21)
        Me.tbSN.TabIndex = 210
        Me.tbSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.CausesValidation = False
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 14)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "PR"
        '
        'tbFaltas
        '
        Me.tbFaltas.Enabled = False
        Me.tbFaltas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFaltas.Location = New System.Drawing.Point(132, 206)
        Me.tbFaltas.Name = "tbFaltas"
        Me.tbFaltas.Size = New System.Drawing.Size(37, 21)
        Me.tbFaltas.TabIndex = 208
        Me.tbFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.CausesValidation = False
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(139, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 14)
        Me.Label7.TabIndex = 212
        Me.Label7.Text = "FT"
        '
        'tbMedia
        '
        Me.tbMedia.Enabled = False
        Me.tbMedia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMedia.Location = New System.Drawing.Point(62, 206)
        Me.tbMedia.Name = "tbMedia"
        Me.tbMedia.Size = New System.Drawing.Size(37, 21)
        Me.tbMedia.TabIndex = 207
        Me.tbMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.CausesValidation = False
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(69, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 14)
        Me.Label8.TabIndex = 211
        Me.Label8.Text = "AV"
        '
        'btExcluir
        '
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcluir.Location = New System.Drawing.Point(71, 237)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(96, 22)
        Me.btExcluir.TabIndex = 216
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.UseVisualStyleBackColor = True
        '
        'btFechar
        '
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(186, 237)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(96, 22)
        Me.btFechar.TabIndex = 217
        Me.btFechar.Text = "Fechar"
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 106)
        Me.GroupBox1.TabIndex = 218
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Boletim"
        '
        'btConsultar
        '
        Me.btConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConsultar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConsultar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConsultar.Location = New System.Drawing.Point(206, 114)
        Me.btConsultar.Name = "btConsultar"
        Me.btConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btConsultar.TabIndex = 219
        Me.btConsultar.Text = "Consultar"
        '
        'frmManUltimoAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 151)
        Me.Controls.Add(Me.btConsultar)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.LbCodigo)
        Me.Controls.Add(Me.tbAC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbSN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbFaltas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbMedia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmManUltimoAluno"
        Me.ShowInTaskbar = False
        Me.Text = "Mais Escola - Manutenção - Remover último aluno"
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbAF As System.Windows.Forms.CheckBox
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDisciplina As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbCodigo As System.Windows.Forms.Label
    Friend WithEvents tbAC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbSN As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbFaltas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbMedia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btExcluir As System.Windows.Forms.Button
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btConsultar As DevComponents.DotNetBar.ButtonX
End Class
