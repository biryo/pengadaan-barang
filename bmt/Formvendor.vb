Imports MySql.Data.MySqlClient

Public Class Formvendor
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub load()
        delete.Enabled = False
        Button1.Enabled = False
        simpan.Enabled = True
        Dim query As String = "SELECT * FROM vendor"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "vendor")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        id_vendor.Clear()
        pt_vendor.Clear()
        nm_vendor.Clear()
        cp.Clear()
        alamat.Clear()
        deskripsi.Clear()


        Me.DataGridView1.Columns(0).HeaderText = "ID Vendor"
        Me.DataGridView1.Columns(1).HeaderText = "Nama PT"
        Me.DataGridView1.Columns(2).HeaderText = "Nama Orang"
        Me.DataGridView1.Columns(3).HeaderText = "Kontak"
        Me.DataGridView1.Columns(4).HeaderText = "Alamat"
        Me.DataGridView1.Columns(5).HeaderText = "Deskripsi"
    End Sub

    Private Sub Formvendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        simpan.Enabled = False
        Button1.Enabled = True
        delete.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_vendor.Text = row.Cells(0).Value.ToString()
            pt_vendor.text = row.Cells(1).Value.ToString()
            nm_vendor.Text = row.Cells(2).Value.ToString()
            cp.Text = row.Cells(3).Value.ToString()
            alamat.Text = row.Cells(4).Value.ToString()
            deskripsi.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        If pt_vendor.Text = "" Or nm_vendor.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
            Try

                cmd = con.CreateCommand
                cmd.CommandText = "update vendor set pt_vendor=@pt_vendor, nm_vendor=@nm_vendor , cp=@cp, alamat=@alamat, deskripsi=@deskripsi where id_vendor =@id_vendor "
                cmd.Parameters.AddWithValue("@id_vendor", id_vendor.Text)
                cmd.Parameters.AddWithValue("pt_vendor", pt_vendor.Text)
                cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)
                cmd.Parameters.AddWithValue("@cp", cp.Text)
                cmd.Parameters.AddWithValue("@alamat", alamat.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "delete from vendor where id_vendor=@id_vendor;"

            cmd.Parameters.AddWithValue("@id_vendor", id_vendor.Text)
            cmd.ExecuteNonQuery()
            load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim cmd As MySqlCommand
        If pt_vendor.Text = "" Or nm_vendor.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into vendor (pt_vendor,nm_vendor,cp,alamat,deskripsi)values(@pt_vendor,@nm_vendor,@cp,@alamat,@deskripsi);"

                cmd.Parameters.AddWithValue("@id_vendor", id_vendor.Text)
                cmd.Parameters.AddWithValue("@pt_vendor", pt_vendor.Text)
                cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)
                cmd.Parameters.AddWithValue("@cp", cp.Text)
                cmd.Parameters.AddWithValue("@alamat", alamat.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception

            End Try
            Input_RFQ.reload()
            FormPO.reload()
        End If
    End Sub

    Private Sub deskripsi_TextChanged(sender As Object, e As EventArgs) Handles deskripsi.TextChanged

    End Sub

    Private Sub id_vendor_TextChanged(sender As Object, e As EventArgs) Handles id_vendor.TextChanged

    End Sub

    Private Sub pt_vendor_TextChanged(sender As Object, e As EventArgs) Handles pt_vendor.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapter = New MySqlDataAdapter("select * from vendor where deskripsi like '%" & search.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class