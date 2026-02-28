<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCProductM
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
        Me.rbProductWithoutExpiration = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbWithExpiration = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbProductCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvProduct = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtProductSellingPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProductBarcodeNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProductItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnP_Add = New Guna.UI2.WinForms.Guna2Button()
        Me.btnP_Edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnP_Delete = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbProductWithoutExpiration
        '
        Me.rbProductWithoutExpiration.AutoSize = True
        Me.rbProductWithoutExpiration.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbProductWithoutExpiration.CheckedState.BorderThickness = 0
        Me.rbProductWithoutExpiration.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbProductWithoutExpiration.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbProductWithoutExpiration.CheckedState.InnerOffset = -4
        Me.rbProductWithoutExpiration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProductWithoutExpiration.Location = New System.Drawing.Point(376, 234)
        Me.rbProductWithoutExpiration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbProductWithoutExpiration.Name = "rbProductWithoutExpiration"
        Me.rbProductWithoutExpiration.Size = New System.Drawing.Size(209, 29)
        Me.rbProductWithoutExpiration.TabIndex = 42
        Me.rbProductWithoutExpiration.Text = "Without Expiration"
        Me.rbProductWithoutExpiration.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbProductWithoutExpiration.UncheckedState.BorderThickness = 2
        Me.rbProductWithoutExpiration.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbProductWithoutExpiration.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbWithExpiration
        '
        Me.rbWithExpiration.AutoSize = True
        Me.rbWithExpiration.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbWithExpiration.CheckedState.BorderThickness = 0
        Me.rbWithExpiration.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbWithExpiration.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbWithExpiration.CheckedState.InnerOffset = -4
        Me.rbWithExpiration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWithExpiration.Location = New System.Drawing.Point(169, 234)
        Me.rbWithExpiration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbWithExpiration.Name = "rbWithExpiration"
        Me.rbWithExpiration.Size = New System.Drawing.Size(179, 29)
        Me.rbWithExpiration.TabIndex = 43
        Me.rbWithExpiration.Text = "With Expiration"
        Me.rbWithExpiration.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbWithExpiration.UncheckedState.BorderThickness = 2
        Me.rbWithExpiration.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbWithExpiration.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(597, 191)
        Me.Guna2HtmlLabel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(131, 27)
        Me.Guna2HtmlLabel10.TabIndex = 40
        Me.Guna2HtmlLabel10.Text = "Selling Price:"
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(169, 191)
        Me.Guna2HtmlLabel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(123, 27)
        Me.Guna2HtmlLabel11.TabIndex = 41
        Me.Guna2HtmlLabel11.Text = "Barcode No:"
        '
        'cmbProductCategory
        '
        Me.cmbProductCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbProductCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProductCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProductCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbProductCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbProductCategory.ItemHeight = 30
        Me.cmbProductCategory.Location = New System.Drawing.Point(753, 138)
        Me.cmbProductCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbProductCategory.Name = "cmbProductCategory"
        Me.cmbProductCategory.Size = New System.Drawing.Size(223, 36)
        Me.cmbProductCategory.TabIndex = 38
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvProduct.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProduct.ColumnHeadersHeight = 4
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduct.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProduct.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProduct.Location = New System.Drawing.Point(75, 308)
        Me.dgvProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersVisible = False
        Me.dgvProduct.RowHeadersWidth = 51
        Me.dgvProduct.RowTemplate.Height = 24
        Me.dgvProduct.Size = New System.Drawing.Size(998, 302)
        Me.dgvProduct.TabIndex = 1
        Me.dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvProduct.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProduct.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvProduct.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvProduct.ThemeStyle.ReadOnly = True
        Me.dgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProduct.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvProduct.ThemeStyle.RowsStyle.Height = 24
        Me.dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtProductSellingPrice
        '
        Me.txtProductSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductSellingPrice.DefaultText = ""
        Me.txtProductSellingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductSellingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductSellingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductSellingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductSellingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductSellingPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProductSellingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductSellingPrice.Location = New System.Drawing.Point(752, 188)
        Me.txtProductSellingPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductSellingPrice.Name = "txtProductSellingPrice"
        Me.txtProductSellingPrice.PlaceholderText = ""
        Me.txtProductSellingPrice.SelectedText = ""
        Me.txtProductSellingPrice.Size = New System.Drawing.Size(221, 30)
        Me.txtProductSellingPrice.TabIndex = 33
        '
        'txtProductBarcodeNo
        '
        Me.txtProductBarcodeNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductBarcodeNo.DefaultText = ""
        Me.txtProductBarcodeNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductBarcodeNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductBarcodeNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductBarcodeNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductBarcodeNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductBarcodeNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProductBarcodeNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductBarcodeNo.Location = New System.Drawing.Point(324, 189)
        Me.txtProductBarcodeNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductBarcodeNo.Name = "txtProductBarcodeNo"
        Me.txtProductBarcodeNo.PlaceholderText = ""
        Me.txtProductBarcodeNo.SelectedText = ""
        Me.txtProductBarcodeNo.Size = New System.Drawing.Size(221, 30)
        Me.txtProductBarcodeNo.TabIndex = 35
        '
        'txtProductItemName
        '
        Me.txtProductItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductItemName.DefaultText = ""
        Me.txtProductItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProductItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductItemName.Location = New System.Drawing.Point(324, 145)
        Me.txtProductItemName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductItemName.Name = "txtProductItemName"
        Me.txtProductItemName.PlaceholderText = ""
        Me.txtProductItemName.SelectedText = ""
        Me.txtProductItemName.Size = New System.Drawing.Size(221, 30)
        Me.txtProductItemName.TabIndex = 36
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(597, 145)
        Me.Guna2HtmlLabel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(98, 27)
        Me.Guna2HtmlLabel12.TabIndex = 31
        Me.Guna2HtmlLabel12.Text = "Category:"
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(169, 145)
        Me.Guna2HtmlLabel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(113, 27)
        Me.Guna2HtmlLabel13.TabIndex = 32
        Me.Guna2HtmlLabel13.Text = "Item Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(303, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(572, 51)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "PRODUCT MANAGEMENT"
        '
        'btnP_Add
        '
        Me.btnP_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnP_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnP_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnP_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnP_Add.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnP_Add.ForeColor = System.Drawing.Color.White
        Me.btnP_Add.Location = New System.Drawing.Point(640, 247)
        Me.btnP_Add.Name = "btnP_Add"
        Me.btnP_Add.Size = New System.Drawing.Size(113, 36)
        Me.btnP_Add.TabIndex = 46
        Me.btnP_Add.Text = "Add"
        '
        'btnP_Edit
        '
        Me.btnP_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnP_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnP_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnP_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnP_Edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnP_Edit.ForeColor = System.Drawing.Color.White
        Me.btnP_Edit.Location = New System.Drawing.Point(786, 247)
        Me.btnP_Edit.Name = "btnP_Edit"
        Me.btnP_Edit.Size = New System.Drawing.Size(113, 36)
        Me.btnP_Edit.TabIndex = 47
        Me.btnP_Edit.Text = "Edit"
        '
        'btnP_Delete
        '
        Me.btnP_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnP_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnP_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnP_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnP_Delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnP_Delete.ForeColor = System.Drawing.Color.White
        Me.btnP_Delete.Location = New System.Drawing.Point(927, 247)
        Me.btnP_Delete.Name = "btnP_Delete"
        Me.btnP_Delete.Size = New System.Drawing.Size(113, 36)
        Me.btnP_Delete.TabIndex = 48
        Me.btnP_Delete.Text = "Delete"
        '
        'UCProductM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.btnP_Delete)
        Me.Controls.Add(Me.btnP_Edit)
        Me.Controls.Add(Me.btnP_Add)
        Me.Controls.Add(Me.dgvProduct)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbProductWithoutExpiration)
        Me.Controls.Add(Me.rbWithExpiration)
        Me.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Controls.Add(Me.cmbProductCategory)
        Me.Controls.Add(Me.txtProductSellingPrice)
        Me.Controls.Add(Me.txtProductBarcodeNo)
        Me.Controls.Add(Me.txtProductItemName)
        Me.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Controls.Add(Me.Guna2HtmlLabel13)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCProductM"
        Me.Size = New System.Drawing.Size(1178, 644)
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbProductWithoutExpiration As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbWithExpiration As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbProductCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dgvProduct As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtProductSellingPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProductBarcodeNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProductItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnP_Add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnP_Edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnP_Delete As Guna.UI2.WinForms.Guna2Button
End Class
