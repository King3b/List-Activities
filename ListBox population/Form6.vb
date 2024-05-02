Imports System.Diagnostics.CodeAnalysis

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Dim isValid As Boolean
        age = txtAge.Text
        Do
            If age >= 1 And age <= 100 Then
                isValid = True
                MessageBox.Show("age is valid")
            Else
                isValid = False
                MessageBox.Show("age is not valid try again")
                Exit Do
            End If

        Loop Until isValid = True



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form5 As New Form5()
        form5.Show()
    End Sub
End Class