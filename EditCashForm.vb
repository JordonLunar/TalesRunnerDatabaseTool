Imports MySql.Data.MySqlClient
Public Class EditCashForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = Nothing Then
            MsgBox("Please enter a cash value to update !", MsgBoxStyle.Critical)
        Else
            Dim connection4 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
            Dim command As New MySqlCommand("select * from UserInfoFromPublisher where fdGameID = @fdGameID", connection4)
            Dim update As New MySqlCommand("UPDATE UserInfoFromPublisher SET fdCash = @fdCash WHERE fdGameID = @fdGameID", connection4)
            update.Parameters.Add("@fdGameID", MySqlDbType.VarChar).Value = TextBox1.Text
            update.Parameters.Add("@fdCash", MySqlDbType.Int32).Value = TextBox2.Text
            connection4.Open()
            If update.ExecuteNonQuery() = 1 Then
                MsgBox("Cash Updated", MsgBoxStyle.Information)
            Else
                MsgBox("Error while updating Cash", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub EditCashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = vbFalse
        TextBox1.Text = Form2.LabelUsername.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection3 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command3 As New MySqlCommand("select * from UserInfoFromPublisher where fdUserID = @fdUserID", connection3)
        command3.Parameters.Add("@fdUserID", MySqlDbType.VarChar).Value = TextBox1.Text
        Dim adapter3 As New MySqlDataAdapter(command3)
        Dim table3 As New DataTable
        adapter3.Fill(table3)
        'return only 1 row
        Label4.Text = table3.Rows(0)(3)
        Button3.Enabled = True
        MsgBox("Current Cash :" & Label4.Text, MsgBoxStyle.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = Nothing Then
            MsgBox("Please enter a Cash value to update !", MsgBoxStyle.Critical)
        Else
            Dim addCashconnection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
            Dim addCashcommand As New MySqlCommand("update UserInfoFromPublisher SET fdCash = fdCash + '" & TextBox3.Text & "' where fdGameID = @fdGameID ", addCashconnection)
            addCashcommand.Parameters.Add("@fdGameID", MySqlDbType.VarChar).Value = TextBox1.Text
            addCashconnection.Open()
            If addCashcommand.ExecuteNonQuery() = 1 Then
                MsgBox(TextBox3.Text & " Cash was successfully added !", MsgBoxStyle.Information)
            Else
                MsgBox("Failed to add Cash to user !", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class