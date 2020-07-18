<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGDAEMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGDAEMenu))
        Me.cbTurma = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbDisciplina = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.btContinuar = New DevComponents.DotNetBar.ButtonX
        Me.btProcessar = New DevComponents.DotNetBar.ButtonX
        Me.DGBoletim = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtP = New System.Windows.Forms.Label
        Me.txtT = New System.Windows.Forms.Label
        Me.cbManual = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbAF = New DevComponents.DotNetBar.Controls.CheckBoxX
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTurma
        '
        Me.cbTurma.DisplayMember = "Text"
        Me.cbTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.ItemHeight = 15
        Me.cbTurma.Location = New System.Drawing.Point(93, 38)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(147, 21)
        Me.cbTurma.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Turma:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Disciplina:"
        '
        'cbDisciplina
        '
        Me.cbDisciplina.DisplayMember = "Text"
        Me.cbDisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.ItemHeight = 15
        Me.cbDisciplina.Location = New System.Drawing.Point(93, 65)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(147, 21)
        Me.cbDisciplina.TabIndex = 2
        '
        'tBimestre
        '
        Me.tBimestre.Location = New System.Drawing.Point(94, 92)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(35, 21)
        Me.tBimestre.TabIndex = 5
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Bimestre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Ano:"
        '
        'tAno
        '
        Me.tAno.Location = New System.Drawing.Point(93, 11)
        Me.tAno.Maximum = New Decimal(New Integer() {2099, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {2008, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(63, 21)
        Me.tAno.TabIndex = 70
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2008, 0, 0, 0})
        '
        'btContinuar
        '
        Me.btContinuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btContinuar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btContinuar.Location = New System.Drawing.Point(172, 130)
        Me.btContinuar.Name = "btContinuar"
        Me.btContinuar.Size = New System.Drawing.Size(75, 23)
        Me.btContinuar.TabIndex = 92
        Me.btContinuar.Text = "Continuar"
        '
        'btProcessar
        '
        Me.btProcessar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btProcessar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btProcessar.Location = New System.Drawing.Point(171, 405)
        Me.btProcessar.Name = "btProcessar"
        Me.btProcessar.Size = New System.Drawing.Size(75, 23)
        Me.btProcessar.TabIndex = 94
        Me.btProcessar.Text = "Processar!"
        '
        'DGBoletim
        '
        Me.DGBoletim.AllowUserToAddRows = False
        Me.DGBoletim.AllowUserToDeleteRows = False
        Me.DGBoletim.AllowUserToResizeColumns = False
        Me.DGBoletim.AllowUserToResizeRows = False
        Me.DGBoletim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBoletim.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGBoletim.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGBoletim.Location = New System.Drawing.Point(5, 159)
        Me.DGBoletim.Name = "DGBoletim"
        Me.DGBoletim.ReadOnly = True
        Me.DGBoletim.Size = New System.Drawing.Size(241, 240)
        Me.DGBoletim.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Previstas:"
        '
        'txtP
        '
        Me.txtP.AutoSize = True
        Me.txtP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP.ForeColor = System.Drawing.Color.Blue
        Me.txtP.Location = New System.Drawing.Point(146, 410)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(23, 13)
        Me.txtP.TabIndex = 102
        Me.txtP.Text = "00"
        '
        'txtT
        '
        Me.txtT.AutoSize = True
        Me.txtT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT.ForeColor = System.Drawing.Color.Blue
        Me.txtT.Location = New System.Drawing.Point(49, 410)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(23, 13)
        Me.txtT.TabIndex = 101
        Me.txtT.Text = "00"
        '
        'cbManual
        '
        Me.cbManual.AutoSize = True
        Me.cbManual.Location = New System.Drawing.Point(12, 130)
        Me.cbManual.Name = "cbManual"
        Me.cbManual.Size = New System.Drawing.Size(104, 16)
        Me.cbManual.TabIndex = 105
        Me.cbManual.Text = "Excluir Alunos!"
        Me.cbManual.Visible = False
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Enabled = False
        Me.cbAF.Location = New System.Drawing.Point(136, 95)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(105, 16)
        Me.cbAF.TabIndex = 106
        Me.cbAF.Text = "Avaliação Final"
        '
        'frmGDAEMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 433)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.cbManual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.txtT)
        Me.Controls.Add(Me.DGBoletim)
        Me.Controls.Add(Me.btProcessar)
        Me.Controls.Add(Me.btContinuar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbTurma)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGDAEMenu"
        Me.ShowInTaskbar = False
        Me.Text = "Mais Escola - Menu GDAE"
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDisciplina As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents btContinuar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btProcessar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DGBoletim As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtP As System.Windows.Forms.Label
    Friend WithEvents txtT As System.Windows.Forms.Label
    Friend WithEvents cbManual As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbAF As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
