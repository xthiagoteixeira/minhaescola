Public Class Splash
    Public fLogin As New frmLogin
    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        VERSAO = String.Format("{0}", My.Application.Info.Version.ToString)
        lbVersao.Text = "Versão " & VERSAO

        '''''' GRAVA ULTIMA VEZ QUE ACESSOU O PROGRAMA...
        ' X - Data Ultimo Acesso ao Programa
        '
        Try
            Dim x1
            Dim cRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("Micro.System.Vms")
            cRegistryKey = cRegistryKey.CreateSubKey("Classes")

            'INICIO DO X
            Dim dataatual
            dataatual = Now()
            x1 = FormatDateTime(dataatual, DateFormat.LongDate)
            cRegistryKey.SetValue("x", "" & x1)
            'FIM DO X
        Catch ex As Exception
        End Try
        '
        '''''
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://www.isolucao.com")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Hide()
        fLogin.Show()
    End Sub
End Class
