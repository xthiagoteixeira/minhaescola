Imports DevExpress.Skins

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmTurma
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
    'Do not modify it using the code editor...
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmTurma))
        Me.btCadastrar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbPeriodo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gridTurmas = New DevExpress.XtraGrid.GridControl()
        Me.viewTurmas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.cbEnsino = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tbClasse = New DevExpress.XtraEditors.TextEdit()
        Me.btExcluir = New DevExpress.XtraEditors.SimpleButton()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cbPeriodo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gridTurmas,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.viewTurmas,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemCheckEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemComboBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemComboBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbEnsino.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbClasse.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btCadastrar
        '
        Me.btCadastrar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btCadastrar.Appearance.Options.UseFont = true
        Me.btCadastrar.Location = New System.Drawing.Point(378, 369)
        Me.btCadastrar.Name = "btCadastrar"
        Me.btCadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btCadastrar.TabIndex = 249
        Me.btCadastrar.Text = "Cadastrar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 389)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 16)
        Me.LabelControl1.TabIndex = 251
        Me.LabelControl1.Text = "Classe:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(13, 417)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl2.TabIndex = 253
        Me.LabelControl2.Text = "Período:"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.EditValue = ""
        Me.cbPeriodo.Location = New System.Drawing.Point(63, 415)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPeriodo.Properties.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite", "Integral", "Intermediário", "Vespertino"})
        Me.cbPeriodo.Size = New System.Drawing.Size(126, 20)
        Me.cbPeriodo.TabIndex = 254
        '
        'gridTurmas
        '
        Me.gridTurmas.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridTurmas.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridTurmas.Location = New System.Drawing.Point(0, 0)
        Me.gridTurmas.MainView = Me.viewTurmas
        Me.gridTurmas.Name = "gridTurmas"
        Me.gridTurmas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemSpinEdit1})
        Me.gridTurmas.Size = New System.Drawing.Size(465, 361)
        Me.gridTurmas.TabIndex = 255
        Me.gridTurmas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewTurmas})
        '
        'viewTurmas
        '
        Me.viewTurmas.GridControl = Me.gridTurmas
        Me.viewTurmas.Name = "viewTurmas"
        Me.viewTurmas.OptionsView.ShowFooter = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'cbEnsino
        '
        Me.cbEnsino.EditValue = ""
        Me.cbEnsino.Location = New System.Drawing.Point(246, 415)
        Me.cbEnsino.Name = "cbEnsino"
        Me.cbEnsino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEnsino.Properties.Items.AddRange(New Object() {"EJA", "Fundamental", "Integral", "Médio", "Superior", "Técnico"})
        Me.cbEnsino.Size = New System.Drawing.Size(126, 20)
        Me.cbEnsino.TabIndex = 257
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(202, 417)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 16)
        Me.LabelControl3.TabIndex = 256
        Me.LabelControl3.Text = "Ensino:"
        '
        'tbClasse
        '
        Me.tbClasse.Location = New System.Drawing.Point(63, 386)
        Me.tbClasse.Name = "tbClasse"
        Me.tbClasse.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClasse.Properties.Appearance.Options.UseFont = True
        Me.tbClasse.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbClasse.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbClasse.Size = New System.Drawing.Size(309, 22)
        Me.tbClasse.TabIndex = 258
        '
        'btExcluir
        '
        Me.btExcluir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcluir.Appearance.Options.UseFont = True
        Me.btExcluir.Location = New System.Drawing.Point(378, 397)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btExcluir.TabIndex = 259
        Me.btExcluir.Text = "Excluir"
        '
        'btImprimir
        '
        Me.btImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.Appearance.Options.UseFont = True
        Me.btImprimir.Location = New System.Drawing.Point(378, 425)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btImprimir.TabIndex = 260
        Me.btImprimir.Text = "Imprimir!"
        '
        'frmAdmTurma
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(465, 459)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.tbClasse)
        Me.Controls.Add(Me.cbEnsino)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.gridTurmas)
        Me.Controls.Add(Me.cbPeriodo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btCadastrar)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAdmTurma"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Turmas"
        CType(Me.cbPeriodo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridTurmas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.viewTurmas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemCheckEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemComboBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemComboBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbEnsino.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbClasse.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btCadastrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbPeriodo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents gridTurmas As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewTurmas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cbEnsino As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents tbClasse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents btExcluir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
End Class
