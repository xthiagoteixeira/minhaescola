Imports DevExpress.Utils
Imports DevExpress.XtraPrinting

Public Class frmUtilEventos
    Dim Consulta_idUsuario
    Dim Consulta_idCategoria

    Sub AlinharDataGrid()

        'Alinhar...
        Try
            viewEventos.Columns(1).Width = 90
            viewEventos.Columns(2).Width = 350
            viewEventos.Columns(3).Width = 120
            viewEventos.Columns(0).Width = 80
            viewEventos.Columns(3).DisplayFormat.FormatType = FormatType.DateTime
            viewEventos.Columns(3).DisplayFormat.FormatString = "g"

        Catch ex As Exception
        End Try
    End Sub

    Public Sub RefreshDG(Modulo)

        'Refresh DATAGRID...
        '
        Dim DataGrid As DataTable
        If Modulo = "Todos" Then
            SQL = "SELECT " _
                  & "  usuariodsk.usuario," _
                  & "  logs_categorias.Categoria," _
                  & "  logs.Descricao," _
                  & "  logs.DataLancamento" _
                  & " FROM" _
                  & "  logs_categorias" _
                  &
                  "  INNER JOIN logs ON (logs_categorias.idLogCat = logs.idLogCat) INNER JOIN usuariodsk ON usuariodsk.codigo = `logs`.idUsuario" _
                  & " ORDER BY logs.DataLancamento DESC;"

        ElseIf Modulo = "Categoria" Then
            SQL = "SELECT " _
                  & "  usuariodsk.usuario," _
                  & "  logs_categorias.Categoria," _
                  & "  logs.Descricao," _
                  & "  logs.DataLancamento" _
                  & " FROM" _
                  & "  logs_categorias" _
                  &
                  "  INNER JOIN logs ON (logs_categorias.idLogCat = logs.idLogCat) INNER JOIN usuariodsk ON usuariodsk.codigo = `logs`.idUsuario" _
                  & "  WHERE logs.idLogCat='" & Consulta_idCategoria & "' ORDER BY logs.DataLancamento DESC;"

        ElseIf Modulo = "Usuario" Then
            SQL = "SELECT " _
                  & "  usuariodsk.usuario," _
                  & "  logs_categorias.Categoria," _
                  & "  logs.Descricao," _
                  & "  logs.DataLancamento" _
                  & " FROM" _
                  & "  logs_categorias" _
                  &
                  "  INNER JOIN logs ON (logs_categorias.idLogCat = logs.idLogCat) INNER JOIN usuariodsk ON usuariodsk.codigo = `logs`.idUsuario" _
                  & " WHERE usuariodsk.usuario='" & cbUsuario.Text & "' ORDER BY logs.DataLancamento DESC;"

        ElseIf Modulo = "Data" Then
            SQL = "SELECT " _
                  & " usuariodsk.usuario," _
                  & "  logs_categorias.Categoria," _
                  & "  logs.Descricao," _
                  & "  logs.DataLancamento" _
                  & " FROM" _
                  & "  logs_categorias" _
                  &
                  "  INNER JOIN logs ON (logs_categorias.idLogCat = logs.idLogCat) INNER JOIN usuariodsk ON usuariodsk.codigo = `logs`.idUsuario" _
                  & "  WHERE logs.DataLancamento LIKE '" & Format(CDate(cbData.EditValue), "yyyy-MM-dd") &
                  "%' ORDER BY logs.DataLancamento DESC;"
        End If

        DataGrid = MySQL_consulta_datagrid(SQL)
        gridEventos.DataSource = DataGrid
        AlinharDataGrid()
    End Sub

    Private Sub frmGerencialLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Sql = "SELECT usuario FROM usuariodsk WHERE bloqueado='0' ORDER BY usuario ASC;"
        cbUsuario.Properties.DataSource = MySQL_combobox(Sql)
        cbUsuario.Properties.DisplayMember = "usuario"

        RefreshDG("Todos")
    End Sub

    Private Sub cbUsuario_TextChanged1(sender As Object, e As EventArgs) Handles cbUsuario.TextChanged

        Dim Sql = String.Format("SELECT codigo, usuario FROM usuariodsk WHERE bloqueado='0' AND usuario='{0}';",
                                cbUsuario.Text)
        Consulta_idUsuario = MySQL_consulta_campo(Sql, "codigo")
        RefreshDG("Usuario")
    End Sub

    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles PictureEdit1.Click
        RefreshDG("Todos")
    End Sub

    Private Sub cbData_EditValueChanged(sender As Object, e As EventArgs) Handles cbData.EditValueChanged
        RefreshDG("Data")
    End Sub

    Private Sub cbUsuario_EditValueChanged(sender As Object, e As EventArgs) Handles cbUsuario.EditValueChanged
        RefreshDG("Usuario")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        frmPreview_Titulo = "Relatório: Visualizador de Eventos"
        Dim Link As New PrintableComponentLink(New PrintingSystem()) With {.Component = gridEventos}
        AddHandler Link.CreateMarginalHeaderArea, AddressOf frmPreview_Padrao
        Link.CreateDocument()
        Link.ShowPreview()
    End Sub

    Private Sub PictureEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEdit1.EditValueChanged
    End Sub
End Class