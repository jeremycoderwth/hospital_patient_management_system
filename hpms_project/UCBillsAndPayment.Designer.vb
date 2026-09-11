<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBillsAndPayment
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
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BillsAndPaymentPanel = New Panel()
        MainTableLayoutPanel = New TableLayoutPanel()
        BillsHeaderPanel = New Panel()
        BillsAndPaymentSublbl = New Label()
        BillsAndPaymentHeaderlbl = New Label()
        mainSubTableLayoutPanel = New TableLayoutPanel()
        billsDataServiceAndPaymentInfoPanel = New Panel()
        paymentInfoPanel = New Panel()
        Panel9 = New Panel()
        makePaymentbtn = New Button()
        paymentInfoDataGridView = New DataGridView()
        columnPaymentInformation = New DataGridViewTextBoxColumn()
        columnPaymentValue = New DataGridViewTextBoxColumn()
        paymentInfoHeaderlbl = New Label()
        serviceChargesPanel = New Panel()
        serviceChargesDataGridView = New DataGridView()
        columnDescription = New DataGridViewTextBoxColumn()
        columnAmount = New DataGridViewTextBoxColumn()
        serviceChargesUnderlinelbl = New Label()
        serviceChargeslbl = New Label()
        billsDataPanel = New Panel()
        billsDataTableLayoutPanel = New TableLayoutPanel()
        billsDataUserStatuslbl = New Label()
        billsDataStatuslbl = New Label()
        billsDataUserDatelbl = New Label()
        billsDataDatelbl = New Label()
        billsDataUnderlinelbl = New Label()
        billsDatalbl = New Label()
        BillsAndPaymentMainPanel = New Panel()
        searchBarPanel = New Panel()
        searchTextbox = New TextBox()
        SearchIcon = New PictureBox()
        billsAndPaymentDataGridView = New DataGridView()
        columnDate = New DataGridViewTextBoxColumn()
        columnTotalAmount = New DataGridViewTextBoxColumn()
        columnStatus = New DataGridViewTextBoxColumn()
        columnView = New DataGridViewLinkColumn()
        billsButtonPanel = New Panel()
        buttonUnderlinelbl = New Label()
        allbillsbtn = New Button()
        unpaidbtn = New Button()
        paidbtn = New Button()
        pageInfoAndButtonsPanel = New Panel()
        nextbtn = New Button()
        currentPagebtn = New Button()
        prevbtn = New Button()
        showCurrentPagelbl = New Label()
        BillsAndPaymentPanel.SuspendLayout()
        MainTableLayoutPanel.SuspendLayout()
        BillsHeaderPanel.SuspendLayout()
        mainSubTableLayoutPanel.SuspendLayout()
        billsDataServiceAndPaymentInfoPanel.SuspendLayout()
        paymentInfoPanel.SuspendLayout()
        Panel9.SuspendLayout()
        CType(paymentInfoDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        serviceChargesPanel.SuspendLayout()
        CType(serviceChargesDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        billsDataPanel.SuspendLayout()
        billsDataTableLayoutPanel.SuspendLayout()
        BillsAndPaymentMainPanel.SuspendLayout()
        searchBarPanel.SuspendLayout()
        CType(SearchIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(billsAndPaymentDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        billsButtonPanel.SuspendLayout()
        pageInfoAndButtonsPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' BillsAndPaymentPanel
        ' 
        BillsAndPaymentPanel.BackColor = Color.Silver
        BillsAndPaymentPanel.Controls.Add(MainTableLayoutPanel)
        BillsAndPaymentPanel.Dock = DockStyle.Fill
        BillsAndPaymentPanel.Location = New Point(0, 0)
        BillsAndPaymentPanel.Name = "BillsAndPaymentPanel"
        BillsAndPaymentPanel.Size = New Size(1352, 912)
        BillsAndPaymentPanel.TabIndex = 3
        ' 
        ' MainTableLayoutPanel
        ' 
        MainTableLayoutPanel.ColumnCount = 1
        MainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        MainTableLayoutPanel.Controls.Add(BillsHeaderPanel, 0, 0)
        MainTableLayoutPanel.Controls.Add(mainSubTableLayoutPanel, 0, 1)
        MainTableLayoutPanel.Dock = DockStyle.Fill
        MainTableLayoutPanel.Location = New Point(0, 0)
        MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        MainTableLayoutPanel.RowCount = 2
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.8904686F))
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 87.1095352F))
        MainTableLayoutPanel.Size = New Size(1352, 912)
        MainTableLayoutPanel.TabIndex = 6
        ' 
        ' BillsHeaderPanel
        ' 
        BillsHeaderPanel.Controls.Add(BillsAndPaymentSublbl)
        BillsHeaderPanel.Controls.Add(BillsAndPaymentHeaderlbl)
        BillsHeaderPanel.Dock = DockStyle.Fill
        BillsHeaderPanel.Location = New Point(25, 3)
        BillsHeaderPanel.Margin = New Padding(25, 3, 3, 3)
        BillsHeaderPanel.Name = "BillsHeaderPanel"
        BillsHeaderPanel.Size = New Size(1324, 111)
        BillsHeaderPanel.TabIndex = 5
        ' 
        ' BillsAndPaymentSublbl
        ' 
        BillsAndPaymentSublbl.AutoSize = True
        BillsAndPaymentSublbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BillsAndPaymentSublbl.Location = New Point(29, 70)
        BillsAndPaymentSublbl.Name = "BillsAndPaymentSublbl"
        BillsAndPaymentSublbl.Size = New Size(764, 28)
        BillsAndPaymentSublbl.TabIndex = 1
        BillsAndPaymentSublbl.Text = "View your current and past bills, and check your payment status"
        ' 
        ' BillsAndPaymentHeaderlbl
        ' 
        BillsAndPaymentHeaderlbl.AutoSize = True
        BillsAndPaymentHeaderlbl.Font = New Font("Lucida Sans Unicode", 20F, FontStyle.Bold)
        BillsAndPaymentHeaderlbl.Location = New Point(21, 11)
        BillsAndPaymentHeaderlbl.Name = "BillsAndPaymentHeaderlbl"
        BillsAndPaymentHeaderlbl.Size = New Size(459, 48)
        BillsAndPaymentHeaderlbl.TabIndex = 0
        BillsAndPaymentHeaderlbl.Text = "BILLS AND PAYMENTS"
        ' 
        ' mainSubTableLayoutPanel
        ' 
        mainSubTableLayoutPanel.ColumnCount = 3
        mainSubTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        mainSubTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 45F))
        mainSubTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        mainSubTableLayoutPanel.Controls.Add(billsDataServiceAndPaymentInfoPanel, 2, 0)
        mainSubTableLayoutPanel.Controls.Add(BillsAndPaymentMainPanel, 0, 0)
        mainSubTableLayoutPanel.Dock = DockStyle.Fill
        mainSubTableLayoutPanel.Location = New Point(25, 120)
        mainSubTableLayoutPanel.Margin = New Padding(25, 3, 25, 25)
        mainSubTableLayoutPanel.Name = "mainSubTableLayoutPanel"
        mainSubTableLayoutPanel.RowCount = 1
        mainSubTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        mainSubTableLayoutPanel.Size = New Size(1302, 767)
        mainSubTableLayoutPanel.TabIndex = 4
        ' 
        ' billsDataServiceAndPaymentInfoPanel
        ' 
        billsDataServiceAndPaymentInfoPanel.BackColor = Color.White
        billsDataServiceAndPaymentInfoPanel.Controls.Add(paymentInfoPanel)
        billsDataServiceAndPaymentInfoPanel.Controls.Add(serviceChargesPanel)
        billsDataServiceAndPaymentInfoPanel.Controls.Add(billsDataPanel)
        billsDataServiceAndPaymentInfoPanel.Dock = DockStyle.Fill
        billsDataServiceAndPaymentInfoPanel.Location = New Point(927, 3)
        billsDataServiceAndPaymentInfoPanel.Name = "billsDataServiceAndPaymentInfoPanel"
        billsDataServiceAndPaymentInfoPanel.Size = New Size(372, 761)
        billsDataServiceAndPaymentInfoPanel.TabIndex = 3
        ' 
        ' paymentInfoPanel
        ' 
        paymentInfoPanel.BackColor = Color.White
        paymentInfoPanel.Controls.Add(Panel9)
        paymentInfoPanel.Controls.Add(paymentInfoDataGridView)
        paymentInfoPanel.Controls.Add(paymentInfoHeaderlbl)
        paymentInfoPanel.Dock = DockStyle.Fill
        paymentInfoPanel.Location = New Point(0, 522)
        paymentInfoPanel.Name = "paymentInfoPanel"
        paymentInfoPanel.Size = New Size(372, 239)
        paymentInfoPanel.TabIndex = 9
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(makePaymentbtn)
        Panel9.Dock = DockStyle.Bottom
        Panel9.Location = New Point(0, 172)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(372, 67)
        Panel9.TabIndex = 2
        ' 
        ' makePaymentbtn
        ' 
        makePaymentbtn.BackColor = Color.FromArgb(CByte(125), CByte(245), CByte(245))
        makePaymentbtn.FlatAppearance.BorderSize = 0
        makePaymentbtn.FlatStyle = FlatStyle.Flat
        makePaymentbtn.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        makePaymentbtn.Location = New Point(68, 3)
        makePaymentbtn.Margin = New Padding(30)
        makePaymentbtn.Name = "makePaymentbtn"
        makePaymentbtn.Size = New Size(240, 62)
        makePaymentbtn.TabIndex = 9
        makePaymentbtn.Text = "make payment"
        makePaymentbtn.UseVisualStyleBackColor = False
        ' 
        ' paymentInfoDataGridView
        ' 
        paymentInfoDataGridView.AllowUserToAddRows = False
        paymentInfoDataGridView.AllowUserToDeleteRows = False
        paymentInfoDataGridView.AllowUserToResizeColumns = False
        paymentInfoDataGridView.AllowUserToResizeRows = False
        paymentInfoDataGridView.BackgroundColor = Color.White
        paymentInfoDataGridView.BorderStyle = BorderStyle.None
        paymentInfoDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None
        paymentInfoDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = SystemColors.Control
        DataGridViewCellStyle13.Font = New Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle13.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True
        paymentInfoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        paymentInfoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        paymentInfoDataGridView.Columns.AddRange(New DataGridViewColumn() {columnPaymentInformation, columnPaymentValue})
        paymentInfoDataGridView.Dock = DockStyle.Fill
        paymentInfoDataGridView.EnableHeadersVisualStyles = False
        paymentInfoDataGridView.GridColor = Color.DarkGray
        paymentInfoDataGridView.Location = New Point(0, 39)
        paymentInfoDataGridView.Name = "paymentInfoDataGridView"
        paymentInfoDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        paymentInfoDataGridView.RowHeadersVisible = False
        paymentInfoDataGridView.RowHeadersWidth = 62
        paymentInfoDataGridView.Size = New Size(372, 200)
        paymentInfoDataGridView.TabIndex = 39
        ' 
        ' columnPaymentInformation
        ' 
        DataGridViewCellStyle14.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        columnPaymentInformation.DefaultCellStyle = DataGridViewCellStyle14
        columnPaymentInformation.HeaderText = ""
        columnPaymentInformation.MinimumWidth = 8
        columnPaymentInformation.Name = "columnPaymentInformation"
        columnPaymentInformation.Width = 150
        ' 
        ' columnPaymentValue
        ' 
        DataGridViewCellStyle15.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        columnPaymentValue.DefaultCellStyle = DataGridViewCellStyle15
        columnPaymentValue.HeaderText = ""
        columnPaymentValue.MinimumWidth = 8
        columnPaymentValue.Name = "columnPaymentValue"
        columnPaymentValue.Width = 150
        ' 
        ' paymentInfoHeaderlbl
        ' 
        paymentInfoHeaderlbl.AutoSize = True
        paymentInfoHeaderlbl.Dock = DockStyle.Top
        paymentInfoHeaderlbl.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold)
        paymentInfoHeaderlbl.Location = New Point(0, 0)
        paymentInfoHeaderlbl.Name = "paymentInfoHeaderlbl"
        paymentInfoHeaderlbl.Size = New Size(364, 39)
        paymentInfoHeaderlbl.TabIndex = 1
        paymentInfoHeaderlbl.Text = "payment information"
        ' 
        ' serviceChargesPanel
        ' 
        serviceChargesPanel.Controls.Add(serviceChargesDataGridView)
        serviceChargesPanel.Controls.Add(serviceChargesUnderlinelbl)
        serviceChargesPanel.Controls.Add(serviceChargeslbl)
        serviceChargesPanel.Dock = DockStyle.Top
        serviceChargesPanel.Location = New Point(0, 135)
        serviceChargesPanel.Name = "serviceChargesPanel"
        serviceChargesPanel.Size = New Size(372, 387)
        serviceChargesPanel.TabIndex = 8
        ' 
        ' serviceChargesDataGridView
        ' 
        serviceChargesDataGridView.AllowUserToAddRows = False
        serviceChargesDataGridView.AllowUserToDeleteRows = False
        serviceChargesDataGridView.AllowUserToResizeColumns = False
        serviceChargesDataGridView.AllowUserToResizeRows = False
        serviceChargesDataGridView.BackgroundColor = Color.White
        serviceChargesDataGridView.BorderStyle = BorderStyle.None
        serviceChargesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        serviceChargesDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = SystemColors.Control
        DataGridViewCellStyle16.Font = New Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle16.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = DataGridViewTriState.True
        serviceChargesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        serviceChargesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        serviceChargesDataGridView.Columns.AddRange(New DataGridViewColumn() {columnDescription, columnAmount})
        serviceChargesDataGridView.Dock = DockStyle.Bottom
        serviceChargesDataGridView.EnableHeadersVisualStyles = False
        serviceChargesDataGridView.GridColor = Color.DarkGray
        serviceChargesDataGridView.Location = New Point(0, 56)
        serviceChargesDataGridView.Name = "serviceChargesDataGridView"
        serviceChargesDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = SystemColors.Control
        DataGridViewCellStyle19.Font = New Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle19.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = DataGridViewTriState.True
        serviceChargesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        serviceChargesDataGridView.RowHeadersVisible = False
        serviceChargesDataGridView.RowHeadersWidth = 62
        serviceChargesDataGridView.Size = New Size(372, 329)
        serviceChargesDataGridView.TabIndex = 39
        ' 
        ' columnDescription
        ' 
        DataGridViewCellStyle17.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        columnDescription.DefaultCellStyle = DataGridViewCellStyle17
        columnDescription.HeaderText = "DESCRIPTION"
        columnDescription.MinimumWidth = 8
        columnDescription.Name = "columnDescription"
        columnDescription.SortMode = DataGridViewColumnSortMode.NotSortable
        columnDescription.Width = 150
        ' 
        ' columnAmount
        ' 
        DataGridViewCellStyle18.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        columnAmount.DefaultCellStyle = DataGridViewCellStyle18
        columnAmount.HeaderText = "AMOUNT"
        columnAmount.MinimumWidth = 8
        columnAmount.Name = "columnAmount"
        columnAmount.SortMode = DataGridViewColumnSortMode.NotSortable
        columnAmount.Width = 150
        ' 
        ' serviceChargesUnderlinelbl
        ' 
        serviceChargesUnderlinelbl.BackColor = Color.Black
        serviceChargesUnderlinelbl.Dock = DockStyle.Bottom
        serviceChargesUnderlinelbl.FlatStyle = FlatStyle.Flat
        serviceChargesUnderlinelbl.Location = New Point(0, 385)
        serviceChargesUnderlinelbl.Name = "serviceChargesUnderlinelbl"
        serviceChargesUnderlinelbl.Size = New Size(372, 2)
        serviceChargesUnderlinelbl.TabIndex = 35
        ' 
        ' serviceChargeslbl
        ' 
        serviceChargeslbl.AutoSize = True
        serviceChargeslbl.Dock = DockStyle.Top
        serviceChargeslbl.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold)
        serviceChargeslbl.Location = New Point(0, 0)
        serviceChargeslbl.Name = "serviceChargeslbl"
        serviceChargeslbl.Size = New Size(287, 39)
        serviceChargeslbl.TabIndex = 2
        serviceChargeslbl.Text = "services charges"
        ' 
        ' billsDataPanel
        ' 
        billsDataPanel.Controls.Add(billsDataTableLayoutPanel)
        billsDataPanel.Controls.Add(billsDataUnderlinelbl)
        billsDataPanel.Controls.Add(billsDatalbl)
        billsDataPanel.Dock = DockStyle.Top
        billsDataPanel.Location = New Point(0, 0)
        billsDataPanel.Name = "billsDataPanel"
        billsDataPanel.Size = New Size(372, 135)
        billsDataPanel.TabIndex = 7
        ' 
        ' billsDataTableLayoutPanel
        ' 
        billsDataTableLayoutPanel.ColumnCount = 2
        billsDataTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        billsDataTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        billsDataTableLayoutPanel.Controls.Add(billsDataUserStatuslbl, 1, 1)
        billsDataTableLayoutPanel.Controls.Add(billsDataStatuslbl, 1, 0)
        billsDataTableLayoutPanel.Controls.Add(billsDataUserDatelbl, 0, 1)
        billsDataTableLayoutPanel.Controls.Add(billsDataDatelbl, 0, 0)
        billsDataTableLayoutPanel.Dock = DockStyle.Bottom
        billsDataTableLayoutPanel.Location = New Point(0, 56)
        billsDataTableLayoutPanel.Name = "billsDataTableLayoutPanel"
        billsDataTableLayoutPanel.RowCount = 2
        billsDataTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        billsDataTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        billsDataTableLayoutPanel.Size = New Size(372, 77)
        billsDataTableLayoutPanel.TabIndex = 39
        ' 
        ' billsDataUserStatuslbl
        ' 
        billsDataUserStatuslbl.AutoSize = True
        billsDataUserStatuslbl.Dock = DockStyle.Fill
        billsDataUserStatuslbl.Font = New Font("Lucida Sans Unicode", 12F)
        billsDataUserStatuslbl.ForeColor = Color.Red
        billsDataUserStatuslbl.Location = New Point(189, 38)
        billsDataUserStatuslbl.Name = "billsDataUserStatuslbl"
        billsDataUserStatuslbl.Size = New Size(180, 39)
        billsDataUserStatuslbl.TabIndex = 6
        billsDataUserStatuslbl.Text = "UNPAID"
        ' 
        ' billsDataStatuslbl
        ' 
        billsDataStatuslbl.AutoSize = True
        billsDataStatuslbl.Dock = DockStyle.Fill
        billsDataStatuslbl.Font = New Font("Lucida Sans Unicode", 12F)
        billsDataStatuslbl.Location = New Point(189, 0)
        billsDataStatuslbl.Name = "billsDataStatuslbl"
        billsDataStatuslbl.Size = New Size(180, 38)
        billsDataStatuslbl.TabIndex = 4
        billsDataStatuslbl.Text = "STATUS:"
        ' 
        ' billsDataUserDatelbl
        ' 
        billsDataUserDatelbl.AutoSize = True
        billsDataUserDatelbl.Dock = DockStyle.Fill
        billsDataUserDatelbl.Font = New Font("Lucida Sans Unicode", 12F)
        billsDataUserDatelbl.Location = New Point(3, 38)
        billsDataUserDatelbl.Name = "billsDataUserDatelbl"
        billsDataUserDatelbl.Size = New Size(180, 39)
        billsDataUserDatelbl.TabIndex = 5
        billsDataUserDatelbl.Text = "DEC. 16 2026"
        ' 
        ' billsDataDatelbl
        ' 
        billsDataDatelbl.AutoSize = True
        billsDataDatelbl.Dock = DockStyle.Fill
        billsDataDatelbl.Font = New Font("Lucida Sans Unicode", 12F)
        billsDataDatelbl.Location = New Point(3, 0)
        billsDataDatelbl.Name = "billsDataDatelbl"
        billsDataDatelbl.Size = New Size(180, 38)
        billsDataDatelbl.TabIndex = 2
        billsDataDatelbl.Text = "DATE:"
        ' 
        ' billsDataUnderlinelbl
        ' 
        billsDataUnderlinelbl.BackColor = Color.Black
        billsDataUnderlinelbl.Dock = DockStyle.Bottom
        billsDataUnderlinelbl.FlatStyle = FlatStyle.Flat
        billsDataUnderlinelbl.Location = New Point(0, 133)
        billsDataUnderlinelbl.Name = "billsDataUnderlinelbl"
        billsDataUnderlinelbl.Size = New Size(372, 2)
        billsDataUnderlinelbl.TabIndex = 34
        ' 
        ' billsDatalbl
        ' 
        billsDatalbl.AutoSize = True
        billsDatalbl.Dock = DockStyle.Top
        billsDatalbl.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        billsDatalbl.Location = New Point(0, 0)
        billsDatalbl.Name = "billsDatalbl"
        billsDatalbl.Size = New Size(168, 39)
        billsDatalbl.TabIndex = 1
        billsDatalbl.Text = "bills data"
        ' 
        ' BillsAndPaymentMainPanel
        ' 
        BillsAndPaymentMainPanel.BackColor = Color.White
        BillsAndPaymentMainPanel.Controls.Add(searchBarPanel)
        BillsAndPaymentMainPanel.Controls.Add(billsAndPaymentDataGridView)
        BillsAndPaymentMainPanel.Controls.Add(billsButtonPanel)
        BillsAndPaymentMainPanel.Controls.Add(pageInfoAndButtonsPanel)
        BillsAndPaymentMainPanel.Dock = DockStyle.Fill
        BillsAndPaymentMainPanel.Location = New Point(3, 3)
        BillsAndPaymentMainPanel.Name = "BillsAndPaymentMainPanel"
        BillsAndPaymentMainPanel.Size = New Size(873, 761)
        BillsAndPaymentMainPanel.TabIndex = 2
        ' 
        ' searchBarPanel
        ' 
        searchBarPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        searchBarPanel.BackColor = Color.Gainsboro
        searchBarPanel.Controls.Add(searchTextbox)
        searchBarPanel.Controls.Add(SearchIcon)
        searchBarPanel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBarPanel.Location = New Point(18, 115)
        searchBarPanel.Margin = New Padding(15, 3, 15, 3)
        searchBarPanel.Name = "searchBarPanel"
        searchBarPanel.Size = New Size(829, 45)
        searchBarPanel.TabIndex = 36
        ' 
        ' searchTextbox
        ' 
        searchTextbox.BackColor = Color.Gainsboro
        searchTextbox.Dock = DockStyle.Fill
        searchTextbox.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchTextbox.Location = New Point(45, 0)
        searchTextbox.Name = "searchTextbox"
        searchTextbox.Size = New Size(784, 44)
        searchTextbox.TabIndex = 0
        searchTextbox.Text = "Search"
        ' 
        ' SearchIcon
        ' 
        SearchIcon.BackColor = Color.Transparent
        SearchIcon.Dock = DockStyle.Left
        SearchIcon.Image = My.Resources.Resources.search
        SearchIcon.Location = New Point(0, 0)
        SearchIcon.Name = "SearchIcon"
        SearchIcon.Size = New Size(45, 45)
        SearchIcon.SizeMode = PictureBoxSizeMode.Zoom
        SearchIcon.TabIndex = 4
        SearchIcon.TabStop = False
        ' 
        ' billsAndPaymentDataGridView
        ' 
        billsAndPaymentDataGridView.AllowUserToAddRows = False
        billsAndPaymentDataGridView.AllowUserToDeleteRows = False
        billsAndPaymentDataGridView.AllowUserToResizeColumns = False
        billsAndPaymentDataGridView.AllowUserToResizeRows = False
        billsAndPaymentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        billsAndPaymentDataGridView.BackgroundColor = Color.White
        billsAndPaymentDataGridView.BorderStyle = BorderStyle.None
        billsAndPaymentDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        billsAndPaymentDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = SystemColors.Control
        DataGridViewCellStyle20.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle20.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = DataGridViewTriState.True
        billsAndPaymentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        billsAndPaymentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        billsAndPaymentDataGridView.Columns.AddRange(New DataGridViewColumn() {columnDate, columnTotalAmount, columnStatus, columnView})
        billsAndPaymentDataGridView.Dock = DockStyle.Bottom
        billsAndPaymentDataGridView.EnableHeadersVisualStyles = False
        billsAndPaymentDataGridView.GridColor = Color.Gray
        billsAndPaymentDataGridView.Location = New Point(0, 166)
        billsAndPaymentDataGridView.Name = "billsAndPaymentDataGridView"
        billsAndPaymentDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        billsAndPaymentDataGridView.RowHeadersVisible = False
        billsAndPaymentDataGridView.RowHeadersWidth = 62
        billsAndPaymentDataGridView.Size = New Size(873, 503)
        billsAndPaymentDataGridView.TabIndex = 39
        ' 
        ' columnDate
        ' 
        DataGridViewCellStyle21.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        columnDate.DefaultCellStyle = DataGridViewCellStyle21
        columnDate.HeaderText = "DATE"
        columnDate.MinimumWidth = 8
        columnDate.Name = "columnDate"
        ' 
        ' columnTotalAmount
        ' 
        DataGridViewCellStyle22.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        columnTotalAmount.DefaultCellStyle = DataGridViewCellStyle22
        columnTotalAmount.HeaderText = "TOTAL AMOUNT"
        columnTotalAmount.MinimumWidth = 8
        columnTotalAmount.Name = "columnTotalAmount"
        ' 
        ' columnStatus
        ' 
        DataGridViewCellStyle23.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        columnStatus.DefaultCellStyle = DataGridViewCellStyle23
        columnStatus.HeaderText = "STATUS"
        columnStatus.MinimumWidth = 8
        columnStatus.Name = "columnStatus"
        ' 
        ' columnView
        ' 
        DataGridViewCellStyle24.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        columnView.DefaultCellStyle = DataGridViewCellStyle24
        columnView.HeaderText = ""
        columnView.LinkBehavior = LinkBehavior.HoverUnderline
        columnView.MinimumWidth = 8
        columnView.Name = "columnView"
        columnView.Text = "VIEW"
        columnView.UseColumnTextForLinkValue = True
        ' 
        ' billsButtonPanel
        ' 
        billsButtonPanel.Controls.Add(buttonUnderlinelbl)
        billsButtonPanel.Controls.Add(allbillsbtn)
        billsButtonPanel.Controls.Add(unpaidbtn)
        billsButtonPanel.Controls.Add(paidbtn)
        billsButtonPanel.Dock = DockStyle.Top
        billsButtonPanel.Location = New Point(0, 0)
        billsButtonPanel.Name = "billsButtonPanel"
        billsButtonPanel.Size = New Size(873, 78)
        billsButtonPanel.TabIndex = 38
        ' 
        ' buttonUnderlinelbl
        ' 
        buttonUnderlinelbl.BackColor = Color.Black
        buttonUnderlinelbl.Dock = DockStyle.Bottom
        buttonUnderlinelbl.FlatStyle = FlatStyle.Flat
        buttonUnderlinelbl.Location = New Point(0, 76)
        buttonUnderlinelbl.Name = "buttonUnderlinelbl"
        buttonUnderlinelbl.Size = New Size(873, 2)
        buttonUnderlinelbl.TabIndex = 35
        ' 
        ' allbillsbtn
        ' 
        allbillsbtn.BackColor = Color.White
        allbillsbtn.FlatAppearance.BorderSize = 0
        allbillsbtn.FlatStyle = FlatStyle.Flat
        allbillsbtn.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold)
        allbillsbtn.Location = New Point(56, 3)
        allbillsbtn.Name = "allbillsbtn"
        allbillsbtn.Size = New Size(187, 63)
        allbillsbtn.TabIndex = 0
        allbillsbtn.Text = "allbills"
        allbillsbtn.UseVisualStyleBackColor = False
        ' 
        ' unpaidbtn
        ' 
        unpaidbtn.FlatAppearance.BorderSize = 0
        unpaidbtn.FlatStyle = FlatStyle.Flat
        unpaidbtn.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold)
        unpaidbtn.Location = New Point(337, 3)
        unpaidbtn.Name = "unpaidbtn"
        unpaidbtn.Size = New Size(187, 65)
        unpaidbtn.TabIndex = 1
        unpaidbtn.Text = "unpaid"
        unpaidbtn.UseVisualStyleBackColor = True
        ' 
        ' paidbtn
        ' 
        paidbtn.FlatAppearance.BorderSize = 0
        paidbtn.FlatStyle = FlatStyle.Flat
        paidbtn.Font = New Font("Lucida Sans Unicode", 16F, FontStyle.Bold)
        paidbtn.Location = New Point(635, 4)
        paidbtn.Name = "paidbtn"
        paidbtn.Size = New Size(187, 60)
        paidbtn.TabIndex = 2
        paidbtn.Text = "paid"
        paidbtn.UseVisualStyleBackColor = True
        ' 
        ' pageInfoAndButtonsPanel
        ' 
        pageInfoAndButtonsPanel.Controls.Add(nextbtn)
        pageInfoAndButtonsPanel.Controls.Add(currentPagebtn)
        pageInfoAndButtonsPanel.Controls.Add(prevbtn)
        pageInfoAndButtonsPanel.Controls.Add(showCurrentPagelbl)
        pageInfoAndButtonsPanel.Dock = DockStyle.Bottom
        pageInfoAndButtonsPanel.Location = New Point(0, 669)
        pageInfoAndButtonsPanel.Name = "pageInfoAndButtonsPanel"
        pageInfoAndButtonsPanel.Size = New Size(873, 92)
        pageInfoAndButtonsPanel.TabIndex = 9
        ' 
        ' nextbtn
        ' 
        nextbtn.BackColor = Color.FromArgb(CByte(125), CByte(245), CByte(245))
        nextbtn.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        nextbtn.Location = New Point(686, 25)
        nextbtn.Margin = New Padding(5, 3, 3, 3)
        nextbtn.Name = "nextbtn"
        nextbtn.Size = New Size(50, 50)
        nextbtn.TabIndex = 7
        nextbtn.Text = ">"
        nextbtn.UseVisualStyleBackColor = False
        ' 
        ' currentPagebtn
        ' 
        currentPagebtn.BackColor = Color.FromArgb(CByte(125), CByte(245), CByte(245))
        currentPagebtn.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        currentPagebtn.Location = New Point(626, 25)
        currentPagebtn.Margin = New Padding(5, 3, 5, 3)
        currentPagebtn.Name = "currentPagebtn"
        currentPagebtn.Size = New Size(50, 50)
        currentPagebtn.TabIndex = 6
        currentPagebtn.Text = "5"
        currentPagebtn.UseVisualStyleBackColor = False
        ' 
        ' prevbtn
        ' 
        prevbtn.BackColor = Color.FromArgb(CByte(125), CByte(245), CByte(245))
        prevbtn.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        prevbtn.Location = New Point(568, 25)
        prevbtn.Margin = New Padding(3, 3, 5, 3)
        prevbtn.Name = "prevbtn"
        prevbtn.Size = New Size(50, 50)
        prevbtn.TabIndex = 5
        prevbtn.Text = "<"
        prevbtn.UseVisualStyleBackColor = False
        ' 
        ' showCurrentPagelbl
        ' 
        showCurrentPagelbl.AutoSize = True
        showCurrentPagelbl.Font = New Font("Lucida Sans Unicode", 11F, FontStyle.Bold)
        showCurrentPagelbl.Location = New Point(18, 28)
        showCurrentPagelbl.Name = "showCurrentPagelbl"
        showCurrentPagelbl.Size = New Size(338, 27)
        showCurrentPagelbl.TabIndex = 4
        showCurrentPagelbl.Text = "SHOWING 1 TO 5 OF 5 BILLS"
        ' 
        ' UCBillsAndPayment
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        Controls.Add(BillsAndPaymentPanel)
        Name = "UCBillsAndPayment"
        Size = New Size(1352, 912)
        BillsAndPaymentPanel.ResumeLayout(False)
        MainTableLayoutPanel.ResumeLayout(False)
        BillsHeaderPanel.ResumeLayout(False)
        BillsHeaderPanel.PerformLayout()
        mainSubTableLayoutPanel.ResumeLayout(False)
        billsDataServiceAndPaymentInfoPanel.ResumeLayout(False)
        paymentInfoPanel.ResumeLayout(False)
        paymentInfoPanel.PerformLayout()
        Panel9.ResumeLayout(False)
        CType(paymentInfoDataGridView, ComponentModel.ISupportInitialize).EndInit()
        serviceChargesPanel.ResumeLayout(False)
        serviceChargesPanel.PerformLayout()
        CType(serviceChargesDataGridView, ComponentModel.ISupportInitialize).EndInit()
        billsDataPanel.ResumeLayout(False)
        billsDataPanel.PerformLayout()
        billsDataTableLayoutPanel.ResumeLayout(False)
        billsDataTableLayoutPanel.PerformLayout()
        BillsAndPaymentMainPanel.ResumeLayout(False)
        searchBarPanel.ResumeLayout(False)
        searchBarPanel.PerformLayout()
        CType(SearchIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(billsAndPaymentDataGridView, ComponentModel.ISupportInitialize).EndInit()
        billsButtonPanel.ResumeLayout(False)
        pageInfoAndButtonsPanel.ResumeLayout(False)
        pageInfoAndButtonsPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BillsAndPaymentPanel As Panel
    Friend WithEvents BillsAndPaymentHeaderlbl As Label
    Friend WithEvents BillsAndPaymentSublbl As Label
    Friend WithEvents billsDataServiceAndPaymentInfoPanel As Panel
    Friend WithEvents BillsAndPaymentMainPanel As Panel
    Friend WithEvents unpaidbtn As Button
    Friend WithEvents allbillsbtn As Button
    Friend WithEvents paidbtn As Button
    Friend WithEvents billsDataUserDatelbl As Label
    Friend WithEvents billsDataStatuslbl As Label
    Friend WithEvents billsDataDatelbl As Label
    Friend WithEvents billsDatalbl As Label
    Friend WithEvents billsDataPanel As Panel
    Friend WithEvents billsDataUserStatuslbl As Label
    Friend WithEvents serviceChargesPanel As Panel
    Friend WithEvents serviceChargeslbl As Label
    Friend WithEvents paymentInfoPanel As Panel
    Friend WithEvents paymentInfoHeaderlbl As Label
    Friend WithEvents pageInfoAndButtonsPanel As Panel
    Friend WithEvents showCurrentPagelbl As Label
    Friend WithEvents nextbtn As Button
    Friend WithEvents currentPagebtn As Button
    Friend WithEvents prevbtn As Button
    Friend WithEvents serviceChargesUnderlinelbl As Label
    Friend WithEvents billsDataUnderlinelbl As Label
    Friend WithEvents billsButtonPanel As Panel
    Friend WithEvents buttonUnderlinelbl As Label
    Friend WithEvents BillsHeaderPanel As Panel
    Friend WithEvents mainSubTableLayoutPanel As TableLayoutPanel
    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents billsDataTableLayoutPanel As TableLayoutPanel
    Friend WithEvents serviceChargesDataGridView As DataGridView
    Friend WithEvents paymentInfoDataGridView As DataGridView
    Friend WithEvents billsAndPaymentDataGridView As DataGridView
    Friend WithEvents columnDescription As DataGridViewTextBoxColumn
    Friend WithEvents columnAmount As DataGridViewTextBoxColumn
    Friend WithEvents columnPaymentInformation As DataGridViewTextBoxColumn
    Friend WithEvents columnPaymentValue As DataGridViewTextBoxColumn
    Friend WithEvents columnDate As DataGridViewTextBoxColumn
    Friend WithEvents columnTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents columnStatus As DataGridViewTextBoxColumn
    Friend WithEvents columnView As DataGridViewLinkColumn
    Friend WithEvents Panel9 As Panel
    Friend WithEvents makePaymentbtn As Button
    Friend WithEvents searchBarPanel As Panel
    Friend WithEvents searchTextbox As TextBox
    Friend WithEvents SearchIcon As PictureBox

End Class
