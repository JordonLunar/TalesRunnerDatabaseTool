Imports MySql.Data.MySqlClient
Public Class ChangePieroColour
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorPiero.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangePieroColour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form2.LabelNickname.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection4 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim params(1) As MySqlParameter



        params(0) = New MySqlParameter("@NickName", MySqlDbType.VarChar)
        params(0).Value = TextBox1.Text

        params(1) = New MySqlParameter("@Color", MySqlDbType.Int16)
        params(1).Value = TextBox2.Text

        Dim command As New MySqlCommand()
        command.Connection = connection4
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_GM_SetPieroColor"

        command.Parameters.AddRange(params)
        connection4.Open()
        command.ExecuteNonQuery()
        If command.ExecuteNonQuery = 0 Then
            MsgBox("Piero Color Changed", MsgBoxStyle.Information)
        Else
            MsgBox("Failed to change piero color !", MsgBoxStyle.Critical)
        End If
        connection4.Close()


    End Sub
End Class