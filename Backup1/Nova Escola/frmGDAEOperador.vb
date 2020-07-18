Imports System.Web
Imports Mais_Escola
Public Class frmGDAEOperador
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents btTransferir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btEscolher As DevComponents.DotNetBar.ButtonX
    Friend WithEvents timeTransferir As System.Windows.Forms.Timer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents webBrowser2 As AxSHDocVw.AxWebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGDAEOperador))
        Me.webBrowser2 = New AxSHDocVw.AxWebBrowser
        Me.btTransferir = New DevComponents.DotNetBar.ButtonX
        Me.btEscolher = New DevComponents.DotNetBar.ButtonX
        Me.timeTransferir = New System.Windows.Forms.Timer(Me.components)
        CType(Me.webBrowser2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webBrowser2
        '
        Me.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser2.Enabled = True
        Me.webBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser2.OcxState = CType(resources.GetObject("webBrowser2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.webBrowser2.Size = New System.Drawing.Size(788, 470)
        Me.webBrowser2.TabIndex = 0
        '
        'btTransferir
        '
        Me.btTransferir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTransferir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btTransferir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTransferir.Location = New System.Drawing.Point(685, 55)
        Me.btTransferir.Name = "btTransferir"
        Me.btTransferir.Size = New System.Drawing.Size(98, 23)
        Me.btTransferir.TabIndex = 12
        Me.btTransferir.Text = "Transferir!"
        '
        'btEscolher
        '
        Me.btEscolher.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEscolher.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEscolher.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEscolher.Location = New System.Drawing.Point(577, 55)
        Me.btEscolher.Name = "btEscolher"
        Me.btEscolher.Size = New System.Drawing.Size(105, 23)
        Me.btEscolher.TabIndex = 13
        Me.btEscolher.Text = "Escolher Boletim!"
        '
        'frmGDAEOperador
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(788, 470)
        Me.Controls.Add(Me.btEscolher)
        Me.Controls.Add(Me.btTransferir)
        Me.Controls.Add(Me.webBrowser2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGDAEOperador"
        Me.ShowInTaskbar = False
        Me.Text = "Mais Escola - Transferir Notas!"
        CType(Me.webBrowser2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public fGDAEMenu As frmGDAEMenu
    Dim ifolha2 = 0
    Dim SubstituirNota As Boolean
    Dim SubstituirValor As Integer
    Dim CodigoEscola

    Private Sub frmGDAEOperador_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        If ClasseDisciplinaAtual = Nothing Then
            Me.Text = "Mais Escola! - Transferir Notas! ******* VOCE ESCOLHEU: NENHUM BOLETIM *******"
        Else
            Me.Text = "Mais Escola! - Transferir Notas! ******* VOCE ESCOLHEU: " & ClasseDisciplinaAtual & " *******"
        End If
       

        If ControleTransferir = 0 Then
            btTransferir.Enabled = False
        Else
            btTransferir.Enabled = True
        End If

        If Not (AulasDadas = 0 And AulasPrevistas = 0) Then
            'AULAS PREVISTAS = TextField_R11C39L2
            'AULAS DADAS = TextField_R13C39L2

            Try
                webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C39L2").Value = AulasPrevistas
                webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C39L2").Value = AulasDadas
            Catch ex As Exception
            End Try
            
            AulasDadas = 0
            AulasPrevistas = 0
        End If

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If ClasseDisciplinaAtual = Nothing Then
            Me.Text = "Mais Escola! - Transferir Notas! ******* VOCE ESCOLHEU: NENHUM BOLETIM *******"

        Else
            Me.Text = "Mais Escola! - Transferir Notas! ******* VOCE ESCOLHEU: " & ClasseDisciplinaAtual & " *******"

        End If


        If ControleTransferir = 0 Then
            btTransferir.Enabled = False
        Else
            btTransferir.Enabled = True
        End If

        'TENTA PUXAR PREFERENCIAS DO USUARIO
        Try
            Dim myRegKey2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("MicroD.Vms")
            myRegKey2 = myRegKey2.OpenSubKey("Classes")

            Dim ferramentaNota As Object = myRegKey2.GetValue("ferramentaNota")
            Dim ferramentaNota2 As Object = myRegKey2.GetValue("ferramentaNota2")

            If ferramentaNota = "1" Then
                SubstituirNota = True
                SubstituirValor = ferramentaNota2
            Else
                SubstituirNota = False
                SubstituirValor = "0"
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        webBrowser2 = Nothing
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTransferir.Click

        If travaProcessos <> 99 Then

            If contadorTransf = 1 Then
                ifolha2 = 1
                final = 10
            ElseIf contadorTransf = 11 Then
                ifolha2 = 2
                inicio = 11
                If (nroTotalAlunos - contadorTransf) > 10 Then
                    final = 20
                Else
                    final = (10 + (nroTotalAlunos - contadorTransf))
                End If
            ElseIf contadorTransf = 21 Then
                ifolha2 = 3
                inicio = 21
                If (nroTotalAlunos - contadorTransf) > 10 Then
                    final = 30
                Else
                    final = (20 + (nroTotalAlunos - contadorTransf))
                End If
            ElseIf contadorTransf = 31 Then
                ifolha2 = 4
                inicio = 31
                If (nroTotalAlunos - contadorTransf) > 10 Then
                    final = 40
                Else
                    final = (30 + (nroTotalAlunos - contadorTransf))
                End If
            ElseIf contadorTransf = 41 Then
                ifolha2 = 5
                inicio = 41
                If (nroTotalAlunos - contadorTransf) > 10 Then
                    final = 50
                Else
                    final = (40 + (nroTotalAlunos - contadorTransf))
                End If
            ElseIf contadorTransf = 51 Then
                ifolha2 = 6
                inicio = 51
                If (nroTotalAlunos - contadorTransf) > 10 Then
                    final = 60
                Else
                    final = (50 + (nroTotalAlunos - contadorTransf))
                End If
            End If

            For inicio = contadorTransf To final

                '////////SE FOR 1 BIMESTRE
                If travaProcessos = 1 Then

                    '################ NUMERO 1 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                        End If
                    Catch ex0 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                    Catch ex0 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                    Catch ex0 As Exception
                    End Try


                    '################ NUMERO 2 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                        End If
                    Catch ex1 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                    Catch ex1 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                    Catch ex1 As Exception
                    End Try


                    '################ NUMERO 3 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                        End If
                    Catch ex2 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                    Catch ex2 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                    Catch ex2 As Exception
                    End Try


                    '################ NUMERO 4 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                        End If
                    Catch ex3 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                    Catch ex3 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                    Catch ex3 As Exception
                    End Try


                    '################ NUMERO 5 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                        End If
                    Catch ex4 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                    Catch ex4 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                    Catch ex4 As Exception
                    End Try


                    '################ NUMERO 6 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                        End If
                    Catch ex5 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                    Catch ex5 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                    Catch ex5 As Exception
                    End Try


                    '################ NUMERO 7 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                        End If
                    Catch ex6 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                    Catch ex6 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                    Catch ex6 As Exception
                    End Try


                    '################ NUMERO 8 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                        End If
                    Catch ex7 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                    Catch ex7 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                    Catch ex7 As Exception
                    End Try


                    '################ NUMERO 9 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                        End If
                    Catch ex8 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                    Catch ex8 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                    Catch ex8 As Exception
                    End Try


                    '################ NUMERO 10 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                        End If
                    Catch ex9 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                    Catch ex9 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                    Catch ex9 As Exception
                    End Try

                    '################## APERTA O ENTER #####################
                    Try
                        webBrowser2.Document.Frames("principal").Document.All.Item("btEnter").Click()
                    Catch ex As Exception
                    End Try


                    '////////SE FOR 2, 3, 4 BIMESTRES
                ElseIf travaProcessos = 2 Then
                    '################ NUMERO 1 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                        End If
                    Catch ex00 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                    Catch ex00 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                    Catch ex00 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                    Catch ex00 As Exception
                    End Try

                    '################ NUMERO 2 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                        End If
                    Catch ex11 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                    Catch ex11 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                    Catch ex11 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                    Catch ex11 As Exception
                    End Try

                    '################ NUMERO 3 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                        End If
                    Catch ex22 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                    Catch ex22 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                    Catch ex22 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                    Catch ex22 As Exception
                    End Try

                    '################ NUMERO 4 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                        End If
                    Catch ex33 As Exception
                    End Try ' End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                    Catch ex33 As Exception
                    End Try ' End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                    Catch ex33 As Exception
                    End Try ' End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                    Catch ex33 As Exception
                    End Try

                    '################ NUMERO 5 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                        End If
                    Catch ex44 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                    Catch ex44 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                    Catch ex44 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                    Catch ex44 As Exception
                    End Try

                    '################ NUMERO 6 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                        End If
                    Catch ex55 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                    Catch ex55 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                    Catch ex55 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                    Catch ex55 As Exception
                    End Try

                    '################ NUMERO 7 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                        End If
                    Catch ex66 As Exception
                    End Try 'End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                    Catch ex66 As Exception
                    End Try 'End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                    Catch ex66 As Exception
                    End Try 'End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                    Catch ex66 As Exception
                    End Try 'End If

                    '################ NUMERO 8 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                        End If
                    Catch ex77 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                    Catch ex77 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                    Catch ex77 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                    Catch ex77 As Exception
                    End Try

                    '################ NUMERO 9 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                        End If
                    Catch ex88 As Exception
                    End Try 'End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                    Catch ex88 As Exception
                    End Try 'End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                    Catch ex88 As Exception
                    End Try 'End If
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                    Catch ex88 As Exception
                    End Try 'End If

                    '################ NUMERO 10 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                        End If
                    Catch ex99 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C10L3").Value = iFT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                    Catch ex99 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C14L2").Value = iACT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                    Catch ex99 As Exception
                    End Try
                    Try
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C17L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                    Catch ex99 As Exception
                    End Try

                    '################## APERTA O ENTER #####################
                    Try
                        webBrowser2.Document.Frames("principal").Document.All.Item("btEnter").Click()
                    Catch ex As Exception
                    End Try


                    '////////// 2AF E 4AF - SE FOR AVALIACAO FINAL OU FUNDAMENTAL ////////////
                ElseIf travaProcessos = 3 Then

                    '################ NUMERO 1 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R10C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R10C3L2").innerText)
                    Catch ex000 As Exception
                    End Try

                    '################ NUMERO 2 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R11C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R11C3L2").innerText)
                    Catch ex111 As Exception
                    End Try

                    '################ NUMERO 3 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R12C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R12C3L2").innerText)
                    Catch ex222 As Exception
                    End Try

                    '################ NUMERO 4 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R13C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R13C3L2").innerText)
                    Catch ex333 As Exception
                    End Try

                    '################ NUMERO 5 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R14C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R14C3L2").innerText)
                    Catch ex444 As Exception
                    End Try

                    '################ NUMERO 6 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R15C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R15C3L2").innerText)
                    Catch ex555 As Exception
                    End Try

                    '################ NUMERO 7 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R16C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R16C3L2").innerText)
                    Catch ex666 As Exception
                    End Try

                    '################ NUMERO 8 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R17C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R17C3L2").innerText)
                    Catch ex777 As Exception
                    End Try

                    '################ NUMERO 9 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R18C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R18C3L2").innerText)
                    Catch ex888 As Exception
                    End Try

                    '################ NUMERO 10 ##################
                    Try
                        If SubstituirNota = True And (iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText) > 10) Then
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C6L3").Value = SubstituirValor
                        Else
                            webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C6L3").Value = iAV(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                        End If
                        webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R19C20L1").Value = iPRT(webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R19C3L2").innerText)
                    Catch ex999 As Exception
                    End Try

                    '################## APERTA O ENTER #####################
                    Try
                        webBrowser2.Document.Frames("principal").Document.All.Item("btEnter").Click()
                    Catch ex As Exception
                    End Try
                End If
            Next
            contadorTransf = inicio

            '/// FINALIZAR O PROCESSO DE TRANSFERENCIA
            If ifolha = ifolha2 Then
                MsgBox("Transferido com sucesso!", MsgBoxStyle.Information, "Mais Escola")
            End If
        Else
            MsgBox("É necessário escolher um boletim para transferir!", MsgBoxStyle.Information, "Atenção!")
        End If

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEscolher.Click
        fGDAEMenu = New frmGDAEMenu
        fGDAEMenu.Show()
    End Sub

    Private Sub webBrowser2_DocumentComplete(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent) Handles webBrowser2.DocumentComplete
        Try
            CodigoEscola = webBrowser2.Document.Frames("principal").Document.Frames("site").Document.GetElementById("Label_R6C1L31").innerText
        Catch ex As Exception
        End Try

        If CodigoSEE <> 0 And CodigoEscola = "              CODIGO DA ESCOLA: " Then

            Try
                webBrowser2.Document.Frames("principal").Document.Frames("site").Document.All.Item("TextField_R6C33L7").Value = CodigoSEE
                webBrowser2.Document.Frames("principal").Document.All.Item("btEnter").Click()
            Catch ex As Exception
            End Try

        End If

    End Sub

    Private Sub webBrowser2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles webBrowser2.Enter

    End Sub
End Class
