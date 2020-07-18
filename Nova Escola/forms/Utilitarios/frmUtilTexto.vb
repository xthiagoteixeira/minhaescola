Imports DevExpress.XtraRichEdit

Public Class frmUtilTexto

    Public Sub New(ByVal Abrir As Boolean, ByVal Caminho As String)

        InitializeComponent()

        If Abrir = True Then
            RichEditControl1.LoadDocument(Caminho, DocumentFormat.Doc)
        End If

    End Sub

    Private Sub frmUtilTexto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class