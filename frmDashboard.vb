Public Class frmDashboard

    ' Controls this code expects on the form (rename here or in the designer to match):
    '   Labels:    lblTotal, lblPending, lblAssigned, lblResolved, lblEmergency, lblConnection
    '   Grid:      dgvComplaints   (ReadOnly, FullRowSelect, SelectionMode = FullRowSelect)
    '   Editors:   cboStatus (DropDownList), cboTechnician (DropDown), btnUpdate
    '   Timer:     tmrRefresh (Interval = 15000)
    '   Buttons:   btnReportIssue, btnTrackComplaint, btnStaffUpdates

    Private isRefreshing As Boolean = False
    Private lastCount As Integer = -1

    Private Async Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.Items.AddRange({"Pending", "Assigned", "Resolved"})
        cboTechnician.Items.AddRange({"Technician 1", "Technician 2", "Technician 3"}) ' edit names
        Await RefreshDashboard()
        tmrRefresh.Start()
    End Sub

    Private Async Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        Await RefreshDashboard()
    End Sub

    Private Async Function RefreshDashboard() As Task
        If isRefreshing Then Return
        isRefreshing = True
        Try
            Dim ok As Boolean = Await LoadComplaintsAsync()
            lblConnection.Text = If(ok, "Live", "Offline, retrying")
            If Not ok Then Return

            lblTotal.Text = Complaints.Count.ToString()
            lblPending.Text = CountByStatus("Pending").ToString()
            lblAssigned.Text = CountByStatus("Assigned").ToString()
            lblResolved.Text = CountByStatus("Resolved").ToString()
            lblEmergency.Text = CountOpenEmergencies().ToString()

            FillGrid()

            If lastCount >= 0 AndAlso Complaints.Count > lastCount Then
                System.Media.SystemSounds.Exclamation.Play()
            End If
            lastCount = Complaints.Count
        Finally
            isRefreshing = False
        End Try
    End Function

    Private Sub FillGrid()
        Dim selectedId As Integer = -1
        If dgvComplaints.CurrentRow IsNot Nothing Then
            selectedId = CInt(dgvComplaints.CurrentRow.Cells("Id").Value)
        End If

        dgvComplaints.DataSource = Complaints.Select(Function(c) New With {
            c.Id, c.Reference, c.Hostel, c.Room, c.Category,
            c.Priority, c.Status, c.Technician, c.CreatedAt
        }).ToList()
        dgvComplaints.Columns("Id").Visible = False

        For Each row As DataGridViewRow In dgvComplaints.Rows
            If row.Cells("Priority").Value?.ToString() = "Emergency" AndAlso
               row.Cells("Status").Value?.ToString() <> "Resolved" Then
                row.DefaultCellStyle.BackColor = Color.MistyRose
                row.DefaultCellStyle.ForeColor = Color.DarkRed
            End If
            If CInt(row.Cells("Id").Value) = selectedId Then
                dgvComplaints.CurrentCell = row.Cells("Reference")
            End If
        Next
    End Sub

    ' Show the selected complaint's current values in the editors
    Private Sub dgvComplaints_SelectionChanged(sender As Object, e As EventArgs) Handles dgvComplaints.SelectionChanged
        If dgvComplaints.CurrentRow Is Nothing Then Return
        cboStatus.Text = dgvComplaints.CurrentRow.Cells("Status").Value?.ToString()
        cboTechnician.Text = dgvComplaints.CurrentRow.Cells("Technician").Value?.ToString()
    End Sub

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvComplaints.CurrentRow Is Nothing Then
            MessageBox.Show("Select a complaint first.")
            Return
        End If
        If cboStatus.Text = "" Then
            MessageBox.Show("Choose a status.")
            Return
        End If
        If cboStatus.Text = "Assigned" AndAlso cboTechnician.Text.Trim() = "" Then
            MessageBox.Show("Choose a technician before marking it Assigned.")
            Return
        End If

        Dim id As Integer = CInt(dgvComplaints.CurrentRow.Cells("Id").Value)
        btnUpdate.Enabled = False
        Dim ok As Boolean = Await UpdateComplaintAsync(id, cboStatus.Text, cboTechnician.Text.Trim())
        btnUpdate.Enabled = True

        If ok Then
            Await RefreshDashboard()
        Else
            MessageBox.Show("Could not save. Check the internet connection and try again.")
        End If
    End Sub

    ' Navigation (each button handles only its own click)
    Private Sub btnReportIssue_Click(sender As Object, e As EventArgs) Handles btnReportIssue.Click
        OpenForm(New frmReportIssue())
    End Sub

    Private Sub btnTrackComplaint_Click(sender As Object, e As EventArgs) Handles btnTrackComplaint.Click
        OpenForm(New frmTrackComplaints())
    End Sub

    Private Sub btnStaffUpdates_Click(sender As Object, e As EventArgs) Handles btnStaffUpdates.Click
        OpenForm(New frmStaffUpdates())
    End Sub

    Private Sub OpenForm(target As Form)
        AddHandler target.FormClosed, Sub() Me.Show()
        Me.Hide()
        target.Show()
    End Sub

End Class
