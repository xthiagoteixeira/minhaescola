<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerencialDCL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerencialDCL))
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.rb3 = New System.Windows.Forms.RadioButton
        Me.rb4 = New System.Windows.Forms.RadioButton
        Me.rb5 = New System.Windows.Forms.RadioButton
        Me.rb6 = New System.Windows.Forms.RadioButton
        Me.rb7 = New System.Windows.Forms.RadioButton
        Me.rb8 = New System.Windows.Forms.RadioButton
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.HorarioFIM = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
        Me.HorarioINICIO = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
        Me.Label7 = New System.Windows.Forms.Label
        Me.gpAluno = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lbNome = New System.Windows.Forms.Label
        Me.pbProcurar = New System.Windows.Forms.PictureBox
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbCodigo = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbNome = New System.Windows.Forms.TextBox
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.gpAluno.SuspendLayout()
        CType(Me.pbProcurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(218, 173)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(187, 17)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "Matrícula do Aluno - Regular"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(218, 196)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(213, 17)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "Matrícula do Aluno - Não Regular"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.Location = New System.Drawing.Point(218, 219)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(202, 17)
        Me.rb3.TabIndex = 2
        Me.rb3.TabStop = True
        Me.rb3.Text = "Matrícula do Aluno - Conclusão"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.Location = New System.Drawing.Point(28, 173)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(137, 17)
        Me.rb4.TabIndex = 3
        Me.rb4.TabStop = True
        Me.rb4.Text = "Solicitação de Vaga"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb5.Location = New System.Drawing.Point(28, 196)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(103, 17)
        Me.rb5.TabIndex = 4
        Me.rb5.TabStop = True
        Me.rb5.Text = "Transferência"
        Me.rb5.UseVisualStyleBackColor = True
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb6.Location = New System.Drawing.Point(28, 219)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(173, 17)
        Me.rb6.TabIndex = 5
        Me.rb6.TabStop = True
        Me.rb6.Text = "Dependências - Cursando"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'rb7
        '
        Me.rb7.AutoSize = True
        Me.rb7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb7.Location = New System.Drawing.Point(28, 242)
        Me.rb7.Name = "rb7"
        Me.rb7.Size = New System.Drawing.Size(177, 17)
        Me.rb7.TabIndex = 6
        Me.rb7.TabStop = True
        Me.rb7.Text = "Dependências - Conclusão"
        Me.rb7.UseVisualStyleBackColor = True
        '
        'rb8
        '
        Me.rb8.AutoSize = True
        Me.rb8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb8.Location = New System.Drawing.Point(218, 242)
        Me.rb8.Name = "rb8"
        Me.rb8.Size = New System.Drawing.Size(284, 17)
        Me.rb8.TabIndex = 8
        Me.rb8.TabStop = True
        Me.rb8.Text = "Matrícula do Aluno - Efetuada e/ou Renovada"
        Me.rb8.UseVisualStyleBackColor = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.GroupPanel2)
        Me.GroupPanel1.Controls.Add(Me.gpAluno)
        Me.GroupPanel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(483, 154)
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
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 9
        Me.GroupPanel1.Text = "Informações"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.HorarioFIM)
        Me.GroupPanel2.Controls.Add(Me.HorarioINICIO)
        Me.GroupPanel2.Controls.Add(Me.Label7)
        Me.GroupPanel2.Location = New System.Drawing.Point(336, 10)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(129, 109)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 164
        Me.GroupPanel2.Text = "Horário"
        '
        'HorarioFIM
        '
        '
        '
        '
        Me.HorarioFIM.BackgroundStyle.Class = "TextBoxBorder"
        Me.HorarioFIM.ButtonClear.Visible = True
        Me.HorarioFIM.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.HorarioFIM.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorarioFIM.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.HorarioFIM.Location = New System.Drawing.Point(15, 60)
        Me.HorarioFIM.Mask = "00:00"
        Me.HorarioFIM.Name = "HorarioFIM"
        Me.HorarioFIM.Size = New System.Drawing.Size(94, 21)
        Me.HorarioFIM.TabIndex = 167
        Me.HorarioFIM.Text = ""
        Me.HorarioFIM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HorarioFIM.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.HorarioFIM.ValidatingType = GetType(Date)
        '
        'HorarioINICIO
        '
        '
        '
        '
        Me.HorarioINICIO.BackgroundStyle.Class = "TextBoxBorder"
        Me.HorarioINICIO.ButtonClear.Visible = True
        Me.HorarioINICIO.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.HorarioINICIO.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorarioINICIO.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.HorarioINICIO.Location = New System.Drawing.Point(15, 3)
        Me.HorarioINICIO.Mask = "00:00"
        Me.HorarioINICIO.Name = "HorarioINICIO"
        Me.HorarioINICIO.Size = New System.Drawing.Size(94, 21)
        Me.HorarioINICIO.TabIndex = 166
        Me.HorarioINICIO.Text = ""
        Me.HorarioINICIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HorarioINICIO.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.HorarioINICIO.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "às"
        '
        'gpAluno
        '
        Me.gpAluno.BackColor = System.Drawing.Color.Transparent
        Me.gpAluno.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpAluno.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpAluno.Controls.Add(Me.lbNome)
        Me.gpAluno.Controls.Add(Me.pbProcurar)
        Me.gpAluno.Controls.Add(Me.tAno)
        Me.gpAluno.Controls.Add(Me.Label3)
        Me.gpAluno.Controls.Add(Me.Label2)
        Me.gpAluno.Controls.Add(Me.tbCodigo)
        Me.gpAluno.Controls.Add(Me.Label5)
        Me.gpAluno.Controls.Add(Me.tbNome)
        Me.gpAluno.Controls.Add(Me.cbTurma)
        Me.gpAluno.Controls.Add(Me.Label1)
        Me.gpAluno.IsShadowEnabled = True
        Me.gpAluno.Location = New System.Drawing.Point(13, 10)
        Me.gpAluno.Name = "gpAluno"
        Me.gpAluno.Size = New System.Drawing.Size(309, 110)
        '
        '
        '
        Me.gpAluno.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpAluno.Style.BackColorGradientAngle = 90
        Me.gpAluno.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpAluno.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAluno.Style.BorderBottomWidth = 1
        Me.gpAluno.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpAluno.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAluno.Style.BorderLeftWidth = 1
        Me.gpAluno.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAluno.Style.BorderRightWidth = 1
        Me.gpAluno.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpAluno.Style.BorderTopWidth = 1
        Me.gpAluno.Style.CornerDiameter = 4
        Me.gpAluno.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpAluno.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpAluno.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpAluno.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpAluno.TabIndex = 163
        Me.gpAluno.Text = "Aluno Matriculado"
        '
        'lbNome
        '
        Me.lbNome.BackColor = System.Drawing.Color.White
        Me.lbNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbNome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNome.ForeColor = System.Drawing.Color.Blue
        Me.lbNome.Location = New System.Drawing.Point(51, 61)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(151, 17)
        Me.lbNome.TabIndex = 201
        Me.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbProcurar
        '
        Me.pbProcurar.Image = Global.Mais_Escola.My.Resources.Resources.lupa_melhor
        Me.pbProcurar.Location = New System.Drawing.Point(277, 36)
        Me.pbProcurar.Name = "pbProcurar"
        Me.pbProcurar.Size = New System.Drawing.Size(19, 16)
        Me.pbProcurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbProcurar.TabIndex = 200
        Me.pbProcurar.TabStop = False
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Location = New System.Drawing.Point(242, 60)
        Me.tAno.Maximum = New Decimal(New Integer() {2800, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(54, 21)
        Me.tAno.TabIndex = 164
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Ano:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 14)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Nro:"
        '
        'tbCodigo
        '
        Me.tbCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo.Location = New System.Drawing.Point(39, 7)
        Me.tbCodigo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(39, 21)
        Me.tbCodigo.TabIndex = 161
        Me.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbCodigo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "Nome:"
        '
        'tbNome
        '
        Me.tbNome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNome.Location = New System.Drawing.Point(51, 33)
        Me.tbNome.Name = "tbNome"
        Me.tbNome.Size = New System.Drawing.Size(221, 21)
        Me.tbNome.TabIndex = 157
        '
        'cbTurma
        '
        Me.cbTurma.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Location = New System.Drawing.Point(162, 6)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(134, 21)
        Me.cbTurma.TabIndex = 159
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Turma:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(251, 265)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(118, 23)
        Me.ButtonX1.TabIndex = 10
        Me.ButtonX1.Text = "Emitir Relatório"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(375, 265)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(118, 23)
        Me.ButtonX2.TabIndex = 11
        Me.ButtonX2.Text = "Fechar"
        '
        'frmGerencialDCL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 293)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.rb8)
        Me.Controls.Add(Me.rb7)
        Me.Controls.Add(Me.rb6)
        Me.Controls.Add(Me.rb5)
        Me.Controls.Add(Me.rb4)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGerencialDCL"
        Me.ShowInTaskbar = False
        Me.Text = "Mais Escola! - Declaração"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.gpAluno.ResumeLayout(False)
        Me.gpAluno.PerformLayout()
        CType(Me.pbProcurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents rb6 As System.Windows.Forms.RadioButton
    Friend WithEvents rb7 As System.Windows.Forms.RadioButton
    Friend WithEvents rb8 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gpAluno As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCodigo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNome As System.Windows.Forms.TextBox
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HorarioFIM As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents HorarioINICIO As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents pbProcurar As System.Windows.Forms.PictureBox
    Friend WithEvents lbNome As System.Windows.Forms.Label
End Class
