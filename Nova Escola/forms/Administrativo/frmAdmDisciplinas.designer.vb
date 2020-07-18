Imports DevExpress.Skins

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmDisciplinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmDisciplinas))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btCadastrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btAlterar = New DevExpress.XtraEditors.SimpleButton()
        Me.gridDisciplinas = New DevExpress.XtraGrid.GridControl()
        Me.viewDisciplina = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.tbDisciplina = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridDisciplinas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewDisciplina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDisciplina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 361)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl1.TabIndex = 244
        Me.LabelControl1.Text = "Disciplina:"
        '
        'btCadastrar
        '
        Me.btCadastrar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCadastrar.Appearance.Options.UseFont = True
        Me.btCadastrar.Location = New System.Drawing.Point(378, 345)
        Me.btCadastrar.Name = "btCadastrar"
        Me.btCadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btCadastrar.TabIndex = 245
        Me.btCadastrar.Text = "Cadastrar"
        '
        'btAlterar
        '
        Me.btAlterar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlterar.Appearance.Options.UseFont = True
        Me.btAlterar.Enabled = False
        Me.btAlterar.Location = New System.Drawing.Point(378, 374)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btAlterar.TabIndex = 246
        Me.btAlterar.Text = "Alterar"
        '
        'gridDisciplinas
        '
        Me.gridDisciplinas.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridDisciplinas.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridDisciplinas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridDisciplinas.Location = New System.Drawing.Point(0, 0)
        Me.gridDisciplinas.MainView = Me.viewDisciplina
        Me.gridDisciplinas.Name = "gridDisciplinas"
        Me.gridDisciplinas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemComboBox1})
        Me.gridDisciplinas.Size = New System.Drawing.Size(465, 337)
        Me.gridDisciplinas.TabIndex = 247
        Me.gridDisciplinas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewDisciplina})
        '
        'viewDisciplina
        '
        Me.viewDisciplina.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewDisciplina.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.viewDisciplina.GridControl = Me.gridDisciplinas
        Me.viewDisciplina.Name = "viewDisciplina"
        Me.viewDisciplina.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'tbDisciplina
        '
        Me.tbDisciplina.EditValue = ""
        Me.tbDisciplina.Location = New System.Drawing.Point(88, 359)
        Me.tbDisciplina.Name = "tbDisciplina"
        Me.tbDisciplina.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDisciplina.Properties.Appearance.Options.UseFont = True
        Me.tbDisciplina.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbDisciplina.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbDisciplina.Size = New System.Drawing.Size(185, 22)
        Me.tbDisciplina.TabIndex = 248
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Location = New System.Drawing.Point(297, 374)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 249
        Me.SimpleButton1.Text = "Imprimir!"
        '
        'frmAdmDisciplinas
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(465, 406)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.tbDisciplina)
        Me.Controls.Add(Me.gridDisciplinas)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.btCadastrar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdmDisciplinas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Disciplinas"
        CType(Me.gridDisciplinas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewDisciplina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDisciplina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents btCadastrar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btAlterar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents gridDisciplinas As DevExpress.XtraGrid.GridControl
    Private WithEvents viewDisciplina As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Private WithEvents tbDisciplina As DevExpress.XtraEditors.TextEdit
    Private WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
