<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRpt_Declaracao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpt_Declaracao))
        Me.gridDeclaracao = New DevExpress.XtraGrid.GridControl()
        Me.viewDeclaracao = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.tAno = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.opcoesDeclaracao = New DevExpress.XtraEditors.RadioGroup()
        Me.horarioInicio = New DevExpress.XtraEditors.TextEdit()
        Me.horarioFinal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tbObservacao = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridDeclaracao,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.viewDeclaracao,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.opcoesDeclaracao.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.horarioInicio.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.horarioFinal.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbObservacao.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'gridDeclaracao
        '
        Me.gridDeclaracao.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridDeclaracao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDeclaracao.Location = New System.Drawing.Point(2, 23)
        Me.gridDeclaracao.MainView = Me.viewDeclaracao
        Me.gridDeclaracao.Name = "gridDeclaracao"
        Me.gridDeclaracao.Size = New System.Drawing.Size(351, 332)
        Me.gridDeclaracao.TabIndex = 165
        Me.gridDeclaracao.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewDeclaracao})
        '
        'viewDeclaracao
        '
        Me.viewDeclaracao.GridControl = Me.gridDeclaracao
        Me.viewDeclaracao.Name = "viewDeclaracao"
        Me.viewDeclaracao.OptionsFind.AlwaysVisible = true
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupControl1.Appearance.Options.UseFont = true
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = true
        Me.GroupControl1.Controls.Add(Me.gridDeclaracao)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(355, 357)
        Me.GroupControl1.TabIndex = 166
        Me.GroupControl1.Text = "Pesquisa"
        '
        'tAno
        '
        Me.tAno.EditValue = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.tAno.Location = New System.Drawing.Point(649, 106)
        Me.tAno.Name = "tAno"
        Me.tAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tAno.Properties.IsFloatValue = false
        Me.tAno.Properties.Mask.EditMask = "N00"
        Me.tAno.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.tAno.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.tAno.Size = New System.Drawing.Size(62, 20)
        Me.tAno.TabIndex = 167
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(581, 109)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 168
        Me.LabelControl1.Text = "Ano Vigente:"
        '
        'opcoesDeclaracao
        '
        Me.opcoesDeclaracao.Location = New System.Drawing.Point(363, 19)
        Me.opcoesDeclaracao.Name = "opcoesDeclaracao"
        Me.opcoesDeclaracao.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(4.0!, "Solicitação de Vaga"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5.0!, "Transferência"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1.0!, "Matrícula - Regular"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2.0!, "Matrícula - Não Regular"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3.0!, "Matrícula - Conclusão")})
        Me.opcoesDeclaracao.Size = New System.Drawing.Size(360, 117)
        Me.opcoesDeclaracao.TabIndex = 169
        '
        'horarioInicio
        '
        Me.horarioInicio.EditValue = "07:00"
        Me.horarioInicio.Location = New System.Drawing.Point(485, 67)
        Me.horarioInicio.Name = "horarioInicio"
        Me.horarioInicio.Properties.DisplayFormat.FormatString = "t"
        Me.horarioInicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.horarioInicio.Properties.EditFormat.FormatString = "t"
        Me.horarioInicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.horarioInicio.Properties.Mask.EditMask = "t"
        Me.horarioInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.horarioInicio.Size = New System.Drawing.Size(37, 20)
        Me.horarioInicio.TabIndex = 170
        '
        'horarioFinal
        '
        Me.horarioFinal.EditValue = "11:30"
        Me.horarioFinal.Location = New System.Drawing.Point(536, 67)
        Me.horarioFinal.Name = "horarioFinal"
        Me.horarioFinal.Properties.DisplayFormat.FormatString = "t"
        Me.horarioFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.horarioFinal.Properties.EditFormat.FormatString = "t"
        Me.horarioFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.horarioFinal.Properties.Mask.EditMask = "t"
        Me.horarioFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.horarioFinal.Size = New System.Drawing.Size(37, 20)
        Me.horarioFinal.TabIndex = 171
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(526, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl2.TabIndex = 172
        Me.LabelControl2.Text = "-"
        '
        'tbObservacao
        '
        Me.tbObservacao.EditValue = "-"
        Me.tbObservacao.Location = New System.Drawing.Point(363, 161)
        Me.tbObservacao.Name = "tbObservacao"
        Me.tbObservacao.Size = New System.Drawing.Size(360, 156)
        Me.tbObservacao.TabIndex = 174
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(366, 146)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl3.TabIndex = 175
        Me.LabelControl3.Text = "Observação:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(648, 326)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 176
        Me.SimpleButton1.Text = "Visualizar!"
        '
        'frmRpt_Declaracao
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(730, 357)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tbObservacao)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.horarioFinal)
        Me.Controls.Add(Me.horarioInicio)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tAno)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.opcoesDeclaracao)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRpt_Declaracao"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório - Declaração Escolar"
        CType(Me.gridDeclaracao,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.viewDeclaracao,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        CType(Me.tAno.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.opcoesDeclaracao.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.horarioInicio.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.horarioFinal.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbObservacao.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents gridDeclaracao As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewDeclaracao As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tAno As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents opcoesDeclaracao As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents horarioInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents horarioFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbObservacao As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
