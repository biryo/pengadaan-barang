Imports MySql.Data.MySqlClient
Public Class FormCVR
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)
    Sub load()
        hapus.Text = ""
        If add_list.Checked = True Then
            detail.Items.Clear()
            nm_brg.Items.Clear()
        Else
            detail.Items.Clear()
            nm_brg.Items.Clear()
        End If

        If id_cvr.Text = "" Then
            delete.Enabled = False
            edit.Enabled = False
            save.Enabled = True
        Else
            delete.Enabled = True
            edit.Enabled = True
            save.Enabled = False
        End If

        Dim query As String

        If detail.Text = "" Then
            query = "SELECT * FROM cvr group by no_cvr"
        Else
            query = "SELECT * FROM cvr where no_cvr='" & detail.Text & "'"
        End If

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select no_cvr from cvr GROUP by no_cvr", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            detail.Items.Add(dr.Item(0))
        Loop
        con.Close()

        con.Open()
        cmd = New MySqlCommand("SELECT nm_brg FROM barang", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            nm_brg.Items.Add(dr.Item(0))
        Loop
        con.Close()

        Dim querys As String
        querys = "SELECT * FROM material where no_cvr='" & e_no_cvr.Text & "'"
        Dim adpts As New MySqlDataAdapter(querys, con)
        Dim dss As New DataSet()
        adpts.Fill(dss)
        DataGridView2.DataSource = dss.Tables(0)
        con.Close()

        If add_list.Checked = True Then
            deksr.Clear()
            nm_brg.SelectedIndex = -1
            price_unit.Clear()
            qty.Clear()
            unit.Clear()
            account.Clear()
            nm_brg.ResetText()
            debet.Checked = True
            kredit.Checked = False
            add_list.Checked = False
        Else
            id_cvr.Clear()
            no_cvr.Clear()
            cash.Clear()
            DateTimePicker2.ResetText()
            remark.Clear()
            kategori.Text = ""
            deksr.Clear()
            account.Clear()
            nm_brg.SelectedIndex = -1
            nm_brg.ResetText()
            price_unit.Clear()
            qty.Clear()
            unit.Clear()
            debet.Checked = True
            kredit.Checked = False
        End If

        If kategori.Text = "Material" Then

            desk.Visible = True
            nm_brg.Visible = True
            deksr.Visible = False
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True

        ElseIf kategori.Text = "Additional Material" Then
            desk.Visible = True
            nm_brg.Visible = False
            deksr.Visible = True
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True
        ElseIf kategori.Text = "Additional Cost" Then
            desk.Visible = True
            nm_brg.Visible = False
            deksr.Visible = True
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True
        ElseIf kategori.Text = "Transportation" Then
            desk.Visible = True
            nm_brg.Visible = False
            deksr.Visible = True
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True
        ElseIf kategori.Text = "Delivery" Then
            desk.Visible = True
            nm_brg.Visible = False
            deksr.Visible = True
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True
        ElseIf kategori.Text = "" Then
            desk.Visible = False
            nm_brg.Visible = False
            deksr.Visible = False
            price.Visible = False
            price_unit.Visible = False
            jml.Visible = False
            qty.Visible = False
            satuan.Visible = False
            unit.Visible = False
            debet.Visible = False
            kredit.Visible = False
            save.Visible = False
            edit.Visible = False
            cancel.Visible = False
            delete.Visible = False
        Else
            desk.Visible = False
            nm_brg.Visible = False
            deksr.Visible = False
            price.Visible = False
            price_unit.Visible = False
            jml.Visible = False
            qty.Visible = False
            satuan.Visible = False
            unit.Visible = False
            debet.Visible = False
            kredit.Visible = False
            save.Visible = False
            edit.Visible = False
            cancel.Visible = False
            delete.Visible = False
        End If


        Me.DataGridView1.Columns(0).HeaderText = "ID CVR"
        Me.DataGridView1.Columns(1).HeaderText = "No CVR"
        Me.DataGridView1.Columns(2).HeaderText = "Tanggal"
        Me.DataGridView1.Columns(3).HeaderText = "Cash"
        Me.DataGridView1.Columns(4).HeaderText = "Remark"


        Me.DataGridView2.Columns(0).HeaderText = "ID"
        Me.DataGridView2.Columns(1).HeaderText = "No CVR"
        Me.DataGridView2.Columns(2).HeaderText = "Akun"
        Me.DataGridView2.Columns(3).HeaderText = "Deskripsi"
        Me.DataGridView2.Columns(4).HeaderText = "Harga/Unit"
        Me.DataGridView2.Columns(5).HeaderText = "QTY"
        Me.DataGridView2.Columns(6).HeaderText = "Satuan"
        Me.DataGridView2.Columns(7).HeaderText = "Debet"
        Me.DataGridView2.Columns(8).HeaderText = "Kredit"
    End Sub

    Private Sub FormCVR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancel.Click
        add_list.Checked = False
        load()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles delete.Click

        Dim dr As DialogResult
        dr = MsgBox("Delete All List?", MsgBoxStyle.YesNoCancel)
        If dr = DialogResult.Yes Then
            delete_cvr.Checked = True
        ElseIf dr = DialogResult.No Then
            delete_cvr.Checked = False
        Else

        End If

        Dim cmd As MySqlCommand

        If delete_cvr.Checked = True Then
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from cvr where id_cvr=@id_cvr;"
            cmd.Parameters.AddWithValue("@id_cvr", id_cvr.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from material where no_cvr=@no_cvr;"
            cmd.Parameters.AddWithValue("@no_cvr", e_no_cvr.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from transport where no_cvr=@no_cvr;"
            cmd.Parameters.AddWithValue("@no_cvr", e_no_cvr.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from delivery where no_cvr=@no_cvr;"
            cmd.Parameters.AddWithValue("@no_cvr", e_no_cvr.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from additional_cost where no_cvr=@no_cvr;"
            cmd.Parameters.AddWithValue("@no_cvr", e_no_cvr.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from additional_material where no_cvr=@no_cvr;"
            cmd.Parameters.AddWithValue("@no_cvr", e_no_cvr.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            load()
        Else
            add_list.Checked = True
            If id.Text = "" Then
                If dr = DialogResult.Cancel Then

                Else
                    MessageBox.Show("Please Choose Data", "Data Not Complete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If dr = DialogResult.Cancel Then

                Else
                    If kategori.Text = "Material" Then
                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "delete from material where id_material=@id;"
                        cmd.Parameters.AddWithValue("@id", id.Text)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        load()
                    ElseIf kategori.Text = "Additional Material" Then

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "delete from additional_material where id_add_material=@id;"

                        cmd.Parameters.AddWithValue("@id", id.Text)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        load()
                    ElseIf kategori.Text = "Additional Cost" Then

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "delete from additional_cost where id_add_cost=@id;"

                        cmd.Parameters.AddWithValue("@id", id.Text)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        load()
                    ElseIf kategori.Text = "Transportation" Then

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "delete from transport where id_transport=@id;"

                        cmd.Parameters.AddWithValue("@id", id.Text)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        load()
                    ElseIf kategori.Text = "Delivery" Then

                        con.Open()
                        cmd = con.CreateCommand
                        cmd.CommandText = "delete from delivery where id_delivery=@id;"

                        cmd.Parameters.AddWithValue("@id", id.Text)
                        cmd.ExecuteNonQuery()
                        con.Close()

                        load()
                    Else
                        load()
                    End If
                End If
            End If

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim cmd As MySqlCommand
        If no_cvr.Text = "" Or cash.Text = "" Or account.Text = "" Or price_unit.Text = "" Or unit.Text = "" Or qty.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If nm_brg.Text = "" Then
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update cvr set no_cvr=@no_cvr,periode=@datetimepicker2,cash=@cash,remark=@remark where id_cvr=@id_cvr"

                cmd.Parameters.AddWithValue("@id_cvr", id_cvr.Text)
                cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                cmd.Parameters.AddWithValue("@datetimepicker2", DateTimePicker2.Text)
                cmd.Parameters.AddWithValue("@cash", cash.Text)
                cmd.Parameters.AddWithValue("@remark", remark.Text)

                cmd.ExecuteNonQuery()
                con.Close()

                If kategori.Text = "Material" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update material set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_material=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Additional Material" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update additional_material set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_add_material=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Additional Cost" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update additional_cost set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_add_cost=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Transportation" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update transport set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_transport=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Delivery" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update delivery set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_delivery=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                Else
                    load()
                End If
            Else
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update cvr set no_cvr=@no_cvr,periode=@datetimepicker2,cash=@cash,remark=@remark where id_cvr=@id_cvr"

                cmd.Parameters.AddWithValue("@id_cvr", id_cvr.Text)
                cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                cmd.Parameters.AddWithValue("@datetimepicker2", DateTimePicker2.Text)
                cmd.Parameters.AddWithValue("@cash", cash.Text)
                cmd.Parameters.AddWithValue("@remark", remark.Text)

                cmd.ExecuteNonQuery()
                con.Close()

                If kategori.Text = "Material" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update material set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_material=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Additional Material" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update additional_material set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_add_material=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Additional Cost" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update additional_cost set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_add_cost=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Transportation" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update transport set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_transport=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Delivery" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update delivery set no_cvr=@no_cvr,account=@account,deskripsi=@deskripsi,hrg_unit=@hrg_unit,qty=@qty,unit=@unit,debet=@debet,kredit=@kredit where id_delivery=@id;"

                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@e_no_cvr", e_no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                Else
                    load()
                End If
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles save.Click
        hapus.Text = "hapus"
        price_unit.Text = price_unit.Text.Replace(",", "")
        price_unit.Text = price_unit.Text.Replace(".", "")
        cash.Text = cash.Text.Replace(",", "")
        cash.Text = cash.Text.Replace(".", "")

        Dim cmd As MySqlCommand
        If no_cvr.Text = "" Or cash.Text = "" Or account.Text = "" Or price_unit.Text = "" Or unit.Text = "" Or qty.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If nm_brg.Text = "" Then
                Dim query As String = "SELECT * FROM cvr where no_cvr='" & no_cvr.Text & "'"
                Dim adpt As New MySqlDataAdapter(query, con)
                Dim dt As New DataTable
                adpt.Fill(dt)
                If dt.Rows.Count > 0 Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update cvr set no_cvr=@no_cvr,periode=@datetimepicker2,cash=@cash,remark=@remark where no_cvr='" & e_no_cvr.Text & "'"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@datetimepicker2", DateTimePicker2.Text)
                    cmd.Parameters.AddWithValue("@cash", cash.Text)
                    cmd.Parameters.AddWithValue("@remark", remark.Text)

                    cmd.ExecuteNonQuery()
                    con.Close()
                Else
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into cvr (no_cvr,periode,cash,remark)values(@no_cvr,@datetimepicker2,@cash,@remark);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@datetimepicker2", DateTimePicker2.Text)
                    cmd.Parameters.AddWithValue("@cash", cash.Text)
                    cmd.Parameters.AddWithValue("@remark", remark.Text)

                    cmd.ExecuteNonQuery()
                    con.Close()

                    e_no_cvr.Text = no_cvr.Text
                End If

                If kategori.Text = "Material" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into material (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Additional Material" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into additional_material (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Additional Cost" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into additional_cost (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Transportation" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into transport (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Delivery" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into delivery (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                Else
                    load()
                End If
            Else
                Dim query As String = "SELECT * FROM cvr where no_cvr='" & no_cvr.Text & "'"
                Dim adpt As New MySqlDataAdapter(query, con)
                Dim dt As New DataTable
                adpt.Fill(dt)
                If dt.Rows.Count > 0 Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "update cvr set no_cvr=@no_cvr,periode=@datetimepicker2,cash=@cash,remark=@remark where no_cvr='" & e_no_cvr.Text & "'"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@datetimepicker2", DateTimePicker2.Text)
                    cmd.Parameters.AddWithValue("@cash", cash.Text)
                    cmd.Parameters.AddWithValue("@remark", remark.Text)

                    cmd.ExecuteNonQuery()
                    con.Close()
                Else
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into cvr (no_cvr,periode,cash,remark)values(@no_cvr,@datetimepicker2,@cash,@remark);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@datetimepicker2", DateTimePicker2.Text)
                    cmd.Parameters.AddWithValue("@cash", cash.Text)
                    cmd.Parameters.AddWithValue("@remark", remark.Text)

                    cmd.ExecuteNonQuery()
                    con.Close()

                    e_no_cvr.Text = no_cvr.Text
                End If

                If kategori.Text = "Material" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into material (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", nm_brg.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Additional Material" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into additional_material (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Additional Cost" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into additional_cost (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Transportation" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into transport (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                ElseIf kategori.Text = "Delivery" Then
                    con.Open()
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into delivery (no_cvr,account,deskripsi,hrg_unit,qty,unit,debet,kredit)values(@no_cvr,@account,@deskripsi,@hrg_unit,@qty,@unit,@debet,@kredit);"

                    cmd.Parameters.AddWithValue("@no_cvr", no_cvr.Text)
                    cmd.Parameters.AddWithValue("@account", account.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", deksr.Text)
                    cmd.Parameters.AddWithValue("@hrg_unit", price_unit.Text)
                    cmd.Parameters.AddWithValue("@qty", qty.Text)
                    cmd.Parameters.AddWithValue("@unit", unit.Text)

                    If debet.Checked = True Then
                        cmd.Parameters.AddWithValue("@debet", 1)
                        cmd.Parameters.AddWithValue("@kredit", 0)
                    Else
                        cmd.Parameters.AddWithValue("@debet", 0)
                        cmd.Parameters.AddWithValue("@kredit", 1)
                    End If

                    cmd.ExecuteNonQuery()
                    con.Close()

                    load()
                Else
                    load()
                End If
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        delete.Enabled = True
        edit.Enabled = True
        save.Enabled = False
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_cvr.Text = row.Cells(0).Value.ToString()
            no_cvr.Text = row.Cells(1).Value.ToString()
            e_no_cvr.Text = row.Cells(1).Value.ToString()
            DateTimePicker2.Text = row.Cells(2).Value.ToString()
            cash.Text = row.Cells(3).Value.ToString()
            remark.Text = row.Cells(4).Value.ToString()
        Catch ex As Exception

        End Try

        If cash.Text = "" Then

        ElseIf hapus.Text = "hapus" Then

        Else
            Dim titik As Long
            titik = cash.Text
            cash.Text = Format(titik, "#,##0")
            cash.SelectionStart = Len(cash.Text)
        End If
    End Sub

    Private Sub kategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kategori.SelectedIndexChanged
        If kategori.Text = "Material" Then
            desk.Visible = True
            nm_brg.Visible = True
            account.Visible = True
            acc.Visible = True
            deksr.Visible = False
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True
            DataGridView2.Visible = True
            Dim query As String
            query = "SELECT * FROM material where no_cvr='" & e_no_cvr.Text & "'"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()
        ElseIf kategori.Text = "Additional Material" Then
            desk.Visible = True
            nm_brg.Visible = False
            deksr.Visible = True
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True

            DataGridView2.Visible = True
            Dim query As String
            query = "SELECT * FROM additional_material where no_cvr='" & e_no_cvr.Text & "'"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()
        ElseIf kategori.Text = "Additional Cost" Then
            desk.Visible = True
            nm_brg.Visible = False
            deksr.Visible = True
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True

            DataGridView2.Visible = True
            Dim query As String
            query = "SELECT * FROM additional_cost where no_cvr='" & e_no_cvr.Text & "'"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()
        ElseIf kategori.Text = "Transportation" Then
            desk.Visible = True
            nm_brg.Visible = False
            deksr.Visible = True
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True

            DataGridView2.Visible = True
            Dim query As String
            query = "SELECT * FROM transport where no_cvr='" & e_no_cvr.Text & "'"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()
        ElseIf kategori.Text = "Delivery" Then
            desk.Visible = True
            nm_brg.Visible = False
            deksr.Visible = True
            price.Visible = True
            price_unit.Visible = True
            jml.Visible = True
            account.Visible = True
            acc.Visible = True
            qty.Visible = True
            satuan.Visible = True
            unit.Visible = True
            debet.Visible = True
            kredit.Visible = True
            save.Visible = True
            edit.Visible = True
            cancel.Visible = True
            delete.Visible = True

            DataGridView2.Visible = True
            Dim query As String
            query = "SELECT * FROM delivery where no_cvr='" & e_no_cvr.Text & "'"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()
        ElseIf kategori.Text = "" Then
            desk.Visible = False
            nm_brg.Visible = False
            deksr.Visible = False
            price.Visible = False
            price_unit.Visible = False
            jml.Visible = False
            qty.Visible = False
            satuan.Visible = False
            unit.Visible = False
            debet.Visible = False
            kredit.Visible = False
            save.Visible = False
            edit.Visible = False
            cancel.Visible = False
            delete.Visible = False

            DataGridView2.Visible = False
        Else
            desk.Visible = False
            nm_brg.Visible = False
            deksr.Visible = False
            price.Visible = False
            price_unit.Visible = False
            jml.Visible = False
            account.Visible = False
            acc.Visible = False
            qty.Visible = False
            satuan.Visible = False
            unit.Visible = False
            debet.Visible = False
            kredit.Visible = False
            save.Visible = False
            edit.Visible = False
            cancel.Visible = False
            delete.Visible = False
            DataGridView2.Visible = False
        End If
        Button1.Visible = True

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        delete.Enabled = True
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Try
            id.Text = row.Cells(0).Value.ToString()
            e_no_cvr.Text = row.Cells(1).Value.ToString()
            account.Text = row.Cells(2).Value.ToString()
            If kategori.Text = "Material" Then
                nm_brg.Text = row.Cells(3).Value.ToString()
            Else
                deksr.Text = row.Cells(3).Value.ToString()
            End If
            price_unit.Text = row.Cells(4).Value.ToString()
            qty.Text = row.Cells(5).Value.ToString()
            unit.Text = row.Cells(6).Value.ToString()

            If row.Cells(7).Value.ToString() = "1" Then
                debet.Checked = True
            Else
                kredit.Checked = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub detail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detail.SelectedIndexChanged
        Dim query As String
        If detail.Text = "" Then
            query = "SELECT * from cvr group by no_cvr"
        Else
            query = "SELECT * from cvr where no_cvr='" & detail.Text & "'"
        End If

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub detail_TextChanged(sender As Object, e As EventArgs) Handles detail.TextChanged
        Dim query As String
        If detail.Text = "" Then
            query = "SELECT * from cvr group by no_cvr"
        Else

        End If
    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub nm_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nm_brg.SelectedIndexChanged

    End Sub

    Private Sub account_TextChanged(sender As Object, e As EventArgs) Handles account.TextChanged

    End Sub

    Private Sub deksr_TextChanged(sender As Object, e As EventArgs) Handles deksr.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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

    Private Sub desk_Click(sender As Object, e As EventArgs) Handles desk.Click

    End Sub

    Private Sub delete_cvr_CheckedChanged(sender As Object, e As EventArgs) Handles delete_cvr.CheckedChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            If kategori.Text = "Material" Then
                adapter = New MySqlDataAdapter("select * from material where deskripsi like '%" & search.Text & "%'", con)
            ElseIf kategori.Text = "Additional Material" Then
                adapter = New MySqlDataAdapter("select * from additional_material where deskripsi like '%" & search.Text & "%'", con)
            ElseIf kategori.Text = "Additional Cost" Then
                adapter = New MySqlDataAdapter("select * from additional_cost where deskripsi like '%" & search.Text & "%'", con)
            ElseIf kategori.Text = "Transportation" Then
                adapter = New MySqlDataAdapter("select * from transportation where deskripsi like '%" & search.Text & "%'", con)
            ElseIf kategori.Text = "Delivery" Then
                adapter = New MySqlDataAdapter("select * from delivery where deskripsi like '%" & search.Text & "%'", con)
            Else
                adapter = New MySqlDataAdapter("select * from material deskripsi='tidak ada datanya'", con)
            End If

            adapter.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If search.Text = "Search By Name" Then
            search.Text = ""
        Else

        End If
    End Sub

    Private Sub search_Leave(sender As Object, e As EventArgs) Handles search.Leave
        If search.Text = "" Then
            search.Text = "Search By Name"
        Else

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        add_list.Checked = True

        Dim detek As String

        If save.Enabled = True Then
            detek = "Benar"
        Else
            save.Enabled = True
            detek = "Salah"
        End If

        save.PerformClick()

        If detek = "Benar" Then

        Else
            save.Enabled = False
        End If

    End Sub

    Private Sub cash_TextChanged(sender As Object, e As EventArgs) Handles cash.TextChanged
        If cash.Text = "" Then

        ElseIf hapus.Text = "hapus" Then

        Else
            Dim titik As Long
            titik = cash.Text
            cash.Text = Format(titik, "#,##0")
            cash.SelectionStart = Len(cash.Text)
        End If
    End Sub

    Private Sub cash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cash.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub price_unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price_unit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class