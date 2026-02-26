

Public Class DashBoard

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelInventory.Visible = False
        PanelMaintenance.Visible = False
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        If PanelInventory.Visible = False Then
            PanelInventory.Visible = True
            PanelMaintenance.Visible = False
        Else
            PanelInventory.Visible = False
        End If
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        If PanelMaintenance.Visible = False Then
            PanelMaintenance.Visible = True
            PanelInventory.Visible = False
        Else
            PanelMaintenance.Visible = False
        End If
    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        Ucpos1.BringToFront()
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        UcDelivery1.BringToFront()
    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        UcStocks1.BringToFront()
    End Sub

    Private Sub btnCategoryM_Click(sender As Object, e As EventArgs) Handles btnCategoryM.Click
        UcCategoryM1.BringToFront()
    End Sub

    Private Sub btnProductM_Click(sender As Object, e As EventArgs) Handles btnProductM.Click
        UcProductM1.BringToFront()
    End Sub

    Private Sub btnSupplierM_Click(sender As Object, e As EventArgs) Handles btnSupplierM.Click
        UcSupplierM1.BringToFront()
    End Sub

    Private Sub btnVATM_Click(sender As Object, e As EventArgs) Handles btnVATM.Click
        Ucvatm1.BringToFront()
    End Sub

    Private Sub btnDiscountM_Click(sender As Object, e As EventArgs) Handles btnDiscountM.Click
        UcDiscountM1.BringToFront()
    End Sub

    Private Sub btnAccountReg_Click(sender As Object, e As EventArgs) Handles btnAccountReg.Click
        UcAccountReg1.BringToFront()
    End Sub
End Class