Imports MySql.Data.MySqlClient
Public Class Login

    Sub verifyUser()

        query = "Select * from mppos_db.tbluseraccount where username= '" & frmLogin.txtusername.Text & "' and password= '" & frmLogin.txtpassword.Text & "'"
        runServer()
        MysqlConn.Open()
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read()
            usertype = READER("usertype").ToString
            Globaluserid = READER("userid").ToString
            userinfo = READER("fname").ToString & " " & READER("lname").ToString

        End While
        READER.Close()
        MysqlConn.Close()
        If usertype <> "" Then

            If usertype = "ADMINISTRATOR" Then
                MsgBox("Access Granted")
                frmAdminMain.ShowDialog()
                '  frmLogin.Hide()
                frmLogin.txtpassword.Clear()
                frmLogin.txtusername.Clear()
            ElseIf usertype = "CASHIER" Then
                MsgBox("Access Granted")

                frmLogin.txtpassword.Clear()
                frmLogin.txtusername.Clear()
                frmCashier.ShowDialog()
                ' frmLogin.Hide()



            Else
                MsgBox("System Denied to allow this user to Access the System,Please Contact the System Administrator")

            End If
        Else
            MsgBox("Invalid Username/Password")
            frmLogin.txtpassword.Clear()
            frmLogin.txtusername.Clear()
            frmLogin.txtusername.Focus()

        End If

    End Sub

End Class
