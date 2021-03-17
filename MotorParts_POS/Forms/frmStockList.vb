Public Class frmStockList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idLoader(frmStockIn.txtStockno.Text, "tblstockin", "Select * from mppos_db.tblstockin order by stockbatch", "stockbatch", "SKU -")
        frmStockIn.ShowDialog()
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      
        frmStockAdjustDetail.ShowDialog()
    End Sub

  
    Private Sub frmStockList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myStockin.stocklist("LOADALL")
    End Sub

    Private Sub dtgstocklist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgstocklist.CellClick
        lblcountof.Text = dtgstocklist.CurrentCell.RowIndex + 1 & " of"
    End Sub

    Private Sub dtgstocklist_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgstocklist.KeyDown
        lblcountof.Text = dtgstocklist.CurrentCell.RowIndex + 1 & " of"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search = True
        myStockin.stocklist("LOADALL")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        myStockin.stocklist("LOADALL")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dtgstocklist.Rows.Count <> 0 Then

            myStockin.printStockInListreport()
        End If




    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        myStockin.stocklist("LOADBYDATE")
    End Sub
End Class