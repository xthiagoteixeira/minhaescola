<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmBolsas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmBolsas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridBolsa = New DevExpress.XtraGrid.GridControl()
        Me.viewBolsa = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rgBolsas = New DevExpress.XtraEditors.RadioGroup()
        Me.btEfetuar = New DevExpress.XtraEditors.SimpleButton()
        Me.tbAluno = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.tBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.listarTodos = New DevExpress.XtraEditors.CheckButton()
        Me.listarBVJ = New DevExpress.XtraEditors.CheckButton()
        Me.listarBolsaFamilia = New DevExpress.XtraEditors.CheckButton()
        Me.lbTurma = New System.Windows.Forms.Label()
        Me.nroCodigo = New DevExpress.XtraEditors.SpinEdit()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridBolsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBolsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgBolsas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAluno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nroCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Turma:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(219, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Nro:"
        '
        'gridBolsa
        '
        Me.gridBolsa.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridBolsa.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridBolsa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBolsa.Location = New System.Drawing.Point(0, 73)
        Me.gridBolsa.MainView = Me.viewBolsa
        Me.gridBolsa.Name = "gridBolsa"
        Me.gridBolsa.Size = New System.Drawing.Size(584, 266)
        Me.gridBolsa.TabIndex = 165
        Me.gridBolsa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBolsa})
        '
        'viewBolsa
        '
        Me.viewBolsa.GridControl = Me.gridBolsa
        Me.viewBolsa.Name = "viewBolsa"
        Me.viewBolsa.OptionsBehavior.Editable = False
        '
        'rgBolsas
        '
        Me.rgBolsas.Location = New System.Drawing.Point(6, 345)
        Me.rgBolsas.Name = "rgBolsas"
        Me.rgBolsas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgBolsas.Properties.Appearance.Options.UseFont = True
        Me.rgBolsas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rgBolsas.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rgBolsas.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Bolsa Família"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Bolsa Variável Jovem"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Sem Bolsa")})
        Me.rgBolsas.Size = New System.Drawing.Size(185, 87)
        Me.rgBolsas.TabIndex = 166
        '
        'btEfetuar
        '
        Me.btEfetuar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEfetuar.Appearance.Options.UseFont = True
        Me.btEfetuar.Enabled = False
        Me.btEfetuar.Location = New System.Drawing.Point(486, 403)
        Me.btEfetuar.Name = "btEfetuar"
        Me.btEfetuar.Size = New System.Drawing.Size(75, 23)
        Me.btEfetuar.TabIndex = 167
        Me.btEfetuar.Text = "Salvar!"
        '
        'tbAluno
        '
        Me.tbAluno.Location = New System.Drawing.Point(262, 377)
        Me.tbAluno.Name = "tbAluno"
        Me.tbAluno.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbAluno.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbAluno.Properties.ReadOnly = True
        Me.tbAluno.Size = New System.Drawing.Size(299, 20)
        Me.tbAluno.TabIndex = 170
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.tBimestre)
        Me.GroupControl1.Controls.Add(Me.tAno)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.listarTodos)
        Me.GroupControl1.Controls.Add(Me.listarBVJ)
        Me.GroupControl1.Controls.Add(Me.listarBolsaFamilia)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(584, 73)
        Me.GroupControl1.TabIndex = 171
        Me.GroupControl1.Text = "Listar alunos:"
        '
        'tBimestre
        '
        Me.tBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Location = New System.Drawing.Point(144, 35)
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBimestre.Properties.Appearance.Options.UseFont = True
        Me.tBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tBimestre.Properties.IsFloatValue = False
        Me.tBimestre.Properties.Mask.EditMask = "N00"
        Me.tBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Size = New System.Drawing.Size(39, 22)
        Me.tBimestre.TabIndex = 4
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(15, 35)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = True
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.DisplayFormat.FormatString = "y"
        Me.tAno.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tAno.Properties.EditFormat.FormatString = "y"
        Me.tAno.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(57, 22)
        Me.tAno.TabIndex = 174
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(83, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Bimestre:"
        '
        'listarTodos
        '
        Me.listarTodos.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listarTodos.Appearance.Options.UseFont = True
        Me.listarTodos.Location = New System.Drawing.Point(455, 35)
        Me.listarTodos.Name = "listarTodos"
        Me.listarTodos.Size = New System.Drawing.Size(122, 23)
        Me.listarTodos.TabIndex = 2
        Me.listarTodos.Text = "Todos da Escola"
        '
        'listarBVJ
        '
        Me.listarBVJ.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listarBVJ.Appearance.Options.UseFont = True
        Me.listarBVJ.Location = New System.Drawing.Point(310, 35)
        Me.listarBVJ.Name = "listarBVJ"
        Me.listarBVJ.Size = New System.Drawing.Size(143, 23)
        Me.listarBVJ.TabIndex = 1
        Me.listarBVJ.Text = "Bolsa Variável Jovem"
        '
        'listarBolsaFamilia
        '
        Me.listarBolsaFamilia.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listarBolsaFamilia.Appearance.Options.UseFont = True
        Me.listarBolsaFamilia.Location = New System.Drawing.Point(186, 35)
        Me.listarBolsaFamilia.Name = "listarBolsaFamilia"
        Me.listarBolsaFamilia.Size = New System.Drawing.Size(122, 23)
        Me.listarBolsaFamilia.TabIndex = 0
        Me.listarBolsaFamilia.Text = "Bolsa Família"
        '
        'lbTurma
        '
        Me.lbTurma.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTurma.Location = New System.Drawing.Point(350, 352)
        Me.lbTurma.Name = "lbTurma"
        Me.lbTurma.Size = New System.Drawing.Size(115, 16)
        Me.lbTurma.TabIndex = 172
        Me.lbTurma.Text = "-"
        '
        'nroCodigo
        '
        Me.nroCodigo.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroCodigo.Location = New System.Drawing.Point(249, 352)
        Me.nroCodigo.Name = "nroCodigo"
        Me.nroCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nroCodigo.Properties.IsFloatValue = False
        Me.nroCodigo.Properties.Mask.EditMask = "N00"
        Me.nroCodigo.Properties.MaxValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroCodigo.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroCodigo.Size = New System.Drawing.Size(43, 20)
        Me.nroCodigo.TabIndex = 173
        '
        'btImprimir
        '
        Me.btImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Appearance.Options.UseFont = True
        Me.btImprimir.Enabled = False
        Me.btImprimir.Location = New System.Drawing.Point(353, 403)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(112, 23)
        Me.btImprimir.TabIndex = 175
        Me.btImprimir.Text = "Imprimir!"
        '
        'FrmAdmBolsas
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(584, 438)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.nroCodigo)
        Me.Controls.Add(Me.lbTurma)
        Me.Controls.Add(Me.gridBolsa)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.tbAluno)
        Me.Controls.Add(Me.btEfetuar)
        Me.Controls.Add(Me.rgBolsas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdmBolsas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bolsa de Estudos!"
        CType(Me.gridBolsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewBolsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgBolsas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAluno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nroCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridBolsa As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBolsa As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rgBolsas As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btEfetuar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbAluno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents listarTodos As DevExpress.XtraEditors.CheckButton
    Friend WithEvents listarBVJ As DevExpress.XtraEditors.CheckButton
    Friend WithEvents listarBolsaFamilia As DevExpress.XtraEditors.CheckButton
    Friend WithEvents lbTurma As System.Windows.Forms.Label
    Friend WithEvents nroCodigo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tBimestre As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
