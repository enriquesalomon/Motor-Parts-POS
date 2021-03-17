<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockIn
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
        Me.dtgStockIn = New System.Windows.Forms.DataGridView()
        Me.panelStockinField = New System.Windows.Forms.Panel()
        Me.panelSearchItem = New System.Windows.Forms.Panel()
        Me.dtgItemsearch = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnCLosepanel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStockno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsize = New System.Windows.Forms.TextBox()
        Me.Model = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.btnAddStockin = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalQtyOnHand = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtyOnHand = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtitemdescription = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtprodid = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblcountof = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStockinCountdtg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dtgStockIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelStockinField.SuspendLayout()
        Me.panelSearchItem.SuspendLayout()
        CType(Me.dtgItemsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgStockIn
        '
        Me.dtgStockIn.AllowUserToAddRows = False
        Me.dtgStockIn.AllowUserToDeleteRows = False
        Me.dtgStockIn.AllowUserToResizeColumns = False
        Me.dtgStockIn.AllowUserToResizeRows = False
        Me.dtgStockIn.BackgroundColor = System.Drawing.Color.White
        Me.dtgStockIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgStockIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgStockIn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgStockIn.Location = New System.Drawing.Point(0, 0)
        Me.dtgStockIn.Name = "dtgStockIn"
        Me.dtgStockIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgStockIn.Size = New System.Drawing.Size(967, 315)
        Me.dtgStockIn.TabIndex = 2
        '
        'panelStockinField
        '
        Me.panelStockinField.BackColor = System.Drawing.Color.Cornsilk
        Me.panelStockinField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelStockinField.Controls.Add(Me.panelSearchItem)
        Me.panelStockinField.Controls.Add(Me.GroupBox1)
        Me.panelStockinField.Controls.Add(Me.Label11)
        Me.panelStockinField.Controls.Add(Me.txtcolor)
        Me.panelStockinField.Controls.Add(Me.Label10)
        Me.panelStockinField.Controls.Add(Me.txtsize)
        Me.panelStockinField.Controls.Add(Me.Model)
        Me.panelStockinField.Controls.Add(Me.txtModel)
        Me.panelStockinField.Controls.Add(Me.btnAddStockin)
        Me.panelStockinField.Controls.Add(Me.Label8)
        Me.panelStockinField.Controls.Add(Me.txtTotalQtyOnHand)
        Me.panelStockinField.Controls.Add(Me.Label7)
        Me.panelStockinField.Controls.Add(Me.txtQty)
        Me.panelStockinField.Controls.Add(Me.Label6)
        Me.panelStockinField.Controls.Add(Me.txtQtyOnHand)
        Me.panelStockinField.Controls.Add(Me.Label5)
        Me.panelStockinField.Controls.Add(Me.Label4)
        Me.panelStockinField.Controls.Add(Me.Label3)
        Me.panelStockinField.Controls.Add(Me.Label2)
        Me.panelStockinField.Controls.Add(Me.Label1)
        Me.panelStockinField.Controls.Add(Me.txtunit)
        Me.panelStockinField.Controls.Add(Me.txtCategory)
        Me.panelStockinField.Controls.Add(Me.txtitemdescription)
        Me.panelStockinField.Controls.Add(Me.txtBarcode)
        Me.panelStockinField.Controls.Add(Me.txtprodid)
        Me.panelStockinField.Controls.Add(Me.btnFind)
        Me.panelStockinField.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelStockinField.Location = New System.Drawing.Point(0, 0)
        Me.panelStockinField.Name = "panelStockinField"
        Me.panelStockinField.Size = New System.Drawing.Size(967, 292)
        Me.panelStockinField.TabIndex = 3
        '
        'panelSearchItem
        '
        Me.panelSearchItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelSearchItem.Controls.Add(Me.dtgItemsearch)
        Me.panelSearchItem.Controls.Add(Me.txtSearch)
        Me.panelSearchItem.Controls.Add(Me.btnCLosepanel)
        Me.panelSearchItem.Location = New System.Drawing.Point(396, 139)
        Me.panelSearchItem.Name = "panelSearchItem"
        Me.panelSearchItem.Size = New System.Drawing.Size(537, 148)
        Me.panelSearchItem.TabIndex = 45
        Me.panelSearchItem.Visible = False
        '
        'dtgItemsearch
        '
        Me.dtgItemsearch.AllowUserToAddRows = False
        Me.dtgItemsearch.AllowUserToDeleteRows = False
        Me.dtgItemsearch.AllowUserToResizeColumns = False
        Me.dtgItemsearch.AllowUserToResizeRows = False
        Me.dtgItemsearch.BackgroundColor = System.Drawing.Color.White
        Me.dtgItemsearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgItemsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgItemsearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgItemsearch.Location = New System.Drawing.Point(3, 32)
        Me.dtgItemsearch.Name = "dtgItemsearch"
        Me.dtgItemsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgItemsearch.Size = New System.Drawing.Size(534, 159)
        Me.dtgItemsearch.TabIndex = 3
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(3, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(485, 26)
        Me.txtSearch.TabIndex = 2
        '
        'btnCLosepanel
        '
        Me.btnCLosepanel.Location = New System.Drawing.Point(494, 3)
        Me.btnCLosepanel.Name = "btnCLosepanel"
        Me.btnCLosepanel.Size = New System.Drawing.Size(40, 26)
        Me.btnCLosepanel.TabIndex = 1
        Me.btnCLosepanel.Text = "x"
        Me.btnCLosepanel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtStockno)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(946, 39)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Stock No"
        '
        'txtStockno
        '
        Me.txtStockno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStockno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStockno.Enabled = False
        Me.txtStockno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockno.Location = New System.Drawing.Point(76, 13)
        Me.txtStockno.Name = "txtStockno"
        Me.txtStockno.Size = New System.Drawing.Size(753, 19)
        Me.txtStockno.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Color"
        '
        'txtcolor
        '
        Me.txtcolor.Enabled = False
        Me.txtcolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolor.Location = New System.Drawing.Point(93, 235)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(210, 26)
        Me.txtcolor.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Size"
        '
        'txtsize
        '
        Me.txtsize.Enabled = False
        Me.txtsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsize.Location = New System.Drawing.Point(93, 203)
        Me.txtsize.Name = "txtsize"
        Me.txtsize.Size = New System.Drawing.Size(210, 26)
        Me.txtsize.TabIndex = 37
        '
        'Model
        '
        Me.Model.AutoSize = True
        Me.Model.Location = New System.Drawing.Point(21, 184)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(36, 13)
        Me.Model.TabIndex = 36
        Me.Model.Text = "Model"
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(93, 171)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(210, 26)
        Me.txtModel.TabIndex = 35
        '
        'btnAddStockin
        '
        Me.btnAddStockin.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAddStockin.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnAddStockin.FlatAppearance.BorderSize = 2
        Me.btnAddStockin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStockin.ForeColor = System.Drawing.Color.White
        Me.btnAddStockin.Location = New System.Drawing.Point(636, 229)
        Me.btnAddStockin.Name = "btnAddStockin"
        Me.btnAddStockin.Size = New System.Drawing.Size(210, 40)
        Me.btnAddStockin.TabIndex = 16
        Me.btnAddStockin.Text = "Add to Stock"
        Me.btnAddStockin.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(534, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total Qty On Hand"
        '
        'txtTotalQtyOnHand
        '
        Me.txtTotalQtyOnHand.Enabled = False
        Me.txtTotalQtyOnHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQtyOnHand.Location = New System.Drawing.Point(636, 194)
        Me.txtTotalQtyOnHand.Name = "txtTotalQtyOnHand"
        Me.txtTotalQtyOnHand.Size = New System.Drawing.Size(210, 26)
        Me.txtTotalQtyOnHand.TabIndex = 14
        Me.txtTotalQtyOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(586, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(636, 139)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(210, 49)
        Me.txtQty.TabIndex = 12
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(562, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Qty On Hand"
        '
        'txtQtyOnHand
        '
        Me.txtQtyOnHand.Enabled = False
        Me.txtQtyOnHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyOnHand.Location = New System.Drawing.Point(636, 107)
        Me.txtQtyOnHand.Name = "txtQtyOnHand"
        Me.txtQtyOnHand.Size = New System.Drawing.Size(210, 26)
        Me.txtQtyOnHand.TabIndex = 10
        Me.txtQtyOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(604, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Barcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Product ID"
        '
        'txtunit
        '
        Me.txtunit.Enabled = False
        Me.txtunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.Location = New System.Drawing.Point(636, 75)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(210, 26)
        Me.txtunit.TabIndex = 4
        '
        'txtCategory
        '
        Me.txtCategory.Enabled = False
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(93, 139)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(210, 26)
        Me.txtCategory.TabIndex = 3
        '
        'txtitemdescription
        '
        Me.txtitemdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemdescription.Location = New System.Drawing.Point(93, 107)
        Me.txtitemdescription.Name = "txtitemdescription"
        Me.txtitemdescription.Size = New System.Drawing.Size(284, 26)
        Me.txtitemdescription.TabIndex = 2
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(93, 75)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(210, 26)
        Me.txtBarcode.TabIndex = 1
        '
        'txtprodid
        '
        Me.txtprodid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtprodid.Enabled = False
        Me.txtprodid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprodid.Location = New System.Drawing.Point(93, 43)
        Me.txtprodid.Name = "txtprodid"
        Me.txtprodid.ReadOnly = True
        Me.txtprodid.Size = New System.Drawing.Size(210, 26)
        Me.txtprodid.TabIndex = 0
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(305, 75)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(46, 27)
        Me.btnFind.TabIndex = 46
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 607)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(967, 27)
        Me.Panel2.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblcountof, Me.lblStockinCountdtg, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 2)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(967, 25)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblcountof
        '
        Me.lblcountof.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcountof.ForeColor = System.Drawing.Color.White
        Me.lblcountof.Name = "lblcountof"
        Me.lblcountof.Size = New System.Drawing.Size(17, 20)
        Me.lblcountof.Text = "0"
        '
        'lblStockinCountdtg
        '
        Me.lblStockinCountdtg.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStockinCountdtg.ForeColor = System.Drawing.Color.White
        Me.lblStockinCountdtg.Name = "lblStockinCountdtg"
        Me.lblStockinCountdtg.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblStockinCountdtg.Size = New System.Drawing.Size(19, 20)
        Me.lblStockinCountdtg.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(13, 20)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtgStockIn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 292)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(967, 315)
        Me.Panel3.TabIndex = 6
        '
        'frmStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 634)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelStockinField)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStockIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock -in Module"
        CType(Me.dtgStockIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelStockinField.ResumeLayout(False)
        Me.panelStockinField.PerformLayout()
        Me.panelSearchItem.ResumeLayout(False)
        Me.panelSearchItem.PerformLayout()
        CType(Me.dtgItemsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgStockIn As System.Windows.Forms.DataGridView
    Friend WithEvents panelStockinField As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtitemdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtprodid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalQtyOnHand As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQtyOnHand As System.Windows.Forms.TextBox
    Friend WithEvents btnAddStockin As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcolor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsize As System.Windows.Forms.TextBox
    Friend WithEvents Model As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblcountof As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStockinCountdtg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtStockno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents panelSearchItem As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnCLosepanel As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents dtgItemsearch As System.Windows.Forms.DataGridView
End Class
