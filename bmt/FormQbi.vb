Imports MySql.Data.MySqlClient

Public Class FormQbi
	Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
	Dim con As New MySqlConnection(str)

	Sub load()
		If notif.Text = "ada" Then
            detail.Items.Clear()
            no_rfq.Items.Clear()
        Else
			Me.Controls.Clear() 'removes all the controls on the form
			InitializeComponent()
		End If

        'revisi.Enabled = False
        'edit.Enabled = False
        delete.Enabled = False
		Button5.Enabled = True
        hapus.Text = ""

        Dim cmd As MySqlCommand
		Dim dr As MySqlDataReader
		con.Open()
		cmd = New MySqlCommand("select no_rfq from rfq GROUP by no_rfq", con)
		dr = cmd.ExecuteReader
		Do While dr.Read
			no_rfq.Items.Add(dr.Item(0))
		Loop
		con.Close()

		con.Open()
		cmd = New MySqlCommand("select no_qbi from qbi GROUP by no_qbi", con)
		dr = cmd.ExecuteReader
		Do While dr.Read
			detail.Items.Add(dr.Item(0))
		Loop
		con.Close()

		Dim query As String
		If detail.Text = "" Then
			query = "SELECT * from qbi group by no_qbi"
		Else
			query = "SELECT * from qbi where no_qbi='" & detail.Text & "'"
		End If

		Dim adpt As New MySqlDataAdapter(query, con)
		Dim ds As New DataSet()
		adpt.Fill(ds, "qbi")
		DataGridView1.DataSource = ds.Tables(0)
		con.Close()

		If CheckBox1.Checked = True Then
			id_rfq.Clear()
			ttl.Clear()
			hrg_satuan.Clear()
			nm_brg.Clear()
			qty.Clear()
			hrg_ttl.Clear()
			partnumber.Clear()
		Else
			id_rfq.Clear()
			id_qbi.Clear()
			no_qbi.Clear()
			no_rfq.SelectedIndex = -1
			ttl.Clear()
			ya.Checked = True
			hrg_satuan.Clear()
			nm_brg.Clear()
			qty.Clear()
			hrg_ttl.Clear()
			partnumber.Clear()
			masa_berlaku.Clear()
			rev.Clear()
			perihal.Clear()
			payment.Clear()
			garansi.Clear()
			DateTimePicker1.ResetText()
			DateTimePicker2.ResetText()
		End If

		Me.DataGridView1.Columns(0).HeaderText = "ID QBI"
		Me.DataGridView1.Columns(1).HeaderText = "No QBI"
		Me.DataGridView1.Columns(2).HeaderText = "ID RFQ"
		Me.DataGridView1.Columns(3).HeaderText = "No RFQ"
		Me.DataGridView1.Columns(4).HeaderText = "Total"
		Me.DataGridView1.Columns(5).HeaderText = "Tanggal QBI"
		Me.DataGridView1.Columns(6).HeaderText = "Tanggal Tempo"
		Me.DataGridView1.Columns(7).HeaderText = "PPN"
		Me.DataGridView1.Columns(8).HeaderText = "Harga Satuan"
		Me.DataGridView1.Columns(9).HeaderText = "Harga Total"
		Me.DataGridView1.Columns(10).HeaderText = "QTY"
		Me.DataGridView1.Columns(11).HeaderText = "Partnumber"
		Me.DataGridView1.Columns(12).HeaderText = "Revisi"
		Me.DataGridView1.Columns(13).HeaderText = "Masa Berlaku"
		Me.DataGridView1.Columns(14).HeaderText = "Perihal"
		Me.DataGridView1.Columns(15).HeaderText = "Payment"
		Me.DataGridView1.Columns(16).HeaderText = "Garansi"

		'HEADER TIDAK BISA DI CLIK
		Me.DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
		Me.DataGridView1.Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(16).SortMode = DataGridViewColumnSortMode.NotSortable


    End Sub

	Private Sub FormQbi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		load()
	End Sub

	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
		Button5.Enabled = False
		revisi.Enabled = True
        edit.Enabled = True
        delete.Enabled = True

		Dim row As DataGridViewRow = DataGridView1.CurrentRow
		Try
			id_qbi.Text = row.Cells(0).Value.ToString()
			no_qbi.Text = row.Cells(1).Value.ToString()
			id_rfq.Text = row.Cells(2).Value.ToString()
			no_rfq.Text = row.Cells(3).Value.ToString()
			ttl.Text = row.Cells(4).Value.ToString()
			DateTimePicker1.Text = row.Cells(5).Value.ToString()
			DateTimePicker2.Text = row.Cells(6).Value.ToString()
			ppn.Text = row.Cells(7).Value.ToString()
			hrg_satuan.Text = row.Cells(8).Value.ToString()
			hrg_ttl.Text = row.Cells(9).Value.ToString()
			qty.Text = row.Cells(10).Value.ToString()
			partnumber.Text = row.Cells(11).Value.ToString()
			rev.Text = row.Cells(12).Value.ToString()
			masa_berlaku.Text = row.Cells(13).Value.ToString()
			perihal.Text = row.Cells(14).Value.ToString()
			payment.Text = row.Cells(15).Value.ToString()
			garansi.Text = row.Cells(16).Value.ToString()
		Catch ex As Exception

		End Try

		Dim query As String = "SELECT * FROM rfq as r,barang as b where b.partnumber=r.partnumber and r.no_rfq='" & no_rfq.Text & "'"
		Dim adpt As New MySqlDataAdapter(query, con)
		Dim ds As New DataSet
		adpt.Fill(ds)
		DataGridView2.DataSource = ds.Tables(0)

		Dim querys As String = "SELECT * FROM barang where partnumber='" & partnumber.Text & "'"
		Dim adpts As New MySqlDataAdapter(querys, con)
		Dim dts As New DataTable
		adpts.Fill(dts)
        If dts.Rows.Count > 0 Then
            nm_brg.Text = dts.Rows(0).Item("nm_brg").ToString()
        End If
    End Sub

	Private Sub id_rfq_TextChanged(sender As Object, e As EventArgs) Handles id_rfq.TextChanged

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub id_qbi_TextChanged(sender As Object, e As EventArgs) Handles id_qbi.TextChanged

	End Sub

	Private Sub hrg_satuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hrg_satuan.KeyPress
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub qtyKeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub QTY_KeyPress(sender As Object, e As KeyPressEventArgs)
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub ongkir_KeyPress(sender As Object, e As KeyPressEventArgs)
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub


	Private Sub ttl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ttl.KeyPress
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
		notif.Text = ""
		Dim cmd As MySqlCommand
		Try
			con.Open()
			cmd = con.CreateCommand
			cmd.CommandText = "delete from qbi where id_qbi=@id_qbi;"

			cmd.Parameters.AddWithValue("@id_qbi", id_qbi.Text)
			cmd.ExecuteNonQuery()
			con.Close()

			load()

		Catch ex As Exception

		End Try
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		If CheckBox1.Checked = True Then
		Else
			notif.Text = ""
		End If
		hapus.Text = "hapus"
		hrg_satuan.Text = hrg_satuan.Text.Replace(",", "")
		hrg_satuan.Text = hrg_satuan.Text.Replace(".", "")
		hrg_ttl.Text = hrg_ttl.Text.Replace(",", "")
		hrg_ttl.Text = hrg_ttl.Text.Replace(".", "")

		Dim cmd As MySqlCommand
        If no_qbi.Text = "" Or no_rfq.Text = "" Or ppn.Text = "" Or hrg_satuan.Text = "" Or masa_berlaku.Text = "" Or rev.Text = "" Or hrg_ttl.Text = "" Or payment.Text = "" Or perihal.Text = "" Or garansi.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
			cmd = con.CreateCommand
			cmd.CommandText = "update rfq set stts_rfq='Terbuat' where id_rfq=@id_rfq"

			cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)

			cmd.ExecuteNonQuery()
			con.Close()

			If CheckBox1.Checked = True Then

			Else
				con.Open()
				cmd = con.CreateCommand
				cmd.CommandText = "insert into kode_qbi (no_qbi)values(@no_qbi);"

				cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)

				cmd.ExecuteNonQuery()
				con.Close()
			End If

			Dim query As String = "SELECT * FROM qbi where no_qbi='" & no_qbi.Text & "'"
			Dim adpt As New MySqlDataAdapter(query, con)
			Dim dt As New DataTable
			adpt.Fill(dt)

			Try
				If dt.Rows.Count > 0 Then

					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "insert into qbi (no_qbi,id_rfq,no_rfq,ttl,tgl_qbi,tgl_tempo,ppn,hrg_satuan,hrg_ttl,qty,masa_berlaku,revisi,partnumber,perihal,payment,garansi)values(@no_qbi,@id_rfq,@no_rfq,@ttl,@tgl_qbi,@tgl_tempo,@ppn,@hrg_satuan,@hrg_ttl,@qty,@masa_berlaku,@revisi,@partnumber,@perihal,@payment,@garansi);"

					cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
					cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)
					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@ttl", ttl.Text)
					cmd.Parameters.AddWithValue("@tgl_qbi", DateTimePicker1.Text)
					cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
					cmd.Parameters.AddWithValue("@ppn", ppn.Text)
					cmd.Parameters.AddWithValue("@hrg_satuan", hrg_satuan.Text)
					cmd.Parameters.AddWithValue("@hrg_ttl", hrg_ttl.Text)
					cmd.Parameters.AddWithValue("@qty", qty.Text)
					cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
					cmd.Parameters.AddWithValue("@revisi", rev.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
					cmd.Parameters.AddWithValue("@perihal", perihal.Text)
					cmd.Parameters.AddWithValue("@payment", payment.Text)
					cmd.Parameters.AddWithValue("@garansi", garansi.Text)


					cmd.ExecuteNonQuery()
					con.Close()

					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "update qbi set ttl=@ttl,ppn=@ppn,masa_berlaku=@masa_berlaku,revisi=@revisi,perihal=@perihal,payment=@payment,garansi=@garansi where no_qbi=@no_qbi"

					cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
					cmd.Parameters.AddWithValue("@ttl", ttl.Text)
					cmd.Parameters.AddWithValue("@ppn", ppn.Text)
					cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
					cmd.Parameters.AddWithValue("@revisi", rev.Text)

					cmd.Parameters.AddWithValue("@perihal", perihal.Text)
					cmd.Parameters.AddWithValue("@payment", payment.Text)
					cmd.Parameters.AddWithValue("@garansi", garansi.Text)


					cmd.ExecuteNonQuery()
					con.Close()

					load()
				Else

					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "insert into qbi (no_qbi,id_rfq,no_rfq,ttl,tgl_qbi,tgl_tempo,ppn,hrg_satuan,hrg_ttl,qty,masa_berlaku,revisi,partnumber,perihal,payment,garansi)values(@no_qbi,@id_rfq,@no_rfq,@ttl,@tgl_qbi,@tgl_tempo,@ppn,@hrg_satuan,@hrg_ttl,@qty,@masa_berlaku,@revisi,@partnumber,@perihal,@payment,@garansi);"

					cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
					cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)
					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@ttl", ttl.Text)
					cmd.Parameters.AddWithValue("@tgl_qbi", DateTimePicker1.Text)
					cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
					cmd.Parameters.AddWithValue("@ppn", ppn.Text)
					cmd.Parameters.AddWithValue("@hrg_satuan", hrg_satuan.Text)
					cmd.Parameters.AddWithValue("@hrg_ttl", hrg_ttl.Text)
					cmd.Parameters.AddWithValue("@qty", qty.Text)
					cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
					cmd.Parameters.AddWithValue("@revisi", rev.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
					cmd.Parameters.AddWithValue("@perihal", perihal.Text)
					cmd.Parameters.AddWithValue("@payment", payment.Text)
					cmd.Parameters.AddWithValue("@garansi", garansi.Text)

					cmd.ExecuteNonQuery()
					con.Close()
					load()
				End If

			Catch ex As Exception

			End Try
		End If
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		load()
	End Sub

	Private Sub revisi_Click(sender As Object, e As EventArgs) Handles revisi.Click
		notif.Text = ""
		hapus.Text = "hapus"
		hrg_satuan.Text = hrg_satuan.Text.Replace(",", "")
		hrg_satuan.Text = hrg_satuan.Text.Replace(".", "")
		hrg_ttl.Text = hrg_ttl.Text.Replace(",", "")
		hrg_ttl.Text = hrg_ttl.Text.Replace(".", "")

        Dim cmd As MySqlCommand
		If no_qbi.Text = "" Or no_rfq.Text = "" Or ppn.Text = "" Or hrg_satuan.Text = "" Or masa_berlaku.Text = "" Or rev.Text = "" Or hrg_ttl.Text = "" Then
			MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			Dim revisi As String
			Dim no_qbii As String
			no_qbii = no_qbi.Text
            revisi = rev.Text

            Dim queryy As String = "SELECT * FROM qbi where id_qbi='" & id_qbi.Text & "'"
            Dim adpty As New MySqlDataAdapter(queryy, con)
            Dim dty As New DataTable
            adpty.Fill(dty)
            Dim no_rev As String = dty.Rows(0).Item("revisi")

            Dim query As String = "SELECT * FROM qbi where no_qbi='" & no_qbii & "' and revisi='" & revisi & "'"
			Dim adpt As New MySqlDataAdapter(query, con)
			Dim dt As New DataTable
			adpt.Fill(dt)

			Try
				If dt.Rows.Count > 0 Then
					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "insert into qbi (no_qbi,id_rfq,no_rfq,ttl,tgl_qbi,tgl_tempo,ppn,hrg_satuan,hrg_ttl,qty,masa_berlaku,revisi,partnumber,perihal,payment,garansi)values(@no_qbi,@id_rfq,@no_rfq,@ttl,@tgl_qbi,@tgl_tempo,@ppn,@hrg_satuan,@hrg_ttl,@qty,@masa_berlaku,@revisi,@partnumber,@perihal,@payment,@garansi);"

					cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
					cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)
					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@ttl", ttl.Text)
					cmd.Parameters.AddWithValue("@tgl_qbi", DateTimePicker1.Text)
					cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
					cmd.Parameters.AddWithValue("@ppn", ppn.Text)
					cmd.Parameters.AddWithValue("@hrg_satuan", hrg_satuan.Text)
					cmd.Parameters.AddWithValue("@hrg_ttl", hrg_ttl.Text)
					cmd.Parameters.AddWithValue("@qty", qty.Text)
					cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
					cmd.Parameters.AddWithValue("@revisi", rev.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
					cmd.Parameters.AddWithValue("@perihal", perihal.Text)
					cmd.Parameters.AddWithValue("@payment", payment.Text)
					cmd.Parameters.AddWithValue("@garansi", garansi.Text)


					cmd.ExecuteNonQuery()
					con.Close()

					con.Open()
					cmd = con.CreateCommand
                    cmd.CommandText = "update qbi set ttl=@ttl,ppn=@ppn,masa_berlaku=@masa_berlaku,revisi=@revisi,perihal=@perihal,payment=@payment,garansi=@garansi where no_qbi=@no_qbi and revisi='" & revisi & "'"

                    cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
					cmd.Parameters.AddWithValue("@ttl", ttl.Text)
					cmd.Parameters.AddWithValue("@ppn", ppn.Text)
					cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
					cmd.Parameters.AddWithValue("@revisi", rev.Text)

					cmd.Parameters.AddWithValue("@perihal", perihal.Text)
					cmd.Parameters.AddWithValue("@payment", payment.Text)
					cmd.Parameters.AddWithValue("@garansi", garansi.Text)


					cmd.ExecuteNonQuery()
					con.Close()

					load()
				Else
					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "insert into qbi (no_qbi,id_rfq,no_rfq,ttl,tgl_qbi,tgl_tempo,ppn,hrg_satuan,hrg_ttl,qty,masa_berlaku,revisi,partnumber,perihal,payment,garansi)values(@no_qbi,@id_rfq,@no_rfq,@ttl,@tgl_qbi,@tgl_tempo,@ppn,@hrg_satuan,@hrg_ttl,@qty,@masa_berlaku,@revisi,@partnumber,@perihal,@payment,@garansi);"

					cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
					cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)
					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@ttl", ttl.Text)
					cmd.Parameters.AddWithValue("@tgl_qbi", DateTimePicker1.Text)
					cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
					cmd.Parameters.AddWithValue("@ppn", ppn.Text)
					cmd.Parameters.AddWithValue("@hrg_satuan", hrg_satuan.Text)
					cmd.Parameters.AddWithValue("@hrg_ttl", hrg_ttl.Text)
					cmd.Parameters.AddWithValue("@qty", qty.Text)
					cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
					cmd.Parameters.AddWithValue("@revisi", rev.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
					cmd.Parameters.AddWithValue("@perihal", perihal.Text)
					cmd.Parameters.AddWithValue("@payment", payment.Text)
					cmd.Parameters.AddWithValue("@garansi", garansi.Text)

					cmd.ExecuteNonQuery()
					con.Close()

					load()
				End If

			Catch ex As Exception

			End Try
		End If
	End Sub

	Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
		notif.Text = ""
		hapus.Text = "hapus"
		hrg_satuan.Text = hrg_satuan.Text.Replace(",", "")
		hrg_satuan.Text = hrg_satuan.Text.Replace(".", "")
		hrg_ttl.Text = hrg_ttl.Text.Replace(",", "")
		hrg_ttl.Text = hrg_ttl.Text.Replace(".", "")

        Dim cmd As MySqlCommand
        If no_qbi.Text = "" Or no_rfq.Text = "" Or ppn.Text = "" Or hrg_satuan.Text = "" Or masa_berlaku.Text = "" Or rev.Text = "" Or hrg_ttl.Text = "" Or payment.Text = "" Or perihal.Text = "" Or garansi.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '      Dim query As String = "SELECT * FROM qbi where no_qbi='" & no_qbi.Text & "'"
            '	Dim adpt As New MySqlDataAdapter(query, con)
            '	Dim dt As New DataTable
            '      adpt.Fill(dt)

            Dim queryy As String = "SELECT * FROM qbi where id_qbi='" & id_qbi.Text & "'"
            Dim adpty As New MySqlDataAdapter(queryy, con)
            Dim dty As New DataTable
            adpty.Fill(dty)
            Dim no_rev As String = dty.Rows(0).Item("revisi")
            Try
                'If dt.Rows.Count > 0 Then
                con.Open()
					cmd = con.CreateCommand
                cmd.CommandText = "update qbi set no_qbi=@no_qbi, no_rfq=@no_rfq,ttl=@ttl, tgl_qbi=@tgl_qbi, tgl_tempo=@tgl_tempo, ppn=@ppn, qty=@qty,partnumber=@partnumber,hrg_satuan=@hrg_satuan,hrg_ttl=@hrg_ttl,masa_berlaku=@masa_berlaku,revisi=@revisi,perihal=@perihal,payment=@payment,garansi=@garansi where id_qbi=@id_qbi"

                cmd.Parameters.AddWithValue("@id_qbi", id_qbi.Text)
					cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@ttl", ttl.Text)
					cmd.Parameters.AddWithValue("@tgl_qbi", DateTimePicker1.Text)
					cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
					cmd.Parameters.AddWithValue("@ppn", ppn.Text)
					cmd.Parameters.AddWithValue("@qty", qty.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
					cmd.Parameters.AddWithValue("@hrg_satuan", hrg_satuan.Text)
					cmd.Parameters.AddWithValue("@hrg_ttl", hrg_ttl.Text)
					cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
					cmd.Parameters.AddWithValue("@revisi", rev.Text)
					cmd.Parameters.AddWithValue("@perihal", perihal.Text)
					cmd.Parameters.AddWithValue("@payment", payment.Text)
					cmd.Parameters.AddWithValue("@garansi", garansi.Text)


					cmd.ExecuteNonQuery()
					con.Close()

					con.Open()
					cmd = con.CreateCommand
                cmd.CommandText = "update qbi set ttl=@ttl,ppn=@ppn,masa_berlaku=@masa_berlaku,revisi=@revisi,perihal=@perihal, payment=@payment,garansi=@garansi where no_qbi=@no_qbi and revisi='" & rev.Text & "'"

                cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
					cmd.Parameters.AddWithValue("@ttl", ttl.Text)
					cmd.Parameters.AddWithValue("@ppn", ppn.Text)
					cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
					cmd.Parameters.AddWithValue("@revisi", rev.Text)
					cmd.Parameters.AddWithValue("@perihal", perihal.Text)
					cmd.Parameters.AddWithValue("@payment", payment.Text)
					cmd.Parameters.AddWithValue("@garansi", garansi.Text)

					cmd.ExecuteNonQuery()
                    con.Close()

                    con.Open()
						cmd = con.CreateCommand
                    cmd.CommandText = "update qbi set ttl=@ttl where no_qbi=@no_qbi and revisi='" & no_rev & "'"

                    cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
						cmd.Parameters.AddWithValue("@rev", rev.Text)
						cmd.Parameters.AddWithValue("@ttl", ttl.Text)

						cmd.ExecuteNonQuery()
					con.Close()
					load()
                'Else
                '    con.Open()
                '		cmd = con.CreateCommand
                '		cmd.CommandText = "update qbi set no_qbi=@no_qbi, no_rfq=@no_rfq,ttl=@ttl, tgl_qbi=@tgl_qbi, tgl_tempo=@tgl_tempo, ppn=@ppn, qty=@qty,partnumber=@partnumber,hrg_satuan=@hrg_satuan,hrg_ttl=@hrg_ttl,masa_berlaku=@masa_berlaku,revisi=@revisi,perihal=@perihal,payment=@payment,garansi=@garansi where id_qbi=@id_qbi"
                '
                '		cmd.Parameters.AddWithValue("@id_qbi", id_qbi.Text)
                '		cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
                '		cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                '		cmd.Parameters.AddWithValue("@ttl", ttl.Text)
                '		cmd.Parameters.AddWithValue("@tgl_qbi", DateTimePicker1.Text)
                '		cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                '		cmd.Parameters.AddWithValue("@ppn", ppn.Text)
                '		cmd.Parameters.AddWithValue("@qty", qty.Text)
                '		cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                '		cmd.Parameters.AddWithValue("@hrg_satuan", hrg_satuan.Text)
                '
                '		cmd.Parameters.AddWithValue("@hrg_ttl", hrg_ttl.Text)
                '		cmd.Parameters.AddWithValue("@masa_berlaku", masa_berlaku.Text)
                '		cmd.Parameters.AddWithValue("@revisi", rev.Text)
                '		cmd.Parameters.AddWithValue("@perihal", perihal.Text)
                '		cmd.Parameters.AddWithValue("@payment", payment.Text)
                '		cmd.Parameters.AddWithValue("@garansi", garansi.Text)
                '
                '		cmd.ExecuteNonQuery()
                '        con.Close()
                '
                '        con.Open()
                '			cmd = con.CreateCommand
                '			cmd.CommandText = "update qbi set ttl=@ttl where no_qbi=@no_qbi and revisi=@rev"
                '
                '			cmd.Parameters.AddWithValue("@no_qbi", no_qbi.Text)
                '			cmd.Parameters.AddWithValue("@rev", rev.Text)
                '			cmd.Parameters.AddWithValue("@ttl", ttl.Text)
                '
                '			cmd.ExecuteNonQuery()
                '			con.Close()
                '
                '		'End If
                '
                '
                '		load()
                'End If

            Catch ex As Exception

			End Try
		End If
	End Sub

	Private Sub ttl_TextChanged(sender As Object, e As EventArgs) Handles ttl.TextChanged

	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
		Dim a As String
		Dim b As String
#Disable Warning BC42024 ' Unused local variable
		Dim c As String
#Enable Warning BC42024 ' Unused local variable
		Dim d As String

		Dim ee As Double
		Dim eee As Double
		Dim aa As Double
		Dim bb As Double
		Dim cc As Double
		Dim dd As Double

		Dim query As String = "SELECT sum(hrg_ttl) AS total from qbi WHERE no_qbi='" & no_qbi.Text & "'"
		Dim adpt As New MySqlDataAdapter(query, con)
		Dim dt As New DataTable()
		adpt.Fill(dt)
		If no_qbi.Text = "" Or no_rfq.Text = "" Or ppn.Text = "" Or hrg_satuan.Text = "" Or masa_berlaku.Text = "" Or rev.Text = "" Then

		Else
			If dt.Rows(0).Item("total").ToString() = "" Then

				a = qty.Text
				b = hrg_satuan.Text
				d = ppn.Text

				aa = Convert.ToDouble(a)
				bb = Convert.ToDouble(b)
				cc = Convert.ToDouble(d)

				dd = cc / 100
				ee = aa * bb
				eee = ee * dd
				ee = ee + eee

				hrg_ttl.Text = ee.ToString()
				ttl.Text = hrg_ttl.Text

			Else
				a = qty.Text
				b = hrg_satuan.Text

				aa = Convert.ToDouble(a)
				bb = Convert.ToDouble(b)

				ee = aa * bb

				hrg_ttl.Text = ee.ToString()

				a = ppn.Text
				b = hrg_ttl.Text
				d = dt.Rows(0).Item("total").ToString()

				aa = Convert.ToDouble(a)
				bb = Convert.ToDouble(b)

				cc = aa / 100
				ee = bb + d
				eee = ee * cc
				eee = ee + eee

				ttl.Text = eee.ToString()

			End If
		End If
	End Sub

	Private Sub attch_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub browser_Click(sender As Object, e As EventArgs)

	End Sub


	Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles hrg_satuan.TextChanged
		If hrg_satuan.Text = "" Then

		ElseIf hapus.text = "hapus" Then

		Else
			Dim titik As Long
			titik = hrg_satuan.Text
			hrg_satuan.Text = Format(titik, "#,##0")
			hrg_satuan.SelectionStart = Len(hrg_satuan.Text)
		End If
	End Sub

	Private Sub no_rfq_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
		Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Try
            id_rfq.Text = row.Cells(0).Value.ToString()
            'no_rfq.Text = row.Cells(1).Value.ToString()
            partnumber.Text = row.Cells(4).Value.ToString()
            hrg_satuan.Text = row.Cells(5).Value.ToString()
            qty.Text = row.Cells(6).Value.ToString()
        Catch ex As Exception

        End Try

        Dim queryy As String = "SELECT * FROM rfq where id_rfq='" & id_rfq.Text & "'"
		Dim adpty As New MySqlDataAdapter(queryy, con)
		Dim dty As New DataTable
		adpty.Fill(dty)
		If dty.Rows.Count > 0 Then
			no_rfq.Text = dty.Rows(0).Item("no_rfq").ToString()
		End If

		Dim query As String = "SELECT * FROM barang where partnumber='" & partnumber.Text & "'"
		Dim adpt As New MySqlDataAdapter(query, con)
		Dim dt As New DataTable
		adpt.Fill(dt)
        If dt.Rows.Count > 0 Then
            nm_brg.Text = dt.Rows(0).Item("nm_brg").ToString()
        End If

        Dim marginn As String
        Dim data As String
#Disable Warning BC42024 ' Unused local variable
        Dim stu As String
#Enable Warning BC42024 ' Unused local variable
        Dim qtys As String
#Disable Warning BC42024 ' Unused local variable
        Dim margind As Double
#Enable Warning BC42024 ' Unused local variable

#Disable Warning BC42024 ' Unused local variable
        Dim ttld As Double
#Enable Warning BC42024 ' Unused local variable
        Dim hrg_unit_ttl As Double
#Disable Warning BC42024 ' Unused local variable
        Dim ttls As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim prsn As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim prsnd As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim stuan As Double
#Enable Warning BC42024 ' Unused local variable
        Dim qtyss As Double

        Dim queryss As String = "SELECT total AS total from rfq WHERE id_rfq='" & id_rfq.Text & "'"
        Dim adptss As New MySqlDataAdapter(queryss, con)
        Dim dtss As New DataTable()
        adptss.Fill(dtss)

        If id_rfq.Text = "" Then

        Else
            If dtss.Rows(0).Item("total").ToString() = "" Then

            Else
                marginn = margin.Text
                data = dtss.Rows(0).Item("total").ToString()

                qtys = qty.Text
                qtyss = Convert.ToDouble(qtys)
                hrg_unit_ttl = data / qtyss
                hrg_satuan.Text = hrg_unit_ttl.ToString()
            End If
        End If
    End Sub

	Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

	End Sub

	Private Sub qty_TextChanged(sender As Object, e As EventArgs) Handles qty.TextChanged

	End Sub

	Private Sub no_qbi_TextChanged(sender As Object, e As EventArgs) Handles no_qbi.TextChanged

	End Sub

	Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

	End Sub

	Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles perihal.TextChanged

	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs)

	End Sub

	Private Sub ppn_KeyPress(sender As Object, e As KeyPressEventArgs)
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
		Dim query As String = "SELECT max(kd_qbi) as id FROM kode_qbi"
		Dim adpt As New MySqlDataAdapter(query, con)
		Dim dts As New DataTable
		adpt.Fill(dts)
		Dim urutankode As String
		Dim hitung As Long

		If dts.Rows(0).Item("id").ToString() = "" Then
			urutankode = "QBI" + "001"
			no_qbi.Text = urutankode
		Else
			hitung = dts.Rows(0).Item("id").ToString() + 1
			urutankode = "QBI" + Microsoft.VisualBasic.Right("000" & hitung, 3)
			no_qbi.Text = urutankode
		End If
	End Sub

	Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
		Dim query As String
		If no_rfq.Text = "" Then
			If CheckBox2.Checked = True Then
				query = "SELECT * FROM rfq where stts_rfq='complete'"
			Else
				query = "SELECT * from rfq group by no_rfq"
			End If
		Else
			If CheckBox2.Checked = True Then
				query = "SELECT * FROM rfq where stts_rfq='complete' and no_rfq='" & no_rfq.Text & "'"
			Else
				query = "SELECT * from rfq where no_rfq='" & no_rfq.Text & "'"
			End If
		End If

		Dim adpt As New MySqlDataAdapter(query, con)
		Dim ds As New DataSet()
		adpt.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0)


        Me.DataGridView2.Columns(0).HeaderText = "ID RFQ"
        Me.DataGridView2.Columns(1).HeaderText = "No RFQ"
        Me.DataGridView2.Columns(2).HeaderText = "Tanggal"
        Me.DataGridView2.Columns(3).HeaderText = "Tanggal Berakhir"
        Me.DataGridView2.Columns(4).HeaderText = "Partnumber"
        Me.DataGridView2.Columns(5).HeaderText = "Harga/Unit"
        Me.DataGridView2.Columns(6).HeaderText = "QTY"
        Me.DataGridView2.Columns(7).HeaderText = "Ongkir"
        Me.DataGridView2.Columns(8).HeaderText = "Sub Total"
        Me.DataGridView2.Columns(9).HeaderText = "Grand Total"
        Me.DataGridView2.Columns(10).HeaderText = "Status"
        Me.DataGridView2.Columns(11).HeaderText = "File RFQ"
        Me.DataGridView2.Columns(12).HeaderText = "Id Barang"
        Me.DataGridView2.Columns(13).HeaderText = "Jenis Pengiriman"
        Me.DataGridView2.Columns(14).HeaderText = "Tanggal Tiba Pengiriman"
        Me.DataGridView2.Columns(15).HeaderText = "Customer"
        Me.DataGridView2.Columns(16).HeaderText = "Attn"
        Me.DataGridView2.Columns(17).HeaderText = "Franco"
        Me.DataGridView2.Columns(18).HeaderText = "Deskripsi Item"
        Me.DataGridView2.Columns(19).HeaderText = "File Pendukung"
        Me.DataGridView2.Columns(20).HeaderText = "Status Data Ini"
        Me.DataGridView2.Columns(21).HeaderText = "Remark"


        Me.DataGridView2.Columns(9).Visible = False
    End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detail.SelectedIndexChanged
		Dim query As String
		If detail.Text = "" Then
			query = "SELECT * from qbi group by no_qbi"
		Else
			query = "SELECT * from qbi where no_qbi='" & detail.Text & "'"
		End If

		Dim adpt As New MySqlDataAdapter(query, con)
		Dim ds As New DataSet()
		adpt.Fill(ds, "qbi")
		DataGridView1.DataSource = ds.Tables(0)
		con.Close()
	End Sub

	Private Sub payment_TextChanged(sender As Object, e As EventArgs) Handles payment.TextChanged

	End Sub

	Private Sub no_rfq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles no_rfq.SelectedIndexChanged
		Dim query As String
		If no_rfq.Text = "" Then
			If CheckBox2.Checked = True Then
				query = "SELECT * FROM rfq where stts_rfq='complete'"
			Else
				query = "SELECT * from rfq group by no_rfq"
			End If
		Else
			If CheckBox2.Checked = True Then
				query = "SELECT * FROM rfq where stts_rfq='complete' and no_rfq='" & no_rfq.Text & "'"
			Else
				query = "SELECT * from rfq where no_rfq='" & no_rfq.Text & "'"
			End If
		End If

		Dim adpt As New MySqlDataAdapter(query, con)
		Dim ds As New DataSet()
		adpt.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0)


        Me.DataGridView2.Columns(0).HeaderText = "ID RFQ"
        Me.DataGridView2.Columns(1).HeaderText = "No RFQ"
        Me.DataGridView2.Columns(2).HeaderText = "Tanggal"
        Me.DataGridView2.Columns(3).HeaderText = "Tanggal Berakhir"
        Me.DataGridView2.Columns(4).HeaderText = "Partnumber"
        Me.DataGridView2.Columns(5).HeaderText = "Harga/Unit"
        Me.DataGridView2.Columns(6).HeaderText = "QTY"
        Me.DataGridView2.Columns(7).HeaderText = "Ongkir"
        Me.DataGridView2.Columns(8).HeaderText = "Sub Total"
        Me.DataGridView2.Columns(9).HeaderText = "Grand Total"
        Me.DataGridView2.Columns(10).HeaderText = "Status"
        Me.DataGridView2.Columns(11).HeaderText = "File RFQ"
        Me.DataGridView2.Columns(12).HeaderText = "Id Barang"
        Me.DataGridView2.Columns(13).HeaderText = "Jenis Pengiriman"
        Me.DataGridView2.Columns(14).HeaderText = "Tanggal Tiba Pengiriman"
        Me.DataGridView2.Columns(15).HeaderText = "Customer"
        Me.DataGridView2.Columns(16).HeaderText = "Attn"
        Me.DataGridView2.Columns(17).HeaderText = "Franco"
        Me.DataGridView2.Columns(18).HeaderText = "Deskripsi Item"
        Me.DataGridView2.Columns(19).HeaderText = "File Pendukung"
        Me.DataGridView2.Columns(20).HeaderText = "Status Data Ini"
        Me.DataGridView2.Columns(21).HeaderText = "Remark"


        Me.DataGridView2.Columns(9).Visible = False
    End Sub

	Private Sub detail_TextChanged(sender As Object, e As EventArgs) Handles detail.TextChanged
		Dim query As String
		If detail.Text = "" Then
			query = "SELECT * from qbi group by no_qbi"

			Dim adpt As New MySqlDataAdapter(query, con)
			Dim ds As New DataSet()
			adpt.Fill(ds)
			DataGridView1.DataSource = ds.Tables(0)
			con.Close()
		Else

		End If
	End Sub

	Private Sub no_rfq_TextChanged_1(sender As Object, e As EventArgs) Handles no_rfq.TextChanged
		Dim query As String
        If no_rfq.Text = "" Then
            If CheckBox2.Checked = True Then
                query = "SELECT * FROM rfq where stts_rfq='complete'"
            Else
                query = "SELECT * from rfq group by no_rfq"
            End If
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
        Else
            '	If CheckBox2.Checked = True Then
            '		query = "SELECT * FROM rfq where stts_rfq='complete' and no_rfq='" & no_rfq.Text & "'"
            '	Else
            '		query = "SELECT * from rfq where no_rfq='" & no_rfq.Text & "'"
            '	End If
        End If
    End Sub


	Private Sub hrg_ttl_TextChanged(sender As Object, e As EventArgs) Handles hrg_ttl.TextChanged
		If hrg_ttl.Text = "" Then
		ElseIf hapus.text = "hapus" Then
		Else
			Dim titik As Long
			titik = hrg_ttl.Text
			hrg_ttl.Text = Format(titik, "#,##0")
			hrg_ttl.SelectionStart = Len(hrg_ttl.Text)
		End If

	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

	End Sub

	Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

	End Sub

	Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

	End Sub

	Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)
	End Sub

	Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

	End Sub

	Private Sub TableLayoutPanel2_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

	End Sub

	Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, Label1.Click

	End Sub

	Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

	End Sub

	Private Sub no_qbi_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles no_qbi.ChangeUICues

	End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

	End Sub

	Private Function CustomRound(input As Integer)

		Dim roundUpTo500 = (input Mod 1000) < 500

        If (roundUpTo500) Then
            Return Math.Floor(input / 1000) * 1000
        Else
            Return Math.Round(input / 1000) * 1000 + 1000
        End If
    End Function

	Private Sub TextBox1_TextChanged_3(sender As Object, e As EventArgs) Handles margin.TextChanged
        If margin.Text = "" Then
            margin.Text = 0
        End If

        Dim marginn As String
        Dim data As String
		Dim stu As String
		Dim qtys As String
		Dim margind As Double

        Dim ttld As Double
        Dim hrg_unit_ttl As Double
        Dim ttls As Double
		Dim prsn As Double
