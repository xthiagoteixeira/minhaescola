<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpListas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpListas))
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.bwMaisEscola = New System.ComponentModel.BackgroundWorker()
        Me.barra = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.pbProcurar = New DevExpress.XtraEditors.PictureEdit()
        Me.lbArquivo = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lstArquivos = New System.Windows.Forms.ListBox()
        Me.lstTurma = New System.Windows.Forms.ListBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbArquivos = New DevExpress.XtraEditors.LabelControl()
        Me.lbTurmas = New DevExpress.XtraEditors.LabelControl()
        Me.arquivoRefresh = New DevExpress.XtraEditors.PictureEdit()
        Me.arquivoRetira = New DevExpress.XtraEditors.PictureEdit()
        Me.turmaRefresh = New DevExpress.XtraEditors.PictureEdit()
        Me.turmaRetira = New DevExpress.XtraEditors.PictureEdit()
        Me.arquivoOrigDesce = New DevExpress.XtraEditors.PictureEdit()
        Me.arquivoOrigSobe = New DevExpress.XtraEditors.PictureEdit()
        Me.turmaDestDesce = New DevExpress.XtraEditors.PictureEdit()
        Me.turmaDestSobe = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbVTurmas = New DevExpress.XtraEditors.CheckEdit()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btImportar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.barra.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.pbProcurar.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lbArquivo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl2.SuspendLayout
        CType(Me.arquivoRefresh.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.arquivoRetira.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.turmaRefresh.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.turmaRetira.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.arquivoOrigDesce.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.arquivoOrigSobe.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.turmaDestDesce.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.turmaDestSobe.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbVTurmas.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'openFD
        '
        '
        'bwMaisEscola
        '
        '
        'barra
        '
        Me.barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barra.Location = New System.Drawing.Point(0, 536)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(390, 25)
        Me.barra.TabIndex = 218
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.pbProcurar)
        Me.GroupControl1.Controls.Add(Me.lbArquivo)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(366, 83)
        Me.GroupControl1.TabIndex = 219
        Me.GroupControl1.Text = "Localização da lista de alunos"
        '
        'pbProcurar
        '
        Me.pbProcurar.EditValue = CType(resources.GetObject("pbProcurar.EditValue"), Object)
        Me.pbProcurar.Location = New System.Drawing.Point(312, 40)
        Me.pbProcurar.Name = "pbProcurar"
        Me.pbProcurar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbProcurar.Size = New System.Drawing.Size(23, 23)
        Me.pbProcurar.TabIndex = 1
        '
        'lbArquivo
        '
        Me.lbArquivo.Location = New System.Drawing.Point(21, 40)
        Me.lbArquivo.Name = "lbArquivo"
        Me.lbArquivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbArquivo.Properties.Appearance.Options.UseFont = True
        Me.lbArquivo.Properties.ReadOnly = True
        Me.lbArquivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbArquivo.Size = New System.Drawing.Size(285, 22)
        Me.lbArquivo.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.lstArquivos)
        Me.GroupControl2.Controls.Add(Me.lstTurma)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.lbArquivos)
        Me.GroupControl2.Controls.Add(Me.lbTurmas)
        Me.GroupControl2.Controls.Add(Me.arquivoRefresh)
        Me.GroupControl2.Controls.Add(Me.arquivoRetira)
        Me.GroupControl2.Controls.Add(Me.turmaRefresh)
        Me.GroupControl2.Controls.Add(Me.turmaRetira)
        Me.GroupControl2.Controls.Add(Me.arquivoOrigDesce)
        Me.GroupControl2.Controls.Add(Me.arquivoOrigSobe)
        Me.GroupControl2.Controls.Add(Me.turmaDestDesce)
        Me.GroupControl2.Controls.Add(Me.turmaDestSobe)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 101)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(366, 378)
        Me.GroupControl2.TabIndex = 220
        Me.GroupControl2.Text = "Ordem das Turmas / Arquivos"
        '
        'lstArquivos
        '
        Me.lstArquivos.FormattingEnabled = True
        Me.lstArquivos.ItemHeight = 16
        Me.lstArquivos.Location = New System.Drawing.Point(184, 50)
        Me.lstArquivos.Name = "lstArquivos"
        Me.lstArquivos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstArquivos.Size = New System.Drawing.Size(120, 276)
        Me.lstArquivos.TabIndex = 227
        '
        'lstTurma
        '
        Me.lstTurma.FormattingEnabled = True
        Me.lstTurma.ItemHeight = 16
        Me.lstTurma.Location = New System.Drawing.Point(59, 50)
        Me.lstTurma.Name = "lstTurma"
        Me.lstTurma.Size = New System.Drawing.Size(120, 276)
        Me.lstTurma.TabIndex = 226
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(311, 349)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl5.TabIndex = 225
        Me.LabelControl5.Text = "arquivos"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(41, 349)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 223
        Me.LabelControl4.Text = "turmas"
        '
        'lbArquivos
        '
        Me.lbArquivos.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbArquivos.Appearance.Options.UseFont = True
        Me.lbArquivos.Location = New System.Drawing.Point(292, 349)
        Me.lbArquivos.Name = "lbArquivos"
        Me.lbArquivos.Size = New System.Drawing.Size(14, 13)
        Me.lbArquivos.TabIndex = 222
        Me.lbArquivos.Text = "00"
        '
        'lbTurmas
        '
        Me.lbTurmas.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTurmas.Appearance.Options.UseFont = True
        Me.lbTurmas.Location = New System.Drawing.Point(23, 349)
        Me.lbTurmas.Name = "lbTurmas"
        Me.lbTurmas.Size = New System.Drawing.Size(14, 13)
        Me.lbTurmas.TabIndex = 221
        Me.lbTurmas.Text = "00"
        '
        'arquivoRefresh
        '
        Me.arquivoRefresh.EditValue = CType(resources.GetObject("arquivoRefresh.EditValue"), Object)
        Me.arquivoRefresh.Location = New System.Drawing.Point(185, 332)
        Me.arquivoRefresh.Name = "arquivoRefresh"
        Me.arquivoRefresh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.arquivoRefresh.Size = New System.Drawing.Size(30, 30)
        Me.arquivoRefresh.TabIndex = 11
        '
        'arquivoRetira
        '
        Me.arquivoRetira.EditValue = CType(resources.GetObject("arquivoRetira.EditValue"), Object)
        Me.arquivoRetira.Location = New System.Drawing.Point(221, 332)
        Me.arquivoRetira.Name = "arquivoRetira"
        Me.arquivoRetira.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.arquivoRetira.Size = New System.Drawing.Size(30, 30)
        Me.arquivoRetira.TabIndex = 10
        '
        'turmaRefresh
        '
        Me.turmaRefresh.EditValue = CType(resources.GetObject("turmaRefresh.EditValue"), Object)
        Me.turmaRefresh.Location = New System.Drawing.Point(149, 332)
        Me.turmaRefresh.Name = "turmaRefresh"
        Me.turmaRefresh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.turmaRefresh.Size = New System.Drawing.Size(30, 30)
        Me.turmaRefresh.TabIndex = 9
        '
        'turmaRetira
        '
        Me.turmaRetira.EditValue = CType(resources.GetObject("turmaRetira.EditValue"), Object)
        Me.turmaRetira.Location = New System.Drawing.Point(113, 332)
        Me.turmaRetira.Name = "turmaRetira"
        Me.turmaRetira.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.turmaRetira.Size = New System.Drawing.Size(30, 30)
        Me.turmaRetira.TabIndex = 8
        '
        'arquivoOrigDesce
        '
        Me.arquivoOrigDesce.Cursor = System.Windows.Forms.Cursors.Default
        Me.arquivoOrigDesce.EditValue = CType(resources.GetObject("arquivoOrigDesce.EditValue"), Object)
        Me.arquivoOrigDesce.Location = New System.Drawing.Point(311, 294)
        Me.arquivoOrigDesce.Name = "arquivoOrigDesce"
        Me.arquivoOrigDesce.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.arquivoOrigDesce.Size = New System.Drawing.Size(30, 30)
        Me.arquivoOrigDesce.TabIndex = 7
        '
        'arquivoOrigSobe
        '
        Me.arquivoOrigSobe.Cursor = System.Windows.Forms.Cursors.Default
        Me.arquivoOrigSobe.EditValue = CType(resources.GetObject("arquivoOrigSobe.EditValue"), Object)
        Me.arquivoOrigSobe.Location = New System.Drawing.Point(311, 255)
        Me.arquivoOrigSobe.Name = "arquivoOrigSobe"
        Me.arquivoOrigSobe.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.arquivoOrigSobe.Size = New System.Drawing.Size(30, 30)
        Me.arquivoOrigSobe.TabIndex = 6
        '
        'turmaDestDesce
        '
        Me.turmaDestDesce.EditValue = CType(resources.GetObject("turmaDestDesce.EditValue"), Object)
        Me.turmaDestDesce.Location = New System.Drawing.Point(23, 294)
        Me.turmaDestDesce.Name = "turmaDestDesce"
        Me.turmaDestDesce.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.turmaDestDesce.Size = New System.Drawing.Size(30, 30)
        Me.turmaDestDesce.TabIndex = 5
        '
        'turmaDestSobe
        '
        Me.turmaDestSobe.Cursor = System.Windows.Forms.Cursors.Default
        Me.turmaDestSobe.EditValue = CType(resources.GetObject("turmaDestSobe.EditValue"), Object)
        Me.turmaDestSobe.Location = New System.Drawing.Point(23, 255)
        Me.turmaDestSobe.Name = "turmaDestSobe"
        Me.turmaDestSobe.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.turmaDestSobe.Size = New System.Drawing.Size(30, 30)
        Me.turmaDestSobe.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(183, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Arquivos encontrados"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(64, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Turmas disponíveis"
        '
        'cbVTurmas
        '
        Me.cbVTurmas.EditValue = True
        Me.cbVTurmas.Location = New System.Drawing.Point(12, 508)
        Me.cbVTurmas.Name = "cbVTurmas"
        Me.cbVTurmas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVTurmas.Properties.Appearance.Options.UseFont = True
        Me.cbVTurmas.Properties.Caption = "Visualizar lista após a importação"
        Me.cbVTurmas.Size = New System.Drawing.Size(221, 20)
        Me.cbVTurmas.TabIndex = 221
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2017, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(320, 482)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAno.Properties.Appearance.Options.UseFont = True
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = False
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(56, 22)
        Me.tAno.TabIndex = 222
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(240, 485)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl3.TabIndex = 223
        Me.LabelControl3.Text = "Ano Vigente:"
        '
        'btImportar
        '
        Me.btImportar.Location = New System.Drawing.Point(301, 508)
        Me.btImportar.Name = "btImportar"
        Me.btImportar.Size = New System.Drawing.Size(75, 23)
        Me.btImportar.TabIndex = 224
        Me.btImportar.Text = "Importar!"
        '
        'frmImpListas
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(390, 561)
        Me.Controls.Add(Me.btImportar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.cbVTurmas)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barra)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpListas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Relação de Alunos em PDF"
        CType(Me.barra.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        CType(Me.pbProcurar.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lbArquivo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(false)
        Me.GroupControl2.PerformLayout
        CType(Me.arquivoRefresh.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.arquivoRetira.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.turmaRefresh.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.turmaRetira.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.arquivoOrigDesce.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.arquivoOrigSobe.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.turmaDestDesce.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.turmaDestSobe.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbVTurmas.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents openFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bwMaisEscola As System.ComponentModel.BackgroundWorker
    Friend WithEvents barra As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pbProcurar As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lbArquivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents arquivoRefresh As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents arquivoRetira As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents turmaRefresh As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents turmaRetira As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents arquivoOrigDesce As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents arquivoOrigSobe As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents turmaDestDesce As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents turmaDestSobe As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbTurmas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbVTurmas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbArquivos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstArquivos As System.Windows.Forms.ListBox
    Friend WithEvents lstTurma As System.Windows.Forms.ListBox
End Class
