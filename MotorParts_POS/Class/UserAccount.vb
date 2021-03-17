Imports MySql.Data.MySqlClient
Public Class UserAccount

    Sub userslist()
        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        If search Then
            If frmUser.cmbFiltr.Text = "Firstname" Then
                query = "Select userid as User_ID,fname as Firstname,mname as Middlename,lname as Lastname, usertype as User_Type,username as Username, password as Password, dateinserted as Date_Inserted from mppos_db.tbluseraccount where fname like '" & frmUser.txtsearch.Text & "%' order by userid"
            ElseIf frmUser.cmbFiltr.Text = "Lastname" Then
                query = "Select userid as User_ID,fname as Firstname,mname as Middlename,lname as Lastname, usertype as User_Type,username as Username, password as Password, dateinserted as Date_Inserted from mppos_db.tbluseraccount where lname like '" & frmUser.txtsearch.Text & "%' order by userid"
            Else
                query = "Select userid as User_ID,fname as Firstname,mname as Middlename,lname as Lastname, usertype as User_Type,username as Username, password as Password, dateinserted as Date_Inserted from mppos_db.tbluseraccount"
            End If
        Else
            query = "Select userid as User_ID,fname as Firstname,mname as Middlename,lname as Lastname, usertype as User_Type,username as Username, password as Password, dateinserted as Date_Inserted from mppos_db.tbluseraccount"
        End If
        Try
            MysqlConn.Open()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            frmUser.dtgUserlist.DataSource = bSource
            SDA.Update(dbDataset)
            MysqlConn.Close()
            frmUser.lblUserCountdtg.Text = frmUser.dtgUserlist.Rows.Count & " Records"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Sub loadData()
        Try
            Dim GridRow As DataGridViewRow = frmUser.dtgUserlist.CurrentRow
            frmUser.txtUserid.Text = CStr(GridRow.Cells.Item("User_ID").Value)
            frmUser.txtusername.Text = CStr(GridRow.Cells.Item("Username").Value)
            frmUser.txtpassword.Text = CStr(GridRow.Cells.Item("Password").Value)
            frmUser.cmbUsertype.Text = CStr(GridRow.Cells.Item("User_Type").Value)
            frmUser.txtfname.Text = CStr(GridRow.Cells.Item("Firstname").Value)
            frmUser.txtmname.Text = CStr(GridRow.Cells.Item("Middlename").Value)
            frmUser.txtlname.Text = CStr(GridRow.Cells.Item("Lastname").Value)
        Catch ex As Exception

        End Try
    End Sub

    Sub SaveUpdateUser()

        Try

            If saving Then
                If checkUsername() = False Then
                    runServer()
                    MysqlConn.Open()
                    If MessageBox.Show("Are you sure you want to add this new User Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        query = "insert into mppos_db.tbluseraccount (userid,fname,mname,lname,usertype,username,password,dateinserted) values ('" & Trim(frmUser.txtUserid.Text) & "','" & Trim(frmUser.txtfname.Text) & "','" & Trim(frmUser.txtmname.Text) & "','" & Trim(frmUser.txtlname.Text) & "','" & Trim(frmUser.cmbUsertype.Text) & "','" & Trim(frmUser.txtusername.Text) & "','" & Trim(frmUser.txtpassword.Text) & "','" & Date.Now.ToShortDateString & "')"
                        COMMAND = New MySqlCommand(query, MysqlConn)
                        READER = COMMAND.ExecuteReader
                        MsgBox("New User Account has been successfully added!", MsgBoxStyle.Information)
                    End If
                    MysqlConn.Close()
                    userslist()
                    clearTxt("user")
                    frmUser.pneluser.Visible = False
                    frmUser.btnAdd.Enabled = True : frmUser.btnEdit.Enabled = True : frmUser.btnDelete.Enabled = True
                Else
                    MsgBox("Username is already taken, Please choose another username", MsgBoxStyle.Information)
                    frmUser.txtusername.Clear()
                    frmUser.txtusername.Focus()


                End If
            Else

                If checkUpdateUsername() = False Then
                    runServer()
                    MysqlConn.Open()
                    If MessageBox.Show("Are you sure you want to update this User Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        query = "update mppos_db.tbluseraccount set fname='" & Trim(frmUser.txtfname.Text) & "',mname='" & Trim(frmUser.txtmname.Text) & "',lname='" & Trim(frmUser.txtlname.Text) & "',usertype='" & Trim(frmUser.cmbUsertype.Text) & "',username='" & Trim(frmUser.txtusername.Text) & "',password='" & Trim(frmUser.txtpassword.Text) & "' where userid='" & frmUser.txtUserid.Text & "'"
                        COMMAND = New MySqlCommand(query, MysqlConn)
                        READER = COMMAND.ExecuteReader
                        MsgBox(" User Account has been successfully updated!", MsgBoxStyle.Information)
                    End If
                    MysqlConn.Close()
                    userslist()
                    clearTxt("user")
                    frmUser.pneluser.Visible = False
                    frmUser.btnAdd.Enabled = True : frmUser.btnEdit.Enabled = True : frmUser.btnDelete.Enabled = True
                Else
                    MsgBox("Username is already taken, Please choose another username", MsgBoxStyle.Information)
                    frmUser.txtusername.Clear()
                    frmUser.txtusername.Focus()

                End If
              
            End If

               

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
       




    End Sub
    Function checkUsername() As Boolean
        runServer()
        MysqlConn.Open()
        query = "Select * from mppos_db.tbluseraccount where username='" & Trim(frmUser.txtusername.Text) & "' "
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read()
            Return True
        End While
        READER.Close()
        MysqlConn.Close()
    End Function
    Function checkUpdateUsername() As Boolean
        runServer()
        MysqlConn.Open()
        query = "Select * from mppos_db.tbluseraccount where username='" & Trim(frmUser.txtusername.Text) & "' and userid !='" & Trim(frmUser.txtUserid.Text) & "'"
        COMMAND = New MySqlCommand(query, MysqlConn)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        READER = COMMAND.ExecuteReader
        While READER.Read()
            Return True
        End While
        READER.Close()
        MysqlConn.Close()
    End Function
    'Function chckupdateusername() As Boolean
    '    runServer()
    '    MysqlConn.Open()
    '    query = "Select * from mppos_db.tbluseraccount where username='" & Trim(frmUser.txtusername.Text) & "'"
    '    COMMAND = New MySqlCommand(query, MysqlConn)
    '    SDA.SelectCommand = COMMAND
    '    SDA.Fill(dbDataset)
    '    bSource.DataSource = dbDataset
    '    READER = COMMAND.ExecuteReader
    '    While READER.Read()
    '        Return True
    '    End While
    '    READER.Close()
    '    MysqlConn.Close()
    'End Function

    Sub deleteUser()
        runServer()
        Try
            If frmUser.txtUserid.Text = "USER-100001" Then
                If MessageBox.Show("THIS IS THE SYSTEM ADMINISTRATOR ACCOUNT,Unable to Delete ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.OK Then
                End If
            Else
                MysqlConn.Open()

                If MessageBox.Show("Are you sure you want to delete this User Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    query = "delete from mppos_db.tbluseraccount where userid='" & frmUser.txtUserid.Text & "'"
                    COMMAND = New MySqlCommand(query, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    MsgBox(" User Account has been successfully deleted!", MsgBoxStyle.Information)
                    MysqlConn.Close()
                    userslist()
                    frmUser.txtUserid.Clear()
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub





End Class
