Imports MySql.Data.MySqlClient
Public Class Category

    Function setBoxCategory()
        frmItemDetails.cmbCategory.Items.Clear()
        Try

            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If

            MysqlConn.Open()
          
                query = "Select Distinct categoryname from mppos_db.tblcategory order by catid"
           

            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            READER = COMMAND.ExecuteReader
            While READER.Read()

                frmItemDetails.cmbCategory.Items.Add(READER("categoryname"))

            End While


            READER.Close()
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.Exclamation, "Connection Error!")
            MysqlConn.Close()
        End Try
    End Function
    Sub categorylist()
        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        If search Then
            ' query = "Select barcode as PRODUCT_CODE,itemname as DESCRIPTION,category as CATEGORY,model as MODEL,size as SIZE,color as COLOR,unit as UNIT,unitcost as UNIT_COST,saleprice as UNIT_SALEPRICE,quantity as QUANTITY,criticallimit as CRITICAL_LIMIT,dateinserted as DATE_INSERTED,datemodified as LAST_MODIFIED,addedby as ADDED_BY,itemid as ITEM_ID from mppos_db.tblcategory where model like '" & frmItem.txtsearch.Text & "%' order by itemid"
            query = "Select tblcategory.catid as CATEGORY_ID,tblcategory.categoryname as CATEGORY from mppos_db.tblcategory where tblcategory.categoryname like '" & frmCategory.txtsearch.Text & "%' order by tblcategory.catid"
        Else
            query = "Select tblcategory.catid as CATEGORY_ID,tblcategory.categoryname as CATEGORY from  mppos_db.tblcategory order by tblcategory.catid"

        End If
        Try
            MysqlConn.Open()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            frmCategory.dtglist.DataSource = bSource
            SDA.Update(dbDataset)
            MysqlConn.Close()
            frmCategory.dtglist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            frmCategory.lblCountdtg.Text = frmCategory.dtglist.Rows.Count & " Records"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub
    Sub SaveUpdateItem()

        Try

            If saving Then
                If checkcategoryname() = False Then
                    runServer()
                    MysqlConn.Open()
                    If MessageBox.Show("Are you sure you want to add this new Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        query = "insert into mppos_db.tblcategory (catid,categoryname) values ('" & Trim(frmCatDetails.txtCatID.Text) & "','" & Trim(frmCatDetails.txtCategory.Text) & "')"
                        COMMAND = New MySqlCommand(query, MysqlConn)
                        READER = COMMAND.ExecuteReader
                        MsgBox("New Category has been successfully added!", MsgBoxStyle.Information)
                    End If
                    MysqlConn.Close()
                    categorylist()
                    frmCatDetails.txtCatID.Clear()
                    frmCatDetails.txtCategory.Clear()
                    GlobalCatID = Nothing
                    frmCatDetails.Close()
                Else
                    MsgBox("Category name is already exist, Please choose another category", MsgBoxStyle.Information)
                    frmCatDetails.txtCategory.Clear()
                    frmCatDetails.txtCategory.Focus()

                End If

            Else
                If checkUpdateCategoryname() = False Then
                    runServer()
                    MysqlConn.Open()
                    If MessageBox.Show("Are you sure you want to update this User Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        query = "update mppos_db.tblcategory set categoryname='" & Trim(frmCatDetails.txtCategory.Text) & "' where catid='" & GlobalCatID & "'"
                        COMMAND = New MySqlCommand(query, MysqlConn)
                        READER = COMMAND.ExecuteReader
                        MsgBox(" Category has been successfully updated!", MsgBoxStyle.Information)
                    End If
                    MysqlConn.Close()
                    categorylist()
                    frmCatDetails.txtCatID.Clear()
                    frmCatDetails.txtCategory.Clear()
                    GlobalCatID = Nothing
                    frmCatDetails.Close()
                Else
                    MsgBox("Category name is already exist, Please choose another category", MsgBoxStyle.Information)
                    frmCatDetails.txtCategory.Clear()
                    frmCatDetails.txtCategory.Focus()

                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try


    End Sub
    Function checkUpdateCategoryname() As Boolean
        runServer()
        MysqlConn.Open()
        query = "Select * from mppos_db.tblcategory where categoryname='" & Trim(frmCatDetails.txtCategory.Text) & "' and catid !='" & Trim(frmCatDetails.txtCatID.Text) & "'"
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
    Function checkcategoryname() As Boolean
        runServer()
        MysqlConn.Open()
        query = "Select * from mppos_db.tblcategory where categoryname='" & Trim(frmCatDetails.txtCategory.Text) & "' "
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
    Sub deleteCategory()
        runServer()
        Try


            MysqlConn.Open()

            If MessageBox.Show("Are you sure you want to delete this Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                query = "delete from mppos_db.tblcategory where catid='" & GlobalCatID & "'"
                COMMAND = New MySqlCommand(query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MsgBox(" Category has been successfully deleted!", MsgBoxStyle.Information)
                MysqlConn.Close()
                categorylist()

            End If
            MysqlConn.Close()
            categorylist()

            GlobalCatID = Nothing
            frmCategory.lblcountof.Text = "0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
    Sub loadData()
        'Try
        Dim GridRow As DataGridViewRow = frmCategory.dtglist.CurrentRow
        frmCatDetails.txtCatID.Text = CStr(GridRow.Cells.Item("CATEGORY_ID").Value)
        GlobalCatID = CStr(GridRow.Cells.Item("CATEGORY_ID").Value)
        frmCatDetails.txtCategory.Text = CStr(GridRow.Cells.Item("CATEGORY").Value)

        'Catch ex As Exception

        'End Try
    End Sub

End Class
