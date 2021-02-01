Imports MySql.Data.MySqlClient

Public Class barangmasuk
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)
    Sub load()

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent()

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select deskripsi from gudang", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            id_brg.Items.Add(dr.Item(0))
        Loop
        con.Close()

        delete.Enabled = False
        edit.Enabled = False
        simpan.Enabled = True

        Dim query As String = "SELECT * FROM barang_masuk"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Open()

        id_bm.Clear()
        unit.Clear()
        deskripsi.Clear()
        partnumber.Clear()
        DateTimePicker1.ResetText()
        con.Close()


    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        load()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim queryy As String = "SELECT * FROM gudang where partnumber = '" & partnumber.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable

        Dim stok_gdg As String
        Dim stok_gdgs As Double
        Dim outt As String
        Dim outs As Double
        Dim ttl As Double


        adpty.Fill(dty)

        Dim cmd As MySqlCommand

        If unit.Text = "" Or deskripsi.Text = "" Or partnumber.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "insert into barang_masuk (unit,date,deskripsi,partnumber)values(@unit,@date,@deskripsi,@partnumber);"

        '    cmd.Parameters.AddWithValue("@id_bm", id_bm.Text)
            cmd.Parameters.AddWithValue("@unit", unit.Text)
            cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
         '   cmd.Parameters.AddWithValue("@nm", nm.Text)
          '  cmd.Parameters.AddWithValue("@projek", projek.Text)
            cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
            cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
         '   cmd.Parameters.AddWithValue("@brg", brg.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            If dty.Rows.Count > 0 Then

                stok_gdg = dty.Rows(0).Item("stok").ToString()
                stok_gdgs = Convert.ToDouble(stok_gdg)
                outt = unit.Text
                outs = Convert.ToDouble(outt)
                ttl = stok_gdgs + outs

                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update gudang set stok= '" & ttl & "' where partnumber=@partnumber;"

                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into gudang (deskripsi,partnumber,stok,unit)values(@deskripsi,@partnumber,@stok,@unit);"

                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
                cmd.Parameters.AddWithValue("@stok", unit.Text)
                cmd.Parameters.AddWithValue("@unit", units.Text)
                cmd.ExecuteNonQuery()
                con.Close()
			End If
			
			
			load()
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim queryy As String = "SELECT * FROM gudang where partnumber  = '" & partnumber.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable

        Dim queryyy As String = "SELECT * FROM barang_masuk where id_bm  = '" & id_bm.Text & "'"
        Dim adptyy As New MySqlDataAdapter(queryyy, con)
        Dim dtyy As New DataTable

        Dim stok_out As String
        Dim stok_outs As Double
        Dim stok_gdg As String
        Dim stok_gdgs As Double
        Dim ttl As Double

        adptyy.Fill(dtyy)
        adpty.Fill(dty)

        stok_gdg = dty.Rows(0).Item("stok").ToString()
        stok_gdgs = Convert.ToDouble(stok_gdg)

        stok_out = dtyy.Rows(0).Item("unit").ToString()
        stok_outs = Convert.ToDouble(stok_out)

        ttl = stok_gdgs - stok_outs + Convert.ToDouble(unit.Text)


        Dim cmd As MySqlCommand
        If id_bm.Text = "" Or unit.Text = "" Or deskripsi.Text = "" Or partnumber.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "update gudang set stok= '" & ttl & "' where partnumber=@partnumber;"

            cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update barang_masuk set unit=@unit,date=@date,deskripsi=@deskripsi,partnumber=@partnumber,units=@units where id_bm=@id_bm"
                cmd.Parameters.AddWithValue("@id_bm", id_bm.Text)
                cmd.Parameters.AddWithValue("@unit", unit.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
                cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
                cmd.Parameters.AddWithValue("@units", units.Text)
                cmd.ExecuteNonQuery()
            con.Close()

            load()
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim queryy As String = "SELECT * FROM gudang where partnumber  = '" & partnumber.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable

        Dim queryyy As String = "SELECT * FROM barang_masuk where id_bm  = '" & id_bm.Text & "'"
        Dim adptyy As New MySqlDataAdapter(queryyy, con)
        Dim dtyy As New DataTable

        Dim stok_out As String
        Dim stok_outs As Double
        Dim stok_gdg As String
        Dim stok_gdgs As Double
        Dim ttl As Double

        adptyy.Fill(dtyy)
        adpty.Fill(dty)

        stok_gdg = dty.Rows(0).Item("stok").ToString()
        stok_gdgs = Convert.ToDouble(stok_gdg)

        stok_out = dtyy.Rows(0).Item("unit").ToString()
        stok_outs = Convert.ToDouble(stok_out)

        ttl = stok_gdgs - stok_outs

        Dim cmd As MySqlCommand

        con.Open()
        cmd = con.CreateCommand
        cmd.CommandText = "update gudang set stok= '" & ttl & "' where partnumber=@partnumber;"

        cmd.Parameters.AddWithValue("@partnumber", partnumber.Text)
        cmd.ExecuteNonQuery()
        con.Close()

        con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from barang_masuk where id_bm=@id_bm;"

            cmd.Parameters.AddWithValue("@id_bm", id_bm.Text)
            cmd.ExecuteNonQuery()
            con.Close()



        load()
    End Sub


    Private Sub tmbh_data_Click(sender As Object, e As EventArgs)
        'add_item.Checked = True
        simpan.PerformClick()
        'add_item.Checked = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        simpan.Enabled = False
        edit.Enabled = True
        delete.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_bm.Text = row.Cells(0).Value.ToString()
            unit.Text = row.Cells(1).Value.ToString()
            DateTimePicker1.Text = row.Cells(2).Value.ToString()
            deskripsi.Text = row.Cells(3).Value.ToString()
            partnumber.Text = row.Cells(4).Value.ToString()
            units.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles unit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub barangmasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub id_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id_brg.SelectedIndexChanged
        Dim queryy As String = "SELECT * FROM gudang where deskripsi  = '" & id_brg.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable
        adpty.Fill(dty)
        If dty.Rows.Count > 0 Then
            partnumber.Text = dty.Rows(0).Item("partnumber").ToString()
            deskripsi.Text = dty.Rows(0).Item("deskripsi").ToString()
        End If
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
            adapter = New MySqlDataAdapter("select * from barang_masuk where deskripsi like '%" & search.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
    End Sub
End Class