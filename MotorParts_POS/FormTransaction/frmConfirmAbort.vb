Imports MySql.Data.MySqlClient

Public Class frmConfirmAbort

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        For Each RW As DataGridViewRow In frmCashier.dtgItemPurchase.Rows
            barcode = RW.Cells(1).Value.ToString
            quantity = RW.Cells(0).Value.ToString

            runServer()
            MysqlConn.Open()
            query = "update mppos_db.tblitem set quantity=quantity+ '" & quantity & "'  where barcode='" & barcode & "'"
            COMMAND = New MySqlCommand(query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()
        Next

        MysqlConn.Open()
        query = "delete from mppos_db.tblsolditem where transid='" & frmCashier.lblTransID.Text & "'"
            COMMAND = New MySqlCommand(query, MysqlConn)
            READER = COMMAND.ExecuteReader
        MysqlConn.Close()
        frmCashier.lblitemDescription.Text = "Description"
        frmCashier.txtPrice.Text = "0.00"
        frmCashier.txttotalPrice.Text = "0.00"
        myTransaction.getActivePurchaseItemList()
        myTransaction.computeTotalAmountDue()
        Me.Close()

          
    End Sub
End Class