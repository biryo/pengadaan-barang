Imports MySql.Data.MySqlClient
Public Class Customer
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;"
    Dim con As New MySqlConnection(str)

    Sub load()
        Button1.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        Dim query As String = "select * from Vendor"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        con.Open()
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        pt.Clear()
        cus.Clear()
        add.Clear()
        cp.Clear()

        Me.DataGridView1.Columns(0).HeaderText = "ID Vendor"
        Me.DataGridView1.Columns(1).HeaderText = "Nama PT"
        Me.DataGridView1.Columns(2).HeaderText = "Nama Orang"
        Me.DataGridView1.Columns(3).HeaderText = "Kontak"
        Me.DataGridView1.Columns(4).HeaderText = "Alamat"
        Me.DataGridView1.Columns(5).HeaderText = "Deskripsi"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        If pt.Text = "" Or cus.Text = "" Or add.Text = "" Or cp.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update vendor set pt_vendor=@pt, nm_vendor=@cus,cp=@cp,alamat=@add where id_vendor=@id_vendor"

                cmd.Parameters.AddWithValue("@id_vendor", id_vendor.Text)
                cmd.Parameters.AddWithValue("@pt", pt.Text)
                cmd.Parameters.AddWithValue("@cus", cus.Text)
                cmd.Parameters.AddWithValue("@add", add.Text)
                cmd.Parameters.AddWithValue("@cp", cp.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            load()
        End If

        Input_RFQ.reload()
        FormPO.reload()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As MySqlCommand

        con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from vendor where id_vendor=@id_vendor;"

            cmd.Parameters.AddWithValue("@id_vendor", id_vendor.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            load()

            Input_RFQ.reload()
        FormPO.reload()
    End Sub

    Private Sub Vendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        If pt.Text = "" Or cus.Text = "" Or add.Text = "" Or cp.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into vendor (pt_vendor,nm_vendor,cp,alamat)values(@pt,@cus,@cp,@add);"

                cmd.Parameters.AddWithValue("@pt", pt.Text)
                cmd.Parameters.AddWithValue("@cus", cus.Text)
                cmd.Parameters.AddWithValue("@add", add.Text)
                cmd.Parameters.AddWithValue("@cp", cp.Text)

                cmd.ExecuteNonQuery()
                con.Close()
            load()
        End If

        Input_RFQ.reload()
        FormPO.reload()
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs)
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        con.Open()
            adapter = New MySqlDataAdapter("select * from vendor where pt_vendor like '%" & search.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
            adapter = New MySqlDataAdapter("select * from vendor where pt_vendor like '%" & search.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search.KeyPress
        If search.Text = "Search" Then
            search.Text = ""
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button1.Enabled = False
        Button4.Enabled = True
        Button3.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_vendor.Text = row.Cells(0).Value.ToString()
            pt.Text = row.Cells(1).Value.ToString()
            cus.Text = row.Cells(2).Value.ToString()
            cp.Text = row.Cells(3).Value.ToString()
            add.Text = row.Cells(4).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub
End Class