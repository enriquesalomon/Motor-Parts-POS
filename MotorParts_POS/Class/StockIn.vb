Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class StockIn
  
    Function setAutoFillupTextField(parametersID As String) As String
        'Try

        If MysqlConn.State = ConnectionState.Open Then
            MysqlConn.Close()
        End If

        MysqlConn.Open()
        If parametersID = "itemdescription" Then
            query = "Select * from mppos_db.tblitem where tblitem.itemname  ='" & frmStockIn.txtitemdescription.Text & "'"
        Else
            ' query = "SELECT tblitem.book_barcodeNo FROM mppos_db.tblitem INNER JOIN mppos_db.tblstockin ON tblstockin.itemid = tblitem.itemid where tblTransaction.Borrowed_Status  ='" & "UNRETURNED" & "' and tblTransaction.book_barcodeNo ='" & frmBorrow.txtBookCode.Text & "'"

            query = "Select * from mppos_db.tblitem where tblitem.barcode  ='" & frmStockIn.txtBarcode.Text & "'"
        End If

        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read()
            If parametersID = "itemdescription" Then
                frmStockIn.txtprodid.Text = READER("itemid")
                frmStockIn.txtBarcode.Text = READER("barcode")
                frmStockIn.txtitemdescription.Text = READER("itemname")
                frmStockIn.txtCategory.Text = READER("category")
                frmStockIn.txtModel.Text = READER("model")
                frmStockIn.txtsize.Text = READER("size")
                frmStockIn.txtcolor.Text = READER("color")
                frmStockIn.txtunit.Text = READER("unit")
                frmStockIn.txtQtyOnHand.Text = READER("quantity")

            Else
                frmStockIn.txtprodid.Text = READER("itemid")
                frmStockIn.txtitemdescription.Text = READER("itemname")
                frmStockIn.txtCategory.Text = READER("category")
                frmStockIn.txtModel.Text = READER("model")
                frmStockIn.txtsize.Text = READER("size")
                frmStockIn.txtcolor.Text = READER("color")
                frmStockIn.txtunit.Text = READER("unit")
                frmStockIn.txtQtyOnHand.Text = READER("quantity")
            End If

        End While


        READER.Close()
        MysqlConn.Close()
        'Catch ex As Exception
        '    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.Exclamation, "Connection Error!")
        '    MysqlConn.Close()
        'End Try
    End Function
    Sub itemlistsearch()

        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            If search = True Then
                query = "Select * from mppos_db.tblitem where tblitem.itemname  like'" & frmStockIn.txtSearch.Text & "%' "
            Else
                query = "SELECT * from mppos_db.tblitem"

            End If
        
            'dbDataset.Clear()
            'dbDataset.Rows.Clear()
            frmStockIn.dtgItemsearch.Rows.Clear()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset

            READER = COMMAND.ExecuteReader
            If dbDataset.Rows.Count > 0 Then
                frmStockIn.dtgItemsearch.ColumnCount = 3
                frmStockIn.dtgItemsearch.Columns(0).HeaderText = "Item ID" : frmStockIn.dtgItemsearch.Columns(0).Width = 100 : frmStockIn.dtgItemsearch.Columns(0).Name = "itemid"
                frmStockIn.dtgItemsearch.Columns(1).HeaderText = "Barcode" : frmStockIn.dtgItemsearch.Columns(1).Width = 100 : frmStockIn.dtgItemsearch.Columns(1).Name = "barcode"
                frmStockIn.dtgItemsearch.Columns(2).HeaderText = "Description" : frmStockIn.dtgItemsearch.Columns(2).Width = 300 : frmStockIn.dtgItemsearch.Columns(2).Name = "itemname"
               
                For Each row As DataRow In dbDataset.Rows
                    Dim rowData As String() = New String() {row("itemid").ToString, row("barcode").ToString, row("itemname").ToString}
                    frmStockIn.dtgItemsearch.Rows.Add(rowData)
                Next
            End If

            READER.Close()
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try





    End Sub

    Sub stocklist(ByVal param As String)

        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        '    Try
        MysqlConn.Open()
        If param = "LOADBYDATE" Then
             query = "SELECT tblstockin.stockbatch,tblstockin.itemid,tblstockin.Barcode,tblitem.itemname,tblitem.category,tblstockin.quantity,tblstockin.dateinserted,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as USER FROM ((mppos_db.tblstockin) INNER JOIN mppos_db.tblitem ON tblstockin.itemid = tblitem.itemid)INNER JOIN mppos_db.tbluseraccount ON tblstockin.addedby = tbluseraccount.userid WHERE ((tblstockin.dateinserted Between '" & frmStockList.dtpfrom.Text & "' and '" & frmStockList.dtpto.Text & "' ))   order by tblstockin.dateinserted ASC "

        ElseIf param = "LOADALL" Then
            If search = True Then
                  query = "SELECT tblstockin.stockbatch,tblstockin.itemid,tblstockin.Barcode,tblitem.itemname,tblitem.category,tblstockin.quantity,tblstockin.dateinserted,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as USER FROM ((mppos_db.tblstockin) INNER JOIN mppos_db.tblitem ON tblstockin.itemid = tblitem.itemid)INNER JOIN mppos_db.tbluseraccount ON tblstockin.addedby = tbluseraccount.userid where tblitem.itemname like '" & frmStockList.txtSearch.Text & "%' order by tblstockin.no"

            Else
                'query = "SELECT tblstockin.stockbatch,tblstockin.itemid,tblstockin.Barcode,tblitem.itemname,tblitem.category,tblstockin.quantity,tblstockin.dateinserted,tblstockin.addedby as USER FROM mppos_db.tblstockin INNER JOIN mppos_db.tblitem ON tblstockin.itemid = tblitem.itemid "
                query = "SELECT tblstockin.stockbatch,tblstockin.itemid,tblstockin.Barcode,tblitem.itemname,tblitem.category,tblstockin.quantity,tblstockin.dateinserted,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as USER FROM ((mppos_db.tblstockin) INNER JOIN mppos_db.tblitem ON tblstockin.itemid = tblitem.itemid)INNER JOIN mppos_db.tbluseraccount ON tblstockin.addedby = tbluseraccount.userid "

            End If

        End If
        'dbDataset.Clear()
        'dbDataset.Rows.Clear()
        frmStockList.dtgstocklist.Rows.Clear()
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset

        READER = COMMAND.ExecuteReader
        If dbDataset.Rows.Count > 0 Then
            frmStockList.dtgstocklist.ColumnCount = 8
            frmStockList.dtgstocklist.Columns(0).HeaderText = "Refference_No" : frmStockList.dtgstocklist.Columns(0).Width = 100 : frmStockList.dtgstocklist.Columns(0).Name = "stockbatch"
            frmStockList.dtgstocklist.Columns(1).HeaderText = "Item ID" : frmStockList.dtgstocklist.Columns(1).Width = 100 : frmStockList.dtgstocklist.Columns(1).Name = "itemid"
            frmStockList.dtgstocklist.Columns(2).HeaderText = "Barcode" : frmStockList.dtgstocklist.Columns(2).Width = 120 : frmStockList.dtgstocklist.Columns(2).Name = "Barcode"
            frmStockList.dtgstocklist.Columns(3).HeaderText = "Description" : frmStockList.dtgstocklist.Columns(3).Width = 400 : frmStockList.dtgstocklist.Columns(3).Name = "itemname"
            frmStockList.dtgstocklist.Columns(4).HeaderText = "Category" : frmStockList.dtgstocklist.Columns(4).Width = 150 : frmStockList.dtgstocklist.Columns(4).Name = "category"
            frmStockList.dtgstocklist.Columns(5).HeaderText = "Qty" : frmStockList.dtgstocklist.Columns(5).Width = 50 : frmStockList.dtgstocklist.Columns(5).Name = "quantity"
            frmStockList.dtgstocklist.Columns(6).HeaderText = "Date" : frmStockList.dtgstocklist.Columns(6).Width = 100 : frmStockList.dtgstocklist.Columns(6).Name = "dateinserted"
            frmStockList.dtgstocklist.Columns(7).HeaderText = "User" : frmStockList.dtgstocklist.Columns(7).Width = 100 : frmStockList.dtgstocklist.Columns(7).Name = "USER"

            For Each row As DataRow In dbDataset.Rows
                Dim rowData As String() = New String() {row("stockbatch").ToString, row("itemid").ToString, row("Barcode").ToString, row("itemname").ToString, row("category").ToString, row("quantity").ToString, row("dateinserted").ToString, row("USER").ToString}
                frmStockList.dtgstocklist.Rows.Add(rowData)
            Next
        End If

        READER.Close()
        MysqlConn.Close()

        Dim TotQty As Double = 0

        If frmStockList.dtgstocklist.Rows.Count <> 0 Then
            Dim i As Integer = 0
            For Each RW As DataGridViewRow In frmStockList.dtgstocklist.Rows
                TotQty += CDbl(RW.Cells(5).Value)
                i += 1
            Next
        End If
        frmStockList.lblqty.Text = TotQty



        'frmStockList.dtgstocklist.DataSource = bSource
        'SDA.Update(dbDataset)
        'MysqlConn.Close()
        frmStockList.dtgstocklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        frmStockList.lblCountdtg.Text = frmStockList.dtgstocklist.Rows.Count & " Records"

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()

        'End Try





    End Sub

    Sub SaveStock()
        runServer()
        Try

            If MessageBox.Show("Are you sure you want to add this Item to Stock?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                setNo()
                MysqlConn.Open()
                query = "insert into mppos_db.tblstockin (no,stockbatch,itemid,barcode,quantity,dateinserted,addedby) values ('" & globalstockNumber & "','" & frmStockIn.txtStockno.Text & "','" & frmStockIn.txtprodid.Text & "','" & frmStockIn.txtBarcode.Text & "','" & frmStockIn.txtQty.Text & "','" & Date.Now.ToShortDateString & "','" & Globaluserid & "')"
                COMMAND = New MySqlCommand(query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MysqlConn.Close()
                MysqlConn.Open()
                query = "update mppos_db.tblitem set quantity='" & frmStockIn.txtTotalQtyOnHand.Text & "' where itemid='" & frmStockIn.txtprodid.Text & "'"
                COMMAND = New MySqlCommand(query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MysqlConn.Close()
                MsgBox(" Record has been successfully added!", MsgBoxStyle.Information)
                addToStockDTG()
                frmStockIn.txtQtyOnHand.Text = "0"
                clearTxt("stockitem")

            End If


            stocklist("LOADALL")

            frmItemDetails.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Sub setNo()

        runServer()
        globalstockNumber = Nothing
        Dim last As Integer
        Dim continue_num As Integer
        query = "Select * from mppos_db.tblstockin order by no"

        MysqlConn.Open()
        ' query = "Select * from mppos_db.tbluseraccount"
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read()
            last = CInt(READER("no"))
        End While
        continue_num = last + 1
        globalstockNumber = continue_num
        READER.Close()
        MysqlConn.Close()

    End Sub
    Sub addToStockDTG()
        frmStockIn.dtgStockIn.ColumnCount = 8
        frmStockIn.dtgStockIn.Columns(0).Name = "Refference_No"
        frmStockIn.dtgStockIn.Columns(1).Name = "PRODUCT ID"
        frmStockIn.dtgStockIn.Columns(2).Name = "BARCODE"
        frmStockIn.dtgStockIn.Columns(3).Name = "DESCRIPTION"
        frmStockIn.dtgStockIn.Columns(4).Name = "CATEGORY"
        frmStockIn.dtgStockIn.Columns(5).Name = "QTY"
        frmStockIn.dtgStockIn.Columns(6).Name = "DATE"
        frmStockIn.dtgStockIn.Columns(7).Name = "USER"
        frmStockIn.dtgStockIn.Enabled = True
        Dim a As String = CStr(frmStockIn.txtStockno.Text)
        Dim b As String = CStr(frmStockIn.txtprodid.Text)
        Dim c As String = CStr(frmStockIn.txtBarcode.Text)
        Dim d As String = CStr(frmStockIn.txtitemdescription.Text)
        Dim ee As String = CStr(frmStockIn.txtCategory.Text)
        Dim f As String = CStr(frmStockIn.txtQty.Text)
        Dim g As String = CStr(Date.Now.ToShortDateString)
        Dim h As String = CStr(Globaluserid)
        Dim row As String() = New String() {a, b, c, d, ee, f, g, h}
        frmStockIn.dtgStockIn.Rows.Add(row)

    End Sub


    Sub printStockInListreport()
        Dim officeexcel As New Microsoft.Office.Interop.Excel.Application 'creat office application
        officeexcel = CreateObject("Excel.Application")
        Dim workbook As Object = officeexcel.Workbooks.Add(StockInTemplate)
        Dim num As Integer = 1
        Dim excelrow As Integer

        Dim i As Integer = 0
        For Each RW As DataGridViewRow In frmStockList.dtgstocklist.Rows

            With officeexcel
                .Range("B" & (7)).Value = ("Stock-in Report").ToString
                .Range("B" & (8)).Value = (Date.Now.ToShortDateString).ToString

                .Range("A" & (i + 13)).Value = (RW.Cells(0).Value).ToString
                .Range("B" & (i + 13)).Value = (RW.Cells(1).Value).ToString
                .Range("C" & (i + 13)).Value = (RW.Cells(2).Value).ToString
                .Range("D" & (i + 13)).Value = (RW.Cells(3).Value).ToString
                .Range("E" & (i + 13)).Value = (RW.Cells(4).Value).ToString
                .Range("F" & (i + 13)).Value = (RW.Cells(5).Value).ToString
                .Range("G" & (i + 13)).Value = (RW.Cells(7).Value).ToString
                .Range("H" & (i + 13)).Value = (RW.Cells(6).Value).ToString

                excelrow = i
                Dim A, B, C, D, E, F, G, H As Excel.Range
                A = officeexcel.Range("A" & (i + 13), "B" & (i + 13))
                B = officeexcel.Range("B" & (i + 13), "C" & (i + 13))
                C = officeexcel.Range("C" & (i + 13), "D" & (i + 13))
                D = officeexcel.Range("D" & (i + 13), "E" & (i + 13))
                E = officeexcel.Range("E" & (i + 13), "F" & (i + 13))
                F = officeexcel.Range("F" & (i + 13), "G" & (i + 13))
                G = officeexcel.Range("G" & (i + 13), "H" & (i + 13))
                H = officeexcel.Range("H" & (i + 13), "H" & (i + 13))
                A.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                B.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                C.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                D.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                E.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                F.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                G.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                H.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)

            End With : i += 1
        Next
        With officeexcel
            .Range("A" & (excelrow + 15)).Value = ("No. of Items: " & frmStockList.dtgstocklist.Rows.Count).ToString
            .Range("F" & (excelrow + 15)).Value = ("Total Qty: " & frmStockList.lblqty.Text).ToString

            .Range("A" & (excelrow + 17)).Value = ("Prepared By: " & frmAdminMain.lblUser.Text).ToString
        End With
        officeexcel.Visible = True
        officeexcel = Nothing
        workbook = Nothing
    End Sub


End Class
