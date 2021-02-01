<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gudang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gudang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_gdg = New System.Windows.Forms.TextBox()
        Me.stok = New System.Windows.Forms.TextBox()
        Me.partnumber = New System.Windows.Forms.TextBox()
        Me.unit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.simpan = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.deskripsi = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(622, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Partnumber"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stok"
        '
        'id_gdg
        '
        Me.id_gdg.BackColor = System.Drawing.SystemColors.Control
        Me.id_gdg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_gdg.Location = New System.Drawing.Point(564, 114)
        Me.id_gdg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.id_gdg.Name = "id_gdg"
        Me.id_gdg.Size = New System.Drawing.Size(154, 26)
        Me.id_gdg.TabIndex = 4
        Me.id_gdg.Visible = False
        '
        'stok
        '
        Me.stok.BackColor = System.Drawing.Color.WhiteSmoke
        Me.stok.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.stok.ForeColor = System.Drawing.Color.Black
        Me.stok.Location = New System.Drawing.Point(38, 195)
        Me.stok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(336, 19)
        Me.stok.TabIndex = 6
        '
        'partnumber
        '
        Me.partnumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.partnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.partnumber.ForeColor = System.Drawing.Color.Black
        Me.partnumber.Location = New System.Drawing.Point(40, 258)
        Me.partnumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.partnumber.Name = "partnumber"
        Me.partnumber.Size = New System.Drawing.Size(336, 19)
        Me.partnumber.TabIndex = 7
        '
        'unit
        '
        Me.unit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.unit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.unit.ForeColor = System.Drawing.Color.Black
        Me.unit.Location = New System.Drawing.Point(38, 323)
        Me.unit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(336, 19)
        Me.unit.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(38, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Unit"
        '
        'simpan
        '
        Me.simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.simpan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.simpan.Location = New System.Drawing.Point(418, 168)
        Me.simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(93, 38)
        Me.simpan.TabIndex = 10
        Me.simpan.Text = "Save"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.simpan.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delete.Location = New System.Drawing.Point(418, 314)
        Me.delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(93, 38)
        Me.delete.TabIndex = 11
        Me.delete.Text = "Delete"
        Me.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.edit.Location = New System.Drawing.Point(418, 265)
        Me.edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(93, 38)
        Me.edit.TabIndex = 12
        Me.edit.Text = "Edit"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancel.Location = New System.Drawing.Point(418, 215)
        Me.cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(93, 38)
        Me.cancel.TabIndex = 13
        Me.cancel.Text = "Cancel"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.UseVisualStyleBackColor = False
        '
        'deskripsi
        '
        Me.deskripsi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.deskripsi.ForeColor = System.Drawing.Color.Black
        Me.deskripsi.Location = New System.Drawing.Point(38, 142)
        Me.deskripsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Size = New System.Drawing.Size(336, 19)
        Me.deskripsi.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 431)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(474, 211)
        Me.DataGridView1.TabIndex = 15
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.37276!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.62724!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.955224!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.706468!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.701492!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.452736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.24051!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.47257!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(34, 40)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 29)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(20, 9)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(756, 638)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.51852!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.48148!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(40, 65)
        Me.TableLayoutPanel4.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 48)
        Me.Panel1.TabIndex = 19
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(501, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(218, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "WAREHOUSE"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(38, 168)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(336, 2)
        Me.Panel7.TabIndex = 113
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(42, 285)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 2)
        Me.Panel2.TabIndex = 114
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(42, 346)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 2)
        Me.Panel3.TabIndex = 116
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(38, 222)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(336, 2)
        Me.Panel4.TabIndex = 115
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.Gainsboro
        Me.search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(370, 385)
        Me.search.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(112, 19)
        Me.search.TabIndex = 117
        Me.search.Text = "Search"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.ForeColor = System.Drawing.Color.Cyan
        Me.Panel5.Location = New System.Drawing.Point(368, 412)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(117, 2)
        Me.Panel5.TabIndex = 117
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(314, 385)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 118
        Me.PictureBox1.TabStop = False
        '
        'Gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(564, 668)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.id_gdg)
        Me.Controls.Add(Me.deskripsi)
        Me.Controls.Add(Me.unit)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.partnumber)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Gudang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id_gdg As TextBox
    Friend WithEvents stok As TextBox
    Friend WithEvents partnumber As TextBox
    Friend WithEvents unit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents simpan As Button
    Friend WithEvents delete As Button
    Friend WithEvents edit As Button
    Friend WithEvents cancel As Button
    Friend WithEvents deskripsi As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents search As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
