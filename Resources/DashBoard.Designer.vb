<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelSideBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAccountReg = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelMaintenance = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDiscountM = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVATM = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSupplierM = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProductM = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCategoryM = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaintenance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPOS = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelInventory = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnStocks = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelivery = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelDashB = New Guna.UI2.WinForms.Guna2Panel()
        Me.UcAccountReg1 = New MCCHSIS.UCAccountReg()
        Me.Ucpos1 = New MCCHSIS.UCPOS()
        Me.UcDelivery1 = New MCCHSIS.UCDelivery()
        Me.Ucvatm1 = New MCCHSIS.UCVATM()
        Me.UcSupplierM1 = New MCCHSIS.UCSupplierM()
        Me.UcStocks1 = New MCCHSIS.UCStocks()
        Me.UcProductM1 = New MCCHSIS.UCProductM()
        Me.UcCategoryM1 = New MCCHSIS.UCCategoryM()
        Me.UcDiscountM1 = New MCCHSIS.UCDiscountM()
        Me.Guna2Panel1.SuspendLayout()
        Me.PanelSideBar.SuspendLayout()
        Me.PanelMaintenance.SuspendLayout()
        Me.PanelInventory.SuspendLayout()
        Me.PanelDashB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(453, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(561, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SALES AND INVENTORY SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1445, 108)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FillColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Location = New System.Drawing.Point(0, 0)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(246, 69)
        Me.btnInventory.TabIndex = 0
        Me.btnInventory.Text = "Inventory"
        '
        'PanelSideBar
        '
        Me.PanelSideBar.AutoScroll = True
        Me.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.btnAccountReg)
        Me.PanelSideBar.Controls.Add(Me.PanelMaintenance)
        Me.PanelSideBar.Controls.Add(Me.btnMaintenance)
        Me.PanelSideBar.Controls.Add(Me.btnPOS)
        Me.PanelSideBar.Controls.Add(Me.PanelInventory)
        Me.PanelSideBar.Controls.Add(Me.btnInventory)
        Me.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideBar.Location = New System.Drawing.Point(0, 108)
        Me.PanelSideBar.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(267, 644)
        Me.PanelSideBar.TabIndex = 1
        '
        'btnAccountReg
        '
        Me.btnAccountReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAccountReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAccountReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAccountReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAccountReg.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccountReg.FillColor = System.Drawing.Color.DimGray
        Me.btnAccountReg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAccountReg.ForeColor = System.Drawing.Color.White
        Me.btnAccountReg.Location = New System.Drawing.Point(0, 676)
        Me.btnAccountReg.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAccountReg.Name = "btnAccountReg"
        Me.btnAccountReg.Size = New System.Drawing.Size(246, 68)
        Me.btnAccountReg.TabIndex = 7
        Me.btnAccountReg.Text = "Account Registration"
        '
        'PanelMaintenance
        '
        Me.PanelMaintenance.BackColor = System.Drawing.Color.White
        Me.PanelMaintenance.Controls.Add(Me.btnDiscountM)
        Me.PanelMaintenance.Controls.Add(Me.btnVATM)
        Me.PanelMaintenance.Controls.Add(Me.btnSupplierM)
        Me.PanelMaintenance.Controls.Add(Me.btnProductM)
        Me.PanelMaintenance.Controls.Add(Me.btnCategoryM)
        Me.PanelMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMaintenance.Location = New System.Drawing.Point(0, 342)
        Me.PanelMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMaintenance.Name = "PanelMaintenance"
        Me.PanelMaintenance.Size = New System.Drawing.Size(246, 334)
        Me.PanelMaintenance.TabIndex = 5
        '
        'btnDiscountM
        '
        Me.btnDiscountM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscountM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscountM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDiscountM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDiscountM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDiscountM.FillColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnDiscountM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDiscountM.ForeColor = System.Drawing.Color.White
        Me.btnDiscountM.Location = New System.Drawing.Point(0, 272)
        Me.btnDiscountM.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDiscountM.Name = "btnDiscountM"
        Me.btnDiscountM.Size = New System.Drawing.Size(246, 68)
        Me.btnDiscountM.TabIndex = 6
        Me.btnDiscountM.Text = "Discount Management"
        '
        'btnVATM
        '
        Me.btnVATM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVATM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVATM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVATM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVATM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVATM.FillColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnVATM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnVATM.ForeColor = System.Drawing.Color.White
        Me.btnVATM.Location = New System.Drawing.Point(0, 204)
        Me.btnVATM.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVATM.Name = "btnVATM"
        Me.btnVATM.Size = New System.Drawing.Size(246, 68)
        Me.btnVATM.TabIndex = 5
        Me.btnVATM.Text = "Vat Management"
        '
        'btnSupplierM
        '
        Me.btnSupplierM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSupplierM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSupplierM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSupplierM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSupplierM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSupplierM.FillColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnSupplierM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSupplierM.ForeColor = System.Drawing.Color.White
        Me.btnSupplierM.Location = New System.Drawing.Point(0, 136)
        Me.btnSupplierM.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupplierM.Name = "btnSupplierM"
        Me.btnSupplierM.Size = New System.Drawing.Size(246, 68)
        Me.btnSupplierM.TabIndex = 4
        Me.btnSupplierM.Text = "Supplier Management"
        '
        'btnProductM
        '
        Me.btnProductM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnProductM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnProductM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProductM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProductM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductM.FillColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnProductM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProductM.ForeColor = System.Drawing.Color.White
        Me.btnProductM.Location = New System.Drawing.Point(0, 68)
        Me.btnProductM.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProductM.Name = "btnProductM"
        Me.btnProductM.Size = New System.Drawing.Size(246, 68)
        Me.btnProductM.TabIndex = 3
        Me.btnProductM.Text = "Product Management"
        '
        'btnCategoryM
        '
        Me.btnCategoryM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCategoryM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCategoryM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCategoryM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCategoryM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCategoryM.FillColor = System.Drawing.Color.DimGray
        Me.btnCategoryM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCategoryM.ForeColor = System.Drawing.Color.White
        Me.btnCategoryM.Location = New System.Drawing.Point(0, 0)
        Me.btnCategoryM.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCategoryM.Name = "btnCategoryM"
        Me.btnCategoryM.Size = New System.Drawing.Size(246, 68)
        Me.btnCategoryM.TabIndex = 2
        Me.btnCategoryM.Text = "Category Management"
        '
        'btnMaintenance
        '
        Me.btnMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMaintenance.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnMaintenance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMaintenance.ForeColor = System.Drawing.Color.White
        Me.btnMaintenance.Location = New System.Drawing.Point(0, 273)
        Me.btnMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(246, 69)
        Me.btnMaintenance.TabIndex = 4
        Me.btnMaintenance.Text = "Maintenance"
        '
        'btnPOS
        '
        Me.btnPOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPOS.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPOS.FillColor = System.Drawing.Color.DimGray
        Me.btnPOS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPOS.ForeColor = System.Drawing.Color.White
        Me.btnPOS.Location = New System.Drawing.Point(0, 204)
        Me.btnPOS.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.Size = New System.Drawing.Size(246, 69)
        Me.btnPOS.TabIndex = 2
        Me.btnPOS.Text = "POS"
        '
        'PanelInventory
        '
        Me.PanelInventory.Controls.Add(Me.btnStocks)
        Me.PanelInventory.Controls.Add(Me.btnDelivery)
        Me.PanelInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInventory.Location = New System.Drawing.Point(0, 69)
        Me.PanelInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelInventory.Name = "PanelInventory"
        Me.PanelInventory.Size = New System.Drawing.Size(246, 135)
        Me.PanelInventory.TabIndex = 1
        '
        'btnStocks
        '
        Me.btnStocks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStocks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStocks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStocks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStocks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStocks.FillColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnStocks.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStocks.ForeColor = System.Drawing.Color.White
        Me.btnStocks.Location = New System.Drawing.Point(0, 68)
        Me.btnStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Size = New System.Drawing.Size(246, 68)
        Me.btnStocks.TabIndex = 2
        Me.btnStocks.Text = "Stocks"
        '
        'btnDelivery
        '
        Me.btnDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelivery.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelivery.FillColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnDelivery.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelivery.ForeColor = System.Drawing.Color.White
        Me.btnDelivery.Location = New System.Drawing.Point(0, 0)
        Me.btnDelivery.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(246, 68)
        Me.btnDelivery.TabIndex = 1
        Me.btnDelivery.Text = "Delivery"
        '
        'PanelDashB
        '
        Me.PanelDashB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelDashB.BackColor = System.Drawing.SystemColors.Control
        Me.PanelDashB.Controls.Add(Me.Ucpos1)
        Me.PanelDashB.Controls.Add(Me.UcDelivery1)
        Me.PanelDashB.Controls.Add(Me.Ucvatm1)
        Me.PanelDashB.Controls.Add(Me.UcSupplierM1)
        Me.PanelDashB.Controls.Add(Me.UcStocks1)
        Me.PanelDashB.Controls.Add(Me.UcProductM1)
        Me.PanelDashB.Controls.Add(Me.UcCategoryM1)
        Me.PanelDashB.Controls.Add(Me.UcDiscountM1)
        Me.PanelDashB.Controls.Add(Me.UcAccountReg1)
        Me.PanelDashB.Location = New System.Drawing.Point(267, 108)
        Me.PanelDashB.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDashB.Name = "PanelDashB"
        Me.PanelDashB.Size = New System.Drawing.Size(1178, 644)
        Me.PanelDashB.TabIndex = 2
        '
        'UcAccountReg1
        '
        Me.UcAccountReg1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UcAccountReg1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UcAccountReg1.Location = New System.Drawing.Point(0, 0)
        Me.UcAccountReg1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcAccountReg1.Name = "UcAccountReg1"
        Me.UcAccountReg1.Size = New System.Drawing.Size(1178, 644)
        Me.UcAccountReg1.TabIndex = 7
        '
        'Ucpos1
        '
        Me.Ucpos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Ucpos1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ucpos1.Location = New System.Drawing.Point(0, 0)
        Me.Ucpos1.Margin = New System.Windows.Forms.Padding(5)
        Me.Ucpos1.Name = "Ucpos1"
        Me.Ucpos1.Size = New System.Drawing.Size(1178, 644)
        Me.Ucpos1.TabIndex = 1
        '
        'UcDelivery1
        '
        Me.UcDelivery1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UcDelivery1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UcDelivery1.Location = New System.Drawing.Point(0, 0)
        Me.UcDelivery1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDelivery1.Name = "UcDelivery1"
        Me.UcDelivery1.Size = New System.Drawing.Size(1178, 644)
        Me.UcDelivery1.TabIndex = 0
        '
        'Ucvatm1
        '
        Me.Ucvatm1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ucvatm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Ucvatm1.Location = New System.Drawing.Point(0, 0)
        Me.Ucvatm1.Margin = New System.Windows.Forms.Padding(5)
        Me.Ucvatm1.Name = "Ucvatm1"
        Me.Ucvatm1.Size = New System.Drawing.Size(1178, 644)
        Me.Ucvatm1.TabIndex = 6
        '
        'UcSupplierM1
        '
        Me.UcSupplierM1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UcSupplierM1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UcSupplierM1.Location = New System.Drawing.Point(0, 0)
        Me.UcSupplierM1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcSupplierM1.Name = "UcSupplierM1"
        Me.UcSupplierM1.Size = New System.Drawing.Size(1178, 644)
        Me.UcSupplierM1.TabIndex = 5
        '
        'UcStocks1
        '
        Me.UcStocks1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcStocks1.Location = New System.Drawing.Point(0, 0)
        Me.UcStocks1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcStocks1.Name = "UcStocks1"
        Me.UcStocks1.Size = New System.Drawing.Size(1178, 644)
        Me.UcStocks1.TabIndex = 4
        '
        'UcProductM1
        '
        Me.UcProductM1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UcProductM1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UcProductM1.Location = New System.Drawing.Point(0, 0)
        Me.UcProductM1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcProductM1.Name = "UcProductM1"
        Me.UcProductM1.Size = New System.Drawing.Size(1178, 644)
        Me.UcProductM1.TabIndex = 3
        '
        'UcCategoryM1
        '
        Me.UcCategoryM1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UcCategoryM1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcCategoryM1.Location = New System.Drawing.Point(0, 0)
        Me.UcCategoryM1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCategoryM1.Name = "UcCategoryM1"
        Me.UcCategoryM1.Size = New System.Drawing.Size(1178, 644)
        Me.UcCategoryM1.TabIndex = 2
        '
        'UcDiscountM1
        '
        Me.UcDiscountM1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UcDiscountM1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UcDiscountM1.Location = New System.Drawing.Point(0, 0)
        Me.UcDiscountM1.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDiscountM1.Name = "UcDiscountM1"
        Me.UcDiscountM1.Size = New System.Drawing.Size(1178, 644)
        Me.UcDiscountM1.TabIndex = 8
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1445, 752)
        Me.Controls.Add(Me.PanelDashB)
        Me.Controls.Add(Me.PanelSideBar)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashBoard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.PanelSideBar.ResumeLayout(False)
        Me.PanelMaintenance.ResumeLayout(False)
        Me.PanelInventory.ResumeLayout(False)
        Me.PanelDashB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelSideBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelDashB As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelInventory As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnStocks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelivery As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaintenance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelMaintenance As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCategoryM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAccountReg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDiscountM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVATM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSupplierM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProductM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UcDelivery1 As UCDelivery
    Friend WithEvents Ucvatm1 As UCVATM
    Friend WithEvents UcSupplierM1 As UCSupplierM
    Friend WithEvents UcStocks1 As UCStocks
    Friend WithEvents UcProductM1 As UCProductM
    Friend WithEvents UcCategoryM1 As UCCategoryM
    Friend WithEvents Ucpos1 As UCPOS
    Friend WithEvents UcDiscountM1 As UCDiscountM
    Friend WithEvents UcAccountReg1 As UCAccountReg
End Class
