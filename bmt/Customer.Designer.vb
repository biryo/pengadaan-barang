<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pt = New System.Windows.Forms.TextBox()
        Me.cus = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.TextBox()
        Me.cp = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.id_vendor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name PT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact Number"
        '
        'pt
        '
        Me.pt.Location = New System.Drawing.Point(186, 155)
        Me.pt.Name = "pt"
        Me.pt.Size = New System.Drawing.Size(236, 26)
        Me.pt.TabIndex = 4
        '
        'cus
        '
        Me.cus.Location = New System.Drawing.Point(186, 198)
        Me.cus.Name = "cus"
        Me.cus.Size = New System.Drawing.Size(236, 26)
        Me.cus.TabIndex = 5
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(186, 243)
        Me.add.Multiline = True
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(236, 29)
        Me.add.TabIndex = 6
        '
        'cp
        '
        Me.cp.Location = New System.Drawing.Point(186, 285)
        Me.cp.Multiline = True
        Me.cp.Name = "cp"
        Me.cp.Size = New System.Drawing.Size(236, 29)
        Me.cp.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 386)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(489, 175)
        Me.DataGridView1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(449, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(449, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(449, 265)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Edit"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(449, 317)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Delete"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'id_vendor
        '
        Me.id_vendor.Location = New System.Drawing.Point(591, 97)
        Me.id_vendor.Name = "id_vendor"
        Me.id_vendor.Size = New System.Drawing.Size(106, 26)
        Me.id_vendor.TabIndex = 15
        Me.id_vendor.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(586, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ID Vendor"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(240, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "CUSTOMER"
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.Gainsboro
        Me.search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(102, 338)
        Me.search.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(112, 19)
        Me.search.TabIndex = 118
        Me.search.Text = "Search"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(48, 338)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 120
        Me.PictureBox3.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.ForeColor = System.Drawing.Color.Cyan
        Me.Panel5.Location = New System.Drawing.Point(102, 366)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(117, 2)
        Me.Panel5.TabIndex = 119
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(509, 18)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(20, 20)
        Me.LinkLabel1.TabIndex = 121
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 655)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.id_vendor)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cp)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.cus)
        Me.Controls.Add(Me.pt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer"
        Me.Text = "Vendor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pt As TextBox
    Friend WithEvents cus As TextBox
    Friend WithEvents add As TextBox
    Friend WithEvents cp As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents id_vendor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents search As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
