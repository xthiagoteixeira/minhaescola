<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmDelib11Ficha
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmDelib11Ficha))
        Me.tabFichaCompleta = New System.Windows.Forms.TabControl()
        Me.tabFicha1 = New System.Windows.Forms.TabPage()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTurma = New DevExpress.XtraEditors.LookUpEdit()
        Me.gridFicha = New DevExpress.XtraGrid.GridControl()
        Me.viewFicha = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabFicha2 = New System.Windows.Forms.TabPage()
        Me.tbTurma_delib11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.tbAluno_Delib11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.nrAluno_Delib11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbDelib_Cat01 = New DevExpress.XtraEditors.LabelControl()
        Me.lbDelib_Cat02 = New DevExpress.XtraEditors.LabelControl()
        Me.lbDelib_Cat03 = New DevExpress.XtraEditors.LabelControl()
        Me.lbDelib_Cat04 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gridBoletim = New DevExpress.XtraGrid.GridControl()
        Me.viewBoletim = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.listaDelib11_04 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.listaDelib11_03 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.listaDelib11_02 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.listaDelib11_01 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.bwConsulta = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.botaoConfiguracao = New DevExpress.XtraEditors.SimpleButton()
        Me.tabFichaCompleta.SuspendLayout()
        Me.tabFicha1.SuspendLayout()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFicha2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaDelib11_04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaDelib11_03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaDelib11_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaDelib11_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabFichaCompleta
        '
        Me.tabFichaCompleta.Controls.Add(Me.tabFicha1)
        Me.tabFichaCompleta.Controls.Add(Me.tabFicha2)
        Me.tabFichaCompleta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabFichaCompleta.Location = New System.Drawing.Point(0, 0)
        Me.tabFichaCompleta.Name = "tabFichaCompleta"
        Me.tabFichaCompleta.SelectedIndex = 0
        Me.tabFichaCompleta.Size = New System.Drawing.Size(719, 518)
        Me.tabFichaCompleta.TabIndex = 221
        '
        'tabFicha1
        '
        Me.tabFicha1.Controls.Add(Me.botaoConfiguracao)
        Me.tabFicha1.Controls.Add(Me.tAno)
        Me.tabFicha1.Controls.Add(Me.LabelControl2)
        Me.tabFicha1.Controls.Add(Me.LabelControl1)
        Me.tabFicha1.Controls.Add(Me.cbTurma)
        Me.tabFicha1.Controls.Add(Me.gridFicha)
        Me.tabFicha1.Controls.Add(Me.Label6)
        Me.tabFicha1.Controls.Add(Me.Label3)
        Me.tabFicha1.Controls.Add(Me.Label1)
        Me.tabFicha1.Location = New System.Drawing.Point(4, 25)
        Me.tabFicha1.Name = "tabFicha1"
        Me.tabFicha1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFicha1.Size = New System.Drawing.Size(711, 489)
        Me.tabFicha1.TabIndex = 0
        Me.tabFicha1.Text = "Pesquisa"
        Me.tabFicha1.UseVisualStyleBackColor = True
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(50, 461)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(60, 20)
        Me.tAno.TabIndex = 238
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(17, 463)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 16)
        Me.LabelControl2.TabIndex = 237
        Me.LabelControl2.Text = "Ano:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(143, 464)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl1.TabIndex = 236
        Me.LabelControl1.Text = "Turma:"
        '
        'cbTurma
        '
        Me.cbTurma.EditValue = ""
        Me.cbTurma.Location = New System.Drawing.Point(188, 462)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbTurma.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cbTurma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurma.Properties.NullText = ""
        Me.cbTurma.Size = New System.Drawing.Size(124, 20)
        Me.cbTurma.TabIndex = 235
        '
        'gridFicha
        '
        Me.gridFicha.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridFicha.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridFicha.Location = New System.Drawing.Point(3, 3)
        Me.gridFicha.MainView = Me.viewFicha
        Me.gridFicha.Name = "gridFicha"
        Me.gridFicha.Size = New System.Drawing.Size(705, 453)
        Me.gridFicha.TabIndex = 234
        Me.gridFicha.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewFicha})
        '
        'viewFicha
        '
        Me.viewFicha.GridControl = Me.gridFicha
        Me.viewFicha.Name = "viewFicha"
        Me.viewFicha.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewFicha.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewFicha.OptionsBehavior.Editable = False
        Me.viewFicha.OptionsPrint.PrintPreview = True
        Me.viewFicha.OptionsView.ShowFooter = True
        Me.viewFicha.OptionsView.ShowGroupPanel = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(557, 463)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 18)
        Me.Label6.TabIndex = 232
        Me.Label6.Text = "Aluno regular"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(451, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 231
        Me.Label3.Text = "Falta preencher"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(356, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 230
        Me.Label1.Text = "Preenchida"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabFicha2
        '
        Me.tabFicha2.Controls.Add(Me.tbTurma_delib11)
        Me.tabFicha2.Controls.Add(Me.LabelControl5)
        Me.tabFicha2.Controls.Add(Me.tbAluno_Delib11)
        Me.tabFicha2.Controls.Add(Me.LabelControl4)
        Me.tabFicha2.Controls.Add(Me.LabelControl3)
        Me.tabFicha2.Controls.Add(Me.nrAluno_Delib11)
        Me.tabFicha2.Controls.Add(Me.lbDelib_Cat01)
        Me.tabFicha2.Controls.Add(Me.lbDelib_Cat02)
        Me.tabFicha2.Controls.Add(Me.lbDelib_Cat03)
        Me.tabFicha2.Controls.Add(Me.lbDelib_Cat04)
        Me.tabFicha2.Controls.Add(Me.GroupControl1)
        Me.tabFicha2.Controls.Add(Me.listaDelib11_04)
        Me.tabFicha2.Controls.Add(Me.listaDelib11_03)
        Me.tabFicha2.Controls.Add(Me.listaDelib11_02)
        Me.tabFicha2.Controls.Add(Me.listaDelib11_01)
        Me.tabFicha2.Controls.Add(Me.ShapeContainer1)
        Me.tabFicha2.Location = New System.Drawing.Point(4, 25)
        Me.tabFicha2.Name = "tabFicha2"
        Me.tabFicha2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFicha2.Size = New System.Drawing.Size(711, 489)
        Me.tabFicha2.TabIndex = 1
        Me.tabFicha2.Text = "Ficha"
        Me.tabFicha2.UseVisualStyleBackColor = True
        '
        'tbTurma_delib11
        '
        Me.tbTurma_delib11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTurma_delib11.Appearance.Options.UseFont = True
        Me.tbTurma_delib11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tbTurma_delib11.Location = New System.Drawing.Point(516, 14)
        Me.tbTurma_delib11.Name = "tbTurma_delib11"
        Me.tbTurma_delib11.Size = New System.Drawing.Size(180, 13)
        Me.tbTurma_delib11.TabIndex = 270
        Me.tbTurma_delib11.Text = "-"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(461, 13)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl5.TabIndex = 269
        Me.LabelControl5.Text = "Turma:"
        '
        'tbAluno_Delib11
        '
        Me.tbAluno_Delib11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAluno_Delib11.Appearance.Options.UseFont = True
        Me.tbAluno_Delib11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tbAluno_Delib11.Location = New System.Drawing.Point(150, 14)
        Me.tbAluno_Delib11.Name = "tbAluno_Delib11"
        Me.tbAluno_Delib11.Size = New System.Drawing.Size(304, 13)
        Me.tbAluno_Delib11.TabIndex = 268
        Me.tbAluno_Delib11.Text = "-"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(100, 13)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl4.TabIndex = 267
        Me.LabelControl4.Text = "Nome:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(15, 13)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 16)
        Me.LabelControl3.TabIndex = 266
        Me.LabelControl3.Text = "Nº:"
        '
        'nrAluno_Delib11
        '
        Me.nrAluno_Delib11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nrAluno_Delib11.Appearance.Options.UseFont = True
        Me.nrAluno_Delib11.Location = New System.Drawing.Point(40, 13)
        Me.nrAluno_Delib11.Name = "nrAluno_Delib11"
        Me.nrAluno_Delib11.Size = New System.Drawing.Size(14, 16)
        Me.nrAluno_Delib11.TabIndex = 265
        Me.nrAluno_Delib11.Text = "00"
        '
        'lbDelib_Cat01
        '
        Me.lbDelib_Cat01.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDelib_Cat01.Appearance.Options.UseFont = True
        Me.lbDelib_Cat01.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbDelib_Cat01.Location = New System.Drawing.Point(11, 39)
        Me.lbDelib_Cat01.Name = "lbDelib_Cat01"
        Me.lbDelib_Cat01.Size = New System.Drawing.Size(341, 13)
        Me.lbDelib_Cat01.TabIndex = 264
        Me.lbDelib_Cat01.Text = "-"
        '
        'lbDelib_Cat02
        '
        Me.lbDelib_Cat02.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDelib_Cat02.Appearance.Options.UseFont = True
        Me.lbDelib_Cat02.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbDelib_Cat02.Location = New System.Drawing.Point(11, 191)
        Me.lbDelib_Cat02.Name = "lbDelib_Cat02"
        Me.lbDelib_Cat02.Size = New System.Drawing.Size(341, 13)
        Me.lbDelib_Cat02.TabIndex = 263
        Me.lbDelib_Cat02.Text = "-"
        '
        'lbDelib_Cat03
        '
        Me.lbDelib_Cat03.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDelib_Cat03.Appearance.Options.UseFont = True
        Me.lbDelib_Cat03.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbDelib_Cat03.Location = New System.Drawing.Point(11, 346)
        Me.lbDelib_Cat03.Name = "lbDelib_Cat03"
        Me.lbDelib_Cat03.Size = New System.Drawing.Size(341, 13)
        Me.lbDelib_Cat03.TabIndex = 262
        Me.lbDelib_Cat03.Text = "-"
        '
        'lbDelib_Cat04
        '
        Me.lbDelib_Cat04.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDelib_Cat04.Appearance.Options.UseFont = True
        Me.lbDelib_Cat04.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbDelib_Cat04.Location = New System.Drawing.Point(358, 346)
        Me.lbDelib_Cat04.Name = "lbDelib_Cat04"
        Me.lbDelib_Cat04.Size = New System.Drawing.Size(348, 13)
        Me.lbDelib_Cat04.TabIndex = 261
        Me.lbDelib_Cat04.Text = "-"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.gridBoletim)
        Me.GroupControl1.Location = New System.Drawing.Point(358, 39)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(348, 297)
        Me.GroupControl1.TabIndex = 260
        Me.GroupControl1.Text = "Boletim do Aluno"
        '
        'gridBoletim
        '
        Me.gridBoletim.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridBoletim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridBoletim.Location = New System.Drawing.Point(2, 29)
        Me.gridBoletim.MainView = Me.viewBoletim
        Me.gridBoletim.Name = "gridBoletim"
        Me.gridBoletim.Size = New System.Drawing.Size(344, 266)
        Me.gridBoletim.TabIndex = 0
        Me.gridBoletim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBoletim})
        '
        'viewBoletim
        '
        Me.viewBoletim.GridControl = Me.gridBoletim
        Me.viewBoletim.Name = "viewBoletim"
        Me.viewBoletim.OptionsView.ShowGroupPanel = False
        '
        'listaDelib11_04
        '
        Me.listaDelib11_04.Location = New System.Drawing.Point(358, 364)
        Me.listaDelib11_04.Name = "listaDelib11_04"
        Me.listaDelib11_04.Size = New System.Drawing.Size(348, 123)
        Me.listaDelib11_04.TabIndex = 259
        '
        'listaDelib11_03
        '
        Me.listaDelib11_03.Location = New System.Drawing.Point(11, 364)
        Me.listaDelib11_03.Name = "listaDelib11_03"
        Me.listaDelib11_03.Size = New System.Drawing.Size(341, 123)
        Me.listaDelib11_03.TabIndex = 258
        '
        'listaDelib11_02
        '
        Me.listaDelib11_02.Location = New System.Drawing.Point(11, 209)
        Me.listaDelib11_02.Name = "listaDelib11_02"
        Me.listaDelib11_02.Size = New System.Drawing.Size(341, 127)
        Me.listaDelib11_02.TabIndex = 257
        '
        'listaDelib11_01
        '
        Me.listaDelib11_01.Location = New System.Drawing.Point(11, 58)
        Me.listaDelib11_01.Name = "listaDelib11_01"
        Me.listaDelib11_01.Size = New System.Drawing.Size(341, 129)
        Me.listaDelib11_01.TabIndex = 256
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(705, 483)
        Me.ShapeContainer1.TabIndex = 244
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 692
        Me.LineShape1.Y1 = 30
        Me.LineShape1.Y2 = 30
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'botaoConfiguracao
        '
        Me.botaoConfiguracao.AutoSize = True
        Me.botaoConfiguracao.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.botaoConfiguracao.Location = New System.Drawing.Point(686, 461)
        Me.botaoConfiguracao.Name = "botaoConfiguracao"
        Me.botaoConfiguracao.Size = New System.Drawing.Size(22, 22)
        Me.botaoConfiguracao.TabIndex = 239
        '
        'frmAdmDelib11Ficha
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(719, 518)
        Me.Controls.Add(Me.tabFichaCompleta)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAdmDelib11Ficha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deliberação 11 - Ficha"
        Me.tabFichaCompleta.ResumeLayout(false)
        Me.tabFicha1.ResumeLayout(false)
        Me.tabFicha1.PerformLayout
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbTurma.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridFicha,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.viewFicha,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabFicha2.ResumeLayout(false)
        Me.tabFicha2.PerformLayout
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        CType(Me.gridBoletim,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.viewBoletim,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.listaDelib11_04,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.listaDelib11_03,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.listaDelib11_02,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.listaDelib11_01,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tabFichaCompleta As System.Windows.Forms.TabControl
    Friend WithEvents tabFicha1 As System.Windows.Forms.TabPage
    Friend WithEvents tabFicha2 As System.Windows.Forms.TabPage
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bwConsulta As System.ComponentModel.BackgroundWorker
    Friend WithEvents gridFicha As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewFicha As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbTurma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents listaDelib11_04 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents listaDelib11_03 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents listaDelib11_02 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents listaDelib11_01 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridBoletim As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBoletim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbDelib_Cat01 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbDelib_Cat02 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbDelib_Cat03 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbDelib_Cat04 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbTurma_delib11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbAluno_Delib11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nrAluno_Delib11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents botaoConfiguracao As DevExpress.XtraEditors.SimpleButton
End Class
