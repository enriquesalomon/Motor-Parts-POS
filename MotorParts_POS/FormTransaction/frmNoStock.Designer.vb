<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNoStock))
        Me.lnlInfoHelp = New System.Windows.Forms.Label()
        Me.lblItemnotFind = New System.Windows.Forms.Label()
        Me.btnItemNotFind = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnlInfoHelp
        '
        Me.lnlInfoHelp.AutoSize = True
        Me.lnlInfoHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlInfoHelp.Location = New System.Drawing.Point(125, 73)
        Me.lnlInfoHelp.Name = "lnlInfoHelp"
        Me.lnlInfoHelp.Size = New System.Drawing.Size(208, 20)
        Me.lnlInfoHelp.TabIndex = 18
        Me.lnlInfoHelp.Text = "Press OK button to continue"
        '
        'lblItemnotFind
        '
        Me.lblItemnotFind.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblItemnotFind.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemnotFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblItemnotFind.Location = New System.Drawing.Point(0, 0)
        Me.lblItemnotFind.Name = "lblItemnotFind"
        Me.lblItemnotFind.Size = New System.Drawing.Size(424, 63)
        Me.lblItemnotFind.TabIndex = 17
        Me.lblItemnotFind.Text = "Item Out of Stock"
        Me.lblItemnotFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnItemNotFind
        '
        Me.btnItemNotFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemNotFind.Image = CType(resources.GetObject("btnItemNotFind.Image"), System.Drawing.Image)
        Me.btnItemNotFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemNotFind.Location = New System.Drawing.Point(162, 109)
        Me.btnItemNotFind.Name = "btnItemNotFind"
        Me.btnItemNotFind.Size = New System.Drawing.Size(115, 53)
        Me.btnItemNotFind.TabIndex = 16
        Me.btnItemNotFind.Text = "OK"
        Me.btnItemNotFind.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmNoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(422, 170)
        Me.Controls.Add(Me.lnlInfoHelp)
        Me.Controls.Add(Me.lblItemnotFind)
        Me.Controls.Add(Me.btnItemNotFind)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNoStock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnlInfoHelp As System.Windows.Forms.Label
    Friend WithEvents lblItemnotFind As System.Windows.Forms.Label
    Friend WithEvents btnItemNotFind As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
