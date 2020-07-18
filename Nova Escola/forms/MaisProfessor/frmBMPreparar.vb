Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class frmBMPreparar
    Dim mydrive
    Dim AnoCriar

    Sub Refresh_DataGrid()

        If cbProfessor.Text <> String.Empty Then
            SQL = "SELECT usuariodsk.usuario AS Professor, " _
                  & "turma.classe As Turma, " _
                  & "disciplinas.disciplina AS Disciplina " _
                  & "FROM " _
                  & "usuariodsk " _
                  & "INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK " _
                  & "INNER JOIN disciplinas ON disciplinas.codigo_disc = professor_grupos.codigo_disc " _
                  & "INNER JOIN turma ON turma.codigo_trma = professor_grupos.codigo_trma " _
                  & "WHERE usuariodsk.usuario='" & cbProfessor.Text &
                  "' ORDER BY turma.classe, disciplinas.disciplina ASC;"
            gridAtribuicao.DataSource = Nothing
            gridAtribuicao.DataSource = MySQL_datatable(SQL)
        Else
            SQL = "SELECT usuariodsk.usuario AS Professor," _
                  & "turma.classe As Turma, " _
                  & "disciplinas.disciplina AS Disciplina " _
                  & "FROM " _
                  & "usuariodsk " _
                  & "INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK " _
                  & "INNER JOIN disciplinas ON disciplinas.codigo_disc = professor_grupos.codigo_disc " _
                  & "INNER JOIN turma ON turma.codigo_trma = professor_grupos.codigo_trma " _
                  & "ORDER BY usuariodsk.usuario, turma.classe, disciplinas.disciplina ASC;"
            gridAtribuicao.DataSource = Nothing
            gridAtribuicao.DataSource = MySQL_datatable(SQL)
        End If
    End Sub

    Public Sub EsconderPasta()

        Try
            Dim myprocessD = New Process()
            myprocessD.StartInfo.FileName = "attrib"
            myprocessD.StartInfo.Arguments = String.Format("+H {0}", AnoCriar)
            myprocessD.Start()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub RefreshDrive()

        cbDriver.Properties.Items.Clear()
        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            cbDriver.Properties.Items.Add(drive)
        Next drive

    End Sub

    Public Sub RefreshUsuarios()

        SQL = "SELECT usuario FROM usuariodsk WHERE cod_prof='1' ORDER BY usuario ASC;"
        cbProfessor.Properties.DataSource = MySQL_combobox(SQL)
        cbProfessor.Properties.DisplayMember = "usuario"
    End Sub

    Private Sub gravaArquivoini()
        WritePrivateProfileString("Sistema", "Escola", Escola_Sistema, nome_arquivo_ini)
    End Sub

    Function nomeArquivoINI() As String

        Dim nome_arquivo_ini As String = String.Format("{0}{1}\mep.ini", mydrive, tAno.Value)
        Return nome_arquivo_ini
    End Function

    Public Sub Carregar()

        Dim myTexto
        Dim ano, turma

        AnoCriar = String.Format("{0}{1}", mydrive, tAno.Text)

        '\\\\\\\\\\\\\\\\\\\ APAGA TODOS OS DADOS ANTIGOS DO PROGRAMA.
        If cbApagar.Checked = True Then

            Try
                My.Computer.FileSystem.DeleteDirectory(AnoCriar, DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
            End Try

        End If

        '\\\\\\\\\\\\\\\\\ APAGA TURMAS E DISCIPLINAS...
        Try
            File.Delete(String.Format("{0}{1}\turmas.txt", cbDriver.Text, tAno.Text))
            File.Delete(String.Format("{0}{1}\disciplinas.txt", cbDriver.Text, tAno.Text))
            File.Delete(String.Format("{0}{1}\professor.txt", cbDriver.Text, tAno.Text))

        Catch ex As Exception
        End Try

        '\\\\\\\\\\\\\\\\\\ 
        If (My.Computer.FileSystem.DirectoryExists(String.Format("{0}{1}", mydrive, tAno.Text)) = False) Then
            'CRIA AS DIRETORIO ANO

            Try
                My.Computer.FileSystem.CreateDirectory(AnoCriar)
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message, MsgBoxStyle.Information, "Mais Escola!")
                Exit Sub
            End Try

            ' FIM CRIAR DIRETORIO ANO
        End If

        'TIPO DA ESCOLA, E GRAVA!
        Try
            Dim nome_arquivo_ini As String = nomeArquivoINI()
            WritePrivateProfileString("Sistema", "Escola", Escola_Sistema, nome_arquivo_ini)
            gravaArquivoini()
        Catch ex As Exception
        End Try

        'Copiando o PROGRAMA...
        Try
            FileCopy("Mais Professor!.exe", String.Format("{0}Mais Professor!.exe", mydrive))
        Catch ex As Exception
        End Try

        'Arquivo Padrao - PROFESSOR
        Try
            FileCopy("mep.ini", String.Format("{0}{1}\mep.ini", mydrive, tAno.Value))
        Catch ex As Exception
        End Try

        Dim myTexto20, myTexto30
        Dim ArqTurmas As String = String.Format("{0}{1}\turmas.txt", mydrive, tAno.Value)
        Dim ArqDisciplinas As String = String.Format("{0}{1}\disciplinas.txt", mydrive, tAno.Value)
        Dim ArqProfessor As String = String.Format("{0}{1}\professor.txt", mydrive, tAno.Value)

        '''''''''''''CARREGA TODAS AS TURMAS E DISCIPLINAS''''''''''''
        If rbTodos.Checked = True Then

            Try
                Dim objStream20 As New FileStream(ArqTurmas, FileMode.Create)
                Dim Arq20 As New StreamWriter(objStream20)

                SQL = "SELECT classe FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
                Dim Turmas = MySQL_datatable(SQL)

                For Each r In Turmas.Rows
                    myTexto20 = r("classe")
                    Arq20.WriteLine(myTexto20)

                    ' ... CRIA AS TURMAS
                    turma = String.Format("{0}{1}\{2}", mydrive, tAno.Value, myTexto20)
                    My.Computer.FileSystem.CreateDirectory(turma)
                    ' ... FIM CRIAR AS TURMAS
                Next
                Arq20.Close()

            Catch ex As Exception
                MsgBox("Desculpe, não foi possível criar o arquivo turma.", MsgBoxStyle.Information, "Disco inválido!")
            End Try

            Try

                Dim objStream30 As New FileStream(ArqDisciplinas, FileMode.Create)
                Dim Arq30 As New StreamWriter(objStream30)

                SQL = "SELECT disciplina FROM disciplinas WHERE bloqueado='0' AND disciplina<>'-' ORDER BY disciplina;"
                Dim Disciplina = MySQL_datatable(SQL)

                For Each r In Disciplina.Rows
                    myTexto30 = r("disciplina")
                    Arq30.WriteLine(myTexto30)
                Next
                Arq30.Close()

            Catch ex As Exception
                MsgBox("Desculpe, não foi possível criar o arquivo disciplina.", MsgBoxStyle.Information,
                       "Disco inválido!")

            End Try

            '/// Criar arquivo de cada Turma
            If cbAlunos.Checked = True Then

                '\\\\\\\\\\\\\\\\\\\\\\\\\\\\ CRIAR OS ARQUIVOS SOMENTE PARA TURMAS E DISCIPLINAS //////////////////////////////////
                Try

                    SQL = "SELECT classe, codigo_trma FROM turma WHERE bloqueado='0' ORDER BY classe ASC;"
                    Dim ListaPiloto = MySQL_datatable(SQL)

                    For Each r In ListaPiloto.Rows

                        Dim nturma = r("codigo_trma")
                        ano = tAno.Value
                        myTexto = r("classe")

                        Try

                            Dim ArqAlunos As Object = String.Format("{0}{1}\{2}\{2}a.txt", mydrive, ano, myTexto)
                            Dim objStreamT As New FileStream(ArqAlunos, FileMode.Create)
                            Dim Arq As New StreamWriter(objStreamT)
                            Dim myTextoF = String.Empty
                            Dim iContador = 1
                            ' Consulta a tabela por inteiro.
                            '
                            SQL =
                                String.Format(
                                    "SELECT nro, status FROM aluno WHERE turma='{0}' AND anovigente='{1}' ORDER BY nro ASC;",
                                    nturma, ano)
                            Dim MinhaListaPiloto = MySQL_datatable(SQL)

                            ' For iContador = 1 To AlunoFinal

                            '..." Gravar NroAluno;Status
                            For Each r2 In MinhaListaPiloto.Rows

                                Dim NroAluno = r2("nro")
                                Dim Status = r2("status")

                                If iContador = NroAluno Then
                                    ' Se for Normal...
                                    myTextoF = String.Format("{0};{1};", NroAluno, Status)
                                    Arq.WriteLine(myTextoF)
                                    iContador = iContador + 1
                                Else
                                    While (iContador < NroAluno)
                                        ' Se for NC...
                                        myTextoF = String.Format("{0};NC;", iContador)
                                        Arq.WriteLine(myTextoF)
                                        iContador = iContador + 1
                                    End While

                                    myTextoF = String.Format("{0};{1};", NroAluno, Status)
                                    Arq.WriteLine(myTextoF)
                                    iContador = iContador + 1
                                End If

                            Next
                            Arq.Close()

                            'Apaga se não tiver dados...
                            Dim DadosArquivoOriginal = New FileInfo(ArqAlunos)
                            If DadosArquivoOriginal.Length = 0 Then
                                DadosArquivoOriginal.Delete()
                            End If

                        Catch ex As Exception
                        End Try

                    Next

                Catch myerro As Exception
                    MsgBox("Mensagem: " & myerro.Message.ToString, "Informação!")
                End Try

            End If
            '/// Fim de criar Arquivo de Turma...

        ElseIf rbProfessor.Checked = True Then

            '////////////////////// PERSONALIZADO DO PROFESSOR.
            '

            Try
                Dim objStreamProf As New FileStream(ArqProfessor, FileMode.Create)
                Dim Arq40 As New StreamWriter(objStreamProf)

                ' Refresh no Data Grid
                '
                SQL = "SELECT " _
                      & "turma.classe As Turma, turma.codigo_trma As NroTurma, " _
                      & "disciplinas.disciplina AS Disciplina " _
                      & "FROM " _
                      & "usuariodsk " _
                      & "INNER JOIN professor_grupos ON usuariodsk.codigo = professor_grupos.idUsuarioDSK " _
                      & "INNER JOIN disciplinas ON disciplinas.codigo_disc = professor_grupos.codigo_disc " _
                      & "INNER JOIN turma ON turma.codigo_trma = professor_grupos.codigo_trma " _
                      & "WHERE usuariodsk.usuario='" & cbProfessor.Text &
                      "' ORDER BY turma.classe, disciplinas.disciplina ASC;"
                Dim Turmas = MySQL_datatable(SQL)

                For Each r In Turmas.Rows
                    myTexto20 = r("Turma")
                    myTexto30 = r("Disciplina")
                    Arq40.WriteLine(String.Format("{0};{1};", myTexto20, myTexto30))

                    ' ... CRIA AS TURMAS
                    turma = String.Format("{0}{1}\{2}", mydrive, tAno.Value, myTexto20)
                    My.Computer.FileSystem.CreateDirectory(turma)
                    ' ... FIM CRIAR AS TURMAS

                    ' ... CRIA AS DISCIPLINAS
                    Dim disciplina = String.Format("{0}{1}\{2}\{3}", mydrive, tAno.Value, myTexto20, myTexto30)
                    My.Computer.FileSystem.CreateDirectory(disciplina)
                    ' ... FIM CRIAR AS DISCIPLINAS

                    ' INICIO GRAVA ALUNOS DA TURMA...
                    If cbAlunos.Checked = True Then

                        Try

                            Dim ArqAlunos As Object = String.Format("{0}{1}\{2}\{2}a.txt", mydrive, tAno.Value,
                                                                    myTexto20)
                            Dim objStreamT As New FileStream(ArqAlunos, FileMode.Create)
                            Dim Arq As New StreamWriter(objStreamT)
                            Dim myTextoF = String.Empty
                            Dim iContador = 1
                            ' Consulta a tabela por inteiro.
                            '
                            SQL =
                                String.Format(
                                    "SELECT nro, status FROM aluno WHERE turma='{0}' AND anovigente='{1}' ORDER BY nro ASC;",
                                    r("NroTurma").ToString, tAno.Value)
                            Dim MinhaListaPiloto = MySQL_datatable(SQL)

                            ' For iContador = 1 To AlunoFinal

                            '..." Gravar NroAluno;Status
                            For Each r2 In MinhaListaPiloto.Rows

                                Dim NroAluno = r2("nro")
                                Dim Status = r2("status")

                                If iContador = NroAluno Then
                                    ' Se for Normal...
                                    myTextoF = String.Format("{0};{1};", NroAluno, Status)
                                    Arq.WriteLine(myTextoF)
                                    iContador = iContador + 1
                                Else
                                    While (iContador < NroAluno)
                                        ' Se for NC...
                                        myTextoF = String.Format("{0};NC;", iContador)
                                        Arq.WriteLine(myTextoF)
                                        iContador = iContador + 1
                                    End While

                                    myTextoF = String.Format("{0};{1};", NroAluno, Status)
                                    Arq.WriteLine(myTextoF)
                                    iContador = iContador + 1
                                End If

                            Next
                            Arq.Close()

                            'Apaga se não tiver dados...
                            Dim DadosArquivoOriginal = New FileInfo(ArqAlunos)
                            If DadosArquivoOriginal.Length = 0 Then
                                DadosArquivoOriginal.Delete()
                            End If

                        Catch ex As Exception
                            ' MsgBox(ex.Message)
                        End Try

                    End If
                    ' FIM GRAVA ALUNOS DA TURMA...
                Next
                Arq40.Close()

            Catch ex As Exception
                MsgBox("Desculpe, não foi possível criar o arquivo personalizado.", MsgBoxStyle.Information,
                       "Disco inválido!")
            End Try

        End If

        EsconderPasta()

        MsgBox("Turmas e Disciplinas gravadas com sucesso!", MsgBoxStyle.Information, "Confirmação")
    End Sub

    Private Sub frmImpBoletim2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmBMPreparar"
        ' Dim Info As New cpInfo.psInfo
        ' CONEXAOBD = Info.CarregaPreferencias

        tAno.Value = AnoVigente
        SQL = "SELECT usuario FROM usuariodsk ORDER BY usuario ASC;"
        cbProfessor.Properties.DataSource = MySQL_combobox(SQL)
        cbProfessor.Properties.DisplayMember = "usuario"
        RefreshDrive()

        Refresh_DataGrid()
    End Sub

    Private Sub lkDotNet_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
        Handles linkDotNet.LinkClicked

        MsgBox(
            "Ao desabilitar a 'Atualização Automática' do Windows," & vbCrLf &
            "o computador fica desatualizado, nesse caso, clique em OK e salve o download no pen-drive do professor.",
            MsgBoxStyle.Information, "Mais Escola!")
        Process.Start("http://morpheus.isolucao.com.br/prerequisitos/dotnetfx.zip")
    End Sub

    Private Sub rbProfessor_CheckedChanged(sender As Object, e As EventArgs) Handles rbProfessor.CheckedChanged

        If rbProfessor.Checked = True Then
            cbProfessor.Enabled = True
        Else
            cbProfessor.Enabled = False
        End If

        RefreshUsuarios()
    End Sub

    Private Sub btPreparar_Click(sender As Object, e As EventArgs) Handles btPreparar.Click

        If cbDriver.Text <> String.Empty Then
            Carregar()
        Else
            MsgBox("Escolha um drive para carregar!", MsgBoxStyle.Information, "Informação!")
        End If
    End Sub

    Private Sub cbProfessor_TextChanged(sender As Object, e As EventArgs) Handles cbProfessor.TextChanged
        Refresh_DataGrid()
        rbProfessor.Checked = True
    End Sub

    Private Sub cbDriver_TextChanged(sender As Object, e As EventArgs) Handles cbDriver.TextChanged

        mydrive = cbDriver.Text
        btPreparar.Enabled = True
    End Sub

    Private Sub cbDriver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbDriver.KeyPress
        e.Handled = False

    End Sub
End Class