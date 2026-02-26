<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDelivery
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbDH_Supplier = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpDH_DeliveryDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel30 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnDH_DeliveryProceed = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel31 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDH_TransactionNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDH_DeliveryClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel32 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlDH = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtDD_ItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDD_Barcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtpDD_ExpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtDD_Quantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDD_CostPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDD_Description = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel43 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel42 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel41 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvDeliveryDetail = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnDD_Add = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDD_Edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDD_Delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDD_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDT_SupplierName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDt_TransactionNo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDT_DeliveryDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlDH.SuspendLayout()
        CType(Me.dgvDeliveryDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbDH_Supplier
        '
        Me.cmbDH_Supplier.BackColor = System.Drawing.Color.Transparent
        Me.cmbDH_Supplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDH_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDH_Supplier.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDH_Supplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDH_Supplier.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDH_Supplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDH_Supplier.ItemHeight = 30
        Me.cmbDH_Supplier.Location = New System.Drawing.Point(200, 41)
        Me.cmbDH_Supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDH_Supplier.Name = "cmbDH_Supplier"
        Me.cmbDH_Supplier.Size = New System.Drawing.Size(265, 36)
        Me.cmbDH_Supplier.TabIndex = 17
        '
        'dtpDH_DeliveryDate
        '
        Me.dtpDH_DeliveryDate.Checked = True
        Me.dtpDH_DeliveryDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDH_DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDH_DeliveryDate.Location = New System.Drawing.Point(200, 176)
        Me.dtpDH_DeliveryDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDH_DeliveryDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDH_DeliveryDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDH_DeliveryDate.Name = "dtpDH_DeliveryDate"
        Me.dtpDH_DeliveryDate.Size = New System.Drawing.Size(267, 44)
        Me.dtpDH_DeliveryDate.TabIndex = 16
        Me.dtpDH_DeliveryDate.Value = New Date(2026, 2, 17, 7, 55, 16, 244)
        '
        'Guna2HtmlLabel30
        '
        Me.Guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel30.Location = New System.Drawing.Point(11, 48)
        Me.Guna2HtmlLabel30.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel30.Name = "Guna2HtmlLabel30"
        Me.Guna2HtmlLabel30.Size = New System.Drawing.Size(145, 27)
        Me.Guna2HtmlLabel30.TabIndex = 10
        Me.Guna2HtmlLabel30.Text = "Supplier Name"
        '
        'btnDH_DeliveryProceed
        '
        Me.btnDH_DeliveryProceed.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDH_DeliveryProceed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDH_DeliveryProceed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDH_DeliveryProceed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDH_DeliveryProceed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDH_DeliveryProceed.ForeColor = System.Drawing.Color.White
        Me.btnDH_DeliveryProceed.Location = New System.Drawing.Point(264, 271)
        Me.btnDH_DeliveryProceed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDH_DeliveryProceed.Name = "btnDH_DeliveryProceed"
        Me.btnDH_DeliveryProceed.Size = New System.Drawing.Size(163, 47)
        Me.btnDH_DeliveryProceed.TabIndex = 15
        Me.btnDH_DeliveryProceed.Text = "Proceed"
        '
        'Guna2HtmlLabel31
        '
        Me.Guna2HtmlLabel31.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel31.Location = New System.Drawing.Point(11, 116)
        Me.Guna2HtmlLabel31.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel31.Name = "Guna2HtmlLabel31"
        Me.Guna2HtmlLabel31.Size = New System.Drawing.Size(156, 27)
        Me.Guna2HtmlLabel31.TabIndex = 11
        Me.Guna2HtmlLabel31.Text = "Transaction No."
        '
        'txtDH_TransactionNo
        '
        Me.txtDH_TransactionNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDH_TransactionNo.DefaultText = ""
        Me.txtDH_TransactionNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDH_TransactionNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDH_TransactionNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDH_TransactionNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDH_TransactionNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDH_TransactionNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDH_TransactionNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDH_TransactionNo.Location = New System.Drawing.Point(200, 107)
        Me.txtDH_TransactionNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDH_TransactionNo.Name = "txtDH_TransactionNo"
        Me.txtDH_TransactionNo.PlaceholderText = ""
        Me.txtDH_TransactionNo.SelectedText = ""
        Me.txtDH_TransactionNo.Size = New System.Drawing.Size(267, 44)
        Me.txtDH_TransactionNo.TabIndex = 13
        '
        'btnDH_DeliveryClear
        '
        Me.btnDH_DeliveryClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDH_DeliveryClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDH_DeliveryClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDH_DeliveryClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDH_DeliveryClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDH_DeliveryClear.ForeColor = System.Drawing.Color.White
        Me.btnDH_DeliveryClear.Location = New System.Drawing.Point(45, 271)
        Me.btnDH_DeliveryClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDH_DeliveryClear.Name = "btnDH_DeliveryClear"
        Me.btnDH_DeliveryClear.Size = New System.Drawing.Size(163, 47)
        Me.btnDH_DeliveryClear.TabIndex = 14
        Me.btnDH_DeliveryClear.Text = "Clear"
        '
        'Guna2HtmlLabel32
        '
        Me.Guna2HtmlLabel32.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel32.Location = New System.Drawing.Point(11, 185)
        Me.Guna2HtmlLabel32.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel32.Name = "Guna2HtmlLabel32"
        Me.Guna2HtmlLabel32.Size = New System.Drawing.Size(132, 27)
        Me.Guna2HtmlLabel32.TabIndex = 12
        Me.Guna2HtmlLabel32.Text = "Delivery Date"
        '
        'pnlDH
        '
        Me.pnlDH.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlDH.Controls.Add(Me.dtpDH_DeliveryDate)
        Me.pnlDH.Controls.Add(Me.cmbDH_Supplier)
        Me.pnlDH.Controls.Add(Me.Guna2HtmlLabel32)
        Me.pnlDH.Controls.Add(Me.btnDH_DeliveryClear)
        Me.pnlDH.Controls.Add(Me.Guna2HtmlLabel30)
        Me.pnlDH.Controls.Add(Me.txtDH_TransactionNo)
        Me.pnlDH.Controls.Add(Me.btnDH_DeliveryProceed)
        Me.pnlDH.Controls.Add(Me.Guna2HtmlLabel31)
        Me.pnlDH.Location = New System.Drawing.Point(60, 19)
        Me.pnlDH.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDH.Name = "pnlDH"
        Me.pnlDH.Size = New System.Drawing.Size(471, 347)
        Me.pnlDH.TabIndex = 18
        '
        'txtDD_ItemName
        '
        Me.txtDD_ItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDD_ItemName.DefaultText = ""
        Me.txtDD_ItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDD_ItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDD_ItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_ItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_ItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_ItemName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDD_ItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_ItemName.Location = New System.Drawing.Point(259, 262)
        Me.txtDD_ItemName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDD_ItemName.Name = "txtDD_ItemName"
        Me.txtDD_ItemName.PlaceholderText = ""
        Me.txtDD_ItemName.SelectedText = ""
        Me.txtDD_ItemName.Size = New System.Drawing.Size(272, 27)
        Me.txtDD_ItemName.TabIndex = 23
        '
        'txtDD_Barcode
        '
        Me.txtDD_Barcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDD_Barcode.DefaultText = ""
        Me.txtDD_Barcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDD_Barcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDD_Barcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_Barcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_Barcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_Barcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDD_Barcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_Barcode.Location = New System.Drawing.Point(259, 206)
        Me.txtDD_Barcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDD_Barcode.Name = "txtDD_Barcode"
        Me.txtDD_Barcode.PlaceholderText = ""
        Me.txtDD_Barcode.SelectedText = ""
        Me.txtDD_Barcode.Size = New System.Drawing.Size(272, 27)
        Me.txtDD_Barcode.TabIndex = 22
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(68, 262)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(106, 27)
        Me.Guna2HtmlLabel2.TabIndex = 20
        Me.Guna2HtmlLabel2.Text = "Item Name"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(68, 206)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(101, 27)
        Me.Guna2HtmlLabel1.TabIndex = 19
        Me.Guna2HtmlLabel1.Text = "Barcode #"
        '
        'dtpDD_ExpDate
        '
        Me.dtpDD_ExpDate.Checked = True
        Me.dtpDD_ExpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDD_ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDD_ExpDate.Location = New System.Drawing.Point(784, 141)
        Me.dtpDD_ExpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDD_ExpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDD_ExpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDD_ExpDate.Name = "dtpDD_ExpDate"
        Me.dtpDD_ExpDate.Size = New System.Drawing.Size(272, 44)
        Me.dtpDD_ExpDate.TabIndex = 38
        Me.dtpDD_ExpDate.Value = New Date(2026, 2, 17, 7, 55, 16, 244)
        '
        'txtDD_Quantity
        '
        Me.txtDD_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDD_Quantity.DefaultText = ""
        Me.txtDD_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDD_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDD_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_Quantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDD_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_Quantity.Location = New System.Drawing.Point(784, 205)
        Me.txtDD_Quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDD_Quantity.Name = "txtDD_Quantity"
        Me.txtDD_Quantity.PlaceholderText = ""
        Me.txtDD_Quantity.SelectedText = ""
        Me.txtDD_Quantity.Size = New System.Drawing.Size(272, 27)
        Me.txtDD_Quantity.TabIndex = 37
        '
        'txtDD_CostPrice
        '
        Me.txtDD_CostPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDD_CostPrice.DefaultText = ""
        Me.txtDD_CostPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDD_CostPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDD_CostPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_CostPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_CostPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_CostPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDD_CostPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_CostPrice.Location = New System.Drawing.Point(784, 92)
        Me.txtDD_CostPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDD_CostPrice.Name = "txtDD_CostPrice"
        Me.txtDD_CostPrice.PlaceholderText = ""
        Me.txtDD_CostPrice.SelectedText = ""
        Me.txtDD_CostPrice.Size = New System.Drawing.Size(272, 27)
        Me.txtDD_CostPrice.TabIndex = 36
        '
        'txtDD_Description
        '
        Me.txtDD_Description.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDD_Description.DefaultText = ""
        Me.txtDD_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDD_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDD_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDD_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_Description.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDD_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDD_Description.Location = New System.Drawing.Point(784, 36)
        Me.txtDD_Description.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDD_Description.Name = "txtDD_Description"
        Me.txtDD_Description.PlaceholderText = ""
        Me.txtDD_Description.SelectedText = ""
        Me.txtDD_Description.Size = New System.Drawing.Size(272, 27)
        Me.txtDD_Description.TabIndex = 34
        '
        'Guna2HtmlLabel43
        '
        Me.Guna2HtmlLabel43.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel43.Location = New System.Drawing.Point(625, 205)
        Me.Guna2HtmlLabel43.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel43.Name = "Guna2HtmlLabel43"
        Me.Guna2HtmlLabel43.Size = New System.Drawing.Size(84, 27)
        Me.Guna2HtmlLabel43.TabIndex = 33
        Me.Guna2HtmlLabel43.Text = "Quantity"
        '
        'Guna2HtmlLabel42
        '
        Me.Guna2HtmlLabel42.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel42.Location = New System.Drawing.Point(625, 149)
        Me.Guna2HtmlLabel42.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel42.Name = "Guna2HtmlLabel42"
        Me.Guna2HtmlLabel42.Size = New System.Drawing.Size(91, 27)
        Me.Guna2HtmlLabel42.TabIndex = 32
        Me.Guna2HtmlLabel42.Text = "Exp Date"
        '
        'Guna2HtmlLabel41
        '
        Me.Guna2HtmlLabel41.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel41.Location = New System.Drawing.Point(625, 92)
        Me.Guna2HtmlLabel41.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel41.Name = "Guna2HtmlLabel41"
        Me.Guna2HtmlLabel41.Size = New System.Drawing.Size(103, 27)
        Me.Guna2HtmlLabel41.TabIndex = 31
        Me.Guna2HtmlLabel41.Text = "Cost Price"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(625, 36)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(111, 27)
        Me.Guna2HtmlLabel4.TabIndex = 29
        Me.Guna2HtmlLabel4.Text = "Description"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(68, 149)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(132, 27)
        Me.Guna2HtmlLabel6.TabIndex = 39
        Me.Guna2HtmlLabel6.Text = "Delivery Date"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(68, 92)
        Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(156, 27)
        Me.Guna2HtmlLabel7.TabIndex = 40
        Me.Guna2HtmlLabel7.Text = "Transaction No."
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(68, 36)
        Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(145, 27)
        Me.Guna2HtmlLabel8.TabIndex = 41
        Me.Guna2HtmlLabel8.Text = "Supplier Name"
        '
        'dgvDeliveryDetail
        '
        Me.dgvDeliveryDetail.AllowUserToAddRows = False
        Me.dgvDeliveryDetail.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvDeliveryDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDeliveryDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDeliveryDetail.ColumnHeadersHeight = 28
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDeliveryDetail.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDeliveryDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDeliveryDetail.Location = New System.Drawing.Point(23, 390)
        Me.dgvDeliveryDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDeliveryDetail.Name = "dgvDeliveryDetail"
        Me.dgvDeliveryDetail.ReadOnly = True
        Me.dgvDeliveryDetail.RowHeadersVisible = False
        Me.dgvDeliveryDetail.RowHeadersWidth = 51
        Me.dgvDeliveryDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDeliveryDetail.Size = New System.Drawing.Size(1132, 238)
        Me.dgvDeliveryDetail.TabIndex = 46
        Me.dgvDeliveryDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDeliveryDetail.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDeliveryDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDeliveryDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDeliveryDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDeliveryDetail.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvDeliveryDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDeliveryDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDeliveryDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDeliveryDetail.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDeliveryDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDeliveryDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDeliveryDetail.ThemeStyle.HeaderStyle.Height = 28
        Me.dgvDeliveryDetail.ThemeStyle.ReadOnly = True
        Me.dgvDeliveryDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDeliveryDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDeliveryDetail.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDeliveryDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvDeliveryDetail.ThemeStyle.RowsStyle.Height = 22
        Me.dgvDeliveryDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDeliveryDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnDD_Add
        '
        Me.btnDD_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDD_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDD_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDD_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDD_Add.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDD_Add.ForeColor = System.Drawing.Color.White
        Me.btnDD_Add.Location = New System.Drawing.Point(587, 319)
        Me.btnDD_Add.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDD_Add.Name = "btnDD_Add"
        Me.btnDD_Add.Size = New System.Drawing.Size(128, 47)
        Me.btnDD_Add.TabIndex = 47
        Me.btnDD_Add.Text = "Add"
        '
        'btnDD_Edit
        '
        Me.btnDD_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDD_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDD_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDD_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDD_Edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDD_Edit.ForeColor = System.Drawing.Color.White
        Me.btnDD_Edit.Location = New System.Drawing.Point(723, 319)
        Me.btnDD_Edit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDD_Edit.Name = "btnDD_Edit"
        Me.btnDD_Edit.Size = New System.Drawing.Size(128, 47)
        Me.btnDD_Edit.TabIndex = 48
        Me.btnDD_Edit.Text = "Edit"
        '
        'btnDD_Delete
        '
        Me.btnDD_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDD_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDD_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDD_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDD_Delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDD_Delete.ForeColor = System.Drawing.Color.White
        Me.btnDD_Delete.Location = New System.Drawing.Point(859, 319)
        Me.btnDD_Delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDD_Delete.Name = "btnDD_Delete"
        Me.btnDD_Delete.Size = New System.Drawing.Size(128, 47)
        Me.btnDD_Delete.TabIndex = 49
        Me.btnDD_Delete.Text = "Delete"
        '
        'btnDD_Save
        '
        Me.btnDD_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDD_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDD_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDD_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDD_Save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDD_Save.ForeColor = System.Drawing.Color.White
        Me.btnDD_Save.Location = New System.Drawing.Point(993, 319)
        Me.btnDD_Save.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDD_Save.Name = "btnDD_Save"
        Me.btnDD_Save.Size = New System.Drawing.Size(128, 47)
        Me.btnDD_Save.TabIndex = 50
        Me.btnDD_Save.Text = "Save"
        '
        'lblDT_SupplierName
        '
        Me.lblDT_SupplierName.BackColor = System.Drawing.Color.Transparent
        Me.lblDT_SupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDT_SupplierName.Location = New System.Drawing.Point(259, 36)
        Me.lblDT_SupplierName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDT_SupplierName.Name = "lblDT_SupplierName"
        Me.lblDT_SupplierName.Size = New System.Drawing.Size(145, 27)
        Me.lblDT_SupplierName.TabIndex = 54
        Me.lblDT_SupplierName.Text = "Supplier Name"
        '
        'lblDt_TransactionNo
        '
        Me.lblDt_TransactionNo.BackColor = System.Drawing.Color.Transparent
        Me.lblDt_TransactionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDt_TransactionNo.Location = New System.Drawing.Point(259, 92)
        Me.lblDt_TransactionNo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDt_TransactionNo.Name = "lblDt_TransactionNo"
        Me.lblDt_TransactionNo.Size = New System.Drawing.Size(145, 27)
        Me.lblDt_TransactionNo.TabIndex = 55
        Me.lblDt_TransactionNo.Text = "Supplier Name"
        '
        'lblDT_DeliveryDate
        '
        Me.lblDT_DeliveryDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDT_DeliveryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDT_DeliveryDate.Location = New System.Drawing.Point(259, 149)
        Me.lblDT_DeliveryDate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDT_DeliveryDate.Name = "lblDT_DeliveryDate"
        Me.lblDT_DeliveryDate.Size = New System.Drawing.Size(145, 27)
        Me.lblDT_DeliveryDate.TabIndex = 56
        Me.lblDT_DeliveryDate.Text = "Supplier Name"
        '
        'UCDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.pnlDH)
        Me.Controls.Add(Me.lblDT_SupplierName)
        Me.Controls.Add(Me.lblDt_TransactionNo)
        Me.Controls.Add(Me.lblDT_DeliveryDate)
        Me.Controls.Add(Me.btnDD_Save)
        Me.Controls.Add(Me.btnDD_Delete)
        Me.Controls.Add(Me.btnDD_Edit)
        Me.Controls.Add(Me.btnDD_Add)
        Me.Controls.Add(Me.dgvDeliveryDetail)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.dtpDD_ExpDate)
        Me.Controls.Add(Me.txtDD_Quantity)
        Me.Controls.Add(Me.txtDD_CostPrice)
        Me.Controls.Add(Me.txtDD_Description)
        Me.Controls.Add(Me.Guna2HtmlLabel43)
        Me.Controls.Add(Me.Guna2HtmlLabel42)
        Me.Controls.Add(Me.Guna2HtmlLabel41)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.txtDD_ItemName)
        Me.Controls.Add(Me.txtDD_Barcode)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCDelivery"
        Me.Size = New System.Drawing.Size(1179, 644)
        Me.pnlDH.ResumeLayout(False)
        Me.pnlDH.PerformLayout()
        CType(Me.dgvDeliveryDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbDH_Supplier As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpDH_DeliveryDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel30 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDH_DeliveryProceed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel31 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDH_TransactionNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDH_DeliveryClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel32 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlDH As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtDD_ItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDD_Barcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtpDD_ExpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtDD_Quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDD_CostPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDD_Description As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel43 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel42 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel41 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvDeliveryDetail As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnDD_Add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDD_Edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDD_Delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDD_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDT_SupplierName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDt_TransactionNo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDT_DeliveryDate As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
