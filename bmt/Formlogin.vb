Imports MySql.Data.MySqlClient
Public Class Formlogin

    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt;"
    Dim con As New MySqlConnection(str)

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Yakin Ingin Membatalkan Login?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Home.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "select * from login where username = '" & username.Text & "' and password = '" & password.Text & "'"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dts As New DataTable
        adpt.Fill(dts)

        If dts.Rows.Count = 0 Then
            MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            password.Text = ""
            username.Text = ""
        Else
            Home.id_user.Text = dts.Rows(0).Item("id_username").ToString()
            Home.nama.Text = dts.Rows(0).Item("nama").ToString()

            Profile.id_user.Text = dts.Rows(0).Item("id_username").ToString()
            Profile.nma.Text = dts.Rows(0).Item("nama").ToString()
            Profile.tlp.Text = dts.Rows(0).Item("no_telp").ToString()
            Profile.almat.Text = dts.Rows(0).Item("alamat").ToString()
            Profile.jk.Text = dts.Rows(0).Item("jk").ToString()
            Profile.norek.Text = dts.Rows(0).Item("no_rek").ToString()
            Profile.user.Text = dts.Rows(0).Item("username").ToString()

            Profile.nama.Text = dts.Rows(0).Item("nama").ToString()
            Profile.no_telp.Text = dts.Rows(0).Item("no_telp").ToString()
            Profile.alamat.Text = dts.Rows(0).Item("alamat").ToString()
            If dts.Rows(0).Item("jk").ToString() = "Laki-Laki" Then
                Profile.lakilaki.Checked = True
            Else
                Profile.perempuan.Checked = True
            End If
            Profile.no_rek.Text = dts.Rows(0).Item("no_rek").ToString()
            Profile.username.Text = dts.Rows(0).Item("username").ToString()
            Profile.password.Text = dts.Rows(0).Item("password").ToString()

            If dts.Rows(0).Item("lvl").ToString() = "1" Then 'Mas Kresna
                Home.ToolStripSeparator5.Enabled = False
                Home.NotifikasiToolStripMenuItem.Visible = False
                Home.TambahRFQToolStripMenuItem.Enabled = False
                Home.ToolStripSeparator3.Enabled = False
                Home.TambahQBIToolStripMenuItem.Enabled = False
                Home.DataQBIToolStripMenuItem.Enabled = False
                Home.ToolStripMenuItem1.Enabled = False
                Home.ToolStripSeparator11.Enabled = False
                Me.Visible = False
                Home.Show()
            ElseIf dts.Rows(0).Item("lvl").ToString() = "2" Then 'Mba Windy
                Home.PemberitahuanToolStripMenuItem.Visible = False
                Home.ToolStripSeparator3.Enabled = False
                Home.ToolStripSeparator4.Enabled = False
                Home.BARANGToolStripMenuItem.Enabled = False
                Home.VENDORToolStripMenuItem.Enabled = False
                Home.ToolStripSeparator10.Enabled = False
                Home.DataRFQToolStripMenuItem.Enabled = False
                Home.ProjectAdvanceToolStripMenuItem.Enabled = False
                Home.ToolStripMenuItem5.Enabled = False
                Home.CVRToolStripMenuItem.Enabled = False
                Home.CetakCVRToolStripMenuItem.Enabled = False
                Home.ToolStripMenuItem2.Enabled = False
                Me.Visible = False
                Home.Show()
            ElseIf dts.Rows(0).Item("lvl").ToString() = "3" Then
                Me.Visible = False
                Home.Show()
            ElseIf dts.Rows(0).Item("lvl").ToString() = "4" Then
                Me.Visible = False
                regisakun.Show()
            End If
        End If
    End Sub

    Private Sub Formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub username_Click(sender As Object, e As EventArgs) Handles username.Click
        If username.Text = "Username" Then
            username.Text = ""
        Else

        End If
    End Sub

    Private Sub username_Leave(sender As Object, e As EventArgs) Handles username.Leave
        If username.Text = "" Then
            username.Text = "Username"
        Else

        End If
    End Sub

    Private Sub password_Click(sender As Object, e As EventArgs) Handles password.Click
        If password.Text = "Password" Then
            password.Text = ""
        Else

        End If
    End Sub

    Private Sub password_Leave(sender As Object, e As EventArgs) Handles password.Leave
        If password.Text = "" Then
            password.Text = "Password"
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub password_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub password_TextChanged_1(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class