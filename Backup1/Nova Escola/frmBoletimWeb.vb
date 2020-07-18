Imports System.Web
Imports Mais_Escola

Public Class frmBoletimWeb
    Dim menunovo, manualgdae, ferramenta3, transfEvasao
    Dim UsuarioWeb As String
    Dim SenhaWeb As String
    Dim webservice1 As New MaisEscolaAdm.Service4
    Dim webservice2 As New MaisEscolaWeb.Service5

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Dim Operacao As String
        Dim MeuUsuario As String

        Try

            If rbIncluir.Checked = True Then
                Operacao = 3001
                MeuUsuario = txtUsuarioProfessor.Text

            ElseIf rbAlterar.Checked = True Then
                Operacao = 3322
                MeuUsuario = cbUsuarioProfessor.Text

            ElseIf rbBloquear.Checked = True Then
                Operacao = 3023
                MeuUsuario = cbUsuarioProfessor.Text

            ElseIf rbDesbloquear.Checked = True Then
                Operacao = 3024
                MeuUsuario = cbUsuarioProfessor.Text

            Else
                MsgBox("Favor, escolher uma operação!", MsgBoxStyle.Critical)
                Exit Sub

            End If

            MsgBox(webservice1.WS4(MeuUsuario, txtSenha.Text, UsuarioWeb, SenhaWeb, Operacao), MsgBoxStyle.Information)

        Catch erro As Exception
            MessageBox.Show("Não foi possível conectar com o Servidor!" & vbCrLf & "" & erro.Message)
        End Try
    End Sub

    Private Sub frmFerOpcoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("MicroD.Vms")
        myRegKey2 = myRegKey2.OpenSubKey("Classes")

        Try
            UsuarioWeb = myRegKey2.GetValue("UsuarioWeb")
            SenhaWeb = myRegKey2.GetValue("SenhaWeb")

            txtUsuarioEscola.Text = UsuarioWeb
            txtUsuarioEscola.Enabled = False

            If UsuarioWeb = Nothing Or SenhaWeb = Nothing Then
                MsgBox("Para continuar é necessário colocar o usuário/senha do Boletim Web em Administrativo/Ferramentas!", MsgBoxStyle.Critical)
                Me.Close()

            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub rbAlterar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAlterar.CheckedChanged
        If rbAlterar.Checked = True Then
            cbUsuarioProfessor.Visible = True
            txtUsuarioProfessor.Visible = False

            cbUsuarioProfessor.Items.Clear()
            Dim ListaUsuario As String = webservice2.WS5(UsuarioWeb, SenhaWeb, 3122, 0, 0, 0)
            Dim strArray As String()
            strArray = ListaUsuario.Split(";")
            For i As Integer = 0 To strArray.Length - 1 Step 1
                cbUsuarioProfessor.Items.Add(strArray(i))
            Next

        Else
            cbUsuarioProfessor.Visible = False
            txtUsuarioProfessor.Visible = True
        End If

    End Sub

    Private Sub rbBloquear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBloquear.CheckedChanged
        If rbBloquear.Checked = True Then
            cbUsuarioProfessor.Visible = True
            txtUsuarioProfessor.Visible = False

            cbUsuarioProfessor.Items.Clear()
            Dim ListaUsuario As String = webservice2.WS5(UsuarioWeb, SenhaWeb, 3122, 0, 0, 0)
            Dim strArray As String()
            strArray = ListaUsuario.Split(";")
            For i As Integer = 0 To strArray.Length - 1 Step 1
                cbUsuarioProfessor.Items.Add(strArray(i))
            Next

        Else
            cbUsuarioProfessor.Visible = False
            txtUsuarioProfessor.Visible = True
        End If
    End Sub

    Private Sub rbDesbloquear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDesbloquear.CheckedChanged
        If rbDesbloquear.Checked = True Then
            cbUsuarioProfessor.Visible = True
            txtUsuarioProfessor.Visible = False

            cbUsuarioProfessor.Items.Clear()
            Dim ListaUsuario As String = webservice2.WS5(UsuarioWeb, SenhaWeb, 3122, 0, 0, 0)
            Dim strArray As String()
            strArray = ListaUsuario.Split(";")
            For i As Integer = 0 To strArray.Length - 1 Step 1
                cbUsuarioProfessor.Items.Add(strArray(i))
            Next

        Else
            cbUsuarioProfessor.Visible = False
            txtUsuarioProfessor.Visible = True
        End If
    End Sub
End Class