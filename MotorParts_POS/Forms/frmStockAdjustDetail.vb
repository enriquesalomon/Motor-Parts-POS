Public Class frmStockAdjustDetail

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panelStockAdjustDetail.Paint

    End Sub

    Private Sub frmStockAdjustDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idLoader(txtAdjustRefNo.Text, "tblstockadjust", "Select * from mppos_db.tblstockadjust order by adjustno", "adjustno", "ASKU-")
        idLoader(txtStockno.Text, "tblstockin", "Select * from mppos_db.tblstockin order by stockbatch", "stockbatch", "SKU -")
        myStockAdjustment.itemlist()
        myStockAdjustment.setNo()
    End Sub

    Private Sub dtgItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStockAdjustList.CellClick
        Try

     
        myStockAdjustment.loadData()
            lblcount.Text = dtgStockAdjustList.CurrentCell.RowIndex + 1 & " of"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        e.Handled = trapkey(Asc(e.KeyChar))

    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        
    End Sub

    Private Sub btnAdjsutStock_Click(sender As Object, e As EventArgs) Handles btnAdjsutStock.Click
        If txtqty.Text = Nothing Then
            MsgBox("Quantity is Required,cannot be empty")
            Exit Sub

        ElseIf cmbActionadjust.Text = Nothing Then
            MsgBox("Action is Required,cannot be empty")
            Exit Sub

        ElseIf cmbActionadjust.Text = Nothing Then
            MsgBox("Reason is Required,cannot be empty")
            Exit Sub
        Else
            myStockAdjustment.SaveStockAdjustment()
        End If

    End Sub

    Private Sub dtgItemList_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgStockAdjustList.KeyDown
        lblcount.Text = dtgStockAdjustList.CurrentCell.RowIndex + 1 & " of"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search = True
        myStockAdjustment.itemlist()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cmbfilter.Text = Nothing
        txtSearch.Clear()
        search = False
        myStockAdjustment.itemlist()
    End Sub

    Private Sub cmbActionadjust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbActionadjust.SelectedIndexChanged

        Try
            If cmbActionadjust.Text = "Add" Then
                If CDbl(txtqty.Text) <= 0 Then
                    MsgBox("Invalid Qty Input, Value must not 0 ")
                    txtqty.Clear()
                    txtqty.Focus()
                End If

            End If
            If cmbActionadjust.Text = "Remove" Then
                If CDbl(txtqty.Text) > CDbl(txtQtyONhand.Text) Then
                    MsgBox("Invalid Qty Input, Value must not more than onhand Qty")
                    txtqty.Clear()
                    txtqty.Focus()
                End If

            End If

            
        Catch ex As Exception

        End Try
    End Sub
End Class