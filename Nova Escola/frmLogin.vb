Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Threading
Imports Mais_Escola.MeusProjetos

Public Class frmLogin

    Inherits XtraForm
    Friend WithEvents tbUsuario As TextEdit
    Friend WithEvents tbSenha As TextEdit
    Friend WithEvents btContinuar As SimpleButton
    Friend WithEvents PictureEdit1 As PictureEdit
    Friend WithEvents PictureEdit2 As PictureEdit
    Friend WithEvents PictureEdit3 As PictureEdit
    Friend WithEvents ValidationHint1 As DevExpress.Utils.VisualEffects.ValidationHint
    Friend WithEvents Badge1 As DevExpress.Utils.VisualEffects.Badge
    Friend WithEvents bwWS As System.ComponentModel.BackgroundWorker
    Friend WithEvents btFechar As SimpleButton
    Private WithEvents labelControl1 As LabelControl
    Friend WithEvents PictureEdit4 As PictureEdit

    Public NotInheritable Class Simple3Des

        ' ... ENCRIPTACAO & DESINCRIPTACAO ... !!!

        Sub New(ByVal passprog As String)

            Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("pt-BR")
            Localizer.Active = Localizer.CreateDefaultLocalizer()

            'Add any initialization after the InitializeComponent() call
            SkinManager.EnableFormSkins()
            SkinManager.EnableMdiFormSkins()
            BonusSkins.Register()

            Dim defaultLF As DefaultLookAndFeel = New DefaultLookAndFeel()
            defaultLF.LookAndFeel.UseDefaultLookAndFeel = True
            UserLookAndFeel.Default.SkinName = "Office 2016 Colorful"

        End Sub

        Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.
            Dim keyBytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        End Function

    End Class

