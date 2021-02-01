Imports MySql.Data.MySqlClient

Public Class FormBrg

    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;"
    Dim con As New MySqlConnection(str)

    Sub load()
        Button3.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = False
        Dim query As String = "select * from barang"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        nm_brg.Clear()
        partnumber.Clear()
        brand.Clear()
        nm_vendor.Clear()
        deskripsi.Clear()


        Me.DataGridView1.Columns(0).HeaderText = "ID Barang"
        Me.DataGridView1.Columns(1).HeaderText = "Nama Vendor"
        Me.DataGridView1.Columns(2).HeaderText = "Nama Barang"
        Me.DataGridView1.Columns(3).HeaderText = "Brand"
        Me.DataGridView1.Columns(4).HeaderText = "Partnumber"
        Me.DataGridView1.Columns(5).HeaderText = "Deskripsi"
    End Sub

    Private Sub FormBrg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_brg.Text = row.Cells(0).Value.ToString()
            nm_vendor.Text = row.Cells(1).Value.ToString()
            nm_brg.Text = row.Cells(2).Value.ToString()
            brand.Text = row.Cells(3).Value.ToString()
            partnumber.Text = row.Cells(4).Value.ToString()
            deskripsi.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "delete from barang where id_brg=@id_brg;"

            cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)
            cmd.ExecuteNonQuery()
            load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub nm_brg_TextChanged(sender As Object, e As EventArgs) Handles nm_brg.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As MySqlCommand
        If nm_brg.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update barang set partnumber=@partnumber, brand=@brand,nm_brg=@nm_brg,nm_vendor=@nm_vendor,deskripsi=@deskripsi where id_brg=@id_brg"

                cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)
                cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
                cmd.Parameters.AddWithValue("@brand", brand.Text)
                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        If nm_brg.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into barang (partnumber,brand,nm_brg,nm_vendor,deskripsi)values(@partnumber,@brand,@nm_brg,@nm_vendor,@deskripsi);"

                cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
                cmd.Parameters.AddWithValue("@brand", brand.Text)
                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)

                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub nm_vendor_TextChanged(sender As Object, e As EventArgs) Handles nm_vendor.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If search.Text = "Search" Then
            search.Text = ""
        Else

        End If
    End Sub

    Private Sub search_Leave(sender As Object, e As EventArgs) Handles search.Leave
        If search.Text = "" Then
            search.Text = "Search"
        Else

        End If
    End Sub

    Private Sub deskripsi_TextChanged(sender As Object, e As EventArgs) Handles deskripsi.TextChanged

    End Sub

    Private Sub partnumber_TextChanged(sender As Object, e As EventArgs) Handles partnumber.TextChanged

    End Sub

    Private Sub brand_TextChanged(sender As Object, e As EventArgs) Handles brand.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapter = New MySqlDataAdapter("select * from barang where nm_brg like '%" & search.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class