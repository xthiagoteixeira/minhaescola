<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadNF
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
        Me.btAdicionar = New System.Windows.Forms.Button
        Me.cbDisciplina = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tQtdade = New System.Windows.Forms.NumericUpDown
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.pQtdade = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbEJA = New System.Windows.Forms.CheckBox
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tQtdade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pQtdade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btAdicionar
        '
        Me.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(241, 125)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(96, 22)
        Me.btAdicionar.TabIndex = 138
        Me.btAdicionar.Text = "Continuar"
        Me.btAdicionar.UseVisualStyleBackColor = True
        '
        'cbDisciplina
        '
        Me.cbDisciplina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbDisciplina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cbDisciplina.Location = New System.Drawing.Point(110, 43)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(197, 21)
        Me.cbDisciplina.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Disciplina:"
        '
        'cbTurma
        '
        Me.cbTurma.AllowDrop = True
        Me.cbTurma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbTurma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTurma.Location = New System.Drawing.Point(110, 16)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(197, 21)
        Me.cbTurma.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Turma:"
        '
        'tBimestre
        '
        Me.tBimestre.Location = New System.Drawing.Point(110, 71)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(31, 20)
        Me.tBimestre.TabIndex = 146
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Bimestre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 14)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "aulas"
        '
        'tQtdade
        '
        Me.tQtdade.Location = New System.Drawing.Point(226, 72)
        Me.tQtdade.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.tQtdade.Name = "tQtdade"
        Me.tQtdade.Size = New System.Drawing.Size(38, 20)
        Me.tQtdade.TabIndex = 150
        Me.tQtdade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tAno
        '
        Me.tAno.Location = New System.Drawing.Point(110, 95)
        Me.tAno.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(50, 20)
        Me.tAno.TabIndex = 152
        Me.tAno.Value = New Decimal(New Integer() {2007, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Ano:"
        '
        'pQtdade
        '
        Me.pQtdade.Location = New System.Drawing.Point(226, 95)
        Me.pQtdade.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.pQtdade.Name = "pQtdade"
        Me.pQtdade.Size = New System.Drawing.Size(38, 20)
        Me.pQtdade.TabIndex = 154
        Me.pQtdade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(270, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 14)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "aulas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(185, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 14)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(166, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Previsto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbEJA
        '
        Me.cbEJA.AutoSize = True
        Me.cbEJA.Location = New System.Drawing.Point(12, 128)
        Me.cbEJA.Name = "cbEJA"
        Me.cbEJA.Size = New System.Drawing.Size(120, 17)
        Me.cbEJA.TabIndex = 157
        Me.cbEJA.Text = "Avaliação Final EJA"
        Me.cbEJA.UseVisualStyleBackColor = True
        '
        'frmCadNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 154)
        Me.Controls.Add(Me.cbEJA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pQtdade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tQtdade)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAdicionar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCadNF"
        Me.Text = "Notas e Freqüências - Cadastro"
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tQtdade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pQtdade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAdicionar As System.Windows.Forms.Button
    Friend WithEvents cbDisciplina As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tQtdade As System.Windows.Forms.NumericUpDown
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pQtdade As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Protected Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents cbEJA As System.Windows.Forms.CheckBox
End Class
