<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerencialRPT
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
        Me.cbRelatorio = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbFiltro = New System.Windows.Forms.ComboBox
        Me.btVisualizar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbDisciplina = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.checkFiltro = New System.Windows.Forms.CheckBox
        Me.CheckDisciplinas = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbRelatorio)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Relatório de:"
        '
        'cbRelatorio
        '
        Me.cbRelatorio.FormattingEnabled = True
        Me.cbRelatorio.Items.AddRange(New Object() {"Código de Barras", "Ata do Conselho", "Boletim", "Gráficos", "Consolidado"})
        Me.cbRelatorio.Location = New System.Drawing.Point(39, 27)
        Me.cbRelatorio.Name = "cbRelatorio"
        Me.cbRelatorio.Size = New System.Drawing.Size(121, 21)
        Me.cbRelatorio.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbFiltro)
        Me.GroupBox2.Location = New System.Drawing.Point(252, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo:"
        '
        'cbFiltro
        '
        Me.cbFiltro.Enabled = False
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Location = New System.Drawing.Point(39, 27)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cbFiltro.TabIndex = 1
        '
        'btVisualizar
        '
        Me.btVisualizar.Enabled = False
        Me.btVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVisualizar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVisualizar.Location = New System.Drawing.Point(391, 162)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(72, 25)
        Me.btVisualizar.TabIndex = 10
        Me.btVisualizar.Text = "Visualizar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.tBimestre)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbDisciplina)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tAno)
        Me.GroupBox3.Controls.Add(Me.cbTurma)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 98)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrar por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "bimestre"
        '
        'tBimestre
        '
        Me.tBimestre.Enabled = False
        Me.tBimestre.Location = New System.Drawing.Point(246, 58)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(33, 20)
        Me.tBimestre.TabIndex = 7
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Disciplina:"
        '
        'cbDisciplina
        '
        Me.cbDisciplina.Enabled = False
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.Location = New System.Drawing.Point(97, 56)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(121, 21)
        Me.cbDisciplina.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Turma:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ano:"
        '
        'tAno
        '
        Me.tAno.Enabled = False
        Me.tAno.Location = New System.Drawing.Point(288, 27)
        Me.tAno.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(52, 20)
        Me.tAno.TabIndex = 2
        Me.tAno.Value = New Decimal(New Integer() {2008, 0, 0, 0})
        '
        'cbTurma
        '
        Me.cbTurma.Enabled = False
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Location = New System.Drawing.Point(97, 26)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(121, 21)
        Me.cbTurma.TabIndex = 1
        '
        'checkFiltro
        '
        Me.checkFiltro.AutoSize = True
        Me.checkFiltro.Location = New System.Drawing.Point(376, 105)
        Me.checkFiltro.Name = "checkFiltro"
        Me.checkFiltro.Size = New System.Drawing.Size(70, 17)
        Me.checkFiltro.TabIndex = 12
        Me.checkFiltro.Text = "Usar filtro"
        Me.checkFiltro.UseVisualStyleBackColor = True
        '
        'CheckDisciplinas
        '
        Me.CheckDisciplinas.AutoSize = True
        Me.CheckDisciplinas.Enabled = False
        Me.CheckDisciplinas.Location = New System.Drawing.Point(376, 128)
        Me.CheckDisciplinas.Name = "CheckDisciplinas"
        Me.CheckDisciplinas.Size = New System.Drawing.Size(107, 17)
        Me.CheckDisciplinas.TabIndex = 13
        Me.CheckDisciplinas.Text = "Todas disciplinas"
        Me.CheckDisciplinas.UseVisualStyleBackColor = True
        '
        'frmGerencialRPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 199)
        Me.Controls.Add(Me.CheckDisciplinas)
        Me.Controls.Add(Me.checkFiltro)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btVisualizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGerencialRPT"
        Me.Text = "Gerenciador de Relatórios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbRelatorio As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents btVisualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbDisciplina As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents checkFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckDisciplinas As System.Windows.Forms.CheckBox
End Class
