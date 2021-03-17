Public Class frmCatDetails

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCatID.Text <> Nothing And txtCategory.Text <> Nothing Then
            myCategory.SaveUpdateItem()
        Else
            MsgBox("Some Fields are Blank,PLease Complete to proceed Saving")
        End If
    End Sub
End Class