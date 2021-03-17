Public Class frmQTY

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        

        If e.KeyCode = Keys.Enter Then
            If txtQty.Text = "" Then
                If MessageBox.Show("Please provide quantity?", "Do you want to try again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    txtQty.Focus()
                Else
                End If
            Else



                If minusQty = True Then
                    If frmCashier.onHandStock() Then
                        Dim numQty As Integer
                        Dim GridRow As DataGridViewRow = frmCashier.dtgItemPurchase.CurrentRow
                        numQty = CStr(GridRow.Cells.Item("QTY").Value)
                        If numQty > 1 Then
                            If numQty > CDbl(txtQty.Text) Then
                                If CDbl(onhanQty + numQty) >= CDbl(txtQty.Text) Then
                                    quantity = numQty - CInt(txtQty.Text)
                                    frmCashier.FrmTransaction("ReduceQty")
                                    Me.Close()
                                Else

                                End If
                            Else
                                MsgBox("Invalid Qty to Reduce,Please try again")
                                txtQty.Focus()
                            End If
                        Else
                            MsgBox("Unable to reduce Qty 1")
                        End If


                    End If

                Else
                    If frmCashier.onHandStock() Then
                        Dim numQty As Integer
                        Dim GridRow As DataGridViewRow = frmCashier.dtgItemPurchase.CurrentRow
                        numQty = CStr(GridRow.Cells.Item("QTY").Value)
                        If CDbl(onhanQty + numQty) >= CDbl(numQty + txtQty.Text) Then
                            addQty = CInt(txtQty.Text)
                            quantity = numQty + CDbl(txtQty.Text)
                            'SalePrice = frmCashier.txtPrice.Text
                            'SalePrice = SalePrice * quantity
                            frmCashier.FrmTransaction("AddQty")
                            Me.Close()
                        Else
                            MsgBox("Please reduce the purchase item quantity to proceed process")
                            txtQty.Focus()

                        End If
                    Else
                        MsgBox("error")

                    End If

                End If





                End If
        Else
            If e.KeyCode = Keys.Escape Then
                Me.Close()
                txtQty.Clear()
            End If
        End If

    End Sub


    Private Sub frmQTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQty.Focus()
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        e.Handled = trapkey(Asc(e.KeyChar))
    End Sub

 
 
    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub
End Class