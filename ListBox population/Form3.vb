Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim number As Integer
        number = txtNum.Text
        lstNumbers.Items.Add(number)
        txtNum.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2, anw As Integer
        anw = 0
        Do While lstNumbers.Items.Count > 0
            num1 = CInt(lstNumbers.Items(0))
            anw += num1
            lstNumbers.Items.RemoveAt(0)


        Loop
        txtNum.Text = anw.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form4 As New Form4
        form4.Show()
    End Sub
End Class