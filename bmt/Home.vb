Imports MySql.Data.MySqlClient

Public Class Home
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim querysss As String = "SELECT COUNT(*) AS new FROM (SELECT COUNT(id_rfq) FROM rfq WHERE stts_rfq='' GROUP BY no_rfq) AS new"
        Dim adptsss As New MySqlDataAdapter(querysss, con)
        Dim dtsss As New DataTable
        adptsss.Fill(dtsss)

        'DataBaruToolStripMenuItem.Text = dtsss.Rows(0).Item("new").ToString() + " Data Need Submit!!!"
        PemberitahuanToolStripMenuItem.Text = dtsss.Rows(0).Item("new").ToString() + " RFQ Baru"

        'Notif QBI
        Dim query As String = "SELECT COUNT(*) AS news FROM (SELECT COUNT(stts_rfq) FROM rfq WHERE stts_rfq='complete' GROUP BY no_rfq) AS news"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dt As New DataTable
        adpt.Fill(dt)

        NotifikasiToolStripMenuItem.Text = dt.Rows(0).Item("news").ToString() + " QBI Siap Dibuat"
        'DataBaruToolStripMenuItem1.Text = dt.Rows(0).Item("news").ToString() + " Data Ready To Process!!!"
    End Sub

    Private Sub TambahRFQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahRFQToolStripMenuItem.Click
        Input_RFQ.Show()
    End Sub

    Private Sub TambahQBIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahQBIToolStripMenuItem.Click
        FormQbi.Show()
    End Sub

    Private Sub TambahBaraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahBaraToolStripMenuItem.Click
        FormBrg.Show()
    End Sub

    Private Sub DataRFQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataRFQToolStripMenuItem.Click
        FormRfq.Show()
    End Sub

    Private Sub DataQBIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataQBIToolStripMenuItem.Click
        Cetak_PDF.Show()
    End Sub

    Private Sub VENDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDORToolStripMenuItem.Click
        Formvendor.Show()
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub InputPOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputPOToolStripMenuItem.Click
        FormPO.Show()
    End Sub

    Private Sub ShipToToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShipToToolStripMenuItem1.Click
        form_ship_to.Show()
    End Sub

    Private Sub CetakPOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakPOToolStripMenuItem.Click
        cetak_po.Show()
    End Sub

    Private Sub DataBaruToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataBaruToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        FormQbi.CheckBox2.Checked = True
        FormQbi.notif.Text = "ada"
        FormQbi.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Formlogin.Visible = True

        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        inputlogistik.Show()
    End Sub

    Private Sub ScanBarcodeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        inputlogistik.Show()
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        ViewAttchrfq.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Formlogin.Visible = True
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim querysss As String = "SELECT COUNT(*) AS new FROM (SELECT COUNT(id_rfq) FROM rfq WHERE stts_rfq='' GROUP BY no_rfq) AS new"
        Dim adptsss As New MySqlDataAdapter(querysss, con)
        Dim dtsss As New DataTable
        adptsss.Fill(dtsss)

        'DataBaruToolStripMenuItem.Text = dtsss.Rows(0).Item("new").ToString() + " Data Need Submit!!!"
        PemberitahuanToolStripMenuItem.Text = dtsss.Rows(0).Item("new").ToString() + " RFQ Baru"

        'Notif QBI
        Dim query As String = "SELECT COUNT(*) AS news FROM (SELECT COUNT(stts_rfq) FROM rfq WHERE stts_rfq='complete' GROUP BY no_rfq) AS news"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dt As New DataTable
        adpt.Fill(dt)

        NotifikasiToolStripMenuItem.Text = dt.Rows(0).Item("news").ToString() + " QBI Siap Dibuat"
        'DataBaruToolStripMenuItem1.Text = dt.Rows(0).Item("news").ToString() + " Data Ready To Process!!!"

        ' con.Close()
        MenuStrip1.Refresh()
    End Sub

    Private Sub ProjectAdvanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectAdvanceToolStripMenuItem.Click
        PA.Show()
    End Sub

    Private Sub CVRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CVRToolStripMenuItem.Click
        FormCVR.Show()
    End Sub

    Private Sub CetakCVRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakCVRToolStripMenuItem.Click
        cetak_cvr.Show()
    End Sub

    Private Sub CetakProjectAdvanceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cetak_pa.Show()
    End Sub

    Private Sub CekQBIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CekQBIToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub GudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GudangToolStripMenuItem.Click
        Gudang.Show()
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        Barangkeluar.Show()
    End Sub

    Private Sub CetakBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakBarangToolStripMenuItem.Click
        cetak_RI.Show()
    End Sub

    Private Sub PemberitahuanToolStripMenuItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PemberitahuanToolStripMenuItem.SelectedIndexChanged
        FormRfq.detail.Text = PemberitahuanToolStripMenuItem.Text
        FormRfq.notif.Text = "ada"
        FormRfq.Show()
        FormRfq.CheckBox2.Checked = True
    End Sub

    Private Sub PemberitahuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemberitahuanToolStripMenuItem.Click
        PemberitahuanToolStripMenuItem.Items.Clear()
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select no_rfq FROM rfq WHERE stts_rfq='' GROUP BY no_rfq", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            PemberitahuanToolStripMenuItem.Items.Add(dr.Item(0))
        Loop
        con.Close()
    End Sub

    Private Sub NotifikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotifikasiToolStripMenuItem.Click
        NotifikasiToolStripMenuItem.Items.Clear()
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        con.Open()
        cmd = New MySqlCommand("select no_rfq FROM rfq WHERE stts_rfq='complete' GROUP BY no_rfq", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            NotifikasiToolStripMenuItem.Items.Add(dr.Item(0))
        Loop
        con.Close()
    End Sub

    Private Sub NotifikasiToolStripMenuItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NotifikasiToolStripMenuItem.SelectedIndexChanged
        FormQbi.no_rfq.Text = NotifikasiToolStripMenuItem.Text
        FormQbi.notif.Text = "ada"
        FormQbi.Show()
        FormQbi.CheckBox2.Checked = True
    End Sub

    Private Sub RegisterAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        regisakun.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        cetak_pa.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Formlogin.Visible = True
        Me.Close()
    End Sub

    Private Sub time_Click(sender As Object, e As EventArgs) Handles time.Click

    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        time.Text = DateTime.Now
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Profile.Show()
    End Sub

    Private Sub PictureBox3_MouseHover_1(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover

    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        barangmasuk.Show()
    End Sub

    Private Sub FinanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FinanceToolStripMenuItem1.Click
        finance.Show()
    End Sub
End Class