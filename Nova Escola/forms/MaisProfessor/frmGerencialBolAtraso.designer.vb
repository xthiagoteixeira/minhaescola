<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerencialBolAtraso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerencialBolAtraso))
        Me.bwProcesso = New System.ComponentModel.BackgroundWorker()
        Me.barra = New DevExpress.XtraEditors.ProgressBarControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.nroBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.btEfetivar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbTurma = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbTodas = New DevExpress.XtraEditors.CheckEdit()
        Me.gridBoletim = New DevExpress.XtraGrid.GridControl()
        Me.viewBoletim = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cbAF = New DevExpress.XtraEditors.CheckButton()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nroBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTodas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bwProcesso
        '
        Me.bwProcesso.WorkerReportsProgress = True
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.barra.Location = New System.Drawing.Point(0, 407)
        Me.barra.Name = "barra"
        Me.barra.Properties.DisplayFormat.FormatString = " "
        Me.barra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.NullText = " "
        Me.barra.Properties.PercentView = False
        Me.barra.Properties.ShowTitle = True
        Me.barra.ShowProgressInTaskBar = True
        Me.barra.Size = New System.Drawing.Size(413, 26)
        Me.barra.TabIndex = 181
        Me.barra.Tag = ""
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(29, 463)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl1.TabIndex = 183
        Me.LabelControl1.Text = "Turma:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(17, 493)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl2.TabIndex = 184
        Me.LabelControl2.Text = "Bimestre:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(296, 446)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 16)
        Me.LabelControl3.TabIndex = 185
        Me.LabelControl3.Text = "Ano:"
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(326, 443)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = True
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(60, 22)
        Me.tAno.TabIndex = 186
        '
        'nroBimestre
        '
        Me.nroBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroBimestre.Location = New System.Drawing.Point(75, 490)
        Me.nroBimestre.Name = "nroBimestre"
        Me.nroBimestre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroBimestre.Properties.Appearance.Options.UseFont = True
        Me.nroBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nroBimestre.Properties.IsFloatValue = False
        Me.nroBimestre.Properties.Mask.EditMask = "N00"
        Me.nroBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nroBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroBimestre.Size = New System.Drawing.Size(34, 22)
        Me.nroBimestre.TabIndex = 187
        '
        'btEfetivar
        '
        Me.btEfetivar.Location = New System.Drawing.Point(296, 503)
        Me.btEfetivar.Name = "btEfetivar"
        Me.btEfetivar.Size = New System.Drawing.Size(90, 23)
        Me.btEfetivar.TabIndex = 189
        Me.btEfetivar.Text = "Efetivar!"
        '
        'cbTurma
        '
        Me.cbTurma.EditValue = ""
        Me.cbTurma.Location = New System.Drawing.Point(75, 460)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurma.Properties.Appearance.Options.UseFont = True
        Me.cbTurma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurma.Properties.NullText = "[EditValue is null]"
        Me.cbTurma.Properties.PopupSizeable = True
        Me.cbTurma.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbTurma.Size = New System.Drawing.Size(137, 22)
        Me.cbTurma.TabIndex = 182
        '
        'cbTodas
        '
        Me.cbTodas.Location = New System.Drawing.Point(151, 491)
        Me.cbTodas.Name = "cbTodas"
        Me.cbTodas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTodas.Properties.Appearance.Options.UseFont = True
        Me.cbTodas.Properties.Caption = "Todas as turmas"
        Me.cbTodas.Size = New System.Drawing.Size(121, 20)
        Me.cbTodas.TabIndex = 190
        '
        'gridBoletim
        '
        Me.gridBoletim.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridBoletim.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridBoletim.Location = New System.Drawing.Point(0, 0)
        Me.gridBoletim.MainView = Me.viewBoletim
        Me.gridBoletim.Name = "gridBoletim"
        Me.gridBoletim.Size = New System.Drawing.Size(413, 407)
        Me.gridBoletim.TabIndex = 191
        Me.gridBoletim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBoletim})
        '
        'viewBoletim
        '
        Me.viewBoletim.GridControl = Me.gridBoletim
        Me.viewBoletim.Name = "viewBoletim"
        Me.viewBoletim.OptionsBehavior.Editable = False
        '
        'btImprimir
        '
        Me.btImprimir.Enabled = False
        Me.btImprimir.Location = New System.Drawing.Point(296, 475)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(90, 23)
        Me.btImprimir.TabIndex = 192
        Me.btImprimir.Text = "Imprimir"
        '
        'cbAF
        '
        Me.cbAF.Location = New System.Drawing.Point(115, 490)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(30, 23)
        Me.cbAF.TabIndex = 193
        Me.cbAF.Text = "AF"
        '
        'frmGerencialBolAtraso
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(413, 536)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.cbTodas)
        Me.Controls.Add(Me.btEfetivar)
        Me.Controls.Add(Me.nroBimestre)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.gridBoletim)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGerencialBolAtraso"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Boletins! - Boletins em Atraso"
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nroBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTodas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bwProcesso As System.ComponentModel.BackgroundWorker
    Friend WithEvents barra As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents nroBimestre As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btEfetivar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTurma As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbTodas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gridBoletim As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBoletim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckButton
End Class
