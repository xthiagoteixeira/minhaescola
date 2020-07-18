<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpBoletim2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpBoletim2))
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbDisciplina = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.btDelDisciplinas = New System.Windows.Forms.Button
        Me.lbDisciplinas = New System.Windows.Forms.ListBox
        Me.btAddDisciplinas = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.btDelTurmas = New System.Windows.Forms.Button
        Me.lbTurmas = New System.Windows.Forms.ListBox
        Me.btAddTurmas = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbDrivers = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.pNao = New System.Windows.Forms.PictureBox
        Me.pSim = New System.Windows.Forms.PictureBox
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.cbMail = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbAlunos = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbAvancadas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btCarregar = New DevComponents.DotNetBar.ButtonX
        Me.btRefazer = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.btAvancado = New DevComponents.DotNetBar.ButtonX
        Me.pBarra = New DevComponents.DotNetBar.Controls.ProgressBarX
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pNao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pSim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(300, 80)
        Me.tAno.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(59, 21)
        Me.tAno.TabIndex = 191
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(219, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 14)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "Ano Letivo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbDisciplina)
        Me.GroupBox2.Controls.Add(Me.btDelDisciplinas)
        Me.GroupBox2.Controls.Add(Me.lbDisciplinas)
        Me.GroupBox2.Controls.Add(Me.btAddDisciplinas)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(605, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 140)
        Me.GroupBox2.TabIndex = 194
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Disciplinas"
        '
        'cbDisciplina
        '
        Me.cbDisciplina.DisplayMember = "Text"
        Me.cbDisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.ItemHeight = 15
        Me.cbDisciplina.Location = New System.Drawing.Point(8, 19)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(126, 21)
        Me.cbDisciplina.TabIndex = 15
        '
        'btDelDisciplinas
        '
        Me.btDelDisciplinas.Enabled = False
        Me.btDelDisciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDelDisciplinas.Location = New System.Drawing.Point(139, 108)
        Me.btDelDisciplinas.Name = "btDelDisciplinas"
        Me.btDelDisciplinas.Size = New System.Drawing.Size(24, 23)
        Me.btDelDisciplinas.TabIndex = 14
        Me.btDelDisciplinas.Text = "-"
        Me.btDelDisciplinas.UseVisualStyleBackColor = True
        '
        'lbDisciplinas
        '
        Me.lbDisciplinas.FormattingEnabled = True
        Me.lbDisciplinas.Location = New System.Drawing.Point(8, 49)
        Me.lbDisciplinas.Name = "lbDisciplinas"
        Me.lbDisciplinas.Size = New System.Drawing.Size(126, 82)
        Me.lbDisciplinas.TabIndex = 11
        '
        'btAddDisciplinas
        '
        Me.btAddDisciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAddDisciplinas.Location = New System.Drawing.Point(139, 19)
        Me.btAddDisciplinas.Name = "btAddDisciplinas"
        Me.btAddDisciplinas.Size = New System.Drawing.Size(24, 23)
        Me.btAddDisciplinas.TabIndex = 13
        Me.btAddDisciplinas.Text = "+"
        Me.btAddDisciplinas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbTurma)
        Me.GroupBox1.Controls.Add(Me.btDelTurmas)
        Me.GroupBox1.Controls.Add(Me.lbTurmas)
        Me.GroupBox1.Controls.Add(Me.btAddTurmas)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(416, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 140)
        Me.GroupBox1.TabIndex = 193
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Turmas"
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 15
        Me.cbTurma.Location = New System.Drawing.Point(9, 19)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(126, 21)
        Me.cbTurma.TabIndex = 11
        '
        'btDelTurmas
        '
        Me.btDelTurmas.Enabled = False
        Me.btDelTurmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDelTurmas.Location = New System.Drawing.Point(140, 108)
        Me.btDelTurmas.Name = "btDelTurmas"
        Me.btDelTurmas.Size = New System.Drawing.Size(24, 23)
        Me.btDelTurmas.TabIndex = 10
        Me.btDelTurmas.Text = "-"
        Me.btDelTurmas.UseVisualStyleBackColor = True
        '
        'lbTurmas
        '
        Me.lbTurmas.FormattingEnabled = True
        Me.lbTurmas.Location = New System.Drawing.Point(9, 49)
        Me.lbTurmas.Name = "lbTurmas"
        Me.lbTurmas.Size = New System.Drawing.Size(126, 82)
        Me.lbTurmas.TabIndex = 0
        '
        'btAddTurmas
        '
        Me.btAddTurmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAddTurmas.Location = New System.Drawing.Point(140, 19)
        Me.btAddTurmas.Name = "btAddTurmas"
        Me.btAddTurmas.Size = New System.Drawing.Size(24, 23)
        Me.btAddTurmas.TabIndex = 9
        Me.btAddTurmas.Text = "+"
        Me.btAddTurmas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbDrivers)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.pNao)
        Me.GroupBox3.Controls.Add(Me.pSim)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(76, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 55)
        Me.GroupBox3.TabIndex = 195
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Escolha o drive"
        '
        'cbDrivers
        '
        Me.cbDrivers.DisplayMember = "Text"
        Me.cbDrivers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDrivers.FormattingEnabled = True
        Me.cbDrivers.ItemHeight = 16
        Me.cbDrivers.Location = New System.Drawing.Point(56, 20)
        Me.cbDrivers.Name = "cbDrivers"
        Me.cbDrivers.Size = New System.Drawing.Size(59, 22)
        Me.cbDrivers.TabIndex = 209
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(149, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "disponível."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 14)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "Disco:"
        '
        'pNao
        '
        Me.pNao.Image = Global.Mais_Escola.My.Resources.Resources.nOK
        Me.pNao.Location = New System.Drawing.Point(121, 20)
        Me.pNao.Name = "pNao"
        Me.pNao.Size = New System.Drawing.Size(20, 20)
        Me.pNao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pNao.TabIndex = 202
        Me.pNao.TabStop = False
        '
        'pSim
        '
        Me.pSim.Image = Global.Mais_Escola.My.Resources.Resources.OK
        Me.pSim.Location = New System.Drawing.Point(121, 20)
        Me.pSim.Name = "pSim"
        Me.pSim.Size = New System.Drawing.Size(20, 20)
        Me.pSim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pSim.TabIndex = 200
        Me.pSim.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 185)
        Me.ShapeContainer1.TabIndex = 196
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 399
        Me.LineShape1.X2 = 399
        Me.LineShape1.Y1 = 15
        Me.LineShape1.Y2 = 168
        '
        'cbMail
        '
        Me.cbMail.AutoSize = True
        Me.cbMail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMail.Location = New System.Drawing.Point(12, 97)
        Me.cbMail.Name = "cbMail"
        Me.cbMail.Size = New System.Drawing.Size(165, 16)
        Me.cbMail.TabIndex = 202
        Me.cbMail.Text = "Envio de notas por e-mail"
        '
        'cbAlunos
        '
        Me.cbAlunos.AutoSize = True
        Me.cbAlunos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlunos.Location = New System.Drawing.Point(12, 117)
        Me.cbAlunos.Name = "cbAlunos"
        Me.cbAlunos.Size = New System.Drawing.Size(186, 16)
        Me.cbAlunos.TabIndex = 203
        Me.cbAlunos.Text = "Carregar Situação dos Alunos"
        '
        'cbAvancadas
        '
        Me.cbAvancadas.AutoSize = True
        Me.cbAvancadas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAvancadas.Location = New System.Drawing.Point(12, 77)
        Me.cbAvancadas.Name = "cbAvancadas"
        Me.cbAvancadas.Size = New System.Drawing.Size(114, 16)
        Me.cbAvancadas.TabIndex = 204
        Me.cbAvancadas.Text = "Opção Avançada"
        '
        'btCarregar
        '
        Me.btCarregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btCarregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btCarregar.Enabled = False
        Me.btCarregar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCarregar.Location = New System.Drawing.Point(307, 122)
        Me.btCarregar.Name = "btCarregar"
        Me.btCarregar.Size = New System.Drawing.Size(75, 23)
        Me.btCarregar.TabIndex = 205
        Me.btCarregar.Text = "Carregar!"
        '
        'btRefazer
        '
        Me.btRefazer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btRefazer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btRefazer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefazer.Location = New System.Drawing.Point(226, 151)
        Me.btRefazer.Name = "btRefazer"
        Me.btRefazer.Size = New System.Drawing.Size(75, 23)
        Me.btRefazer.TabIndex = 206
        Me.btRefazer.Text = "Refazer!"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(307, 151)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 207
        Me.btFechar.Text = "Fechar"
        '
        'btAvancado
        '
        Me.btAvancado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAvancado.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAvancado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAvancado.Location = New System.Drawing.Point(700, 151)
        Me.btAvancado.Name = "btAvancado"
        Me.btAvancado.Size = New System.Drawing.Size(75, 23)
        Me.btAvancado.TabIndex = 208
        Me.btAvancado.Text = "Carregar"
        '
        'pBarra
        '
        Me.pBarra.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pBarra.ForeColor = System.Drawing.Color.Black
        Me.pBarra.Location = New System.Drawing.Point(12, 151)
        Me.pBarra.Name = "pBarra"
        Me.pBarra.Size = New System.Drawing.Size(205, 23)
        Me.pBarra.TabIndex = 209
        Me.pBarra.TextVisible = True
        '
        'frmImpBoletim2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 185)
        Me.Controls.Add(Me.pBarra)
        Me.Controls.Add(Me.btAvancado)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.btRefazer)
        Me.Controls.Add(Me.btCarregar)
        Me.Controls.Add(Me.cbAvancadas)
        Me.Controls.Add(Me.cbAlunos)
        Me.Controls.Add(Me.cbMail)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmImpBoletim2"
        Me.ShowInTaskbar = False
        Me.Text = "Boletim Móvel - Preparar Disquete!"
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pNao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pSim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btDelDisciplinas As System.Windows.Forms.Button
    Friend WithEvents lbDisciplinas As System.Windows.Forms.ListBox
    Friend WithEvents btAddDisciplinas As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btDelTurmas As System.Windows.Forms.Button
    Friend WithEvents lbTurmas As System.Windows.Forms.ListBox
    Friend WithEvents btAddTurmas As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents pSim As System.Windows.Forms.PictureBox
    Friend WithEvents pNao As System.Windows.Forms.PictureBox
    Friend WithEvents cbMail As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbAlunos As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbAvancadas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btCarregar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btRefazer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAvancado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbDrivers As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbDisciplina As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents pBarra As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
