Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic.FileIO
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.Support.UI
Imports System.ComponentModel
Imports System.Text

Public Class frmCopiarColar
    Inherits XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tBimestre As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gridBoletim As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBoletim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbDisciplina As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl2 As GroupControl
    Friend WithEvents bkTodas As BackgroundWorker
    Friend WithEvents URL As TextEdit
    Friend WithEvents btEnviarTodas As SimpleButton
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents barra As ProgressBarControl
    Friend WithEvents btFirefox As SimpleButton
    Friend WithEvents gridAulasDadasPrevistas As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewAulasDadasPrevistas As GridView
    Friend WithEvents btEnviarDisciplina As SimpleButton
    Friend WithEvents bkDisciplina As BackgroundWorker
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents btChrome As SimpleButton
    Friend WithEvents cbTurma As DevExpress.XtraEditors.LookUpEdit

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCopiarColar))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gridAulasDadasPrevistas = New DevExpress.XtraGrid.GridControl()
        Me.viewAulasDadasPrevistas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.barra = New DevExpress.XtraEditors.ProgressBarControl()
        Me.URL = New DevExpress.XtraEditors.TextEdit()
        Me.btEnviarTodas = New DevExpress.XtraEditors.SimpleButton()
        Me.cbDisciplina = New DevExpress.XtraEditors.LookUpEdit()
        Me.gridBoletim = New DevExpress.XtraGrid.GridControl()
        Me.viewBoletim = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbAF = New DevExpress.XtraEditors.CheckEdit()
        Me.tBimestre = New System.Windows.Forms.NumericUpDown()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tAno = New System.Windows.Forms.NumericUpDown()
        Me.cbTurma = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bkTodas = New System.ComponentModel.BackgroundWorker()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.btFirefox = New DevExpress.XtraEditors.SimpleButton()
        Me.btEnviarDisciplina = New DevExpress.XtraEditors.SimpleButton()
        Me.bkDisciplina = New System.ComponentModel.BackgroundWorker()
        Me.btChrome = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gridAulasDadasPrevistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewAulasDadasPrevistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.URL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDisciplina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.gridAulasDadasPrevistas)
        Me.GroupControl1.Location = New System.Drawing.Point(7, 124)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(219, 134)
        Me.GroupControl1.TabIndex = 18
        Me.GroupControl1.Text = "Aulas Dadas e Previstas"
        '
        'gridAulasDadasPrevistas
        '
        Me.gridAulasDadasPrevistas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAulasDadasPrevistas.Location = New System.Drawing.Point(2, 21)
        Me.gridAulasDadasPrevistas.MainView = Me.viewAulasDadasPrevistas
        Me.gridAulasDadasPrevistas.Name = "gridAulasDadasPrevistas"
        Me.gridAulasDadasPrevistas.Size = New System.Drawing.Size(215, 111)
        Me.gridAulasDadasPrevistas.TabIndex = 0
        Me.gridAulasDadasPrevistas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewAulasDadasPrevistas})
        '
        'viewAulasDadasPrevistas
        '
        Me.viewAulasDadasPrevistas.GridControl = Me.gridAulasDadasPrevistas
        Me.viewAulasDadasPrevistas.Name = "viewAulasDadasPrevistas"
        Me.viewAulasDadasPrevistas.OptionsView.ShowGroupPanel = False
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.Location = New System.Drawing.Point(0, 726)
        Me.barra.Margin = New System.Windows.Forms.Padding(2)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(234, 14)
        Me.barra.TabIndex = 38
        '
        'URL
        '
        Me.URL.EditValue = "http://"
        Me.URL.Location = New System.Drawing.Point(7, 11)
        Me.URL.Margin = New System.Windows.Forms.Padding(2)
        Me.URL.Name = "URL"
        Me.URL.Size = New System.Drawing.Size(167, 20)
        Me.URL.TabIndex = 37
        '
        'btEnviarTodas
        '
        Me.btEnviarTodas.AutoSize = True
        Me.btEnviarTodas.Enabled = False
        Me.btEnviarTodas.ImageOptions.Image = CType(resources.GetObject("btEnviarTodas.ImageOptions.Image"), System.Drawing.Image)
        Me.btEnviarTodas.Location = New System.Drawing.Point(187, 48)
        Me.btEnviarTodas.Margin = New System.Windows.Forms.Padding(2)
        Me.btEnviarTodas.Name = "btEnviarTodas"
        Me.btEnviarTodas.Size = New System.Drawing.Size(22, 22)
        Me.btEnviarTodas.TabIndex = 33
        '
        'cbDisciplina
        '
        Me.cbDisciplina.EditValue = ""
        Me.cbDisciplina.Enabled = False
        Me.cbDisciplina.Location = New System.Drawing.Point(71, 262)
        Me.cbDisciplina.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDisciplina.Properties.NullText = ""
        Me.cbDisciplina.Size = New System.Drawing.Size(122, 20)
        Me.cbDisciplina.TabIndex = 32
        '
        'gridBoletim
        '
        Me.gridBoletim.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridBoletim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridBoletim.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.gridBoletim.Location = New System.Drawing.Point(0, 286)
        Me.gridBoletim.MainView = Me.viewBoletim
        Me.gridBoletim.Margin = New System.Windows.Forms.Padding(2)
        Me.gridBoletim.Name = "gridBoletim"
        Me.gridBoletim.Size = New System.Drawing.Size(234, 440)
        Me.gridBoletim.TabIndex = 24
        Me.gridBoletim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBoletim})
        '
        'viewBoletim
        '
        Me.viewBoletim.GridControl = Me.gridBoletim
        Me.viewBoletim.Name = "viewBoletim"
        Me.viewBoletim.OptionsBehavior.Editable = False
        Me.viewBoletim.OptionsSelection.MultiSelect = True
        Me.viewBoletim.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(11, 265)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "Disciplina:"
        '
        'cbAF
        '
        Me.cbAF.Location = New System.Drawing.Point(169, 26)
        Me.cbAF.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Properties.Caption = "AF"
        Me.cbAF.Size = New System.Drawing.Size(38, 19)
        Me.cbAF.TabIndex = 23
        '
        'tBimestre
        '
        Me.tBimestre.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.tBimestre.Location = New System.Drawing.Point(136, 25)
        Me.tBimestre.Margin = New System.Windows.Forms.Padding(2)
        Me.tBimestre.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.tBimestre.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.tBimestre.Name = "tBimestre"
        Me.tBimestre.Size = New System.Drawing.Size(31, 21)
        Me.tBimestre.TabIndex = 22
        Me.tBimestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tBimestre.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(87, 29)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Bimestre:"
        '
        'tAno
        '
        Me.tAno.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.tAno.Location = New System.Drawing.Point(20, 25)
        Me.tAno.Margin = New System.Windows.Forms.Padding(2)
        Me.tAno.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(52, 21)
        Me.tAno.TabIndex = 16
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2018, 0, 0, 0})
        '
        'cbTurma
        '
        Me.cbTurma.EditValue = ""
        Me.cbTurma.Location = New System.Drawing.Point(48, 50)
        Me.cbTurma.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurma.Properties.NullText = ""
        Me.cbTurma.Size = New System.Drawing.Size(135, 20)
        Me.cbTurma.TabIndex = 31
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.cbTurma)
        Me.GroupControl2.Controls.Add(Me.tBimestre)
        Me.GroupControl2.Controls.Add(Me.tAno)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.btEnviarTodas)
        Me.GroupControl2.Controls.Add(Me.cbAF)
        Me.GroupControl2.Location = New System.Drawing.Point(7, 45)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(219, 75)
        Me.GroupControl2.TabIndex = 36
        Me.GroupControl2.Text = "Qual período?"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(4, 53)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Turma:"
        '
        'bkTodas
        '
        Me.bkTodas.WorkerReportsProgress = True
        Me.bkTodas.WorkerSupportsCancellation = True
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'btFirefox
        '
        Me.btFirefox.ImageOptions.Image = CType(resources.GetObject("btFirefox.ImageOptions.Image"), System.Drawing.Image)
        Me.btFirefox.Location = New System.Drawing.Point(178, 10)
        Me.btFirefox.Margin = New System.Windows.Forms.Padding(2)
        Me.btFirefox.Name = "btFirefox"
        Me.btFirefox.Size = New System.Drawing.Size(24, 22)
        Me.btFirefox.TabIndex = 38
        '
        'btEnviarDisciplina
        '
        Me.btEnviarDisciplina.AutoSize = True
        Me.btEnviarDisciplina.Enabled = False
        Me.btEnviarDisciplina.ImageOptions.Image = CType(resources.GetObject("btEnviarDisciplina.ImageOptions.Image"), System.Drawing.Image)
        Me.btEnviarDisciplina.Location = New System.Drawing.Point(197, 260)
        Me.btEnviarDisciplina.Margin = New System.Windows.Forms.Padding(2)
        Me.btEnviarDisciplina.Name = "btEnviarDisciplina"
        Me.btEnviarDisciplina.Size = New System.Drawing.Size(22, 22)
        Me.btEnviarDisciplina.TabIndex = 39
        '
        'bkDisciplina
        '
        Me.bkDisciplina.WorkerReportsProgress = True
        Me.bkDisciplina.WorkerSupportsCancellation = True
        '
        'btChrome
        '
        Me.btChrome.ImageOptions.Image = CType(resources.GetObject("btChrome.ImageOptions.Image"), System.Drawing.Image)
        Me.btChrome.Location = New System.Drawing.Point(204, 10)
        Me.btChrome.Margin = New System.Windows.Forms.Padding(2)
        Me.btChrome.Name = "btChrome"
        Me.btChrome.Size = New System.Drawing.Size(24, 22)
        Me.btChrome.TabIndex = 40
        '
        'frmCopiarColar
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(234, 740)
        Me.Controls.Add(Me.btChrome)
        Me.Controls.Add(Me.btEnviarDisciplina)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbDisciplina)
        Me.Controls.Add(Me.gridBoletim)
        Me.Controls.Add(Me.btFirefox)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.URL)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.barra)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCopiarColar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiar/Colar Notas"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gridAulasDadasPrevistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewAulasDadasPrevistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.URL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDisciplina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBimestre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim navegadorEscolhido

    Dim bimestre = String.Empty
    Dim turma, disciplina
    Dim verificationErrors
    Dim descobreControlador = False

    Dim aulasRealizadas
    Dim aulasPlanejadas
    Dim tabControlador = "0"
    Dim iDisciplina = 0

    Dim NroTransferencia = 1
    Dim NroAluno_Global = 0
    Dim clicouTurma = False
    Dim Disciplina_Atual

    Dim TravaFaltas = False

    Dim NroAluno_AC = 0
    Dim NroAluno_FT = 0
    Dim NroAluno_AV = 0
    Dim nroOficina = 1

    Dim TAB_Disciplinas
    Dim TAB_Disciplinas_i = 0

    Dim PrimeiraTAB = False

    Dim posicaoDisciplina = 0
    Dim posicaoNroAlunos = 0

    ReadOnly iMedia(0 To 100) As String
    ReadOnly iFalta(0 To 100) As Integer
    ReadOnly iAC(0 To 100) As Integer
    ReadOnly iPR(0 To 100) As String
    ReadOnly iTr(0 To 100) As Boolean

    Sub Consulta_PosicaoDisciplina()

        If cbDisciplina.Text <> "" Then
            Try
                TAB_Disciplinas = navegadorEscolhido.FindElement(By.XPath("//div[@id='fechamentoTabs']/ul")).Text.ToString
                Dim linhaAtual As String() = TAB_Disciplinas.Split(New Char() {vbCrLf})

                Dim y = 0
                While linhaAtual(y) <> Nothing
                    Disciplina_Atual = linhaAtual(y).ToString.Replace(vbLf, "")

                    If Disciplina_Atual = cbDisciplina.Text Then
                        posicaoDisciplina = y + 1
                        Exit While
                    End If
                    y = y + 1
                End While

                navegadorEscolhido.FindElement(By.LinkText(Disciplina_Atual)).Click()

            Catch ex As Exception
            End Try
        End If

    End Sub

    Sub Consulta_PrevistasDadas()

        Dim Sql = String.Format("SELECT d.disciplina AS Disciplina, n.previsaoaulas AS Previstas, n.qtdadeaulas AS Dadas FROM notasfreq n, disciplinas d WHERE n.disciplina = d.codigo_disc AND n.turma='{0}' AND n.cod_bimestre='{1}' AND n.anovigente='{2}' ORDER BY d.disciplina ASC;", Consulta_Turma(cbTurma.Text), bimestre, tAno.Value)
        Dim MinhaDataGrid = MySQL_consulta_datagrid(Sql)
        gridAulasDadasPrevistas.DataSource = Nothing
        gridAulasDadasPrevistas.DataSource = MinhaDataGrid

    End Sub
    Sub Carregar_DisciplinasBoletim()

        turma = Consulta_Turma(cbTurma.Text)
        If (cbAF.Checked = True And tBimestre.Value = 2) Then
            bimestre = "2AF"
        ElseIf (cbAF.Checked = True And tBimestre.Value = 4) Then
            bimestre = "4AF"
        ElseIf (cbAF.Checked = False) Then
            bimestre = tBimestre.Value
        End If

        Try
            SQL = "SELECT disciplinas.disciplina AS disciplina FROM " _
                 & "notasfreq " _
                 & "INNER JOIN disciplinas ON notasfreq.disciplina = disciplinas.codigo_disc " _
                 & "INNER JOIN turma ON notasfreq.turma = turma.codigo_trma " _
                 & "WHERE notasfreq.anovigente='" & tAno.Text & "' AND notasfreq.cod_bimestre='" & bimestre & "' AND turma.codigo_trma='" & turma & "' " _
                 & "ORDER BY disciplinas.disciplina ASC;"
            cbDisciplina.Properties.DataSource = MySQL_combobox(SQL)
            cbDisciplina.Properties.DisplayMember = "disciplina"
        Catch ex As Exception
        End Try

    End Sub

    Sub Consulta_Boletim(Disciplina As String)

        If clicouTurma = True Then

            nroTotalAlunos = 1

            Array.Clear(iMedia, 0, 100)
            Array.Clear(iFalta, 0, 100)
            Array.Clear(iAC, 0, 100)
            Array.Clear(iPR, 0, 100)
            Array.Clear(iTr, 0, 100)

            If (cbAF.Checked = True And tBimestre.Value = 2) Then
                bimestre = "2AF"
            ElseIf (cbAF.Checked = True And tBimestre.Value = 4) Then
                bimestre = "4AF"
            ElseIf (cbAF.Checked = False) Then
                bimestre = tBimestre.Value
            End If

            Dim Sql = String.Format("SELECT * FROM notasfreq WHERE disciplina='{0}' AND turma='{1}' AND cod_bimestre='{2}' AND anovigente='{3}';", Consulta_Disciplina(Disciplina), Consulta_Turma(cbTurma.Text), bimestre, tAno.Value)
            meuboletim = MySQL_consulta_campo(Sql, "cod_nf")

            If meuboletim = 0 Then
                MsgBox("Boletim não encontrado!", MsgBoxStyle.Information, "Informação!")
                travaProcessos = 99
                Exit Sub
            Else

                Sql = String.Format("SELECT DISTINCT nro_aluno AS Nro, M AS AV, F AS FT, AC AS AC, S AS PR FROM boletim WHERE cod_boletim='{0}' ORDER BY nro_aluno ASC",
                    meuboletim)
                Dim MinhaDataGrid = MySQL_consulta_datagrid(Sql)
                Try
                    gridBoletim.DataSource = Nothing
                    gridBoletim.DataSource = MinhaDataGrid
                Catch ex As Exception
                End Try


                '/// INDICE DE ALUNOS
                For Each r In MinhaDataGrid.Rows

                    If r("AV") > 10 Then
                        iMedia(nroTotalAlunos) = "0"
                    Else
                        iMedia(nroTotalAlunos) = r("AV")
                    End If

                    iFalta(nroTotalAlunos) = r("FT")
                    iAC(nroTotalAlunos) = r("AC")
                    iPR(nroTotalAlunos) = r("PR")

                    nroTotalAlunos = nroTotalAlunos + 1
                Next

            End If
        End If

    End Sub

    Public Sub ZerarDados()

        NroTransferencia = 0

        contadorTransf = 1
        aulasPlanejadas = 0
        aulasRealizadas = 0
        travaProcessos = 99

        posicaoNroAlunos = 0

        Array.Clear(iMedia, 0, 100)
        Array.Clear(iFalta, 0, 100)
        Array.Clear(iAC, 0, 100)
        Array.Clear(iPR, 0, 100)
        Array.Clear(iTr, 0, 100)

        Array.Clear(iAV, 0, 100)
        Array.Clear(iFT, 0, 100)
        Array.Clear(iACT, 0, 100)
        Array.Clear(iPRT, 0, 100)
        Array.Clear(iTRT, 0, 100)


        '  btTransferir.Enabled = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = "True"

        tBimestre.Value = consultaBimestre()
        tAno.Value = AnoVigente

        SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe;"
        cbTurma.Properties.DataSource = MySQL_combobox(SQL)
        cbTurma.Properties.DisplayMember = "classe"

    End Sub


    Private Sub cbAF_CheckedChanged(sender As Object, e As EventArgs) Handles cbAF.CheckedChanged

        If cbAF.Checked = False Then
            tBimestre.Enabled = True
            bimestre = tBimestre.Text

        Else
            tBimestre.Enabled = False
            bimestre = tBimestre.Text & "AF"
        End If

        Consulta_PrevistasDadas()

    End Sub

    Private Sub cbTurma_Click(sender As Object, e As EventArgs) Handles cbTurma.Click

        'If MsgBox("Deseja trocar de turma?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        ZerarDados()
        clicouTurma = True
        cbDisciplina.Enabled = True
        cbTurma.Enabled = True
        iDisciplina = 0
        btEnviarTodas.Enabled = False

        Consulta_PrevistasDadas()

    End Sub

    Private Sub cbDisciplina_Click(sender As Object, e As EventArgs) Handles cbDisciplina.Click
        ZerarDados()
        descobreControlador = False
        NroAluno_Global = 0

    End Sub

    Private Sub viewBoletim_RowStyle(sender As Object, e As RowStyleEventArgs) Handles viewBoletim.RowStyle

        Try
            Dim View As GridView = sender
            Dim NotasVermelhas As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("AV"))

            If NotasVermelhas > 4 Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.White
            Else
                e.Appearance.BackColor = Color.LightSalmon
                e.Appearance.BackColor2 = Color.White
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub cbTurma_EditValueChanged(sender As Object, e As EventArgs) Handles cbTurma.EditValueChanged

        iDisciplina = 0
        Carregar_DisciplinasBoletim()
        'btTransferir.Enabled = True
        PrimeiraTAB = False

        NroAluno_AC = 0
        NroAluno_FT = 0
        NroAluno_AV = 0

        Consulta_PrevistasDadas()
        btEnviarTodas.Enabled = True

    End Sub
    Private Sub cbDisciplina_TextChanged(sender As Object, e As EventArgs) Handles cbDisciplina.TextChanged

        Consulta_Boletim(cbDisciplina.Text)
        'btEnviarTodas.Enabled = True
        iDisciplina = iDisciplina + 1
        btEnviarDisciplina.Enabled = True
        Consulta_PosicaoDisciplina()

    End Sub
    Sub inicializar(meuNavegador As String, meuEndereco As String)

        Try
            If meuNavegador = "Chrome" Then
                navegadorEscolhido = New ChromeDriver()
                navegadorEscolhido.Navigate().GoToUrl(meuEndereco)

            ElseIf meuNavegador = "Firefox" Then
                navegadorEscolhido = New FirefoxDriver
                verificationErrors = New StringBuilder
                navegadorEscolhido.Navigate().GoToUrl(meuEndereco)

                'ElseIf meuNavegador = "Internet Explorer" Then
                '    navegadorEscolhido = New InternetExplorerDriver
                'navegadorEscolhido.Navigate().GoToUrl(meuEndereco)
            End If

        Catch ex As Exception
            MsgBox("Firefox não encontrado!" & vbCrLf & "Erro: " & ex.Message, MsgBoxStyle.Information, "Informao")
        End Try

    End Sub
    Sub preencherBoletim(NroAluno As Integer, AV As String, Faltas As String, AC As String, Justificativa As String)

        Try
            If AV = Nothing Then
                AV = ""
            End If

            If NroAluno = "1" Then

                ' ///////// Verifica Primeira TAB  ///////////
                Try
                    Dim Aluno_Avaliacao As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[3]")))
                    Aluno_Avaliacao.Clear()
                    Aluno_Avaliacao.SendKeys(AV)
                    PrimeiraTAB = True
                Catch ex As Exception
                    PrimeiraTAB = False
                End Try

                ' ///////// Primeira TAB ///////////
                If PrimeiraTAB = True Then
                    Try
                        Dim Aluno_Faltas As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[4]")))
                        Aluno_Faltas.Clear()
                        Aluno_Faltas.SendKeys(Faltas)
                    Catch ex As Exception
                    End Try

                    Try
                        'Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@name='fechamento.FaltasCompensadas'])", NroAluno_AC)))
                        Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[6]")))
                        Aluno_AC.Clear()
                        Aluno_AC.SendKeys(AC)
                    Catch ex As Exception
                    End Try

                    'NroAluno_AV = 9
                    'NroAluno_FT = 10
                    'NroAluno_AC = 12

                    NroAluno_AV = 8
                    NroAluno_FT = 9
                    NroAluno_AC = 11

                Else

                    'If Disciplina_Atual <> "DISCIPLINAS ELETIVAS" And Disciplina_Atual <> "PREPARACAO ACADEMICA" And Disciplina_Atual <> "MUNDO DO TRABALHO" And Disciplina_Atual <> "ORIENTACAO DE ESTUDOS" Then


                    '////////// OUTRAS TAB \\\\\\\\\\\\
                    Dim AcharCaixaTexto = False
                    Dim AcharCaixaTexto2 = False
                    Dim AcharCaixaTexto3 = False

                    While AcharCaixaTexto = False And AcharCaixaTexto2 = False And AcharCaixaTexto3 = False

                        NroAluno_AV = NroAluno_AV + 1
                        Try
                            Dim Aluno_Avaliacao As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_AV)))
                            Aluno_Avaliacao.Clear()
                            Aluno_Avaliacao.SendKeys(AV)
                            AcharCaixaTexto = True
                        Catch ex As Exception
                            AcharCaixaTexto = False
                        End Try
                        NroAluno_AV = NroAluno_AV + 5

                        NroAluno_FT = NroAluno_FT + 1
                        Try
                            Dim Aluno_Faltas As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_FT)))
                            Aluno_Faltas.Clear()
                            Aluno_Faltas.SendKeys(Faltas)
                            AcharCaixaTexto2 = True
                        Catch ex As Exception
                            AcharCaixaTexto2 = False
                        End Try
                        NroAluno_FT = NroAluno_FT + 5

                        NroAluno_AC = NroAluno_AC + 1
                        Try
                            Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_AC)))
                            Aluno_AC.Clear()
                            Aluno_AC.SendKeys(AC)
                            AcharCaixaTexto3 = True
                        Catch ex As Exception
                            AcharCaixaTexto3 = False
                        End Try
                    End While
                    NroAluno_AC = NroAluno_AC + 5

                    'Else

                    '    '\\\ Oficinas ...
                    '    '////////// OUTRAS TAB \\\\\\\\\\\\
                    '    Dim AcharCaixaTexto = False
                    '    Dim AcharCaixaTexto2 = False
                    '    Dim AcharCaixaTexto3 = False

                    '    While AcharCaixaTexto2 = False Or AcharCaixaTexto3 = False

                    '        NroAluno_AV = NroAluno_AV + 1
                    '        NroAluno_FT = NroAluno_FT + 1
                    '        Try
                    '            Dim Aluno_Faltas As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_FT)))
                    '            Aluno_Faltas.Clear()
                    '            Aluno_Faltas.SendKeys(Faltas)
                    '            AcharCaixaTexto2 = True
                    '        Catch ex As Exception
                    '            AcharCaixaTexto2 = False
                    '        End Try

                    '        NroAluno_AC = NroAluno_AC - 1
                    '        Try
                    '            Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@name='fechamento.FaltasCompensadas'])[{0}]", NroAluno_AC)))
                    '            Aluno_AC.Clear()
                    '            Aluno_AC.SendKeys(AC)
                    '            AcharCaixaTexto3 = True
                    '        Catch ex As Exception
                    '            AcharCaixaTexto3 = False
                    '        End Try
                    '    End While
                    '    NroAluno_AV = NroAluno_AV + 5
                    '    NroAluno_FT = NroAluno_FT + 5
                    '    NroAluno_AC = NroAluno_AC + 2
                    'End If

                End If

            Else
                '\\\\\\\\\ OUTROS ALUNOS ////////
                'If Disciplina_Atual <> "DISCIPLINAS ELETIVAS" And Disciplina_Atual <> "PREPARACAO ACADEMICA" And Disciplina_Atual <> "MUNDO DO TRABALHO" And Disciplina_Atual <> "ORIENTACAO DE ESTUDOS" Then
                Try
                    Dim Aluno_Avaliacao As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_AV)))
                    Aluno_Avaliacao.Clear()
                    Aluno_Avaliacao.SendKeys(AV)
                Catch ex As Exception
                End Try
                NroAluno_AV = NroAluno_AV + 5
                Try
                    Dim Aluno_Faltas As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_FT)))
                    Aluno_Faltas.Clear()
                    Aluno_Faltas.SendKeys(Faltas)
                Catch ex As Exception
                    TravaFaltas = True
                End Try
                NroAluno_FT = NroAluno_FT + 5
                Try
                    Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_AC)))
                    Aluno_AC.Clear()
                    Aluno_AC.SendKeys(AC)
                Catch ex As Exception
                End Try
                NroAluno_AC = NroAluno_AC + 5

                'Else

                '    NroAluno_AV = NroAluno_AV + 5
                '    Try
                '        Dim Aluno_Faltas As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_FT)))
                '        Aluno_Faltas.Clear()
                '        Aluno_Faltas.SendKeys(Faltas)
                '    Catch ex As Exception
                '        TravaFaltas = True
                '    End Try
                '    NroAluno_FT = NroAluno_FT + 5
                '    Try
                '        Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@name='fechamento.FaltasCompensadas'])[{0}]", NroAluno_AC)))
                '        Aluno_AC.Clear()
                '        Aluno_AC.SendKeys(AC)
                '    Catch ex As Exception
                '    End Try
                '    NroAluno_AC = NroAluno_AC + 2

                'End If


            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btEnviarTodas_Click(sender As Object, e As EventArgs) Handles btEnviarTodas.Click
        bkTodas.RunWorkerAsync()
        barra.Properties.Maximum = nroTotalAlunos
        barra.Properties.Minimum = 0
        btEnviarTodas.Enabled = False

    End Sub

    Sub preencherBoletimFinal(NroAluno As Integer, AV As String, ST As String)

        Try
            If AV = Nothing Then
                AV = ""
            End If

            If NroAluno = "1" Then

                ' ///////// Verifica Primeira TAB  ///////////
                Try
                    Dim Aluno_Avaliacao As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[3]")))
                    Aluno_Avaliacao.Clear()
                    Aluno_Avaliacao.SendKeys(AV)
                    PrimeiraTAB = True
                Catch ex As Exception
                    PrimeiraTAB = False
                End Try
                NroAluno_AV = 4

                ' ///////// Primeira TAB ///////////
                If PrimeiraTAB = True Then
                    'Try
                    '    Dim Aluno_Faltas As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[4]")))
                    '    Aluno_Faltas.Clear()
                    '    Aluno_Faltas.SendKeys(Faltas)
                    'Catch ex As Exception
                    'End Try

                    'Try
                    '    'Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@name='fechamento.FaltasCompensadas'])", NroAluno_AC)))
                    '    Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[6]")))
                    '    Aluno_AC.Clear()
                    '    Aluno_AC.SendKeys(AC)
                    'Catch ex As Exception
                    'End Try

                    ''NroAluno_AV = 9
                    ''NroAluno_FT = 10
                    ''NroAluno_AC = 12

                    If AV <> "S/N" Then
                        Try
                            ' // SITUACOES ... 
                            If ST = 3 Then
                                ' \ Retido(a) por frequncia Insuficiente na disciplina /
                                Dim NroAluno1 = New SelectElement(navegadorEscolhido.FindElement(By.XPath(String.Format("//table[@id='tabLancamentoFechamentoAvaliacoes" & tabControlador & "']/tbody/tr/td[7]/select", NroAluno))))
                                NroAluno1.SelectByText("Retido(a) por frequência Insuficiente")

                            ElseIf ST = 4 Then
                                ' \ Retido(a) por rendimento Insuficiente na disciplina /
                                Dim NroAluno1 = New SelectElement(navegadorEscolhido.FindElement(By.XPath(String.Format("//table[@id='tabLancamentoFechamentoAvaliacoes" & tabControlador & "']/tbody/tr/td[7]/select", NroAluno))))
                                NroAluno1.SelectByText("Retido(a) por rendimento Insuficiente")

                            ElseIf ST = 1 Or ST = "N" Then
                                ' \ Aprovado(a) /
                                Dim NroAluno1 = New SelectElement(navegadorEscolhido.FindElement(By.XPath(String.Format("//table[@id='tabLancamentoFechamentoAvaliacoes" & tabControlador & "']/tbody/tr/td[7]/select", NroAluno))))
                                NroAluno1.SelectByText("Aprovado(a)")
                            End If
                        Catch ex As Exception
                        End Try
                    End If



                Else

                    'If Disciplina_Atual <> "DISCIPLINAS ELETIVAS" And Disciplina_Atual <> "PREPARACAO ACADEMICA" And Disciplina_Atual <> "MUNDO DO TRABALHO" And Disciplina_Atual <> "ORIENTACAO DE ESTUDOS" Then


                    '////////// OUTRAS TAB \\\\\\\\\\\\
                    Dim AcharCaixaTexto = False
                    Dim AcharCaixaTexto2 = False
                    Dim AcharCaixaTexto3 = False

                    While AcharCaixaTexto = False

                        'NroAluno_AV = NroAluno_AV + 1
                        Try
                            Dim Aluno_Avaliacao As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_AV)))
                            Aluno_Avaliacao.Clear()
                            Aluno_Avaliacao.SendKeys(AV)
                            AcharCaixaTexto = True
                        Catch ex As Exception
                            AcharCaixaTexto = False
                        End Try
                        NroAluno_AV = NroAluno_AV + 1

                    End While
                    'NroAluno_AC = NroAluno_AC + 5

                    'Else

                    '    '\\\ Oficinas ...
                    '    '////////// OUTRAS TAB \\\\\\\\\\\\
                    '    Dim AcharCaixaTexto = False
                    '    Dim AcharCaixaTexto2 = False
                    '    Dim AcharCaixaTexto3 = False

                    '    While AcharCaixaTexto2 = False Or AcharCaixaTexto3 = False

                    '        NroAluno_AV = NroAluno_AV + 1
                    '        NroAluno_FT = NroAluno_FT + 1
                    '        Try
                    '            Dim Aluno_Faltas As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_FT)))
                    '            Aluno_Faltas.Clear()
                    '            Aluno_Faltas.SendKeys(Faltas)
                    '            AcharCaixaTexto2 = True
                    '        Catch ex As Exception
                    '            AcharCaixaTexto2 = False
                    '        End Try

                    '        NroAluno_AC = NroAluno_AC - 1
                    '        Try
                    '            Dim Aluno_AC As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@name='fechamento.FaltasCompensadas'])[{0}]", NroAluno_AC)))
                    '            Aluno_AC.Clear()
                    '            Aluno_AC.SendKeys(AC)
                    '            AcharCaixaTexto3 = True
                    '        Catch ex As Exception
                    '            AcharCaixaTexto3 = False
                    '        End Try
                    '    End While
                    '    NroAluno_AV = NroAluno_AV + 5
                    '    NroAluno_FT = NroAluno_FT + 5
                    '    NroAluno_AC = NroAluno_AC + 2
                    'End If

                End If

            Else
                '\\\\\\\\\ OUTROS ALUNOS ////////
                'If Disciplina_Atual <> "DISCIPLINAS ELETIVAS" And Disciplina_Atual <> "PREPARACAO ACADEMICA" And Disciplina_Atual <> "MUNDO DO TRABALHO" And Disciplina_Atual <> "ORIENTACAO DE ESTUDOS" Then
                Try
                    Dim Aluno_Avaliacao As IWebElement = navegadorEscolhido.FindElement(By.XPath(String.Format("(//input[@type='text'])[{0}]", NroAluno_AV)))
                    Aluno_Avaliacao.Clear()
                    Aluno_Avaliacao.SendKeys(AV)
                Catch ex As Exception
                End Try
                NroAluno_AV = NroAluno_AV + 1


                If AV <> "S/N" Then
                    Try
                        ' // SITUACOES ... 
                        If ST = 3 Then
                            ' \ Retido(a) por frequncia Insuficiente na disciplina /
                            Dim NroAluno1 = New SelectElement(navegadorEscolhido.FindElement(By.XPath(String.Format("//table[@id='tabLancamentoFechamentoAvaliacoes" & tabControlador & "']/tbody/tr[{0}]/td[7]/select", NroAluno))))
                            NroAluno1.SelectByText("Retido(a) por frequência Insuficiente")

                        ElseIf ST = 4 Then
                            ' \ Retido(a) por rendimento Insuficiente na disciplina /
                            Dim NroAluno1 = New SelectElement(navegadorEscolhido.FindElement(By.XPath(String.Format("//table[@id='tabLancamentoFechamentoAvaliacoes" & tabControlador & "']/tbody/tr[{0}]/td[7]/select", NroAluno))))
                            NroAluno1.SelectByText("Retido(a) por rendimento Insuficiente")

                        ElseIf ST = 1 Or ST = "N" Then
                            ' \ Aprovado(a) /
                            Dim NroAluno1 = New SelectElement(navegadorEscolhido.FindElement(By.XPath(String.Format("//table[@id='tabLancamentoFechamentoAvaliacoes" & tabControlador & "']/tbody/tr[{0}]/td[7]/select", NroAluno))))
                            NroAluno1.SelectByText("Aprovado(a)")

                        End If
                    Catch ex As Exception
                    End Try
                End If


            End If
        Catch ex As Exception
        End Try


    End Sub

    Private Sub bkTodas_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkTodas.DoWork

        TAB_Disciplinas = navegadorEscolhido.FindElement(By.XPath("//div[@id='fechamentoTabs']/ul")).Text.ToString
        Dim linhaAtual As String() = TAB_Disciplinas.Split(New Char() {vbCrLf})
        Try
            Dim y = 0
            While linhaAtual(y) <> ""

                Disciplina_Atual = linhaAtual(y).ToString.Replace(vbLf, "")
                Dim Controlador = 0
                Try
                    navegadorEscolhido.FindElement(By.LinkText(Disciplina_Atual)).Click()
                    Consulta_Boletim(Disciplina_Atual)
                Catch ex As Exception
                    MsgBox("Não encontramos a disciplina: " & Disciplina_Atual & "!", MsgBoxStyle.Information, "Mais Escola!")
                    Exit Sub
                End Try

                Dim NroAluno = String.Empty

                ' PROCURA O NUMERO DO ALUNO ...
                Dim x = 1
                While (NroAluno = String.Empty)

                    Select Case x
                        Case 1
                            tabControlador = "3100"
                        Case 2
                            tabControlador = "2600"
                        Case 3
                            tabControlador = "1813"
                        Case 4
                            tabControlador = "2800"
                        Case 5
                            tabControlador = "2200"
                        Case 6
                            tabControlador = "2300"
                        Case 7
                            tabControlador = "1400"
                        Case 8
                            tabControlador = "2400"
                        Case 9
                            tabControlador = "2100"
                        Case 10
                            tabControlador = "2700"
                        Case 11
                            tabControlador = "1900"
                        Case 12
                            tabControlador = "1111"
                        Case 13
                            tabControlador = "2500"
                        Case 14
                            tabControlador = "1100"
                        Case 15
                            tabControlador = "2707"
                        Case 16
                            tabControlador = "2105"
                        Case 17
                            tabControlador = "1814"
                        Case 18
                            tabControlador = "1401"
                        Case 19
                            tabControlador = "2208"
                        Case 20
                            tabControlador = "2306"
                        Case 21
                            tabControlador = "3105"
                        Case 22
                            tabControlador = "2605"
                        Case 23
                            tabControlador = "2812"
                        Case 24
                            tabControlador = "2413"
                        Case 25
                            tabControlador = "1119"
                        Case 26
                            tabControlador = "1903"
                        Case 27
                            tabControlador = "1118"
                        Case 28
                            tabControlador = "8427"
                        Case 29
                            tabControlador = "8442"
                        Case 30
                            tabControlador = "8443"
                        Case 31
                            tabControlador = "8446"
                        Case 32
                            tabControlador = "8447"
                        Case 33
                            tabControlador = "8441"
                        Case 34
                            tabControlador = "2504"
                        Case 35
                            tabControlador = "6400"
                        Case 36
                            Dim tabControlador2 = 1100

                            While (NroAluno = String.Empty)
                                Try
                                    NroAluno = navegadorEscolhido.findElement(By.XPath(String.Format("//table[contains(@id,'tabLancamentoFechamentoAvaliacoes{0}')]/tbody/tr/td[2]", tabControlador2))).Text()
                                    tabControlador2 = tabControlador2 + 1
                                    tabControlador = tabControlador2
                                Catch ex As Exception
                                End Try
                            End While
                    End Select

                    Try
                        NroAluno = navegadorEscolhido.findElement(By.XPath(String.Format("//table[contains(@id,'tabLancamentoFechamentoAvaliacoes{0}')]/tbody/tr/td[2]", tabControlador))).Text()
                    Catch ex As Exception
                        NroAluno = String.Empty
                    End Try
                    x = x + 1
                End While

                If NroAluno <> String.Empty Then

                    '... Envia os dados Tab ...
                    Try
                        For i = 1 To nroTotalAlunos + 10 Step 1
                            bkTodas.ReportProgress(i + 1)

                            Try
                                NroAluno = navegadorEscolhido.findElement(By.XPath(String.Format("//table[contains(@id,'tabLancamentoFechamentoAvaliacoes" & tabControlador & "')]/tbody/tr[{0}]/td[2]", i))).Text()
                                If cbAF.Checked = True Or tBimestre.Value = 5 Then
                                    preencherBoletimFinal(i, iMedia(NroAluno), iPR(NroAluno))
                                Else
                                    preencherBoletim(NroAluno, iMedia(NroAluno), iFalta(NroAluno), iAC(NroAluno), "-")
                                End If
                                posicaoNroAlunos = posicaoNroAlunos + 1

                            Catch ex As Exception
                                '\\ QUANDO ACABAR O ALUNO...
                                NroAluno_AC = NroAluno_AC + 1
                                NroAluno_FT = NroAluno_FT + 1
                                NroAluno_AV = NroAluno_AV + 1
                                Exit For
                            End Try

                        Next
                    Catch ex As Exception
                    End Try
                End If
                y = y + 1
            End While
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bkTodas_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bkTodas.ProgressChanged

        Invoke(Sub()
                   Me.barra.Properties.DisplayFormat.FormatString = "Enviando: [ " & e.ProgressPercentage & " / " & nroTotalAlunos - 1 & " ]"
                   Me.barra.EditValue = e.ProgressPercentage
               End Sub)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btFirefox.Click
        inicializar("Firefox", URL.Text)

    End Sub

    Private Sub tBimestre_TextChanged(sender As Object, e As EventArgs) Handles tBimestre.TextChanged

        If tBimestre.Value = 2 Or tBimestre.Value = 4 Then
            cbAF.Enabled = True
            bimestre = tBimestre.Text
        Else
            cbAF.Enabled = False
            bimestre = tBimestre.Text
        End If
        Consulta_PrevistasDadas()
        Carregar_DisciplinasBoletim()

    End Sub

    Private Sub bkDisciplina_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkDisciplina.DoWork

        Dim Controlador = 0
        Dim NroAluno = String.Empty

        ' PROCURA O NUMERO DO ALUNO...
        Dim x = 1
        While (NroAluno = String.Empty)

            Select Case x
                Case 1
                    tabControlador = "3100"
                Case 2
                    tabControlador = "2600"
                Case 3
                    tabControlador = "1813"
                Case 4
                    tabControlador = "2800"
                Case 5
                    tabControlador = "2200"
                Case 6
                    tabControlador = "2300"
                Case 7
                    tabControlador = "1400"
                Case 8
                    tabControlador = "2400"
                Case 9
                    tabControlador = "2100"
                Case 10
                    tabControlador = "2700"
                Case 11
                    tabControlador = "1900"
                Case 12
                    tabControlador = "1111"
                Case 13
                    tabControlador = "2500"
                Case 14
                    tabControlador = "1100"
                Case 15
                    tabControlador = "2707"
                Case 16
                    tabControlador = "2105"
                Case 17
                    tabControlador = "1814"
                Case 18
                    tabControlador = "1401"
                Case 19
                    tabControlador = "2208"
                Case 20
                    tabControlador = "2306"
                Case 21
                    tabControlador = "3105"
                Case 22
                    tabControlador = "2605"
                Case 23
                    tabControlador = "2812"
                Case 24
                    tabControlador = "2413"
                Case 25
                    tabControlador = "1119"
                Case 26
                    tabControlador = "1903"
                Case 27
                    tabControlador = "1118"
                Case 28
                    tabControlador = "8427"
                Case 29
                    tabControlador = "8442"
                Case 30
                    tabControlador = "8443"
                Case 31
                    tabControlador = "8446"
                Case 32
                    tabControlador = "8447"
                Case 33
                    tabControlador = "8441"
                Case 34
                    tabControlador = "2504"
                Case 35
                    tabControlador = "6400"
                Case 36
                    Dim tabControlador2 = 1100

                    While (NroAluno = String.Empty)
                        Try
                            NroAluno = navegadorEscolhido.findElement(By.XPath(String.Format("//table[contains(@id,'tabLancamentoFechamentoAvaliacoes{0}')]/tbody/tr/td[2]", tabControlador2))).Text()
                            tabControlador2 = tabControlador2 + 1
                            tabControlador = tabControlador2
                        Catch ex As Exception
                        End Try
                    End While
            End Select

            Try
                NroAluno = navegadorEscolhido.findElement(By.XPath(String.Format("//table[contains(@id,'tabLancamentoFechamentoAvaliacoes{0}')]/tbody/tr/td[2]", tabControlador))).Text()
            Catch ex As Exception
                NroAluno = String.Empty
            End Try
            x = x + 1
        End While

        If NroAluno <> String.Empty Then

            '... Envia os dados Tab ...
            Try
                For i = 1 To nroTotalAlunos + 10 Step 1
                    bkDisciplina.ReportProgress(i + 1)
                    Try
                        NroAluno = navegadorEscolhido.findElement(By.XPath(String.Format("//table[contains(@id,'tabLancamentoFechamentoAvaliacoes" & tabControlador & "')]/tbody/tr[{0}]/td[2]", i))).Text()
                        If cbAF.Checked = True Or tBimestre.Value = 5 Then
                            preencherBoletimFinal(i, iMedia(NroAluno), iPR(NroAluno))
                        Else
                            preencherBoletim(NroAluno, iMedia(NroAluno), iFalta(NroAluno), iAC(NroAluno), "-")
                        End If
                        posicaoNroAlunos = posicaoNroAlunos + 1
                    Catch ex As Exception
                        '\\ QUANDO ACABAR O ALUNO...
                        NroAluno_AC = NroAluno_AC + 1
                        NroAluno_FT = NroAluno_FT + 1
                        NroAluno_AV = NroAluno_AV + 1
                        Exit For
                    End Try
                Next
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub btEnviarDisciplina_Click(sender As Object, e As EventArgs) Handles btEnviarDisciplina.Click

        bkDisciplina.RunWorkerAsync()
        btEnviarTodas.Enabled = False
        btEnviarDisciplina.Enabled = False

    End Sub

    Private Sub tAno_TextChanged(sender As Object, e As EventArgs) Handles tAno.TextChanged
        Consulta_PrevistasDadas()
        Carregar_DisciplinasBoletim()

    End Sub

    Private Sub cbDisciplina_EditValueChanged(sender As Object, e As EventArgs) Handles cbDisciplina.EditValueChanged

    End Sub

    Private Sub btChrome_Click(sender As Object, e As EventArgs) Handles btChrome.Click
        inicializar("Chrome", URL.Text)
    End Sub

    Private Sub bkDisciplina_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bkDisciplina.ProgressChanged

        Invoke(Sub()
                   Me.barra.Properties.DisplayFormat.FormatString = "Enviando: [ " & e.ProgressPercentage & " / " & nroTotalAlunos - 1 & " ]"
                   Me.barra.EditValue = e.ProgressPercentage
               End Sub)

    End Sub
End Class
