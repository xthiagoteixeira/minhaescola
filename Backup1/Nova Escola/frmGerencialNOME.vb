Imports Mais_Escola
Imports MySql.Data.MySqlClient

Public Class frmGerencialNOME
    Dim meuClique

    Private Sub DGBusca_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBusca.CellContentClick


    End Sub

    Private Sub frmGerencialNOME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DGBusca.DataSource = myData3
        DGBusca.Columns(0).Width = "200"
        'DGBusca.Columns(1).Width = "10"
        'DGBusca.Columns(2).Width = "10"
        'DGBusca.Columns(3).Width = "10"

    End Sub

    Private Sub DGBusca_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBusca.CellDoubleClick

        meuClique = DGBusca.Rows(e.RowIndex).Cells(0).Value
        selecionaNome = meuClique

        selecionaNomeID = DGBusca.Rows(e.RowIndex).Cells(4).Value
        selecionaNomeTr = DGBusca.Rows(e.RowIndex).Cells(1).Value
        selecionaNomeAno = DGBusca.Rows(e.RowIndex).Cells(2).Value
        selecionaNomeNro = DGBusca.Rows(e.RowIndex).Cells(3).Value
        Try
            selecionaNomeNroTr = DGBusca.Rows(e.RowIndex).Cells(5).Value
        Catch ex As Exception
        End Try
        iProcura = 1

        Me.Close()

    End Sub
End Class