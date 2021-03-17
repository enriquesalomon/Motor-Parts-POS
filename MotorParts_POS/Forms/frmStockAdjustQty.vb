Public Class frmStockAdjustQty

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmStockAdjustDetail.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStockAdjustmentList.CellClick
        Try

     
            lblcountof.Text = dtgStockAdjustmentList.CurrentCell.RowIndex + 1 & " of"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmStockAdjustQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myStockAdjustment.adjustmentlist("LOADALL")
    End Sub

    Private Sub dtgStockAdjustmentList_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgStockAdjustmentList.KeyDown
        lblcountof.Text = dtgStockAdjustmentList.CurrentCell.RowIndex + 1 & " of"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        myStockAdjustment.adjustmentlist("LOADALL")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        myStockAdjustment.adjustmentlist("LOADBYDATE")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dtgStockAdjustmentList.Rows.Count <> 0 Then
            myStockAdjustment.printStockAdjustListreport()
        End If
    End Sub
End Class