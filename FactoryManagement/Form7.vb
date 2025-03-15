Imports System.Data.SqlClient

Public Class Form7
    Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=FactoryManagement;Integrated Security=True;TrustServerCertificate=True")

    Private Sub LoadCustomers()
        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "SELECT * FROM Customer"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    ' ✅ INSERT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "INSERT INTO Customer (Name, Address, PhoneNumber, PaymentStatus) VALUES (@Name, @Address, @PhoneNumber, @PaymentStatus)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Address", TextBox3.Text)
            cmd.Parameters.AddWithValue("@PhoneNumber", TextBox4.Text)
            cmd.Parameters.AddWithValue("@PaymentStatus", TextBox5.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Customer Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearTextBoxes()
        End Using
    End Sub

    ' ✅ UPDATE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter CustomerID to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "UPDATE Customer SET Name=@Name, Address=@Address, PhoneNumber=@PhoneNumber, PaymentStatus=@PaymentStatus WHERE Customer_id=@CustomerID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(TextBox1.Text))
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Address", TextBox3.Text)
            cmd.Parameters.AddWithValue("@PhoneNumber", TextBox4.Text)
            cmd.Parameters.AddWithValue("@PaymentStatus", TextBox5.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Customer Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearTextBoxes()
        End Using
    End Sub

    ' ✅ DELETE
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter CustomerID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "DELETE FROM Customer WHERE Customer_id=@CustomerID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(TextBox1.Text))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Customer Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()
            ClearTextBoxes()
        End Using
    End Sub

    ' 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearTextBoxes()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim adminPanel As New Form8()
        adminPanel.Show()
        Me.Hide()
    End Sub

    ' Helper Function to Clear Textboxes
    Private Sub ClearTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class
