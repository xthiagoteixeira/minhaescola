<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConDisciplinas
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
        Me.DGDisciplina = New System.Windows.Forms.DataGrid
        CType(Me.DGDisciplina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGDisciplina
        '
        Me.DGDisciplina.DataMember = ""
        Me.DGDisciplina.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGDisciplina.Location = New System.Drawing.Point(2, 2)
        Me.DGDisciplina.Name = "DGDisciplina"
        Me.DGDisciplina.ReadOnly = True
        Me.DGDisciplina.Size = New System.Drawing.Size(550, 281)
        Me.DGDisciplina.TabIndex = 146
        '
        'frmConDisciplinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 286)
        Me.Controls.Add(Me.DGDisciplina)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConDisciplinas"
        Me.Text = "Disciplina - Consulta"
        CType(Me.DGDisciplina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGDisciplina As System.Windows.Forms.DataGrid
End Class
