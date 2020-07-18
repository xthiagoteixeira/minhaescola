<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMBoletim
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBMBoletim))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pErradoD = New System.Windows.Forms.PictureBox()
        Me.barra = New DevExpress.XtraEditors.ProgressBarControl()
        Me.pErradoT = New System.Windows.Forms.PictureBox()
        Me.pErradoB = New System.Windows.Forms.PictureBox()
        Me.pErradoIF = New System.Windows.Forms.PictureBox()
        Me.pCertoB = New System.Windows.Forms.PictureBox()
        Me.pErradoI = New System.Windows.Forms.PictureBox()
        Me.pCertoT = New System.Windows.Forms.PictureBox()
        Me.pCertoIF = New System.Windows.Forms.PictureBox()
        Me.pCertoI = New System.Windows.Forms.PictureBox()
        Me.pCertoD = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bkProcesso = New System.ComponentModel.BackgroundWorker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DGBoletim = New System.Windows.Forms.DataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.cbDisco = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.tBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.btTrazer = New DevExpress.XtraEditors.SimpleButton()
        Me.cbSobreescrever = New DevExpress.XtraEditors.CheckEdit()
        Me.btImprimir_Recibo = New DevExpress.XtraEditors.SimpleButton()
        Me.btImprimir_Consolidado = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pErradoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pErradoT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pErradoB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pErradoIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCertoB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pErradoI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCertoT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCertoIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCertoI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCertoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDisco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSobreescrever.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Lista de Disciplinas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Lista de Turmas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Disco:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Encontrar Boletins"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Importar Boletins"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 16)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Importação Finalizada"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pErradoD)
        Me.GroupBox1.Controls.Add(Me.barra)
        Me.GroupBox1.Controls.Add(Me.pErradoT)
        Me.GroupBox1.Controls.Add(Me.pErradoB)
        Me.GroupBox1.Controls.Add(Me.pErradoIF)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.pCertoB)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.pErradoI)
        Me.GroupBox1.Controls.Add(Me.pCertoT)
        Me.GroupBox1.Controls.Add(Me.pCertoIF)
        Me.GroupBox1.Controls.Add(Me.pCertoI)
        Me.GroupBox1.Controls.Add(Me.pCertoD)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 173)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        '
        'pErradoD
        '
        Me.pErradoD.Image = CType(resources.GetObject("pErradoD.Image"), System.Drawing.Image)
        Me.pErradoD.Location = New System.Drawing.Point(10, 40)
        Me.pErradoD.Name = "pErradoD"
        Me.pErradoD.Size = New System.Drawing.Size(20, 20)
        Me.pErradoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pErradoD.TabIndex = 197
        Me.pErradoD.TabStop = False
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(10, 141)
        Me.barra.Name = "barra"
        Me.barra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.DisplayFormat.FormatString = "."
        Me.barra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.EditFormat.FormatString = "."
        Me.barra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.ShowTitle = True
        Me.barra.ShowProgressInTaskBar = True
        Me.barra.Size = New System.Drawing.Size(211, 21)
        Me.barra.TabIndex = 204
        '
        'pErradoT
        '
        Me.pErradoT.Image = CType(resources.GetObject("pErradoT.Image"), System.Drawing.Image)
        Me.pErradoT.Location = New System.Drawing.Point(10, 15)
        Me.pErradoT.Name = "pErradoT"
        Me.pErradoT.Size = New System.Drawing.Size(20, 20)
        Me.pErradoT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pErradoT.TabIndex = 198
        Me.pErradoT.TabStop = False
        '
        'pErradoB
        '
        Me.pErradoB.Image = CType(resources.GetObject("pErradoB.Image"), System.Drawing.Image)
        Me.pErradoB.Location = New System.Drawing.Point(10, 65)
        Me.pErradoB.Name = "pErradoB"
        Me.pErradoB.Size = New System.Drawing.Size(20, 20)
        Me.pErradoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pErradoB.TabIndex = 196
        Me.pErradoB.TabStop = False
        '
        'pErradoIF
        '
        Me.pErradoIF.Image = CType(resources.GetObject("pErradoIF.Image"), System.Drawing.Image)
        Me.pErradoIF.Location = New System.Drawing.Point(10, 115)
        Me.pErradoIF.Name = "pErradoIF"
        Me.pErradoIF.Size = New System.Drawing.Size(20, 20)
        Me.pErradoIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pErradoIF.TabIndex = 194
        Me.pErradoIF.TabStop = False
        '
        'pCertoB
        '
        Me.pCertoB.Image = CType(resources.GetObject("pCertoB.Image"), System.Drawing.Image)
        Me.pCertoB.Location = New System.Drawing.Point(10, 65)
        Me.pCertoB.Name = "pCertoB"
        Me.pCertoB.Size = New System.Drawing.Size(20, 20)
        Me.pCertoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCertoB.TabIndex = 201
        Me.pCertoB.TabStop = False
        '
        'pErradoI
        '
        Me.pErradoI.Image = CType(resources.GetObject("pErradoI.Image"), System.Drawing.Image)
        Me.pErradoI.Location = New System.Drawing.Point(10, 90)
        Me.pErradoI.Name = "pErradoI"
        Me.pErradoI.Size = New System.Drawing.Size(20, 20)
        Me.pErradoI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pErradoI.TabIndex = 195
        Me.pErradoI.TabStop = False
        '
        'pCertoT
        '
        Me.pCertoT.Image = CType(resources.GetObject("pCertoT.Image"), System.Drawing.Image)
        Me.pCertoT.Location = New System.Drawing.Point(10, 15)
        Me.pCertoT.Name = "pCertoT"
        Me.pCertoT.Size = New System.Drawing.Size(20, 20)
        Me.pCertoT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCertoT.TabIndex = 203
        Me.pCertoT.TabStop = False
        '
        'pCertoIF
        '
        Me.pCertoIF.Image = CType(resources.GetObject("pCertoIF.Image"), System.Drawing.Image)
        Me.pCertoIF.Location = New System.Drawing.Point(10, 115)
        Me.pCertoIF.Name = "pCertoIF"
        Me.pCertoIF.Size = New System.Drawing.Size(20, 20)
        Me.pCertoIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCertoIF.TabIndex = 199
        Me.pCertoIF.TabStop = False
        '
        'pCertoI
        '
        Me.pCertoI.Image = CType(resources.GetObject("pCertoI.Image"), System.Drawing.Image)
        Me.pCertoI.Location = New System.Drawing.Point(10, 90)
        Me.pCertoI.Name = "pCertoI"
        Me.pCertoI.Size = New System.Drawing.Size(20, 20)
        Me.pCertoI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCertoI.TabIndex = 200
        Me.pCertoI.TabStop = False
        '
        'pCertoD
        '
        Me.pCertoD.Image = CType(resources.GetObject("pCertoD.Image"), System.Drawing.Image)
        Me.pCertoD.Location = New System.Drawing.Point(10, 40)
        Me.pCertoD.Name = "pCertoD"
        Me.pCertoD.Size = New System.Drawing.Size(20, 20)
        Me.pCertoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCertoD.TabIndex = 202
        Me.pCertoD.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(266, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 14)
        Me.Label10.TabIndex = 190
        Me.Label10.Text = "Ano Letivo:"
        '
        'bkProcesso
        '
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(279, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 14)
        Me.Label11.TabIndex = 207
        Me.Label11.Text = "Bimestre:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(565, 537)
        Me.ShapeContainer1.TabIndex = 208
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 260
        Me.LineShape1.X2 = 554
        Me.LineShape1.Y1 = 46
        Me.LineShape1.Y2 = 46
        '
        'DGBoletim
        '
        Me.DGBoletim.AllowUserToAddRows = False
        Me.DGBoletim.AllowUserToDeleteRows = False
        Me.DGBoletim.AllowUserToOrderColumns = True
        Me.DGBoletim.AllowUserToResizeColumns = False
        Me.DGBoletim.AllowUserToResizeRows = False
        Me.DGBoletim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBoletim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.DataHora, Me.Descrição})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBoletim.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGBoletim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGBoletim.Location = New System.Drawing.Point(0, 181)
        Me.DGBoletim.Name = "DGBoletim"
        Me.DGBoletim.ReadOnly = True
        Me.DGBoletim.RowHeadersVisible = False
        Me.DGBoletim.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGBoletim.Size = New System.Drawing.Size(565, 356)
        Me.DGBoletim.TabIndex = 209
        '
        'Status
        '
        Me.Status.HeaderText = "*"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 25
        '
        'DataHora
        '
        Me.DataHora.HeaderText = "Data"
        Me.DataHora.Name = "DataHora"
        Me.DataHora.ReadOnly = True
        Me.DataHora.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataHora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataHora.Width = 130
        '
        'Descrição
        '
        Me.Descrição.HeaderText = "Descrição"
        Me.Descrição.Name = "Descrição"
        Me.Descrição.ReadOnly = True
        Me.Descrição.Width = 400
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "ImgFalha")
        Me.ImageList.Images.SetKeyName(1, "ImgSucesso")
        '
        'cbDisco
        '
        Me.cbDisco.Location = New System.Drawing.Point(345, 38)
        Me.cbDisco.Name = "cbDisco"
        Me.cbDisco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDisco.Properties.Appearance.Options.UseFont = True
        Me.cbDisco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDisco.Size = New System.Drawing.Size(65, 22)
        Me.cbDisco.TabIndex = 210
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(345, 62)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = True
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "d"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(65, 22)
        Me.tAno.TabIndex = 211
        '
        'tBimestre
        '
        Me.tBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Location = New System.Drawing.Point(345, 86)
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Properties.Appearance.Options.UseFont = True
        Me.tBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tBimestre.Properties.IsFloatValue = False
        Me.tBimestre.Properties.Mask.EditMask = "N00"
        Me.tBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Size = New System.Drawing.Size(38, 22)
        Me.tBimestre.TabIndex = 212
        '
        'btTrazer
        '
        Me.btTrazer.Location = New System.Drawing.Point(447, 80)
        Me.btTrazer.Name = "btTrazer"
        Me.btTrazer.Size = New System.Drawing.Size(93, 23)
        Me.btTrazer.TabIndex = 213
        Me.btTrazer.Text = "Trazer!"
        '
        'cbSobreescrever
        '
        Me.cbSobreescrever.Location = New System.Drawing.Point(442, 49)
        Me.cbSobreescrever.Name = "cbSobreescrever"
        Me.cbSobreescrever.Properties.Caption = "Atualizar notas"
        Me.cbSobreescrever.Size = New System.Drawing.Size(98, 19)
        Me.cbSobreescrever.TabIndex = 216
        '
        'btImprimir_Recibo
        '
        Me.btImprimir_Recibo.Enabled = False
        Me.btImprimir_Recibo.Location = New System.Drawing.Point(248, 141)
        Me.btImprimir_Recibo.Name = "btImprimir_Recibo"
        Me.btImprimir_Recibo.Size = New System.Drawing.Size(120, 23)
        Me.btImprimir_Recibo.TabIndex = 217
        Me.btImprimir_Recibo.Text = "Imprimir Recibo"
        '
        'btImprimir_Consolidado
        '
        Me.btImprimir_Consolidado.Enabled = False
        Me.btImprimir_Consolidado.Location = New System.Drawing.Point(433, 141)
        Me.btImprimir_Consolidado.Name = "btImprimir_Consolidado"
        Me.btImprimir_Consolidado.Size = New System.Drawing.Size(120, 23)
        Me.btImprimir_Consolidado.TabIndex = 218
        Me.btImprimir_Consolidado.Text = "Imprimir Consolidado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(248, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 101)
        Me.GroupBox2.TabIndex = 219
        Me.GroupBox2.TabStop = False
        '
        'frmBMBoletim
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(565, 537)
        Me.Controls.Add(Me.btImprimir_Consolidado)
        Me.Controls.Add(Me.btImprimir_Recibo)
        Me.Controls.Add(Me.cbSobreescrever)
        Me.Controls.Add(Me.btTrazer)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.cbDisco)
        Me.Controls.Add(Me.DGBoletim)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBMBoletim"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Professor! - Trazer Notas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pErradoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pErradoT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pErradoB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pErradoIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCertoB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pErradoI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCertoT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCertoIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCertoI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCertoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDisco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSobreescrever.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pErradoT As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pCertoT As System.Windows.Forms.PictureBox
    Friend WithEvents pErradoD As System.Windows.Forms.PictureBox
    Friend WithEvents pCertoD As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pErradoB As System.Windows.Forms.PictureBox
    Friend WithEvents pCertoB As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pErradoI As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pErradoIF As System.Windows.Forms.PictureBox
    Friend WithEvents pCertoIF As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bkProcesso As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pCertoI As System.Windows.Forms.PictureBox
    Friend WithEvents DGBoletim As System.Windows.Forms.DataGridView
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
    Friend WithEvents cbDisco As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tBimestre As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btTrazer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents barra As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents cbSobreescrever As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Status As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descrição As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btImprimir_Recibo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btImprimir_Consolidado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
