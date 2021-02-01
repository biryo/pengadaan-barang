<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barangmasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(barangmasuk))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.delete = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.edit = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.unit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.partnumber = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.deskripsi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.add_item = New System.Windows.Forms.CheckBox()
        Me.id_bm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.units = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id_brg = New System.Windows.Forms.ComboBox()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(177, 289)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 22)
        Me.Button1.TabIndex = 147
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(101, 163)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(233, 1)
        Me.Panel7.TabIndex = 142
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(101, 132)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(233, 1)
        Me.Panel6.TabIndex = 141
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(101, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(233, 1)
        Me.Panel4.TabIndex = 140
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 1)
        Me.Panel5.TabIndex = 111
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delete.Location = New System.Drawing.Point(355, 191)
        Me.delete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(61, 27)
        Me.delete.TabIndex = 134
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
        Me.simpan.Location = New System.Drawing.Point(355, 98)
        Me.simpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(61, 27)
        Me.simpan.TabIndex = 131
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
        Me.DataGridView1.Location = New System.Drawing.Point(57, 319)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(297, 121)
        Me.DataGridView1.TabIndex = 136
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.edit.Location = New System.Drawing.Point(355, 161)
        Me.edit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(61, 27)
        Me.edit.TabIndex = 133
        Me.edit.Text = "Edit"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancel.Location = New System.Drawing.Point(355, 129)
        Me.cancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(61, 27)
        Me.cancel.TabIndex = 132
        Me.cancel.Text = "Cancel"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "QTY"
        '
        'unit
        '
        Me.unit.BackColor = System.Drawing.Color.Silver
        Me.unit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.unit.ForeColor = System.Drawing.Color.Black
        Me.unit.Location = New System.Drawing.Point(101, 148)
        Me.unit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(233, 13)
        Me.unit.TabIndex = 130
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Tanggal Masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Partnumber"
        '
        'partnumber
        '
        Me.partnumber.BackColor = System.Drawing.Color.Silver
        Me.partnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partnumber.ForeColor = System.Drawing.Color.Black
        Me.partnumber.Location = New System.Drawing.Point(101, 117)
        Me.partnumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.partnumber.Name = "partnumber"
        Me.partnumber.Size = New System.Drawing.Size(233, 13)
        Me.partnumber.TabIndex = 129
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 50)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 137
        Me.DateTimePicker1.Value = New Date(2020, 12, 4, 18, 31, 0, 0)
        '
        'deskripsi
        '
        Me.deskripsi.BackColor = System.Drawing.Color.Silver
        Me.deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.deskripsi.ForeColor = System.Drawing.Color.Black
        Me.deskripsi.Location = New System.Drawing.Point(101, 85)
        Me.deskripsi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Size = New System.Drawing.Size(233, 13)
        Me.deskripsi.TabIndex = 128
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Deskripsi"
        '
        'add_item
        '
        Me.add_item.AutoSize = True
        Me.add_item.ForeColor = System.Drawing.Color.Black
        Me.add_item.Location = New System.Drawing.Point(460, 29)
        Me.add_item.Name = "add_item"
        Me.add_item.Size = New System.Drawing.Size(68, 17)
        Me.add_item.TabIndex = 152
        Me.add_item.Text = "Add Item"
        Me.add_item.UseVisualStyleBackColor = True
        Me.add_item.Visible = False
        '
        'id_bm
        '
        Me.id_bm.BackColor = System.Drawing.Color.White
        Me.id_bm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_bm.ForeColor = System.Drawing.Color.Black
        Me.id_bm.Location = New System.Drawing.Point(279, 49)
        Me.id_bm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.id_bm.Name = "id_bm"
        Me.id_bm.Size = New System.Drawing.Size(57, 20)
        Me.id_bm.TabIndex = 150
        Me.id_bm.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "ID BRG"
        Me.Label1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(101, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 1)
        Me.Panel1.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 179)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Unit"
        '
        'units
        '
        Me.units.BackColor = System.Drawing.Color.Silver
        Me.units.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.units.ForeColor = System.Drawing.Color.Black
        Me.units.Location = New System.Drawing.Point(101, 175)
        Me.units.Margin = New System.Windows.Forms.Padding(2)
        Me.units.Name = "units"
        Me.units.Size = New System.Drawing.Size(233, 13)
        Me.units.TabIndex = 144
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "Pilih Barang"
        '
        'id_brg
        '
        Me.id_brg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.id_brg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.id_brg.BackColor = System.Drawing.Color.Silver
        Me.id_brg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.id_brg.ForeColor = System.Drawing.Color.Black
        Me.id_brg.FormattingEnabled = True
        Me.id_brg.Location = New System.Drawing.Point(99, 203)
        Me.id_brg.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.id_brg.Name = "id_brg"
        Me.id_brg.Size = New System.Drawing.Size(233, 21)
        Me.id_brg.TabIndex = 153
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.Gainsboro
        Me.search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(224, 294)
        Me.search.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(130, 13)
        Me.search.TabIndex = 155
        Me.search.Text = "Search"
        '
        'barangmasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 458)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.id_brg)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.add_item)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.units)
        Me.Controls.Add(Me.id_bm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.unit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.partnumber)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.deskripsi)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "barangmasuk"
        Me.Text = "barangmasuk"
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents delete As Button
    Friend WithEvents simpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents edit As Button
    Friend WithEvents cancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents unit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents partnumber As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents deskripsi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents add_item As CheckBox
    Friend WithEvents id_bm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents units As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents id_brg As ComboBox
    Friend WithEvents search As TextBox
End Class
