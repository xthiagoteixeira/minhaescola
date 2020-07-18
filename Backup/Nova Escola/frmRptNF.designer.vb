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
        Me.btAdicionar = New System.Windows.Forms.Button
        Me.cbDisciplina = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btAdicionar
        '
        Me.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(119, 88)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(96, 22)
        Me.btAdicionar.TabIndex = 138
        Me.btAdicionar.Text = "Continuar"
        Me.btAdicionar.UseVisualStyleBackColor = True
        '
        'cbDisciplina
        '
        Me.cbDisciplina.FormattingEnabled = True
        Me.cbDisciplina.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cbDisciplina.Location = New System.Drawing.Point(110, 43)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Size = New System.Drawing.Size(147, 21)
        Me.cbDisciplina.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Disciplina:"
        '
        'cbTurma
        '
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cbTurma.Location = New System.Drawing.Point(110, 16)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(147, 21)
        Me.cbTurma.TabIndex = 144
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 14)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Turma:"
        '
        'frmRptNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 120)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAdicionar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRptNF"
        Me.Text = "Boletim - Relatório"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAdicionar As System.Windows.Forms.Button
    Friend WithEvents cbDisciplina As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
