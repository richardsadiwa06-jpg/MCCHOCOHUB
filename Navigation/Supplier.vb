Imports System.Data.SqlClient

Public Class Supplier

        Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MCCHSIS;Integrated Security=True;"

        Public Function GetSuppliers() As DataTable
            Dim dt As New DataTable()
            Dim query As String = "SELECT Supplier_ID, Supplier_Name, Address, Contact_No FROM dbo.SupplierM"
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        End Function

        Public Function InsertSupplier(name As String, address As String, contact As String) As Boolean
            Dim query As String = "INSERT INTO dbo.SupplierM (Supplier_Name, Address, Contact_No) VALUES (@name, @address, @contact)"
            Try
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@address", address)
                        cmd.Parameters.AddWithValue("@contact", contact)
                        con.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                Return True
            Catch ex As Exception
                Throw New Exception("Error inserting supplier: " & ex.Message)
                Return False
            End Try
        End Function

        Public Function UpdateSupplier(name As String, address As String, contact As String) As Boolean
            Dim query As String = "UPDATE dbo.SupplierM SET Supplier_Name=@name, Address=@address, Contact_No=@contact WHERE Supplier_ID=@id"
            Try
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@address", address)
                        cmd.Parameters.AddWithValue("@contact", contact)
                        con.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                Return True
            Catch ex As Exception
                Throw New Exception("Error updating supplier: " & ex.Message)
                Return False
            End Try
        End Function

        Public Function DeleteSupplier(id As Integer) As Boolean
            Dim query As String = "DELETE FROM dbo.SupplierM WHERE Supplier_ID=@id"
            Try
                Using con As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@id", id)
                        con.Open()

                        Return cmd.ExecuteNonQuery() > 0

                    End Using
                End Using

            Catch ex As Exception
                Throw New Exception("Error deleting supplier: " & ex.Message)
            End Try
        End Function

    End Class

