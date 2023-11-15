Imports MySql.Data.MySqlClient
Public Class ExtraIGN
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox5.Text = Nothing Then
            MsgBox("Please enter a nickname !", MsgBoxStyle.Critical)
        Else
            Dim connection As New MySqlConnection("server=207.148.13.74;userid=root;password=SaD153az!;database=tr_game_db")
            Dim command As New MySqlCommand("select * from UserInfo where fdNickname = @fdNickname", connection)
            command.Parameters.Add("@fdNickName", MySqlDbType.VarChar).Value = TextBox5.Text
            connection.Open()
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            ' return only 1 row
            If table.Rows.Count > 0 Then
                TextBox1.Text = table.Rows(0)(0).ToString()

                MsgBox("User search completed !", MsgBoxStyle.Information)
                connection.Close()
            Else
                TextBox1.Text = Nothing

                TextBox5.Text = Nothing
                MsgBox("Failed to find user !", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub ExtraIGN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
    End Sub
End Class