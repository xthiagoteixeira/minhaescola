<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManDisciplinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManDisciplinas))
        Me.tbDisciplina = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DGDisciplina = New System.Windows.Forms.DataGrid
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.cbBloqueia = New DevComponents.DotNetBar.Controls.CheckBoxX
        CType(Me.DGDisciplina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbDisciplina
        '
        Me.tbDisciplina.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDisciplina.Location = New System.Drawing.Point(112, 183)
        Me.tbDisciplina.Name = "tbDisciplina"
        Me.tbDisciplina.Size = New System.Drawing.Size(150, 21)
        Me.tbDisciplina.TabIndex = 132
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 14)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Nome:"
        '
        'DGDisciplina
        '
        Me.DGDisciplina.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DGDisciplina.BackColor = System.Drawing.Color.Gainsboro
        Me.DGDisciplina.BackgroundColor = System.Drawing.Color.Silver
        Me.DGDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGDisciplina.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGDisciplina.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DGDisciplina.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DGDisciplina.DataMember = ""
        Me.DGDisciplina.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGDisciplina.FlatMode = True
        Me.DGDisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DGDisciplina.ForeColor = System.Drawing.Color.Black
        Me.DGDisciplina.GridLineColor = System.Drawing.Color.DimGray
        Me.DGDisciplina.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DGDisciplina.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DGDisciplina.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DGDisciplina.HeaderForeColor = System.Drawing.Color.White
        Me.DGDisciplina.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DGDisciplina.Location = New System.Drawing.Point(0, 0)
        Me.DGDisciplina.Name = "DGDisciplina"
        Me.DGDisciplina.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.DGDisciplina.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGDisciplina.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DGDisciplina.SelectionForeColor = System.Drawing.Color.White
        Me.DGDisciplina.Size = New System.Drawing.Size(316, 175)
        Me.DGDisciplina.TabIndex = 138
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Location = New System.Drawing.Point(149, 212)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.TabIndex = 139
        Me.ButtonX1.Text = "Efetivar!"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Location = New System.Drawing.Point(229, 212)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.TabIndex = 140
        Me.ButtonX2.Text = "Fechar"
        '
        'cbBloqueia
        '
        Me.cbBloqueia.Location = New System.Drawing.Point(20, 210)
        Me.cbBloqueia.Name = "cbBloqueia"
        Me.cbBloqueia.Size = New System.Drawing.Size(75, 23)
        Me.cbBloqueia.TabIndex = 141
        Me.cbBloqueia.Text = "Bloqueia!"
        '
        'frmManDisciplinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 242)
        Me.Controls.Add(Me.cbBloqueia)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.DGDisciplina)
        Me.Controls.Add(Me.tbDisciplina)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManDisciplinas"
        Me.Text = "Mais Escola - Disciplinas"
        CType(Me.DGDisciplina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbDisciplina As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGDisciplina As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbBloqueia As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
