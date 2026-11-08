Public Class frmTrackComplaints

    Private Sub frmTrackComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvHistory.AllowUserToAddRows = False
        dgvHistory.ReadOnly = True
        dgvHistory.RowHeadersVisible = False
        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.AcceptButton = btnSearch   ' Enter key searches
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim reference As String = txtReference.Text.Trim().ToUpper()
        If reference = "" Then
            MessageBox.Show("Enter a reference number, for example HF012.")
            Return
        End If

        btnSearch.Enabled = False
        lblStatus.Text = "Searching..."
        dgvHistory.Rows.Clear()

        Dim detail = Await GetComplaintDetailAsync(reference)
        btnSearch.Enabled = True

        If detail Is Nothing OrElse detail.Complaint Is Nothing Then
            lblStatus.Text = "No complaint found"
            Return
        End If

        Dim c = detail.Complaint
        lblStatus.Text = c.Status & If(String.IsNullOrEmpty(c.Technician), "", ": " & c.Technician)

        If detail.History IsNot Nothing Then
            For Each h In detail.History
                Dim update As String = h.Status & If(String.IsNullOrEmpty(h.Technician), "", " (" & h.Technician & ")")
                dgvHistory.Rows.Add(h.CreatedAt, update, h.Remarks)
            Next
        End If
    End Sub

End Class