Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data
Imports System

Public Class frmLogin2

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
 
    Dim mybd = 0
    Dim SQL

    Public Function CriarBD(ByVal JaExiste As Boolean)

        ' CRIA BANCO DE DADOS E USUARIOS
        Dim conn2 As MySqlConnection
        conn2 = New MySqlConnection()

        If JaExiste = True Then
            conn2.ConnectionString = "server=" & tbIP.Text & ";user id=" & txtUsuario.Text & ";password=" & txtSenha.Text & ""
        Else
            conn2.ConnectionString = "server=" & tbIP.Text & ";user id=root;password=maisescola"
        End If

        Try
            conn2.Open()
            If JaExiste = False Then
                Try
                    SQL = "SET PASSWORD FOR 'root'@'localhost' = PASSWORD('adm2wer435mt');"
                    myCommand.Connection = conn2
                    myCommand.CommandText = SQL
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myData)
                Catch myerro As MySqlException
                End Try
            End If

            Try
                SQL = "CREATE USER 'admsuporte'@'%' IDENTIFIED BY 'admauxcli';"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE USER 'admisolucao'@'%' IDENTIFIED BY 'adm2td987as';"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE DATABASE " & tbBD.Text & ";"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "GRANT ALL PRIVILEGES ON *.* TO 'admisolucao'@'%' WITH GRANT OPTION MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "GRANT SELECT , INSERT , UPDATE , DELETE ON " & tbBD.Text & ".* TO 'admsuporte'@'%' IDENTIFIED BY 'admauxcli' WITH GRANT OPTION MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE TABLE " & tbBD.Text & ".boletim (`cod_boletim` int(10) unsigned default NULL, `nro_aluno` int(10) unsigned default NULL, `M` int(5) default NULL, `F` int(10) unsigned default '0', `AC` int(10) unsigned default '0', `S` varchar(3) default 'N', `codigo` int(10) unsigned NOT NULL auto_increment, `porcentagem` int(10) unsigned default '0', PRIMARY KEY  (`codigo`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE TABLE " & tbBD.Text & ".disciplinas (`codigo_disc` int(10) unsigned NOT NULL auto_increment, `disciplina` varchar(45) NOT NULL, `qtdadeaulas` int(10) unsigned default '0', PRIMARY KEY  (`codigo_disc`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE TABLE " & tbBD.Text & ".notasfreq (`cod_nf` int(10) unsigned NOT NULL auto_increment, `cod_bimestre` char(3) character set ucs2 collate ucs2_bin default NULL, `turma` int(10) unsigned NOT NULL, `disciplina` int(10) unsigned NOT NULL, `anovigente` int(10) unsigned default '0', `qtdadeaulas` int(10) unsigned default '0', `previsaoaulas` int(10) unsigned default '0', PRIMARY KEY  (`cod_nf`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE TABLE " & tbBD.Text & ".aluno (`codigo_aluno` int(10) unsigned NOT NULL auto_increment, `nome` varchar(45) default '0', `ra` varchar(25) default '0', `turma` int(10) unsigned default '0', `anovigente` int(10) unsigned default '0', `nro` int(10) unsigned default '0', `data` varchar(15) default '0', `bf` tinyint(3) unsigned default '0', `status` varchar(5) default '0', PRIMARY KEY  USING BTREE (`codigo_aluno`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE TABLE " & tbBD.Text & ".turma (`codigo_trma` int(10) unsigned NOT NULL auto_increment, `classe` varchar(45) NOT NULL, `periodo` varchar(20) NOT NULL, `total_alunos` int(10) unsigned NOT NULL, `bloqueado` tinyint(1) default '0', `fundamental` tinyint(1) default '0', `anovigente` int(10) unsigned NOT NULL, PRIMARY KEY  (`codigo_trma`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE TABLE " & tbBD.Text & ".usuariodsk (`usuario` varchar(20) NOT NULL, `senha` varchar(20) NOT NULL, `cod_prof` int(10) unsigned NOT NULL, `codigo` int(10) unsigned NOT NULL auto_increment, PRIMARY KEY  (`codigo`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE TABLE " & tbBD.Text & ".escola (`idescola` int(10) unsigned NOT NULL AUTO_INCREMENT, `nome` varchar(45) NOT NULL, `de` varchar(45) NOT NULL, PRIMARY KEY (`idescola`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "CREATE TABLE " & tbBD.Text & ".notasfreq_prof ( " _
                        & "idnfp int(10) unsigned NOT NULL AUTO_INCREMENT, " _
                        & "data_lancamento date NOT NULL, " _
                        & "grupo int(10) unsigned NOT NULL, " _
                        & "cod_nf int(10) unsigned NOT NULL, " _
                        & "PRIMARY KEY (idnfp)); "
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch myerro As MySqlException
            End Try



            '*********************OS INSERTS PADROES*************************
            Try
                SQL = "INSERT INTO " & tbBD.Text & ".turma (`codigo_trma`,`classe`,`periodo`,`total_alunos`,`anovigente`,`bloqueado`,`fundamental`) VALUES  (1,'2a série A','Manhã',4," & Format(Date.Now, "yyyy") & ",0,1), (2,'3a série A','Manhã',35," & Format(Date.Now, "yyyy") & ",0,1), (3,'4a série A','Manhã',13," & Format(Date.Now, "yyyy") & ",0,1), (4,'5a série A','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (5,'6a série A','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (6,'7a série A','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (7,'8a série A','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (8,'2a série B','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (9,'3a série B','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (10,'4a série B','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (11,'5a série B','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (12,'6a série B','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (13,'7a série B','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (14,'8a série B','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (15,'2a série C','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (16,'3a série C','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (17,'4a série C','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (18,'5a série C','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (19,'6a série C','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (20,'7a série C','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (21,'8a série C','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (22,'2a série D','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (23,'3a série D','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1);"
                atualizaMySQL(SQL)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "INSERT INTO " & tbBD.Text & ".turma (`codigo_trma`,`classe`,`periodo`,`total_alunos`,`anovigente`,`bloqueado`,`fundamental`) VALUES  (24,'4a série D','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (25,'5a série D','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (26,'6a série D','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (27,'7a série D','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (28,'8a série D','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (29,'2a série E','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (30,'3a série E','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (31,'4a série E','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (32,'5a série E','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (33,'6a série E','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (34,'7a série E','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (35,'8a série E','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (36,'1a série A - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (37,'1a série B - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (38,'1a série C - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (39,'1a série D - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (40,'1a série E - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (41,'2a série A - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (42,'2a série B - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (43,'2a série C - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (44,'2a série D - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (45,'2a série E - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0);"
                atualizaMySQL(SQL)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "INSERT INTO " & tbBD.Text & ".turma (`codigo_trma`,`classe`,`periodo`,`total_alunos`,`anovigente`,`bloqueado`,`fundamental`) VALUES  (46,'3a série A - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (47,'3a série B - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (48,'3a série C - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (49,'3a série D - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (50,'3a série E - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (51,'1a série F - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (52,'1a série G - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (53,'2a série F - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (54,'3a série F - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (55,'3a série G - EM','Manhã',40," & Format(Date.Now, "yyyy") & ",0,0), (56,'1a série A','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (57,'1a série B','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (58,'1a série C','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (59,'1a série D','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (60,'1a série E','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (61,'1a série F','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (62,'1a série G','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (63,'1a série H','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (64,'1a série I','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (65,'1a série J','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (66,'1a série K','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1);"
                atualizaMySQL(SQL)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "INSERT INTO " & tbBD.Text & ".turma (`codigo_trma`,`classe`,`periodo`,`total_alunos`,`anovigente`,`bloqueado`,`fundamental`) VALUES  (67,'2a série F','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (68,'2a série G','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (69,'2a série H','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (70,'2a série I','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (71,'2a série J','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (72,'2a série K','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (73,'3a série F','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (74,'3a série G','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (75,'3a série H','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (76,'3a série I','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (77,'3a série J','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (78,'3a série K','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (79,'4a série F','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (80,'4a série G','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (81,'4a série H','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (82,'4a série I','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (83,'4a série J','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1), (84,'4a série K','Manhã',40," & Format(Date.Now, "yyyy") & ",0,1);"
                atualizaMySQL(SQL)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "INSERT INTO " & tbBD.Text & ".disciplinas (`codigo_disc`,`disciplina`,`qtdadeaulas`) VALUES (1,'Matemática',22), (2,'Português',7), (3,'Geografia',22), (4,'Física',22), (5,'Química',22), (6,'Inglês',22), (7,'Ciências',0), (8,'Ed. Artística',0), (9,'Ed. Física',0), (10,'Leitura',0), (11,'Biologia',0), (12,'Filosofia',0), (13,'Estudos Sociais',0), (14,'Iniciação a Ciência',0), (15,'História',0), (16,'Sociologia',0), (17,'Psicologia',0), (18,'Ensino Religioso',0), (19,'Arte',0);"
                atualizaMySQL(SQL)
            Catch myerro As MySqlException
            End Try
            Try
                SQL = "INSERT INTO " & tbBD.Text & ".usuariodsk (`usuario`,`senha`,`cod_prof`,`codigo`) VALUES ('suporte','suporte" & Format(Date.Now, "yyyy") & "s',0,1), ('admin','admin" & Format(Date.Now, "yyyy") & "a',0,2), ('maisescola','maisescola',1,3);"
                atualizaMySQL(SQL)
            Catch myerro As MySqlException
            End Try

            Try
                SQL = "INSERT INTO " & tbBD.Text & ".escola (`idescola`,`nome`,`de`) VALUES (1,'E E iSolucao Informatica','DIRETORIA DE ENSINO DE RIBEIRAO PRETO');"
                atualizaMySQL(SQL)
            Catch myerro As MySqlException
            End Try

            '############## INICIO DE ATUALIZACOES...
            '

            'ATUALIZA BANCO...
            Try
                myData.Clear()
                SQL = "ALTER TABLE " & BD_OK & ".disciplinas ADD COLUMN bloqueado TINYINT UNSIGNED NOT NULL AFTER qtdadeaulas;"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch ex As Exception
            End Try

            Try
                myData.Clear()
                SQL = "ALTER TABLE " & BD_OK & ".disciplinas MODIFY COLUMN bloqueado TINYINT(3) UNSIGNED NOT NULL DEFAULT 0;"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch ex As Exception
            End Try

            Try
                ' # CRIAR TABELAS PARA QUEM ATUALIZAR APENAS!!
                myData.Clear()
                SQL = "CREATE TABLE " & BD_OK & ".notasfreq_prof ( " _
                        & "`idnfp` int(10) unsigned NOT NULL AUTO_INCREMENT, " _
                        & "`data_lancamento` date NOT NULL, " _
                        & "`grupo` int(10) unsigned NOT NULL, " _
                        & "`cod_nf` int(10) unsigned NOT NULL, " _
                        & "PRIMARY KEY (`idnfp`)); "
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch ex As Exception
            End Try

            Try
                myData.Clear()
                ' # CRIAR TABELAS PARA QUEM ATUALIZAR APENAS!!
                SQL = "CREATE TABLE " & BD_OK & ".bolsas ( " _
                    & "`idbolsas` int(10) unsigned NOT NULL AUTO_INCREMENT, " _
                    & "`nro` int(10) unsigned NOT NULL, " _
                    & "`codigo_trma` int(10) unsigned NOT NULL, " _
                    & "`ano` int(10) unsigned NOT NULL, " _
                    & "`tipo` varchar(4) NOT NULL, " _
                    & "`bimestre` char(3) DEFAULT '0', " _
                    & "`porcentagem` int(10) unsigned DEFAULT '0', " _
                    & "PRIMARY KEY (`idbolsas`)); "
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch ex As Exception
            End Try

            Try
                myData.Clear()
                ' # CRIAR TABELAS PARA QUEM ATUALIZAR APENAS!!
                SQL = "CREATE TABLE " & BD_OK & ".aluno_ficha ( " _
                    & "  `INSCRICAO` DOUBLE NOT NULL AUTO_INCREMENT, " _
                    & "  `CODIGO` INTEGER(11) DEFAULT '0', " _
                    & "  `NOME` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `RG_NUM` VARCHAR(20) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `RG_UF` VARCHAR(2) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `SEXO` VARCHAR(1) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `DT_NASC` DATE DEFAULT '0000-00-00', " _
                    & "  `ENDERECO` VARCHAR(100) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `NUMERO` VARCHAR(4) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `APTO` VARCHAR(10) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `BAIRRO` VARCHAR(100) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `CIDADE` VARCHAR(100) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `UF` VARCHAR(2) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `CEP` VARCHAR(10) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `DDD` VARCHAR(4) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `FONE` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `RAMAL` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `PAI` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `MAE` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `CTNASC` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `FICHA` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `ANO` INTEGER(10) UNSIGNED DEFAULT '0', " _
                    & "  `MODU` VARCHAR(10) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `CURSO` VARCHAR(10) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `NUM` INTEGER(10) UNSIGNED DEFAULT '0', " _
                    & "  `Status_Matricula` VARCHAR(1) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `Motivo_Desistencia` VARCHAR(150) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `Data_Desistencia` DATE DEFAULT '0000-00-00', " _
                    & "  `Escola_Transferencia` VARCHAR(150) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `Periodo` VARCHAR(1) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `Certidao_Nascimento` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `Livro` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `Folhas` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT '0', " _
                    & "  `Data_Matricula` DATE DEFAULT '0000-00-00', " _
                    & "  PRIMARY KEY (`INSCRICAO`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch ex As Exception
            End Try

            Try
                myData.Clear()
                ' # CRIAR TABELAS PARA QUEM ATUALIZAR APENAS!!
                SQL = "CREATE TABLE " & BD_OK & ".aluno_ficha_complemento ( " _
                        & "  `Codigo` INTEGER(11) DEFAULT NULL, " _
                        & "  `Curso` VARCHAR(10) COLLATE latin1_swedish_ci DEFAULT NULL, " _
                        & "  `Ano` INTEGER(11) DEFAULT NULL, " _
                        & "  `Num` INTEGER(11) DEFAULT NULL, " _
                        & "  `Obs` VARCHAR(200) COLLATE latin1_swedish_ci DEFAULT NULL, " _
                        & "  `Identidade` INTEGER(11) DEFAULT NULL, " _
                        & "  `Observacao` VARCHAR(200) COLLATE latin1_swedish_ci DEFAULT NULL, " _
                        & "  `Data` DATETIME DEFAULT NULL, " _
                        & "  `Ja_Recebeu_Livro` VARCHAR(1) COLLATE latin1_swedish_ci DEFAULT NULL, " _
                        & "  `idCodigo` INTEGER(10) UNSIGNED NOT NULL AUTO_INCREMENT, " _
                        & "  PRIMARY KEY (`idCodigo`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch ex As Exception
            End Try

            Try
                myData.Clear()
                ' # CRIAR TABELAS PARA QUEM ATUALIZAR APENAS!!
                SQL = "CREATE TABLE " & BD_OK & ".tempDeclaracao (" _
                    & " `idDec` int(10) unsigned NOT NULL AUTO_INCREMENT, " _
                    & "  `idDeclaracao` int(10) unsigned  DEFAULT NULL, " _
                    & "`nome` varchar(45) DEFAULT NULL, " _
                    & "  `horarioINICIO` varchar(8) DEFAULT NULL, " _
                    & "  `horarioFIM` varchar(8) DEFAULT NULL, " _
                    & " `op1` varchar(3) DEFAULT NULL, " _
                    & " `op2` varchar(3) DEFAULT NULL, " _
                    & " `op3` varchar(3) DEFAULT NULL, " _
                    & " `op4` varchar(3) DEFAULT NULL, " _
                    & " `op5` varchar(3) DEFAULT NULL, " _
                    & " `op6` varchar(3) DEFAULT NULL, " _
                    & " `op7` varchar(3) DEFAULT NULL, " _
                    & " `op8` varchar(3) DEFAULT NULL, " _
                    & " `ra` varchar(20) DEFAULT NULL, " _
                    & "  PRIMARY KEY (`idDec`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
            Catch ex As Exception
            End Try
            'FIM ATUALIZA BANCO...


            '
            '############## ESPACO PARA ATUALIZACOES...
            conn2.Close()
        Catch myerro2 As MySqlException
            MsgBox("O banco de dados solicita usuário e senha, favor preencher abaixo!" & vbCrLf, MsgBoxStyle.Information, "Mais Escola")
            mybd = 1
            btBD.Enabled = False
            Me.Size = New System.Drawing.Size(463, 370)
            conn2.Dispose()
            conn2.Close()
            Exit Function
        Finally
            conn2.Dispose()
        End Try
        ' FIM DA CONEXAO
        MsgBox("Concluído com sucesso!", MsgBoxStyle.Information)
        Me.Close()

    End Function
    Private Sub rbLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLocal.CheckedChanged
        If rbLocal.Checked = True Then
            tbIP.Enabled = False
            tbIP.Text = "localhost"
        End If

        If rbIntranet.Checked = True Then
            tbIP.Enabled = True
            tbIP.Text = ""
        End If

    End Sub

    Private Sub frmLogin2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("System.Windows.Net.Conexao")
            myRegKey2 = myRegKey2.OpenSubKey("Classe")
            Dim BD As Object = myRegKey2.GetValue("bd")
            Dim IP As Object = myRegKey2.GetValue("ip")
            Dim URL As Object = myRegKey2.GetValue("site")
            Dim REVENDA As Object = myRegKey2.GetValue("revenda")
            Dim FONE As Object = myRegKey2.GetValue("fone")


            If BD IsNot DBNull.Value Then
                tbBD.Text = BD
            End If

            If IP IsNot DBNull.Value Then
                tbIP.Text = IP
            End If

            If URL IsNot DBNull.Value Then
                tbSite.Text = URL
            End If

            If REVENDA IsNot DBNull.Value Then
                tbRevenda.Text = REVENDA
            End If

            If FONE IsNot DBNull.Value Then
                tbFone.Text = FONE
            End If

        Catch ex As Exception
        End Try


        If tbIP.Text = "localhost" Then

            rbLocal.Checked = True
            rbIntranet.Checked = False

        Else
            rbLocal.Checked = False
            rbIntranet.Checked = True

        End If

    End Sub

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click

        Try
            Dim bd, ip, imagem, revenda, site, fone
            ' REGISTRA O CODIGO SECRETO EM UM LUGAR SEGURO
            Dim csRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("System.Windows.Net.Conexao")
            csRegistryKey = csRegistryKey.CreateSubKey("Classe")
            '''''''''''''''''''''''''''''''''''''''''''''''
            'RETIRAR APENAS ALGUNS NUMEROS PARA CODIFICAR E DESCODIFICAR
            ip = tbIP.Text
            bd = tbBD.Text
            revenda = tbRevenda.Text
            site = tbSite.Text
            fone = tbFone.Text

            If rbLocal.Checked = True Then
                imagem = "1"
                csRegistryKey.SetValue("x", "" & imagem)
            End If

            If rbIntranet.Checked = True Then
                imagem = "2"
                csRegistryKey.SetValue("x", "" & imagem)
            End If

            'If rbInternet.Checked = True Then
            '    imagem = "3"
            '    csRegistryKey.SetValue("x", "" & imagem)
            'End If

            csRegistryKey.SetValue("bd", "" & bd)
            csRegistryKey.SetValue("ip", "" & ip)
            csRegistryKey.SetValue("revenda", "" & revenda)
            csRegistryKey.SetValue("site", "" & site)
            csRegistryKey.SetValue("fone", "" & fone)

            MsgBox("Concluído com sucesso!", MsgBoxStyle.Information)

            Me.Close()

        Catch ex As Exception
            MsgBox("Não foi possível gravar no registro!" & vbCrLf & "Desabilite o UAC do Windows (msconfig)!", MsgBoxStyle.Critical, "Atenção!")

        End Try

    End Sub

    Private Sub btBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBD.Click

        myData.Clear()

        If mybd = 0 Then

            If Not (tbBD.Text = "" And tbIP.Text = "") Then
                CriarBD(False)
            Else
                MsgBox("Favor, colocar o Nome do Banco de Dados e o IP.")
            End If
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btBD2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBD2.Click

        If (txtUsuario.Text = "" Or txtSenha.Text = "") Then
            MsgBox("Favor, verificar os campos!", MsgBoxStyle.Information)
        Else
            ''Ja existe o Banco de Dados...
            '
            CriarBD(True)

        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()

    End Sub
End Class