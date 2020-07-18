Public Class frmFerNavegador

    Private Sub pAdiante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pAdiante.Click
        webb1.GoForward()

    End Sub

    Private Sub pVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pVoltar.Click
        webb1.GoBack()

    End Sub

    Private Sub pStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pStop.Click
        webb1.Stop()

    End Sub

    Private Sub pHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pHome.Click
        webb1.GoHome()

    End Sub

    Private Sub webb1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webb1.DocumentCompleted
        ProgressBar1.Value = 0
    End Sub

    Private Sub webb1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles webb1.ProgressChanged
        ProgressBar1.Value = CType(((e.CurrentProgress / e.MaximumProgress) * 100), Integer)

    End Sub

    Private Sub txtUrl_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUrl.Enter

    End Sub

    Private Sub txtUrl_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUrl.Leave

    End Sub

    Private Sub txtUrl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUrl.TextChanged
       
    End Sub

    Private Sub frmFerNavegador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtUrl.Text.Length < 1 Then
            txtUrl.Text = "http://www.smav.com.br"
        End If
        webb1.Url = New System.Uri(txtUrl.Text)
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class