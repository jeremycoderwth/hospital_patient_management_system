<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lb1Appointment = New Label()
        lb1subtitle = New Label()
        pnlAppointmentContent = New Panel()
        Panel1 = New Panel()
        pnlLine2 = New Panel()
        btnCancelled = New Button()
        btnPast = New Button()
        btnUpcoming = New Button()
        btnAll = New Button()
        dgvAppointments = New DataGridView()
        DateTime = New DataGridViewTextBoxColumn()
        Doctor = New DataGridViewTextBoxColumn()
        Type = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        View = New DataGridViewButtonColumn()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Label18 = New Label()
        Panel5 = New Panel()
        lblYourAppointments = New Label()
        btnAddAppointment = New Button()
        pnlAppointmentContent.SuspendLayout()
        CType(dgvAppointments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lb1Appointment
        ' 
        lb1Appointment.AutoSize = True
        lb1Appointment.Font = New Font("Lucida Sans", 24F, FontStyle.Bold)
        lb1Appointment.Location = New Point(30, 20)
        lb1Appointment.Name = "lb1Appointment"
        lb1Appointment.Size = New Size(262, 37)
        lb1Appointment.TabIndex = 0
        lb1Appointment.Text = "APPOINTMENT"
        ' 
        ' lb1subtitle
        ' 
        lb1subtitle.AutoSize = True
        lb1subtitle.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        lb1subtitle.Location = New Point(30, 58)
        lb1subtitle.Name = "lb1subtitle"
        lb1subtitle.Size = New Size(316, 16)
        lb1subtitle.TabIndex = 1
        lb1subtitle.Text = "view your upcoming and past appointment"
        ' 
        ' pnlAppointmentContent
        ' 
        pnlAppointmentContent.BackColor = Color.White
        pnlAppointmentContent.BorderStyle = BorderStyle.FixedSingle
        pnlAppointmentContent.Controls.Add(Panel1)
        pnlAppointmentContent.Controls.Add(pnlLine2)
        pnlAppointmentContent.Controls.Add(btnCancelled)
        pnlAppointmentContent.Controls.Add(btnPast)
        pnlAppointmentContent.Controls.Add(btnUpcoming)
        pnlAppointmentContent.Controls.Add(btnAll)
        pnlAppointmentContent.Controls.Add(dgvAppointments)
        pnlAppointmentContent.Controls.Add(Button10)
        pnlAppointmentContent.Controls.Add(Button9)
        pnlAppointmentContent.Controls.Add(Button8)
        pnlAppointmentContent.Controls.Add(Button7)
        pnlAppointmentContent.Controls.Add(Button6)
        pnlAppointmentContent.Controls.Add(Button5)
        pnlAppointmentContent.Controls.Add(Label18)
        pnlAppointmentContent.Controls.Add(Panel5)
        pnlAppointmentContent.Controls.Add(lblYourAppointments)
        pnlAppointmentContent.Controls.Add(btnAddAppointment)
        pnlAppointmentContent.Location = New Point(12, 87)
        pnlAppointmentContent.Name = "pnlAppointmentContent"
        pnlAppointmentContent.Size = New Size(1040, 521)
        pnlAppointmentContent.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(0, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1040, 2)
        Panel1.TabIndex = 61
        ' 
        ' pnlLine2
        ' 
        pnlLine2.BackColor = Color.Gray
        pnlLine2.BorderStyle = BorderStyle.FixedSingle
        pnlLine2.Location = New Point(20, 121)
        pnlLine2.Name = "pnlLine2"
        pnlLine2.Size = New Size(1000, 2)
        pnlLine2.TabIndex = 60
        ' 
        ' btnCancelled
        ' 
        btnCancelled.FlatStyle = FlatStyle.Flat
        btnCancelled.Font = New Font("Lucida Sans", 11F, FontStyle.Bold)
        btnCancelled.Location = New Point(642, 75)
        btnCancelled.Name = "btnCancelled"
        btnCancelled.Size = New Size(180, 40)
        btnCancelled.TabIndex = 59
        btnCancelled.Text = "cancelled"
        btnCancelled.UseVisualStyleBackColor = True
        ' 
        ' btnPast
        ' 
        btnPast.FlatStyle = FlatStyle.Flat
        btnPast.Font = New Font("Lucida Sans", 11F, FontStyle.Bold)
        btnPast.Location = New Point(442, 75)
        btnPast.Name = "btnPast"
        btnPast.Size = New Size(180, 40)
        btnPast.TabIndex = 58
        btnPast.Text = "past"
        btnPast.UseVisualStyleBackColor = True
        ' 
        ' btnUpcoming
        ' 
        btnUpcoming.FlatStyle = FlatStyle.Flat
        btnUpcoming.Font = New Font("Lucida Sans", 11F, FontStyle.Bold)
        btnUpcoming.Location = New Point(234, 75)
        btnUpcoming.Name = "btnUpcoming"
        btnUpcoming.Size = New Size(180, 40)
        btnUpcoming.TabIndex = 57
        btnUpcoming.Text = "upcoming"
        btnUpcoming.UseVisualStyleBackColor = True
        ' 
        ' btnAll
        ' 
        btnAll.FlatStyle = FlatStyle.Flat
        btnAll.Font = New Font("Lucida Sans", 11F, FontStyle.Bold)
        btnAll.Location = New Point(30, 75)
        btnAll.Name = "btnAll"
        btnAll.Size = New Size(180, 40)
        btnAll.TabIndex = 56
        btnAll.Text = "all"
        btnAll.UseVisualStyleBackColor = True
        ' 
        ' dgvAppointments
        ' 
        dgvAppointments.AllowUserToAddRows = False
        dgvAppointments.AllowUserToDeleteRows = False
        dgvAppointments.AllowUserToResizeColumns = False
        dgvAppointments.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Lucida Sans", 11F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.Black
        dgvAppointments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAppointments.BackgroundColor = Color.White
        dgvAppointments.BorderStyle = BorderStyle.None
        dgvAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Lucida Sans", 11F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvAppointments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvAppointments.ColumnHeadersHeight = 40
        dgvAppointments.Columns.AddRange(New DataGridViewColumn() {DateTime, Doctor, Type, Status, View})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.White
        DataGridViewCellStyle8.Font = New Font("Lucida Sans", 11F, FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.SelectionBackColor = Color.LightGray
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvAppointments.DefaultCellStyle = DataGridViewCellStyle8
        dgvAppointments.EnableHeadersVisualStyles = False
        dgvAppointments.GridColor = Color.Gray
        dgvAppointments.Location = New Point(20, 125)
        dgvAppointments.MultiSelect = False
        dgvAppointments.Name = "dgvAppointments"
        dgvAppointments.ReadOnly = True
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Control
        DataGridViewCellStyle9.Font = New Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgvAppointments.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgvAppointments.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = Color.White
        DataGridViewCellStyle10.Font = New Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle10.ForeColor = Color.Black
        dgvAppointments.RowsDefaultCellStyle = DataGridViewCellStyle10
        dgvAppointments.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvAppointments.RowTemplate.DefaultCellStyle.BackColor = Color.White
        dgvAppointments.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvAppointments.RowTemplate.Height = 55
        dgvAppointments.ScrollBars = ScrollBars.None
        dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAppointments.Size = New Size(1000, 280)
        dgvAppointments.TabIndex = 55
        dgvAppointments.UseWaitCursor = True
        ' 
        ' DateTime
        ' 
        DateTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Font = New Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTime.DefaultCellStyle = DataGridViewCellStyle3
        DateTime.FillWeight = 180F
        DateTime.HeaderText = "DATE & TIME"
        DateTime.Name = "DateTime"
        DateTime.ReadOnly = True
        DateTime.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Doctor
        ' 
        Doctor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Font = New Font("Lucida Sans", 11.25F, FontStyle.Bold)
        Doctor.DefaultCellStyle = DataGridViewCellStyle4
        Doctor.FillWeight = 130F
        Doctor.HeaderText = "DOCTOR"
        Doctor.Name = "Doctor"
        Doctor.ReadOnly = True
        Doctor.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Type
        ' 
        Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Font = New Font("Lucida Sans", 11.25F, FontStyle.Bold)
        Type.DefaultCellStyle = DataGridViewCellStyle5
        Type.FillWeight = 150F
        Type.HeaderText = "TYPE"
        Type.Name = "Type"
        Type.ReadOnly = True
        Type.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Status
        ' 
        Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Font = New Font("Lucida Sans", 11.25F, FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = Color.Black
        Status.DefaultCellStyle = DataGridViewCellStyle6
        Status.FillWeight = 120F
        Status.HeaderText = "STATUS"
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.SortMode = DataGridViewColumnSortMode.NotSortable
        Status.Width = 160
        ' 
        ' View
        ' 
        View.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Lucida Sans", 12F, FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.White
        DataGridViewCellStyle7.SelectionForeColor = Color.Blue
        View.DefaultCellStyle = DataGridViewCellStyle7
        View.FillWeight = 70F
        View.FlatStyle = FlatStyle.Flat
        View.HeaderText = "VIEW"
        View.Name = "View"
        View.ReadOnly = True
        View.Resizable = DataGridViewTriState.True
        View.Text = "VIEW"
        View.UseColumnTextForButtonValue = True
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Aquamarine
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        Button10.Location = New Point(960, 469)
        Button10.Name = "Button10"
        Button10.Size = New Size(35, 35)
        Button10.TabIndex = 54
        Button10.Text = ">"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Aquamarine
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        Button9.Location = New Point(920, 469)
        Button9.Name = "Button9"
        Button9.Size = New Size(35, 35)
        Button9.TabIndex = 53
        Button9.Text = "5"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Aquamarine
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        Button8.Location = New Point(880, 469)
        Button8.Name = "Button8"
        Button8.Size = New Size(35, 35)
        Button8.TabIndex = 52
        Button8.Text = "4"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Aquamarine
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        Button7.Location = New Point(840, 469)
        Button7.Name = "Button7"
        Button7.Size = New Size(35, 35)
        Button7.TabIndex = 51
        Button7.Text = "3"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Aquamarine
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        Button6.Location = New Point(800, 469)
        Button6.Name = "Button6"
        Button6.Size = New Size(35, 35)
        Button6.TabIndex = 50
        Button6.Text = "2"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Aquamarine
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        Button5.Location = New Point(760, 469)
        Button5.Name = "Button5"
        Button5.Size = New Size(35, 35)
        Button5.TabIndex = 49
        Button5.Text = " 1"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Lucida Sans", 10F, FontStyle.Bold)
        Label18.Location = New Point(30, 481)
        Label18.Name = "Label18"
        Label18.Size = New Size(286, 16)
        Label18.TabIndex = 48
        Label18.Text = "SHOWING 1 TO 5 OF 12 APPOINTMENTS"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Gray
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Location = New Point(0, 459)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1040, 2)
        Panel5.TabIndex = 47
        ' 
        ' lblYourAppointments
        ' 
        lblYourAppointments.AutoSize = True
        lblYourAppointments.Font = New Font("Lucida Sans", 16F, FontStyle.Bold)
        lblYourAppointments.Location = New Point(40, 20)
        lblYourAppointments.Name = "lblYourAppointments"
        lblYourAppointments.Size = New Size(264, 25)
        lblYourAppointments.TabIndex = 4
        lblYourAppointments.Text = "YOUR APPOINTMENTS"
        ' 
        ' btnAddAppointment
        ' 
        btnAddAppointment.BackColor = Color.Aquamarine
        btnAddAppointment.FlatStyle = FlatStyle.Flat
        btnAddAppointment.Font = New Font("Lucida Sans", 9F, FontStyle.Bold)
        btnAddAppointment.Location = New Point(847, 14)
        btnAddAppointment.Name = "btnAddAppointment"
        btnAddAppointment.Size = New Size(164, 30)
        btnAddAppointment.TabIndex = 3
        btnAddAppointment.Text = "+ add appointment"
        btnAddAppointment.UseVisualStyleBackColor = False
        ' 
        ' Appointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Gainsboro
        ClientSize = New Size(1184, 661)
        Controls.Add(pnlAppointmentContent)
        Controls.Add(lb1subtitle)
        Controls.Add(lb1Appointment)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Appointment"
        Text = "Appointment"
        WindowState = FormWindowState.Maximized
        pnlAppointmentContent.ResumeLayout(False)
        pnlAppointmentContent.PerformLayout()
        CType(dgvAppointments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lb1Appointment As Label
    Friend WithEvents lb1subtitle As Label
    Friend WithEvents pnlAppointmentContent As Panel
    Friend WithEvents lblYourAppointments As Label
    Friend WithEvents btnAddAppointment As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents btnCancelled As Button
    Friend WithEvents btnPast As Button
    Friend WithEvents btnUpcoming As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents pnlLine2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTime As DataGridViewTextBoxColumn
    Friend WithEvents Doctor As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents View As DataGridViewButtonColumn
End Class
