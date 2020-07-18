<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerencialNOME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGBusca = New System.Windows.Forms.DataGridView
        CType(Me.DGBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGBusca
        '
        Me.DGBusca.AllowUserToAddRows = False
        Me.DGBusca.AllowUserToDeleteRows = False
        Me.DGBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBusca.Location = New System.Drawing.Point(1, 1)
        Me.DGBusca.Name = "DGBusca"
        Me.DGBusca.ReadOnly = True
        Me.DGBusca.Size = New System.Drawing.Size(435, 135)
        Me.DGBusca.TabIndex = 0
        '
        'frmGerencialNOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 137)
        Me.Controls.Add(Me.DGBusca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmGerencialNOME"
        Me.ShowInTaskbar = False
        Me.Text = "Resultado da Busca"
        CType(Me.DGBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGBusca As System.Windows.Forms.DataGridView
End Class
