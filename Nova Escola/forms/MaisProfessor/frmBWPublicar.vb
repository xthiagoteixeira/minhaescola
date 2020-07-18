
Imports Mais_Escola.WS_MaisEscola_Web
Imports System.ComponentModel

Public Class frmBWPublicar
    Dim Transf_Erro = False
    Dim Transf_Msg
    ReadOnly WS_MaisEscola_Web = New Web

    Private Sub frmGerAlunosPublicar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Erro_Form = "frmBWPublicar"
        ' checa se existe usuario e senha...
        '
        Dim Sql = "SELECT * FROM preferencias WHERE idPreferencias=1;"
        Dim inicioCalendarioBD = MySQL_consulta_campo(Sql, "mp_inicio")
        Dim finalCalendarioBD = MySQL_consulta_campo(Sql, "mp_final")

        If inicioCalendarioBD = "0" And finalCalendarioBD = "0" Then
            inicioCalendario.Text = Format(Date.Now, "dd/MM/yyyy")
            finalCalendario.Text = Format(Date.Now, "dd/MM/yyyy")
        Else
            inicioCalendario.Text = inicioCalendarioBD
            finalCalendario.Text = finalCalendarioBD
        End If

        Sql = "SELECT ferramenta6 FROM preferencias WHERE idPreferencias='1';"
        Dim Pub_Usuarios = MySQL_consulta_campo(Sql, "ferramenta6")
        If Pub_Usuarios.ToString <> "0" Then
            lbTurma_Data.Text = Pub_Usuarios.ToString
        Else
            lbTurma_Data.Text = "00/00/0000"
        End If

        Sql = "SELECT tabela, sincronizado FROM boletimweb WHERE sincronizado='1';"
        Dim Pub_Evasao = MySQL_consulta_campo(Sql, "sincronizado")

        ' Se precisar publicar...
        '
        If Pub_Evasao = "1" Then
            btPublicar.Text = "Publicar..."
            btPublicar.Enabled = True
        Else
            btPublicar.Enabled = False
            btPublicar.Text = "Publicado!"
        End If
    End Sub

    Private Sub prTransfere_DoWork(sender As Object, e As DoWorkEventArgs) Handles prTransfere.DoWork


        ' Colocar o calendário no sistema...
        Dim Sql = String.Format("UPDATE preferencias SET mp_inicio='{0}', mp_final='{1}' WHERE idPreferencias='1';",
                                Format(CDate(inicioCalendario.EditValue), "yyyy-MM-dd"),
                                Format(CDate(finalCalendario.EditValue), "yyyy-MM-dd"))
        MySQL_atualiza(Sql)

        ' Colocar o calendário ONLINE ...
        Try
            WS_MaisEscola_Web.BW_PublicarCalendario(UsuarioWeb, SenhaWeb,
                                                    Format(CDate(inicioCalendario.EditValue), "yyyy-MM-dd"),
                                                    Format(CDate(finalCalendario.EditValue), "yyyy-MM-dd"))
        Catch ex As Exception
            MsgBox("Entrar em contato com o suporte!" & vbCrLf & "Mensagem: ", ex.Message, MsgBoxStyle.Information)
        End Try

        ' Verifica quais são as tabelas necessárias para publicar...
        Dim Tabela
        Dim Tabela_Opcao
        Sql = "SELECT tabela, tabela_opcao FROM boletimweb WHERE sincronizado='1';"
        Tabela = MySQL_consulta_campo(Sql, "tabela")
        Tabela_Opcao = MySQL_consulta_campo(Sql, "tabela_opcao")

        Try
            While (Tabela <> "0")

                ' Publica aquelas que precisa...
                '
                Dim myData As New DataSet()

                ' Publicacao... (colocar somente do ano (alunos)
                '
                If Tabela = "aluno" Then
                    Sql = String.Format("SELECT * FROM {0} WHERE anovigente='{1}';", Tabela, AnoVigente)
                Else
                    Sql = String.Format("SELECT * FROM {0}", Tabela)
                End If
                myData = MySQL_dataset(Sql)

                ' Publicar ...
                WS_MaisEscola_Web.BW_Publicar(UsuarioWeb, SenhaWeb, Tabela_Opcao, myData)

                ' LIBERA NO boletimweb, PARA NAO SINCRONIZAR MAIS...
                '
                Dim DataHoje = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")
                Sql = String.Format("UPDATE boletimweb SET sincronizado='0', dt_atualizacao='{0}' WHERE tabela='{1}';",
                                    DataHoje, Tabela)
                MySQL_atualiza(Sql)

                'Checa a a próxima tabela a ser publicada ...
                '
                Sql = "SELECT tabela, tabela_opcao FROM boletimweb WHERE sincronizado='1';"
                Tabela = MySQL_consulta_campo(Sql, "tabela")
                Tabela_Opcao = MySQL_consulta_campo(Sql, "tabela_opcao")
            End While

        Catch ex As Exception
            Transf_Erro = True

        End Try
    End Sub

    Private Sub prTransfere_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) _
        Handles prTransfere.RunWorkerCompleted

        If Transf_Erro = True Then
            MsgBox("Não houve publicação!" & vbCrLf & " " & Format(Date.Now, "HH:mm:ss") & " no dia " &
                Format(Date.Now, "dd/MM/yyyy") & "!", MsgBoxStyle.Information)

        Else
            MsgBox(
                "Publicado com sucesso às " & Format(Date.Now, "HH:mm:ss") & " no dia " & Format(Date.Now, "dd/MM/yyyy") &
                "!", MsgBoxStyle.Information)
            arquivoLog("Administrativo", "Publicou a lista piloto.")
        End If

        Dim DataHoje As String = Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")
        Dim SQL2 = String.Format("UPDATE preferencias SET ferramenta6='{0}' WHERE idPreferencias='1';", DataHoje)
        MySQL_atualiza(SQL2)


        Me.Close()
    End Sub

    Private Sub inicioCalendario_TextChanged(sender As Object, e As EventArgs) Handles inicioCalendario.Click
        btPublicar.Enabled = True
    End Sub

    Private Sub finalCalendario_TextChanged(sender As Object, e As EventArgs) Handles finalCalendario.Click
        btPublicar.Enabled = True
    End Sub

    Private Sub btPublicar_Click(sender As Object, e As EventArgs) Handles btPublicar.Click

        ' Calendário não pode passar de 15 dias.
        '
        Dim CalendarioInicial As Date = inicioCalendario.Text
        Dim CalendarioFinal As Date = finalCalendario.Text
        Dim IntervaloDias = DateDiff(DateInterval.Day, CalendarioInicial, CalendarioFinal)

        If IntervaloDias > 15 Then
            MsgBox("Sistema permite o intervalo de até 15 dias", MsgBoxStyle.Information, "Mais Professor! - Online")
            Exit Sub
        End If

        If _
            MsgBox("Deseja publicar o Calendário, Lista de Alunos e Usuários?", MsgBoxStyle.YesNo,
                   "Publicação em andamento...") = DialogResult.Yes Then

            MsgBox("Clique em OK, e aguarde a mensagem...", MsgBoxStyle.Information, "Mais Professor! - Online")
            prTransfere = New BackgroundWorker() _
                With {.WorkerReportsProgress = True, .WorkerSupportsCancellation = True}
            prTransfere.RunWorkerAsync()

        End If
        btPublicar.Enabled = False
    End Sub
End Class