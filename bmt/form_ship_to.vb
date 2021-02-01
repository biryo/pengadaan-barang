Imports MySql.Data.MySqlClient

Public Class form_ship_to

    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;"
    Dim con As New MySqlConnection(str)

    Sub load()
        Button3.Enabled = False
        Button4.Enabled = False
        Button2.Enabled = True

        Dim query As String = "SELECT * from ship_to"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        nm_penerima.Clear()
        nm_pt.Clear()
        alamat.Clear()
        kontak.Clear()


        Me.DataGridView1.Columns(0).HeaderText = "ID"
        Me.DataGridView1.Columns(1).HeaderText = "Nama Penerima"
        Me.DataGridView1.Columns(2).HeaderText = "Nama PT"
        Me.DataGridView1.Columns(3).HeaderText = "Alamat"
        Me.DataGridView1.Columns(4).HeaderText = "Kontak"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        load()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from ship_to where id_to=@id_to;"

            cmd.Parameters.AddWithValue("@id_to", id_to.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        load()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As MySqlCommand
        If nm_penerima.Text = "" Or nm_pt.Text = "" Or alamat.Text = "" Or kontak.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update ship_to set nm_penerima=@nm_penerima,nm_pt=@nm_pt,alamat=@alamat,kontak=@kontak where id_to=@id_to"

                cmd.Parameters.AddWithValue("@id_to", id_to.Text)
                cmd.Parameters.AddWithValue("@nm_penerima", nm_penerima.Text)
                cmd.Parameters.AddWithValue("@nm_pt", nm_pt.Text)
                cmd.Parameters.AddWithValue("@alamat", alamat.Text)
                cmd.Parameters.AddWithValue("@kontak", kontak.Text)

                cmd.ExecuteNonQuery()
                con.Close()
                load()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As MySqlCommand
        If nm_penerima.Text = "" Or nm_pt.Text = "" Or alamat.Text = "" Or kontak.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into ship_to (nm_penerima,nm_pt,alamat,kontak)values(@nm_penerima,@nm_pt,@alamat,@kontak);"

                cmd.Parameters.AddWithValue("@id_to", id_to.Text)
                cmd.Parameters.AddWithValue("@nm_penerima", nm_penerima.Text)
                cmd.Parameters.AddWithValue("@nm_pt", nm_pt.Text)
                cmd.Parameters.AddWithValue("@alamat", alamat.Text)
                cmd.Parameters.AddWithValue("@kontak", kontak.Text)

                cmd.ExecuteNonQuery()
                con.Close()
            load()
            FormPO.reload()
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub form_ship_to_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button2.Enabled = False
        Button4.Enabled = True
        Button3.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_to.Text = row.Cells(0).Value.ToString()
            nm_penerima.Text = row.Cells(1).Value.ToString()
            nm_pt.Text = row.Cells(2).Value.ToString()
            alamat.Text = row.Cells(3).Value.ToString()
            kontak.Text = row.Cells(4).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class