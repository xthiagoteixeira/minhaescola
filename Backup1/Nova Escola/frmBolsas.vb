Imports System.DBNull
Imports System.Data.DataTable
Imports System.Data
Imports System.IO
Imports System
Imports MySql.Data.MySqlClient
Public Class frmBolsas

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Dim TipoBolsa = ""
        
        Dim conn As MySqlConnection
        conn = New MySqlConnection()
        conn.ConnectionString = CONEXAOBD

        Try
            conn.Open()
            Try
                ' PRIMEIRO FILTRA-SE O QUE FOI ESCOLHIDO
                '
                If rbBF.Checked = True Then
                    TipoBolsa = "BF"

                ElseIf rbBVJ.Checked = True Then
                    TipoBolsa = "BVJ"

                End If

                myData4.Clear()
                SQL4 = "SELECT * FROM bolsas WHERE tipo='" & TipoBolsa & "' AND ano='" & tAno.Value & "';"
                myCommand4.Connection = conn
                myCommand4.CommandText = SQL4
                myAdapter4.SelectCommand = myCommand4
                myAdapter4.Fill(myData4)

                For Each r4 In myData4.Rows

                    Dim NumeroAluno = r4("nro")
                    Dim CodigoTurma = r4("codigo_trma")
                    Dim Bimestre = tBimestre.Value
                    Dim TotalAulasDadas = 0
                    Dim SomaFaltasAluno = 0

                    ' SOMA QTDADEAULAS DE TODOS OS BOLETINS, ANOVIGENTE / BIMESTRE / CODIGO_TURMA
                    '
                    Try

                        myData7.Clear()
                        SQL7 = "SELECT SUM(qtdadeaulas) FROM notasfreq WHERE cod_bimestre='" & Bimestre & "' AND turma='" & CodigoTurma & "' AND anovigente='" & tAno.Value & "';"
                        myCommand7.Connection = conn
                        myCommand7.CommandText = SQL7
                        myAdapter7.SelectCommand = myCommand7
                        myAdapter7.Fill(myData7)
                        r7 = myData7.Rows(0)
                        TotalAulasDadas = r7("SUM(qtdadeaulas)")

                    Catch ex As Exception
                    End Try

                    '''' SELECIONA TODOS OS BOLETINS, ANOVIGENTE / BIMESTRE / CODIGO_TURMA
                    '
                    Try

                        myData7.Clear()
                        SQL7 = "SELECT * FROM notasfreq WHERE cod_bimestre='" & Bimestre & "' AND turma='" & CodigoTurma & "' AND anovigente='" & tAno.Value & "';"
                        myCommand7.Connection = conn
                        myCommand7.CommandText = SQL7
                        myAdapter7.SelectCommand = myCommand7
                        myAdapter7.Fill(myData7)

                    Catch ex As Exception
                    End Try
                    '
                    ''''  

                    '''' SELECIONA O ALUNO, PELO NUMERO, E SOMA FALTAS DO BIMESTRE
                    '
                    myData2.Clear()
                    SQL2 = "SELECT " _
                    & " boletim.nro_aluno," _
                    & " SUM(boletim.F)" _
                    & " FROM" _
                    & " notasfreq" _
                    & " INNER JOIN boletim ON (notasfreq.cod_nf = boletim.cod_boletim)" _
                    & " WHERE boletim.nro_aluno='" & NumeroAluno & "' AND notasfreq.cod_bimestre='" & Bimestre & "' AND notasfreq.turma='" & CodigoTurma & "' AND notasfreq.anovigente='" & tAno.Value & "';"
                    myCommand2.Connection = conn
                    myCommand2.CommandText = SQL2
                    myAdapter2.SelectCommand = myCommand2
                    myAdapter2.Fill(myData2)
                    r2 = myData2.Rows(0)
                    SomaFaltasAluno = r2("SUM(boletim.F)")
                    '
                    ''''

                    Dim CalculoPorcentagem

                    CalculoPorcentagem = (CInt(SomaFaltasAluno) * 100) / (CInt(TotalAulasDadas))
                    CalculoPorcentagem = CInt(CalculoPorcentagem)

                    '''' ATUALIZA NO BOLSAS A NOVA SITUAÇÃO DO ALUNO
                    '
                    myData2.Clear()
                    SQL2 = "UPDATE bolsas SET bimestre='" & tBimestre.Value & "', porcentagem='" & CalculoPorcentagem & "' WHERE nro='" & NumeroAluno & "' AND ano='" & tAno.Value & "' AND codigo_trma='" & CodigoTurma & "' AND tipo='" & TipoBolsa & "';"
                    atualizaMySQL(SQL2)
                    '
                    ''''
                Next

                Dim w = ""

                If rbBF.Checked = True Then
                    w = "BolsaFamilia"
                ElseIf rbBVJ.Checked = True Then
                    w = "BolsaVariavelJovem"
                End If

                frmRpt.lbParametro.Text = w
                frmRpt.Show()

            Catch myerro As MySqlException
                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)
            End Try
            '           MessageBox.Show("Conexão aberta com sucesso")
            conn.Close()
        Catch myerro As MySqlException
            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub
End Class