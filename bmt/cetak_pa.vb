﻿Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class cetak_pa
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Private Sub cetak_pa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select no_pa from pa GROUP by no_pa", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            no_pa.Items.Add(dr.Item(0))
        Loop
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If no_pa.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim report As New ReportDocument
            report.Load("pengajuandana.rpt")
            report.SetParameterValue("no_pa", no_pa.Text)
            CrystalReportViewer1.ReportSource = report
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub no_pa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles no_pa.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class