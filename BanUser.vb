Imports MySql.Data.MySqlClient
Public Class BanUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim banconnection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim bancommand As New MySqlCommand("insert into tblblacklist(fdUserNum,fdBlockReasonNum,fdCommanderUserNum,fdCommandDateTime,fdBlockStartDateTime,fdBlockEndDateTime) values('" & TextBox1.Text & "','" & 1 & "','" & 13 & "','" & DateTimePicker1.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "')", banconnection)
        banconnection.Open()

        If bancommand.ExecuteNonQuery = 1 Then
            MsgBox("User banned !", MsgBoxStyle.Information)
        Else
            MsgBox("Failed to ban user !", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub BanUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        TextBox1.Text = Form2.LabelUsernumber.Text



    End Sub
End Class