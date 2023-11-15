Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Text
Imports System.IO
Imports INIControl.INIControl
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection3 As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
            Dim command3 As New MySqlCommand("select * from tblGMTool where fdID = @fdID", connection3)
            command3.Parameters.Add("@fdID", MySqlDbType.VarChar).Value = TextBox1.Text
            Dim adapter3 As New MySqlDataAdapter(command3)
            Dim table3 As New DataTable
            adapter3.Fill(table3)
        'return only 1 row




        If table3.Rows.Count() <= 0 Then
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical)
        Else
            Label4.Text = table3.Rows(0)(1)
                Label5.Text = table3.Rows(0)(3)

                MsgBox("Login Successful, Welcome " & Label4.Text & "", MsgBoxStyle.Information)
                Form2.Show()
                Me.Hide()

            End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        DatabaseInfo.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Form2.Label13.Text = "Higher Admin"
        Form2.Label11.Text = "Test Administrator"
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Form2.Show()
        Form2.Label11.Text = "Test Administrator"

        Form2.Label13.Text = "Higher Admin"

    End Sub
End Class
