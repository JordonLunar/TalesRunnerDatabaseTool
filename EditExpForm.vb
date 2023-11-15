Imports MySql.Data.MySqlClient
Public Class EditExpForm
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection3 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command3 As New MySqlCommand("select * from UserInfoGame where fdUserNum = @fdUserNum", connection3)
        command3.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
        Dim adapter3 As New MySqlDataAdapter(command3)
        Dim table3 As New DataTable
        adapter3.Fill(table3)
        'return only 1 row
        Label4.Text = table3.Rows(0)(1)
        Button3.Enabled = True
        MsgBox("Current EXP :" & Label4.Text, MsgBoxStyle.Information)
    End Sub

    Private Sub EditExpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        TextBox1.Text = Form2.LabelUsernumber.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = Nothing Then
            MsgBox("Please enter an exp value to update exp !", MsgBoxStyle.Critical)
        Else
            Dim connection4 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
            Dim command As New MySqlCommand("select * from UserInfoGame where fdUserNum = @fdUserNum", connection4)
            Dim update As New MySqlCommand("UPDATE UserInfoGame SET fdExp = @fdExp WHERE fdUserNum = @fdUserNum", connection4)
            update.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
            update.Parameters.Add("@fdExp", MySqlDbType.Int32).Value = TextBox2.Text
            connection4.Open()
            If update.ExecuteNonQuery() = 1 Then
                MsgBox("EXP Updated", MsgBoxStyle.Information)
            Else
                MsgBox("Error while updating EXP", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = Nothing Then
            MsgBox("Please enter an EXP value to update !", MsgBoxStyle.Critical)
        Else
            Dim addEXPconnection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
            Dim addEXPcommand As New MySqlCommand("update UserInfoGame SET fdExp = fdExp + '" & TextBox3.Text & "' where fdUserNum = @fdUserNum ", addEXPconnection)
            addEXPcommand.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = TextBox1.Text
            addEXPconnection.Open()
            If addEXPcommand.ExecuteNonQuery() = 1 Then
                MsgBox(TextBox3.Text & " EXP was successfully added !", MsgBoxStyle.Information)
            Else
                MsgBox("Failed to add EXP to user !", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class