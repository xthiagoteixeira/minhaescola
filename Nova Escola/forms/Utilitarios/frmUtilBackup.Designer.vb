<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilBackup
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilBackup))
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_IniciarBackup = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        Me.BackgroundWorker.WorkerSupportsCancellation = True
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "ImgFalha")
        Me.ImageList.Images.SetKeyName(1, "ImgSucesso")
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToOrderColumns = True
        Me.DataGridView.AllowUserToResizeColumns = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.DataHora, Me.Descrição})
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView.Size = New System.Drawing.Size(529, 283)
        Me.DataGridView.TabIndex = 13
        '
        'Status
        '
        Me.Status.HeaderText = "*"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 25
        '
        'DataHora
        '
        Me.DataHora.HeaderText = "Data"
        Me.DataHora.Name = "DataHora"
        Me.DataHora.ReadOnly = True
        Me.DataHora.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataHora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataHora.Width = 120
        '
        'Descrição
        '
        Me.Descrição.HeaderText = "Descrição"
        Me.Descrição.Name = "Descrição"
        Me.Descrição.ReadOnly = True
        Me.Descrição.Width = 380
        '
        'Btn_IniciarBackup
        '
        Me.Btn_IniciarBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_IniciarBackup.Location = New System.Drawing.Point(364, 289)
        Me.Btn_IniciarBackup.Name = "Btn_IniciarBackup"
        Me.Btn_IniciarBackup.Size = New System.Drawing.Size(159, 27)
        Me.Btn_IniciarBackup.TabIndex = 16
        Me.Btn_IniciarBackup.Text = "Iniciar Backup"
        Me.Btn_IniciarBackup.UseVisualStyleBackColor = True
        '
        'frmAdmFerBackup
        '
        Me.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(529, 321)
        Me.Controls.Add(Me.Btn_IniciarBackup)
        Me.Controls.Add(Me.DataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdmFerBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mais Escola! - Backup de Sistema"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Status As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descrição As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_IniciarBackup As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
