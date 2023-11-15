Imports System.Data.SqlClient
Public Class EditToolUser
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub EditToolUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Higher Admin")
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("GM")
        ComboBox1.Items.Add("VIP")
        ComboBox1.Items.Add("None")
        TextBox3.Text = ToolUserManager.TextBox3.Text
        TextBox4.Text = ToolUserManager.TextBox4.Text
        TextBox5.Text = ToolUserManager.TextBox5.Text
        TextBox6.Text = ToolUserManager.TextBox6.Text
        TextBox7.Text = ToolUserManager.TextBox7.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Server = LAPTOP-JDBAUBK0\SQLEXPRESS; Database = TR_GAMESVR_DB; Integrated Security = true")
        Dim command As New SqlCommand("select * from tblGMTool where fdID = @fdID", connection)
        Dim update As New SqlCommand("UPDATE tblGMTool SET fdID = @fdID where fdID = @fdID", connection)
        update.Parameters.Add("@fdID", SqlDbType.VarChar).Value = TextBox1.Text

        connection.Open()
        If update.ExecuteNonQuery() = 1 Then
            MsgBox("Login Updated", MsgBoxStyle.Information)
        Else
            MsgBox("Error while updating login", MsgBoxStyle.Critical)
        End If
    End Sub
End Class