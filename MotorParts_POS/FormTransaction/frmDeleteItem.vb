Public Class frmDeleteItem

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        myTransaction.CancelTransaction()
        Me.Close()
        frmCashier.txtBarcode.Focus()
        'frmTransaction.datagridStyle()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class