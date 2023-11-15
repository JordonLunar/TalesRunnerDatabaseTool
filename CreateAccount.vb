Imports MySql.Data.MySqlClient
Public Class CreateAccount
    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection4 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim command As New MySqlCommand("insert into UserInfoFromPublisher(fdUserID,fdGameID,fdPassword,fdCash) values('" & TextBox1.Text & "','" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & 60000 & "')", connection4)
        connection4.Open()

        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Account Created", MsgBoxStyle.Information)
        Else
            MsgBox("Error while creating account", MsgBoxStyle.Critical)
        End If
        connection4.Close()
    End Sub
End Class