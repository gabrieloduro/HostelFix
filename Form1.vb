Public Class frmDashboard

    Private WithEvents tmrRefresh As New System.Windows.Forms.Timer With {.Interval = 15000}
    Private isRefreshing As Boolean = False
    Private lastCount As Integer = -1

    Private Async Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvComplaints.AllowUserToAddRows = False
        dgvComplaints.ReadOnly = True
        dgvComplaints.RowHeadersVisible = False
        dgvComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
            Me.Text = If(ok, "UPSA HostelFix-Dashboard", "UPSA HostelFix-Dashboard (offline, retrying)")
            If Not ok Then Return

            lblTotal.Text = Complaints.Count.ToString()
            lblPending.Text = CountByStatus("Pending").ToString()
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
        dgvComplaints.Rows.Clear()
        For Each c In Complaints.OrderByDescending(Function(x) x.Id).Take(10)
            Dim i As Integer = dgvComplaints.Rows.Add(c.Reference, c.Category, c.Priority, c.Status)
            If c.Priority = "Emergency" AndAlso c.Status <> "Resolved" Then
                dgvComplaints.Rows(i).DefaultCellStyle.BackColor = Color.MistyRose
                dgvComplaints.Rows(i).DefaultCellStyle.ForeColor = Color.DarkRed
            End If
        Next
        dgvComplaints.ClearSelection()
    End Sub

    ' Sidebar
    Private Async Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Await RefreshDashboard()
    End Sub

    Private Sub btnReportIssue_Click(sender As Object, e As EventArgs) Handles btnReportIssue.Click
        ' Opens the same web form students use, for walk-in complaints
        Process.Start(New ProcessStartInfo(WebFormUrl) With {.UseShellExecute = True})
    End Sub

    Private Sub btnTrackComplaints_Click(sender As Object, e As EventArgs) Handles btnTrackComplaints.Click
        OpenForm(New frmTrackComplaints())
    End Sub

    Private Sub btnStaffUpdates_Click(sender As Object, e As EventArgs) Handles btnStaffUpdates.Click
        OpenForm(New frmStaffUpdates())
    End Sub

    Private Sub OpenForm(target As Form)
        AddHandler target.FormClosed, Async Sub()
                                          Me.Show()
                                          Await RefreshDashboard()
                                      End Sub
        Me.Hide()
        target.Show()
    End Sub

End Class