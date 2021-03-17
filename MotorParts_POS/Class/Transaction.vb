Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class Transaction
   
    Public Sub generateItemDetails()
        runServer()
        MysqlConn.Open()
        query = "Select * from mppos_db.tblitem where quantity > 0 and barcode='" & frmCashier.txtBarcode.Text & "' "
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read
            barcode = frmCashier.txtBarcode.Text
            GlobalItemID = READER("itemid")
            frmCashier.lblitemDescription.Text = READER("itemname")
            frmCashier.txtPrice.Text = Format(READER("saleprice"), "Standard")
            saleprice = (Format(READER("saleprice"), "Standard")).ToString()
            frmCashier.txttotalPrice.Text = Format(READER("saleprice"), "Standard")
        End While
        READER.Close()
        MysqlConn.Close()


        updateStockQty()

        getActivePurchaseItemList()
        computeTotalAmountDue()


    End Sub

    Sub setNo()
        '''''''solditem id
        runServer()
        idSolditem = Nothing
        Dim last As Integer
        Dim continue_num As Integer
        query = "Select * from mppos_db.tblsolditem order by id"

        MysqlConn.Open()
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read()
            last = CInt(READER("id"))
        End While
        continue_num = last + 1
        idSolditem = continue_num
        READER.Close()
        MysqlConn.Close()

    End Sub
    Sub setNoStockout()

        '''stockout id
        runServer()
        idStockout = Nothing
        Dim last As Integer
        Dim continue_num As Integer
        query = "Select * from mppos_db.tblstockout order by no"

        MysqlConn.Open()
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read()
            last = CInt(READER("no"))
        End While
        continue_num = last + 1
        idStockout = continue_num
        READER.Close()
        MysqlConn.Close()

    End Sub


   
    Sub updateStockQty()
        runServer()
        Dim qtystock As String
        query = "Select * from mppos_db.tblitem where itemid='" & GlobalItemID & "'"
        MysqlConn.Open()
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read()
            qtystock = CInt(READER("quantity"))
        End While
        READER.Close()
        MysqlConn.Close()
        qtystock = CDbl(qtystock) - 1
        MysqlConn.Open()
        query = "update mppos_db.tblitem set quantity='" & qtyStock & "' where itemid='" & GlobalItemID & "'"
        COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()
    End Sub

    Sub getActivePurchaseItemList()
        Try


            frmCashier.dtgItemPurchase.Rows.Clear()
            runServer()
            Dim SDA As New MySqlDataAdapter
            Dim dbDataset As New DataTable
            Dim bSource As New BindingSource
            MysqlConn.Open()
            'query = "SELECT tblsolditem.quantity,Format(tblsolditem.quantity*tblsolditem.saleprice,2) as amount,tblsolditem.itemid,tblsolditem.barcode,tblitem.itemname,tblsolditem.saleprice,tblsolditem.discount,Format(tblsolditem.quantity*tblsolditem.saleprice,2) -  Format(tblsolditem.quantity*tblsolditem.saleprice,2)*  tblsolditem.discount as totalsale FROM mppos_db.tblsolditem INNER JOIN mppos_db.tblitem ON tblsolditem.itemid = tblitem.itemid where tblsolditem.transid ='" & frmCashier.lblTransID.Text & "' order by tblsolditem.id DESC "
            query = "SELECT tblsolditem.quantity,Format(tblsolditem.quantity*tblsolditem.saleprice,2) as amount,tblsolditem.itemid,tblsolditem.barcode,tblitem.itemname,tblsolditem.saleprice,tblsolditem.discount,tblsolditem.quantity*tblsolditem.saleprice-tblsolditem.quantity*tblsolditem.saleprice * tblsolditem.discount as totalsale FROM mppos_db.tblsolditem INNER JOIN mppos_db.tblitem ON tblsolditem.itemid = tblitem.itemid where tblsolditem.transid ='" & frmCashier.lblTransID.Text & "' order by tblsolditem.id DESC "

            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            READER = COMMAND.ExecuteReader

            While READER.Read
                frmCashier.dtgItemPurchase.ColumnCount = 6
                frmCashier.dtgItemPurchase.Columns(0).Name = "QTY"
                frmCashier.dtgItemPurchase.Columns(1).Name = "BARCODE"
                frmCashier.dtgItemPurchase.Columns(2).Name = "DESCRIPTION"
                frmCashier.dtgItemPurchase.Columns(3).Name = "SALEPRICE"
                frmCashier.dtgItemPurchase.Columns(4).Name = "DISCOUNT %"
                frmCashier.dtgItemPurchase.Columns(5).Name = "AMOUNT"
                Dim column1 As DataGridViewColumn = frmCashier.dtgItemPurchase.Columns(0)
                Dim column2 As DataGridViewColumn = frmCashier.dtgItemPurchase.Columns(1)
                Dim column3 As DataGridViewColumn = frmCashier.dtgItemPurchase.Columns(2)
                Dim column4 As DataGridViewColumn = frmCashier.dtgItemPurchase.Columns(3)
                Dim column5 As DataGridViewColumn = frmCashier.dtgItemPurchase.Columns(4)
                Dim column6 As DataGridViewColumn = frmCashier.dtgItemPurchase.Columns(5)
                column1.Width = 100
                column2.Width = 150
                column3.Width = 420
                column4.Width = 100
                column5.Width = 120
                column6.Width = 100

                Dim q, b, d, p, ds, a As String
                q = (READER("quantity"))
                b = (READER("barcode"))
                d = (READER("itemname"))
                p = (READER("saleprice"))
                ds = (READER("discount"))
                a = (READER("totalsale"))
                Dim row2 As String() = New String() {q, b, d, p, ds, Format(a, "Standard")}
                frmCashier.dtgItemPurchase.Rows.Add(row2)

            End While
            READER.Close()
            MysqlConn.Close()
            frmCashier.lblitemCount.Text = frmCashier.dtgItemPurchase.Rows.Count
            If frmCashier.dtgItemPurchase.Rows.Count = 0 Then
                frmCashier.txtPrice.Text = "0.00"
                frmCashier.txttotalPrice.Text = "0.00"
                frmCashier.lblitemDescription.Text = "Item Description"
            End If

        Catch ex As Exception

        End Try
    End Sub
   

    Sub computeTotalAmountDue()
        Dim price, totdiscount As Double
        For Each RW As DataGridViewRow In frmCashier.dtgItemPurchase.Rows

            totdiscount += (CDbl(RW.Cells(0).Value.ToString) * CDbl(RW.Cells(3).Value.ToString)) * CDbl(RW.Cells(4).Value.ToString)
            price += CDbl(RW.Cells(5).Value.ToString)
        Next
        frmCashier.lblDisc.Text = Format(totdiscount, "Standard")
        frmCashier.txtAmountDue.Text = Format(price, "Standard")
    End Sub

    Sub CancelTransaction()
        runServer()
        MysqlConn.Open()
        query = "Select * from mppos_db.tblitem where barcode='" & barcode & "' "
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read
            GlobalitemID = READER("itemid")
        End While
        READER.Close()
        MysqlConn.Close()
        MysqlConn.Open()
        query = "delete from mppos_db.tblsolditem where itemid='" & GlobalitemID & "'"
        COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()

        MysqlConn.Open()
        query = "update mppos_db.tblitem set quantity=quantity + '" & GlobalQty & "'  where itemid='" & GlobalitemID & "'"
        COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()

        getActivePurchaseItemList()
        computeTotalAmountDue()
        GlobalitemID = Nothing
        barcode = Nothing
        GlobalQty = Nothing
        If frmCashier.dtgItemPurchase.Rows.Count = 0 Then
            frmCashier.txttotalPrice.Text = "0.00"
            frmCashier.lblDisc.Text = "0.00"
            frmCashier.txtPrice.Text = "0.00"
            frmCashier.lblDisc.Text = "0.00"
            frmCashier.lblCash.Text = "0.00"
            frmCashier.txtAmountDue.Text = "0.00"
            frmCashier.lblChange.Text = "0.00"
            frmCashier.lblitemDescription.Text = "Item Description"
        Else
            frmCashier.txtPrice.Text = "0.00"
            frmCashier.txttotalPrice.Text = "0.00"
            frmCashier.lblitemDescription.Text = "Item Description"

        End If
         End Sub



    Public Sub saveTransaction()
        runServer()
        MysqlConn.Open()

        query = "insert into mppos_db.tbltransaction (transid,orno,totalamount,totaldiscount,cashpay,cashchange,dateinserted,userid) values ('" & frmCashier.lblTransID.Text & "','" & ORno & "','" & frmCashier.txtAmountDue.Text & "','" & frmCashier.lblDisc.Text & "','" & frmCashier.lblCash.Text & "','" & frmCashier.lblChange.Text & "','" & Date.Now.ToShortDateString & "','" & Globaluserid & "')"
        COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()
        saveOR()
        frmCashier.dtgItemPurchase.Rows.Clear()
        frmCashier.txtAmountDue.Text = "0.00"
        frmCashier.txtPrice.Text = "0.00"
        frmCashier.txttotalPrice.Text = "0.00"
        frmCashier.lblDisc.Text = "0.00"
        frmCashier.lblitemDescription.Text = "Item Description"
        frmCashier.lblTransID.Text = ""
        frmCashier.lblTransID.Text = ""
        ORno = Nothing
        frmCashpay.txtPayment.Clear()
        frmCashier.txtBarcode.Clear()
        frmTransactProcess.Timer1.Stop()
        frmCashier.grpitemcount.Visible = False
        frmCashier.panelPaySettled.Visible = True
        frmCashier.txtBarcode.Focus()
        frmCashier.txtBarcode.ReadOnly = True
    End Sub

   

End Class
