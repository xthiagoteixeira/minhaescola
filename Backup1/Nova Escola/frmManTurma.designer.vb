<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManTurma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManTurma))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbPeriodo = New System.Windows.Forms.ComboBox
        Me.tAlunos = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.tAnoVigente = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbBloqueia = New System.Windows.Forms.CheckBox
        Me.fundamental = New System.Windows.Forms.CheckBox
        Me.tbClasse = New System.Windows.Forms.ComboBox
        Me.tbCodigo = New System.Windows.Forms.Label
        Me.btEfetuar = New DevComponents.DotNetBar.ButtonX
        Me.DGTurma = New System.Windows.Forms.DataGridView
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.pbCodigoCon = New System.Windows.Forms.PictureBox
        Me.pbCodigoCad = New System.Windows.Forms.PictureBox
        CType(Me.tAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGTurma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCodigoCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCodigoCad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Período:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(298, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Classe:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Código:"
        '
        'tbPeriodo
        '
        Me.tbPeriodo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbPeriodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tbPeriodo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPeriodo.FormattingEnabled = True
        Me.tbPeriodo.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.tbPeriodo.Location = New System.Drawing.Point(355, 65)
        Me.tbPeriodo.Name = "tbPeriodo"
        Me.tbPeriodo.Size = New System.Drawing.Size(124, 21)
        Me.tbPeriodo.TabIndex = 150
        '
        'tAlunos
        '
        Me.tAlunos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAlunos.Location = New System.Drawing.Point(434, 93)
        Me.tAlunos.Name = "tAlunos"
        Me.tAlunos.Size = New System.Drawing.Size(40, 21)
        Me.tAlunos.TabIndex = 153
        Me.tAlunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 14)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Total de Alunos:"
        '
        'tAnoVigente
        '
        Me.tAnoVigente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAnoVigente.Location = New System.Drawing.Point(434, 118)
        Me.tAnoVigente.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.tAnoVigente.Name = "tAnoVigente"
        Me.tAnoVigente.Size = New System.Drawing.Size(59, 21)
        Me.tAnoVigente.TabIndex = 156
        Me.tAnoVigente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAnoVigente.Value = New Decimal(New Integer() {2008, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 14)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Ano vigente:"
        '
        'cbBloqueia
        '
        Me.cbBloqueia.AutoSize = True
        Me.cbBloqueia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBloqueia.Location = New System.Drawing.Point(410, 7)
        Me.cbBloqueia.Name = "cbBloqueia"
        Me.cbBloqueia.Size = New System.Drawing.Size(86, 17)
        Me.cbBloqueia.TabIndex = 157
        Me.cbBloqueia.Text = "Bloqueado"
        Me.cbBloqueia.UseVisualStyleBackColor = True
        '
        'fundamental
        '
        Me.fundamental.AutoSize = True
        Me.fundamental.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fundamental.Location = New System.Drawing.Point(410, 24)
        Me.fundamental.Name = "fundamental"
        Me.fundamental.Size = New System.Drawing.Size(118, 17)
        Me.fundamental.TabIndex = 160
        Me.fundamental.Text = "Ciclo I (1a - 4a)"
        Me.fundamental.UseVisualStyleBackColor = True
        '
        'tbClasse
        '
        Me.tbClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tbClasse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClasse.FormattingEnabled = True
        Me.tbClasse.Location = New System.Drawing.Point(355, 42)
        Me.tbClasse.Name = "tbClasse"
        Me.tbClasse.Size = New System.Drawing.Size(124, 21)
        Me.tbClasse.TabIndex = 161
        '
        'tbCodigo
        '
        Me.tbCodigo.AutoSize = True
        Me.tbCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.tbCodigo.Location = New System.Drawing.Point(352, 21)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(23, 13)
        Me.tbCodigo.TabIndex = 162
        Me.tbCodigo.Text = "00"
        '
        'btEfetuar
        '
        Me.btEfetuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEfetuar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEfetuar.Enabled = False
        Me.btEfetuar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEfetuar.Location = New System.Drawing.Point(331, 150)
        Me.btEfetuar.Name = "btEfetuar"
        Me.btEfetuar.Size = New System.Drawing.Size(75, 23)
        Me.btEfetuar.TabIndex = 163
        Me.btEfetuar.Text = "Efetuar"
        '
        'DGTurma
        '
        Me.DGTurma.AllowUserToAddRows = False
        Me.DGTurma.AllowUserToDeleteRows = False
        Me.DGTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTurma.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGTurma.Location = New System.Drawing.Point(0, 0)
        Me.DGTurma.Name = "DGTurma"
        Me.DGTurma.ReadOnly = True
        Me.DGTurma.Size = New System.Drawing.Size(283, 180)
        Me.DGTurma.TabIndex = 164
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(417, 150)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.TabIndex = 165
        Me.ButtonX1.Text = "Fechar"
        '
        'pbCodigoCon
        '
        Me.pbCodigoCon.Image = CType(resources.GetObject("pbCodigoCon.Image"), System.Drawing.Image)
        Me.pbCodigoCon.Location = New System.Drawing.Point(381, 19)
        Me.pbCodigoCon.Name = "pbCodigoCon"
        Me.pbCodigoCon.Size = New System.Drawing.Size(20, 17)
        Me.pbCodigoCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCodigoCon.TabIndex = 231
        Me.pbCodigoCon.TabStop = False
        '
        'pbCodigoCad
        '
        Me.pbCodigoCad.Image = CType(resources.GetObject("pbCodigoCad.Image"), System.Drawing.Image)
        Me.pbCodigoCad.Location = New System.Drawing.Point(381, 19)
        Me.pbCodigoCad.Name = "pbCodigoCad"
        Me.pbCodigoCad.Size = New System.Drawing.Size(20, 17)
        Me.pbCodigoCad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCodigoCad.TabIndex = 232
        Me.pbCodigoCad.TabStop = False
        '
        'frmManTurma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 180)
        Me.Controls.Add(Me.pbCodigoCon)
        Me.Controls.Add(Me.pbCodigoCad)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.DGTurma)
        Me.Controls.Add(Me.btEfetuar)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.tbClasse)
        Me.Controls.Add(Me.fundamental)
        Me.Controls.Add(Me.cbBloqueia)
        Me.Controls.Add(Me.tAnoVigente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tAlunos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmManTurma"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Turma - Manutenção"
        CType(Me.tAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGTurma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCodigoCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCodigoCad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents tAlunos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tAnoVigente As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbBloqueia As System.Windows.Forms.CheckBox
    Friend WithEvents fundamental As System.Windows.Forms.CheckBox
    Friend WithEvents tbClasse As System.Windows.Forms.ComboBox
    Friend WithEvents tbCodigo As System.Windows.Forms.Label
    Friend WithEvents btEfetuar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DGTurma As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pbCodigoCon As System.Windows.Forms.PictureBox
    Friend WithEvents pbCodigoCad As System.Windows.Forms.PictureBox
End Class
