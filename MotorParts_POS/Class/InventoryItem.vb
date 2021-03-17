Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class InventoryItem

    Public Sub generateInventory()
        frmInventoryItem.lblcountof.Text = "0"
        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        If search Then

            query = "SELECT tblitem.itemid as ID,tblitem.barcode as PRODUCT_CODE,tblitem.itemname as ITEM_DESCRIPTION,tblitem.unit as UNIT,FORMAT(tblitem.unitcost,2) as UNIT_COST,FORMAT(tblitem.saleprice,2) as SALEPRICE,tblitem.quantity as ONHAND,Format(tblitem.quantity*tblitem.saleprice,2) as TOTAL_PRICE,tblitem.criticallimit as REORDER_LIMIT FROM mppos_db.tblitem where tblitem.itemname like '" & frmInventoryItem.txtsearch.Text & "%' order by tblitem.itemid ASC "

        Else
            query = "SELECT tblitem.itemid as ID,tblitem.barcode as PRODUCT_CODE,tblitem.itemname as ITEM_DESCRIPTION,tblitem.unit as UNIT,FORMAT(tblitem.unitcost,2) as UNIT_COST,FORMAT(tblitem.saleprice,2) as SALEPRICE,tblitem.quantity as ONHAND,Format(tblitem.quantity*tblitem.saleprice,2) as TOTAL_PRICE,tblitem.criticallimit as REORDER_LIMIT FROM mppos_db.tblitem order by tblitem.itemid ASC "


            'query = "SELECT tblitem.bor_id,tblitem.bor_fname,tblitem.bor_mname,tblitem.bor_lname,tblitem.bor_gender,tblitem.bor_bday,tblBorrowers.bor_age,tblBorrowers.bor_year,tblBorrowers.bor_section,tblBorrowers.bor_province,tblBorrowers.bor_city,tblBorrowers.bor_barangay,tblBorrowers.bor_cellphoneNo,tblBorrowers.bor_barcodeNo ,tblBorrowers.bor_dateinserted " & _
            '     "FROM ((mppos_db.tblitem) INNER JOIN mppos_db.tblstockin ON tblitem.itemid = tblstockin.itemid)INNER JOIN mppos_db.tblstockadjust ON tblstockadjust.itemid =tblstockin.itemid where tblstockadjust.action='Add' and tblBook.Category='NODATA' "


        End If

        Try
            MysqlConn.Open()
            frmInventoryItem.dtgListReport.Rows.Clear()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset

            READER = COMMAND.ExecuteReader
            If dbDataset.Rows.Count > 0 Then
                frmInventoryItem.dtgListReport.ColumnCount = 9
                frmInventoryItem.dtgListReport.Columns(0).HeaderText = "ID" : frmInventoryItem.dtgListReport.Columns(0).Width = 160 : frmInventoryItem.dtgListReport.Columns(0).Name = "ID"
                frmInventoryItem.dtgListReport.Columns(1).HeaderText = "PRODUCT_CODE" : frmInventoryItem.dtgListReport.Columns(1).Width = 160 : frmInventoryItem.dtgListReport.Columns(1).Name = "PRODUCT_CODE"
                frmInventoryItem.dtgListReport.Columns(2).HeaderText = "ITEM_DESCRIPTION" : frmInventoryItem.dtgListReport.Columns(2).Width = 400 : frmInventoryItem.dtgListReport.Columns(2).Name = "ITEM_DESCRIPTION"
                frmInventoryItem.dtgListReport.Columns(3).HeaderText = "UNIT" : frmInventoryItem.dtgListReport.Columns(3).Width = 100 : frmInventoryItem.dtgListReport.Columns(3).Name = "UNIT"
                frmInventoryItem.dtgListReport.Columns(4).HeaderText = "UNIT_COST" : frmInventoryItem.dtgListReport.Columns(4).Width = 120 : frmInventoryItem.dtgListReport.Columns(4).Name = "UNIT_COST"
                frmInventoryItem.dtgListReport.Columns(5).HeaderText = "SALEPRICE" : frmInventoryItem.dtgListReport.Columns(5).Width = 120 : frmInventoryItem.dtgListReport.Columns(5).Name = "SALEPRICE"
                frmInventoryItem.dtgListReport.Columns(6).HeaderText = "ONHAND_QTY" : frmInventoryItem.dtgListReport.Columns(6).Width = 100 : frmInventoryItem.dtgListReport.Columns(6).Name = "ONHAND"
                frmInventoryItem.dtgListReport.Columns(7).HeaderText = "INVENTORY VALUE" : frmInventoryItem.dtgListReport.Columns(7).Width = 120 : frmInventoryItem.dtgListReport.Columns(7).Name = "TOTAL_PRICE"
                frmInventoryItem.dtgListReport.Columns(8).HeaderText = "REORDER LIMIT" : frmInventoryItem.dtgListReport.Columns(8).Width = 0 : frmInventoryItem.dtgListReport.Columns(8).Name = "REORDER_LIMIT"


                For Each row As DataRow In dbDataset.Rows
                    Dim rowData As String() = New String() {row("ID").ToString, row("PRODUCT_CODE").ToString, row("ITEM_DESCRIPTION").ToString, row("UNIT").ToString, row("UNIT_COST").ToString, row("SALEPRICE").ToString, row("ONHAND").ToString, row("TOTAL_PRICE").ToString, row("REORDER_LIMIT").ToString}
                    frmInventoryItem.dtgListReport.Rows.Add(rowData)
                Next

                Dim TotCost As Double = 0
                Dim TotPrice As Double = 0
                Dim TotQty As Double = 0
                Dim TotValue As Double = 0
                If frmInventoryItem.dtgListReport.Rows.Count <> 0 Then

                    Dim a As Integer = 0
                    For Each RW As DataGridViewRow In frmInventoryItem.dtgListReport.Rows
                        TotCost += CDbl(RW.Cells(4).Value)
                        TotPrice += CDbl(RW.Cells(5).Value)
                        TotQty += CDbl(RW.Cells(6).Value)
                        TotValue += CDbl(RW.Cells(7).Value)
                        a += 1
                    Next
                End If
                frmInventoryItem.lblCost.Text = Format(TotCost, "Standard")
                frmInventoryItem.lblTotalPrice.Text = Format(TotPrice, "Standard")
                frmInventoryItem.lbltotQty.Text = TotQty
                frmInventoryItem.lblTotalValue.Text = Format(TotValue, "Standard")
            End If





            Dim i As Integer = 0
            Dim critcalItem As Integer = 0
            For Each RW As DataGridViewRow In frmInventoryItem.dtgListReport.Rows

                If CDbl(RW.Cells(6).Value) <= CDbl(RW.Cells(8).Value) Then
                    frmInventoryItem.dtgListReport.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
                    frmInventoryItem.dtgListReport.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    critcalItem += 1
                End If : i += 1
              

                'totdiscount += CDbl(RW.Cells(4).Value.ToString)
            Next
            If critcalItem = 0 Then
                frmInventoryItem.lblCriticalItemQty.BackColor = Color.White
                frmInventoryItem.lblCriticalItemQty.ForeColor = Color.Black
            Else
                frmInventoryItem.lblCriticalItemQty.BackColor = Color.IndianRed
                frmInventoryItem.lblCriticalItemQty.ForeColor = Color.White
            End If


            READER.Close()
            MysqlConn.Close()


            frmInventoryItem.lblCountdtg.Text = frmInventoryItem.dtgListReport.Rows.Count & " Records"
            frmInventoryItem.lblCriticalItemQty.Text = critcalItem & " item(s) found critical quantity"
            frmInventoryItem.dtgListReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub

    Sub printItemreport()
        Dim officeexcel As New Microsoft.Office.Interop.Excel.Application 'creat office application
        officeexcel = CreateObject("Excel.Application")
        Dim workbook As Object = officeexcel.Workbooks.Add(ItemReportTemplate)
        Dim num As Integer = 1
        Dim excelrow As Integer

        Dim i As Integer = 0
        For Each RW As DataGridViewRow In frmInventoryItem.dtgListReport.Rows

            With officeexcel
                .Range("B" & (7)).Value = ("Item Inventory").ToString
                .Range("B" & (8)).Value = (Date.Now.ToShortDateString).ToString

                .Range("A" & (i + 13)).Value = (RW.Cells(0).Value).ToString
                .Range("B" & (i + 13)).Value = (RW.Cells(1).Value).ToString
                .Range("C" & (i + 13)).Value = (RW.Cells(2).Value).ToString
                .Range("D" & (i + 13)).Value = (RW.Cells(3).Value).ToString
                .Range("E" & (i + 13)).Value = (RW.Cells(4).Value).ToString
                .Range("F" & (i + 13)).Value = (RW.Cells(5).Value).ToString
                .Range("G" & (i + 13)).Value = (RW.Cells(6).Value).ToString
                .Range("H" & (i + 13)).Value = (RW.Cells(7).Value).ToString
                excelrow = i
                Dim A, B, C, D, E, F, G As Excel.Range
                A = officeexcel.Range("A" & (i + 13), "B" & (i + 13))
                B = officeexcel.Range("B" & (i + 13), "C" & (i + 13))
                C = officeexcel.Range("C" & (i + 13), "D" & (i + 13))
                D = officeexcel.Range("D" & (i + 13), "E" & (i + 13))
                E = officeexcel.Range("E" & (i + 13), "F" & (i + 13))
                F = officeexcel.Range("F" & (i + 13), "G" & (i + 13))
                G = officeexcel.Range("G" & (i + 13), "H" & (i + 13))
                A.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                B.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                C.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                D.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                E.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                F.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                G.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)

            End With : i += 1

        Next
        With officeexcel
            .Range("A" & (excelrow + 15)).Value = ("No. of Items: " & frmInventoryItem.dtgListReport.Rows.Count).ToString
            .Range("E" & (excelrow + 15)).Value = ("Total Cost: " & frmInventoryItem.lblCost.Text).ToString
            .Range("F" & (excelrow + 15)).Value = ("Total Selling Price: " & frmInventoryItem.lblTotalPrice.Text).ToString
            .Range("G" & (excelrow + 15)).Value = ("Total QTY: " & frmInventoryItem.lbltotQty.Text).ToString
            .Range("H" & (excelrow + 15)).Value = ("Total Value: " & frmInventoryItem.lblTotalValue.Text).ToString

            .Range("A" & (excelrow + 17)).Value = ("Prepared By: " & frmAdminMain.lblUser.Text).ToString
        End With
        officeexcel.Visible = True
        officeexcel = Nothing
        workbook = Nothing




    End Sub


End Class
