<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        LeftSideBar = New Panel()
        HorizontalLine = New Label()
        DashboardIcon = New PictureBox()
        PeopleIcon = New PictureBox()
        AppointmentIcon = New PictureBox()
        MedRecordsIcon = New PictureBox()
        BillsIcon = New PictureBox()
        LogOutIcon = New PictureBox()
        CostumerSupportPanel = New Panel()
        CostumerSuportLabel3 = New Label()
        CostumerSuportLabel2 = New Label()
        CostumerSuportLabel1 = New Label()
        LOGO = New PictureBox()
        LogOutBtn = New Button()
        BillsBtn = New Button()
        MedRecordsBtn = New Button()
        AppointmentBtn = New Button()
        PeopelBtn = New Button()
        DashboardBtn = New Button()
        TopPanel = New Panel()
        verticalLine = New Label()
        NotifIcon = New PictureBox()
        MessageIcon = New PictureBox()
        MainFormPatientDashboardLabel = New Label()
        ProfileLabel = New Label()
        ProfilePictureIcon = New PictureBox()
        MainPanel = New Panel()
        LeftSideBarVerticalLine = New Label()
        TopPanelHorizontalLine = New Label()
        LeftSideBar.SuspendLayout()
        CType(DashboardIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PeopleIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(AppointmentIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(MedRecordsIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(BillsIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(LogOutIcon, ComponentModel.ISupportInitialize).BeginInit()
        CostumerSupportPanel.SuspendLayout()
        CType(LOGO, ComponentModel.ISupportInitialize).BeginInit()
        TopPanel.SuspendLayout()
        CType(NotifIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(MessageIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfilePictureIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LeftSideBar
        ' 
        LeftSideBar.BackColor = Color.FromArgb(CByte(167), CByte(239), CByte(241))
        LeftSideBar.Controls.Add(LeftSideBarVerticalLine)
        LeftSideBar.Controls.Add(HorizontalLine)
        LeftSideBar.Controls.Add(DashboardIcon)
        LeftSideBar.Controls.Add(PeopleIcon)
        LeftSideBar.Controls.Add(AppointmentIcon)
        LeftSideBar.Controls.Add(MedRecordsIcon)
        LeftSideBar.Controls.Add(BillsIcon)
        LeftSideBar.Controls.Add(LogOutIcon)
        LeftSideBar.Controls.Add(CostumerSupportPanel)
        LeftSideBar.Controls.Add(LOGO)
        LeftSideBar.Controls.Add(LogOutBtn)
        LeftSideBar.Controls.Add(BillsBtn)
        LeftSideBar.Controls.Add(MedRecordsBtn)
        LeftSideBar.Controls.Add(AppointmentBtn)
        LeftSideBar.Controls.Add(PeopelBtn)
        LeftSideBar.Controls.Add(DashboardBtn)
        LeftSideBar.Dock = DockStyle.Left
        LeftSideBar.Location = New Point(0, 0)
        LeftSideBar.Margin = New Padding(3, 2, 3, 2)
        LeftSideBar.Name = "LeftSideBar"
        LeftSideBar.Size = New Size(459, 952)
        LeftSideBar.TabIndex = 0
        ' 
        ' HorizontalLine
        ' 
        HorizontalLine.BackColor = Color.Black
        HorizontalLine.BorderStyle = BorderStyle.FixedSingle
        HorizontalLine.Location = New Point(25, 208)
        HorizontalLine.MinimumSize = New Size(2, 2)
        HorizontalLine.Name = "HorizontalLine"
        HorizontalLine.Size = New Size(401, 2)
        HorizontalLine.TabIndex = 3
        ' 
        ' DashboardIcon
        ' 
        DashboardIcon.BackColor = Color.Transparent
        DashboardIcon.Image = My.Resources.Resources.minimalist
        DashboardIcon.Location = New Point(46, 295)
        DashboardIcon.Margin = New Padding(3, 2, 3, 2)
        DashboardIcon.Name = "DashboardIcon"
        DashboardIcon.Size = New Size(45, 49)
        DashboardIcon.SizeMode = PictureBoxSizeMode.Zoom
        DashboardIcon.TabIndex = 12
        DashboardIcon.TabStop = False
        ' 
        ' PeopleIcon
        ' 
        PeopleIcon.BackColor = Color.Transparent
        PeopleIcon.Image = My.Resources.Resources.user
        PeopleIcon.Location = New Point(46, 344)
        PeopleIcon.Margin = New Padding(3, 2, 3, 2)
        PeopleIcon.Name = "PeopleIcon"
        PeopleIcon.Size = New Size(45, 49)
        PeopleIcon.SizeMode = PictureBoxSizeMode.Zoom
        PeopleIcon.TabIndex = 11
        PeopleIcon.TabStop = False
        ' 
        ' AppointmentIcon
        ' 
        AppointmentIcon.BackColor = Color.Transparent
        AppointmentIcon.Image = My.Resources.Resources.calendar
        AppointmentIcon.Location = New Point(46, 393)
        AppointmentIcon.Margin = New Padding(3, 2, 3, 2)
        AppointmentIcon.Name = "AppointmentIcon"
        AppointmentIcon.Size = New Size(45, 49)
        AppointmentIcon.SizeMode = PictureBoxSizeMode.Zoom
        AppointmentIcon.TabIndex = 10
        AppointmentIcon.TabStop = False
        ' 
        ' MedRecordsIcon
        ' 
        MedRecordsIcon.BackColor = Color.Transparent
        MedRecordsIcon.Image = My.Resources.Resources.edit
        MedRecordsIcon.Location = New Point(46, 442)
        MedRecordsIcon.Margin = New Padding(3, 2, 3, 2)
        MedRecordsIcon.Name = "MedRecordsIcon"
        MedRecordsIcon.Size = New Size(45, 49)
        MedRecordsIcon.SizeMode = PictureBoxSizeMode.Zoom
        MedRecordsIcon.TabIndex = 9
        MedRecordsIcon.TabStop = False
        ' 
        ' BillsIcon
        ' 
        BillsIcon.BackColor = Color.Transparent
        BillsIcon.Image = My.Resources.Resources.invoice
        BillsIcon.Location = New Point(46, 491)
        BillsIcon.Margin = New Padding(3, 2, 3, 2)
        BillsIcon.Name = "BillsIcon"
        BillsIcon.Size = New Size(45, 49)
        BillsIcon.SizeMode = PictureBoxSizeMode.Zoom
        BillsIcon.TabIndex = 8
        BillsIcon.TabStop = False
        ' 
        ' LogOutIcon
        ' 
        LogOutIcon.Anchor = AnchorStyles.Bottom
        LogOutIcon.BackColor = Color.Transparent
        LogOutIcon.Image = My.Resources.Resources._exit
        LogOutIcon.Location = New Point(46, 692)
        LogOutIcon.Margin = New Padding(3, 2, 3, 2)
        LogOutIcon.Name = "LogOutIcon"
        LogOutIcon.Size = New Size(45, 45)
        LogOutIcon.SizeMode = PictureBoxSizeMode.Zoom
        LogOutIcon.TabIndex = 7
        LogOutIcon.TabStop = False
        ' 
        ' CostumerSupportPanel
        ' 
        CostumerSupportPanel.Anchor = AnchorStyles.Bottom
        CostumerSupportPanel.BackColor = Color.White
        CostumerSupportPanel.Controls.Add(CostumerSuportLabel3)
        CostumerSupportPanel.Controls.Add(CostumerSuportLabel2)
        CostumerSupportPanel.Controls.Add(CostumerSuportLabel1)
        CostumerSupportPanel.Location = New Point(61, 751)
        CostumerSupportPanel.Margin = New Padding(3, 2, 3, 2)
        CostumerSupportPanel.Name = "CostumerSupportPanel"
        CostumerSupportPanel.Size = New Size(324, 135)
        CostumerSupportPanel.TabIndex = 3
        ' 
        ' CostumerSuportLabel3
        ' 
        CostumerSuportLabel3.AutoSize = True
        CostumerSuportLabel3.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CostumerSuportLabel3.Location = New Point(42, 83)
        CostumerSuportLabel3.Name = "CostumerSuportLabel3"
        CostumerSuportLabel3.Size = New Size(258, 34)
        CostumerSuportLabel3.TabIndex = 2
        CostumerSuportLabel3.Text = "0962-072-8201"
        ' 
        ' CostumerSuportLabel2
        ' 
        CostumerSuportLabel2.AutoSize = True
        CostumerSuportLabel2.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        CostumerSuportLabel2.Location = New Point(44, 49)
        CostumerSuportLabel2.Name = "CostumerSuportLabel2"
        CostumerSuportLabel2.Size = New Size(247, 34)
        CostumerSuportLabel2.TabIndex = 1
        CostumerSuportLabel2.Text = "Contact Support"
        ' 
        ' CostumerSuportLabel1
        ' 
        CostumerSuportLabel1.AutoSize = True
        CostumerSuportLabel1.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        CostumerSuportLabel1.Location = New Point(74, 15)
        CostumerSuportLabel1.Name = "CostumerSuportLabel1"
        CostumerSuportLabel1.Size = New Size(180, 34)
        CostumerSuportLabel1.TabIndex = 0
        CostumerSuportLabel1.Text = "Need Help?"
        ' 
        ' LOGO
        ' 
        LOGO.BackColor = Color.White
        LOGO.Location = New Point(129, 24)
        LOGO.Margin = New Padding(3, 2, 3, 2)
        LOGO.Name = "LOGO"
        LOGO.Size = New Size(159, 153)
        LOGO.TabIndex = 6
        LOGO.TabStop = False
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.Anchor = AnchorStyles.Bottom
        LogOutBtn.FlatAppearance.BorderSize = 0
        LogOutBtn.FlatStyle = FlatStyle.Flat
        LogOutBtn.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold)
        LogOutBtn.Location = New Point(89, 692)
        LogOutBtn.Margin = New Padding(3, 2, 3, 2)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(285, 45)
        LogOutBtn.TabIndex = 5
        LogOutBtn.Text = "LOG OUT"
        LogOutBtn.TextAlign = ContentAlignment.MiddleLeft
        LogOutBtn.UseVisualStyleBackColor = True
        ' 
        ' BillsBtn
        ' 
        BillsBtn.BackColor = Color.Transparent
        BillsBtn.FlatAppearance.BorderSize = 0
        BillsBtn.FlatStyle = FlatStyle.Flat
        BillsBtn.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold)
        BillsBtn.Location = New Point(89, 491)
        BillsBtn.Margin = New Padding(3, 2, 3, 2)
        BillsBtn.Name = "BillsBtn"
        BillsBtn.Size = New Size(296, 49)
        BillsBtn.TabIndex = 4
        BillsBtn.Text = "BILLS"
        BillsBtn.TextAlign = ContentAlignment.MiddleLeft
        BillsBtn.UseVisualStyleBackColor = False
        ' 
        ' MedRecordsBtn
        ' 
        MedRecordsBtn.BackColor = Color.Transparent
        MedRecordsBtn.FlatAppearance.BorderSize = 0
        MedRecordsBtn.FlatStyle = FlatStyle.Flat
        MedRecordsBtn.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold)
        MedRecordsBtn.Location = New Point(89, 442)
        MedRecordsBtn.Margin = New Padding(3, 2, 3, 2)
        MedRecordsBtn.Name = "MedRecordsBtn"
        MedRecordsBtn.Size = New Size(296, 49)
        MedRecordsBtn.TabIndex = 3
        MedRecordsBtn.Text = "MED RECORDS"
        MedRecordsBtn.TextAlign = ContentAlignment.MiddleLeft
        MedRecordsBtn.UseVisualStyleBackColor = False
        ' 
        ' AppointmentBtn
        ' 
        AppointmentBtn.BackColor = Color.Transparent
        AppointmentBtn.FlatAppearance.BorderSize = 0
        AppointmentBtn.FlatStyle = FlatStyle.Flat
        AppointmentBtn.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold)
        AppointmentBtn.Location = New Point(89, 393)
        AppointmentBtn.Margin = New Padding(3, 2, 3, 2)
        AppointmentBtn.Name = "AppointmentBtn"
        AppointmentBtn.Size = New Size(296, 49)
        AppointmentBtn.TabIndex = 2
        AppointmentBtn.Text = "APPOINTMENT"
        AppointmentBtn.TextAlign = ContentAlignment.MiddleLeft
        AppointmentBtn.UseVisualStyleBackColor = False
        ' 
        ' PeopelBtn
        ' 
        PeopelBtn.BackColor = Color.Transparent
        PeopelBtn.FlatAppearance.BorderSize = 0
        PeopelBtn.FlatStyle = FlatStyle.Flat
        PeopelBtn.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold)
        PeopelBtn.Location = New Point(89, 344)
        PeopelBtn.Margin = New Padding(3, 2, 3, 2)
        PeopelBtn.Name = "PeopelBtn"
        PeopelBtn.Size = New Size(296, 49)
        PeopelBtn.TabIndex = 1
        PeopelBtn.Text = "PEOPLE"
        PeopelBtn.TextAlign = ContentAlignment.MiddleLeft
        PeopelBtn.UseVisualStyleBackColor = False
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.BackColor = Color.Transparent
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashboardBtn.Location = New Point(85, 295)
        DashboardBtn.Margin = New Padding(3, 2, 3, 2)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Size = New Size(300, 49)
        DashboardBtn.TabIndex = 0
        DashboardBtn.Text = "DASHBOARD"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.FromArgb(CByte(167), CByte(239), CByte(241))
        TopPanel.Controls.Add(TopPanelHorizontalLine)
        TopPanel.Controls.Add(verticalLine)
        TopPanel.Controls.Add(NotifIcon)
        TopPanel.Controls.Add(MessageIcon)
        TopPanel.Controls.Add(MainFormPatientDashboardLabel)
        TopPanel.Controls.Add(ProfileLabel)
        TopPanel.Controls.Add(ProfilePictureIcon)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(459, 0)
        TopPanel.Margin = New Padding(3, 2, 3, 2)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1286, 138)
        TopPanel.TabIndex = 1
        ' 
        ' verticalLine
        ' 
        verticalLine.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        verticalLine.BackColor = Color.Black
        verticalLine.BorderStyle = BorderStyle.FixedSingle
        verticalLine.Location = New Point(884, -2)
        verticalLine.MinimumSize = New Size(2, 2)
        verticalLine.Name = "verticalLine"
        verticalLine.Size = New Size(2, 140)
        verticalLine.TabIndex = 2
        ' 
        ' NotifIcon
        ' 
        NotifIcon.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        NotifIcon.BackColor = Color.Transparent
        NotifIcon.Image = My.Resources.Resources.notification
        NotifIcon.Location = New Point(675, 40)
        NotifIcon.Margin = New Padding(3, 2, 3, 2)
        NotifIcon.Name = "NotifIcon"
        NotifIcon.Size = New Size(45, 45)
        NotifIcon.SizeMode = PictureBoxSizeMode.Zoom
        NotifIcon.TabIndex = 4
        NotifIcon.TabStop = False
        ' 
        ' MessageIcon
        ' 
        MessageIcon.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MessageIcon.BackColor = Color.Transparent
        MessageIcon.Image = My.Resources.Resources.chatting
        MessageIcon.Location = New Point(778, 41)
        MessageIcon.Margin = New Padding(3, 2, 3, 2)
        MessageIcon.Name = "MessageIcon"
        MessageIcon.Size = New Size(45, 45)
        MessageIcon.SizeMode = PictureBoxSizeMode.Zoom
        MessageIcon.TabIndex = 3
        MessageIcon.TabStop = False
        ' 
        ' MainFormPatientDashboardLabel
        ' 
        MainFormPatientDashboardLabel.AutoSize = True
        MainFormPatientDashboardLabel.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainFormPatientDashboardLabel.Location = New Point(131, 40)
        MainFormPatientDashboardLabel.Name = "MainFormPatientDashboardLabel"
        MainFormPatientDashboardLabel.Size = New Size(355, 44)
        MainFormPatientDashboardLabel.TabIndex = 2
        MainFormPatientDashboardLabel.Text = "Patient Dashboard"
        ' 
        ' ProfileLabel
        ' 
        ProfileLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProfileLabel.AutoSize = True
        ProfileLabel.BackColor = Color.Transparent
        ProfileLabel.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfileLabel.Location = New Point(997, 40)
        ProfileLabel.Name = "ProfileLabel"
        ProfileLabel.Size = New Size(253, 44)
        ProfileLabel.TabIndex = 1
        ProfileLabel.Text = "Profile Name"
        ' 
        ' ProfilePictureIcon
        ' 
        ProfilePictureIcon.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProfilePictureIcon.BackColor = Color.White
        ProfilePictureIcon.Location = New Point(914, 41)
        ProfilePictureIcon.Margin = New Padding(3, 2, 3, 2)
        ProfilePictureIcon.Name = "ProfilePictureIcon"
        ProfilePictureIcon.Size = New Size(45, 45)
        ProfilePictureIcon.SizeMode = PictureBoxSizeMode.Zoom
        ProfilePictureIcon.TabIndex = 0
        ProfilePictureIcon.TabStop = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(459, 138)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1286, 814)
        MainPanel.TabIndex = 2
        ' 
        ' LeftSideBarVerticalLine
        ' 
        LeftSideBarVerticalLine.BackColor = Color.Black
        LeftSideBarVerticalLine.BorderStyle = BorderStyle.FixedSingle
        LeftSideBarVerticalLine.Dock = DockStyle.Right
        LeftSideBarVerticalLine.Location = New Point(457, 0)
        LeftSideBarVerticalLine.MinimumSize = New Size(2, 2)
        LeftSideBarVerticalLine.Name = "LeftSideBarVerticalLine"
        LeftSideBarVerticalLine.Size = New Size(2, 952)
        LeftSideBarVerticalLine.TabIndex = 3
        ' 
        ' TopPanelHorizontalLine
        ' 
        TopPanelHorizontalLine.BackColor = Color.Black
        TopPanelHorizontalLine.BorderStyle = BorderStyle.FixedSingle
        TopPanelHorizontalLine.Dock = DockStyle.Bottom
        TopPanelHorizontalLine.Location = New Point(0, 136)
        TopPanelHorizontalLine.MinimumSize = New Size(2, 2)
        TopPanelHorizontalLine.Name = "TopPanelHorizontalLine"
        TopPanelHorizontalLine.Size = New Size(1286, 2)
        TopPanelHorizontalLine.TabIndex = 5
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1745, 952)
        Controls.Add(MainPanel)
        Controls.Add(TopPanel)
        Controls.Add(LeftSideBar)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "MainForm"
        LeftSideBar.ResumeLayout(False)
        CType(DashboardIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PeopleIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(AppointmentIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(MedRecordsIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(BillsIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(LogOutIcon, ComponentModel.ISupportInitialize).EndInit()
        CostumerSupportPanel.ResumeLayout(False)
        CostumerSupportPanel.PerformLayout()
        CType(LOGO, ComponentModel.ISupportInitialize).EndInit()
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(NotifIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(MessageIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfilePictureIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LeftSideBar As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents BillsBtn As Button
    Friend WithEvents MedRecordsBtn As Button
    Friend WithEvents AppointmentBtn As Button
    Friend WithEvents PeopelBtn As Button
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents MainFormPatientDashboardLabel As Label
    Friend WithEvents ProfileLabel As Label
    Friend WithEvents ProfilePictureIcon As PictureBox
    Friend WithEvents CostumerSupportPanel As Panel
    Friend WithEvents CostumerSuportLabel2 As Label
    Friend WithEvents CostumerSuportLabel1 As Label
    Friend WithEvents AppointmentIcon As PictureBox
    Friend WithEvents MedRecordsIcon As PictureBox
    Friend WithEvents BillsIcon As PictureBox
    Friend WithEvents LogOutIcon As PictureBox
    Friend WithEvents DashboardIcon As PictureBox
    Friend WithEvents PeopleIcon As PictureBox
    Friend WithEvents NotifIcon As PictureBox
    Friend WithEvents MessageIcon As PictureBox
    Friend WithEvents CostumerSuportLabel3 As Label
    Friend WithEvents verticalLine As Label
    Friend WithEvents HorizontalLine As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents LeftSideBarVerticalLine As Label
    Friend WithEvents TopPanelHorizontalLine As Label
End Class
