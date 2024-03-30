Imports System.IO
Imports DotSpatial.Controls
Imports DotSpatial.Data
Imports DotSpatial.Symbology
Imports DotSpatial.Topology

Public Class Form_AddPoint
    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs)
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Browse Photo"
        ofd.InitialDirectory = "C:\"
        ofd.Filter = "JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|All files (*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.RestoreDirectory = True

        If (ofd.ShowDialog() = DialogResult.OK) Then
            Dim fileName As String = Path.GetFileName(ofd.FileName)
            Dim sourcePath As String = Path.GetDirectoryName(ofd.FileName)
            Dim targetPath As String = Path.Combine(FormMainWindow.ResourcePath, "Resources/Database/Data NonSpasial/Foto")
            Dim sourceFile As String = Path.Combine(sourcePath, fileName)
            Dim destFile As String = Path.Combine(targetPath, fileName)
            File.Copy(sourceFile, destFile, True)
            txtFoto.Text = fileName
            Map1.ClearLayers()
            Map1.AddLayer(destFile)
        Else
            MessageBox.Show("KAMU BELUM MEMASUKKAN FOTO.", "Report", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub cmdZoomIn_Click(sender As Object, e As EventArgs) Handles cmdZoomIn.Click
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn
    End Sub

    Private Sub cmdZoomOut_Click(sender As Object, e As EventArgs) Handles cmdZoomOut.Click
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut
    End Sub

    Private Sub cmdPan_Click(sender As Object, e As EventArgs) Handles cmdPan.Click
        Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan
    End Sub

    Private Sub cmdFullExtent_Click(sender As Object, e As EventArgs) Handles cmdFullExtent.Click
        Map1.ZoomToMaxExtent()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Dim banksampahFeatureSet As FeatureSet = FormMainWindow.lyrAset.FeatureSet
        Dim banksampahPoint As New Point(CDbl(txtTitik_X.Text), CDbl(txtTitik_Y.Text))
        Dim featureInserted As IFeature = banksampahFeatureSet.AddFeature(banksampahPoint)

        featureInserted.DataRow.BeginEdit()
        featureInserted.DataRow("nama_aset") = txtNamaAset.Text
        featureInserted.DataRow("jenis_aset") = txtJenisAset.Text
        featureInserted.DataRow("atas_nama") = txtAtasNama.Text
        featureInserted.DataRow("foto") = txtFoto.Text
        'featureInserted.DataROw("FID") = pendidikanFeatureSet.Features.Count - 1
        featureInserted.DataRow.EndEdit()

        banksampahFeatureSet.InitializeVertices()
        banksampahFeatureSet.UpdateExtent()
        banksampahFeatureSet.Save()

        FormMainWindow.lyrAset.DataSet.InitializeVertices()
        FormMainWindow.lyrAset.AssignFastDrawnStates()
        FormMainWindow.lyrAset.DataSet.UpdateExtent()

        Dim dt As DataTable
        dt = FormMainWindow.lyrAset.DataSet.DataTable
        dt.Columns.RemoveAt((dt.Columns.Count - 1))
        dt.AcceptChanges()
        FormMainWindow.lyrAset.DataSet.Save()
        FormMainWindow.lyrAset.FeatureSet.AddFid()
        FormMainWindow.lyrAset.FeatureSet.Save()

        FormMainWindow.pointLayerTemplate.SelectAll()
        FormMainWindow.pointLayerTemplate.RemoveSelectedFeatures()

        FormMainWindow.pointFeatureTemplate.InitializeVertices()
        FormMainWindow.pointFeatureTemplate.UpdateExtent()
        FormMainWindow.pointLayerTemplate.DataSet.InitializeVertices()
        FormMainWindow.pointLayerTemplate.AssignFastDrawnStates()
        FormMainWindow.pointLayerTemplate.DataSet.UpdateExtent()

        FormMainWindow.pointLayerTemplate.SelectAll()
        FormMainWindow.pointLayerTemplate.RemoveSelectedFeatures()

        Map1.Refresh()
        Map1.ResetBuffer()

        MessageBox.Show("Data telah tersimpan.")
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Form_AddPoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdBrowse_Click_1(sender As Object, e As EventArgs) Handles cmdBrowse.Click

    End Sub
End Class
