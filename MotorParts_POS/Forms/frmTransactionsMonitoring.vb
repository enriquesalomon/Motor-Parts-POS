Public Class frmTransactionsMonitoring

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub dtgSalesReport_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frmTransactionMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myTransactionMonitor.generateSales("LOADALL")

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        myTransactionMonitor.generateSales("LOADBYDATE")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        myTransactionMonitor.generateSales("LOADALL")
    End Sub

    Private Sub dtgListReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgListReport.CellClick
        lblcountof.Text = dtgListReport.CurrentCell.RowIndex + 1 & " of"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dtgListReport.Rows.Count <> 0 Then
            myTransactionMonitor.printTransactionreport()
        End If

    End Sub
End Class