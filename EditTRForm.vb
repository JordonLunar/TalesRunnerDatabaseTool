Imports MySql.Data.MySqlClient
Public Class EditTRForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection3 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command3 As New MySqlCommand("select * from UserInfoGame where fdUserNum = @fdUserNum", connection3)
        command3.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
        Dim adapter3 As New MySqlDataAdapter(command3)
        Dim table3 As New DataTable
        adapter3.Fill(table3)
        'return only 1 row
        Label4.Text = table3.Rows(0)(2)

        Button3.Enabled = True
        MsgBox("Current TR :" & Label4.Text, MsgBoxStyle.Information)


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = Nothing Then
            MsgBox("Please enter a TR value to update !", MsgBoxStyle.Critical)
        Else
            Dim connection4 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
            Dim command As New MySqlCommand("select * from UserInfoGame where fdUserNum = @fdUserNum", connection4)
            Dim update As New MySqlCommand("UPDATE UserInfoGame SET fdGameMoney = @fdGameMoney WHERE fdUserNum = @fdUserNum", connection4)
            update.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
            update.Parameters.Add("@fdGameMoney", MySqlDbType.Int32).Value = TextBox2.Text
            connection4.Open()
            If update.ExecuteNonQuery() = 1 Then
                MsgBox("TR updated", MsgBoxStyle.Information)
            Else
                MsgBox("Error while updating TR", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub EditTRForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form2.LabelUsernumber.Text
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = Nothing Then
            MsgBox("Please enter a TR value to update !", MsgBoxStyle.Critical)
        Else
            Dim addTRconnection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
            Dim addTRcommand As New MySqlCommand("update UserInfoGame SET fdGameMoney = fdGameMoney + '" & TextBox3.Text & "' where fdUserNum = @fdUserNum ", addTRconnection)
            addTRcommand.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
            addTRconnection.Open()
            If addTRcommand.ExecuteNonQuery() = 1 Then
                MsgBox(TextBox3.Text & " cash was successfully added !", MsgBoxStyle.Information)
            Else
                MsgBox("Failed to add cash to user !", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class