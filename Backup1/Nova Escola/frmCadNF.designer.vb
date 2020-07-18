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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadNF))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.tQtdade = New System.Windows.Forms.NumericUpDown
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.pQtdade = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.cbDisciplina = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbAF = New DevComponents.DotNetBar.Controls.CheckBoxX
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tQtdade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pQtdade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Disciplina:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Turma:"
        '
        'tBimestre
        '
        Me.tBimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Location = New System.Drawing.Point(115, 67)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(39, 21)
        Me.tBimestre.TabIndex = 146
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Bimestre:"
        '
        'tQtdade
        '
        Me.tQtdade.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tQtdade.Location = New System.Drawing.Point(299, 67)
        Me.tQtdade.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.tQtdade.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tQtdade.Name = "tQtdade"
        Me.tQtdade.Size = New System.Drawing.Size(44, 21)
        Me.tQtdade.TabIndex = 150
        Me.tQtdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tQtdade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(115, 92)
        Me.tAno.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(61, 21)
        Me.tAno.TabIndex = 152
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Ano:"
        '
        'pQtdade
        '
        Me.pQtdade.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pQtdade.Location = New System.Drawing.Point(299, 92)
        Me.pQtdade.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.pQtdade.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.pQtdade.Name = "pQtdade"
        Me.pQtdade.Size = New System.Drawing.Size(44, 21)
        Me.pQtdade.TabIndex = 154
        Me.pQtdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pQtdade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(208, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 14)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Aulas dadas:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(188, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 14)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Aulas Previstas:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btAdicionar
        '
        Me.btAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdicionar.Location = New System.Drawing.Point(298, 124)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(92, 23)
        Me.btAdicionar.TabIndex = 158
        Me.btAdicionar.Text = "Continuar"
        '
        'cbDisciplina
        '
        Me.cbDisciplina.DisplayMember = "Text"
        Me.cbDisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.ItemHeight = 15
        Me.cbDisciplina.Location = New System.Drawing.Point(115, 41)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(229, 21)
        Me.cbDisciplina.TabIndex = 159
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 15
        Me.cbTurma.Location = New System.Drawing.Point(115, 14)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(229, 21)
        Me.cbTurma.TabIndex = 160
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Location = New System.Drawing.Point(12, 131)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(105, 16)
        Me.cbAF.TabIndex = 161
        Me.cbAF.Text = "Avaliação Final"
        '
        'frmCadNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 156)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pQtdade)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tQtdade)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadNF"
        Me.ShowInTaskbar = False
        Me.Text = "Notas e Frequências - Cadastro"
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tQtdade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pQtdade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tQtdade As System.Windows.Forms.NumericUpDown
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pQtdade As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbDisciplina As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbAF As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
