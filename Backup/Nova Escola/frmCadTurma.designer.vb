<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadturma
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
        Me.tbTurma = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbCodigo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbPeriodo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tAlunos = New System.Windows.Forms.NumericUpDown
        Me.tAnoVigente = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.tAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btAdicionar
        '
        Me.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(117, 129)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(96, 22)
        Me.btAdicionar.TabIndex = 138
        Me.btAdicionar.Text = "Adicionar"
        Me.btAdicionar.UseVisualStyleBackColor = True
        '
        'tbTurma
        '
        Me.tbTurma.Location = New System.Drawing.Point(102, 29)
        Me.tbTurma.Name = "tbTurma"
        Me.tbTurma.Size = New System.Drawing.Size(159, 20)
        Me.tbTurma.TabIndex = 130
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Classe:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.Location = New System.Drawing.Point(108, 9)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lbCodigo.TabIndex = 128
        Me.lbCodigo.Text = "0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Código:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Período:"
        '
        'tbPeriodo
        '
        Me.tbPeriodo.FormattingEnabled = True
        Me.tbPeriodo.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.tbPeriodo.Location = New System.Drawing.Point(114, 52)
        Me.tbPeriodo.Name = "tbPeriodo"
        Me.tbPeriodo.Size = New System.Drawing.Size(147, 21)
        Me.tbPeriodo.TabIndex = 140
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 14)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Total de Alunos:"
        '
        'tAlunos
        '
        Me.tAlunos.Location = New System.Drawing.Point(205, 77)
        Me.tAlunos.Name = "tAlunos"
        Me.tAlunos.Size = New System.Drawing.Size(39, 20)
        Me.tAlunos.TabIndex = 142
        '
        'tAnoVigente
        '
        Me.tAnoVigente.Location = New System.Drawing.Point(188, 103)
        Me.tAnoVigente.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.tAnoVigente.Name = "tAnoVigente"
        Me.tAnoVigente.Size = New System.Drawing.Size(56, 20)
        Me.tAnoVigente.TabIndex = 144
        Me.tAnoVigente.Value = New Decimal(New Integer() {2007, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 14)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Ano vigente:"
        '
        'frmCadturma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 163)
        Me.Controls.Add(Me.tAnoVigente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tAlunos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.tbTurma)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCadturma"
        Me.Text = "Turma - Cadastro"
        CType(Me.tAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAnoVigente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAdicionar As System.Windows.Forms.Button
    Friend WithEvents tbTurma As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tAlunos As System.Windows.Forms.NumericUpDown
    Friend WithEvents tAnoVigente As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
