<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formvendor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formvendor))
        Me.delete = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.simpan = New System.Windows.Forms.Button()
        Me.deskripsi = New System.Windows.Forms.TextBox()
        Me.cp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nm_vendor = New System.Windows.Forms.TextBox()
        Me.id_vendor = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pt_vendor = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.search = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delete.Location = New System.Drawing.Point(314, 190)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(65, 22)
        Me.delete.TabIndex = 23
        Me.delete.Text = "Delete"
        Me.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancel.Location = New System.Drawing.Point(314, 136)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(65, 22)
        Me.cancel.TabIndex = 22
        Me.cancel.Text = "Cancel"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(286, 117)
        Me.DataGridView1.TabIndex = 21
        '
        'simpan
        '
        Me.simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.simpan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.simpan.Location = New System.Drawing.Point(314, 110)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(65, 22)
        Me.simpan.TabIndex = 19
        Me.simpan.Text = "Save"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.simpan.UseVisualStyleBackColor = False
        '
        'deskripsi
        '
        Me.deskripsi.BackColor = System.Drawing.Color.Silver
        Me.deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.deskripsi.Location = New System.Drawing.Point(104, 149)
        Me.deskripsi.Multiline = True
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Size = New System.Drawing.Size(199, 56)
        Me.deskripsi.TabIndex = 3
        '
        'cp
        '
        Me.cp.BackColor = System.Drawing.Color.Silver
        Me.cp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cp.ForeColor = System.Drawing.Color.Black
        Me.cp.Location = New System.Drawing.Point(104, 76)
        Me.cp.Name = "cp"
        Me.cp.Size = New System.Drawing.Size(199, 13)
        Me.cp.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama Vendor"
        '
        'nm_vendor
        '
        Me.nm_vendor.BackColor = System.Drawing.Color.Silver
        Me.nm_vendor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nm_vendor.ForeColor = System.Drawing.Color.Black
        Me.nm_vendor.Location = New System.Drawing.Point(104, 52)
        Me.nm_vendor.Name = "nm_vendor"
        Me.nm_vendor.Size = New System.Drawing.Size(199, 13)
        Me.nm_vendor.TabIndex = 1
        '
        'id_vendor
        '
        Me.id_vendor.Location = New System.Drawing.Point(390, 47)
        Me.id_vendor.Name = "id_vendor"
        Me.id_vendor.Size = New System.Drawing.Size(10, 20)
        Me.id_vendor.TabIndex = 0
        Me.id_vendor.Visible = False
        Me.id_vendor.WordWrap = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(314, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 22)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Edit"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Deskripsi"
        '
        'alamat
        '
        Me.alamat.BackColor = System.Drawing.Color.Silver
        Me.alamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.alamat.ForeColor = System.Drawing.Color.Black
        Me.alamat.Location = New System.Drawing.Point(104, 126)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(199, 13)
        Me.alamat.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Nama PT"
        '
        'pt_vendor
        '
        Me.pt_vendor.BackColor = System.Drawing.Color.Silver
        Me.pt_vendor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pt_vendor.ForeColor = System.Drawing.Color.Black
        Me.pt_vendor.Location = New System.Drawing.Point(104, 100)
        Me.pt_vendor.Name = "pt_vendor"
        Me.pt_vendor.Size = New System.Drawing.Size(199, 13)
        Me.pt_vendor.TabIndex = 26
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(698, 346)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.57143!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.42857!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(43, 45)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30303!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.69697!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 5)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.160305!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.160305!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.923664!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.778625!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.80153!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(37, 24)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25951!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.91349!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.91349!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.91349!))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(14, 22)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(20, 1)
        Me.TableLayoutPanel3.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(104, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(104, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(103, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 1)
        Me.Panel3.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(104, 145)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 1)
        Me.Panel4.TabIndex = 34
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(103, 211)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 1)
        Me.Panel5.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(217, 255)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(249, 272)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(78, 1)
        Me.Panel6.TabIndex = 119
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.LightGray
        Me.search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(249, 255)
        Me.search.Margin = New System.Windows.Forms.Padding(2)
        Me.search.Multiline = True
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(75, 17)
        Me.search.TabIndex = 120
        Me.search.Text = "Search"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(358, -1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 122
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "VENDOR"
        '
        'Formvendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(391, 431)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.id_vendor)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cp)
        Me.Controls.Add(Me.pt_vendor)
        Me.Controls.Add(Me.nm_vendor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.deskripsi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "Formvendor"
        Me.Text = "Data Vendor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents delete As Button
    Friend WithEvents cancel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents simpan As Button
    Friend WithEvents deskripsi As TextBox
    Friend WithEvents cp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nm_vendor As TextBox
    Friend WithEvents id_vendor As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents alamat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pt_vendor As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents search As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
End Class
