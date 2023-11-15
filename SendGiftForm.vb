Imports MySql.Data.MySqlClient
Public Class SendGiftForm
    Private Sub SendGiftForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Enabled = False
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Please search for a user before sending a gift !", MsgBoxStyle.Critical)
        Else
            If CheckBox1.Checked = True Then
                Dim connection5 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
                connection5.Open()
                Dim ammount2 As Integer = NumericUpDown1.Text

                For ammount2 = 1 To NumericUpDown1.Text
                    Dim command2 As New MySqlCommand("insert into tblGift(fdSendUserNum,fdSendNickname,fdReceiveUserNum,fdGiftItemDescNum,fdNotified,fdMemo) values('" & 180317 & "','" & TextBox3.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & 0 & "', '" & TextBox4.Text & "')", connection5)
                    Dim command3 As New MySqlCommand("insert into tblGift(fdSendUserNum,fdSendNickname,fdReceiveUserNum,fdGiftItemDescNum,fdNotified,fdMemo) values('" & 180317 & "','" & TextBox3.Text & "', '" & ExtraIGN.TextBox1.Text & "', '" & TextBox2.Text & "', '" & 0 & "', '" & TextBox4.Text & "')", connection5)
                    If command2.ExecuteNonQuery() = 1 And command3.ExecuteNonQuery() = 1 Then
                        MsgBox(NumericUpDown1.Text & " gift(s) Sent !", MsgBoxStyle.Information)
                    Else
                        MsgBox(NumericUpDown1.TextAlign & " gift(s) failed to send !", MsgBoxStyle.Critical)

                        connection5.Close()
                    End If
                Next

            ElseIf CheckBox1.Checked = False Then


                Dim ammount As Integer = NumericUpDown1.Text
                For ammount = 1 To NumericUpDown1.Text
                    Dim flag2 As Boolean = True
                    Dim connection4 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
                    Dim command As New MySqlCommand("insert into tblGift(fdSendUserNum,fdSendNickname,fdReceiveUserNum,fdGiftItemDescNum,fdNotified,fdMemo) values('" & 180317 & "','" & TextBox3.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & 0 & "', '" & TextBox4.Text & "')", connection4)
                    connection4.Open()
                    If command.ExecuteNonQuery() = 1 Then


                        MsgBox(NumericUpDown1.Text & " gift(s) Sent !", MsgBoxStyle.Information)
                        Dim connection500 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
                        Dim command500 As New MySqlCommand("insert into tbltoolgiftlog(ToolUserName,ItemNumber,SentToUserNumber,Message,Date) values('" & Form2.Label11.Text & "','" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & TextBox4.Text & "', '" & DateTimePicker1.Text & "')", connection500)
                        connection500.Open()
                        command500.ExecuteNonQuery()
                        connection500.Close()

                    Else
                        MsgBox(NumericUpDown1.TextAlign & " gift(s) failed to send !", MsgBoxStyle.Critical)
                    End If
                    connection4.Close()
                Next
            End If
        End If


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox5.Text = Nothing Then
            MsgBox("Please enter a nickname !", MsgBoxStyle.Critical)
        Else
            Dim connection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ExtraIGN.Show()
    End Sub
End Class