<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConAlunos
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
        Me.DGVendedor = New System.Windows.Forms.DataGrid
        CType(Me.DGVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVendedor
        '
        Me.DGVendedor.DataMember = ""
        Me.DGVendedor.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVendedor.Location = New System.Drawing.Point(2, 2)
        Me.DGVendedor.Name = "DGVendedor"
        Me.DGVendedor.ReadOnly = True
        Me.DGVendedor.Size = New System.Drawing.Size(781, 343)
        Me.DGVendedor.TabIndex = 146
        '
        'frmConAlunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 347)
        Me.Controls.Add(Me.DGVendedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConAlunos"
        Me.Text = "Boletim - Consulta"
        CType(Me.DGVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVendedor As System.Windows.Forms.DataGrid
End Class
