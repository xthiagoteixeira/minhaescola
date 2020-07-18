Public Class frmSobre2
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://suporte.isolucao.com.br/medown/MaisEscola_LUS.pdf")
    End Sub

    Private Sub btFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFinalizar.Click
        Me.Close()

    End Sub
End Class