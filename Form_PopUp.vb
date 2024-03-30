Imports System.IO
Imports DotSpatial.Data
Imports DotSpatial.Controls
Imports DotSpatial.Symbology

Public Class Form_PopUp

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Try

            FormMainWindow.sedangload = True

            If cmdEdit.Text = "Edit" Then
                Dim input As String = Microsoft.VisualBasic.Interaction.InputBox(
                    "Please enter your password...", "Password", "", -1, -1)

                If input = "sampah" Then
                    txtJenisAset.ReadOnly = False
                    txtNamaAset.ReadOnly = False
                    cmdBrowse.Enabled = True
                    cmdDetele.Visible = True
                    cmdEdit.Text = "Save"
                Else
                    txtJenisAset.ReadOnly = True
                    txtNamaAset.ReadOnly = True
                    cmdBrowse.Enabled = False
                    cmdDetele.Visible = False
                    cmdEdit.Text = "Edit"
                    MessageBox.Show("Password yang dimasukkan salah.")
                End If

            ElseIf cmdEdit.Text = "Save" Then
                Dim featureEdited As IFeature = FormMainWindow.lyrAset.FeatureSet.GetFeature(CInt(txtShapeIndex.Text))
                featureEdited.DataRow.BeginEdit()
                featureEdited.DataRow("nama_bank_sampah") = txtJenisAset.Text
                featureEdited.DataRow("atas_nama") = txtAtasNama.Text
                featureEdited.DataRow("foto") = txtfoto.Text
                featureEdited.DataRow.EndEdit()

                cmdEdit.Text = "Edit"
                txtJenisAset.ReadOnly = True
                txtAtasNama.ReadOnly = True
                cmdBrowse.Enabled = False
                Map1.Refresh()
                Me.Hide()
                MessageBox.Show("Data telah tersimpan.")
            End If

            FormMainWindow.sedangload = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
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
            txtfoto.Text = fileName
            Map1.ClearLayers()
            Map1.AddLayer(destFile)
        Else
            MessageBox.Show("masukin foto lahhh", "Report", MessageBoxButtons.OK)
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

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDetele.Click
        FormMainWindow.sedangload = True
        FormMainWindow.lyrAset.ClearSelection()
        FormMainWindow.lyrAset.Select(CInt(txtShapeIndex.Text))
        FormMainWindow.lyrAset.RemoveSelectedFeatures()
        FormMainWindow.sedangload = False
        FormMainWindow.Map1.Refresh()
        Me.Close()
        MessageBox.Show("Yeyyy, data deleted!")
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Form_PopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblAtasNama_Click(sender As Object, e As EventArgs) Handles lblAlamat.Click

    End Sub
End Class
