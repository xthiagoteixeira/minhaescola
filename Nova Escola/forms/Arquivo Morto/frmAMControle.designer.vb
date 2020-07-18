<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMControle
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAMControle))
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.gridPesquisa = New DevExpress.XtraGrid.GridControl()
        Me.viewPesquisa = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.tbLocalizacao_Pasta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.pbPesquisar = New DevExpress.XtraEditors.PictureEdit()
        Me.tbLocalizar_Pesquisa = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbLocalizar = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grupoMovimentacao = New DevExpress.XtraEditors.GroupControl()
        Me.btMovimentacao_Salvar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.tbMov_Descricao = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.gridMovimentacao = New DevExpress.XtraGrid.GridControl()
        Me.viewMovimentacao = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbMov_Data = New DevExpress.XtraEditors.DateEdit()
        Me.cbMov_Tipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridPesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewPesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocalizacao_Pasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.pbPesquisar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocalizar_Pesquisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLocalizar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoMovimentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoMovimentacao.SuspendLayout()
        CType(Me.tbMov_Descricao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMovimentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewMovimentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMov_Data.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMov_Data.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMov_Tipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridPesquisa
        '
        Me.gridPesquisa.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridPesquisa.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridPesquisa.Location = New System.Drawing.Point(2, 23)
        Me.gridPesquisa.MainView = Me.viewPesquisa
        Me.gridPesquisa.Name = "gridPesquisa"
        Me.gridPesquisa.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3})
        Me.gridPesquisa.Size = New System.Drawing.Size(703, 219)
        Me.gridPesquisa.TabIndex = 1
        Me.gridPesquisa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewPesquisa})
        '
        'viewPesquisa
        '
        Me.viewPesquisa.GridControl = Me.gridPesquisa
        Me.viewPesquisa.Name = "viewPesquisa"
        Me.viewPesquisa.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Mais_Escola.My.Resources.Resources.file_edit
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
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
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'tbLocalizacao_Pasta
        '
        Me.tbLocalizacao_Pasta.EditValue = ""
        Me.tbLocalizacao_Pasta.Enabled = False
        Me.tbLocalizacao_Pasta.Location = New System.Drawing.Point(548, 33)
        Me.tbLocalizacao_Pasta.Name = "tbLocalizacao_Pasta"
        Me.tbLocalizacao_Pasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLocalizacao_Pasta.Properties.Appearance.Options.UseFont = True
        Me.tbLocalizacao_Pasta.Size = New System.Drawing.Size(142, 22)
        Me.tbLocalizacao_Pasta.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(506, 36)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Pasta:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.btImprimir)
        Me.GroupControl2.Controls.Add(Me.pbPesquisar)
        Me.GroupControl2.Controls.Add(Me.tbLocalizar_Pesquisa)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.gridPesquisa)
        Me.GroupControl2.Controls.Add(Me.cbLocalizar)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(707, 276)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "Pesquisa"
        '
        'pbPesquisar
        '
        Me.pbPesquisar.EditValue = CType(resources.GetObject("pbPesquisar.EditValue"), Object)
        Me.pbPesquisar.Location = New System.Drawing.Point(681, 249)
        Me.pbPesquisar.Name = "pbPesquisar"
        Me.pbPesquisar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pbPesquisar.Size = New System.Drawing.Size(22, 22)
        Me.pbPesquisar.TabIndex = 12
        '
        'tbLocalizar_Pesquisa
        '
        Me.tbLocalizar_Pesquisa.Enabled = False
        Me.tbLocalizar_Pesquisa.Location = New System.Drawing.Point(388, 249)
        Me.tbLocalizar_Pesquisa.Name = "tbLocalizar_Pesquisa"
        Me.tbLocalizar_Pesquisa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLocalizar_Pesquisa.Properties.Appearance.Options.UseFont = True
        Me.tbLocalizar_Pesquisa.Size = New System.Drawing.Size(288, 22)
        Me.tbLocalizar_Pesquisa.TabIndex = 11
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(207, 252)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 16)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Localizar por:"
        '
        'cbLocalizar
        '
        Me.cbLocalizar.EditValue = "Todos"
        Me.cbLocalizar.Location = New System.Drawing.Point(287, 249)
        Me.cbLocalizar.Name = "cbLocalizar"
        Me.cbLocalizar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLocalizar.Properties.Appearance.Options.UseFont = True
        Me.cbLocalizar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLocalizar.Properties.Items.AddRange(New Object() {"Mãe", "Nascimento", "Nome", "RA", "RM", "Todos"})
        Me.cbLocalizar.Size = New System.Drawing.Size(95, 22)
        Me.cbLocalizar.TabIndex = 10
        '
        'grupoMovimentacao
        '
        Me.grupoMovimentacao.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoMovimentacao.Appearance.Options.UseFont = True
        Me.grupoMovimentacao.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoMovimentacao.AppearanceCaption.Options.UseFont = True
        Me.grupoMovimentacao.Controls.Add(Me.tbLocalizacao_Pasta)
        Me.grupoMovimentacao.Controls.Add(Me.btMovimentacao_Salvar)
        Me.grupoMovimentacao.Controls.Add(Me.LabelControl4)
        Me.grupoMovimentacao.Controls.Add(Me.LabelControl8)
        Me.grupoMovimentacao.Controls.Add(Me.LabelControl7)
        Me.grupoMovimentacao.Controls.Add(Me.tbMov_Descricao)
        Me.grupoMovimentacao.Controls.Add(Me.LabelControl6)
        Me.grupoMovimentacao.Controls.Add(Me.gridMovimentacao)
        Me.grupoMovimentacao.Controls.Add(Me.cbMov_Data)
        Me.grupoMovimentacao.Controls.Add(Me.cbMov_Tipo)
        Me.grupoMovimentacao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupoMovimentacao.Location = New System.Drawing.Point(0, 282)
        Me.grupoMovimentacao.Name = "grupoMovimentacao"
        Me.grupoMovimentacao.Size = New System.Drawing.Size(707, 176)
        Me.grupoMovimentacao.TabIndex = 12
        Me.grupoMovimentacao.Text = "Movimentação de Documentos"
        '
        'btMovimentacao_Salvar
        '
        Me.btMovimentacao_Salvar.Enabled = False
        Me.btMovimentacao_Salvar.Location = New System.Drawing.Point(615, 147)
        Me.btMovimentacao_Salvar.Name = "btMovimentacao_Salvar"
        Me.btMovimentacao_Salvar.Size = New System.Drawing.Size(75, 23)
        Me.btMovimentacao_Salvar.TabIndex = 16
        Me.btMovimentacao_Salvar.Text = "Salvar!"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(511, 64)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Data:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(512, 92)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Tipo:"
        '
        'tbMov_Descricao
        '
        Me.tbMov_Descricao.EditValue = ""
        Me.tbMov_Descricao.Enabled = False
        Me.tbMov_Descricao.Location = New System.Drawing.Point(548, 117)
        Me.tbMov_Descricao.Name = "tbMov_Descricao"
        Me.tbMov_Descricao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMov_Descricao.Properties.Appearance.Options.UseFont = True
        Me.tbMov_Descricao.Size = New System.Drawing.Size(142, 22)
        Me.tbMov_Descricao.TabIndex = 11
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(482, 120)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Descrição:"
        '
        'gridMovimentacao
        '
        Me.gridMovimentacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridMovimentacao.Dock = System.Windows.Forms.DockStyle.Left
        Me.gridMovimentacao.Location = New System.Drawing.Point(2, 23)
        Me.gridMovimentacao.MainView = Me.viewMovimentacao
        Me.gridMovimentacao.Name = "gridMovimentacao"
        Me.gridMovimentacao.Size = New System.Drawing.Size(461, 151)
        Me.gridMovimentacao.TabIndex = 0
        Me.gridMovimentacao.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewMovimentacao})
        '
        'viewMovimentacao
        '
        Me.viewMovimentacao.GridControl = Me.gridMovimentacao
        Me.viewMovimentacao.Name = "viewMovimentacao"
        Me.viewMovimentacao.OptionsBehavior.Editable = False
        Me.viewMovimentacao.OptionsView.ShowGroupPanel = False
        '
        'cbMov_Data
        '
        Me.cbMov_Data.EditValue = Nothing
        Me.cbMov_Data.Enabled = False
        Me.cbMov_Data.Location = New System.Drawing.Point(548, 61)
        Me.cbMov_Data.Name = "cbMov_Data"
        Me.cbMov_Data.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMov_Data.Properties.Appearance.Options.UseFont = True
        Me.cbMov_Data.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMov_Data.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cbMov_Data.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.cbMov_Data.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.cbMov_Data.Size = New System.Drawing.Size(142, 22)
        Me.cbMov_Data.TabIndex = 15
        '
        'cbMov_Tipo
        '
        Me.cbMov_Tipo.EditValue = ""
        Me.cbMov_Tipo.Enabled = False
        Me.cbMov_Tipo.Location = New System.Drawing.Point(548, 89)
        Me.cbMov_Tipo.Name = "cbMov_Tipo"
        Me.cbMov_Tipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMov_Tipo.Properties.Appearance.Options.UseFont = True
        Me.cbMov_Tipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMov_Tipo.Properties.NullText = ""
        Me.cbMov_Tipo.Properties.PopupSizeable = False
        Me.cbMov_Tipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbMov_Tipo.Size = New System.Drawing.Size(142, 22)
        Me.cbMov_Tipo.TabIndex = 13
        '
        'btImprimir
        '
        Me.btImprimir.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.btImprimir.Location = New System.Drawing.Point(12, 248)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btImprimir.TabIndex = 13
        Me.btImprimir.Text = "Imprimir"
        '
        'frmAMControle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(707, 458)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.grupoMovimentacao)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAMControle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arquivo Morto! - Controle de Registros"
        CType(Me.gridPesquisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewPesquisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocalizacao_Pasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.pbPesquisar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocalizar_Pesquisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLocalizar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoMovimentacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoMovimentacao.ResumeLayout(False)
        Me.grupoMovimentacao.PerformLayout()
        CType(Me.tbMov_Descricao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMovimentacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewMovimentacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMov_Data.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMov_Data.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMov_Tipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewPesquisa As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tbLocalizacao_Pasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tbLocalizar_Pesquisa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grupoMovimentacao As DevExpress.XtraEditors.GroupControl
    Friend WithEvents viewMovimentacao As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbMov_Descricao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMov_Data As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btMovimentacao_Salvar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbMov_Tipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbLocalizar As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents pbPesquisar As DevExpress.XtraEditors.PictureEdit
    Private WithEvents gridPesquisa As DevExpress.XtraGrid.GridControl
    Private WithEvents gridMovimentacao As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
End Class
