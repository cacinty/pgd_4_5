'Impor Library pengembang aplikasi
Imports DotSpatial.Controls
Imports DotSpatial.Data
Imports DotSpatial.Symbology
Imports DotSpatial.Topology
Imports BruTile
Imports DotSpatial.Plugins.WebMap

Public Class FormMainWindow

    'Pendefisian Variabel dan dan Properti
    Public AppPath As String = Application.ExecutablePath
    Public ResourcePath As String = ("D:\01. UGM_SIG\SEMESTER 2\01. PRAKTIKUM PEMROGRAMAN GEOSPASIAL DESKTOP\Acara 4 dan 5\project\SiBangSa\SiBangSa\PGD_A_45\Resource")
    Public lyrAset As MapPointLayer
    Public lyrJalan As MapLineLayer
    Public lyrAdmin As MapPolygonLayer
    Public iselect(,) As String
    Public iselectnumd As Integer = 0
    Public totalselected As Integer
    Public selectnext As String = "salah"
    Public fullextentclick As String = "salah"
    Public sedangload As Boolean = False
    Public pointLayerTemplate As MapPointLayer
    Public pointFeatureTemplate As New FeatureSet(FeatureType.Point)
    Public Property KryptonRibbonGroupComboBoxQueryKecamatan As Object

    Private Sub FormMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sedangload = True

            'ADD LAYER BATAS ADMIN 
            lyrAdmin = Map1.Layers.Add(ResourcePath & "\Database\Data Spasial\shp_desa_yogyakarta.shp")
            lyrAdmin.LegendText = "Batas Administrasi"
            lyrAdmin.FeatureSet.AddFid()
            lyrAdmin.FeatureSet.Save()
            lyrAdmin.SelectionEnabled = True

            Dim schemeAdmin As New PolygonScheme
            schemeAdmin.EditorSettings.ClassificationType = ClassificationType.UniqueValues
            schemeAdmin.EditorSettings.UseGradient = False
            schemeAdmin.EditorSettings.FieldName = "NAMOBJ"
            schemeAdmin.CreateCategories(lyrAdmin.DataSet.DataTable)

            For Each ifc As IFeatureCategory In schemeAdmin.GetCategories
                ifc.SetColor(Color.FromArgb(255, ifc.GetColor))
            Next

            lyrAdmin.Symbology = schemeAdmin



            'ADD LAYER JARINGAN JALAN
            lyrJalan = Map1.Layers.Add(ResourcePath & "\Database\Data Spasial\jalan_yogyakarta.shp")
            lyrJalan.LegendText = "Jaringan Jalan"
            lyrJalan.FeatureSet.AddFid()
            lyrJalan.FeatureSet.Save()
            lyrJalan.SelectionEnabled = False

            Dim schemeJalan As New LineScheme
            schemeJalan.ClearCategories()

            Dim symbolizerJalanKolektor As New LineSymbolizer(Color.FromArgb(255, 127, 0), Color.Gray, 3, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)
            symbolizerJalanKolektor.ScaleMode = ScaleMode.Simple
            Dim categoryJalanKolektor As New LineCategory(symbolizerJalanKolektor)
            categoryJalanKolektor.FilterExpression = "[REMARK] = 'Jalan Kolektor'"
            categoryJalanKolektor.LegendText = "Jalan Kolektor"
            schemeJalan.AddCategory(categoryJalanKolektor)

            Dim symbolizerJalanLokal As New LineSymbolizer(Color.FromArgb(178, 178, 255), Color.Transparent, 2, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)
            symbolizerJalanLokal.ScaleMode = ScaleMode.Simple
            Dim categoryJalanLokal As New LineCategory(symbolizerJalanLokal)
            categoryJalanLokal.FilterExpression = "[REMARK] = 'Jalan Lokal'"
            categoryJalanLokal.LegendText = "Jalan Lokal"
            schemeJalan.AddCategory(categoryJalanLokal)

            Dim symbolizerJalanLain As New LineSymbolizer(Color.FromArgb(232, 190, 255), Color.Transparent, 1.5, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)
            symbolizerJalanLain.ScaleMode = ScaleMode.Simple
            Dim categoryJalanLain As New LineCategory(symbolizerJalanLain)
            categoryJalanLain.FilterExpression = "[REMARK] = 'Jalan Lain'"
            categoryJalanLain.LegendText = "Jalan Lain"
            schemeJalan.AddCategory(categoryJalanLain)

            For Each ifc As IFeatureCategory In schemeJalan.GetCategories
                ifc.SetColor(Color.FromArgb(255, ifc.GetColor))
            Next

            lyrJalan.Symbology = schemeJalan

            'ADD LAYER SAMPAH
            lyrAset = Map1.Layers.Add(ResourcePath & "\Database\Data Spasial\titik_bank_sampah.shp")
            lyrAset.LegendText = "Bank Sampah"
            lyrAset.FeatureSet.AddFid()
            lyrAset.FeatureSet.Save()

            Dim schemeSampah As New PointScheme
            schemeSampah.ClearCategories()

            Dim imageSampah As Image = Image.FromFile(ResourcePath & "\Database\Data NonSpatial\Icon\sampah.png")
            Dim symbolizerSampah As New PointSymbolizer(imageSampah, 20)
            symbolizerSampah.ScaleMode = ScaleMode.Simple
            Dim categoryPos As New PointCategory(symbolizerSampah)
            categoryPos.FilterExpression = "[Shape] = 'Point ZM'"
            categoryPos.LegendText = "Titik Sampah"
            schemeSampah.AddCategory(categoryPos)

            lyrAset.Symbology = schemeSampah



            'ADD LAYER TEMPLATE (menampilkan titik pada peta)
            pointLayerTemplate = Map1.Layers.Add(pointFeatureTemplate)
            Dim pointsymbol As New PointSymbolizer(Color.FromArgb(175, 75, 230, 0), DotSpatial.Symbology.PointShape.Star, 12)
            pointLayerTemplate.Symbolizer = pointsymbol
            pointLayerTemplate.LegendText = "point template"
            pointLayerTemplate.LegendItemVisible = False


            'LOAD ATTRIBUTE 
            Dim dt As DataTable
            dt = lyrAset.DataSet.DataTable
            DataGridView1.DataSource = dt


            'LOAD DATA QUERY  implementasi untuk memuat data query pada aplikasi 
            lyrAdmin.SelectAll()

            Dim ls1 As List(Of IFeature) = New List(Of IFeature)
            Dim il1 As ISelection = lyrAdmin.Selection

            ls1 = il1.ToFeatureList

            KryptonRibbonGroupComboBoxQueryKecamatan.Items.Clear()
            Dim i As Integer = 0
            Do While (i < il1.Count)
                Dim WADMKC As String = (ls1(i).DataRow.ItemArray.GetValue(6).ToString)
                KryptonRibbonGroupComboBoxQueryKecamatan.Items.Insert(i, WADMKC)
                i = (i + 1)
            Loop

            KryptonRibbonGroupComboBoxQueryKecamatan.Sorted = True
            Dim cboNumber As Integer = KryptonRibbonGroupComboBoxQueryKecamatan.Items.Count - 1
            Try
                For j = 1 To cboNumber
                    If j > (KryptonRibbonGroupComboBoxQueryKecamatan.Items.Count - 1) Then Exit For
                    If KryptonRibbonGroupComboBoxQueryKecamatan.Items(j) = KryptonRibbonGroupComboBoxQueryKecamatan.Items(j - 1) Then
                        KryptonRibbonGroupComboBoxQueryKecamatan.Items.RemoveAt(j)
                        j = j - 1
                        cboNumber = cboNumber - 1
                    End If
                Next
            Catch ex As Exception
            End Try

            KryptonRibbonGroupComboBoxQueryKecamatan.Sorted = True

            lyrAdmin.UnSelectAll()

            sedangload = False

        Catch ex As Exception
        End Try

    End Sub

    'Menangani perubahan pemilihan pada peta, dengan menampilkan informasi tambahan tentang fitur yang dipilih dalam sebuah formulir pop-up ketika mode identifikasi aktif.
    Private Sub Map1_SelectionChanged(sender As Object, e As EventArgs) Handles Map1.SelectionChanged
        Try
            If sedangload = True Then Exit Sub
            If KryptonRibbonGroupButton_Identify.Checked = True Then
                If lyrAset.Selection.Count = 0 Then
                    Call RemoveSelection()
                    Exit Sub
                Else
                    Form_PopUp.Show()
                    Call ShowPhoto()
                    Form_PopUp.BringToFront()
                    Form_PopUp.Activate()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Map1_MouseMove(sender As Object, e As MouseEventArgs) Handles Map1.MouseMove
        Try
            Dim coord As Coordinate = Map1.PixelToProj(e.Location)
            lblXY.Text = String.Format("X: {0} Y: {1}", coord.X, coord.Y)
        Catch ex As Exception
            MsgBox("Mohon maaf, terjadi kesalahan. " & ex.ToString & ". Error Number (" & Err.Number & ") 
            : " & vbCrLf & Err.Description, MsgBoxStyle.Critical, "SIM Jaringan Utilitas Kota Yogyakarta")
        End Try
    End Sub

    Private Sub Map1_MouseUp(sender As Object, e As MouseEventArgs) Handles Map1.MouseUp
        If KryptonRibbonGroupButton_AddPoint.Checked = True And Map1.Cursor = Cursors.Cross Then
            If Form_AddPoint.rdoTitik_Cursor.Checked = True Then
                If e.Button = MouseButtons.Left Then
                    sedangload = True
                    pointLayerTemplate.SelectAll()
                    pointLayerTemplate.RemoveSelectedFeatures()
                    Dim coord As Coordinate = Map1.PixelToProj(e.Location)
                    Dim point As New Point(coord)
                    Dim currentFeatures As IFeature = pointFeatureTemplate.AddFeature(point)
                    Form_AddPoint.txtTitik_X.Text = coord.X
                    Form_AddPoint.txtTitik_Y.Text = coord.Y
                    sedangload = False
                End If
                pointFeatureTemplate.InitializeVertices()
                pointLayerTemplate.DataSet.InitializeVertices()
                pointLayerTemplate.AssignFastDrawnStates()
                pointFeatureTemplate.UpdateExtent()
                pointLayerTemplate.DataSet.UpdateExtent()
                Map1.Refresh()
                Map1.ResetBuffer()
            End If
        End If
    End Sub



    'CURSOR MODE
    Private Sub KryptonRibbonGroupButton_NormalMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_NormalMode.Click
        If KryptonRibbonGroupButton_NormalMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
            'KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            KryptonRibbonGroupButton_Length.Checked = False
            KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomInMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomInMode.Click
        If KryptonRibbonGroupButton_ZoomInMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn
            KryptonRibbonGroupButton_NormalMode.Checked = False
            'KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            KryptonRibbonGroupButton_Length.Checked = False
            KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomOutMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomOutMode.Click
        If KryptonRibbonGroupButton_ZoomOutMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            'KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            KryptonRibbonGroupButton_Length.Checked = False
            KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_PanMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_PanMode.Click
        If KryptonRibbonGroupButton_PanMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            'KryptonRibbonGroupButton_PanMode.Checked = False
            KryptonRibbonGroupButton_Length.Checked = False
            KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_Identify_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Identify.Click
        KryptonRibbonGroupButton_Identify.Checked = True
        If KryptonRibbonGroupButton_Identify.Checked = True Then
            Map1.Cursor = Cursors.Cross
            Form_PopUp.Show()
            Form_PopUp.BringToFront()
            Form_PopUp.Activate()
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            KryptonRibbonGroupButton_Length.Checked = False
            KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            'KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_AddPoint_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_AddPoint.Click
        KryptonRibbonGroupButton_AddPoint.Checked = True
        If KryptonRibbonGroupButton_AddPoint.Checked = True Then
            Map1.Cursor = Cursors.Cross
            Form_AddPoint.Show()
            Form_AddPoint.BringToFront()
            Form_AddPoint.Activate()
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            'KryptonRibbonGroupButton_Length.Checked = False
            'KryptonRibbonGroupButton_Area.Checked = False
            'KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_Length_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Length.Click
        If KryptonRibbonGroupButton_Length.Checked = True Then
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            'KryptonRibbonGroupButton_Length.Checked = False
            KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_Area_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Area.Click
        If KryptonRibbonGroupButton_Area.Checked = True Then
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked = False
            KryptonRibbonGroupButton_Length.Checked = False
            'KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub


    'ZOOMING
    Private Sub KryptonRibbonGroupButton_ZoomIn_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomIn.Click
        Map1.ZoomIn()
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomOut_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomOut.Click
        Map1.ZoomOut()
    End Sub

    Private Sub KryptonRibbonGroupButton_FullExtent_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_FullExtent.Click
        Map1.ZoomToMaxExtent()
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomToPrev_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomToPrev.Click
        Map1.ZoomToPrevious()
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomToNext_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomToNext.Click
        Map1.ZoomToNext()
    End Sub



    'QUERY
    Private Sub KryptonRibbonGroupComboBoxQuerKecamatan_SelectedIndexChanged(sender As Object, e As EventArgs)
        If KryptonRibbonGroupComboBoxQueryKecamatan.Text = "Cari Kecamatan..." Then Exit Sub

        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBoxQueryKecamatan.Text
        lyrAdmin.SelectByAttribute("[WADMKC] ='" & StrKecamatan & "'")
        lyrAdmin.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()

        Dim ls1 As List(Of IFeature) = New List(Of IFeature)
        Dim il1 As ISelection = lyrAdmin.Selection

        ls1 = il1.ToFeatureList
        KryptonRibbonGroupComboBoxQueryDesa.Items.Clear()
        Dim i As Integer = 0
        Do While (i < il1.Count)
            Dim Name As String = (ls1(i).DataRow.ItemArray.GetValue(3).ToString)
            KryptonRibbonGroupComboBoxQueryDesa.Items.Insert(i, Name)
            i = (i + 1)
        Loop

        KryptonRibbonGroupComboBoxQueryDesa.Sorted = True
        Dim cboNumber As Integer = KryptonRibbonGroupComboBoxQueryDesa.Items.Count - 1
        Try
            For j = 1 To cboNumber
                If j > (KryptonRibbonGroupComboBoxQueryDesa.Items.Count - 1) Then Exit For
                If KryptonRibbonGroupComboBoxQueryDesa.Items(j) = KryptonRibbonGroupComboBoxQueryDesa.Items(j - 1) Then
                    KryptonRibbonGroupComboBoxQueryDesa.Items.RemoveAt(j)
                    j = j - 1
                    cboNumber = cboNumber - 1
                End If
            Next
        Catch ex As Exception
        End Try

        KryptonRibbonGroupComboBoxQueryDesa.Sorted = True

        lyrAdmin.UnSelectAll()

        sedangload = False

    End Sub

    Private Sub KryptonRibbonGroupComboBoxQueryDesa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupComboBoxQueryDesa.SelectedIndexChanged
        If KryptonRibbonGroupComboBoxQueryKecamatan.Text = "Cari Kecamatan..." Then Exit Sub
        If KryptonRibbonGroupComboBoxQueryDesa.Text = "Cari Desa..." Then Exit Sub

        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBoxQueryKecamatan.Text
        Dim StrDesa As String = KryptonRibbonGroupComboBoxQueryDesa.Text
        lyrAdmin.SelectByAttribute("[WADMKC] = '" & StrKecamatan & "' AND [NAMOBJ] ='" & StrDesa & "'")
        lyrAdmin.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()

        lyrAset.SelectByAttribute("[kecamatan] = '" & StrKecamatan & "' AND [Desa] ='" & StrDesa & "'")
        Dim ls1 As List(Of IFeature) = New List(Of IFeature)
        Dim il1 As ISelection = lyrAset.Selection

        ls1 = il1.ToFeatureList

        KryptonRibbonGroupComboBoxQueryAset.Items.Clear()
        Dim i As Integer = 0
        Do While (i < il1.Count)
            Dim Name As String = (ls1(i).DataRow.ItemArray.GetValue(2).ToString)
            KryptonRibbonGroupComboBoxQueryAset.Items.Insert(i, Name)
            i = (i + 1)
        Loop

        KryptonRibbonGroupComboBoxQueryAset.Sorted = True
        Dim cboNumber As Integer = KryptonRibbonGroupComboBoxQueryAset.Items.Count - 1
        Try
            For j = i To cboNumber
                If j > (KryptonRibbonGroupComboBoxQueryAset.Items.Count - 1) Then Exit For
                If KryptonRibbonGroupComboBoxQueryAset.Items(j) = KryptonRibbonGroupComboBoxQueryAset.Items(j - 1) Then
                    KryptonRibbonGroupComboBoxQueryAset.Items.RemoveAt(j)
                    j = j - 1
                    cboNumber = cboNumber - 1
                End If
            Next
        Catch ex As Exception
        End Try

        KryptonRibbonGroupComboBoxQueryAset.Sorted = True

        lyrAdmin.UnSelectAll()

        sedangload = False
    End Sub

    Private Sub KryptonRibbonGroupComboBoxQuery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupComboBoxQueryAset.SelectedIndexChanged
        If KryptonRibbonGroupComboBoxQueryKecamatan.Text = "Cari Kecamatan..." Then Exit Sub
        If KryptonRibbonGroupComboBoxQueryDesa.Text = "Cari Desa..." Then Exit Sub
        If KryptonRibbonGroupComboBoxQueryAset.Text = "Cari Bank Sampah..." Then Exit Sub

        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBoxQueryKecamatan.Text
        Dim StrDesa As String = KryptonRibbonGroupComboBoxQueryDesa.Text
        Dim StrBankSampah As String = KryptonRibbonGroupComboBoxQueryAset.Text
        lyrAset.SelectByAttribute("[kecamatan] ='" & StrKecamatan & "' AND [Desa] ='" & StrDesa & "' AND [name] ='" & StrBankSampah & "'")
        lyrAset.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()

        lyrAdmin.UnSelectAll()

        sedangload = False
    End Sub



    'ATTRIBUTE
    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        sedangload = True
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        Map1.ClearSelection()
        lyrAset.Select(CInt(DataGridView1.SelectedRows.Item(0).Cells.Item("FID").Value))
        lyrAset.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()
        sedangload = False
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs)
        sedangload = True
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        Map1.ClearSelection()
        For i = 0 To DataGridView1.SelectedRows.Count - 1
            'lyrAset.SelecByAttribute("[FID] =" & DataGridView1.SelectedRows.Item(i).Cells.Item.("FID").Value)
            lyrAset.Select(CInt(DataGridView1.SelectedRows.Item(i).Cells.Item("FID").Value))
        Next
        lyrAset.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()
        sedangload = True
    End Sub



    'POP UP (menampilkan informasi detail dan foto terkait dengan fitur yang dipilih pada layer lyrAset)
    Public Sub ShowPhoto()
        Try
            Dim ls1 As List(Of IFeature) = New List(Of IFeature)
            Dim il1 As ISelection = lyrAset.Selection

            Dim dt As DataTable
            dt = lyrAset.DataSet.DataTable

            Dim Kode As String = ""
            Dim NamaAset As String = ""
            Dim JenisAset As String = ""
            Dim Alamat As String = ""
            Dim Foto As String = ""
            Dim ShapeIndex As Integer = 0

            ls1 = il1.ToFeatureList

            Kode = (ls1(0).DataRow.ItemArray.GetValue(0).ToString)
            NamaAset = (ls1(0).DataRow.ItemArray.GetValue(2).ToString)
            JenisAset = (ls1(0).DataRow.ItemArray.GetValue(6).ToString)
            Alamat = (ls1(0).DataRow.ItemArray.GetValue(3).ToString)
            Foto = (ls1(0).DataRow.ItemArray.GetValue(2).ToString)
            ShapeIndex = (ls1(0).DataRow.ItemArray.GetValue(dt.Columns.Count - 1))

            Form_PopUp.txtKode.Text = Kode
            Form_PopUp.txtNamaAset.Text = NamaAset
            Form_PopUp.txtJenisAset.Text = JenisAset
            Form_PopUp.txtAtasNama.Text = Alamat
            Form_PopUp.txtfoto.Text = Foto
            Form_PopUp.txtShapeIndex.Text = ShapeIndex


            Dim AlamatFoto As String = ResourcePath & "D:\01. UGM_SIG\SEMESTER 2\01. PRAKTIKUM PEMROGRAMAN GEOSPASIAL DESKTOP\Acara 4 dan 5\project\SiBangSa\SiBangSa\PGD_A_45\Resource" & Foto
            Form_PopUp.Map1.AddLayer(AlamatFoto)

            If NamaAset = "" Then
                Call RemoveSelection()
                Exit Sub
            End If

            Map1.Refresh()
            Me.Refresh()
            Form_PopUp.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub RemoveSelection()
        Try
            sedangload = True

            Form_PopUp.txtKode.Text = ""
            Form_PopUp.txtNamaAset.Text = ""
            Form_PopUp.txtJenisAset.Text = ""
            Form_PopUp.txtAtasNama.Text = ""
            Form_PopUp.txtfoto.Text = ""
            Form_PopUp.txtfoto.Text = ""
            Form_PopUp.txtShapeIndex.Text = ""

            lyrAdmin.UnSelectAll()
            lyrAset.UnSelectAll()

            Form_PopUp.Map1.ClearLayers()
            'DataAttribute.SelectedRows(0).Selected = False

            Me.Refresh()
            Form_PopUp.Refresh()

            sedangload = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Map1_Load(sender As Object, e As EventArgs) Handles Map1.Load

    End Sub

    Private Sub KryptonRibbon1_SelectedTabChanged(sender As Object, e As EventArgs) Handles KryptonRibbon1.SelectedTabChanged

    End Sub

    Private Sub Legend1_Click(sender As Object, e As EventArgs) Handles Legend1.Click

    End Sub
End Class
