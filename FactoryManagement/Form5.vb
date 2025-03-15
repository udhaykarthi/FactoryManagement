Imports System.Data.SqlClient

Public Class Form5
    ' Define SQL Connection
    Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=FactoryManagement;Integrated Security=True;TrustServerCertificate=True")


    ' Load Finished Product Data
    Private Sub LoadFinishedProducts()
        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "SELECT * FROM FinishedProduct"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    ' Form Load Event
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFinishedProducts()
    End Sub

    ' INSERT Button (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "INSERT INTO FinishedProduct (Name, Description, Price, Quantity) VALUES (@Name, @Description, @Price, @Quantity)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Description", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(TextBox4.Text))
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(TextBox5.Text))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Finished Product Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadFinishedProducts()
        End Using
    End Sub

    ' UPDATE Button (Button2)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter Finished Product ID to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "UPDATE FinishedProduct SET Name=@Name, Description=@Description, Price=@Price, Quantity=@Quantity WHERE Product_Id=@ID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(TextBox1.Text))
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Description", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(TextBox4.Text))
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(TextBox5.Text))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Finished Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadFinishedProducts()
        End Using
    End Sub

    ' DELETE Button (Button3)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Finished Product ID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "DELETE FROM FinishedProduct WHERE Product_Id=@ID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(TextBox1.Text))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Finished Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadFinishedProducts()
        End Using
    End Sub

    ' CLEAR Button (Button4)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearTextBoxes()
    End Sub

    ' BACK Button (Button5)
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form8 As New Form8()
        form8.Show()
        Me.Hide()
    End Sub

    ' Clear TextBoxes Function
    Private Sub ClearTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class
