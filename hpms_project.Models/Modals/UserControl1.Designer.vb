<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
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
        titlelbl = New Label()
        subtitlelbl = New Label()
        appointmentpnl = New GroupBox()
        addappointmentlbl = New Label()
        doctorlbl = New Label()
        appointmenttypelbl = New Label()
        appointmenttypecmb = New ComboBox()
        datelbl = New Label()
        datedtp = New DateTimePicker()
        durationlbl = New Label()
        durationcmb = New ComboBox()
        reasonlbl = New Label()
        reasontxt = New RichTextBox()
        doctorcmb = New ComboBox()
        notiflbl = New Label()
        notifchk = New CheckBox()
        cancelbtn = New Button()
        savebtn = New Button()
        appointmentpnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' titlelbl
        ' 
        titlelbl.Font = New Font("Lucida Sans Unicode", 45F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titlelbl.ForeColor = SystemColors.ActiveCaptionText
        titlelbl.Location = New Point(27, 9)
        titlelbl.Name = "titlelbl"
        titlelbl.Size = New Size(438, 80)
        titlelbl.TabIndex = 0
        titlelbl.Text = "Appointment"
        titlelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' subtitlelbl
        ' 
        subtitlelbl.AutoSize = True
        subtitlelbl.Font = New Font("Lucida Sans Unicode", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subtitlelbl.ForeColor = Color.Black
        subtitlelbl.Location = New Point(45, 101)
        subtitlelbl.Name = "subtitlelbl"
        subtitlelbl.Size = New Size(582, 34)
        subtitlelbl.TabIndex = 1
        subtitlelbl.Text = "view your upcoming and past appointment"
        ' 
        ' appointmentpnl
        ' 
        appointmentpnl.BackgroundImageLayout = ImageLayout.Center
        appointmentpnl.Controls.Add(savebtn)
        appointmentpnl.Controls.Add(cancelbtn)
        appointmentpnl.Controls.Add(notifchk)
        appointmentpnl.Controls.Add(notiflbl)
        appointmentpnl.Controls.Add(doctorcmb)
        appointmentpnl.Controls.Add(reasontxt)
        appointmentpnl.Controls.Add(reasonlbl)
        appointmentpnl.Controls.Add(durationcmb)
        appointmentpnl.Controls.Add(durationlbl)
        appointmentpnl.Controls.Add(datedtp)
        appointmentpnl.Controls.Add(datelbl)
        appointmentpnl.Controls.Add(appointmenttypecmb)
        appointmentpnl.Controls.Add(appointmenttypelbl)
        appointmentpnl.Controls.Add(doctorlbl)
        appointmentpnl.Controls.Add(addappointmentlbl)
        appointmentpnl.FlatStyle = FlatStyle.Flat
        appointmentpnl.Location = New Point(45, 153)
        appointmentpnl.Name = "appointmentpnl"
        appointmentpnl.Size = New Size(1264, 575)
        appointmentpnl.TabIndex = 2
        appointmentpnl.TabStop = False
        ' 
        ' addappointmentlbl
        ' 
        addappointmentlbl.AutoSize = True
        addappointmentlbl.BackColor = Color.Transparent
        addappointmentlbl.BorderStyle = BorderStyle.FixedSingle
        addappointmentlbl.Font = New Font("Lucida Sans Unicode", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addappointmentlbl.ForeColor = Color.Black
        addappointmentlbl.Location = New Point(0, 9)
        addappointmentlbl.Name = "addappointmentlbl"
        addappointmentlbl.Size = New Size(309, 41)
        addappointmentlbl.TabIndex = 0
        addappointmentlbl.Text = "Add Appointment"
        ' 
        ' doctorlbl
        ' 
        doctorlbl.AutoSize = True
        doctorlbl.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        doctorlbl.Location = New Point(16, 68)
        doctorlbl.Name = "doctorlbl"
        doctorlbl.Size = New Size(567, 28)
        doctorlbl.TabIndex = 1
        doctorlbl.Text = "FILL OUT FORM BELOW TO REQUEST DOCTOR *"
        ' 
        ' appointmenttypelbl
        ' 
        appointmenttypelbl.AutoSize = True
        appointmenttypelbl.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        appointmenttypelbl.Location = New Point(705, 68)
        appointmenttypelbl.Name = "appointmenttypelbl"
        appointmenttypelbl.Size = New Size(265, 28)
        appointmenttypelbl.TabIndex = 3
        appointmenttypelbl.Text = "APPOINTMENT TYPE *"
        ' 
        ' appointmenttypecmb
        ' 
        appointmenttypecmb.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        appointmenttypecmb.FormattingEnabled = True
        appointmenttypecmb.Location = New Point(705, 109)
        appointmenttypecmb.Name = "appointmenttypecmb"
        appointmenttypecmb.Size = New Size(347, 24)
        appointmenttypecmb.TabIndex = 4
        appointmenttypecmb.Text = "APPOINTMENT TYPE *"
        ' 
        ' datelbl
        ' 
        datelbl.AutoSize = True
        datelbl.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datelbl.Location = New Point(16, 165)
        datelbl.Name = "datelbl"
        datelbl.Size = New Size(95, 28)
        datelbl.TabIndex = 5
        datelbl.Text = "DATE *"
        ' 
        ' datedtp
        ' 
        datedtp.Font = New Font("Lucida Sans Unicode", 10F)
        datedtp.Location = New Point(16, 196)
        datedtp.Name = "datedtp"
        datedtp.Size = New Size(321, 28)
        datedtp.TabIndex = 6
        ' 
        ' durationlbl
        ' 
        durationlbl.AutoSize = True
        durationlbl.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        durationlbl.Location = New Point(705, 165)
        durationlbl.Name = "durationlbl"
        durationlbl.Size = New Size(158, 28)
        durationlbl.TabIndex = 8
        durationlbl.Text = "DURATION *"
        ' 
        ' durationcmb
        ' 
        durationcmb.Font = New Font("Lucida Sans Unicode", 10F)
        durationcmb.FormattingEnabled = True
        durationcmb.Location = New Point(705, 199)
        durationcmb.Name = "durationcmb"
        durationcmb.Size = New Size(347, 24)
        durationcmb.TabIndex = 9
        ' 
        ' reasonlbl
        ' 
        reasonlbl.AutoSize = True
        reasonlbl.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        reasonlbl.Location = New Point(16, 248)
        reasonlbl.Name = "reasonlbl"
        reasonlbl.Size = New Size(214, 28)
        reasonlbl.TabIndex = 10
        reasonlbl.Text = "REASON / NOTES"
        ' 
        ' reasontxt
        ' 
        reasontxt.Location = New Point(16, 279)
        reasontxt.Name = "reasontxt"
        reasontxt.Size = New Size(713, 131)
        reasontxt.TabIndex = 11
        reasontxt.Text = ""
        ' 
        ' doctorcmb
        ' 
        doctorcmb.Font = New Font("Lucida Sans Unicode", 10F)
        doctorcmb.FormattingEnabled = True
        doctorcmb.Location = New Point(16, 109)
        doctorcmb.Name = "doctorcmb"
        doctorcmb.Size = New Size(321, 24)
        doctorcmb.TabIndex = 12
        doctorcmb.Text = "SELECT A DOCTOR"
        ' 
        ' notiflbl
        ' 
        notiflbl.AutoSize = True
        notiflbl.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        notiflbl.Location = New Point(16, 428)
        notiflbl.Name = "notiflbl"
        notiflbl.Size = New Size(154, 28)
        notiflbl.TabIndex = 13
        notiflbl.Text = "SEND NOTIF"
        ' 
        ' notifchk
        ' 
        notifchk.AutoSize = True
        notifchk.Font = New Font("Lucida Sans Unicode", 10F)
        notifchk.Location = New Point(26, 480)
        notifchk.Name = "notifchk"
        notifchk.Size = New Size(208, 21)
        notifchk.TabIndex = 14
        notifchk.Text = "YES, SEND NOTIFICATIONS"
        notifchk.UseVisualStyleBackColor = True
        ' 
        ' cancelbtn
        ' 
        cancelbtn.Font = New Font("Lucida Sans Unicode", 12F)
        cancelbtn.ImageAlign = ContentAlignment.TopLeft
        cancelbtn.Location = New Point(829, 480)
        cancelbtn.Name = "cancelbtn"
        cancelbtn.Size = New Size(126, 30)
        cancelbtn.TabIndex = 15
        cancelbtn.Text = "cancel"
        cancelbtn.UseVisualStyleBackColor = True
        ' 
        ' savebtn
        ' 
        savebtn.AutoSize = True
        savebtn.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        savebtn.Location = New Point(1003, 480)
        savebtn.Name = "savebtn"
        savebtn.Size = New Size(146, 30)
        savebtn.TabIndex = 16
        savebtn.Text = "save application"
        savebtn.UseVisualStyleBackColor = True
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(appointmentpnl)
        Controls.Add(subtitlelbl)
        Controls.Add(titlelbl)
        Margin = New Padding(10, 10, 10, 3)
        Name = "UserControl1"
        Size = New Size(1375, 731)
        appointmentpnl.ResumeLayout(False)
        appointmentpnl.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents subtitlelbl As Label
    Friend WithEvents appointmentpnl As GroupBox
    Friend WithEvents addappointmentlbl As Label
    Friend WithEvents doctorlbl As Label
    Friend WithEvents appointmenttypelbl As Label
    Friend WithEvents appointmenttypecmb As ComboBox
    Friend WithEvents datedtp As DateTimePicker
    Friend WithEvents datelbl As Label
    Friend WithEvents durationcmb As ComboBox
    Friend WithEvents durationlbl As Label
    Friend WithEvents reasontxt As RichTextBox
    Friend WithEvents reasonlbl As Label
    Friend WithEvents doctorcmb As ComboBox
    Friend WithEvents notifchk As CheckBox
    Friend WithEvents notiflbl As Label
    Friend WithEvents savebtn As Button
    Friend WithEvents cancelbtn As Button

End Class
