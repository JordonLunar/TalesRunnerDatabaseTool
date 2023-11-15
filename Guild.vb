Imports MySql.Data.MySqlClient
Public Class Guild
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand("select * from GameDataGuild where fdName = @fdName", connection)
        command.Parameters.Add("@fdName", MySqlDbType.VarChar).Value = TextBox1.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        ' return only 1 row
        If table.Rows.Count > 0 Then
            Label12.Text = table.Rows(0)(3)
            Label13.Text = table.Rows(0)(2)
            Label14.Text = table.Rows(0)(9)
            Label15.Text = table.Rows(0)(0)
            Label16.Text = table.Rows(0)(4)
            Label17.Text = table.Rows(0)(10)
            Label18.Text = table.Rows(0)(12)
            Label19.Text = table.Rows(0)(13)
            Label20.Text = table.Rows(0)(15)
            TextBox1.Text = Nothing
            MsgBox("Current Guild: " & Label12.Text, MsgBoxStyle.Information)
        Else
            MsgBox("Failed to find guild !", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection2 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command2 As New MySqlCommand("select * from GameDataGuild where fdMasterNickName = @fdMasterNickName", connection2)
        command2.Parameters.Add("@fdMasterNickName", MySqlDbType.VarChar).Value = TextBox2.Text
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        ' return only 1 row
        If table2.Rows.Count > 0 Then
            Label12.Text = table2.Rows(0)(3)
            Label13.Text = table2.Rows(0)(2)
            Label14.Text = table2.Rows(0)(9)
            Label15.Text = table2.Rows(0)(0)
            Label16.Text = table2.Rows(0)(4)
            Label17.Text = table2.Rows(0)(10)
            Label18.Text = table2.Rows(0)(12)
            Label19.Text = table2.Rows(0)(13)
            Label20.Text = table2.Rows(0)(15)
            TextBox2.Text = Nothing
            MsgBox("Current Guild: " & Label12.Text, MsgBoxStyle.Information)
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
        Else
            MsgBox("Failed to find guild !", MsgBoxStyle.Critical)
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
        End If
    End Sub
End Class