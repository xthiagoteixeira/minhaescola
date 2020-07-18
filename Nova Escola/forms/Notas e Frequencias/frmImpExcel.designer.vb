<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImpExcel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpExcel))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbEscolhaBimestre = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cbAtualizarNotas = New DevExpress.XtraEditors.CheckButton()
        Me.cbTodosArquivos = New DevExpress.XtraEditors.CheckButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btCarregar = New DevExpress.XtraEditors.SimpleButton()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.tbArquivo = New System.Windows.Forms.TextBox()
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.bwCarregar = New System.ComponentModel.BackgroundWorker()
        Me.barra = New DevExpress.XtraEditors.ProgressBarControl()
        Me.gridBoletim = New DevExpress.XtraGrid.GridControl()
        Me.viewBoletim = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.cbEscolhaBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(67, 73)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Bimestre:"
        '
        'cbEscolhaBimestre
        '
        Me.cbEscolhaBimestre.Location = New System.Drawing.Point(135, 70)
        Me.cbEscolhaBimestre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbEscolhaBimestre.Name = "cbEscolhaBimestre"
        Me.cbEscolhaBimestre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEscolhaBimestre.Properties.Appearance.Options.UseFont = True
        Me.cbEscolhaBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEscolhaBimestre.Properties.Items.AddRange(New Object() {"1º Bimestre", "2º Bimestre", "2º Avaliação Final", "3º Bimestre", "4º Bimestre", "4º Avaliação Final"})
        Me.cbEscolhaBimestre.Size = New System.Drawing.Size(97, 22)
        Me.cbEscolhaBimestre.TabIndex = 6
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btImprimir)
        Me.GroupControl1.Controls.Add(Me.cbAtualizarNotas)
        Me.GroupControl1.Controls.Add(Me.cbTodosArquivos)
        Me.GroupControl1.Controls.Add(Me.PictureEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.btCarregar)
        Me.GroupControl1.Controls.Add(Me.tAno)
        Me.GroupControl1.Controls.Add(Me.cbEscolhaBimestre)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.tbArquivo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 308)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(568, 145)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Escolher a pasta:"
        '
        'btImprimir
        '
        Me.btImprimir.Enabled = False
        Me.btImprimir.Location = New System.Drawing.Point(377, 101)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(163, 23)
        Me.btImprimir.TabIndex = 245
        Me.btImprimir.Text = "Imprimir Relatório"
        '
        'cbAtualizarNotas
        '
        Me.cbAtualizarNotas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.cbAtualizarNotas.Location = New System.Drawing.Point(377, 72)
        Me.cbAtualizarNotas.Name = "cbAtualizarNotas"
        Me.cbAtualizarNotas.Size = New System.Drawing.Size(163, 23)
        Me.cbAtualizarNotas.TabIndex = 244
        Me.cbAtualizarNotas.Text = "Atualizar Notas"
        '
        'cbTodosArquivos
        '
        Me.cbTodosArquivos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.cbTodosArquivos.Location = New System.Drawing.Point(377, 43)
        Me.cbTodosArquivos.Name = "cbTodosArquivos"
        Me.cbTodosArquivos.Size = New System.Drawing.Size(163, 23)
        Me.cbTodosArquivos.TabIndex = 243
        Me.cbTodosArquivos.Text = "Todos arquivos da pasta"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(323, 43)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(23, 23)
        Me.PictureEdit1.TabIndex = 242
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(98, 100)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl2.TabIndex = 241
        Me.LabelControl2.Text = "Ano:"
        '
        'btCarregar
        '
        Me.btCarregar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCarregar.Appearance.Options.UseFont = True
        Me.btCarregar.Enabled = False
        Me.btCarregar.Location = New System.Drawing.Point(269, 93)
        Me.btCarregar.Name = "btCarregar"
        Me.btCarregar.Size = New System.Drawing.Size(77, 23)
        Me.btCarregar.TabIndex = 4
        Me.btCarregar.Text = "Carregar!"
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(135, 97)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = True
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2200, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(60, 22)
        Me.tAno.TabIndex = 239
        '
        'tbArquivo
        '
        Me.tbArquivo.Enabled = False
        Me.tbArquivo.Location = New System.Drawing.Point(12, 43)
        Me.tbArquivo.Name = "tbArquivo"
        Me.tbArquivo.Size = New System.Drawing.Size(298, 23)
        Me.tbArquivo.TabIndex = 2
        Me.tbArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "ImgFalha")
        Me.ImageList.Images.SetKeyName(1, "ImgSucesso")
        '
        'bwCarregar
        '
        Me.bwCarregar.WorkerReportsProgress = True
        Me.bwCarregar.WorkerSupportsCancellation = True
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.barra.EditValue = "0"
        Me.barra.Location = New System.Drawing.Point(0, 283)
        Me.barra.Name = "barra"
        Me.barra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.barra.Properties.Maximum = 1
        Me.barra.Properties.ShowTitle = True
        Me.barra.Properties.Step = 1
        Me.barra.ShowProgressInTaskBar = True
        Me.barra.Size = New System.Drawing.Size(568, 25)
        Me.barra.TabIndex = 212
        '
        'gridBoletim
        '
        Me.gridBoletim.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridBoletim.Location = New System.Drawing.Point(0, 0)
        Me.gridBoletim.MainView = Me.viewBoletim
        Me.gridBoletim.Name = "gridBoletim"
        Me.gridBoletim.Size = New System.Drawing.Size(568, 283)
        Me.gridBoletim.TabIndex = 213
        Me.gridBoletim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewBoletim})
        '
        'viewBoletim
        '
        Me.viewBoletim.GridControl = Me.gridBoletim
        Me.viewBoletim.Name = "viewBoletim"
        '
        'frmImpExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(568, 454)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.gridBoletim)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trazer Notas! - Excel"
        CType(Me.cbEscolhaBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewBoletim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbEscolhaBimestre As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbArquivo As System.Windows.Forms.TextBox
    Friend WithEvents btCarregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents bwCarregar As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barra As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbAtualizarNotas As DevExpress.XtraEditors.CheckButton
    Friend WithEvents cbTodosArquivos As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridBoletim As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewBoletim As DevExpress.XtraGrid.Views.Grid.GridView
End Class
