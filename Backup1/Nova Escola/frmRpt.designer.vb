<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpt))
        Me.lbParametro = New System.Windows.Forms.Label
        Me.nrodisciplina = New System.Windows.Forms.Label
        Me.nroturma = New System.Windows.Forms.Label
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'lbParametro
        '
        Me.lbParametro.AutoSize = True
        Me.lbParametro.Location = New System.Drawing.Point(478, 170)
        Me.lbParametro.Name = "lbParametro"
        Me.lbParametro.Size = New System.Drawing.Size(49, 13)
        Me.lbParametro.TabIndex = 1
        Me.lbParametro.Text = "Relatorio"
        Me.lbParametro.Visible = False
        '
        'nrodisciplina
        '
        Me.nrodisciplina.AutoSize = True
        Me.nrodisciplina.Location = New System.Drawing.Point(514, 218)
        Me.nrodisciplina.Name = "nrodisciplina"
        Me.nrodisciplina.Size = New System.Drawing.Size(13, 13)
        Me.nrodisciplina.TabIndex = 2
        Me.nrodisciplina.Text = "1"
        Me.nrodisciplina.Visible = False
        '
        'nroturma
        '
        Me.nroturma.AutoSize = True
        Me.nroturma.Location = New System.Drawing.Point(514, 195)
        Me.nroturma.Name = "nroturma"
        Me.nroturma.Size = New System.Drawing.Size(13, 13)
        Me.nroturma.TabIndex = 3
        Me.nroturma.Text = "1"
        Me.nroturma.Visible = False
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.Size = New System.Drawing.Size(590, 304)
        Me.crViewer.TabIndex = 4
        '
        'frmRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 304)
        Me.Controls.Add(Me.crViewer)
        Me.Controls.Add(Me.nroturma)
        Me.Controls.Add(Me.nrodisciplina)
        Me.Controls.Add(Me.lbParametro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRpt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Escola - Relatórios!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbParametro As System.Windows.Forms.Label
    Friend WithEvents nrodisciplina As System.Windows.Forms.Label
    Friend WithEvents nroturma As System.Windows.Forms.Label
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
