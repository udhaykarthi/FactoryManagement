Imports System.Data.SqlClient

Public Class Form3
    Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=FactoryManagement;Integrated Security=True;TrustServerCertificate=True")


    Private Sub LoadRawMaterialSuppliers()
        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "SELECT * FROM RawMaterialSupplier"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRawMaterialSuppliers()
    End Sub

    ' INSERT BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "INSERT INTO RawMaterialSupplier (MaterialType, Price, Quantity) VALUES (@MaterialType, @Price, @Quantity)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@MaterialType", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(TextBox3.Text))
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(TextBox4.Text))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Raw Material Supplier Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRawMaterialSuppliers()
        End Using
    End Sub

    ' UPDATE BUTTON
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Supplier ID to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "UPDATE RawMaterialSupplier SET MaterialType=@MaterialType, Price=@Price, Quantity=@Quantity WHERE Product_id=@ID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(TextBox1.Text))
            cmd.Parameters.AddWithValue("@MaterialType", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(TextBox3.Text))
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(TextBox4.Text))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Raw Material Supplier Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRawMaterialSuppliers()
        End Using
    End Sub

    ' DELETE BUTTON
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Supplier ID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "DELETE FROM RawMaterialSupplier WHERE Product_id=@ID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(TextBox1.Text))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Raw Material Supplier Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRawMaterialSuppliers()
        End Using
    End Sub

    ' CLEAR BUTTON
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearTextBoxes()
    End Sub

    Private Sub ClearTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    ' BACK BUTTON
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form8 As New Form8()
        form8.Show()
        Me.Hide()
    End Sub
End Class
