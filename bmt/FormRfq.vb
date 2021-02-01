Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FormRfq

	Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
	Dim con As New MySqlConnection(str)

    Sub load()
        If notif.Text = "ada" Then
            detail.Items.Clear()
        Else
            detail.Items.Clear() 'removes all the controls on the form
        End If

        hapus.Text = ""
        delete.Enabled = False
        edit.Enabled = False

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("SELECT no_rfq FROM rfq group by no_rfq", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            detail.Items.Add(dr.Item(0))
        Loop
        con.Close()

        Dim query As String

        If detail.Text = "" Then
            query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq group by no_rfq"
        Else
            query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq where no_rfq='" & detail.Text & "'"
        End If

        If CheckBox2.Checked = True Then
            query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq where hrg_pcs='' and ongkir=''"
        Else

        End If
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
		adpt.Fill(ds)
		con.Open()
		DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        If CheckBox1.Checked = True Then
            id_brg.Clear()
            hrg_pcs.Clear()
            QTY.Clear()
            status.Clear()
            ttl_hrg.Clear()
            nm_brg.Clear()
            partnumber.Clear()
            brand.Clear()
            nm_vendor.Clear()
            ongkir.Clear()
            attch.Clear()
            src.Clear()
            deskripsii.Clear()
        Else
            id_rfq.Clear()
            no_rfq.Clear()
            id_brg.Clear()
            hrg_pcs.Clear()
            QTY.Clear()
            status.Clear()
            ttl_hrg.Clear()
            nm_brg.Clear()
            partnumber.Clear()
            brand.Clear()
            nm_vendor.Clear()
            ongkir.Clear()
            attch.Clear()
            src.Clear()
            transportasi.Clear()
            tgl_tiba.Clear()
            deskripsii.Clear()
            DateTimePicker1.ResetText()
            DateTimePicker2.ResetText()
            Total.Clear()
			remark.Clear()
		End If

        Me.DataGridView1.Columns(0).HeaderText = "ID RFQ"
        Me.DataGridView1.Columns(1).HeaderText = "Number RFQ"
        Me.DataGridView1.Columns(2).HeaderText = "Customer"
        Me.DataGridView1.Columns(3).HeaderText = "Date Release"
        Me.DataGridView1.Columns(4).HeaderText = "End Date"

        'HEADER TIDAK BISA DI CLIK
        Me.DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles ttl_hrg.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        edit.Enabled = True
        delete.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_rfq.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception

        End Try

        Dim querys As String = "SELECT * FROM rfq where id_rfq='" & id_rfq.Text & "'"
        Dim adpts As New MySqlDataAdapter(querys, con)
        Dim dt As New DataTable
        adpts.Fill(dt)
        If dt.Rows.Count > 0 Then
            Try
                no_rfq.Text = dt.Rows(0).Item("no_rfq").ToString()
                DateTimePicker1.Text = dt.Rows(0).Item("tgl").ToString()
                DateTimePicker2.Text = dt.Rows(0).Item("tgl_tempo").ToString()
                hrg_pcs.Text = dt.Rows(0).Item("hrg_pcs").ToString()
                QTY.Text = dt.Rows(0).Item("qty").ToString()
                ongkir.Text = dt.Rows(0).Item("ongkir").ToString()
                Total.Text = dt.Rows(0).Item("total").ToString()

                ttl_hrg.Text = dt.Rows(0).Item("ttl_hrg").ToString()
                status.Text = dt.Rows(0).Item("status").ToString()
                src.Text = dt.Rows(0).Item("attch_hrg").ToString()
                id_brg.Text = dt.Rows(0).Item("id_brg").ToString()
                transportasi.Text = dt.Rows(0).Item("transportasi").ToString()
                tgl_tiba.Text = dt.Rows(0).Item("tgl_tiba").ToString()
                deskripsii.Text = dt.Rows(0).Item("deskripsii").ToString()
                remark.Text = dt.Rows(0).Item("remark").ToString()
            Catch ex As Exception

            End Try
        End If


        Dim query As String = "SELECT * FROM barang where id_brg='" & id_brg.Text & "'"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dts As New DataTable
        adpt.Fill(dts)

        If dt.Rows.Count > 0 Then
            Try
                nm_vendor.Text = dts.Rows(0).Item("nm_vendor").ToString()
                partnumber.Text = dts.Rows(0).Item("partnumber").ToString()
                nm_brg.Text = dts.Rows(0).Item("nm_brg").ToString()
                brand.Text = dts.Rows(0).Item("brand").ToString()
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        Dim b As String
        Dim c As String
        Dim d As String
        Dim ee As Double
        Dim aa As Double
        Dim bb As Double
        Dim cc As Double
#Disable Warning BC42024 ' Unused local variable
        Dim dd As Double
#Enable Warning BC42024 ' Unused local variable

        Dim queryss As String = "SELECT sum((QTY*hrg_pcs+ongkir)) As total from rfq WHERE no_rfq='" & no_rfq.Text & "'"
        Dim adptss As New MySqlDataAdapter(queryss, con)
        Dim dtss As New DataTable()
        adptss.Fill(dtss)
        If hrg_pcs.Text = "" Or QTY.Text = "" Or ongkir.Text = "" Then

        Else
            If dtss.Rows(0).Item("total").ToString() = "" Then
                a = hrg_pcs.Text
                b = QTY.Text
                c = ongkir.Text
                aa = Convert.ToDouble(a)
                bb = Convert.ToDouble(b)
                cc = Convert.ToDouble(c)
                ee = aa * bb + cc
                ttl_hrg.Text = ee.ToString()
            Else
                a = hrg_pcs.Text
                b = QTY.Text
                c = ongkir.Text
                d = dtss.Rows(0).Item("total").ToString()
                aa = Convert.ToDouble(a)
                bb = Convert.ToDouble(b)
                cc = Convert.ToDouble(c)
                ee = aa * bb + cc + d
                ttl_hrg.Text = ee
            End If
        End If

        Dim cmd As MySqlCommand
        Dim name As String
        name = Path.GetFileName(OpenFileDialog1.FileName)
        If no_rfq.Text = "" Or nm_brg.Text = "" Or partnumber.Text = "" Or brand.Text = "" Or hrg_pcs.Text = "" Or QTY.Text = "" Or ongkir.Text = "" Or status.Text = "" Or nm_vendor.Text = "" Or attch.Text = "" Or ttl_hrg.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'buat sharing file,lokasiny
            Dim paths As String
            paths = "\\ZAKY-PC\path\" & name
            System.IO.File.Copy(OpenFileDialog1.FileName, "\\ZAKY-PC\path\" & name)


            'cocokin no_rfq
            Dim querys As String = "SELECT * FROM rfq where no_rfq='" & no_rfq.Text & "'"
            Dim adpts As New MySqlDataAdapter(querys, con)
            Dim dt As New DataTable
            adpts.Fill(dt)

            'cocokin partnumber
            Dim query As String = "SELECT * FROM barang where partnumber='" & partnumber.Text & "'"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim dts As New DataTable
            adpt.Fill(dts)

            'ngambil id maxx
            Dim querysss As String = "SELECT max(id_brg) as id FROM barang"
            Dim adptsss As New MySqlDataAdapter(querysss, con)
            Dim dtsss As New DataTable
            adptsss.Fill(dtsss)

			If dts.Rows.Count = 0 Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into barang (nm_brg,partnumber,brand,nm_vendor)values(@nm_brg,@partnumber,@brand,@nm_vendor);"

                    cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
                    cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                    cmd.Parameters.AddWithValue("@brand", brand.Text)
                    cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    If dt.Rows.Count > 0 Then

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "update rfq set ttl_hrg=@ttl_hrg,rfq_source=@rfq_source where no_rfq=@no_rfq"

                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
                        cmd.Parameters.AddWithValue("@rfq_source", paths)

                        cmd.ExecuteNonQuery()
                        con.Close()

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "insert into rfq (no_rfq,tgl,tgl_tempo,partnumber,hrg_pcs,QTY,ongkir,ttl_hrg,status,rfq_source,id_brg)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@partnumber,@hrg_pcs,@QTY,@ongkir,@ttl_hrg,@status,@rfq_source,@id_brg);"
                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                        cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                        cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                        cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
                        cmd.Parameters.AddWithValue("@QTY", QTY.Text)

                        cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
                        cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
                        cmd.Parameters.AddWithValue("@status", status.Text)
                        cmd.Parameters.AddWithValue("@rfq_source", paths)
                        cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)


                        cmd.ExecuteNonQuery()
                        con.Close()

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "update rfq set id_brg=@id_brg where no_rfq=@no_rfq"
                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@id_brg", dtsss.Rows(0).Item("id").ToString())
                        cmd.ExecuteNonQuery()
                        con.Close()

                        load()
                    Else

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "insert into rfq(no_rfq,tgl,tgl_tempo,partnumber,hrg_pcs,QTY,ongkir,ttl_hrg,status,rfq_source,id_brg)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@partnumber,@hrg_pcs,@QTY,@ongkir,@ttl_hrg,@status,@rfq_source,@id_brg);"
                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                        cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                        cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                        cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
                        cmd.Parameters.AddWithValue("@QTY", QTY.Text)

                        cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
                        cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
                        cmd.Parameters.AddWithValue("@status", status.Text)
                        cmd.Parameters.AddWithValue("@rfq_source", paths)
                        cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)

                        cmd.ExecuteNonQuery()
                        con.Close()

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "update rfq set id_brg=@id_brg where no_rfq=@no_rfq"
                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@id_brg", dtsss.Rows(0).Item("id").ToString())
                        cmd.ExecuteNonQuery()
                        con.Close()

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "update rfq set id_brg=@id_brg where no_rfq=@no_rfq"
                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@id_brg", dtsss.Rows(0).Item("id").ToString())
                        cmd.ExecuteNonQuery()
                        con.Close()

                        load()
                    End If
                Else
                    If dt.Rows.Count > 0 Then
                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "update rfq set ttl_hrg=@ttl_hrg,rfq_source=@rfq_source where no_rfq=@no_rfq"

                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
                        cmd.Parameters.AddWithValue("@rfq_source", paths)

                        cmd.ExecuteNonQuery()
                        con.Close()

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "insert into rfq (no_rfq,tgl,tgl_tempo,partnumber,hrg_pcs,QTY,ongkir,ttl_hrg,status,rfq_source,id_brg)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@partnumber,@hrg_pcs,@QTY,@ongkir,@ttl_hrg,@status,@rfq_source,@id_brg);"
                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                        cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                        cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                        cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
                        cmd.Parameters.AddWithValue("@QTY", QTY.Text)

                        cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
                        cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
                        cmd.Parameters.AddWithValue("@status", status.Text)
                        cmd.Parameters.AddWithValue("@rfq_source", paths)
                        cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)

                        cmd.ExecuteNonQuery()
                        con.Close()
                        load()
                    Else
                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "insert into rfq(no_rfq,tgl,tgl_tempo,partnumber,hrg_pcs,QTY,ongkir,ttl_hrg,status,rfq_source,id_brg)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@partnumber,@hrg_pcs,@QTY,@ongkir,@ttl_hrg,@status,@rfq_source,@id_brg);"
                        cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                        cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                        cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                        cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                        cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
                        cmd.Parameters.AddWithValue("@QTY", QTY.Text)

                        cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
                        cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
                        cmd.Parameters.AddWithValue("@status", status.Text)
                        cmd.Parameters.AddWithValue("@rfq_source", paths)
                        cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)

                        cmd.ExecuteNonQuery()
                        con.Close()
                        load()
                    End If
                End If

		End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click


        Dim cmd As MySqlCommand
        Dim name As String
        name = Path.GetFileName(OpenFileDialog1.FileName)
        '-------------------------------SUBMIT RFQ------------------------------------------------------------------------------------------------------------------------------------------
        If no_rfq.Text = "" Or nm_brg.Text = "" Or hrg_pcs.Text = "" Or QTY.Text = "" Or ongkir.Text = "" Or status.Text = "" Or ttl_hrg.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            notif.Text = ""
            hapus.Text = "hapus"
            hrg_pcs.Text = hrg_pcs.Text.Replace(",", "")
            hrg_pcs.Text = hrg_pcs.Text.Replace(".", "")
            ongkir.Text = ongkir.Text.Replace(",", "")
            ongkir.Text = ongkir.Text.Replace(".", "")
            Total.Text = Total.Text.Replace(",", "")
            Total.Text = Total.Text.Replace(".", "")

            Dim n As String
            Dim m As String
            Dim o As String
            Dim d As String
            Dim qq As Double
            Dim nn As Double
            Dim mm As Double
            Dim oo As Double

            n = hrg_pcs.Text
            m = QTY.Text
            o = ongkir.Text
            nn = Convert.ToDouble(n)
            mm = Convert.ToDouble(m)
            oo = Convert.ToDouble(o)
            qq = nn * mm + oo
            Total.Text = qq.ToString()


            Dim paths As String
            paths = name
            If attch.Text = "" Then

            Else
                Try
					My.Computer.Network.UploadFile(attch.Text, "ftp://localhost/Harga/" + name, "jihan", "jihan123", True, 500)
				Catch ex As Exception
					MsgBox(ex.Message)
				End Try
			End If

			Dim query As String = "SELECT * FROM barang where id_brg='" & id_brg.Text & "'"
			Dim adpt As New MySqlDataAdapter(query, con)
			Dim dts As New DataTable
			adpt.Fill(dts)

            If dts.Rows.Count = 0 Then
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update barang set partnumber=@partnumber, brand=@brand,nm_brg=@nm_brg,nm_vendor=@nm_vendor where id_brg=@id_brg"

                cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)
                cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
                cmd.Parameters.AddWithValue("@brand", brand.Text)
                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)

                cmd.ExecuteNonQuery()
                con.Close()
            Else
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update barang set partnumber=@partnumber, brand=@brand,nm_brg=@nm_brg,nm_vendor=@nm_vendor where id_brg=@id_brg"

                cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)
                cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
                cmd.Parameters.AddWithValue("@brand", brand.Text)
                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)

                cmd.ExecuteNonQuery()
                con.Close()
            End If

			'------------
			Dim query3 As String = "SELECT * FROM barang,gudang,login WHERE barang.nm_brg='" & nm_brg.Text & "' and gudang.deskripsi='" & nm_brg.Text & "' and login.lvl=2"
			Dim adpt3 As New MySqlDataAdapter(query3, con)
			Dim dts3 As New DataTable
			adpt3.Fill(dts3)

			Dim stok_gdg As String
					Dim stok_gdgs As Double
					Dim outt As String
					Dim outs As Double
			Dim ttl As Double
			Dim ttls As Double

			If dts3.Rows.Count > 0 Then
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "INSERT INTO barang_keluar (unit, date, id_gdg, nm, projek) VALUES (@unit, @date, @id_gdg, @nm, @projek);"

                cmd.Parameters.AddWithValue("@unit", QTY.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@id_gdg", dts3.Rows(0).Item("id_gdg").ToString())
                cmd.Parameters.AddWithValue("@nm", dts3.Rows(0).Item("nama").ToString())
                cmd.Parameters.AddWithValue("@projek", no_rfq.Text)

                cmd.ExecuteNonQuery()
                con.Close()

				stok_gdg = dts3.Rows(0).Item("stok").ToString()
					stok_gdgs = Convert.ToDouble(stok_gdg)
					outt = QTY.Text
					outs = Convert.ToDouble(outt)
					ttl = stok_gdgs - outs
				
				con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update gudang set stok= '" & ttl & "' where id_gdg=@id_gdg;"

                cmd.Parameters.AddWithValue("@id_gdg", dts3.Rows(0).Item("id_gdg").ToString())
                cmd.ExecuteNonQuery()
				con.Close()


				If dts3.Rows(0).Item("stok") < QTY.Text Then

					ttls = outs - stok_gdgs

					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "insert into barang_masuk (unit,date,deskripsi,partnumber)values(@unit,@date,@deskripsi,@partnumber);"

					cmd.Parameters.AddWithValue("@unit", ttls)
					cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
					cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)

					cmd.ExecuteNonQuery()
					con.Close()

					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "update gudang set stok='0' where id_gdg=@id_gdg;"

					cmd.Parameters.AddWithValue("@id_gdg", dts3.Rows(0).Item("id_gdg").ToString())
					cmd.ExecuteNonQuery()
					con.Close()
				End If
			Else
				con.Open()
                cmd = con.CreateCommand
				cmd.CommandText = "insert into barang_masuk (unit,date,deskripsi,partnumber)values(@unit,@date,@deskripsi,@partnumber);"

				cmd.Parameters.AddWithValue("@unit", QTY.Text)
				cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)	
                cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
				cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)

				cmd.ExecuteNonQuery()
                con.Close()
				
				con.Open()
                cmd = con.CreateCommand
				cmd.CommandText = "insert into gudang (deskripsi,partnumber,stok)values(@deskripsi,@partnumber,@stok);"

				cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
				cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
				cmd.Parameters.AddWithValue("@stok", QTY.Text)
				cmd.ExecuteNonQuery()
                con.Close()

				Dim query4 As String = "SELECT * FROM gudang,login where login.lvl=2 ORDER BY id_gdg desc limit 1"
				Dim adpt4 As New MySqlDataAdapter(query4, con)
				Dim dts4 As New DataTable
				adpt4.Fill(dts4)

				con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "INSERT INTO barang_keluar (unit, date, id_gdg, nm, projek) VALUES (@unit, @date, @id_gdg, @nm, @projek);"

                cmd.Parameters.AddWithValue("@unit", QTY.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
				cmd.Parameters.AddWithValue("@id_gdg", dts4.Rows(0).Item("id_gdg").ToString())
				cmd.Parameters.AddWithValue("@nm", dts4.Rows(0).Item("nama").ToString())
				cmd.Parameters.AddWithValue("@projek", no_rfq.Text)

                cmd.ExecuteNonQuery()
                con.Close()
            End If
			'----------


			Dim querys As String = "SELECT * FROM rfq where no_rfq='" & no_rfq.Text & "'"
			Dim adpts As New MySqlDataAdapter(querys, con)
			Dim dt As New DataTable
			adpts.Fill(dt)

			If dt.Rows.Count > 0 Then
					con.Open()
					cmd = con.CreateCommand
                cmd.CommandText = "update rfq set ttl_hrg=@ttl_hrg, transportasi=@transportasi, tgl_tiba=@tgl_tiba where no_rfq=@no_rfq"

                cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)

					cmd.Parameters.AddWithValue("@transportasi", transportasi.Text)
					cmd.Parameters.AddWithValue("@tgl_tiba", tgl_tiba.Text)

					cmd.ExecuteNonQuery()
					con.Close()

					con.Open()
					cmd = con.CreateCommand
                cmd.CommandText = "update rfq set no_rfq=@no_rfq, tgl=@tgl, tgl_tempo=@tgl_tempo, partnumber=@partnumber, hrg_pcs=@hrg_pcs, QTY=@QTY,ongkir=@ongkir,total=@total, ttl_hrg=@ttl_hrg, status=@status,attch_hrg=@rfq_source, transportasi=@transportasi, tgl_tiba=@tgl_tiba, deskripsii=@deskripsii, remark=@remark,stts_rfq='complete' where id_rfq=@id_rfq"

                cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)
					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
					cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
					cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
					cmd.Parameters.AddWithValue("@QTY", QTY.Text)
					cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
					cmd.Parameters.AddWithValue("@total", Total.Text)
					cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
				cmd.Parameters.AddWithValue("@status", status.Text)

				If attch.Text = "" Then
						cmd.Parameters.AddWithValue("@rfq_source", src.Text)
					Else
						cmd.Parameters.AddWithValue("@rfq_source", paths)
					End If
					cmd.Parameters.AddWithValue("@transportasi", transportasi.Text)
					cmd.Parameters.AddWithValue("@tgl_tiba", tgl_tiba.Text)
				cmd.Parameters.AddWithValue("@deskripsii", deskripsii.Text)
				cmd.Parameters.AddWithValue("@remark", remark.Text)

				cmd.ExecuteNonQuery()
                con.Close()

                con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "update rfq set ttl_hrg=@ttl_hrg where no_rfq=@no_rfq"

					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)

					cmd.ExecuteNonQuery()
					con.Close()

					load()
				Else
					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "update rfq set no_rfq=@no_rfq, tgl=@tgl, tgl_tempo=@tgl_tempo, partnumber=@partnumber, hrg_pcs=@hrg_pcs, QTY=@QTY,ongkir=@ongkir,total=@total, ttl_hrg=@ttl_hrg, status=@status, attch_hrg=@rfq_source, transportasi=@transportasi, tgl_tiba=@tgl_tiba, deskripsii=@deskripsii, remark=@remark,stts_rfq='complete' where id_rfq=@id_rfq"

					cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)
					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
					cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
					cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
					cmd.Parameters.AddWithValue("@QTY", QTY.Text)
					cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
					cmd.Parameters.AddWithValue("@total", Total.Text)

					cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
				cmd.Parameters.AddWithValue("@status", status.Text)

				If attch.Text = "" Then
						cmd.Parameters.AddWithValue("@rfq_source", src.Text)
					Else
						cmd.Parameters.AddWithValue("@rfq_source", paths)
					End If
					cmd.Parameters.AddWithValue("@transportasi", transportasi.Text)
					cmd.Parameters.AddWithValue("@tgl_tiba", tgl_tiba.Text)
				cmd.Parameters.AddWithValue("@deskripsii", deskripsii.Text)
				cmd.Parameters.AddWithValue("@remark", remark.Text)


				cmd.ExecuteNonQuery()
					con.Close()



                con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "update rfq set ttl_hrg=@ttl_hrg where no_rfq=@no_rfq"

					cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
					cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)

					cmd.ExecuteNonQuery()
					con.Close()

					load()
				End If

		End If
	End Sub

	'   Private Sub revisi_Click(sender As Object, e As EventArgs) Handles revisi.Click
	'       Dim a As String
	'       Dim b As String
	'       Dim c As String
	'       Dim d As String
	'       Dim ee As Double
	'       Dim aa As Double
	'       Dim bb As Double
	'       Dim cc As Double
	'       Dim dd As Double
	'
	'       Dim query As String = "SELECT sum((QTY*hrg_pcs+ongkir)) As total from rfq WHERE no_rfq='" & no_rfq.Text + "_Revisi" & "'"
	'       Dim adpt As New MySqlDataAdapter(query, con)
	'       Dim dt As New DataTable()
	'       adpt.Fill(dt)
	'       If hrg_pcs.Text = "" Or QTY.Text = "" Or ongkir.Text = "" Then
	'
	'       Else
	'           If dt.Rows(0).Item("total").ToString() = "" Then
	'               a = hrg_pcs.Text
	'               b = QTY.Text
	'               c = ongkir.Text
	'               aa = Convert.ToDouble(a)
	'               bb = Convert.ToDouble(b)
	'               cc = Convert.ToDouble(c)
	'               ee = aa * bb + cc
	'               ttl_hrg.Text = ee.ToString()
	'           Else
	'               a = hrg_pcs.Text
	'               b = QTY.Text
	'               c = ongkir.Text
	'               d = dt.Rows(0).Item("total").ToString()
	'               aa = Convert.ToDouble(a)
	'               bb = Convert.ToDouble(b)
	'               cc = Convert.ToDouble(c)
	'               ee = aa * bb + cc + d
	'               ttl_hrg.Text = ee
	'           End If
	'       End If
	'
	'       Dim cmd As MySqlCommand
	'       Dim name As String
	'       name = Path.GetFileName(OpenFileDialog1.FileName)
	'       If no_rfq.Text = "" Or nm_brg.Text = "" Or partnumber.Text = "" Or brand.Text = "" Or hrg_pcs.Text = "" Or QTY.Text = "" Or ongkir.Text = "" Or status.Text = "" Or nm_vendor.Text = "" Or ttl_hrg.Text = "" Then
	'           MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	'       Else
	'           Dim paths As String
	'           paths = "\\ZAKY-PC\path\" & name
	'           If attch.Text = "" Then
	'
	'           Else
	'               System.IO.File.Copy(OpenFileDialog1.FileName, "\\ZAKY-PC\path\" & name)
	'           End If
	'
	'           Dim queryss As String = "SELECT * FROM barang where partnumber='" & partnumber.Text & "'"
	'           Dim adptss As New MySqlDataAdapter(queryss, con)
	'           Dim dtss As New DataTable
	'           adptss.Fill(dtss)
	'           Try
	'
	'               If dtss.Rows.Count = 0 Then
	'                   con.Open()
	'                   cmd = con.CreateCommand
	'                   cmd.CommandText = "insert into barang (nm_brg,partnumber,brand,nm_vendor)values(@nm_brg,@partnumber,@brand,@nm_vendor);"
	'
	'                   cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
	'                   cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
	'                   cmd.Parameters.AddWithValue("@brand", brand.Text)
	'                   cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)
	'                   cmd.ExecuteNonQuery()
	'                   con.Close()
	'               End If
	'
	'           Catch ex As Exception
	'
	'           End Try
	'
	'           Dim rev As String
	'           rev = no_rfq.Text + "_Revisi"
	'           Dim querys As String = "SELECT * FROM rfq where no_rfq='" & rev & "'"
	'           Dim adpts As New MySqlDataAdapter(querys, con)
	'           Dim dts As New DataTable
	'           adpts.Fill(dts)
	'
	'           Try
	'               If dts.Rows.Count > 0 Then
	'                   con.Open()
	'                   cmd = con.CreateCommand
	'                   cmd.CommandText = "update rfq set ttl_hrg=@ttl_hrg,rfq_source=@rfq_source where no_rfq=@no_rfq"
	'
	'                   cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text + "_Revisi")
	'                   cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
	'                   cmd.Parameters.AddWithValue("@rfq_source", paths)
	'
	'                   cmd.ExecuteNonQuery()
	'                   con.Close()
	'
	'                   con.Open()
	'                   cmd = con.CreateCommand
	'                   cmd.CommandText = "insert into rfq (no_rfq,tgl,tgl_tempo,partnumber,hrg_pcs,QTY,ongkir,ttl_hrg,status,rfq_source)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@partnumber,@hrg_pcs,@QTY,@ongkir,@ttl_hrg,@status,@rfq_source);"
	'                   cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text + "_Revisi")
	'                   cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
	'                   cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
	'                   cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
	'                   cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
	'                   cmd.Parameters.AddWithValue("@QTY", QTY.Text)
	'
	'                   cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
	'                   cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
	'                   cmd.Parameters.AddWithValue("@status", status.Text)
	'                   If attch.Text = "" Then
	'                       cmd.Parameters.AddWithValue("@rfq_source", src.Text)
	'                   Else
	'                       cmd.Parameters.AddWithValue("@rfq_source", paths)
	'                   End If
	'
	'                   cmd.ExecuteNonQuery()
	'                   con.Close()
	'                   load()
	'               Else
	'                   con.Open()
	'                   cmd = con.CreateCommand
	'                   cmd.CommandText = "insert into rfq(no_rfq,tgl,tgl_tempo,partnumber,hrg_pcs,QTY,ongkir,ttl_hrg,status,rfq_source)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@partnumber,@hrg_pcs,@QTY,@ongkir,@ttl_hrg,@status,@rfq_source);"
	'                   cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text + "_Revisi")
	'                   cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
	'                   cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
	'                   cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
	'                   cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
	'                   cmd.Parameters.AddWithValue("@QTY", QTY.Text)
	'
	'                   cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
	'                   cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
	'                   cmd.Parameters.AddWithValue("@status", status.Text)
	'                   If attch.Text = "" Then
	'                       cmd.Parameters.AddWithValue("@rfq_source", src.Text)
	'                   Else
	'                       cmd.Parameters.AddWithValue("@rfq_source", paths)
	'                   End If
	'
	'                   cmd.ExecuteNonQuery()
	'                   con.Close()
	'                   load()
	'               End If
	'
	'           Catch ex As Exception
	'
	'           End Try
	'       End If
	'   End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Dim cmd As MySqlCommand
		If no_rfq.Text = "" Or nm_brg.Text = "" Or partnumber.Text = "" Or brand.Text = "" Or hrg_pcs.Text = "" Or QTY.Text = "" Or ongkir.Text = "" Or status.Text = "" Or nm_vendor.Text = "" Or attch.Text = "" Or ttl_hrg.Text = "" Then
			MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			Dim querys As String = "SELECT * FROM barang where partnumber='" & partnumber.Text & "'"
			Dim adpts As New MySqlDataAdapter(querys, con)
			Dim dts As New DataTable
			adpts.Fill(dts)

			'Tambah Data Barang Otomatis
			If dts.Rows.Count = 0 Then
					con.Open()
					cmd = con.CreateCommand
					cmd.CommandText = "insert into barang (nm_brg,partnumber,brand,nm_vendor)values(@nm_brg,@partnumber,@brand,@nm_vendor);"

					cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
					cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
					cmd.Parameters.AddWithValue("@brand", brand.Text)
					cmd.Parameters.AddWithValue("@nm_vendor", nm_vendor.Text)
					cmd.ExecuteNonQuery()
					con.Close()
				End If

				Dim query As String = "SELECT * FROM rfq where no_rfq='" & no_rfq.Text & "'"
			Dim adpt As New MySqlDataAdapter(query, con)
			Dim dt As New DataTable
			adpt.Fill(dt)

			If dt.Rows.Count > 0 Then 'valisasi rfq baru atau bukan  
				con.Open() 'rfq lama
				cmd = con.CreateCommand
				cmd.CommandText = "update rfq set ttl_hrg=@ttl_hrg where no_rfq=@no_rfq"

				cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
				cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)

				cmd.ExecuteNonQuery()
				con.Close()

				con.Open()

				cmd = con.CreateCommand
				cmd.CommandText = "insert into rfq (no_rfq,tgl,tgl_tempo,partnumber,hrg_pcs,QTY,ongkir,ttl_hrg,status)values(@no_rfq,@tgl,@tgl_tempo,@partnumber,@hrg_pcs,@QTY,@ongkir,@ttl_hrg,@status);"

				cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
				cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
				cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
				cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)

				cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
				cmd.Parameters.AddWithValue("@QTY", QTY.Text)


				cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
				cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
				cmd.Parameters.AddWithValue("@status", status.Text)


				cmd.ExecuteNonQuery()
				con.Close()
				id_brg.Clear()
				QTY.Clear()
				status.Clear()
				nm_brg.Clear()
				partnumber.Clear()
				brand.Clear()
				nm_vendor.Clear()
				ongkir.Clear()
				hrg_pcs.Clear()

			Else
				con.Open()
				cmd = con.CreateCommand
				cmd.CommandText = "insert into rfq (no_rfq,tgl,tgl_tempo,partnumber,hrg_pcs,QTY,ongkir,ttl_hrg,status)values(@no_rfq,@tgl,@tgl_tempo,@partnumber,@hrg_pcs,@QTY,@ongkir,@ttl_hrg,@status);"
				cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
				cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
				cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
				cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
				cmd.Parameters.AddWithValue("@hrg_pcs", hrg_pcs.Text)
				cmd.Parameters.AddWithValue("@QTY", QTY.Text)

				cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
				cmd.Parameters.AddWithValue("@ttl_hrg", ttl_hrg.Text)
				cmd.Parameters.AddWithValue("@status", status.Text)

				cmd.ExecuteNonQuery()
				con.Close()
				id_brg.Clear()
				QTY.Clear()
				status.Clear()
				nm_brg.Clear()
				partnumber.Clear()
				brand.Clear()
				nm_vendor.Clear()
				ongkir.Clear()
				hrg_pcs.Clear()

			End If
		End If
	End Sub

	Private Sub link_TextChanged(sender As Object, e As EventArgs) Handles nm_vendor.TextChanged

	End Sub

	Private Sub no_rfq_TextChanged(sender As Object, e As EventArgs) Handles no_rfq.TextChanged
		'   Dim adapter As MySqlDataAdapter
		'   Dim ds As New DataSet
		'   Try
		'       con.Open()
		'       adapter = New MySqlDataAdapter("select * from rfq where no_rfq like '%" & no_rfq.Text & "%'", con)
		'       adapter.Fill(ds)
		'       DataGridView1.DataSource = ds.Tables(0)
		'       con.Close()
		'   Catch ex As Exception
		'
		'   End Try
	End Sub

	Private Sub hrg_pcs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hrg_pcs.KeyPress
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub QTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY.KeyPress
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub ongkir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ongkir.KeyPress
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub ppn_KeyPress(sender As Object, e As KeyPressEventArgs)
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub ttl_hrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ttl_hrg.KeyPress
		If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
			e.Handled = True
		End If
	End Sub

	Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
		Dim cmd As MySqlCommand

		con.Open()
			cmd = con.CreateCommand
			cmd.CommandText = "delete from rfq where id_rfq=@id_rfq;"

			cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)
			cmd.ExecuteNonQuery()
			con.Close()
			load()

	End Sub

	Private Sub nm_brg_TextChanged(sender As Object, e As EventArgs) Handles nm_brg.TextChanged

	End Sub

	Private Sub browser_Click(sender As Object, e As EventArgs) Handles browser.Click
		OpenFileDialog1.ShowDialog()
		If OpenFileDialog1.FileName > "" Then
			attch.Text = OpenFileDialog1.FileName
		End If
	End Sub

	Private Sub partnumber_TextChanged(sender As Object, e As EventArgs) Handles partnumber.TextChanged

	End Sub

	Private Sub OpenFileDialog1_FileOk(sender As Object, e As EventArgs) Handles OpenFileDialog1.FileOk

	End Sub

	Private Sub tgl_tempo_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub QTY_TextChanged(sender As Object, e As EventArgs) Handles QTY.TextChanged

	End Sub

	Private Sub id_rfq_TextChanged(sender As Object, e As EventArgs) Handles id_rfq.TextChanged

	End Sub

	Private Sub ppn_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub ongkir_TextChanged(sender As Object, e As EventArgs) Handles ongkir.TextChanged
		If ongkir.Text = "" Then
		ElseIf hapus.text = "hapus" Then

		Else
			Dim titik As Long
			titik = ongkir.Text
			ongkir.Text = Format(titik, "#,##0")
			ongkir.SelectionStart = Len(ongkir.Text)
		End If


		Dim a As String
		Dim b As String
		Dim c As String
		Dim d As String
		Dim ee As Double
		Dim aa As Double
		Dim bb As Double
		Dim cc As Double


        Dim query As String = "SELECT sum((QTY*hrg_pcs+ongkir)) As total from rfq WHERE no_rfq='" & no_rfq.Text & "'"
		Dim adpt As New MySqlDataAdapter(query, con)
		Dim dt As New DataTable()
		adpt.Fill(dt)
		If hrg_pcs.Text = "" Or QTY.Text = "" Or ongkir.Text = "" Then

		Else
			If dt.Rows(0).Item("total").ToString() = "" Then
				a = hrg_pcs.Text
				b = QTY.Text
				c = ongkir.Text
				aa = Convert.ToDouble(a)
				bb = Convert.ToDouble(b)
				cc = Convert.ToDouble(c)
				ee = aa * bb + cc
				Total.Text = ee.ToString()
				ttl_hrg.Text = ee.ToString()
			Else
				a = hrg_pcs.Text
				b = QTY.Text
				c = ongkir.Text
				d = dt.Rows(0).Item("total").ToString()
				aa = Convert.ToDouble(a)
				bb = Convert.ToDouble(b)
				cc = Convert.ToDouble(c)
				ee = aa * bb + cc
				Total.Text = ee.ToString()
				ee = ee + d

				ttl_hrg.Text = ee
			End If
		End If
	End Sub

	Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs)

	End Sub

	Private Sub attch_TextChanged(sender As Object, e As EventArgs) Handles attch.TextChanged

	End Sub

	Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

	End Sub

	Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

	End Sub

	Private Sub SaveFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog2.FileOk

	End Sub

	Private Sub deskripsii_TextChanged(sender As Object, e As EventArgs) Handles deskripsii.TextChanged

	End Sub

	Private Sub tgl_tiba_TextChanged(sender As Object, e As EventArgs) Handles tgl_tiba.TextChanged

	End Sub

	Private Sub Total_TextChanged(sender As Object, e As EventArgs) Handles Total.TextChanged
		If Total.Text = "" Then
		ElseIf hapus.text = "hapus" Then
		Else
			Dim titik As Long
			titik = Total.Text
			Total.Text = Format(titik, "#,##0")
			Total.SelectionStart = Len(Total.Text)
		End If

	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs)
		load()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs)
		load()
	End Sub

	Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
		Dim query As String
		If detail.Text = "" Then
			If CheckBox2.Checked = False Then
				query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq group by no_rfq"
			Else
				query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq where hrg_pcs='' and ongkir=''"
			End If
		Else
			If CheckBox2.Checked = False Then
				query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq where no_rfq='" & detail.Text & "'"
			Else
				query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq where hrg_pcs='' and ongkir='' and no_rfq='" & detail.Text & "'"
			End If
		End If


		Dim adpt As New MySqlDataAdapter(query, con)
		Dim ds As New DataSet()
		adpt.Fill(ds)
		con.Open()
		DataGridView1.DataSource = ds.Tables(0)
		con.Close()
	End Sub

	Private Sub remark_TextChanged(sender As Object, e As EventArgs) Handles remark.TextChanged

	End Sub

	Private Sub detail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detail.SelectedIndexChanged
		Dim query As String

		If detail.Text = "" Then
			query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq group by no_rfq"
		Else
			If CheckBox2.Checked = True Then
				query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq where hrg_pcs='' and ongkir='' and no_rfq='" & detail.Text & "'"
			Else
				query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq where no_rfq='" & detail.Text & "'"
			End If

		End If
		Dim adpt As New MySqlDataAdapter(query, con)
		Dim ds As New DataSet()
		adpt.Fill(ds)
		con.Open()
		DataGridView1.DataSource = ds.Tables(0)
		con.Close()
	End Sub

	Private Sub detail_TextChanged(sender As Object, e As EventArgs) Handles detail.TextChanged
		If detail.Text = "" Then
			Dim query As String
			query = "SELECT id_rfq,no_rfq,too,tgl,tgl_tempo FROM rfq group by no_rfq"

				Dim adpt As New MySqlDataAdapter(query, con)
			Dim ds As New DataSet()
			adpt.Fill(ds)
			con.Open()
			DataGridView1.DataSource = ds.Tables(0)
			con.Close()
		End If
	End Sub

	Private Sub hrg_pcs_TextChanged(sender As Object, e As EventArgs) Handles hrg_pcs.TextChanged
		If hrg_pcs.Text = "" Then

		ElseIf hapus.text = "hapus" Then

		Else
			Dim titik As Double
			titik = hrg_pcs.Text
			hrg_pcs.Text = Format(titik, "#,##0")
			hrg_pcs.SelectionStart = Len(hrg_pcs.Text)
		End If

	End Sub

	Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

	End Sub

	Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

	End Sub

	Private Sub TableLayoutPanel11_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel11.Paint

	End Sub

	Private Sub TableLayoutPanel16_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel16.Paint

	End Sub

	Private Sub TableLayoutPanel15_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel15.Paint

	End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub brand_TextChanged(sender As Object, e As EventArgs) Handles brand.TextChanged

    End Sub

    Private Sub status_TextChanged(sender As Object, e As EventArgs) Handles status.TextChanged

    End Sub

    Private Sub transportasi_TextChanged(sender As Object, e As EventArgs) Handles transportasi.TextChanged

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
