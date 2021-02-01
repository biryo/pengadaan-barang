Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine


Public Class cetak_RI
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Private Sub cetak_RI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select projek from barang_keluar GROUP by projek", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            subject.Items.Add(dr.Item(0))
        Loop
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If subject.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim report As New ReportDocument
            report.Load("brg_out.rpt")
            report.SetParameterValue("projek", subject.Text)
            CrystalReportViewer1.ReportSource = report
            WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class