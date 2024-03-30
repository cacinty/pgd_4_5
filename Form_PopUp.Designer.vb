<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PopUp
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
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdDetele = New System.Windows.Forms.Button()
        Me.txtShapeIndex = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtfoto = New System.Windows.Forms.TextBox()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.txtAtasNama = New System.Windows.Forms.TextBox()
        Me.txtJenisAset = New System.Windows.Forms.TextBox()
        Me.txtNamaAset = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblJenisAset = New System.Windows.Forms.Label()
        Me.lblNamaAset = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.cmdFullExtent = New System.Windows.Forms.Button()
        Me.cmdPan = New System.Windows.Forms.Button()
        Me.cmdZoomOut = New System.Windows.Forms.Button()
        Me.cmdZoomIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Map1 = New DotSpatial.Controls.Map()
        Me.SuspendLayout()
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(279, 510)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(100, 28)
        Me.cmdEdit.TabIndex = 41
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(419, 510)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 28)
        Me.cmdCancel.TabIndex = 40
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdDetele
        '
        Me.cmdDetele.Location = New System.Drawing.Point(153, 510)
        Me.cmdDetele.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDetele.Name = "cmdDetele"
        Me.cmdDetele.Size = New System.Drawing.Size(100, 28)
        Me.cmdDetele.TabIndex = 39
        Me.cmdDetele.Text = "Detele"
        Me.cmdDetele.UseVisualStyleBackColor = True
        '
        'txtShapeIndex
        '
        Me.txtShapeIndex.Location = New System.Drawing.Point(16, 510)
        Me.txtShapeIndex.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtShapeIndex.Name = "txtShapeIndex"
        Me.txtShapeIndex.Size = New System.Drawing.Size(112, 22)
        Me.txtShapeIndex.TabIndex = 38
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(419, 471)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(100, 28)
        Me.cmdBrowse.TabIndex = 37
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtfoto
        '
        Me.txtfoto.Location = New System.Drawing.Point(57, 474)
        Me.txtfoto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfoto.Name = "txtfoto"
        Me.txtfoto.Size = New System.Drawing.Size(343, 22)
        Me.txtfoto.TabIndex = 36
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(12, 478)
        Me.lblFoto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(36, 17)
        Me.lblFoto.TabIndex = 35
        Me.lblFoto.Text = "Foto"
        '
        'txtAtasNama
        '
        Me.txtAtasNama.Location = New System.Drawing.Point(175, 437)
        Me.txtAtasNama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAtasNama.Name = "txtAtasNama"
        Me.txtAtasNama.Size = New System.Drawing.Size(343, 22)
        Me.txtAtasNama.TabIndex = 34
        '
        'txtJenisAset
        '
        Me.txtJenisAset.Location = New System.Drawing.Point(175, 407)
        Me.txtJenisAset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJenisAset.Name = "txtJenisAset"
        Me.txtJenisAset.Size = New System.Drawing.Size(343, 22)
        Me.txtJenisAset.TabIndex = 33
        '
        'txtNamaAset
        '
        Me.txtNamaAset.Location = New System.Drawing.Point(175, 377)
        Me.txtNamaAset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaAset.Name = "txtNamaAset"
        Me.txtNamaAset.Size = New System.Drawing.Size(343, 22)
        Me.txtNamaAset.TabIndex = 32
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(175, 348)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(343, 22)
        Me.txtKode.TabIndex = 31
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(16, 441)
        Me.lblAlamat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(51, 17)
        Me.lblAlamat.TabIndex = 30
        Me.lblAlamat.Text = "Alamat"
        '
        'lblJenisAset
        '
        Me.lblJenisAset.AutoSize = True
        Me.lblJenisAset.Location = New System.Drawing.Point(16, 411)
        Me.lblJenisAset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJenisAset.Name = "lblJenisAset"
        Me.lblJenisAset.Size = New System.Drawing.Size(73, 17)
        Me.lblJenisAset.TabIndex = 29
        Me.lblJenisAset.Text = "Jenis Aset"
        '
        'lblNamaAset
        '
        Me.lblNamaAset.AutoSize = True
        Me.lblNamaAset.Location = New System.Drawing.Point(16, 380)
        Me.lblNamaAset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaAset.Name = "lblNamaAset"
        Me.lblNamaAset.Size = New System.Drawing.Size(77, 17)
        Me.lblNamaAset.TabIndex = 28
        Me.lblNamaAset.Text = "Nama Aset"
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Location = New System.Drawing.Point(16, 352)
        Me.lblKode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(41, 17)
        Me.lblKode.TabIndex = 27
        Me.lblKode.Text = "Kode"
        '
        'cmdFullExtent
        '
        Me.cmdFullExtent.Location = New System.Drawing.Point(457, 185)
        Me.cmdFullExtent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFullExtent.Name = "cmdFullExtent"
        Me.cmdFullExtent.Size = New System.Drawing.Size(100, 28)
        Me.cmdFullExtent.TabIndex = 26
        Me.cmdFullExtent.Text = "Full Extent"
        Me.cmdFullExtent.UseVisualStyleBackColor = True
        '
        'cmdPan
        '
        Me.cmdPan.Location = New System.Drawing.Point(457, 149)
        Me.cmdPan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdPan.Name = "cmdPan"
        Me.cmdPan.Size = New System.Drawing.Size(100, 28)
        Me.cmdPan.TabIndex = 25
        Me.cmdPan.Text = "Pan"
        Me.cmdPan.UseVisualStyleBackColor = True
        '
        'cmdZoomOut
        '
        Me.cmdZoomOut.Location = New System.Drawing.Point(457, 113)
        Me.cmdZoomOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdZoomOut.Name = "cmdZoomOut"
        Me.cmdZoomOut.Size = New System.Drawing.Size(100, 28)
        Me.cmdZoomOut.TabIndex = 24
        Me.cmdZoomOut.Text = "ZoomOut"
        Me.cmdZoomOut.UseVisualStyleBackColor = True
        '
        'cmdZoomIn
        '
        Me.cmdZoomIn.Location = New System.Drawing.Point(457, 78)
        Me.cmdZoomIn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdZoomIn.Name = "cmdZoomIn"
        Me.cmdZoomIn.Size = New System.Drawing.Size(100, 28)
        Me.cmdZoomIn.TabIndex = 23
        Me.cmdZoomIn.Text = "Zoom In"
        Me.cmdZoomIn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "INFORMASI"
        '
        'Map1
        '
        Me.Map1.AllowDrop = True
        Me.Map1.BackColor = System.Drawing.Color.White
        Me.Map1.CollectAfterDraw = False
        Me.Map1.CollisionDetection = False
        Me.Map1.ExtendBuffer = False
        Me.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map1.IsBusy = False
        Me.Map1.IsZoomedToMaxExtent = False
        Me.Map1.Legend = Nothing
        Me.Map1.Location = New System.Drawing.Point(16, 64)
        Me.Map1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Map1.Name = "Map1"
        Me.Map1.ProgressHandler = Nothing
        Me.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.RedrawLayersWhileResizing = False
        Me.Map1.SelectionEnabled = True
        Me.Map1.Size = New System.Drawing.Size(421, 255)
        Me.Map1.TabIndex = 42
        Me.Map1.ZoomOutFartherThanMaxExtent = False
        '
        'Form_PopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 549)
        Me.Controls.Add(Me.Map1)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDetele)
        Me.Controls.Add(Me.txtShapeIndex)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtfoto)
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.txtAtasNama)
        Me.Controls.Add(Me.txtJenisAset)
        Me.Controls.Add(Me.txtNamaAset)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblJenisAset)
        Me.Controls.Add(Me.lblNamaAset)
        Me.Controls.Add(Me.lblKode)
        Me.Controls.Add(Me.cmdFullExtent)
        Me.Controls.Add(Me.cmdPan)
        Me.Controls.Add(Me.cmdZoomOut)
        Me.Controls.Add(Me.cmdZoomIn)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_PopUp"
        Me.Text = "Informasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdDetele As Button
    Friend WithEvents txtShapeIndex As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents txtfoto As TextBox
    Friend WithEvents lblFoto As Label
    Friend WithEvents txtAtasNama As TextBox
    Friend WithEvents txtJenisAset As TextBox
    Friend WithEvents txtNamaAset As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJenisAset As Label
    Friend WithEvents lblNamaAset As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents cmdFullExtent As Button
    Friend WithEvents cmdPan As Button
    Friend WithEvents cmdZoomOut As Button
    Friend WithEvents cmdZoomIn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Map1 As DotSpatial.Controls.Map
End Class
