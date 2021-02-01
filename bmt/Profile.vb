Imports MySql.Data.MySqlClient
Public Class Profile
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub load()
        Dim query As String = "select * from login where id_username = '" & Home.id_user.Text & "'"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim dts As New DataTable
        adpt.Fill(dts)
        con.Close()
        If dts.Rows.Count = 0 Then

        Else

            Home.nama.Text = dts.Rows(0).Item("nama").ToString()
            nma.Text = dts.Rows(0).Item("nama").ToString()
            tlp.Text = dts.Rows(0).Item("no_telp").ToString()
            almat.Text = dts.Rows(0).Item("alamat").ToString()
            jk.Text = dts.Rows(0).Item("jk").ToString()
            norek.Text = dts.Rows(0).Item("no_rek").ToString()
            user.Text = dts.Rows(0).Item("username").ToString()

            nama.Text = dts.Rows(0).Item("nama").ToString()
            no_telp.Text = dts.Rows(0).Item("no_telp").ToString()
            alamat.Text = dts.Rows(0).Item("alamat").ToString()
            If dts.Rows(0).Item("jk").ToString() = "Laki-Laki" Then
                lakilaki.Checked = True
            Else
                perempuan.Checked = True
            End If
            no_rek.Text = dts.Rows(0).Item("no_rek").ToString()
            username.Text = dts.Rows(0).Item("username").ToString()
            password.Text = dts.Rows(0).Item("password").ToString()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load()
        Me.Size = New Size(379, 419)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        If username.Text = "" Or password.Text = "" Or nama.Text = "" Or no_telp.Text = "" Or alamat.Text = "" Or no_rek.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
            Try
                cmd = con.CreateCommand
                cmd.CommandText = "update login set username=@username, password=@password, nama=@nama, no_telp=@no_telp, alamat=@alamat, no_rek=@no_rek, jk=@jk where id_username='" & Home.id_user.Text & "'"

                cmd.Parameters.AddWithValue("@username", username.Text)
                cmd.Parameters.AddWithValue("@password", password.Text)
                cmd.Parameters.AddWithValue("@nama", nama.Text)
                cmd.Parameters.AddWithValue("@no_telp", no_telp.Text)
                cmd.Parameters.AddWithValue("@alamat", alamat.Text)
                cmd.Parameters.AddWithValue("@no_rek", no_rek.Text)
                If lakilaki.Checked = True Then
                    cmd.Parameters.AddWithValue("@jk", "Laki-Laki")
                Else
                    cmd.Parameters.AddWithValue("@jk", "Perempuan")
                End If

                cmd.ExecuteNonQuery()
                con.Close()
                load()
                Me.Size = New Size(379, 419)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub edit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles edit.LinkClicked
        Me.Size = New Size(599, 419)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub password_leave(sender As Object, e As EventArgs) Handles password.Leave
        If password.Text = "" Then
            password.Text = "Password"
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub
End Class