<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BloodTestModal
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        DateAndTimeLbl = New Label()
        BloodTestLbl = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        DataGridView2 = New DataGridView()
        PatientKeyColumn = New DataGridViewTextBoxColumn()
        PatientValuesColumn = New DataGridViewTextBoxColumn()
        DataGridView3 = New DataGridView()
        TestInfoKey = New DataGridViewTextBoxColumn()
        TestInfoValuesColumn = New DataGridViewTextBoxColumn()
        TableLayoutPanel2 = New TableLayoutPanel()
        DataGridView1 = New DataGridView()
        ExaminationColumn = New DataGridViewTextBoxColumn()
        ResultColumn = New DataGridViewTextBoxColumn()
        UnitColumn = New DataGridViewTextBoxColumn()
        NormalValuesColumn = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(97, 99)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(DateAndTimeLbl)
        Panel1.Controls.Add(BloodTestLbl)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1258, 122)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label1.Location = New Point(964, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 34)
        Label1.TabIndex = 3
        Label1.Text = "COMPLETED"
        ' 
        ' DateAndTimeLbl
        ' 
        DateAndTimeLbl.AutoSize = True
        DateAndTimeLbl.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        DateAndTimeLbl.Location = New Point(132, 67)
        DateAndTimeLbl.Name = "DateAndTimeLbl"
        DateAndTimeLbl.Size = New Size(245, 34)
        DateAndTimeLbl.TabIndex = 2
        DateAndTimeLbl.Text = "DATE AND TIME"
        ' 
        ' BloodTestLbl
        ' 
        BloodTestLbl.AutoSize = True
        BloodTestLbl.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        BloodTestLbl.Location = New Point(132, 21)
        BloodTestLbl.Name = "BloodTestLbl"
        BloodTestLbl.Size = New Size(196, 34)
        BloodTestLbl.TabIndex = 1
        BloodTestLbl.Text = "BLOOD TEST"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.05395F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 59.9460526F))
        TableLayoutPanel1.Controls.Add(DataGridView2, 0, 0)
        TableLayoutPanel1.Controls.Add(DataGridView3, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1252, 501)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.AllowUserToResizeColumns = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.BorderStyle = BorderStyle.Fixed3D
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {PatientKeyColumn, PatientValuesColumn})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        DataGridView2.Dock = DockStyle.Fill
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.GridColor = Color.DarkGray
        DataGridView2.Location = New Point(10, 3)
        DataGridView2.Margin = New Padding(10, 3, 3, 10)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 62
        DataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView2.RowTemplate.Height = 34
        DataGridView2.ScrollBars = ScrollBars.None
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(488, 488)
        DataGridView2.TabIndex = 4
        ' 
        ' PatientKeyColumn
        ' 
        DataGridViewCellStyle2.Font = New Font("Lucida Sans Unicode", 12F)
        PatientKeyColumn.DefaultCellStyle = DataGridViewCellStyle2
        PatientKeyColumn.FillWeight = 40.0324135F
        PatientKeyColumn.HeaderText = "PATIENT INFORMATION"
        PatientKeyColumn.MinimumWidth = 8
        PatientKeyColumn.Name = "PatientKeyColumn"
        PatientKeyColumn.ReadOnly = True
        PatientKeyColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' PatientValuesColumn
        ' 
        DataGridViewCellStyle3.Font = New Font("Lucida Sans Unicode", 12F)
        PatientValuesColumn.DefaultCellStyle = DataGridViewCellStyle3
        PatientValuesColumn.FillWeight = 59.9675865F
        PatientValuesColumn.HeaderText = ""
        PatientValuesColumn.MinimumWidth = 8
        PatientValuesColumn.Name = "PatientValuesColumn"
        PatientValuesColumn.ReadOnly = True
        PatientValuesColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.AllowUserToResizeColumns = False
        DataGridView3.AllowUserToResizeRows = False
        DataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView3.BackgroundColor = Color.White
        DataGridView3.BorderStyle = BorderStyle.Fixed3D
        DataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.White
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {TestInfoKey, TestInfoValuesColumn})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = Color.White
        DataGridViewCellStyle9.SelectionForeColor = Color.Black
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        DataGridView3.DefaultCellStyle = DataGridViewCellStyle9
        DataGridView3.Dock = DockStyle.Fill
        DataGridView3.GridColor = Color.DarkGray
        DataGridView3.Location = New Point(511, 3)
        DataGridView3.Margin = New Padding(10, 3, 20, 10)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = SystemColors.Control
        DataGridViewCellStyle10.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        DataGridView3.RowHeadersVisible = False
        DataGridView3.RowHeadersWidth = 62
        DataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView3.RowTemplate.Height = 30
        DataGridView3.ScrollBars = ScrollBars.None
        DataGridView3.Size = New Size(721, 488)
        DataGridView3.TabIndex = 5
        ' 
        ' TestInfoKey
        ' 
        DataGridViewCellStyle7.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TestInfoKey.DefaultCellStyle = DataGridViewCellStyle7
        TestInfoKey.FillWeight = 35F
        TestInfoKey.HeaderText = "TEST INFORMATION"
        TestInfoKey.MinimumWidth = 8
        TestInfoKey.Name = "TestInfoKey"
        TestInfoKey.ReadOnly = True
        TestInfoKey.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' TestInfoValuesColumn
        ' 
        DataGridViewCellStyle8.Font = New Font("Lucida Sans Unicode", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TestInfoValuesColumn.DefaultCellStyle = DataGridViewCellStyle8
        TestInfoValuesColumn.FillWeight = 65F
        TestInfoValuesColumn.HeaderText = ""
        TestInfoValuesColumn.MinimumWidth = 8
        TestInfoValuesColumn.Name = "TestInfoValuesColumn"
        TestInfoValuesColumn.ReadOnly = True
        TestInfoValuesColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel2.Controls.Add(DataGridView1, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 122)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 55F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel2.Size = New Size(1258, 922)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = Color.White
        DataGridViewCellStyle11.SelectionForeColor = Color.Black
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ExaminationColumn, ResultColumn, UnitColumn, NormalValuesColumn})
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = SystemColors.Window
        DataGridViewCellStyle16.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle16.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = Color.White
        DataGridViewCellStyle16.SelectionForeColor = Color.Black
        DataGridViewCellStyle16.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle16
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.DarkGray
        DataGridView1.Location = New Point(10, 510)
        DataGridView1.Margin = New Padding(10, 3, 20, 10)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = SystemColors.Control
        DataGridViewCellStyle17.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle17.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridView1.RowTemplate.Height = 32
        DataGridView1.ScrollBars = ScrollBars.None
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1228, 402)
        DataGridView1.TabIndex = 3
        ' 
        ' ExaminationColumn
        ' 
        DataGridViewCellStyle12.Font = New Font("Lucida Sans Unicode", 10F)
        ExaminationColumn.DefaultCellStyle = DataGridViewCellStyle12
        ExaminationColumn.HeaderText = "EXAMINATION"
        ExaminationColumn.MinimumWidth = 8
        ExaminationColumn.Name = "ExaminationColumn"
        ExaminationColumn.ReadOnly = True
        ExaminationColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' ResultColumn
        ' 
        DataGridViewCellStyle13.Font = New Font("Lucida Sans Unicode", 10F)
        ResultColumn.DefaultCellStyle = DataGridViewCellStyle13
        ResultColumn.HeaderText = "RESULT"
        ResultColumn.MinimumWidth = 8
        ResultColumn.Name = "ResultColumn"
        ResultColumn.ReadOnly = True
        ResultColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' UnitColumn
        ' 
        DataGridViewCellStyle14.Font = New Font("Lucida Sans Unicode", 10F)
        UnitColumn.DefaultCellStyle = DataGridViewCellStyle14
        UnitColumn.HeaderText = "UNIT"
        UnitColumn.MinimumWidth = 8
        UnitColumn.Name = "UnitColumn"
        UnitColumn.ReadOnly = True
        UnitColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' NormalValuesColumn
        ' 
        DataGridViewCellStyle15.Font = New Font("Lucida Sans Unicode", 10F)
        NormalValuesColumn.DefaultCellStyle = DataGridViewCellStyle15
        NormalValuesColumn.HeaderText = "NORMAL VALUES"
        NormalValuesColumn.MinimumWidth = 8
        NormalValuesColumn.Name = "NormalValuesColumn"
        NormalValuesColumn.ReadOnly = True
        NormalValuesColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' BloodTestModal
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1258, 1044)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "BloodTestModal"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateAndTimeLbl As Label
    Friend WithEvents BloodTestLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ExaminationColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitColumn As DataGridViewTextBoxColumn
    Friend WithEvents NormalValuesColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestInfoKey As DataGridViewTextBoxColumn
    Friend WithEvents TestInfoValuesColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientKeyColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientValuesColumn As DataGridViewTextBoxColumn
End Class
