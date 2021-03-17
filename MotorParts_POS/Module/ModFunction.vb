Imports MySql.Data.MySqlClient
Module ModFunction
    Public MysqlConn As MySqlConnection
    Public COMMAND As MySqlCommand
    Public stringServer = "server=localhost;userid=root;password=godisnotdead"
    ';database=sakila
    Public READER As MySqlDataReader
    Public SDA As New MySqlDataAdapter
    Public dbDataset As New DataTable
    Public bSource As New BindingSource

   

    Function runServer()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = stringServer
    End Function

    Public Function trapkey(ByVal Kcode As String) As Boolean
        If Kcode >= 47 And Kcode <= 57 Or Kcode = 8 Then : trapkey = False
        Else : trapkey = True : End If
    End Function
    Public Function idLoader(ByVal newID As String, ByVal dbTablename As String, ByVal query As String, ByVal slctID As String, ByVal idText As String)
        Try

            runServer()
            newID = ""

            Dim continue_num As String = ""
            MysqlConn.Open()
            ' query = "Select * from mppos_db.tbluseraccount"
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            READER = COMMAND.ExecuteReader
            While READER.Read()
                continue_num = Microsoft.VisualBasic.Right(String.Format(READER(slctID)), 6)
            End While

            If dbDataset.Rows.Count = 0 Then : newID = "100001"
            Else
                newID = String.Format("{0:00}", Mid(Trim(continue_num), 1, 6) + 1)
            End If
            If dbTablename = "tbluseraccount" Then frmUser.txtUserid.Text = Trim(idText & newID)
            If dbTablename = "tblitem" Then frmItemDetails.txtitemId.Text = Trim(idText & newID)
            If dbTablename = "tblstockin" Then frmStockIn.txtStockno.Text = Trim(idText & newID) : frmStockAdjustDetail.txtStockno.Text = Trim(idText & newID)
            If dbTablename = "tblstockadjust" Then frmStockAdjustDetail.txtAdjustRefNo.Text = Trim(idText & newID)
            If dbTablename = "tblcategory" Then frmCatDetails.txtCatID.Text = Trim(idText & newID)

            READER.Close()
            MysqlConn.Close()
            Return newID
        Catch ex As Exception

        End Try
    End Function
    Function CheckField(clas As String) As Boolean
        Select clas
            Case "user"
                For Each t In frmUser.pneluser.Controls
                    If TypeOf t Is TextBox Then
                        If t.text = Nothing And frmUser.cmbUsertype.ValueMember = Nothing Then
                            Return True
                        End If
                    End If
                Next
            Case "item"
                For Each t In frmItemDetails.panelItemDetails.Controls
                    If TypeOf t Is TextBox Then
                        If t.text = Nothing And frmItemDetails.cmbCategory.ValueMember = Nothing And frmItemDetails.cmbunit.ValueMember = Nothing Then
                            Return True
                        End If
                    End If
                Next

           
        End Select
    End Function
    '' Funtion to cleartx globally in evry class
    Public Sub clearTxt(ByVal clas As String)
        Select Case clas
            Case "user"
                For Each t In frmUser.pneluser.Controls
                    If TypeOf t Is TextBox Then
                        t.clear() : frmUser.cmbUsertype.Text = "" : frmUser.cmbUsertype.Text = ""
                    End If
                Next
            Case "item"
                For Each t In frmItemDetails.panelItemDetails.Controls
                    If TypeOf t Is TextBox Then
                        t.clear() : frmItemDetails.cmbCategory.Text = Nothing
                    End If
                Next
            Case "stockitem"
                For Each t In frmStockIn.panelStockinField.Controls
                    If TypeOf t Is TextBox Then
                        t.clear()
                    End If
                Next
            Case "stockadjustdetail"
                For Each t In frmStockAdjustDetail.panelStockAdjustDetail.Controls
                    If TypeOf t Is TextBox Then
                        t.clear() : frmStockAdjustDetail.cmbActionadjust.Text = Nothing
                    End If
                Next
        End Select

    End Sub
  
    Function checkExist(clas As String) As Boolean
        Select Case clas
            'Case "category"
            '    For Each RW As DataGridViewRow In frmCategory.dtgCategory.Rows
            '        If RW.Cells(1).Value.ToString = frmCategory.txtCat.Text Then
            '            checkExist = True
            '        End If
            '    Next
            Case "useraccount"
                For Each RW As DataGridViewRow In frmUser.dtgUserlist.Rows
                    If RW.Cells(1).Value.ToString = frmUser.txtfname.Text And RW.Cells(3).Value.ToString = frmUser.txtlname.Text Then
                        checkExist = True
                    End If
                Next

        End Select
       
    End Function












    '======================Procedures and Functions use in UI========================
    Public Function PlexiglassForm(dialog As Form, form As String)
        Try
            frmDialogForm.FormBorderStyle = FormBorderStyle.None
            frmDialogForm.Bounds = Screen.FromPoint(dialog.Location).Bounds
            frmDialogForm.StartPosition = FormStartPosition.Manual
            frmDialogForm.AutoScaleMode = AutoScaleMode.None
            frmDialogForm.BackColor = Color.Black
            frmDialogForm.Opacity = 0.45
            frmDialogForm.Show()
            dialog.StartPosition = FormStartPosition.CenterParent
            'If form = "masterItem" Then : frmMasterItem.ShowDialog()
            If form = "user" Then : frmUser.ShowDialog()
                'ElseIf form = "Backup" Then : frmBackup.ShowDialog()
                'ElseIf form = "User" Then : frmUserAccount.ShowDialog()
                'ElseIf form = "Category" Then : frmCategory.ShowDialog()
                'ElseIf form = "Setting" Then : frmSettings.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("ERROR:" & ex.Message & ex.Source)
        End Try
    End Function
    Sub itemLookuplist()

        runServer()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            If search = True Then
                query = "Select * from mppos_db.tblitem where tblitem.itemname  like'" & frmItemLookup.txtSearch.Text & "%' and quantity > 0 "
            Else
                query = "SELECT * from mppos_db.tblitem where quantity > 0 "

            End If

            'dbDataset.Clear()
            'dbDataset.Rows.Clear()
            frmItemLookup.DGVStocks.Rows.Clear()
            COMMAND = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset

            READER = COMMAND.ExecuteReader
            If dbDataset.Rows.Count > 0 Then
                frmItemLookup.DGVStocks.ColumnCount = 4
                frmItemLookup.DGVStocks.Columns(0).HeaderText = "Barcode" : frmItemLookup.DGVStocks.Columns(0).Width = 150 : frmItemLookup.DGVStocks.Columns(0).Name = "barcode"
                frmItemLookup.DGVStocks.Columns(1).HeaderText = "Description" : frmItemLookup.DGVStocks.Columns(1).Width = 500 : frmItemLookup.DGVStocks.Columns(1).Name = "itemname"
                frmItemLookup.DGVStocks.Columns(2).HeaderText = "Category" : frmItemLookup.DGVStocks.Columns(2).Width = 150 : frmItemLookup.DGVStocks.Columns(2).Name = "category"
                frmItemLookup.DGVStocks.Columns(3).HeaderText = "Quantity" : frmItemLookup.DGVStocks.Columns(3).Width = 100 : frmItemLookup.DGVStocks.Columns(3).Name = "quantity"

                For Each row As DataRow In dbDataset.Rows
                    Dim rowData As String() = New String() {row("barcode").ToString, row("itemname").ToString, row("category").ToString, row("quantity").ToString}
                    frmItemLookup.DGVStocks.Rows.Add(rowData)
                Next
            End If

            READER.Close()
            MysqlConn.Close()
            frmItemLookup.txtSearch.Focus()
            frmItemLookup.DGVStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub


End Module
