Imports System.Data.SqlClient
Public Class Product
    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MCCHSIS;Integrated Security=True;"

    Public Function GetProducts() As DataTable
        Dim query As String = "SELECT * FROM Products"
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, connection)
                connection.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    dataTable.Load(reader)
                End Using
            End Using
        End Using
        Return dataTable
    End Function

    Public Sub AddProduct(name As String, price As Decimal, categoryID As Integer, withExp As Boolean)
        Dim query As String = "INSERT INTO dbo.ProductM (ItemName, Barcode, SellingPrice, Category) VALUES (@Name, @Price)"
        Using connection As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Price", price)
                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateProduct(id As Integer, name As String, price As Decimal)
        Dim query As String = "UPDATE Products SET Name = @Name, Price = @Price WHERE Id = @Id"
        Using connection As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@Price", price)
                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteProduct(id As Integer)
        Dim query As String = "DELETE FROM Products WHERE Id = @Id"
        Using connection As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Id", id)
                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
