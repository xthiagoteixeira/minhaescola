<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBolsas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbBVJ = New System.Windows.Forms.RadioButton
        Me.rbBF = New System.Windows.Forms.RadioButton
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.tBimestre = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.pBarra = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.GroupPanel1.SuspendLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbBVJ
        '
        Me.rbBVJ.AutoSize = True
        Me.rbBVJ.BackColor = System.Drawing.Color.Transparent
        Me.rbBVJ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBVJ.Location = New System.Drawing.Point(12, 27)
        Me.rbBVJ.Name = "rbBVJ"
        Me.rbBVJ.Size = New System.Drawing.Size(148, 17)
        Me.rbBVJ.TabIndex = 163
        Me.rbBVJ.TabStop = True
        Me.rbBVJ.Text = "Bolsa Variável Jovem"
        Me.rbBVJ.UseVisualStyleBackColor = False
        '
        'rbBF
        '
        Me.rbBF.AutoSize = True
        Me.rbBF.BackColor = System.Drawing.Color.Transparent
        Me.rbBF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBF.Location = New System.Drawing.Point(12, 5)
        Me.rbBF.Name = "rbBF"
        Me.rbBF.Size = New System.Drawing.Size(100, 17)
        Me.rbBF.TabIndex = 162
        Me.rbBF.TabStop = True
        Me.rbBF.Text = "Bolsa Família"
        Me.rbBF.UseVisualStyleBackColor = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rbBVJ)
        Me.GroupPanel1.Controls.Add(Me.rbBF)
        Me.GroupPanel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(7, 7)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(174, 71)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 164
        Me.GroupPanel1.Text = "Escolha uma opção"
        '
        'tBimestre
        '
        Me.tBimestre.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Location = New System.Drawing.Point(269, 25)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(40, 21)
        Me.tBimestre.TabIndex = 166
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Bimestre:"
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(254, 52)
        Me.tAno.Maximum = New Decimal(New Integer() {2800, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {2007, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(55, 21)
        Me.tAno.TabIndex = 168
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Ano:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(115, 86)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(115, 23)
        Me.ButtonX1.TabIndex = 169
        Me.ButtonX1.Text = "Gerar Relatório"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(236, 86)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.TabIndex = 170
        Me.ButtonX2.Text = "Fechar"
        '
        'pBarra
        '
        Me.pBarra.Location = New System.Drawing.Point(7, 86)
        Me.pBarra.Name = "pBarra"
        Me.pBarra.Size = New System.Drawing.Size(102, 23)
        Me.pBarra.TabIndex = 171
        Me.pBarra.Text = "ProgressBarX1"
        '
        'frmBolsas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 118)
        Me.Controls.Add(Me.pBarra)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBolsas"
        Me.Text = "Mais Escola - Bolsa Escolar"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbBVJ As System.Windows.Forms.RadioButton
    Friend WithEvents rbBF As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pBarra As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
