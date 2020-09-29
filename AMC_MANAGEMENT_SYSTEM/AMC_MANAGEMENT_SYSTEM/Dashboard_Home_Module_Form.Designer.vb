<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard_Home_Module_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblTotComplain = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotSer = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTotAmcSale = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlOperation = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.dgvComplainDetails = New System.Windows.Forms.DataGridView()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.dgvServiceDetails = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbEmpId = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbComplainType = New System.Windows.Forms.ComboBox()
        Me.cbServiceListType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbServiceListDate = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbCompType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblComSM = New System.Windows.Forms.Label()
        Me.lblComSY = New System.Windows.Forms.Label()
        Me.lblComSW = New System.Windows.Forms.Label()
        Me.lblComST = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblSerSM = New System.Windows.Forms.Label()
        Me.lblSerSY = New System.Windows.Forms.Label()
        Me.lblSerSW = New System.Windows.Forms.Label()
        Me.lblserST = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblAmcSM = New System.Windows.Forms.Label()
        Me.lblAmcSY = New System.Windows.Forms.Label()
        Me.lblAmcSW = New System.Windows.Forms.Label()
        Me.lblAmcST = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlOperation.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.dgvComplainDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.dgvServiceDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(25, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Service = "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1460, 98)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1458, 98)
        Me.Panel4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(56, -2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Today Dashboard"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel6.Controls.Add(Me.lblTotComplain)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(1037, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(401, 59)
        Me.Panel6.TabIndex = 2
        '
        'lblTotComplain
        '
        Me.lblTotComplain.AutoSize = True
        Me.lblTotComplain.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotComplain.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotComplain.Location = New System.Drawing.Point(323, 10)
        Me.lblTotComplain.Name = "lblTotComplain"
        Me.lblTotComplain.Size = New System.Drawing.Size(44, 37)
        Me.lblTotComplain.TabIndex = 3
        Me.lblTotComplain.Text = "to"
        Me.lblTotComplain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(72, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Complain = "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.lblTotSer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(53, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 59)
        Me.Panel1.TabIndex = 0
        '
        'lblTotSer
        '
        Me.lblTotSer.AutoSize = True
        Me.lblTotSer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotSer.Location = New System.Drawing.Point(249, 12)
        Me.lblTotSer.Name = "lblTotSer"
        Me.lblTotSer.Size = New System.Drawing.Size(44, 37)
        Me.lblTotSer.TabIndex = 1
        Me.lblTotSer.Text = "to"
        Me.lblTotSer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Controls.Add(Me.lblTotAmcSale)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(551, 30)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(401, 59)
        Me.Panel5.TabIndex = 1
        '
        'lblTotAmcSale
        '
        Me.lblTotAmcSale.AutoSize = True
        Me.lblTotAmcSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotAmcSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotAmcSale.Location = New System.Drawing.Point(244, 11)
        Me.lblTotAmcSale.Name = "lblTotAmcSale"
        Me.lblTotAmcSale.Size = New System.Drawing.Size(44, 37)
        Me.lblTotAmcSale.TabIndex = 2
        Me.lblTotAmcSale.Text = "to"
        Me.lblTotAmcSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(52, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total AMC ="
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(428, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(401, 59)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(51, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Home Page Module"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlMain.Controls.Add(Me.pnlOperation)
        Me.pnlMain.Controls.Add(Me.Panel3)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlMain.Size = New System.Drawing.Size(1480, 771)
        Me.pnlMain.TabIndex = 3
        '
        'pnlOperation
        '
        Me.pnlOperation.Controls.Add(Me.Panel12)
        Me.pnlOperation.Controls.Add(Me.Panel11)
        Me.pnlOperation.Controls.Add(Me.Panel7)
        Me.pnlOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOperation.Location = New System.Drawing.Point(10, 108)
        Me.pnlOperation.Name = "pnlOperation"
        Me.pnlOperation.Size = New System.Drawing.Size(1460, 653)
        Me.pnlOperation.TabIndex = 4
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.dgvComplainDetails)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Panel12.Location = New System.Drawing.Point(760, 280)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(700, 373)
        Me.Panel12.TabIndex = 7
        '
        'dgvComplainDetails
        '
        Me.dgvComplainDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComplainDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvComplainDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvComplainDetails.Name = "dgvComplainDetails"
        Me.dgvComplainDetails.Size = New System.Drawing.Size(700, 373)
        Me.dgvComplainDetails.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.dgvServiceDetails)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Panel11.Location = New System.Drawing.Point(0, 280)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(729, 373)
        Me.Panel11.TabIndex = 6
        '
        'dgvServiceDetails
        '
        Me.dgvServiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvServiceDetails.Location = New System.Drawing.Point(0, 0)
        Me.dgvServiceDetails.Name = "dgvServiceDetails"
        Me.dgvServiceDetails.Size = New System.Drawing.Size(729, 373)
        Me.dgvServiceDetails.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.cbEmpId)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.cbComplainType)
        Me.Panel7.Controls.Add(Me.cbServiceListType)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.cbServiceListDate)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.cbCompType)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1460, 280)
        Me.Panel7.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.Location = New System.Drawing.Point(1146, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Emp ID :  "
        '
        'cbEmpId
        '
        Me.cbEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpId.FormattingEnabled = True
        Me.cbEmpId.Location = New System.Drawing.Point(1235, 243)
        Me.cbEmpId.Margin = New System.Windows.Forms.Padding(10)
        Me.cbEmpId.Name = "cbEmpId"
        Me.cbEmpId.Size = New System.Drawing.Size(221, 28)
        Me.cbEmpId.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(832, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Complain Type :  "
        '
        'cbComplainType
        '
        Me.cbComplainType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbComplainType.FormattingEnabled = True
        Me.cbComplainType.Location = New System.Drawing.Point(979, 243)
        Me.cbComplainType.Margin = New System.Windows.Forms.Padding(10)
        Me.cbComplainType.Name = "cbComplainType"
        Me.cbComplainType.Size = New System.Drawing.Size(164, 28)
        Me.cbComplainType.TabIndex = 18
        '
        'cbServiceListType
        '
        Me.cbServiceListType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbServiceListType.FormattingEnabled = True
        Me.cbServiceListType.Location = New System.Drawing.Point(77, 248)
        Me.cbServiceListType.Margin = New System.Windows.Forms.Padding(10)
        Me.cbServiceListType.Name = "cbServiceListType"
        Me.cbServiceListType.Size = New System.Drawing.Size(164, 28)
        Me.cbServiceListType.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(21, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Type :  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(270, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Date :  "
        '
        'cbServiceListDate
        '
        Me.cbServiceListDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbServiceListDate.FormattingEnabled = True
        Me.cbServiceListDate.Location = New System.Drawing.Point(338, 248)
        Me.cbServiceListDate.Margin = New System.Windows.Forms.Padding(10)
        Me.cbServiceListDate.Name = "cbServiceListDate"
        Me.cbServiceListDate.Size = New System.Drawing.Size(234, 28)
        Me.cbServiceListDate.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label19.Location = New System.Drawing.Point(1039, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 20)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Complain Type"
        '
        'cbCompType
        '
        Me.cbCompType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCompType.FormattingEnabled = True
        Me.cbCompType.Location = New System.Drawing.Point(1165, 4)
        Me.cbCompType.Margin = New System.Windows.Forms.Padding(10)
        Me.cbCompType.Name = "cbCompType"
        Me.cbCompType.Size = New System.Drawing.Size(198, 28)
        Me.cbCompType.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(57, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 29)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "SUMMARY"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel8.Controls.Add(Me.lblComSM)
        Me.Panel8.Controls.Add(Me.lblComSY)
        Me.Panel8.Controls.Add(Me.lblComSW)
        Me.Panel8.Controls.Add(Me.lblComST)
        Me.Panel8.Location = New System.Drawing.Point(1037, 31)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(401, 202)
        Me.Panel8.TabIndex = 2
        '
        'lblComSM
        '
        Me.lblComSM.AutoSize = True
        Me.lblComSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComSM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblComSM.Location = New System.Drawing.Point(10, 112)
        Me.lblComSM.Name = "lblComSM"
        Me.lblComSM.Size = New System.Drawing.Size(163, 37)
        Me.lblComSM.TabIndex = 7
        Me.lblComSM.Text = "MONTH - "
        Me.lblComSM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComSY
        '
        Me.lblComSY.AutoSize = True
        Me.lblComSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComSY.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblComSY.Location = New System.Drawing.Point(13, 158)
        Me.lblComSY.Name = "lblComSY"
        Me.lblComSY.Size = New System.Drawing.Size(132, 37)
        Me.lblComSY.TabIndex = 6
        Me.lblComSY.Text = "YEAR - "
        Me.lblComSY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComSW
        '
        Me.lblComSW.AutoSize = True
        Me.lblComSW.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComSW.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblComSW.Location = New System.Drawing.Point(10, 68)
        Me.lblComSW.Name = "lblComSW"
        Me.lblComSW.Size = New System.Drawing.Size(139, 37)
        Me.lblComSW.TabIndex = 5
        Me.lblComSW.Text = "WEEK - "
        Me.lblComSW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComST
        '
        Me.lblComST.AutoSize = True
        Me.lblComST.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComST.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblComST.Location = New System.Drawing.Point(10, 24)
        Me.lblComST.Name = "lblComST"
        Me.lblComST.Size = New System.Drawing.Size(157, 37)
        Me.lblComST.TabIndex = 4
        Me.lblComST.Text = "TODAY - "
        Me.lblComST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel9.Controls.Add(Me.lblSerSM)
        Me.Panel9.Controls.Add(Me.lblSerSY)
        Me.Panel9.Controls.Add(Me.lblSerSW)
        Me.Panel9.Controls.Add(Me.lblserST)
        Me.Panel9.Location = New System.Drawing.Point(53, 29)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(401, 204)
        Me.Panel9.TabIndex = 0
        '
        'lblSerSM
        '
        Me.lblSerSM.AutoSize = True
        Me.lblSerSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerSM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSerSM.Location = New System.Drawing.Point(3, 116)
        Me.lblSerSM.Name = "lblSerSM"
        Me.lblSerSM.Size = New System.Drawing.Size(163, 37)
        Me.lblSerSM.TabIndex = 3
        Me.lblSerSM.Text = "MONTH - "
        Me.lblSerSM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSerSY
        '
        Me.lblSerSY.AutoSize = True
        Me.lblSerSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerSY.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSerSY.Location = New System.Drawing.Point(6, 162)
        Me.lblSerSY.Name = "lblSerSY"
        Me.lblSerSY.Size = New System.Drawing.Size(132, 37)
        Me.lblSerSY.TabIndex = 2
        Me.lblSerSY.Text = "YEAR - "
        Me.lblSerSY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSerSW
        '
        Me.lblSerSW.AutoSize = True
        Me.lblSerSW.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerSW.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSerSW.Location = New System.Drawing.Point(3, 72)
        Me.lblSerSW.Name = "lblSerSW"
        Me.lblSerSW.Size = New System.Drawing.Size(139, 37)
        Me.lblSerSW.TabIndex = 1
        Me.lblSerSW.Text = "WEEK - "
        Me.lblSerSW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblserST
        '
        Me.lblserST.AutoSize = True
        Me.lblserST.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserST.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblserST.Location = New System.Drawing.Point(3, 28)
        Me.lblserST.Name = "lblserST"
        Me.lblserST.Size = New System.Drawing.Size(157, 37)
        Me.lblserST.TabIndex = 0
        Me.lblserST.Text = "TODAY - "
        Me.lblserST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel10.Controls.Add(Me.lblAmcSM)
        Me.Panel10.Controls.Add(Me.lblAmcSY)
        Me.Panel10.Controls.Add(Me.lblAmcSW)
        Me.Panel10.Controls.Add(Me.lblAmcST)
        Me.Panel10.Location = New System.Drawing.Point(551, 31)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(401, 203)
        Me.Panel10.TabIndex = 1
        '
        'lblAmcSM
        '
        Me.lblAmcSM.AutoSize = True
        Me.lblAmcSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmcSM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAmcSM.Location = New System.Drawing.Point(14, 117)
        Me.lblAmcSM.Name = "lblAmcSM"
        Me.lblAmcSM.Size = New System.Drawing.Size(163, 37)
        Me.lblAmcSM.TabIndex = 7
        Me.lblAmcSM.Text = "MONTH - "
        Me.lblAmcSM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmcSY
        '
        Me.lblAmcSY.AutoSize = True
        Me.lblAmcSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmcSY.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAmcSY.Location = New System.Drawing.Point(17, 163)
        Me.lblAmcSY.Name = "lblAmcSY"
        Me.lblAmcSY.Size = New System.Drawing.Size(132, 37)
        Me.lblAmcSY.TabIndex = 6
        Me.lblAmcSY.Text = "YEAR - "
        Me.lblAmcSY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmcSW
        '
        Me.lblAmcSW.AutoSize = True
        Me.lblAmcSW.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmcSW.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAmcSW.Location = New System.Drawing.Point(14, 73)
        Me.lblAmcSW.Name = "lblAmcSW"
        Me.lblAmcSW.Size = New System.Drawing.Size(139, 37)
        Me.lblAmcSW.TabIndex = 5
        Me.lblAmcSW.Text = "WEEK - "
        Me.lblAmcSW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmcST
        '
        Me.lblAmcST.AutoSize = True
        Me.lblAmcST.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmcST.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAmcST.Location = New System.Drawing.Point(14, 29)
        Me.lblAmcST.Name = "lblAmcST"
        Me.lblAmcST.Size = New System.Drawing.Size(157, 37)
        Me.lblAmcST.TabIndex = 4
        Me.lblAmcST.Text = "TODAY - "
        Me.lblAmcST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dashboard_Home_Module_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1480, 771)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Dashboard_Home_Module_Form"
        Me.Text = "Dashboard_Home_Module_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlOperation.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.dgvComplainDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        CType(Me.dgvServiceDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlOperation As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotSer As Label
    Friend WithEvents lblTotAmcSale As Label
    Friend WithEvents lblTotComplain As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblserST As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSerSM As Label
    Friend WithEvents lblSerSY As Label
    Friend WithEvents lblSerSW As Label
    Friend WithEvents lblAmcSM As Label
    Friend WithEvents lblAmcSY As Label
    Friend WithEvents lblAmcSW As Label
    Friend WithEvents lblAmcST As Label
    Friend WithEvents lblComSM As Label
    Friend WithEvents lblComSY As Label
    Friend WithEvents lblComSW As Label
    Friend WithEvents lblComST As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cbCompType As ComboBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents dgvServiceDetails As DataGridView
    Friend WithEvents dgvComplainDetails As DataGridView
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents cbServiceListDate As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbServiceListType As ComboBox
    Friend WithEvents cbComplainType As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbEmpId As ComboBox
End Class
