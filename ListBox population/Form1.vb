Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Fruits As String
        Dim isFruit As Boolean = True
        Fruits = txtFruits.Text

        Do While isFruit = True
            If Fruits.ToUpper <> "DONE" Then
                lstFruits.Items.Add(Fruits)
                MessageBox.Show(Fruits + " has been added")
                txtFruits.Text = ""
                Exit Do
            End If
            isFruit = False
            If isFruit = False Then
                MessageBox.Show("stop adding fruits plz")
            End If

        Loop



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form7 As New Form7()
        form7.Show()
    End Sub
End Class
