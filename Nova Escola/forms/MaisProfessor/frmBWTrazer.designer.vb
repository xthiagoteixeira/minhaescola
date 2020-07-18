<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBWTrazer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBWTrazer))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.barra = New DevExpress.XtraEditors.ProgressBarControl()
        Me.pErradoIF = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pCertoIF = New System.Windows.Forms.PictureBox()
        Me.pErradoI = New System.Windows.Forms.PictureBox()
        Me.pCertoI = New System.Windows.Forms.PictureBox()
        Me.pErradoB = New System.Windows.Forms.PictureBox()
        Me.pCertoB = New System.Windows.Forms.PictureBox()
        Me.bwTrazer = New System.ComponentModel.BackgroundWorker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.tBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.cbAF = New DevExpress.XtraEditors.CheckEdit()
        Me.btImportar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbNroDelib11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbNroBoletins = New DevExpress.XtraEditors.LabelControl()
        Me.DGBoletim = New System.Windows.Forms.DataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pErradoIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCertoIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pErradoI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCertoI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pErradoB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCertoB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "ImgFalha")
        Me.ImageList.Images.SetKeyName(1, "ImgSucesso")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.barra)
        Me.GroupBox1.Controls.Add(Me.pErradoIF)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.pCertoIF)
        Me.GroupBox1.Controls.Add(Me.pErradoI)
        Me.GroupBox1.Controls.Add(Me.pCertoI)
        Me.GroupBox1.Controls.Add(Me.pErradoB)
        Me.GroupBox1.Controls.Add(Me.pCertoB)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 120)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(13, 91)
        Me.barra.Name = "barra"
        Me.barra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.DisplayFormat.FormatString = "."
        Me.barra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.EditFormat.FormatString = "."
        Me.barra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.ShowTitle = True
        Me.barra.ShowProgressInTaskBar = True
        Me.barra.Size = New System.Drawing.Size(177, 21)
        Me.barra.TabIndex = 217
        '
        'pErradoIF
        '
        Me.pErradoIF.Image = CType(resources.GetObject("pErradoIF.Image"), System.Drawing.Image)
        Me.pErradoIF.Location = New System.Drawing.Point(13, 64)
        Me.pErradoIF.Name = "pErradoIF"
        Me.pErradoIF.Size = New System.Drawing.Size(20, 20)
        Me.pErradoIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pErradoIF.TabIndex = 209
        Me.pErradoIF.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 16)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "Importação Finalizada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Importar Boletins"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "Encontrar Boletins"
        '
        'pCertoIF
        '
        Me.pCertoIF.Image = CType(resources.GetObject("pCertoIF.Image"), System.Drawing.Image)
        Me.pCertoIF.Location = New System.Drawing.Point(13, 64)
        Me.pCertoIF.Name = "pCertoIF"
        Me.pCertoIF.Size = New System.Drawing.Size(20, 20)
        Me.pCertoIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCertoIF.TabIndex = 214
        Me.pCertoIF.TabStop = False
        '
        'pErradoI
        '
        Me.pErradoI.Image = CType(resources.GetObject("pErradoI.Image"), System.Drawing.Image)
        Me.pErradoI.Location = New System.Drawing.Point(13, 39)
        Me.pErradoI.Name = "pErradoI"
        Me.pErradoI.Size = New System.Drawing.Size(20, 20)
        Me.pErradoI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pErradoI.TabIndex = 210
        Me.pErradoI.TabStop = False
        '
        'pCertoI
        '
        Me.pCertoI.Image = CType(resources.GetObject("pCertoI.Image"), System.Drawing.Image)
        Me.pCertoI.Location = New System.Drawing.Point(13, 39)
        Me.pCertoI.Name = "pCertoI"
        Me.pCertoI.Size = New System.Drawing.Size(20, 20)
        Me.pCertoI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCertoI.TabIndex = 215
        Me.pCertoI.TabStop = False
        '
        'pErradoB
        '
        Me.pErradoB.Image = CType(resources.GetObject("pErradoB.Image"), System.Drawing.Image)
        Me.pErradoB.Location = New System.Drawing.Point(13, 14)
        Me.pErradoB.Name = "pErradoB"
        Me.pErradoB.Size = New System.Drawing.Size(20, 20)
        Me.pErradoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pErradoB.TabIndex = 211
        Me.pErradoB.TabStop = False
        '
        'pCertoB
        '
        Me.pCertoB.Image = CType(resources.GetObject("pCertoB.Image"), System.Drawing.Image)
        Me.pCertoB.Location = New System.Drawing.Point(13, 14)
        Me.pCertoB.Name = "pCertoB"
        Me.pCertoB.Size = New System.Drawing.Size(20, 20)
        Me.pCertoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCertoB.TabIndex = 216
        Me.pCertoB.TabStop = False
        '
        'bwTrazer
        '
        Me.bwTrazer.WorkerReportsProgress = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 14)
        Me.Label10.TabIndex = 190
        Me.Label10.Text = "Ano Letivo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(146, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 14)
        Me.Label11.TabIndex = 207
        Me.Label11.Text = "Bimestre:"
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(86, 36)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = True
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "d"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(58, 22)
        Me.tAno.TabIndex = 211
        '
        'tBimestre
        '
        Me.tBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Location = New System.Drawing.Point(214, 38)
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tBimestre.Properties.IsFloatValue = False
        Me.tBimestre.Properties.Mask.EditMask = "N00"
        Me.tBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Size = New System.Drawing.Size(36, 20)
        Me.tBimestre.TabIndex = 212
        '
        'cbAF
        '
        Me.cbAF.Location = New System.Drawing.Point(256, 39)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Properties.Caption = "AF"
        Me.cbAF.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cbAF.Size = New System.Drawing.Size(39, 19)
        Me.cbAF.TabIndex = 213
        '
        'btImportar
        '
        Me.btImportar.Location = New System.Drawing.Point(204, 78)
        Me.btImportar.Name = "btImportar"
        Me.btImportar.Size = New System.Drawing.Size(70, 23)
        Me.btImportar.TabIndex = 214
        Me.btImportar.Text = "Trazer!"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.lbNroDelib11)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.lbNroBoletins)
        Me.GroupBox2.Controls.Add(Me.btImportar)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tAno)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbAF)
        Me.GroupBox2.Controls.Add(Me.tBimestre)
        Me.GroupBox2.Location = New System.Drawing.Point(245, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 120)
        Me.GroupBox2.TabIndex = 216
        Me.GroupBox2.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(41, 90)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl3.TabIndex = 218
        Me.LabelControl3.Text = "Deliberações 11:"
        '
        'lbNroDelib11
        '
        Me.lbNroDelib11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNroDelib11.Appearance.Options.UseFont = True
        Me.lbNroDelib11.Location = New System.Drawing.Point(144, 90)
        Me.lbNroDelib11.Name = "lbNroDelib11"
        Me.lbNroDelib11.Size = New System.Drawing.Size(16, 16)
        Me.lbNroDelib11.TabIndex = 217
        Me.lbNroDelib11.Text = "00"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(41, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl2.TabIndex = 216
        Me.LabelControl2.Text = "Boletins:"
        '
        'lbNroBoletins
        '
        Me.lbNroBoletins.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNroBoletins.Appearance.Options.UseFont = True
        Me.lbNroBoletins.Location = New System.Drawing.Point(96, 72)
        Me.lbNroBoletins.Name = "lbNroBoletins"
        Me.lbNroBoletins.Size = New System.Drawing.Size(16, 16)
        Me.lbNroBoletins.TabIndex = 215
        Me.lbNroBoletins.Text = "00"
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
        Me.DGBoletim.Location = New System.Drawing.Point(0, 124)
        Me.DGBoletim.Name = "DGBoletim"
        Me.DGBoletim.ReadOnly = True
        Me.DGBoletim.RowHeadersVisible = False
        Me.DGBoletim.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGBoletim.Size = New System.Drawing.Size(568, 266)
        Me.DGBoletim.TabIndex = 217
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
        'frmBWTrazer
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(568, 390)
        Me.Controls.Add(Me.DGBoletim)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBWTrazer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Professor! - Online : Trazer Notas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pErradoIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCertoIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pErradoI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCertoI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pErradoB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCertoB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pErradoB As System.Windows.Forms.PictureBox
    Friend WithEvents pErradoIF As System.Windows.Forms.PictureBox
    Friend WithEvents pCertoB As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pErradoI As System.Windows.Forms.PictureBox
    Friend WithEvents pCertoIF As System.Windows.Forms.PictureBox
    Friend WithEvents pCertoI As System.Windows.Forms.PictureBox
    Friend WithEvents bwTrazer As System.ComponentModel.BackgroundWorker
    Friend WithEvents barra As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tBimestre As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGBoletim As System.Windows.Forms.DataGridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbNroDelib11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbNroBoletins As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Status As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descrição As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
