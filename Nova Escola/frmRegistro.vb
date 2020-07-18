Imports System.IO
Imports System.Net
Imports System.Windows.Forms
Imports DevExpress.DocumentServices.ServiceModel

Public Class frmRegistro

    Dim cnpj As New valida_CNPJ_CPF

    Private Sub btConfirmar_Click(sender As Object, e As EventArgs) Handles btConfirmar.Click

        ' Salva em empresa (banco de dados)
        ''
        'If MeuCore.MaquinaAutorizada("MaisEscola") = "Não autorizado!" Then

        '    MsgBox("Entrar em contato com o suporte!", MsgBoxStyle.Information, "Mais Escola!")

        'Else

        MaquinaRegistrar("MaisEscola", txtNome.Text, txtCNPJ.Text, txtResponsavel.Text)

        'Salvar no (empresa) e na (escola)
        '
        SQL = "UPDATE `empresa`
                        SET
                        `Nome` = '" & txtNome.Text & "',
                        `CNPJ` = '" & txtCNPJ.Text & "',
                        `Responsavel` = '" & txtResponsavel.Text & "',
                        `Modulo` = 'Mais Escola'
                        WHERE `idEmpresa` = '1';"
            Dim retorno = MySQL_atualiza(SQL)
            If retorno = 0 Then

                SQL = "INSERT INTO `empresa`
                        (idEmpresa, `Nome`,
                        `CNPJ`,
                        `Responsavel`,
                        `Modulo`)
                        VALUES
                        ('1', '" & txtNome.Text & "',
                        '" & txtCNPJ.Text & "',
                        '" & txtResponsavel.Text & "',
                        'Mais Escola');"

            End If

            End
        '
        ' ********************************
        ' End If

    End Sub

    Private Sub frmConfirmarDados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Environment.Exit(0)

    End Sub

    Private Sub frmConfirmarDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Tenta carregar!
        Try
            cnpj.cnpj = txtCNPJ.Text
            SQL = "SELECT * FROM empresa;"
            If cnpj.isCnpjValido() Then
                txtCNPJ.Text = MySQL_consulta_campo(SQL, "CNPJ")
                txtNome.Text = MySQL_consulta_campo(SQL, "Nome")
                txtResponsavel.Text = MySQL_consulta_campo(SQL, "Responsavel")
            End If
        Catch ex As Exception
        End Try

        Dim Url = "http://matrix.thiagoteixeira.me/maisescola/MaisEscola_LUS.pdf"

        Dim stream As MemoryStream
        Dim wc As WebClient = New WebClient()
        Dim data = wc.DownloadData(Url)
        stream = New MemoryStream(data)
        pdfViewer.LoadDocument(stream)

    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            txtCNPJ.Focus()
        End If
    End Sub

    Private Sub txtCNPJ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCNPJ.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            txtResponsavel.Focus()
        End If
    End Sub

    Private Sub txtResponsavel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResponsavel.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btConfirmar.Focus()
        End If
    End Sub

    Private Sub txtCNPJ_LostFocus(sender As Object, e As EventArgs) Handles txtCNPJ.LostFocus

        cnpj.cnpj = txtCNPJ.Text

        If Not cnpj.isCnpjValido() Then
            txtCNPJ.BackColor = Color.LightSalmon
            btConfirmar.Enabled = False
        Else
            txtCNPJ.BackColor = Color.LightGreen
            btConfirmar.Enabled = True
        End If
    End Sub
End Class