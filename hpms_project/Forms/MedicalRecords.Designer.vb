<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalRecords
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvMedicalRecords = New DataGridView()
        codate = New DataGridViewTextBoxColumn()
        covisittype = New DataGridViewTextBoxColumn()
        colDiagnosis = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colAction = New DataGridViewTextBoxColumn()
        lblTitle = New Label()
        lblSubtitle = New Label()
        lblRecordCount = New Label()
        btnPrevious = New Button()
        btnPage3 = New Button()
        btnNext = New Button()
        CType(dgvMedicalRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvMedicalRecords
        ' 
        dgvMedicalRecords.AllowUserToAddRows = False
        dgvMedicalRecords.AllowUserToDeleteRows = False
        dgvMedicalRecords.AllowUserToResizeRows = False
        dgvMedicalRecords.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMedicalRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMedicalRecords.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Lucida Sans", 11F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvMedicalRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMedicalRecords.ColumnHeadersHeight = 50
        dgvMedicalRecords.Columns.AddRange(New DataGridViewColumn() {codate, covisittype, colDiagnosis, colStatus, colAction})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.Padding = New Padding(8, 4, 8, 4)
        DataGridViewCellStyle7.SelectionBackColor = Color.White
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvMedicalRecords.DefaultCellStyle = DataGridViewCellStyle7
        dgvMedicalRecords.Location = New Point(19, 75)
        dgvMedicalRecords.Name = "dgvMedicalRecords"
        dgvMedicalRecords.ReadOnly = True
        dgvMedicalRecords.RowHeadersVisible = False
        dgvMedicalRecords.RowTemplate.Height = 60
        dgvMedicalRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMedicalRecords.Size = New Size(903, 474)
        dgvMedicalRecords.TabIndex = 0
        ' 
        ' codate
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        codate.DefaultCellStyle = DataGridViewCellStyle2
        codate.FillWeight = 130F
        codate.HeaderText = "DATE"
        codate.Name = "codate"
        codate.ReadOnly = True
        ' 
        ' covisittype
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        covisittype.DefaultCellStyle = DataGridViewCellStyle3
        covisittype.FillWeight = 150F
        covisittype.HeaderText = "VISIT TYPE"
        covisittype.Name = "covisittype"
        covisittype.ReadOnly = True
        ' 
        ' colDiagnosis
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        colDiagnosis.DefaultCellStyle = DataGridViewCellStyle4
        colDiagnosis.FillWeight = 210F
        colDiagnosis.HeaderText = "NOTE/DIAGNOSIS"
        colDiagnosis.Name = "colDiagnosis"
        colDiagnosis.ReadOnly = True
        ' 
        ' colStatus
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        colStatus.DefaultCellStyle = DataGridViewCellStyle5
        colStatus.FillWeight = 140F
        colStatus.HeaderText = "STATUS"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colAction
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.ForeColor = Color.MediumBlue
        colAction.DefaultCellStyle = DataGridViewCellStyle6
        colAction.HeaderText = "ACTION"
        colAction.Name = "colAction"
        colAction.ReadOnly = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Lucida Sans", 20F, FontStyle.Bold)
        lblTitle.Location = New Point(28, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(284, 31)
        lblTitle.TabIndex = 1
        lblTitle.Text = "MEDICAL RECORDS"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        lblSubtitle.Location = New Point(28, 42)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(434, 16)
        lblSubtitle.TabIndex = 2
        lblSubtitle.Text = "view your consultation history, medical rec, and last result"
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.AutoSize = True
        lblRecordCount.BackColor = Color.White
        lblRecordCount.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        lblRecordCount.Location = New Point(80, 512)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(236, 16)
        lblRecordCount.TabIndex = 3
        lblRecordCount.Text = "SHOWING 1 TO 5 OF 5 RECORDS"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        btnPrevious.Location = New Point(331, 507)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(25, 25)
        btnPrevious.TabIndex = 4
        btnPrevious.Text = "<"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnPage3
        ' 
        btnPage3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnPage3.FlatStyle = FlatStyle.Flat
        btnPage3.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        btnPage3.Location = New Point(362, 507)
        btnPage3.Name = "btnPage3"
        btnPage3.Size = New Size(25, 25)
        btnPage3.TabIndex = 5
        btnPage3.Text = "3"
        btnPage3.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        btnNext.Location = New Point(393, 507)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(25, 25)
        btnNext.TabIndex = 6
        btnNext.Text = ">"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' MedicalRecords
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(954, 561)
        Controls.Add(btnNext)
        Controls.Add(btnPage3)
        Controls.Add(btnPrevious)
        Controls.Add(lblRecordCount)
        Controls.Add(lblSubtitle)
        Controls.Add(lblTitle)
        Controls.Add(dgvMedicalRecords)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "MedicalRecords"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MedicalRecords"
        CType(dgvMedicalRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvMedicalRecords As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnPage3 As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents codate As DataGridViewTextBoxColumn
    Friend WithEvents covisittype As DataGridViewTextBoxColumn
    Friend WithEvents colDiagnosis As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colAction As DataGridViewTextBoxColumn
End Class
