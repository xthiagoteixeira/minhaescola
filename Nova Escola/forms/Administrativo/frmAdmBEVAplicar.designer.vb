<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmBevAplicar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmBevAplicar))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridEvasao = New DevExpress.XtraGrid.GridControl()
        Me.viewEvasao = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbAF = New DevExpress.XtraEditors.CheckEdit()
        Me.cbTodas = New DevExpress.XtraEditors.CheckEdit()
        Me.cbTurma = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbDisciplina = New DevExpress.XtraEditors.LookUpEdit()
        Me.btPesquisar = New DevExpress.XtraEditors.SimpleButton()
        Me.bwConsulta = New System.ComponentModel.BackgroundWorker()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.tBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.bwAplicar = New System.ComponentModel.BackgroundWorker()
        Me.barraConsulta = New DevExpress.XtraEditors.ProgressBarControl()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.gridEvasao,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.viewEvasao,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbAF.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbTodas.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbTurma.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbDisciplina.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tBimestre.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.barraConsulta.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Ano:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Bimestre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Turma:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Disciplina:"
        '
        'gridEvasao
        '
        Me.gridEvasao.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridEvasao.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridEvasao.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gridEvasao.EmbeddedNavigator.Appearance.Options.UseFont = true
        Me.gridEvasao.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gridEvasao.Location = New System.Drawing.Point(0, 0)
        Me.gridEvasao.MainView = Me.viewEvasao
        Me.gridEvasao.Name = "gridEvasao"
        Me.gridEvasao.Size = New System.Drawing.Size(480, 261)
        Me.gridEvasao.TabIndex = 22
        Me.gridEvasao.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewEvasao})
        '
        'viewEvasao
        '
        Me.viewEvasao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.viewEvasao.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.viewEvasao.GridControl = Me.gridEvasao
        Me.viewEvasao.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.viewEvasao.Name = "viewEvasao"
        Me.viewEvasao.OptionsBehavior.Editable = false
        Me.viewEvasao.OptionsCustomization.AllowColumnMoving = false
        Me.viewEvasao.OptionsCustomization.AllowGroup = false
        Me.viewEvasao.OptionsCustomization.AllowRowSizing = true
        Me.viewEvasao.OptionsView.ShowGroupPanel = false
        Me.viewEvasao.RowHeight = 0
        '
        'btAplicar
        '
        Me.btAplicar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btAplicar.Appearance.Options.UseFont = true
        Me.btAplicar.Enabled = false
        Me.btAplicar.Location = New System.Drawing.Point(400, 358)
        Me.btAplicar.Name = "btAplicar"
        Me.btAplicar.Size = New System.Drawing.Size(67, 23)
        Me.btAplicar.TabIndex = 23
        Me.btAplicar.Text = "Efetuar!"
        '
        'cbAF
        '
        Me.cbAF.Location = New System.Drawing.Point(126, 356)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbAF.Properties.Appearance.Options.UseFont = true
        Me.cbAF.Properties.Caption = "Avaliação Final"
        Me.cbAF.Size = New System.Drawing.Size(107, 20)
        Me.cbAF.TabIndex = 24
        '
        'cbTodas
        '
        Me.cbTodas.Location = New System.Drawing.Point(326, 328)
        Me.cbTodas.Name = "cbTodas"
        Me.cbTodas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbTodas.Properties.Appearance.Options.UseFont = true
        Me.cbTodas.Properties.Caption = "Todas as disciplinas"
        Me.cbTodas.Size = New System.Drawing.Size(136, 20)
        Me.cbTodas.TabIndex = 25
        '
        'cbTurma
        '
        Me.cbTurma.EditValue = ""
        Me.cbTurma.Location = New System.Drawing.Point(79, 299)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbTurma.Properties.Appearance.Options.UseFont = true
        Me.cbTurma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurma.Properties.NullText = ""
        Me.cbTurma.Size = New System.Drawing.Size(215, 22)
        Me.cbTurma.TabIndex = 28
        '
        'cbDisciplina
        '
        Me.cbDisciplina.EditValue = ""
        Me.cbDisciplina.Location = New System.Drawing.Point(79, 327)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbDisciplina.Properties.Appearance.Options.UseFont = true
        Me.cbDisciplina.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDisciplina.Properties.NullText = ""
        Me.cbDisciplina.Size = New System.Drawing.Size(215, 22)
        Me.cbDisciplina.TabIndex = 29
        '
        'btPesquisar
        '
        Me.btPesquisar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btPesquisar.Appearance.Options.UseFont = true
        Me.btPesquisar.Location = New System.Drawing.Point(326, 358)
        Me.btPesquisar.Name = "btPesquisar"
        Me.btPesquisar.Size = New System.Drawing.Size(67, 23)
        Me.btPesquisar.TabIndex = 30
        Me.btPesquisar.Text = "Pesquisar!"
        '
        'bwConsulta
        '
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(403, 301)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = false
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(59, 20)
        Me.tAno.TabIndex = 32
        '
        'tBimestre
        '
        Me.tBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Location = New System.Drawing.Point(79, 357)
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tBimestre.Properties.IsFloatValue = false
        Me.tBimestre.Properties.Mask.EditMask = "N00"
        Me.tBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Size = New System.Drawing.Size(41, 20)
        Me.tBimestre.TabIndex = 33
        '
        'bwAplicar
        '
        Me.bwAplicar.WorkerReportsProgress = true
        '
        'barraConsulta
        '
        Me.barraConsulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.barraConsulta.Location = New System.Drawing.Point(0, 261)
        Me.barraConsulta.Name = "barraConsulta"
        Me.barraConsulta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.barraConsulta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.barraConsulta.Properties.DisplayFormat.FormatString = "."
        Me.barraConsulta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barraConsulta.Properties.ShowTitle = true
        Me.barraConsulta.ShowProgressInTaskBar = true
        Me.barraConsulta.Size = New System.Drawing.Size(480, 23)
        Me.barraConsulta.TabIndex = 34
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'frmAdmBevAplicar
        '
        Me.Appearance.Options.UseFont = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(480, 390)
        Me.Controls.Add(Me.barraConsulta)
        Me.Controls.Add(Me.tBimestre)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.btPesquisar)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.cbTodas)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.btAplicar)
        Me.Controls.Add(Me.gridEvasao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Office 2013"
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAdmBevAplicar"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicar Evasão Escolar"
        CType(Me.gridEvasao,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.viewEvasao,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbAF.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbTodas.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbTurma.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbDisciplina.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tBimestre.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.barraConsulta.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridEvasao As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewEvasao As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbTodas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbTurma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbDisciplina As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btPesquisar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bwConsulta As System.ComponentModel.BackgroundWorker
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tBimestre As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents bwAplicar As System.ComponentModel.BackgroundWorker
    Friend WithEvents barraConsulta As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
