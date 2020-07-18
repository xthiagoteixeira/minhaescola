<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt_BuscaAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpt_BuscaAluno))
        Me.gridAluno = New DevExpress.XtraGrid.GridControl()
        Me.viewAluno = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.checkAnos = New DevExpress.XtraEditors.CheckButton()
        Me.btBuscarAno = New DevExpress.XtraEditors.SimpleButton()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grupoRelatorio = New DevExpress.XtraEditors.RadioGroup()
        Me.btVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.bwAlunos = New System.ComponentModel.BackgroundWorker()
        Me.barra = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        CType(Me.gridAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoRelatorio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridAluno
        '
        Me.gridAluno.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridAluno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAluno.Location = New System.Drawing.Point(0, 0)
        Me.gridAluno.MainView = Me.viewAluno
        Me.gridAluno.Name = "gridAluno"
        Me.gridAluno.Size = New System.Drawing.Size(764, 530)
        Me.gridAluno.TabIndex = 0
        Me.gridAluno.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewAluno})
        '
        'viewAluno
        '
        Me.viewAluno.GridControl = Me.gridAluno
        Me.viewAluno.Name = "viewAluno"
        Me.viewAluno.OptionsFind.AlwaysVisible = True
        Me.viewAluno.OptionsFind.FindNullPrompt = "Digite aqui o nome para procurar..."
        Me.viewAluno.OptionsFind.SearchInPreview = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.checkAnos)
        Me.GroupControl1.Controls.Add(Me.btBuscarAno)
        Me.GroupControl1.Controls.Add(Me.tAno)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.grupoRelatorio)
        Me.GroupControl1.Controls.Add(Me.btVisualizar)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 548)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(764, 72)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Opções de Relatório"
        '
        'checkAnos
        '
        Me.checkAnos.Location = New System.Drawing.Point(18, 49)
        Me.checkAnos.Name = "checkAnos"
        Me.checkAnos.Size = New System.Drawing.Size(117, 19)
        Me.checkAnos.TabIndex = 261
        Me.checkAnos.Text = "Todos os Anos"
        '
        'btBuscarAno
        '
        Me.btBuscarAno.AutoSize = True
        Me.btBuscarAno.ImageOptions.Image = CType(resources.GetObject("btBuscarAno.ImageOptions.Image"), System.Drawing.Image)
        Me.btBuscarAno.Location = New System.Drawing.Point(110, 23)
        Me.btBuscarAno.Name = "btBuscarAno"
        Me.btBuscarAno.Size = New System.Drawing.Size(22, 22)
        Me.btBuscarAno.TabIndex = 260
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(46, 24)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(56, 20)
        Me.tAno.TabIndex = 259
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 258
        Me.LabelControl2.Text = "Ano:"
        '
        'grupoRelatorio
        '
        Me.grupoRelatorio.Location = New System.Drawing.Point(145, 30)
        Me.grupoRelatorio.Name = "grupoRelatorio"
        Me.grupoRelatorio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("FI", "Ficha Individual"), New DevExpress.XtraEditors.Controls.RadioGroupItem("BS", "Boletim Simples"), New DevExpress.XtraEditors.Controls.RadioGroupItem("BC", "Boletim Completo"), New DevExpress.XtraEditors.Controls.RadioGroupItem("HE", "Histórico Auxiliar")})
        Me.grupoRelatorio.Size = New System.Drawing.Size(528, 32)
        Me.grupoRelatorio.TabIndex = 3
        '
        'btVisualizar
        '
        Me.btVisualizar.Enabled = False
        Me.btVisualizar.ImageOptions.Image = CType(resources.GetObject("btVisualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.btVisualizar.Location = New System.Drawing.Point(681, 34)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btVisualizar.TabIndex = 2
        Me.btVisualizar.Text = "Visualizar!"
        '
        'bwAlunos
        '
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.EditValue = 0
        Me.barra.Location = New System.Drawing.Point(0, 530)
        Me.barra.Name = "barra"
        Me.barra.Properties.Paused = True
        Me.barra.Size = New System.Drawing.Size(764, 18)
        Me.barra.TabIndex = 2
        '
        'frmRpt_BuscaAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(764, 620)
        Me.Controls.Add(Me.gridAluno)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.GroupControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRpt_BuscaAluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios - Procurar Aluno"
        CType(Me.gridAluno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewAluno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoRelatorio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridAluno As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewAluno As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bwAlunos As System.ComponentModel.BackgroundWorker
    Friend WithEvents grupoRelatorio As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents barra As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btBuscarAno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkAnos As DevExpress.XtraEditors.CheckButton
End Class
