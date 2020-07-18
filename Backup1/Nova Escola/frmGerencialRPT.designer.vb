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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerencialRPT))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbRelatorio = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.ComboItem5 = New DevComponents.Editors.ComboItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbFiltro = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tbNome = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbDisciplina = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbAF = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.lbNome = New System.Windows.Forms.Label
        Me.pbProcurar = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.btVisualizar = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.checkFiltro = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.checkTurmas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.checkDisciplinas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ComboItem6 = New DevComponents.Editors.ComboItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProcurar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbRelatorio)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Relatório de:"
        '
        'cbRelatorio
        '
        Me.cbRelatorio.DisplayMember = "Text"
        Me.cbRelatorio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbRelatorio.FormattingEnabled = True
        Me.cbRelatorio.ItemHeight = 15
        Me.cbRelatorio.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem4, Me.ComboItem5, Me.ComboItem3, Me.ComboItem6})
        Me.cbRelatorio.Location = New System.Drawing.Point(45, 27)
        Me.cbRelatorio.Name = "cbRelatorio"
        Me.cbRelatorio.Size = New System.Drawing.Size(151, 21)
        Me.cbRelatorio.TabIndex = 21
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Ata do Conselho"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Boletim"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Gráficos"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Consolidado"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Ficha Individual"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbFiltro)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(294, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo:"
        '
        'cbFiltro
        '
        Me.cbFiltro.DisplayMember = "Text"
        Me.cbFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.ItemHeight = 15
        Me.cbFiltro.Location = New System.Drawing.Point(51, 27)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(151, 21)
        Me.cbFiltro.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbNome)
        Me.GroupBox3.Controls.Add(Me.cbTurma)
        Me.GroupBox3.Controls.Add(Me.cbDisciplina)
        Me.GroupBox3.Controls.Add(Me.cbAF)
        Me.GroupBox3.Controls.Add(Me.tBimestre)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tAno)
        Me.GroupBox3.Controls.Add(Me.lbNome)
        Me.GroupBox3.Controls.Add(Me.pbProcurar)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 119)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrar por:"
        '
        'tbNome
        '
        '
        '
        '
        Me.tbNome.Border.Class = "TextBoxBorder"
        Me.tbNome.Location = New System.Drawing.Point(89, 86)
        Me.tbNome.Name = "tbNome"
        Me.tbNome.Size = New System.Drawing.Size(161, 21)
        Me.tbNome.TabIndex = 21
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 15
        Me.cbTurma.Location = New System.Drawing.Point(89, 28)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(161, 21)
        Me.cbTurma.TabIndex = 21
        '
        'cbDisciplina
        '
        Me.cbDisciplina.DisplayMember = "Text"
        Me.cbDisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.ItemHeight = 15
        Me.cbDisciplina.Location = New System.Drawing.Point(89, 57)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(161, 21)
        Me.cbDisciplina.TabIndex = 23
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Location = New System.Drawing.Point(304, 45)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(105, 16)
        Me.cbAF.TabIndex = 200
        Me.cbAF.Text = "Avaliação Final"
        '
        'tBimestre
        '
        Me.tBimestre.Enabled = False
        Me.tBimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Location = New System.Drawing.Point(370, 20)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(38, 21)
        Me.tBimestre.TabIndex = 7
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "Ano:"
        '
        'tAno
        '
        Me.tAno.Enabled = False
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(347, 65)
        Me.tAno.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(61, 21)
        Me.tAno.TabIndex = 197
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'lbNome
        '
        Me.lbNome.BackColor = System.Drawing.Color.White
        Me.lbNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbNome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNome.ForeColor = System.Drawing.Color.Blue
        Me.lbNome.Location = New System.Drawing.Point(285, 89)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(123, 17)
        Me.lbNome.TabIndex = 12
        Me.lbNome.Text = "Não encontrado!"
        Me.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbProcurar
        '
        Me.pbProcurar.Image = Global.Mais_Escola.My.Resources.Resources.lupa_melhor
        Me.pbProcurar.Location = New System.Drawing.Point(256, 89)
        Me.pbProcurar.Name = "pbProcurar"
        Me.pbProcurar.Size = New System.Drawing.Size(19, 16)
        Me.pbProcurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbProcurar.TabIndex = 199
        Me.pbProcurar.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(301, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bimestre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Disciplina:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Turma:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(415, 99)
        Me.ShapeContainer1.TabIndex = 199
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 282
        Me.LineShape1.X2 = 282
        Me.LineShape1.Y1 = 2
        Me.LineShape1.Y2 = 64
        '
        'btVisualizar
        '
        Me.btVisualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVisualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVisualizar.Enabled = False
        Me.btVisualizar.Location = New System.Drawing.Point(460, 158)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btVisualizar.TabIndex = 16
        Me.btVisualizar.Text = "Visualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Location = New System.Drawing.Point(460, 183)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 17
        Me.btFechar.Text = "Fechar"
        '
        'checkFiltro
        '
        Me.checkFiltro.AutoSize = True
        Me.checkFiltro.Location = New System.Drawing.Point(433, 85)
        Me.checkFiltro.Name = "checkFiltro"
        Me.checkFiltro.Size = New System.Drawing.Size(77, 16)
        Me.checkFiltro.TabIndex = 18
        Me.checkFiltro.Text = "Usar filtro"
        '
        'checkTurmas
        '
        Me.checkTurmas.AutoSize = True
        Me.checkTurmas.Location = New System.Drawing.Point(433, 107)
        Me.checkTurmas.Name = "checkTurmas"
        Me.checkTurmas.Size = New System.Drawing.Size(114, 16)
        Me.checkTurmas.TabIndex = 19
        Me.checkTurmas.Text = "Todas as turmas"
        '
        'checkDisciplinas
        '
        Me.checkDisciplinas.AutoSize = True
        Me.checkDisciplinas.Location = New System.Drawing.Point(433, 130)
        Me.checkDisciplinas.Name = "checkDisciplinas"
        Me.checkDisciplinas.Size = New System.Drawing.Size(132, 16)
        Me.checkDisciplinas.TabIndex = 20
        Me.checkDisciplinas.Text = "Todas as disciplinas"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Declaração Escolar"
        '
        'frmGerencialRPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 214)
        Me.Controls.Add(Me.checkDisciplinas)
        Me.Controls.Add(Me.checkTurmas)
        Me.Controls.Add(Me.checkFiltro)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.btVisualizar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGerencialRPT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meu Relatório!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProcurar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pbProcurar As System.Windows.Forms.PictureBox
    Friend WithEvents lbNome As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btVisualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents checkFiltro As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checkTurmas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checkDisciplinas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbAF As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbRelatorio As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbFiltro As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbDisciplina As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents tbNome As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
End Class
