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
        Me.Label1 = New System.Windows.Forms.Label
        Me.btAdicionar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tbPeriodo = New System.Windows.Forms.ComboBox
        Me.tAlunos = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.tAnoVigente = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.check = New System.Windows.Forms.CheckBox
        Me.tbCodigo = New System.Windows.Forms.ComboBox
        Me.fundamental = New System.Windows.Forms.CheckBox
        Me.tbClasse = New System.Windows.Forms.ComboBox
        CType(Me.tAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Período:"
        '
        'btAdicionar
        '
        Me.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(80, 147)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(96, 22)
        Me.btAdicionar.TabIndex = 145
        Me.btAdicionar.Text = "Alterar"
        Me.btAdicionar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Classe:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Código:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(220, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 22)
        Me.Button1.TabIndex = 148
        Me.Button1.Text = "Excluir"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'tbPeriodo
        '
        Me.tbPeriodo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbPeriodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tbPeriodo.FormattingEnabled = True
        Me.tbPeriodo.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.tbPeriodo.Location = New System.Drawing.Point(98, 60)
        Me.tbPeriodo.Name = "tbPeriodo"
        Me.tbPeriodo.Size = New System.Drawing.Size(124, 21)
        Me.tbPeriodo.TabIndex = 150
        '
        'tAlunos
        '
        Me.tAlunos.Location = New System.Drawing.Point(150, 88)
        Me.tAlunos.Name = "tAlunos"
        Me.tAlunos.Size = New System.Drawing.Size(40, 20)
        Me.tAlunos.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 14)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Total de Alunos:"
        '
        'tAnoVigente
        '
        Me.tAnoVigente.Location = New System.Drawing.Point(150, 113)
        Me.tAnoVigente.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.tAnoVigente.Name = "tAnoVigente"
        Me.tAnoVigente.Size = New System.Drawing.Size(51, 20)
        Me.tAnoVigente.TabIndex = 156
        Me.tAnoVigente.Value = New Decimal(New Integer() {2007, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 14)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Ano vigente:"
        '
        'check
        '
        Me.check.AutoSize = True
        Me.check.Location = New System.Drawing.Point(150, 2)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(77, 17)
        Me.check.TabIndex = 157
        Me.check.Text = "Bloqueado"
        Me.check.UseVisualStyleBackColor = True
        '
        'tbCodigo
        '
        Me.tbCodigo.FormattingEnabled = True
        Me.tbCodigo.Location = New System.Drawing.Point(98, 13)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(44, 21)
        Me.tbCodigo.TabIndex = 159
        '
        'fundamental
        '
        Me.fundamental.AutoSize = True
        Me.fundamental.Location = New System.Drawing.Point(150, 19)
        Me.fundamental.Name = "fundamental"
        Me.fundamental.Size = New System.Drawing.Size(87, 17)
        Me.fundamental.TabIndex = 160
        Me.fundamental.Text = "Fundamental"
        Me.fundamental.UseVisualStyleBackColor = True
        '
        'tbClasse
        '
        Me.tbClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tbClasse.FormattingEnabled = True
        Me.tbClasse.Location = New System.Drawing.Point(98, 37)
        Me.tbClasse.Name = "tbClasse"
        Me.tbClasse.Size = New System.Drawing.Size(124, 21)
        Me.tbClasse.TabIndex = 161
        '
        'frmManTurma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 180)
        Me.Controls.Add(Me.tbClasse)
        Me.Controls.Add(Me.fundamental)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.tAnoVigente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tAlunos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPeriodo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmManTurma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Turma - Manutenção"
        CType(Me.tAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btAdicionar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents tAlunos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tAnoVigente As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents check As System.Windows.Forms.CheckBox
    Friend WithEvents tbCodigo As System.Windows.Forms.ComboBox
    Friend WithEvents fundamental As System.Windows.Forms.CheckBox
    Friend WithEvents tbClasse As System.Windows.Forms.ComboBox
End Class
