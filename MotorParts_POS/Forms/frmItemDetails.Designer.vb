<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelItemDetails = New System.Windows.Forms.Panel()
        Me.Panelsizecolor = New System.Windows.Forms.Panel()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.cmbunit = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCritcalLmit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSelPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCostprice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtDecription = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtitemId = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelItemDetails.SuspendLayout()
        Me.Panelsizecolor.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelItemDetails
        '
        Me.panelItemDetails.BackColor = System.Drawing.Color.LemonChiffon
        Me.panelItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelItemDetails.Controls.Add(Me.Panelsizecolor)
        Me.panelItemDetails.Controls.Add(Me.cmbunit)
        Me.panelItemDetails.Controls.Add(Me.Label11)
        Me.panelItemDetails.Controls.Add(Me.Label10)
        Me.panelItemDetails.Controls.Add(Me.cmbCategory)
        Me.panelItemDetails.Controls.Add(Me.Label9)
        Me.panelItemDetails.Controls.Add(Me.btnCancel)
        Me.panelItemDetails.Controls.Add(Me.btnSave)
        Me.panelItemDetails.Controls.Add(Me.Label8)
        Me.panelItemDetails.Controls.Add(Me.txtCritcalLmit)
        Me.panelItemDetails.Controls.Add(Me.Label7)
        Me.panelItemDetails.Controls.Add(Me.txtSelPrice)
        Me.panelItemDetails.Controls.Add(Me.Label6)
        Me.panelItemDetails.Controls.Add(Me.txtCostprice)
        Me.panelItemDetails.Controls.Add(Me.Label5)
        Me.panelItemDetails.Controls.Add(Me.Label4)
        Me.panelItemDetails.Controls.Add(Me.Label3)
        Me.panelItemDetails.Controls.Add(Me.Label2)
        Me.panelItemDetails.Controls.Add(Me.Label1)
        Me.panelItemDetails.Controls.Add(Me.txtModel)
        Me.panelItemDetails.Controls.Add(Me.txtDecription)
        Me.panelItemDetails.Controls.Add(Me.txtBarcode)
        Me.panelItemDetails.Controls.Add(Me.txtitemId)
        Me.panelItemDetails.Controls.Add(Me.Panel2)
        Me.panelItemDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelItemDetails.Location = New System.Drawing.Point(0, 0)
        Me.panelItemDetails.Name = "panelItemDetails"
        Me.panelItemDetails.Size = New System.Drawing.Size(565, 484)
        Me.panelItemDetails.TabIndex = 1
        '
        'Panelsizecolor
        '
        Me.Panelsizecolor.Controls.Add(Me.txtColor)
        Me.Panelsizecolor.Controls.Add(Me.txtSize)
        Me.Panelsizecolor.Location = New System.Drawing.Point(73, 226)
        Me.Panelsizecolor.Name = "Panelsizecolor"
        Me.Panelsizecolor.Size = New System.Drawing.Size(454, 76)
        Me.Panelsizecolor.TabIndex = 36
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(20, 37)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(426, 26)
        Me.txtColor.TabIndex = 33
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.Location = New System.Drawing.Point(20, 5)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(426, 26)
        Me.txtSize.TabIndex = 31
        '
        'cmbunit
        '
        Me.cmbunit.FormattingEnabled = True
        Me.cmbunit.Location = New System.Drawing.Point(93, 308)
        Me.cmbunit.Name = "cmbunit"
        Me.cmbunit.Size = New System.Drawing.Size(210, 21)
        Me.cmbunit.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Color"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Size"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(93, 172)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(426, 21)
        Me.cmbCategory.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Category"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Tomato
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(427, 436)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 41)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(329, 436)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 41)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 412)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Critical Limit"
        '
        'txtCritcalLmit
        '
        Me.txtCritcalLmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCritcalLmit.Location = New System.Drawing.Point(93, 399)
        Me.txtCritcalLmit.Name = "txtCritcalLmit"
        Me.txtCritcalLmit.Size = New System.Drawing.Size(210, 26)
        Me.txtCritcalLmit.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Selling Price"
        '
        'txtSelPrice
        '
        Me.txtSelPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelPrice.Location = New System.Drawing.Point(93, 367)
        Me.txtSelPrice.Name = "txtSelPrice"
        Me.txtSelPrice.Size = New System.Drawing.Size(210, 26)
        Me.txtSelPrice.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cost Price"
        '
        'txtCostprice
        '
        Me.txtCostprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostprice.Location = New System.Drawing.Point(93, 335)
        Me.txtCostprice.Name = "txtCostprice"
        Me.txtCostprice.Size = New System.Drawing.Size(210, 26)
        Me.txtCostprice.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Barcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Product No."
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(93, 199)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(426, 26)
        Me.txtModel.TabIndex = 13
        '
        'txtDecription
        '
        Me.txtDecription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecription.Location = New System.Drawing.Point(93, 139)
        Me.txtDecription.Name = "txtDecription"
        Me.txtDecription.Size = New System.Drawing.Size(426, 26)
        Me.txtDecription.TabIndex = 12
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(93, 107)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(210, 26)
        Me.txtBarcode.TabIndex = 11
        '
        'txtitemId
        '
        Me.txtitemId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtitemId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtitemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemId.Location = New System.Drawing.Point(93, 80)
        Me.txtitemId.Name = "txtitemId"
        Me.txtitemId.ReadOnly = True
        Me.txtitemId.Size = New System.Drawing.Size(426, 19)
        Me.txtitemId.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(561, 49)
        Me.Panel2.TabIndex = 2
        '
        'frmItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 484)
        Me.Controls.Add(Me.panelItemDetails)
        Me.Name = "frmItemDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Detail"
        Me.panelItemDetails.ResumeLayout(False)
        Me.panelItemDetails.PerformLayout()
        Me.Panelsizecolor.ResumeLayout(False)
        Me.Panelsizecolor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelItemDetails As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCritcalLmit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSelPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCostprice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtDecription As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtitemId As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbunit As System.Windows.Forms.ComboBox
    Friend WithEvents Panelsizecolor As System.Windows.Forms.Panel
End Class
