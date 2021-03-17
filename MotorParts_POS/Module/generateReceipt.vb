Imports System.IO
Imports MySql.Data.MySqlClient

Module generateReceipt
    Public vat = 0.12, total, vatAmount, vatSales As Double
    Public Sub rcptComputation()
        total = CDbl(Val(frmCashier.txtAmountDue.Text))
        vatAmount = total * vat
        vatSales = total - vatAmount
    End Sub

    Public TextToPrint As String = ""
    Public Sub PrintHeader()
        TextToPrint = ""
        'send Business Name
        Dim StringToPrint As String = "Gonzaga Motor Parts and Accessories"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((38 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine
        'send address name
        StringToPrint = "Address"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine
        ' send phone number
        StringToPrint = "VAT REG TIN#: 999-999-9999"
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine
        'send website
        StringToPrint = "website.com"
        LineLen = StringToPrint.Length
        Dim spcLen4b As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4b & StringToPrint & Environment.NewLine
        TextToPrint &= "=======================================" & Environment.NewLine
        TextToPrint &= "OR#:     " & PadLeft(ORno, " ", 28) & Environment.NewLine
        TextToPrint &= "Date-Time:" & PadLeft(Format(Date.Now).ToString, " ", 27) & Environment.NewLine
        TextToPrint &= "CashierID:" & PadLeft(frmCashier.lblPosID.Text, " ", 27) & Environment.NewLine
        TextToPrint &= "Name:    " & PadLeft(frmCashier.lblFullname.Text, " ", 28) & Environment.NewLine
        TextToPrint &= "=======================================" & Environment.NewLine
        TextToPrint &= "------------OFFICIAL RECEIPT-----------" & Environment.NewLine

    End Sub

    Public prt_file As String
    Public Sub ItemsToBePrinted()
        TextToPrint &= "   Qty      " & "Description    " & "   Price   " & Environment.NewLine
        Dim StringToPrint As String
        Dim LineLen As Integer
        Dim q, d, p As String

        For Each RW As DataGridViewRow In frmCashier.dtgItemPurchase.Rows
            q = RW.Cells(0).Value.ToString
            d = RW.Cells(1).Value.ToString
            p = RW.Cells(2).Value.ToString
            StringToPrint = PadLeft(q, " ", 3) & "        " & PadLeft(d, " ", 10) & "        " & PadRight(p, " ", 6)
            TextToPrint &= " " & StringToPrint & Environment.NewLine
        Next
        TextToPrint &= "---------------------------------------" & Environment.NewLine
        TextToPrint &= frmCashier.lblitemCount.Text & " Item(s)" & Environment.NewLine
        TextToPrint &= "TOTAL DUE       " & PadLeft(frmCashier.txtAmountDue.Text, " ", 21) & Environment.NewLine
        TextToPrint &= "DISCOUNT AMNT   " & PadLeft(frmCashier.lblDisc.Text, " ", 21) & Environment.NewLine
        TextToPrint &= "CASH            " & PadLeft(frmCashier.lblCash.Text, " ", 21) & Environment.NewLine
        TextToPrint &= "CHANGE          " & PadLeft(frmCashier.lblChange.Text, " ", 21) & Environment.NewLine
        TextToPrint &= "" & Environment.NewLine
        TextToPrint &= "VATable Sales   " & PadLeft(vatSales, " ", 21) & Environment.NewLine
        TextToPrint &= "VAT-Exmpt Sales " & PadLeft("0.00", " ", 21) & Environment.NewLine
        TextToPrint &= "VAT Amount      " & PadLeft(vat, " ", 21) & Environment.NewLine
        TextToPrint &= "" & Environment.NewLine
        TextToPrint &= "---------------------------------------" & Environment.NewLine
        TextToPrint &= "=======================================" & Environment.NewLine

        TextToPrint &= "" & Environment.NewLine
        TextToPrint &= "" & Environment.NewLine
    End Sub


    Public Sub printFooter()
        Dim globalLengt As Integer = 0
        Dim StringToPrint As String = "This Serves as an OFFICIAL RECEIPT"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen5 & StringToPrint & Environment.NewLine
        StringToPrint = "THANK YOU FOR SHOPPING!!!"
        LineLen = StringToPrint.Length
        Dim spcLen6 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine
    End Sub
    Public Function PadLeft(ByVal cString As String, ByVal cCharacter As String, ByVal nLength As Integer) As String
        Dim len1, ctr As Integer
        If Len(Trim(cString)) > nLength Then
            cString = Mid(cString, 1, nLength)
        End If
        cString = Trim(cString) : len1 = Len(cString)
        For ctr = 1 To nLength - len1
            cString = cCharacter & cString
        Next
        PadLeft = cString
    End Function
    Public Function PadCenter(ByVal cString As String, ByVal nLen As Integer) As String
        PadCenter = Space((nLen - Len(cString)) / 2) + cString
    End Function

    Public Function PadRight(ByVal cString As String, ByVal cCharacter As String, ByVal nLength As Integer) As String
        Dim len1, ctr As Integer
        If Len(Trim(cString)) > nLength Then
            cString = Mid(cString, 1, nLength)
        End If
        cString = Trim(cString)
        len1 = Len(cString)
        If IsDBNull(len1) Then
            len1 = 0
        End If
        For ctr = 1 To nLength - len1
            cString = cString & cCharacter
        Next
        PadRight = cString

    End Function
    Sub duplicateReciept()
        Try
            Dim FileNum As Integer = FreeFile()
            Dim TempS As String = Nothing
            Dim TempL As String = Nothing
            FileOpen(FileNum, "RecieptPath.txt", OpenMode.Input)
            Do Until EOF(FileNum)
                TempL = LineInput(FileNum)
                TempS += TempL
            Loop
            FileClose(FileNum)
            path = TempS
            prt_file = path & ORno & ".txt"
            Dim fs As New FileStream(prt_file, FileMode.Create, FileAccess.Write)
            Dim s As New StreamWriter(fs)
            s.BaseStream.Seek(0, SeekOrigin.End) 'set the position of the stream
            s.WriteLine(TextToPrint)
            s.Close()
        Catch ex As Exception
        End Try

    End Sub
    Public Sub saveOR()
        runServer()
        MysqlConn.Open()
        query = "insert into mppos_db.tblofficialreceipt (orno,transid,vatsales,vatamount) values ('" & ORno & "','" & frmCashier.lblTransID.Text & "','" & vatSales & "','" & vat & "')"
        COMMAND = New MySqlCommand(query, MysqlConn)
        READER = COMMAND.ExecuteReader
        MysqlConn.Close()
    End Sub
End Module
