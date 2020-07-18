Imports System.ComponentModel

Public Class frmUtilBackup
    Dim DataHoje As String = DateTime.Now
    Dim NomeArquivo As String = DataHoje
    Dim ReadOnly salvarComo As SaveFileDialog = New SaveFileDialog()
    Dim caminho As DialogResult

    Private Delegate Sub TreathGeral(StatusAdd As String, MensgaemAdd As String)

    Public Sub Inicializar()

        DataHoje = Replace(DataHoje, "/", "-")
        DataHoje = Replace(DataHoje, ":", "-")
        DataHoje = Replace(DataHoje, " ", "-")

        DataGridView.Rows.Clear()

        AdicionaLog("S", String.Format("Backup iniciado com gravação em '{0}'", NomeArquivo))
        BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub IniciarBackup(ProcessoAtivo As BackgroundWorker)
        GerarDumpDataBase(BD)
    End Sub

    Private Sub GerarDumpDataBase(NomeDataBase As String)

        Try

            'Log
            Me.Invoke(New TreathGeral(AddressOf Me.AdicionaLog), "S",
                      String.Format("Criando Backup, aguarde..."))

            'Cria o DUMP

            Dim Proc = New Process()
            Dim LocalSalvar = String.Format("{0}.sql", NomeArquivo)
            'Dim LocalZipar = String.Format("{0}.zip", NomeArquivo)

            Proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Proc.StartInfo.FileName = "mysqldump.exe"
            Proc.StartInfo.Arguments = String.Format(" -r {0} --user=admsuporte --password=admauxcli --host={1} --default-character-set=utf8 {2}", LocalSalvar, Preferencias(1), Preferencias(0))
            'Proc.StartInfo.Arguments = String.Format(" -r {0} --user=admsuporte --password=admauxcli --host={1} --default-character-set=latin1 -N {2}",LocalSalvar, IP, NomeDataBase)
            'Proc.StartInfo.Arguments = String.Format(" -r {0} --user=admsuporte --password=admauxcli --host={1} --default-character-set=utf8 --opt {2}", LocalSalvar, IP, NomeDataBase)
            'Proc.StartInfo.Arguments = "--user=admsuporte --password=admauxcli --host=" & IP & " --port=3306 --default-character-set=utf8 --databases " & NomeDataBase & " -r " & LocalSalvar

            If Proc.Start() Then
                Proc.WaitForExit()
            End If

            'Log
            Me.Invoke(New TreathGeral(AddressOf Me.AdicionaLog), "S",
                      String.Format("OK, feito!"))

            ''Log
            ''Me.Invoke(New TreathGeral(AddressOf Me.AdicionaLog), "S",
            ''          String.Format("Compressão ( ZIP ) de '{0}' para '{1}'", LocalSalvar, LocalZipar))

            'Comprimir...
            '\\\\\\\\\arquivoZip(LocalSalvar, LocalZipar)

            ''Dim DadosArquivoOriginal = New FileInfo(String.Format("{0}", LocalSalvar))
            ''Dim DadosArquivoDestino = New FileInfo(String.Format("{0}", LocalZipar))

            ''Log
            ''Me.Invoke(New TreathGeral(AddressOf Me.AdicionaLog), "S",
            ''          "Compressão completada ( " & DadosArquivoOriginal.Length & " bytes compactados em " &
            ''          DadosArquivoDestino.Length & " bytes )")

            ''Deleta o arquivo SQL
            ''File.Delete(LocalSalvar)

            ''Log
            ''Me.Invoke(New TreathGeral(AddressOf Me.AdicionaLog), "S", "Deletado '" & LocalSalvar)

        Catch ex As Exception
            MsgBox("ERRO:" & ex.Message)

        End Try
    End Sub

    Private Sub AdicionaLog(StatusAdd As String, MensgaemAdd As String)

        If StatusAdd = "S" Then
            DataGridView.Rows.Add({ImageList.Images(1), DateTime.Now, MensgaemAdd})
        Else
            DataGridView.Rows.Add({ImageList.Images(0), DateTime.Now, MensgaemAdd})
        End If

        DataGridView.CurrentCell = DataGridView.Rows(DataGridView.Rows.Count - 1).Cells(0)
    End Sub


    Private Sub BackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker.DoWork

        Dim AcaoSegundoPlano = New BackgroundWorker

        AcaoSegundoPlano = CType(sender, BackgroundWorker)
        IniciarBackup(AcaoSegundoPlano)

        If AcaoSegundoPlano.CancellationPending = True Then

            e.Cancel = True

        End If
    End Sub

    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) _
        Handles BackgroundWorker.ProgressChanged

        '   ProgressoBackup.Value = e.ProgressPercentage + 1
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles BackgroundWorker.RunWorkerCompleted

        If e.Cancelled = True Then
            AdicionaLog("F", "Backup Cancelado!")
        Else
            AdicionaLog("S", "Backup Completado!")
        End If

        Btn_IniciarBackup.Enabled = False
        '    ProgressoBackup.Value = 0
        '   Bt_Voltar.Enabled = True
    End Sub

    Private Sub Progresso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        BackgroundWorker.CancelAsync()
    End Sub

    Private Sub Btn_IniciarBackup_Click(sender As Object, e As EventArgs) Handles Btn_IniciarBackup.Click

        salvarComo.CheckFileExists = False
        salvarComo.FileName = Format(Date.Now, "dd-MM-yyyy").ToString()
        'salvarComo.Title = "Backup Mais Escola |*.zip |"
        salvarComo.Filter = "Backup Mais Escola |*.*"
        caminho = salvarComo.ShowDialog
        SaveFileDialog1.FileName = NomeArquivo
        NomeArquivo = salvarComo.FileName

        If NomeArquivo = Nothing Then
            MessageBox.Show("Arquivo Inválido", "Salvar Como", MessageBoxButtons.OK)
        Else
            Inicializar()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmAdmFerBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmAdmFerBackup"
    End Sub
End Class