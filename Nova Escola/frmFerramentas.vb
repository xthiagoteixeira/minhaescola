Imports DevExpress.XtraEditors.Controls
Imports Mais_Escola.WS_MaisEscola_Web
Imports System.Reflection

Public Class frmFerramentas

    Dim ImagemAtual = 1
    Dim IdentificaEscolha As String

    Private Sub SetImageIndex(imageIndex As Integer)
        Try
            Dim pi As PropertyInfo = imagemFundo.GetType().GetProperty("CurrentImageIndex", BindingFlags.Instance Or BindingFlags.NonPublic)
            pi.SetValue(imagemFundo, imageIndex, Nothing)
            pi = imagemFundo.GetType().GetProperty("CurrentImage", BindingFlags.Instance Or BindingFlags.Public)
            pi.SetValue(imagemFundo, imagemFundo.Images(imageIndex), Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmFerOpcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmFerOpcoes"
        '... BOLETIM WEB ...
        Const Sql = "SELECT * FROM preferencias WHERE idPreferencias='1';"
        txtUsuarioWeb.Text = MySQL_consulta_campo(Sql, "ferramenta3").ToString
        txtSenhaWeb.Text = MySQL_consulta_campo(Sql, "ferramenta4").ToString
        Dim Retorno = MySQL_consulta_campo(Sql, "ferramenta5").ToString
        If Retorno = "0" Then
            cbEscola.Text = "Nenhuma"
        Else
            cbEscola.Text = Retorno
        End If
    End Sub

    Private Sub btEfetuar_Click(sender As Object, e As EventArgs) Handles btEfetuar.Click

        If IdentificaEscolha > 12 Then
            WritePrivateProfileString("Ferramentas", "Fundo", MaisEscolaINI_Fundo, nome_arquivo_ini)
        Else
            IdentificaEscolha = CInt(cbFundo.Text.Replace("Fundo ", String.Empty))
            WritePrivateProfileString("Ferramentas", "Fundo", IdentificaEscolha, nome_arquivo_ini)
        End If

        ' SALVAR OS DADOS DO ALUNO...
        Try
            ' Salva e ATUALIZA O TIPO DE ESCOLA...
            Dim SQL2 = String.Format("UPDATE preferencias SET ferramenta5='{0}' WHERE idPreferencias='1';",
                                     cbEscola.Text)
            MySQL_atualiza(SQL2)
            Escola_Sistema = cbEscola.Text

            If txtUsuarioWeb.Text <> "0" Or txtSenhaWeb.Text <> "0" Then
                ' MeuCore_Atualiza.AtivaBoletimWeb(txtUsuarioWeb.Text, txtSenhaWeb.Text, "MaisEscola")
                Dim SQL =
                        String.Format(
                            "UPDATE preferencias SET ferramenta3='{0}', ferramenta4='{1}' WHERE idPreferencias='1';",
                            txtUsuarioWeb.EditValue, txtSenhaWeb.EditValue)
                MySQL_atualiza(SQL)
                Carrega_Fundo()

            End If
        Catch ex As Exception
            MsgBox("Sem acesso a internet!", MsgBoxStyle.Information, "Sem conexão")
        End Try
    End Sub

    Private Sub imagemFundo_CurrentImageIndexChanged(sender As Object, e As ImageSliderCurrentImageIndexChangedEventArgs) _
        Handles imagemFundo.CurrentImageIndexChanged

        ImagemAtual = e.CurrentIndex + 1
        If ImagemAtual <> 0 Then
            cbFundo.Text = "Fundo " & ImagemAtual
        End If
    End Sub

    Private Sub cbFundo_Closed(sender As Object, e As ClosedEventArgs) Handles cbFundo.Closed
        IdentificaEscolha = CInt(cbFundo.Text.Replace("Fundo ", String.Empty))
        SetImageIndex(IdentificaEscolha - 1)
    End Sub

    Private Sub cbFundo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbFundo.SelectedValueChanged

        If cbFundo.Text = "Personalizar..." Then

            Try
                openFD.InitialDirectory = openFD.FileName
            Catch ex As Exception
                openFD.InitialDirectory = "C:\"
            End Try

            Try
                openFD.Title = "Abrir arquivo"
                openFD.Filter = "Papel de Parede (*.jpg)|*.jpg|Papel de Parede (*.gif)|*.gif"
                openFD.FilterIndex = 1
                openFD.ShowDialog()
                MaisEscolaINI_Fundo = openFD.FileName

                SetImageIndex(13)
                imagemFundo.Images.Add(Image.FromFile(MaisEscolaINI_Fundo))

            Catch ex As Exception
                MsgBox("Nenhum plano de fundo escolhido!", MsgBoxStyle.Information, "Plano de Fundo")

            End Try

        Else
            IdentificaEscolha = CInt(cbFundo.Text.Replace("Fundo ", String.Empty))
            'SetImageIndex(IdentificaEscolha - 1)

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)


    End Sub
End Class