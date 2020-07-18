Imports System.Net

Public Class frmErro
    Dim erromsg

    Private Sub frmConturma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Carrega o formulário...
        erromsg = String.Format("{0} - Mensagem: {1}", Erro_Form, Erro_Mensagem)
        erromsg = erromsg.replace("'", String.Empty)
        tbMensagem.Text = erromsg
    End Sub

    Private Sub btEnviar_Click(sender As Object, e As EventArgs) Handles btEnviar.Click

        ServicePointManager.Expect100Continue = False

        '...Try
        '    SQL = "SELECT CNPJ FROM empresa;"
        '    Dim CNPJ = MeuCore.Consulta(SQL, "CNPJ", MeuSistema)

        '    Dim NotificacaoErro As New NotificacaoErro
        '    Dim Resultado = NotificacaoErro.Receber(MeuSistema, erromsg, CNPJ, Dns.GetHostName())
        '    MsgBox(Resultado, MsgBoxStyle.Information, "Mais Escola!")
        'Catch erro As Exception
        '    MsgBox("Mensagem: " & erro.Message, MsgBoxStyle.Information, "Sistemas iSolucao.com")
        'End Try

        Me.Close()
    End Sub
End Class