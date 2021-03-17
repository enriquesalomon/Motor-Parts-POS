Public Class frmNoStock

    Private Sub btnItemNotFind_Click(sender As Object, e As EventArgs) Handles btnItemNotFind.Click

        Me.Close()
        frmCashier.txtBarcode.Clear()
    End Sub
End Class