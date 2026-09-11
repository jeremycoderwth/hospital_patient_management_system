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
        Panel2 = New Panel()
        HorizontalLine = New Label()
        LOGO = New PictureBox()
        LeftSideBarVerticalLine = New Label()
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
        LogOutBtn = New Button()
        BillsBtn = New Button()
        MedRecordsBtn = New Button()
        AppointmentBtn = New Button()
        PeopelBtn = New Button()
        DashboardBtn = New Button()
        TopPanel = New Panel()
        MessageBtn = New Button()
        NotifBtn = New Button()
        Panel1 = New Panel()
        verticalLine = New Label()
        ProfileLabel = New Label()
        ProfilePictureIcon = New PictureBox()
        TopPanelHorizontalLine = New Label()
        MainFormPatientDashboardLabel = New Label()
        MainPanel = New Panel()
        LeftSideBar.SuspendLayout()
        Panel2.SuspendLayout()
        CType(LOGO, ComponentModel.ISupportInitialize).BeginInit()
        CType(DashboardIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PeopleIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(AppointmentIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(MedRecordsIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(BillsIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(LogOutIcon, ComponentModel.ISupportInitialize).BeginInit()
        CostumerSupportPanel.SuspendLayout()
        TopPanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(ProfilePictureIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LeftSideBar
        ' 
        LeftSideBar.BackColor = Color.FromArgb(CByte(167), CByte(239), CByte(241))
        LeftSideBar.Controls.Add(Panel2)
        LeftSideBar.Controls.Add(LeftSideBarVerticalLine)
        LeftSideBar.Controls.Add(DashboardIcon)
        LeftSideBar.Controls.Add(PeopleIcon)
        LeftSideBar.Controls.Add(AppointmentIcon)
        LeftSideBar.Controls.Add(MedRecordsIcon)
        LeftSideBar.Controls.Add(BillsIcon)
        LeftSideBar.Controls.Add(LogOutIcon)
        LeftSideBar.Controls.Add(CostumerSupportPanel)
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
        LeftSideBar.Size = New Size(424, 1050)
        LeftSideBar.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(HorizontalLine)
        Panel2.Controls.Add(LOGO)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(422, 204)
        Panel2.TabIndex = 13
        ' 
        ' HorizontalLine
        ' 
        HorizontalLine.BackColor = Color.Black
        HorizontalLine.BorderStyle = BorderStyle.FixedSingle
        HorizontalLine.Dock = DockStyle.Bottom
        HorizontalLine.Location = New Point(0, 202)
        HorizontalLine.MinimumSize = New Size(2, 2)
        HorizontalLine.Name = "HorizontalLine"
        HorizontalLine.Size = New Size(422, 2)
        HorizontalLine.TabIndex = 7
        ' 
        ' LOGO
        ' 
        LOGO.BackColor = Color.White
        LOGO.Location = New Point(124, 20)
        LOGO.Margin = New Padding(3, 2, 3, 2)
        LOGO.Name = "LOGO"
        LOGO.Size = New Size(159, 153)
        LOGO.TabIndex = 6
        LOGO.TabStop = False
        ' 
        ' LeftSideBarVerticalLine
        ' 
        LeftSideBarVerticalLine.BackColor = Color.Black
        LeftSideBarVerticalLine.BorderStyle = BorderStyle.FixedSingle
        LeftSideBarVerticalLine.Dock = DockStyle.Right
        LeftSideBarVerticalLine.Location = New Point(422, 0)
        LeftSideBarVerticalLine.MinimumSize = New Size(2, 2)
        LeftSideBarVerticalLine.Name = "LeftSideBarVerticalLine"
        LeftSideBarVerticalLine.Size = New Size(2, 1050)
        LeftSideBarVerticalLine.TabIndex = 3
        ' 
        ' DashboardIcon
        ' 
        DashboardIcon.BackColor = Color.Transparent
        DashboardIcon.Image = My.Resources.Resources.minimalist
        DashboardIcon.Location = New Point(31, 294)
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
        PeopleIcon.Location = New Point(31, 343)
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
        AppointmentIcon.Location = New Point(31, 392)
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
        MedRecordsIcon.Location = New Point(31, 441)
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
        BillsIcon.Location = New Point(31, 490)
        BillsIcon.Margin = New Padding(3, 2, 3, 2)
        BillsIcon.Name = "BillsIcon"
        BillsIcon.Size = New Size(45, 49)
        BillsIcon.SizeMode = PictureBoxSizeMode.Zoom
        BillsIcon.TabIndex = 8
        BillsIcon.TabStop = False
        ' 
        ' LogOutIcon
        ' 
        LogOutIcon.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LogOutIcon.BackColor = Color.Transparent
        LogOutIcon.Image = My.Resources.Resources._exit
        LogOutIcon.Location = New Point(37, 692)
        LogOutIcon.Margin = New Padding(3, 2, 3, 2)
        LogOutIcon.Name = "LogOutIcon"
        LogOutIcon.Size = New Size(45, 45)
        LogOutIcon.SizeMode = PictureBoxSizeMode.Zoom
        LogOutIcon.TabIndex = 7
        LogOutIcon.TabStop = False
        ' 
        ' CostumerSupportPanel
        ' 
        CostumerSupportPanel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        CostumerSupportPanel.BackColor = Color.White
        CostumerSupportPanel.Controls.Add(CostumerSuportLabel3)
        CostumerSupportPanel.Controls.Add(CostumerSuportLabel2)
        CostumerSupportPanel.Controls.Add(CostumerSuportLabel1)
        CostumerSupportPanel.Location = New Point(37, 785)
        CostumerSupportPanel.Margin = New Padding(3, 2, 3, 2)
        CostumerSupportPanel.Name = "CostumerSupportPanel"
        CostumerSupportPanel.Size = New Size(341, 135)
        CostumerSupportPanel.TabIndex = 3
        ' 
        ' CostumerSuportLabel3
        ' 
        CostumerSuportLabel3.AutoSize = True
        CostumerSuportLabel3.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CostumerSuportLabel3.Location = New Point(37, 83)
        CostumerSuportLabel3.Name = "CostumerSuportLabel3"
        CostumerSuportLabel3.Size = New Size(258, 34)
        CostumerSuportLabel3.TabIndex = 2
        CostumerSuportLabel3.Text = "0962-072-8201"
        ' 
        ' CostumerSuportLabel2
        ' 
        CostumerSuportLabel2.AutoSize = True
        CostumerSuportLabel2.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        CostumerSuportLabel2.Location = New Point(33, 49)
        CostumerSuportLabel2.Name = "CostumerSuportLabel2"
        CostumerSuportLabel2.Size = New Size(247, 34)
        CostumerSuportLabel2.TabIndex = 1
        CostumerSuportLabel2.Text = "Contact Support"
        ' 
        ' CostumerSuportLabel1
        ' 
        CostumerSuportLabel1.AutoSize = True
        CostumerSuportLabel1.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        CostumerSuportLabel1.Location = New Point(54, 15)
        CostumerSuportLabel1.Name = "CostumerSuportLabel1"
        CostumerSuportLabel1.Size = New Size(180, 34)
        CostumerSuportLabel1.TabIndex = 0
        CostumerSuportLabel1.Text = "Need Help?"
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LogOutBtn.FlatAppearance.BorderSize = 0
        LogOutBtn.FlatStyle = FlatStyle.Flat
        LogOutBtn.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold)
        LogOutBtn.Location = New Point(80, 692)
        LogOutBtn.Margin = New Padding(3, 2, 3, 2)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(344, 53)
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
        BillsBtn.Location = New Point(74, 490)
        BillsBtn.Margin = New Padding(3, 2, 3, 2)
        BillsBtn.Name = "BillsBtn"
        BillsBtn.Size = New Size(350, 49)
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
        MedRecordsBtn.Location = New Point(74, 441)
        MedRecordsBtn.Margin = New Padding(3, 2, 3, 2)
        MedRecordsBtn.Name = "MedRecordsBtn"
        MedRecordsBtn.Size = New Size(350, 49)
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
        AppointmentBtn.Location = New Point(74, 392)
        AppointmentBtn.Margin = New Padding(3, 2, 3, 2)
        AppointmentBtn.Name = "AppointmentBtn"
        AppointmentBtn.Size = New Size(350, 49)
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
        PeopelBtn.Location = New Point(74, 343)
        PeopelBtn.Margin = New Padding(3, 2, 3, 2)
        PeopelBtn.Name = "PeopelBtn"
        PeopelBtn.Size = New Size(350, 49)
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
        DashboardBtn.Location = New Point(70, 294)
        DashboardBtn.Margin = New Padding(3, 2, 3, 2)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Size = New Size(352, 49)
        DashboardBtn.TabIndex = 0
        DashboardBtn.Text = "DASHBOARD"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.FromArgb(CByte(167), CByte(239), CByte(241))
        TopPanel.Controls.Add(MessageBtn)
        TopPanel.Controls.Add(NotifBtn)
        TopPanel.Controls.Add(Panel1)
        TopPanel.Controls.Add(TopPanelHorizontalLine)
        TopPanel.Controls.Add(MainFormPatientDashboardLabel)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(424, 0)
        TopPanel.Margin = New Padding(3, 2, 3, 2)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(1352, 138)
        TopPanel.TabIndex = 1
        ' 
        ' MessageBtn
        ' 
        MessageBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MessageBtn.BackColor = Color.Transparent
        MessageBtn.BackgroundImage = My.Resources.Resources.chatting
        MessageBtn.BackgroundImageLayout = ImageLayout.Zoom
        MessageBtn.FlatAppearance.BorderSize = 0
        MessageBtn.FlatStyle = FlatStyle.Flat
        MessageBtn.Location = New Point(837, 36)
        MessageBtn.Name = "MessageBtn"
        MessageBtn.Size = New Size(50, 50)
        MessageBtn.TabIndex = 8
        MessageBtn.UseVisualStyleBackColor = False
        ' 
        ' NotifBtn
        ' 
        NotifBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        NotifBtn.BackColor = Color.Transparent
        NotifBtn.BackgroundImage = My.Resources.Resources.notification
        NotifBtn.BackgroundImageLayout = ImageLayout.Zoom
        NotifBtn.FlatAppearance.BorderSize = 0
        NotifBtn.FlatStyle = FlatStyle.Flat
        NotifBtn.Location = New Point(744, 36)
        NotifBtn.Name = "NotifBtn"
        NotifBtn.Size = New Size(50, 50)
        NotifBtn.TabIndex = 7
        NotifBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.Controls.Add(verticalLine)
        Panel1.Controls.Add(ProfileLabel)
        Panel1.Controls.Add(ProfilePictureIcon)
        Panel1.Location = New Point(951, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(401, 136)
        Panel1.TabIndex = 6
        ' 
        ' verticalLine
        ' 
        verticalLine.BackColor = Color.Black
        verticalLine.BorderStyle = BorderStyle.FixedSingle
        verticalLine.Dock = DockStyle.Left
        verticalLine.Location = New Point(0, 0)
        verticalLine.MinimumSize = New Size(2, 2)
        verticalLine.Name = "verticalLine"
        verticalLine.Size = New Size(2, 136)
        verticalLine.TabIndex = 3
        ' 
        ' ProfileLabel
        ' 
        ProfileLabel.AutoSize = True
        ProfileLabel.BackColor = Color.Transparent
        ProfileLabel.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfileLabel.Location = New Point(106, 36)
        ProfileLabel.Name = "ProfileLabel"
        ProfileLabel.Size = New Size(253, 44)
        ProfileLabel.TabIndex = 1
        ProfileLabel.Text = "Profile Name"
        ' 
        ' ProfilePictureIcon
        ' 
        ProfilePictureIcon.BackColor = Color.White
        ProfilePictureIcon.Location = New Point(23, 37)
        ProfilePictureIcon.Margin = New Padding(3, 2, 3, 2)
        ProfilePictureIcon.Name = "ProfilePictureIcon"
        ProfilePictureIcon.Size = New Size(50, 50)
        ProfilePictureIcon.SizeMode = PictureBoxSizeMode.Zoom
        ProfilePictureIcon.TabIndex = 0
        ProfilePictureIcon.TabStop = False
        ' 
        ' TopPanelHorizontalLine
        ' 
        TopPanelHorizontalLine.BackColor = Color.Black
        TopPanelHorizontalLine.BorderStyle = BorderStyle.FixedSingle
        TopPanelHorizontalLine.Dock = DockStyle.Bottom
        TopPanelHorizontalLine.Location = New Point(0, 136)
        TopPanelHorizontalLine.MinimumSize = New Size(2, 2)
        TopPanelHorizontalLine.Name = "TopPanelHorizontalLine"
        TopPanelHorizontalLine.Size = New Size(1352, 2)
        TopPanelHorizontalLine.TabIndex = 5
        ' 
        ' MainFormPatientDashboardLabel
        ' 
        MainFormPatientDashboardLabel.AutoSize = True
        MainFormPatientDashboardLabel.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainFormPatientDashboardLabel.Location = New Point(131, 36)
        MainFormPatientDashboardLabel.Name = "MainFormPatientDashboardLabel"
        MainFormPatientDashboardLabel.Size = New Size(355, 44)
        MainFormPatientDashboardLabel.TabIndex = 2
        MainFormPatientDashboardLabel.Text = "Patient Dashboard"
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(424, 138)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1352, 912)
        MainPanel.TabIndex = 2
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1776, 1050)
        Controls.Add(MainPanel)
        Controls.Add(TopPanel)
        Controls.Add(LeftSideBar)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1280, 720)
        Name = "MainForm"
        WindowState = FormWindowState.Maximized
        LeftSideBar.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(LOGO, ComponentModel.ISupportInitialize).EndInit()
        CType(DashboardIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PeopleIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(AppointmentIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(MedRecordsIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(BillsIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(LogOutIcon, ComponentModel.ISupportInitialize).EndInit()
        CostumerSupportPanel.ResumeLayout(False)
        CostumerSupportPanel.PerformLayout()
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents CostumerSuportLabel3 As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents LeftSideBarVerticalLine As Label
    Friend WithEvents TopPanelHorizontalLine As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents verticalLine As Label
    Friend WithEvents HorizontalLine As Label
    Friend WithEvents NotifBtn As Button
    Friend WithEvents MessageBtn As Button
End Class
