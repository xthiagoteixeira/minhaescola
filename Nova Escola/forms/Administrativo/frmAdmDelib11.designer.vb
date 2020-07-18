<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmDelib11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmDelib11))
        Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.tabDescricao = New DevExpress.XtraTab.XtraTabPage()
        Me.tbDescricao = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btDescricaoAlt = New DevExpress.XtraEditors.SimpleButton()
        Me.btDescricaoCad = New DevExpress.XtraEditors.SimpleButton()
        Me.gridDescricao = New DevExpress.XtraGrid.GridControl()
        Me.ViewDescricao = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cbCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.tabCategorias = New DevExpress.XtraTab.XtraTabPage()
        Me.tbCategoria = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btCategoriaAlt = New DevExpress.XtraEditors.SimpleButton()
        Me.gridCategorias = New DevExpress.XtraGrid.GridControl()
        Me.ViewCategorias = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.tabDescricao.SuspendLayout()
        CType(Me.tbDescricao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDescricao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewDescricao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCategorias.SuspendLayout()
        CType(Me.tbCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedTabPage = Me.tabDescricao
        Me.tabControl.Size = New System.Drawing.Size(417, 330)
        Me.tabControl.TabIndex = 1
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDescricao, Me.tabCategorias})
        '
        'tabDescricao
        '
        Me.tabDescricao.Controls.Add(Me.tbDescricao)
        Me.tabDescricao.Controls.Add(Me.LabelControl2)
        Me.tabDescricao.Controls.Add(Me.LabelControl1)
        Me.tabDescricao.Controls.Add(Me.btDescricaoAlt)
        Me.tabDescricao.Controls.Add(Me.btDescricaoCad)
        Me.tabDescricao.Controls.Add(Me.gridDescricao)
        Me.tabDescricao.Controls.Add(Me.cbCategoria)
        Me.tabDescricao.Name = "tabDescricao"
        Me.tabDescricao.Size = New System.Drawing.Size(415, 305)
        Me.tabDescricao.Text = "Descrição"
        '
        'tbDescricao
        '
        Me.tbDescricao.Location = New System.Drawing.Point(70, 238)
        Me.tbDescricao.Name = "tbDescricao"
        Me.tbDescricao.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbDescricao.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbDescricao.Size = New System.Drawing.Size(329, 20)
        Me.tbDescricao.TabIndex = 16
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 241)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Descrição:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 215)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Categoria:"
        '
        'btDescricaoAlt
        '
        Me.btDescricaoAlt.Enabled = False
        Me.btDescricaoAlt.Location = New System.Drawing.Point(324, 272)
        Me.btDescricaoAlt.Name = "btDescricaoAlt"
        Me.btDescricaoAlt.Size = New System.Drawing.Size(75, 23)
        Me.btDescricaoAlt.TabIndex = 10
        Me.btDescricaoAlt.Text = "Alterar"
        '
        'btDescricaoCad
        '
        Me.btDescricaoCad.Enabled = False
        Me.btDescricaoCad.Location = New System.Drawing.Point(231, 272)
        Me.btDescricaoCad.Name = "btDescricaoCad"
        Me.btDescricaoCad.Size = New System.Drawing.Size(75, 23)
        Me.btDescricaoCad.TabIndex = 9
        Me.btDescricaoCad.Text = "Cadastrar"
        '
        'gridDescricao
        '
        Me.gridDescricao.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridDescricao.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridDescricao.Location = New System.Drawing.Point(0, 0)
        Me.gridDescricao.MainView = Me.ViewDescricao
        Me.gridDescricao.Name = "gridDescricao"
        Me.gridDescricao.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.gridDescricao.Size = New System.Drawing.Size(415, 200)
        Me.gridDescricao.TabIndex = 0
        Me.gridDescricao.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewDescricao})
        '
        'ViewDescricao
        '
        Me.ViewDescricao.GridControl = Me.gridDescricao
        Me.ViewDescricao.Name = "ViewDescricao"
        Me.ViewDescricao.OptionsView.ShowFooter = True
        Me.ViewDescricao.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'cbCategoria
        '
        Me.cbCategoria.Location = New System.Drawing.Point(70, 212)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCategoria.Properties.NullText = ""
        Me.cbCategoria.Properties.PopupSizeable = False
        Me.cbCategoria.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbCategoria.Size = New System.Drawing.Size(329, 20)
        Me.cbCategoria.TabIndex = 14
        '
        'tabCategorias
        '
        Me.tabCategorias.Controls.Add(Me.tbCategoria)
        Me.tabCategorias.Controls.Add(Me.LabelControl3)
        Me.tabCategorias.Controls.Add(Me.btCategoriaAlt)
        Me.tabCategorias.Controls.Add(Me.gridCategorias)
        Me.tabCategorias.Name = "tabCategorias"
        Me.tabCategorias.Size = New System.Drawing.Size(411, 302)
        Me.tabCategorias.Text = "Categorias"
        '
        'tbCategoria
        '
        Me.tbCategoria.Location = New System.Drawing.Point(67, 227)
        Me.tbCategoria.Name = "tbCategoria"
        Me.tbCategoria.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbCategoria.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbCategoria.Size = New System.Drawing.Size(332, 20)
        Me.tbCategoria.TabIndex = 17
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 230)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Categoria:"
        '
        'btCategoriaAlt
        '
        Me.btCategoriaAlt.Enabled = False
        Me.btCategoriaAlt.Location = New System.Drawing.Point(324, 272)
        Me.btCategoriaAlt.Name = "btCategoriaAlt"
        Me.btCategoriaAlt.Size = New System.Drawing.Size(75, 23)
        Me.btCategoriaAlt.TabIndex = 15
        Me.btCategoriaAlt.Text = "Alterar"
        '
        'gridCategorias
        '
        Me.gridCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridCategorias.Location = New System.Drawing.Point(0, 0)
        Me.gridCategorias.MainView = Me.ViewCategorias
        Me.gridCategorias.Name = "gridCategorias"
        Me.gridCategorias.Size = New System.Drawing.Size(411, 200)
        Me.gridCategorias.TabIndex = 0
        Me.gridCategorias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ViewCategorias})
        '
        'ViewCategorias
        '
        Me.ViewCategorias.GridControl = Me.gridCategorias
        Me.ViewCategorias.Name = "ViewCategorias"
        Me.ViewCategorias.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ViewCategorias.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ViewCategorias.OptionsBehavior.Editable = False
        Me.ViewCategorias.OptionsView.ShowFooter = True
        Me.ViewCategorias.OptionsView.ShowGroupPanel = False
        '
        'FrmAdmDelib11
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(417, 330)
        Me.Controls.Add(Me.tabControl)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdmDelib11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deliberação 11 - Configuração"
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.tabDescricao.ResumeLayout(False)
        Me.tabDescricao.PerformLayout()
        CType(Me.tbDescricao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDescricao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDescricao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCategorias.ResumeLayout(False)
        Me.tabCategorias.PerformLayout()
        CType(Me.tbCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabDescricao As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btDescricaoAlt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btDescricaoCad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridDescricao As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewDescricao As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabCategorias As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btCategoriaAlt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridCategorias As DevExpress.XtraGrid.GridControl
    Friend WithEvents ViewCategorias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCategoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents tbDescricao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbCategoria As DevExpress.XtraEditors.TextEdit
End Class
