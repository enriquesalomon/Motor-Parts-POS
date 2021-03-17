<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockAdjustDetail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelStockAdjustDetail = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdjustRefNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnAdjsutStock = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.cmbActionadjust = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQtyONhand = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtStockno = New System.Windows.Forms.TextBox()
        Me.cmbfilter = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtgStockAdjustList = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblcount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCountdtg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panelStockAdjustDetail.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtgStockAdjustList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelStockAdjustDetail
        '
        Me.panelStockAdjustDetail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelStockAdjustDetail.Controls.Add(Me.GroupBox1)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtDescription)
        Me.panelStockAdjustDetail.Controls.Add(Me.btnAdjsutStock)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label14)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtReason)
        Me.panelStockAdjustDetail.Controls.Add(Me.cmbActionadjust)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label13)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label11)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtSize)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label10)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtModel)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label9)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label8)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtqty)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label7)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtQtyONhand)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label6)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtUnit)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label5)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label4)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label3)
        Me.panelStockAdjustDetail.Controls.Add(Me.Label2)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtColor)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtCategory)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtBarcode)
        Me.panelStockAdjustDetail.Controls.Add(Me.txtProdID)
        Me.panelStockAdjustDetail.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelStockAdjustDetail.Location = New System.Drawing.Point(599, 0)
        Me.panelStockAdjustDetail.Name = "panelStockAdjustDetail"
        Me.panelStockAdjustDetail.Size = New System.Drawing.Size(269, 733)
        Me.panelStockAdjustDetail.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdjustRefNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 39)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'txtAdjustRefNo
        '
        Me.txtAdjustRefNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAdjustRefNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdjustRefNo.Enabled = False
        Me.txtAdjustRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustRefNo.Location = New System.Drawing.Point(90, 13)
        Me.txtAdjustRefNo.Name = "txtAdjustRefNo"
        Me.txtAdjustRefNo.Size = New System.Drawing.Size(162, 19)
        Me.txtAdjustRefNo.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Refference No"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(11, 170)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(240, 26)
        Me.txtDescription.TabIndex = 62
        '
        'btnAdjsutStock
        '
        Me.btnAdjsutStock.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAdjsutStock.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnAdjsutStock.FlatAppearance.BorderSize = 2
        Me.btnAdjsutStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdjsutStock.ForeColor = System.Drawing.Color.White
        Me.btnAdjsutStock.Location = New System.Drawing.Point(11, 655)
        Me.btnAdjsutStock.Name = "btnAdjsutStock"
        Me.btnAdjsutStock.Size = New System.Drawing.Size(241, 57)
        Me.btnAdjsutStock.TabIndex = 61
        Me.btnAdjsutStock.Text = "Adjust Stock"
        Me.btnAdjsutStock.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 581)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Reason"
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(12, 597)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(240, 47)
        Me.txtReason.TabIndex = 59
        '
        'cmbActionadjust
        '
        Me.cmbActionadjust.FormattingEnabled = True
        Me.cmbActionadjust.Items.AddRange(New Object() {"Add", "Remove"})
        Me.cmbActionadjust.Location = New System.Drawing.Point(12, 552)
        Me.cmbActionadjust.Name = "cmbActionadjust"
        Me.cmbActionadjust.Size = New System.Drawing.Size(239, 21)
        Me.cmbActionadjust.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 536)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Action"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Model"
        '
        'txtSize
        '
        Me.txtSize.Enabled = False
        Me.txtSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.Location = New System.Drawing.Point(11, 303)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(240, 26)
        Me.txtSize.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Description"
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(11, 258)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(240, 26)
        Me.txtModel.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Category"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 479)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Adjust Qty"
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(12, 495)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(240, 26)
        Me.txtqty.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Qty On Hand"
        '
        'txtQtyONhand
        '
        Me.txtQtyONhand.Enabled = False
        Me.txtQtyONhand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyONhand.Location = New System.Drawing.Point(12, 450)
        Me.txtQtyONhand.Name = "txtQtyONhand"
        Me.txtQtyONhand.Size = New System.Drawing.Size(240, 26)
        Me.txtQtyONhand.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Unit"
        '
        'txtUnit
        '
        Me.txtUnit.Enabled = False
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(11, 402)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(240, 26)
        Me.txtUnit.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Product Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Product ID"
        '
        'txtColor
        '
        Me.txtColor.Enabled = False
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(11, 354)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(240, 26)
        Me.txtColor.TabIndex = 39
        '
        'txtCategory
        '
        Me.txtCategory.Enabled = False
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(11, 213)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(240, 26)
        Me.txtCategory.TabIndex = 38
        '
        'txtBarcode
        '
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(11, 123)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(240, 26)
        Me.txtBarcode.TabIndex = 37
        '
        'txtProdID
        '
        Me.txtProdID.Enabled = False
        Me.txtProdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdID.Location = New System.Drawing.Point(11, 78)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(240, 26)
        Me.txtProdID.TabIndex = 36
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Khaki
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtStockno)
        Me.Panel3.Controls.Add(Me.cmbfilter)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 64)
        Me.Panel3.TabIndex = 6
        '
        'txtStockno
        '
        Me.txtStockno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStockno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStockno.Enabled = False
        Me.txtStockno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockno.Location = New System.Drawing.Point(303, 6)
        Me.txtStockno.Name = "txtStockno"
        Me.txtStockno.Size = New System.Drawing.Size(162, 19)
        Me.txtStockno.TabIndex = 36
        Me.txtStockno.Visible = False
        '
        'cmbfilter
        '
        Me.cmbfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbfilter.FormattingEnabled = True
        Me.cmbfilter.Items.AddRange(New Object() {"PRODUCT CODE", "DESCRIPTION", "CATEGORY"})
        Me.cmbfilter.Location = New System.Drawing.Point(7, 33)
        Me.cmbfilter.Name = "cmbfilter"
        Me.cmbfilter.Size = New System.Drawing.Size(197, 21)
        Me.cmbfilter.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Search By"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SearchKey"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(210, 34)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(287, 20)
        Me.txtSearch.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(499, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 37)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dtgStockAdjustList
        '
        Me.dtgStockAdjustList.AllowUserToAddRows = False
        Me.dtgStockAdjustList.AllowUserToDeleteRows = False
        Me.dtgStockAdjustList.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtgStockAdjustList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgStockAdjustList.BackgroundColor = System.Drawing.Color.White
        Me.dtgStockAdjustList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgStockAdjustList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgStockAdjustList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgStockAdjustList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgStockAdjustList.Location = New System.Drawing.Point(0, 64)
        Me.dtgStockAdjustList.Name = "dtgStockAdjustList"
        Me.dtgStockAdjustList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgStockAdjustList.Size = New System.Drawing.Size(599, 669)
        Me.dtgStockAdjustList.TabIndex = 7
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblcount, Me.lblCountdtg, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(599, 25)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblcount
        '
        Me.lblcount.BackColor = System.Drawing.Color.Black
        Me.lblcount.ForeColor = System.Drawing.Color.White
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(17, 20)
        Me.lblcount.Text = "0"
        '
        'lblCountdtg
        '
        Me.lblCountdtg.BackColor = System.Drawing.Color.Black
        Me.lblCountdtg.ForeColor = System.Drawing.Color.White
        Me.lblCountdtg.Name = "lblCountdtg"
        Me.lblCountdtg.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblCountdtg.Size = New System.Drawing.Size(19, 20)
        Me.lblCountdtg.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'frmStockAdjustDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(868, 733)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dtgStockAdjustList)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panelStockAdjustDetail)
        Me.Name = "frmStockAdjustDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Adjustment"
        Me.panelStockAdjustDetail.ResumeLayout(False)
        Me.panelStockAdjustDetail.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dtgStockAdjustList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelStockAdjustDetail As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQtyONhand As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtProdID As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjustRefNo As System.Windows.Forms.TextBox
    Friend WithEvents btnAdjsutStock As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents cmbActionadjust As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbfilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtgStockAdjustList As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblcount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCountdtg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStockno As System.Windows.Forms.TextBox
End Class
