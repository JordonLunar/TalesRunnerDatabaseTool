Imports MySql.Data.MySqlClient
Public Class ToolUserManager
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New MySqlConnection("server=207.148.13.74;userid=root;password=SaD153az!;database=tr_game_db")
        Dim command As New MySqlCommand("select * from tblGmTool where fdID = @fdID", connection)
        command.Parameters.Add("@fdID", MySqlDbType.VarChar).Value = TextBox1.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            TextBox3.Text = table.Rows(0)(2)
            TextBox4.Text = table.Rows(0)(0)
            TextBox5.Text = table.Rows(0)(1)
            TextBox6.Text = table.Rows(0)(3)
            TextBox7.Text = table.Rows(0)(4)
            MsgBox("Current User: " & TextBox5.Text, MsgBoxStyle.Information)
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            Button3.Enabled = True

        Else
            MsgBox("User Not Found", MsgBoxStyle.Critical)
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            TextBox3.Text = "?"
            TextBox4.Text = "?"
            TextBox5.Text = "?"
            TextBox6.Text = "?"
            TextBox7.Text = "?"
            Button3.Enabled = False

        End If

    End Sub

    Private Sub ToolUserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = "?"
        TextBox4.Text = "?"
        TextBox5.Text = "?"
        TextBox6.Text = "?"
        TextBox7.Text = "?"
        ComboBox1.Items.Add("Higher Admin")
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("GM")
        ComboBox1.Items.Add("VIP")
        ComboBox1.Items.Add("None")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection2 As New MySqlConnection("server=207.148.13.74;userid=root;password=SaD153az!;database=tr_game_db")
        Dim command2 As New MySqlCommand("select * from tblGmTool where fdToolNum = @fdToolNum", connection2)
        command2.Parameters.Add("@fdToolNum", MySqlDbType.Int32).Value = TextBox2.Text
        Dim adapter2 As New MySqlDataAdapter(command2)
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        If table2.Rows.Count() > 0 Then
            TextBox3.Text = table2.Rows(0)(2)
            TextBox4.Text = table2.Rows(0)(0)
            TextBox5.Text = table2.Rows(0)(1)
            TextBox6.Text = table2.Rows(0)(3)
            TextBox7.Text = table2.Rows(0)(4)
            MsgBox("Current User: " & TextBox5.Text, MsgBoxStyle.Information)
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            Button3.Enabled = True
        Else
            MsgBox("User Not Found", MsgBoxStyle.Critical)
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            TextBox3.Text = "?"
            TextBox4.Text = "?"
            TextBox5.Text = "?"
            TextBox6.Text = "?"
            TextBox7.Text = "?"
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connection3 As New MySqlConnection("server=207.148.13.74;userid=root;password=SaD153az!;database=tr_game_db")
        Dim command3 As New MySqlCommand("DELETE FROM tblGmTool where fdToolNum = @fdToolNum", connection3)
        command3.Parameters.Add("@fdToolNum", MySqlDbType.Int32).Value = TextBox4.Text
        connection3.Open()
        If command3.ExecuteNonQuery() = 1 Then
            MsgBox("User Deleted !", MsgBoxStyle.Information)
            TextBox3.Text = "?"
            TextBox4.Text = "?"
            TextBox5.Text = "?"
            TextBox6.Text = "?"
            TextBox7.Text = "?"
        Else
            MsgBox("Failed to remove user !", MsgBoxStyle.Critical)
            TextBox3.Text = "?"
            TextBox4.Text = "?"
            TextBox5.Text = "?"
            TextBox6.Text = "?"
            TextBox7.Text = "?"
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connection4 As New MySqlConnection("server=144.202.53.197;userid=root;password=SaD153az!;database=tr_game_db")
        Dim command As New MySqlCommand("insert into tblGMTool(fdNick,fdID,fdPassword,fdClearance) values('" & TextBox9.Text & "','" & TextBox8.Text & "', '" & TextBox10.Text & "', '" & ComboBox1.Text & "')", connection4)
        connection4.Open()

        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Account Created", MsgBoxStyle.Information)
            TextBox8.Text = Nothing
            TextBox9.Text = Nothing
            TextBox10.Text = Nothing
            ComboBox1.Text = Nothing
        Else
            MsgBox("Error while creating account", MsgBoxStyle.Critical)
            TextBox8.Text = Nothing
            TextBox9.Text = Nothing
            TextBox10.Text = Nothing
            ComboBox1.Text = Nothing
        End If
        connection4.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        EditToolUser.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connection5 As New MySqlConnection("server=207.148.13.74;userid=root;password=SaD153az!;database=tr_game_db")
        Dim command5 As New MySqlCommand("select * from tblGmTool where fdNick = @fdNick", connection5)
        command5.Parameters.Add("@fdNick", MySqlDbType.VarChar).Value = TextBox11.Text
        Dim adapter5 As New MySqlDataAdapter(command5)
        Dim table5 As New DataTable
        adapter5.Fill(table5)
        If table5.Rows.Count() > 0 Then
            TextBox3.Text = table5.Rows(0)(2)
            TextBox4.Text = table5.Rows(0)(0)
            TextBox5.Text = table5.Rows(0)(1)
            TextBox6.Text = table5.Rows(0)(3)
            TextBox7.Text = table5.Rows(0)(4)
            MsgBox("Current User: " & TextBox5.Text, MsgBoxStyle.Information)
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            Button3.Enabled = True

        Else
            MsgBox("User Not Found", MsgBoxStyle.Critical)
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            TextBox3.Text = "?"
            TextBox4.Text = "?"
            TextBox5.Text = "?"
            TextBox6.Text = "?"
            TextBox7.Text = "?"
            Button3.Enabled = False

        End If

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Feature coming soon", MsgBoxStyle.Critical)
    End Sub
End Class