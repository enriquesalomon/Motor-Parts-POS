Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class StockAdjustment

    Sub itemlist()
        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource


        If search Then
            If frmStockAdjustDetail.cmbfilter.Text = "PRODUCT CODE" Then
                query = "Select barcode,itemname,category,quantity from mppos_db.tblitem where barcode like '" & frmStockAdjustDetail.txtSearch.Text & "%' order by itemid"
            ElseIf frmStockAdjustDetail.cmbfilter.Text = "DESCRIPTION" Then
                query = "Select barcode,itemname,category,quantity from mppos_db.tblitem where itemname like '" & frmStockAdjustDetail.txtSearch.Text & "%' order by itemid"
            ElseIf frmStockAdjustDetail.cmbfilter.Text = "CATEGORY" Then
                query = "Select barcode,itemname,category,quantity from mppos_db.tblitem where category like '" & frmStockAdjustDetail.txtSearch.Text & "%' order by itemid"

            End If
        Else
            query = "Select barcode,itemname,category,quantity from mppos_db.tblitem"
        End If
        Try
            MysqlConn.Open()
            frmStockAdjustDetail.dtgStockAdjustList.Rows.Clear()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset

            READER = COMMAND.ExecuteReader
            If dbDataset.Rows.Count > 0 Then
                frmStockAdjustDetail.dtgStockAdjustList.ColumnCount = 4
                frmStockAdjustDetail.dtgStockAdjustList.Columns(0).HeaderText = "PRODUCT_CODE" : frmStockAdjustDetail.dtgStockAdjustList.Columns(0).Width = 100 : frmStockAdjustDetail.dtgStockAdjustList.Columns(0).Name = "barcode"
                frmStockAdjustDetail.dtgStockAdjustList.Columns(1).HeaderText = "DESCRIPTION" : frmStockAdjustDetail.dtgStockAdjustList.Columns(1).Width = 100 : frmStockAdjustDetail.dtgStockAdjustList.Columns(1).Name = "itemname"
                frmStockAdjustDetail.dtgStockAdjustList.Columns(2).HeaderText = "CATEGORY" : frmStockAdjustDetail.dtgStockAdjustList.Columns(2).Width = 120 : frmStockAdjustDetail.dtgStockAdjustList.Columns(2).Name = "category"
                frmStockAdjustDetail.dtgStockAdjustList.Columns(3).HeaderText = "ONHAND" : frmStockAdjustDetail.dtgStockAdjustList.Columns(3).Width = 400 : frmStockAdjustDetail.dtgStockAdjustList.Columns(3).Name = "quantity"
                For Each row As DataRow In dbDataset.Rows
                    Dim rowData As String() = New String() {row("barcode").ToString, row("itemname").ToString, row("category").ToString, row("quantity").ToString}
                    frmStockAdjustDetail.dtgStockAdjustList.Rows.Add(rowData)
                Next
            End If

            READER.Close()
            MysqlConn.Close()
            frmStockAdjustDetail.lblCountdtg.Text = frmStockAdjustDetail.dtgStockAdjustList.Rows.Count & " Records"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Sub adjustmentlist(ByVal Param As String)
        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource


        If Param = "LOADBYDATE" Then
            '  query = "SELECT tblstockadjust.adjustno,tblstockadjust.itemid,tblitem.Barcode,tblitem.itemname,tblstockadjust.qty,tblstockadjust.action,tblstockadjust.reason,tblstockadjust.date,tblstockadjust.adjustedby FROM mppos_db.tblstockadjust INNER JOIN mppos_db.tblitem ON tblstockadjust.itemid = tblitem.itemid WHERE ((tblstockadjust.date Between '" & frmStockAdjustQty.dtpFrom.Text & "' and '" & frmStockAdjustQty.dtpTo.Text & "' )) order by tblstockadjust.date"
            query = "SELECT  tblstockadjust.adjustno,tblstockadjust.itemid,tblitem.Barcode,tblitem.itemname,tblstockadjust.qty,tblstockadjust.action,tblstockadjust.reason,tblstockadjust.date,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as USER FROM ((mppos_db.tblstockadjust) INNER JOIN mppos_db.tblitem ON tblstockadjust.itemid = tblitem.itemid)INNER JOIN mppos_db.tbluseraccount ON tblstockadjust.adjustedby = tbluseraccount.userid WHERE ((tblstockadjust.date Between '" & frmStockAdjustQty.dtpFrom.Text & "' and '" & frmStockAdjustQty.dtpTo.Text & "' )) order by tblstockadjust.date"

        ElseIf Param = "LOADALL" Then
            'query = "SELECT tblstockadjust.adjustno,tblstockadjust.itemid,tblitem.Barcode,tblitem.itemname,tblstockadjust.qty,tblstockadjust.action,tblstockadjust.reason,tblstockadjust.date,tblstockadjust.adjustedby FROM mppos_db.tblstockadjust INNER JOIN mppos_db.tblitem ON tblstockadjust.itemid = tblitem.itemid order by no"

            query = "SELECT  tblstockadjust.adjustno,tblstockadjust.itemid,tblitem.Barcode,tblitem.itemname,tblstockadjust.qty,tblstockadjust.action,tblstockadjust.reason,tblstockadjust.date,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as USER FROM ((mppos_db.tblstockadjust) INNER JOIN mppos_db.tblitem ON tblstockadjust.itemid = tblitem.itemid)INNER JOIN mppos_db.tbluseraccount ON tblstockadjust.adjustedby = tbluseraccount.userid "

        End If
        Try
            If frmStockAdjustQty.dtgStockAdjustmentList.Rows.Count <> 0 Then
                frmStockAdjustQty.dtgStockAdjustmentList.Rows.Clear()
            End If
            MysqlConn.Open()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset

            READER = COMMAND.ExecuteReader
            If dbDataset.Rows.Count > 0 Then
                frmStockAdjustQty.dtgStockAdjustmentList.ColumnCount = 9
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(0).HeaderText = "Refference No" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(0).Width = 100 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(0).Name = "adjustno"
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(1).HeaderText = "Product ID" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(1).Width = 100 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(1).Name = "itemid"
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(2).HeaderText = "Product Code" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(2).Width = 120 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(2).Name = "Barcode"
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(3).HeaderText = "Description" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(3).Width = 400 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(3).Name = "itemname"
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(4).HeaderText = "Qty" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(4).Width = 50 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(4).Name = "qty"
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(5).HeaderText = "Action" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(5).Width = 80 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(5).Name = "action"
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(6).HeaderText = "Reason" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(6).Width = 250 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(6).Name = "reason"
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(7).HeaderText = "Date" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(7).Width = 100 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(7).Name = "date"
                frmStockAdjustQty.dtgStockAdjustmentList.Columns(8).HeaderText = "User" : frmStockAdjustQty.dtgStockAdjustmentList.Columns(8).Width = 100 : frmStockAdjustQty.dtgStockAdjustmentList.Columns(8).Name = "USER"

                For Each row As DataRow In dbDataset.Rows
                    Dim rowData As String() = New String() {row("adjustno").ToString, row("itemid").ToString, row("Barcode").ToString, row("itemname").ToString, row("qty").ToString, row("action").ToString, row("reason").ToString, row("date").ToString, row("USER").ToString}
                    frmStockAdjustQty.dtgStockAdjustmentList.Rows.Add(rowData)
                Next
            End If

            READER.Close()
            MysqlConn.Close()
            frmStockAdjustQty.lblAdjustCountdtg.Text = frmStockAdjustQty.dtgStockAdjustmentList.Rows.Count & " Records"



            'Dim i As Integer = 0
            'For Each RW As DataGridViewRow In frmStockAdjustQty.dtgStockAdjustmentList.Rows

            '    If RW.Cells(5).Value.ToString = "Remove" Then
            '        frmStockAdjustQty.dtgStockAdjustmentList.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
            '        frmStockAdjustQty.dtgStockAdjustmentList.Rows(i).DefaultCellStyle.ForeColor = Color.White
            '    Else
            '        frmStockAdjustQty.dtgStockAdjustmentList.Rows(i).DefaultCellStyle.BackColor = Color.White
            '        frmStockAdjustQty.dtgStockAdjustmentList.Rows(i).DefaultCellStyle.ForeColor = Color.Black

            '    End If : i += 1


            '    'totdiscount += CDbl(RW.Cells(4).Value.ToString)
            'Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Sub loadData()

        Dim GridRow As DataGridViewRow = frmStockAdjustDetail.dtgStockAdjustList.CurrentRow
        frmStockAdjustDetail.txtBarcode.Text = CStr(GridRow.Cells.Item("barcode").Value)
        frmStockAdjustDetail.txtDescription.Text = CStr(GridRow.Cells.Item("itemname").Value)
        frmStockAdjustDetail.txtCategory.Text = CStr(GridRow.Cells.Item("category").Value)
        frmStockAdjustDetail.txtQtyONhand.Text = CStr(GridRow.Cells.Item("quantity").Value)

        query = "Select * from mppos_db.tblitem where barcode='" & frmStockAdjustDetail.txtBarcode.Text & "'"
        MysqlConn.Open()

        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        If READER.Read Then
            frmStockAdjustDetail.txtProdID.Text = READER("itemid")
            frmStockAdjustDetail.txtModel.Text = READER("model")
            frmStockAdjustDetail.txtSize.Text = READER("size")
            frmStockAdjustDetail.txtColor.Text = READER("color")
            frmStockAdjustDetail.txtUnit.Text = READER("unit")
        End If

        READER.Close()
        MysqlConn.Close()

    End Sub

    Sub SaveStockAdjustment()
        runServer()
        setNo()
        Try
            If frmStockAdjustDetail.txtAdjustRefNo.Text <> Nothing Then

                MysqlConn.Open()

                If MessageBox.Show("Do you want to Adjust this Item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    query = "insert into mppos_db.tblstockadjust (no,adjustno,itemid,qty,action,reason,date,adjustedby) values ('" & adjustNo & "','" & frmStockAdjustDetail.txtAdjustRefNo.Text & "','" & frmStockAdjustDetail.txtProdID.Text & "','" & frmStockAdjustDetail.txtqty.Text & "','" & frmStockAdjustDetail.cmbActionadjust.Text & "','" & frmStockAdjustDetail.txtReason.Text & "','" & Date.Now.ToShortDateString & "','" & Globaluserid & "')"
                    COMMAND = New MySqlCommand(query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MsgBox("Record successfully added!", MsgBoxStyle.Information)
                End If
                MysqlConn.Close()

                If frmStockAdjustDetail.cmbActionadjust.Text = "Add" Then
                    '' insert data to stockin


                    MysqlConn.Open()
                    query = "insert into mppos_db.tblstockin (no,stockbatch,itemid,barcode,quantity,dateinserted,addedby) values ('" & globalstockNumber & "','" & frmStockAdjustDetail.txtStockno.Text & "','" & frmStockAdjustDetail.txtProdID.Text & "','" & frmStockAdjustDetail.txtBarcode.Text & "','" & frmStockAdjustDetail.txtqty.Text & "','" & Date.Now.ToShortDateString & "','" & Globaluserid & "')"
                    COMMAND = New MySqlCommand(query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MysqlConn.Close()
                End If




                If frmStockAdjustDetail.cmbActionadjust.Text = "Add" Then
                    OnhandQty = CInt(frmStockAdjustDetail.txtqty.Text) + CInt(frmStockAdjustDetail.txtQtyONhand.Text)
                Else
                    OnhandQty = CInt(frmStockAdjustDetail.txtQtyONhand.Text) - CInt(frmStockAdjustDetail.txtqty.Text)
                End If
                MysqlConn.Open()
                query = "update mppos_db.tblitem set quantity='" & OnhandQty & "' where itemid='" & frmStockAdjustDetail.txtProdID.Text & "'"
                COMMAND = New MySqlCommand(query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MysqlConn.Close()
                OnhandQty = Nothing
                clearTxt("stockadjustdetail")
                itemlist()
                adjustmentlist("LOADALL")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Dim OnhandQty As Integer
    Sub stockAdjustment()
       
           End Sub
    Dim adjustNo As String
    Sub setNo()

        runServer()
        adjustNo = Nothing
        Dim last As Integer
        Dim continue_num As Integer
        query = "Select * from mppos_db.tblstockadjust order by no"

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
        adjustNo = continue_num
        READER.Close()
        MysqlConn.Close()

    End Sub



    Sub printStockAdjustListreport()
        Dim officeexcel As New Microsoft.Office.Interop.Excel.Application 'creat office application
        officeexcel = CreateObject("Excel.Application")
        Dim workbook As Object = officeexcel.Workbooks.Add(StockAdjustTemplate)
        Dim num As Integer = 1
        Dim excelrow As Integer

        Dim i As Integer = 0
        For Each RW As DataGridViewRow In frmStockAdjustQty.dtgStockAdjustmentList.Rows

            With officeexcel
                .Range("B" & (7)).Value = ("Stock Adjustment Report").ToString
                .Range("B" & (8)).Value = (Date.Now.ToShortDateString).ToString

                .Range("A" & (i + 13)).Value = (RW.Cells(1).Value).ToString
                .Range("B" & (i + 13)).Value = (RW.Cells(2).Value).ToString
                .Range("C" & (i + 13)).Value = (RW.Cells(3).Value).ToString
                .Range("D" & (i + 13)).Value = (RW.Cells(4).Value).ToString
                .Range("E" & (i + 13)).Value = (RW.Cells(5).Value).ToString
                .Range("F" & (i + 13)).Value = (RW.Cells(6).Value).ToString
                .Range("G" & (i + 13)).Value = (RW.Cells(7).Value).ToString
                .Range("H" & (i + 13)).Value = (RW.Cells(8).Value).ToString


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
            .Range("A" & (excelrow + 15)).Value = ("No. of Items: " & frmStockAdjustQty.dtgStockAdjustmentList.Rows.Count).ToString
            '   .Range("F" & (excelrow + 15)).Value = ("Total Qty: " & frmStockList.lblqty.Text).ToString

            .Range("A" & (excelrow + 17)).Value = ("Prepared By: " & frmAdminMain.lblUser.Text).ToString
        End With
        officeexcel.Visible = True
        officeexcel = Nothing
        workbook = Nothing
    End Sub



End Class
