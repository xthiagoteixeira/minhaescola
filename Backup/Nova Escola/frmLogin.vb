Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data

Public Class frmLogin
    Inherits System.Windows.Forms.Form

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
    Dim r As DataRow
    Dim rc As Integer
    Dim SQL As String
    Dim cdinteiro, pVal
    Dim xregistro = 0
    Dim trava = "0"
    Dim BD_OK, IP_OK, imagem_OK
    Dim user As String
    Private dv As DataView
    Private cm As CurrencyManager
    Dim info As New cpInfo.psInfo

    Public Shared fPrincipal As New frmPrincipal()
    Public Shared fRegistro As New frmRegistro()
    Public Shared fLogin2 As New frmLogin2()
    Friend WithEvents tbStatus As System.Windows.Forms.TextBox
    Friend WithEvents tbData As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lnConexao As System.Windows.Forms.LinkLabel
    Friend WithEvents tbAlerta1 As System.Windows.Forms.TextBox
    Public Shared fLogin As New frmLogin()
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
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbSenha As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbUsuario = New System.Windows.Forms.TextBox
        Me.tbSenha = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.tbStatus = New System.Windows.Forms.TextBox
        Me.tbData = New System.Windows.Forms.TextBox
        Me.lnConexao = New System.Windows.Forms.LinkLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tbAlerta1 = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(169, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(169, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(239, 43)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(136, 20)
        Me.tbUsuario.TabIndex = 2
        '
        'tbSenha
        '
        Me.tbSenha.Location = New System.Drawing.Point(239, 75)
        Me.tbSenha.Name = "tbSenha"
        Me.tbSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbSenha.Size = New System.Drawing.Size(136, 20)
        Me.tbSenha.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(173, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Continuar"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(277, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 21)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancelar"
        '
        'tbStatus
        '
        Me.tbStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbStatus.Font = New System.Drawing.Font("Pristina", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStatus.ForeColor = System.Drawing.Color.DodgerBlue
        Me.tbStatus.Location = New System.Drawing.Point(194, 2)
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(124, 46)
        Me.tbStatus.TabIndex = 7
        Me.tbStatus.Text = "Bom dia!"
        Me.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbData
        '
        Me.tbData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbData.ForeColor = System.Drawing.Color.RoyalBlue
        Me.tbData.Location = New System.Drawing.Point(166, 141)
        Me.tbData.Name = "tbData"
        Me.tbData.Size = New System.Drawing.Size(211, 14)
        Me.tbData.TabIndex = 8
        Me.tbData.Text = "00 de fevereiro de 2007"
        Me.tbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnConexao
        '
        Me.lnConexao.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnConexao.Location = New System.Drawing.Point(323, -1)
        Me.lnConexao.Name = "lnConexao"
        Me.lnConexao.Size = New System.Drawing.Size(85, 17)
        Me.lnConexao.TabIndex = 15
        Me.lnConexao.TabStop = True
        Me.lnConexao.Text = "Minha conexão!"
        Me.lnConexao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'tbAlerta1
        '
        Me.tbAlerta1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAlerta1.BackColor = System.Drawing.Color.PowderBlue
        Me.tbAlerta1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAlerta1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlerta1.ForeColor = System.Drawing.Color.OrangeRed
        Me.tbAlerta1.Location = New System.Drawing.Point(166, 127)
        Me.tbAlerta1.Name = "tbAlerta1"
        Me.tbAlerta1.Size = New System.Drawing.Size(211, 14)
        Me.tbAlerta1.TabIndex = 11
        Me.tbAlerta1.Text = "O sistema irá vencer em:"
        Me.tbAlerta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbAlerta1.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(410, 159)
        Me.Controls.Add(Me.lnConexao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbData)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbSenha)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAlerta1)
        Me.Controls.Add(Me.tbStatus)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova Escola - Login"
        Me.TransparencyKey = System.Drawing.Color.WhiteSmoke
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'envia usuario para o principal, assim, dando acesso somente ao permitido.
        Dim usuarioenvia As String
        usuarioenvia = tbUsuario.Text
        frmPrincipal.tTudo.Text = usuarioenvia
        myData.Clear()

        user = tbUsuario.Text
        user = user.Substring(0, 3)

        'AREA SUPORTE
        If (user = "adm") Then
            trava = "1"
            Dim conn As MySqlConnection
            conn = New MySqlConnection()
            conn.ConnectionString = "server=suporte.isolucao.com.br;user id=admsuporte;password=admauxcli;database=isolucao"

            SQL = "SELECT usuario,senha FROM isolucao.usuariodsk WHERE usuario='" & tbUsuario.Text & "'"

            Try
                conn.Open()
                Try
                    myCommand.Connection = conn
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)

                    Dim usuario, senha
                    Try
                        r = myData.Rows(0)

                        If r IsNot DBNull.Value Then

                            usuario = r("usuario")
                            senha = r("senha")

                            If (usuario = tbUsuario.Text) And (senha = tbSenha.Text) Then
                                tbAlerta1.Text = "Autenticado!"
                                trava = "1"
                                tbAlerta1.Visible = True
                                Hide()
                                fPrincipal.Show()
                            Else
                                'MsgBox("Usuário e senha inválido!", MsgBoxStyle.Critical)
                                tbAlerta1.Text = "Usuário e senha inválido!"
                                tbAlerta1.Visible = True

                            End If
                        End If
                    Catch ex As Exception
                        'MsgBox("Usuário e senha inválido!", MsgBoxStyle.Critical)
                        'tbAlerta1.Text = "Usuário e senha inválido!"
                        'tbAlerta1.Visible = True
                    End Try

                Catch myerro As MySqlException
                    MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                    Exit Sub
                    tbAlerta1.Text = "Erro de leitura!"
                    tbAlerta1.Visible = True

                End Try
                '           MessageBox.Show("Conexão aberta com sucesso")
                conn.Close()
            Catch myerro As MySqlException
                MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                Exit Sub
                tbAlerta1.Text = "Erro de conexão!"
                tbAlerta1.Visible = True

            Finally
                conn.Dispose()
            End Try
            trava = "1"
        End If



        If trava = "0" Then

            If tbUsuario.Text = "" And tbSenha.Text = "" Then

                MsgBox("É necessário digitar o usuário e senha para acessar o sistema!", MsgBoxStyle.Critical)
                tbAlerta1.Text = "Digite o usuário e a senha de acesso!"
                tbAlerta1.Visible = True
            Else

                tbAlerta1.Text = "Autenticando..."
                tbAlerta1.Visible = True

                'Inicio do registro das datas de: 
                ' X - Data do Ultimo Acesso ao Programa
                ' Y - Data Ultimo Registro do Programa
                ' Z - Data Do Proximo Registro do Programa
                ' W - Data Da Execucao Registro do Programa


                info.carry2()
                Dim tVal

                If (info.carry3() = 5) Then
                    tbAlerta1.Text = "Registro expirado"
                    tbAlerta1.Visible = True
                    MsgBox("O Registro expirou, deverá efetuar um novo registro.", MsgBoxStyle.Critical)
                    tVal = 5
                    fRegistro.Show()
                    Hide()
                    Exit Sub
                Else
                    tbAlerta1.Text = "Autenticando..."
                    tbAlerta1.Visible = True

                    '''''''''''''CARREGA INICIALMENTE''''''''''''
                    Dim conn As MySqlConnection
                    conn = New MySqlConnection()
                    conn.ConnectionString = "server=" & IP_OK & ";user id=admsuporte;password=admauxcli;database=" & BD_OK

                    SQL = "SELECT usuario, senha FROM " & BD_OK & ".usuariodsk WHERE usuario='" & tbUsuario.Text & "'"

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

                                'If r IsNot DBNull.Value Then

                                usuario = r("usuario")
                                senha = r("senha")

                                If (usuario = tbUsuario.Text) And (senha = tbSenha.Text) Then
                                    tbAlerta1.Text = "Autenticado!"
                                    tbAlerta1.Visible = True
                                    Hide()


                                    Dim MeuUsuario

                                    MeuUsuario = tbUsuario.Text

                                    frmPrincipal.tTudo.Text = MeuUsuario

                                    x = "1"
                                    frmPrincipal.Show()

                                Else
                                    tbAlerta1.Text = "Usuário e senha inválido!"
                                    tbAlerta1.Visible = True
                                End If
                                'End If


                            Catch ex As Exception
                                If x = "0" Then
                                    'MsgBox("Usuário e senha inválido!", MsgBoxStyle.Critical)
                                    tbAlerta1.Text = "Usuário e senha inválido!"
                                    tbAlerta1.Visible = True
                                End If

                            End Try

                        Catch myerro As MySqlException
                            MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                            Exit Sub
                            tbAlerta1.Text = "Erro de leitura!"
                            tbAlerta1.Visible = True

                        End Try
                        '           MessageBox.Show("Conexão aberta com sucesso")
                        conn.Close()
                    Catch myerro As MySqlException
                        MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
                        Exit Sub
                        tbAlerta1.Text = "Erro de conexão!"
                        tbAlerta1.Visible = True

                    Finally
                        conn.Dispose()
                    End Try

                End If
            End If
        End If

    End Sub



    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")
            Dim Imagem As Object = myRegKey2.GetValue("x")

            'If Imagem = "1" Then
            '    imgLocal.Visible = True
            '    imgInternet.Visible = False
            '    '  imgServidor.Visible = False
            'End If

            'If Imagem = "2" Then
            '    imgLocal.Visible = False
            '    imgInternet.Visible = False
            '    'imgServidor.Visible = True
            'End If

            'If Imagem = "3" Then
            '    imgLocal.Visible = False
            '    imgInternet.Visible = True
            '    '     imgServidor.Visible = False
            'End If

            BD_OK = BD
            IP_OK = IP
            imagem_OK = Imagem


        Catch ex As Exception
        End Try

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

        tbData.Text = data3

    End Sub

    Private Sub lnConexao_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnConexao.LinkClicked

        fLogin2 = New frmLogin2
        fLogin2.Show()

    End Sub

    Private Sub frmLogin_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")
            Dim Imagem As Object = myRegKey2.GetValue("x")

            'If Imagem = "1" Then
            '    imgLocal.Visible = True
            '    imgInternet.Visible = False
            '    ' imgServidor.Visible = False
            'End If

            'If Imagem = "2" Then
            '    imgLocal.Visible = False
            '    imgInternet.Visible = False
            '    '   imgServidor.Visible = True
            'End If

            'If Imagem = "3" Then
            '    imgLocal.Visible = False
            '    imgInternet.Visible = True
            '    '   imgServidor.Visible = False
            'End If

            BD_OK = BD
            IP_OK = IP
            imagem_OK = Imagem


        Catch ex As Exception
        End Try

    End Sub

    Private Sub tbData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbData.TextChanged

    End Sub

    Private Sub tbUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            tbSenha.Focus()
        End If

    End Sub

    Private Sub tbUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbUsuario.TextChanged

    End Sub

    Private Sub tbSenha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSenha.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Button1.Focus()
        End If
    End Sub

    Private Sub tbSenha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSenha.TextChanged

    End Sub
End Class
