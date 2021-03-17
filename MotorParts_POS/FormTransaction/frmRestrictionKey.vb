Imports MySql.Data.MySqlClient

Public Class frmRestrictionKey

    Private Sub txtSecKey_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSecKey.KeyDown
        If e.KeyCode = Keys.Enter Then : verifyTarget()
        ElseIf e.KeyCode = Keys.Escape Then : triggerSecurityPass = "" : Me.Close()
        End If
    End Sub
    Function VerifyPassword() As Boolean

        runServer()
        MysqlConn.Open()
        query = "select * from mppos_db.tbluseraccount where password ='" & txtSecKey.Text & "'"
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        If READER.Read Then
            VerifyPassword = True
        Else
            VerifyPassword = False
        End If
        READER.Close()
        MysqlConn.Close()


    End Function
    Sub verifyTarget()

        If txtSecKey.Text = "" Then : MsgBox("Please input Security Key", MsgBoxStyle.Critical)
        ElseIf VerifyPassword() = True Then : txtSecKey.Clear() : Me.Hide()
            If triggerSecurityPass = "Discount" Then : frmDiscount.ShowDialog()
            ElseIf triggerSecurityPass = "CanceTransact" Then
                frmConfirmAbort.ShowDialog()
            ElseIf triggerSecurityPass = "RemoveItem" Then : frmDeleteItem.ShowDialog()
                'ElseIf triggerSecurityPass = "QuickEntry" Then : frmIQuickEntry.ShowDialog()
            End If
            triggerSecurityPass = Nothing
        Else : MsgBox("Invalid Key", MsgBoxStyle.Exclamation) : txtSecKey.Clear()
        End If
    End Sub

    Private Sub txtSecKey_TextChanged(sender As Object, e As EventArgs) Handles txtSecKey.TextChanged

    End Sub

    Private Sub frmRestrictionKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class