Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class TransactionMonitoring
    Public Sub generateSales(ByVal Param As String)
        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim datefrom As String = Convert.ToDateTime(frmTransactionsMonitoring.dtpFrom.Text)
        Dim dateto As String = Convert.ToDateTime(frmTransactionsMonitoring.dtpTo.Text)
        If Param = "LOADBYDATE" Then
            query = "SELECT  tbltransaction.transid as TRANSACTION_ID,tbltransaction.orno as OR_NUMBER,tbltransaction.totalamount as AMOUNT_TENDER,tbltransaction.totaldiscount as DISCOUNT,tblofficialreceipt.vatsales as VAT_SALES,tblofficialreceipt.vatamount as VAT,tbltransaction.cashpay as CASH,tbltransaction.cashchange as CHANGEPAY,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as CASHIER,tbltransaction.dateinserted as TRANSDATE FROM ((mppos_db.tbltransaction) INNER JOIN mppos_db.tblofficialreceipt ON tblofficialreceipt.transid = tblTransaction.transid)INNER JOIN mppos_db.tbluseraccount ON tblTransaction.userid = tbluseraccount.userid WHERE ((tbltransaction.dateinserted Between '" & frmTransactionsMonitoring.dtpFrom.Text & "' and '" & frmTransactionsMonitoring.dtpTo.Text & "' ))   order by tbltransaction.dateinserted ASC "


        ElseIf Param = "LOADALL" Then
            query = "SELECT  tbltransaction.transid as TRANSACTION_ID,tbltransaction.orno as OR_NUMBER,tbltransaction.totalamount as AMOUNT_TENDER,tbltransaction.totaldiscount as DISCOUNT,tblofficialreceipt.vatsales as VAT_SALES,tblofficialreceipt.vatamount as VAT,tbltransaction.cashpay as CASH,tbltransaction.cashchange as CHANGEPAY,CONCAT(tbluseraccount.fname,' ',tbluseraccount.lname) as CASHIER,tbltransaction.dateinserted as TRANSDATE FROM ((mppos_db.tbltransaction) INNER JOIN mppos_db.tblofficialreceipt ON tblofficialreceipt.transid = tblTransaction.transid)INNER JOIN mppos_db.tbluseraccount ON tblTransaction.userid = tbluseraccount.userid "

        End If

        Try
            MysqlConn.Open()
            frmTransactionsMonitoring.dtgListReport.Rows.Clear()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset

            READER = COMMAND.ExecuteReader
            If dbDataset.Rows.Count > 0 Then
                frmTransactionsMonitoring.dtgListReport.ColumnCount = 10
                frmTransactionsMonitoring.dtgListReport.Columns(0).HeaderText = "NO." : frmTransactionsMonitoring.dtgListReport.Columns(0).Width = 50 : frmTransactionsMonitoring.dtgListReport.Columns(0).Name = "TRANSACTION_ID"
                frmTransactionsMonitoring.dtgListReport.Columns(1).HeaderText = "OR_NUMBER" : frmTransactionsMonitoring.dtgListReport.Columns(1).Width = 160 : frmTransactionsMonitoring.dtgListReport.Columns(1).Name = "OR_NUMBER"
                frmTransactionsMonitoring.dtgListReport.Columns(2).HeaderText = "AMOUNT_TENDER" : frmTransactionsMonitoring.dtgListReport.Columns(2).Width = 120 : frmTransactionsMonitoring.dtgListReport.Columns(2).Name = "AMOUNT_TENDER"
                frmTransactionsMonitoring.dtgListReport.Columns(3).HeaderText = "DISCOUNT" : frmTransactionsMonitoring.dtgListReport.Columns(3).Width = 100 : frmTransactionsMonitoring.dtgListReport.Columns(3).Name = "DISCOUNT"
                frmTransactionsMonitoring.dtgListReport.Columns(4).HeaderText = "VAT_SALES" : frmTransactionsMonitoring.dtgListReport.Columns(4).Width = 100 : frmTransactionsMonitoring.dtgListReport.Columns(4).Name = "VAT_SALES"
                frmTransactionsMonitoring.dtgListReport.Columns(5).HeaderText = "VAT" : frmTransactionsMonitoring.dtgListReport.Columns(5).Width = 100 : frmTransactionsMonitoring.dtgListReport.Columns(5).Name = "VAT"
                frmTransactionsMonitoring.dtgListReport.Columns(6).HeaderText = "CASH" : frmTransactionsMonitoring.dtgListReport.Columns(6).Width = 100 : frmTransactionsMonitoring.dtgListReport.Columns(6).Name = "CASH"
                frmTransactionsMonitoring.dtgListReport.Columns(7).HeaderText = "CHANGE" : frmTransactionsMonitoring.dtgListReport.Columns(7).Width = 100 : frmTransactionsMonitoring.dtgListReport.Columns(7).Name = "CHANGEPAY"
                frmTransactionsMonitoring.dtgListReport.Columns(8).HeaderText = "DATE" : frmTransactionsMonitoring.dtgListReport.Columns(8).Width = 100 : frmTransactionsMonitoring.dtgListReport.Columns(8).Name = "TRANSDATE"
                frmTransactionsMonitoring.dtgListReport.Columns(9).HeaderText = "CASHIER" : frmTransactionsMonitoring.dtgListReport.Columns(9).Width = 200 : frmTransactionsMonitoring.dtgListReport.Columns(9).Name = "CASHIER"


                For Each row As DataRow In dbDataset.Rows
                    Dim rowData As String() = New String() {row("TRANSACTION_ID").ToString, row("OR_NUMBER").ToString, row("AMOUNT_TENDER").ToString, row("DISCOUNT").ToString, row("VAT_SALES").ToString, row("VAT").ToString, row("CASH").ToString, row("CHANGEPAY").ToString, row("TRANSDATE").ToString, row("CASHIER").ToString}
                    frmTransactionsMonitoring.dtgListReport.Rows.Add(rowData)
                    ' i += 1
                Next
            End If

            READER.Close()
            MysqlConn.Close()
            Dim TotDiscount As Double = 0
            Dim TotSale As Double = 0
            If frmTransactionsMonitoring.dtgListReport.Rows.Count <> 0 Then

                Dim i As Integer = 0
                For Each RW As DataGridViewRow In frmTransactionsMonitoring.dtgListReport.Rows
                    TotDiscount += CDbl(RW.Cells(3).Value)
                    TotSale += CDbl(RW.Cells(2).Value)
                    i += 1
                Next
            End If
            frmTransactionsMonitoring.lblTransactionCount.Text = frmTransactionsMonitoring.dtgListReport.Rows.Count
            frmTransactionsMonitoring.lblTotalDisc.Text = Format(TotDiscount, "Standard")
            frmTransactionsMonitoring.lblTotalSale.Text = Format(TotSale, "Standard")

            frmTransactionsMonitoring.lblcountof.Text = ""
            frmTransactionsMonitoring.lblCountdtg.Text = frmTransactionsMonitoring.dtgListReport.Rows.Count & " Records"
            frmTransactionsMonitoring.dtgListReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub

    Sub printTransactionreport()
        Dim officeexcel As New Microsoft.Office.Interop.Excel.Application 'creat office application
        officeexcel = CreateObject("Excel.Application")
        Dim workbook As Object = officeexcel.Workbooks.Add(TransactionReportTemplate)
        Dim num As Integer = 1
        Dim excelrow As Integer

        Dim i As Integer = 0
        For Each RW As DataGridViewRow In frmTransactionsMonitoring.dtgListReport.Rows

            With officeexcel
                .Range("B" & (7)).Value = ("Transaction Report").ToString
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
                .Range("J" & (i + 13)).Value = (RW.Cells(9).Value).ToString
                excelrow = i
                Dim A, B, C, D, E, F, G, H, J As Excel.Range
                A = officeexcel.Range("A" & (i + 13), "B" & (i + 13))
                B = officeexcel.Range("B" & (i + 13), "C" & (i + 13))
                C = officeexcel.Range("C" & (i + 13), "D" & (i + 13))
                D = officeexcel.Range("D" & (i + 13), "E" & (i + 13))
                E = officeexcel.Range("E" & (i + 13), "F" & (i + 13))
                F = officeexcel.Range("F" & (i + 13), "G" & (i + 13))
                G = officeexcel.Range("G" & (i + 13), "H" & (i + 13))
                H = officeexcel.Range("I" & (i + 13), "J" & (i + 13))
                J = officeexcel.Range("J" & (i + 13), "J" & (i + 13))
                A.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                B.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                C.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                D.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                E.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                F.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                G.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                H.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                J.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)

            End With : i += 1
        Next
        With officeexcel
            .Range("A" & (excelrow + 15)).Value = ("No. of Items: " & frmTransactionsMonitoring.dtgListReport.Rows.Count).ToString
            .Range("C" & (excelrow + 15)).Value = ("Total Sale: " & frmTransactionsMonitoring.lblTotalSale.Text).ToString
           
            .Range("A" & (excelrow + 17)).Value = ("Prepared By: " & frmAdminMain.lblUser.Text).ToString
        End With
        officeexcel.Visible = True
        officeexcel = Nothing
        workbook = Nothing
    End Sub

End Class
