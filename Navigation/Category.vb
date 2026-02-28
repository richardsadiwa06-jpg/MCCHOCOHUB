Imports System.Data.SqlClient
Public Class Category
    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MCCHSIS;Integrated Security=True;"

    Public Function InsertCategory(categoryName As String) As Boolean

        If String.IsNullOrWhiteSpace(categoryName) Then
            Throw New ArgumentException("Category name cannot be empty.")
        End If

        Dim query As String =
            "INSERT INTO dbo.CategoryM (Category_Name)
             VALUES (@categoryName)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.Add("@categoryName", SqlDbType.VarChar, 100).Value = categoryName

                con.Open()
                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function

    Public Function GetCategories() As DataTable

        Dim dt As New DataTable()

        Dim query As String = "SELECT Category_ID, Category_Name FROM dbo.CategoryM"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using

        Return dt

    End Function

    Public Function UpdateCategory(categoryID As Integer, categoryName As String) As Boolean

        Dim query As String = "UPDATE dbo.CategoryM SET Category_Name = @categoryName WHERE Category_ID = @categoryID"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = categoryID
                cmd.Parameters.Add("@categoryName", SqlDbType.VarChar, 100).Value = categoryName

                con.Open()
                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function

    Public Function DeleteCategory(categoryID As Integer) As Boolean

        Dim query As String = "DELETE FROM dbo.CategoryM WHERE Category_ID = @categoryID"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = categoryID

                con.Open()
                Return cmd.ExecuteNonQuery() > 0

            End Using
        End Using

    End Function

End Class
