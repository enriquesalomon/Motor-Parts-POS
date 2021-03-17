Imports MySql.Data.MySqlClient
Public Class frmUser
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        frmDialogForm.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbUsertype.Text = "" Then
            MsgBox("Some fields are blank, Please fill all required data")
        Else
            If CheckField("user") Then
                MsgBox("Some fields are blank, Please fill all required data")
            Else
                'If checkExist("useraccount") = True Then
                'If MessageBox.Show("USER IS ALREADY EXISTED,FAILED TO SAVE", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.OK Then
                'End If
                'Else
                myUser.SaveUpdateUser()
                'End If


            End If
        End If
        dtgUserlist.Enabled = True
        pnelUp.Enabled = True
    End Sub
   
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myUser.userslist()
      End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dtgUserlist.Enabled = False : pnelUp.Enabled = False : pneluser.Visible = True
        saving = True : clearTxt("user")
        idLoader(txtUserid.Text, "tbluseraccount", "Select * from mppos_db.tbluseraccount order by userid", "userid", "USER-")
        btnAdd.Enabled = False : btnEdit.Enabled = False : btnDelete.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtUserid.Text <> Nothing Then
            myUser.deleteUser()
            txtUserid.Clear()
        End If
        clearTxt("user")
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        btnAdd.Enabled = True : btnEdit.Enabled = True : btnDelete.Enabled = True
        clearTxt("user") : pneluser.Visible = False : pnelUp.Enabled = True : dtgUserlist.Enabled = True
    End Sub
    Private Sub dtgUserlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUserlist.CellClick
        myUser.loadData()
        lblcountof.Text = dtgUserlist.CurrentCell.RowIndex + 1 & " of"
        'If e.RowIndex >= 0 Then
        '    dtgUserlist.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
        '    MsgBox(e.ToString)
        'End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtUserid.Text <> Nothing Then
 pnelUp.Enabled = False : saving = False : pneluser.Visible = True
        End If

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        search = True
        If cmbFiltr.Text = Nothing Then
            MsgBox("Please specify a keyword in searching")
        Else : myUser.userslist()
        End If

    End Sub
  
    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtgUserlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUserlist.CellContentClick

    End Sub

  
    Private Sub frmUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress, txtfname.KeyPress, txtmname.KeyPress, txtlname.KeyPress
        Dim t As Control

        For Each t In pneluser.Controls
            If TypeOf t Is TextBox Then
                If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then

                    If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then

                        e.Handled = True
                    End If
                End If
            End If
        Next


    End Sub
   

End Class