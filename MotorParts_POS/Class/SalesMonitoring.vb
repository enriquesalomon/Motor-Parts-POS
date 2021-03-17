Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class SalesMonitoring

    Public Sub generateSales(ByVal Param As String)
        '  Dim i As Integer = 0
        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim datefrom As String = Convert.ToDateTime(frmSalesMonitoring.dtpFrom.Text)
        Dim dateto As String = Convert.ToDateTime(frmSalesMonitoring.dtpTo.Text)
        If Param = "LoadByDate" Then
            query = "SELECT tblsolditem.itemid as ID,tblsolditem.barcode as PRODUCT_CODE,tblitem.itemname as ITEM_DESCRIPTION,tblsolditem.quantity as QTY,tblsolditem.saleprice as SALEPRICE,Format(tblsolditem.quantity*tblsolditem.saleprice,2) as TOTAL_AMOUNT,Format(tblsolditem.quantity*tblsolditem.saleprice*tblsolditem.discount,2) as DISCOUNT,Format(tblsolditem.quantity*tblsolditem.saleprice,2) -  Format(tblsolditem.quantity*tblsolditem.saleprice,2)*  tblsolditem.discount as TOTAL_SALE,tblsolditem.transdate as DATE_SOLD FROM mppos_db.tblsolditem INNER JOIN mppos_db.tblitem ON tblsolditem.itemid = tblitem.itemid WHERE ((tblsolditem.transdate Between '" & frmSalesMonitoring.dtpFrom.Text & "' and '" & frmSalesMonitoring.dtpTo.Text & "' ))   order by tblsolditem.transdate ASC "

        ElseIf Param = "LOADALL" Then
            query = "SELECT tblsolditem.itemid as ID,tblsolditem.barcode as PRODUCT_CODE,tblitem.itemname as ITEM_DESCRIPTION,tblsolditem.quantity as QTY,tblsolditem.saleprice as SALEPRICE,Format(tblsolditem.quantity*tblsolditem.saleprice,2) as TOTAL_AMOUNT,Format(tblsolditem.quantity*tblsolditem.saleprice*tblsolditem.discount,2) as DISCOUNT,(tblsolditem.quantity*tblsolditem.saleprice) -  ((tblsolditem.quantity*tblsolditem.saleprice)*  tblsolditem.discount) as TOTAL_SALE,tblsolditem.transdate as DATE_SOLD FROM mppos_db.tblsolditem INNER JOIN mppos_db.tblitem ON tblsolditem.itemid = tblitem.itemid order by tblsolditem.transdate ASC "

        End If

        Try
            MysqlConn.Open()
            frmSalesMonitoring.dtgListReport.Rows.Clear()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset

            READER = COMMAND.ExecuteReader
            If dbDataset.Rows.Count > 0 Then
                frmSalesMonitoring.dtgListReport.ColumnCount = 9
                frmSalesMonitoring.dtgListReport.Columns(0).HeaderText = "ID" : frmSalesMonitoring.dtgListReport.Columns(0).Width = 160 : frmSalesMonitoring.dtgListReport.Columns(0).Name = "ID"
                frmSalesMonitoring.dtgListReport.Columns(1).HeaderText = "PRODUCT_CODE" : frmSalesMonitoring.dtgListReport.Columns(1).Width = 160 : frmSalesMonitoring.dtgListReport.Columns(1).Name = "PRODUCT_CODE"
                frmSalesMonitoring.dtgListReport.Columns(2).HeaderText = "ITEM_DESCRIPTION" : frmSalesMonitoring.dtgListReport.Columns(2).Width = 400 : frmSalesMonitoring.dtgListReport.Columns(2).Name = "ITEM_DESCRIPTION"
                frmSalesMonitoring.dtgListReport.Columns(3).HeaderText = "QTY" : frmSalesMonitoring.dtgListReport.Columns(3).Width = 100 : frmSalesMonitoring.dtgListReport.Columns(3).Name = "QTY"
                frmSalesMonitoring.dtgListReport.Columns(4).HeaderText = "SALEPRICE" : frmSalesMonitoring.dtgListReport.Columns(4).Width = 100 : frmSalesMonitoring.dtgListReport.Columns(4).Name = "SALEPRICE"
                frmSalesMonitoring.dtgListReport.Columns(5).HeaderText = "TOTAL_AMOUNT" : frmSalesMonitoring.dtgListReport.Columns(5).Width = 100 : frmSalesMonitoring.dtgListReport.Columns(5).Name = "TOTAL_AMOUNT"
                frmSalesMonitoring.dtgListReport.Columns(6).HeaderText = "DISCOUNT" : frmSalesMonitoring.dtgListReport.Columns(6).Width = 100 : frmSalesMonitoring.dtgListReport.Columns(6).Name = "DISCOUNT"
                frmSalesMonitoring.dtgListReport.Columns(7).HeaderText = "TOTAL_SALE" : frmSalesMonitoring.dtgListReport.Columns(7).Width = 100 : frmSalesMonitoring.dtgListReport.Columns(7).Name = "TOTAL_SALE"
                frmSalesMonitoring.dtgListReport.Columns(8).HeaderText = "DATE_SOLD" : frmSalesMonitoring.dtgListReport.Columns(8).Width = 100 : frmSalesMonitoring.dtgListReport.Columns(8).Name = "DATE_SOLD"


                For Each row As DataRow In dbDataset.Rows
                    Dim rowData As String() = New String() {row("ID").ToString, row("PRODUCT_CODE").ToString, row("ITEM_DESCRIPTION").ToString, row("QTY").ToString, row("SALEPRICE").ToString, row("TOTAL_AMOUNT").ToString, row("DISCOUNT").ToString, row("TOTAL_SALE").ToString, row("DATE_SOLD").ToString}
                    frmSalesMonitoring.dtgListReport.Rows.Add(rowData)
                    ' i += 1
                Next
            End If

            READER.Close()
            MysqlConn.Close()
            Dim qty As Integer = 0
            Dim salePrice As Double = 0
            Dim TotAmount As Double = 0
            Dim TotDiscount As Double = 0
            Dim TotSale As Double = 0
            If frmSalesMonitoring.dtgListReport.Rows.Count <> 0 Then

                Dim i As Integer = 0
                For Each RW As DataGridViewRow In frmSalesMonitoring.dtgListReport.Rows
                    qty += CDbl(RW.Cells(3).Value)
                    salePrice += CDbl(RW.Cells(4).Value)
                    TotAmount += CDbl(RW.Cells(5).Value)
                    TotDiscount += CDbl(RW.Cells(6).Value)
                    TotSale += CDbl(RW.Cells(7).Value)
                    i += 1
                Next
            End If
            frmSalesMonitoring.lblItemCount.Text = qty
            frmSalesMonitoring.lblTotalPrice.Text = Format(salePrice, "Standard")
            frmSalesMonitoring.lblTotalAMount.Text = Format(TotAmount, "Standard")
            frmSalesMonitoring.lblTotalDisc.Text = Format(TotDiscount, "Standard")
            frmSalesMonitoring.lblTotalSale.Text = Format(TotSale, "Standard")
            frmSalesMonitoring.lblcountof.Text = ""
            frmSalesMonitoring.lblCountdtg.Text = frmSalesMonitoring.dtgListReport.Rows.Count & " Records"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Sub printSalesreport()
        Dim officeexcel As New Microsoft.Office.Interop.Excel.Application 'creat office application
        officeexcel = CreateObject("Excel.Application")
        Dim workbook As Object = officeexcel.Workbooks.Add(SalesReportTemplate)
        Dim num As Integer = 1
        Dim excelrow As Integer

        Dim i As Integer = 0
        For Each RW As DataGridViewRow In frmSalesMonitoring.dtgListReport.Rows

            With officeexcel
                .Range("B" & (7)).Value = ("Sales Reading").ToString
                .Range("B" & (8)).Value = (Date.Now.ToShortDateString).ToString

                .Range("A" & (i + 13)).Value = (RW.Cells(0).Value).ToString
                .Range("B" & (i + 13)).Value = (RW.Cells(1).Value).ToString
                .Range("C" & (i + 13)).Value = (RW.Cells(2).Value).ToString
                .Range("D" & (i + 13)).Value = (RW.Cells(3).Value).ToString
                .Range("E" & (i + 13)).Value = (RW.Cells(4).Value).ToString
                .Range("F" & (i + 13)).Value = (RW.Cells(5).Value).ToString
                .Range("G" & (i + 13)).Value = (RW.Cells(6).Value).ToString
                .Range("H" & (i + 13)).Value = (RW.Cells(7).Value).ToString
                .Range("I" & (i + 13)).Value = (RW.Cells(8).Value).ToString
                excelrow = i
                Dim A, B, C, D, E, F, G, H As Excel.Range
                A = officeexcel.Range("A" & (i + 13), "B" & (i + 13))
                B = officeexcel.Range("B" & (i + 13), "C" & (i + 13))
                C = officeexcel.Range("C" & (i + 13), "D" & (i + 13))
                D = officeexcel.Range("D" & (i + 13), "E" & (i + 13))
                E = officeexcel.Range("E" & (i + 13), "F" & (i + 13))
                F = officeexcel.Range("F" & (i + 13), "G" & (i + 13))
                G = officeexcel.Range("G" & (i + 13), "H" & (i + 13))
                H = officeexcel.Range("I" & (i + 13), "I" & (i + 13))
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
            .Range("A" & (excelrow + 15)).Value = ("No. of Items: " & frmSalesMonitoring.dtgListReport.Rows.Count).ToString
            .Range("D" & (excelrow + 15)).Value = ("Total QTY: " & frmSalesMonitoring.lblItemCount.Text).ToString
            .Range("E" & (excelrow + 15)).Value = ("Total Price: " & frmSalesMonitoring.lblTotalPrice.Text).ToString
            .Range("F" & (excelrow + 15)).Value = ("Total Amount: " & frmSalesMonitoring.lblTotalAMount.Text).ToString
            .Range("G" & (excelrow + 15)).Value = ("Total Discount: " & frmSalesMonitoring.lblTotalDisc.Text).ToString
            .Range("H" & (excelrow + 15)).Value = ("Total Sale: " & frmSalesMonitoring.lblTotalSale.Text).ToString

            .Range("A" & (excelrow + 17)).Value = ("Prepared By: " & frmAdminMain.lblUser.Text).ToString
        End With
        officeexcel.Visible = True
        officeexcel = Nothing
        workbook = Nothing
    End Sub


End Class
