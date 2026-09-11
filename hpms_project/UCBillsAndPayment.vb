Public Class UCBillsAndPayment
    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles BillsAndPaymentPanel.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles BillsAndPaymentMainPanel.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles allbillsbtn.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles serviceChargesPanel.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles billsDataStatuslbl.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BillsHeaderPanel_Paint(sender As Object, e As PaintEventArgs) Handles BillsHeaderPanel.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles serviceChargesDataGridView.CellContentClick

    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UCBillsAndPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Stretch Description to take remaining space, keep Amount right-aligned
        serviceChargesDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        serviceChargesDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ' Increase default row height for better vertical spacing
        serviceChargesDataGridView.RowTemplate.Height = 33


        ' Hide scrollbars if unnecessary
        serviceChargesDataGridView.ScrollBars = ScrollBars.None
        ' Add normal item rows
        serviceChargesDataGridView.Rows.Add("CONSUATIONAL FEE", "₱ 200.00")
        serviceChargesDataGridView.Rows.Add("CBC", "₱ 100.00")
        serviceChargesDataGridView.Rows.Add("X-RAY", "₱ 200.00")
        serviceChargesDataGridView.Rows.Add("LABORATORY FEE", "₱ 200.00")

        ' Add total row
        Dim totalRowIndex As Integer = serviceChargesDataGridView.Rows.Add("total ammount:", "₱ 700.00")
        serviceChargesDataGridView.Rows(totalRowIndex).DefaultCellStyle.Font = New Font("Lucida Sans Unicode", 12, FontStyle.Bold)

        ' Increase height of the last item row to push the total row further down
        Dim lastItemIndex As Integer = 4 ' Index of LABORATORY FEE
        serviceChargesDataGridView.Rows(lastItemIndex).Height = 50

        paymentInfoDataGridView.ScrollBars = ScrollBars.None
        paymentInfoDataGridView.Rows.Add("PAYMENT STATUS:", "UNPAID")
        paymentInfoDataGridView.Rows.Add("AMOUNT PAID:", "₱ 0.00")
        paymentInfoDataGridView.Rows.Add("BALANCE:", "₱ 700.00")

        paymentInfoDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        paymentInfoDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ' Increase default row height for better vertical spacing
        paymentInfoDataGridView.RowTemplate.Height = 33

        ' Get the status string from the first row, second column
        Dim statusValue As String = paymentInfoDataGridView.Rows(0).Cells(1).Value.ToString().Trim().ToUpper()

        ' Apply conditional coloring
        If statusValue = "UNPAID" Then
            paymentInfoDataGridView.Rows(0).Cells(1).Style.ForeColor = Color.Red
            paymentInfoDataGridView.Rows(0).Cells(1).Style.SelectionForeColor = Color.Red
        ElseIf statusValue = "PAID" Then
            paymentInfoDataGridView.Rows(0).Cells(1).Style.ForeColor = Color.Green
            paymentInfoDataGridView.Rows(0).Cells(1).Style.SelectionForeColor = Color.Green
        End If

        billsAndPaymentDataGridView.RowTemplate.Height = 45
        billsAndPaymentDataGridView.ScrollBars = ScrollBars.None
        billsAndPaymentDataGridView.Rows.Add("DEC. 10 2026:", "₱ 700.00", "UNPAID")
        billsAndPaymentDataGridView.Rows.Add("OCT. 13 2026:", "₱ 560.00", "UNPAID")
        billsAndPaymentDataGridView.Rows.Add("NOV. 8 2026:", "₱ 1,060.00", "PAID")
        billsAndPaymentDataGridView.Rows.Add("SEPT. 8 2026:", "₱ 840.00", "UNPAID")
        billsAndPaymentDataGridView.Rows.Add("AUG. 19 2026:", "₱ 970.00", "PAID")

        billsAndPaymentDataGridView.Columns(0).FillWeight = 30
        billsAndPaymentDataGridView.Columns(1).FillWeight = 30
        billsAndPaymentDataGridView.Columns(2).FillWeight = 25 ' STATUS
        billsAndPaymentDataGridView.Columns(3).FillWeight = 15 ' VIEW


        For Each row As DataGridViewRow In billsAndPaymentDataGridView.Rows
            If row.IsNewRow Then Continue For


            statusValue = row.Cells(2).Value.ToString().Trim().ToUpper()

            If statusValue = "UNPAID" Then
                row.Cells(2).Style.ForeColor = Color.Red
                row.Cells(2).Style.SelectionForeColor = Color.Red
            ElseIf statusValue = "PAID" Then
                row.Cells(2).Style.ForeColor = Color.Green
                row.Cells(2).Style.SelectionForeColor = Color.Green
            End If
        Next

        serviceChargesDataGridView.ClearSelection()
        paymentInfoDataGridView.ClearSelection()
        billsAndPaymentDataGridView.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles serviceChargesDataGridView.CellContentClick


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles MainTableLayoutPanel.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles paymentInfoPanel.Paint

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles billsAndPaymentDataGridView.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles BillsAndPaymentSublbl.Click

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles mainSubTableLayoutPanel.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles unpaidbtn.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles paidbtn.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles paymentInfoDataGridView.CellContentClick

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles makePaymentbtn.Click

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles pageInfoAndButtonsPanel.Paint

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles searchTextbox.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles currentPagebtn.Click

    End Sub
End Class
