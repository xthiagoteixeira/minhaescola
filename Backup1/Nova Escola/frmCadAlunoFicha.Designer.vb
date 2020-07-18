<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadAlunoFicha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadAlunoFicha))
        Me.tbCodigo = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTurma = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbAluno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.gpAluno = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.tAno = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.rbIncluir = New System.Windows.Forms.RadioButton
        Me.rbAlterar = New System.Windows.Forms.RadioButton
        Me.btEfetuar = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.txtEndereco = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbPesquisar = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtRG = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCidade = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtBairro = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtEstado = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCep = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtFone = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPai = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtMae = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtRM = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.rbAtivo = New System.Windows.Forms.RadioButton
        Me.rbTransferido = New System.Windows.Forms.RadioButton
        Me.rbDesistencia = New System.Windows.Forms.RadioButton
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtDataDesistencia = New System.Windows.Forms.MaskedTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMotivo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtFolhas = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtLivro = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtObservacao = New System.Windows.Forms.RichTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lbLancamento = New System.Windows.Forms.Label
        Me.rbMasculino = New System.Windows.Forms.RadioButton
        Me.rbFeminino = New System.Windows.Forms.RadioButton
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.DGComplemento = New System.Windows.Forms.DataGridView
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtNascimento = New System.Windows.Forms.MaskedTextBox
        CType(Me.tbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpAluno.SuspendLayout()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.DGComplemento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'tbAluno
        '
        Me.tbAluno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAluno.Location = New System.Drawing.Point(51, 33)
        Me.tbAluno.Name = "tbAluno"
        Me.tbAluno.Size = New System.Drawing.Size(245, 21)
        Me.tbAluno.TabIndex = 157
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
        'gpAluno
        '
        Me.gpAluno.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpAluno.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpAluno.Controls.Add(Me.tAno)
        Me.gpAluno.Controls.Add(Me.Label3)
        Me.gpAluno.Controls.Add(Me.Label2)
        Me.gpAluno.Controls.Add(Me.tbCodigo)
        Me.gpAluno.Controls.Add(Me.Label5)
        Me.gpAluno.Controls.Add(Me.tbAluno)
        Me.gpAluno.Controls.Add(Me.cbTurma)
        Me.gpAluno.Controls.Add(Me.Label1)
        Me.gpAluno.IsShadowEnabled = True
        Me.gpAluno.Location = New System.Drawing.Point(12, 12)
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
        Me.gpAluno.TabIndex = 162
        Me.gpAluno.Text = "Aluno Matriculado"
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
        'rbIncluir
        '
        Me.rbIncluir.AutoSize = True
        Me.rbIncluir.Location = New System.Drawing.Point(351, 43)
        Me.rbIncluir.Name = "rbIncluir"
        Me.rbIncluir.Size = New System.Drawing.Size(71, 20)
        Me.rbIncluir.TabIndex = 163
        Me.rbIncluir.TabStop = True
        Me.rbIncluir.Text = "Incluir!"
        Me.rbIncluir.UseVisualStyleBackColor = True
        Me.rbIncluir.Visible = False
        '
        'rbAlterar
        '
        Me.rbAlterar.AutoSize = True
        Me.rbAlterar.Location = New System.Drawing.Point(351, 61)
        Me.rbAlterar.Name = "rbAlterar"
        Me.rbAlterar.Size = New System.Drawing.Size(88, 20)
        Me.rbAlterar.TabIndex = 164
        Me.rbAlterar.TabStop = True
        Me.rbAlterar.Text = "Atualizar!"
        Me.rbAlterar.UseVisualStyleBackColor = True
        '
        'btEfetuar
        '
        Me.btEfetuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEfetuar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEfetuar.Location = New System.Drawing.Point(473, 54)
        Me.btEfetuar.Name = "btEfetuar"
        Me.btEfetuar.Size = New System.Drawing.Size(75, 23)
        Me.btEfetuar.TabIndex = 166
        Me.btEfetuar.Text = "Efetuar!"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(473, 80)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.TabIndex = 167
        Me.ButtonX2.Text = "Fechar"
        '
        'txtEndereco
        '
        '
        '
        '
        Me.txtEndereco.Border.Class = "TextBoxBorder"
        Me.txtEndereco.Location = New System.Drawing.Point(87, 164)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(279, 23)
        Me.txtEndereco.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Endereço:"
        '
        'rbPesquisar
        '
        Me.rbPesquisar.AutoSize = True
        Me.rbPesquisar.Location = New System.Drawing.Point(351, 78)
        Me.rbPesquisar.Name = "rbPesquisar"
        Me.rbPesquisar.Size = New System.Drawing.Size(93, 20)
        Me.rbPesquisar.TabIndex = 171
        Me.rbPesquisar.TabStop = True
        Me.rbPesquisar.Text = "Pesquisar!"
        Me.rbPesquisar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 14)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "RM:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(173, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 14)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "RG:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtRG
        '
        '
        '
        '
        Me.txtRG.Border.Class = "TextBoxBorder"
        Me.txtRG.Location = New System.Drawing.Point(202, 255)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(92, 23)
        Me.txtRG.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "Cidade:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCidade
        '
        '
        '
        '
        Me.txtCidade.Border.Class = "TextBoxBorder"
        Me.txtCidade.Location = New System.Drawing.Point(87, 212)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(160, 23)
        Me.txtCidade.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 182
        Me.Label10.Text = "Dta Nasc.:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 14)
        Me.Label11.TabIndex = 184
        Me.Label11.Text = "Bairro:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBairro
        '
        '
        '
        '
        Me.txtBairro.Border.Class = "TextBoxBorder"
        Me.txtBairro.Location = New System.Drawing.Point(87, 188)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(155, 23)
        Me.txtBairro.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(251, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 14)
        Me.Label12.TabIndex = 186
        Me.Label12.Text = "Estado:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEstado
        '
        '
        '
        '
        Me.txtEstado.Border.Class = "TextBoxBorder"
        Me.txtEstado.Location = New System.Drawing.Point(315, 212)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(51, 23)
        Me.txtEstado.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(245, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 14)
        Me.Label13.TabIndex = 188
        Me.Label13.Text = "CEP:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCep
        '
        '
        '
        '
        Me.txtCep.Border.Class = "TextBoxBorder"
        Me.txtCep.Location = New System.Drawing.Point(286, 188)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(80, 23)
        Me.txtCep.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(38, 330)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 14)
        Me.Label14.TabIndex = 190
        Me.Label14.Text = "Fone:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFone
        '
        '
        '
        '
        Me.txtFone.Border.Class = "TextBoxBorder"
        Me.txtFone.Location = New System.Drawing.Point(89, 327)
        Me.txtFone.Name = "txtFone"
        Me.txtFone.Size = New System.Drawing.Size(205, 23)
        Me.txtFone.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(50, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 14)
        Me.Label15.TabIndex = 192
        Me.Label15.Text = "Pai:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPai
        '
        '
        '
        '
        Me.txtPai.Border.Class = "TextBoxBorder"
        Me.txtPai.Location = New System.Drawing.Point(89, 279)
        Me.txtPai.Name = "txtPai"
        Me.txtPai.Size = New System.Drawing.Size(205, 23)
        Me.txtPai.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(43, 306)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 14)
        Me.Label16.TabIndex = 194
        Me.Label16.Text = "Mãe:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMae
        '
        '
        '
        '
        Me.txtMae.Border.Class = "TextBoxBorder"
        Me.txtMae.Location = New System.Drawing.Point(89, 303)
        Me.txtMae.Name = "txtMae"
        Me.txtMae.Size = New System.Drawing.Size(205, 23)
        Me.txtMae.TabIndex = 12
        '
        'txtRM
        '
        '
        '
        '
        Me.txtRM.Border.Class = "TextBoxBorder"
        Me.txtRM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRM.Location = New System.Drawing.Point(87, 140)
        Me.txtRM.Name = "txtRM"
        Me.txtRM.Size = New System.Drawing.Size(74, 23)
        Me.txtRM.TabIndex = 1
        Me.txtRM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbAtivo
        '
        Me.rbAtivo.AutoSize = True
        Me.rbAtivo.BackColor = System.Drawing.Color.Transparent
        Me.rbAtivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAtivo.Location = New System.Drawing.Point(7, 5)
        Me.rbAtivo.Name = "rbAtivo"
        Me.rbAtivo.Size = New System.Drawing.Size(54, 17)
        Me.rbAtivo.TabIndex = 196
        Me.rbAtivo.TabStop = True
        Me.rbAtivo.Text = "Ativo"
        Me.rbAtivo.UseVisualStyleBackColor = False
        '
        'rbTransferido
        '
        Me.rbTransferido.AutoSize = True
        Me.rbTransferido.BackColor = System.Drawing.Color.Transparent
        Me.rbTransferido.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTransferido.Location = New System.Drawing.Point(67, 5)
        Me.rbTransferido.Name = "rbTransferido"
        Me.rbTransferido.Size = New System.Drawing.Size(90, 17)
        Me.rbTransferido.TabIndex = 197
        Me.rbTransferido.TabStop = True
        Me.rbTransferido.Text = "Transferido"
        Me.rbTransferido.UseVisualStyleBackColor = False
        '
        'rbDesistencia
        '
        Me.rbDesistencia.AutoSize = True
        Me.rbDesistencia.BackColor = System.Drawing.Color.Transparent
        Me.rbDesistencia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDesistencia.Location = New System.Drawing.Point(159, 5)
        Me.rbDesistencia.Name = "rbDesistencia"
        Me.rbDesistencia.Size = New System.Drawing.Size(90, 17)
        Me.rbDesistencia.TabIndex = 198
        Me.rbDesistencia.TabStop = True
        Me.rbDesistencia.Text = "Desistência"
        Me.rbDesistencia.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(572, 481)
        Me.ShapeContainer1.TabIndex = 199
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 34
        Me.LineShape3.X2 = 201
        Me.LineShape3.Y1 = 443
        Me.LineShape3.Y2 = 443
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 366
        Me.LineShape2.X2 = 571
        Me.LineShape2.Y1 = 27
        Me.LineShape2.Y2 = 27
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 48
        Me.LineShape1.X2 = 519
        Me.LineShape1.Y1 = 131
        Me.LineShape1.Y2 = 131
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtDataDesistencia)
        Me.GroupPanel1.Controls.Add(Me.Label17)
        Me.GroupPanel1.Controls.Add(Me.txtMotivo)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.rbDesistencia)
        Me.GroupPanel1.Controls.Add(Me.rbTransferido)
        Me.GroupPanel1.Controls.Add(Me.rbAtivo)
        Me.GroupPanel1.Location = New System.Drawing.Point(300, 242)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(259, 107)
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
        Me.GroupPanel1.TabIndex = 200
        Me.GroupPanel1.Text = "Matrícula"
        '
        'txtDataDesistencia
        '
        Me.txtDataDesistencia.Location = New System.Drawing.Point(93, 32)
        Me.txtDataDesistencia.Mask = "00/00/0000"
        Me.txtDataDesistencia.Name = "txtDataDesistencia"
        Me.txtDataDesistencia.Size = New System.Drawing.Size(122, 23)
        Me.txtDataDesistencia.TabIndex = 15
        Me.txtDataDesistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataDesistencia.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(34, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 14)
        Me.Label17.TabIndex = 204
        Me.Label17.Text = "Motivo:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMotivo
        '
        '
        '
        '
        Me.txtMotivo.Border.Class = "TextBoxBorder"
        Me.txtMotivo.Location = New System.Drawing.Point(93, 58)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(122, 23)
        Me.txtMotivo.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 14)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "Data:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(266, 143)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 14)
        Me.Label18.TabIndex = 204
        Me.Label18.Text = "Folhas:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFolhas
        '
        '
        '
        '
        Me.txtFolhas.Border.Class = "TextBoxBorder"
        Me.txtFolhas.Location = New System.Drawing.Point(320, 140)
        Me.txtFolhas.Name = "txtFolhas"
        Me.txtFolhas.Size = New System.Drawing.Size(46, 23)
        Me.txtFolhas.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(162, 143)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 14)
        Me.Label19.TabIndex = 202
        Me.Label19.Text = "Livro:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLivro
        '
        '
        '
        '
        Me.txtLivro.Border.Class = "TextBoxBorder"
        Me.txtLivro.Location = New System.Drawing.Point(212, 140)
        Me.txtLivro.Name = "txtLivro"
        Me.txtLivro.Size = New System.Drawing.Size(50, 23)
        Me.txtLivro.TabIndex = 2
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(89, 351)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(471, 53)
        Me.txtObservacao.TabIndex = 14
        Me.txtObservacao.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(44, 355)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 14)
        Me.Label20.TabIndex = 206
        Me.Label20.Text = "Obs:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(368, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 14)
        Me.Label21.TabIndex = 207
        Me.Label21.Text = "Data Matrícula:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbLancamento
        '
        Me.lbLancamento.AutoSize = True
        Me.lbLancamento.BackColor = System.Drawing.Color.Transparent
        Me.lbLancamento.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLancamento.ForeColor = System.Drawing.Color.Blue
        Me.lbLancamento.Location = New System.Drawing.Point(471, 10)
        Me.lbLancamento.Name = "lbLancamento"
        Me.lbLancamento.Size = New System.Drawing.Size(95, 14)
        Me.lbLancamento.TabIndex = 208
        Me.lbLancamento.Text = "00/00/0000"
        Me.lbLancamento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.BackColor = System.Drawing.Color.Transparent
        Me.rbMasculino.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMasculino.Location = New System.Drawing.Point(44, 14)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(89, 17)
        Me.rbMasculino.TabIndex = 209
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = False
        '
        'rbFeminino
        '
        Me.rbFeminino.AutoSize = True
        Me.rbFeminino.BackColor = System.Drawing.Color.Transparent
        Me.rbFeminino.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFeminino.Location = New System.Drawing.Point(44, 35)
        Me.rbFeminino.Name = "rbFeminino"
        Me.rbFeminino.Size = New System.Drawing.Size(85, 17)
        Me.rbFeminino.TabIndex = 210
        Me.rbFeminino.TabStop = True
        Me.rbFeminino.Text = "Feminino"
        Me.rbFeminino.UseVisualStyleBackColor = False
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.rbMasculino)
        Me.GroupPanel2.Controls.Add(Me.rbFeminino)
        Me.GroupPanel2.Location = New System.Drawing.Point(386, 140)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(173, 95)
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
        Me.GroupPanel2.TabIndex = 211
        Me.GroupPanel2.Text = "Sexo"
        '
        'DGComplemento
        '
        Me.DGComplemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGComplemento.Location = New System.Drawing.Point(212, 406)
        Me.DGComplemento.Name = "DGComplemento"
        Me.DGComplemento.Size = New System.Drawing.Size(347, 65)
        Me.DGComplemento.TabIndex = 212
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(141, 427)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 14)
        Me.Label22.TabIndex = 213
        Me.Label22.Text = "Histórico:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNascimento
        '
        Me.txtNascimento.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNascimento.Location = New System.Drawing.Point(89, 254)
        Me.txtNascimento.Mask = "00/00/0000"
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(80, 22)
        Me.txtNascimento.TabIndex = 9
        Me.txtNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNascimento.ValidatingType = GetType(Date)
        '
        'frmCadAlunoFicha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 481)
        Me.Controls.Add(Me.txtNascimento)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.DGComplemento)
        Me.Controls.Add(Me.txtLivro)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.lbLancamento)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtFolhas)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.txtRM)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtMae)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPai)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtFone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbPesquisar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.btEfetuar)
        Me.Controls.Add(Me.rbAlterar)
        Me.Controls.Add(Me.rbIncluir)
        Me.Controls.Add(Me.gpAluno)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmCadAlunoFicha"
        Me.ShowIcon = False
        Me.Text = "Aluno - Ficha Completa"
        CType(Me.tbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpAluno.ResumeLayout(False)
        Me.gpAluno.PerformLayout()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.DGComplemento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCodigo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gpAluno As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbIncluir As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlterar As System.Windows.Forms.RadioButton
    Friend WithEvents btEfetuar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtEndereco As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbPesquisar As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRG As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCep As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFone As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPai As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMae As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRM As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents rbAtivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransferido As System.Windows.Forms.RadioButton
    Friend WithEvents rbDesistencia As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFolhas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtLivro As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtObservacao As System.Windows.Forms.RichTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbLancamento As System.Windows.Forms.Label
    Friend WithEvents rbMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents rbFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DGComplemento As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtNascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDataDesistencia As System.Windows.Forms.MaskedTextBox
End Class
