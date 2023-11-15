Imports MySql.Data.MySqlClient
Public Class Storage_Gift
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
                Button1.Enabled = True
                MsgBox("User search completed !", MsgBoxStyle.Information)
                connection.Close()
            Else
                TextBox1.Text = Nothing
                Button1.Enabled = False
                TextBox5.Text = Nothing
                MsgBox("Failed to find user !", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ammount As Integer = NumericUpDown1.Text
        For ammount = 1 To NumericUpDown1.Text
            Dim reader As MySqlDataReader
            Dim uniqueNumber As Integer
            Dim connection4 As New MySqlConnection("server=207.148.13.74;userid=root;password=SaD153az!;database=tr_game_db")
            connection4.Open()
            Dim command2 As New MySqlCommand("SELECT fdUniqueNum FROM userstoragekeepingitem order by fdUniqueNum DESC limit 1", connection4)
            reader = command2.ExecuteReader()
            reader.Read()
            uniqueNumber = reader("fdUniqueNum")
            Dim command As New MySqlCommand("insert into userstoragekeepingitem(fdUniqueNum,fdUserNum,fdItemNum, fdDateTime) values('" & uniqueNumber + 1 & "','" & TextBox1.Text & "','" & TextBox2.Text & "' ,'" & DateTimePicker1.Text & "')", connection4)
            reader.Close()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox(NumericUpDown1.Text & " gift(s) Sent !", MsgBoxStyle.Information)
            Else
                connection4.Close()
                MsgBox(NumericUpDown1.TextAlign & " gift(s) failed to send !", MsgBoxStyle.Critical)
            End If

        Next


    End Sub

    Private Sub Storage_Gift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss"


    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class