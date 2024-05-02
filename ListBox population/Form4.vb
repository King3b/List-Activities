Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim letter As String
        Dim i As Integer
        Dim names = {"Jhon", "amy", "Adam", "Trent", "Aladin", "Jhonny", "Thabo"}
        letter = txtLetter.Text
        For i = 1 To names.Length - 1
            lstNames.Items.Add(names(i))
        Next

        For i = 1 To names.Length - 1
            If names(i).StartsWith(letter) Then
                lstLetters.Items.Add(names(i))
            End If

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form6 As New Form6()
        form6.Show()
    End Sub
End Class