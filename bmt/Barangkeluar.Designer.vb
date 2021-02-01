<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barangkeluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barangkeluar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_bk = New System.Windows.Forms.TextBox()
        Me.unit = New System.Windows.Forms.TextBox()
        Me.partnumber = New System.Windows.Forms.TextBox()
        Me.deskripsi = New System.Windows.Forms.TextBox()
        Me.cancel = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.id_gdg = New System.Windows.Forms.TextBox()
        Me.id_brg = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.projek = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.nm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.detail = New System.Windows.Forms.ComboBox()
        Me.add_item = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmbh_data = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(660, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID BRG"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "QTY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Partnumber"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Deskripsi"
        '
        'id_bk
        '
        Me.id_bk.BackColor = System.Drawing.Color.White
        Me.id_bk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_bk.ForeColor = System.Drawing.Color.Black
        Me.id_bk.Location = New System.Drawing.Point(784, 85)
        Me.id_bk.Name = "id_bk"
        Me.id_bk.Size = New System.Drawing.Size(140, 26)
        Me.id_bk.TabIndex = 4
        Me.id_bk.Visible = False
        '
        'unit
        '
        Me.unit.BackColor = System.Drawing.Color.Silver
        Me.unit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.unit.ForeColor = System.Drawing.Color.Black
        Me.unit.Location = New System.Drawing.Point(142, 354)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(350, 19)
        Me.unit.TabIndex = 5
        '
        'partnumber
        '
        Me.partnumber.BackColor = System.Drawing.Color.Silver
        Me.partnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partnumber.ForeColor = System.Drawing.Color.Black
        Me.partnumber.Location = New System.Drawing.Point(142, 306)
        Me.partnumber.Name = "partnumber"
        Me.partnumber.Size = New System.Drawing.Size(350, 19)
        Me.partnumber.TabIndex = 4
        '
        'deskripsi
        '
        Me.deskripsi.BackColor = System.Drawing.Color.Silver
        Me.deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.deskripsi.ForeColor = System.Drawing.Color.Black
        Me.deskripsi.Location = New System.Drawing.Point(142, 257)
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Size = New System.Drawing.Size(350, 19)
        Me.deskripsi.TabIndex = 3
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancel.Location = New System.Drawing.Point(522, 197)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(93, 42)
        Me.cancel.TabIndex = 7
        Me.cancel.Text = "Cancel"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.edit.Location = New System.Drawing.Point(522, 245)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(93, 42)
        Me.edit.TabIndex = 8
        Me.edit.Text = "Edit"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delete.Location = New System.Drawing.Point(522, 292)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(93, 42)
        Me.delete.TabIndex = 9
        Me.delete.Text = "Delete"
        Me.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.UseVisualStyleBackColor = False
        '
        'simpan
        '
        Me.simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.simpan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.simpan.Location = New System.Drawing.Point(522, 149)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(93, 42)
        Me.simpan.TabIndex = 6
        Me.simpan.Text = "Save"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.simpan.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(21, 586)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(590, 158)
        Me.DataGridView1.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 26)
        Me.DateTimePicker1.TabIndex = 13
        '
        'id_gdg
        '
        Me.id_gdg.Location = New System.Drawing.Point(784, 126)
        Me.id_gdg.Name = "id_gdg"
        Me.id_gdg.Size = New System.Drawing.Size(140, 26)
        Me.id_gdg.TabIndex = 14
        Me.id_gdg.Visible = False
        '
        'id_brg
        '
        Me.id_brg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.id_brg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.id_brg.BackColor = System.Drawing.Color.Silver
        Me.id_brg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.id_brg.ForeColor = System.Drawing.Color.Black
        Me.id_brg.FormattingEnabled = True
        Me.id_brg.Location = New System.Drawing.Point(142, 212)
        Me.id_brg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.id_brg.Name = "id_brg"
        Me.id_brg.Size = New System.Drawing.Size(348, 28)
        Me.id_brg.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Tanggal Keluar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Pilih Barang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 49)
        Me.Panel1.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(254, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ITEM PERMISSION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(604, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(142, 280)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(350, 2)
        Me.Panel4.TabIndex = 110
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 2)
        Me.Panel5.TabIndex = 111
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(142, 329)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(350, 2)
        Me.Panel6.TabIndex = 111
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(142, 377)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(350, 2)
        Me.Panel7.TabIndex = 112
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(142, 189)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 2)
        Me.Panel2.TabIndex = 114
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 2)
        Me.Panel3.TabIndex = 111
        '
        'projek
        '
        Me.projek.BackColor = System.Drawing.Color.Silver
        Me.projek.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.projek.ForeColor = System.Drawing.Color.Black
        Me.projek.Location = New System.Drawing.Point(142, 165)
        Me.projek.Name = "projek"
        Me.projek.Size = New System.Drawing.Size(350, 19)
        Me.projek.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Perihal"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(142, 146)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(350, 2)
        Me.Panel8.TabIndex = 117
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Black
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(300, 2)
        Me.Panel9.TabIndex = 111
        '
        'nm
        '
        Me.nm.BackColor = System.Drawing.Color.Silver
        Me.nm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nm.ForeColor = System.Drawing.Color.Black
        Me.nm.Location = New System.Drawing.Point(142, 123)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(350, 19)
        Me.nm.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "Nama"
        '
        'detail
        '
        Me.detail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.detail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.detail.BackColor = System.Drawing.Color.White
        Me.detail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.detail.ForeColor = System.Drawing.Color.Black
        Me.detail.FormattingEnabled = True
        Me.detail.Location = New System.Drawing.Point(386, 531)
        Me.detail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.detail.Name = "detail"
        Me.detail.Size = New System.Drawing.Size(229, 28)
        Me.detail.TabIndex = 10
        '
        'add_item
        '
        Me.add_item.AutoSize = True
        Me.add_item.ForeColor = System.Drawing.Color.Black
        Me.add_item.Location = New System.Drawing.Point(664, 62)
        Me.add_item.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.add_item.Name = "add_item"
        Me.add_item.Size = New System.Drawing.Size(100, 24)
        Me.add_item.TabIndex = 118
        Me.add_item.Text = "Add Item"
        Me.add_item.UseVisualStyleBackColor = True
        Me.add_item.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(660, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "ID Gudang"
        Me.Label10.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(316, 528)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 34)
        Me.Button1.TabIndex = 120
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tmbh_data
        '
        Me.tmbh_data.BackColor = System.Drawing.Color.LightGray
        Me.tmbh_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbh_data.Image = CType(resources.GetObject("tmbh_data.Image"), System.Drawing.Image)
        Me.tmbh_data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tmbh_data.Location = New System.Drawing.Point(522, 342)
        Me.tmbh_data.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tmbh_data.Name = "tmbh_data"
        Me.tmbh_data.Size = New System.Drawing.Size(93, 40)
        Me.tmbh_data.TabIndex = 121
        Me.tmbh_data.Text = "Item"
        Me.tmbh_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tmbh_data.UseVisualStyleBackColor = False
        '
        'Barangkeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(660, 786)
        Me.Controls.Add(Me.tmbh_data)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.add_item)
        Me.Controls.Add(Me.detail)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.nm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.projek)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.id_gdg)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.id_bk)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id_brg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.unit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.partnumber)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.deskripsi)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Barangkeluar"
        Me.Text = "Barangkeluar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id_bk As TextBox
    Friend WithEvents unit As TextBox
    Friend WithEvents partnumber As TextBox
    Friend WithEvents deskripsi As TextBox
    Friend WithEvents cancel As Button
    Friend WithEvents delete As Button
    Friend WithEvents simpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents id_gdg As TextBox
    Friend WithEvents id_brg As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents projek As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents nm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents edit As Button
    Friend WithEvents detail As ComboBox
    Friend WithEvents add_item As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tmbh_data As Button
End Class
