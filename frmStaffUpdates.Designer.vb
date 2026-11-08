<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffUpdates
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvStaffComplaints = New System.Windows.Forms.DataGridView()
        Me.colStaffRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStaffRoom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStuffIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStaffPriority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStaffStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTechnician = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStaffNote = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvStaffComplaints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 35)
        Me.Label1.MinimumSize = New System.Drawing.Size(650, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maintenance Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'dgvStaffComplaints
        '
        Me.dgvStaffComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaffComplaints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStaffRef, Me.colStaffRoom, Me.colStuffIssue, Me.colStaffPriority, Me.colStaffStatus})
        Me.dgvStaffComplaints.Location = New System.Drawing.Point(40, 110)
        Me.dgvStaffComplaints.MinimumSize = New System.Drawing.Size(850, 220)
        Me.dgvStaffComplaints.Name = "dgvStaffComplaints"
        Me.dgvStaffComplaints.RowHeadersWidth = 51
        Me.dgvStaffComplaints.RowTemplate.Height = 24
        Me.dgvStaffComplaints.Size = New System.Drawing.Size(850, 220)
        Me.dgvStaffComplaints.TabIndex = 2
        '
        'colStaffRef
        '
        Me.colStaffRef.HeaderText = "Reference"
        Me.colStaffRef.MinimumWidth = 6
        Me.colStaffRef.Name = "colStaffRef"
        Me.colStaffRef.Width = 125
        '
        'colStaffRoom
        '
        Me.colStaffRoom.HeaderText = "Room"
        Me.colStaffRoom.MinimumWidth = 6
        Me.colStaffRoom.Name = "colStaffRoom"
        Me.colStaffRoom.Width = 125
        '
        'colStuffIssue
        '
        Me.colStuffIssue.HeaderText = "Issue"
        Me.colStuffIssue.MinimumWidth = 6
        Me.colStuffIssue.Name = "colStuffIssue"
        Me.colStuffIssue.Width = 125
        '
        'colStaffPriority
        '
        Me.colStaffPriority.HeaderText = "Priority"
        Me.colStaffPriority.MinimumWidth = 6
        Me.colStaffPriority.Name = "colStaffPriority"
        Me.colStaffPriority.Width = 125
        '
        'colStaffStatus
        '
        Me.colStaffStatus.HeaderText = "Status"
        Me.colStaffStatus.MinimumWidth = 6
        Me.colStaffStatus.Name = "colStaffStatus"
        Me.colStaffStatus.Width = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Assign Technician"
        '
        'cmbTechnician
        '
        Me.cmbTechnician.FormattingEnabled = True
        Me.cmbTechnician.Items.AddRange(New Object() {"Mr.Apau(Electrician)", "Mr.Asiedu(Plumber)", "Mr.Yaw Donkor(Carpenter)", "Mr.Agyenim Boateng(Mason)", "Mr.Setsofia(Electrician)"})
        Me.cmbTechnician.Location = New System.Drawing.Point(40, 405)
        Me.cmbTechnician.MinimumSize = New System.Drawing.Size(350, 0)
        Me.cmbTechnician.Name = "cmbTechnician"
        Me.cmbTechnician.Size = New System.Drawing.Size(350, 24)
        Me.cmbTechnician.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Update Complaint Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Submitted", "Acknowledged", "Assigned", "In Progress", "Resolved ", "Confrimedd by student", "Reopened"})
        Me.cmbStatus.Location = New System.Drawing.Point(40, 495)
        Me.cmbStatus.MinimumSize = New System.Drawing.Size(350, 0)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(350, 24)
        Me.cmbStatus.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Staff Remarks"
        '
        'txtStaffNote
        '
        Me.txtStaffNote.Location = New System.Drawing.Point(430, 405)
        Me.txtStaffNote.MinimumSize = New System.Drawing.Size(400, 100)
        Me.txtStaffNote.Multiline = True
        Me.txtStaffNote.Name = "txtStaffNote"
        Me.txtStaffNote.Size = New System.Drawing.Size(400, 100)
        Me.txtStaffNote.TabIndex = 8
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(430, 530)
        Me.btnUpdate.MinimumSize = New System.Drawing.Size(170, 45)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(170, 45)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Save Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'frmStaffUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 703)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtStaffNote)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTechnician)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvStaffComplaints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStaffUpdates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStaffUpdates"
        CType(Me.dgvStaffComplaints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvStaffComplaints As DataGridView
    Friend WithEvents colStaffRef As DataGridViewTextBoxColumn
    Friend WithEvents colStaffRoom As DataGridViewTextBoxColumn
    Friend WithEvents colStuffIssue As DataGridViewTextBoxColumn
    Friend WithEvents colStaffPriority As DataGridViewTextBoxColumn
    Friend WithEvents colStaffStatus As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTechnician As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStaffNote As TextBox
    Friend WithEvents btnUpdate As Button
End Class
