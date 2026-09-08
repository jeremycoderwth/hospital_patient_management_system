<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        LeftSideBar.SuspendLayout()
        Panel1.SuspendLayout()
        CType(LOGO, ComponentModel.ISupportInitialize).BeginInit()
        TopPanel.SuspendLayout()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
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
        LeftSideBar.Name = "LeftSideBar"
        LeftSideBar.Size = New Size(188, 750)
        LeftSideBar.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(3, 540)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(179, 126)
        Panel1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(9, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 28)
        Label3.TabIndex = 1
        Label3.Text = "Contact Support"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(28, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 28)
        Label2.TabIndex = 0
        Label2.Text = "Need Help?"
        ' 
        ' LOGO
        ' 
        LOGO.BackColor = Color.White
        LOGO.Location = New Point(31, 30)
        LOGO.Name = "LOGO"
        LOGO.Size = New Size(127, 130)
        LOGO.TabIndex = 6
        LOGO.TabStop = False
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.Location = New Point(16, 493)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(131, 41)
        LogOutBtn.TabIndex = 5
        LogOutBtn.Text = "LOG OUT"
        LogOutBtn.UseVisualStyleBackColor = True
        ' 
        ' BillsBtn
        ' 
        BillsBtn.Location = New Point(16, 349)
        BillsBtn.Name = "BillsBtn"
        BillsBtn.Size = New Size(142, 41)
        BillsBtn.TabIndex = 4
        BillsBtn.Text = "BILLS"
        BillsBtn.UseVisualStyleBackColor = True
        ' 
        ' MedRecordsBtn
        ' 
        MedRecordsBtn.Location = New Point(16, 311)
        MedRecordsBtn.Name = "MedRecordsBtn"
        MedRecordsBtn.Size = New Size(142, 41)
        MedRecordsBtn.TabIndex = 3
        MedRecordsBtn.Text = "MED RECORDS"
        MedRecordsBtn.UseVisualStyleBackColor = True
        ' 
        ' AppointmentBtn
        ' 
        AppointmentBtn.Location = New Point(16, 275)
        AppointmentBtn.Name = "AppointmentBtn"
        AppointmentBtn.Size = New Size(142, 41)
        AppointmentBtn.TabIndex = 2
        AppointmentBtn.Text = "APPOINTMENT"
        AppointmentBtn.UseVisualStyleBackColor = True
        ' 
        ' PeopelBtn
        ' 
        PeopelBtn.Location = New Point(16, 237)
        PeopelBtn.Name = "PeopelBtn"
        PeopelBtn.Size = New Size(142, 41)
        PeopelBtn.TabIndex = 1
        PeopelBtn.Text = "PEOPLE"
        PeopelBtn.UseVisualStyleBackColor = True
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.Location = New Point(16, 199)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Size = New Size(142, 41)
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
        TopPanel.Location = New Point(188, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(955, 107)
        TopPanel.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(84, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 32)
        Label1.TabIndex = 2
        Label1.Text = "Patient Dashboard"
        ' 
        ' ProfileLabel
        ' 
        ProfileLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProfileLabel.AutoSize = True
        ProfileLabel.BackColor = Color.Transparent
        ProfileLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ProfileLabel.Location = New Point(1439, 30)
        ProfileLabel.Name = "ProfileLabel"
        ProfileLabel.Size = New Size(157, 32)
        ProfileLabel.TabIndex = 1
        ProfileLabel.Text = "Profile Name"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProfilePicture.BackColor = Color.White
        ProfilePicture.Location = New Point(1367, 21)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(66, 54)
        ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        ProfilePicture.TabIndex = 0
        ProfilePicture.TabStop = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = SystemColors.ControlDark
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(188, 107)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(955, 643)
        MainPanel.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(MainPanel)
        Controls.Add(TopPanel)
        Controls.Add(LeftSideBar)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Form1"
        LeftSideBar.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(LOGO, ComponentModel.ISupportInitialize).EndInit()
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LeftSideBar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents BillsBtn As Button
    Friend WithEvents MedRecordsBtn As Button
    Friend WithEvents AppointmentBtn As Button
    Friend WithEvents PeopelBtn As Button
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents TopPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ProfileLabel As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents MainPanel As Panel

End Class
