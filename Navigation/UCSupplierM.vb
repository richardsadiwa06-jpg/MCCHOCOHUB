
Imports System.Data.SqlClient

Public Class UCSupplierM

    Private sup As New Supplier()

    Private Sub UCSupplierM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSuppliers()
    End Sub

    Private Sub LoadSuppliers()

        dgvSupplier.DataSource = sup.GetSuppliers()

    End Sub

    Private Sub btnSupplierAdd_Click(sender As Object, e As EventArgs) Handles btnSupplierAdd.Click
        Try
            If sup.InsertSupplier(txtSupplierName.Text, txtSupplierAddress.Text, txtSupplierContactNo.Text) Then
                LoadSuppliers()
            End If
        Catch
            MessageBox.Show("Error adding supplier.")
        End Try
    End Sub

    Private Sub btnUpdateSupplier_Click(sender As Object, e As EventArgs)
        Try
            If sup.UpdateSupplier(txtSupplierName.Text, txtSupplierAddress.Text, txtSupplierContactNo.Text) Then
                LoadSuppliers()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSupplierDelete_Click(sender As Object, e As EventArgs) Handles btnSupplierDelete.Click
        Try
            If dgvSupplier.CurrentRow IsNot Nothing Then

                Dim supplierID As Integer =
                CInt(dgvSupplier.CurrentRow.Cells("Supplier_ID").Value)

                Dim supplierLogic As New Supplier()

                If supplierLogic.DeleteSupplier(supplierID) Then
                    MessageBox.Show("Supplier deleted successfully.")
                    LoadSuppliers()
                Else
                    MessageBox.Show("Delete failed.")
                End If

            Else
                MessageBox.Show("Please select a supplier to delete.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