#Disable Warning BC42024 ' Unused local variable
		Dim prsnd As Double
#Enable Warning BC42024 ' Unused local variable
		Dim stuan As Double
		Dim qtyss As Double

        Dim queryss As String = "SELECT total AS total  from rfq WHERE id_rfq='" & id_rfq.Text & "'"
        Dim adptss As New MySqlDataAdapter(queryss, con)
		Dim dtss As New DataTable()
		adptss.Fill(dtss)
		If id_rfq.Text = "" Or margin.Text = "" Or hrg_satuan.Text = "" Or qty.text = "" Then

		Else
			If dtss.Rows(0).Item("total").ToString() = "" Then

			Else
				marginn = margin.Text
                data = dtss.Rows(0).Item("total").ToString()

                qtys = qty.Text
                qtyss = Convert.ToDouble(qtys)
                hrg_unit_ttl = data / qtyss
                'hrg_satuan.Text = hrg_unit_ttl.ToString()

                margind = Convert.ToDouble(marginn)

				prsn = margind / 100 + 1
                ttld = hrg_unit_ttl * prsn
                hrg_satuan.Text = CustomRound(ttld)

                stu = hrg_satuan.Text

                stuan = Convert.ToDouble(stu)

                ttls = stuan * qtyss
				hrg_ttl.Text = ttls.ToString()
			End If
		End If
	End Sub

	Private Sub margin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles margin.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

	Private Sub ya_CheckedChanged(sender As Object, e As EventArgs) Handles ya.CheckedChanged
		ppn.Text = "10"
	End Sub

	Private Sub tidak_CheckedChanged(sender As Object, e As EventArgs) Handles tidak.CheckedChanged
		ppn.Text = "0"
	End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub masa_berlaku_TextChanged(sender As Object, e As EventArgs) Handles masa_berlaku.TextChanged

    End Sub

    Private Sub ppn_TextChanged(sender As Object, e As EventArgs) Handles ppn.TextChanged

    End Sub

    Private Sub partnumber_TextChanged(sender As Object, e As EventArgs) Handles partnumber.TextChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub tmbh_data_Click(sender As Object, e As EventArgs) Handles tmbh_data.Click
        CheckBox1.Checked = True
        Button5.PerformClick()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox2.Checked = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dr As DialogResult
        dr = MsgBox("Tekan Yes Jika ingin Mengubah Data Lama , Tekan No Jika Ingin Revisi Data Tanpa Mengubah Data", MsgBoxStyle.YesNoCancel)
        If dr = DialogResult.Yes Then
            edit.PerformClick()
        ElseIf dr = DialogResult.No Then
            revisi.PerformClick()
        Else

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub nm_brg_TextChanged(sender As Object, e As EventArgs) Handles nm_brg.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub rev_TextChanged(sender As Object, e As EventArgs) Handles rev.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub garansi_TextChanged(sender As Object, e As EventArgs) Handles garansi.TextChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub hapus_TextChanged(sender As Object, e As EventArgs) Handles hapus.TextChanged

    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub notif_TextChanged(sender As Object, e As EventArgs) Handles notif.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class