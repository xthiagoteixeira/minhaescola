<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMPreparar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBMPreparar))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbDriver = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.linkDotNet = New System.Windows.Forms.LinkLabel()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbProfessor = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbProfessor = New DevExpress.XtraEditors.LookUpEdit()
        Me.btPreparar = New DevExpress.XtraEditors.SimpleButton()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.cbApagar = New DevExpress.XtraEditors.CheckEdit()
        Me.cbAlunos = New DevExpress.XtraEditors.CheckEdit()
        Me.cbEvasaoEscolar = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gridAtribuicao = New DevExpress.XtraGrid.GridControl()
        Me.viewAtribuicao = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox3.SuspendLayout
        CType(Me.cbDriver.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.cbProfessor.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbApagar.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbAlunos.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbEvasaoEscolar.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.gridAtribuicao,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.viewAtribuicao,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.Location = New System.Drawing.Point(379, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "Ano Letivo:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbDriver)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 254)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 55)
        Me.GroupBox3.TabIndex = 195
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Escolha o drive"
        '
        'cbDriver
        '
        Me.cbDriver.Location = New System.Drawing.Point(105, 22)
        Me.cbDriver.Name = "cbDriver"
        Me.cbDriver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDriver.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbDriver.Size = New System.Drawing.Size(71, 20)
        Me.cbDriver.TabIndex = 212
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.Location = New System.Drawing.Point(54, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 14)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "Disco:"
        '
        'linkDotNet
        '
        Me.linkDotNet.Dock = System.Windows.Forms.DockStyle.Top
        Me.linkDotNet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.linkDotNet.Location = New System.Drawing.Point(0, 238)
        Me.linkDotNet.Name = "linkDotNet"
        Me.linkDotNet.Size = New System.Drawing.Size(516, 17)
        Me.linkDotNet.TabIndex = 211
        Me.linkDotNet.TabStop = true
        Me.linkDotNet.Text = "Professor não consegue usar?"
        Me.linkDotNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = true
        Me.rbTodos.Checked = true
        Me.rbTodos.Location = New System.Drawing.Point(8, 11)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(185, 20)
        Me.rbTodos.TabIndex = 215
        Me.rbTodos.TabStop = true
        Me.rbTodos.Text = "Todas as turmas/disciplinas"
        Me.rbTodos.UseVisualStyleBackColor = true
        '
        'rbProfessor
        '
        Me.rbProfessor.AutoSize = true
        Me.rbProfessor.Location = New System.Drawing.Point(8, 30)
        Me.rbProfessor.Name = "rbProfessor"
        Me.rbProfessor.Size = New System.Drawing.Size(137, 20)
        Me.rbProfessor.TabIndex = 216
        Me.rbProfessor.Text = "Escolher professor:"
        Me.rbProfessor.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.cbProfessor)
        Me.GroupBox1.Controls.Add(Me.rbProfessor)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(271, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 55)
        Me.GroupBox1.TabIndex = 217
        Me.GroupBox1.TabStop = false
        '
        'cbProfessor
        '
        Me.cbProfessor.Enabled = false
        Me.cbProfessor.Location = New System.Drawing.Point(142, 31)
        Me.cbProfessor.Name = "cbProfessor"
        Me.cbProfessor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProfessor.Properties.NullText = ""
        Me.cbProfessor.Properties.PopupSizeable = false
        Me.cbProfessor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbProfessor.Size = New System.Drawing.Size(91, 20)
        Me.cbProfessor.TabIndex = 217
        '
        'btPreparar
        '
        Me.btPreparar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btPreparar.Appearance.Options.UseFont = true
        Me.btPreparar.Enabled = false
        Me.btPreparar.Location = New System.Drawing.Point(434, 346)
        Me.btPreparar.Name = "btPreparar"
        Me.btPreparar.Size = New System.Drawing.Size(75, 23)
        Me.btPreparar.TabIndex = 219
        Me.btPreparar.Text = "Preparar!"
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(453, 313)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = true
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.Mask.EditMask = "d"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(56, 22)
        Me.tAno.TabIndex = 220
        '
        'cbApagar
        '
        Me.cbApagar.Location = New System.Drawing.Point(7, 315)
        Me.cbApagar.Name = "cbApagar"
        Me.cbApagar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbApagar.Properties.Appearance.Options.UseFont = true
        Me.cbApagar.Properties.Caption = "Apagar dados antigos"
        Me.cbApagar.Size = New System.Drawing.Size(149, 20)
        Me.cbApagar.TabIndex = 221
        '
        'cbAlunos
        '
        Me.cbAlunos.EditValue = true
        Me.cbAlunos.Location = New System.Drawing.Point(7, 333)
        Me.cbAlunos.Name = "cbAlunos"
        Me.cbAlunos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbAlunos.Properties.Appearance.Options.UseFont = true
        Me.cbAlunos.Properties.Caption = "Carregar Situação dos Alunos"
        Me.cbAlunos.Size = New System.Drawing.Size(195, 20)
        Me.cbAlunos.TabIndex = 222
        '
        'cbEvasaoEscolar
        '
        Me.cbEvasaoEscolar.Location = New System.Drawing.Point(7, 351)
        Me.cbEvasaoEscolar.Name = "cbEvasaoEscolar"
        Me.cbEvasaoEscolar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbEvasaoEscolar.Properties.Appearance.Options.UseFont = true
        Me.cbEvasaoEscolar.Properties.Caption = "Não permitir digitar Evasão Escolar"
        Me.cbEvasaoEscolar.Size = New System.Drawing.Size(223, 20)
        Me.cbEvasaoEscolar.TabIndex = 223
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = true
        Me.GroupControl1.Controls.Add(Me.gridAtribuicao)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(516, 238)
        Me.GroupControl1.TabIndex = 224
        Me.GroupControl1.Text = "Atribuição"
        '
        'gridAtribuicao
        '
        Me.gridAtribuicao.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridAtribuicao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAtribuicao.Location = New System.Drawing.Point(2, 23)
        Me.gridAtribuicao.MainView = Me.viewAtribuicao
        Me.gridAtribuicao.Name = "gridAtribuicao"
        Me.gridAtribuicao.Size = New System.Drawing.Size(512, 213)
        Me.gridAtribuicao.TabIndex = 0
        Me.gridAtribuicao.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewAtribuicao})
        '
        'viewAtribuicao
        '
        Me.viewAtribuicao.GridControl = Me.gridAtribuicao
        Me.viewAtribuicao.Name = "viewAtribuicao"
        Me.viewAtribuicao.OptionsBehavior.Editable = false
        '
        'frmBMPreparar
        '
        Me.Appearance.Options.UseFont = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(516, 379)
        Me.Controls.Add(Me.cbEvasaoEscolar)
        Me.Controls.Add(Me.cbAlunos)
        Me.Controls.Add(Me.cbApagar)
        Me.Controls.Add(Me.linkDotNet)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.btPreparar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmBMPreparar"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Professor! - Preparar Pen-drive"
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        CType(Me.cbDriver.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.cbProfessor.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbApagar.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbAlunos.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbEvasaoEscolar.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        CType(Me.gridAtribuicao,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.viewAtribuicao,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents linkDotNet As System.Windows.Forms.LinkLabel
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbProfessor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbDriver As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btPreparar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cbApagar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbAlunos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbEvasaoEscolar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbProfessor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridAtribuicao As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewAtribuicao As DevExpress.XtraGrid.Views.Grid.GridView
End Class
