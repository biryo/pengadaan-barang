Imports MySql.Data.MySqlClient

Public Class PA
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub load()
        hapus.Text = ""
        If add_list.Checked = True Then

        Else
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent()
        End If
        nm_brg.Items.Clear()
        delete.Enabled = False
        edit.Enabled = False
        save.Enabled = True

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("SELECT nm_brg FROM barang", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            nm_brg.Items.Add(dr.Item(0))
        Loop
        con.Close()

        con.Open()
        cmd = New MySqlCommand("SELECT no_pa FROM pa group by no_pa", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            detail.Items.Add(dr.Item(0))
        Loop
        con.Close()

        Dim query As String

        If detail.Text = "" Then
            query = "SELECT * FROM pa group by no_pa"
        Else
            query = "SELECT * FROM rfq where no_pa='" & detail.Text & "'"
        End If

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        con.Close()
        If add_list.Checked = True Then
            id_pa.Clear()
            nm_brg.SelectedIndex = -1
            nm_brg.Text = ""
            price_unit.Clear()
            qty.Clear()
            unit.Clear()
        Else
            id_pa.Clear()
            no_pa.Clear()
            prjk_nm.Clear()
            dtp.ResetText()
            nm_brg.SelectedIndex = -1
            price_unit.Clear()
            qty.Clear()
            unit.Clear()
        End If


        Me.DataGridView1.Columns(0).HeaderText = "ID PA"
        Me.DataGridView1.Columns(1).HeaderText = "No PA"
        Me.DataGridView1.Columns(2).HeaderText = "Nama Projek"
        Me.DataGridView1.Columns(3).HeaderText = "Tanggal"
        Me.DataGridView1.Columns(4).HeaderText = "Deskripsi"
        Me.DataGridView1.Columns(5).HeaderText = "Harga/Unit"
        Me.DataGridView1.Columns(6).HeaderText = "QTY"
        Me.DataGridView1.Columns(7).HeaderText = "Satuan"
        Me.DataGridView1.Columns(8).HeaderText = "Jenis Jabatan"
    End Sub

    Private Sub PA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

	Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

        hapus.Text = "hapus"
        price_unit.Text = price_unit.Text.Replace(",", "")
        price_unit.Text = price_unit.Text.Replace(".", "")

        Dim cmd As MySqlCommand
        If no_pa.Text = "" Or prjk_nm.Text = "" Or nm_brg.Text = "" Or price_unit.Text = "" Or qty.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
				con.Open()
				cmd = con.CreateCommand
				cmd.CommandText = "INSERT INTO `pa` (`no_pa`, `prjk_nm`, `date`, `deskripsi`, `hrg_unit`, `qty`, `satuan`) VALUES (@no_pa, @prjk_nm, @date, @deskripsi, @hrg_unit, @qty, @satuan);"

				cmd.Parameters.AddWithValue("@no_pa", no_pa.Text)
				cmd.Parameters.AddWithValue("@prjk_nm", prjk_nm.Text)
				cmd.Parameters.AddWithValue("@date", dtp.Text)
				cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
				cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
				cmd.Parameters.AddWithValue("@qty", qty.Text)
				cmd.Parameters.AddWithValue("@satuan", unit.Text)

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
			cmd.CommandText = "delete from pa where id_pa=@id_pa;"

            cmd.Parameters.AddWithValue("@id_pa", id_pa.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            load()
        Catch ex As Exception

		End Try
	End Sub

	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
		delete.Enabled = True
		edit.Enabled = True
		save.Enabled = False

		Dim row As DataGridViewRow = DataGridView1.CurrentRow
		Try
			id_pa.Text = row.Cells(0).Value.ToString()
			no_pa.Text = row.Cells(1).Value.ToString()
			prjk_nm.Text = row.Cells(2).Value.ToString()
			dtp.Text = row.Cells(3).Value.ToString()
			nm_brg.Text = row.Cells(4).Value.ToString()
			price_unit.Text = row.Cells(5).Value.ToString()
			qty.Text = row.Cells(6).Value.ToString()
			unit.Text = row.Cells(7).Value.ToString()
		Catch ex As Exception

		End Try
	End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        load()
    End Sub

	Private Sub detail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detail.SelectedIndexChanged
		Dim query As String

		If detail.Text = "" Then
			query = "SELECT * FROM pa group by no_pa"
		Else
			query = "SELECT * FROM pa where no_pa='" & detail.Text & "'"
		End If

		Dim adpt As New MySqlDataAdapter(query, con)
		Dim ds As New DataSet()
		adpt.Fill(ds)
		DataGridView1.DataSource = ds.Tables(0)
	End Sub

	Private Sub detail_TextChanged(sender As Object, e As EventArgs) Handles detail.TextChanged
		Dim query As String

		If detail.Text = "" Then
			query = "SELECT * FROM pa group by no_pa"
			Dim adpt As New MySqlDataAdapter(query, con)
			Dim ds As New DataSet()
			adpt.Fill(ds)
			DataGridView1.DataSource = ds.Tables(0)
		Else

		End If
	End Sub

    Private Sub price_unit_TextChanged(sender As Object, e As EventArgs) Handles price_unit.TextChanged
        If price_unit.Text = "" Then

        ElseIf hapus.Text = "hapus" Then

        Else
            Dim titik As Long
            titik = price_unit.Text
            price_unit.Text = Format(titik, "#,##0")
            price_unit.SelectionStart = Len(price_unit.Text)
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        hapus.Text = "hapus"
        price_unit.Text = price_unit.Text.Replace(",", "")
        price_unit.Text = price_unit.Text.Replace(".", "")

        Dim cmd As MySqlCommand
        If id_pa.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "Update `pa` Set `no_pa`=@no_pa, `prjk_nm`=@prjk_nm, `date`=@date, `deskripsi`=@deskripsi, `hrg_unit`=@hrg_unit, `qty`=@qty, `satuan`=@satuan where id_pa= '" & id_pa.Text & "';"

                cmd.Parameters.AddWithValue("@no_pa", no_pa.Text)
                cmd.Parameters.AddWithValue("@prjk_nm", prjk_nm.Text)
                cmd.Parameters.AddWithValue("@date", dtp.Text)
                cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
                cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                cmd.Parameters.AddWithValue("@qty", qty.Text)
                cmd.Parameters.AddWithValue("@satuan", unit.Text)

                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub add_list_CheckedChanged(sender As Object, e As EventArgs) Handles add_list.CheckedChanged

    End Sub

    Private Sub tmbh_data_Click(sender As Object, e As EventArgs) Handles tmbh_data.Click
        add_list.Checked = True
        save.PerformClick()
        add_list.Checked = False
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class