Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Public Class frmPrincipal

    Inherits System.Windows.Forms.Form

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim sql

    Dim BD_OK, IP_OK, imagem_OK

    Dim info As New cpInfo.psInfo

    Public Shared fPrincipal As New frmPrincipal()
    Public Shared fRegistro As New frmRegistro()

    Public Shared fCadBoletim As New frmCadBoletim()
    Public Shared fConBoletim As New frmConBoletim()
    Public Shared fManBoletim As New frmManBoletim()

    Public Shared fCadDisciplinas As New frmCadDisciplinas()
    Public Shared fConDisciplinas As New frmConDisciplinas()
    Public Shared fManDisciplinas As New frmManDisciplinas()

    Public Shared fCadNF As New frmCadNF()
    Public Shared fRptNF As New frmRptNF()

    Public Shared fCadProfessor As New frmCadProfessor()
    Public Shared fConProfessor As New frmConProfessor()
    Public Shared fManProfessor As New frmManProfessor()

    Public Shared fCadTurma As New frmCadturma()
    Public Shared fConTurma As New frmConturma()
    Public Shared fManTurma As New frmManTurma()

    Public Shared fGerencial2 As New frmGerencial2()
    Public Shared fGerencialRPT As New frmRpt()

    Public Shared fManACP As New frmManACP()
    Public Shared fManNFsf As New frmManNFsf()
    Public Shared fManNF As New frmManNF()
    Public Shared fManAulasPrevistas As New frmManAulasPrevistas

    Public Shared fImportarAlunos As New Importacao
    Public Shared fImportarAlunos2 As New Importacao2

    Public Shared fFerNavegador As New frmFerNavegador
    Public Shared fGerenciadorRPT As New frmGerencialRPT
    Public Shared fSobre As New frmSobre
    Public Shared fSobre2 As New frmSobre2

    Dim strTemp As String
    Friend WithEvents mEstrutura As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mRelatorio As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents mNF As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents tTudo As System.Windows.Forms.Label
    Friend WithEvents tProfe As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents ppropaganda2 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem


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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Timers.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mEstrutura = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.mNF = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.mRelatorio = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.Timer1 = New System.Timers.Timer
        Me.tTudo = New System.Windows.Forms.Label
        Me.tProfe = New System.Windows.Forms.Label
        Me.ppropaganda2 = New System.Windows.Forms.PictureBox
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppropaganda2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mEstrutura, Me.mNF, Me.mRelatorio, Me.MenuItem52, Me.MenuItem66, Me.MenuItem5})
        '
        'mEstrutura
        '
        Me.mEstrutura.Index = 0
        Me.mEstrutura.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14, Me.MenuItem3, Me.MenuItem36, Me.MenuItem8, Me.MenuItem4, Me.MenuItem13})
        resources.ApplyResources(Me.mEstrutura, "mEstrutura")
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 0
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem35, Me.MenuItem15, Me.MenuItem32, Me.MenuItem33})
        resources.ApplyResources(Me.MenuItem14, "MenuItem14")
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 0
        Me.MenuItem35.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem47, Me.MenuItem48})
        resources.ApplyResources(Me.MenuItem35, "MenuItem35")
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 0
        resources.ApplyResources(Me.MenuItem47, "MenuItem47")
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 1
        resources.ApplyResources(Me.MenuItem48, "MenuItem48")
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        resources.ApplyResources(Me.MenuItem15, "MenuItem15")
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 2
        resources.ApplyResources(Me.MenuItem32, "MenuItem32")
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 3
        resources.ApplyResources(Me.MenuItem33, "MenuItem33")
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem17, Me.MenuItem18})
        resources.ApplyResources(Me.MenuItem3, "MenuItem3")
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        resources.ApplyResources(Me.MenuItem16, "MenuItem16")
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        resources.ApplyResources(Me.MenuItem17, "MenuItem17")
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        resources.ApplyResources(Me.MenuItem18, "MenuItem18")
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 2
        Me.MenuItem36.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40, Me.MenuItem49})
        resources.ApplyResources(Me.MenuItem36, "MenuItem36")
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 0
        resources.ApplyResources(Me.MenuItem37, "MenuItem37")
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 1
        resources.ApplyResources(Me.MenuItem38, "MenuItem38")
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 2
        resources.ApplyResources(Me.MenuItem39, "MenuItem39")
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 3
        resources.ApplyResources(Me.MenuItem40, "MenuItem40")
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 4
        Me.MenuItem49.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem50, Me.MenuItem51})
        resources.ApplyResources(Me.MenuItem49, "MenuItem49")
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 0
        resources.ApplyResources(Me.MenuItem50, "MenuItem50")
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 1
        resources.ApplyResources(Me.MenuItem51, "MenuItem51")
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem20, Me.MenuItem24})
        resources.ApplyResources(Me.MenuItem8, "MenuItem8")
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        resources.ApplyResources(Me.MenuItem19, "MenuItem19")
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        resources.ApplyResources(Me.MenuItem20, "MenuItem20")
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem26, Me.MenuItem1})
        resources.ApplyResources(Me.MenuItem24, "MenuItem24")
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        resources.ApplyResources(Me.MenuItem21, "MenuItem21")
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        resources.ApplyResources(Me.MenuItem26, "MenuItem26")
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        resources.ApplyResources(Me.MenuItem1, "MenuItem1")
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem11, Me.MenuItem12})
        resources.ApplyResources(Me.MenuItem4, "MenuItem4")
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        resources.ApplyResources(Me.MenuItem9, "MenuItem9")
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        resources.ApplyResources(Me.MenuItem11, "MenuItem11")
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        resources.ApplyResources(Me.MenuItem12, "MenuItem12")
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 5
        resources.ApplyResources(Me.MenuItem13, "MenuItem13")
        '
        'mNF
        '
        Me.mNF.Index = 1
        Me.mNF.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem6, Me.MenuItem25, Me.MenuItem10})
        resources.ApplyResources(Me.mNF, "mNF")
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        resources.ApplyResources(Me.MenuItem23, "MenuItem23")
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        resources.ApplyResources(Me.MenuItem6, "MenuItem6")
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 2
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem27, Me.MenuItem29})
        resources.ApplyResources(Me.MenuItem25, "MenuItem25")
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        resources.ApplyResources(Me.MenuItem28, "MenuItem28")
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        resources.ApplyResources(Me.MenuItem27, "MenuItem27")
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 2
        resources.ApplyResources(Me.MenuItem29, "MenuItem29")
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 3
        resources.ApplyResources(Me.MenuItem10, "MenuItem10")
        '
        'mRelatorio
        '
        Me.mRelatorio.Index = 2
        Me.mRelatorio.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem34, Me.MenuItem31, Me.MenuItem7, Me.MenuItem2, Me.MenuItem44, Me.MenuItem41})
        resources.ApplyResources(Me.mRelatorio, "mRelatorio")
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 0
        Me.MenuItem34.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem42, Me.MenuItem43})
        resources.ApplyResources(Me.MenuItem34, "MenuItem34")
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 0
        resources.ApplyResources(Me.MenuItem42, "MenuItem42")
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 1
        resources.ApplyResources(Me.MenuItem43, "MenuItem43")
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 1
        Me.MenuItem31.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem45, Me.MenuItem46})
        resources.ApplyResources(Me.MenuItem31, "MenuItem31")
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 0
        resources.ApplyResources(Me.MenuItem45, "MenuItem45")
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 1
        resources.ApplyResources(Me.MenuItem46, "MenuItem46")
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem30, Me.MenuItem22})
        resources.ApplyResources(Me.MenuItem7, "MenuItem7")
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 0
        resources.ApplyResources(Me.MenuItem30, "MenuItem30")
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        resources.ApplyResources(Me.MenuItem22, "MenuItem22")
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem69, Me.MenuItem55, Me.MenuItem54})
        resources.ApplyResources(Me.MenuItem2, "MenuItem2")
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 0
        resources.ApplyResources(Me.MenuItem69, "MenuItem69")
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 1
        resources.ApplyResources(Me.MenuItem55, "MenuItem55")
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 2
        resources.ApplyResources(Me.MenuItem54, "MenuItem54")
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 4
        Me.MenuItem44.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem58, Me.MenuItem57, Me.MenuItem59})
        resources.ApplyResources(Me.MenuItem44, "MenuItem44")
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 0
        resources.ApplyResources(Me.MenuItem58, "MenuItem58")
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 1
        resources.ApplyResources(Me.MenuItem57, "MenuItem57")
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 2
        Me.MenuItem59.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem60, Me.MenuItem61, Me.MenuItem62, Me.MenuItem63, Me.MenuItem64, Me.MenuItem65})
        resources.ApplyResources(Me.MenuItem59, "MenuItem59")
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 0
        resources.ApplyResources(Me.MenuItem60, "MenuItem60")
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 1
        resources.ApplyResources(Me.MenuItem61, "MenuItem61")
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 2
        resources.ApplyResources(Me.MenuItem62, "MenuItem62")
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 3
        resources.ApplyResources(Me.MenuItem63, "MenuItem63")
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 4
        resources.ApplyResources(Me.MenuItem64, "MenuItem64")
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 5
        resources.ApplyResources(Me.MenuItem65, "MenuItem65")
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 5
        resources.ApplyResources(Me.MenuItem41, "MenuItem41")
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 3
        Me.MenuItem52.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem53, Me.MenuItem56})
        resources.ApplyResources(Me.MenuItem52, "MenuItem52")
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 0
        resources.ApplyResources(Me.MenuItem53, "MenuItem53")
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 1
        resources.ApplyResources(Me.MenuItem56, "MenuItem56")
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 4
        Me.MenuItem66.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem68, Me.MenuItem67})
        resources.ApplyResources(Me.MenuItem66, "MenuItem66")
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 0
        resources.ApplyResources(Me.MenuItem68, "MenuItem68")
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 1
        resources.ApplyResources(Me.MenuItem67, "MenuItem67")
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        resources.ApplyResources(Me.MenuItem5, "MenuItem5")
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        '
        'StatusBarPanel1
        '
        resources.ApplyResources(Me.StatusBarPanel1, "StatusBarPanel1")
        '
        'StatusBarPanel2
        '
        resources.ApplyResources(Me.StatusBarPanel2, "StatusBarPanel2")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.SynchronizingObject = Me
        '
        'tTudo
        '
        resources.ApplyResources(Me.tTudo, "tTudo")
        Me.tTudo.Name = "tTudo"
        '
        'tProfe
        '
        resources.ApplyResources(Me.tProfe, "tProfe")
        Me.tProfe.Name = "tProfe"
        '
        'ppropaganda2
        '
        Me.ppropaganda2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.ppropaganda2, "ppropaganda2")
        Me.ppropaganda2.Name = "ppropaganda2"
        Me.ppropaganda2.TabStop = False
        '
        'frmPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ppropaganda2)
        Me.Controls.Add(Me.tProfe)
        Me.Controls.Add(Me.tTudo)
        Me.Controls.Add(Me.StatusBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppropaganda2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        End

    End Sub



    Protected Overrides Sub Finalize()
        MyBase.Finalize()

    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        StatusBar1.Text = "Nova Escola - Versão 5.5   |   http://www.isolucao.com.br   |   Central de Atendimento: (16) 3234-6500   |   " & Date.Today & ""


        Dim x, r

        myData.Clear()
        x = info.ccheck(x)

        If x = 5 Then

            mEstrutura.Enabled = False
            mNF.Enabled = False
            mRelatorio.Enabled = False

            Hide()
            fRegistro.Show()
            Exit Sub
        End If

        Dim dec As Decimal = 1
        Dim strin As String = 1
        Dim tVal
        '     dec = dec * 1 + 2
        '     MsgBox("" & dec)
        '    strin = dec * strin + 1
        '    MsgBox("" & strin)
        'Inicio do registro das datas de: 
        ' X - Data Ultimo Acesso ao Programa
        If (tVal <> 5) Then
            Dim x1
            Dim cRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("MicroD.Vms")
            cRegistryKey = cRegistryKey.CreateSubKey("Classes")

            'INICIO DO X
            Dim dataatual
            dataatual = Now()
            x1 = FormatDateTime(dataatual, DateFormat.LongDate)
            cRegistryKey.SetValue("x", "" & x1)
            'FIM DO X
        End If

        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")

            BD_OK = BD
            IP_OK = IP

        Catch ex As Exception
        End Try


        'usuario personalizado
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        sql = "SELECT * FROM " & BD_OK & ".usuariodsk WHERE usuario='" & tTudo.Text & "'"

        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = sql
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                'Dim usuario

                r = myData.Rows(0)

                'If r IsNot DBNull.Value Then

                ''CADASTRO()
                If r("cod_prof") = 0 Then
                    'Libera tudo
                    mEstrutura.Visible = True

                    mRelatorio.Visible = True

                    mNF.Visible = True


                Else
                    'Libera somente para cadastro das notas e relatorios
                    mNF.Visible = True

                    mRelatorio.Visible = True

                    mEstrutura.Visible = False

                End If

                tProfe.Text = r("cod_prof")

                'End If
            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                Exit Sub
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
            Exit Sub
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    ppropaganda2.Visible = False

        fRegistro = New frmRegistro
        fRegistro.MdiParent = Me
        fRegistro.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        ppropaganda2.Visible = False

        fCadTurma = New frmCadturma
        fCadTurma.MdiParent = Me
        fCadTurma.Show()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click

        ppropaganda2.Visible = False

        fConTurma = New frmConturma
        fConTurma.MdiParent = Me
        fConTurma.Show()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        ppropaganda2.Visible = False

        fManTurma = New frmManTurma
        fManTurma.MdiParent = Me
        fManTurma.Show()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        ppropaganda2.Visible = False

        fCadDisciplinas = New frmCadDisciplinas
        fCadDisciplinas.MdiParent = Me
        fCadDisciplinas.Show()
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        ppropaganda2.Visible = False

        fConDisciplinas = New frmConDisciplinas
        fConDisciplinas.MdiParent = Me
        fConDisciplinas.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        ppropaganda2.Visible = False

        fManDisciplinas = New frmManDisciplinas
        fManDisciplinas.MdiParent = Me
        fManDisciplinas.Show()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ppropaganda2.Visible = False

        fCadProfessor = New frmCadProfessor
        fCadProfessor.MdiParent = Me
        fCadProfessor.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ppropaganda2.Visible = False

        fConProfessor = New frmConProfessor
        fConProfessor.MdiParent = Me
        fConProfessor.Show()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ppropaganda2.Visible = False

        fManProfessor = New frmManProfessor
        fManProfessor.MdiParent = Me
        fManProfessor.Show()
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        ppropaganda2.Visible = False

        fCadNF = New frmCadNF
        fCadNF.MdiParent = Me
        fCadNF.Show()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        ppropaganda2.Visible = False

        fConBoletim = New frmConBoletim
        fConBoletim.MdiParent = Me
        fConBoletim.Show()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        ppropaganda2.Visible = False

        fManNFsf = New frmManNFsf
        fManNFsf.MdiParent = Me
        fManNFsf.Show()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ppropaganda2.Visible = False

        fGerencial2 = New frmGerencial2
        fGerencial2.MdiParent = Me
        fGerencial2.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ppropaganda2.Visible = False

        fConBoletim = New frmConBoletim
        fConBoletim.MdiParent = Me
        fConBoletim.Show()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        ppropaganda2.Visible = False

        fManACP = New frmManACP
        fManACP.MdiParent = Me
        fManACP.Show()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        ppropaganda2.Visible = False


        Dim w
        w = "NF"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ppropaganda2.Visible = False

        Dim a
        a = "AC"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = a
        fGerencialRPT.Show()

    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        ppropaganda2.Visible = False

        fManNF = New frmManNF
        fManNF.MdiParent = Me
        fManNF.Show()

    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        ppropaganda2.Visible = False


        Dim w
        w = "SF"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub MenuItem27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        ppropaganda2.Visible = False

        fManNF = New frmManNF
        fManNF.MdiParent = Me
        fManNF.Show()

    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        ppropaganda2.Visible = False

        Dim b
        b = tProfe.Text

        fManAulasPrevistas = New frmManAulasPrevistas
        fManAulasPrevistas.MdiParent = Me
        fManAulasPrevistas.Show()

    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        ppropaganda2.Visible = False


        Dim b
        b = tProfe.Text

        fManNFsf = New frmManNFsf
        fManNFsf.MdiParent = Me
        fManNFsf.Show()

    End Sub

    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        ppropaganda2.Visible = False

        fGerencial2 = New frmGerencial2
        fGerencial2.MdiParent = Me
        fGerencial2.Show()
    End Sub

    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        ppropaganda2.Visible = False

        fCadProfessor = New frmCadProfessor
        fCadProfessor.MdiParent = Me
        fCadProfessor.Show()
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        ppropaganda2.Visible = False

        fConProfessor = New frmConProfessor
        fConProfessor.MdiParent = Me
        fConProfessor.Show()
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        ppropaganda2.Visible = False

        fManProfessor = New frmManProfessor
        fManProfessor.MdiParent = Me
        fManProfessor.Show()
    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        ppropaganda2.Visible = False

        fConBoletim = New frmConBoletim
        fConBoletim.MdiParent = Me
        fConBoletim.Show()
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        ppropaganda2.Visible = False

        Dim w
        w = "Alunos"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        ppropaganda2.Visible = False

        Dim w
        w = "AlunosAssinatura"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click

    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        ppropaganda2.Visible = False

        Dim w
        w = "Boletim"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        ppropaganda2.Visible = False

        Dim w
        w = "BoletimSN"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        ppropaganda2.Visible = False

        fImportarAlunos = New Importacao
        fImportarAlunos.MdiParent = Me
        fImportarAlunos.Show()

    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        ppropaganda2.Visible = False

        fImportarAlunos2 = New Importacao2
        fImportarAlunos2.MdiParent = Me
        fImportarAlunos2.Show()
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        ppropaganda2.Visible = False

        fGerenciadorRPT = New frmGerencialRPT
        fGerenciadorRPT.MdiParent = Me
        fGerenciadorRPT.Show()
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click

    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        ppropaganda2.Visible = False

        fSobre = New frmSobre
        fSobre.MdiParent = Me
        fSobre.Show()
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        ppropaganda2.Visible = False


        Dim b
        b = tProfe.Text

        fCadNF = New frmCadNF
        fCadNF.MdiParent = Me
        fCadNF.Show()
    End Sub

    Private Sub MenuItem54_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ppropaganda2.Visible = False

        Dim w
        w = "Consolidado"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        ppropaganda2.Visible = False

        Dim w
        w = "AFConsolidado"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        ppropaganda2.Visible = False

        fSobre2 = New frmSobre2
        fSobre2.MdiParent = Me
        fSobre2.Show()
    End Sub

    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed

    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        ppropaganda2.Visible = False

        Dim w
        w = "TGraficos"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        ppropaganda2.Visible = False

        Dim w
        w = "Graficos"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        ppropaganda2.Visible = False

        Dim w
        w = "ABEvasaoEscolar"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        ppropaganda2.Visible = False

        Dim w
        w = "TREvasaoEscolar"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        ppropaganda2.Visible = False

        Dim w
        w = "LGEvasaoEscolar"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        ppropaganda2.Visible = False

        Dim w
        w = "LSEvasaoEscolar"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        ppropaganda2.Visible = False


        Dim w
        w = "REEvasaoEscolar"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click

        ppropaganda2.Visible = False

        Dim w
        w = "FAEvasaoEscolar"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()

    End Sub

    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        System.Diagnostics.Process.Start("http://www.isolucao.com.br/")
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        System.Diagnostics.Process.Start("http://suporte.isolucao.com.br/nedown/Manual.pdf")
    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        ppropaganda2.Visible = False

        Dim w
        w = "AlunosReprovadosCP"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub

    Private Sub MenuItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        fFerNavegador = New frmFerNavegador
        fFerNavegador.MdiParent = Me
        fFerNavegador.Show()
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click

    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click

    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click

    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        ppropaganda2.Visible = False

        Dim w
        w = "Consolidado"

        fGerencialRPT = New frmRpt
        fGerencialRPT.MdiParent = Me
        fGerencialRPT.lbParametro.Text = w
        fGerencialRPT.Show()
    End Sub
End Class


