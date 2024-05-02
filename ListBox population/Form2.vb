Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numb, Anw As Integer

        For Numb = 1 To 20
            If Numb Mod 2 = 0 Then
                lstEven.Items.Add(Numb.ToString)
            ElseIf Numb Mod 2 <> 0 Then
                lstOdd.Items.Add(Numb.ToString)
            End If

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub


End Class