#Region "Windows Form Designer generated code"

    Public Sub New()
        MyBase.New()

        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("pt-BR")
        Localizer.Active = Localizer.CreateDefaultLocalizer()

        'Add any initialization after the InitializeComponent() call
        SkinManager.EnableFormSkins()
        SkinManager.EnableMdiFormSkins()
        BonusSkins.Register()

        Dim defaultLF As DefaultLookAndFeel = New DefaultLookAndFeel()
        defaultLF.LookAndFeel.UseDefaultLookAndFeel = True
        UserLookAndFeel.Default.SkinName = "Office 2016 Colorful"

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.tbUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.tbSenha = New DevExpress.XtraEditors.TextEdit()
        Me.ValidationHint1 = New DevExpress.Utils.VisualEffects.ValidationHint()
        Me.Badge1 = New DevExpress.Utils.VisualEffects.Badge()
        Me.bwWS = New System.ComponentModel.BackgroundWorker()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.btContinuar = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btFechar = New DevExpress.XtraEditors.SimpleButton()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit4 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tbUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSenha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(286, 120)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tbUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tbUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.tbUsuario.Properties.Appearance.Options.UseFont = True
        Me.tbUsuario.Properties.Appearance.Options.UseForeColor = True
        Me.tbUsuario.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbUsuario.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbUsuario.Size = New System.Drawing.Size(227, 22)
        Me.tbUsuario.TabIndex = 0
        '
        'tbSenha
        '
        Me.tbSenha.Location = New System.Drawing.Point(286, 148)
        Me.tbSenha.Name = "tbSenha"
        Me.tbSenha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tbSenha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSenha.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tbSenha.Properties.Appearance.Options.UseBackColor = True
        Me.tbSenha.Properties.Appearance.Options.UseFont = True
        Me.tbSenha.Properties.Appearance.Options.UseForeColor = True
        Me.tbSenha.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbSenha.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbSenha.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbSenha.Size = New System.Drawing.Size(227, 22)
        Me.tbSenha.TabIndex = 1
        '
        'PictureEdit3
        '
        Me.PictureEdit3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit3.EditValue = CType(resources.GetObject("PictureEdit3.EditValue"), Object)
        Me.PictureEdit3.Location = New System.Drawing.Point(258, 148)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit3.Size = New System.Drawing.Size(22, 22)
        Me.PictureEdit3.TabIndex = 29
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(258, 120)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Size = New System.Drawing.Size(22, 22)
        Me.PictureEdit2.TabIndex = 28
        '
        'btContinuar
        '
        Me.btContinuar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btContinuar.Appearance.Options.UseFont = True
        Me.btContinuar.ImageOptions.Image = CType(resources.GetObject("btContinuar.ImageOptions.Image"), System.Drawing.Image)
        Me.btContinuar.Location = New System.Drawing.Point(489, 176)
        Me.btContinuar.Name = "btContinuar"
        Me.btContinuar.Size = New System.Drawing.Size(24, 22)
        Me.btContinuar.TabIndex = 2
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(541, 337)
        Me.PictureEdit1.TabIndex = 27
        '
        'btFechar
        '
        Me.btFechar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Appearance.Options.UseFont = True
        Me.btFechar.AutoSize = True
        Me.btFechar.ImageOptions.Image = CType(resources.GetObject("btFechar.ImageOptions.Image"), System.Drawing.Image)
        Me.btFechar.Location = New System.Drawing.Point(489, 92)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(22, 22)
        Me.btFechar.TabIndex = 30
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.Appearance.Options.UseFont = True
        Me.labelControl1.Appearance.Options.UseTextOptions = True
        Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl1.Location = New System.Drawing.Point(556, 298)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(176, 13)
        Me.labelControl1.TabIndex = 32
        Me.labelControl1.Text = "www.thiagoteixeira.com.br"
        '
        'PictureEdit4
        '
        Me.PictureEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit4.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit4.EditValue = CType(resources.GetObject("PictureEdit4.EditValue"), Object)
        Me.PictureEdit4.Location = New System.Drawing.Point(535, 0)
        Me.PictureEdit4.Name = "PictureEdit4"
        Me.PictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit4.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.PictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit4.Size = New System.Drawing.Size(209, 269)
        Me.PictureEdit4.TabIndex = 33
        '
        'frmLogin
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(744, 335)
        Me.Controls.Add(Me.PictureEdit4)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.btContinuar)
        Me.Controls.Add(Me.tbSenha)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pl/[o"
        CType(Me.tbUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSenha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            meucaminho = Environment.CurrentDirectory
            meucaminho = Mid(meucaminho, 1, 3)
            meucaminhorelatorio = meucaminho & "MaisEscola"
        Catch ex As Exception
        End Try

        tbUsuario.Focus()

        ' PUXA CONFIGURAÇÕES...
        AnoVigente = Format(Date.Now, "yyyy")
        DataSistema = Format(Date.Now, "dd/MM/yyyy")


    End Sub

    Private Sub btContinuar_Click(sender As Object, e As EventArgs) Handles btContinuar.Click
        Dim resultado = ""

        If Not String.IsNullOrEmpty(tbUsuario.Text) Then

            Try
                Using login = New MeusProjetos.MeusProjetos()

                    resultado = login.Validar(tbUsuario.Text, tbSenha.Text, "minhaescola")
                    If resultado <> "" Then

                        Hide()
                        CONEXAOBD = resultado

                        frmPrincipal.Show()

                    End If

                End Using

            Catch ex As Exception

            End Try

        End If

        If resultado = "" Then
            MsgBox("Dados inválidos. Informe seu usuário e senha.")
        End If


    End Sub

    Private Sub tbSenha_Click(sender As Object, e As EventArgs) Handles tbSenha.Click

        If tbSenha.Text <> String.Empty Then
            tbSenha.SelectAll()
        End If

    End Sub

    Private Sub tbSenha_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles tbSenha.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btContinuar.Focus()
        End If

    End Sub

    Private Sub tbUsuario_Click(sender As Object, e As EventArgs) Handles tbUsuario.Click
        If tbUsuario.Text <> String.Empty Then
            tbUsuario.SelectAll()
        End If
    End Sub

    Private Sub tbUsuario_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles tbUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tbSenha.Focus()
        End If
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click

        Environment.Exit(0)

    End Sub


    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try
            Environment.Exit(0)
        Catch ex As Exception
        End Try
    End Sub

End Class
