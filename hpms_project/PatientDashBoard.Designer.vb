<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDashBoard
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
        Panel1 = New Panel()
        OverviewAddressLabel = New Label()
        OverviewGenderLabel = New Label()
        OverviewBirthdateLabel = New Label()
        OverviewContactLabel = New Label()
        OverviewEmailLabel = New Label()
        OverviewIDLabel = New Label()
        OverviewNameLabel = New Label()
        PictureBox1 = New PictureBox()
        UCPersonalInfoPanel = New Panel()
        CPNumberTextBox = New TextBox()
        BirthDateTextBox = New TextBox()
        FullNameTextBox = New TextBox()
        BirthdateLabel = New Label()
        FullNameLabel = New Label()
        PersonalInfoLabel = New Label()
        CPNumberLabel = New Label()
        UCAccountInformationPanel = New Panel()
        EditLabel = New Label()
        PassTextBox = New TextBox()
        EmailTextBox = New TextBox()
        UsernameTextBox = New TextBox()
        ChangePassBtn = New Button()
        PasswordLabel = New Label()
        EMailLabel = New Label()
        UserNameLabel = New Label()
        AccountInfoLabel = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        UCProfileLabel = New Label()
        ProfileInfoLabel = New Label()
        PatientDashboardPanel = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        UCWelcomePanel = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        UCPersonalInfoPanel.SuspendLayout()
        UCAccountInformationPanel.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        PatientDashboardPanel.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        UCWelcomePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(OverviewAddressLabel)
        Panel1.Controls.Add(OverviewGenderLabel)
        Panel1.Controls.Add(OverviewBirthdateLabel)
        Panel1.Controls.Add(OverviewContactLabel)
        Panel1.Controls.Add(OverviewEmailLabel)
        Panel1.Controls.Add(OverviewIDLabel)
        Panel1.Controls.Add(OverviewNameLabel)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(25, 0)
        Panel1.Margin = New Padding(25, 0, 45, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(603, 718)
        Panel1.TabIndex = 2
        ' 
        ' OverviewAddressLabel
        ' 
        OverviewAddressLabel.AutoSize = True
        OverviewAddressLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        OverviewAddressLabel.Location = New Point(44, 579)
        OverviewAddressLabel.Name = "OverviewAddressLabel"
        OverviewAddressLabel.Size = New Size(122, 28)
        OverviewAddressLabel.TabIndex = 8
        OverviewAddressLabel.Text = "Address:"
        ' 
        ' OverviewGenderLabel
        ' 
        OverviewGenderLabel.AutoSize = True
        OverviewGenderLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        OverviewGenderLabel.Location = New Point(44, 533)
        OverviewGenderLabel.Name = "OverviewGenderLabel"
        OverviewGenderLabel.Size = New Size(110, 28)
        OverviewGenderLabel.TabIndex = 7
        OverviewGenderLabel.Text = "Gender:"
        ' 
        ' OverviewBirthdateLabel
        ' 
        OverviewBirthdateLabel.AutoSize = True
        OverviewBirthdateLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        OverviewBirthdateLabel.Location = New Point(44, 490)
        OverviewBirthdateLabel.Name = "OverviewBirthdateLabel"
        OverviewBirthdateLabel.Size = New Size(135, 28)
        OverviewBirthdateLabel.TabIndex = 6
        OverviewBirthdateLabel.Text = "Birthdate:"
        ' 
        ' OverviewContactLabel
        ' 
        OverviewContactLabel.AutoSize = True
        OverviewContactLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        OverviewContactLabel.Location = New Point(48, 449)
        OverviewContactLabel.Name = "OverviewContactLabel"
        OverviewContactLabel.Size = New Size(118, 28)
        OverviewContactLabel.TabIndex = 5
        OverviewContactLabel.Text = "Contact:"
        ' 
        ' OverviewEmailLabel
        ' 
        OverviewEmailLabel.AutoSize = True
        OverviewEmailLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        OverviewEmailLabel.Location = New Point(48, 409)
        OverviewEmailLabel.Name = "OverviewEmailLabel"
        OverviewEmailLabel.Size = New Size(103, 28)
        OverviewEmailLabel.TabIndex = 3
        OverviewEmailLabel.Text = "E-mail:"
        ' 
        ' OverviewIDLabel
        ' 
        OverviewIDLabel.AutoSize = True
        OverviewIDLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        OverviewIDLabel.Location = New Point(189, 318)
        OverviewIDLabel.Name = "OverviewIDLabel"
        OverviewIDLabel.Size = New Size(56, 34)
        OverviewIDLabel.TabIndex = 2
        OverviewIDLabel.Text = "ID:"
        ' 
        ' OverviewNameLabel
        ' 
        OverviewNameLabel.AutoSize = True
        OverviewNameLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        OverviewNameLabel.Location = New Point(138, 284)
        OverviewNameLabel.Name = "OverviewNameLabel"
        OverviewNameLabel.Size = New Size(107, 34)
        OverviewNameLabel.TabIndex = 1
        OverviewNameLabel.Text = "Name:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(240, 61)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' UCPersonalInfoPanel
        ' 
        UCPersonalInfoPanel.BackColor = Color.White
        UCPersonalInfoPanel.Controls.Add(CPNumberTextBox)
        UCPersonalInfoPanel.Controls.Add(BirthDateTextBox)
        UCPersonalInfoPanel.Controls.Add(FullNameTextBox)
        UCPersonalInfoPanel.Controls.Add(BirthdateLabel)
        UCPersonalInfoPanel.Controls.Add(FullNameLabel)
        UCPersonalInfoPanel.Controls.Add(PersonalInfoLabel)
        UCPersonalInfoPanel.Controls.Add(CPNumberLabel)
        UCPersonalInfoPanel.Dock = DockStyle.Fill
        UCPersonalInfoPanel.Location = New Point(3, 3)
        UCPersonalInfoPanel.Name = "UCPersonalInfoPanel"
        UCPersonalInfoPanel.Size = New Size(639, 351)
        UCPersonalInfoPanel.TabIndex = 3
        ' 
        ' CPNumberTextBox
        ' 
        CPNumberTextBox.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        CPNumberTextBox.Location = New Point(181, 204)
        CPNumberTextBox.Name = "CPNumberTextBox"
        CPNumberTextBox.Size = New Size(470, 44)
        CPNumberTextBox.TabIndex = 10
        ' 
        ' BirthDateTextBox
        ' 
        BirthDateTextBox.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        BirthDateTextBox.Location = New Point(181, 144)
        BirthDateTextBox.Name = "BirthDateTextBox"
        BirthDateTextBox.Size = New Size(470, 44)
        BirthDateTextBox.TabIndex = 9
        ' 
        ' FullNameTextBox
        ' 
        FullNameTextBox.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        FullNameTextBox.Location = New Point(181, 81)
        FullNameTextBox.Name = "FullNameTextBox"
        FullNameTextBox.Size = New Size(470, 44)
        FullNameTextBox.TabIndex = 8
        ' 
        ' BirthdateLabel
        ' 
        BirthdateLabel.AutoSize = True
        BirthdateLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        BirthdateLabel.Location = New Point(22, 160)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New Size(162, 28)
        BirthdateLabel.TabIndex = 7
        BirthdateLabel.Text = "BIRTHDATE:"
        ' 
        ' FullNameLabel
        ' 
        FullNameLabel.AutoSize = True
        FullNameLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        FullNameLabel.Location = New Point(17, 97)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New Size(163, 28)
        FullNameLabel.TabIndex = 6
        FullNameLabel.Text = "FULL NAME:"
        ' 
        ' PersonalInfoLabel
        ' 
        PersonalInfoLabel.AutoSize = True
        PersonalInfoLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PersonalInfoLabel.Location = New Point(18, 18)
        PersonalInfoLabel.Name = "PersonalInfoLabel"
        PersonalInfoLabel.Size = New Size(313, 34)
        PersonalInfoLabel.TabIndex = 2
        PersonalInfoLabel.Text = "Personal Information"
        ' 
        ' CPNumberLabel
        ' 
        CPNumberLabel.AutoSize = True
        CPNumberLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        CPNumberLabel.Location = New Point(18, 220)
        CPNumberLabel.Name = "CPNumberLabel"
        CPNumberLabel.Size = New Size(166, 28)
        CPNumberLabel.TabIndex = 5
        CPNumberLabel.Text = "CP NUMBER:"
        ' 
        ' UCAccountInformationPanel
        ' 
        UCAccountInformationPanel.BackColor = Color.White
        UCAccountInformationPanel.Controls.Add(EditLabel)
        UCAccountInformationPanel.Controls.Add(PassTextBox)
        UCAccountInformationPanel.Controls.Add(EmailTextBox)
        UCAccountInformationPanel.Controls.Add(UsernameTextBox)
        UCAccountInformationPanel.Controls.Add(ChangePassBtn)
        UCAccountInformationPanel.Controls.Add(PasswordLabel)
        UCAccountInformationPanel.Controls.Add(EMailLabel)
        UCAccountInformationPanel.Controls.Add(UserNameLabel)
        UCAccountInformationPanel.Controls.Add(AccountInfoLabel)
        UCAccountInformationPanel.Dock = DockStyle.Fill
        UCAccountInformationPanel.Location = New Point(3, 360)
        UCAccountInformationPanel.Name = "UCAccountInformationPanel"
        UCAccountInformationPanel.Size = New Size(639, 352)
        UCAccountInformationPanel.TabIndex = 4
        ' 
        ' EditLabel
        ' 
        EditLabel.AutoSize = True
        EditLabel.Cursor = Cursors.Hand
        EditLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        EditLabel.ForeColor = SystemColors.HotTrack
        EditLabel.Location = New Point(581, 21)
        EditLabel.Name = "EditLabel"
        EditLabel.Size = New Size(70, 34)
        EditLabel.TabIndex = 14
        EditLabel.Text = "Edit"
        ' 
        ' PassTextBox
        ' 
        PassTextBox.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        PassTextBox.Location = New Point(181, 183)
        PassTextBox.Name = "PassTextBox"
        PassTextBox.Size = New Size(470, 44)
        PassTextBox.TabIndex = 13
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        EmailTextBox.Location = New Point(181, 130)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(470, 44)
        EmailTextBox.TabIndex = 12
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        UsernameTextBox.Location = New Point(181, 75)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(470, 44)
        UsernameTextBox.TabIndex = 11
        ' 
        ' ChangePassBtn
        ' 
        ChangePassBtn.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        ChangePassBtn.Location = New Point(364, 255)
        ChangePassBtn.Name = "ChangePassBtn"
        ChangePassBtn.Size = New Size(287, 54)
        ChangePassBtn.TabIndex = 8
        ChangePassBtn.Text = "Change Password"
        ChangePassBtn.UseVisualStyleBackColor = True
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        PasswordLabel.Location = New Point(22, 199)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(158, 28)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "PASSWORD:"
        ' 
        ' EMailLabel
        ' 
        EMailLabel.AutoSize = True
        EMailLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        EMailLabel.Location = New Point(68, 146)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New Size(112, 28)
        EMailLabel.TabIndex = 6
        EMailLabel.Text = "E-MAIL:"
        ' 
        ' UserNameLabel
        ' 
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold)
        UserNameLabel.Location = New Point(25, 91)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New Size(156, 28)
        UserNameLabel.TabIndex = 4
        UserNameLabel.Text = "USERNAME:"
        ' 
        ' AccountInfoLabel
        ' 
        AccountInfoLabel.AutoSize = True
        AccountInfoLabel.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        AccountInfoLabel.Location = New Point(18, 21)
        AccountInfoLabel.Name = "AccountInfoLabel"
        AccountInfoLabel.Size = New Size(307, 34)
        AccountInfoLabel.TabIndex = 3
        AccountInfoLabel.Text = "Account Information"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(UCAccountInformationPanel, 0, 1)
        TableLayoutPanel1.Controls.Add(UCPersonalInfoPanel, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(676, 3)
        TableLayoutPanel1.Margin = New Padding(3, 3, 25, 25)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(645, 715)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 1, 0)
        TableLayoutPanel2.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 166)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(1346, 743)
        TableLayoutPanel2.TabIndex = 6
        ' 
        ' UCProfileLabel
        ' 
        UCProfileLabel.AutoSize = True
        UCProfileLabel.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UCProfileLabel.Location = New Point(17, 19)
        UCProfileLabel.Name = "UCProfileLabel"
        UCProfileLabel.Size = New Size(165, 44)
        UCProfileLabel.TabIndex = 0
        UCProfileLabel.Text = "PROFILE"
        ' 
        ' ProfileInfoLabel
        ' 
        ProfileInfoLabel.AutoSize = True
        ProfileInfoLabel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfileInfoLabel.ForeColor = SystemColors.Highlight
        ProfileInfoLabel.Location = New Point(17, 72)
        ProfileInfoLabel.Name = "ProfileInfoLabel"
        ProfileInfoLabel.Size = New Size(662, 28)
        ProfileInfoLabel.TabIndex = 1
        ProfileInfoLabel.Text = "VIEW AND MANAGE YOUR PERSONAL INFORMATION"
        ' 
        ' PatientDashboardPanel
        ' 
        PatientDashboardPanel.Controls.Add(TableLayoutPanel3)
        PatientDashboardPanel.Dock = DockStyle.Fill
        PatientDashboardPanel.Location = New Point(0, 0)
        PatientDashboardPanel.Name = "PatientDashboardPanel"
        PatientDashboardPanel.Size = New Size(1352, 912)
        PatientDashboardPanel.TabIndex = 2
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.BackColor = Color.Silver
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(UCWelcomePanel, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Margin = New Padding(25)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 17.8807945F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 82.1192F))
        TableLayoutPanel3.Size = New Size(1352, 912)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' UCWelcomePanel
        ' 
        UCWelcomePanel.BackColor = Color.White
        UCWelcomePanel.Controls.Add(ProfileInfoLabel)
        UCWelcomePanel.Controls.Add(UCProfileLabel)
        UCWelcomePanel.Dock = DockStyle.Fill
        UCWelcomePanel.Location = New Point(25, 25)
        UCWelcomePanel.Margin = New Padding(25)
        UCWelcomePanel.Name = "UCWelcomePanel"
        UCWelcomePanel.Size = New Size(1302, 113)
        UCWelcomePanel.TabIndex = 9
        ' 
        ' PatientDashBoard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        Controls.Add(PatientDashboardPanel)
        Name = "PatientDashBoard"
        Size = New Size(1352, 912)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        UCPersonalInfoPanel.ResumeLayout(False)
        UCPersonalInfoPanel.PerformLayout()
        UCAccountInformationPanel.ResumeLayout(False)
        UCAccountInformationPanel.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        PatientDashboardPanel.ResumeLayout(False)
        PatientDashboardPanel.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        UCWelcomePanel.ResumeLayout(False)
        UCWelcomePanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OverviewIDLabel As Label
    Friend WithEvents OverviewNameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UCPersonalInfoPanel As Panel
    Friend WithEvents UCAccountInformationPanel As Panel
    Friend WithEvents OverviewAddressLabel As Label
    Friend WithEvents OverviewGenderLabel As Label
    Friend WithEvents OverviewBirthdateLabel As Label
    Friend WithEvents OverviewContactLabel As Label
    Friend WithEvents OverviewEmailLabel As Label
    Friend WithEvents PersonalInfoLabel As Label
    Friend WithEvents BirthdateLabel As Label
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents CPNumberLabel As Label
    Friend WithEvents EMailLabel As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents AccountInfoLabel As Label
    Friend WithEvents BirthDateTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents ChangePassBtn As Button
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents CPNumberTextBox As TextBox
    Friend WithEvents EditLabel As Label
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents UCWelcomePanel As Panel
    Friend WithEvents PatientDashboardPanel As Panel
    Friend WithEvents ProfileInfoLabel As Label
    Friend WithEvents UCProfileLabel As Label

End Class
