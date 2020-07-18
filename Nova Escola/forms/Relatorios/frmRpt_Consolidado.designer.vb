<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt_Consolidado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpt_Consolidado))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nroBimestre = New DevExpress.XtraEditors.SpinEdit()
        Me.cbAF = New DevExpress.XtraEditors.CheckButton()
        Me.btMenos = New DevExpress.XtraEditors.SimpleButton()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btMais = New DevExpress.XtraEditors.SimpleButton()
        Me.cbDisciplina = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbTurma = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tAno = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gridConsolidado = New DevExpress.XtraGrid.GridControl()
        Me.viewConsolidado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nroBimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDisciplina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Turma:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nroBimestre)
        Me.GroupBox1.Controls.Add(Me.cbAF)
        Me.GroupBox1.Controls.Add(Me.btMenos)
        Me.GroupBox1.Controls.Add(Me.btImprimir)
        Me.GroupBox1.Controls.Add(Me.btMais)
        Me.GroupBox1.Controls.Add(Me.cbDisciplina)
        Me.GroupBox1.Controls.Add(Me.cbTurma)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tAno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'nroBimestre
        '
        Me.nroBimestre.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroBimestre.Location = New System.Drawing.Point(205, 15)
        Me.nroBimestre.Name = "nroBimestre"
        Me.nroBimestre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nroBimestre.Properties.Appearance.Options.UseFont = True
        Me.nroBimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nroBimestre.Properties.IsFloatValue = False
        Me.nroBimestre.Properties.Mask.EditMask = "N00"
        Me.nroBimestre.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nroBimestre.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nroBimestre.Size = New System.Drawing.Size(34, 22)
        Me.nroBimestre.TabIndex = 188
        '
        'cbAF
        '
        Me.cbAF.AutoSize = True
        Me.cbAF.Enabled = False
        Me.cbAF.Location = New System.Drawing.Point(246, 16)
        Me.cbAF.Name = "cbAF"
        Me.cbAF.Size = New System.Drawing.Size(20, 22)
        Me.cbAF.TabIndex = 13
        Me.cbAF.Text = "AF"
        '
        'btMenos
        '
        Me.btMenos.AutoSize = True
        Me.btMenos.Image = CType(resources.GetObject("btMenos.Image"), System.Drawing.Image)
        Me.btMenos.Location = New System.Drawing.Point(246, 69)
        Me.btMenos.Name = "btMenos"
        Me.btMenos.Size = New System.Drawing.Size(22, 22)
        Me.btMenos.TabIndex = 12
        '
        'btImprimir
        '
        Me.btImprimir.Enabled = False
        Me.btImprimir.Location = New System.Drawing.Point(165, 96)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btImprimir.TabIndex = 11
        Me.btImprimir.Text = "Imprimir!"
        '
        'btMais
        '
        Me.btMais.AutoSize = True
        Me.btMais.Image = CType(resources.GetObject("btMais.Image"), System.Drawing.Image)
        Me.btMais.Location = New System.Drawing.Point(246, 43)
        Me.btMais.Name = "btMais"
        Me.btMais.Size = New System.Drawing.Size(22, 22)
        Me.btMais.TabIndex = 10
        '
        'cbDisciplina
        '
        Me.cbDisciplina.Location = New System.Drawing.Point(75, 70)
        Me.cbDisciplina.Name = "cbDisciplina"
        Me.cbDisciplina.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDisciplina.Properties.NullText = ""
        Me.cbDisciplina.Size = New System.Drawing.Size(165, 20)
        Me.cbDisciplina.TabIndex = 9
        '
        'cbTurma
        '
        Me.cbTurma.Location = New System.Drawing.Point(75, 43)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTurma.Properties.NullText = ""
        Me.cbTurma.Size = New System.Drawing.Size(165, 20)
        Me.cbTurma.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Disciplina:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bimestre:"
        '
        'tAno
        '
        Me.tAno.Location = New System.Drawing.Point(75, 16)
        Me.tAno.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.tAno.Minimum = New Decimal(New Integer() {2007, 0, 0, 0})
        Me.tAno.Name = "tAno"
        Me.tAno.Size = New System.Drawing.Size(53, 21)
        Me.tAno.TabIndex = 1
        Me.tAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tAno.Value = New Decimal(New Integer() {2009, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ano:"
        '
        'gridConsolidado
        '
        Me.gridConsolidado.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridConsolidado.Location = New System.Drawing.Point(0, 0)
        Me.gridConsolidado.MainView = Me.viewConsolidado
        Me.gridConsolidado.Name = "gridConsolidado"
        Me.gridConsolidado.Size = New System.Drawing.Size(311, 212)
        Me.gridConsolidado.TabIndex = 1
        Me.gridConsolidado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewConsolidado})
        '
        'viewConsolidado
        '
        Me.viewConsolidado.GridControl = Me.gridConsolidado
        Me.viewConsolidado.Name = "viewConsolidado"
        Me.viewConsolidado.OptionsView.ShowGroupPanel = False
        '
        'frmRpt_Consolidado
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(311, 360)
        Me.Controls.Add(Me.gridConsolidado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRpt_Consolidado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imprimir Consolidado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nroBimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDisciplina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTurma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tAno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    ' Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    ' Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    ' Friend WithEvents cbTurma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
   ' Friend WithEvents btMenos As DevComponents.DotNetBar.ButtonX
   '  Friend WithEvents btMais As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tAno As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    ' Friend WithEvents cbDisciplina As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridConsolidado As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewConsolidado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btMais As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbDisciplina As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbTurma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btMenos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbAF As DevExpress.XtraEditors.CheckButton
    Friend WithEvents nroBimestre As DevExpress.XtraEditors.SpinEdit
    ' Friend WithEvents DGGrupo As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
