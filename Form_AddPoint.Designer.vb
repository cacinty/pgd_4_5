<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AddPoint
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
        Me.txtTitik_Y = New System.Windows.Forms.TextBox()
        Me.txtTitik_X = New System.Windows.Forms.TextBox()
        Me.lblTitik_Y = New System.Windows.Forms.Label()
        Me.lblTitik_X = New System.Windows.Forms.Label()
        Me.rdoTitik_Keyboard = New System.Windows.Forms.RadioButton()
        Me.rdoTitik_Cursor = New System.Windows.Forms.RadioButton()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtShapeIndex = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.txtAtasNama = New System.Windows.Forms.TextBox()
        Me.txtJenisAset = New System.Windows.Forms.TextBox()
        Me.txtNamaAset = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.lblAtasNama = New System.Windows.Forms.Label()
        Me.lblJenisAset = New System.Windows.Forms.Label()
        Me.lblNamaAset = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.cmdFullExtent = New System.Windows.Forms.Button()
        Me.cmdPan = New System.Windows.Forms.Button()
        Me.cmdZoomOut = New System.Windows.Forms.Button()
        Me.cmdZoomIn = New System.Windows.Forms.Button()
        Me.Map1 = New DotSpatial.Controls.Map()
        Me.SuspendLayout()
        '
        'txtTitik_Y
        '
        Me.txtTitik_Y.Location = New System.Drawing.Point(468, 62)
        Me.txtTitik_Y.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitik_Y.Name = "txtTitik_Y"
        Me.txtTitik_Y.Size = New System.Drawing.Size(99, 22)
        Me.txtTitik_Y.TabIndex = 71
        '
        'txtTitik_X
        '
        Me.txtTitik_X.Location = New System.Drawing.Point(325, 65)
        Me.txtTitik_X.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitik_X.Name = "txtTitik_X"
        Me.txtTitik_X.Size = New System.Drawing.Size(99, 22)
        Me.txtTitik_X.TabIndex = 70
        '
        'lblTitik_Y
        '
        Me.lblTitik_Y.AutoSize = True
        Me.lblTitik_Y.Location = New System.Drawing.Point(439, 65)
        Me.lblTitik_Y.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitik_Y.Name = "lblTitik_Y"
        Me.lblTitik_Y.Size = New System.Drawing.Size(21, 17)
        Me.lblTitik_Y.TabIndex = 69
        Me.lblTitik_Y.Text = "Y:"
        '
        'lblTitik_X
        '
        Me.lblTitik_X.AutoSize = True
        Me.lblTitik_X.Location = New System.Drawing.Point(289, 65)
        Me.lblTitik_X.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitik_X.Name = "lblTitik_X"
        Me.lblTitik_X.Size = New System.Drawing.Size(25, 17)
        Me.lblTitik_X.TabIndex = 68
        Me.lblTitik_X.Text = "X :"
        '
        'rdoTitik_Keyboard
        '
        Me.rdoTitik_Keyboard.AutoSize = True
        Me.rdoTitik_Keyboard.Location = New System.Drawing.Point(16, 65)
        Me.rdoTitik_Keyboard.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTitik_Keyboard.Name = "rdoTitik_Keyboard"
        Me.rdoTitik_Keyboard.Size = New System.Drawing.Size(217, 21)
        Me.rdoTitik_Keyboard.TabIndex = 67
        Me.rdoTitik_Keyboard.TabStop = True
        Me.rdoTitik_Keyboard.Text = "Input menggunakan keyboard"
        Me.rdoTitik_Keyboard.UseVisualStyleBackColor = True
        '
        'rdoTitik_Cursor
        '
        Me.rdoTitik_Cursor.AutoSize = True
        Me.rdoTitik_Cursor.Location = New System.Drawing.Point(16, 18)
        Me.rdoTitik_Cursor.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTitik_Cursor.Name = "rdoTitik_Cursor"
        Me.rdoTitik_Cursor.Size = New System.Drawing.Size(280, 21)
        Me.rdoTitik_Cursor.TabIndex = 66
        Me.rdoTitik_Cursor.TabStop = True
        Me.rdoTitik_Cursor.Text = "Digitasi on screen menggunakan cursor"
        Me.rdoTitik_Cursor.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(275, 567)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 28)
        Me.cmdSave.TabIndex = 65
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(383, 567)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 28)
        Me.cmdCancel.TabIndex = 64
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtShapeIndex
        '
        Me.txtShapeIndex.Location = New System.Drawing.Point(15, 567)
        Me.txtShapeIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShapeIndex.Name = "txtShapeIndex"
        Me.txtShapeIndex.Size = New System.Drawing.Size(112, 22)
        Me.txtShapeIndex.TabIndex = 63
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(443, 529)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(100, 28)
        Me.cmdBrowse.TabIndex = 62
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(81, 532)
        Me.txtFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(343, 22)
        Me.txtFoto.TabIndex = 61
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(36, 535)
        Me.lblFoto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(36, 17)
        Me.lblFoto.TabIndex = 60
        Me.lblFoto.Text = "Foto"
        '
        'txtAtasNama
        '
        Me.txtAtasNama.Location = New System.Drawing.Point(199, 495)
        Me.txtAtasNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAtasNama.Name = "txtAtasNama"
        Me.txtAtasNama.Size = New System.Drawing.Size(343, 22)
        Me.txtAtasNama.TabIndex = 59
        '
        'txtJenisAset
        '
        Me.txtJenisAset.Location = New System.Drawing.Point(199, 465)
        Me.txtJenisAset.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJenisAset.Name = "txtJenisAset"
        Me.txtJenisAset.Size = New System.Drawing.Size(343, 22)
        Me.txtJenisAset.TabIndex = 58
        '
        'txtNamaAset
        '
        Me.txtNamaAset.Location = New System.Drawing.Point(199, 434)
        Me.txtNamaAset.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaAset.Name = "txtNamaAset"
        Me.txtNamaAset.Size = New System.Drawing.Size(343, 22)
        Me.txtNamaAset.TabIndex = 57
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(199, 406)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(343, 22)
        Me.txtKode.TabIndex = 56
        '
        'lblAtasNama
        '
        Me.lblAtasNama.AutoSize = True
        Me.lblAtasNama.Location = New System.Drawing.Point(40, 498)
        Me.lblAtasNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAtasNama.Name = "lblAtasNama"
        Me.lblAtasNama.Size = New System.Drawing.Size(77, 17)
        Me.lblAtasNama.TabIndex = 55
        Me.lblAtasNama.Text = "Atas Nama"
        '
        'lblJenisAset
        '
        Me.lblJenisAset.AutoSize = True
        Me.lblJenisAset.Location = New System.Drawing.Point(40, 469)
        Me.lblJenisAset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJenisAset.Name = "lblJenisAset"
        Me.lblJenisAset.Size = New System.Drawing.Size(73, 17)
        Me.lblJenisAset.TabIndex = 54
        Me.lblJenisAset.Text = "Jenis Aset"
        '
        'lblNamaAset
        '
        Me.lblNamaAset.AutoSize = True
        Me.lblNamaAset.Location = New System.Drawing.Point(40, 438)
        Me.lblNamaAset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamaAset.Name = "lblNamaAset"
        Me.lblNamaAset.Size = New System.Drawing.Size(77, 17)
        Me.lblNamaAset.TabIndex = 53
        Me.lblNamaAset.Text = "Nama Aset"
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Location = New System.Drawing.Point(40, 410)
        Me.lblKode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(41, 17)
        Me.lblKode.TabIndex = 52
        Me.lblKode.Text = "Kode"
        '
        'cmdFullExtent
        '
        Me.cmdFullExtent.Location = New System.Drawing.Point(468, 240)
        Me.cmdFullExtent.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFullExtent.Name = "cmdFullExtent"
        Me.cmdFullExtent.Size = New System.Drawing.Size(100, 28)
        Me.cmdFullExtent.TabIndex = 51
        Me.cmdFullExtent.Text = "Full Extent"
        Me.cmdFullExtent.UseVisualStyleBackColor = True
        '
        'cmdPan
        '
        Me.cmdPan.Location = New System.Drawing.Point(468, 204)
        Me.cmdPan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPan.Name = "cmdPan"
        Me.cmdPan.Size = New System.Drawing.Size(100, 28)
        Me.cmdPan.TabIndex = 50
        Me.cmdPan.Text = "Pan"
        Me.cmdPan.UseVisualStyleBackColor = True
        '
        'cmdZoomOut
        '
        Me.cmdZoomOut.Location = New System.Drawing.Point(468, 169)
        Me.cmdZoomOut.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdZoomOut.Name = "cmdZoomOut"
        Me.cmdZoomOut.Size = New System.Drawing.Size(100, 28)
        Me.cmdZoomOut.TabIndex = 49
        Me.cmdZoomOut.Text = "ZoomOut"
        Me.cmdZoomOut.UseVisualStyleBackColor = True
        '
        'cmdZoomIn
        '
        Me.cmdZoomIn.Location = New System.Drawing.Point(468, 133)
        Me.cmdZoomIn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdZoomIn.Name = "cmdZoomIn"
        Me.cmdZoomIn.Size = New System.Drawing.Size(100, 28)
        Me.cmdZoomIn.TabIndex = 48
        Me.cmdZoomIn.Text = "Zoom In"
        Me.cmdZoomIn.UseVisualStyleBackColor = True
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
        Me.Map1.Location = New System.Drawing.Point(15, 118)
        Me.Map1.Margin = New System.Windows.Forms.Padding(4)
        Me.Map1.Name = "Map1"
        Me.Map1.ProgressHandler = Nothing
        Me.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.RedrawLayersWhileResizing = False
        Me.Map1.SelectionEnabled = True
        Me.Map1.Size = New System.Drawing.Size(445, 260)
        Me.Map1.TabIndex = 72
        Me.Map1.ZoomOutFartherThanMaxExtent = False
        '
        'Form_AddPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 618)
        Me.Controls.Add(Me.Map1)
        Me.Controls.Add(Me.txtTitik_Y)
        Me.Controls.Add(Me.txtTitik_X)
        Me.Controls.Add(Me.lblTitik_Y)
        Me.Controls.Add(Me.lblTitik_X)
        Me.Controls.Add(Me.rdoTitik_Keyboard)
        Me.Controls.Add(Me.rdoTitik_Cursor)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtShapeIndex)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.txtAtasNama)
        Me.Controls.Add(Me.txtJenisAset)
        Me.Controls.Add(Me.txtNamaAset)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.lblAtasNama)
        Me.Controls.Add(Me.lblJenisAset)
        Me.Controls.Add(Me.lblNamaAset)
        Me.Controls.Add(Me.lblKode)
        Me.Controls.Add(Me.cmdFullExtent)
        Me.Controls.Add(Me.cmdPan)
        Me.Controls.Add(Me.cmdZoomOut)
        Me.Controls.Add(Me.cmdZoomIn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_AddPoint"
        Me.Text = "Tambah Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitik_Y As TextBox
    Friend WithEvents txtTitik_X As TextBox
    Friend WithEvents lblTitik_Y As Label
    Friend WithEvents lblTitik_X As Label
    Friend WithEvents rdoTitik_Keyboard As RadioButton
    Friend WithEvents rdoTitik_Cursor As RadioButton
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents txtShapeIndex As TextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents lblFoto As Label
    Friend WithEvents txtAtasNama As TextBox
    Friend WithEvents txtJenisAset As TextBox
    Friend WithEvents txtNamaAset As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents lblAtasNama As Label
    Friend WithEvents lblJenisAset As Label
    Friend WithEvents lblNamaAset As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents cmdFullExtent As Button
    Friend WithEvents cmdPan As Button
    Friend WithEvents cmdZoomOut As Button
    Friend WithEvents cmdZoomIn As Button
    Friend WithEvents Map1 As DotSpatial.Controls.Map
End Class
