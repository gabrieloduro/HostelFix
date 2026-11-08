<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.btnReportIssue = New System.Windows.Forms.Button()
        Me.btnTrackComplaints = New System.Windows.Forms.Button()
        Me.btnStaffUpdates = New System.Windows.Forms.Button()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.dgvComplaints = New System.Windows.Forms.DataGridView()
        Me.colReference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPriority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRecentComplaints = New System.Windows.Forms.Label()
        Me.pnlEmergency = New System.Windows.Forms.Panel()
        Me.lblEmergency = New System.Windows.Forms.Label()
        Me.lblEmergencyTitle = New System.Windows.Forms.Label()
        Me.pnlResolved = New System.Windows.Forms.Panel()
        Me.lblResolved = New System.Windows.Forms.Label()
        Me.lblResolvedTitle = New System.Windows.Forms.Label()
        Me.pnlPending = New System.Windows.Forms.Panel()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.lblPendingTitle = New System.Windows.Forms.Label()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDashboardTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        CType(Me.dgvComplaints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmergency.SuspendLayout()
        Me.pnlResolved.SuspendLayout()
        Me.pnlPending.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblSubtitle)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.lblAppName)
        Me.pnlSidebar.Controls.Add(Me.btnReportIssue)
        Me.pnlSidebar.Controls.Add(Me.btnTrackComplaints)
        Me.pnlSidebar.Controls.Add(Me.btnStaffUpdates)
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.MinimumSize = New System.Drawing.Size(230, 710)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(230, 710)
        Me.pnlSidebar.TabIndex = 0
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(30, 48)
        Me.lblSubtitle.MinimumSize = New System.Drawing.Size(190, 25)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(190, 25)
        Me.lblSubtitle.TabIndex = 8
        Me.lblSubtitle.Text = "HOSTEL MAINTENANCE"
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(12, 473)
        Me.btnDashboard.MinimumSize = New System.Drawing.Size(200, 45)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 53)
        Me.btnDashboard.TabIndex = 6
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.BackColor = System.Drawing.Color.Transparent
        Me.lblAppName.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.ForeColor = System.Drawing.Color.White
        Me.lblAppName.Location = New System.Drawing.Point(3, 18)
        Me.lblAppName.MinimumSize = New System.Drawing.Size(190, 55)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(217, 55)
        Me.lblAppName.TabIndex = 1
        Me.lblAppName.Text = "UPSA HOSTEL-FIX"
        '
        'btnReportIssue
        '
        Me.btnReportIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportIssue.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportIssue.ForeColor = System.Drawing.Color.White
        Me.btnReportIssue.Location = New System.Drawing.Point(12, 313)
        Me.btnReportIssue.MinimumSize = New System.Drawing.Size(200, 45)
        Me.btnReportIssue.Name = "btnReportIssue"
        Me.btnReportIssue.Size = New System.Drawing.Size(200, 53)
        Me.btnReportIssue.TabIndex = 2
        Me.btnReportIssue.Text = "Report Issue"
        Me.btnReportIssue.UseVisualStyleBackColor = True
        '
        'btnTrackComplaints
        '
        Me.btnTrackComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrackComplaints.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackComplaints.ForeColor = System.Drawing.Color.White
        Me.btnTrackComplaints.Location = New System.Drawing.Point(12, 238)
        Me.btnTrackComplaints.MinimumSize = New System.Drawing.Size(200, 45)
        Me.btnTrackComplaints.Name = "btnTrackComplaints"
        Me.btnTrackComplaints.Size = New System.Drawing.Size(200, 57)
        Me.btnTrackComplaints.TabIndex = 4
        Me.btnTrackComplaints.Text = "Track Complaint"
        Me.btnTrackComplaints.UseVisualStyleBackColor = True
        '
        'btnStaffUpdates
        '
        Me.btnStaffUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffUpdates.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffUpdates.ForeColor = System.Drawing.Color.White
        Me.btnStaffUpdates.Location = New System.Drawing.Point(12, 393)
        Me.btnStaffUpdates.MinimumSize = New System.Drawing.Size(200, 45)
        Me.btnStaffUpdates.Name = "btnStaffUpdates"
        Me.btnStaffUpdates.Size = New System.Drawing.Size(200, 53)
        Me.btnStaffUpdates.TabIndex = 5
        Me.btnStaffUpdates.Text = "Staff Updates"
        Me.btnStaffUpdates.UseVisualStyleBackColor = True
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.Color.White
        Me.pnlDashboard.Controls.Add(Me.dgvComplaints)
        Me.pnlDashboard.Controls.Add(Me.lblRecentComplaints)
        Me.pnlDashboard.Controls.Add(Me.pnlEmergency)
        Me.pnlDashboard.Controls.Add(Me.pnlResolved)
        Me.pnlDashboard.Controls.Add(Me.pnlPending)
        Me.pnlDashboard.Controls.Add(Me.pnlTotal)
        Me.pnlDashboard.Controls.Add(Me.Label1)
        Me.pnlDashboard.Controls.Add(Me.lblDashboardTitle)
        Me.pnlDashboard.Location = New System.Drawing.Point(230, 0)
        Me.pnlDashboard.MinimumSize = New System.Drawing.Size(900, 710)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(907, 710)
        Me.pnlDashboard.TabIndex = 6
        '
        'dgvComplaints
        '
        Me.dgvComplaints.AllowUserToAddRows = False
        Me.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvComplaints.BackgroundColor = System.Drawing.Color.White
        Me.dgvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComplaints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReference, Me.colIssue, Me.colPriority, Me.colStatus})
        Me.dgvComplaints.Location = New System.Drawing.Point(30, 415)
        Me.dgvComplaints.MinimumSize = New System.Drawing.Size(790, 220)
        Me.dgvComplaints.Name = "dgvComplaints"
        Me.dgvComplaints.ReadOnly = True
        Me.dgvComplaints.RowHeadersVisible = False
        Me.dgvComplaints.RowHeadersWidth = 51
        Me.dgvComplaints.RowTemplate.Height = 24
        Me.dgvComplaints.Size = New System.Drawing.Size(790, 220)
        Me.dgvComplaints.TabIndex = 7
        '
        'colReference
        '
        Me.colReference.HeaderText = "Reference"
        Me.colReference.MinimumWidth = 6
        Me.colReference.Name = "colReference"
        Me.colReference.ReadOnly = True
        '
        'colIssue
        '
        Me.colIssue.HeaderText = "Issue"
        Me.colIssue.MinimumWidth = 6
        Me.colIssue.Name = "colIssue"
        Me.colIssue.ReadOnly = True
        '
        'colPriority
        '
        Me.colPriority.HeaderText = "Priority"
        Me.colPriority.MinimumWidth = 6
        Me.colPriority.Name = "colPriority"
        Me.colPriority.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 6
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'lblRecentComplaints
        '
        Me.lblRecentComplaints.AutoSize = True
        Me.lblRecentComplaints.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentComplaints.Location = New System.Drawing.Point(30, 370)
        Me.lblRecentComplaints.MinimumSize = New System.Drawing.Size(400, 35)
        Me.lblRecentComplaints.Name = "lblRecentComplaints"
        Me.lblRecentComplaints.Size = New System.Drawing.Size(400, 35)
        Me.lblRecentComplaints.TabIndex = 6
        Me.lblRecentComplaints.Text = "Recent Complaints"
        '
        'pnlEmergency
        '
        Me.pnlEmergency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEmergency.Controls.Add(Me.lblEmergency)
        Me.pnlEmergency.Controls.Add(Me.lblEmergencyTitle)
        Me.pnlEmergency.Location = New System.Drawing.Point(340, 240)
        Me.pnlEmergency.MinimumSize = New System.Drawing.Size(280, 100)
        Me.pnlEmergency.Name = "pnlEmergency"
        Me.pnlEmergency.Size = New System.Drawing.Size(280, 100)
        Me.pnlEmergency.TabIndex = 5
        '
        'lblEmergency
        '
        Me.lblEmergency.AutoSize = True
        Me.lblEmergency.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergency.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEmergency.Location = New System.Drawing.Point(15, 45)
        Me.lblEmergency.MinimumSize = New System.Drawing.Size(240, 40)
        Me.lblEmergency.Name = "lblEmergency"
        Me.lblEmergency.Size = New System.Drawing.Size(240, 44)
        Me.lblEmergency.TabIndex = 2
        Me.lblEmergency.Text = "2"
        '
        'lblEmergencyTitle
        '
        Me.lblEmergencyTitle.AutoSize = True
        Me.lblEmergencyTitle.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergencyTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblEmergencyTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblEmergencyTitle.MinimumSize = New System.Drawing.Size(240, 25)
        Me.lblEmergencyTitle.Name = "lblEmergencyTitle"
        Me.lblEmergencyTitle.Size = New System.Drawing.Size(240, 25)
        Me.lblEmergencyTitle.TabIndex = 1
        Me.lblEmergencyTitle.Text = "Emergency"
        '
        'pnlResolved
        '
        Me.pnlResolved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlResolved.Controls.Add(Me.lblResolved)
        Me.pnlResolved.Controls.Add(Me.lblResolvedTitle)
        Me.pnlResolved.Location = New System.Drawing.Point(30, 240)
        Me.pnlResolved.MinimumSize = New System.Drawing.Size(280, 100)
        Me.pnlResolved.Name = "pnlResolved"
        Me.pnlResolved.Size = New System.Drawing.Size(280, 100)
        Me.pnlResolved.TabIndex = 4
        '
        'lblResolved
        '
        Me.lblResolved.AutoSize = True
        Me.lblResolved.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblResolved.Location = New System.Drawing.Point(15, 45)
        Me.lblResolved.MinimumSize = New System.Drawing.Size(240, 40)
        Me.lblResolved.Name = "lblResolved"
        Me.lblResolved.Size = New System.Drawing.Size(240, 44)
        Me.lblResolved.TabIndex = 2
        Me.lblResolved.Text = "10"
        '
        'lblResolvedTitle
        '
        Me.lblResolvedTitle.AutoSize = True
        Me.lblResolvedTitle.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolvedTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblResolvedTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblResolvedTitle.MinimumSize = New System.Drawing.Size(240, 25)
        Me.lblResolvedTitle.Name = "lblResolvedTitle"
        Me.lblResolvedTitle.Size = New System.Drawing.Size(240, 25)
        Me.lblResolvedTitle.TabIndex = 1
        Me.lblResolvedTitle.Text = "Resolved "
        '
        'pnlPending
        '
        Me.pnlPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPending.Controls.Add(Me.lblPending)
        Me.pnlPending.Controls.Add(Me.lblPendingTitle)
        Me.pnlPending.Location = New System.Drawing.Point(340, 120)
        Me.pnlPending.MinimumSize = New System.Drawing.Size(280, 100)
        Me.pnlPending.Name = "pnlPending"
        Me.pnlPending.Size = New System.Drawing.Size(280, 100)
        Me.pnlPending.TabIndex = 3
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPending.Location = New System.Drawing.Point(15, 45)
        Me.lblPending.MinimumSize = New System.Drawing.Size(240, 40)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(240, 44)
        Me.lblPending.TabIndex = 1
        Me.lblPending.Text = "12"
        '
        'lblPendingTitle
        '
        Me.lblPendingTitle.AutoSize = True
        Me.lblPendingTitle.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblPendingTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblPendingTitle.MinimumSize = New System.Drawing.Size(240, 25)
        Me.lblPendingTitle.Name = "lblPendingTitle"
        Me.lblPendingTitle.Size = New System.Drawing.Size(240, 25)
        Me.lblPendingTitle.TabIndex = 0
        Me.lblPendingTitle.Text = "Pending"
        '
        'pnlTotal
        '
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotal.Controls.Add(Me.lblTotal)
        Me.pnlTotal.Controls.Add(Me.lblTotalTitle)
        Me.pnlTotal.Location = New System.Drawing.Point(30, 120)
        Me.pnlTotal.MinimumSize = New System.Drawing.Size(280, 100)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(280, 100)
        Me.pnlTotal.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(15, 45)
        Me.lblTotal.MinimumSize = New System.Drawing.Size(240, 40)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(240, 44)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "24"
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblTotalTitle.MinimumSize = New System.Drawing.Size(240, 25)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(240, 25)
        Me.lblTotalTitle.TabIndex = 0
        Me.lblTotalTitle.Text = "Total Reports"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(34, 68)
        Me.Label1.MinimumSize = New System.Drawing.Size(650, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Monitor hostel repairs and outstanding complaints"
        '
        'lblDashboardTitle
        '
        Me.lblDashboardTitle.AutoSize = True
        Me.lblDashboardTitle.Font = New System.Drawing.Font("Arial Narrow", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDashboardTitle.Location = New System.Drawing.Point(30, 25)
        Me.lblDashboardTitle.MinimumSize = New System.Drawing.Size(650, 40)
        Me.lblDashboardTitle.Name = "lblDashboardTitle"
        Me.lblDashboardTitle.Size = New System.Drawing.Size(650, 43)
        Me.lblDashboardTitle.TabIndex = 0
        Me.lblDashboardTitle.Text = "Maintenance Dashboard"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 703)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlSidebar)
        Me.MinimumSize = New System.Drawing.Size(1150, 750)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPSA HostelFix-Dashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        CType(Me.dgvComplaints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmergency.ResumeLayout(False)
        Me.pnlEmergency.PerformLayout()
        Me.pnlResolved.ResumeLayout(False)
        Me.pnlResolved.PerformLayout()
        Me.pnlPending.ResumeLayout(False)
        Me.pnlPending.PerformLayout()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblAppName As Label
    Friend WithEvents btnReportIssue As Button
    Friend WithEvents btnTrackComplaints As Button
    Friend WithEvents btnStaffUpdates As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents pnlTotal As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents pnlPending As Panel
    Friend WithEvents lblPending As Label
    Friend WithEvents lblPendingTitle As Label
    Friend WithEvents pnlResolved As Panel
    Friend WithEvents pnlEmergency As Panel
    Friend WithEvents lblEmergency As Label
    Friend WithEvents lblEmergencyTitle As Label
    Friend WithEvents lblResolved As Label
    Friend WithEvents lblResolvedTitle As Label
    Friend WithEvents lblRecentComplaints As Label
    Friend WithEvents dgvComplaints As DataGridView
    Friend WithEvents colReference As DataGridViewTextBoxColumn
    Friend WithEvents colIssue As DataGridViewTextBoxColumn
    Friend WithEvents colPriority As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
End Class
