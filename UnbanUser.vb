Imports MySql.Data.MySqlClient
Public Class UnbanUser
    Private Sub UnbanUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox1.Text = Form2.LabelUsernumber.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection3 As New MySqlConnection("server=207.148.13.74;userid=root;password=SaD153az!;database=tr_game_db")
        Dim command3 As New MySqlCommand("DELETE FROM tblblacklist where fdUserNum = @fdUserNum", connection3)
        command3.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
        connection3.Open()
        If command3.ExecuteNonQuery() = 1 Then
            MsgBox("User unbanned !", MsgBoxStyle.Information)

        Else
            MsgBox("Failed to unban user !", MsgBoxStyle.Critical)

        End If


    End Sub
End Class