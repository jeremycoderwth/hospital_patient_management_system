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
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        LOGO = New PictureBox()
        LogOutBtn = New Button()
        BillsBtn = New Button()
        MedRecordsBtn = New Button()
        AppointmentBtn = New Button()
        PeopelBtn = New Button()
        DashboardBtn = New Button()
        TopPanel = New Panel()
        Label1 = New Label()
        ProfileLabel = New Label()
        ProfilePicture = New PictureBox()
        MainPanel = New Panel()
        AppointmentPanel = New Panel()
        ViewAppointmentBtn = New Button()
        UpcomingAppointmentLabel = New Label()
        BillOVPanel1 = New Panel()
        PayBtn = New Button()
        BillOVLabel = New Label()
        HealthSummaryPanel = New Panel()
        HealthSummaryLabel = New Label()
        WelcomePanel = New Panel()
        GreetingsLabel = New Label()
        LeftSideBar.SuspendLayout()
        Panel1.SuspendLayout()
        CType(LOGO, ComponentModel.ISupportInitialize).BeginInit()
        TopPanel.SuspendLayout()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        MainPanel.SuspendLayout()
        AppointmentPanel.SuspendLayout()
        BillOVPanel1.SuspendLayout()
        HealthSummaryPanel.SuspendLayout()
        WelcomePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' LeftSideBar
        ' 
        LeftSideBar.BackColor = Color.LightSkyBlue
        LeftSideBar.Controls.Add(Panel1)
        LeftSideBar.Controls.Add(LOGO)
        LeftSideBar.Controls.Add(LogOutBtn)
        LeftSideBar.Controls.Add(BillsBtn)
        LeftSideBar.Controls.Add(MedRecordsBtn)
        LeftSideBar.Controls.Add(AppointmentBtn)
        LeftSideBar.Controls.Add(PeopelBtn)
        LeftSideBar.Controls.Add(DashboardBtn)
        LeftSideBar.Dock = DockStyle.Left
        LeftSideBar.Location = New Point(0, 0)
        LeftSideBar.Margin = New Padding(2)
        LeftSideBar.Name = "LeftSideBar"
        LeftSideBar.Size = New Size(132, 410)
        LeftSideBar.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(2, 324)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(125, 76)
        Panel1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 26)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 19)
        Label3.TabIndex = 1
        Label3.Text = "Contact Support"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 9)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 19)
        Label2.TabIndex = 0
        Label2.Text = "Need Help?"
        ' 
        ' LOGO
        ' 
        LOGO.BackColor = Color.White
        LOGO.Location = New Point(22, 18)
        LOGO.Margin = New Padding(2)
        LOGO.Name = "LOGO"
        LOGO.Size = New Size(89, 78)
        LOGO.TabIndex = 6
        LOGO.TabStop = False
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.Location = New Point(11, 296)
        LogOutBtn.Margin = New Padding(2)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(92, 25)
        LogOutBtn.TabIndex = 5
        LogOutBtn.Text = "LOG OUT"
        LogOutBtn.UseVisualStyleBackColor = True
        ' 
        ' BillsBtn
        ' 
        BillsBtn.Location = New Point(11, 209)
        BillsBtn.Margin = New Padding(2)
        BillsBtn.Name = "BillsBtn"
        BillsBtn.Size = New Size(99, 25)
        BillsBtn.TabIndex = 4
        BillsBtn.Text = "BILLS"
        BillsBtn.UseVisualStyleBackColor = True
        ' 
        ' MedRecordsBtn
        ' 
        MedRecordsBtn.Location = New Point(11, 187)
        MedRecordsBtn.Margin = New Padding(2)
        MedRecordsBtn.Name = "MedRecordsBtn"
        MedRecordsBtn.Size = New Size(99, 25)
        MedRecordsBtn.TabIndex = 3
        MedRecordsBtn.Text = "MED RECORDS"
        MedRecordsBtn.UseVisualStyleBackColor = True
        ' 
        ' AppointmentBtn
        ' 
        AppointmentBtn.Location = New Point(11, 165)
        AppointmentBtn.Margin = New Padding(2)
        AppointmentBtn.Name = "AppointmentBtn"
        AppointmentBtn.Size = New Size(99, 25)
        AppointmentBtn.TabIndex = 2
        AppointmentBtn.Text = "APPOINTMENT"
        AppointmentBtn.UseVisualStyleBackColor = True
        ' 
        ' PeopelBtn
        ' 
        PeopelBtn.Location = New Point(11, 142)
        PeopelBtn.Margin = New Padding(2)
        PeopelBtn.Name = "PeopelBtn"
        PeopelBtn.Size = New Size(99, 25)
        PeopelBtn.TabIndex = 1
        PeopelBtn.Text = "PEOPLE"
        PeopelBtn.UseVisualStyleBackColor = True
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.Location = New Point(11, 119)
        DashboardBtn.Margin = New Padding(2)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Size = New Size(99, 25)
        DashboardBtn.TabIndex = 0
        DashboardBtn.Text = "DASHBOARD"
        DashboardBtn.UseVisualStyleBackColor = True
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.LightSkyBlue
        TopPanel.Controls.Add(Label1)
        TopPanel.Controls.Add(ProfileLabel)
        TopPanel.Controls.Add(ProfilePicture)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(132, 0)
        TopPanel.Margin = New Padding(2)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(715, 64)
        TopPanel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(59, 18)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 21)
        Label1.TabIndex = 2
        Label1.Text = "Patient Dashboard"
        ' 
        ' ProfileLabel
        ' 
        ProfileLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProfileLabel.AutoSize = True
        ProfileLabel.BackColor = Color.Transparent
        ProfileLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ProfileLabel.Location = New Point(479, 18)
        ProfileLabel.Margin = New Padding(2, 0, 2, 0)
        ProfileLabel.Name = "ProfileLabel"
        ProfileLabel.Size = New Size(105, 21)
        ProfileLabel.TabIndex = 1
        ProfileLabel.Text = "Profile Name"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProfilePicture.BackColor = Color.White
        ProfilePicture.Location = New Point(428, 13)
        ProfilePicture.Margin = New Padding(2)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(46, 32)
        ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        ProfilePicture.TabIndex = 0
        ProfilePicture.TabStop = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = SystemColors.ControlDark
        MainPanel.Controls.Add(AppointmentPanel)
        MainPanel.Controls.Add(BillOVPanel1)
        MainPanel.Controls.Add(HealthSummaryPanel)
        MainPanel.Controls.Add(WelcomePanel)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(132, 64)
        MainPanel.Margin = New Padding(2)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(715, 346)
        MainPanel.TabIndex = 2
        ' 
        ' AppointmentPanel
        ' 
        AppointmentPanel.BackColor = Color.White
        AppointmentPanel.Controls.Add(ViewAppointmentBtn)
        AppointmentPanel.Controls.Add(UpcomingAppointmentLabel)
        AppointmentPanel.Location = New Point(332, 4)
        AppointmentPanel.Margin = New Padding(2)
        AppointmentPanel.Name = "AppointmentPanel"
        AppointmentPanel.Size = New Size(377, 200)
        AppointmentPanel.TabIndex = 4
        ' 
        ' ViewAppointmentBtn
        ' 
        ViewAppointmentBtn.Location = New Point(27, 146)
        ViewAppointmentBtn.Margin = New Padding(2)
        ViewAppointmentBtn.Name = "ViewAppointmentBtn"
        ViewAppointmentBtn.Size = New Size(127, 20)
        ViewAppointmentBtn.TabIndex = 3
        ViewAppointmentBtn.Text = "View Appointment"
        ViewAppointmentBtn.UseVisualStyleBackColor = True
        ' 
        ' UpcomingAppointmentLabel
        ' 
        UpcomingAppointmentLabel.AutoSize = True
        UpcomingAppointmentLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpcomingAppointmentLabel.Location = New Point(27, 11)
        UpcomingAppointmentLabel.Margin = New Padding(2, 0, 2, 0)
        UpcomingAppointmentLabel.Name = "UpcomingAppointmentLabel"
        UpcomingAppointmentLabel.Size = New Size(188, 21)
        UpcomingAppointmentLabel.TabIndex = 2
        UpcomingAppointmentLabel.Text = "Upcoming Appointment"
        ' 
        ' BillOVPanel1
        ' 
        BillOVPanel1.BackColor = Color.White
        BillOVPanel1.Controls.Add(PayBtn)
        BillOVPanel1.Controls.Add(BillOVLabel)
        BillOVPanel1.Location = New Point(4, 208)
        BillOVPanel1.Margin = New Padding(2)
        BillOVPanel1.Name = "BillOVPanel1"
        BillOVPanel1.Size = New Size(705, 131)
        BillOVPanel1.TabIndex = 2
        ' 
        ' PayBtn
        ' 
        PayBtn.Location = New Point(206, 37)
        PayBtn.Margin = New Padding(2)
        PayBtn.Name = "PayBtn"
        PayBtn.Size = New Size(78, 20)
        PayBtn.TabIndex = 3
        PayBtn.Text = "Pay Now"
        PayBtn.UseVisualStyleBackColor = True
        ' 
        ' BillOVLabel
        ' 
        BillOVLabel.AutoSize = True
        BillOVLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillOVLabel.Location = New Point(12, 11)
        BillOVLabel.Margin = New Padding(2, 0, 2, 0)
        BillOVLabel.Name = "BillOVLabel"
        BillOVLabel.Size = New Size(128, 21)
        BillOVLabel.TabIndex = 2
        BillOVLabel.Text = "Billing Overview"
        ' 
        ' HealthSummaryPanel
        ' 
        HealthSummaryPanel.BackColor = Color.White
        HealthSummaryPanel.Controls.Add(HealthSummaryLabel)
        HealthSummaryPanel.Location = New Point(4, 73)
        HealthSummaryPanel.Margin = New Padding(2)
        HealthSummaryPanel.Name = "HealthSummaryPanel"
        HealthSummaryPanel.Size = New Size(323, 131)
        HealthSummaryPanel.TabIndex = 1
        ' 
        ' HealthSummaryLabel
        ' 
        HealthSummaryLabel.AutoSize = True
        HealthSummaryLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryLabel.Location = New Point(12, 13)
        HealthSummaryLabel.Margin = New Padding(2, 0, 2, 0)
        HealthSummaryLabel.Name = "HealthSummaryLabel"
        HealthSummaryLabel.Size = New Size(131, 21)
        HealthSummaryLabel.TabIndex = 1
        HealthSummaryLabel.Text = "Health Summary"
        ' 
        ' WelcomePanel
        ' 
        WelcomePanel.BackColor = Color.White
        WelcomePanel.Controls.Add(GreetingsLabel)
        WelcomePanel.Location = New Point(4, 4)
        WelcomePanel.Margin = New Padding(2)
        WelcomePanel.Name = "WelcomePanel"
        WelcomePanel.Size = New Size(323, 65)
        WelcomePanel.TabIndex = 0
        ' 
        ' GreetingsLabel
        ' 
        GreetingsLabel.AutoSize = True
        GreetingsLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GreetingsLabel.Location = New Point(12, 11)
        GreetingsLabel.Margin = New Padding(2, 0, 2, 0)
        GreetingsLabel.Name = "GreetingsLabel"
        GreetingsLabel.Size = New Size(108, 19)
        GreetingsLabel.TabIndex = 0
        GreetingsLabel.Text = "Welcome Back"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 410)
        Controls.Add(MainPanel)
        Controls.Add(TopPanel)
        Controls.Add(LeftSideBar)
        Margin = New Padding(2)
        Name = "MainForm"
        LeftSideBar.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(LOGO, ComponentModel.ISupportInitialize).EndInit()
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        MainPanel.ResumeLayout(False)
        AppointmentPanel.ResumeLayout(False)
        AppointmentPanel.PerformLayout()
        BillOVPanel1.ResumeLayout(False)
        BillOVPanel1.PerformLayout()
        HealthSummaryPanel.ResumeLayout(False)
        HealthSummaryPanel.PerformLayout()
        WelcomePanel.ResumeLayout(False)
        WelcomePanel.PerformLayout()
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
    Friend WithEvents MainPanel As Panel
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProfileLabel As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents BillOVPanel1 As Panel
    Friend WithEvents HealthSummaryPanel As Panel
    Friend WithEvents WelcomePanel As Panel
    Friend WithEvents AppointmentPanel As Panel
    Friend WithEvents HealthSummaryLabel As Label
    Friend WithEvents GreetingsLabel As Label
    Friend WithEvents UpcomingAppointmentLabel As Label
    Friend WithEvents ViewAppointmentBtn As Button
    Friend WithEvents BillOVLabel As Label
    Friend WithEvents PayBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
