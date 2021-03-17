Public Class frmDiscount

    Private Sub txtDiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then : computePay()
        ElseIf e.KeyCode = Keys.Escape Then : Me.Close()
        End If
    End Sub
    Sub computePay()
        Try

      
        Dim val As Integer = txtDiscount.Text
        Dim a As String = String.Format("{0:0}", val)
        disInPrcent = CDbl("0." & a)
        disc = disInPrcent * CDbl(frmCashier.txttotalPrice.Text)
        netAmount = disc
        discAmount = CDbl(frmCashier.txttotalPrice.Text) - disc
        netAmount = discAmount
        If discAmount <= CDbl(frmCashier.txttotalPrice.Text) Then
            'frmCashier.lblDisc.Text = disc
            frmCashier.txtAmountDue.Text = CDbl(frmCashier.txttotalPrice.Text) - disc
            frmCashier.updateSoldItem()
            Me.Close()
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class