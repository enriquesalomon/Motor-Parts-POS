Public Class frmItemLookup
    Private Sub frmItemLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Focus()
        itemLookuplist()

    End Sub

    Private Sub DGVStocks_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVStocks.KeyDown
        txtSearch.Focus()
        If e.KeyCode = Keys.Enter Then loddata() : clear() : frmCashier.txtBarcode.Focus()
        If e.KeyCode = Keys.Down Then DGVStocks.Focus()
        If e.KeyCode = Keys.Escape Then Me.Close() : clear()

    End Sub
    Private Sub clear()
        lblNoItm.Visible = False
        txtSearch.Clear()
        Me.Close()
    End Sub
    Sub loddata()
        Try

            Dim GridRow As DataGridViewRow = DGVStocks.CurrentRow
            frmCashier.txtBarcode.Text = CStr(GridRow.Cells.Item("barcode").Value)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        txtSearch.Focus()

        If e.KeyCode = Keys.Enter Then loddata() : clear()
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.Down Then DGVStocks.Focus()
        If e.KeyCode = Keys.Escape Then Me.Close() : clear()
    End Sub

   

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search = True
        itemLookuplist()

        If DGVStocks.RowCount = 0 Then : lblNoItm.Visible = True
        Else : lblNoItm.Visible = False
        End If
    End Sub

    Private Sub DGVStocks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGVStocks.KeyPress
        txtSearch.Focus()
    End Sub

    Private Sub DGVStocks_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DGVStocks.MouseDoubleClick
        loddata() : clear() : frmCashier.txtBarcode.Focus()

       
    End Sub
End Class