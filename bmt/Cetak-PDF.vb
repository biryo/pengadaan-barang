Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class Cetak_PDF
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Private Sub Cetak_PDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If no_qbi.Text = "" Or rev.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim report As New ReportDocument
            report.Load("QBI-R.1.rpt")

            report.SetParameterValue("No_QBI", no_qbi.Text)
            report.SetParameterValue("Revisi", rev.Text)

            CrystalReportViewer1.ReportSource = report
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select no_qbi,revisi from qbi GROUP by no_qbi", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            no_qbi.Items.Add(dr.Item(0))
            rev.Items.Add(dr.Item(1))
        Loop
        con.Close()
    End Sub

    Private Sub no_qbi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles no_qbi.SelectedIndexChanged
        Dim query As String = "SELECT Max(revisi) as revisi FROM qbi WHERE no_qbi='" & no_qbi.Text & "'"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dt As New DataTable
        adpt.Fill(dt)
        If dt.Rows.Count > 0 Then
            rev.Text = dt.Rows(0).Item("revisi").ToString()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class