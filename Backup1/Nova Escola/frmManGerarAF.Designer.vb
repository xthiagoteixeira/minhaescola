<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManGerarAF
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
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.pbBar = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.cb1bimestre = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cb2bimestre = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cb3bimestre = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cb4bimestre = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btEfetuar = New DevComponents.DotNetBar.ButtonX
        Me.btFinalizar = New DevComponents.DotNetBar.ButtonX
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(272, 19)
        Me.tAno.Maximum = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(56, 21)
        Me.tAno.TabIndex = 163
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2008, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(236, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 14)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Ano:"
        '
        'cbTurma
        '
        Me.cbTurma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbTurma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cbTurma.Location = New System.Drawing.Point(70, 19)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(147, 21)
        Me.cbTurma.TabIndex = 159
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 14)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "Turma:"
        '
        'pbBar
        '
        Me.pbBar.Location = New System.Drawing.Point(22, 97)
        Me.pbBar.Name = "pbBar"
        Me.pbBar.Size = New System.Drawing.Size(303, 23)
        Me.pbBar.TabIndex = 181
        Me.pbBar.Text = "ProgressBarX1"
        '
        'cb1bimestre
        '
        Me.cb1bimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1bimestre.Location = New System.Drawing.Point(75, 46)
        Me.cb1bimestre.Name = "cb1bimestre"
        Me.cb1bimestre.Size = New System.Drawing.Size(99, 23)
        Me.cb1bimestre.TabIndex = 183
        Me.cb1bimestre.Text = "1º bimestre"
        '
        'cb2bimestre
        '
        Me.cb2bimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2bimestre.Location = New System.Drawing.Point(75, 69)
        Me.cb2bimestre.Name = "cb2bimestre"
        Me.cb2bimestre.Size = New System.Drawing.Size(99, 23)
        Me.cb2bimestre.TabIndex = 184
        Me.cb2bimestre.Text = "2º bimestre"
        '
        'cb3bimestre
        '
        Me.cb3bimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb3bimestre.Location = New System.Drawing.Point(192, 46)
        Me.cb3bimestre.Name = "cb3bimestre"
        Me.cb3bimestre.Size = New System.Drawing.Size(98, 23)
        Me.cb3bimestre.TabIndex = 185
        Me.cb3bimestre.Text = "3º bimestre"
        '
        'cb4bimestre
        '
        Me.cb4bimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb4bimestre.Location = New System.Drawing.Point(192, 69)
        Me.cb4bimestre.Name = "cb4bimestre"
        Me.cb4bimestre.Size = New System.Drawing.Size(98, 23)
        Me.cb4bimestre.TabIndex = 186
        Me.cb4bimestre.Text = "4º bimestre"
        '
        'btEfetuar
        '
        Me.btEfetuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEfetuar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEfetuar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEfetuar.Location = New System.Drawing.Point(22, 130)
        Me.btEfetuar.Name = "btEfetuar"
        Me.btEfetuar.Size = New System.Drawing.Size(75, 23)
        Me.btEfetuar.TabIndex = 187
        Me.btEfetuar.Text = "Efetuar"
        '
        'btFinalizar
        '
        Me.btFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFinalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFinalizar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFinalizar.Location = New System.Drawing.Point(250, 130)
        Me.btFinalizar.Name = "btFinalizar"
        Me.btFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btFinalizar.TabIndex = 188
        Me.btFinalizar.Text = "Finalizar"
        '
        'frmManGerarAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 163)
        Me.Controls.Add(Me.btFinalizar)
        Me.Controls.Add(Me.btEfetuar)
        Me.Controls.Add(Me.cb4bimestre)
        Me.Controls.Add(Me.cb3bimestre)
        Me.Controls.Add(Me.cb2bimestre)
        Me.Controls.Add(Me.cb1bimestre)
        Me.Controls.Add(Me.pbBar)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmManGerarAF"
        Me.ShowInTaskbar = False
        Me.Text = "Manutenção - Gerar Avaliação Final"
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pbBar As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents cb1bimestre As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cb2bimestre As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cb3bimestre As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cb4bimestre As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btEfetuar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFinalizar As DevComponents.DotNetBar.ButtonX
End Class
