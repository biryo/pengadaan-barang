<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_ship_to
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_ship_to))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nm_penerima = New System.Windows.Forms.TextBox()
        Me.nm_pt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kontak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_to = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'nm_penerima
        '
        Me.nm_penerima.BackColor = System.Drawing.Color.White
        Me.nm_penerima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nm_penerima.ForeColor = System.Drawing.Color.Black
        Me.nm_penerima.Location = New System.Drawing.Point(97, 36)
        Me.nm_penerima.Name = "nm_penerima"
        Me.nm_penerima.Size = New System.Drawing.Size(231, 20)
        Me.nm_penerima.TabIndex = 1
        '
        'nm_pt
        '
        Me.nm_pt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nm_pt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nm_pt.ForeColor = System.Drawing.Color.Black
        Me.nm_pt.Location = New System.Drawing.Point(97, 69)
        Me.nm_pt.Name = "nm_pt"
        Me.nm_pt.Size = New System.Drawing.Size(231, 20)
        Me.nm_pt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama PT"
        '
        'alamat
        '
        Me.alamat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alamat.ForeColor = System.Drawing.Color.Black
        Me.alamat.Location = New System.Drawing.Point(97, 102)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(231, 20)
        Me.alamat.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Alamat"
        '
        'kontak
        '
        Me.kontak.BackColor = System.Drawing.Color.WhiteSmoke
        Me.kontak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kontak.ForeColor = System.Drawing.Color.Black
        Me.kontak.Location = New System.Drawing.Point(97, 137)
        Me.kontak.Name = "kontak"
        Me.kontak.Size = New System.Drawing.Size(231, 20)
        Me.kontak.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kontak"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(334, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cancel"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(334, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Save"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(334, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 25)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Delete"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(334, 102)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 27)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Edit"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(3, 227)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(665, 144)
        Me.DataGridView1.TabIndex = 22
        '
        'id_to
        '
        Me.id_to.BackColor = System.Drawing.SystemColors.Control
        Me.id_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_to.Location = New System.Drawing.Point(334, 168)
        Me.id_to.Name = "id_to"
        Me.id_to.Size = New System.Drawing.Size(100, 20)
        Me.id_to.TabIndex = 23
        Me.id_to.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightGray
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.1!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.9!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.id_to, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.kontak, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.alamat, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nm_pt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nm_penerima, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 1)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25135!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25135!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25135!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.77019!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.90683!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.56522!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(667, 209)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(627, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightGray
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(671, 374)
        Me.TableLayoutPanel2.TabIndex = 25
        '
        'form_ship_to
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(671, 374)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_ship_to"
        Me.Text = "form_ship_to"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nm_penerima As TextBox
    Friend WithEvents nm_pt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents alamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kontak As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id_to As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
