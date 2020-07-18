Imports System.Web
Public Class frmGDAELogin
    Inherits System.Windows.Forms.Form
    Dim USR
    Dim Lembrar

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
    Friend WithEvents cbLembrar As DevComponents.DotNetBar.Controls.CheckBoxX

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents webBrowser As AxSHDocVw.AxWebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGDAELogin))
        Me.webBrowser = New AxSHDocVw.AxWebBrowser
        Me.cbLembrar = New DevComponents.DotNetBar.Controls.CheckBoxX
        CType(Me.webBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webBrowser
        '
        Me.webBrowser.Dock = System.Windows.Forms.DockStyle.Top
        Me.webBrowser.Enabled = True
        Me.webBrowser.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser.OcxState = CType(resources.GetObject("webBrowser.OcxState"), System.Windows.Forms.AxHost.State)
        Me.webBrowser.Size = New System.Drawing.Size(244, 150)
        Me.webBrowser.TabIndex = 0
        '
        'cbLembrar
        '
        Me.cbLembrar.BackColor = System.Drawing.Color.White
        Me.cbLembrar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLembrar.Location = New System.Drawing.Point(124, 118)
        Me.cbLembrar.Name = "cbLembrar"
        Me.cbLembrar.Size = New System.Drawing.Size(122, 23)
        Me.cbLembrar.TabIndex = 1
        Me.cbLembrar.Text = "Lembrar usuário!"
        '
        'frmGDAELogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(244, 146)
        Me.Controls.Add(Me.cbLembrar)
        Me.Controls.Add(Me.webBrowser)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGDAELogin"
        Me.ShowInTaskbar = False
        Me.Text = "Mais Escola - Login GDAE"
        CType(Me.webBrowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CodigoSEE = 0

        Try
            '###### SE EXISTIR ######
            Dim oRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
            oRegistryKey = oRegistryKey.OpenSubKey("Mais Escola")
            Lembrar = oRegistryKey.GetValue("TR")
            USR = oRegistryKey.GetValue("USR")

            If Lembrar = 1 Then
                cbLembrar.Checked = True
            Else
                cbLembrar.Checked = False
            End If

        Catch ex As Exception
            '###### SE NAO EXISTIR ######
            Dim oRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
            oRegistryKey = oRegistryKey.CreateSubKey("Mais Escola")
            oRegistryKey.SetValue("TR", "0")
        End Try

        Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("MicroD.Vms")
        myRegKey2 = myRegKey2.OpenSubKey("Classes")

        Dim ferramenta5 As Object = myRegKey2.GetValue("ferramenta5")
        IP_GDAE = ferramenta5
        webBrowser.Navigate(IP_GDAE & "/projetos.html")

    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        webBrowser = Nothing
    End Sub

    Public Function SoNumero(ByVal Text As String) As String
        Dim i As Integer, j As String = ""
        For i = 1 To Len(Text)
            If Asc(Mid(Text, i, 1)) < 48 Or _
               Asc(Mid(Text, i, 1)) > 57 Then
            Else
                j = j & Mid(Text, i, 1)
            End If
            SoNumero = j
        Next
    End Function

    Private Sub webBrowser_DocumentComplete(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent) Handles webBrowser.DocumentComplete

        Try
            webBrowser.Document.GetElementById("0").InnerText = "Avaliações e Freqüência"
        Catch ex As Exception
        End Try

        If Lembrar = 1 Then
            cbLembrar.Checked = True
            Try
                webBrowser.Document.GetElementById("Usuario").InnerText = USR
            Catch ex As Exception
            End Try
            CodigoSEE = SoNumero(USR)
        Else
            cbLembrar.Checked = False
        End If

    End Sub

    Private Sub webBrowser_NewWindow2(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_NewWindow2Event) Handles webBrowser.NewWindow2

        'VEJA SE A ESCOLA PREFERE SALVAR O USUARIO
        If cbLembrar.Checked = True Then
            '###### SE PREFERIR ######
            Try
                Dim oRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
                oRegistryKey = oRegistryKey.CreateSubKey("Mais Escola")
                oRegistryKey.SetValue("TR", 1)
                oRegistryKey.SetValue("USR", webBrowser.Document.All.Item("Usuario").Value)
            Catch ex As Exception
            End Try
        Else
            '###### SE NAO PREFERIR ######
            Dim oRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
            oRegistryKey = oRegistryKey.CreateSubKey("Mais Escola")
            oRegistryKey.SetValue("TR", "0")
        End If

        'ABRE A NOVA JANELA
        Dim frmWB As frmGDAEOperador
        frmWB = New frmGDAEOperador
        frmWB.webBrowser2.RegisterAsBrowser = True
        e.ppDisp = frmWB.webBrowser2.Application
        frmWB.Visible = True

    End Sub

    Private Sub webBrowser_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles webBrowser.Enter

    End Sub
End Class
