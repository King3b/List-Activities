Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim names = {
            "Emma Johnson",
            "Ethan Martinez",
            "Olivia Smith",
            "Liam Rodriguez",
            "Ava Williams",
            "Noah Brown",
            "Sophia Anderson",
            "Mason Taylor",
            "Isabella Jackson",
            "Lucas Thompson",
            "Mia White",
            "Logan Harris",
            "Amelia Martin",
            "James Garcia",
            "Harper Clark",
            "Benjamin Lewis",
            "Evelyn Lee",
            "Oliver Walker",
            "Charlotte Hall",
            "William Young"
        }
        For i = lstNames.SelectedItems.Count - 1 To 0 Step -1
            If names.Contains(lstNames.SelectedItems(i).ToString()) Then
                lstNames.Items.RemoveAt(lstNames.SelectedIndices(i))
            End If
        Next
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim names = {
            "Emma Johnson",
            "Ethan Martinez",
            "Olivia Smith",
            "Liam Rodriguez",
            "Ava Williams",
            "Noah Brown",
            "Sophia Anderson",
            "Mason Taylor",
            "Isabella Jackson",
            "Lucas Thompson",
            "Mia White",
            "Logan Harris",
            "Amelia Martin",
            "James Garcia",
            "Harper Clark",
            "Benjamin Lewis",
            "Evelyn Lee",
            "Oliver Walker",
            "Charlotte Hall",
            "William Young"
        }
        lstNames.Items.AddRange(names)
    End Sub
End Class