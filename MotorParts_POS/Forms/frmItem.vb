Public Class frmItem

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        GlobalitemID = Nothing
        If GlobalitemID = Nothing Then
            saving = True
            clearTxt("item") : frmItemDetails.txtColor.Clear() : frmItemDetails.txtSize.Clear()
            idLoader(frmItemDetails.txtitemId.Text, "tblitem", "Select * from mppos_db.tblitem order by itemid", "itemid", "PROD-")
            frmItemDetails.ShowDialog()
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If frmItemDetails.txtBarcode.Text <> Nothing Then
            saving = False
            frmItemDetails.ShowDialog()
        End If
     
    End Sub

 

    Private Sub frmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myItem.itemlist()
    End Sub

    Private Sub dtgItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgItemList.CellClick
        Try
            myItem.loadData()
            lblcountof.Text = dtgItemList.CurrentCell.RowIndex + 1 & " of"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgItemList_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgItemList.KeyDown
        lblcountof.Text = dtgItemList.CurrentCell.RowIndex + 1 & " of"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If GlobalitemID <> Nothing Then
            If dtgItemList.Rows.Count > 1 Then
                myItem.deleteitem()
            End If

        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If cmbfilter.Text = Nothing Then
            If MessageBox.Show("Please select a filter option to search.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                txtsearch.Clear()
            End If
        Else
            search = True
            myItem.itemlist()
        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        search = False
        txtsearch.Clear() : cmbfilter.Text = Nothing
        myItem.itemlist()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dtgItemList.Rows.Count <> 0 Then
            myItem.printItemreport()
        End If

    End Sub
End Class