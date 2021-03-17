Public Class frmCashpay

    Private Sub txtPayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPayment.KeyPress
        e.Handled = trapkey(Asc(e.KeyChar))
        Dim allowedChars As String = "0123456789." & vbBack
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
            Try
                txtPayment.Text = Format(Double.Parse(txtPayment.Text), "###,###,##0.00")
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtPayment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPayment.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPayment.Text <> "" Then computePayment()
        ElseIf e.KeyCode = Keys.Escape Then : Me.Close()
        End If
    End Sub
    Dim total As Double
    Private Sub frmCashPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPayment.Clear()
        txtPayment.Focus()
    End Sub

    Sub computePayment()
        Dim amountPaid, totalAmount, change As Double
        amountPaid = 0
        amountPaid = CDbl(txtPayment.Text)
        totalAmount = CDbl(frmCashier.txtAmountDue.Text)
        If amountPaid < totalAmount Then
            MsgBox("Insufficient Funds")
            amountPaid = 0 : totalAmount = 0
        Else : change = amountPaid - totalAmount
            frmCashier.lblCash.Text = Format(amountPaid, "Standard")
            frmCashier.lblChange.Text = Format(change, "Standard")

            frmCashier.FrmTransaction("Save Transaction")
            Me.Close()
            'saving ttransaction´´´´´´´´      frmCashier.btnSaveTransaction.Enabled = True

        End If
    End Sub
End Class