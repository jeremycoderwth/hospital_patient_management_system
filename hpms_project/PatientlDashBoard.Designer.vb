<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientlDashBoard
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
        UCWelcomePanel = New Panel()
        ProfileInfoLabel = New Label()
        UCProfileLabel = New Label()
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
        ProfileEmailLabel = New Label()
        ProfileContactLabel = New Label()
        ProfileBirthdateLabel = New Label()
        ProfileGenderLabel = New Label()
        ProfileAddressLabel = New Label()
        Label1 = New Label()
        Label2 = New Label()
        UCWelcomePanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        UCPersonalInfoPanel.SuspendLayout()
        UCAccountInformationPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' UCWelcomePanel
        ' 
        UCWelcomePanel.BackColor = Color.White
        UCWelcomePanel.Controls.Add(ProfileInfoLabel)
        UCWelcomePanel.Controls.Add(UCProfileLabel)
        UCWelcomePanel.Location = New Point(3, 3)
        UCWelcomePanel.Name = "UCWelcomePanel"
        UCWelcomePanel.Size = New Size(1014, 109)
        UCWelcomePanel.TabIndex = 1
        ' 
        ' ProfileInfoLabel
        ' 
        ProfileInfoLabel.AutoSize = True
        ProfileInfoLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfileInfoLabel.ForeColor = SystemColors.Highlight
        ProfileInfoLabel.Location = New Point(17, 62)
        ProfileInfoLabel.Name = "ProfileInfoLabel"
        ProfileInfoLabel.Size = New Size(458, 25)
        ProfileInfoLabel.TabIndex = 1
        ProfileInfoLabel.Text = "VIEW AND MANAGE YOUR PERSONAL INFORMATION"
        ' 
        ' UCProfileLabel
        ' 
        UCProfileLabel.AutoSize = True
        UCProfileLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UCProfileLabel.Location = New Point(17, 19)
        UCProfileLabel.Name = "UCProfileLabel"
        UCProfileLabel.Size = New Size(89, 28)
        UCProfileLabel.TabIndex = 0
        UCProfileLabel.Text = "PROFILE"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ProfileAddressLabel)
        Panel1.Controls.Add(ProfileGenderLabel)
        Panel1.Controls.Add(ProfileBirthdateLabel)
        Panel1.Controls.Add(ProfileContactLabel)
        Panel1.Controls.Add(ProfileEmailLabel)
        Panel1.Controls.Add(OverviewAddressLabel)
        Panel1.Controls.Add(OverviewGenderLabel)
        Panel1.Controls.Add(OverviewBirthdateLabel)
        Panel1.Controls.Add(OverviewContactLabel)
        Panel1.Controls.Add(OverviewEmailLabel)
        Panel1.Controls.Add(OverviewIDLabel)
        Panel1.Controls.Add(OverviewNameLabel)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(3, 118)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(468, 448)
        Panel1.TabIndex = 2
        ' 
        ' OverviewAddressLabel
        ' 
        OverviewAddressLabel.AutoSize = True
        OverviewAddressLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewAddressLabel.Location = New Point(31, 360)
        OverviewAddressLabel.Name = "OverviewAddressLabel"
        OverviewAddressLabel.Size = New Size(90, 28)
        OverviewAddressLabel.TabIndex = 8
        OverviewAddressLabel.Text = "Address:"
        ' 
        ' OverviewGenderLabel
        ' 
        OverviewGenderLabel.AutoSize = True
        OverviewGenderLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewGenderLabel.Location = New Point(31, 322)
        OverviewGenderLabel.Name = "OverviewGenderLabel"
        OverviewGenderLabel.Size = New Size(85, 28)
        OverviewGenderLabel.TabIndex = 7
        OverviewGenderLabel.Text = "Gender:"
        ' 
        ' OverviewBirthdateLabel
        ' 
        OverviewBirthdateLabel.AutoSize = True
        OverviewBirthdateLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewBirthdateLabel.Location = New Point(31, 285)
        OverviewBirthdateLabel.Name = "OverviewBirthdateLabel"
        OverviewBirthdateLabel.Size = New Size(101, 28)
        OverviewBirthdateLabel.TabIndex = 6
        OverviewBirthdateLabel.Text = "Birthdate:"
        ' 
        ' OverviewContactLabel
        ' 
        OverviewContactLabel.AutoSize = True
        OverviewContactLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewContactLabel.Location = New Point(31, 248)
        OverviewContactLabel.Name = "OverviewContactLabel"
        OverviewContactLabel.Size = New Size(86, 28)
        OverviewContactLabel.TabIndex = 5
        OverviewContactLabel.Text = "Contact:"
        ' 
        ' OverviewEmailLabel
        ' 
        OverviewEmailLabel.AutoSize = True
        OverviewEmailLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewEmailLabel.Location = New Point(31, 210)
        OverviewEmailLabel.Name = "OverviewEmailLabel"
        OverviewEmailLabel.Size = New Size(73, 28)
        OverviewEmailLabel.TabIndex = 3
        OverviewEmailLabel.Text = "E-mail:"
        ' 
        ' OverviewIDLabel
        ' 
        OverviewIDLabel.AutoSize = True
        OverviewIDLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewIDLabel.Location = New Point(136, 175)
        OverviewIDLabel.Name = "OverviewIDLabel"
        OverviewIDLabel.Size = New Size(44, 32)
        OverviewIDLabel.TabIndex = 2
        OverviewIDLabel.Text = "ID:"
        ' 
        ' OverviewNameLabel
        ' 
        OverviewNameLabel.AutoSize = True
        OverviewNameLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewNameLabel.Location = New Point(136, 143)
        OverviewNameLabel.Name = "OverviewNameLabel"
        OverviewNameLabel.Size = New Size(85, 32)
        OverviewNameLabel.TabIndex = 1
        OverviewNameLabel.Text = "Name:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(159, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 122)
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
        UCPersonalInfoPanel.Location = New Point(477, 118)
        UCPersonalInfoPanel.Name = "UCPersonalInfoPanel"
        UCPersonalInfoPanel.Size = New Size(540, 221)
        UCPersonalInfoPanel.TabIndex = 3
        ' 
        ' CPNumberTextBox
        ' 
        CPNumberTextBox.Location = New Point(144, 146)
        CPNumberTextBox.Name = "CPNumberTextBox"
        CPNumberTextBox.Size = New Size(337, 31)
        CPNumberTextBox.TabIndex = 10
        ' 
        ' BirthDateTextBox
        ' 
        BirthDateTextBox.Location = New Point(144, 109)
        BirthDateTextBox.Name = "BirthDateTextBox"
        BirthDateTextBox.Size = New Size(337, 31)
        BirthDateTextBox.TabIndex = 9
        ' 
        ' FullNameTextBox
        ' 
        FullNameTextBox.Location = New Point(144, 69)
        FullNameTextBox.Name = "FullNameTextBox"
        FullNameTextBox.Size = New Size(337, 31)
        FullNameTextBox.TabIndex = 8
        ' 
        ' BirthdateLabel
        ' 
        BirthdateLabel.AutoSize = True
        BirthdateLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BirthdateLabel.Location = New Point(18, 103)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New Size(120, 28)
        BirthdateLabel.TabIndex = 7
        BirthdateLabel.Text = "BIRTHDATE:"
        ' 
        ' FullNameLabel
        ' 
        FullNameLabel.AutoSize = True
        FullNameLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FullNameLabel.Location = New Point(18, 65)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New Size(123, 28)
        FullNameLabel.TabIndex = 6
        FullNameLabel.Text = "FULL NAME:"
        ' 
        ' PersonalInfoLabel
        ' 
        PersonalInfoLabel.AutoSize = True
        PersonalInfoLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PersonalInfoLabel.Location = New Point(18, 18)
        PersonalInfoLabel.Name = "PersonalInfoLabel"
        PersonalInfoLabel.Size = New Size(242, 32)
        PersonalInfoLabel.TabIndex = 2
        PersonalInfoLabel.Text = "Personal Information"
        ' 
        ' CPNumberLabel
        ' 
        CPNumberLabel.AutoSize = True
        CPNumberLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CPNumberLabel.Location = New Point(18, 143)
        CPNumberLabel.Name = "CPNumberLabel"
        CPNumberLabel.Size = New Size(128, 28)
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
        UCAccountInformationPanel.Location = New Point(477, 345)
        UCAccountInformationPanel.Name = "UCAccountInformationPanel"
        UCAccountInformationPanel.Size = New Size(540, 221)
        UCAccountInformationPanel.TabIndex = 4
        ' 
        ' EditLabel
        ' 
        EditLabel.AutoSize = True
        EditLabel.Cursor = Cursors.Hand
        EditLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditLabel.ForeColor = SystemColors.HotTrack
        EditLabel.Location = New Point(416, 21)
        EditLabel.Name = "EditLabel"
        EditLabel.Size = New Size(55, 32)
        EditLabel.TabIndex = 14
        EditLabel.Text = "Edit"
        ' 
        ' PassTextBox
        ' 
        PassTextBox.Location = New Point(142, 143)
        PassTextBox.Name = "PassTextBox"
        PassTextBox.Size = New Size(337, 31)
        PassTextBox.TabIndex = 13
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(142, 105)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(337, 31)
        EmailTextBox.TabIndex = 12
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(144, 70)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(337, 31)
        UsernameTextBox.TabIndex = 11
        ' 
        ' ChangePassBtn
        ' 
        ChangePassBtn.Location = New Point(308, 180)
        ChangePassBtn.Name = "ChangePassBtn"
        ChangePassBtn.Size = New Size(171, 34)
        ChangePassBtn.TabIndex = 8
        ChangePassBtn.Text = "Change Password"
        ChangePassBtn.UseVisualStyleBackColor = True
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordLabel.Location = New Point(18, 146)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(118, 28)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "PASSWORD"
        ' 
        ' EMailLabel
        ' 
        EMailLabel.AutoSize = True
        EMailLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EMailLabel.Location = New Point(18, 108)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New Size(82, 28)
        EMailLabel.TabIndex = 6
        EMailLabel.Text = "E-MAIL:"
        ' 
        ' UserNameLabel
        ' 
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserNameLabel.Location = New Point(18, 70)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New Size(120, 28)
        UserNameLabel.TabIndex = 4
        UserNameLabel.Text = "USERNAME:"
        ' 
        ' AccountInfoLabel
        ' 
        AccountInfoLabel.AutoSize = True
        AccountInfoLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AccountInfoLabel.Location = New Point(18, 21)
        AccountInfoLabel.Name = "AccountInfoLabel"
        AccountInfoLabel.Size = New Size(239, 32)
        AccountInfoLabel.TabIndex = 3
        AccountInfoLabel.Text = "Account Information"
        ' 
        ' ProfileEmailLabel
        ' 
        ProfileEmailLabel.AutoSize = True
        ProfileEmailLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ProfileEmailLabel.Location = New Point(101, 213)
        ProfileEmailLabel.Name = "ProfileEmailLabel"
        ProfileEmailLabel.Size = New Size(110, 25)
        ProfileEmailLabel.TabIndex = 9
        ProfileEmailLabel.Text = "ProfileEmail"
        ' 
        ' ProfileContactLabel
        ' 
        ProfileContactLabel.AutoSize = True
        ProfileContactLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ProfileContactLabel.Location = New Point(123, 251)
        ProfileContactLabel.Name = "ProfileContactLabel"
        ProfileContactLabel.Size = New Size(139, 25)
        ProfileContactLabel.TabIndex = 10
        ProfileContactLabel.Text = "ContactNumber"
        ' 
        ' ProfileBirthdateLabel
        ' 
        ProfileBirthdateLabel.AutoSize = True
        ProfileBirthdateLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ProfileBirthdateLabel.Location = New Point(136, 288)
        ProfileBirthdateLabel.Name = "ProfileBirthdateLabel"
        ProfileBirthdateLabel.Size = New Size(146, 25)
        ProfileBirthdateLabel.TabIndex = 11
        ProfileBirthdateLabel.Text = "January 20, 2003"
        ' 
        ' ProfileGenderLabel
        ' 
        ProfileGenderLabel.AutoSize = True
        ProfileGenderLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ProfileGenderLabel.Location = New Point(122, 325)
        ProfileGenderLabel.Name = "ProfileGenderLabel"
        ProfileGenderLabel.Size = New Size(57, 25)
        ProfileGenderLabel.TabIndex = 12
        ProfileGenderLabel.Text = "Bakal"
        ' 
        ' ProfileAddressLabel
        ' 
        ProfileAddressLabel.AutoSize = True
        ProfileAddressLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ProfileAddressLabel.Location = New Point(122, 363)
        ProfileAddressLabel.Name = "ProfileAddressLabel"
        ProfileAddressLabel.Size = New Size(161, 25)
        ProfileAddressLabel.TabIndex = 13
        ProfileAddressLabel.Text = "Bandang Kanluran"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(219, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 28)
        Label1.TabIndex = 14
        Label1.Text = "Sample Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(186, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 28)
        Label2.TabIndex = 15
        Label2.Text = "!92168922"
        ' 
        ' UserControlDashBoard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        Controls.Add(UCAccountInformationPanel)
        Controls.Add(UCPersonalInfoPanel)
        Controls.Add(Panel1)
        Controls.Add(UCWelcomePanel)
        Name = "UserControlDashBoard"
        Size = New Size(1020, 577)
        UCWelcomePanel.ResumeLayout(False)
        UCWelcomePanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        UCPersonalInfoPanel.ResumeLayout(False)
        UCPersonalInfoPanel.PerformLayout()
        UCAccountInformationPanel.ResumeLayout(False)
        UCAccountInformationPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents UCWelcomePanel As Panel
    Friend WithEvents UCProfileLabel As Label
    Friend WithEvents ProfileInfoLabel As Label
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
    Friend WithEvents ProfileContactLabel As Label
    Friend WithEvents ProfileEmailLabel As Label
    Friend WithEvents ProfileAddressLabel As Label
    Friend WithEvents ProfileGenderLabel As Label
    Friend WithEvents ProfileBirthdateLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
