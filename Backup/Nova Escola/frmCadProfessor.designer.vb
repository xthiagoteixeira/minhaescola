<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProfessor
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
        Me.tbProfessor = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbCodigo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.nroAluno = New System.Windows.Forms.NumericUpDown
        CType(Me.nroAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btAdicionar
        '
        Me.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(117, 117)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(96, 22)
        Me.btAdicionar.TabIndex = 138
        Me.btAdicionar.Text = "Adicionar"
        Me.btAdicionar.UseVisualStyleBackColor = True
        '
        'tbProfessor
        '
        Me.tbProfessor.Location = New System.Drawing.Point(120, 45)
        Me.tbProfessor.Name = "tbProfessor"
        Me.tbProfessor.Size = New System.Drawing.Size(147, 20)
        Me.tbProfessor.TabIndex = 130
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Nome:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.Location = New System.Drawing.Point(123, 23)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lbCodigo.TabIndex = 128
        Me.lbCodigo.Text = "0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Código:"
        '
        'cbTurma
        '
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Location = New System.Drawing.Point(120, 71)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(147, 21)
        Me.cbTurma.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Turma:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Nro:"
        '
        'nroAluno
        '
        Me.nroAluno.Location = New System.Drawing.Point(231, 20)
        Me.nroAluno.Name = "nroAluno"
        Me.nroAluno.Size = New System.Drawing.Size(35, 20)
        Me.nroAluno.TabIndex = 144
        '
        'frmCadProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 148)
        Me.Controls.Add(Me.nroAluno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.tbProfessor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCadProfessor"
        Me.Text = "Aluno - Cadastro"
        CType(Me.nroAluno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAdicionar As System.Windows.Forms.Button
    Friend WithEvents tbProfessor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nroAluno As System.Windows.Forms.NumericUpDown
End Class
