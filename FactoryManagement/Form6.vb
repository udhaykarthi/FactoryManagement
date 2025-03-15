Imports System.Data.SqlClient

Public Class Form6
    ' Define SQL Connection
    Dim conn As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=FactoryManagement;Integrated Security=True;TrustServerCertificate=True")


    ' Load Quality Check Data
    Private Sub LoadQualityCheck()
        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "SELECT * FROM QualityCheck"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    ' Form Load Event
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQualityCheck()
    End Sub

    ' INSERT Button (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "INSERT INTO QualityCheck (BatchNo, Comments, Status) VALUES (@BatchNo, @Comments, @Status)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@FinishedProduct_ID", Convert.ToInt32(TextBox1.Text))
            cmd.Parameters.AddWithValue("@BatchNo", Convert.ToInt32(TextBox2.Text))
            cmd.Parameters.AddWithValue("@Comments", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Status", TextBox4.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Quality Check Data Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadQualityCheck()
            ClearTextBoxes()
        End Using
    End Sub

    ' UPDATE Button (Button2)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter Finished Product ID to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "UPDATE QualityCheck SET BatchNo=@BatchNo, Comments=@Comments, Status=@Status WHERE FinishedProduct_ID=@ID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(TextBox1.Text))
            cmd.Parameters.AddWithValue("@BatchNo", Convert.ToInt32(TextBox2.Text))
            cmd.Parameters.AddWithValue("@Comments", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Status", TextBox4.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Quality Check Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadQualityCheck()
            ClearTextBoxes()
        End Using
    End Sub

    ' DELETE Button (Button3)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Finished Product ID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using con As New SqlConnection(conn.ConnectionString)
            Dim query As String = "DELETE FROM QualityCheck WHERE FinishedProduct_ID=@ID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(TextBox1.Text))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Quality Check Data Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadQualityCheck()
            ClearTextBoxes()
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
    End Sub
End Class
