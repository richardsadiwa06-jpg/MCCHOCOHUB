Imports System.Data.SqlClient
Public Class Delivery

    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MCCHSIS;Integrated Security=True;"

    Public Function InsertHeader(supplierID As Integer, transactionNo As String, deliveryDate As Date) As Boolean
        Dim query As String =
        "INSERT INTO dbo.DeliveryHT (Supplier_ID, Transaction_No, Delivery_Date) 
             VALUES (@supplierID, @transactionNo, @deliveryDate)"
        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@supplierID", supplierID)
                    cmd.Parameters.AddWithValue("@transactionNo", transactionNo)
                    cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Throw New Exception("Error inserting delivery header: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetLastHeaderID() As Integer
        Dim id As Integer = 0
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT MAX(DeliveryHT_ID) FROM dbo.DeliveryHT", con)
            con.Open()
            id = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return id
    End Function

    Public Function InsertDetail(deliveryHTID As Integer, barcode As String, itemName As String, description As String, quantity As Integer, costPrice As Decimal, expDate As Date) As Boolean
        Dim query As String =
        "INSERT INTO dbo.DeliveryDT (DeliveryHT_ID, Barcode, Item_Name, Description, Quantity, Cost_Price, Exp_Date) 
             VALUES (@deliveryHTID, @barcode, @itemName, @description, @quantity, @costPrice, @expDate)"
        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@deliveryHTID", deliveryHTID)
                    cmd.Parameters.AddWithValue("@barcode", barcode)
                    cmd.Parameters.AddWithValue("@itemName", itemName)
                    cmd.Parameters.AddWithValue("@description", description)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.Parameters.AddWithValue("@costPrice", costPrice)
                    cmd.Parameters.AddWithValue("@expDate", expDate)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Throw New Exception("Error inserting delivery detail: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GenerateTransactionNo() As String
        Dim seed As Integer = 262602
        Dim txnNo As String = seed.ToString()

        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("SELECT ISNULL(MAX(CAST(Transaction_No AS INT)), 0) FROM dbo.DeliveryHT", con)
                con.Open()
                Dim result As Object = cmd.ExecuteScalar()
                Dim lastNo As Integer = 0

                If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), lastNo) Then
                    txnNo = Math.Max(lastNo + 1, seed).ToString()
                End If

            End Using
        Catch ex As Exception
            Throw New Exception("Error generating transaction number: " & ex.Message)
        End Try

        Return txnNo
    End Function

    Public Function GetDeliveryItems(deliveryHTID As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT Barcode, Item_Name, Description, Quantity, Cost_Price, Exp_Date FROM dbo.DeliveryDT WHERE DeliveryHT_ID = @deliveryHTID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@deliveryHTID", deliveryHTID)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error fetching delivery items: " & ex.Message)
        End Try
        Return dt
    End Function

End Class

