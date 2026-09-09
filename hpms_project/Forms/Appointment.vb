Public Class Appointment
    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvAppointments.Rows.Add(
        "December 10, 2026 10:30 AM",
        "Dr. OBREGON",
        "CHECKUP",
        "UPCOMING",
        "VIEW"
    )

        dgvAppointments.Rows.Add(
        "October 13, 2026 9:40 AM",
        "Dr. OBREGON",
        "FOLLOW UP",
        "UPCOMING",
        "VIEW"
    )

        dgvAppointments.Rows.Add(
        "November 8, 2026 1:30 PM",
        "Dr. GIBADA",
        "CONSULTATION",
        "PAST",
        "VIEW"
    )

        dgvAppointments.Rows.Add(
        "September 8, 2026 3:00 PM",
        "Dr. LUNA",
        "DENTAL CLEANING",
        "CANCELLED",
        "VIEW"
    )

        dgvAppointments.Rows.Add(
        "August 19, 2026 9:00 AM",
        "Dr. TOMINEZ",
        "MEDICAL",
        "PAST",
        "VIEW"
    )

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lb1Appointment.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lb1subtitle.Click

    End Sub

    Private Sub pnlAppointmentContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlAppointmentContent.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvAppointments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointments.CellContentClick

    End Sub
End Class