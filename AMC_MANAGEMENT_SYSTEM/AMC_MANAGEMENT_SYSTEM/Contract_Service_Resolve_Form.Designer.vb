<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contract_Service_Resolve_Form
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEnaEmpId = New System.Windows.Forms.Button()
        Me.lblDCustName = New System.Windows.Forms.Label()
        Me.txtAmtCharge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnProductDelete = New System.Windows.Forms.Button()
        Me.btnProductAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtSrNo = New System.Windows.Forms.TextBox()
        Me.dgvProductList = New System.Windows.Forms.DataGridView()
        Me.cbProductId = New System.Windows.Forms.ComboBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWorkDetails = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mtxtServiceDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbEmpId = New System.Windows.Forms.ComboBox()
        Me.lblDOtherDetails = New System.Windows.Forms.Label()
        Me.lblDWorkDetails = New System.Windows.Forms.Label()
        Me.lblDCustAddress = New System.Windows.Forms.Label()
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDSerDateTime = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAllocated = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProductDetails = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvProductList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Size = New System.Drawing.Size(1042, 633)
        Me.pnlMain.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(8, 115)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1003, 506)
        Me.Panel3.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEnaEmpId)
        Me.GroupBox1.Controls.Add(Me.lblDCustName)
        Me.GroupBox1.Controls.Add(Me.txtAmtCharge)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtRemark)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtWorkDetails)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.mtxtServiceDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbEmpId)
        Me.GroupBox1.Controls.Add(Me.lblDOtherDetails)
        Me.GroupBox1.Controls.Add(Me.lblDWorkDetails)
        Me.GroupBox1.Controls.Add(Me.lblDCustAddress)
        Me.GroupBox1.Controls.Add(Me.lblCustomerDetails)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblDSerDateTime)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblAllocated)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 449)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Service Details"
        '
        'btnEnaEmpId
        '
        Me.btnEnaEmpId.Location = New System.Drawing.Point(387, 174)
        Me.btnEnaEmpId.Name = "btnEnaEmpId"
        Me.btnEnaEmpId.Size = New System.Drawing.Size(30, 23)
        Me.btnEnaEmpId.TabIndex = 43
        Me.btnEnaEmpId.Text = "@"
        Me.btnEnaEmpId.UseVisualStyleBackColor = True
        '
        'lblDCustName
        '
        Me.lblDCustName.AutoSize = True
        Me.lblDCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDCustName.Location = New System.Drawing.Point(124, 57)
        Me.lblDCustName.Name = "lblDCustName"
        Me.lblDCustName.Size = New System.Drawing.Size(102, 13)
        Me.lblDCustName.TabIndex = 42
        Me.lblDCustName.Text = "Customer Details"
        '
        'txtAmtCharge
        '
        Me.txtAmtCharge.Location = New System.Drawing.Point(124, 356)
        Me.txtAmtCharge.Multiline = True
        Me.txtAmtCharge.Name = "txtAmtCharge"
        Me.txtAmtCharge.Size = New System.Drawing.Size(78, 26)
        Me.txtAmtCharge.TabIndex = 41
        Me.txtAmtCharge.Text = "0"
        Me.txtAmtCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Amount Charge :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnProductDelete)
        Me.GroupBox3.Controls.Add(Me.btnProductAdd)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtQty)
        Me.GroupBox3.Controls.Add(Me.txtSrNo)
        Me.GroupBox3.Controls.Add(Me.dgvProductList)
        Me.GroupBox3.Controls.Add(Me.cbProductId)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(424, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(524, 328)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PRODUCT CONSUME IN SERVICE"
        '
        'btnProductDelete
        '
        Me.btnProductDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductDelete.Location = New System.Drawing.Point(433, 58)
        Me.btnProductDelete.Name = "btnProductDelete"
        Me.btnProductDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnProductDelete.TabIndex = 8
        Me.btnProductDelete.Text = "Delete"
        Me.btnProductDelete.UseVisualStyleBackColor = True
        '
        'btnProductAdd
        '
        Me.btnProductAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductAdd.Location = New System.Drawing.Point(352, 58)
        Me.btnProductAdd.Name = "btnProductAdd"
        Me.btnProductAdd.Size = New System.Drawing.Size(75, 30)
        Me.btnProductAdd.TabIndex = 8
        Me.btnProductAdd.Text = "Add"
        Me.btnProductAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Product Name."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(287, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Qty."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SR No."
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(290, 61)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(56, 24)
        Me.txtQty.TabIndex = 6
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSrNo
        '
        Me.txtSrNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrNo.Location = New System.Drawing.Point(22, 60)
        Me.txtSrNo.Name = "txtSrNo"
        Me.txtSrNo.Size = New System.Drawing.Size(53, 24)
        Me.txtSrNo.TabIndex = 6
        '
        'dgvProductList
        '
        Me.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductList.Location = New System.Drawing.Point(22, 95)
        Me.dgvProductList.Margin = New System.Windows.Forms.Padding(10)
        Me.dgvProductList.Name = "dgvProductList"
        Me.dgvProductList.Size = New System.Drawing.Size(489, 220)
        Me.dgvProductList.TabIndex = 5
        '
        'cbProductId
        '
        Me.cbProductId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProductId.FormattingEnabled = True
        Me.cbProductId.Location = New System.Drawing.Point(84, 61)
        Me.cbProductId.Name = "cbProductId"
        Me.cbProductId.Size = New System.Drawing.Size(200, 24)
        Me.cbProductId.TabIndex = 3
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(124, 294)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(257, 48)
        Me.txtRemark.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(208, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 31)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Remark :"
        '
        'txtWorkDetails
        '
        Me.txtWorkDetails.Location = New System.Drawing.Point(125, 235)
        Me.txtWorkDetails.Multiline = True
        Me.txtWorkDetails.Name = "txtWorkDetails"
        Me.txtWorkDetails.Size = New System.Drawing.Size(256, 48)
        Me.txtWorkDetails.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(124, 400)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 31)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Work Detail :"
        '
        'mtxtServiceDate
        '
        Me.mtxtServiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtServiceDate.Location = New System.Drawing.Point(126, 204)
        Me.mtxtServiceDate.Mask = "00/00/0000"
        Me.mtxtServiceDate.Name = "mtxtServiceDate"
        Me.mtxtServiceDate.Size = New System.Drawing.Size(88, 22)
        Me.mtxtServiceDate.TabIndex = 4
        Me.mtxtServiceDate.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Resolve Date :"
        '
        'cbEmpId
        '
        Me.cbEmpId.FormattingEnabled = True
        Me.cbEmpId.Location = New System.Drawing.Point(126, 174)
        Me.cbEmpId.Name = "cbEmpId"
        Me.cbEmpId.Size = New System.Drawing.Size(255, 24)
        Me.cbEmpId.TabIndex = 3
        '
        'lblDOtherDetails
        '
        Me.lblDOtherDetails.AutoSize = True
        Me.lblDOtherDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOtherDetails.Location = New System.Drawing.Point(122, 122)
        Me.lblDOtherDetails.Name = "lblDOtherDetails"
        Me.lblDOtherDetails.Size = New System.Drawing.Size(103, 13)
        Me.lblDOtherDetails.TabIndex = 6
        Me.lblDOtherDetails.Text = "Customer Name :"
        '
        'lblDWorkDetails
        '
        Me.lblDWorkDetails.AutoSize = True
        Me.lblDWorkDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDWorkDetails.Location = New System.Drawing.Point(122, 99)
        Me.lblDWorkDetails.Name = "lblDWorkDetails"
        Me.lblDWorkDetails.Size = New System.Drawing.Size(103, 13)
        Me.lblDWorkDetails.TabIndex = 6
        Me.lblDWorkDetails.Text = "Customer Name :"
        '
        'lblDCustAddress
        '
        Me.lblDCustAddress.AutoSize = True
        Me.lblDCustAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDCustAddress.Location = New System.Drawing.Point(123, 76)
        Me.lblDCustAddress.Name = "lblDCustAddress"
        Me.lblDCustAddress.Size = New System.Drawing.Size(103, 13)
        Me.lblDCustAddress.TabIndex = 6
        Me.lblDCustAddress.Text = "Customer Name :"
        '
        'lblCustomerDetails
        '
        Me.lblCustomerDetails.AutoSize = True
        Me.lblCustomerDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerDetails.Location = New System.Drawing.Point(122, 44)
        Me.lblCustomerDetails.Name = "lblCustomerDetails"
        Me.lblCustomerDetails.Size = New System.Drawing.Size(0, 13)
        Me.lblCustomerDetails.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Other Details :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Service Detiails :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Address"
        '
        'lblDSerDateTime
        '
        Me.lblDSerDateTime.AutoSize = True
        Me.lblDSerDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSerDateTime.Location = New System.Drawing.Point(265, 18)
        Me.lblDSerDateTime.Name = "lblDSerDateTime"
        Me.lblDSerDateTime.Size = New System.Drawing.Size(103, 13)
        Me.lblDSerDateTime.TabIndex = 6
        Me.lblDSerDateTime.Text = "Customer Name :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(143, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Service Date & Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Customer Name :"
        '
        'lblAllocated
        '
        Me.lblAllocated.AutoSize = True
        Me.lblAllocated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllocated.Location = New System.Drawing.Point(20, 179)
        Me.lblAllocated.Name = "lblAllocated"
        Me.lblAllocated.Size = New System.Drawing.Size(87, 13)
        Me.lblAllocated.TabIndex = 6
        Me.lblAllocated.Text = "Allocated To :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.lblProductDetails)
        Me.Panel1.Location = New System.Drawing.Point(7, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 100)
        Me.Panel1.TabIndex = 0
        '
        'lblProductDetails
        '
        Me.lblProductDetails.AutoSize = True
        Me.lblProductDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblProductDetails.Location = New System.Drawing.Point(338, 33)
        Me.lblProductDetails.Name = "lblProductDetails"
        Me.lblProductDetails.Size = New System.Drawing.Size(270, 37)
        Me.lblProductDetails.TabIndex = 0
        Me.lblProductDetails.Text = "Service Allocation"
        Me.lblProductDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Contract_Service_Resolve_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 633)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Contract_Service_Resolve_Form"
        Me.Text = "Contract_Service_Resolve_Form"
        Me.pnlMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvProductList As DataGridView
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWorkDetails As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents mtxtServiceDate As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbEmpId As ComboBox
    Friend WithEvents lblAllocated As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblProductDetails As Label
    Friend WithEvents lblDOtherDetails As Label
    Friend WithEvents lblDWorkDetails As Label
    Friend WithEvents lblDCustAddress As Label
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDSerDateTime As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmtCharge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProductDelete As Button
    Friend WithEvents btnProductAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtSrNo As TextBox
    Friend WithEvents cbProductId As ComboBox
    Friend WithEvents lblDCustName As Label
    Friend WithEvents btnEnaEmpId As Button
End Class
