<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadBoletimTela
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadBoletimTela))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbAF = New DevExpress.XtraEditors.CheckEdit()
        Me.cbTurma = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbDisciplina = New DevExpress.XtraEditors.LookUpEdit()
        Me.tBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.tQtdade = New DevExpress.XtraEditors.SpinEdit()
        Me.pQtdade = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.cbAF.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbTurma.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbDisciplina.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tBimestre.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tQtdade.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pQtdade.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Disciplina:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Turma:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bimestre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ano:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(184, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Aulas dadas:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(164, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Aulas Previstas:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(244, 119)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "Continuar!"
        '
        'cbAF
        '
        Me.cbAF.Location = New System.Drawing.Point(21, 123)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Properties.Caption = "Avaliação Final"
        Me.cbAF.Size = New System.Drawing.Size(105, 19)
        Me.cbAF.TabIndex = 13
        '
        'cbTurma
        '
        Me.cbTurma.EditValue = ""
        Me.cbTurma.Location = New System.Drawing.Point(91, 14)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurma.Properties.NullText = ""
        Me.cbTurma.Size = New System.Drawing.Size(228, 20)
        Me.cbTurma.TabIndex = 14
        '
        'cbDisciplina
        '
        Me.cbDisciplina.EditValue = ""
        Me.cbDisciplina.Location = New System.Drawing.Point(91, 40)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDisciplina.Properties.NullText = ""
        Me.cbDisciplina.Size = New System.Drawing.Size(228, 20)
        Me.cbDisciplina.TabIndex = 15
        '
        'tBimestre
        '
        Me.tBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Location = New System.Drawing.Point(91, 67)
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tBimestre.Properties.IsFloatValue = false
        Me.tBimestre.Properties.Mask.EditMask = "N00"
        Me.tBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Size = New System.Drawing.Size(38, 20)
        Me.tBimestre.TabIndex = 16
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(91, 92)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = false
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(52, 20)
        Me.tAno.TabIndex = 17
        '
        'tQtdade
        '
        Me.tQtdade.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.tQtdade.Location = New System.Drawing.Point(275, 69)
        Me.tQtdade.Name = "tQtdade"
        Me.tQtdade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tQtdade.Properties.IsFloatValue = false
        Me.tQtdade.Properties.Mask.EditMask = "N00"
        Me.tQtdade.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.tQtdade.Size = New System.Drawing.Size(44, 20)
        Me.tQtdade.TabIndex = 18
        '
        'pQtdade
        '
        Me.pQtdade.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.pQtdade.Location = New System.Drawing.Point(275, 91)
        Me.pQtdade.Name = "pQtdade"
        Me.pQtdade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pQtdade.Properties.IsFloatValue = false
        Me.pQtdade.Properties.Mask.EditMask = "N00"
        Me.pQtdade.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.pQtdade.Size = New System.Drawing.Size(44, 20)
        Me.pQtdade.TabIndex = 19
        '
        'frmCadBoletimTela
        '
        Me.Appearance.Options.UseFont = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(339, 151)
        Me.Controls.Add(Me.pQtdade)
        Me.Controls.Add(Me.tQtdade)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmCadBoletimTela"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas e Frequências! - Cadastro"
        CType(Me.cbAF.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbTurma.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbDisciplina.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tBimestre.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tQtdade.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pQtdade.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbTurma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbDisciplina As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tBimestre As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tQtdade As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents pQtdade As DevExpress.XtraEditors.SpinEdit
End Class
