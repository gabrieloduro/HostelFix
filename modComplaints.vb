Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports System.Text.Json.Serialization

Public Class Complaint
    <JsonPropertyName("id")> Public Property Id As Integer
    <JsonPropertyName("reference")> Public Property Reference As String
    <JsonPropertyName("hostel")> Public Property Hostel As String
    <JsonPropertyName("room")> Public Property Room As String
    <JsonPropertyName("category")> Public Property Category As String
    <JsonPropertyName("description")> Public Property Description As String
    <JsonPropertyName("priority")> Public Property Priority As String
    <JsonPropertyName("status")> Public Property Status As String
    <JsonPropertyName("technician")> Public Property Technician As String
    <JsonPropertyName("created_at")> Public Property CreatedAt As String
End Class

Public Module modComplaints

    ' Folder on your host that holds api.php (keep the trailing slash)
    Private Const BaseUrl As String = Secrets.BaseUrl
    ' Must match ADMIN_KEY in config.php
    Private Const ApiKey As String = Secrets.ApiKey


    Public Class HistoryEntry
        <JsonPropertyName("status")> Public Property Status As String
        <JsonPropertyName("technician")> Public Property Technician As String
        <JsonPropertyName("remarks")> Public Property Remarks As String
        <JsonPropertyName("created_at")> Public Property CreatedAt As String
    End Class

    Public Class ComplaintDetail
        <JsonPropertyName("complaint")> Public Property Complaint As Complaint
        <JsonPropertyName("history")> Public Property History As List(Of HistoryEntry)
    End Class

    Public ReadOnly Property WebFormUrl As String
        Get
            Return BaseUrl
        End Get
    End Property

    Private ReadOnly http As HttpClient = CreateClient()
    Public Complaints As New List(Of Complaint)

    Private Function CreateClient() As HttpClient
        Dim c As New HttpClient()
        c.Timeout = TimeSpan.FromSeconds(10)
        c.DefaultRequestHeaders.Add("X-API-KEY", ApiKey)
        Return c
    End Function

    ' Pulls every complaint from the server. Returns False if offline.
    Public Async Function LoadComplaintsAsync() As Task(Of Boolean)
        Try
            Dim json As String = Await http.GetStringAsync(BaseUrl & "api.php")
            Dim list = JsonSerializer.Deserialize(Of List(Of Complaint))(json)
            Complaints = If(list, New List(Of Complaint))
            Return True
        Catch
            Return False
        End Try
    End Function

    ' Saves status and technician for one complaint.
    Public Async Function UpdateComplaintAsync(id As Integer, status As String,
                                           technician As String, remarks As String) As Task(Of Boolean)
        Try
            Dim payload As New Dictionary(Of String, Object) From {
            {"id", id},
            {"status", status},
            {"technician", technician},
            {"remarks", remarks}
        }
            Using content As New StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
                Dim resp = Await http.PostAsync(BaseUrl & "api.php", content)
                Return resp.IsSuccessStatusCode
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Async Function GetComplaintDetailAsync(reference As String) As Task(Of ComplaintDetail)
        Try
            Dim json As String = Await http.GetStringAsync(BaseUrl & "api.php?ref=" & Uri.EscapeDataString(reference))
            Return JsonSerializer.Deserialize(Of ComplaintDetail)(json)
        Catch
            Return Nothing
        End Try
    End Function

    Public Function CountByStatus(status As String) As Integer

        Dim total As Integer = 0

        For Each c As Complaint In Complaints
            If c.Status = status Then
                total += 1
            End If
        Next

        Return total

    End Function


    Public Function CountOpenEmergencies() As Integer

        Dim total As Integer = 0

        For Each c As Complaint In Complaints
            If c.Priority = "Emergency" AndAlso c.Status <> "Resolved" Then
                total += 1
            End If
        Next

        Return total

    End Function
End Module
