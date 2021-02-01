Imports MySql.Data.MySqlClient

Public Class inputlogistik
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub load()
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True

        Dim query As String = "SELECT * from logistik"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        id_logistik.Clear()
        resi.Clear()
        jenis_pengiriman.Clear()
        nm_jasa.Clear()
        estimasi_waktu.Clear()
        tmpt_tujuan.Clear()
        no_poo.SelectedIndex = -1
        stts.SelectedIndex = -1
        dtp1.ResetText()


        Me.DataGridView1.Columns(0).HeaderText = "ID"
        Me.DataGridView1.Columns(1).HeaderText = "No Resi"
        Me.DataGridView1.Columns(2).HeaderText = "Jasa Pengiriman"
        Me.DataGridView1.Columns(3).HeaderText = "Nama Jasa"
        Me.DataGridView1.Columns(4).HeaderText = "Estimasi Waktu"
        Me.DataGridView1.Columns(5).HeaderText = "Tujuan"
        Me.DataGridView1.Columns(6).HeaderText = "No PO"
        Me.DataGridView1.Columns(7).HeaderText = "Status Pengiriman"
        Me.DataGridView1.Columns(8).HeaderText = "Tanggal"
    End Sub

    Private Sub inputlogistik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
        Dim query As String = "SELECT * FROM PO"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dt As New DataTable()
        adpt.Fill(dt)
        no_poo.DataSource = dt

        no_poo.DisplayMember = "po"
        no_poo.ValueMember = "po"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        If resi.Text = "" Or nm_jasa.Text = "" Or jenis_pengiriman.Text = "" Or tmpt_tujuan.Text = "" Or estimasi_waktu.Text = "" Or no_poo.Text = "" Or stts.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "INSERT INTO logistik (`resi`, `jasper`, `nm_jasa`, `estimasi_waktu`, `tujuan`, `no_po`, `status_pengiriman`, `tgl`) VALUES (@resi, @jasper, @nm_jasa, @estimasi_waktu, @tujuan, @no_po, @status_pengiriman, @tgl);"

                cmd.Parameters.AddWithValue("@resi", resi.Text)
                cmd.Parameters.AddWithValue("@jasper", jenis_pengiriman.Text)
                cmd.Parameters.AddWithValue("@nm_jasa", nm_jasa.Text)
                cmd.Parameters.AddWithValue("@estimasi_waktu", estimasi_waktu.Text)
                cmd.Parameters.AddWithValue("@tujuan", tmpt_tujuan.Text)
                cmd.Parameters.AddWithValue("@no_po", no_poo.Text)
                cmd.Parameters.AddWithValue("@status_pengiriman", stts.Text)
                cmd.Parameters.AddWithValue("@tgl", dtp1.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_logistik.Text = row.Cells(0).Value.ToString()
            resi.Text = row.Cells(1).Value.ToString()
            jenis_pengiriman.Text = row.Cells(2).Value.ToString()
            nm_jasa.Text = row.Cells(3).Value.ToString()
            estimasi_waktu.Text = row.Cells(4).Value.ToString()
            tmpt_tujuan.Text = row.Cells(5).Value.ToString()
            no_poo.Text = row.Cells(6).Value.ToString()
            stts.Text = row.Cells(7).Value.ToString()
            dtp1.Text = row.Cells(8).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As MySqlCommand
        If resi.Text = "" Or nm_jasa.Text = "" Or jenis_pengiriman.Text = "" Or tmpt_tujuan.Text = "" Or estimasi_waktu.Text = "" Or no_poo.Text = "" Or stts.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "UPDATE logistik SET resi = @resi, jasper = @jasper, nm_jasa = @nm_jasa, estimasi_waktu = @estimasi_waktu, tujuan = @tujuan, no_po = @no_po, status_pengiriman = @status_pengiriman, tgl = @tgl WHERE id_logistik = @id_logistik ;"

                cmd.Parameters.AddWithValue("@id_logistik", id_logistik.Text)
                cmd.Parameters.AddWithValue("@resi", resi.Text)
                cmd.Parameters.AddWithValue("@jasper", jenis_pengiriman.Text)
                cmd.Parameters.AddWithValue("@nm_jasa", nm_jasa.Text)
                cmd.Parameters.AddWithValue("@estimasi_waktu", estimasi_waktu.Text)
                cmd.Parameters.AddWithValue("@tujuan", tmpt_tujuan.Text)
                cmd.Parameters.AddWithValue("@no_po", no_poo.Text)
                cmd.Parameters.AddWithValue("@status_pengiriman", stts.Text)
                cmd.Parameters.AddWithValue("@tgl", dtp1.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "delete from logistik where id_logistik=@id_logistik;"

            cmd.Parameters.AddWithValue("@id_logistik", id_logistik.Text)
            cmd.ExecuteNonQuery()
            load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub no_poo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles no_poo.SelectedIndexChanged

    End Sub

    Private Sub stts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stts.SelectedIndexChanged

    End Sub

    Private Sub tmpt_tujuan_TextChanged(sender As Object, e As EventArgs) Handles tmpt_tujuan.TextChanged

    End Sub

    Private Sub estimasi_waktu_TextChanged(sender As Object, e As EventArgs) Handles estimasi_waktu.TextChanged

    End Sub

    Private Sub nm_jasa_TextChanged(sender As Object, e As EventArgs) Handles nm_jasa.TextChanged

    End Sub

    Private Sub jenis_pengiriman_TextChanged(sender As Object, e As EventArgs) Handles jenis_pengiriman.TextChanged

    End Sub

    Private Sub resi_TextChanged(sender As Object, e As EventArgs) Handles resi.TextChanged

    End Sub

    Private Sub id_logistik_TextChanged(sender As Object, e As EventArgs) Handles id_logistik.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class