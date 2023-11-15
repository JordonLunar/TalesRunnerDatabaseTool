Imports MySql.Data.MySqlClient
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label11.Text = Form1.Label4.Text
        Label13.Text = Form1.Label5.Text

        Me.Text = "TalesRunner Admin Tool - " & Label11.Text
        Button6.Enabled = False
        Button12.Enabled = True
        Button13.Enabled = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = Nothing Then
            MsgBox("Please Enter a Nickname !", MsgBoxStyle.Critical)
        Else
            Dim connection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
            Dim command As New MySqlCommand("select * from UserInfo where fdNickname = @fdNickname", connection)
            command.Parameters.Add("@fdNickName", MySqlDbType.VarChar).Value = TextBox1.Text
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ' return only 1 row
            If table.Rows.Count > 0 Then
                LabelNickname.Text = table.Rows(0)(6).ToString()
                LabelUsername.Text = table.Rows(0)(5).ToString()
                LabelUsernumber.Text = table.Rows(0)(0).ToString
                Button2.Enabled = True
                Button3.Enabled = True
                Button4.Enabled = True
                Button5.Enabled = True
                Button6.Enabled = True
                Button8.Enabled = True
                Button9.Enabled = True
                Button11.Enabled = True
                Button12.Enabled = True
                Button14.Enabled = True
                Button15.Enabled = True
                Button17.Enabled = True
                Button18.Enabled = True
                Button19.Enabled = True
                Button21.Enabled = True
                Button22.Enabled = True
                Dim connection2 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
                Dim command2 As New MySqlCommand("select * from UserInfoFromPublisher where fdUserID = @fdUserID", connection2)
                command2.Parameters.Add("@fdUserID", MySqlDbType.VarChar).Value = LabelUsername.Text
                Dim adapter2 As New MySqlDataAdapter(command2)
                Dim table2 As New DataTable
                adapter2.Fill(table2)
                'return only 1 row
                If table2.Rows.Count > 0 Then
                    LabelPassword.Text = table2.Rows(0)(2).ToString
                    LabelCash.Text = table2.Rows(0)(3).ToString
                End If
                Dim password As String = LabelPassword.Text
                Dim connection3 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
                Dim command3 As New MySqlCommand("select * from UserInfoGame where fdUserNum = @fdUserNum", connection3)
                command3.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = LabelUsernumber.Text
                Dim adapter3 As New MySqlDataAdapter(command3)
                Dim table3 As New DataTable
                adapter3.Fill(table3)
                'return only 1 row
                LabelTR.Text = table3.Rows(0)(2)
                LabelEXP.Text = table3.Rows(0)(1)
                Dim connection7 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
                Dim command7 As New MySqlCommand("select * from UserInfo where fdUserNum = @fdUserNum", connection7)
                command7.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = LabelUsernumber.Text
                Dim adapter7 As New MySqlDataAdapter(command7)
                Dim table7 As New DataTable
                adapter7.Fill(table7)
                'return only 1 row
                Label5.Text = table7.Rows(0)(3)
                If table7.Rows(0)(3) = 1 Then
                    Label5.Text = "Yes"
                Else
                    Label5.Text = "No"
                End If
                Dim connection9 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
                Dim command9 As New MySqlCommand("select * from UserInfoLogin where fdUserNum = @fdUserNum", connection9)
                command9.Parameters.Add("@fdUserNum", MySqlDbType.Int32).Value = LabelUsernumber.Text
                Dim adapter9 As New MySqlDataAdapter(command9)
                Dim table9 As New DataTable()
                adapter9.Fill(table9)
                Label18.Text = table9.Rows(0)(3)
                Label20.Text = table9.Rows(0)(2)
                TextBox1.Text = Nothing
                MsgBox("Current User: " & LabelNickname.Text, MsgBoxStyle.Information)
            Else
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False

                Button8.Enabled = False
                Button9.Enabled = False

                Button11.Enabled = True

                Button13.Enabled = False
                MsgBox("Failed to find user !", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LabelNickname.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()

        Form1.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        EditTRForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EditExpForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EditCashForm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SendGiftForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditUserForm.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ChangePieroColour.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim connectionrank As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim params(0) As MySqlParameter
        params(0) = New MySqlParameter("@detailRank", MySqlDbType.Int32)
        params(0).Value = 0
        Dim command As New MySqlCommand()
        command.Connection = connectionrank
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_makerank"
        command.Parameters.AddRange(params)
        connectionrank.Open()
        command.ExecuteNonQuery()
        connectionrank.Close()
        MsgBox("Rank Updated", MsgBoxStyle.Information)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Dim connectionrankfarm As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand()
        command.Connection = connectionrankfarm
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_Farm_makerank"
        connectionrankfarm.Open()
        command.ExecuteNonQuery()
        connectionrankfarm.Close()
        MsgBox("Farm Rank Updated", MsgBoxStyle.Information)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        CreateAccount.Show()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Guild.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ToolUserManager.Show()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim connectionrankfarm As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand()
        command.Connection = connectionrankfarm
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_itemCollection_makeRank"
        connectionrankfarm.Open()
        command.ExecuteNonQuery()
        connectionrankfarm.Close()
        MsgBox("Item Rank Updated", MsgBoxStyle.Information)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Label13.Text = "Higher Admin" Then
            Clipboard.SetText(LabelPassword.Text)
            MsgBox("Password hash copied to clipboard !", MsgBoxStyle.Information)
        Else
            MsgBox("You do not have enough clearance to access password data !")
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        BanUser.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        UnbanUser.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        CashToAllUsers.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim connectionguildrank As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand()
        command.Connection = connectionguildrank
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_guildMatchMakeRank"
        connectionguildrank.Open()
        command.ExecuteNonQuery()
        connectionguildrank.Close()
        MsgBox("Updated guild rank !", MsgBoxStyle.Information)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        CustomItems.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Storage_Gift.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        SearchItem.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
    End Sub
End Class