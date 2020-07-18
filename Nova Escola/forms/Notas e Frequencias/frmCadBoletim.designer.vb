<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadBoletim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadBoletim))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.btSalvar = New DevExpress.XtraEditors.SimpleButton()
        Me.gridBoletim = New DevExpress.XtraGrid.GridControl()
        Me.viewBoletim = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbAulasPrevistas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lbAulasDadas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbTotalAlunos = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbBimestre = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbDisciplina = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbTurma = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grupoAluno = New DevExpress.XtraEditors.GroupControl()
        Me.lbAluno_Faltas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbAluno_Media = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.grupoSalaDisciplina = New DevExpress.XtraEditors.GroupControl()
        Me.lbBoletim_Faltas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.lbBoletim_Media = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.bwSala = New System.ComponentModel.BackgroundWorker()
        Me.bwAluno = New System.ComponentModel.BackgroundWorker()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.lbSala_Evasao = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbSala_Faltas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.lbSala_Media = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.bwBoletim = New System.ComponentModel.BackgroundWorker()
        Me.tbMedia = New DevExpress.XtraEditors.TextEdit()
        Me.tbFaltas = New DevExpress.XtraEditors.TextEdit()
        Me.tbAC = New DevExpress.XtraEditors.TextEdit()
        Me.cbDisciplina = New DevExpress.XtraEditors.LookUpEdit()
        Me.tbNomeAluno = New DevExpress.XtraEditors.TextEdit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grupoAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoAluno.SuspendLayout()
        CType(Me.grupoSalaDisciplina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoSalaDisciplina.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.tbMedia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFaltas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDisciplina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbNomeAluno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 14)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "AV"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 14)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "FT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 14)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "AC"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.ForeColor = System.Drawing.Color.Blue
        Me.lbCodigo.Location = New System.Drawing.Point(72, 375)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(15, 14)
        Me.lbCodigo.TabIndex = 159
        Me.lbCodigo.Text = "0"
        '
        'btSalvar
        '
        Me.btSalvar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.Appearance.Options.UseFont = True
        Me.btSalvar.Location = New System.Drawing.Point(220, 425)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.TabIndex = 5
        Me.btSalvar.Text = "Salvar!"
        '
        'gridBoletim
        '
        Me.gridBoletim.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridBoletim.Location = New System.Drawing.Point(331, 36)
        Me.gridBoletim.MainView = Me.viewBoletim
        Me.gridBoletim.Name = "gridBoletim"
        Me.gridBoletim.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.gridBoletim.Size = New System.Drawing.Size(177, 412)
        Me.gridBoletim.TabIndex = 173
        Me.gridBoletim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBoletim})
        '
        'viewBoletim
        '
        Me.viewBoletim.GridControl = Me.gridBoletim
        Me.viewBoletim.Name = "viewBoletim"
        Me.viewBoletim.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.viewBoletim.OptionsView.ShowGroupPanel = False
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
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.lbAulasPrevistas)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.lbAulasDadas)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.lbTotalAlunos)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.lbBimestre)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.lbDisciplina)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.lbTurma)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(309, 116)
        Me.GroupControl1.TabIndex = 174
        Me.GroupControl1.Text = "Dados do Boletim"
        '
        'lbAulasPrevistas
        '
        Me.lbAulasPrevistas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAulasPrevistas.Appearance.Options.UseFont = True
        Me.lbAulasPrevistas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbAulasPrevistas.Location = New System.Drawing.Point(279, 95)
        Me.lbAulasPrevistas.Name = "lbAulasPrevistas"
        Me.lbAulasPrevistas.Size = New System.Drawing.Size(22, 14)
        Me.lbAulasPrevistas.TabIndex = 11
        Me.lbAulasPrevistas.Text = "00"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(180, 95)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(96, 14)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "Aulas Previstas:"
        '
        'lbAulasDadas
        '
        Me.lbAulasDadas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAulasDadas.Appearance.Options.UseFont = True
        Me.lbAulasDadas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbAulasDadas.Location = New System.Drawing.Point(279, 77)
        Me.lbAulasDadas.Name = "lbAulasDadas"
        Me.lbAulasDadas.Size = New System.Drawing.Size(20, 14)
        Me.lbAulasDadas.TabIndex = 9
        Me.lbAulasDadas.Text = "00"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(198, 77)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(78, 14)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "Aulas Dadas:"
        '
        'lbTotalAlunos
        '
        Me.lbTotalAlunos.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalAlunos.Appearance.Options.UseFont = True
        Me.lbTotalAlunos.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbTotalAlunos.Location = New System.Drawing.Point(71, 95)
        Me.lbTotalAlunos.Name = "lbTotalAlunos"
        Me.lbTotalAlunos.Size = New System.Drawing.Size(69, 14)
        Me.lbTotalAlunos.TabIndex = 7
        Me.lbTotalAlunos.Text = "00 alunos."
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(33, 95)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Total:"
        '
        'lbBimestre
        '
        Me.lbBimestre.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBimestre.Appearance.Options.UseFont = True
        Me.lbBimestre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbBimestre.Location = New System.Drawing.Point(74, 68)
        Me.lbBimestre.Name = "lbBimestre"
        Me.lbBimestre.Size = New System.Drawing.Size(85, 14)
        Me.lbBimestre.TabIndex = 5
        Me.lbBimestre.Text = "xxx"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(11, 68)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Bimestre:"
        '
        'lbDisciplina
        '
        Me.lbDisciplina.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDisciplina.Appearance.Options.UseFont = True
        Me.lbDisciplina.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbDisciplina.Location = New System.Drawing.Point(74, 46)
        Me.lbDisciplina.Name = "lbDisciplina"
        Me.lbDisciplina.Size = New System.Drawing.Size(229, 14)
        Me.lbDisciplina.TabIndex = 3
        Me.lbDisciplina.Text = "xxx"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(8, 46)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Disciplina:"
        '
        'lbTurma
        '
        Me.lbTurma.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTurma.Appearance.Options.UseFont = True
        Me.lbTurma.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbTurma.Location = New System.Drawing.Point(74, 24)
        Me.lbTurma.Name = "lbTurma"
        Me.lbTurma.Size = New System.Drawing.Size(229, 14)
        Me.lbTurma.TabIndex = 1
        Me.lbTurma.Text = "xxx"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(26, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Turma:"
        '
        'grupoAluno
        '
        Me.grupoAluno.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoAluno.Appearance.Options.UseFont = True
        Me.grupoAluno.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoAluno.AppearanceCaption.Options.UseFont = True
        Me.grupoAluno.Controls.Add(Me.lbAluno_Faltas)
        Me.grupoAluno.Controls.Add(Me.LabelControl8)
        Me.grupoAluno.Controls.Add(Me.lbAluno_Media)
        Me.grupoAluno.Controls.Add(Me.LabelControl6)
        Me.grupoAluno.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupoAluno.Location = New System.Drawing.Point(2, 21)
        Me.grupoAluno.Name = "grupoAluno"
        Me.grupoAluno.Size = New System.Drawing.Size(305, 57)
        Me.grupoAluno.TabIndex = 175
        Me.grupoAluno.Text = "Turma - Aluno nº1"
        '
        'lbAluno_Faltas
        '
        Me.lbAluno_Faltas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAluno_Faltas.Appearance.Options.UseFont = True
        Me.lbAluno_Faltas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbAluno_Faltas.Location = New System.Drawing.Point(145, 30)
        Me.lbAluno_Faltas.Name = "lbAluno_Faltas"
        Me.lbAluno_Faltas.Size = New System.Drawing.Size(25, 14)
        Me.lbAluno_Faltas.TabIndex = 11
        Me.lbAluno_Faltas.Text = "0,000"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(106, 29)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(34, 14)
        Me.LabelControl8.TabIndex = 10
        Me.LabelControl8.Text = "Faltas:"
        '
        'lbAluno_Media
        '
        Me.lbAluno_Media.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAluno_Media.Appearance.Options.UseFont = True
        Me.lbAluno_Media.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbAluno_Media.Location = New System.Drawing.Point(58, 30)
        Me.lbAluno_Media.Name = "lbAluno_Media"
        Me.lbAluno_Media.Size = New System.Drawing.Size(24, 14)
        Me.lbAluno_Media.TabIndex = 9
        Me.lbAluno_Media.Text = "0,00"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(18, 29)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "Média:"
        '
        'grupoSalaDisciplina
        '
        Me.grupoSalaDisciplina.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoSalaDisciplina.Appearance.Options.UseFont = True
        Me.grupoSalaDisciplina.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoSalaDisciplina.AppearanceCaption.Options.UseFont = True
        Me.grupoSalaDisciplina.Controls.Add(Me.lbBoletim_Faltas)
        Me.grupoSalaDisciplina.Controls.Add(Me.LabelControl15)
        Me.grupoSalaDisciplina.Controls.Add(Me.lbBoletim_Media)
        Me.grupoSalaDisciplina.Controls.Add(Me.LabelControl17)
        Me.grupoSalaDisciplina.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupoSalaDisciplina.Location = New System.Drawing.Point(2, 78)
        Me.grupoSalaDisciplina.Name = "grupoSalaDisciplina"
        Me.grupoSalaDisciplina.Size = New System.Drawing.Size(305, 63)
        Me.grupoSalaDisciplina.TabIndex = 176
        Me.grupoSalaDisciplina.Text = "Turma - Disciplina"
        '
        'lbBoletim_Faltas
        '
        Me.lbBoletim_Faltas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoletim_Faltas.Appearance.Options.UseFont = True
        Me.lbBoletim_Faltas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbBoletim_Faltas.Location = New System.Drawing.Point(145, 33)
        Me.lbBoletim_Faltas.Name = "lbBoletim_Faltas"
        Me.lbBoletim_Faltas.Size = New System.Drawing.Size(26, 14)
        Me.lbBoletim_Faltas.TabIndex = 11
        Me.lbBoletim_Faltas.Text = "0,000"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(106, 32)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(34, 14)
        Me.LabelControl15.TabIndex = 10
        Me.LabelControl15.Text = "Faltas:"
        '
        'lbBoletim_Media
        '
        Me.lbBoletim_Media.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBoletim_Media.Appearance.Options.UseFont = True
        Me.lbBoletim_Media.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbBoletim_Media.Location = New System.Drawing.Point(58, 33)
        Me.lbBoletim_Media.Name = "lbBoletim_Media"
        Me.lbBoletim_Media.Size = New System.Drawing.Size(24, 14)
        Me.lbBoletim_Media.TabIndex = 9
        Me.lbBoletim_Media.Text = "0,00"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(18, 32)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl17.TabIndex = 8
        Me.LabelControl17.Text = "Média:"
        '
        'bwAluno
        '
        '
        'GroupControl4
        '
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.Appearance.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.lbSala_Evasao)
        Me.GroupControl4.Controls.Add(Me.LabelControl11)
        Me.GroupControl4.Controls.Add(Me.lbSala_Faltas)
        Me.GroupControl4.Controls.Add(Me.LabelControl19)
        Me.GroupControl4.Controls.Add(Me.lbSala_Media)
        Me.GroupControl4.Controls.Add(Me.LabelControl21)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(2, 141)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(305, 63)
        Me.GroupControl4.TabIndex = 177
        Me.GroupControl4.Text = "Turma - Média"
        '
        'lbSala_Evasao
        '
        Me.lbSala_Evasao.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSala_Evasao.Appearance.Options.UseFont = True
        Me.lbSala_Evasao.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbSala_Evasao.Location = New System.Drawing.Point(229, 33)
        Me.lbSala_Evasao.Name = "lbSala_Evasao"
        Me.lbSala_Evasao.Size = New System.Drawing.Size(21, 14)
        Me.lbSala_Evasao.TabIndex = 13
        Me.lbSala_Evasao.Text = "00"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(183, 32)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(41, 14)
        Me.LabelControl11.TabIndex = 12
        Me.LabelControl11.Text = "Evasão:"
        '
        'lbSala_Faltas
        '
        Me.lbSala_Faltas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSala_Faltas.Appearance.Options.UseFont = True
        Me.lbSala_Faltas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbSala_Faltas.Location = New System.Drawing.Point(145, 33)
        Me.lbSala_Faltas.Name = "lbSala_Faltas"
        Me.lbSala_Faltas.Size = New System.Drawing.Size(25, 14)
        Me.lbSala_Faltas.TabIndex = 11
        Me.lbSala_Faltas.Text = "0,00"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(106, 32)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(34, 14)
        Me.LabelControl19.TabIndex = 10
        Me.LabelControl19.Text = "Faltas:"
        '
        'lbSala_Media
        '
        Me.lbSala_Media.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSala_Media.Appearance.Options.UseFont = True
        Me.lbSala_Media.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbSala_Media.Location = New System.Drawing.Point(58, 33)
        Me.lbSala_Media.Name = "lbSala_Media"
        Me.lbSala_Media.Size = New System.Drawing.Size(24, 14)
        Me.lbSala_Media.TabIndex = 9
        Me.lbSala_Media.Text = "0,00"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(18, 32)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(35, 14)
        Me.LabelControl21.TabIndex = 8
        Me.LabelControl21.Text = "Notas:"
        '
        'GroupControl5
        '
        Me.GroupControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.Appearance.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.Controls.Add(Me.GroupControl4)
        Me.GroupControl5.Controls.Add(Me.grupoSalaDisciplina)
        Me.GroupControl5.Controls.Add(Me.grupoAluno)
        Me.GroupControl5.Location = New System.Drawing.Point(11, 134)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(309, 212)
        Me.GroupControl5.TabIndex = 178
        Me.GroupControl5.Text = "Estatística"
        '
        'tbMedia
        '
        Me.tbMedia.Location = New System.Drawing.Point(93, 374)
        Me.tbMedia.Name = "tbMedia"
        Me.tbMedia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMedia.Properties.Appearance.Options.UseFont = True
        Me.tbMedia.Properties.Appearance.Options.UseTextOptions = True
        Me.tbMedia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbMedia.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tbMedia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbMedia.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMedia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbMedia.Properties.AppearanceFocused.Options.UseFont = True
        Me.tbMedia.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.tbMedia.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbMedia.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tbMedia.Size = New System.Drawing.Size(37, 20)
        Me.tbMedia.TabIndex = 1
        '
        'tbFaltas
        '
        Me.tbFaltas.Location = New System.Drawing.Point(162, 374)
        Me.tbFaltas.Name = "tbFaltas"
        Me.tbFaltas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFaltas.Properties.Appearance.Options.UseFont = True
        Me.tbFaltas.Properties.Appearance.Options.UseTextOptions = True
        Me.tbFaltas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbFaltas.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tbFaltas.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbFaltas.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFaltas.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbFaltas.Properties.AppearanceFocused.Options.UseFont = True
        Me.tbFaltas.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.tbFaltas.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbFaltas.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tbFaltas.Size = New System.Drawing.Size(37, 20)
        Me.tbFaltas.TabIndex = 2
        '
        'tbAC
        '
        Me.tbAC.Location = New System.Drawing.Point(234, 374)
        Me.tbAC.Name = "tbAC"
        Me.tbAC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAC.Properties.Appearance.Options.UseFont = True
        Me.tbAC.Properties.Appearance.Options.UseTextOptions = True
        Me.tbAC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbAC.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tbAC.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbAC.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAC.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbAC.Properties.AppearanceFocused.Options.UseFont = True
        Me.tbAC.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.tbAC.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbAC.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.tbAC.Size = New System.Drawing.Size(37, 20)
        Me.tbAC.TabIndex = 3
        '
        'cbDisciplina
        '
        Me.cbDisciplina.EditValue = ""
        Me.cbDisciplina.Location = New System.Drawing.Point(331, 12)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDisciplina.Properties.NullText = ""
        Me.cbDisciplina.Size = New System.Drawing.Size(177, 20)
        Me.cbDisciplina.TabIndex = 179
        '
        'tbNomeAluno
        '
        Me.tbNomeAluno.Location = New System.Drawing.Point(53, 399)
        Me.tbNomeAluno.Name = "tbNomeAluno"
        Me.tbNomeAluno.Size = New System.Drawing.Size(242, 20)
        Me.tbNomeAluno.TabIndex = 180
        '
        'frmCadBoletim
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(514, 454)
        Me.Controls.Add(Me.tbNomeAluno)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.tbAC)
        Me.Controls.Add(Me.tbFaltas)
        Me.Controls.Add(Me.tbMedia)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gridBoletim)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadBoletim"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas e Frequências! - Cadastro"
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.grupoAluno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoAluno.ResumeLayout(False)
        Me.grupoAluno.PerformLayout()
        CType(Me.grupoSalaDisciplina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoSalaDisciplina.ResumeLayout(False)
        Me.grupoSalaDisciplina.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.tbMedia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFaltas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDisciplina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbNomeAluno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    'Friend WithEvents tbNomeAluno As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btSalvar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridBoletim As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBoletim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbTurma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grupoAluno As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbDisciplina As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbBimestre As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbTotalAlunos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbAluno_Media As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbAulasPrevistas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbAulasDadas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbAluno_Faltas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grupoSalaDisciplina As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbBoletim_Faltas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbBoletim_Media As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bwSala As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwAluno As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbSala_Evasao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbSala_Faltas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbSala_Media As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bwBoletim As System.ComponentModel.BackgroundWorker
    Friend WithEvents tbMedia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbFaltas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbAC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cbDisciplina As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tbNomeAluno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
