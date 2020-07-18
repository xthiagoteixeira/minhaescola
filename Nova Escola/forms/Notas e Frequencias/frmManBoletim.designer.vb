<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManBoletim
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManBoletim))
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.lbSala_Evasao = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbSala_Faltas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.lbSala_Media = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.grupoSalaDisciplina = New DevExpress.XtraEditors.GroupControl()
        Me.lbBoletim_Faltas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.lbBoletim_Media = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.grupoAluno = New DevExpress.XtraEditors.GroupControl()
        Me.lbAluno_Faltas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbAluno_Media = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbAulasPrevistas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lbAulasDadas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbTotalAlunos = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbBimestre = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbTurma = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbDisciplina = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gridBoletim = New DevExpress.XtraGrid.GridControl()
        Me.viewBoletim = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.bwSala = New System.ComponentModel.BackgroundWorker()
        Me.bwBoletim = New System.ComponentModel.BackgroundWorker()
        Me.bwAluno = New System.ComponentModel.BackgroundWorker()
        Me.barra = New DevExpress.XtraEditors.ProgressBarControl()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.lbNomeDisciplina = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grupoSalaDisciplina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoSalaDisciplina.SuspendLayout()
        CType(Me.grupoAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoAluno.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbDisciplina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupControl5.Location = New System.Drawing.Point(11, 117)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(309, 222)
        Me.GroupControl5.TabIndex = 181
        Me.GroupControl5.Text = "Estatística"
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
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(178, 33)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(46, 14)
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
        Me.lbSala_Faltas.Size = New System.Drawing.Size(24, 14)
        Me.lbSala_Faltas.TabIndex = 11
        Me.lbSala_Faltas.Text = "0,00"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(101, 33)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(39, 14)
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
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(13, 33)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(39, 14)
        Me.LabelControl21.TabIndex = 8
        Me.LabelControl21.Text = "Notas:"
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
        Me.lbBoletim_Faltas.Size = New System.Drawing.Size(25, 14)
        Me.lbBoletim_Faltas.TabIndex = 11
        Me.lbBoletim_Faltas.Text = "0,000"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(101, 33)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(39, 14)
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
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(13, 33)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(40, 14)
        Me.LabelControl17.TabIndex = 8
        Me.LabelControl17.Text = "Média:"
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
        Me.lbAluno_Faltas.Size = New System.Drawing.Size(24, 14)
        Me.lbAluno_Faltas.TabIndex = 11
        Me.lbAluno_Faltas.Text = "0,000"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(101, 30)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(39, 14)
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
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(13, 30)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(40, 14)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "Média:"
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
        Me.GroupControl1.Controls.Add(Me.lbTurma)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 402)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(309, 88)
        Me.GroupControl1.TabIndex = 180
        Me.GroupControl1.Text = "Dados do Boletim"
        '
        'lbAulasPrevistas
        '
        Me.lbAulasPrevistas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAulasPrevistas.Appearance.Options.UseFont = True
        Me.lbAulasPrevistas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbAulasPrevistas.Location = New System.Drawing.Point(279, 64)
        Me.lbAulasPrevistas.Name = "lbAulasPrevistas"
        Me.lbAulasPrevistas.Size = New System.Drawing.Size(22, 14)
        Me.lbAulasPrevistas.TabIndex = 11
        Me.lbAulasPrevistas.Text = "00"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(180, 64)
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
        Me.lbAulasDadas.Location = New System.Drawing.Point(279, 46)
        Me.lbAulasDadas.Name = "lbAulasDadas"
        Me.lbAulasDadas.Size = New System.Drawing.Size(20, 14)
        Me.lbAulasDadas.TabIndex = 9
        Me.lbAulasDadas.Text = "00"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(198, 46)
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
        Me.lbTotalAlunos.Location = New System.Drawing.Point(71, 64)
        Me.lbTotalAlunos.Name = "lbTotalAlunos"
        Me.lbTotalAlunos.Size = New System.Drawing.Size(69, 14)
        Me.lbTotalAlunos.TabIndex = 7
        Me.lbTotalAlunos.Text = "00 alunos."
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(33, 64)
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
        Me.lbBimestre.Location = New System.Drawing.Point(74, 44)
        Me.lbBimestre.Name = "lbBimestre"
        Me.lbBimestre.Size = New System.Drawing.Size(85, 14)
        Me.lbBimestre.TabIndex = 5
        Me.lbBimestre.Text = "xxx"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(11, 44)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 14)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Bimestre:"
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
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(26, 24)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(42, 14)
        Me.LabelControl12.TabIndex = 0
        Me.LabelControl12.Text = "Turma:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(70, 62)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 14)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Disciplina:"
        '
        'cbDisciplina
        '
        Me.cbDisciplina.EditValue = ""
        Me.cbDisciplina.Location = New System.Drawing.Point(74, 12)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDisciplina.Properties.Appearance.Options.UseFont = True
        Me.cbDisciplina.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDisciplina.Properties.PopupSizeable = True
        Me.cbDisciplina.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbDisciplina.Size = New System.Drawing.Size(238, 20)
        Me.cbDisciplina.TabIndex = 12
        Me.cbDisciplina.Visible = False
        '
        'gridBoletim
        '
        Me.gridBoletim.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridBoletim.Location = New System.Drawing.Point(328, 12)
        Me.gridBoletim.MainView = Me.viewBoletim
        Me.gridBoletim.Name = "gridBoletim"
        Me.gridBoletim.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemSpinEdit1, Me.RepositoryItemTextEdit4})
        Me.gridBoletim.Size = New System.Drawing.Size(462, 563)
        Me.gridBoletim.TabIndex = 179
        Me.gridBoletim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBoletim})
        '
        'viewBoletim
        '
        Me.viewBoletim.GridControl = Me.gridBoletim
        Me.viewBoletim.Name = "viewBoletim"
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
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'bwSala
        '
        Me.bwSala.WorkerReportsProgress = True
        Me.bwSala.WorkerSupportsCancellation = True
        '
        'bwBoletim
        '
        Me.bwBoletim.WorkerReportsProgress = True
        Me.bwBoletim.WorkerSupportsCancellation = True
        '
        'bwAluno
        '
        Me.bwAluno.WorkerReportsProgress = True
        Me.bwAluno.WorkerSupportsCancellation = True
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(94, 550)
        Me.barra.Name = "barra"
        Me.barra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.DisplayFormat.FormatString = " "
        Me.barra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.barra.Properties.ShowTitle = True
        Me.barra.ShowProgressInTaskBar = True
        Me.barra.Size = New System.Drawing.Size(226, 25)
        Me.barra.TabIndex = 205
        '
        'btImprimir
        '
        Me.btImprimir.ImageOptions.Image = CType(resources.GetObject("btImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.btImprimir.Location = New System.Drawing.Point(13, 550)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 25)
        Me.btImprimir.TabIndex = 206
        Me.btImprimir.Text = "Imprimir!"
        '
        'lbNomeDisciplina
        '
        Me.lbNomeDisciplina.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomeDisciplina.Appearance.Options.UseFont = True
        Me.lbNomeDisciplina.Location = New System.Drawing.Point(136, 62)
        Me.lbNomeDisciplina.Name = "lbNomeDisciplina"
        Me.lbNomeDisciplina.Size = New System.Drawing.Size(113, 14)
        Me.lbNomeDisciplina.TabIndex = 207
        Me.lbNomeDisciplina.Text = "Nome da Disciplina"
        '
        'frmManBoletim
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(803, 607)
        Me.Controls.Add(Me.lbNomeDisciplina)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gridBoletim)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.LabelControl3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmManBoletim"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas e Frequências! - Manutenção"
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.grupoSalaDisciplina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoSalaDisciplina.ResumeLayout(False)
        Me.grupoSalaDisciplina.PerformLayout()
        CType(Me.grupoAluno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoAluno.ResumeLayout(False)
        Me.grupoAluno.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbDisciplina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbSala_Evasao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbSala_Faltas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbSala_Media As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grupoSalaDisciplina As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbBoletim_Faltas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbBoletim_Media As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grupoAluno As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbAluno_Faltas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbAluno_Media As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbAulasPrevistas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbAulasDadas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbTotalAlunos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbBimestre As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbTurma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridBoletim As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBoletim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cbDisciplina As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents bwSala As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwBoletim As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwAluno As System.ComponentModel.BackgroundWorker
    Friend WithEvents barra As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lbNomeDisciplina As DevExpress.XtraEditors.LabelControl
End Class
