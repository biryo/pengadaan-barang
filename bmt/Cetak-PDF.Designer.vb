<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak_PDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cetak_PDF))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rev = New System.Windows.Forms.ComboBox()
        Me.no_qbi = New System.Windows.Forms.ComboBox()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.ForeColor = System.Drawing.Color.Black
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(583, 334)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(275, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 21)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "View"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rev)
        Me.SplitContainer1.Panel1.Controls.Add(Me.no_qbi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(583, 397)
        Me.SplitContainer1.SplitterDistance = 59
        Me.SplitContainer1.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(425, 9)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(548, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(145, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Revisi"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NO QBI"
        Me.Label1.UseWaitCursor = True
        '
        'rev
        '
        Me.rev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.rev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.rev.BackColor = System.Drawing.Color.White
        Me.rev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rev.ForeColor = System.Drawing.Color.Black
        Me.rev.FormattingEnabled = True
        Me.rev.Location = New System.Drawing.Point(148, 25)
        Me.rev.Name = "rev"
        Me.rev.Size = New System.Drawing.Size(121, 21)
        Me.rev.TabIndex = 8
        '
        'no_qbi
        '
        Me.no_qbi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.no_qbi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.no_qbi.BackColor = System.Drawing.Color.White
        Me.no_qbi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.no_qbi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.no_qbi.ForeColor = System.Drawing.Color.Black
        Me.no_qbi.FormattingEnabled = True
        Me.no_qbi.Location = New System.Drawing.Point(15, 26)
        Me.no_qbi.Name = "no_qbi"
        Me.no_qbi.Size = New System.Drawing.Size(121, 21)
        Me.no_qbi.TabIndex = 7
        '
        'Cetak_PDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(583, 397)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cetak_PDF"
        Me.Text = "Cetak_PDF"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents no_qbi As ComboBox
    Friend WithEvents rev As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
