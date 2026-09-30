Public Class MedicalRecords

    Private Sub MedicalRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvMedicalRecords.Rows.Add("DEC. 10 2026", "CONSULTATION", "FEVER, COUGH, SORE THROAT", "COMPLETED", "VIEW >")
        dgvMedicalRecords.Rows.Add("NOV. 8 2026", "LAB TEST", "URINALYSIS", "COMPLETED", "VIEW >")
        dgvMedicalRecords.Rows.Add("OCT. 13 2026", "CONSULTATION", "GENERAL CHECK UP", "COMPLETED", "VIEW >")
        dgvMedicalRecords.Rows.Add("SEPT. 8 2026", "CONSULTATION", "CHEST X-RAY", "COMPLETED", "VIEW >")
        dgvMedicalRecords.Rows.Add("AUG. 19 2026", "LAB TEST", "BLOOD TEST", "PENDING", "VIEW >")
    End Sub
End Class