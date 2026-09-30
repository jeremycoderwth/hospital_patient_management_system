Public Class BloodTestModal
    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BloodTestModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Rows.Add("WBC", "6.2", "10³/L", "9 - 11")
        DataGridView1.Rows.Add("RBC", "5.1", "10¹²/L", "34 - 6.5")
        DataGridView1.Rows.Add("Hb", "14", "g/dl", "12 - 18")
        DataGridView1.Rows.Add("HDL", "45", "mg/dl", "> 50")
        DataGridView1.Rows.Add("LDL", "81.00", "mg/dl", "< 50")
        DataGridView1.Rows.Add("BG", "95", "mg/dl", "65 - 100")

        DataGridView2.Rows.Add("NAME", "JEREMY GIBADA")
        DataGridView2.Rows.Add("AGE/GENDER", "67 years old / male")
        DataGridView2.Rows.Add("VISIT DATE", "date & time")
        DataGridView2.Rows.Add("VISIT TYPE", "BLOOD TEST")

        DataGridView3.Rows.Add("test name", "")
        DataGridView3.Rows.Add("reason", "")
        DataGridView3.Rows.Add("ordered by", "")
        DataGridView3.Rows.Add("scheduled date", "")
        DataGridView3.Rows.Add("released date", "")
        DataGridView3.Rows.Add("LAS", "")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick_3(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub
End Class