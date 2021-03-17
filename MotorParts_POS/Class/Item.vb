Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class Item
    Function setBoxCategory(cmbtxt As String) As String

        Try

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If

            MysqlConn.Open()
            If cmbtxt = "category" Then
                frmItemDetails.cmbCategory.Items.Clear()
                query = "Select Distinct categoryname from mppos_db.tblcategory order by catid"
            Else
                frmItemDetails.cmbunit.Items.Clear()
                query = "Select Distinct unit from mppos_db.tblitem order by itemid"
            End If

            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            READER = COMMAND.ExecuteReader
            While READER.Read()
                If cmbtxt = "category" Then
                    frmItemDetails.cmbCategory.Items.Add(READER("categoryname"))
                Else
                    frmItemDetails.cmbunit.Items.Add(READER("unit"))
                End If

            End While


            READER.Close()
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.Exclamation, "Connection Error!")
            MysqlConn.Close()
        End Try
    End Function
    Sub AutoCompleteDescription()
        runServer()
        Try
            query = "Select itemname from mppos_db.tblitem order by itemid"
            MysqlConn.Open()

            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            READER = COMMAND.ExecuteReader
            Dim autoComp As New AutoCompleteStringCollection()

            While READER.Read()

                autoComp.Add(READER("itemname"))
            End While
            READER.Close()
            frmStockIn.txtitemdescription.AutoCompleteMode = AutoCompleteMode.Suggest
            frmStockIn.txtitemdescription.AutoCompleteSource = AutoCompleteSource.CustomSource
            frmStockIn.txtitemdescription.AutoCompleteCustomSource = autoComp


            MysqlConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.Exclamation, "Connection Error!")
            MysqlConn.Close()
        End Try
    End Sub
    Sub AutoCompleteBarcode()
        runServer()
        Try
            query = "Select barcode from mppos_db.tblitem order by itemid"
            MysqlConn.Open()

            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            READER = COMMAND.ExecuteReader
            Dim autoComp As New AutoCompleteStringCollection()

            While READER.Read()

                autoComp.Add(READER("barcode"))
            End While
            READER.Close()
            frmStockIn.txtBarcode.AutoCompleteMode = AutoCompleteMode.Suggest
            frmStockIn.txtBarcode.AutoCompleteSource = AutoCompleteSource.CustomSource
            frmStockIn.txtBarcode.AutoCompleteCustomSource = autoComp


            MysqlConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.Exclamation, "Connection Error!")
            MysqlConn.Close()
        End Try
    End Sub
    Sub itemlist()
        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

      
        If search Then
            If frmItem.cmbfilter.SelectedIndex = 0 Then
                ' query = "Select barcode as PRODUCT_CODE,itemname as DESCRIPTION,category as CATEGORY,model as MODEL,size as SIZE,color as COLOR,unit as UNIT,unitcost as UNIT_COST,saleprice as UNIT_SALEPRICE,quantity as QUANTITY,criticallimit as CRITICAL_LIMIT,dateinserted as DATE_INSERTED,datemodified as LAST_MODIFIED,addedby as ADDED_BY,itemid as ITEM_ID from mppos_db.tblitem where barcode like '" & frmItem.txtsearch.Text & "%' order by itemid"
                query = "Select tblitem.barcode as PRODUCT_CODE,tblitem.itemname as DESCRIPTION,tblitem.category as CATEGORY,tblitem.model as MODEL,tblitem.size as SIZE,tblitem.color as COLOR,tblitem.unit as UNIT,tblitem.unitcost as UNIT_COST,tblitem.saleprice as UNIT_SALEPRICE,tblitem.quantity as QUANTITY,tblitem.criticallimit as CRITICAL_LIMIT,tblitem.dateinserted as DATE_INSERTED,tblitem.datemodified as LAST_MODIFIED,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as INSERTED_BY,tblitem.itemid as ITEM_ID FROM mppos_db.tblitem INNER JOIN mppos_db.tbluseraccount ON tbluseraccount.userid = tblitem.addedby where tblitem.barcode like '" & frmItem.txtsearch.Text & "%' order by tblitem.itemid"

            ElseIf frmItem.cmbfilter.SelectedIndex = 1 Then
                'query = "Select barcode as PRODUCT_CODE,itemname as DESCRIPTION,category as CATEGORY,model as MODEL,size as SIZE,color as COLOR,unit as UNIT,unitcost as UNIT_COST,saleprice as UNIT_SALEPRICE,quantity as QUANTITY,criticallimit as CRITICAL_LIMIT,dateinserted as DATE_INSERTED,datemodified as LAST_MODIFIED,addedby as ADDED_BY,itemid as ITEM_ID from mppos_db.tblitem where itemname like '" & frmItem.txtsearch.Text & "%' order by itemid"
                query = "Select tblitem.barcode as PRODUCT_CODE,tblitem.itemname as DESCRIPTION,tblitem.category as CATEGORY,tblitem.model as MODEL,tblitem.size as SIZE,tblitem.color as COLOR,tblitem.unit as UNIT,tblitem.unitcost as UNIT_COST,tblitem.saleprice as UNIT_SALEPRICE,tblitem.quantity as QUANTITY,tblitem.criticallimit as CRITICAL_LIMIT,tblitem.dateinserted as DATE_INSERTED,tblitem.datemodified as LAST_MODIFIED,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as INSERTED_BY,tblitem.itemid as ITEM_ID FROM mppos_db.tblitem INNER JOIN mppos_db.tbluseraccount ON tbluseraccount.userid = tblitem.addedby where tblitem.itemname like '" & frmItem.txtsearch.Text & "%' order by tblitem.itemid"

            ElseIf frmItem.cmbfilter.SelectedIndex = 2 Then
                'query = "Select barcode as PRODUCT_CODE,itemname as DESCRIPTION,category as CATEGORY,model as MODEL,size as SIZE,color as COLOR,unit as UNIT,unitcost as UNIT_COST,saleprice as UNIT_SALEPRICE,quantity as QUANTITY,criticallimit as CRITICAL_LIMIT,dateinserted as DATE_INSERTED,datemodified as LAST_MODIFIED,addedby as ADDED_BY,itemid as ITEM_ID from mppos_db.tblitem where category like '" & frmItem.txtsearch.Text & "%' order by itemid"
                query = "Select tblitem.barcode as PRODUCT_CODE,tblitem.itemname as DESCRIPTION,tblitem.category as CATEGORY,tblitem.model as MODEL,tblitem.size as SIZE,tblitem.color as COLOR,tblitem.unit as UNIT,tblitem.unitcost as UNIT_COST,tblitem.saleprice as UNIT_SALEPRICE,tblitem.quantity as QUANTITY,tblitem.criticallimit as CRITICAL_LIMIT,tblitem.dateinserted as DATE_INSERTED,tblitem.datemodified as LAST_MODIFIED,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as INSERTED_BY,tblitem.itemid as ITEM_ID FROM mppos_db.tblitem INNER JOIN mppos_db.tbluseraccount ON tbluseraccount.userid = tblitem.addedby where tblitem.category like '" & frmItem.txtsearch.Text & "%' order by tblitem.itemid"

            ElseIf frmItem.cmbfilter.SelectedIndex = 3 Then
                ' query = "Select barcode as PRODUCT_CODE,itemname as DESCRIPTION,category as CATEGORY,model as MODEL,size as SIZE,color as COLOR,unit as UNIT,unitcost as UNIT_COST,saleprice as UNIT_SALEPRICE,quantity as QUANTITY,criticallimit as CRITICAL_LIMIT,dateinserted as DATE_INSERTED,datemodified as LAST_MODIFIED,addedby as ADDED_BY,itemid as ITEM_ID from mppos_db.tblitem where model like '" & frmItem.txtsearch.Text & "%' order by itemid"
                query = "Select tblitem.barcode as PRODUCT_CODE,tblitem.itemname as DESCRIPTION,tblitem.category as CATEGORY,tblitem.model as MODEL,tblitem.size as SIZE,tblitem.color as COLOR,tblitem.unit as UNIT,tblitem.unitcost as UNIT_COST,tblitem.saleprice as UNIT_SALEPRICE,tblitem.quantity as QUANTITY,tblitem.criticallimit as CRITICAL_LIMIT,tblitem.dateinserted as DATE_INSERTED,tblitem.datemodified as LAST_MODIFIED,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as INSERTED_BY,tblitem.itemid as ITEM_ID FROM mppos_db.tblitem INNER JOIN mppos_db.tbluseraccount ON tbluseraccount.userid = tblitem.addedby where tblitem.model like '" & frmItem.txtsearch.Text & "%' order by tblitem.itemid"

            End If
        Else
            ' query = "Select barcode as PRODUCT_CODE,itemname as DESCRIPTION,category as CATEGORY,model as MODEL,size as SIZE,color as COLOR,unit as UNIT,unitcost as UNIT_COST,saleprice as UNIT_SALEPRICE,quantity as QUANTITY,criticallimit as CRITICAL_LIMIT,dateinserted as DATE_INSERTED,datemodified as LAST_MODIFIED,addedby as ADDED_BY,itemid as ITEM_ID from mppos_db.tblitem"
            query = "Select tblitem.barcode as PRODUCT_CODE,tblitem.itemname as DESCRIPTION,tblitem.category as CATEGORY,tblitem.model as MODEL,tblitem.size as SIZE,tblitem.color as COLOR,tblitem.unit as UNIT,tblitem.unitcost as UNIT_COST,tblitem.saleprice as UNIT_SALEPRICE,tblitem.quantity as QUANTITY,tblitem.criticallimit as CRITICAL_LIMIT,tblitem.dateinserted as DATE_INSERTED,tblitem.datemodified as LAST_MODIFIED,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as INSERTED_BY,tblitem.itemid as ITEM_ID FROM mppos_db.tblitem INNER JOIN mppos_db.tbluseraccount ON tbluseraccount.userid = tblitem.addedby order by tblitem.itemid"

        End If
        Try
            MysqlConn.Open()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            frmItem.dtgItemList.DataSource = bSource
            SDA.Update(dbDataset)
            MysqlConn.Close()
            frmItem.lblCountdtg.Text = frmItem.dtgItemList.Rows.Count & " Records"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Sub loadData()
        'Try
        Dim GridRow As DataGridViewRow = frmItem.dtgItemList.CurrentRow
        frmItemDetails.txtBarcode.Text = CStr(GridRow.Cells.Item("PRODUCT_CODE").Value)
        frmItemDetails.txtDecription.Text = CStr(GridRow.Cells.Item("DESCRIPTION").Value)
        frmItemDetails.cmbCategory.Text = CStr(GridRow.Cells.Item("CATEGORY").Value)
        frmItemDetails.txtModel.Text = CStr(GridRow.Cells.Item("MODEL").Value)
        frmItemDetails.txtSize.Text = CStr(GridRow.Cells.Item("SIZE").Value)
        frmItemDetails.txtColor.Text = CStr(GridRow.Cells.Item("COLOR").Value)
        frmItemDetails.cmbunit.Text = CStr(GridRow.Cells.Item("UNIT").Value)
        frmItemDetails.txtCostprice.Text = CDbl(GridRow.Cells.Item("UNIT_COST").Value)
        frmItemDetails.txtSelPrice.Text = CDbl(GridRow.Cells.Item("UNIT_SALEPRICE").Value)
        frmItemDetails.txtCritcalLmit.Text = CDbl(GridRow.Cells.Item("CRITICAL_LIMIT").Value)
        frmItemDetails.txtitemId.Text = CStr(GridRow.Cells.Item("ITEM_ID").Value)
        GlobalitemID = CStr(GridRow.Cells.Item("ITEM_ID").Value)

        'Catch ex As Exception

        'End Try
    End Sub

    Sub SaveUpdateItem()
        runServer()
        Try
            MysqlConn.Open()
            If saving Then
                If MessageBox.Show("Are you sure you want to add this new Item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    query = "insert into mppos_db.tblitem (itemid,barcode,itemname,category,model,size,color,unit,unitcost,saleprice,quantity,criticallimit,dateinserted,datemodified,addedby) values ('" & Trim(frmItemDetails.txtitemId.Text) & "','" & Trim(frmItemDetails.txtBarcode.Text) & "','" & Trim(frmItemDetails.txtDecription.Text) & "','" & Trim(frmItemDetails.cmbCategory.Text) & "','" & Trim(frmItemDetails.txtModel.Text) & "','" & Trim(frmItemDetails.txtSize.Text) & "','" & Trim(frmItemDetails.txtColor.Text) & "','" & Trim(frmItemDetails.cmbunit.Text) & "','" & Trim(frmItemDetails.txtCostprice.Text) & "','" & Trim(frmItemDetails.txtSelPrice.Text) & "','" & "0" & "','" & Trim(frmItemDetails.txtCritcalLmit.Text) & "','" & Date.Now.ToShortDateString & "','" & " " & "','" & Globaluserid & "')"
                    COMMAND = New MySqlCommand(query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MsgBox("New Item has been successfully added!", MsgBoxStyle.Information)
                End If
            Else
                If MessageBox.Show("Are you sure you want to update this User Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    query = "update mppos_db.tblitem set barcode='" & Trim(frmItemDetails.txtBarcode.Text) & "',itemname='" & Trim(frmItemDetails.txtDecription.Text) & "',category='" & Trim(frmItemDetails.cmbCategory.Text) & "',model='" & Trim(frmItemDetails.txtModel.Text) & "',size='" & Trim(frmItemDetails.txtSize.Text) & "',color='" & Trim(frmItemDetails.txtColor.Text) & "',unit='" & Trim(frmItemDetails.cmbunit.Text) & "',unitcost='" & Trim(frmItemDetails.txtCostprice.Text) & "',saleprice='" & Trim(frmItemDetails.txtSelPrice.Text) & "',criticallimit='" & Trim(frmItemDetails.txtCritcalLmit.Text) & "',datemodified='" & Date.Now.ToShortDateString & "' where itemid='" & GlobalitemID & "'"
                    COMMAND = New MySqlCommand(query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MsgBox(" User Account has been successfully updated!", MsgBoxStyle.Information)
                End If
            End If
            MysqlConn.Close()
            itemlist()
            clearTxt("item")
            GlobalitemID = Nothing
            frmItemDetails.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try


    End Sub

    Sub deleteitem()
        runServer()
        Try


            MysqlConn.Open()

            If MessageBox.Show("Are you sure you want to delete this Item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                query = "delete from mppos_db.tblitem where itemid='" & GlobalitemID & "'"
                COMMAND = New MySqlCommand(query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MsgBox(" Item has been successfully deleted!", MsgBoxStyle.Information)
                MysqlConn.Close()
                itemlist()

            End If
            MysqlConn.Close()
            itemlist()
            clearTxt("item")
            GlobalitemID = Nothing
            frmItem.lblcountof.Text = "0"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Sub printItemreport()
        Dim officeexcel As New Microsoft.Office.Interop.Excel.Application 'creat office application
        officeexcel = CreateObject("Excel.Application")
        Dim workbook As Object = officeexcel.Workbooks.Add(ItemListTemplate)
        Dim num As Integer = 1
        Dim excelrow As Integer

        Dim i As Integer = 0
        For Each RW As DataGridViewRow In frmItem.dtgItemList.Rows

            With officeexcel
                .Range("B" & (7)).Value = ("List of Item").ToString
                .Range("B" & (8)).Value = ("Date of Report: " & Date.Now.ToShortDateString).ToString
                .Range("A" & (i + 13)).Value = (RW.Cells(14).Value).ToString
                .Range("B" & (i + 13)).Value = (RW.Cells(0).Value).ToString
                .Range("C" & (i + 13)).Value = (RW.Cells(1).Value).ToString
                .Range("D" & (i + 13)).Value = (RW.Cells(2).Value).ToString
                .Range("E" & (i + 13)).Value = (RW.Cells(3).Value).ToString
                .Range("F" & (i + 13)).Value = (RW.Cells(4).Value).ToString
                .Range("G" & (i + 13)).Value = (RW.Cells(5).Value).ToString
                .Range("H" & (i + 13)).Value = (RW.Cells(6).Value).ToString
                .Range("I" & (i + 13)).Value = (RW.Cells(7).Value).ToString
                .Range("J" & (i + 13)).Value = (RW.Cells(8).Value).ToString
                .Range("K" & (i + 13)).Value = (RW.Cells(9).Value).ToString

                excelrow = i
                Dim A, B, C, D, E, F, G, H, j As Excel.Range
                A = officeexcel.Range("A" & (i + 13), "B" & (i + 13))
                B = officeexcel.Range("B" & (i + 13), "C" & (i + 13))
                C = officeexcel.Range("C" & (i + 13), "D" & (i + 13))
                D = officeexcel.Range("D" & (i + 13), "E" & (i + 13))
                E = officeexcel.Range("E" & (i + 13), "F" & (i + 13))
                F = officeexcel.Range("F" & (i + 13), "G" & (i + 13))
                G = officeexcel.Range("G" & (i + 13), "H" & (i + 13))
                H = officeexcel.Range("I" & (i + 13), "J" & (i + 13))
                j = officeexcel.Range("K" & (i + 13), "K" & (i + 13))
                A.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                B.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                C.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                D.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                E.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                F.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                G.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                H.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                j.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)

            End With : i += 1

        Next
        With officeexcel
            .Range("A" & (excelrow + 15)).Value = ("No. of Items: " & frmItem.dtgItemList.Rows.Count).ToString
            '.Range("E" & (excelrow + 15)).Value = ("Total Cost: " & frmItem.lblCost.Text).ToString
            '.Range("F" & (excelrow + 15)).Value = ("Total Selling Price: " & frmItem.lblTotalPrice.Text).ToString
            '.Range("G" & (excelrow + 15)).Value = ("Total QTY: " & frmItem.lbltotQty.Text).ToString
            '.Range("H" & (excelrow + 15)).Value = ("Total Value: " & frmItem.lblTotalValue.Text).ToString

            .Range("A" & (excelrow + 17)).Value = ("Prepared By: " & frmAdminMain.lblUser.Text).ToString
        End With
        officeexcel.Visible = True
        officeexcel = Nothing
        workbook = Nothing




    End Sub
End Class
