Option Explicit On
Imports MySql.Data.MySqlClient

Public Class frmCashier
 
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Function chkItemFound() As Boolean
           runServer()
          MysqlConn.Open()
        query = "Select * from mppos_db.tblitem where quantity >0 and barcode='" & Trim(txtBarcode.Text) & "' "
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
           If READER.Read = True Then
            chkItemFound = True
        Else
            frmItemNotFound.ShowDialog()

            'If MessageBox.Show("Barcode not Found in Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            '    txtBarcode.Clear()
            '    txtBarcode.Focus()
            'End If
        End If
       READER.Close()
        MysqlConn.Close()

    End Function
    'Sub getItemId()
    '    runServer()
    '    MysqlConn.Open()
    '    query = "Select * from mppos_db.tblitem where quantity > 0 and barcode='" & barcode & "' "
    '    COMMAND = New MySqlCommand(query, MysqlConn)
    '    SDA.SelectCommand = COMMAND
    '    SDA.Fill(dbDataset)
    '    bSource.DataSource = dbDataset
    '    READER = COMMAND.ExecuteReader
    '    While READER.Read
    '        barcode = frmCashier.txtBarcode.Text
    '        GlobalitemID = READER("itemid")
    '        frmCashier.lblitemDescription.Text = READER("itemname")
    '        frmCashier.txtPrice.Text = Format(READER("saleprice"), "Standard")
    '        SalePrice = (Format(READER("saleprice"), "Standard")).ToString()
    '        frmCashier.txttotalPrice.Text = Format(READER("saleprice"), "Standard")
    '    End While
    '    READER.Close()
    '    MysqlConn.Close()

    'End Sub

    Function getBarcode() As String
        Dim GridRow As DataGridViewRow = dtgItemPurchase.CurrentRow
        barcode = CStr(GridRow.Cells.Item("BARCODE").Value)
        GlobalQty = CStr(GridRow.Cells.Item("QTY").Value)
        Return barcode
        'quantity = CDbl(GridRow.Cells.Item("Quantity").Value)
    End Function
    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown, dtgItemPurchase.KeyDown, Button1.KeyDown, Button2.KeyDown, Button3.KeyDown, Button4.KeyDown, Button5.KeyDown, Button6.KeyDown, Button7.KeyDown, Button8.KeyDown
        barcode = Trim(txtBarcode.Text)


        If e.KeyCode = Keys.F2 Then
            If panelPaySettled.Visible = False Then
                frmItemLookup.txtSearch.Focus()
                frmItemLookup.ShowDialog()
            End If
        End If
        If e.KeyCode = Keys.Enter Then : FrmTransaction("New")
            If txtBarcode.Text <> Nothing Then
                If chkItemFound() Then : txtBarcodeScanned()
                    txtBarcode.Clear() : txtBarcode.Focus()
                    'Else : txtBarcode.Clear() : frmNotFound.ShowDialog()
                End If
            End If
        End If
        If e.KeyCode = Keys.F3 Then
            frmQTY.lblQtyLabel.Text = "(+) INPUT QUANTITY"
            minusQty = False
            If dtgItemPurchase.Rows.Count = 0 Then
            Else
                getBarcode()
                If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
                    If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
                    ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then
                        If onHandStock() Then
                            If onhanQty = GlobalQty Then
                            ElseIf onhanQty > GlobalQty Then
                                frmQTY.ShowDialog()
                            Else
                                frmNoStock.ShowDialog()

                            End If
                        Else
                            frmNoStock.ShowDialog()

                        End If
                    End If
                ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then
                    If onHandStock() = True Then
                        If onhanQty > 0 Then
                            frmQTY.ShowDialog()
                        Else
                            frmNoStock.ShowDialog()
                        End If
                    Else

                        frmNoStock.ShowDialog()
                    End If
                End If
                'ElseIf barcode <> "" And CDbl(lblCash.Text) = 0 Then : frmAddQuantity.ShowDialog()
                'End If
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            frmQTY.lblQtyLabel.Text = "(-) INPUT QUANTITY"

            If dtgItemPurchase.Rows.Count = 0 Then
            Else
                getBarcode()
                minusQty = True
                If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
                ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then
                    frmQTY.ShowDialog()
                End If
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            If dtgItemPurchase.Rows.Count = 0 Then
            Else
                getBarcode()
                If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
                ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then : FrmTransaction("Discounted")
                End If
            End If
        End If


        If e.KeyCode = Keys.F6 Then
            If dtgItemPurchase.Rows.Count = 0 Then
            Else : getBarcode()
                If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
                ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then : FrmTransaction("RemoveItem")
                End If
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            If lblTransID.Text <> Nothing And CDbl(lblCash.Text) = 0 Then FrmTransaction("Accept")
        End If


        If e.KeyCode = Keys.F10 Then
            If lblTransID.Text <> Nothing And dtgItemPurchase.RowCount <> 0 Then FrmTransaction("CancelTransact")
        End If
        If e.KeyCode = Keys.F12 Then
            If dtgItemPurchase.Rows.Count = 0 Then
                If MessageBox.Show("Are you sure to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If usertype = "ADMINISTRATOR" Then
                        Me.Close()
                    ElseIf usertype = "CASHIER" Then
                        FrmTransaction("New")
                        Me.Close() : frmLogin.Show() : frmLogin.txtusername.Focus()
                        'Else
                        '    Me.Close() : frmAdminMain.Close() : frmLogin.Show(frmLogin.txtusername.Focus())
                    End If
                    panelPaySettled.Visible = False
                    lblCash.Text = "0.00"
                    lblChange.Text = "0.00"
                    lblDisc.Text = "0.00"

                End If
            Else
                If MessageBox.Show("Unable to exit,detect active transaction?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                End If
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            If panelPaySettled.Visible = True Then
                panelPaySettled.Visible = False
                txtBarcode.ReadOnly = False
                lblCash.Text = "0.00"
                lblChange.Text = "0.00"
                FrmTransaction("New")
            End If
        End If


    End Sub
    Dim qtyExisted As String
    Function ChkDupBarcodeExist() As Boolean

        For Each RW As DataGridViewRow In dtgItemPurchase.Rows

            If RW.Cells(1).Value.ToString = Trim(txtBarcode.Text) Then
                ChkDupBarcodeExist = True
                qtyExisted = RW.Cells(0).Value.ToString
            End If
        Next



    End Function

    Sub barcodeNotFound()
        frmItemNotFound.lblItemnotFind.Text = "Information Required"
        frmItemNotFound.lnlInfoHelp.Text = "Please select item to the list"
        frmItemNotFound.ShowDialog()
        txtBarcode.Clear()
    End Sub

    Public Function onHandStock() As Boolean
        'Dim f As Boolean
        runServer()
        MysqlConn.Open()
        query = "Select * from mppos_db.tblitem where quantity >0 and barcode='" & barcode & "' "
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read = True
            onhanQty = READER("Quantity")
            onHandStock = True
        End While
        READER.Close()
        MysqlConn.Close()
        'If f = True Then Return True Else  : f = False

    End Function

    Sub txtBarcodeScanned()
        If ChkDupBarcodeExist() Then
            barcode = Trim(txtBarcode.Text)

            If barcode = "" Then : barcodeNotFound()
            ElseIf barcode <> "" And CDbl(lblCash.Text) = 0 Then

                If onHandStock() Then
                    Dim numQty As Integer
                    If dtgItemPurchase.RowCount <> 0 Then
                        'Dim GridRow As DataGridViewRow = dtgItemPurchase.CurrentRow
                        'numQty = CStr(GridRow.Cells.Item("QTY").Value)


                    End If

                    If onhanQty >= 1 Then
                        quantity = qtyExisted + 1
                        addQty = 1
                        'SalePrice = txtPrice.Text
                        'SalePrice = SalePrice * quantity
                        FrmTransaction("AddQty")
                    Else
                        MsgBox("error")
                        ' frmNoStock.ShowDialog()
                    End If

                End If

                'quantity = quantity + 1
                'SalePrice = txtPrice.Text
                'SalePrice = SalePrice * quantity
                'FrmTransaction("AddQty")
            End If

        Else : FrmTransaction("Add")
        End If
    End Sub


    Sub AutoTransID(ByVal newID As String)
        'Try


        runServer()
        newID = ""
        Dim continue_num As Double = Nothing

        MysqlConn.Open()
        query = "Select * from mppos_db.tbltransaction"
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read() : continue_num = CDbl(READER("transid")) : End While
        If dbDataset.Rows.Count = 0 Then : newID = "1"
        Else : newID = CDbl(continue_num) + 1
        End If
        lblTransID.Text = Trim(newID)
        READER.Close()
        MysqlConn.Close()
        'Catch ex As Exception
        '    MsgBox("ERROR:" & ex.Message & ex.Source)
        'End Try
    End Sub

    Sub AutoOrNo(ByVal newID As String)
        ' Try

        runServer()
        newID = ""
        Dim continue_num As Double = Nothing

        MysqlConn.Open()
        query = "Select * from mppos_db.tbltransaction"
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read() : continue_num = CDbl(READER("orno")) : End While
        If dbDataset.Rows.Count = 0 Then : newID = "00000000000001"
        Else : newID = String.Format("{0:00000000000000}", Mid(Trim(continue_num), 1, 14) + 1)
        End If
        ORno = Trim(newID) : READER.Close() : MysqlConn.Close()
        'Catch ex As Exception
        '    MsgBox("ERROR:" & ex.Message & ex.Source)
        'End Try
    End Sub
    Sub addtoList()
        myTransaction.setNo()
        runServer()
        MysqlConn.Open()
        query = "insert into mppos_db.tblsolditem (id,transid,itemid,barcode,quantity,saleprice,discount,transdate,userid) values ('" & idSolditem & "','" & lblTransID.Text & "','" & GlobalitemID & "','" & txtBarcode.Text & "','" & "1" & "','" & SalePrice & "','" & "0.0" & "','" & Date.Now.ToShortDateString & "','" & Globaluserid & "')"
        COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()


    End Sub
    'Sub addtoOutStock()
    '    myTransaction.setNoStockout()
    '    runServer()
    '    MysqlConn.Open()
    '    query = "insert into mppos_db.tblstockout (no,transid,itemid,quantity,transdate) values ('" & idStockout & "','" & lblTransID.Text & "','" & GlobalitemID & "','" & "1" & "','" & Date.Now.ToShortDateString & "')"
    '    COMMAND = New MySqlCommand(query, MysqlConn)
    '    READER = COMMAND.ExecuteReader
    '    MysqlConn.Close()
    'End Sub
    Sub UpdateItemQuantity()

        runServer()
        MysqlConn.Open()
        'query = "Select * from mppos_db.tblitem where quantity > 0 and barcode='" & barcode & "' "
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
        If minusQty = True Then
            query = "update mppos_db.tblsolditem set quantity= '" & quantity & "'  where itemid='" & GlobalitemID & "'"

        Else
            query = "update mppos_db.tblsolditem set quantity='" & quantity & "'  where itemid='" & GlobalitemID & "'"

        End If
        COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()
       
        myTransaction.getActivePurchaseItemList()
        myTransaction.computeTotalAmountDue()
        txtBarcode.Clear()

        MysqlConn.Open()
        If minusQty = True Then
            query = "update mppos_db.tblitem set quantity=quantity +'" & frmQTY.txtQty.Text & "'  where itemid='" & GlobalitemID & "'"
        Else
            query = "update mppos_db.tblitem set quantity=quantity- '" & addQty & "'  where itemid='" & GlobalitemID & "'"
        End If
         COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()


        GlobalitemID = Nothing
        barcode = Nothing
        quantity = 0
        addQty = 0

    End Sub

    Sub updateSoldItem()

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
        query = "UPDATE mppos_db.tblsolditem set tblsolditem.discount = '" & disInPrcent & "'  where tblsolditem.itemid='" & GlobalitemID & "'"
        COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()
        myTransaction.getActivePurchaseItemList()
        myTransaction.computeTotalAmountDue()
        barcode = Nothing : discAmount = 0.0
        GlobalitemID = Nothing
        frmDiscount.txtDiscount.Clear()
        'mysales.loadListSales() : TotalPayment()
        'TotalPaymentWDisc() : datagridStyle()
    End Sub

    Sub FrmTransaction(ByVal a As String)
        Select Case a
            Case "Load"

                'btnDis() : txtBarcode.Focus()
                'lblitemDescription.Text = "Item Description"
                'txtPrice.Text = "0.00" : lblTransID.Text = ""
            Case "New"
                grpitemcount.Visible = True
                txtBarcode.Focus() : AutoTransID(lblTransID.Text)
                myTransaction.getActivePurchaseItemList()
                myTransaction.computeTotalAmountDue()
                AutoOrNo(ORno) ': btnDis()
            Case "Add"
                myTransaction.generateItemDetails()
                addtoList() : myTransaction.getActivePurchaseItemList()
                myTransaction.computeTotalAmountDue()
                txtBarcode.Clear() : txtBarcode.Focus()
                'datagridStyle()

            Case "AddQty"
                UpdateItemQuantity() : txtBarcode.Focus()

                txtBarcode.Focus()
            Case "ReduceQty"
                UpdateItemQuantity() : txtBarcode.Focus()
                txtBarcode.Focus()
                'datagridStyle()

                'Case "ItemLookup"
                '    frmItemLookUp.ShowDialog()
                '    frmItemLookUp.txtFind.Focus()
                'Case "Settle"
            Case "Discounted"
                frmRestrictionKey.lblSecInfo.Text = "Please provide security key" & vbCrLf &
                "to Access a Discount of an Item"
                triggerSecurityPass = "Discount" : frmRestrictionKey.ShowDialog()
                'Case "QuickEntry"
                '    frmRestrictionPassword.lblSecInfo.Text = "Please provide security key" & vbCrLf &
                '    "to Quick Entry an Item"
                '    triggerSecurityPass = "QuickEntry" : frmRestrictionPassword.ShowDialog()
            Case "Save Transaction"

                frmTransactProcess.ShowDialog()
            Case "Accept"
                If dtgItemPurchase.Rows.Count = 0 Then : Else : frmCashPay.ShowDialog()
                End If
            Case ("RemoveItem")
                frmRestrictionKey.lblSecInfo.Text = "Please provide security key" & vbCrLf &
                "to remove Individual Item"
                triggerSecurityPass = "RemoveItem" : frmRestrictionKey.ShowDialog()
            Case "CancelTransact"
                frmRestrictionKey.lblSecInfo.Text = "Please provide security key" & vbCrLf &
                    "to cancel the Transaction"
                triggerSecurityPass = "CanceTransact" : removeTransaction()
        End Select
    End Sub
    Sub removeTransaction()
        '  AbortConfirm = True
        frmRestrictionKey.lblSecInfo.Text = "Please provide security key"
        frmRestrictionKey.ShowDialog()
    End Sub


    

    Private Sub txtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarcode.KeyPress
        txtBarcode.BackColor = Color.Black
    End Sub

    Private Sub txtBarcode_Leave(sender As Object, e As EventArgs) Handles txtBarcode.Leave
        '   txtBarcode.BackColor = Color.LightYellow
    End Sub

    Private Sub dtgItemPurchase_SelectionChanged(sender As Object, e As EventArgs) Handles dtgItemPurchase.SelectionChanged
        Dim a As String
        Dim GridRow As DataGridViewRow = dtgItemPurchase.CurrentRow
        barcode = CStr(GridRow.Cells.Item("BARCODE").Value)
        GlobalQty = CDbl(GridRow.Cells.Item("QTY").Value)
        a = CStr(GridRow.Cells.Item("DESCRIPTION").Value)
        lblitemDescription.Text = PadLeft(a, " ", 20)
        txtPrice.Text = Format(CDbl(GridRow.Cells.Item("SALEPRICE").Value), "Standard")
        txttotalPrice.Text = Format(CDbl(GridRow.Cells.Item("AMOUNT").Value), "Standard")
      

    End Sub

    Private Sub dtgItemPurchase_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.F3 Then
        '    If dtgItemPurchase.Rows.Count = 0 Then
        '    Else
        '        Dim GridRow As DataGridViewRow = dtgItemPurchase.CurrentRow
        '        barcode = CStr(GridRow.Cells.Item("BARCODE").Value)
        '        GlobalQty = CStr(GridRow.Cells.Item("QTY").Value)
        '        If barcode = "" And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
        '            If barcode = "" And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
        '            ElseIf barcode <> "" And CDbl(lblCash.Text) = 0 Then
        '                If onHandStock() Then
        '                    If onhanQty = GlobalQty Then
        '                    ElseIf onhanQty > GlobalQty Then
        '                        frmQTY.ShowDialog()
        '                    Else
        '                        frmNoStock.ShowDialog()
        '                    End If
        '                Else
        '                    frmNoStock.ShowDialog()
        '                End If
        '            End If
        '        ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then
        '            If onHandStock() = True Then
        '                If onhanQty > 0 Then
        '                    frmQTY.ShowDialog()
        '                Else
        '                    frmNoStock.ShowDialog()
        '                End If
        '            Else
        '                frmNoStock.ShowDialog()
        '            End If
        '        End If
        '    End If
        'End If

        'If e.KeyCode = Keys.F2 Then
        '    frmItemLookup.ShowDialog()
        'End If

    End Sub

 

    Private Sub frmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPosID.Text = Globaluserid
        lblFullname.Text = userinfo
        lblPosition.Text = usertype
        FrmTransaction("New")

        Timer1.Interval = 250
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Timer()
        Static bDummy As Boolean

        bDummy = Not bDummy
        If bDummy Then
            lblblink.ForeColor = Color.Aqua
        Else
            lblblink.ForeColor = Color.Red
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1_Timer()
        tsslTime.Text = Format(Date.Now, "General Date")

    End Sub
    Sub GenerateReceipt()
        Try
            AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
            ' Me.PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 6, FontStyle.Regular)
        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0 : w = 0
            left = 0 : top = 0
        End With
        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer
        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 6, FontStyle.Regular), Brushes.Black, b, format)
        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then : e.HasMorePages = True
        Else : e.HasMorePages = False : currentChar = 0
        End If
        duplicateReciept()
    End Sub

  
 
    Private Sub btnExit_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

  
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub pnelHeadersystem_Paint(sender As Object, e As PaintEventArgs) Handles pnelHeadersystem.Paint

    End Sub

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If panelPaySettled.Visible = False Then
            frmItemLookup.txtSearch.Focus()
            frmItemLookup.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmQTY.lblQtyLabel.Text = "(+) INPUT QUANTITY"
        minusQty = False
        If dtgItemPurchase.Rows.Count = 0 Then
        Else
            getBarcode()
            If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
                If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
                ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then
                    If onHandStock() Then
                        If onhanQty = GlobalQty Then
                        ElseIf onhanQty > GlobalQty Then
                            frmQTY.ShowDialog()
                        Else
                            frmNoStock.ShowDialog()

                        End If
                    Else
                        frmNoStock.ShowDialog()

                    End If
                End If
            ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then
                If onHandStock() = True Then
                    If onhanQty > 0 Then
                        frmQTY.ShowDialog()
                    Else
                        frmNoStock.ShowDialog()
                    End If
                Else

                    frmNoStock.ShowDialog()
                End If
            End If
            'ElseIf barcode <> "" And CDbl(lblCash.Text) = 0 Then : frmAddQuantity.ShowDialog()
            'End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmQTY.lblQtyLabel.Text = "(-) INPUT QUANTITY"

        If dtgItemPurchase.Rows.Count = 0 Then
        Else
            getBarcode()
            minusQty = True
            If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
            ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then
                frmQTY.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dtgItemPurchase.Rows.Count = 0 Then
        Else
            getBarcode()
            If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
            ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then : FrmTransaction("Discounted")
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If dtgItemPurchase.Rows.Count = 0 Then
        Else : getBarcode()
            If barcode = Nothing And CDbl(lblCash.Text) = 0 Then : barcodeNotFound()
            ElseIf barcode <> Nothing And CDbl(lblCash.Text) = 0 Then : FrmTransaction("RemoveItem")
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If lblTransID.Text <> Nothing And CDbl(lblCash.Text) = 0 Then FrmTransaction("Accept")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If lblTransID.Text <> Nothing And dtgItemPurchase.RowCount <> 0 Then FrmTransaction("CancelTransact")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If dtgItemPurchase.Rows.Count = 0 Then
            If MessageBox.Show("Are you sure to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If usertype = "ADMINISTRATOR" Then
                    Me.Close()
                ElseIf usertype = "CASHIER" Then
                    FrmTransaction("New")
                    Me.Close() : frmLogin.Show() : frmLogin.txtusername.Focus()
                    'Else
                    '    Me.Close() : frmAdminMain.Close() : frmLogin.Show(frmLogin.txtusername.Focus())
                End If
                panelPaySettled.Visible = False
                lblCash.Text = "0.00"
                lblChange.Text = "0.00"
                lblDisc.Text = "0.00"

            End If
        Else
            If MessageBox.Show("Unable to exit,detect active transaction?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub
End Class