Public Class frmTransactProcess

    Private Sub Button1_Click(sender As Object, e As EventArgs)
       
        Me.Visible = False

    End Sub

    Private Sub frmTransactProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
      
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.ForeColor = Color.Blue
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = ProgressBar1.Maximum Then


            frmCashier.GenerateReceipt()
            rcptComputation()
            PrintHeader()
            ItemsToBePrinted()
            printFooter()
            Dim printControl = New Printing.StandardPrintController
            frmCashier.PrintDocument1.PrintController = printControl
            Try : frmCashier.PrintDocument1.Print()
            Catch ex As Exception : MsgBox(ex.Message)
            End Try
            myTransaction.saveTransaction()
            Me.Dispose()
        End If

    End Sub
End Class