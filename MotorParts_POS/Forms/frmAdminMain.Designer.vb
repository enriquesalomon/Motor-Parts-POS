<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CashSalesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsddbMasterItems = New System.Windows.Forms.ToolStripDropDownButton()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdjustStockQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsddbMonitoring = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashSalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton7 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.lblUser = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowMerge = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripDropDownButton3, Me.tsddbMasterItems, Me.tsddbMonitoring, Me.ToolStripDropDownButton7, Me.ToolStripDropDownButton2, Me.lblUser})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(934, 108)
        Me.ToolStrip1.TabIndex = 125
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 108)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashSalesToolStripMenuItem2})
        Me.ToolStripDropDownButton3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(101, 105)
        Me.ToolStripDropDownButton3.Text = "Transaction"
        Me.ToolStripDropDownButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CashSalesToolStripMenuItem2
        '
        Me.CashSalesToolStripMenuItem2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashSalesToolStripMenuItem2.Name = "CashSalesToolStripMenuItem2"
        Me.CashSalesToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.CashSalesToolStripMenuItem2.Text = "Cash Sales"
        '
        'tsddbMasterItems
        '
        Me.tsddbMasterItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StocksToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.StocksCategoryToolStripMenuItem})
        Me.tsddbMasterItems.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsddbMasterItems.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.tsddbMasterItems.Image = CType(resources.GetObject("tsddbMasterItems.Image"), System.Drawing.Image)
        Me.tsddbMasterItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsddbMasterItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsddbMasterItems.Name = "tsddbMasterItems"
        Me.tsddbMasterItems.Size = New System.Drawing.Size(110, 105)
        Me.tsddbMasterItems.Text = "Master Items"
        Me.tsddbMasterItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StocksToolStripMenuItem.Text = "Item"
        '
        'StocksCategoryToolStripMenuItem
        '
        Me.StocksCategoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockListToolStripMenuItem, Me.AdjustStockQuantityToolStripMenuItem})
        Me.StocksCategoryToolStripMenuItem.Name = "StocksCategoryToolStripMenuItem"
        Me.StocksCategoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StocksCategoryToolStripMenuItem.Text = "Stock in"
        '
        'StockListToolStripMenuItem
        '
        Me.StockListToolStripMenuItem.Name = "StockListToolStripMenuItem"
        Me.StockListToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.StockListToolStripMenuItem.Text = "Stock List"
        '
        'AdjustStockQuantityToolStripMenuItem
        '
        Me.AdjustStockQuantityToolStripMenuItem.Name = "AdjustStockQuantityToolStripMenuItem"
        Me.AdjustStockQuantityToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.AdjustStockQuantityToolStripMenuItem.Text = "Adjust Stock Quantity"
        '
        'tsddbMonitoring
        '
        Me.tsddbMonitoring.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionsToolStripMenuItem, Me.CashSalesToolStripMenuItem1, Me.SalesReadingToolStripMenuItem, Me.UserLogsToolStripMenuItem})
        Me.tsddbMonitoring.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsddbMonitoring.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.tsddbMonitoring.Image = CType(resources.GetObject("tsddbMonitoring.Image"), System.Drawing.Image)
        Me.tsddbMonitoring.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsddbMonitoring.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsddbMonitoring.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsddbMonitoring.Name = "tsddbMonitoring"
        Me.tsddbMonitoring.Size = New System.Drawing.Size(94, 105)
        Me.tsddbMonitoring.Text = "Monitoring"
        Me.tsddbMonitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TransactionsToolStripMenuItem.Text = "&Item Inventory"
        '
        'CashSalesToolStripMenuItem1
        '
        Me.CashSalesToolStripMenuItem1.Name = "CashSalesToolStripMenuItem1"
        Me.CashSalesToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.CashSalesToolStripMenuItem1.Text = "&Sales Reading"
        '
        'SalesReadingToolStripMenuItem
        '
        Me.SalesReadingToolStripMenuItem.Name = "SalesReadingToolStripMenuItem"
        Me.SalesReadingToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SalesReadingToolStripMenuItem.Text = "Transactions"
        '
        'UserLogsToolStripMenuItem
        '
        Me.UserLogsToolStripMenuItem.Name = "UserLogsToolStripMenuItem"
        Me.UserLogsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UserLogsToolStripMenuItem.Text = "User Logs"
        '
        'ToolStripDropDownButton7
        '
        Me.ToolStripDropDownButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.ToolStripDropDownButton7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ToolStripDropDownButton7.Image = CType(resources.GetObject("ToolStripDropDownButton7.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripDropDownButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton7.Name = "ToolStripDropDownButton7"
        Me.ToolStripDropDownButton7.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.ToolStripDropDownButton7.Size = New System.Drawing.Size(117, 105)
        Me.ToolStripDropDownButton7.Text = "Security"
        Me.ToolStripDropDownButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripDropDownButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripDropDownButton7.ToolTipText = "Help"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem4.Text = "User Account"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripDropDownButton2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(76, 105)
        Me.ToolStripDropDownButton2.Text = "Log Out"
        Me.ToolStripDropDownButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lblUser
        '
        Me.lblUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblUser.Image = CType(resources.GetObject("lblUser.Image"), System.Drawing.Image)
        Me.lblUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lblUser.Margin = New System.Windows.Forms.Padding(0, 1, 0, 7)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Padding = New System.Windows.Forms.Padding(0, 42, 0, 0)
        Me.lblUser.Size = New System.Drawing.Size(98, 100)
        Me.lblUser.Text = "User: ADMIN"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 10)
        Me.Panel1.TabIndex = 126
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(934, 553)
        Me.Panel2.TabIndex = 127
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.tsslTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(934, 50)
        Me.StatusStrip1.TabIndex = 126
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(669, 45)
        Me.ToolStripStatusLabel1.Text = "GONZAGA MOTOR PARTS AND ACCESSORIES"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ToolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Lavender
        Me.ToolStripStatusLabel3.Image = CType(resources.GetObject("ToolStripStatusLabel3.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(28, 45)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(47, 45)
        Me.ToolStripStatusLabel4.Text = "Time:"
        '
        'tsslTime
        '
        Me.tsslTime.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslTime.ForeColor = System.Drawing.Color.White
        Me.tsslTime.Name = "tsslTime"
        Me.tsslTime.Size = New System.Drawing.Size(175, 45)
        Me.tsslTime.Text = "1:45:23 PM"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'frmAdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 613)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdminMain"
        Me.Text = "Motor Parts POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CashSalesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsddbMasterItems As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents StocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StocksCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsddbMonitoring As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CashSalesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton7 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents StockListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdjustStockQuantityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
