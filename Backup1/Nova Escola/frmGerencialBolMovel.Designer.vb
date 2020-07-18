<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerencialBolMovel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerencialBolMovel))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label2 = New System.Windows.Forms.Label
        Me.btMenos = New DevComponents.DotNetBar.ButtonX
        Me.btMais = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbDisciplina = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbAF = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.DGGrupo = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.GroupBox1.SuspendLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(108, 128)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Imprimir"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.Location = New System.Drawing.Point(211, 308)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX3.TabIndex = 2
        Me.ButtonX3.Text = "Fechar"
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 15
        Me.cbTurma.Location = New System.Drawing.Point(60, 50)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(196, 21)
        Me.cbTurma.TabIndex = 168
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Turma:"
        '
        'btMenos
        '
        Me.btMenos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btMenos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btMenos.Enabled = False
        Me.btMenos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenos.Location = New System.Drawing.Point(262, 128)
        Me.btMenos.Name = "btMenos"
        Me.btMenos.Size = New System.Drawing.Size(24, 23)
        Me.btMenos.TabIndex = 163
        Me.btMenos.Text = "-"
        '
        'btMais
        '
        Me.btMais.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btMais.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btMais.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMais.Location = New System.Drawing.Point(12, 128)
        Me.btMais.Name = "btMais"
        Me.btMais.Size = New System.Drawing.Size(24, 23)
        Me.btMais.TabIndex = 162
        Me.btMais.Text = "+"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbDisciplina)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbAF)
        Me.GroupBox1.Controls.Add(Me.tBimestre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tAno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbTurma)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 109)
        Me.GroupBox1.TabIndex = 164
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escolha um grupo:"
        '
        'cbDisciplina
        '
        Me.cbDisciplina.DisplayMember = "Text"
        Me.cbDisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDisciplina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.ItemHeight = 15
        Me.cbDisciplina.Location = New System.Drawing.Point(79, 80)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(177, 21)
        Me.cbDisciplina.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Disciplina:"
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Location = New System.Drawing.Point(232, 24)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(36, 16)
        Me.cbAF.TabIndex = 173
        Me.cbAF.Text = "AF"
        '
        'tBimestre
        '
        Me.tBimestre.Location = New System.Drawing.Point(191, 20)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(38, 21)
        Me.tBimestre.TabIndex = 172
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "Bimestre:"
        '
        'tAno
        '
        Me.tAno.Location = New System.Drawing.Point(60, 20)
        Me.tAno.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {2007, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(53, 21)
        Me.tAno.TabIndex = 170
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 14)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Ano:"
        '
        'DGGrupo
        '
        Me.DGGrupo.AllowUserToAddRows = False
        Me.DGGrupo.AllowUserToDeleteRows = False
        Me.DGGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGGrupo.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGGrupo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGGrupo.Location = New System.Drawing.Point(12, 159)
        Me.DGGrupo.Name = "DGGrupo"
        Me.DGGrupo.ReadOnly = True
        Me.DGGrupo.Size = New System.Drawing.Size(274, 142)
        Me.DGGrupo.TabIndex = 165
        '
        'frmGerencialBolMovel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 339)
        Me.Controls.Add(Me.DGGrupo)
        Me.Controls.Add(Me.btMenos)
        Me.Controls.Add(Me.btMais)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGerencialBolMovel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gerenciar Boletim Móvel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btMenos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btMais As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbAF As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbDisciplina As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGGrupo As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
