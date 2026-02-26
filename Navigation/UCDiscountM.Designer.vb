<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDiscountM
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnDiscountEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDiscountAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDiscountDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCategoryDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCategoryName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvDiscount = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = Global.MCCHSIS.My.Resources.Resources.delete2
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(690, 598)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(49, 26)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 54
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.MCCHSIS.My.Resources.Resources.edit_icon2
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(542, 592)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(37, 33)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 55
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.MCCHSIS.My.Resources.Resources.add_icon
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(385, 596)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(32, 27)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 56
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btnDiscountEdit
        '
        Me.btnDiscountEdit.BorderRadius = 5
        Me.btnDiscountEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscountEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscountEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDiscountEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDiscountEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnDiscountEdit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscountEdit.ForeColor = System.Drawing.Color.White
        Me.btnDiscountEdit.Location = New System.Drawing.Point(530, 589)
        Me.btnDiscountEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDiscountEdit.Name = "btnDiscountEdit"
        Me.btnDiscountEdit.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDiscountEdit.Size = New System.Drawing.Size(106, 42)
        Me.btnDiscountEdit.TabIndex = 51
        Me.btnDiscountEdit.Text = "EDIT"
        '
        'btnDiscountAdd
        '
        Me.btnDiscountAdd.BorderRadius = 5
        Me.btnDiscountAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscountAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscountAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDiscountAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDiscountAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscountAdd.ForeColor = System.Drawing.Color.White
        Me.btnDiscountAdd.Location = New System.Drawing.Point(379, 589)
        Me.btnDiscountAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDiscountAdd.Name = "btnDiscountAdd"
        Me.btnDiscountAdd.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDiscountAdd.Size = New System.Drawing.Size(106, 42)
        Me.btnDiscountAdd.TabIndex = 52
        Me.btnDiscountAdd.Text = "ADD"
        '
        'btnDiscountDelete
        '
        Me.btnDiscountDelete.BorderRadius = 5
        Me.btnDiscountDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscountDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscountDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDiscountDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDiscountDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnDiscountDelete.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscountDelete.ForeColor = System.Drawing.Color.White
        Me.btnDiscountDelete.Location = New System.Drawing.Point(698, 589)
        Me.btnDiscountDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDiscountDelete.Name = "btnDiscountDelete"
        Me.btnDiscountDelete.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDiscountDelete.Size = New System.Drawing.Size(115, 42)
        Me.btnDiscountDelete.TabIndex = 53
        Me.btnDiscountDelete.Text = "DELETE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(296, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(585, 51)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "DISCOUNT MANAGEMENT"
        '
        'txtCategoryDescription
        '
        Me.txtCategoryDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategoryDescription.DefaultText = ""
        Me.txtCategoryDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCategoryDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCategoryDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategoryDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategoryDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategoryDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCategoryDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategoryDescription.Location = New System.Drawing.Point(555, 208)
        Me.txtCategoryDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCategoryDescription.Name = "txtCategoryDescription"
        Me.txtCategoryDescription.PlaceholderText = ""
        Me.txtCategoryDescription.SelectedText = ""
        Me.txtCategoryDescription.Size = New System.Drawing.Size(267, 36)
        Me.txtCategoryDescription.TabIndex = 53
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategoryName.DefaultText = ""
        Me.txtCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategoryName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategoryName.Location = New System.Drawing.Point(555, 155)
        Me.txtCategoryName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.PlaceholderText = ""
        Me.txtCategoryName.SelectedText = ""
        Me.txtCategoryName.Size = New System.Drawing.Size(267, 36)
        Me.txtCategoryName.TabIndex = 54
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(333, 212)
        Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(210, 27)
        Me.Guna2HtmlLabel7.TabIndex = 51
        Me.Guna2HtmlLabel7.Text = "Discount Percentage:"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(337, 159)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(149, 27)
        Me.Guna2HtmlLabel8.TabIndex = 52
        Me.Guna2HtmlLabel8.Text = "Discount Type:"
        '
        'dgvDiscount
        '
        Me.dgvDiscount.AllowUserToAddRows = False
        Me.dgvDiscount.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvDiscount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDiscount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDiscount.ColumnHeadersHeight = 4
        Me.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDiscount.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDiscount.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDiscount.Location = New System.Drawing.Point(90, 279)
        Me.dgvDiscount.Name = "dgvDiscount"
        Me.dgvDiscount.ReadOnly = True
        Me.dgvDiscount.RowHeadersVisible = False
        Me.dgvDiscount.RowHeadersWidth = 51
        Me.dgvDiscount.RowTemplate.Height = 24
        Me.dgvDiscount.Size = New System.Drawing.Size(998, 284)
        Me.dgvDiscount.TabIndex = 57
        Me.dgvDiscount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDiscount.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDiscount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDiscount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDiscount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDiscount.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvDiscount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDiscount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDiscount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDiscount.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDiscount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDiscount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDiscount.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvDiscount.ThemeStyle.ReadOnly = True
        Me.dgvDiscount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDiscount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDiscount.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDiscount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvDiscount.ThemeStyle.RowsStyle.Height = 24
        Me.dgvDiscount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDiscount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'UCDiscountM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.dgvDiscount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCategoryDescription)
        Me.Controls.Add(Me.txtCategoryName)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.btnDiscountEdit)
        Me.Controls.Add(Me.btnDiscountAdd)
        Me.Controls.Add(Me.btnDiscountDelete)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCDiscountM"
        Me.Size = New System.Drawing.Size(1178, 644)
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnDiscountEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDiscountAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDiscountDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCategoryDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCategoryName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvDiscount As Guna.UI2.WinForms.Guna2DataGridView
End Class
