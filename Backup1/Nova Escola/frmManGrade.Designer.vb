<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManGrade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManGrade))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbAno = New System.Windows.Forms.Label
        Me.lbBimestre = New System.Windows.Forms.Label
        Me.lbTurma = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btAtualizar = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.tbAC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbSN = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbFaltas = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbMedia = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbDisciplinas = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lBoletins = New System.Windows.Forms.Label
        Me.DGBoletim = New System.Windows.Forms.DataGrid
        Me.LbCodigo = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbAno)
        Me.GroupBox1.Controls.Add(Me.lbBimestre)
        Me.GroupBox1.Controls.Add(Me.lbTurma)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados da Turma"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(353, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Ano:"
        '
        'lbAno
        '
        Me.lbAno.AutoSize = True
        Me.lbAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAno.ForeColor = System.Drawing.Color.Blue
        Me.lbAno.Location = New System.Drawing.Point(389, 23)
        Me.lbAno.Name = "lbAno"
        Me.lbAno.Size = New System.Drawing.Size(39, 13)
        Me.lbAno.TabIndex = 4
        Me.lbAno.Text = "2009"
        '
        'lbBimestre
        '
        Me.lbBimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBimestre.ForeColor = System.Drawing.Color.Blue
        Me.lbBimestre.Location = New System.Drawing.Point(210, 23)
        Me.lbBimestre.Name = "lbBimestre"
        Me.lbBimestre.Size = New System.Drawing.Size(23, 13)
        Me.lbBimestre.TabIndex = 3
        Me.lbBimestre.Text = "00"
        Me.lbBimestre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTurma
        '
        Me.lbTurma.AutoSize = True
        Me.lbTurma.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTurma.ForeColor = System.Drawing.Color.Blue
        Me.lbTurma.Location = New System.Drawing.Point(79, 23)
        Me.lbTurma.Name = "lbTurma"
        Me.lbTurma.Size = New System.Drawing.Size(95, 13)
        Me.lbTurma.TabIndex = 2
        Me.lbTurma.Text = "XXXXXXXXXXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "o. Bimestre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Turma:"
        '
        'btAtualizar
        '
        Me.btAtualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAtualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAtualizar.Enabled = False
        Me.btAtualizar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtualizar.Location = New System.Drawing.Point(281, 394)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btAtualizar.TabIndex = 5
        Me.btAtualizar.Text = "Atualizar"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Location = New System.Drawing.Point(438, 394)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 23)
        Me.btFechar.TabIndex = 6
        Me.btFechar.Text = "Fechar"
        '
        'tbAC
        '
        Me.tbAC.Enabled = False
        Me.tbAC.Location = New System.Drawing.Point(410, 361)
        Me.tbAC.Name = "tbAC"
        Me.tbAC.Size = New System.Drawing.Size(37, 20)
        Me.tbAC.TabIndex = 171
        Me.tbAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 14)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "AC"
        '
        'tbSN
        '
        Me.tbSN.Enabled = False
        Me.tbSN.Location = New System.Drawing.Point(476, 361)
        Me.tbSN.Name = "tbSN"
        Me.tbSN.Size = New System.Drawing.Size(37, 20)
        Me.tbSN.TabIndex = 167
        Me.tbSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(481, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 14)
        Me.Label3.TabIndex = 170
        Me.Label3.Text = "PR"
        '
        'tbFaltas
        '
        Me.tbFaltas.Enabled = False
        Me.tbFaltas.Location = New System.Drawing.Point(346, 361)
        Me.tbFaltas.Name = "tbFaltas"
        Me.tbFaltas.Size = New System.Drawing.Size(37, 20)
        Me.tbFaltas.TabIndex = 166
        Me.tbFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(353, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 14)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "FT"
        '
        'tbMedia
        '
        Me.tbMedia.Enabled = False
        Me.tbMedia.Location = New System.Drawing.Point(281, 361)
        Me.tbMedia.Name = "tbMedia"
        Me.tbMedia.Size = New System.Drawing.Size(37, 20)
        Me.tbMedia.TabIndex = 165
        Me.tbMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 14)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "AV"
        '
        'cbDisciplinas
        '
        Me.cbDisciplinas.DisplayMember = "Text"
        Me.cbDisciplinas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDisciplinas.FormattingEnabled = True
        Me.cbDisciplinas.ItemHeight = 15
        Me.cbDisciplinas.Location = New System.Drawing.Point(81, 54)
        Me.cbDisciplinas.Name = "cbDisciplinas"
        Me.cbDisciplinas.Size = New System.Drawing.Size(117, 21)
        Me.cbDisciplinas.TabIndex = 174
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 175
        Me.Label7.Text = "Disciplina:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbDisciplinas)
        Me.GroupBox2.Controls.Add(Me.lBoletins)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 92)
        Me.GroupBox2.TabIndex = 176
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Situação Atual"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "boletins encontrados"
        '
        'lBoletins
        '
        Me.lBoletins.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lBoletins.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBoletins.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lBoletins.Location = New System.Drawing.Point(26, 28)
        Me.lBoletins.Name = "lBoletins"
        Me.lBoletins.Size = New System.Drawing.Size(23, 13)
        Me.lBoletins.TabIndex = 0
        Me.lBoletins.Text = "00"
        Me.lBoletins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DGBoletim
        '
        Me.DGBoletim.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DGBoletim.BackColor = System.Drawing.Color.Gainsboro
        Me.DGBoletim.BackgroundColor = System.Drawing.Color.Silver
        Me.DGBoletim.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGBoletim.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DGBoletim.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DGBoletim.DataMember = ""
        Me.DGBoletim.FlatMode = True
        Me.DGBoletim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DGBoletim.ForeColor = System.Drawing.Color.Black
        Me.DGBoletim.GridLineColor = System.Drawing.Color.DimGray
        Me.DGBoletim.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DGBoletim.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DGBoletim.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DGBoletim.HeaderForeColor = System.Drawing.Color.White
        Me.DGBoletim.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DGBoletim.Location = New System.Drawing.Point(12, 60)
        Me.DGBoletim.Name = "DGBoletim"
        Me.DGBoletim.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.DGBoletim.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGBoletim.ReadOnly = True
        Me.DGBoletim.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DGBoletim.SelectionForeColor = System.Drawing.Color.White
        Me.DGBoletim.Size = New System.Drawing.Size(531, 259)
        Me.DGBoletim.TabIndex = 177
        '
        'LbCodigo
        '
        Me.LbCodigo.AutoSize = True
        Me.LbCodigo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodigo.ForeColor = System.Drawing.Color.Blue
        Me.LbCodigo.Location = New System.Drawing.Point(250, 364)
        Me.LbCodigo.Name = "LbCodigo"
        Me.LbCodigo.Size = New System.Drawing.Size(16, 14)
        Me.LbCodigo.TabIndex = 178
        Me.LbCodigo.Text = "1"
        '
        'frmManGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 429)
        Me.Controls.Add(Me.LbCodigo)
        Me.Controls.Add(Me.DGBoletim)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tbAC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbSN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbFaltas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbMedia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.btAtualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmManGrade"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção - Notas e Frequências"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbBimestre As System.Windows.Forms.Label
    Friend WithEvents lbTurma As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btAtualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbAC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbSN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbFaltas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbMedia As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbDisciplinas As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbAno As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lBoletins As System.Windows.Forms.Label
    Friend WithEvents DGBoletim As System.Windows.Forms.DataGrid
    Friend WithEvents LbCodigo As System.Windows.Forms.Label
End Class
