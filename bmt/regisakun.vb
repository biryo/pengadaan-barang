Imports MySql.Data.MySqlClient

Public Class regisakun
    Dim str As String = "server=127.0.0.1; port=3306; uid=root; pwd=; database=bmt; Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)

    Sub load()
        Dim querys As String
        querys = "SELECT * FROM login"
        Dim adpts As New MySqlDataAdapter(querys, con)
        Dim dss As New DataSet()
        adpts.Fill(dss)
        DataGridView1.DataSource = dss.Tables(0)
        con.Close()

        id.Clear()
        username.Clear()
        password.Clear()
        lvl.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        If username.Text = "" Or password.Text = "" Or lvl.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "insert into login (username,password,lvl)values(@username,@password,@lvl);"

                cmd.Parameters.AddWithValue("@username", username.Text)
                cmd.Parameters.AddWithValue("@password", password.Text)

                If lvl.Text = "Purchasing" Then
                    lvl.Text = 1
                    cmd.Parameters.AddWithValue("@lvl", lvl.Text)
                End If

                If lvl.Text = "Procurement" Then
                    lvl.Text = 2
                    cmd.Parameters.AddWithValue("@lvl", lvl.Text)
                End If

                If lvl.Text = "Manager" Then
                    lvl.Text = 3
                    cmd.Parameters.AddWithValue("@lvl", lvl.Text)
                End If


                cmd.ExecuteNonQuery()
                con.Close()
                Load()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id.Text = row.Cells(0).Value.ToString()
            username.Text = row.Cells(6).Value.ToString()
            password.Text = row.Cells(7).Value.ToString()

            If row.Cells(8).Value.ToString() = "1" Then
                lvl.SelectedIndex = 0
            End If

            If row.Cells(8).Value.ToString() = "2" Then
                lvl.SelectedIndex = 1
            End If

            If row.Cells(8).Value.ToString() = "3" Then
                lvl.SelectedIndex = 2
            End If

            If row.Cells(8).Value.ToString() = "4" Then
                lvl.SelectedIndex = 3
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub regisakun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        If id.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
                cmd = con.CreateCommand
                cmd.CommandText = "update login set lvl=@lvl, username=@username, password=@password where id_username=@id"

            cmd.Parameters.AddWithValue("@id", id.Text)
            cmd.Parameters.AddWithValue("@username", username.Text)
                cmd.Parameters.AddWithValue("@password", password.Text)

                If lvl.Text = "Purchasing" Then
                    cmd.Parameters.AddWithValue("@lvl", 1)
                End If

                If lvl.Text = "Procurement" Then
                    cmd.Parameters.AddWithValue("@lvl", 2)
                End If

                If lvl.Text = "Manager" Then
                    cmd.Parameters.AddWithValue("@lvl", 3)
                End If

            If lvl.Text = "RegistMan" Then
                cmd.Parameters.AddWithValue("@lvl", 4)
            End If

            cmd.ExecuteNonQuery()
                con.Close()
            load()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "delete from login where id_username=@id;"

            cmd.Parameters.AddWithValue("@id", id.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Formlogin.Visible = True
        Me.Close()
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub
End Class