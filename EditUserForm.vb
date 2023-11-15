Imports MySql.Data.MySqlClient
Public Class EditUserForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection3 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command3 As New MySqlCommand("select * from UserInfo where fdUserNum = @fdUserNum", connection3)
        command3.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
        Dim adapter3 As New MySqlDataAdapter(command3)
        Dim table3 As New DataTable
        adapter3.Fill(table3)
        'return only 1 row
        Label4.Text = table3.Rows(0)(6)
        If table3.Rows(0)(3) = 1 Then
            Label6.Text = "Yes"
        Else
            Label6.Text = "No"
        End If

        MsgBox("Current User :" & Label4.Text, MsgBoxStyle.Information)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection4 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand("select * from UserInfo where fdUserNum = @fdUserNum", connection4)
        Dim update As New MySqlCommand("UPDATE UserInfo SET fdNickname = @fdNickname WHERE fdUserNum = @fdUserNum", connection4)
        update.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
        update.Parameters.Add("@fdNickname", MySqlDbType.VarChar).Value = TextBox2.Text
        connection4.Open()
        If update.ExecuteNonQuery() = 1 Then
            MsgBox("IGN Updated", MsgBoxStyle.Information)
        Else
            MsgBox("Error while updating IGN", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connection5 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand("select * from UserInfo where fdUserNum = @fdUserNum", connection5)
        Dim update As New MySqlCommand("UPDATE UserInfo SET fdAttribute = @fdAttribute WHERE fdUserNum = @fdUserNum", connection5)
        update.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
        update.Parameters.Add("@fdAttribute", MySqlDbType.Int32).Value = 1
        connection5.Open()
        If update.ExecuteNonQuery() = 1 Then
            MsgBox("Changed to piero account", MsgBoxStyle.Information)
        Else
            MsgBox("Error while updating piero status", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connection6 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand("select * from UserInfo where fdUserNum = @fdUserNum", connection6)
        Dim update As New MySqlCommand("UPDATE UserInfo SET fdAttribute = @fdAttribute WHERE fdUserNum = @fdUserNum", connection6)
        update.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
        update.Parameters.Add("@fdAttribute", MySqlDbType.Int32).Value = 0
        connection6.Open()
        If update.ExecuteNonQuery() = 1 Then
            MsgBox("Changed to player account", MsgBoxStyle.Information)
        Else
            MsgBox("Error while updating piero status", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub EditUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form2.LabelUsernumber.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connection6 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand("select * from UserInfo where fdUserNum = @fdUserNum", connection6)
        Dim update1 As New MySqlCommand("UPDATE UserInfo SET fdAttribute = @fdAttribute WHERE fdUserNum = @fdUserNum", connection6)
        update1.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
        update1.Parameters.Add("@fdAttribute", MySqlDbType.Int32).Value = 3
        connection6.Open()
        If update1.ExecuteNonQuery() = 1 Then
            MsgBox("Changed to observation account !", MsgBoxStyle.Information)
        Else
            MsgBox("Error while updating observation account !", MsgBoxStyle.Critical)
        End If
    End Sub
End Class