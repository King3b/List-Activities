<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        txtNum = New TextBox()
        lstNumbers = New ListBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(168, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(566, 79)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 33)
        Button2.TabIndex = 1
        Button2.Text = "add Number"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(566, 137)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 37)
        Button3.TabIndex = 2
        Button3.Text = "Calculate"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtNum
        ' 
        txtNum.Location = New Point(300, 79)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(247, 23)
        txtNum.TabIndex = 3
        ' 
        ' lstNumbers
        ' 
        lstNumbers.FormattingEnabled = True
        lstNumbers.ItemHeight = 15
        lstNumbers.Location = New Point(300, 128)
        lstNumbers.Name = "lstNumbers"
        lstNumbers.Size = New Size(247, 229)
        lstNumbers.TabIndex = 4
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstNumbers)
        Controls.Add(txtNum)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents lstNumbers As ListBox
End Class
