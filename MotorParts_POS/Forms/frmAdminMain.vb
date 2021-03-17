Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Public Class frmAdminMain

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub



    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem.Click
        frmItem.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        frmUser.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub StocksCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksCategoryToolStripMenuItem.Click

    End Sub

    Private Sub CashSalesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CashSalesToolStripMenuItem2.Click
        frmCashier.ShowDialog()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '   frmCategory.ShowDialog()
    End Sub

    Private Sub StockListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockListToolStripMenuItem.Click
        frmStockList.ShowDialog()
    End Sub

    Private Sub AdjustStockQuantityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdjustStockQuantityToolStripMenuItem.Click
        frmStockAdjustQty.ShowDialog()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tsslTime.Text = Format(Date.Now, "General Date")

    End Sub

    Private Sub CashSalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CashSalesToolStripMenuItem1.Click
        frmSalesMonitoring.ShowDialog()
    End Sub

    Private Sub TransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionsToolStripMenuItem.Click
        frmInventoryItem.ShowDialog()
    End Sub

    Private Sub ToolStripDropDownButton2_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton2.Click
        If MessageBox.Show("Are you sure you want to exit?", "Log-out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
            frmLogin.txtusername.Focus()

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub StockItemToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalesReadingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReadingToolStripMenuItem.Click
        frmTransactionsMonitoring.ShowDialog()
    End Sub

    Private Sub frmAdminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = userinfo

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        BarcodeGenerator()
    End Sub
    Dim lastCode As Integer
    Dim seriesCode As String
    'Function verifyBarcodeDBRecord(ByVal table As String) As Boolean
    '    Dim query, Attribute As String
    '    Dim bookCode As Integer

    '    If table = "tblBorrowers" Then
    '        query = "Select bor_barcodeNo from tblBorrowers order by bor_barcodeNo ASC"
    '        Attribute = "bor_barcodeNo"
    '    Else
    '        query = "Select book_barcodeNo from tblBook order by book_barcodeNo ASC"
    '        Attribute = "book_barcodeNo"
    '    End If

    '    conn.Open()
    '    command = conn.CreateCommand
    '    command.CommandText = query
    '    adapter.SelectCommand = command
    '    datareader = command.ExecuteReader
    '    While datareader.Read
    '        lastCode = CInt(datareader(Attribute))
    '    End While
    '    lastCode += 1
    '    If lastCode <> Nothing Then
    '        verifyBarcodeDBRecord = True
    '    End If
    '    conn.Close()
    'End Function
    Sub BarcodeGenerator()


        'If verifyBarcodeDBRecord(id) = True Then

        'Else
        '    If id = "tblBorrowers" Then
        '        lastCode = 100001
        '    Else
        lastCode = 200001
        '    End If

        'End If
        ' MsgBox(lastCode)

        Dim officeexcel As New Microsoft.Office.Interop.Excel.Application 'creat office application
        officeexcel = CreateObject("Excel.Application")

        Dim workbook As Object = officeexcel.Workbooks.Add(ItemReportTemplate)
        With officeexcel
            .Range("A" & (2)).Value = (lastCode).ToString
        End With

        officeexcel.Visible = True
        officeexcel = Nothing
        workbook = Nothing
    End Sub

    Private Sub ToolStripDropDownButton3_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton3.Click

    End Sub

    Private Sub CategoryToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        frmCategory.ShowDialog()
    End Sub
End Class