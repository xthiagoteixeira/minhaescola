Imports System.Web
Imports Mais_Escola

Public Class frmFerOpcoes
    Dim menunovo, manualgdae, ferramenta3, transfEvasao

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        If txtUsuarioWeb.Text <> "" Or txtSenhaWeb.Text <> "" Then

            'Faz a checagem do usuário!
            Try

                Dim webservice1 As New MaisEscolaWeb.Service5
                Dim Operacao = 2001

                MsgBox(webservice1.WS5(txtUsuarioWeb.Text, txtSenhaWeb.Text, Operacao, 0, 0, 0), MsgBoxStyle.Information)

            Catch erro As Exception
                MessageBox.Show("Não foi possível conectar com o Servidor!" & vbCrLf & "" & erro.Message)
            End Try


        End If

        Dim cRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("MicroD.Vms")
        cRegistryKey = cRegistryKey.CreateSubKey("Classes")

        If cbManualGDAE.Checked = True Then
            manualgdae = 1
        Else
            manualgdae = 0
        End If

        If cbNaoCript.Checked = True Then
            ferramenta3 = 1
        Else
            ferramenta3 = 0
        End If

        If cbNotaTransf.Checked = True Then
            transfEvasao = 1
        Else
            transfEvasao = 0
        End If

        cRegistryKey.SetValue("ferramenta1", "" & menunovo)
        cRegistryKey.SetValue("ferramenta2", "" & manualgdae)
        cRegistryKey.SetValue("ferramenta3", "" & ferramenta3)
        cRegistryKey.SetValue("ferramenta4", "" & tbFundo.Text)
        cRegistryKey.SetValue("ferramenta5", "" & tbGdae.Text)
        cRegistryKey.SetValue("ferramentaNota", "" & transfEvasao)
        cRegistryKey.SetValue("ferramentaNota2", "" & tbNota.Text)

        cRegistryKey.SetValue("UsuarioWeb", "" & txtUsuarioWeb.Text)
        cRegistryKey.SetValue("SenhaWeb", "" & txtSenhaWeb.Text)

        MsgBox("É necessário reiniciar o programa para efetuar as alterações!", MsgBoxStyle.Information)
        Me.Close()

    End Sub

    Private Sub frmFerOpcoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("MicroD.Vms")
        myRegKey2 = myRegKey2.OpenSubKey("Classes")
        'Dim ferramenta1 As Object = myRegKey2.GetValue("ferramenta1")
        Dim ferramenta2 As Object = myRegKey2.GetValue("ferramenta2")
        Dim ferramenta3 As Object = myRegKey2.GetValue("ferramenta3")
        Dim ferramenta4 As Object = myRegKey2.GetValue("ferramenta4")
        Dim ferramenta5 As Object = myRegKey2.GetValue("ferramenta5")
        Dim ferramentaNota As Object = myRegKey2.GetValue("ferramentaNota")
        Dim ferramentaNota2 As Object = myRegKey2.GetValue("ferramentaNota2")

        Try
            Dim UsuarioWeb As Object = myRegKey2.GetValue("UsuarioWeb")
            Dim SenhaWeb As Object = myRegKey2.GetValue("SenhaWeb")

            txtUsuarioWeb.Text = UsuarioWeb
            txtSenhaWeb.Text = SenhaWeb

        Catch ex As Exception
        End Try

        Try
            If ferramenta2 = 1 Then
                cbManualGDAE.Checked = True
            Else
                cbManualGDAE.Checked = False
            End If
        Catch ex As Exception
            cbManualGDAE.Checked = False

        End Try


        If ferramenta3 = 1 Then
            cbNaoCript.Checked = True
        Else
            cbNaoCript.Checked = False
        End If

        Try
            tbFundo.Text = ferramenta4
        Catch ex As Exception
        End Try

        Try
            If ferramenta5 <> "" Then
                tbGdae.Text = ferramenta5
            Else
                tbGdae.Text = "https://gdaenet.edunet.sp.gov.br"
            End If
        Catch ex As Exception
        End Try

        Try
            If ferramentaNota <> "" Then

                If ferramentaNota = 0 Then
                    cbNotaTransf.Checked = False
                Else
                    cbNotaTransf.Checked = True
                End If

            Else
                cbNotaTransf.Checked = False
            End If
        Catch ex As Exception
        End Try

        Try
            If ferramentaNota2 <> "" Then
                tbNota.Text = ferramentaNota2
            Else
                tbNota.Text = 0
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub pbProcurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbProcurar.Click

        openFD.InitialDirectory = "C:\"
        openFD.Title = "Abrir arquivo"
        openFD.Filter = "Imagem JPG|*.jpg"
        openFD.ShowDialog()
        tbFundo.Text = openFD.FileName

    End Sub

    Private Sub tbNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNota.KeyPress
        If Not IsNumeric(tbNota.Text) Then
            MsgBox("Somente números!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBoxX2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSenhaWeb.TextChanged

    End Sub
End Class