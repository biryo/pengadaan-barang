Imports MySql.Data.MySqlClient
Public Class finance
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;"
    Dim con As New MySqlConnection(str)
    Sub load()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent()

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select no_pa from pa", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            id_pa.Items.Add(dr.Item(0))
        Loop
        con.Close()

        simpan.Enabled = True
        edit.Enabled = False
        delete.Enabled = False
        Dim query As String = "select * from finance"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        no.Clear()
        nm.Clear()
        pengajuan.Clear()

        Me.DataGridView1.Columns(0).HeaderText = "ID Finance"
        Me.DataGridView1.Columns(1).HeaderText = "No PA"
        Me.DataGridView1.Columns(2).HeaderText = "Project Name"
        Me.DataGridView1.Columns(3).HeaderText = "Date"
        Me.DataGridView1.Columns(4).HeaderText = "Status Pengajuan"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancel.Click
        load()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim cmd As MySqlCommand
        If id_fin.Text = "" Or no.Text = "" Or nm.Text = "" Or pengajuan.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update finance set no=@no,nm=@nm,date=@date,pengajuan=@pengajuan where id_fin=@id_fin"

                cmd.Parameters.AddWithValue("@id_fin", id_fin.Text)
                cmd.Parameters.AddWithValue("@no", no.Text)
                cmd.Parameters.AddWithValue("@nm", nm.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@pengajuan", pengajuan.Text)

                cmd.ExecuteNonQuery()
                con.Close()
                load()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim cmd As MySqlCommand

        con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from finance where id_fin=@id_fin;"

            cmd.Parameters.AddWithValue("@id_fin", id_fin.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        simpan.Enabled = False
        delete.Enabled = True
        edit.Enabled = True

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id_fin.Text = row.Cells(0).Value.ToString()
            no.Text = row.Cells(1).Value.ToString()
            nm.Text = row.Cells(2).Value.ToString()
            DateTimePicker1.Text = row.Cells(3).Value.ToString()
            pengajuan.Text = row.Cells(4).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim cmd As MySqlCommand
        If no.Text = "" Or nm.Text = "" Or pengajuan.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into finance (no,nm,date,pengajuan)values(@no,@nm,@date,@pengajuan);"

                cmd.Parameters.AddWithValue("@no", no.Text)
                cmd.Parameters.AddWithValue("@nm", nm.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                cmd.Parameters.AddWithValue("@pengajuan", pengajuan.Text)
                cmd.ExecuteNonQuery()
                con.Close()
            load()
        End If
    End Sub

    Private Sub finance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        con.Open()
            adapter = New MySqlDataAdapter("select * from finance where nm like '%" & search.Text & "%'", con)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
    End Sub

    Private Sub id_pa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id_pa.SelectedIndexChanged
        Dim queryy As String = "SELECT * FROM pa where no_pa  = '" & id_pa.Text & "'"
        Dim adpty As New MySqlDataAdapter(queryy, con)
        Dim dty As New DataTable
        adpty.Fill(dty)
        If dty.Rows.Count > 0 Then
            no.Text = dty.Rows(0).Item("no_pa").ToString()
            nm.Text = dty.Rows(0).Item("deskripsi").ToString()
        End If
    End Sub
End Class