Public Class UCCategoryM

    Private cat As New Category()
    Private Sub UCCategoryM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategory()
    End Sub
    Private Sub LoadCategory()

        dgvCategory.DataSource = cat.GetCategories()

    End Sub

    Private Sub btnCategoryAdd_Click(sender As Object, e As EventArgs) Handles btnCategoryAdd.Click
        Try
            If cat.InsertCategory(txtCategoryName.Text) Then
                LoadCategory()
            End If
        Catch ex As Exception
            MessageBox.Show("Error adding category.")
        End Try
    End Sub

    Private Sub btnCategoryEdit_Click(sender As Object, e As EventArgs) Handles btnCategoryEdit.Click
        Try
            If cat.UpdateCategory(CInt(dgvCategory.CurrentRow.Cells("Category_ID").Value), txtCategoryName.Text) Then
                LoadCategory()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating category.")
        End Try
    End Sub

    Private Sub btnCategoryDelete_Click(sender As Object, e As EventArgs) Handles btnCategoryDelete.Click
        Try
            If dgvCategory.CurrentRow IsNot Nothing Then
                Dim categoryID As Integer =
                CInt(dgvCategory.CurrentRow.Cells("Category_ID").Value)
                If cat.DeleteCategory(categoryID) Then
                    MessageBox.Show("Category deleted successfully.")
                    LoadCategory()
                Else
                    MessageBox.Show("Delete failed.")
                End If
            Else
                MessageBox.Show("Please select a category to delete.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting category.")
        End Try
    End Sub
End Class
