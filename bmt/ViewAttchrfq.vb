Imports MySql.Data.MySqlClient

Public Class ViewAttchrfq
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub load()

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent()

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
            query = "SELECT * FROM rfq group by no_rfq"
        Else
            query = "SELECT * FROM rfq where no_rfq='" & detail.Text & "'"
        End If

        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()


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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pdffile As String = "ftp://jihan:jihan123@localhost/RFQ/" + src.Text
        WebBrowser1.Navigate(pdffile)
    End Sub

    Private Sub ViewAttchrfq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
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
        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            src.Text = row.Cells(11).Value.ToString()
            attch_hrg.Text = row.Cells(19).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pdffile As String = "ftp://jihan:jihan123@localhost/Harga/" + attch_hrg.Text
        WebBrowser1.Navigate(pdffile)
	End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub
End Class