<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputlogistik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inputlogistik))
        Me.resi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.jenis_pengiriman = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nm_jasa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.estimasi_waktu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tmpt_tujuan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.no_poo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.stts = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.id_logistik = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'resi
        '
        Me.resi.BackColor = System.Drawing.Color.Silver
        Me.resi.ForeColor = System.Drawing.Color.Black
        Me.resi.Location = New System.Drawing.Point(130, 34)
        Me.resi.Name = "resi"
        Me.resi.Size = New System.Drawing.Size(107, 20)
        Me.resi.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Resi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "yyyy-MM-dd"
        Me.dtp1.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(130, 3)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(93, 20)
        Me.dtp1.TabIndex = 6
        '
        'jenis_pengiriman
        '
        Me.jenis_pengiriman.BackColor = System.Drawing.Color.Silver
        Me.jenis_pengiriman.ForeColor = System.Drawing.Color.Black
        Me.jenis_pengiriman.Location = New System.Drawing.Point(130, 65)
        Me.jenis_pengiriman.Name = "jenis_pengiriman"
        Me.jenis_pengiriman.Size = New System.Drawing.Size(107, 20)
        Me.jenis_pengiriman.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jenis Pengiriman"
        '
        'nm_jasa
        '
        Me.nm_jasa.BackColor = System.Drawing.Color.Silver
        Me.nm_jasa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nm_jasa.ForeColor = System.Drawing.Color.Black
        Me.nm_jasa.Location = New System.Drawing.Point(130, 96)
        Me.nm_jasa.Name = "nm_jasa"
        Me.nm_jasa.Size = New System.Drawing.Size(230, 20)
        Me.nm_jasa.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 31)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nama Jasa"
        '
        'estimasi_waktu
        '
        Me.estimasi_waktu.BackColor = System.Drawing.Color.Silver
        Me.estimasi_waktu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.estimasi_waktu.ForeColor = System.Drawing.Color.Black
        Me.estimasi_waktu.Location = New System.Drawing.Point(130, 127)
        Me.estimasi_waktu.Name = "estimasi_waktu"
        Me.estimasi_waktu.Size = New System.Drawing.Size(230, 20)
        Me.estimasi_waktu.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 31)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Estimasi Waktu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 31)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Status Pengiriman"
        '
        'tmpt_tujuan
        '
        Me.tmpt_tujuan.BackColor = System.Drawing.Color.Silver
        Me.tmpt_tujuan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tmpt_tujuan.ForeColor = System.Drawing.Color.Black
        Me.tmpt_tujuan.Location = New System.Drawing.Point(130, 158)
        Me.tmpt_tujuan.Name = "tmpt_tujuan"
        Me.tmpt_tujuan.Size = New System.Drawing.Size(230, 20)
        Me.tmpt_tujuan.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 31)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tempat Tujuan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(3, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 31)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "No P.O"
        '
        'no_poo
        '
        Me.no_poo.BackColor = System.Drawing.Color.Silver
        Me.no_poo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.no_poo.ForeColor = System.Drawing.Color.Black
        Me.no_poo.FormattingEnabled = True
        Me.no_poo.Items.AddRange(New Object() {"test"})
        Me.no_poo.Location = New System.Drawing.Point(130, 189)
        Me.no_poo.Name = "no_poo"
        Me.no_poo.Size = New System.Drawing.Size(107, 21)
        Me.no_poo.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(366, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 25)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Save"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(366, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 25)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Edit"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(366, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 25)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(366, 158)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 25)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Cancel"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'stts
        '
        Me.stts.BackColor = System.Drawing.Color.Silver
        Me.stts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stts.ForeColor = System.Drawing.Color.Black
        Me.stts.FormattingEnabled = True
        Me.stts.Items.AddRange(New Object() {"Packing", "Delivery", "Delivered"})
        Me.stts.Location = New System.Drawing.Point(130, 220)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(107, 21)
        Me.stts.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 316)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(579, 106)
        Me.DataGridView1.TabIndex = 24
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightGray
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.96753!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.68768!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.4403!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.id_logistik, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtp1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.jenis_pengiriman, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.resi, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nm_jasa, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.estimasi_waktu, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tmpt_tujuan, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.no_poo, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.stts, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Cyan
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 1)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(581, 311)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'id_logistik
        '
        Me.id_logistik.BackColor = System.Drawing.Color.Silver
        Me.id_logistik.Dock = System.Windows.Forms.DockStyle.Right
        Me.id_logistik.ForeColor = System.Drawing.Color.Black
        Me.id_logistik.Location = New System.Drawing.Point(470, 3)
        Me.id_logistik.Name = "id_logistik"
        Me.id_logistik.Size = New System.Drawing.Size(108, 20)
        Me.id_logistik.TabIndex = 25
        Me.id_logistik.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightGray
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(585, 452)
        Me.TableLayoutPanel2.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 427)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'inputlogistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(585, 452)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inputlogistik"
        Me.Text = "Logistik"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents resi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents jenis_pengiriman As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nm_jasa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents estimasi_waktu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tmpt_tujuan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents no_poo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents stts As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents id_logistik As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
