Imports MySql.Data.MySqlClient

Public Class Gudang
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub load()
        delete.Enabled = False
        edit.Enabled = False
        simpan.Enabled = True
        Dim query As String = "SELECT * FROM gudang"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        id_gdg.clear()
        unit.Clear()
        stok.Clear()
        partnumber.Clear()
        deskripsi.Clear()


        Me.DataGridView1.Columns(0).HeaderText = "ID"
        Me.DataGridView1.Columns(1).HeaderText = "Deskripsi"
        Me.DataGridView1.Columns(2).HeaderText = "Partnumber"
        Me.DataGridView1.Columns(3).HeaderText = "Stok"
        Me.DataGridView1.Columns(4).HeaderText = "Unit"
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Gudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        simpan.Enabled = False
        edit.Enabled = True
        delete.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_gdg.Text = row.Cells(0).Value.ToString()
            unit.Text = row.Cells(4).Value.ToString()
            stok.Text = row.Cells(3).Value.ToString()
            partnumber.Text = row.Cells(2).Value.ToString()
            deskripsi.Text = row.Cells(1).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim cmd As MySqlCommand
        If id_gdg.Text = "" Or unit.Text = "" Or stok.Text = "" Or deskripsi.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
            cmd = con.CreateCommand
                cmd.CommandText = "update gudang set id_gdg=@id_gdg, unit=@unit, stok=@stok, partnumber=@partnumber, deskripsi=@deskripsi where id_gdg=@id_gdg"
                cmd.Parameters.AddWithValue("@id_gdg", id_gdg.Text)
                cmd.Parameters.AddWithValue("@unit", unit.Text)
                cmd.Parameters.AddWithValue("@stok", stok.Text)
                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim cmd As MySqlCommand
        con.Open()
        cmd = con.CreateCommand
            cmd.CommandText = "delete from gudang where id_gdg=@id_gdg;"

            cmd.Parameters.AddWithValue("@id_gdg", id_gdg.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            load()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim cmd As MySqlCommand
        If unit.Text = "" Or stok.Text = "" Or deskripsi.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into gudang (deskripsi,partnumber,stok,unit)values(@deskripsi,@partnumber,@stok,@unit);"

                cmd.Parameters.AddWithValue("@unit", unit.Text)
                cmd.Parameters.AddWithValue("@stok", stok.Text)
                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        load()
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles search.Click
        search.Text = ""
    End Sub

    Private Sub search_Leave(sender As Object, e As EventArgs) Handles search.Leave
        If search.Text = "" Then
            search.Text = "Search"
        Else

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub partnumber_TextChanged(sender As Object, e As EventArgs) Handles partnumber.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
            adapter = New MySqlDataAdapter("select * from gudang where deskripsi like '%" & search.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
    End Sub
End Class