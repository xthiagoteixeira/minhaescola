<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManAulasPrevistas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManAulasPrevistas))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gridBoletins = New DevExpress.XtraGrid.GridControl()
        Me.viewBoletins = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.nroBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.cbTurma = New DevExpress.XtraEditors.LookUpEdit()
        Me.bwBoletins = New System.ComponentModel.BackgroundWorker()
        Me.barra = New DevExpress.XtraEditors.ProgressBarControl()
        Me.cbAF = New DevExpress.XtraEditors.CheckButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.btAtualizar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridBoletins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBoletins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nroBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 14)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Ano:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(146, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Bimestre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Turma:"
        '
        'gridBoletins
        '
        Me.gridBoletins.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridBoletins.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridBoletins.Location = New System.Drawing.Point(0, 106)
        Me.gridBoletins.MainView = Me.viewBoletins
        Me.gridBoletins.Name = "gridBoletins"
        Me.gridBoletins.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemCheckEdit1})
        Me.gridBoletins.Size = New System.Drawing.Size(461, 313)
        Me.gridBoletins.TabIndex = 10
        Me.gridBoletins.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBoletins})
        '
        'viewBoletins
        '
        Me.viewBoletins.GridControl = Me.gridBoletins
        Me.viewBoletins.Name = "viewBoletins"
        Me.viewBoletins.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2017, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(86, 13)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = True
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(57, 20)
        Me.tAno.TabIndex = 11
        '
        'nroBimestre
        '
        Me.nroBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroBimestre.Location = New System.Drawing.Point(213, 13)
        Me.nroBimestre.Name = "nroBimestre"
        Me.nroBimestre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroBimestre.Properties.Appearance.Options.UseFont = True
        Me.nroBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nroBimestre.Properties.IsFloatValue = False
        Me.nroBimestre.Properties.Mask.EditMask = "N00"
        Me.nroBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nroBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroBimestre.Size = New System.Drawing.Size(39, 20)
        Me.nroBimestre.TabIndex = 12
        '
        'cbTurma
        '
        Me.cbTurma.EditValue = ""
        Me.cbTurma.Location = New System.Drawing.Point(86, 39)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurma.Properties.Appearance.Options.UseFont = True
        Me.cbTurma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurma.Properties.NullText = ""
        Me.cbTurma.Size = New System.Drawing.Size(194, 20)
        Me.cbTurma.TabIndex = 13
        '
        'bwBoletins
        '
        Me.bwBoletins.WorkerReportsProgress = True
        Me.bwBoletins.WorkerSupportsCancellation = True
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.Location = New System.Drawing.Point(0, 81)
        Me.barra.Name = "barra"
        Me.barra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.ShowTitle = True
        Me.barra.ShowProgressInTaskBar = True
        Me.barra.Size = New System.Drawing.Size(461, 25)
        Me.barra.TabIndex = 16
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Enabled = False
        Me.cbAF.Location = New System.Drawing.Point(258, 12)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(20, 22)
        Me.cbAF.TabIndex = 17
        Me.cbAF.Text = "AF"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(293, 13)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Todos os bimestres"
        Me.CheckEdit1.Size = New System.Drawing.Size(116, 19)
        Me.CheckEdit1.TabIndex = 18
        '
        'btAtualizar
        '
        Me.btAtualizar.Enabled = False
        Me.btAtualizar.Location = New System.Drawing.Point(374, 47)
        Me.btAtualizar.Name = "btAtualizar"
        Me.btAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btAtualizar.TabIndex = 19
        Me.btAtualizar.Text = "Atualizar!"
        '
        'frmManAulasPrevistas
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(461, 419)
        Me.Controls.Add(Me.btAtualizar)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.cbAF)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.cbTurma)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nroBimestre)
        Me.Controls.Add(Me.gridBoletins)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tAno)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManAulasPrevistas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Boletins - Manutenção : Aulas Dadas e Previstas"
        CType(Me.gridBoletins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewBoletins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nroBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gridBoletins As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBoletins As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents nroBimestre As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cbTurma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bwBoletins As System.ComponentModel.BackgroundWorker
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents barra As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btAtualizar As DevExpress.XtraEditors.SimpleButton
End Class
