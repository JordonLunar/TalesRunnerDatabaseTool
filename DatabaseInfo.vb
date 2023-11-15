Imports INICONTROL.INIControl
Public Class DatabaseInfo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WriteINI("Config", "IP", TextBox1.Text)
        WriteINI("Config", "US", TextBox2.Text)
        WriteINI("Config", "PW", TextBox3.Text)
        WriteINI("Config", "DB", TextBox4.Text)
        MsgBox("Database information Updated")
    End Sub

    Private Sub DatabaseInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectINI(".\\databaseconfig.ini")
        TextBox1.Text = ReadINI("Config", "IP")
        TextBox2.Text = ReadINI("Config", "US")
        TextBox3.Text = ReadINI("Config", "PW")
        TextBox4.Text = ReadINI("Config", "DB")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class