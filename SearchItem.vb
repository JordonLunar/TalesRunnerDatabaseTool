Imports MySql.Data.MySqlClient
Public Class SearchItem
    Private Sub SearchItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionglove As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterglove As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3004", connectionglove)
        Dim tableglove As New DataTable()
        adapterglove.Fill(tableglove)
        DataGridView1.DataSource = tableglove
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionall As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterall As New MySqlDataAdapter("select * from tblavataritemdesc", connectionall)
        Dim tableall As New DataTable()
        adapterall.Fill(tableall)
        DataGridView1.DataSource = tableall
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectionwing As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterwing As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3005", connectionwing)
        Dim tablewing As New DataTable()
        adapterwing.Fill(tablewing)
        DataGridView1.DataSource = tablewing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectionshoe As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adaptershoe As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 2004", connectionshoe)
        Dim tableshoe As New DataTable()
        adaptershoe.Fill(tableshoe)
        DataGridView1.DataSource = tableshoe
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connectionbottom As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterbottom As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 2003", connectionbottom)
        Dim tablebottom As New DataTable()
        adapterbottom.Fill(tablebottom)
        DataGridView1.DataSource = tablebottom
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim connectiontop As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adaptertop As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 2002", connectiontop)
        Dim tabletop As New DataTable()
        adaptertop.Fill(tabletop)
        DataGridView1.DataSource = tabletop
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim connectionhair As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterhair As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 2001", connectionhair)
        Dim tablehair As New DataTable()
        adapterhair.Fill(tablehair)
        DataGridView1.DataSource = tablehair
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim connectionhead As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterhead As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3001", connectionhead)
        Dim tablehead As New DataTable()
        adapterhead.Fill(tablehead)
        DataGridView1.DataSource = tablehead
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim connectionface As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterface As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3002", connectionface)
        Dim tableface As New DataTable()
        adapterface.Fill(tableface)
        DataGridView1.DataSource = tableface
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim connectionneck As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterneck As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3003", connectionneck)
        Dim tableneck As New DataTable()
        adapterneck.Fill(tableneck)
        DataGridView1.DataSource = tableneck
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim connectionjewelry As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterjewelry As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3007", connectionjewelry)
        Dim tablejewelry As New DataTable()
        adapterjewelry.Fill(tablejewelry)
        DataGridView1.DataSource = tablejewelry
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim connectionwrist As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterwrist As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3008", connectionwrist)
        Dim tablewrist As New DataTable()
        adapterwrist.Fill(tablewrist)
        DataGridView1.DataSource = tablewrist
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim connectionbooster As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterbooster As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3009", connectionbooster)
        Dim tablebooster As New DataTable()
        adapterbooster.Fill(tablebooster)
        DataGridView1.DataSource = tablebooster
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim connectiontail As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adaptertail As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 3010", connectiontail)
        Dim tabletail As New DataTable()
        adaptertail.Fill(tabletail)
        DataGridView1.DataSource = tabletail
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim connectionpet As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterpet As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 4001", connectionpet)
        Dim tablepet As New DataTable()
        adapterpet.Fill(tablepet)
        DataGridView1.DataSource = tablepet
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim connectionsymbol As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adaptersymbol As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 5010 ", connectionsymbol)
        Dim tablesymbol As New DataTable()
        adaptersymbol.Fill(tablesymbol)
        DataGridView1.DataSource = tablesymbol
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim connectioncharacter As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adaptercharacter As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 1001 ", connectioncharacter)
        Dim tablecharacter As New DataTable()
        adaptercharacter.Fill(tablecharacter)
        DataGridView1.DataSource = tablecharacter
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim connectionspecial As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adapterspecial As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 1003 ", connectionspecial)
        Dim tablespecial As New DataTable()
        adapterspecial.Fill(tablespecial)
        DataGridView1.DataSource = tablespecial
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim connectiontrans As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim adaptertrans As New MySqlDataAdapter("select * from tblavataritemdesc where fdItemCategory = 1002 ", connectiontrans)
        Dim tabletrans As New DataTable()
        adaptertrans.Fill(tabletrans)
        DataGridView1.DataSource = tabletrans
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim connectionsearch As New MySqlConnection("server=127.0.0.1;userid=root;password=b89cd5e5d1a51dd06;database=tr_game_db")
        Dim commandsearch As New MySqlCommand("select * from tblavataritemdesc where fdItemNum = @fdItemNum", connectionsearch)
        commandsearch.Parameters.Add("@fdItemNum", MySqlDbType.Int32).Value = TextBox1.Text
        Dim adaptersearch As New MySqlDataAdapter(commandsearch)
        Dim tablesearch As New DataTable()
        adaptersearch.Fill(tablesearch)
        DataGridView1.DataSource = tablesearch
    End Sub
End Class