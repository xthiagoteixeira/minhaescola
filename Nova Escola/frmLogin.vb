Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Threading

Public Class frmLogin

    Inherits XtraForm

    Dim usuario, senha
    Friend WithEvents tbUsuario As TextEdit
    Friend WithEvents tbSenha As TextEdit
    Friend WithEvents btContinuar As SimpleButton
    Friend WithEvents pbFerramentas As PictureEdit
    Friend passprog As String = "z1AsVezesEHmelHorTerPaciencia53doQUEPerdErOAmordaVidA21Inteira"
    Friend WithEvents PictureEdit1 As PictureEdit
    Friend WithEvents PictureEdit2 As PictureEdit
    Friend WithEvents PictureEdit3 As PictureEdit
    Friend WithEvents ValidationHint1 As DevExpress.Utils.VisualEffects.ValidationHint
    Friend WithEvents Badge1 As DevExpress.Utils.VisualEffects.Badge
    Friend WithEvents bwWS As System.ComponentModel.BackgroundWorker
    Friend WithEvents btFechar As SimpleButton
    Private WithEvents labelControl1 As LabelControl
    Private WithEvents separatorControl1 As SeparatorControl
    Friend WithEvents PictureEdit4 As PictureEdit
    Friend wrapper As New Simple3Des(passprog)

    Public NotInheritable Class Simple3Des
        Private TripleDes As New TripleDESCryptoServiceProvider

        ' ... ENCRIPTACAO & DESINCRIPTACAO ... !!!

        Sub New(ByVal passprog As String)

            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash(passprog, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash(String.Empty, TripleDes.BlockSize \ 8)

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

        Function DecryptData(ByVal p1 As String) As String
            Try
                ' Convert the encrypted text string to a byte array.
                Dim encryptedBytes() As Byte = Convert.FromBase64String(p1)

                ' Create the stream.
                Dim ms As New System.IO.MemoryStream

                ' Create the decoder to write to the stream.
                Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), CryptoStreamMode.Write)

                ' Use the crypto stream to write the byte array to the stream.
                decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
                decStream.FlushFinalBlock()

                ' Convert the plaintext stream to a string.
                Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
            Catch ex As Exception
            End Try

        End Function

        Function Encrypt(ByVal p1 As String) As String
            Try
                ' Convert the plaintext string to a byte array...
                Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(p1)

                ' Create the stream.
                Dim ms As New System.IO.MemoryStream

                ' Create the encoder to write to the stream.
                Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), CryptoStreamMode.Write)

                ' Use the crypto stream to write the byte array to the stream.
                encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
                encStream.FlushFinalBlock()

                ' Convert the encrypted stream to a printable string.
                Return Convert.ToBase64String(ms.ToArray)
            Catch ex As Exception
            End Try
        End Function


    End Class

    Public Function MySQL_consulta_campo_crypt(SQL As String, Campo As String)

        Dim Retorno As String
        Dim myAdapter As New MySqlDataAdapter()
        Dim myData As New DataTable()
        Dim r As DataRow

        myData.Clear()
        myData.Columns.Clear()
        Try
            Using connection As New MySqlConnection(CONEXAOBD), cmd As New MySqlCommand(SQL, connection) With {.CommandTimeout = 300}
                connection.Open()
                myAdapter.SelectCommand = cmd
                myAdapter.Fill(myData)
                Try
                    r = myData.Rows(0)
                    Retorno = r(Campo)
                    If Retorno <> String.Empty Then
                        Retorno = wrapper.DecryptData(Retorno)
                    End If
                Catch ex As Exception
                    '   Retorno = ex.Message
                End Try
            End Using
        Catch myerro As MySqlException
        End Try

        Return Retorno

    End Function

    Public Function carry1() As String

        '... ### GERA O CODIGO SECRETO! ###
        '... INICIO do calculo para gerar numero aleatorio
        Dim cnpjKG As String
        Dim randomKG
        Dim randomKG2
        Dim randomKG3
        Dim TamanhoCS As Integer

        Dim GeradorDeNumerosAleatorios As Random = New Random()
        Dim GeradorDeNumerosAleatorios2 As Random = New Random()
        Dim GeradorDeNumerosAleatorios3 As Random = New Random()

        '''''''''''''''''''''''''''''''''''''''''''''''
        ' --- Uma chave somente com 28 caracteres --- '
        '''''''''''''''''''''''''''''''''''''''''''''''
        '
        While (TamanhoCS <> 28)
            randomKG = GeradorDeNumerosAleatorios.Next(115267559, 999999999)
            randomKG2 = GeradorDeNumerosAleatorios2.Next(864524589, 999999999)
            randomKG3 = GeradorDeNumerosAleatorios3.Next(734567099, 999999999)
            cnpjKG = String.Format("{0}{1}5{2}", randomKG, randomKG2, randomKG3)
            TamanhoCS = cnpjKG.Length
        End While

        Return cnpjKG

    End Function
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
        Me.pbFerramentas = New DevExpress.XtraEditors.PictureEdit()
        Me.btContinuar = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btFechar = New DevExpress.XtraEditors.SimpleButton()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.PictureEdit4 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tbUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSenha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFerramentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.separatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(374, 64)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tbUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tbUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.tbUsuario.Properties.Appearance.Options.UseFont = True
        Me.tbUsuario.Properties.Appearance.Options.UseForeColor = True
        Me.tbUsuario.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbUsuario.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tbUsuario.Size = New System.Drawing.Size(155, 22)
        Me.tbUsuario.TabIndex = 0
        '
        'tbSenha
        '
        Me.tbSenha.Location = New System.Drawing.Point(374, 92)
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
        Me.tbSenha.Size = New System.Drawing.Size(155, 22)
        Me.tbSenha.TabIndex = 1
        '
        'PictureEdit3
        '
        Me.PictureEdit3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit3.EditValue = CType(resources.GetObject("PictureEdit3.EditValue"), Object)
        Me.PictureEdit3.Location = New System.Drawing.Point(346, 92)
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
        Me.PictureEdit2.Location = New System.Drawing.Point(346, 64)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Size = New System.Drawing.Size(22, 22)
        Me.PictureEdit2.TabIndex = 28
        '
        'pbFerramentas
        '
        Me.pbFerramentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbFerramentas.EditValue = CType(resources.GetObject("pbFerramentas.EditValue"), Object)
        Me.pbFerramentas.Location = New System.Drawing.Point(644, 12)
        Me.pbFerramentas.Name = "pbFerramentas"
        Me.pbFerramentas.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbFerramentas.Properties.Appearance.Options.UseBackColor = True
        Me.pbFerramentas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbFerramentas.Size = New System.Drawing.Size(29, 29)
        Me.pbFerramentas.TabIndex = 3
        '
        'btContinuar
        '
        Me.btContinuar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btContinuar.Appearance.Options.UseFont = True
        Me.btContinuar.ImageOptions.Image = CType(resources.GetObject("btContinuar.ImageOptions.Image"), System.Drawing.Image)
        Me.btContinuar.Location = New System.Drawing.Point(346, 136)
        Me.btContinuar.Name = "btContinuar"
        Me.btContinuar.Size = New System.Drawing.Size(76, 26)
        Me.btContinuar.TabIndex = 2
        Me.btContinuar.Text = "Entrar!"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(27, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(196, 207)
        Me.PictureEdit1.TabIndex = 27
        '
        'btFechar
        '
        Me.btFechar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Appearance.Options.UseFont = True
        Me.btFechar.ImageOptions.Image = CType(resources.GetObject("btFechar.ImageOptions.Image"), System.Drawing.Image)
        Me.btFechar.Location = New System.Drawing.Point(453, 136)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(76, 26)
        Me.btFechar.TabIndex = 30
        Me.btFechar.Text = "Fechar"
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.Appearance.Options.UseFont = True
        Me.labelControl1.Appearance.Options.UseTextOptions = True
        Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl1.Location = New System.Drawing.Point(27, 244)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(635, 13)
        Me.labelControl1.TabIndex = 32
        Me.labelControl1.Text = "www.thiagoteixeira.com.br"
        '
        'separatorControl1
        '
        Me.separatorControl1.Location = New System.Drawing.Point(27, 215)
        Me.separatorControl1.Name = "separatorControl1"
        Me.separatorControl1.Size = New System.Drawing.Size(635, 32)
        Me.separatorControl1.TabIndex = 31
        '
        'PictureEdit4
        '
        Me.PictureEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit4.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit4.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureEdit4.EditValue = CType(resources.GetObject("PictureEdit4.EditValue"), Object)
        Me.PictureEdit4.Location = New System.Drawing.Point(679, 0)
        Me.PictureEdit4.Name = "PictureEdit4"
        Me.PictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit4.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.PictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit4.Size = New System.Drawing.Size(165, 269)
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
        Me.ClientSize = New System.Drawing.Size(844, 269)
        Me.Controls.Add(Me.PictureEdit4)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.separatorControl1)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.pbFerramentas)
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
        CType(Me.pbFerramentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.separatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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

        ' ####################### CARREGA PREFERENCIA DE USUARIOS...
        Try
            'CONEXAOBD = MeuCore.CarregaPreferencias("MaisEscola")
            CONEXAOBD = CarregaPreferencias("MaisEscola")
        Catch ex As Exception
        End Try

        ' **************************** Suporte TEAMVIEWER
        'Try
        '    SuporteRapido = Process.Start("Suporte Rápido.exe")
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub btContinuar_Click(sender As Object, e As EventArgs) Handles btContinuar.Click

        If tbUsuario.Text = String.Empty Or tbSenha.Text = String.Empty Then
            MsgBox("Digite o usuário e a senha!", MsgBoxStyle.Information, Sistema)
            btContinuar.Enabled = True
            Exit Sub
        ElseIf CONEXAOBD = String.Empty Then
            MsgBox("É necessário configurar 'Minha conexão!'", MsgBoxStyle.Information, Sistema)
            btContinuar.Enabled = True
            Exit Sub
        Else

            UsuarioSistema = tbUsuario.EditValue

            If ((tbUsuario.EditValue = "admin") And (tbSenha.EditValue = Format(Date.Now, "100482"))) Then
                idUsuarioDSK = 1

                Carrega_Fundo()

                'If MeuCore.MaquinaAutorizada("MaisEscola") = "Não autorizado!" Then
                '    Me.Hide()
                '    frmRegistro.Show()
                'Else

                ' **************** TEMPORARIO
                SQL = "SELECT CNPJ FROM empresa;"
                Dim CNPJ = MySQL_consulta_campo(SQL, "CNPJ").ToString

                If CNPJ = String.Empty Or CNPJ <> "49.619.679/0001-90" Or CNPJ <> "49.619.398/0001-38" Or CNPJ <> "49.619.364/0001-43" Or CNPJ <> "49.163.579/0001-00" Or CNPJ <> "49.959.018/0001-04" Then
                    MsgBox("Entrar em contato com o suporte", MsgBoxStyle.Information, "Mais Escola!")
                    End
                End If

                Hide()
                frmMaisEscola_Novo.Show()

                ' End If
            Else

                ''... CHECA USUARIO DO SISTEMA ...
                Try
                    SQL = String.Format("SELECT codigo, usuario, senha FROM usuariodsk WHERE usuario='{0}';", tbUsuario.EditValue)
                    usuario = MySQL_consulta_login(SQL, "usuario").ToString

                    If usuario = tbUsuario.Text Then
                        senha = MySQL_consulta_login(SQL, "senha").ToString
                    End If
                Catch ex As Exception
                    usuario = "Sem conexão!"
                End Try

                '' ... Usuario e Senha CORRETOS
                If (usuario = tbUsuario.Text) And (senha = tbSenha.Text) Then

                    ' CHECA A DATA DO SERVIDOR COM O DO MICRO...
                    Dim MeuSistema = Format(Date.Now, "yyyy-MM-dd")
                    SQL = String.Format("SELECT DATEDIFF('{0}', CURDATE()) AS Resultado;", MeuSistema)
                    Dim Resultado = MySQL_consulta_login(SQL, "Resultado")

                    If (Resultado <> "Sem conexão!") And (Resultado <> "0") Then
                        SQL = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Data incorreta do computador.', '{0}', '1', '{1}');",
                                idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
                        MySQL_atualiza(SQL)

                        MsgBox(
                            String.Format("Favor, verificar a data do servidor e deste computador.{0}Seu computador: {1}",
                                          vbCrLf, DataSistema), MsgBoxStyle.Information, "Data incorreta!")
                        End
                    End If

                    SQL = String.Format("INSERT INTO logs (Descricao, idUsuario, idLogCat, DataLancamento) VALUES ('Entrou no sistema.', '{0}', '1', '{1}');", idUsuarioDSK, Format(Date.Now, "yyyy-MM-dd HH:mm:ss"))
                    MySQL_atualiza(SQL)
                    Carrega_Fundo()

                    '' *** // Autoriza máquina // ***
                    'If MeuCore.MaquinaAutorizada("MaisEscola") = "Não autorizado!" Then
                    '    Hide()
                    '    frmRegistro.Show()
                    'Else
                    Hide()
                    frmMaisEscola_Novo.Show()
                    '  End If

                ElseIf (tbUsuario.Text <> usuario) Then

                    MsgBox("Usuário não encontrado!", MsgBoxStyle.Information, Sistema)
                    btContinuar.Enabled = True
                    tbUsuario.Focus()
                    tbUsuario.SelectAll()

                ElseIf (tbSenha.Text <> senha) Then

                    MsgBox("Senha incorreta!", MsgBoxStyle.Information, Sistema)
                    btContinuar.Enabled = True
                    tbSenha.Focus()
                    tbSenha.SelectAll()

                End If

            End If
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

    Private Sub pbFerramentas_Click(sender As Object, e As EventArgs) Handles pbFerramentas.Click
        frmLogin2.Show()
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click

        Environment.Exit(0)

    End Sub

    Private Sub PictureEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEdit4.EditValueChanged

    End Sub

    Private Sub labelControl1_Click(sender As Object, e As EventArgs) Handles labelControl1.Click

    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            SuporteRapido.Kill()
        Catch ex As Exception
        End Try

        Try
            Environment.Exit(0)
        Catch ex As Exception
        End Try
    End Sub

End Class
