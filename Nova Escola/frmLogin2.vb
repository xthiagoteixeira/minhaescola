Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net

Public Class frmLogin2
    Public Sub SalvaPreferencias()

        Try
            '// Arquivo do Boletim
            Dim objStreamE As New FileStream(meucaminhorelatorio & "\cpSystem.dll", FileMode.OpenOrCreate)
            Dim ArqME As New StreamWriter(objStreamE)

            ArqME.WriteLine(tbBD.Text)
            ArqME.WriteLine(tbIP.Text)
            ' ArqME.WriteLine(cbBanco.Text)
            ArqME.Dispose()

            MsgBox("Configurações salvas!", MsgBoxStyle.Information)
            Application.Exit()


        Catch ex As Exception
            MensagemErro("Não foi possível criar o arquivo para as preferências o sistema! - " & ex.Message, "frmLogin2", False, "Alerta")

        End Try
    End Sub

    Public Sub CriarBD(JaExiste As Boolean)

        ' CRIA BANCO DE DADOS E USUARIOS ...
        '
        Dim ConexaoCriarBD
        If JaExiste = True Then
            ConexaoCriarBD = String.Format("server={0};user id={1};password={2};", tbIP.Text, txtUsuario.Text,
                                           txtSenha.Text)
        Else
            ConexaoCriarBD = String.Format("server={0};user id=root;password=maisescola;", tbIP.Text)
        End If

        If JaExiste = False Then
            ' Checa a conexao...
            Dim conn = New MySqlConnection()
            conn.ConnectionString = ConexaoCriarBD
            Try
                conn.Open()
                Try
                    JaExiste = False
                Catch myerro As MySqlException
                    'MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
                End Try
                conn.Close()
            Catch myerro As MySqlException
                JaExiste = True
            Finally
                conn.Dispose()
            End Try

            If JaExiste = True Then
                MsgBox("O banco de dados solicita usuário e senha, favor preencher abaixo!" & vbCrLf,
                       MsgBoxStyle.Information, Sistema)
                btBD.Enabled = False
                Me.Size = New Size(463, 381)
                Exit Sub
            End If
            '
            ' Fim...
        End If

        '## Pega o arquivo mysql.sql e lê linha por linha...
        Try
            Dim atualizacao = "mysql.sql"
            Dim objStream As New FileStream(atualizacao, FileMode.Open)
            Dim Arq As New StreamReader(objStream)
            Dim linhaTexto As String

            linhaTexto = Arq.ReadLine

            While (linhaTexto <> "FIM")
                Dim LinhaSQL = String.Empty

                ' If (linhaTexto <> "DELIMITER $$") Then

                While (linhaTexto <> "COMMIT;")
                    LinhaSQL = LinhaSQL + linhaTexto
                    linhaTexto = Arq.ReadLine
                End While

                Try
                    ' NORMAL...
                    '
                    LinhaSQL = LinhaSQL.Replace("$BD", tbBD.Text)

                    Dim connection As New MySqlConnection(ConexaoCriarBD)
                    Dim cmd As New MySqlCommand(LinhaSQL, connection)

                    connection.Open()

                    cmd.ExecuteNonQuery()

                    connection.Dispose()
                    connection.Close()

                Catch ex As Exception
                End Try

                linhaTexto = Arq.ReadLine

            End While

            Arq.Dispose()
            Arq.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        '// FUNCOES...

        SQL = "DELIMITER $$ " _
               & "CREATE DEFINER=`root`@`localhost` FUNCTION `FotoAluno`(MEUNOME TEXT, MEURA INT) RETURNS blob BEGIN declare MinhaFoto blob;   SELECT file INTO MinhaFoto FROM file INNER JOIN aluno_ficha ON file.file_id = aluno_ficha.file_id WHERE NOME = MEUNOME OR RA = MEURA LIMIT 1;   RETURN MinhaFoto; END$$ " _
               & "DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$ " _
            & " CREATE FUNCTION ArquivoMorto(Procura TEXT) RETURNS varchar(45) begin     declare MeuAM varchar(45);	SELECT idAM INTO MeuAM FROM arquivomorto WHERE INSCRICAO = Procura;	IF MeuAM <> '0' THEN SET MeuAM = MeuAM; ELSE SET MeuAM = '-'; END IF;	RETURN MeuAM; END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$ " _
            & " CREATE FUNCTION ArquivoMorto_corredor(Procura TEXT) RETURNS varchar(45) begin     declare MeuAM varchar(45); 	SELECT arquivomorto_corredor.corredor INTO MeuAM FROM arquivomorto INNER JOIN arquivomorto_corredor ON arquivomorto.idAM_c = arquivomorto_corredor.idAM_c WHERE arquivomorto.INSCRICAO = Procura;	IF MeuAM <> '0' THEN SET MeuAM = MeuAM; ELSE SET MeuAM = '-'; END IF;	RETURN MeuAM; END$$  " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$ " _
            & " CREATE FUNCTION ArquivoMorto_estante(Procura TEXT) RETURNS varchar(45) begin     declare MeuAM varchar(45);	SELECT arquivomorto_estante.estante INTO MeuAM FROM arquivomorto INNER JOIN arquivomorto_estante ON arquivomorto.idAM_e = arquivomorto_estante.idAM_e WHERE arquivomorto.INSCRICAO = Procura; 	If MeuAM <> '0' THEN SET MeuAM = MeuAM; ELSE SET MeuAM = '-'; END IF;	RETURN MeuAM; END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$ " _
            & " CREATE FUNCTION ArquivoMorto_prateleira(Procura TEXT) RETURNS varchar(45) " _
            & " begin " _
            & "     declare MeuAM varchar(45); " _
            & " 	SELECT arquivomorto_prateleira.prateleira INTO MeuAM FROM arquivomorto INNER JOIN arquivomorto_prateleira ON arquivomorto.idAM_p = arquivomorto_prateleira.idAM_p WHERE arquivomorto.INSCRICAO = Procura; " _
            & " 	IF MeuAM <> '0' THEN SET MeuAM = MeuAM; ELSE SET MeuAM = '-'; END IF; " _
            & " 	RETURN MeuAM; " _
            & " END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
            & " CREATE FUNCTION BoletimCadastrado(Bimestre TEXT, MeuAnoVigente INT, MinhaTurma INT, MinhaDisciplina INT) RETURNS char(20) " _
            & " BEGIN " _
            & "    declare MeuBoletim int(10); " _
            & "    declare Resultado char(20); " _
            & "    SELECT cod_nf INTO MeuBoletim FROM notasfreq WHERE anovigente = MeuAnoVigente and cod_bimestre = Bimestre and turma = MinhaTurma AND disciplina = MinhaDisciplina; " _
            & "    IF MeuBoletim <> 0 THEN SET Resultado = 'Recebido!'; ELSE SET Resultado = 'Não recebido!'; END IF; " _
            & "    RETURN Resultado; " _
            & " END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
            & " CREATE FUNCTION Delib11Ficha(`AnoVigente` int,`TurmaNro` int,`AlunoNro` int) RETURNS int(11) " _
            & " BEGIN " _
            & "   DECLARE FichaNro INT(5); " _
            & "   SET FichaNro = 0; " _
            & "   SELECT idDelibNF INTO FichaNro FROM delib11_nf WHERE anovigente = AnoVigente AND turma = TurmaNro AND nro_aluno = AlunoNro; " _
            & "   RETURN FichaNro; " _
            & " END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
            & " CREATE FUNCTION EvasaoEscolar(codigo TEXT) RETURNS varchar(45) " _
            & " BEGIN " _
            & "            If codigo = '11' Then SET codigo = 'TR'; " _
            & " 			ElseIf codigo = '12' Then SET codigo = 'AB'; " _
            & " 			ElseIf codigo = '13' Then SET codigo = 'LS'; " _
            & " 			ElseIf codigo = '14' Then SET codigo = 'LG'; " _
            & " 			ElseIf codigo = '15' Then SET codigo = 'RE'; " _
            & " 			ElseIf codigo = '16' Then SET codigo = 'FA'; " _
            & " 			ElseIf codigo = '17' Then SET codigo = 'DI'; " _
            & " 			ElseIf codigo = '18' Then SET codigo = 'NA'; " _
            & " 			ElseIf codigo = '19' Then SET codigo = 'NC'; " _
            & " 			ElseIf codigo = '20' Then SET codigo = 'DM'; " _
            & " 			ElseIf codigo = '21' Then SET codigo = 'DT'; " _
            & " 			ElseIf codigo = '22' Then SET codigo = 'DP'; " _
            & " 			ElseIf codigo = '23' Then SET codigo = 'NF'; " _
            & " 			ElseIf codigo = '24' Then SET codigo = 'RM'; " _
            & " 			ElseIf codigo = '25' Then SET codigo = 'RC'; " _
            & " 			ElseIf codigo = '26' Then SET codigo = 'CE';  " _
            & " 			ElseIf codigo = '27' Then SET codigo = 'I';   " _
            & "             ElseIf codigo = '28' Then SET codigo = 'R'; " _
            & " 			ElseIf codigo = '29' Then SET codigo = 'B';  " _
            & " 			ElseIf codigo = '30' Then SET codigo = 'MB';  " _
            & " 			ElseIf codigo = 'TR' Or codigo = 'Tr' Or codigo = 'tr' Then SET codigo = '11'; " _
            & " 			ElseIf codigo = 'AB' Or codigo = 'Ab' Or codigo = 'ab' Then SET codigo = '12'; " _
            & " 			ElseIf codigo = 'LS' Or codigo = 'Ls' Or codigo = 'ls' Then SET codigo = '13'; " _
            & " 			ElseIf codigo = 'LG' Or codigo = 'Lg' Or codigo = 'lg' Then SET codigo = '14'; " _
            & " 			ElseIf codigo = 'RE' Or codigo = 'Re' Or codigo = 're' Then SET codigo = '15'; " _
            & " 			ElseIf codigo = 'FA' Or codigo = 'Fa' Or codigo = 'fa' Then SET codigo = '16'; " _
            & " 			ElseIf codigo = 'DI' Or codigo = 'Di' Or codigo = 'di' Then SET codigo = '17'; " _
            & " 			ElseIf codigo = 'NA' Or codigo = 'Na' Or codigo = 'na' Then SET codigo = '18'; " _
            & " 			ElseIf codigo = 'NC' Or codigo = 'Nc' Or codigo = 'nc' Then SET codigo = '19'; " _
            & " 			ElseIf codigo = 'DM' Or codigo = 'Dm' Or codigo = 'dm' Then SET codigo = '20'; " _
            & " 			ElseIf codigo = 'DT' Or codigo = 'Dt' Or codigo = 'dt' Then SET codigo = '21'; " _
            & " 			ElseIf codigo = 'DP' Or codigo = 'Dp' Or codigo = 'dp' Then SET codigo = '22'; " _
            & " 			ElseIf codigo = 'NF' Or codigo = 'Nf' Or codigo = 'nf' Then SET codigo = '23'; " _
            & "             ElseIf codigo = 'RM' Or codigo = 'Rm' Or codigo = 'rm' Then SET codigo = '24'; " _
            & " 			ElseIf codigo = 'RC' Or codigo = 'Rc' Or codigo = 'rc' Then SET codigo = '25'; " _
            & " 			ElseIf codigo = 'CE' Or codigo = 'Ce' Or codigo = 'ce' Then SET codigo = '26'; " _
            & "             ElseIf codigo = 'I' Or codigo = 'i' Then SET codigo = '27'; " _
            & " 			ElseIf codigo = 'R' Or codigo = 'r' Then SET codigo = '28'; " _
            & " 			ElseIf codigo = 'B' Or codigo = 'b' Then SET codigo = '29'; " _
            & " 			ElseIf codigo = 'MB' Or codigo = 'Mb' Or codigo = 'mb' Then SET codigo = '30'; " _
            & " 			Else SET codigo = codigo; " _
            & "             End If; " _
            & " 			RETURN codigo; " _
            & " END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
            & " CREATE FUNCTION EvasaoEscolar_Nome(codigo TEXT) RETURNS varchar(45) " _
            & " BEGIN " _
            & "             If codigo = 'TR' Then SET codigo = 'Transferido'; " _
            & "             ElseIf codigo = 'AB' Then SET codigo = 'Abandono'; " _
            & "             ElseIf codigo = 'LS' Then SET codigo = 'Licença Saúde'; " _
            & "             ElseIf codigo = 'LG' Then SET codigo = 'Licença Gestante'; " _
            & "             ElseIf codigo = 'RE' Then SET codigo = 'Reclassificado'; " _
            & "             ElseIf codigo = 'FA' Then SET codigo = 'Falecimento'; " _
            & "             ElseIf codigo = 'DI' Then SET codigo = 'Dispensa Idade'; " _
            & "             ElseIf codigo = 'NA' Then SET codigo = 'NA'; " _
            & "             ElseIf codigo = 'NC' Then SET codigo = 'Não Compareceu'; " _
            & "             ElseIf codigo = 'DM' Then SET codigo = 'Dispensa Médica'; " _
            & "             ElseIf codigo = 'DT' Then SET codigo = 'Dispensa Trabalho'; " _
            & "             ElseIf codigo = 'DP' Then SET codigo = 'Dispensa Prole'; " _
            & "             ElseIf codigo = 'NF' Then SET codigo = 'Não Frequenta'; " _
            & "             ElseIf codigo = 'RM' Then SET codigo = 'Remanejado'; " _
            & "             ElseIf codigo = 'RC' Then SET codigo = 'Reclassificado'; " _
            & "             ElseIf codigo = 'CE' Then SET codigo = 'Matrícula Cessada'; " _
            & "             ElseIf codigo = '0' Then SET codigo = 'Frequente'; " _
            & "             Else SET codigo = codigo; " _
            & "             End If; " _
            & "         	RETURN codigo; " _
            & " END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
            & " CREATE FUNCTION EvasaoEscolarConta(MeuStatus INT, MinhaTurma INT, MeuAno INT) RETURNS int(11) " _
            & " BEGIN " _
            & " 	declare Resultado INT(10); " _
            & " 	declare codigo TEXT; " _
            & " 	SET codigo=MeuStatus; " _
            & " 	If codigo = '11' Then SET codigo = 'TR'; " _
            & "               ElseIf codigo = '12' Then SET codigo = 'AB'; " _
            & "               ElseIf codigo = '13' Then SET codigo = 'LS'; " _
            & "               ElseIf codigo = '14' Then SET codigo = 'LG'; " _
            & "               ElseIf codigo = '15' Then SET codigo = 'RE'; " _
            & " 			  ElseIf codigo = '16' Then SET codigo = 'FA'; " _
            & "               ElseIf codigo = '17' Then SET codigo = 'DI'; " _
            & "               ElseIf codigo = '18' Then SET codigo = 'NA'; " _
            & "               ElseIf codigo = '19' Then SET codigo = 'NC'; " _
            & " 			  ElseIf codigo = '20' Then SET codigo = 'DM'; " _
            & " 			  ElseIf codigo = '21' Then SET codigo = 'DT'; " _
            & " 			  ElseIf codigo = '22' Then SET codigo = 'DP';  " _
            & " 			  ElseIf codigo = '23' Then SET codigo = 'NF';  " _
            & " 			  ElseIf codigo = '24' Then SET codigo = 'RM';  " _
            & " 			  ElseIf codigo = '25' Then SET codigo = 'RC';  " _
            & " 			  ElseIf codigo = '26' Then SET codigo = 'CE';     " _
            & " 			  ElseIf codigo = '27' Then SET codigo = 'I';   " _
            & " 			  ElseIf codigo = '28' Then SET codigo = 'R';   " _
            & " 			  ElseIf codigo = '29' Then SET codigo = 'B';   " _
            & " 			  ElseIf codigo = '30' Then SET codigo = 'MB';  " _
            & " 			  ElseIf codigo = 'TR' Or codigo = 'Tr' Or codigo = 'tr' Then SET codigo = '11'; " _
            & "               ElseIf codigo = 'AB' Or codigo = 'Ab' Or codigo = 'ab' Then SET codigo = '12';  " _
            & " 			  ElseIf codigo = 'LS' Or codigo = 'Ls' Or codigo = 'ls' Then SET codigo = '13';  " _
            & " 			  ElseIf codigo = 'LG' Or codigo = 'Lg' Or codigo = 'lg' Then SET codigo = '14';  " _
            & " 			  ElseIf codigo = 'RE' Or codigo = 'Re' Or codigo = 're' Then SET codigo = '15';  " _
            & " 			  ElseIf codigo = 'FA' Or codigo = 'Fa' Or codigo = 'fa' Then SET codigo = '16';  " _
            & " 			  ElseIf codigo = 'DI' Or codigo = 'Di' Or codigo = 'di' Then SET codigo = '17';  " _
            & " 			  ElseIf codigo = 'NA' Or codigo = 'Na' Or codigo = 'na' Then SET codigo = '18';  " _
            & " 			  ElseIf codigo = 'NC' Or codigo = 'Nc' Or codigo = 'nc' Then SET codigo = '19';    " _
            & " 			  ElseIf codigo = 'DM' Or codigo = 'Dm' Or codigo = 'dm' Then SET codigo = '20';  " _
            & " 			  ElseIf codigo = 'DT' Or codigo = 'Dt' Or codigo = 'dt' Then SET codigo = '21';   " _
            & " 			  ElseIf codigo = 'DP' Or codigo = 'Dp' Or codigo = 'dp' Then SET codigo = '22';  " _
            & " 			  ElseIf codigo = 'NF' Or codigo = 'Nf' Or codigo = 'nf' Then SET codigo = '23';  " _
            & " 			  ElseIf codigo = 'RM' Or codigo = 'Rm' Or codigo = 'rm' Then SET codigo = '24';   " _
            & " 			  ElseIf codigo = 'RC' Or codigo = 'Rc' Or codigo = 'rc' Then SET codigo = '25';    " _
            & " 			  ElseIf codigo = 'CE' Or codigo = 'Ce' Or codigo = 'ce' Then SET codigo = '26';     " _
            & " 			  ElseIf codigo = 'I' Or codigo = 'i' Then SET codigo = '27';  " _
            & " 			  ElseIf codigo = 'R' Or codigo = 'r' Then SET codigo = '28';  " _
            & " 			  ElseIf codigo = 'B' Or codigo = 'b' Then SET codigo = '29';    " _
            & " 			  ElseIf codigo = 'MB' Or codigo = 'Mb' Or codigo = 'mb' Then SET codigo = '30';   " _
            & " 			  Else SET codigo = codigo; " _
            & " 			  End If; " _
            & "     SELECT COUNT(status) INTO Resultado FROM aluno WHERE anovigente = MeuAno AND turma = MinhaTurma AND status = codigo; " _
            & "     RETURN Resultado; " _
            & "     END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$ " _
            & "CREATE FUNCTION Porcentagem(MeuAnoVigente INT, MeuBimestre INT, MinhaTurma INT, MeuNumero INT) RETURNS Double(10,2) " _
            & "BEGIN " _
            & " 	declare MeuResultado DOUBLE; " _
            & "  	SELECT ((SUM(b1.F))*100/SUM(n1.qtdadeaulas)) INTO MeuResultado FROM notasfreq n1, boletim b1 WHERE n1.cod_nf = b1.cod_boletim AND n1.anovigente = MeuAnoVigente AND n1.cod_bimestre = MeuBimestre AND n1.turma = MinhaTurma AND b1.nro_aluno = MeuNumero; " _
            & "  	RETURN MeuResultado; " _
            & " 	END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$ " _
            & " CREATE FUNCTION PorcentagemFinal(MeuAnoVigente INT, MinhaTurma INT, MeuNumero INT) RETURNS int(11) " _
            & " BEGIN " _
            & " 	declare MeuResultado INT; " _
            & " 	SELECT ((SUM(b1.F)-SUM(b1.AC))*100/SUM(n1.qtdadeaulas)) INTO MeuResultado FROM notasfreq n1, boletim b1 WHERE n1.cod_nf = b1.cod_boletim AND n1.anovigente = MeuAnoVigente AND (n1.cod_bimestre<>'2AF' AND n1.cod_bimestre<>'4AF') AND n1.turma = MinhaTurma AND b1.nro_aluno = MeuNumero; " _
            & " 	RETURN MeuResultado; " _
            & " END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
            & " CREATE FUNCTION QtdadeNotas(`AnoVigente` int,`TurmaNro` int,`AlunoNro` int, `Nota` int) RETURNS int(11) " _
            & " BEGIN " _
            & "    DECLARE QtdadeNotas INT(5); " _
            & "    SELECT COUNT(boletim.M) INTO QtdadeNotas FROM notasfreq INNER JOIN boletim ON notasfreq.cod_nf = boletim.cod_boletim WHERE notasfreq.anovigente = AnoVigente AND notasfreq.turma = TurmaNro AND notasfreq.cod_bimestre <> '2AF' AND notasfreq.cod_bimestre <> '4AF' AND boletim.nro_aluno = AlunoNro AND boletim.M < Nota; " _
            & "    RETURN QtdadeNotas; " _
            & " END$$ " _
            & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
        & " CREATE FUNCTION QtdadeNotas_NF(CodigoBoletim INT) RETURNS int(10) " _
        & " BEGIN " _
        & "   declare Quantidade int(10); " _
        & "   SELECT COUNT(boletim.nro_aluno) INTO Quantidade FROM boletim WHERE boletim.cod_boletim = CodigoBoletim; " _
        & "   RETURN Quantidade; " _
        & " END$$ " _
        & " DELIMITER ;"
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
        & " CREATE FUNCTION ResultadoFinal(NroAluno INT, NroTurma INT, AnoVigente INT, Bimestre TEXT) RETURNS varchar(45) " _
        & " begin " _
        & " declare RF INT(5); " _
        & " declare Resultado varchar(45); " _
        & "    SELECT SUM(CASE WHEN boletim.M<5 OR boletim.M>10 THEN 1 ELSE 0 END) INTO RF FROM boletim INNER JOIN notasfreq ON boletim.cod_boletim = notasfreq.cod_nf WHERE notasfreq.cod_bimestre = Bimestre AND boletim.nro_aluno = NroAluno And notasfreq.turma = NroTurma And notasfreq.anovigente = AnoVigente;" _
        & "    If RF = 0 Then Set Resultado = 'APROVADO';   else SET Resultado = 'REPROVADO';   end if; " _
        & "    RETURN Resultado; " _
        & " END$$ " _
        & " DELIMITER ; "
        MySQL_atualiza_funcao(SQL)

        SQL = "DELIMITER $$  " _
        & " CREATE FUNCTION RM(MEURA INT, MEURADIGITO TEXT) RETURNS varchar(45) " _
        & " begin " _
        & "    declare MeuRM varchar(45); " _
        & "    SELECT CODIGO INTO MeuRM FROM aluno_ficha WHERE ra = MEURA and ra_digito = MEURADIGITO LIMIT 1; " _
        & "    IF MeuRM <> 0 THEN SET MeuRM = MeuRM; ELSE SET MeuRM = '-'; END IF; " _
        & "    RETURN MeuRM; " _
        & " END$$ " _
        & " DELIMITER ; "
        MySQL_atualiza_funcao(SQL)
        '\\ FIM DA FUNCOES...

        MsgBox("O banco de dados foi criado com sucesso!", MsgBoxStyle.Information)
        '
        '########### FIM ATUALIZA BANCO...
        '
        SalvaPreferencias()
    End Sub

    Private Sub rbLocal_CheckedChanged(sender As Object, e As EventArgs) Handles rbLocal.CheckedChanged

        If rbLocal.Checked = True Then
            tbIP.Enabled = False
            tbIP.Text = "localhost"
        End If

        If rbIntranet.Checked = True Then
            tbIP.Enabled = True
            tbIP.Text = String.Empty
        End If
    End Sub

    Private Sub frmLogin2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (My.Computer.FileSystem.DirectoryExists(meucaminhorelatorio) = False) Then
            'CRIA AS DIRETORIO ANO !
            Try
                My.Computer.FileSystem.CreateDirectory(meucaminhorelatorio)
            Catch ex As Exception
            End Try
            ' FIM CRIAR DIRETORIO ANO
        End If


        Preferencias = CarregaPreferencias2()

        Try
            tbBD.Text = Preferencias(0)
            tbIP.Text = Preferencias(1)
            ' cbBanco.Text = BANCO
        Catch ex As Exception
        End Try

        If tbIP.Text = "localhost" Then
            rbLocal.Checked = True
            rbIntranet.Checked = False
            tbIP.Enabled = False
        Else
            rbLocal.Checked = False
            rbIntranet.Checked = True
            tbIP.Enabled = True
        End If


        If tbBD.Text = String.Empty And tbIP.Text = String.Empty Then
            btConfirma.Enabled = False
        Else
            btConfirma.Enabled = True
        End If
    End Sub

    Private Sub btConfirma_Click(sender As Object, e As EventArgs) Handles btConfirma.Click

        If tbIP.Text <> "localhost" Then

            ' TENTA PEGAR O NOME DO COMPUTADOR
            Try
                Dim strIPAddress As String = tbIP.Text
                Dim host As IPHostEntry = Dns.GetHostEntry(strIPAddress)
                tbIP.Text = host.HostName
            Catch ex As Exception
                MsgBox("Não foi possível obter o nome do servidor!", MsgBoxStyle.Information)
            End Try

        End If
        SalvaPreferencias()
    End Sub

    Private Sub btBD_Click(sender As Object, e As EventArgs) Handles btBD.Click

        If tbBD.Text <> String.Empty Or tbIP.Text <> String.Empty Then
            CriarBD(False)
        Else
            MsgBox("Preencha os dados do Sistema!", MsgBoxStyle.Information, Sistema)
        End If
    End Sub

    Private Sub btBD2_Click(sender As Object, e As EventArgs) Handles btBD2.Click

        If tbBD.Text <> String.Empty Or tbIP.Text <> String.Empty Then
            CriarBD(True)
        Else
            MsgBox("Preencha os dados do Sistema!", MsgBoxStyle.Information, Sistema)
        End If
    End Sub

    Private Sub tbBD_LostFocus(sender As Object, e As EventArgs) Handles tbBD.LostFocus
        If tbBD.Text = String.Empty And tbIP.Text = String.Empty Then
            btConfirma.Enabled = False
            btBD.Enabled = False
        Else
            btConfirma.Enabled = True
            btBD.Enabled = True
        End If
    End Sub

    Private Sub tbIP_LostFocus(sender As Object, e As EventArgs) Handles tbIP.LostFocus
        If tbBD.Text = String.Empty And tbIP.Text = String.Empty Then
            btConfirma.Enabled = False
        Else
            btConfirma.Enabled = True
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ' Crystal
        '
        Try
            Process.Start("http://app.thiagoteixeira.com.br/arquivos/CRRuntime_64bit_13_0_26.zip")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' MySQL
        '
        Try
            Process.Start("http://app.thiagoteixeira.com.br/arquivos/mysql-installer-community-8.0.20.0.msi")
        Catch ex As Exception
        End Try

    End Sub
End Class