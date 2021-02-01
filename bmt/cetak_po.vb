Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class cetak_po
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub no_qbi_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub no_po_SelectedIndexChanged(sender As Object, e As EventArgs) Handles no_po.SelectedIndexChanged
        Dim query As String = "SELECT Max(rev) as revisi FROM PO WHERE po='" & no_po.Text & "'"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dt As New DataTable
        adpt.Fill(dt)
        If dt.Rows.Count > 0 Then
            rev.Text = dt.Rows(0).Item("revisi").ToString()
        End If
    End Sub

    Private Sub cetak_po_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select po,rev from po GROUP by po", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            no_po.Items.Add(dr.Item(0))
            rev.Items.Add(dr.Item(1))
        Loop
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If no_po.Text = "" Or rev.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim report As New ReportDocument
            report.Load("PO_po.rpt")
            report.SetParameterValue("po", no_po.Text)

            report.SetParameterValue("rev", rev.Text)
            CrystalReportViewer1.ReportSource = report
            WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class