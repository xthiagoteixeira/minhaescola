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

    ' Variaveis do sistema
    Dim erg As Long
    Dim cnpjKG As String
    Dim Numero(17)
    Dim tRegistryKey
    Dim mesKG
    Dim mes
    Dim nmes As String
    Dim KeyGen As String
    Dim cdtexto, cdtexto1, cdinteiro As String
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Dim pVal As String

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
    Friend WithEvents Csecreto As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.Csecreto = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lresponsavel
        '
        Me.Lresponsavel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lresponsavel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lresponsavel.Location = New System.Drawing.Point(-6, 133)
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
        Me.Lnempresa.Location = New System.Drawing.Point(-6, 120)
        Me.Lnempresa.Name = "Lnempresa"
        Me.Lnempresa.Size = New System.Drawing.Size(166, 23)
        Me.Lnempresa.TabIndex = 1
        Me.Lnempresa.Text = "Nome da Empresa:"
        Me.Lnempresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lcnpj
        '
        Me.Lcnpj.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lcnpj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcnpj.Location = New System.Drawing.Point(-5, 172)
        Me.Lcnpj.Name = "Lcnpj"
        Me.Lcnpj.Size = New System.Drawing.Size(165, 15)
        Me.Lcnpj.TabIndex = 2
        Me.Lcnpj.Text = "CNPJ:"
        Me.Lcnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cresponsavel
        '
        Me.Cresponsavel.Location = New System.Drawing.Point(162, 146)
        Me.Cresponsavel.MaxLength = 30
        Me.Cresponsavel.Name = "Cresponsavel"
        Me.Cresponsavel.Size = New System.Drawing.Size(232, 20)
        Me.Cresponsavel.TabIndex = 1
        '
        'Cempresa
        '
        Me.Cempresa.Location = New System.Drawing.Point(162, 122)
        Me.Cempresa.MaxLength = 30
        Me.Cempresa.Name = "Cempresa"
        Me.Cempresa.Size = New System.Drawing.Size(232, 20)
        Me.Cempresa.TabIndex = 0
        '
        'Ccnpj
        '
        Me.Ccnpj.Location = New System.Drawing.Point(162, 170)
        Me.Ccnpj.MaxLength = 18
        Me.Ccnpj.Name = "Ccnpj"
        Me.Ccnpj.Size = New System.Drawing.Size(232, 20)
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
        Me.Label4.Location = New System.Drawing.Point(150, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Versão Desktop"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bregistrar
        '
        Me.Bregistrar.Location = New System.Drawing.Point(40, 256)
        Me.Bregistrar.Name = "Bregistrar"
        Me.Bregistrar.Size = New System.Drawing.Size(75, 23)
        Me.Bregistrar.TabIndex = 6
        Me.Bregistrar.Text = "Registrar"
        '
        'Binternet
        '
        Me.Binternet.Location = New System.Drawing.Point(40, 256)
        Me.Binternet.Name = "Binternet"
        Me.Binternet.Size = New System.Drawing.Size(75, 23)
        Me.Binternet.TabIndex = 7
        Me.Binternet.Text = "Via Internet"
        '
        'Bsair
        '
        Me.Bsair.Location = New System.Drawing.Point(328, 256)
        Me.Bsair.Name = "Bsair"
        Me.Bsair.Size = New System.Drawing.Size(75, 24)
        Me.Bsair.TabIndex = 8
        Me.Bsair.Text = "Cancelar"
        '
        'Ccativacao
        '
        Me.Ccativacao.Location = New System.Drawing.Point(162, 194)
        Me.Ccativacao.Name = "Ccativacao"
        Me.Ccativacao.Size = New System.Drawing.Size(232, 20)
        Me.Ccativacao.TabIndex = 4
        '
        'Lcativacao
        '
        Me.Lcativacao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lcativacao.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcativacao.Location = New System.Drawing.Point(-5, 195)
        Me.Lcativacao.Name = "Lcativacao"
        Me.Lcativacao.Size = New System.Drawing.Size(165, 17)
        Me.Lcativacao.TabIndex = 13
        Me.Lcativacao.Text = "Licença:"
        Me.Lcativacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmes
        '
        Me.Cmes.Enabled = False
        Me.Cmes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.Cmes.Location = New System.Drawing.Point(280, 216)
        Me.Cmes.Name = "Cmes"
        Me.Cmes.Size = New System.Drawing.Size(112, 21)
        Me.Cmes.TabIndex = 19
        Me.Cmes.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mês de ativação:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Csecreto
        '
        Me.Csecreto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Csecreto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Csecreto.Location = New System.Drawing.Point(282, 2)
        Me.Csecreto.MaxLength = 28
        Me.Csecreto.Name = "Csecreto"
        Me.Csecreto.Size = New System.Drawing.Size(168, 13)
        Me.Csecreto.TabIndex = 21
        Me.Csecreto.Text = "0000000000000000000000000000"
        Me.Csecreto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(182, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Pristina", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 39)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nova Escola"
        '
        'frmRegistro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 290)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Csecreto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmes)
        Me.Controls.Add(Me.Ccativacao)
        Me.Controls.Add(Me.Lcativacao)
        Me.Controls.Add(Me.Bsair)
        Me.Controls.Add(Me.Bregistrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Ccnpj)
        Me.Controls.Add(Me.Cempresa)
        Me.Controls.Add(Me.Cresponsavel)
        Me.Controls.Add(Me.Lcnpj)
        Me.Controls.Add(Me.Lnempresa)
        Me.Controls.Add(Me.Lresponsavel)
        Me.Controls.Add(Me.Binternet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova Escola - Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub frmRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim try1

        info.carry1()

        Csecreto.Text = info.sc(try1)

        Cempresa.Text = info.cx1()
        Cresponsavel.Text = info.cx2()
        Cmes.Text = info.cx3()
        Ccnpj.Text = info.cx4()

        If Not Cempresa.Text = "" Then
            Cempresa.Enabled = False
        Else
            Cempresa.Enabled = True
        End If

        If Not Cresponsavel.Text = "" Then
            Cresponsavel.Enabled = False
        Else
            Cresponsavel.Enabled = True
        End If

        If Not Cmes.Text = "" Then
            Cmes.Enabled = False
        Else
            Cmes.Enabled = True
        End If

        If Not Ccnpj.Text = "" Then
            Ccnpj.Enabled = False
        Else
            Ccnpj.Enabled = True
        End If

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

            ''''''''''''''''''''''''''''''''''''''
            'Verifica se os campos estão preenchidos antes de registrar.
            '
            Dim d
            d = Cmes.Text
            d = info.IdMes(d)
            If Ccnpj.Text = "" Or Cempresa.Text = "" Or Cresponsavel.Text = "" Or Cmes.Text = "" Then
                MsgBox("Por favor, preencha os campos corretamente.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            '
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

        End If
        End
    End Sub

    Public Sub Bsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsair.Click
        Hide()

        'MsgBox("Teste: " & info.IdMes(Cmes.Text))

    End Sub


    Private Sub Cmes_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmes.SelectedIndexChanged

        nmes = Cmes.Text
        info.IdMes(nmes)


    End Sub

End Class
