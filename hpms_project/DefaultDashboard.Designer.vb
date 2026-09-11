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
        HelpProvider1 = New HelpProvider()
        TableLayoutPanel1 = New TableLayoutPanel()
        BillOVPanel1 = New Panel()
        TableLayoutPanel5 = New TableLayoutPanel()
        BillingOVUserAmountLabel = New Label()
        BillingOVLastPaymentLabel = New Label()
        BillingOVAmountLabel = New Label()
        BillingOVUserLastPaymentDateLabel = New Label()
        BillingAndPaymentLinkLabel = New LinkLabel()
        TableLayoutPanel4 = New TableLayoutPanel()
        BillingOVUSerTotalBalanceLabel = New Label()
        PayBtn = New Button()
        BillingOVTotalBalanceLabel = New Label()
        BillingOverviewHorizontalLine3 = New Label()
        BillingOverviewHorizontalLine2 = New Label()
        BillingOverviewHorizontalLine1 = New Label()
        DashboardBillIcon = New PictureBox()
        BillOVLabel = New Label()
        AppointmentPanel = New Panel()
        TableLayoutPanel6 = New TableLayoutPanel()
        ViewAppointmentBtn = New Button()
        UpcomingAppointmentDateLabel = New Label()
        UpcomingAppointmentDoctorLabel = New Label()
        UpcomingAppointmentRoomLabel = New Label()
        Label2 = New Label()
        DashboardAppointmentIcon = New PictureBox()
        UpcomingAppointmentLabel = New Label()
        Panel1 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        WelcomePanel = New Panel()
        DashboardUserNameLavel = New Label()
        GreetingsLabel = New Label()
        HealthSummaryPanel = New Panel()
        Label1 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        HealthSummaryBloodtypeLabel = New Label()
        HealthSummaryAllergiesLabel = New Label()
        HealthSummaryLastCheckUpLabel = New Label()
        HealthSummaryUserLastCheckUpLabel = New Label()
        HealthSummaryUserAllergiesLabel = New Label()
        HealthSummaryUserBloodtypeLabel = New Label()
        HealthSummaryLabel = New Label()
        EmpltyPanel = New Panel()
        DefaultMainPanel = New Panel()
        TableLayoutPanel1.SuspendLayout()
        BillOVPanel1.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(DashboardBillIcon, ComponentModel.ISupportInitialize).BeginInit()
        AppointmentPanel.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        CType(DashboardAppointmentIcon, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        WelcomePanel.SuspendLayout()
        HealthSummaryPanel.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        DefaultMainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Silver
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(BillOVPanel1, 0, 1)
        TableLayoutPanel1.Controls.Add(AppointmentPanel, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(EmpltyPanel, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(25)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1352, 912)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' BillOVPanel1
        ' 
        BillOVPanel1.BackColor = Color.White
        BillOVPanel1.Controls.Add(TableLayoutPanel5)
        BillOVPanel1.Controls.Add(BillingAndPaymentLinkLabel)
        BillOVPanel1.Controls.Add(TableLayoutPanel4)
        BillOVPanel1.Controls.Add(BillingOverviewHorizontalLine3)
        BillOVPanel1.Controls.Add(BillingOverviewHorizontalLine2)
        BillOVPanel1.Controls.Add(BillingOverviewHorizontalLine1)
        BillOVPanel1.Controls.Add(DashboardBillIcon)
        BillOVPanel1.Controls.Add(BillOVLabel)
        BillOVPanel1.Dock = DockStyle.Fill
        BillOVPanel1.Location = New Point(25, 459)
        BillOVPanel1.Margin = New Padding(25, 3, 3, 25)
        BillOVPanel1.Name = "BillOVPanel1"
        BillOVPanel1.Size = New Size(648, 428)
        BillOVPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(BillingOVUserAmountLabel, 1, 1)
        TableLayoutPanel5.Controls.Add(BillingOVLastPaymentLabel, 0, 0)
        TableLayoutPanel5.Controls.Add(BillingOVAmountLabel, 1, 0)
        TableLayoutPanel5.Controls.Add(BillingOVUserLastPaymentDateLabel, 0, 1)
        TableLayoutPanel5.Location = New Point(3, 220)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(667, 139)
        TableLayoutPanel5.TabIndex = 1
        ' 
        ' BillingOVUserAmountLabel
        ' 
        BillingOVUserAmountLabel.AutoSize = True
        BillingOVUserAmountLabel.Dock = DockStyle.Fill
        BillingOVUserAmountLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVUserAmountLabel.ForeColor = Color.FromArgb(CByte(123), CByte(154), CByte(109))
        BillingOVUserAmountLabel.Location = New Point(336, 69)
        BillingOVUserAmountLabel.Name = "BillingOVUserAmountLabel"
        BillingOVUserAmountLabel.Size = New Size(328, 70)
        BillingOVUserAmountLabel.TabIndex = 20
        BillingOVUserAmountLabel.Text = "P. 1,000.00"
        ' 
        ' BillingOVLastPaymentLabel
        ' 
        BillingOVLastPaymentLabel.AutoSize = True
        BillingOVLastPaymentLabel.Dock = DockStyle.Fill
        BillingOVLastPaymentLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVLastPaymentLabel.Location = New Point(3, 0)
        BillingOVLastPaymentLabel.Name = "BillingOVLastPaymentLabel"
        BillingOVLastPaymentLabel.Size = New Size(327, 69)
        BillingOVLastPaymentLabel.TabIndex = 15
        BillingOVLastPaymentLabel.Text = "Last Payment"
        ' 
        ' BillingOVAmountLabel
        ' 
        BillingOVAmountLabel.AutoSize = True
        BillingOVAmountLabel.Dock = DockStyle.Fill
        BillingOVAmountLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVAmountLabel.Location = New Point(336, 0)
        BillingOVAmountLabel.Name = "BillingOVAmountLabel"
        BillingOVAmountLabel.Size = New Size(328, 69)
        BillingOVAmountLabel.TabIndex = 19
        BillingOVAmountLabel.Text = "Amount"
        ' 
        ' BillingOVUserLastPaymentDateLabel
        ' 
        BillingOVUserLastPaymentDateLabel.AutoSize = True
        BillingOVUserLastPaymentDateLabel.Dock = DockStyle.Fill
        BillingOVUserLastPaymentDateLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVUserLastPaymentDateLabel.Location = New Point(3, 69)
        BillingOVUserLastPaymentDateLabel.Name = "BillingOVUserLastPaymentDateLabel"
        BillingOVUserLastPaymentDateLabel.Size = New Size(327, 70)
        BillingOVUserLastPaymentDateLabel.TabIndex = 16
        BillingOVUserLastPaymentDateLabel.Text = "May 10, 2026"
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
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(BillingOVUSerTotalBalanceLabel, 0, 1)
        TableLayoutPanel4.Controls.Add(PayBtn, 1, 1)
        TableLayoutPanel4.Controls.Add(BillingOVTotalBalanceLabel, 0, 0)
        TableLayoutPanel4.Location = New Point(3, 82)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(667, 129)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' BillingOVUSerTotalBalanceLabel
        ' 
        BillingOVUSerTotalBalanceLabel.AutoSize = True
        BillingOVUSerTotalBalanceLabel.Dock = DockStyle.Fill
        BillingOVUSerTotalBalanceLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVUSerTotalBalanceLabel.ForeColor = Color.FromArgb(CByte(123), CByte(154), CByte(109))
        BillingOVUSerTotalBalanceLabel.Location = New Point(3, 64)
        BillingOVUSerTotalBalanceLabel.Name = "BillingOVUSerTotalBalanceLabel"
        BillingOVUSerTotalBalanceLabel.Size = New Size(327, 65)
        BillingOVUSerTotalBalanceLabel.TabIndex = 9
        BillingOVUSerTotalBalanceLabel.Text = "P. 3,700.00"
        ' 
        ' PayBtn
        ' 
        PayBtn.BackColor = Color.FromArgb(CByte(167), CByte(239), CByte(241))
        PayBtn.Dock = DockStyle.Fill
        PayBtn.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        PayBtn.Location = New Point(336, 67)
        PayBtn.Name = "PayBtn"
        PayBtn.Size = New Size(328, 59)
        PayBtn.TabIndex = 3
        PayBtn.Text = "Pay Now"
        PayBtn.UseVisualStyleBackColor = False
        ' 
        ' BillingOVTotalBalanceLabel
        ' 
        BillingOVTotalBalanceLabel.AutoSize = True
        BillingOVTotalBalanceLabel.Dock = DockStyle.Fill
        BillingOVTotalBalanceLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BillingOVTotalBalanceLabel.Location = New Point(3, 0)
        BillingOVTotalBalanceLabel.Name = "BillingOVTotalBalanceLabel"
        BillingOVTotalBalanceLabel.Size = New Size(327, 64)
        BillingOVTotalBalanceLabel.TabIndex = 8
        BillingOVTotalBalanceLabel.Text = "Total Balance"
        ' 
        ' BillingOverviewHorizontalLine3
        ' 
        BillingOverviewHorizontalLine3.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        BillingOverviewHorizontalLine3.BorderStyle = BorderStyle.FixedSingle
        BillingOverviewHorizontalLine3.Location = New Point(17, 352)
        BillingOverviewHorizontalLine3.MinimumSize = New Size(2, 2)
        BillingOverviewHorizontalLine3.Name = "BillingOverviewHorizontalLine3"
        BillingOverviewHorizontalLine3.Size = New Size(629, 2)
        BillingOverviewHorizontalLine3.TabIndex = 14
        ' 
        ' BillingOverviewHorizontalLine2
        ' 
        BillingOverviewHorizontalLine2.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        BillingOverviewHorizontalLine2.BorderStyle = BorderStyle.FixedSingle
        BillingOverviewHorizontalLine2.Location = New Point(17, 215)
        BillingOverviewHorizontalLine2.MinimumSize = New Size(2, 2)
        BillingOverviewHorizontalLine2.Name = "BillingOverviewHorizontalLine2"
        BillingOverviewHorizontalLine2.Size = New Size(630, 2)
        BillingOverviewHorizontalLine2.TabIndex = 13
        ' 
        ' BillingOverviewHorizontalLine1
        ' 
        BillingOverviewHorizontalLine1.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        BillingOverviewHorizontalLine1.BorderStyle = BorderStyle.FixedSingle
        BillingOverviewHorizontalLine1.Location = New Point(17, 77)
        BillingOverviewHorizontalLine1.MinimumSize = New Size(2, 2)
        BillingOverviewHorizontalLine1.Name = "BillingOverviewHorizontalLine1"
        BillingOverviewHorizontalLine1.Size = New Size(630, 2)
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
        ' AppointmentPanel
        ' 
        AppointmentPanel.BackColor = Color.White
        AppointmentPanel.Controls.Add(TableLayoutPanel6)
        AppointmentPanel.Controls.Add(DashboardAppointmentIcon)
        AppointmentPanel.Controls.Add(UpcomingAppointmentLabel)
        AppointmentPanel.Dock = DockStyle.Fill
        AppointmentPanel.Location = New Point(676, 25)
        AppointmentPanel.Margin = New Padding(0, 25, 25, 25)
        AppointmentPanel.Name = "AppointmentPanel"
        AppointmentPanel.Size = New Size(651, 406)
        AppointmentPanel.TabIndex = 4
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.Controls.Add(ViewAppointmentBtn, 0, 3)
        TableLayoutPanel6.Controls.Add(UpcomingAppointmentDateLabel, 0, 0)
        TableLayoutPanel6.Controls.Add(UpcomingAppointmentDoctorLabel, 0, 1)
        TableLayoutPanel6.Controls.Add(UpcomingAppointmentRoomLabel, 0, 2)
        TableLayoutPanel6.Controls.Add(Label2, 1, 0)
        TableLayoutPanel6.Dock = DockStyle.Bottom
        TableLayoutPanel6.Location = New Point(0, 71)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 4
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.Size = New Size(651, 335)
        TableLayoutPanel6.TabIndex = 0
        ' 
        ' ViewAppointmentBtn
        ' 
        ViewAppointmentBtn.BackColor = Color.FromArgb(CByte(167), CByte(239), CByte(241))
        ViewAppointmentBtn.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ViewAppointmentBtn.Location = New Point(3, 252)
        ViewAppointmentBtn.Name = "ViewAppointmentBtn"
        ViewAppointmentBtn.Size = New Size(328, 59)
        ViewAppointmentBtn.TabIndex = 3
        ViewAppointmentBtn.Text = "View Appointment"
        ViewAppointmentBtn.UseVisualStyleBackColor = False
        ' 
        ' UpcomingAppointmentDateLabel
        ' 
        UpcomingAppointmentDateLabel.AutoSize = True
        UpcomingAppointmentDateLabel.Dock = DockStyle.Fill
        UpcomingAppointmentDateLabel.Font = New Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpcomingAppointmentDateLabel.Location = New Point(3, 0)
        UpcomingAppointmentDateLabel.Name = "UpcomingAppointmentDateLabel"
        UpcomingAppointmentDateLabel.Size = New Size(482, 83)
        UpcomingAppointmentDateLabel.TabIndex = 5
        UpcomingAppointmentDateLabel.Text = "November 17, 2026  "
        ' 
        ' UpcomingAppointmentDoctorLabel
        ' 
        UpcomingAppointmentDoctorLabel.AutoSize = True
        UpcomingAppointmentDoctorLabel.Dock = DockStyle.Fill
        UpcomingAppointmentDoctorLabel.Font = New Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpcomingAppointmentDoctorLabel.Location = New Point(3, 83)
        UpcomingAppointmentDoctorLabel.Name = "UpcomingAppointmentDoctorLabel"
        UpcomingAppointmentDoctorLabel.Size = New Size(482, 83)
        UpcomingAppointmentDoctorLabel.TabIndex = 6
        UpcomingAppointmentDoctorLabel.Text = "DR. Obregoon"
        ' 
        ' UpcomingAppointmentRoomLabel
        ' 
        UpcomingAppointmentRoomLabel.AutoSize = True
        UpcomingAppointmentRoomLabel.Dock = DockStyle.Fill
        UpcomingAppointmentRoomLabel.Font = New Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpcomingAppointmentRoomLabel.Location = New Point(3, 166)
        UpcomingAppointmentRoomLabel.Name = "UpcomingAppointmentRoomLabel"
        UpcomingAppointmentRoomLabel.Size = New Size(482, 83)
        UpcomingAppointmentRoomLabel.TabIndex = 7
        UpcomingAppointmentRoomLabel.Text = "Room 911"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Lucida Console", 16F, FontStyle.Bold)
        Label2.Location = New Point(491, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 83)
        Label2.TabIndex = 8
        Label2.Text = "1:00PM"
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
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(25, 25)
        Panel1.Margin = New Padding(25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(626, 406)
        Panel1.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(WelcomePanel, 0, 0)
        TableLayoutPanel2.Controls.Add(HealthSummaryPanel, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(25)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 34.77089F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 65.22911F))
        TableLayoutPanel2.Size = New Size(626, 406)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' WelcomePanel
        ' 
        WelcomePanel.BackColor = Color.White
        WelcomePanel.Controls.Add(DashboardUserNameLavel)
        WelcomePanel.Controls.Add(GreetingsLabel)
        WelcomePanel.Dock = DockStyle.Fill
        WelcomePanel.Location = New Point(3, 3)
        WelcomePanel.Margin = New Padding(3, 3, 3, 10)
        WelcomePanel.Name = "WelcomePanel"
        WelcomePanel.Size = New Size(620, 128)
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
        GreetingsLabel.Dock = DockStyle.Top
        GreetingsLabel.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GreetingsLabel.Location = New Point(0, 0)
        GreetingsLabel.Name = "GreetingsLabel"
        GreetingsLabel.Size = New Size(248, 39)
        GreetingsLabel.TabIndex = 0
        GreetingsLabel.Text = "Welcome Back"
        ' 
        ' HealthSummaryPanel
        ' 
        HealthSummaryPanel.BackColor = Color.White
        HealthSummaryPanel.Controls.Add(Label1)
        HealthSummaryPanel.Controls.Add(TableLayoutPanel3)
        HealthSummaryPanel.Controls.Add(HealthSummaryLabel)
        HealthSummaryPanel.Dock = DockStyle.Fill
        HealthSummaryPanel.Location = New Point(3, 144)
        HealthSummaryPanel.Name = "HealthSummaryPanel"
        HealthSummaryPanel.Size = New Size(620, 259)
        HealthSummaryPanel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Dock = DockStyle.Top
        Label1.Location = New Point(0, 39)
        Label1.MinimumSize = New Size(2, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(620, 2)
        Label1.TabIndex = 12
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel3.Controls.Add(HealthSummaryBloodtypeLabel, 0, 0)
        TableLayoutPanel3.Controls.Add(HealthSummaryAllergiesLabel, 1, 0)
        TableLayoutPanel3.Controls.Add(HealthSummaryLastCheckUpLabel, 2, 0)
        TableLayoutPanel3.Controls.Add(HealthSummaryUserLastCheckUpLabel, 2, 1)
        TableLayoutPanel3.Controls.Add(HealthSummaryUserAllergiesLabel, 1, 1)
        TableLayoutPanel3.Controls.Add(HealthSummaryUserBloodtypeLabel, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 39)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(620, 220)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' HealthSummaryBloodtypeLabel
        ' 
        HealthSummaryBloodtypeLabel.AutoSize = True
        HealthSummaryBloodtypeLabel.Dock = DockStyle.Fill
        HealthSummaryBloodtypeLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryBloodtypeLabel.Location = New Point(5, 2)
        HealthSummaryBloodtypeLabel.Name = "HealthSummaryBloodtypeLabel"
        HealthSummaryBloodtypeLabel.Size = New Size(197, 40)
        HealthSummaryBloodtypeLabel.TabIndex = 2
        HealthSummaryBloodtypeLabel.Text = "Blood Type"
        ' 
        ' HealthSummaryAllergiesLabel
        ' 
        HealthSummaryAllergiesLabel.AutoSize = True
        HealthSummaryAllergiesLabel.Dock = DockStyle.Fill
        HealthSummaryAllergiesLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryAllergiesLabel.Location = New Point(210, 2)
        HealthSummaryAllergiesLabel.Name = "HealthSummaryAllergiesLabel"
        HealthSummaryAllergiesLabel.Size = New Size(198, 40)
        HealthSummaryAllergiesLabel.TabIndex = 3
        HealthSummaryAllergiesLabel.Text = "Allergies"
        ' 
        ' HealthSummaryLastCheckUpLabel
        ' 
        HealthSummaryLastCheckUpLabel.AutoSize = True
        HealthSummaryLastCheckUpLabel.Dock = DockStyle.Fill
        HealthSummaryLastCheckUpLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryLastCheckUpLabel.Location = New Point(416, 2)
        HealthSummaryLastCheckUpLabel.Name = "HealthSummaryLastCheckUpLabel"
        HealthSummaryLastCheckUpLabel.Size = New Size(199, 40)
        HealthSummaryLastCheckUpLabel.TabIndex = 4
        HealthSummaryLastCheckUpLabel.Text = "Last Check Up"
        ' 
        ' HealthSummaryUserLastCheckUpLabel
        ' 
        HealthSummaryUserLastCheckUpLabel.AutoSize = True
        HealthSummaryUserLastCheckUpLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryUserLastCheckUpLabel.Location = New Point(416, 44)
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
        HealthSummaryUserAllergiesLabel.Location = New Point(210, 44)
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
        HealthSummaryUserBloodtypeLabel.Location = New Point(5, 44)
        HealthSummaryUserBloodtypeLabel.Name = "HealthSummaryUserBloodtypeLabel"
        HealthSummaryUserBloodtypeLabel.Size = New Size(48, 28)
        HealthSummaryUserBloodtypeLabel.TabIndex = 5
        HealthSummaryUserBloodtypeLabel.Text = "0+"
        ' 
        ' HealthSummaryLabel
        ' 
        HealthSummaryLabel.AutoSize = True
        HealthSummaryLabel.Dock = DockStyle.Top
        HealthSummaryLabel.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HealthSummaryLabel.Location = New Point(0, 0)
        HealthSummaryLabel.Name = "HealthSummaryLabel"
        HealthSummaryLabel.Size = New Size(287, 39)
        HealthSummaryLabel.TabIndex = 1
        HealthSummaryLabel.Text = "Health Summary"
        ' 
        ' EmpltyPanel
        ' 
        EmpltyPanel.BackColor = Color.White
        EmpltyPanel.Dock = DockStyle.Fill
        EmpltyPanel.Location = New Point(679, 459)
        EmpltyPanel.Margin = New Padding(3, 3, 25, 25)
        EmpltyPanel.Name = "EmpltyPanel"
        EmpltyPanel.Size = New Size(648, 428)
        EmpltyPanel.TabIndex = 5
        ' 
        ' DefaultMainPanel
        ' 
        DefaultMainPanel.BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        DefaultMainPanel.Controls.Add(TableLayoutPanel1)
        DefaultMainPanel.Dock = DockStyle.Fill
        DefaultMainPanel.Location = New Point(0, 0)
        DefaultMainPanel.Name = "DefaultMainPanel"
        DefaultMainPanel.Size = New Size(1352, 912)
        DefaultMainPanel.TabIndex = 3
        ' 
        ' DefaultDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DefaultMainPanel)
        Name = "DefaultDashboard"
        Size = New Size(1352, 912)
        TableLayoutPanel1.ResumeLayout(False)
        BillOVPanel1.ResumeLayout(False)
        BillOVPanel1.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        CType(DashboardBillIcon, ComponentModel.ISupportInitialize).EndInit()
        AppointmentPanel.ResumeLayout(False)
        AppointmentPanel.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        CType(DashboardAppointmentIcon, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        WelcomePanel.ResumeLayout(False)
        WelcomePanel.PerformLayout()
        HealthSummaryPanel.ResumeLayout(False)
        HealthSummaryPanel.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        DefaultMainPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents HelpProvider1 As HelpProvider
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles UpcomingAppointmentDateLabel.Click
    End Sub
    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles BillingOVUserAmountLabel.Click
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BillOVPanel1 As Panel
    Friend WithEvents BillingOVUserAmountLabel As Label
    Friend WithEvents BillingOVAmountLabel As Label
    Friend WithEvents BillingAndPaymentLinkLabel As LinkLabel
    Friend WithEvents BillingOVUserLastPaymentDateLabel As Label
    Friend WithEvents BillingOVLastPaymentLabel As Label
    Friend WithEvents BillingOverviewHorizontalLine3 As Label
    Friend WithEvents BillingOverviewHorizontalLine2 As Label
    Friend WithEvents BillingOverviewHorizontalLine1 As Label
    Friend WithEvents DashboardBillIcon As PictureBox
    Friend WithEvents BillingOVUSerTotalBalanceLabel As Label
    Friend WithEvents BillingOVTotalBalanceLabel As Label
    Friend WithEvents PayBtn As Button
    Friend WithEvents BillOVLabel As Label
    Friend WithEvents AppointmentPanel As Panel
    Friend WithEvents DashboardAppointmentIcon As PictureBox
    Friend WithEvents UpcomingAppointmentRoomLabel As Label
    Friend WithEvents UpcomingAppointmentDoctorLabel As Label
    Friend WithEvents UpcomingAppointmentDateLabel As Label
    Friend WithEvents ViewAppointmentBtn As Button
    Friend WithEvents UpcomingAppointmentLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WelcomePanel As Panel
    Friend WithEvents DashboardUserNameLavel As Label
    Friend WithEvents GreetingsLabel As Label
    Friend WithEvents HealthSummaryPanel As Panel
    Friend WithEvents HealthSummaryLabel As Label
    Friend WithEvents EmpltyPanel As Panel
    Friend WithEvents DefaultMainPanel As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents HealthSummaryBloodtypeLabel As Label
    Friend WithEvents HealthSummaryAllergiesLabel As Label
    Friend WithEvents HealthSummaryLastCheckUpLabel As Label
    Friend WithEvents HealthSummaryUserLastCheckUpLabel As Label
    Friend WithEvents HealthSummaryUserAllergiesLabel As Label
    Friend WithEvents HealthSummaryUserBloodtypeLabel As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label2 As Label

End Class
