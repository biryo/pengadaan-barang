Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class cetak_cvr
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Private Sub cetak_cvr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select no_cvr from cvr GROUP by no_cvr", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            no_cvr.Items.Add(dr.Item(0))
        Loop
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If no_cvr.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim report As New ReportDocument
            report.Load("cvr.rpt")
            report.SetParameterValue("no_cvr", no_cvr.Text)
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