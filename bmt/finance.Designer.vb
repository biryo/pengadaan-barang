<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class finance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(finance))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.search = New System.Windows.Forms.TextBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nm = New System.Windows.Forms.TextBox()
        Me.no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_fin = New System.Windows.Forms.TextBox()
        Me.pengajuan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id_pa = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(42, 248)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 136
        Me.PictureBox3.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.ForeColor = System.Drawing.Color.Cyan
        Me.Panel5.Location = New System.Drawing.Point(78, 266)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(78, 1)
        Me.Panel5.TabIndex = 135
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.Gainsboro
        Me.search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(78, 248)
        Me.search.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(75, 13)
        Me.search.TabIndex = 134
        Me.search.Text = "Search"
        '
        'delete
        '
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delete.Location = New System.Drawing.Point(306, 179)
        Me.delete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(53, 26)
        Me.delete.TabIndex = 133
        Me.delete.Text = "Delete"
        Me.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.edit.Location = New System.Drawing.Point(306, 145)
        Me.edit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(53, 26)
        Me.edit.TabIndex = 132
        Me.edit.Text = "Edit"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancel.Location = New System.Drawing.Point(306, 110)
        Me.cancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(53, 26)
        Me.cancel.TabIndex = 131
        Me.cancel.Text = "Cancel"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.simpan.Location = New System.Drawing.Point(306, 75)
        Me.simpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(53, 26)
        Me.simpan.TabIndex = 130
        Me.simpan.Text = "Save"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.simpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 279)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(326, 114)
        Me.DataGridView1.TabIndex = 129
        '
        'nm
        '
        Me.nm.Location = New System.Drawing.Point(136, 133)
        Me.nm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(159, 20)
        Me.nm.TabIndex = 126
        '
        'no
        '
        Me.no.Location = New System.Drawing.Point(136, 105)
        Me.no.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(159, 20)
        Me.no.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Project Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(36, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Date"
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 44)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 139
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "ID Finance"
        Me.Label4.Visible = False
        '
        'id_fin
        '
        Me.id_fin.Location = New System.Drawing.Point(306, 24)
        Me.id_fin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.id_fin.Name = "id_fin"
        Me.id_fin.Size = New System.Drawing.Size(72, 20)
        Me.id_fin.TabIndex = 143
        Me.id_fin.Visible = False
        '
        'pengajuan
        '
        Me.pengajuan.Location = New System.Drawing.Point(136, 164)
        Me.pengajuan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pengajuan.Multiline = True
        Me.pengajuan.Name = "pengajuan"
        Me.pengajuan.Size = New System.Drawing.Size(159, 20)
        Me.pengajuan.TabIndex = 146
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Status Pengajuan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(34, 78)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Pilih PA"
        '
        'id_pa
        '
        Me.id_pa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.id_pa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.id_pa.BackColor = System.Drawing.Color.Silver
        Me.id_pa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.id_pa.ForeColor = System.Drawing.Color.Black
        Me.id_pa.FormattingEnabled = True
        Me.id_pa.Location = New System.Drawing.Point(136, 75)
        Me.id_pa.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.id_pa.Name = "id_pa"
        Me.id_pa.Size = New System.Drawing.Size(159, 21)
        Me.id_pa.TabIndex = 155
        '
        'finance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 420)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.id_pa)
        Me.Controls.Add(Me.pengajuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id_fin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.nm)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "finance"
        Me.Text = "finance"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents search As TextBox
    Friend WithEvents delete As Button
    Friend WithEvents edit As Button
    Friend WithEvents cancel As Button
    Friend WithEvents simpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nm As TextBox
    Friend WithEvents no As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents id_fin As TextBox
    Friend WithEvents pengajuan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents id_pa As ComboBox
End Class
