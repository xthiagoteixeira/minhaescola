<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadBoletim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadBoletim))
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
        Me.qtdadeaulas = New System.Windows.Forms.Label
        Me.lbCodigo = New System.Windows.Forms.Label
        Me.travaC = New System.Windows.Forms.Label
        Me.btAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.btVoltar = New DevComponents.DotNetBar.ButtonX
        Me.btFinalizar = New DevComponents.DotNetBar.ButtonX
        Me.exibeR = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.SuspendLayout()
        '
        'tbMedia
        '
        Me.tbMedia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMedia.Location = New System.Drawing.Point(153, 126)
        Me.tbMedia.Name = "tbMedia"
        Me.tbMedia.Size = New System.Drawing.Size(37, 21)
        Me.tbMedia.TabIndex = 0
        Me.tbMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 14)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "AV"
        '
        'tbFaltas
        '
        Me.tbFaltas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFaltas.Location = New System.Drawing.Point(223, 126)
        Me.tbFaltas.Name = "tbFaltas"
        Me.tbFaltas.Size = New System.Drawing.Size(37, 21)
        Me.tbFaltas.TabIndex = 1
        Me.tbFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 14)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "FT"
        '
        'tbSN
        '
        Me.tbSN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSN.Location = New System.Drawing.Point(292, 126)
        Me.tbSN.Name = "tbSN"
        Me.tbSN.Size = New System.Drawing.Size(37, 21)
        Me.tbSN.TabIndex = 2
        Me.tbSN.Text = "N"
        Me.tbSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 14)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "PR"
        '
        'lbDisciplina
        '
        Me.lbDisciplina.AutoSize = True
        Me.lbDisciplina.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisciplina.Location = New System.Drawing.Point(151, 27)
        Me.lbDisciplina.Name = "lbDisciplina"
        Me.lbDisciplina.Size = New System.Drawing.Size(205, 14)
        Me.lbDisciplina.TabIndex = 144
        Me.lbDisciplina.Text = "0000000000000000000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 27)
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
        Me.lbTurma.Location = New System.Drawing.Point(151, 58)
        Me.lbTurma.Name = "lbTurma"
        Me.lbTurma.Size = New System.Drawing.Size(79, 14)
        Me.lbTurma.TabIndex = 149
        Me.lbTurma.Text = "00000000"
        '
        'lbDisc
        '
        Me.lbDisc.AutoSize = True
        Me.lbDisc.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisc.Location = New System.Drawing.Point(101, 58)
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
        Me.lBoletim.Location = New System.Drawing.Point(330, 58)
        Me.lBoletim.Name = "lBoletim"
        Me.lBoletim.Size = New System.Drawing.Size(25, 14)
        Me.lBoletim.TabIndex = 151
        Me.lBoletim.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(265, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 14)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Bimestre:"
        '
        'lbBoletim
        '
        Me.lbBoletim.AutoSize = True
        Me.lbBoletim.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoletim.ForeColor = System.Drawing.Color.Black
        Me.lbBoletim.Location = New System.Drawing.Point(403, 27)
        Me.lbBoletim.Name = "lbBoletim"
        Me.lbBoletim.Size = New System.Drawing.Size(25, 14)
        Me.lbBoletim.TabIndex = 152
        Me.lbBoletim.Text = "00"
        Me.lbBoletim.Visible = False
        '
        'qtdadeaulas
        '
        Me.qtdadeaulas.AutoSize = True
        Me.qtdadeaulas.Location = New System.Drawing.Point(402, 204)
        Me.qtdadeaulas.Name = "qtdadeaulas"
        Me.qtdadeaulas.Size = New System.Drawing.Size(25, 13)
        Me.qtdadeaulas.TabIndex = 155
        Me.qtdadeaulas.Text = "000"
        Me.qtdadeaulas.Visible = False
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.ForeColor = System.Drawing.Color.Blue
        Me.lbCodigo.Location = New System.Drawing.Point(122, 129)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(16, 14)
        Me.lbCodigo.TabIndex = 156
        Me.lbCodigo.Text = "1"
        '
        'travaC
        '
        Me.travaC.AutoSize = True
        Me.travaC.Location = New System.Drawing.Point(403, 105)
        Me.travaC.Name = "travaC"
        Me.travaC.Size = New System.Drawing.Size(13, 13)
        Me.travaC.TabIndex = 159
        Me.travaC.Text = "0"
        Me.travaC.Visible = False
        '
        'btAdicionar
        '
        Me.btAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAdicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(134, 168)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btAdicionar.TabIndex = 3
        Me.btAdicionar.Text = "Adicionar"
        '
        'btVoltar
        '
        Me.btVoltar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btVoltar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btVoltar.Enabled = False
        Me.btVoltar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVoltar.Location = New System.Drawing.Point(215, 168)
        Me.btVoltar.Name = "btVoltar"
        Me.btVoltar.Size = New System.Drawing.Size(30, 23)
        Me.btVoltar.TabIndex = 4
        Me.btVoltar.Text = "<"
        '
        'btFinalizar
        '
        Me.btFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFinalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFinalizar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFinalizar.Location = New System.Drawing.Point(251, 168)
        Me.btFinalizar.Name = "btFinalizar"
        Me.btFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btFinalizar.TabIndex = 5
        Me.btFinalizar.Text = "Finalizar"
        '
        'exibeR
        '
        Me.exibeR.AutoSize = True
        Me.exibeR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exibeR.Location = New System.Drawing.Point(156, 201)
        Me.exibeR.Name = "exibeR"
        Me.exibeR.Size = New System.Drawing.Size(148, 16)
        Me.exibeR.TabIndex = 168
        Me.exibeR.Text = "Exibir relatório no final"
        '
        'frmCadBoletim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 224)
        Me.Controls.Add(Me.exibeR)
        Me.Controls.Add(Me.btFinalizar)
        Me.Controls.Add(Me.btVoltar)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.travaC)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.qtdadeaulas)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadBoletim"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boletim - Cadastro"
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
    Friend WithEvents qtdadeaulas As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    Friend WithEvents travaC As System.Windows.Forms.Label
    Friend WithEvents btAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btVoltar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFinalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents exibeR As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
