Imports MySql.Data.MySqlClient
Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLogin2

    Dim myCommand As New MySqlCommand()
    Dim myAdapter As New MySqlDataAdapter()
    Dim myData As New DataTable()
 

    Dim r As DataRow
    Dim rc As Integer
    Dim SQL As String
    Dim BD_OK, IP_OK, imagem_OK

    Private Sub rbLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLocal.CheckedChanged
        If rbLocal.Checked = True Then
            tbIP.Enabled = False
            tbIP.Text = "127.0.0.1"
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

            If BD IsNot DBNull.Value Then
                tbBD.Text = BD
            End If

            If IP IsNot DBNull.Value Then
                tbIP.Text = IP
            End If

        Catch ex As Exception
        End Try


        If tbIP.Text <> "127.0.0.1" Then

            rbIntranet.Checked = True

        End If

        ' TROCA A SENHA INICIAL
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;password=novaescola"

        Try
            conn.Open()
            Try
                SQL = "SET PASSWORD FOR 'root'@'localhost' = PASSWORD('adm2wer435mt');"
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "SET PASSWORD FOR 'root'@'%' = PASSWORD('adm2wer435mt');"
                myCommand.Connection = conn
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

            Catch myerro As MySqlException
                '      MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            '  MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try
        ' FIM DA CONEXAO

        ' TROCA A SENHA INICIAL
        Dim conn2 As MySqlConnection
        conn2 = New MySqlConnection()
        conn2.ConnectionString = "server=" & IP_OK & ";user id=root;password=adm2wer435mt"

        Try
            conn2.Open()
            Try
                SQL = "CREATE USER 'admsuporte'@'%' IDENTIFIED BY 'admauxcli';"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "GRANT ALL PRIVILEGES ON *.* TO 'admsuporte'@'%' IDENTIFIED BY 'admauxcli' WITH GRANT OPTION MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE DATABASE novaescola;"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.avaliacaofinal (`cod_af` int(10) unsigned NOT NULL auto_increment, `cod_nf` int(10) unsigned NOT NULL, `nro_aluno` int(10) unsigned NOT NULL, `S` varchar(3) default '0', `M` varchar(45) default '0', `descricao` varchar(45) default '0', PRIMARY KEY  (`cod_af`) );"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.boletim (`cod_boletim` int(10) unsigned default NULL, `nro_aluno` int(10) unsigned default NULL, `M` int(5) default NULL, `F` int(10) unsigned default '0', `AC` int(10) unsigned default '0', `S` varchar(3) default 'N', `codigo` int(10) unsigned NOT NULL auto_increment, `porcentagem` int(10) unsigned default '0', PRIMARY KEY  (`codigo`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.codigobarras (`cod_cb` int(10) unsigned NOT NULL auto_increment, `cod_nf` int(10) unsigned NOT NULL, `nro_aluno` int(10) unsigned NOT NULL, `descricao` varchar(18) NOT NULL default '0', PRIMARY KEY  (`cod_cb`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.codigobarras2 (`cod_cb` int(10) unsigned NOT NULL auto_increment, `cod_nf` int(10) unsigned NOT NULL, `nro_aluno` int(10) unsigned NOT NULL, `descricao` varchar(18) NOT NULL default '0', PRIMARY KEY  (`cod_cb`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.disciplinas (`codigo_disc` int(10) unsigned NOT NULL auto_increment, `disciplina` varchar(45) NOT NULL, `qtdadeaulas` int(10) unsigned default '0', PRIMARY KEY  (`codigo_disc`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.notasfreq (`cod_nf` int(10) unsigned NOT NULL auto_increment, `cod_bimestre` int(10) unsigned NOT NULL, `turma` int(10) unsigned NOT NULL, `disciplina` int(10) unsigned NOT NULL, `anovigente` int(10) unsigned default '0', `qtdadeaulas` int(10) unsigned default '0', `previsaoaulas` int(10) unsigned default '0', PRIMARY KEY  (`cod_nf`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.aluno (`codigo_aluno` int(10) unsigned NOT NULL auto_increment, `nome` varchar(45) default '0', `ra` varchar(25) default '0', `turma` int(10) unsigned default '0', `anovigente` int(10) unsigned default '0', `nro` int(10) unsigned default '0', `data` varchar(15) default '0', PRIMARY KEY  USING BTREE (`codigo_aluno`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.turma (`codigo_trma` int(10) unsigned NOT NULL auto_increment, `classe` varchar(45) NOT NULL, `periodo` varchar(20) NOT NULL, `total_alunos` int(10) unsigned NOT NULL, `bloqueado` tinyint(1) default '0', `fundamental` tinyint(1) default '0', `anovigente` int(10) unsigned NOT NULL, PRIMARY KEY  (`codigo_trma`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "CREATE TABLE novaescola.usuariodsk (`usuario` varchar(20) NOT NULL, `senha` varchar(20) NOT NULL, `cod_prof` int(10) unsigned NOT NULL, `codigo` int(10) unsigned NOT NULL auto_increment, PRIMARY KEY  (`codigo`));"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                '*********************OS INSERTS PADROES*************************
                SQL = "INSERT INTO novaescola.turma (`codigo_trma`,`classe`,`periodo`,`total_alunos`,`anovigente`,`bloqueado`,`fundamental`) VALUES  (1,'2a série A','Manhã',4,2007,0,1), (2,'3a série A','Manhã',35,2007,0,1), (3,'4a série A','Manhã',13,2007,0,1), (4,'5a série A','Manhã',40,2007,0,0), (5,'6a série A','Manhã',40,2007,0,0), (6,'7a série A','Manhã',40,2007,0,0), (7,'8a série A','Manhã',40,2007,0,0), (8,'2a série B','Manhã',40,2007,0,1), (9,'3a série B','Manhã',40,2007,0,1), (10,'4a série B','Manhã',40,2007,0,1), (11,'5a série B','Manhã',40,2007,0,0), (12,'6a série B','Manhã',40,2007,0,0), (13,'7a série B','Manhã',40,2007,0,0), (14,'8a série B','Manhã',40,2007,0,0), (15,'2a série C','Manhã',40,2007,0,1), (16,'3a série C','Manhã',40,2007,0,1), (17,'4a série C','Manhã',40,2007,0,1), (18,'5a série C','Manhã',40,2007,0,0), (19,'6a série C','Manhã',40,2007,0,0), (20,'7a série C','Manhã',40,2007,0,0), (21,'8a série C','Manhã',40,2007,0,0), (22,'2a série D','Manhã',40,2007,0,1), (23,'3a série D','Manhã',40,2007,0,1);"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "INSERT INTO novaescola.turma (`codigo_trma`,`classe`,`periodo`,`total_alunos`,`anovigente`,`bloqueado`,`fundamental`) VALUES  (24,'4a série D','Manhã',40,2007,0,1), (25,'5a série D','Manhã',40,2007,0,0), (26,'6a série D','Manhã',40,2007,0,0), (27,'7a série D','Manhã',40,2007,0,0), (28,'8a série D','Manhã',40,2007,0,0), (29,'2a série E','Manhã',40,2007,0,1), (30,'3a série E','Manhã',40,2007,0,1), (31,'4a série E','Manhã',40,2007,0,1), (32,'5a série E','Manhã',40,2007,0,0), (33,'6a série E','Manhã',40,2007,0,0), (34,'7a série E','Manhã',40,2007,0,0), (35,'8a série E','Manhã',40,2007,0,0), (36,'1a série A - EM','Manhã',40,2007,0,0), (37,'1a série B - EM','Manhã',40,2007,0,0), (38,'1a série C - EM','Manhã',40,2007,0,0), (39,'1a série D - EM','Manhã',40,2007,0,0), (40,'1a série E - EM','Manhã',40,2007,0,0), (41,'2a série A - EM','Manhã',40,2007,0,0), (42,'2a série B - EM','Manhã',40,2007,0,0), (43,'2a série C - EM','Manhã',40,2007,0,0), (44,'2a série D - EM','Manhã',40,2007,0,0), (45,'2a série E - EM','Manhã',40,2007,0,0);"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "INSERT INTO novaescola.turma (`codigo_trma`,`classe`,`periodo`,`total_alunos`,`anovigente`,`bloqueado`,`fundamental`) VALUES  (46,'3a série A - EM','Manhã',40,2007,0,0), (47,'3a série B - EM','Manhã',40,2007,0,0), (48,'3a série C - EM','Manhã',40,2007,0,0), (49,'3a série D - EM','Manhã',40,2007,0,0), (50,'3a série E - EM','Manhã',40,2007,0,0), (51,'1a série F - EM','Manhã',40,2007,0,0), (52,'1a série G - EM','Manhã',40,2007,0,0), (53,'2a série F - EM','Manhã',40,2007,0,0), (54,'3a série F - EM','Manhã',40,2007,0,0), (55,'3a série G - EM','Manhã',40,2007,0,0), (56,'1a série A','Manhã',40,2007,0,1), (57,'1a série B','Manhã',40,2007,0,1), (58,'1a série C','Manhã',40,2007,0,1), (59,'1a série D','Manhã',40,2007,0,1), (60,'1a série E','Manhã',40,2007,0,1), (61,'1a série F','Manhã',40,2007,0,1), (62,'1a série G','Manhã',40,2007,0,1), (63,'1a série H','Manhã',40,2007,0,1), (64,'1a série I','Manhã',40,2007,0,1), (65,'1a série J','Manhã',40,2007,0,1), (66,'1a série K','Manhã',40,2007,0,1);"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "INSERT INTO novaescola.turma (`codigo_trma`,`classe`,`periodo`,`total_alunos`,`anovigente`,`bloqueado`,`fundamental`) VALUES  (67,'2a série F','Manhã',40,2007,0,1), (68,'2a série G','Manhã',40,2007,0,1), (69,'2a série H','Manhã',40,2007,0,1), (70,'2a série I','Manhã',40,2007,0,1), (71,'2a série J','Manhã',40,2007,0,1), (72,'2a série K','Manhã',40,2007,0,1), (73,'3a série F','Manhã',40,2007,0,1), (74,'3a série G','Manhã',40,2007,0,1), (75,'3a série H','Manhã',40,2007,0,1), (76,'3a série I','Manhã',40,2007,0,1), (77,'3a série J','Manhã',40,2007,0,1), (78,'3a série K','Manhã',40,2007,0,1), (79,'4a série F','Manhã',40,2007,0,1), (80,'4a série G','Manhã',40,2007,0,1), (81,'4a série H','Manhã',40,2007,0,1), (82,'4a série I','Manhã',40,2007,0,1), (83,'4a série J','Manhã',40,2007,0,1), (84,'4a série K','Manhã',40,2007,0,1);"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "INSERT INTO novaescola.disciplinas (`codigo_disc`,`disciplina`,`qtdadeaulas`) VALUES (1,'Matemática',22), (2,'Português',7), (3,'Geografia',22), (4,'Física',22), (5,'Química',22), (6,'Inglês',22), (7,'Ciências',0), (8,'Ed. Artística',0), (9,'Ed. Física',0), (10,'Leitura',0), (11,'Biologia',0), (12,'Filosofia',0), (13,'Estudos Sociais',0), (14,'Iniciação a Ciência',0), (15,'História',0), (16,'Sociologia',0), (17,'Psicologia',0), (18,'Ensino Religioso',0), (19,'Artes',0);"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                SQL = "INSERT INTO novaescola.usuariodsk (`usuario`,`senha`,`cod_prof`,`codigo`) VALUES ('suporte','suporte2007s',0,1), ('admin','admin2007a',0,2), ('novaescola','novaescola',1,4);"
                myCommand.Connection = conn2
                myCommand.CommandText = SQL
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

            Catch myerro As MySqlException
                ' MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn2.Close()
        Catch myerro As MySqlException
            '   MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn2.Dispose()
        End Try
        ' FIM DA CONEXAO



    End Sub

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        Dim bd, ip, imagem
        ' REGISTRA O CODIGO SECRETO EM UM LUGAR SEGURO
        Dim csRegistryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey("System.Windows.Net.Conexao")
        csRegistryKey = csRegistryKey.CreateSubKey("Classe")
        '''''''''''''''''''''''''''''''''''''''''''''''
        'RETIRAR APENAS ALGUNS NUMEROS PARA CODIFICAR E DESCODIFICAR
        ip = tbIP.Text
        bd = tbBD.Text

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

        Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

      
    End Sub
End Class