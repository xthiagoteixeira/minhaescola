Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmLogin

    Inherits System.Windows.Forms.Form

    Dim info = New cpInfo.psInfo

    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lnConexao As System.Windows.Forms.LinkLabel
    Friend WithEvents tbStatus As System.Windows.Forms.Label
    Friend WithEvents btContinuar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbSenha As DevComponents.DotNetBar.Controls.TextBoxX

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lnConexao = New System.Windows.Forms.LinkLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tbStatus = New System.Windows.Forms.Label
        Me.btContinuar = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.tbUsuario = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.tbSenha = New DevComponents.DotNetBar.Controls.TextBoxX
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(164, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(173, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnConexao
        '
        Me.lnConexao.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnConexao.Location = New System.Drawing.Point(301, -1)
        Me.lnConexao.Name = "lnConexao"
        Me.lnConexao.Size = New System.Drawing.Size(85, 17)
        Me.lnConexao.TabIndex = 15
        Me.lnConexao.TabStop = True
        Me.lnConexao.Text = "Minha conexão!"
        Me.lnConexao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'tbStatus
        '
        Me.tbStatus.Font = New System.Drawing.Font("Pristina", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStatus.ForeColor = System.Drawing.Color.Blue
        Me.tbStatus.Location = New System.Drawing.Point(161, 14)
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(200, 31)
        Me.tbStatus.TabIndex = 16
        Me.tbStatus.Text = "Bom dia!"
        Me.tbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btContinuar
        '
        Me.btContinuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btContinuar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btContinuar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btContinuar.Location = New System.Drawing.Point(168, 113)
        Me.btContinuar.Name = "btContinuar"
        Me.btContinuar.Size = New System.Drawing.Size(75, 23)
        Me.btContinuar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btContinuar.TabIndex = 2
        Me.btContinuar.Text = "Continuar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(277, 113)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ButtonX2.TabIndex = 3
        Me.ButtonX2.Text = "Sair"
        '
        'tbUsuario
        '
        '
        '
        '
        Me.tbUsuario.Border.Class = "TextBoxBorder"
        Me.tbUsuario.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(235, 54)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(120, 21)
        Me.tbUsuario.TabIndex = 0
        '
        'tbSenha
        '
        '
        '
        '
        Me.tbSenha.Border.Class = "TextBoxBorder"
        Me.tbSenha.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSenha.Location = New System.Drawing.Point(235, 82)
        Me.tbSenha.Name = "tbSenha"
        Me.tbSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbSenha.Size = New System.Drawing.Size(120, 21)
        Me.tbSenha.TabIndex = 1
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(389, 148)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbSenha)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.btContinuar)
        Me.Controls.Add(Me.lnConexao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Escola - Entrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ####################### CARREGA PREFERENCIA DE USUARIOS... ########################
        AnoVigente = Format(Date.Now, "yyyy")

        tbUsuario.Focus()
        ' DATA
        Dim SacarData As DateTime = DateTime.Now
        Dim data
        data = Format(SacarData, "HH:mm:ss")
        ' FIM DATA

        ' DATA
        Dim SacarData3 As DateTime = DateTime.Now
        Dim data3
        data3 = FormatDateTime(SacarData3, DateFormat.LongDate)
        ' FIM DATA

        If data > "00:00:00" And data < "11:59:59" Then
            tbStatus.Text = "Bom dia!"
        ElseIf data > "12:00:00" And data < "17:59:59" Then
            tbStatus.Text = "Boa tarde!"
        ElseIf (data > "18:00:00") And (data < "23:59:59") Then
            tbStatus.Text = "Boa noite!"
        End If

        'tbAlerta1.Text = data3

    End Sub

    Private Sub lnConexao_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnConexao.LinkClicked

        frmLogin2.Show()

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btContinuar.Click

        Try

            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")
            BD_OK = BD
            IP_OK = IP
            CONEXAOBD = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

        Catch ex As Exception
        End Try

        'If trava = "0" Then

        If tbUsuario.Text = "" And tbSenha.Text = "" Then

            MsgBox("É necessário digitar o usuário e senha para acessar o sistema!", MsgBoxStyle.Critical)
            MsgBox("Digite o usuário e a senha de acesso!", MsgBoxStyle.Critical, "Mais Escola - Entrar")
            'tbAlerta1.Visible = True
        Else

            'envia usuario para o principal, assim, dando acesso somente ao permitido.
            UsuarioSistema = tbUsuario.Text

            'Inicio do registro das datas de: 
            ' X - Data do Ultimo Acesso ao Programa
            ' Y - Data Ultimo Registro do Programa
            ' Z - Data Do Proximo Registro do Programa
            ' W - Data Da Execucao Registro do Programa

            Dim teste = 0

            Try
                info.carry2()
                teste = info.carry3(0)
            Catch ex As Exception
            End Try

            Dim tVal
            If (teste = 5) Then
                MsgBox("O Registro expirou, deverá efetuar um novo registro.", MsgBoxStyle.Critical)
                tVal = 5
                Me.Hide()
                frmRegistro.Show()
                Exit Sub
            Else

                '''''''''''''CARREGA INICIALMENTE''''''''''''
                Dim conn As MySqlConnection
                conn = New MySqlConnection()
                conn.ConnectionString = CONEXAOBD
                SQL = "SELECT usuario, senha FROM usuariodsk WHERE usuario='" & tbUsuario.Text & "'"

                Try
                    conn.Open()
                    Try

                        myCommand.Connection = conn
                        myCommand.CommandText = SQL
                        myAdapter.SelectCommand = myCommand
                        myAdapter.Fill(myData)

                        Dim usuario, senha
                        Dim x = "0"

                        Try
                            r = myData.Rows(0)
                            usuario = r("usuario")
                            senha = r("senha")

                            If (usuario = tbUsuario.Text) And (senha = tbSenha.Text) Then

                                UsuarioSistema = tbUsuario.Text
                                x = "1"
                                Me.Hide()
                                frmPrincipal.Show()

                            Else
                                MsgBox("Usuário e senha inválido!", MsgBoxStyle.Critical, "Mais Escola - Entrar")
                                'tbAlerta1.Visible = True
                                tbSenha.Focus()
                            End If
                            'End If

                        Catch ex As Exception
                            If x = "0" Then
                                'MsgBox("Usuário e senha inválido!", MsgBoxStyle.Critical)
                                MsgBox("Usuário e senha inválido!", MsgBoxStyle.Critical, "Mais Escola - Entrar")
                                'tbAlerta1.Visible = True
                                tbSenha.Focus()
                            End If
                        End Try

                    Catch myerro As MySqlException
                        Exit Sub
                    End Try
                    'MessageBox.Show("Conexão aberta com sucesso")
                    conn.Close()
                Catch myerro As MySqlException
                    MsgBox("Foi encontrado um problema em sua rede local!", MsgBoxStyle.Critical, "Mais Escola!")
                    MsgBox("Não foi possível conectar com o Banco de dados, uma das possíveis causas são:" & vbCrLf & "1 - Serviços / Firewall do Windows está ativado no Servidor;" & vbCrLf & "2 - Banco de dados / IP não definido em 'Minhas Conexões' na tela de login;" & vbCrLf & "3 - Servidor encontra-se desligado.", MsgBoxStyle.Information)
                    conn.Close()
                    conn.Dispose()
                    Exit Sub
                Finally
                    conn.Dispose()
                End Try
            End If
        End If
        ' End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        End
    End Sub

    Private Sub tbSenha_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSenha.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btContinuar.Focus()
        End If
    End Sub

    Private Sub tbUsuario_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tbSenha.Focus()
        End If
    End Sub
End Class
