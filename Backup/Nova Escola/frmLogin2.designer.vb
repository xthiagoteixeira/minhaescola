<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin2))
        Me.rbLocal = New System.Windows.Forms.RadioButton
        Me.rbIntranet = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbIP = New System.Windows.Forms.TextBox
        Me.btAdicionar = New System.Windows.Forms.Button
        Me.tbBD = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbLocal
        '
        Me.rbLocal.AutoSize = True
        Me.rbLocal.Location = New System.Drawing.Point(8, 31)
        Me.rbLocal.Name = "rbLocal"
        Me.rbLocal.Size = New System.Drawing.Size(51, 17)
        Me.rbLocal.TabIndex = 0
        Me.rbLocal.TabStop = True
        Me.rbLocal.Text = "Local"
        Me.rbLocal.UseVisualStyleBackColor = True
        '
        'rbIntranet
        '
        Me.rbIntranet.AutoSize = True
        Me.rbIntranet.Location = New System.Drawing.Point(8, 54)
        Me.rbIntranet.Name = "rbIntranet"
        Me.rbIntranet.Size = New System.Drawing.Size(102, 17)
        Me.rbIntranet.TabIndex = 1
        Me.rbIntranet.TabStop = True
        Me.rbIntranet.Text = "Intranet/Internet"
        Me.rbIntranet.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbIntranet)
        Me.GroupBox1.Controls.Add(Me.rbLocal)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 94)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Banco de Dados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "IP:"
        '
        'tbIP
        '
        Me.tbIP.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIP.Location = New System.Drawing.Point(187, 52)
        Me.tbIP.Name = "tbIP"
        Me.tbIP.Size = New System.Drawing.Size(99, 22)
        Me.tbIP.TabIndex = 33
        '
        'btAdicionar
        '
        Me.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAdicionar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdicionar.Location = New System.Drawing.Point(148, 84)
        Me.btAdicionar.Name = "btAdicionar"
        Me.btAdicionar.Size = New System.Drawing.Size(134, 23)
        Me.btAdicionar.TabIndex = 34
        Me.btAdicionar.Text = "Efetuar alteração"
        Me.btAdicionar.UseVisualStyleBackColor = True
        '
        'tbBD
        '
        Me.tbBD.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBD.Location = New System.Drawing.Point(187, 27)
        Me.tbBD.Name = "tbBD"
        Me.tbBD.Size = New System.Drawing.Size(99, 22)
        Me.tbBD.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Nome:"
        '
        'frmLogin2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 115)
        Me.Controls.Add(Me.tbBD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAdicionar)
        Me.Controls.Add(Me.tbIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin2"
        Me.Text = "Configurar conexão"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents rbIntranet As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbIP As System.Windows.Forms.TextBox
    Friend WithEvents btAdicionar As System.Windows.Forms.Button
    Friend WithEvents tbBD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
