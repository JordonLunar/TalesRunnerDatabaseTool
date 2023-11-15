Imports MySql.Data.MySqlClient
Public Class CashToAllUsers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addcashconnection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim addcashcommand As New MySqlCommand("UPDATE userinfofrompublisher set fdcash = fdcash + '" & TextBox1.Text & "'", addcashconnection)
        addcashconnection.Open()
        addcashcommand.ExecuteNonQuery()
        MsgBox(TextBox1.Text & " cash was successfully added to all accounts !", MsgBoxStyle.Information)
    End Sub
End Class