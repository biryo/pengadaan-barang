Imports MySql.Data.MySqlClient

Public Class Barangkeluar
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)
    Sub load()
        If add_item.Checked = True Then
            detail.Items.Clear() 'removes all the controls on the form
            id_brg.Items.Clear()
        Else
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent()
        End If

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select deskripsi from gudang", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            id_brg.Items.Add(dr.Item(0))
        Loop
        con.Close()

        con.Open()
        cmd = New MySqlCommand("select projek from barang_keluar", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            detail.Items.Add(dr.Item(0))
        Loop
        con.Close()

        delete.Enabled = False
        edit.Enabled = False
        simpan.Enabled = True
        Dim query As String = "SELECT * FROM barang_keluar"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        If add_item.Checked = True Then
            id_bk.Clear()
            unit.Clear()
            partnumber.Clear()
            deskripsi.Clear()
        Else
            id_bk.Clear()
            unit.Clear()
            partnumber.Clear()
            deskripsi.Clear()
            id_gdg.Clear()
            DateTimePicker1.ResetText()
        End If

        Me.DataGridView1.Columns(0).HeaderText = "ID"
        Me.DataGridView1.Columns(1).HeaderText = "QTY"
        Me.DataGridView1.Columns(2).HeaderText = "Date"
        Me.DataGridView1.Columns(3).HeaderText = "ID Item"
        Me.DataGridView1.Columns(4).HeaderText = "Name"
        Me.DataGridView1.Columns(5).HeaderText = "Subject"

        'HEADER TIDAK BISA DI CLIK
        Me.DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Barangkeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        simpan.Enabled = False
        edit.Enabled = True
        delete.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_bk.Text = row.Cells(0).Value.ToString()
            unit.Text = row.Cells(1).Value.ToString()
            DateTimePicker1.Text = row.Cells(2).Value.ToString()
            id_gdg.Text = row.Cells(3).Value.ToString()
            nm.Text = row.Cells(4).Value.ToString()
            projek.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim queryy As String = "SELECT * FROM gudang where id_gdg  = '" & id_gdg.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable

        Dim queryyy As String = "SELECT * FROM barang_keluar where id_bk  = '" & id_bk.Text & "'"
        Dim adptyy As New MySqlDataAdapter(queryyy, con)
        Dim dtyy As New DataTable

        Dim stok_out As String
        Dim stok_outs As Double
        Dim stok_gdg As String
        Dim stok_gdgs As Double
        Dim out As String
        Dim outs As Double
        Dim ttl As Double

        adptyy.Fill(dtyy)
        adpty.Fill(dty)

        stok_gdg = dty.Rows(0).Item("stok").ToString()
        stok_gdgs = Convert.ToDouble(stok_gdg)
        stok_out = dtyy.Rows(0).Item("unit").ToString()
        stok_outs = Convert.ToDouble(stok_out)
        out = unit.Text
        outs = Convert.ToDouble(out)
        ttl = stok_gdgs + stok_outs - outs

        Dim cmd As MySqlCommand
        If id_bk.Text = "" Or id_gdg.Text = "" Or nm.Text = "" Or projek.Text = "" Or unit.Text = "" Or deskripsi.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update gudang set stok= '" & ttl & "' where id_gdg=@id_gdg;"

                cmd.Parameters.AddWithValue("@id_gdg", id_gdg.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update barang_keluar set unit=@unit,date=@date,id_gdg=@id_gdg,nm=@nm,projek=@projek where id_bk=@id_bk"
                cmd.Parameters.AddWithValue("@id_bk", id_bk.Text)
                cmd.Parameters.AddWithValue("@unit", unit.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@id_gdg", id_gdg.Text)
                cmd.Parameters.AddWithValue("@nm", nm.Text)
                cmd.Parameters.AddWithValue("@projek", projek.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim queryy As String = "SELECT * FROM gudang where id_gdg  = '" & id_gdg.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable

        Dim queryyy As String = "SELECT * FROM barang_keluar where id_bk  = '" & id_bk.Text & "'"
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

        ttl = stok_gdgs + stok_outs

        Dim cmd As MySqlCommand

        con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "update gudang set stok= '" & ttl & "' where id_gdg=@id_gdg;"

            cmd.Parameters.AddWithValue("@id_gdg", id_gdg.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from barang_keluar where id_bk=@id_bk;"

            cmd.Parameters.AddWithValue("@id_bk", id_bk.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            load()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim queryy As String = "SELECT * FROM gudang where id_gdg  = '" & id_gdg.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable
        Dim stok_gdg As String
        Dim stok_gdgs As Double
        Dim out As String
        Dim outs As Double
        Dim ttl As Double

        adpty.Fill(dty)

        If dty.Rows.Count > 0 Then
            stok_gdg = dty.Rows(0).Item("stok").ToString()
            stok_gdgs = Convert.ToDouble(stok_gdg)
            out = unit.Text
            outs = Convert.ToDouble(out)
            ttl = stok_gdgs - outs
        End If

        Dim cmd As MySqlCommand

        If nm.Text = "" Or projek.Text = "" Or unit.Text = "" Or deskripsi.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update gudang set stok= '" & ttl & "' where id_gdg=@id_gdg;"

                cmd.Parameters.AddWithValue("@id_gdg", id_gdg.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into barang_keluar (unit,date,id_gdg,nm,projek)values(@unit,@date,@id_gdg,@nm,@projek);"

                cmd.Parameters.AddWithValue("@unit", unit.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@id_gdg", id_gdg.Text)
                cmd.Parameters.AddWithValue("@nm", nm.Text)
                cmd.Parameters.AddWithValue("@projek", projek.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            load()
        End If
    End Sub

    Private Sub id_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id_brg.SelectedIndexChanged
        Dim queryy As String = "SELECT * FROM gudang where deskripsi  = '" & id_brg.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable
        adpty.Fill(dty)
        If dty.Rows.Count > 0 Then
            id_gdg.Text = dty.Rows(0).Item("id_gdg").ToString()
            partnumber.Text = dty.Rows(0).Item("partnumber").ToString()
            deskripsi.Text = dty.Rows(0).Item("deskripsi").ToString()
        End If
    End Sub

    Private Sub id_gdg_TextChanged(sender As Object, e As EventArgs) Handles id_gdg.TextChanged
        Dim queryy As String = "SELECT * FROM gudang where id_gdg  = '" & id_gdg.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable
        adpty.Fill(dty)
        If dty.Rows.Count > 0 Then
            partnumber.Text = dty.Rows(0).Item("partnumber").ToString()
            deskripsi.Text = dty.Rows(0).Item("deskripsi").ToString()
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        load()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub no_rfq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detail.SelectedIndexChanged
        Dim query As String
        If detail.Text = "" Then
            query = "SELECT * from barang_keluar group by projek"
        Else
            query = "SELECT * from barang_keluar where projek='" & detail.Text & "'"
        End If

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        con.Open()
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub detail_TextChanged(sender As Object, e As EventArgs) Handles detail.TextChanged
        Dim query As String
        If detail.Text = "" Then
            query = "SELECT * from barang_keluar group by projek"

            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            con.Open()
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Else

        End If
    End Sub

    Private Sub tmbh_data_Click(sender As Object, e As EventArgs) Handles tmbh_data.Click
        add_item.Checked = True
        simpan.PerformClick()
        add_item.Checked = False
    End Sub

    Private Sub unit_TextChanged(sender As Object, e As EventArgs) Handles unit.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub id_bk_TextChanged(sender As Object, e As EventArgs) Handles id_bk.TextChanged

    End Sub
End Class