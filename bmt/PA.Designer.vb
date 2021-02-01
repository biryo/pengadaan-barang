<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PA))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.no_pa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prjk_nm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.id_pa = New System.Windows.Forms.TextBox()
        Me.nm_brg = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.price_unit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.add_list = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.unit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tmbh_data = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.detail = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.hapus = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No"
        '
        'no_pa
        '
        Me.no_pa.BackColor = System.Drawing.Color.Silver
        Me.no_pa.Dock = System.Windows.Forms.DockStyle.Left
        Me.no_pa.ForeColor = System.Drawing.Color.Black
        Me.no_pa.Location = New System.Drawing.Point(132, 2)
        Me.no_pa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.no_pa.Name = "no_pa"
        Me.no_pa.Size = New System.Drawing.Size(164, 26)
        Me.no_pa.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Project Name"
        '
        'prjk_nm
        '
        Me.prjk_nm.BackColor = System.Drawing.Color.Silver
        Me.prjk_nm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prjk_nm.ForeColor = System.Drawing.Color.Black
        Me.prjk_nm.Location = New System.Drawing.Point(132, 41)
        Me.prjk_nm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.prjk_nm.Name = "prjk_nm"
        Me.prjk_nm.Size = New System.Drawing.Size(382, 26)
        Me.prjk_nm.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 38)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(307, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "PROJECT ADVANCE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.LightGray
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.ForeColor = System.Drawing.Color.Black
        Me.save.Image = CType(resources.GetObject("save.Image"), System.Drawing.Image)
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(520, 115)
        Me.save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(126, 38)
        Me.save.TabIndex = 15
        Me.save.Text = "Save"
        Me.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.LightGray
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancel.ForeColor = System.Drawing.Color.Black
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancel.Location = New System.Drawing.Point(520, 158)
        Me.cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(126, 37)
        Me.cancel.TabIndex = 16
        Me.cancel.Text = "Cancel"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.LightGray
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.ForeColor = System.Drawing.Color.Black
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.edit.Location = New System.Drawing.Point(520, 199)
        Me.edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(126, 35)
        Me.edit.TabIndex = 17
        Me.edit.Text = "Edit"
        Me.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.LightGray
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete.ForeColor = System.Drawing.Color.Black
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delete.Location = New System.Drawing.Point(520, 238)
        Me.delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(126, 37)
        Me.delete.TabIndex = 18
        Me.delete.Text = "Delete"
        Me.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.UseVisualStyleBackColor = False
        '
        'id_pa
        '
        Me.id_pa.BackColor = System.Drawing.Color.Gainsboro
        Me.id_pa.Dock = System.Windows.Forms.DockStyle.Left
        Me.id_pa.Location = New System.Drawing.Point(520, 2)
        Me.id_pa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.id_pa.Name = "id_pa"
        Me.id_pa.Size = New System.Drawing.Size(32, 26)
        Me.id_pa.TabIndex = 105
        Me.id_pa.Visible = False
        '
        'nm_brg
        '
        Me.nm_brg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.nm_brg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.nm_brg.BackColor = System.Drawing.Color.Silver
        Me.nm_brg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nm_brg.ForeColor = System.Drawing.Color.Black
        Me.nm_brg.FormattingEnabled = True
        Me.nm_brg.Location = New System.Drawing.Point(133, 118)
        Me.nm_brg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nm_brg.Name = "nm_brg"
        Me.nm_brg.Size = New System.Drawing.Size(380, 28)
        Me.nm_brg.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 43)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Description"
        '
        'qty
        '
        Me.qty.BackColor = System.Drawing.Color.Silver
        Me.qty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.qty.ForeColor = System.Drawing.Color.Black
        Me.qty.Location = New System.Drawing.Point(132, 199)
        Me.qty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(382, 26)
        Me.qty.TabIndex = 115
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 39)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "QTY"
        '
        'price_unit
        '
        Me.price_unit.BackColor = System.Drawing.Color.Silver
        Me.price_unit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.price_unit.ForeColor = System.Drawing.Color.Black
        Me.price_unit.Location = New System.Drawing.Point(132, 158)
        Me.price_unit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.price_unit.Name = "price_unit"
        Me.price_unit.Size = New System.Drawing.Size(382, 26)
        Me.price_unit.TabIndex = 113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 41)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Price/Unit"
        '
        'dtp
        '
        Me.dtp.CustomFormat = "yyyy/MM/dd"
        Me.dtp.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(133, 80)
        Me.dtp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(140, 26)
        Me.dtp.TabIndex = 118
        '
        'add_list
        '
        Me.add_list.AutoSize = True
        Me.add_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.add_list.ForeColor = System.Drawing.Color.Black
        Me.add_list.Location = New System.Drawing.Point(521, 80)
        Me.add_list.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.add_list.Name = "add_list"
        Me.add_list.Size = New System.Drawing.Size(148, 24)
        Me.add_list.TabIndex = 119
        Me.add_list.Text = "Add Description"
        Me.add_list.UseVisualStyleBackColor = False
        Me.add_list.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(3, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(772, 20)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Search Detail PA"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.54358!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.6063!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.85827!))
        Me.TableLayoutPanel1.Controls.Add(Me.add_list, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.save, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.id_pa, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.unit, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.qty, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.price_unit, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.dtp, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nm_brg, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.no_pa, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.prjk_nm, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.edit, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.delete, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cancel, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tmbh_data, 2, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.42857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47619!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.95238!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.38095!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.19048!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8541!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.4924!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 359)
        Me.TableLayoutPanel1.TabIndex = 122
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(132, 279)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(382, 78)
        Me.TableLayoutPanel2.TabIndex = 123
        '
        'unit
        '
        Me.unit.BackColor = System.Drawing.Color.Silver
        Me.unit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unit.ForeColor = System.Drawing.Color.Black
        Me.unit.Location = New System.Drawing.Point(132, 238)
        Me.unit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(382, 26)
        Me.unit.TabIndex = 117
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(3, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 41)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Unit"
        '
        'tmbh_data
        '
        Me.tmbh_data.BackColor = System.Drawing.Color.LightGray
        Me.tmbh_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbh_data.Image = CType(resources.GetObject("tmbh_data.Image"), System.Drawing.Image)
        Me.tmbh_data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tmbh_data.Location = New System.Drawing.Point(521, 282)
        Me.tmbh_data.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tmbh_data.Name = "tmbh_data"
        Me.tmbh_data.Size = New System.Drawing.Size(124, 40)
        Me.tmbh_data.TabIndex = 124
        Me.tmbh_data.Text = "Item"
        Me.tmbh_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tmbh_data.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 399)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.08197!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.91803!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(784, 256)
        Me.TableLayoutPanel3.TabIndex = 123
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.detail, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(778, 85)
        Me.TableLayoutPanel4.TabIndex = 124
        '
        'detail
        '
        Me.detail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.detail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.detail.BackColor = System.Drawing.Color.Silver
        Me.detail.Dock = System.Windows.Forms.DockStyle.Left
        Me.detail.ForeColor = System.Drawing.Color.Black
        Me.detail.FormattingEnabled = True
        Me.detail.Location = New System.Drawing.Point(4, 40)
        Me.detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.detail.Name = "detail"
        Me.detail.Size = New System.Drawing.Size(188, 28)
        Me.detail.TabIndex = 120
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(3, 91)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(778, 163)
        Me.DataGridView1.TabIndex = 10
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.LightGray
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox1, 0, 3)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 363.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(790, 694)
        Me.TableLayoutPanel5.TabIndex = 124
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.LightGray
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(784, 30)
        Me.TableLayoutPanel6.TabIndex = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 660)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 126
        Me.PictureBox1.TabStop = False
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(494, 0)
        Me.hapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(10, 26)
        Me.hapus.TabIndex = 125
        Me.hapus.Visible = False
        '
        'PA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 694)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.hapus)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PA"
        Me.Text = " "
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents no_pa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents prjk_nm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents save As Button
    Friend WithEvents cancel As Button
    Friend WithEvents edit As Button
    Friend WithEvents delete As Button
    Friend WithEvents id_pa As TextBox
    Friend WithEvents nm_brg As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents qty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents price_unit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents add_list As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents unit As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents detail As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents hapus As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmbh_data As Button
End Class
