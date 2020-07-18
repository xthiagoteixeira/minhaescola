<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMGerenciar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAMGerenciar))
        Me.tabArquivoMorto = New DevExpress.XtraTab.XtraTabControl()
        Me.tabCorredor = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btSalvar_Corredor = New DevExpress.XtraEditors.SimpleButton()
        Me.tbCorredor = New DevExpress.XtraEditors.TextEdit()
        Me.gridCorredor = New DevExpress.XtraGrid.GridControl()
        Me.viewCorredor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tabEstante = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btSalvar_Estante = New DevExpress.XtraEditors.SimpleButton()
        Me.tbEstante = New DevExpress.XtraEditors.TextEdit()
        Me.gridEstantes = New DevExpress.XtraGrid.GridControl()
        Me.viewEstantes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tabPrateleiras = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btSalvar_Prateleira = New DevExpress.XtraEditors.SimpleButton()
        Me.tbPrateleira = New DevExpress.XtraEditors.TextEdit()
        Me.gridPrateleiras = New DevExpress.XtraGrid.GridControl()
        Me.viewPrateleiras = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tabTipoDoc = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btSalvar_Tipo = New DevExpress.XtraEditors.SimpleButton()
        Me.tbTipoDoc = New DevExpress.XtraEditors.TextEdit()
        Me.gridTipoDoc = New DevExpress.XtraGrid.GridControl()
        Me.viewTipoDoc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.tabArquivoMorto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabArquivoMorto.SuspendLayout()
        Me.tabCorredor.SuspendLayout()
        CType(Me.tbCorredor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCorredor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewCorredor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEstante.SuspendLayout()
        CType(Me.tbEstante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEstantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewEstantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrateleiras.SuspendLayout()
        CType(Me.tbPrateleira.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPrateleiras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewPrateleiras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTipoDoc.SuspendLayout()
        CType(Me.tbTipoDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabArquivoMorto
        '
        Me.tabArquivoMorto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabArquivoMorto.Location = New System.Drawing.Point(0, 0)
        Me.tabArquivoMorto.Name = "tabArquivoMorto"
        Me.tabArquivoMorto.SelectedTabPage = Me.tabCorredor
        Me.tabArquivoMorto.Size = New System.Drawing.Size(496, 199)
        Me.tabArquivoMorto.TabIndex = 0
        Me.tabArquivoMorto.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCorredor, Me.tabEstante, Me.tabPrateleiras, Me.tabTipoDoc})
        '
        'tabCorredor
        '
        Me.tabCorredor.Controls.Add(Me.LabelControl1)
        Me.tabCorredor.Controls.Add(Me.btSalvar_Corredor)
        Me.tabCorredor.Controls.Add(Me.tbCorredor)
        Me.tabCorredor.Controls.Add(Me.gridCorredor)
        Me.tabCorredor.Name = "tabCorredor"
        Me.tabCorredor.Size = New System.Drawing.Size(494, 174)
        Me.tabCorredor.Text = "Corredor"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(180, 148)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Corredor:"
        '
        'btSalvar_Corredor
        '
        Me.btSalvar_Corredor.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar_Corredor.Appearance.Options.UseFont = True
        Me.btSalvar_Corredor.Location = New System.Drawing.Point(425, 144)
        Me.btSalvar_Corredor.Name = "btSalvar_Corredor"
        Me.btSalvar_Corredor.Size = New System.Drawing.Size(58, 23)
        Me.btSalvar_Corredor.TabIndex = 2
        Me.btSalvar_Corredor.Text = "Salvar!"
        '
        'tbCorredor
        '
        Me.tbCorredor.Location = New System.Drawing.Point(242, 145)
        Me.tbCorredor.Name = "tbCorredor"
        Me.tbCorredor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCorredor.Properties.Appearance.Options.UseFont = True
        Me.tbCorredor.Size = New System.Drawing.Size(166, 22)
        Me.tbCorredor.TabIndex = 1
        '
        'gridCorredor
        '
        Me.gridCorredor.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridCorredor.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridCorredor.Location = New System.Drawing.Point(0, 0)
        Me.gridCorredor.MainView = Me.viewCorredor
        Me.gridCorredor.Name = "gridCorredor"
        Me.gridCorredor.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gridCorredor.Size = New System.Drawing.Size(494, 137)
        Me.gridCorredor.TabIndex = 0
        Me.gridCorredor.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewCorredor})
        '
        'viewCorredor
        '
        Me.viewCorredor.GridControl = Me.gridCorredor
        Me.viewCorredor.Name = "viewCorredor"
        Me.viewCorredor.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'tabEstante
        '
        Me.tabEstante.Controls.Add(Me.LabelControl2)
        Me.tabEstante.Controls.Add(Me.btSalvar_Estante)
        Me.tabEstante.Controls.Add(Me.tbEstante)
        Me.tabEstante.Controls.Add(Me.gridEstantes)
        Me.tabEstante.Name = "tabEstante"
        Me.tabEstante.Size = New System.Drawing.Size(494, 174)
        Me.tabEstante.Text = "Estante"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(189, 148)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Estante:"
        '
        'btSalvar_Estante
        '
        Me.btSalvar_Estante.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar_Estante.Appearance.Options.UseFont = True
        Me.btSalvar_Estante.Location = New System.Drawing.Point(425, 144)
        Me.btSalvar_Estante.Name = "btSalvar_Estante"
        Me.btSalvar_Estante.Size = New System.Drawing.Size(58, 23)
        Me.btSalvar_Estante.TabIndex = 5
        Me.btSalvar_Estante.Text = "Salvar!"
        '
        'tbEstante
        '
        Me.tbEstante.Location = New System.Drawing.Point(242, 145)
        Me.tbEstante.Name = "tbEstante"
        Me.tbEstante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEstante.Properties.Appearance.Options.UseFont = True
        Me.tbEstante.Size = New System.Drawing.Size(166, 22)
        Me.tbEstante.TabIndex = 4
        '
        'gridEstantes
        '
        Me.gridEstantes.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridEstantes.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridEstantes.Location = New System.Drawing.Point(0, 0)
        Me.gridEstantes.MainView = Me.viewEstantes
        Me.gridEstantes.Name = "gridEstantes"
        Me.gridEstantes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.gridEstantes.Size = New System.Drawing.Size(494, 137)
        Me.gridEstantes.TabIndex = 1
        Me.gridEstantes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewEstantes})
        '
        'viewEstantes
        '
        Me.viewEstantes.GridControl = Me.gridEstantes
        Me.viewEstantes.Name = "viewEstantes"
        Me.viewEstantes.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'tabPrateleiras
        '
        Me.tabPrateleiras.Controls.Add(Me.LabelControl3)
        Me.tabPrateleiras.Controls.Add(Me.btSalvar_Prateleira)
        Me.tabPrateleiras.Controls.Add(Me.tbPrateleira)
        Me.tabPrateleiras.Controls.Add(Me.gridPrateleiras)
        Me.tabPrateleiras.Name = "tabPrateleiras"
        Me.tabPrateleiras.Size = New System.Drawing.Size(494, 174)
        Me.tabPrateleiras.Text = "Prateleira"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(179, 147)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Prateleira:"
        '
        'btSalvar_Prateleira
        '
        Me.btSalvar_Prateleira.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar_Prateleira.Appearance.Options.UseFont = True
        Me.btSalvar_Prateleira.Location = New System.Drawing.Point(425, 143)
        Me.btSalvar_Prateleira.Name = "btSalvar_Prateleira"
        Me.btSalvar_Prateleira.Size = New System.Drawing.Size(58, 23)
        Me.btSalvar_Prateleira.TabIndex = 5
        Me.btSalvar_Prateleira.Text = "Salvar!"
        '
        'tbPrateleira
        '
        Me.tbPrateleira.Location = New System.Drawing.Point(242, 144)
        Me.tbPrateleira.Name = "tbPrateleira"
        Me.tbPrateleira.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrateleira.Properties.Appearance.Options.UseFont = True
        Me.tbPrateleira.Size = New System.Drawing.Size(166, 22)
        Me.tbPrateleira.TabIndex = 4
        '
        'gridPrateleiras
        '
        Me.gridPrateleiras.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridPrateleiras.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridPrateleiras.Location = New System.Drawing.Point(0, 0)
        Me.gridPrateleiras.MainView = Me.viewPrateleiras
        Me.gridPrateleiras.Name = "gridPrateleiras"
        Me.gridPrateleiras.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3})
        Me.gridPrateleiras.Size = New System.Drawing.Size(494, 137)
        Me.gridPrateleiras.TabIndex = 1
        Me.gridPrateleiras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewPrateleiras})
        '
        'viewPrateleiras
        '
        Me.viewPrateleiras.GridControl = Me.gridPrateleiras
        Me.viewPrateleiras.Name = "viewPrateleiras"
        Me.viewPrateleiras.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'tabTipoDoc
        '
        Me.tabTipoDoc.Controls.Add(Me.LabelControl4)
        Me.tabTipoDoc.Controls.Add(Me.btSalvar_Tipo)
        Me.tabTipoDoc.Controls.Add(Me.tbTipoDoc)
        Me.tabTipoDoc.Controls.Add(Me.gridTipoDoc)
        Me.tabTipoDoc.Name = "tabTipoDoc"
        Me.tabTipoDoc.Size = New System.Drawing.Size(494, 174)
        Me.tabTipoDoc.Text = "Tipo de Documento"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(209, 148)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Tipo:"
        '
        'btSalvar_Tipo
        '
        Me.btSalvar_Tipo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar_Tipo.Appearance.Options.UseFont = True
        Me.btSalvar_Tipo.Location = New System.Drawing.Point(425, 144)
        Me.btSalvar_Tipo.Name = "btSalvar_Tipo"
        Me.btSalvar_Tipo.Size = New System.Drawing.Size(58, 23)
        Me.btSalvar_Tipo.TabIndex = 5
        Me.btSalvar_Tipo.Text = "Salvar!"
        '
        'tbTipoDoc
        '
        Me.tbTipoDoc.Location = New System.Drawing.Point(242, 145)
        Me.tbTipoDoc.Name = "tbTipoDoc"
        Me.tbTipoDoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTipoDoc.Properties.Appearance.Options.UseFont = True
        Me.tbTipoDoc.Size = New System.Drawing.Size(166, 22)
        Me.tbTipoDoc.TabIndex = 4
        '
        'gridTipoDoc
        '
        Me.gridTipoDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridTipoDoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridTipoDoc.Location = New System.Drawing.Point(0, 0)
        Me.gridTipoDoc.MainView = Me.viewTipoDoc
        Me.gridTipoDoc.Name = "gridTipoDoc"
        Me.gridTipoDoc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit4})
        Me.gridTipoDoc.Size = New System.Drawing.Size(494, 137)
        Me.gridTipoDoc.TabIndex = 1
        Me.gridTipoDoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewTipoDoc})
        '
        'viewTipoDoc
        '
        Me.viewTipoDoc.GridControl = Me.gridTipoDoc
        Me.viewTipoDoc.Name = "viewTipoDoc"
        Me.viewTipoDoc.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'frmAMGerenciar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(496, 199)
        Me.Controls.Add(Me.tabArquivoMorto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAMGerenciar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arquivo Morto! - Gerenciar"
        CType(Me.tabArquivoMorto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabArquivoMorto.ResumeLayout(False)
        Me.tabCorredor.ResumeLayout(False)
        Me.tabCorredor.PerformLayout()
        CType(Me.tbCorredor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCorredor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewCorredor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEstante.ResumeLayout(False)
        Me.tabEstante.PerformLayout()
        CType(Me.tbEstante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEstantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewEstantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrateleiras.ResumeLayout(False)
        Me.tabPrateleiras.PerformLayout()
        CType(Me.tbPrateleira.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPrateleiras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewPrateleiras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTipoDoc.ResumeLayout(False)
        Me.tabTipoDoc.PerformLayout()
        CType(Me.tbTipoDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabArquivoMorto As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCorredor As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabEstante As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPrateleiras As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTipoDoc As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridCorredor As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewCorredor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridEstantes As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewEstantes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridPrateleiras As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewPrateleiras As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridTipoDoc As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewTipoDoc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSalvar_Corredor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbCorredor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSalvar_Estante As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbEstante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSalvar_Prateleira As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbPrateleira As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSalvar_Tipo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbTipoDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
