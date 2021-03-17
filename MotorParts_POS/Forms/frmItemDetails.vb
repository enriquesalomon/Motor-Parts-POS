Public Class frmItemDetails

    

    Private Sub frmItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        runServer()
        myCategory.setBoxCategory()
        End Sub

   
   
    'Private Sub cmbCategory_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbCategory.MouseClick
    '    myItem.setBoxCategory("category")
    'End Sub


    Private Sub txtCostprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostprice.KeyPress
        e.Handled = trapkey(Asc(e.KeyChar))
    End Sub

    Private Sub txtSelPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSelPrice.KeyPress
        e.Handled = trapkey(Asc(e.KeyChar))
    End Sub

    Private Sub txtCritcalLmit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCritcalLmit.KeyPress
        e.Handled = trapkey(Asc(e.KeyChar))
    End Sub

    Private Sub txtCritcalLmit_TextChanged(sender As Object, e As EventArgs) Handles txtCritcalLmit.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CheckField("item") Then
            If MessageBox.Show("Some TextField are blank,Complete the Fields to Proceed Saving Data", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.OK Then
            End If
        Else
            myItem.SaveUpdateItem()
        End If
    End Sub

    Private Sub cmbunit_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbunit.MouseClick
        myItem.setBoxCategory("unit")
    End Sub

   
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class