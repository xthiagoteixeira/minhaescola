Imports MySql.Data.MySqlClient
Public Class frmRegistro

    Inherits System.Windows.Forms.Form
    Declare Function GetVolumeInformation Lib _
    "kernel32" Alias "GetVolumeInformationA" _
    (ByVal lpRootPathName As String, _
    ByVal lpVolumeNameBuffer As String, _
    ByVal nVolumeNameSize As Long, _
    ByVal lpVolumeSerialNumber As Long, _
    ByVal lpMaximumComponentLength As Long, _
    ByVal lpFileSystemFlags As Long, _
    ByVal lpFileSystemNameBuffer As String, _
    ByVal nFileSystemNameSize As Long) As Long

    Dim info As New cpInfo.psInfo

    Friend myCommand As New MySqlCommand()
    Friend myAdapter As New MySqlDataAdapter()
    Friend myData As New DataTable()
    Friend r As DataRow
    Friend rc As Integer
    Friend SQL As String

    ' Variaveis do sistema
    Dim autorizar As Integer = 0
    Dim mes
    Dim nmes As String
    Dim try1, x

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Csecreto As System.Windows.Forms.Label
    Friend WithEvents btSolicitar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

    Declare Function GetDriveType Lib "kernel32" Alias "GetDriveTypeA" (ByVal nDrive As String) As Long

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
    Friend WithEvents Lresponsavel As System.Windows.Forms.Label
    Friend WithEvents Lnempresa As System.Windows.Forms.Label
    Friend WithEvents Lcnpj As System.Windows.Forms.Label
    Friend WithEvents Cresponsavel As System.Windows.Forms.TextBox
    Friend WithEvents Cempresa As System.Windows.Forms.TextBox
    Friend WithEvents Ccnpj As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Bregistrar As System.Windows.Forms.Button
    Friend WithEvents Binternet As System.Windows.Forms.Button
    Friend WithEvents Bsair As System.Windows.Forms.Button
    Friend WithEvents Ccativacao As System.Windows.Forms.TextBox
    Friend WithEvents Lcativacao As System.Windows.Forms.Label
    Friend WithEvents Cmes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.Lresponsavel = New System.Windows.Forms.Label
        Me.Lnempresa = New System.Windows.Forms.Label
        Me.Lcnpj = New System.Windows.Forms.Label
        Me.Cresponsavel = New System.Windows.Forms.TextBox
        Me.Cempresa = New System.Windows.Forms.TextBox
        Me.Ccnpj = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Bregistrar = New System.Windows.Forms.Button
        Me.Binternet = New System.Windows.Forms.Button
        Me.Bsair = New System.Windows.Forms.Button
        Me.Ccativacao = New System.Windows.Forms.TextBox
        Me.Lcativacao = New System.Windows.Forms.Label
        Me.Cmes = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Csecreto = New System.Windows.Forms.Label
        Me.btSolicitar = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lresponsavel
        '
        Me.Lresponsavel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lresponsavel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lresponsavel.Location = New System.Drawing.Point(6, 138)
        Me.Lresponsavel.Name = "Lresponsavel"
        Me.Lresponsavel.Size = New System.Drawing.Size(166, 47)
        Me.Lresponsavel.TabIndex = 0
        Me.Lresponsavel.Text = "Responsável:"
        Me.Lresponsavel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lnempresa
        '
        Me.Lnempresa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lnempresa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnempresa.Location = New System.Drawing.Point(6, 125)
        Me.Lnempresa.Name = "Lnempresa"
        Me.Lnempresa.Size = New System.Drawing.Size(166, 23)
        Me.Lnempresa.TabIndex = 1
        Me.Lnempresa.Text = "Nome:"
        Me.Lnempresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lcnpj
        '
        Me.Lcnpj.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lcnpj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcnpj.Location = New System.Drawing.Point(7, 177)
        Me.Lcnpj.Name = "Lcnpj"
        Me.Lcnpj.Size = New System.Drawing.Size(165, 15)
        Me.Lcnpj.TabIndex = 2
        Me.Lcnpj.Text = "CNPJ:"
        Me.Lcnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cresponsavel
        '
        Me.Cresponsavel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cresponsavel.Location = New System.Drawing.Point(174, 151)
        Me.Cresponsavel.MaxLength = 30
        Me.Cresponsavel.Name = "Cresponsavel"
        Me.Cresponsavel.Size = New System.Drawing.Size(230, 21)
        Me.Cresponsavel.TabIndex = 1
        '
        'Cempresa
        '
        Me.Cempresa.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cempresa.Location = New System.Drawing.Point(174, 127)
        Me.Cempresa.MaxLength = 30
        Me.Cempresa.Name = "Cempresa"
        Me.Cempresa.Size = New System.Drawing.Size(230, 21)
        Me.Cempresa.TabIndex = 0
        '
        'Ccnpj
        '
        Me.Ccnpj.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ccnpj.Location = New System.Drawing.Point(174, 175)
        Me.Ccnpj.MaxLength = 18
        Me.Ccnpj.Name = "Ccnpj"
        Me.Ccnpj.Size = New System.Drawing.Size(230, 21)
        Me.Ccnpj.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Papyrus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(201, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Versão Desktop"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bregistrar
        '
        Me.Bregistrar.Enabled = False
        Me.Bregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bregistrar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bregistrar.Location = New System.Drawing.Point(45, 256)
        Me.Bregistrar.Name = "Bregistrar"
        Me.Bregistrar.Size = New System.Drawing.Size(75, 23)
        Me.Bregistrar.TabIndex = 5
        Me.Bregistrar.Text = "Registrar"
        '
        'Binternet
        '
        Me.Binternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Binternet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Binternet.Location = New System.Drawing.Point(45, 256)
        Me.Binternet.Name = "Binternet"
        Me.Binternet.Size = New System.Drawing.Size(75, 23)
        Me.Binternet.TabIndex = 7
        Me.Binternet.Text = "Via Internet"
        '
        'Bsair
        '
        Me.Bsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsair.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsair.Location = New System.Drawing.Point(333, 256)
        Me.Bsair.Name = "Bsair"
        Me.Bsair.Size = New System.Drawing.Size(75, 23)
        Me.Bsair.TabIndex = 7
        Me.Bsair.Text = "Cancelar"
        '
        'Ccativacao
        '
        Me.Ccativacao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ccativacao.Location = New System.Drawing.Point(174, 199)
        Me.Ccativacao.Name = "Ccativacao"
        Me.Ccativacao.Size = New System.Drawing.Size(230, 21)
        Me.Ccativacao.TabIndex = 3
        '
        'Lcativacao
        '
        Me.Lcativacao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lcativacao.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcativacao.Location = New System.Drawing.Point(7, 201)
        Me.Lcativacao.Name = "Lcativacao"
        Me.Lcativacao.Size = New System.Drawing.Size(165, 17)
        Me.Lcativacao.TabIndex = 13
        Me.Lcativacao.Text = "Licença:"
        Me.Lcativacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmes
        '
        Me.Cmes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.Cmes.Location = New System.Drawing.Point(292, 224)
        Me.Cmes.Name = "Cmes"
        Me.Cmes.Size = New System.Drawing.Size(112, 21)
        Me.Cmes.TabIndex = 4
        Me.Cmes.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mês de ativação:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Pristina", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(199, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 46)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Mais Escola"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Csecreto
        '
        Me.Csecreto.AutoSize = True
        Me.Csecreto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Csecreto.ForeColor = System.Drawing.Color.Blue
        Me.Csecreto.Location = New System.Drawing.Point(248, 3)
        Me.Csecreto.Name = "Csecreto"
        Me.Csecreto.Size = New System.Drawing.Size(203, 13)
        Me.Csecreto.TabIndex = 25
        Me.Csecreto.Text = "0000000000000000000000000000"
        '
        'btSolicitar
        '
        Me.btSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSolicitar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSolicitar.Location = New System.Drawing.Point(156, 256)
        Me.btSolicitar.Name = "btSolicitar"
        Me.btSolicitar.Size = New System.Drawing.Size(139, 23)
        Me.btSolicitar.TabIndex = 6
        Me.btSolicitar.Text = "Solicitar Autorização!"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'frmRegistro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 290)
        Me.Controls.Add(Me.btSolicitar)
        Me.Controls.Add(Me.Csecreto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Bsair)
        Me.Controls.Add(Me.Bregistrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Binternet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmes)
        Me.Controls.Add(Me.Ccativacao)
        Me.Controls.Add(Me.Lcativacao)
        Me.Controls.Add(Me.Ccnpj)
        Me.Controls.Add(Me.Cempresa)
        Me.Controls.Add(Me.Cresponsavel)
        Me.Controls.Add(Me.Lcnpj)
        Me.Controls.Add(Me.Lnempresa)
        Me.Controls.Add(Me.Lresponsavel)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Escola - Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub frmRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        info.carry1(x)

        Csecreto.Text = info.sc(try1)

    End Sub

    ' FORMATA CNPJ PARA APARECER LEGAL NO CAMPO
    Private Sub Ccnpj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ccnpj.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If IsNumeric(e.KeyChar) AndAlso Ccnpj.TextLength < Ccnpj.MaxLength Then
            Ccnpj.Text &= e.KeyChar
            Ccnpj.SelectionStart = Ccnpj.TextLength
            Call formatacnpj(Ccnpj)
        End If
        e.Handled = True

    End Sub

    Private Sub formatacnpj(ByVal txtTexto As Object)

        If Len(txtTexto.Text) = 2 Or Len(txtTexto.Text) = 6 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
        If Len(txtTexto.Text) = 10 Then
            txtTexto.Text = txtTexto.Text & "/"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
        If Len(txtTexto.Text) = 15 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub


    Public Sub Bregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bregistrar.Click

        If (Cempresa.Text = "") Or (Cresponsavel.Text = "") Or (Ccnpj.Text = "") Or (Cmes.Text = "") Or (Ccativacao.Text = "") Then

            MsgBox("Para efetuar o registro, é necessário preencher todos os campos corretamente.", MsgBoxStyle.Critical)

        Else

            Dim d
            d = Cmes.Text
            d = info.IdMes(d)

            ' Efetua o registro...
            '''''''''''''''''''''''''''''''''''''''
            '
            Dim z As String
            Dim x As String
            Dim c As String
            Dim w As String
            Dim o As String
            Dim r As String

            z = Csecreto.Text
            x = Cmes.Text
            c = Ccnpj.Text
            w = Cempresa.Text
            o = Cresponsavel.Text
            r = Ccativacao.Text

            info.rcarry1(z, x, c, w, o, r)

            End

        End If

    End Sub

    Public Sub Bsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsair.Click
        End

    End Sub


    Private Sub Cmes_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmes.SelectedIndexChanged

        nmes = Cmes.Text
        info.IdMes(nmes)


    End Sub

    Private Sub btSolicitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSolicitar.Click

        If autorizar = 0 Then

            ' CHECA SE OS DADOS ESTAO CORRETOS
            '
            If (Cempresa.Text = "") Or (Cresponsavel.Text = "") Or (Ccnpj.Text = "") Or (Cmes.Text = "") Then

                'if TESTAR CNPJ, VALIDO OU NAO

                MsgBox("Favor preencher todos os campos", MsgBoxStyle.Critical)
                Exit Sub

            End If

            'ENVIA OS DADOS PARA O REGISTRO - SERVICO2 (WEBSERVICE)
            '
            btSolicitar.Enabled = False

            Dim nome, responsavel, cnpj, maquina, mes, data
            Dim bd As String = "maisescola"

            nome = Cempresa.Text
            responsavel = Cresponsavel.Text
            cnpj = Ccnpj.Text
            maquina = Csecreto.Text
            mes = Cmes.Text
            data = Format(Date.Now, "yyyy-MM-dd")

            Try
                Dim webservice2 As New MaisEscola2.Service2
                MsgBox("" + webservice2.WS2(bd, nome, responsavel, cnpj, maquina, mes, data), MsgBoxStyle.Information)
                autorizar = 1
            Catch erro As Exception
                Bregistrar.Enabled = True
                MessageBox.Show("Não foi possível conectar com o Servidor!" & vbCrLf & "" & erro.Message)
            End Try

            'se deu certo... ele ativa o relogio para dar tempo de autorizar pelo suporte.

            Timer1.Enabled = True
            Timer1.Start()
            btSolicitar.Text = "Receber licença!"
        ElseIf autorizar = 1 Then

            Dim cnpj, maquina As String
            Dim bd As String = "maisescola"

            cnpj = Ccnpj.Text
            maquina = Csecreto.Text
            Try

                Dim webservice1 As New MaisEscola1.Service1
                Dim VerificaAtivacao


                VerificaAtivacao = "" & webservice1.WS1(maquina, cnpj, bd)

                If VerificaAtivacao <> "0" Then

                    Dim d
                    d = Cmes.Text
                    d = info.IdMes(d)
                    Ccativacao.Text = VerificaAtivacao

                    ' Efetua o registro...
                    '''''''''''''''''''''''''''''''''''''''
                    '
                    Dim z As String
                    Dim x As String
                    Dim c As String
                    Dim w As String
                    Dim o As String
                    Dim r As String

                    z = Csecreto.Text
                    x = Cmes.Text
                    c = Ccnpj.Text
                    w = Cempresa.Text
                    o = Cresponsavel.Text
                    r = Ccativacao.Text

                    info.rcarry1(z, x, c, w, o, r)
                    End

                Else
                    MsgBox("Para liberar o programa, entre em contato com a revenda!", MsgBoxStyle.Information, "Mais Escola")

                End If

            Catch erro As Exception
                Bregistrar.Enabled = True
                MessageBox.Show("Não foi possível conectar com o Servidor!" & vbCrLf & "" & erro.Message)
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        btSolicitar.Enabled = True
        Bregistrar.Enabled = True
        Timer1.Stop()

    End Sub
End Class
