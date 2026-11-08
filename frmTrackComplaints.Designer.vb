<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrackComplaints
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTrackTitle = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStatusTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUpdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlStatus.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTrackTitle
        '
        Me.lblTrackTitle.AutoSize = True
        Me.lblTrackTitle.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackTitle.Location = New System.Drawing.Point(40, 35)
        Me.lblTrackTitle.Name = "lblTrackTitle"
        Me.lblTrackTitle.Size = New System.Drawing.Size(370, 44)
        Me.lblTrackTitle.TabIndex = 0
        Me.lblTrackTitle.Text = "Track My Complaint"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(40, 150)
        Me.txtReference.MinimumSize = New System.Drawing.Size(350, 35)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(350, 22)
        Me.txtReference.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(410, 150)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(170, 35)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search Complaint"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.White
        Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Controls.Add(Me.lblStatusTitle)
        Me.pnlStatus.Location = New System.Drawing.Point(40, 220)
        Me.pnlStatus.MinimumSize = New System.Drawing.Size(750, 120)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(750, 120)
        Me.pnlStatus.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Navy
        Me.lblStatus.Location = New System.Drawing.Point(15, 45)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(172, 21)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Awaiting Search...."
        '
        'lblStatusTitle
        '
        Me.lblStatusTitle.AutoSize = True
        Me.lblStatusTitle.BackColor = System.Drawing.Color.Gray
        Me.lblStatusTitle.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusTitle.Location = New System.Drawing.Point(15, 14)
        Me.lblStatusTitle.Name = "lblStatusTitle"
        Me.lblStatusTitle.Size = New System.Drawing.Size(99, 22)
        Me.lblStatusTitle.TabIndex = 0
        Me.lblStatusTitle.Text = "Current Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Complaint Progress History"
        '
        'dgvHistory
        '
        Me.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colUpdate, Me.colRemarks})
        Me.dgvHistory.Location = New System.Drawing.Point(30, 415)
        Me.dgvHistory.MinimumSize = New System.Drawing.Size(790, 220)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.RowHeadersWidth = 51
        Me.dgvHistory.RowTemplate.Height = 24
        Me.dgvHistory.Size = New System.Drawing.Size(790, 220)
        Me.dgvHistory.TabIndex = 6
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.MinimumWidth = 6
        Me.colDate.Name = "colDate"
        '
        'colUpdate
        '
        Me.colUpdate.HeaderText = "Update"
        Me.colUpdate.MinimumWidth = 6
        Me.colUpdate.Name = "colUpdate"
        '
        'colRemarks
        '
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.MinimumWidth = 6
        Me.colRemarks.Name = "colRemarks"
        '
        'frmTrackComplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1132, 703)
        Me.Controls.Add(Me.dgvHistory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.lblTrackTitle)
        Me.Name = "frmTrackComplaints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Track Complaints"
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTrackTitle As Label
    Friend WithEvents txtReference As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnSearch As Button
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblStatusTitle As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colUpdate As DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As DataGridViewTextBoxColumn
End Class
