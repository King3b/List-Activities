Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numbers, counter As Integer
        Do
            Randomize()
            Numbers = Int(50 * Rnd() + 1)
            lstNumb.Items.Add(Numbers)
            counter += 1

        Loop Until counter = 10

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form7 As New Form7()
        form7.Show()
    End Sub
End Class