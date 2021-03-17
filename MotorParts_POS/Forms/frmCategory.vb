Public Class frmCategory

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        GlobalCatID = Nothing
        If GlobalCatID = Nothing Then
            saving = True
            frmCatDetails.txtCatID.Clear() : frmCatDetails.txtCategory.Clear()
            idLoader(frmCatDetails.txtCatID.Text, "tblcategory", "Select * from mppos_db.tblcategory order by catid", "catid", "CTY-")
            frmCatDetails.ShowDialog()
        End If
    End Sub

    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCategory.categorylist()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If GlobalCatID <> Nothing Then
            myCategory.deleteCategory()
        End If
    End Sub

    Private Sub dtglist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellClick

        Try
            myCategory.loadData()
            lblcountof.Text = dtglist.CurrentCell.RowIndex + 1 & " of"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If GlobalCatID <> Nothing Then
            frmCatDetails.ShowDialog()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        search = True
        myCategory.categorylist()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        search = False
        myCategory.categorylist()
    End Sub
End Class