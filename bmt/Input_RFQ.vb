Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Input_RFQ
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub reload()
        too.Items.Clear()

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("SELECT pt_vendor FROM vendor", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            too.Items.Add(dr.Item(0))
        Loop
        con.Close()
    End Sub

    Sub load()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent()
        '     too.Items.Clear()
        '     detail.Items.Clear()
        '     nm_brg.Items.Clear()
        '
        edit.Enabled = False
        delete.Enabled = False
        Button1.Enabled = True

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("SELECT no_rfq FROM rfq group by no_rfq", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            detail.Items.Add(dr.Item(0))
        Loop
        con.Close()

        con.Open()
        cmd = New MySqlCommand("SELECT pt_vendor FROM vendor", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            too.Items.Add(dr.Item(0))
        Loop
        con.Close()

        con.Open()
        cmd = New MySqlCommand("SELECT nm_brg FROM barang", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            nm_brg.Items.Add(dr.Item(0))
        Loop
        con.Close()

        Dim query As String

        If detail.Text = "" Then
            query = "SELECT * FROM rfq group by no_rfq"
        Else
            query = "SELECT * FROM rfq where no_rfq='" & detail.Text & "'"
        End If

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        con.Open()
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        id_rfq.Clear()
        no_rfq.Clear()
        QTY.Clear()
        nm_brg.SelectedIndex = -1
        id_brg.Clear()
        partnumber.Clear()
        franco.Clear()
        deskripsii.Clear()
        too.SelectedIndex = -1
        attn.Clear()
        attch.Clear()
        too.Text = ""
        nm_brg.Text = ""


        Me.DataGridView1.Columns(0).HeaderText = "ID RFQ"
        Me.DataGridView1.Columns(1).HeaderText = "No RFQ"
        Me.DataGridView1.Columns(2).HeaderText = "Tanggal"
        Me.DataGridView1.Columns(3).HeaderText = "Tanggal Berakhir"
        Me.DataGridView1.Columns(4).HeaderText = "Partnumber"
        Me.DataGridView1.Columns(5).HeaderText = "Harga/Unit"
        Me.DataGridView1.Columns(6).HeaderText = "QTY"
        Me.DataGridView1.Columns(7).HeaderText = "Ongkir"
        Me.DataGridView1.Columns(8).HeaderText = "Sub Total"
        Me.DataGridView1.Columns(9).HeaderText = "Grand Total"
        Me.DataGridView1.Columns(10).HeaderText = "Status"
        Me.DataGridView1.Columns(11).HeaderText = "File RFQ"
        Me.DataGridView1.Columns(12).HeaderText = "Id Barang"
        Me.DataGridView1.Columns(13).HeaderText = "Jenis Pengiriman"
        Me.DataGridView1.Columns(14).HeaderText = "Tanggal Tiba Pengiriman"
        Me.DataGridView1.Columns(15).HeaderText = "Customer"
        Me.DataGridView1.Columns(16).HeaderText = "Attn"
        Me.DataGridView1.Columns(17).HeaderText = "Franco"
        Me.DataGridView1.Columns(18).HeaderText = "Deskripsi Item"
        Me.DataGridView1.Columns(19).HeaderText = "File Pendukung"
        Me.DataGridView1.Columns(20).HeaderText = "Status Data Ini"
        Me.DataGridView1.Columns(21).HeaderText = "Remark"

        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(4).Visible = False
        Me.DataGridView1.Columns(5).Visible = False
        Me.DataGridView1.Columns(7).Visible = False
        Me.DataGridView1.Columns(8).Visible = False
        Me.DataGridView1.Columns(9).Visible = False
        Me.DataGridView1.Columns(10).Visible = False
        Me.DataGridView1.Columns(12).Visible = False
        Me.DataGridView1.Columns(13).Visible = False
        Me.DataGridView1.Columns(14).Visible = False
        Me.DataGridView1.Columns(18).Visible = False
        Me.DataGridView1.Columns(19).Visible = False
        Me.DataGridView1.Columns(20).Visible = False
        Me.DataGridView1.Columns(21).Visible = False
    End Sub

    Private Sub Input_RFQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        Dim name As String
        name = filename.Text
        If no_rfq.Text = "" Or nm_brg.Text = "" Or QTY.Text = "" Or franco.Text = "" Or attn.Text = "" Or too.Text = "" Or attch.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim paths As String
            paths = name
            If attch.Text = "" Then

            Else
                Try
                    My.Computer.Network.UploadFile(attch.Text, "ftp://localhost/RFQ/" + filename.Text, "jihan", "jihan123", True, 500)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            If id_brg.Text = "" Then

                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into barang (nm_brg,partnumber,deskripsi)values(@nm_brg,@partnumber,@deskripsi);"

                cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsii.Text)
                cmd.ExecuteNonQuery()
                con.Close()


                Dim query As String = "SELECT max(id_brg) as id FROM barang"
                Dim adpt As New MySqlDataAdapter(query, con)
                Dim dts As New DataTable
                adpt.Fill(dts)


                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into rfq(no_rfq,tgl,tgl_tempo,QTY,id_brg,too,attn,franco,rfq_source,deskripsii)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@QTY,@id_brg,@too,@attn,@franco,@rfq_source,@deskripsii);"
                cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                cmd.Parameters.AddWithValue("@QTY", QTY.Text)
                cmd.Parameters.AddWithValue("@id_brg", dts.Rows(0).Item("id").ToString())
                cmd.Parameters.AddWithValue("@too", too.Text)
                cmd.Parameters.AddWithValue("@attn", attn.Text)
                cmd.Parameters.AddWithValue("@franco", franco.Text)
                cmd.Parameters.AddWithValue("@rfq_source", paths)
                cmd.Parameters.AddWithValue("@deskripsii", deskripsii.Text)


                cmd.ExecuteNonQuery()
                con.Close()

                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update rfq set rfq_source=@rfq_source where no_rfq=@no_rfq"

                cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                cmd.Parameters.AddWithValue("@rfq_source", paths)


                cmd.ExecuteNonQuery()
                con.Close()

                load()
            Else
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into rfq(no_rfq,tgl,tgl_tempo,QTY,id_brg,partnumber,too,attn,franco,rfq_source,deskripsii)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@QTY,@id_brg,@partnumber,@too,@attn,@franco,@rfq_source,@deskripsii);"

                cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                cmd.Parameters.AddWithValue("@QTY", QTY.Text)
                cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)

                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@too", too.Text)
                cmd.Parameters.AddWithValue("@attn", attn.Text)
                cmd.Parameters.AddWithValue("@franco", franco.Text)
                cmd.Parameters.AddWithValue("@rfq_source", paths)
                cmd.Parameters.AddWithValue("@deskripsii", deskripsii.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update rfq set rfq_source=@rfq_source where no_rfq=@no_rfq"

                cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                cmd.Parameters.AddWithValue("@rfq_source", paths)

                cmd.ExecuteNonQuery()
                con.Close()

                load()
            End If
        End If
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Try
            id_brg.Text = row.Cells(0).Value.ToString()
            nm_brg.Text = row.Cells(2).Value.ToString()
            partnumber.Text = row.Cells(4).Value.ToString()
            deskripsii.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub nm_brg_TextChanged(sender As Object, e As EventArgs)
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
            adapter = New MySqlDataAdapter("select * from barang where nm_brg like '%" & nm_brg.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        If no_rfq.Text = "" Or nm_brg.Text = "" Or QTY.Text = "" Or franco.Text = "" Or attn.Text = "" Or too.Text = "" Or attch.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If id_brg.Text = "" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into barang (nm_brg,partnumber,deskripsi)values(@nm_brg,@partnumber,@deskripsi);"

                    cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
                    cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsii.Text)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Dim query As String = "SELECT max(id_brg) as id FROM barang"
                    Dim adpt As New MySqlDataAdapter(query, con)
                    Dim dts As New DataTable
                    adpt.Fill(dts)

                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into rfq(no_rfq,tgl,tgl_tempo,QTY,id_brg,too,attn,franco,deskripsii)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@QTY,@id_brg,@too,@attn,@franco,@deskripsii);"
                    cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                    cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                    cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                    cmd.Parameters.AddWithValue("@QTY", QTY.Text)
                    cmd.Parameters.AddWithValue("@id_brg", dts.Rows(0).Item("id").ToString())
                    cmd.Parameters.AddWithValue("@too", too.Text)
                    cmd.Parameters.AddWithValue("@attn", attn.Text)
                    cmd.Parameters.AddWithValue("@franco", franco.Text)
                    cmd.Parameters.AddWithValue("@deskripsii", deskripsii.Text)


                    cmd.ExecuteNonQuery()
                    con.Close()

                    Dim querys As String
                    querys = "SELECT * FROM rfq group by no_rfq"

                    Dim adpts As New MySqlDataAdapter(querys, con)
                    Dim dss As New DataSet()
                    adpts.Fill(dss)
                    DataGridView1.DataSource = dss.Tables(0)

                    nm_brg.SelectedIndex = -1
                    QTY.Clear()
                    id_brg.Clear()
                    partnumber.Clear()
                    deskripsii.Clear()
                Else
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into rfq(no_rfq,tgl,tgl_tempo,QTY,id_brg,partnumber,too,attn,franco,deskripsii)values(@no_rfq,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "',@QTY,@id_brg,@partnumber,@too,@attn,@franco,@deskripsii);"
                    cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                    cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                    cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                    cmd.Parameters.AddWithValue("@QTY", QTY.Text)
                    cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)
                    cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                    cmd.Parameters.AddWithValue("@too", too.Text)
                    cmd.Parameters.AddWithValue("@attn", attn.Text)
                    cmd.Parameters.AddWithValue("@franco", franco.Text)
                    cmd.Parameters.AddWithValue("@deskripsii", deskripsii.Text)
                    cmd.ExecuteNonQuery()
                    con.Close()

                    Dim query As String
                    query = "SELECT * FROM rfq group by no_rfq"

                    Dim adpt As New MySqlDataAdapter(query, con)
                    Dim ds As New DataSet()
                    adpt.Fill(ds)
                    DataGridView1.DataSource = ds.Tables(0)

                    nm_brg.SelectedIndex = -1
                    QTY.Clear()
                    id_brg.Clear()
                    partnumber.Clear()
                    deskripsii.Clear()
                End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load()
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Button1.Enabled = False
        edit.Enabled = True
        delete.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_rfq.Text = row.Cells(0).Value.ToString()
            no_rfq.Text = row.Cells(1).Value.ToString()
            DateTimePicker1.Text = row.Cells(2).Value.ToString()
            DateTimePicker2.Text = row.Cells(3).Value.ToString()
            QTY.Text = row.Cells(6).Value.ToString()
            src.Text = row.Cells(11).Value.ToString()
            id_brg.Text = row.Cells(12).Value.ToString()
            too.Text = row.Cells(15).Value.ToString()
            attn.Text = row.Cells(16).Value.ToString()
            franco.Text = row.Cells(17).Value.ToString()
        Catch ex As Exception

        End Try

        Dim query As String = "SELECT * FROM barang where id_brg='" & id_brg.Text & "'"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dt As New DataTable
        adpt.Fill(dt)
        If dt.Rows.Count > 0 Then
            nm_brg.Text = dt.Rows(0).Item("nm_brg").ToString()
            partnumber.Text = dt.Rows(0).Item("partnumber").ToString()
            deskripsii.Text = dt.Rows(0).Item("deskripsi").ToString()
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim cmd As MySqlCommand
        Dim name As String
        name = filename.Text
        If no_rfq.Text = "" Or nm_brg.Text = "" Or QTY.Text = "" Or franco.Text = "" Or attn.Text = "" Or too.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim paths As String
            paths = name
            If attch.Text = "" Then

            Else
                Try
                    My.Computer.Network.UploadFile(attch.Text, "ftp://localhost/RFQ/" + filename.Text, "jihan", "jihan123", True, 500)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update rfq set no_rfq=@no_rfq,tgl=@tgl,tgl_tempo=@tgl_tempo,qty=@qty,too=@too,attn=@attn,franco=@franco,rfq_source=@rfq_source,deskripsii=@deskripsii,id_brg=@id_brg where id_rfq=@id_rfq"

                cmd.Parameters.AddWithValue("@id_rfq", id_rfq.Text)
                cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                cmd.Parameters.AddWithValue("@tgl", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@tgl_tempo", DateTimePicker2.Text)
                cmd.Parameters.AddWithValue("@QTY", QTY.Text)
                cmd.Parameters.AddWithValue("@too", too.Text)
                cmd.Parameters.AddWithValue("@attn", attn.Text)
                cmd.Parameters.AddWithValue("@franco", franco.Text)
                cmd.Parameters.AddWithValue("@deskripsii", deskripsii.Text)
                If attch.Text = "" Then
                    cmd.Parameters.AddWithValue("@rfq_source", src.Text)
                Else
                    cmd.Parameters.AddWithValue("@rfq_source", paths)
                End If
                cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)

                cmd.ExecuteNonQuery()
                con.Close()

                If attch.Text = "" Then

                Else
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update rfq set rfq_source=@rfq_source where no_rfq=@no_rfq"

                    cmd.Parameters.AddWithValue("@no_rfq", no_rfq.Text)
                    cmd.Parameters.AddWithValue("@rfq_source", paths)

                    cmd.ExecuteNonQuery()
                    con.Close()
                End If

                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update barang set nm_brg=@nm_brg where id_brg=@id_brg"

                cmd.Parameters.AddWithValue("@id_brg", id_brg.Text)
                cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)

                cmd.ExecuteNonQuery()
                con.Close()
            load()
        End If
    End Sub

    Private Sub browser_Click(sender As Object, e As EventArgs) Handles browser.Click
        '   OpenFileDialog1.ShowDialog()
        '   If OpenFileDialog1.FileName > "" Then
        '       attch.Text = OpenFileDialog1.FileName
        '   End If

        Dim op As New OpenFileDialog
        With op
            .ShowDialog()
            attch.Text = .FileName
            filename.Text = .SafeFileName
        End With
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub QTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTY.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        load()
    End Sub

    Private Sub no_rfq_TextChanged(sender As Object, e As EventArgs) Handles no_rfq.TextChanged

    End Sub

    Private Sub detail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detail.SelectedIndexChanged
        Dim query As String

        If detail.Text = "" Then
            query = "SELECT * FROM rfq group by no_rfq"
        Else
            query = "SELECT * FROM rfq where no_rfq='" & detail.Text & "'"
        End If

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Customer.Show()
    End Sub

    Private Sub deskripsii_TextChanged(sender As Object, e As EventArgs) Handles deskripsii.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub detail_TextChanged(sender As Object, e As EventArgs) Handles detail.TextChanged
        If detail.Text = "" Then
			Dim query As String
			query = "SELECT * FROM rfq group by no_rfq"

			Dim adpt As New MySqlDataAdapter(query, con)
			Dim ds As New DataSet()
			adpt.Fill(ds)
			DataGridView1.DataSource = ds.Tables(0)
		End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nm_brg.SelectedIndexChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        con.Open()
            adapter = New MySqlDataAdapter("select * from barang where nm_brg like '%" & nm_brg.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()


            Me.DataGridView2.Columns(0).HeaderText = "ID Barang"
        Me.DataGridView2.Columns(1).HeaderText = "Nama Vendor"
        Me.DataGridView2.Columns(2).HeaderText = "Nama Barang"
        Me.DataGridView2.Columns(3).HeaderText = "Brand"
        Me.DataGridView2.Columns(4).HeaderText = "Partnumber"
        Me.DataGridView2.Columns(5).HeaderText = "Deskripsi"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        load()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

	Private Sub too_SelectedIndexChanged(sender As Object, e As EventArgs) Handles too.SelectedIndexChanged

	End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub id_rfq_TextChanged(sender As Object, e As EventArgs) Handles id_rfq.TextChanged

    End Sub
End Class