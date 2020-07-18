<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManAC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManAC))
        Me.tbMedia = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbFaltas = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbSN = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbDisciplina = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbTurma = New System.Windows.Forms.Label
        Me.lbDisc = New System.Windows.Forms.Label
        Me.lBoletim = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbBoletim = New System.Windows.Forms.Label
        Me.tbAC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.qtdade = New System.Windows.Forms.Label
        Me.lbCodigo = New System.Windows.Forms.NumericUpDown
        Me.btAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.Button1 = New DevComponents.DotNetBar.ButtonX
        CType(Me.lbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbMedia
        '
        Me.tbMedia.Location = New System.Drawing.Point(113, 128)
        Me.tbMedia.Name = "tbMedia"
        Me.tbMedia.Size = New System.Drawing.Size(37, 20)
        Me.tbMedia.TabIndex = 0
        Me.tbMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 14)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "AV"
        '
        'tbFaltas
        '
        Me.tbFaltas.Location = New System.Drawing.Point(183, 128)
        Me.tbFaltas.Name = "tbFaltas"
        Me.tbFaltas.Size = New System.Drawing.Size(37, 20)
        Me.tbFaltas.TabIndex = 1
        Me.tbFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 14)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "FT"
        '
        'tbSN
        '
        Me.tbSN.Location = New System.Drawing.Point(327, 128)
        Me.tbSN.Name = "tbSN"
        Me.tbSN.Size = New System.Drawing.Size(37, 20)
        Me.tbSN.TabIndex = 2
        Me.tbSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 14)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "PR"
        '
        'lbDisciplina
        '
        Me.lbDisciplina.AutoSize = True
        Me.lbDisciplina.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisciplina.Location = New System.Drawing.Point(155, 29)
        Me.lbDisciplina.Name = "lbDisciplina"
        Me.lbDisciplina.Size = New System.Drawing.Size(205, 14)
        Me.lbDisciplina.TabIndex = 144
        Me.lbDisciplina.Text = "0000000000000000000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(86, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 14)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Disciplina:"
        '
        'lbTurma
        '
        Me.lbTurma.AutoSize = True
        Me.lbTurma.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTurma.ForeColor = System.Drawing.Color.Blue
        Me.lbTurma.Location = New System.Drawing.Point(155, 60)
        Me.lbTurma.Name = "lbTurma"
        Me.lbTurma.Size = New System.Drawing.Size(79, 14)
        Me.lbTurma.TabIndex = 149
        Me.lbTurma.Text = "00000000"
        '
        'lbDisc
        '
        Me.lbDisc.AutoSize = True
        Me.lbDisc.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisc.Location = New System.Drawing.Point(105, 60)
        Me.lbDisc.Name = "lbDisc"
        Me.lbDisc.Size = New System.Drawing.Size(51, 14)
        Me.lbDisc.TabIndex = 148
        Me.lbDisc.Text = "Turma:"
        '
        'lBoletim
        '
        Me.lBoletim.AutoSize = True
        Me.lBoletim.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBoletim.ForeColor = System.Drawing.Color.Blue
        Me.lBoletim.Location = New System.Drawing.Point(334, 60)
        Me.lBoletim.Name = "lBoletim"
        Me.lBoletim.Size = New System.Drawing.Size(25, 14)
        Me.lBoletim.TabIndex = 151
        Me.lBoletim.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(269, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 14)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Bimestre:"
        '
        'lbBoletim
        '
        Me.lbBoletim.AutoSize = True
        Me.lbBoletim.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoletim.ForeColor = System.Drawing.Color.Blue
        Me.lbBoletim.Location = New System.Drawing.Point(377, 9)
        Me.lbBoletim.Name = "lbBoletim"
        Me.lbBoletim.Size = New System.Drawing.Size(25, 14)
        Me.lbBoletim.TabIndex = 152
        Me.lbBoletim.Text = "00"
        Me.lbBoletim.Visible = False
        '
        'tbAC
        '
        Me.tbAC.Location = New System.Drawing.Point(253, 128)
        Me.tbAC.Name = "tbAC"
        Me.tbAC.Size = New System.Drawing.Size(37, 20)
        Me.tbAC.TabIndex = 1
        Me.tbAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 14)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "AC"
        '
        'qtdade
        '
        Me.qtdade.AutoSize = True
        Me.qtdade.Location = New System.Drawing.Point(377, 187)
        Me.qtdade.Name = "qtdade"
        Me.qtdade.Size = New System.Drawing.Size(19, 13)
        Me.qtdade.TabIndex = 159
        Me.qtdade.Text = "00"
        Me.qtdade.Visible = False
        '
        'lbCodigo
        '
        Me.lbCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.Location = New System.Drawing.Point(63, 127)
        Me.lbCodigo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(42, 21)
        Me.lbCodigo.TabIndex = 160
        Me.lbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lbCodigo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btAdicionar
        '
        Me.btAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(109, 171)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btAdicionar.TabIndex = 161
        Me.btAdicionar.Text = "Alterar"
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(245, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 162
        Me.Button1.Text = "Finalizar"
        '
        'frmManAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 209)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.qtdade)
        Me.Controls.Add(Me.tbAC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbBoletim)
        Me.Controls.Add(Me.lBoletim)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbTurma)
        Me.Controls.Add(Me.lbDisc)
        Me.Controls.Add(Me.lbDisciplina)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFaltas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMedia)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmManAC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boletim - Manutenção"
        CType(Me.lbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMedia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbFaltas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbDisciplina As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbTurma As System.Windows.Forms.Label
    Friend WithEvents lbDisc As System.Windows.Forms.Label
    Friend WithEvents lBoletim As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbBoletim As System.Windows.Forms.Label
    Friend WithEvents tbAC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents qtdade As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.NumericUpDown
    Friend WithEvents btAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Button1 As DevComponents.DotNetBar.ButtonX
End Class
