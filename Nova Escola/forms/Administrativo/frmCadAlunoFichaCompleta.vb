Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmCadAlunoFichaCompleta
    Dim Pesquisa_Aluno_Nro = String.Empty
    Dim Pesquisa_Turma_Nro = String.Empty
    Dim Pesquisa_AnoVigente = String.Empty
    Dim Pesquisa_Aluno_Status = String.Empty
    Dim fCadAlunoFichaCompleta_INSCRICAO

    Dim codigoFone
    Dim Foto_file_id = 0
    Dim Imagem_Localizacao

    ReadOnly delete As New RepositoryItemPictureEdit()
    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click

        delete_Click()

    End Sub

    Sub delete_Click()

        viewFone.PostEditor()

        Dim info As GridHitInfo = viewFone.CalcHitInfo(gridFone.PointToClient(Cursor.Position))
        codigoFone = viewFone.GetRowCellDisplayText(info.RowHandle, viewFone.Columns("codigoFone"))

        Dim vStrMsg As DialogResult = MessageBox.Show(("Deseja apagar este telefone?"), "Apagar", MessageBoxButtons.YesNo)
        If vStrMsg = DialogResult.Yes Then
            SQL = String.Format("DELETE FROM aluno_ficha_telefone WHERE idAlunoFone='{0}';", codigoFone)
            MySQL_atualiza(SQL)
            Refresh_Telefones()

        End If
    End Sub

    ' Carrega este FORM, consulta o RM
    Public Sub New(RM As String)
        InitializeComponent()

        If RM <> "-" Then
            Aluno_Ficha(RM)
        Else
            'PESQUISA O NOME DO CIDADAO...
            SQL = String.Format("SELECT INSCRICAO, CODIGO FROM aluno_ficha WHERE NOME='{0}';", fCadAlunoFichaCompleta_Aluno)
            fCadAlunoFichaCompleta_RM = MySQL_consulta_campo(SQL, "CODIGO")
            fCadAlunoFichaCompleta_INSCRICAO = MySQL_consulta_campo(SQL, "INSCRICAO")
            Aluno_Ficha(fCadAlunoFichaCompleta_RM)

            tbNascimento.Text = fCadAlunoFichaCompleta_Nascimento
            tbRA.Text = fCadAlunoFichaCompleta_RA
            tbRA_Digito.Text = fCadAlunoFichaCompleta_RAd
            Refresh_SalasAtribuidas()

        End If
    End Sub

    'constantes usadas na DLL
    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Friend iDevice As Integer = 0 ' ID do dispositivo atual
    Dim hHwnd As Integer ' manipulador da janela do visualizador

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (hwnd As Integer, wMsg As Integer, wParam As Integer,
         <MarshalAs(UnmanagedType.AsAny)> lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (hwnd As Integer,
                                                                    hWndInsertAfter As Integer, x As Integer,
                                                                    y As Integer,
                                                                    cx As Integer, cy As Integer, wFlags As Integer) _
        As Integer

    Declare Function DestroyWindow Lib "user32" (hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (lpszWindowName As String, dwStyle As Integer,
         x As Integer, y As Integer, nWidth As Integer,
         nHeight As Short, hWndParent As Integer,
         nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (wDriver As Short,
                                                                 lpszName As String, cbName As Integer,
                                                                 lpszVer As String,
                                                                 cbVer As Integer) As Boolean

    Sub ProcuraFoto()

        ' SE Não existir, Procura foto...
        Try
            pbLogotipo.Image = Nothing
            Try
                abrirFoto.InitialDirectory = abrirFoto.FileName
            Catch ex As Exception
                abrirFoto.InitialDirectory = "C:\"
            End Try

            abrirFoto.Title = "Abrir"
            abrirFoto.Filter = "Figura JPG (*.jpg)|*.jpg|Figura JPEG (*.jpeg)|*.jpeg|Todos os arquivos (*.*)|*.*"
            abrirFoto.FilterIndex = 1
            abrirFoto.ShowDialog()

            Imagem_Localizacao = abrirFoto.FileName
            pbLogotipo.Image = Image.FromFile(Imagem_Localizacao)
            pbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
        End Try
    End Sub
    Sub Refresh_Telefones()

        viewFone.Columns.Clear()

        Try
            SQL = String.Format("SELECT Tipo, " _
                                & "Fone, idAlunoFone AS codigoFone " _
                                & "FROM " _
                                & "aluno_ficha_telefone " _
                                & "WHERE idAlunoFicha='{0}' ORDER BY Tipo;",
                                fCadAlunoFichaCompleta_INSCRICAO)
            gridFone.DataSource = Nothing
            gridFone.DataSource = MySQL_datatable(SQL)
        Catch ex As Exception
        End Try

        viewFone.Columns(2).Visible = False
        viewFone.Columns(0).OptionsColumn.AllowEdit = False
        viewFone.Columns(1).OptionsColumn.AllowEdit = False

        AddHandler delete.Click, AddressOf delete_Click

        '... Adiciona as colunas...
        Dim col = New GridColumn() _
                With {.ColumnEdit = delete, .Width = 30, .Caption = "Excluir", .FieldName = String.Empty, .VisibleIndex = 3}
        viewFone.Columns.Add(col)


    End Sub

    Private Sub viewFone_RowClick(sender As Object, e As RowClickEventArgs) Handles viewFone.RowClick

        viewFone.PostEditor()
        Dim View As GridView = sender
        codigoFone = View.GetRowCellDisplayText(e.RowHandle, View.Columns("codigoFone"))

    End Sub

    Private Sub viewFone_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles viewFone.CustomRowCellEdit

        If e.Column.Caption = "Excluir" Then
            e.RepositoryItem = gridFone.RepositoryItems(0)
        End If

    End Sub

    Sub Refresh_SalasAtribuidas()

        Try
            SQL = String.Format("SELECT " _
                                & "aluno.anovigente AS Ano, " _
                                & "turma.classe AS Turma " _
                                & "FROM " _
                                & "aluno " _
                                &
                                "INNER JOIN turma ON aluno.turma = turma.codigo_trma WHERE RA='{0}' ORDER BY aluno.anovigente;",
                                tbRA.Text)
            gridSalas.DataSource = Nothing
            gridSalas.DataSource = MySQL_datatable(SQL)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub carregaDispositivos()
        Dim strNome As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bRetorna As Boolean
        Dim x = 0

        ' Carrega os dispositivos em lstDevices
        Do
            '   Obtem o nome e a versão Driver
            bRetorna = capGetDriverDescriptionA(x, strNome, 100, strVer, 100)
            ' se existir um dispositivo inclui o nome da lista
            If bRetorna Then cbWebCam.Properties.Items.Add(strNome.Trim)
            x += 1
        Loop Until bRetorna = False
    End Sub

    Private Sub abreJanelaVisualizacao()

        '
        ' Abre a janela de visualização no picturebox
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640,
                                        480, pbLogotipo.Handle.ToInt32, 0)

        '
        ' Conecta com o drive
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Define a escala de previsão
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            '
            'Define a taxa de visualização em milisegundos
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            '
            'Iniciar a visualização da imagem a partir da camara
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            '
            ' Redimensiona a janela para se ajustar no picturebox
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, pbLogotipo.Width, pbLogotipo.Height,
                         SWP_NOMOVE Or SWP_NOZORDER)

            pbSalvar.Enabled = True
        Else
            ' Erro de conexão fecha a janela de dispostivos
            DestroyWindow(hHwnd)
            ' btnSalvar.Enabled = False

        End If
    End Sub

    Private Sub fechaJanelaVisualizacao()
        ' Desconecta do dispositivo
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

        ' fecha a chama a janela
        DestroyWindow(hHwnd)
    End Sub

    Sub Inicializacao()

        Imagem_Localizacao = Nothing

        Pesquisa_Aluno_Nro = String.Empty
        Pesquisa_AnoVigente = String.Empty
        Pesquisa_Turma_Nro = String.Empty
        Pesquisa_Aluno_Status = String.Empty
        tbRM.Text = String.Empty
        tbBairro.Text = String.Empty
        tbCEP.Text = String.Empty
        cbCidade.Text = String.Empty
        tbEndereco.Text = String.Empty
        tbEstado.Text = String.Empty
        tbMae.Text = String.Empty
        tbNascimento.Text = "01/01/1900"
        tbObservacao.Text = String.Empty
        tbPai.Text = String.Empty
        tbRG.Text = String.Empty
        Foto_file_id = 0

        btSalvar.Enabled = False
    End Sub

    Sub Aluno_Foto()

        If Imagem_Localizacao <> Nothing Then
            Dim fs As FileStream
            Dim FileSize As UInt32
            Dim rawData() As Byte

            Try

                fs = New FileStream(Imagem_Localizacao, FileMode.Open, FileAccess.Read)
                FileSize = fs.Length

                rawData = New Byte(FileSize) {}
                fs.Read(rawData, 0, FileSize)
                fs.Close()

                Try
                    If Foto_file_id = "0" Then
                        SQL =
                            "INSERT INTO file VALUES(NULL, @FileName, @FileSize, @File); SELECT LAST_INSERT_ID() AS file_id;"
                        Foto_file_id = MySQL_foto(SQL, Imagem_Localizacao, FileSize, rawData)
                    Else
                        SQL =
                            String.Format(
                                "UPDATE file SET file_name=@FileName, file_size=@FileSize, file=@File WHERE file_id='{0}';",
                                Foto_file_id)
                        MySQL_foto(SQL, Imagem_Localizacao, FileSize, rawData)
                    End If

                Catch ex As Exception
                    MsgBox(ex)
                End Try

            Catch myerro As MySqlException
                MsgBox(myerro)
            End Try
        End If
    End Sub

    Sub Aluno_Ficha(RM As String)

        ' PROCURA RM / PELO NOME DO ALUNO...
        Dim SQL =
                String.Format(
                    "SELECT INSCRICAO, NOME, RG_NUM, RG_UF, RA, RA_DIGITO, ENDERECO, CODIGO, BAIRRO, CEP, CIDADE, UF, Pai, Mae, FONE, Escola_Transferencia, SEXO, Livro, Folhas, file_id, date_format(DT_NASC,'%d/%m/%Y') AS DT_NASC FROM aluno_ficha WHERE CODIGO='{0}';",
                    RM)
        Dim MeuRM = MySQL_consulta_campo(SQL, "CODIGO")
        fCadAlunoFichaCompleta_INSCRICAO = MySQL_consulta_campo(SQL, "INSCRICAO")
        Refresh_Telefones()

        If MeuRM <> "0" Then

            tbRM.Text = MeuRM

            tbNome.Text = MySQL_consulta_campo(SQL, "NOME").ToString
            tbEndereco.Text = MySQL_consulta_campo(SQL, "ENDERECO").ToString
            tbRG.Text = MySQL_consulta_campo(SQL, "RG_NUM").ToString
            tbBairro.Text = MySQL_consulta_campo(SQL, "BAIRRO").ToString
            tbCEP.Text = MySQL_consulta_campo(SQL, "CEP").ToString

            cbCidade.Properties.NullText = MySQL_consulta_campo(SQL, "CIDADE").ToString

            Dim Estado = MySQL_consulta_campo(SQL, "UF").ToString
            If Estado = "0" Then
                tbEstado.Text = "SP"
            Else
                tbEstado.Text = Estado
            End If

            If tbNascimento.Text = "01/01/2000" Then
                tbNascimento.Text = MySQL_consulta_campo(SQL, "DT_NASC").ToString
            End If

            tbPai.Text = MySQL_consulta_campo(SQL, "Pai").ToString
            tbMae.Text = MySQL_consulta_campo(SQL, "Mae").ToString

            escolhaSexo.EditValue = MySQL_consulta_campo(SQL, "SEXO").ToString

            Dim RA_Estado = MySQL_consulta_campo(SQL, "RG_UF").ToString
            If RA_Estado = "0" Then
                tbRA_Estado.Text = "SP"
            Else
                tbRA_Estado.Text = RA_Estado
            End If

            Dim RA = MySQL_consulta_campo(SQL, "ra").ToString
            Dim RADigito = MySQL_consulta_campo(SQL, "ra_digito").ToString

            If RA = "0" Or RADigito = "-" Then
                Dim SQL_Consulta = "SELECT ra, ra_digito FROM aluno WHERE nome='" & tbNome.Text & "' ORDER BY ra_digito DESC;"
                tbRA.Text = MySQL_consulta_campo(SQL_Consulta, "ra").ToString
                tbRA_Digito.Text = MySQL_consulta_campo(SQL_Consulta, "ra_digito").ToString
            Else
                tbRA.Text = RA
                tbRA_Digito.Text = RADigito
            End If

            Foto_file_id = MySQL_consulta_campo(SQL, "file_id").ToString

            tbFolhas.Text = MySQL_consulta_campo(SQL, "Folhas").ToString
            tbLivro.Text = MySQL_consulta_campo(SQL, "Livro").ToString

            'temp APAGAR DEPOIS DE UM TEMPO...
            Dim Retorno = MySQL_consulta_campo(SQL, "FONE").ToString
            tbObservacao.Text = Retorno + MySQL_consulta_campo(SQL, "Escola_Transferencia").ToString

            SQL = String.Format("SELECT file FROM file WHERE file_id='{0}';", Foto_file_id)
            Dim foto As Image = MySQL_consulta_foto(SQL, "file")
            If foto IsNot Nothing Then
                pbLogotipo.Image = New Bitmap(foto)
                pbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage
            End If

            If tbRM.Text <> String.Empty Then
                btSalvar.Enabled = True
            End If

            Refresh_SalasAtribuidas()
            ' Fim do aluno_ficha...
        Else

            '//Permite digitar os indices...
            tbRA.Text = fCadAlunoFichaCompleta_RA
            tbRA.Enabled = False

            tbRA_Digito.Text = fCadAlunoFichaCompleta_RAd
            tbRA_Digito.Enabled = False

            tbNome.Text = fCadAlunoFichaCompleta_Aluno
            tbNome.Enabled = False

            tbNascimento.Text = fCadAlunoFichaCompleta_Nascimento
            tbNascimento.Enabled = False

            tbEstado.Enabled = False

            If tbRM.Text <> String.Empty Then
                btSalvar.Enabled = True
            End If


        End If
    End Sub

    Sub Aluno()

        Dim DataNascimento

        'ALTERA ALUNO NO ALUNO_FICHA
        '
        If tbNascimento.Text <> String.Empty Then
            DataNascimento = Format(CDate(tbNascimento.Text), "yyyy-MM-dd")
        Else
            DataNascimento = "2000-01-01"
        End If

        Aluno_Foto()

        SQL =
            String.Format(
                "UPDATE aluno_ficha SET NOME='{14}', RG_UF='{15}', endereco='{0}', bairro='{1}', CEP='{2}', cidade='{3}', UF='{4}', DT_NASC='{5}', RG_NUM='{6}', Pai='{7}', Mae='{8}', SEXO='{9}', Data_Matricula='{10}', file_id='{11}', Escola_Transferencia='{13}', Livro='{16}', Folhas='{17}' WHERE CODIGO='{12}';",
                tbEndereco.Text, tbBairro.Text, tbCEP.Text, cbCidade.Text, tbEstado.Text, DataNascimento, tbRG.Text,
                tbPai.Text, tbMae.Text, escolhaSexo.EditValue, Format(Date.Now, "yyyy-MM-dd"), Foto_file_id, tbRM.Text,
                tbObservacao.Text, tbNome.Text, tbRA_Estado.Text, tbLivro.Text, tbFolhas.Text)
        Dim Retorno = MySQL_atualiza(SQL)

        If Retorno = "0" Then

            ' Se não encontrar... ele insere!
            SQL = String.Format(
                    "INSERT INTO aluno_ficha (NOME, RG_UF, endereco, bairro, CEP, cidade, UF, DT_NASC, RG_NUM, Pai, Mae, SEXO, Data_Matricula, file_id, Escola_Transferencia, Livro, Folhas, CODIGO, ra, ra_digito) VALUES('{14}', '{15}', '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{13}', '{16}', '{17}', '{12}', '{18}', '{19}'); SELECT LAST_INSERT_ID() AS INSCRICAO;",
                    tbEndereco.Text, tbBairro.Text, tbCEP.Text, cbCidade.Text, tbEstado.Text, DataNascimento, tbRG.Text,
                    tbPai.Text, tbMae.Text, escolhaSexo.EditValue, Format(Date.Now, "yyyy-MM-dd").ToString, Foto_file_id,
                    tbRM.Text, tbObservacao.Text, tbNome.Text, tbRA_Estado.Text, tbLivro.Text, tbFolhas.Text, tbRA.Text,
                    tbRA_Digito.Text)
            Dim Retorno2 = MySQL_atualiza(SQL)
            If Retorno2 <> "0" Then
                MsgBox("Cadastrado com sucesso!", MsgBoxStyle.Information, "Informação")
                fCadAlunoFichaCompleta_INSCRICAO = Retorno2
            Else
                MsgBox("Verificar os campos!", MsgBoxStyle.Information, "Informação")
            End If

        Else
            MsgBox("Atualizado com sucesso!", MsgBoxStyle.Information, "Informação")

        End If
    End Sub

    Private Sub frmCadAlunoFichaCompleta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        fechaJanelaVisualizacao()
    End Sub

    Private Sub frmCadAlunoFicha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmCadAlunoFichaCompleta"
        'verifica e carrega os dispositivos
        carregaDispositivos()

        If cbWebCam.Properties.Items.Count > 0 Then
            cbWebCam.SelectedIndex = 0
        End If

        pbLogotipo.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        Aluno()
        Me.Close()
    End Sub

    Private Sub tbEstado_Click(sender As Object, e As EventArgs) Handles tbEstado.Click
        cbCidade.Enabled = True

        SQL = String.Format("SELECT municipio FROM cidades WHERE estado='{0}' ORDER BY municipio ASC;", tbEstado.Text)
        cbCidade.Properties.DataSource = Nothing
        cbCidade.Properties.DataSource = MySQL_combobox(SQL)
        cbCidade.Properties.DisplayMember = "municipio"
    End Sub

    Private Sub tbRA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRA.KeyPress
        If e.KeyChar = ","c Or e.KeyChar = "."c Or e.KeyChar = "/"c Or e.KeyChar = "-"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbRM_LostFocus(sender As Object, e As EventArgs) Handles tbRM.LostFocus
        If tbRM.Enabled = True Then
            If tbRM.Text <> String.Empty Then

                ' CHECA SE JA EXISTE...
                SQL = String.Format("SELECT NOME FROM aluno_ficha WHERE CODIGO='{0}';", tbRM.Text)
                Dim Retorno = MySQL_consulta_campo(SQL, "NOME")
                If Retorno = "0" Then
                    btSalvar.Enabled = True
                Else
                    If Retorno <> tbNome.Text Then
                        btSalvar.Enabled = False
                        MsgBox(String.Format("Aluno [{0}] cadastrado com este RM!", Retorno), MsgBoxStyle.Information,
                               "Mais Escola!")
                        tbRM.Text = String.Empty
                    End If
                End If

            Else

                'GERA UM NOVO RM...
                SQL = "SELECT CODIGO FROM aluno_ficha ORDER BY CODIGO DESC;"
                Dim Retorno = MySQL_consulta_campo(SQL, "CODIGO")
                tbRM.Text = Retorno + 1
                btSalvar.Enabled = True

            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles pbSalvar.Click
        If cbWebCam.Text <> String.Empty Or cbWebCam.Text <> "Escolher WebCam..." Then
            Dim bmap As Image

            ' Copia a imagem para o clipboard
            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

            Dim Foto_Aluno As IDataObject = Clipboard.GetDataObject()

            ' Obtem a imagem do clipboard e converte para bitmap

            If Foto_Aluno.GetDataPresent(GetType(Bitmap)) Then
                bmap = CType(Foto_Aluno.GetData(GetType(Bitmap)), Image)
                pbLogotipo.Image = bmap
                fechaJanelaVisualizacao()
                pbSalvar.Enabled = False

                'If sfdImage.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                '    bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Jpeg)
                'End If
                Imagem_Localizacao = meucaminhorelatorio & "\temp_Foto.jpg"
                bmap.Save(Imagem_Localizacao, ImageFormat.Jpeg)

            End If
            'cbWebCam.Text = "Escolher WebCam..."
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btParar.Click
        fechaJanelaVisualizacao()
        ' Apaga a foto do Aluno_Foto()
        '

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles btIniciar.Click
        iDevice = cbWebCam.SelectedIndex
        If iDevice <> -1 Then
            abreJanelaVisualizacao()
        Else
            MsgBox("Escolher WebCam...")
        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles btProcura.Click

        If pbLogotipo.Image Is Nothing Then
            ProcuraFoto()
        Else

            Dim vStrMsg As String = MsgBox(("Deseja trocar a foto?"), MsgBoxStyle.YesNo, "Trocar")
            If vStrMsg = MsgBoxResult.Yes Then

                pbLogotipo.Image = Nothing

                'Abre para escolher a foto...
                ProcuraFoto()
            End If

        End If

    End Sub

    Private Sub btAdicionar_Click(sender As Object, e As EventArgs) Handles btFone_Salvar.Click
        ' Adicionar Telefone
        '
        If cbFone_Tipo.Text <> String.Empty And txtFone.Text <> String.Empty Then

            If fCadAlunoFichaCompleta_INSCRICAO = 0 Then
                ' Se não existir o cadastro no aluno_ficha
                Aluno()
            End If

            SQL = "INSERT INTO aluno_ficha_telefone (tipo, fone, idAlunoFicha) VALUES('" & cbFone_Tipo.Text & "', '" & txtFone.Text & "', '" & fCadAlunoFichaCompleta_INSCRICAO & "');"
            MySQL_atualiza(SQL)
            Refresh_Telefones()
            txtFone.ResetText()
            cbFone_Tipo.ResetText()

        Else
            MsgBox("Verificar os campos!", MsgBoxStyle.Information, "Informação")

        End If
        '
        ' ... Fim...
    End Sub

    Private Sub txtFone_EditValueChanged(sender As Object, e As EventArgs) Handles txtFone.EditValueChanged

    End Sub

    Private Sub txtFone_Enter(sender As Object, e As EventArgs) Handles txtFone.Enter
        If txtFone.Text <> String.Empty Then
            txtFone.ResetText()

        End If
    End Sub

    Private Sub cbFone_Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFone_Tipo.SelectedIndexChanged
        If cbFone_Tipo.Text = "Celular" Then
            txtFone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            txtFone.Properties.Mask.EditMask = "(99) 00000-0000"

        Else
            txtFone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            txtFone.Properties.Mask.EditMask = "(99) 0000-0000"

        End If
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

    End Sub
End Class