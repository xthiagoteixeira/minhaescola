<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManFundamental2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManFundamental2))
        Me.tbMedia = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbSN = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbDisciplina = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbTurma = New System.Windows.Forms.Label
        Me.lbDisc = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbNF = New System.Windows.Forms.Label
        Me.lBoletim = New System.Windows.Forms.Label
        Me.qtdade = New System.Windows.Forms.Label
        Me.lbCodigo = New System.Windows.Forms.NumericUpDown
        Me.btAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.btFinalizar = New DevComponents.DotNetBar.ButtonX
        CType(Me.lbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbMedia
        '
        Me.tbMedia.Location = New System.Drawing.Point(200, 129)
        Me.tbMedia.Name = "tbMedia"
        Me.tbMedia.Size = New System.Drawing.Size(37, 20)
        Me.tbMedia.TabIndex = 0
        Me.tbMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 14)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "AV"
        '
        'tbSN
        '
        Me.tbSN.Location = New System.Drawing.Point(276, 129)
        Me.tbSN.Name = "tbSN"
        Me.tbSN.Size = New System.Drawing.Size(37, 20)
        Me.tbSN.TabIndex = 2
        Me.tbSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 14)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "PR"
        '
        'lbDisciplina
        '
        Me.lbDisciplina.AutoSize = True
        Me.lbDisciplina.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisciplina.Location = New System.Drawing.Point(154, 30)
        Me.lbDisciplina.Name = "lbDisciplina"
        Me.lbDisciplina.Size = New System.Drawing.Size(205, 14)
        Me.lbDisciplina.TabIndex = 144
        Me.lbDisciplina.Text = "0000000000000000000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(85, 30)
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
        Me.lbTurma.Location = New System.Drawing.Point(154, 61)
        Me.lbTurma.Name = "lbTurma"
        Me.lbTurma.Size = New System.Drawing.Size(79, 14)
        Me.lbTurma.TabIndex = 149
        Me.lbTurma.Text = "00000000"
        '
        'lbDisc
        '
        Me.lbDisc.AutoSize = True
        Me.lbDisc.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisc.Location = New System.Drawing.Point(104, 61)
        Me.lbDisc.Name = "lbDisc"
        Me.lbDisc.Size = New System.Drawing.Size(51, 14)
        Me.lbDisc.TabIndex = 148
        Me.lbDisc.Text = "Turma:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(268, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 14)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Bimestre:"
        '
        'lbNF
        '
        Me.lbNF.AutoSize = True
        Me.lbNF.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNF.ForeColor = System.Drawing.Color.Blue
        Me.lbNF.Location = New System.Drawing.Point(406, 30)
        Me.lbNF.Name = "lbNF"
        Me.lbNF.Size = New System.Drawing.Size(25, 14)
        Me.lbNF.TabIndex = 152
        Me.lbNF.Text = "00"
        Me.lbNF.Visible = False
        '
        'lBoletim
        '
        Me.lBoletim.AutoSize = True
        Me.lBoletim.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBoletim.ForeColor = System.Drawing.Color.Blue
        Me.lBoletim.Location = New System.Drawing.Point(333, 61)
        Me.lBoletim.Name = "lBoletim"
        Me.lBoletim.Size = New System.Drawing.Size(16, 14)
        Me.lBoletim.TabIndex = 151
        Me.lBoletim.Text = "5"
        '
        'qtdade
        '
        Me.qtdade.AutoSize = True
        Me.qtdade.Location = New System.Drawing.Point(388, 197)
        Me.qtdade.Name = "qtdade"
        Me.qtdade.Size = New System.Drawing.Size(19, 13)
        Me.qtdade.TabIndex = 154
        Me.qtdade.Text = "00"
        Me.qtdade.Visible = False
        '
        'lbCodigo
        '
        Me.lbCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.Location = New System.Drawing.Point(138, 129)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(43, 21)
        Me.lbCodigo.TabIndex = 166
        Me.lbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lbCodigo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btAdicionar
        '
        Me.btAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(115, 175)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btAdicionar.TabIndex = 167
        Me.btAdicionar.Text = "Alterar"
        '
        'btFinalizar
        '
        Me.btFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFinalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFinalizar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFinalizar.Location = New System.Drawing.Point(260, 175)
        Me.btFinalizar.Name = "btFinalizar"
        Me.btFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btFinalizar.TabIndex = 168
        Me.btFinalizar.Text = "Finalizar"
        '
        'frmManFundamental2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 235)
        Me.Controls.Add(Me.btFinalizar)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.qtdade)
        Me.Controls.Add(Me.lbNF)
        Me.Controls.Add(Me.lBoletim)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbTurma)
        Me.Controls.Add(Me.lbDisc)
        Me.Controls.Add(Me.lbDisciplina)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbMedia)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmManFundamental2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boletim - Notas e Freqüências"
        CType(Me.lbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMedia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbSN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbDisciplina As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbTurma As System.Windows.Forms.Label
    Friend WithEvents lbDisc As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbNF As System.Windows.Forms.Label
    Friend WithEvents lBoletim As System.Windows.Forms.Label
    Friend WithEvents qtdade As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.NumericUpDown
    Friend WithEvents btAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFinalizar As DevComponents.DotNetBar.ButtonX
End Class
