Public Class frmSalesMonitoring

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mySoldItem.generateSales("LOADALL")
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mySoldItem.generateSales("LoadByDate")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mySoldItem.generateSales("LOADALL")

    End Sub

    Private Sub dtgSalesReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgListReport.CellClick

        lblcountof.Text = dtgListReport.CurrentCell.RowIndex + 1 & " of"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dtgListReport.Rows.Count <> 0 Then
            mySoldItem.printSalesreport()
        End If

    End Sub
End Class