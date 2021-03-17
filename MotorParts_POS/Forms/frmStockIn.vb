Public Class frmStockIn

    Private Sub frmStockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idLoader(txtStockno.Text, "tblstockin", "Select * from mppos_db.tblstockin order by stockbatch", "stockbatch", "SKU -")
        myItem.AutoCompleteDescription()
        myItem.AutoCompleteBarcode()
        myStockin.itemlistsearch()
    End Sub

    'Function enAbleTextbox() As Boolean
    '    If enAbleTextbox = False Then

    '        txtBrand.Enabled = False
    '        txtCategory.Enabled = False
    '        txtcolor.Enabled = False
    '        txtQty.Enabled = False
    '        txtQtyOnHand.Enabled = False
    '        txtsize.Enabled = False
    '        txtTotalQtyOnHand.Enabled = False
    '        txtunit.Enabled = False
    '    Else

    '        txtBrand.Enabled = True
    '        txtCategory.Enabled = True
    '        txtcolor.Enabled = True
    '        txtQty.Enabled = True
    '        txtQtyOnHand.Enabled = True
    '        txtsize.Enabled = True
    '        txtTotalQtyOnHand.Enabled = True
    '        txtunit.Enabled = True

    '    End If

    ' End Function

  

    Private Sub txtitemdescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtitemdescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            myStockin.setAutoFillupTextField("itemdescription")
        End If
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
       
    End Sub

   
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        e.Handled = trapkey(Asc(e.KeyChar))


    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        If txtQty.TextLength() = 0 Then
            txtTotalQtyOnHand.Text = 0
        End If
        Try
            txtTotalQtyOnHand.Text = CInt(Int(txtQtyOnHand.Text)) + CInt(Int(txtQty.Text))
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            myStockin.setAutoFillupTextField("barcode")
        End If
    End Sub

    Private Sub btnAddStockin_Click(sender As Object, e As EventArgs) Handles btnAddStockin.Click
        If txtitemdescription.Text = Nothing And txtBarcode.Text = Nothing Then
        Else
            myStockin.SaveStock()
            idLoader(txtStockno.Text, "tblstockin", "Select * from mppos_db.tblstockin order by stockbatch", "stockbatch", "SKU -")

        End If

       
    End Sub

    Private Sub frmStockIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        myStockin.stocklist("LOADALL")
        dtgStockIn.Rows.Clear()
    End Sub

    Private Sub dtgStockIn_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgStockIn.KeyDown
        lblcountof.Text = dtgStockIn.CurrentCell.RowIndex + 1 & " of"
    End Sub

    Private Sub btnCLosepanel_Click(sender As Object, e As EventArgs) Handles btnCLosepanel.Click
        panelSearchItem.Visible = False
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        panelSearchItem.Visible = True

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search = True
        myStockin.itemlistsearch()
    End Sub

    Private Sub dtgItemsearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgItemsearch.CellDoubleClick
        Dim GridRow As DataGridViewRow = dtgItemsearch.CurrentRow
        txtBarcode.Text = CStr(GridRow.Cells.Item("Barcode").Value)
        panelSearchItem.Visible = False
    End Sub

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        myStockin.setAutoFillupTextField("barcode")
    End Sub
End Class