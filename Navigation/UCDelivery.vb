Imports System.Data.SqlClient
Public Class UCDelivery

    Private deliveryHTID As Integer

    Private Sub UCDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSuppliers()
        Dim delivery As New Delivery()
        txtDH_TransactionNo.Text = delivery.GenerateTransactionNo()
        txtDH_TransactionNo.ReadOnly = True

        SetDeliveryDetailsEnabled(False)
    End Sub

    Private Sub LoadDeliveryItems()
        Dim delivery As New Delivery()
        dgvDeliveryDetail.DataSource = delivery.GetDeliveryItems(deliveryHTID)
    End Sub
    Private Sub BtnDH_DeliveryProceed_Click(sender As Object, e As EventArgs) Handles btnDH_DeliveryProceed.Click
        Dim delivery As New Delivery()

        If delivery.InsertHeader(cmbDH_Supplier.SelectedValue, txtDH_TransactionNo.Text, dtpDH_DeliveryDate.Value) Then
            deliveryHTID = delivery.GetLastHeaderID()

            pnlDH.Visible = False

            lblDT_SupplierName.Text = cmbDH_Supplier.Text
            lblDt_TransactionNo.Text = txtDH_TransactionNo.Text
            lblDT_DeliveryDate.Text = dtpDH_DeliveryDate.Value.ToShortDateString()

            If deliveryHTID > 0 Then
                LoadDeliveryItems()
                SetDeliveryDetailsEnabled(True)
            End If
        End If
    End Sub

    Private Sub LoadSuppliers()
        Dim sup As New Supplier()
        Dim dt As DataTable = sup.GetSuppliers()


        cmbDH_Supplier.DataSource = dt
        cmbDH_Supplier.DisplayMember = "Supplier_Name"
        cmbDH_Supplier.ValueMember = "Supplier_ID"
        cmbDH_Supplier.SelectedIndex = -1
    End Sub
    Private Sub SetDeliveryDetailsEnabled(isEnabled As Boolean)


        txtDD_Barcode.Enabled = isEnabled
        txtDD_ItemName.Enabled = isEnabled
        txtDD_Description.Enabled = isEnabled
        txtDD_Quantity.Enabled = isEnabled
        txtDD_CostPrice.Enabled = isEnabled
        dtpDD_ExpDate.Enabled = isEnabled
        btnDD_Add.Enabled = isEnabled
        btnDD_Edit.Enabled = isEnabled
        btnDD_Delete.Enabled = isEnabled
        btnDD_Save.Enabled = isEnabled
    End Sub

    Private Sub btnDD_Add_Click(sender As Object, e As EventArgs) Handles btnDD_Add.Click
        Dim delivery As New Delivery()

        If delivery.InsertDetail(deliveryHTID, txtDD_Barcode.Text, txtDD_ItemName.Text, txtDD_Description.Text,
                              CInt(txtDD_Quantity.Text), CDec(txtDD_CostPrice.Text), dtpDD_ExpDate.Value) Then
            LoadDeliveryItems()
        End If

    End Sub

    Private Sub btnDeliveryProceed_Click(sender As Object, e As EventArgs) Handles btnDH_DeliveryProceed.Click

    End Sub
End Class
