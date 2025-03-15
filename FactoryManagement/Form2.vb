Imports System.Data.SqlClient

Public Class Form2
    Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=FactoryManagement;Integrated Security=True;TrustServerCertificate=True")

    Private Sub LoadOrders()
        Try
            Using con As New SqlConnection(conn.ConnectionString)
                Dim query As String = "SELECT * FROM OrderPlaced"
                Dim adapter As New SqlDataAdapter(query, con)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(conn.ConnectionString)
                Dim query As String = "INSERT INTO OrderPlaced (CustomerName, ProductName, OrderDate, TotalAmt) VALUES (@CustomerName, @ProductName, @OrderDate, @TotalAmt)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CustomerName", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@ProductName", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@OrderDate", Convert.ToDateTime(TextBox4.Text))
                    cmd.Parameters.AddWithValue("@TotalAmt", Convert.ToInt32(TextBox5.Text))

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Order Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadOrders()
        Catch ex As Exception
            MessageBox.Show("Error inserting order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter OrderID to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(conn.ConnectionString)
                Dim query As String = "UPDATE OrderPlaced SET CustomerName=@CustomerName, ProductName=@ProductName, OrderDate=@OrderDate, TotalAmt=@TotalAmt WHERE Order_id=@OrderID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@OrderID", Convert.ToInt32(TextBox1.Text))
                    cmd.Parameters.AddWithValue("@CustomerName", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@ProductName", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@OrderDate", Convert.ToDateTime(TextBox4.Text))
                    cmd.Parameters.AddWithValue("@TotalAmt", Convert.ToInt32(TextBox5.Text))

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Order Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadOrders()
        Catch ex As Exception
            MessageBox.Show("Error updating order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter OrderID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(conn.ConnectionString)
                Dim query As String = "DELETE FROM OrderPlaced WHERE Order_id=@ID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(TextBox1.Text))

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Order Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearTextBoxes()
            LoadOrders()
        Catch ex As Exception
            MessageBox.Show("Error deleting order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearTextBoxes()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form8 As New Form8()
        form8.Show()
        Me.Hide()
    End Sub

    Private Sub ClearTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class
