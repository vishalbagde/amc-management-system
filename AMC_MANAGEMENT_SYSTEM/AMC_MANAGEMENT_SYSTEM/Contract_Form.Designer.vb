<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contract_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.txtContractId = New System.Windows.Forms.TextBox()
        Me.lblCustCode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnServiceTypeRefresh = New System.Windows.Forms.Button()
        Me.mtxtToDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtFromDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbSalesBy = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSalesAmount = New System.Windows.Forms.TextBox()
        Me.cbAMCScheme = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbServiceType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCustId = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtModelNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCustRefresh = New System.Windows.Forms.Button()
        Me.dtContractDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCustInfoName = New System.Windows.Forms.Label()
        Me.lblCustInfo = New System.Windows.Forms.Label()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.txtMachineName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlMain.Controls.Add(Me.Panel3)
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Size = New System.Drawing.Size(959, 624)
        Me.pnlMain.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblCustName)
        Me.Panel3.Controls.Add(Me.txtContractId)
        Me.Panel3.Controls.Add(Me.lblCustCode)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(16, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(913, 476)
        Me.Panel3.TabIndex = 3
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(90, 108)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(103, 13)
        Me.lblCustName.TabIndex = 4
        Me.lblCustName.Text = "Customer Name :"
        '
        'txtContractId
        '
        Me.txtContractId.Location = New System.Drawing.Point(195, 77)
        Me.txtContractId.Name = "txtContractId"
        Me.txtContractId.Size = New System.Drawing.Size(240, 20)
        Me.txtContractId.TabIndex = 2
        '
        'lblCustCode
        '
        Me.lblCustCode.AutoSize = True
        Me.lblCustCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustCode.Location = New System.Drawing.Point(90, 80)
        Me.lblCustCode.Name = "lblCustCode"
        Me.lblCustCode.Size = New System.Drawing.Size(96, 13)
        Me.lblCustCode.TabIndex = 0
        Me.lblCustCode.Text = "Contract Code :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cbCustId)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 447)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "`"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Location = New System.Drawing.Point(66, 349)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(747, 73)
        Me.Panel2.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(201, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(78, 31)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(112, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 31)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(378, 20)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 31)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(289, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(78, 31)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(23, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 31)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnServiceTypeRefresh)
        Me.GroupBox3.Controls.Add(Me.mtxtToDate)
        Me.GroupBox3.Controls.Add(Me.mtxtFromDate)
        Me.GroupBox3.Controls.Add(Me.txtRemark)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cbSalesBy)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtSalesAmount)
        Me.GroupBox3.Controls.Add(Me.cbAMCScheme)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CbServiceType)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(66, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(747, 148)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Service Details"
        '
        'btnServiceTypeRefresh
        '
        Me.btnServiceTypeRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServiceTypeRefresh.Location = New System.Drawing.Point(367, 19)
        Me.btnServiceTypeRefresh.Name = "btnServiceTypeRefresh"
        Me.btnServiceTypeRefresh.Size = New System.Drawing.Size(41, 23)
        Me.btnServiceTypeRefresh.TabIndex = 10
        Me.btnServiceTypeRefresh.Text = "@"
        Me.btnServiceTypeRefresh.UseVisualStyleBackColor = True
        '
        'mtxtToDate
        '
        Me.mtxtToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtToDate.Location = New System.Drawing.Point(273, 83)
        Me.mtxtToDate.Mask = "00/00/0000"
        Me.mtxtToDate.Name = "mtxtToDate"
        Me.mtxtToDate.Size = New System.Drawing.Size(86, 22)
        Me.mtxtToDate.TabIndex = 13
        Me.mtxtToDate.ValidatingType = GetType(Date)
        '
        'mtxtFromDate
        '
        Me.mtxtFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtFromDate.Location = New System.Drawing.Point(121, 83)
        Me.mtxtFromDate.Mask = "00/00/0000"
        Me.mtxtFromDate.Name = "mtxtFromDate"
        Me.mtxtFromDate.Size = New System.Drawing.Size(88, 22)
        Me.mtxtFromDate.TabIndex = 12
        Me.mtxtFromDate.ValidatingType = GetType(Date)
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(531, 83)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(197, 48)
        Me.txtRemark.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(426, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Remark :"
        '
        'cbSalesBy
        '
        Me.cbSalesBy.FormattingEnabled = True
        Me.cbSalesBy.Location = New System.Drawing.Point(531, 49)
        Me.cbSalesBy.Name = "cbSalesBy"
        Me.cbSalesBy.Size = New System.Drawing.Size(197, 21)
        Me.cbSalesBy.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(426, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Sales By :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(231, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "To:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "FROM Date :"
        '
        'txtSalesAmount
        '
        Me.txtSalesAmount.Location = New System.Drawing.Point(531, 21)
        Me.txtSalesAmount.Name = "txtSalesAmount"
        Me.txtSalesAmount.Size = New System.Drawing.Size(197, 20)
        Me.txtSalesAmount.TabIndex = 14
        '
        'cbAMCScheme
        '
        Me.cbAMCScheme.FormattingEnabled = True
        Me.cbAMCScheme.Location = New System.Drawing.Point(121, 49)
        Me.cbAMCScheme.Name = "cbAMCScheme"
        Me.cbAMCScheme.Size = New System.Drawing.Size(240, 21)
        Me.cbAMCScheme.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(426, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Sales Amount :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "AMC Scheme"
        '
        'CbServiceType
        '
        Me.CbServiceType.FormattingEnabled = True
        Me.CbServiceType.Location = New System.Drawing.Point(121, 21)
        Me.CbServiceType.Name = "CbServiceType"
        Me.CbServiceType.Size = New System.Drawing.Size(240, 21)
        Me.CbServiceType.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Service Type :"
        '
        'cbCustId
        '
        Me.cbCustId.FormattingEnabled = True
        Me.cbCustId.Location = New System.Drawing.Point(187, 94)
        Me.cbCustId.Name = "cbCustId"
        Me.cbCustId.Size = New System.Drawing.Size(240, 21)
        Me.cbCustId.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtModelNo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnCustRefresh)
        Me.GroupBox2.Controls.Add(Me.dtContractDate)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblCustInfoName)
        Me.GroupBox2.Controls.Add(Me.lblCustInfo)
        Me.GroupBox2.Controls.Add(Me.txtSerialNo)
        Me.GroupBox2.Controls.Add(Me.txtMachineName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtBrand)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(66, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 166)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Details"
        '
        'txtModelNo
        '
        Me.txtModelNo.Location = New System.Drawing.Point(521, 103)
        Me.txtModelNo.Name = "txtModelNo"
        Me.txtModelNo.Size = New System.Drawing.Size(179, 20)
        Me.txtModelNo.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Model No. :"
        '
        'btnCustRefresh
        '
        Me.btnCustRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustRefresh.Location = New System.Drawing.Point(367, 75)
        Me.btnCustRefresh.Name = "btnCustRefresh"
        Me.btnCustRefresh.Size = New System.Drawing.Size(41, 23)
        Me.btnCustRefresh.TabIndex = 4
        Me.btnCustRefresh.Text = "@"
        Me.btnCustRefresh.UseVisualStyleBackColor = True
        '
        'dtContractDate
        '
        Me.dtContractDate.Location = New System.Drawing.Point(121, 20)
        Me.dtContractDate.Name = "dtContractDate"
        Me.dtContractDate.Size = New System.Drawing.Size(115, 20)
        Me.dtContractDate.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Contract Date :"
        '
        'lblCustInfoName
        '
        Me.lblCustInfoName.AutoSize = True
        Me.lblCustInfoName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustInfoName.Location = New System.Drawing.Point(118, 104)
        Me.lblCustInfoName.Name = "lblCustInfoName"
        Me.lblCustInfoName.Size = New System.Drawing.Size(0, 13)
        Me.lblCustInfoName.TabIndex = 24
        '
        'lblCustInfo
        '
        Me.lblCustInfo.AutoSize = True
        Me.lblCustInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustInfo.Location = New System.Drawing.Point(16, 101)
        Me.lblCustInfo.Name = "lblCustInfo"
        Me.lblCustInfo.Size = New System.Drawing.Size(85, 13)
        Me.lblCustInfo.TabIndex = 21
        Me.lblCustInfo.Text = "Customer Info"
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Location = New System.Drawing.Point(521, 131)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(179, 20)
        Me.txtSerialNo.TabIndex = 8
        '
        'txtMachineName
        '
        Me.txtMachineName.Location = New System.Drawing.Point(520, 48)
        Me.txtMachineName.Name = "txtMachineName"
        Me.txtMachineName.Size = New System.Drawing.Size(179, 20)
        Me.txtMachineName.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(415, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Machine Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Serial No."
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(521, 75)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(179, 20)
        Me.txtBrand.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(416, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Brand :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(317, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contract Forms"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Contract_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 624)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Contract_Form"
        Me.Text = "Contract_Form"
        Me.pnlMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCustName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContractId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSerialNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCustId As ComboBox
    Friend WithEvents txtMachineName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSalesAmount As TextBox
    Friend WithEvents cbAMCScheme As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbServiceType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSalesBy As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCustInfoName As Label
    Friend WithEvents lblCustInfo As Label
    Friend WithEvents lblCustCode As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtContractDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents mtxtToDate As MaskedTextBox
    Friend WithEvents mtxtFromDate As MaskedTextBox
    Friend WithEvents btnCustRefresh As Button
    Friend WithEvents btnServiceTypeRefresh As Button
    Friend WithEvents txtModelNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
End Class
