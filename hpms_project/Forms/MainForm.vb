Public Class MainForm
    Public Sub LoadUserControl(uc As UserControl)

        MainPanel.Controls.Clear()

        uc.Dock = DockStyle.Fill

        MainPanel.Controls.Add(uc)
        uc.BringToFront()
    End Sub
    Private Sub AppointmentPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub HealthSummaryPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BillOVPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BillOVPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MainPanel_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LeftSideBar_Paint(sender As Object, e As PaintEventArgs) Handles LeftSideBar.Paint

    End Sub

    Private Sub TopPanel_Paint(sender As Object, e As PaintEventArgs) Handles TopPanel.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles CostumerSupportPanel.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PeopelBtn_Click(sender As Object, e As EventArgs) Handles PeopelBtn.Click

    End Sub
    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles DashboardIcon.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles LogOutIcon.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles CostumerSuportLabel3.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserControl(New DefaultDashboard())
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardIcon.Click

        LoadUserControl(New DefaultDashboard())
    End Sub


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PeopleIcon.Click

    End Sub

    Private Sub HorizontalLine_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles LeftSideBarVerticalLine.Click

    End Sub

    Private Sub ProfilePictureIcon_Click(sender As Object, e As EventArgs) Handles ProfilePictureIcon.Click
        LoadUserControl(New PatientDashBoard())
    End Sub

    Private Sub NotifIcon_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NotifBtn.Click

    End Sub

    Private Sub MainPanel_Paint_2(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub DashboardBtn_Click_1(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        LoadUserControl(New DefaultDashboard())
    End Sub

    Private Sub BillsBtn_Click(sender As Object, e As EventArgs) Handles BillsBtn.Click
        LoadUserControl(New UCBillsAndPayment())
    End Sub
End Class