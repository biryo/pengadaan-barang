Imports MySql.Data.MySqlClient

Public Class Form2
	Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
	Dim con As New MySqlConnection(str)
	Sub load()
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


    End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
		If detail.Text = "" Then
			Load()
		End If
	End Sub

	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Load()

		Dim cmd As MySqlCommand
		Dim dr As MySqlDataReader


		con.Open()
		cmd = New MySqlCommand("select no_qbi from qbi GROUP by no_qbi", con)
		dr = cmd.ExecuteReader
		Do While dr.Read
			detail.Items.Add(dr.Item(0))
		Loop
		con.Close()
	End Sub

	Private Sub detail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles detail.SelectedIndexChanged
		load()
		Dim query As String = "SELECT Max(no_rfq) as rfq FROM qbi WHERE no_qbi='" & detail.Text & "'"
		Dim adpt As New MySqlDataAdapter(query, con)
		Dim dt As New DataTable
		adpt.Fill(dt)
		If dt.Rows.Count > 0 Then
			no_rfq.Text = dt.Rows(0).Item("rfq").ToString()
		End If


	End Sub

	Private Sub detail_TextChanged(sender As Object, e As EventArgs) Handles detail.TextChanged
		If detail.Text = "" Then
			Load()
		End If
	End Sub

	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

	End Sub

	Private Sub no_rfq_TextChanged(sender As Object, e As EventArgs) Handles no_rfq.TextChanged
		Dim query As String
		query = "SELECT * from rfq where no_rfq='" & no_rfq.Text & "'"

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
    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		detail.SelectedIndex = -1
		no_rfq.Clear()
	End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class