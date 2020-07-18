<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConturma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConturma))
        Me.DGTurma = New System.Windows.Forms.DataGrid
        CType(Me.DGTurma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGTurma
        '
        Me.DGTurma.AllowNavigation = False
        Me.DGTurma.AllowSorting = False
        Me.DGTurma.DataMember = ""
        Me.DGTurma.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGTurma.Location = New System.Drawing.Point(2, 2)
        Me.DGTurma.Name = "DGTurma"
        Me.DGTurma.Size = New System.Drawing.Size(385, 213)
        Me.DGTurma.TabIndex = 146
        Me.DGTurma.TabStop = False
        '
        'frmConturma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 217)
        Me.Controls.Add(Me.DGTurma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConturma"
        Me.ShowInTaskbar = False
        Me.Text = "Turma - Consulta"
        CType(Me.DGTurma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGTurma As System.Windows.Forms.DataGrid
End Class
