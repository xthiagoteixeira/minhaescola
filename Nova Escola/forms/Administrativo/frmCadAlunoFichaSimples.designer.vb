<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadAlunoFichaSimples
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadAlunoFichaSimples))
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.tAno = New System.Windows.Forms.NumericUpDown()
        Me.cbTurma = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btSalvar = New DevExpress.XtraEditors.SimpleButton()
        Me.nroAluno = New DevExpress.XtraEditors.TextEdit()
        Me.tbRA_Digito = New DevExpress.XtraEditors.TextEdit()
        Me.tbRA = New DevExpress.XtraEditors.TextEdit()
        Me.tbNascimento = New DevExpress.XtraEditors.TextEdit()
        Me.tbAluno = New DevExpress.XtraEditors.TextEdit()
        Me.gridAlunos = New DevExpress.XtraGrid.GridControl()
        Me.viewAlunos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.nroAluno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRA_Digito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbNascimento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAluno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Turma:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "Ano:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Nascimento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "RA:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btImprimir)
        Me.GroupControl1.Controls.Add(Me.tAno)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.cbTurma)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 348)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(257, 117)
        Me.GroupControl1.TabIndex = 167
        Me.GroupControl1.Text = "Escolha a turma:"
        '
        'btImprimir
        '
        Me.btImprimir.Enabled = False
        Me.btImprimir.Location = New System.Drawing.Point(172, 86)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btImprimir.TabIndex = 175
        Me.btImprimir.Text = "Imprimir!"
        '
        'tAno
        '
        Me.tAno.Location = New System.Drawing.Point(52, 29)
        Me.tAno.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(61, 23)
        Me.tAno.TabIndex = 148
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'cbTurma
        '
        Me.cbTurma.Location = New System.Drawing.Point(71, 59)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTurma.Properties.Appearance.Options.UseFont = True
        Me.cbTurma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurma.Properties.NullText = ""
        Me.cbTurma.Properties.PopupSizeable = False
        Me.cbTurma.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbTurma.Size = New System.Drawing.Size(176, 22)
        Me.cbTurma.TabIndex = 149
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.btSalvar)
        Me.GroupControl2.Controls.Add(Me.nroAluno)
        Me.GroupControl2.Controls.Add(Me.tbRA_Digito)
        Me.GroupControl2.Controls.Add(Me.tbRA)
        Me.GroupControl2.Controls.Add(Me.tbNascimento)
        Me.GroupControl2.Controls.Add(Me.tbAluno)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Location = New System.Drawing.Point(268, 348)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(353, 117)
        Me.GroupControl2.TabIndex = 168
        Me.GroupControl2.Text = "Dados do Aluno"
        '
        'btSalvar
        '
        Me.btSalvar.Location = New System.Drawing.Point(268, 86)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.TabIndex = 170
        Me.btSalvar.Text = "Salvar!"
        '
        'nroAluno
        '
        Me.nroAluno.Location = New System.Drawing.Point(10, 30)
        Me.nroAluno.Name = "nroAluno"
        Me.nroAluno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroAluno.Properties.Appearance.Options.UseFont = True
        Me.nroAluno.Properties.Appearance.Options.UseTextOptions = True
        Me.nroAluno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nroAluno.Properties.MaxLength = 2
        Me.nroAluno.Size = New System.Drawing.Size(38, 22)
        Me.nroAluno.TabIndex = 174
        '
        'tbRA_Digito
        '
        Me.tbRA_Digito.Location = New System.Drawing.Point(316, 58)
        Me.tbRA_Digito.Name = "tbRA_Digito"
        Me.tbRA_Digito.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRA_Digito.Properties.Appearance.Options.UseFont = True
        Me.tbRA_Digito.Properties.MaxLength = 1
        Me.tbRA_Digito.Size = New System.Drawing.Size(27, 22)
        Me.tbRA_Digito.TabIndex = 173
        '
        'tbRA
        '
        Me.tbRA.Location = New System.Drawing.Point(205, 58)
        Me.tbRA.Name = "tbRA"
        Me.tbRA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRA.Properties.Appearance.Options.UseFont = True
        Me.tbRA.Size = New System.Drawing.Size(105, 22)
        Me.tbRA.TabIndex = 172
        '
        'tbNascimento
        '
        Me.tbNascimento.Location = New System.Drawing.Point(87, 59)
        Me.tbNascimento.Name = "tbNascimento"
        Me.tbNascimento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNascimento.Properties.Appearance.Options.UseFont = True
        Me.tbNascimento.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.tbNascimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.tbNascimento.Size = New System.Drawing.Size(82, 22)
        Me.tbNascimento.TabIndex = 171
        '
        'tbAluno
        '
        Me.tbAluno.Location = New System.Drawing.Point(106, 30)
        Me.tbAluno.Name = "tbAluno"
        Me.tbAluno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAluno.Properties.Appearance.Options.UseFont = True
        Me.tbAluno.Size = New System.Drawing.Size(237, 22)
        Me.tbAluno.TabIndex = 170
        '
        'gridAlunos
        '
        Me.gridAlunos.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridAlunos.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridAlunos.Location = New System.Drawing.Point(0, 0)
        Me.gridAlunos.MainView = Me.viewAlunos
        Me.gridAlunos.Name = "gridAlunos"
        Me.gridAlunos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2, Me.RepositoryItemComboBox1})
        Me.gridAlunos.Size = New System.Drawing.Size(627, 342)
        Me.gridAlunos.TabIndex = 169
        Me.gridAlunos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewAlunos})
        '
        'viewAlunos
        '
        Me.viewAlunos.GridControl = Me.gridAlunos
        Me.viewAlunos.Name = "viewAlunos"
        Me.viewAlunos.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemButtonEdit1
        '
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        EditorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(EditorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Nothing)})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        EditorButtonImageOptions2.Location = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(EditorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Nothing)})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'frmCadAlunoFichaSimples
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(627, 470)
        Me.Controls.Add(Me.gridAlunos)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadAlunoFichaSimples"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Alunos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.nroAluno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRA_Digito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbNascimento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAluno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tbRA_Digito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbRA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbNascimento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbAluno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nroAluno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btSalvar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTurma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridAlunos As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewAlunos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
