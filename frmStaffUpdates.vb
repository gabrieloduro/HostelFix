Public Class frmStaffUpdates

    Private loading As Boolean = False

    Private Async Sub frmStaffUpdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStaffComplaints.AllowUserToAddRows = False
        dgvStaffComplaints.ReadOnly = True
        dgvStaffComplaints.RowHeadersVisible = False
        dgvStaffComplaints.MultiSelect = False
        dgvStaffComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStaffComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange({"Pending", "Assigned", "Resolved"})

        cmbTechnician.Items.Clear()
        cmbTechnician.Items.AddRange({"Technician 1", "Technician 2", "Technician 3"}) ' edit names

        Await LoadGrid()
    End Sub

    Private Function SelectedId() As Integer
        If dgvStaffComplaints.CurrentRow Is Nothing OrElse dgvStaffComplaints.CurrentRow.Tag Is Nothing Then Return -1
        Return CInt(dgvStaffComplaints.CurrentRow.Tag)
    End Function

    Private Async Function LoadGrid() As Task
        Dim keepId As Integer = SelectedId()
        If Not Await LoadComplaintsAsync() Then
            MessageBox.Show("Could not load complaints. Check the connection.")
            Return
        End If

        loading = True
        dgvStaffComplaints.Rows.Clear()
        For Each c In Complaints
            Dim i As Integer = dgvStaffComplaints.Rows.Add(c.Reference, c.Room, c.Category, c.Priority, c.Status)
            dgvStaffComplaints.Rows(i).Tag = c.Id
            If c.Priority = "Emergency" AndAlso c.Status <> "Resolved" Then
                dgvStaffComplaints.Rows(i).DefaultCellStyle.BackColor = Color.MistyRose
                dgvStaffComplaints.Rows(i).DefaultCellStyle.ForeColor = Color.DarkRed
            End If
            If c.Id = keepId Then dgvStaffComplaints.CurrentCell = dgvStaffComplaints.Rows(i).Cells(0)
        Next
        If keepId = -1 Then dgvStaffComplaints.ClearSelection()
        loading = False
    End Function

    Private Sub dgvStaffComplaints_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStaffComplaints.SelectionChanged
        If loading Then Return
        Dim id As Integer = SelectedId()
        If id = -1 Then Return
        Dim c = Complaints.FirstOrDefault(Function(x) x.Id = id)
        If c Is Nothing Then Return
        cmbStatus.Text = c.Status
        cmbTechnician.Text = If(c.Technician, "")
        txtStaffNote.Clear()
    End Sub

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As Integer = SelectedId()
        If id = -1 Then
            MessageBox.Show("Select a complaint first.")
            Return
        End If
        If cmbStatus.Text = "" Then
            MessageBox.Show("Choose a status.")
            Return
        End If
        If cmbStatus.Text = "Assigned" AndAlso cmbTechnician.Text.Trim() = "" Then
            MessageBox.Show("Choose a technician before marking it Assigned.")
            Return
        End If

        btnUpdate.Enabled = False
        Dim ok As Boolean = Await UpdateComplaintAsync(id, cmbStatus.Text,
                                                       cmbTechnician.Text.Trim(), txtStaffNote.Text.Trim())
        btnUpdate.Enabled = True

        If ok Then
            MessageBox.Show("Update saved.")
            txtStaffNote.Clear()
            Await LoadGrid()
        Else
            MessageBox.Show("Could not save. Check the connection and try again.")
        End If
    End Sub

End Class