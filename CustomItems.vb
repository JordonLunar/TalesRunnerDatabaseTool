Imports MySql.Data.MySqlClient
Public Class CustomItems
    Private Sub CustomItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox1.Text = Form2.LabelUsernumber.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim update As New MySqlCommand("INSERT INTO tblAvatarUserAttr (fdUserNum,fdItemDescNum,fdAttrType,fdAttrValue) values('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')", connection)
        connection.Open()

        If update.ExecuteNonQuery = 1 Then
            MsgBox("Item stats updated !", MsgBoxStyle.Information)
        Else
            MsgBox("Failed to update items stats !", MsgBoxStyle.Critical)
        End If
        connection.Close()
    End Sub
End Class