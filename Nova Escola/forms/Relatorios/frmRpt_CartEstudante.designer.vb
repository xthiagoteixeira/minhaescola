<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt_CartEstudante
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpt_CartEstudante))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.cbAlunos = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbTurmas = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.imprimirGrupo = New DevExpress.XtraEditors.RadioGroup()
        Me.gridAlunos = New DevExpress.XtraGrid.GridControl()
        Me.viewAlunos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.cbAlunos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTurmas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imprimirGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbAlunos
        '
        Me.cbAlunos.EditValue = ""
        Me.cbAlunos.Location = New System.Drawing.Point(81, 28)
        Me.cbAlunos.Name = "cbAlunos"
        Me.cbAlunos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAlunos.Properties.DropDownRows = 10
        Me.cbAlunos.Size = New System.Drawing.Size(154, 20)
        Me.cbAlunos.TabIndex = 250
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.tAno)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.btVisualizar)
        Me.GroupControl1.Controls.Add(Me.cbTurmas)
        Me.GroupControl1.Controls.Add(Me.cbAlunos)
        Me.GroupControl1.Controls.Add(Me.imprimirGrupo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 370)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(494, 78)
        Me.GroupControl1.TabIndex = 251
        Me.GroupControl1.Text = "Imprimir por:"
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(365, 25)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(56, 20)
        Me.tAno.TabIndex = 257
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(337, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 256
        Me.LabelControl2.Text = "Ano:"
        '
        'btVisualizar
        '
        Me.btVisualizar.Location = New System.Drawing.Point(316, 50)
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(130, 23)
        Me.btVisualizar.TabIndex = 252
        Me.btVisualizar.Text = "Visualizar!"
        '
        'cbTurmas
        '
        Me.cbTurmas.Enabled = False
        Me.cbTurmas.Location = New System.Drawing.Point(81, 52)
        Me.cbTurmas.Name = "cbTurmas"
        Me.cbTurmas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurmas.Size = New System.Drawing.Size(154, 20)
        Me.cbTurmas.TabIndex = 251
        '
        'imprimirGrupo
        '
        Me.imprimirGrupo.Dock = System.Windows.Forms.DockStyle.Left
        Me.imprimirGrupo.Location = New System.Drawing.Point(2, 20)
        Me.imprimirGrupo.Name = "imprimirGrupo"
        Me.imprimirGrupo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("0", "Alunos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Turmas")})
        Me.imprimirGrupo.Size = New System.Drawing.Size(257, 56)
        Me.imprimirGrupo.TabIndex = 0
        '
        'gridAlunos
        '
        Me.gridAlunos.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridAlunos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAlunos.Location = New System.Drawing.Point(2, 23)
        Me.gridAlunos.MainView = Me.viewAlunos
        Me.gridAlunos.Name = "gridAlunos"
        Me.gridAlunos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.gridAlunos.Size = New System.Drawing.Size(490, 345)
        Me.gridAlunos.TabIndex = 252
        Me.gridAlunos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewAlunos})
        '
        'viewAlunos
        '
        Me.viewAlunos.GridControl = Me.gridAlunos
        Me.viewAlunos.Name = "viewAlunos"
        Me.viewAlunos.OptionsFind.AlwaysVisible = True
        Me.viewAlunos.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.gridAlunos)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(494, 370)
        Me.GroupControl2.TabIndex = 253
        Me.GroupControl2.Text = "Pesquisa"
        '
        'frmRpt_CartEstudante
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(494, 448)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRpt_CartEstudante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório - Carteira de Estudante"
        CType(Me.cbAlunos.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbTurmas.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.imprimirGrupo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridAlunos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.viewAlunos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemButtonEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents cbAlunos As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents imprimirGrupo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents gridAlunos As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewAlunos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbTurmas As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
