Imports MySql.Data.MySqlClient

Public Class FormPO
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub reload()

        nm_pt_v.DataSource = Nothing
        nm_pnrima.DataSource = Nothing
        ' nm_pt_v.Items.Clear()
        ' nm_pnrima.Items.Clear()


        Dim query As String = "SELECT * FROM vendor"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dt As New DataTable()
        adpt.Fill(dt)
        nm_pt_v.DataSource = dt

        nm_pt_v.DisplayMember = "pt_vendor"
        nm_pt_v.ValueMember = "nm_vendor"

        Dim querys As String = "SELECT * FROM ship_to"
        Dim adpts As New MySqlDataAdapter(querys, con)
        Dim dts As New DataTable()
        adpts.Fill(dts)
        nm_pnrima.DataSource = dts

        nm_pnrima.DisplayMember = "nm_penerima"
        nm_pnrima.ValueMember = "nm_penerima"
    End Sub

    Sub load()
        If CheckBox1.Checked = True Then
            detail.Items.Clear()
        Else
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent()

            Dim query As String = "SELECT * FROM vendor"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable()
            adpt.Fill(dt)
            nm_pt_v.DataSource = dt

            nm_pt_v.DisplayMember = "nm_vendor"
            nm_pt_v.ValueMember = "nm_vendor"

            Dim querys As String = "SELECT * FROM ship_to"
            Dim adpts As New MySqlDataAdapter(querys, con)
            Dim dts As New DataTable()
            adpts.Fill(dts)
            nm_pnrima.DataSource = dts

            nm_pnrima.DisplayMember = "nm_penerima"
            nm_pnrima.ValueMember = "nm_penerima"
        End If

        hapus.Text = ""
        Button2.Enabled = False
        Button1.Enabled = True
        Button4.Enabled = False

        Dim queryyy As String = "SELECT id_brg,nm_brg FROM barang"
        Dim adptyy As New MySqlDataAdapter(queryyy, con)
        Dim dsyy As New DataSet()

        adptyy.Fill(dsyy)
        DataGridView1.DataSource = dsyy.Tables(0)


        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("SELECT po FROM po group by po", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            detail.Items.Add(dr.Item(0))
        Loop
        con.Close()

        Dim queryy As String
        If detail.Text = "" Then
            queryy = "SELECT * FROM po group by po"
        Else
            queryy = "SELECT * FROM po group where po='" & detail.Text & "'"
        End If

        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dsy As New DataSet()
        adpty.Fill(dsy)
        DataGridView2.DataSource = dsy.Tables(0)
        If CheckBox1.Checked = True Then
            con.Close()
            id_brg.Clear()
            nm_brg.Clear()
            deskripsi.Clear()
            hrg_unit.Clear()
            qty.Clear()
            ttl.Clear()
            subttl.Clear()
            gtl.Clear()
            ongkir.Clear()
        Else
            id_po.Clear()
            id_brg.Clear()
            dtppo.ResetText()
            con.Close()
            no_po.Clear()
            cos_id.Clear()
            ref_suf.Clear()
            nm_pt_v.ResetText()
            nm_pnrima.ResetText()
            ship_tems.Clear()
            ship_meth.Clear()
            dtp_dd.ResetText()
            confrim_tlp.Clear()
            nm_brg.Clear()
            deskripsi.Clear()
            rev.Clear()
            hrg_unit.Clear()
            disc.Clear()
            qty.Clear()
            ttl.Clear()
            subttl.Clear()
            gtl.Clear()
            ongkir.Clear()
            rev.Text = "0.0"
        End If

        Me.DataGridView1.Columns(0).HeaderText = "ID"
        Me.DataGridView1.Columns(1).HeaderText = "Nama Barang"
        Me.DataGridView1.Columns(0).Width = 25
        Me.DataGridView1.Columns(1).Width = 250

        'HEADER TIDAK BISA DI CLIK
        Me.DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable


        Me.DataGridView2.Columns(0).HeaderText = "ID PO"
        Me.DataGridView2.Columns(1).HeaderText = "Tanggal"
        Me.DataGridView2.Columns(2).HeaderText = "Nomor PO"
        Me.DataGridView2.Columns(3).HeaderText = "Customer Id"
        Me.DataGridView2.Columns(4).HeaderText = "Ref Suf"
        Me.DataGridView2.Columns(5).HeaderText = "Nama Customer"
        Me.DataGridView2.Columns(6).HeaderText = "Nama Penerima"
        Me.DataGridView2.Columns(7).HeaderText = "Shipping Terms"
        Me.DataGridView2.Columns(8).HeaderText = "Shipping Method"
        Me.DataGridView2.Columns(9).HeaderText = "Tanggal Tiba Pengiriman"
        Me.DataGridView2.Columns(10).HeaderText = "Konfirmasi Kontak"
        Me.DataGridView2.Columns(11).HeaderText = "Revisi"
        Me.DataGridView2.Columns(12).HeaderText = "QTY"
        Me.DataGridView2.Columns(13).HeaderText = "Nama Barang"
        Me.DataGridView2.Columns(14).HeaderText = "Deskripsi"
        Me.DataGridView2.Columns(15).HeaderText = "Harga/Unit"
        Me.DataGridView2.Columns(16).HeaderText = "Total"
        Me.DataGridView2.Columns(17).HeaderText = "Sub Total"
        Me.DataGridView2.Columns(18).HeaderText = "Diskon"
        Me.DataGridView2.Columns(19).HeaderText = "Grand Total"
        Me.DataGridView2.Columns(20).HeaderText = "Ongkir"
        Me.DataGridView2.Columns(21).HeaderText = "Mata Uang"
    End Sub

    'Simpan Data 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        hapus.Text = "hapus"
        hrg_unit.Text = hrg_unit.Text.Replace(",", "")
        hrg_unit.Text = hrg_unit.Text.Replace(".", "")
        disc.Text = disc.Text.Replace(".", "")
        disc.Text = disc.Text.Replace(",", "")
        ttl.Text = ttl.Text.Replace(",", "")
        ttl.Text = ttl.Text.Replace(".", "")
        ongkir.Text = ongkir.Text.Replace(".", "")
        ongkir.Text = ongkir.Text.Replace(",", "")

        Dim cmd As MySqlCommand
        If no_po.Text = "" Or cos_id.Text = "" Or nm_pt_v.Text = "" Or dtp_dd.Text = "" Or confrim_tlp.Text = "" Or nm_pnrima.Text = "" Or ship_tems.Text = "" Or rev.Text = "" Or qty.Text = "" Or nm_brg.Text = "" Or deskripsi.Text = "" Or hrg_unit.Text = "" Or disc.Text = "" Or ongkir.Text = "" Or cr.Text = "" Or ref_suf.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If CheckBox1.Checked = True Or CheckBox2.Checked = True Then

            Else
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into kode_po(no_po)values(@no_po);"

                cmd.Parameters.AddWithValue("@no_po", no_po.Text)

                cmd.ExecuteNonQuery()
                con.Close()
            End If

            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "insert into po(`tgl`, `PO`, `cos_id`, `ref_suf`, `nm_vendor`, `nm_penerima`, `ship_tems`, `ship_meth`, `delivery_date`, `confrim_tlp`, `rev`, `qty`, `nm_brg`, `deskripsi`, `hrg_stuan`, `hrg_ttl`, `sub_ttl`, `disc`, `gtl`,`ongkir`,`mata_uang`)values(@tgl, @PO, @cos_id, @ref_suf, @nm_vendor, @nm_penerima, @ship_tems, @ship_meth, @delivery_date, @confrim_tlp, @rev, @qty, @nm_brg, @deskripsi, @hrg_stuan, @hrg_ttl, @sub_ttl, @disc, @gtl,@ongkir,@cr);"

            cmd.Parameters.AddWithValue("@tgl", dtppo.Text)
            cmd.Parameters.AddWithValue("@PO", no_po.Text)
            cmd.Parameters.AddWithValue("@cos_id", cos_id.Text)
            cmd.Parameters.AddWithValue("@ref_suf", ref_suf.Text)
            cmd.Parameters.AddWithValue("@nm_vendor", nm_pt_v.Text)
            cmd.Parameters.AddWithValue("@nm_penerima", nm_pnrima.Text)
            cmd.Parameters.AddWithValue("@ship_tems", ship_tems.Text)
            cmd.Parameters.AddWithValue("@ship_meth", ship_meth.Text)
            cmd.Parameters.AddWithValue("@delivery_date", dtp_dd.Text)
            cmd.Parameters.AddWithValue("@confrim_tlp", confrim_tlp.Text)
            cmd.Parameters.AddWithValue("@rev", rev.Text)
            cmd.Parameters.AddWithValue("@qty", qty.Text)
            cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
            cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
            cmd.Parameters.AddWithValue("@hrg_stuan", hrg_unit.Text)
            cmd.Parameters.AddWithValue("@hrg_ttl", ttl.Text)
            cmd.Parameters.AddWithValue("@sub_ttl", subttl.Text)
            cmd.Parameters.AddWithValue("@disc", disc.Text)
            cmd.Parameters.AddWithValue("@gtl", gtl.Text)
            cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
            cmd.Parameters.AddWithValue("@cr", cr.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            load()
        End If
    End Sub

    Private Sub FormPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hapus.Text = "hapus"
        hrg_unit.Text = hrg_unit.Text.Replace(",", "")
        hrg_unit.Text = hrg_unit.Text.Replace(".", "")
        disc.Text = disc.Text.Replace(".", "")
        disc.Text = disc.Text.Replace(",", "")
        ttl.Text = ttl.Text.Replace(",", "")
        ttl.Text = ttl.Text.Replace(".", "")
        ongkir.Text = ongkir.Text.Replace(".", "")
        ongkir.Text = ongkir.Text.Replace(",", "")

        Dim cmd As MySqlCommand
        If no_po.Text = "" Or cos_id.Text = "" Or nm_pt_v.Text = "" Or dtp_dd.Text = "" Or confrim_tlp.Text = "" Or nm_pnrima.Text = "" Or ship_tems.Text = "" Or rev.Text = "" Or qty.Text = "" Or nm_brg.Text = "" Or deskripsi.Text = "" Or hrg_unit.Text = "" Or disc.Text = "" Or ongkir.Text = "" Or cr.Text = "" Or ref_suf.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "UPDATE po SET tgl=@tgl, PO=@PO, cos_id=@cos_id, ref_suf=@ref_suf, nm_vendor=@nm_vendor, nm_penerima=@nm_penerima, ship_tems=@ship_tems, ship_meth=@ship_meth, delivery_date=@delivery_date, confrim_tlp=@confrim_tlp, rev=@rev, qty=@qty, nm_brg=@nm_brg, deskripsi=@deskripsi, hrg_stuan=@hrg_stuan, hrg_ttl=@hrg_ttl, sub_ttl=@sub_ttl, disc=@disc, gtl=@gtl,ongkir=@ongkir,mata_uang=@cr WHERE id_po='" & id_po.Text & "'"

            cmd.Parameters.AddWithValue("@tgl", dtppo.Text)
            cmd.Parameters.AddWithValue("@PO", no_po.Text)

            cmd.Parameters.AddWithValue("@cos_id", cos_id.Text)
            cmd.Parameters.AddWithValue("@ref_suf", ref_suf.Text)
            cmd.Parameters.AddWithValue("@nm_vendor", nm_pt_v.Text)
            cmd.Parameters.AddWithValue("@nm_penerima", nm_pnrima.Text)
            cmd.Parameters.AddWithValue("@ship_tems", ship_tems.Text)
            cmd.Parameters.AddWithValue("@ship_meth", ship_meth.Text)
            cmd.Parameters.AddWithValue("@delivery_date", dtp_dd.Text)
            cmd.Parameters.AddWithValue("@confrim_tlp", confrim_tlp.Text)
            cmd.Parameters.AddWithValue("@rev", rev.Text)
            cmd.Parameters.AddWithValue("@qty", qty.Text)
            cmd.Parameters.AddWithValue("@nm_brg", nm_brg.Text)
            cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text)
            cmd.Parameters.AddWithValue("@hrg_stuan", hrg_unit.Text)
            cmd.Parameters.AddWithValue("@hrg_ttl", ttl.Text)
            cmd.Parameters.AddWithValue("@sub_ttl", subttl.Text)
            cmd.Parameters.AddWithValue("@disc", disc.Text)
            cmd.Parameters.AddWithValue("@gtl", gtl.Text)
            cmd.Parameters.AddWithValue("@ongkir", ongkir.Text)
            cmd.Parameters.AddWithValue("@cr", cr.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            load()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As MySqlCommand

        Try
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from PO where id_PO=@id_PO;"

            cmd.Parameters.AddWithValue("@id_po", id_po.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        load()
    End Sub

    Private Sub PO_TextChanged(sender As Object, e As EventArgs) Handles no_po.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapter = New MySqlDataAdapter("select * from qbi where no_qbi like '%" & nm_brg.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_brg.Text = row.Cells(0).Value.ToString()
            nm_brg.Text = row.Cells(1).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Customer.Show()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        form_ship_to.Show()
    End Sub

    Private Sub nm_brg_TextChanged(sender As Object, e As EventArgs) Handles nm_brg.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapter = New MySqlDataAdapter("select id_brg,nm_brg FROM barang where nm_brg like '%" & nm_brg.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub qty_TextChanged(sender As Object, e As EventArgs)
        Dim jml As String
        Dim stn As String

#Disable Warning BC42024 ' Unused local variable
        Dim ee As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim eec As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim eee As Double
#Enable Warning BC42024 ' Unused local variable
        Dim jmld As Double
        Dim stnd As Double
#Disable Warning BC42024 ' Unused local variable
        Dim ppnd As Double
#Enable Warning BC42024 ' Unused local variable
        Dim ttld As Double
#Disable Warning BC42024 ' Unused local variable
        Dim prsn As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim prsnd As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim gtld As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim gtlsd As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim ttlsd As Double
#Enable Warning BC42024 ' Unused local variable

        If hrg_unit.Text = "" Or qty.Text = "" Then

        Else
            jml = qty.Text
            stn = hrg_unit.Text

            jmld = Convert.ToDouble(jml)
            stnd = Convert.ToDouble(stn)

            ttld = stnd * jmld

            ttl.Text = ttld.ToString()
            subttl.Text = ttld.ToString()
        End If
    End Sub

    Private Sub disc_TextChanged(sender As Object, e As EventArgs)
#Disable Warning BC42024 ' Unused local variable
        Dim jml As String
#Enable Warning BC42024 ' Unused local variable
        Dim stn As String
        Dim discn As String
#Disable Warning BC42024 ' Unused local variable
        Dim bc As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim c As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim ttll As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim ttls As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim data As String
#Enable Warning BC42024 ' Unused local variable

#Disable Warning BC42024 ' Unused local variable
        Dim ee As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim eec As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim eee As Double
#Enable Warning BC42024 ' Unused local variable
        Dim jmld As Double
        Dim stnd As Double
#Disable Warning BC42024 ' Unused local variable
        Dim ppnd As Double
#Enable Warning BC42024 ' Unused local variable
        Dim ttld As Double
#Disable Warning BC42024 ' Unused local variable
        Dim prsn As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim prsnd As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim gtld As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim gtlsd As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim ttlsd As Double
#Enable Warning BC42024 ' Unused local variable

        If hrg_unit.Text = "" Or qty.Text = "" Or disc.Text = "" Then

        Else
            stn = ttl.Text

            discn = disc.Text

            jmld = Convert.ToDouble(stn)
            stnd = Convert.ToDouble(discn)

            ttld = jmld - stnd

            gtl.Text = ttld.ToString()
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Try
            id_po.Text = row.Cells(0).Value.ToString()
            dtppo.Text = row.Cells(1).Value.ToString()
            no_po.Text = row.Cells(2).Value.ToString()
            cos_id.Text = row.Cells(3).Value.ToString()
            ref_suf.Text = row.Cells(4).Value.ToString()
            nm_pt_v.Text = row.Cells(5).Value.ToString()
            nm_pnrima.Text = row.Cells(6).Value.ToString()
            ship_tems.Text = row.Cells(7).Value.ToString()
            ship_meth.Text = row.Cells(8).Value.ToString()
            dtp_dd.Text = row.Cells(9).Value.ToString()
            confrim_tlp.Text = row.Cells(10).Value.ToString()
            rev.Text = row.Cells(11).Value.ToString()
            qty.Text = row.Cells(12).Value.ToString()
            nm_brg.Text = row.Cells(13).Value.ToString()
            deskripsi.Text = row.Cells(14).Value.ToString()
            hrg_unit.Text = row.Cells(15).Value.ToString()
            ttl.Text = row.Cells(16).Value.ToString()
            subttl.Text = row.Cells(17).Value.ToString()
            disc.Text = row.Cells(18).Value.ToString()
            gtl.Text = row.Cells(19).Value.ToString()
            ongkir.Text = row.Cells(20).Value.ToString()
            cr.Text = row.Cells(21).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub hrg_unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hrg_unit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub disc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles disc.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query As String = "SELECT max(kd_po) as id FROM kode_po"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dts As New DataTable
        adpt.Fill(dts)
        Dim urutankode As String
        Dim hitung As Long

        If dts.Rows(0).Item("id").ToString() = "" Then
            urutankode = "PO-PO1-" + "001"
            no_po.Text = urutankode
        Else
            hitung = dts.Rows(0).Item("id").ToString() + 1
            urutankode = "PO-PO1-" + Microsoft.VisualBasic.Right("000" & hitung, 3)
            no_po.Text = urutankode
        End If
    End Sub

    Private Sub qty_TextChanged_1(sender As Object, e As EventArgs) Handles qty.TextChanged

    End Sub

    Private Sub disc_TextChanged_1(sender As Object, e As EventArgs) Handles disc.TextChanged
        If disc.Text = "" Then
        ElseIf hapus.Text = "hapus" Then


        Else
            Dim titik As Long
            titik = disc.Text
            disc.Text = Format(titik, "#,##0")
            disc.SelectionStart = Len(disc.Text)
        End If

        '    Dim jml As String
        '    Dim stn As String
        '    Dim discn As String
        '    Dim bc As String
        '    Dim c As String
        '    Dim ttll As String
        '    Dim ttls As String
        '    Dim data As String
        '
        '    Dim ee As Double
        '    Dim eec As Double
        '    Dim eee As Double
        '    Dim jmld As Double
        '    Dim stnd As Double
        '    Dim ppnd As Double
        '    Dim ttld As Double
        '    Dim prsn As Double
        '    Dim prsnd As Double
        '    Dim gtld As Double
        '    Dim gtlsd As Double
        '    Dim ttlsd As Double
        '
        '    If hrg_unit.Text = "" Or qty.Text = "" Or disc.Text = "" Then
        '
        '    Else
        '        stn = ttl.Text
        '
        '        discn = disc.Text
        '
        '        jmld = Convert.ToDouble(stn)
        '        stnd = Convert.ToDouble(discn)
        '
        '        ttld = jmld - stnd
        '
        '        gtl.Text = ttld.ToString()
        '    End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            rev.Enabled = True
            rev.Text = ""
        Else
            rev.Enabled = False
            rev.Text = "0.0"
        End If
    End Sub

    Private Sub nm_pnrima_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nm_pnrima.SelectedIndexChanged

    End Sub

    Private Sub ttl_TextChanged(sender As Object, e As EventArgs) Handles ttl.TextChanged
        If ttl.Text = "" Then

        ElseIf hapus.Text = "hapus" Then

        Else
            Dim titik As Long
            titik = ttl.Text
            ttl.Text = Format(titik, "#,##0")
            ttl.SelectionStart = Len(ttl.Text)
        End If

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub ongkir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ongkir.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ongkir_TextChanged(sender As Object, e As EventArgs) Handles ongkir.TextChanged
        If ongkir.Text = "" Then

        ElseIf hapus.Text = "hapus" Then

        Else
            Dim titik As Long
            titik = ongkir.Text
            ongkir.Text = Format(titik, "#,##0")
            ongkir.SelectionStart = Len(ongkir.Text)
        End If

        Dim jml As String
        Dim stn As String

        Dim ongkirs As String
#Disable Warning BC42024 ' Unused local variable
        Dim disc As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim bc As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim c As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim ttll As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim ttls As String
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim data As String
#Enable Warning BC42024 ' Unused local variable

#Disable Warning BC42024 ' Unused local variable
        Dim ee As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim eec As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim eee As Double
#Enable Warning BC42024 ' Unused local variable
        Dim jmld As Double
        Dim stnd As Double
        Dim ongkirss As Double
#Disable Warning BC42024 ' Unused local variable
        Dim ppnd As Double
#Enable Warning BC42024 ' Unused local variable
        Dim ttld As Double
#Disable Warning BC42024 ' Unused local variable
        Dim prsn As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim prsnd As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim gtld As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim gtlsd As Double
#Enable Warning BC42024 ' Unused local variable
#Disable Warning BC42024 ' Unused local variable
        Dim ttlsd As Double
#Enable Warning BC42024 ' Unused local variable

        If hrg_unit.Text = "" Or qty.Text = "" Or ongkir.Text = "" Then

        Else
            jml = qty.Text
            stn = hrg_unit.Text
            ongkirs = ongkir.Text

            jmld = Convert.ToDouble(jml)
            stnd = Convert.ToDouble(stn)
            ongkirss = Convert.ToDouble(ongkirs)
            ttld = stnd * jmld + ongkirss
            ttl.Text = ttld.ToString()
            subttl.Text = ttld.ToString()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        cr.Text = Format(Val(hrg_unit.Text), "Rp #,#")
    End Sub

    Private Sub hrg_unit_TextChanged(sender As Object, e As EventArgs) Handles hrg_unit.TextChanged
        If hrg_unit.Text = "" Then

        ElseIf hapus.Text = "hapus" Then

        Else
            Dim titik As Long
            titik = hrg_unit.Text
            hrg_unit.Text = Format(titik, "#,##0")
            hrg_unit.SelectionStart = Len(hrg_unit.Text)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cr.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub subttl_TextChanged(sender As Object, e As EventArgs) Handles subttl.TextChanged
        If subttl.Text = "" Then
        Else
            Dim titik As Long
            titik = subttl.Text
            subttl.Text = Format(titik, "#,##0")
            subttl.SelectionStart = Len(subttl.Text)
        End If

    End Sub

	Private Sub TableLayoutPanel11_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel11.Paint

	End Sub

    Private Sub detail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detail.SelectedIndexChanged
        Dim query As String

        If detail.Text = "" Then
            query = "SELECT * FROM po group by po"
        Else
            query = "SELECT * FROM po where po='" & detail.Text & "'"
        End If

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView2.DataSource = ds.Tables(0)
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cos_id_TextChanged(sender As Object, e As EventArgs) Handles cos_id.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ref_suf_TextChanged(sender As Object, e As EventArgs) Handles ref_suf.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ship_tems_TextChanged(sender As Object, e As EventArgs) Handles ship_tems.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub confrim_tlp_TextChanged(sender As Object, e As EventArgs) Handles confrim_tlp.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub dtppo_ValueChanged(sender As Object, e As EventArgs) Handles dtppo.ValueChanged

    End Sub

    Private Sub id_po_TextChanged(sender As Object, e As EventArgs) Handles id_po.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub deskripsi_TextChanged(sender As Object, e As EventArgs) Handles deskripsi.TextChanged

    End Sub

    Private Sub gtl_TextChanged(sender As Object, e As EventArgs) Handles gtl.TextChanged

    End Sub

    Private Sub item_TextChanged(sender As Object, e As EventArgs) Handles item.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ship_meth_TextChanged(sender As Object, e As EventArgs) Handles ship_meth.TextChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub dtp_dd_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dd.ValueChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub id_brg_TextChanged(sender As Object, e As EventArgs) Handles id_brg.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub nm_pt_v_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nm_pt_v.SelectedIndexChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub rev_TextChanged(sender As Object, e As EventArgs) Handles rev.TextChanged

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub hapus_TextChanged(sender As Object, e As EventArgs) Handles hapus.TextChanged

    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Sub TableLayoutPanel7_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel7.Paint

    End Sub

    Private Sub TableLayoutPanel8_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel8.Paint

    End Sub

    Private Sub TableLayoutPanel9_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel9.Paint

    End Sub

    Private Sub TableLayoutPanel10_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel10.Paint

    End Sub

    Private Sub TableLayoutPanel13_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel13.Paint

    End Sub

    Private Sub TableLayoutPanel14_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel14.Paint

    End Sub

    Private Sub TableLayoutPanel15_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel15.Paint

    End Sub

    Private Sub TableLayoutPanel16_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel16.Paint

    End Sub

    Private Sub TableLayoutPanel17_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel17.Paint

    End Sub

    Private Sub TableLayoutPanel18_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel18.Paint

    End Sub

    Private Sub TableLayoutPanel12_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel12.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub tmbh_data_Click(sender As Object, e As EventArgs) Handles tmbh_data.Click
        CheckBox1.Checked = True
        Button1.PerformClick()
        CheckBox1.Checked = False
    End Sub
End Class