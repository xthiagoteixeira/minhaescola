<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptNF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptNF))
        Me.Label2 = New System.Windows.Forms.Label
        Me.btMais = New DevComponents.DotNetBar.ButtonX
        Me.btMenos = New DevComponents.DotNetBar.ButtonX
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbAF = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbPeriodo = New System.Windows.Forms.RadioButton
        Me.rbTurmas = New System.Windows.Forms.RadioButton
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbPeriodo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.listaTurmas = New System.Windows.Forms.ListBox
        Me.cbComparar = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.GroupBox1.SuspendLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Turma:"
        '
        'btMais
        '
        Me.btMais.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btMais.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btMais.Enabled = False
        Me.btMais.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMais.Location = New System.Drawing.Point(470, 7)
        Me.btMais.Name = "btMais"
        Me.btMais.Size = New System.Drawing.Size(24, 23)
        Me.btMais.TabIndex = 151
        Me.btMais.Text = "+"
        '
        'btMenos
        '
        Me.btMenos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btMenos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btMenos.Enabled = False
        Me.btMenos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenos.Location = New System.Drawing.Point(470, 118)
        Me.btMenos.Name = "btMenos"
        Me.btMenos.Size = New System.Drawing.Size(24, 23)
        Me.btMenos.TabIndex = 152
        Me.btMenos.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Período:"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(136, 139)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.TabIndex = 156
        Me.ButtonX2.Text = "Fechar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(23, 139)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.TabIndex = 155
        Me.ButtonX1.Text = "Continuar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbAF)
        Me.GroupBox1.Controls.Add(Me.tBimestre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tAno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbPeriodo)
        Me.GroupBox1.Controls.Add(Me.rbTurmas)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 78)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escolha um grupo:"
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Location = New System.Drawing.Point(208, 50)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(35, 16)
        Me.cbAF.TabIndex = 161
        Me.cbAF.Text = "AF"
        '
        'tBimestre
        '
        Me.tBimestre.Location = New System.Drawing.Point(167, 47)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(38, 21)
        Me.tBimestre.TabIndex = 160
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Bimestre:"
        '
        'tAno
        '
        Me.tAno.Location = New System.Drawing.Point(167, 22)
        Me.tAno.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {2007, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(53, 21)
        Me.tAno.TabIndex = 158
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 14)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Ano:"
        '
        'rbPeriodo
        '
        Me.rbPeriodo.AutoSize = True
        Me.rbPeriodo.Location = New System.Drawing.Point(20, 47)
        Me.rbPeriodo.Name = "rbPeriodo"
        Me.rbPeriodo.Size = New System.Drawing.Size(68, 17)
        Me.rbPeriodo.TabIndex = 1
        Me.rbPeriodo.Text = "Período"
        Me.rbPeriodo.UseVisualStyleBackColor = True
        '
        'rbTurmas
        '
        Me.rbTurmas.AutoSize = True
        Me.rbTurmas.Location = New System.Drawing.Point(20, 24)
        Me.rbTurmas.Name = "rbTurmas"
        Me.rbTurmas.Size = New System.Drawing.Size(68, 17)
        Me.rbTurmas.TabIndex = 0
        Me.rbTurmas.Text = "Turmas"
        Me.rbTurmas.UseVisualStyleBackColor = True
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.Enabled = False
        Me.cbTurma.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 15
        Me.cbTurma.Location = New System.Drawing.Point(283, 7)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(175, 21)
        Me.cbTurma.TabIndex = 157
        '
        'cbPeriodo
        '
        Me.cbPeriodo.DisplayMember = "Text"
        Me.cbPeriodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPeriodo.Enabled = False
        Me.cbPeriodo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.ItemHeight = 15
        Me.cbPeriodo.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cbPeriodo.Location = New System.Drawing.Point(283, 146)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(175, 21)
        Me.cbPeriodo.TabIndex = 158
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Manhã"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Tarde"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Noite"
        '
        'listaTurmas
        '
        Me.listaTurmas.Enabled = False
        Me.listaTurmas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaTurmas.FormattingEnabled = True
        Me.listaTurmas.Location = New System.Drawing.Point(283, 32)
        Me.listaTurmas.Name = "listaTurmas"
        Me.listaTurmas.Size = New System.Drawing.Size(174, 108)
        Me.listaTurmas.TabIndex = 159
        '
        'cbComparar
        '
        Me.cbComparar.AutoSize = True
        Me.cbComparar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbComparar.Location = New System.Drawing.Point(30, 112)
        Me.cbComparar.Name = "cbComparar"
        Me.cbComparar.Size = New System.Drawing.Size(174, 16)
        Me.cbComparar.TabIndex = 160
        Me.cbComparar.Text = "Agrupar todos por bimestre"
        '
        'frmRptNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 173)
        Me.Controls.Add(Me.cbComparar)
        Me.Controls.Add(Me.listaTurmas)
        Me.Controls.Add(Me.cbPeriodo)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btMenos)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.btMais)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRptNF"
        Me.ShowInTaskbar = False
        Me.Text = " Relatórios! - Gráficos: Turmas - Grupos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btMais As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btMenos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPeriodo As System.Windows.Forms.RadioButton
    Friend WithEvents rbTurmas As System.Windows.Forms.RadioButton
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbPeriodo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents listaTurmas As System.Windows.Forms.ListBox
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents cbComparar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbAF As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
