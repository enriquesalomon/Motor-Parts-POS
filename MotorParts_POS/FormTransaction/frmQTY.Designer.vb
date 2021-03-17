<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQTY
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
        Me.lblQtyLabel = New System.Windows.Forms.Label()
        Me.pnelAddqty = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.pnelAddqty.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQtyLabel
        '
        Me.lblQtyLabel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblQtyLabel.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyLabel.ForeColor = System.Drawing.Color.White
        Me.lblQtyLabel.Location = New System.Drawing.Point(-1, -1)
        Me.lblQtyLabel.Name = "lblQtyLabel"
        Me.lblQtyLabel.Size = New System.Drawing.Size(421, 50)
        Me.lblQtyLabel.TabIndex = 45
        Me.lblQtyLabel.Text = "INPUT QUANTITY"
        Me.lblQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnelAddqty
        '
        Me.pnelAddqty.BackColor = System.Drawing.SystemColors.Control
        Me.pnelAddqty.Controls.Add(Me.lblQtyLabel)
        Me.pnelAddqty.Controls.Add(Me.Label2)
        Me.pnelAddqty.Controls.Add(Me.txtQty)
        Me.pnelAddqty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnelAddqty.Location = New System.Drawing.Point(0, 0)
        Me.pnelAddqty.Name = "pnelAddqty"
        Me.pnelAddqty.Size = New System.Drawing.Size(418, 172)
        Me.pnelAddqty.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(46, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "(Esc) CANCEL           (Enter) ENTER"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Black
        Me.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQty.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.White
        Me.txtQty.Location = New System.Drawing.Point(23, 55)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(376, 63)
        Me.txtQty.TabIndex = 0
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmQTY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 172)
        Me.Controls.Add(Me.pnelAddqty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQTY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQTY"
        Me.pnelAddqty.ResumeLayout(False)
        Me.pnelAddqty.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblQtyLabel As System.Windows.Forms.Label
    Friend WithEvents pnelAddqty As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
End Class
