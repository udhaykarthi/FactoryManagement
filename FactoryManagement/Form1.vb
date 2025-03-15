Imports System.Data.SqlClient


Public Class Form1
    Dim connection As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=FactoryManagement;Integrated Security=True;TrustServerCertificate=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Data Source=RUIN-E\TEW_SQLEXPRESS;Initial Catalog=FactoryManagement;Integrated Security=True;TrustServerCertificate=True")


        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        '
        Dim query As String = "SELECT COUNT(*) FROM Admin WHERE Username=@username AND Password=@password"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)

        connection.Open()
        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
        connection.Close()

        If count > 0 Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form8.Show()
        Else
            MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
