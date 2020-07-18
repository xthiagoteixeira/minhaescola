<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFerNavegador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFerNavegador))
        Me.webb1 = New System.Windows.Forms.WebBrowser
        Me.pVoltar = New System.Windows.Forms.PictureBox
        Me.pAdiante = New System.Windows.Forms.PictureBox
        Me.pStop = New System.Windows.Forms.PictureBox
        Me.pHome = New System.Windows.Forms.PictureBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUrl = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.pVoltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pAdiante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webb1
        '
        Me.webb1.Location = New System.Drawing.Point(0, 58)
        Me.webb1.MinimumSize = New System.Drawing.Size(20, 17)
        Me.webb1.Name = "webb1"
        Me.webb1.Size = New System.Drawing.Size(814, 449)
        Me.webb1.TabIndex = 0
        '
        'pVoltar
        '
        Me.pVoltar.Image = CType(resources.GetObject("pVoltar.Image"), System.Drawing.Image)
        Me.pVoltar.Location = New System.Drawing.Point(41, 10)
        Me.pVoltar.Name = "pVoltar"
        Me.pVoltar.Size = New System.Drawing.Size(22, 23)
        Me.pVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pVoltar.TabIndex = 1
        Me.pVoltar.TabStop = False
        '
        'pAdiante
        '
        Me.pAdiante.Image = CType(resources.GetObject("pAdiante.Image"), System.Drawing.Image)
        Me.pAdiante.Location = New System.Drawing.Point(129, 10)
        Me.pAdiante.Name = "pAdiante"
        Me.pAdiante.Size = New System.Drawing.Size(22, 23)
        Me.pAdiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pAdiante.TabIndex = 2
        Me.pAdiante.TabStop = False
        '
        'pStop
        '
        Me.pStop.Image = CType(resources.GetObject("pStop.Image"), System.Drawing.Image)
        Me.pStop.Location = New System.Drawing.Point(69, 10)
        Me.pStop.Name = "pStop"
        Me.pStop.Size = New System.Drawing.Size(24, 24)
        Me.pStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pStop.TabIndex = 3
        Me.pStop.TabStop = False
        '
        'pHome
        '
        Me.pHome.Image = CType(resources.GetObject("pHome.Image"), System.Drawing.Image)
        Me.pHome.Location = New System.Drawing.Point(99, 10)
        Me.pHome.Name = "pHome"
        Me.pHome.Size = New System.Drawing.Size(24, 24)
        Me.pHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pHome.TabIndex = 4
        Me.pHome.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 41)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(814, 17)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Endereço:"
        '
        'txtUrl
        '
        Me.txtUrl.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUrl.Location = New System.Drawing.Point(254, 10)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(443, 22)
        Me.txtUrl.TabIndex = 7
        Me.txtUrl.TabStop = False
        Me.txtUrl.Text = "http://www.isolucao.com.br"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(728, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmFerNavegador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1112, 507)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pHome)
        Me.Controls.Add(Me.pStop)
        Me.Controls.Add(Me.pAdiante)
        Me.Controls.Add(Me.pVoltar)
        Me.Controls.Add(Me.webb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFerNavegador"
        Me.Text = "Navegador iSolução"
        CType(Me.pVoltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pAdiante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents webb1 As System.Windows.Forms.WebBrowser
    Friend WithEvents pVoltar As System.Windows.Forms.PictureBox
    Friend WithEvents pAdiante As System.Windows.Forms.PictureBox
    Friend WithEvents pStop As System.Windows.Forms.PictureBox
    Friend WithEvents pHome As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
