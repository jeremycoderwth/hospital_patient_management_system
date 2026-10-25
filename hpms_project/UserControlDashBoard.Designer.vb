<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlDashBoard
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
        UCWelcomePanel.Location = New Point(2, 2)
        UCWelcomePanel.Margin = New Padding(2, 2, 2, 2)
        UCWelcomePanel.Name = "UCWelcomePanel"
        UCWelcomePanel.Size = New Size(710, 65)
        UCWelcomePanel.TabIndex = 1
        ' 
        ' ProfileInfoLabel
        ' 
        ProfileInfoLabel.AutoSize = True
        ProfileInfoLabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProfileInfoLabel.ForeColor = SystemColors.Highlight
        ProfileInfoLabel.Location = New Point(12, 37)
        ProfileInfoLabel.Margin = New Padding(2, 0, 2, 0)
        ProfileInfoLabel.Name = "ProfileInfoLabel"
        ProfileInfoLabel.Size = New Size(300, 15)
        ProfileInfoLabel.TabIndex = 1
        ProfileInfoLabel.Text = "VIEW AND MANAGE YOUR PERSONAL INFORMATION"
        ' 
        ' UCProfileLabel
        ' 
        UCProfileLabel.AutoSize = True
        UCProfileLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UCProfileLabel.Location = New Point(12, 11)
        UCProfileLabel.Margin = New Padding(2, 0, 2, 0)
        UCProfileLabel.Name = "UCProfileLabel"
        UCProfileLabel.Size = New Size(63, 19)
        UCProfileLabel.TabIndex = 0
        UCProfileLabel.Text = "PROFILE"
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
        Panel1.Location = New Point(2, 71)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(328, 269)
        Panel1.TabIndex = 2
        ' 
        ' OverviewAddressLabel
        ' 
        OverviewAddressLabel.AutoSize = True
        OverviewAddressLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewAddressLabel.Location = New Point(22, 216)
        OverviewAddressLabel.Margin = New Padding(2, 0, 2, 0)
        OverviewAddressLabel.Name = "OverviewAddressLabel"
        OverviewAddressLabel.Size = New Size(61, 19)
        OverviewAddressLabel.TabIndex = 8
        OverviewAddressLabel.Text = "Address:"
        ' 
        ' OverviewGenderLabel
        ' 
        OverviewGenderLabel.AutoSize = True
        OverviewGenderLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewGenderLabel.Location = New Point(22, 193)
        OverviewGenderLabel.Margin = New Padding(2, 0, 2, 0)
        OverviewGenderLabel.Name = "OverviewGenderLabel"
        OverviewGenderLabel.Size = New Size(58, 19)
        OverviewGenderLabel.TabIndex = 7
        OverviewGenderLabel.Text = "Gender:"
        ' 
        ' OverviewBirthdateLabel
        ' 
        OverviewBirthdateLabel.AutoSize = True
        OverviewBirthdateLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewBirthdateLabel.Location = New Point(22, 171)
        OverviewBirthdateLabel.Margin = New Padding(2, 0, 2, 0)
        OverviewBirthdateLabel.Name = "OverviewBirthdateLabel"
        OverviewBirthdateLabel.Size = New Size(69, 19)
        OverviewBirthdateLabel.TabIndex = 6
        OverviewBirthdateLabel.Text = "Birthdate:"
        ' 
        ' OverviewContactLabel
        ' 
        OverviewContactLabel.AutoSize = True
        OverviewContactLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewContactLabel.Location = New Point(22, 149)
        OverviewContactLabel.Margin = New Padding(2, 0, 2, 0)
        OverviewContactLabel.Name = "OverviewContactLabel"
        OverviewContactLabel.Size = New Size(61, 19)
        OverviewContactLabel.TabIndex = 5
        OverviewContactLabel.Text = "Contact:"
        ' 
        ' OverviewEmailLabel
        ' 
        OverviewEmailLabel.AutoSize = True
        OverviewEmailLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewEmailLabel.Location = New Point(22, 126)
        OverviewEmailLabel.Margin = New Padding(2, 0, 2, 0)
        OverviewEmailLabel.Name = "OverviewEmailLabel"
        OverviewEmailLabel.Size = New Size(52, 19)
        OverviewEmailLabel.TabIndex = 3
        OverviewEmailLabel.Text = "E-mail:"
        ' 
        ' OverviewIDLabel
        ' 
        OverviewIDLabel.AutoSize = True
        OverviewIDLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewIDLabel.Location = New Point(95, 105)
        OverviewIDLabel.Margin = New Padding(2, 0, 2, 0)
        OverviewIDLabel.Name = "OverviewIDLabel"
        OverviewIDLabel.Size = New Size(30, 21)
        OverviewIDLabel.TabIndex = 2
        OverviewIDLabel.Text = "ID:"
        ' 
        ' OverviewNameLabel
        ' 
        OverviewNameLabel.AutoSize = True
        OverviewNameLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OverviewNameLabel.Location = New Point(95, 86)
        OverviewNameLabel.Margin = New Padding(2, 0, 2, 0)
        OverviewNameLabel.Name = "OverviewNameLabel"
        OverviewNameLabel.Size = New Size(57, 21)
        OverviewNameLabel.TabIndex = 1
        OverviewNameLabel.Text = "Name:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Location = New Point(111, 11)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(106, 73)
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
        UCPersonalInfoPanel.Location = New Point(334, 71)
        UCPersonalInfoPanel.Margin = New Padding(2, 2, 2, 2)
        UCPersonalInfoPanel.Name = "UCPersonalInfoPanel"
        UCPersonalInfoPanel.Size = New Size(378, 133)
        UCPersonalInfoPanel.TabIndex = 3
        ' 
        ' CPNumberTextBox
        ' 
        CPNumberTextBox.Location = New Point(101, 88)
        CPNumberTextBox.Margin = New Padding(2, 2, 2, 2)
        CPNumberTextBox.Name = "CPNumberTextBox"
        CPNumberTextBox.Size = New Size(237, 23)
        CPNumberTextBox.TabIndex = 10
        ' 
        ' BirthDateTextBox
        ' 
        BirthDateTextBox.Location = New Point(101, 65)
        BirthDateTextBox.Margin = New Padding(2, 2, 2, 2)
        BirthDateTextBox.Name = "BirthDateTextBox"
        BirthDateTextBox.Size = New Size(237, 23)
        BirthDateTextBox.TabIndex = 9
        ' 
        ' FullNameTextBox
        ' 
        FullNameTextBox.Location = New Point(101, 41)
        FullNameTextBox.Margin = New Padding(2, 2, 2, 2)
        FullNameTextBox.Name = "FullNameTextBox"
        FullNameTextBox.Size = New Size(237, 23)
        FullNameTextBox.TabIndex = 8
        ' 
        ' BirthdateLabel
        ' 
        BirthdateLabel.AutoSize = True
        BirthdateLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BirthdateLabel.Location = New Point(13, 62)
        BirthdateLabel.Margin = New Padding(2, 0, 2, 0)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New Size(84, 19)
        BirthdateLabel.TabIndex = 7
        BirthdateLabel.Text = "BIRTHDATE:"
        ' 
        ' FullNameLabel
        ' 
        FullNameLabel.AutoSize = True
        FullNameLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FullNameLabel.Location = New Point(13, 39)
        FullNameLabel.Margin = New Padding(2, 0, 2, 0)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New Size(87, 19)
        FullNameLabel.TabIndex = 6
        FullNameLabel.Text = "FULL NAME:"
        ' 
        ' PersonalInfoLabel
        ' 
        PersonalInfoLabel.AutoSize = True
        PersonalInfoLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PersonalInfoLabel.Location = New Point(13, 11)
        PersonalInfoLabel.Margin = New Padding(2, 0, 2, 0)
        PersonalInfoLabel.Name = "PersonalInfoLabel"
        PersonalInfoLabel.Size = New Size(162, 21)
        PersonalInfoLabel.TabIndex = 2
        PersonalInfoLabel.Text = "Personal Information"
        ' 
        ' CPNumberLabel
        ' 
        CPNumberLabel.AutoSize = True
        CPNumberLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CPNumberLabel.Location = New Point(13, 86)
        CPNumberLabel.Margin = New Padding(2, 0, 2, 0)
        CPNumberLabel.Name = "CPNumberLabel"
        CPNumberLabel.Size = New Size(91, 19)
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
        UCAccountInformationPanel.Location = New Point(334, 207)
        UCAccountInformationPanel.Margin = New Padding(2, 2, 2, 2)
        UCAccountInformationPanel.Name = "UCAccountInformationPanel"
        UCAccountInformationPanel.Size = New Size(378, 133)
        UCAccountInformationPanel.TabIndex = 4
        ' 
        ' EditLabel
        ' 
        EditLabel.AutoSize = True
        EditLabel.Cursor = Cursors.Hand
        EditLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditLabel.ForeColor = SystemColors.HotTrack
        EditLabel.Location = New Point(291, 13)
        EditLabel.Margin = New Padding(2, 0, 2, 0)
        EditLabel.Name = "EditLabel"
        EditLabel.Size = New Size(38, 21)
        EditLabel.TabIndex = 14
        EditLabel.Text = "Edit"
        ' 
        ' PassTextBox
        ' 
        PassTextBox.Location = New Point(99, 86)
        PassTextBox.Margin = New Padding(2, 2, 2, 2)
        PassTextBox.Name = "PassTextBox"
        PassTextBox.Size = New Size(237, 23)
        PassTextBox.TabIndex = 13
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(99, 63)
        EmailTextBox.Margin = New Padding(2, 2, 2, 2)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(237, 23)
        EmailTextBox.TabIndex = 12
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(101, 42)
        UsernameTextBox.Margin = New Padding(2, 2, 2, 2)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(237, 23)
        UsernameTextBox.TabIndex = 11
        ' 
        ' ChangePassBtn
        ' 
        ChangePassBtn.Location = New Point(216, 108)
        ChangePassBtn.Margin = New Padding(2, 2, 2, 2)
        ChangePassBtn.Name = "ChangePassBtn"
        ChangePassBtn.Size = New Size(120, 20)
        ChangePassBtn.TabIndex = 8
        ChangePassBtn.Text = "Change Password"
        ChangePassBtn.UseVisualStyleBackColor = True
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordLabel.Location = New Point(13, 88)
        PasswordLabel.Margin = New Padding(2, 0, 2, 0)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(85, 19)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "PASSWORD"
        ' 
        ' EMailLabel
        ' 
        EMailLabel.AutoSize = True
        EMailLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EMailLabel.Location = New Point(13, 65)
        EMailLabel.Margin = New Padding(2, 0, 2, 0)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New Size(58, 19)
        EMailLabel.TabIndex = 6
        EMailLabel.Text = "E-MAIL:"
        ' 
        ' UserNameLabel
        ' 
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserNameLabel.Location = New Point(13, 42)
        UserNameLabel.Margin = New Padding(2, 0, 2, 0)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New Size(86, 19)
        UserNameLabel.TabIndex = 4
        UserNameLabel.Text = "USERNAME:"
        ' 
        ' AccountInfoLabel
        ' 
        AccountInfoLabel.AutoSize = True
        AccountInfoLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AccountInfoLabel.Location = New Point(13, 13)
        AccountInfoLabel.Margin = New Padding(2, 0, 2, 0)
        AccountInfoLabel.Name = "AccountInfoLabel"
        AccountInfoLabel.Size = New Size(162, 21)
        AccountInfoLabel.TabIndex = 3
        AccountInfoLabel.Text = "Account Information"
        ' 
        ' UserControlDashBoard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        Controls.Add(UCAccountInformationPanel)
        Controls.Add(UCPersonalInfoPanel)
        Controls.Add(Panel1)
        Controls.Add(UCWelcomePanel)
        Margin = New Padding(2, 2, 2, 2)
        Name = "UserControlDashBoard"
        Size = New Size(714, 346)
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

End Class
