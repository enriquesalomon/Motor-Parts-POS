Public Class frmInventoryItem

    Private Sub frmInventoryStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myStockInventory.generateInventory()
    End Sub

    Private Sub dtgListReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgListReport.CellClick

        lblcountof.Text = dtgListReport.CurrentCell.RowIndex + 1 & " of"
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        search = True
        myStockInventory.generateInventory()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        search = False
        txtsearch.Clear()
        myStockInventory.generateInventory()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If dtgListReport.Rows.Count <> 0 Then
            myStockInventory.printItemreport()
        End If
    End Sub
End Class