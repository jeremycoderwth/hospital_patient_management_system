<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefaultDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        MainPanel = New Panel()
        AppointmentPanel = New Panel()
        UpcomingAppointmentHorizontalLine = New Label()
        DashboardAppointmentIcon = New PictureBox()
        UpcomingAppointmentRoomLabel = New Label()
        UpcomingAppointmentDoctorLabel = New Label()
        UpcomingAppointmentDateLabel = New Label()
        ViewAppointmentBtn = New Button()
        UpcomingAppointmentLabel = New Label()
        BillOVPanel1 = New Panel()
        BillingOVUserAmountLabel = New Label()
        BillingOVAmountLabel = New Label()
        BillingAndPaymentLinkLabel = New LinkLabel()
        BillingOVUserLastPaymentDateLabel = New Label()
        BillingOVLastPaymentLabel = New Label()
        BillingOverviewHorizontalLine3 = New Label()
        BillingOverviewHorizontalLine2 = New Label()
        BillingOverviewVerticalLine = New Label()
        BillingOverviewHorizontalLine1 = New Label()
        DashboardBillIcon = New PictureBox()
        BillingOVUSerTotalBalanceLabel = New Label()
        BillingOVTotalBalanceLabel = New Label()
        PayBtn = New Button()
        BillOVLabel = New Label()
        HealthSummaryPanel = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        HealthSummaryUserLastCheckUpLabel = New Label()
        HealthSummaryUserAllergiesLabel = New Label()
        HealthSummaryUserBloodtypeLabel = New Label()
        HealthSummaryLastCheckUpLabel = New Label()
        HealthSummaryAllergiesLabel = New Label()
        HealthSummaryBloodtypeLabel = New Label()
        HealthSummaryLabel = New Label()
        WelcomePanel = New Panel()
        DashboardUserNameLavel = New Label()
        GreetingsLabel = New Label()
        HelpProvider1 = New HelpProvider()
        HealthSummaryHorizontalLine = New Label()
        MainPanel.SuspendLayout()
        AppointmentPanel.SuspendLayout()
        CType(DashboardAppointmentIcon, ComponentModel.ISupportInitialize).BeginInit()
        BillOVPanel1.SuspendLayout()
        CType(DashboardBillIcon, ComponentModel.ISupportInitialize).BeginInit()
        HealthSummaryPanel.SuspendLayout()
        WelcomePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        MainPanel.Controls.Add(AppointmentPanel)
        MainPanel.Controls.Add(BillOVPanel1)
        MainPanel.Controls.Add(HealthSummaryPanel)
        MainPanel.Controls.Add(WelcomePanel)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1285, 815)
        MainPanel.TabIndex = 3
        ' 
        ' AppointmentPanel
        ' 
        AppointmentPanel.BackColor = Color.White
        AppointmentPanel.Controls.Add(UpcomingAppointmentHorizontalLine)
        AppointmentPanel.Controls.Add(DashboardAppointmentIcon)
        AppointmentPanel.Controls.Add(UpcomingAppointmentRoomLabel)
        AppointmentPanel.Controls.Add(UpcomingAppointmentDoctorLabel)
        AppointmentPanel.Controls.Add(UpcomingAppointmentDateLabel)
        AppointmentPanel.Controls.Add(ViewAppointmentBtn)
        AppointmentPanel.Controls.Add(UpcomingAppointmentLabel)
        AppointmentPanel.Location = New Point(672, 16)
        AppointmentPanel.Name = "AppointmentPanel"
        AppointmentPanel.Size = New Size(593, 340)
        AppointmentPanel.TabIndex = 4
        ' 
        ' UpcomingAppointmentHorizontalLine
        ' 
        UpcomingAppointmentHorizontalLine.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        UpcomingAppointmentHorizontalLine.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        UpcomingAppointmentHorizontalLine.BorderStyle = BorderStyle.FixedSingle
        UpcomingAppointmentHorizontalLine.Location = New Point(186, 92)
        UpcomingAppointmentHorizontalLine.MinimumSize = New Size(2, 2)
        UpcomingAppointmentHorizontalLine.Name = "UpcomingAppointmentHorizontalLine"
        UpcomingAppointmentHorizontalLine.Size = New Size(246, 2)
        UpcomingAppointmentHorizontalLine.TabIndex = 13
        ' 
        ' DashboardAppointmentIcon
        ' 
        DashboardAppointmentIcon.BackColor = Color.Transparent
        DashboardAppointmentIcon.Image = My.Resources.Resources.calendar
        DashboardAppointmentIcon.Location = New Point(43, 14)
        DashboardAppointmentIcon.Name = "DashboardAppointmentIcon"
        DashboardAppointmentIcon.Size = New Size(45, 45)
        DashboardAppointmentIcon.SizeMode = PictureBoxSizeMode.Zoom
        DashboardAppointmentIcon.TabIndex = 8
        DashboardAppointmentIcon.TabStop = False
        ' 
        ' UpcomingAppointmentRoomLabel
        ' 
        UpcomingAppointmentRoomLabel.AutoSize = True
        UpcomingAppointmentRoomLabel.Font = New Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpcomingAppointmentRoomLabel.Location = New Point(39, 230)
        UpcomingAppointmentRoomLabel.Name = "UpcomingAppointmentRoomLabel"
        UpcomingAppointmentRoomLabel.Size = New Size(174, 32)
        UpcomingAppointmentRoomLabel.TabIndex = 7
        UpcomingAppointmentRoomLabel.Text = "Room 911"
        ' 
        ' UpcomingAppointmentDoctorLabel
        ' 
        UpcomingAppointmentDoctorLabel.AutoSize = True
        UpcomingAppointmentDoctorLabel.Font = New Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpcomingAppointmentDoctorLabel.Location = New Point(39, 179)
        UpcomingAppointmentDoctorLabel.Name = "UpcomingAppointmentDoctorLabel"
        UpcomingAppointmentDoctorLabel.Size = New Size(254, 32)
        UpcomingAppointmentDoctorLabel.TabIndex = 6
        UpcomingAppointmentDoctorLabel.Text = "DR. Obregoon"
        ' 
        ' UpcomingAppointmentDateLabel
        ' 
        UpcomingAppointmentDateLabel.AutoSize = True
        UpcomingAppointmentDateLabel.Font = New Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpcomingAppointmentDateLabel.Location = New Point(39, 128)
        UpcomingAppointmentDateLabel.Name = "UpcomingAppointmentDateLabel"
        UpcomingAppointmentDateLabel.Size = New Size(534, 32)
        UpcomingAppointmentDateLabel.TabIndex = 5
        UpcomingAppointmentDateLabel.Text = "November 17, 2026 * 1:00PM"
        ' 
        ' ViewAppointmentBtn
        ' 
        ViewAppointmentBtn.BackColor = Color.FromArgb(CByte(167), CByte(239), CByte(241))
        ViewAppointmentBtn.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ViewAppointmentBtn.Location = New Point(39, 278)
        ViewAppointmentBtn.Name = "ViewAppointmentBtn"
        ViewAppointmentBtn.Size = New Size(303, 45)
        ViewAppointmentBtn.TabIndex = 3
        ViewAppointmentBtn.Text = "View Appointment"
        ViewAppointmentBtn.UseVisualStyleBackColor = False
        ' 
        ' UpcomingAppointmentLabel
        ' 
        UpcomingAppointmentLabel.AutoSize = True
        UpcomingAppointmentLabel.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpcomingAppointmentLabel.Location = New Point(94, 15)
        UpcomingAppointmentLabel.Name = "UpcomingAppointmentLabel"
        UpcomingAppointmentLabel.Size = New Size(453, 44)
        UpcomingAppointmentLabel.TabIndex = 2
        UpcomingAppointmentLabel.Text = "Upcoming Appointment"
        ' 
        ' BillOVPanel1
        ' 
        BillOVPanel1.BackColor = Color.White
        BillOVPanel1.Controls.Add(BillingOVUserAmountLabel)
        BillOVPanel1.Controls.Add(BillingOVAmountLabel)
        BillOVPanel1.Controls.Add(BillingAndPaymentLinkLabel)
        BillOVPanel1.Controls.Add(BillingOVUserLastPaymentDateLabel)
        BillOVPanel1.Controls.Add(BillingOVLastPaymentLabel)
        BillOVPanel1.Controls.Add(BillingOverviewHorizontalLine3)
        BillOVPanel1.Controls.Add(BillingOverviewHorizontalLine2)
        BillOVPanel1.Controls.Add(BillingOverviewVerticalLine)
        BillOVPanel1.Controls.Add(BillingOverviewHorizontalLine1)
        BillOVPanel1.Controls.Add(DashboardBillIcon)
        BillOVPanel1.Controls.Add(BillingOVUSerTotalBalanceLabel)
        BillOVPanel1.Controls.Add(BillingOVTotalBalanceLabel)
        BillOVPanel1.Controls.Add(PayBtn)
        BillOVPanel1.Controls.Add(BillOVLabel)
        BillOVPanel1.Location = New Point(14, 377)
        BillOVPanel1.Name = "BillOVPanel1"
        BillOVPanel1.Size = New Size(1251, 415)
        BillOVPanel1.TabIndex = 2
        ' 
        ' BillingOVUserAmountLabel
        ' 
        BillingOVUserAmountLabel.AutoSize = True
        BillingOVUserAmountLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVUserAmountLabel.ForeColor = Color.FromArgb(CByte(123), CByte(154), CByte(109))
        BillingOVUserAmountLabel.Location = New Point(362, 296)
        BillingOVUserAmountLabel.Name = "BillingOVUserAmountLabel"
        BillingOVUserAmountLabel.Size = New Size(185, 34)
        BillingOVUserAmountLabel.TabIndex = 20
        BillingOVUserAmountLabel.Text = "P. 1,000.00"
        ' 
        ' BillingOVAmountLabel
        ' 
        BillingOVAmountLabel.AutoSize = True
        BillingOVAmountLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVAmountLabel.Location = New Point(362, 242)
        BillingOVAmountLabel.Name = "BillingOVAmountLabel"
        BillingOVAmountLabel.Size = New Size(127, 34)
        BillingOVAmountLabel.TabIndex = 19
        BillingOVAmountLabel.Text = "Amount"
        ' 
        ' BillingAndPaymentLinkLabel
        ' 
        BillingAndPaymentLinkLabel.AutoSize = True
        BillingAndPaymentLinkLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingAndPaymentLinkLabel.Location = New Point(27, 369)
        BillingAndPaymentLinkLabel.Name = "BillingAndPaymentLinkLabel"
        BillingAndPaymentLinkLabel.Size = New Size(429, 28)
        BillingAndPaymentLinkLabel.TabIndex = 18
        BillingAndPaymentLinkLabel.TabStop = True
        BillingAndPaymentLinkLabel.Text = "VIEW BILLING AND PAYMENTS ->"
        ' 
        ' BillingOVUserLastPaymentDateLabel
        ' 
        BillingOVUserLastPaymentDateLabel.AutoSize = True
        BillingOVUserLastPaymentDateLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVUserLastPaymentDateLabel.Location = New Point(27, 289)
        BillingOVUserLastPaymentDateLabel.Name = "BillingOVUserLastPaymentDateLabel"
        BillingOVUserLastPaymentDateLabel.Size = New Size(216, 34)
        BillingOVUserLastPaymentDateLabel.TabIndex = 16
        BillingOVUserLastPaymentDateLabel.Text = "May 10, 2026"
        ' 
        ' BillingOVLastPaymentLabel
        ' 
        BillingOVLastPaymentLabel.AutoSize = True
        BillingOVLastPaymentLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVLastPaymentLabel.Location = New Point(27, 242)
        BillingOVLastPaymentLabel.Name = "BillingOVLastPaymentLabel"
        BillingOVLastPaymentLabel.Size = New Size(204, 34)
        BillingOVLastPaymentLabel.TabIndex = 15
        BillingOVLastPaymentLabel.Text = "Last Payment"
        ' 
        ' BillingOverviewHorizontalLine3
        ' 
        BillingOverviewHorizontalLine3.Anchor = AnchorStyles.Top
        BillingOverviewHorizontalLine3.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        BillingOverviewHorizontalLine3.BorderStyle = BorderStyle.FixedSingle
        BillingOverviewHorizontalLine3.Location = New Point(17, 352)
        BillingOverviewHorizontalLine3.MinimumSize = New Size(2, 2)
        BillingOverviewHorizontalLine3.Name = "BillingOverviewHorizontalLine3"
        BillingOverviewHorizontalLine3.Size = New Size(606, 2)
        BillingOverviewHorizontalLine3.TabIndex = 14
        ' 
        ' BillingOverviewHorizontalLine2
        ' 
        BillingOverviewHorizontalLine2.Anchor = AnchorStyles.Top
        BillingOverviewHorizontalLine2.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        BillingOverviewHorizontalLine2.BorderStyle = BorderStyle.FixedSingle
        BillingOverviewHorizontalLine2.Location = New Point(17, 215)
        BillingOverviewHorizontalLine2.MinimumSize = New Size(2, 2)
        BillingOverviewHorizontalLine2.Name = "BillingOverviewHorizontalLine2"
        BillingOverviewHorizontalLine2.Size = New Size(606, 2)
        BillingOverviewHorizontalLine2.TabIndex = 13
        ' 
        ' BillingOverviewVerticalLine
        ' 
        BillingOverviewVerticalLine.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        BillingOverviewVerticalLine.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        BillingOverviewVerticalLine.BorderStyle = BorderStyle.FixedSingle
        BillingOverviewVerticalLine.Location = New Point(641, 5)
        BillingOverviewVerticalLine.MinimumSize = New Size(2, 2)
        BillingOverviewVerticalLine.Name = "BillingOverviewVerticalLine"
        BillingOverviewVerticalLine.Size = New Size(2, 410)
        BillingOverviewVerticalLine.TabIndex = 12
        ' 
        ' BillingOverviewHorizontalLine1
        ' 
        BillingOverviewHorizontalLine1.Anchor = AnchorStyles.Top
        BillingOverviewHorizontalLine1.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        BillingOverviewHorizontalLine1.BorderStyle = BorderStyle.FixedSingle
        BillingOverviewHorizontalLine1.Location = New Point(17, 77)
        BillingOverviewHorizontalLine1.MinimumSize = New Size(2, 2)
        BillingOverviewHorizontalLine1.Name = "BillingOverviewHorizontalLine1"
        BillingOverviewHorizontalLine1.Size = New Size(606, 2)
        BillingOverviewHorizontalLine1.TabIndex = 11
        ' 
        ' DashboardBillIcon
        ' 
        DashboardBillIcon.BackColor = Color.Transparent
        DashboardBillIcon.Image = My.Resources.Resources.invoice
        DashboardBillIcon.Location = New Point(27, 14)
        DashboardBillIcon.Name = "DashboardBillIcon"
        DashboardBillIcon.Size = New Size(45, 45)
        DashboardBillIcon.SizeMode = PictureBoxSizeMode.Zoom
        DashboardBillIcon.TabIndex = 10
        DashboardBillIcon.TabStop = False
        ' 
        ' BillingOVUSerTotalBalanceLabel
        ' 
        BillingOVUSerTotalBalanceLabel.AutoSize = True
        BillingOVUSerTotalBalanceLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVUSerTotalBalanceLabel.ForeColor = Color.FromArgb(CByte(123), CByte(154), CByte(109))
        BillingOVUSerTotalBalanceLabel.Location = New Point(27, 151)
        BillingOVUSerTotalBalanceLabel.Name = "BillingOVUSerTotalBalanceLabel"
        BillingOVUSerTotalBalanceLabel.Size = New Size(185, 34)
        BillingOVUSerTotalBalanceLabel.TabIndex = 9
        BillingOVUSerTotalBalanceLabel.Text = "P. 3,700.00"
        ' 
        ' BillingOVTotalBalanceLabel
        ' 
        BillingOVTotalBalanceLabel.AutoSize = True
        BillingOVTotalBalanceLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVTotalBalanceLabel.Location = New Point(27, 97)
        BillingOVTotalBalanceLabel.Name = "BillingOVTotalBalanceLabel"
        BillingOVTotalBalanceLabel.Size = New Size(206, 34)
        BillingOVTotalBalanceLabel.TabIndex = 8
        BillingOVTotalBalanceLabel.Text = "Total Balance"
        ' 
        ' PayBtn
        ' 
        PayBtn.BackColor = Color.FromArgb(CByte(167), CByte(239), CByte(241))
        PayBtn.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        PayBtn.Location = New Point(453, 140)
        PayBtn.Name = "PayBtn"
        PayBtn.Size = New Size(148, 45)
        PayBtn.TabIndex = 3
        PayBtn.Text = "Pay Now"
        PayBtn.UseVisualStyleBackColor = False
        ' 
        ' BillOVLabel
        ' 
        BillOVLabel.AutoSize = True
        BillOVLabel.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold)
        BillOVLabel.Location = New Point(78, 15)
        BillOVLabel.Name = "BillOVLabel"
        BillOVLabel.Size = New Size(310, 44)
        BillOVLabel.TabIndex = 2
        BillOVLabel.Text = "Billing Overview"
        ' 
        ' HealthSummaryPanel
        ' 
        HealthSummaryPanel.BackColor = Color.White
        HealthSummaryPanel.Controls.Add(HealthSummaryHorizontalLine)
        HealthSummaryPanel.Controls.Add(Label2)
        HealthSummaryPanel.Controls.Add(Label1)
        HealthSummaryPanel.Controls.Add(HealthSummaryUserLastCheckUpLabel)
        HealthSummaryPanel.Controls.Add(HealthSummaryUserAllergiesLabel)
        HealthSummaryPanel.Controls.Add(HealthSummaryUserBloodtypeLabel)
        HealthSummaryPanel.Controls.Add(HealthSummaryLastCheckUpLabel)
        HealthSummaryPanel.Controls.Add(HealthSummaryAllergiesLabel)
        HealthSummaryPanel.Controls.Add(HealthSummaryBloodtypeLabel)
        HealthSummaryPanel.Controls.Add(HealthSummaryLabel)
        HealthSummaryPanel.Location = New Point(14, 153)
        HealthSummaryPanel.Name = "HealthSummaryPanel"
        HealthSummaryPanel.Size = New Size(637, 203)
        HealthSummaryPanel.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Location = New Point(191, 68)
        Label2.MinimumSize = New Size(2, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(2, 107)
        Label2.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(362, 68)
        Label1.MinimumSize = New Size(2, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(2, 107)
        Label1.TabIndex = 13
        ' 
        ' HealthSummaryUserLastCheckUpLabel
        ' 
        HealthSummaryUserLastCheckUpLabel.AutoSize = True
        HealthSummaryUserLastCheckUpLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryUserLastCheckUpLabel.Location = New Point(382, 119)
        HealthSummaryUserLastCheckUpLabel.Name = "HealthSummaryUserLastCheckUpLabel"
        HealthSummaryUserLastCheckUpLabel.Size = New Size(196, 28)
        HealthSummaryUserLastCheckUpLabel.TabIndex = 7
        HealthSummaryUserLastCheckUpLabel.Text = "April 16, 2026"
        HealthSummaryUserLastCheckUpLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HealthSummaryUserAllergiesLabel
        ' 
        HealthSummaryUserAllergiesLabel.AutoSize = True
        HealthSummaryUserAllergiesLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryUserAllergiesLabel.Location = New Point(213, 119)
        HealthSummaryUserAllergiesLabel.Name = "HealthSummaryUserAllergiesLabel"
        HealthSummaryUserAllergiesLabel.Size = New Size(96, 28)
        HealthSummaryUserAllergiesLabel.TabIndex = 6
        HealthSummaryUserAllergiesLabel.Text = "Peanut"
        HealthSummaryUserAllergiesLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HealthSummaryUserBloodtypeLabel
        ' 
        HealthSummaryUserBloodtypeLabel.AutoSize = True
        HealthSummaryUserBloodtypeLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryUserBloodtypeLabel.Location = New Point(17, 119)
        HealthSummaryUserBloodtypeLabel.Name = "HealthSummaryUserBloodtypeLabel"
        HealthSummaryUserBloodtypeLabel.Size = New Size(48, 28)
        HealthSummaryUserBloodtypeLabel.TabIndex = 5
        HealthSummaryUserBloodtypeLabel.Text = "0+"
        ' 
        ' HealthSummaryLastCheckUpLabel
        ' 
        HealthSummaryLastCheckUpLabel.AutoSize = True
        HealthSummaryLastCheckUpLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryLastCheckUpLabel.Location = New Point(382, 74)
        HealthSummaryLastCheckUpLabel.Name = "HealthSummaryLastCheckUpLabel"
        HealthSummaryLastCheckUpLabel.Size = New Size(219, 34)
        HealthSummaryLastCheckUpLabel.TabIndex = 4
        HealthSummaryLastCheckUpLabel.Text = "Last Check Up"
        ' 
        ' HealthSummaryAllergiesLabel
        ' 
        HealthSummaryAllergiesLabel.AutoSize = True
        HealthSummaryAllergiesLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryAllergiesLabel.Location = New Point(213, 74)
        HealthSummaryAllergiesLabel.Name = "HealthSummaryAllergiesLabel"
        HealthSummaryAllergiesLabel.Size = New Size(141, 34)
        HealthSummaryAllergiesLabel.TabIndex = 3
        HealthSummaryAllergiesLabel.Text = "Allergies"
        ' 
        ' HealthSummaryBloodtypeLabel
        ' 
        HealthSummaryBloodtypeLabel.AutoSize = True
        HealthSummaryBloodtypeLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryBloodtypeLabel.Location = New Point(8, 68)
        HealthSummaryBloodtypeLabel.Name = "HealthSummaryBloodtypeLabel"
        HealthSummaryBloodtypeLabel.Size = New Size(177, 34)
        HealthSummaryBloodtypeLabel.TabIndex = 2
        HealthSummaryBloodtypeLabel.Text = "Blood Type"
        ' 
        ' HealthSummaryLabel
        ' 
        HealthSummaryLabel.AutoSize = True
        HealthSummaryLabel.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryLabel.Location = New Point(27, 9)
        HealthSummaryLabel.Name = "HealthSummaryLabel"
        HealthSummaryLabel.Size = New Size(287, 39)
        HealthSummaryLabel.TabIndex = 1
        HealthSummaryLabel.Text = "Health Summary"
        ' 
        ' WelcomePanel
        ' 
        WelcomePanel.BackColor = Color.White
        WelcomePanel.Controls.Add(DashboardUserNameLavel)
        WelcomePanel.Controls.Add(GreetingsLabel)
        WelcomePanel.Location = New Point(14, 16)
        WelcomePanel.Name = "WelcomePanel"
        WelcomePanel.Size = New Size(637, 120)
        WelcomePanel.TabIndex = 0
        ' 
        ' DashboardUserNameLavel
        ' 
        DashboardUserNameLavel.AutoSize = True
        DashboardUserNameLavel.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DashboardUserNameLavel.Location = New Point(56, 61)
        DashboardUserNameLavel.Name = "DashboardUserNameLavel"
        DashboardUserNameLavel.Size = New Size(268, 44)
        DashboardUserNameLavel.TabIndex = 1
        DashboardUserNameLavel.Text = "Name Sample"
        ' 
        ' GreetingsLabel
        ' 
        GreetingsLabel.AutoSize = True
        GreetingsLabel.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GreetingsLabel.Location = New Point(3, 11)
        GreetingsLabel.Name = "GreetingsLabel"
        GreetingsLabel.Size = New Size(248, 39)
        GreetingsLabel.TabIndex = 0
        GreetingsLabel.Text = "Welcome Back"
        ' 
        ' HealthSummaryHorizontalLine
        ' 
        HealthSummaryHorizontalLine.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        HealthSummaryHorizontalLine.BorderStyle = BorderStyle.FixedSingle
        HealthSummaryHorizontalLine.Location = New Point(27, 48)
        HealthSummaryHorizontalLine.MinimumSize = New Size(2, 2)
        HealthSummaryHorizontalLine.Name = "HealthSummaryHorizontalLine"
        HealthSummaryHorizontalLine.Size = New Size(585, 2)
        HealthSummaryHorizontalLine.TabIndex = 22
        ' 
        ' DefaultDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MainPanel)
        Name = "DefaultDashboard"
        Size = New Size(1285, 815)
        MainPanel.ResumeLayout(False)
        AppointmentPanel.ResumeLayout(False)
        AppointmentPanel.PerformLayout()
        CType(DashboardAppointmentIcon, ComponentModel.ISupportInitialize).EndInit()
        BillOVPanel1.ResumeLayout(False)
        BillOVPanel1.PerformLayout()
        CType(DashboardBillIcon, ComponentModel.ISupportInitialize).EndInit()
        HealthSummaryPanel.ResumeLayout(False)
        HealthSummaryPanel.PerformLayout()
        WelcomePanel.ResumeLayout(False)
        WelcomePanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents AppointmentPanel As Panel
    Friend WithEvents UpcomingAppointmentRoomLabel As Label
    Friend WithEvents UpcomingAppointmentDoctorLabel As Label
    Friend WithEvents UpcomingAppointmentDateLabel As Label
    Friend WithEvents ViewAppointmentBtn As Button
    Friend WithEvents UpcomingAppointmentLabel As Label
    Friend WithEvents BillOVPanel1 As Panel
    Friend WithEvents BillingOVUSerTotalBalanceLabel As Label
    Friend WithEvents BillingOVTotalBalanceLabel As Label
    Friend WithEvents PayBtn As Button
    Friend WithEvents BillOVLabel As Label
    Friend WithEvents HealthSummaryPanel As Panel
    Friend WithEvents HealthSummaryUserLastCheckUpLabel As Label
    Friend WithEvents HealthSummaryUserAllergiesLabel As Label
    Friend WithEvents HealthSummaryUserBloodtypeLabel As Label
    Friend WithEvents HealthSummaryLastCheckUpLabel As Label
    Friend WithEvents HealthSummaryAllergiesLabel As Label
    Friend WithEvents HealthSummaryBloodtypeLabel As Label
    Friend WithEvents HealthSummaryLabel As Label
    Friend WithEvents WelcomePanel As Panel
    Friend WithEvents DashboardUserNameLavel As Label
    Friend WithEvents GreetingsLabel As Label
    Friend WithEvents DashboardAppointmentIcon As PictureBox
    Friend WithEvents DashboardBillIcon As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents BillingOverviewHorizontalLine1 As Label
    Friend WithEvents BillingOverviewVerticalLine As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles UpcomingAppointmentDateLabel.Click
    End Sub
    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles BillingOVUserAmountLabel.Click
    End Sub
    Friend WithEvents UpcomingAppointmentHorizontalLine As Label
    Friend WithEvents BillingOverviewHorizontalLine3 As Label
    Friend WithEvents BillingOverviewHorizontalLine2 As Label
    Friend WithEvents BillingOVLastPaymentLabel As Label
    Friend WithEvents BillingOVUserLastPaymentDateLabel As Label
    Friend WithEvents BillingAndPaymentLinkLabel As LinkLabel
    Friend WithEvents BillingOVUserAmountLabel As Label
    Friend WithEvents BillingOVAmountLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HealthSummaryHorizontalLine As Label

End Class
