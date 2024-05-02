<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lstNames = New ListBox()
        lstLetters = New ListBox()
        txtLetter = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(535, 48)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 34)
        Button1.TabIndex = 0
        Button1.Text = "Find"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lstNames
        ' 
        lstNames.FormattingEnabled = True
        lstNames.ItemHeight = 15
        lstNames.Location = New Point(272, 134)
        lstNames.Name = "lstNames"
        lstNames.Size = New Size(150, 199)
        lstNames.TabIndex = 1
        ' 
        ' lstLetters
        ' 
        lstLetters.FormattingEnabled = True
        lstLetters.ItemHeight = 15
        lstLetters.Location = New Point(449, 134)
        lstLetters.Name = "lstLetters"
        lstLetters.Size = New Size(150, 199)
        lstLetters.TabIndex = 2
        ' 
        ' txtLetter
        ' 
        txtLetter.Location = New Point(272, 55)
        txtLetter.Name = "txtLetter"
        txtLetter.Size = New Size(207, 23)
        txtLetter.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(116, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 34)
        Button2.TabIndex = 4
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(txtLetter)
        Controls.Add(lstLetters)
        Controls.Add(lstNames)
        Controls.Add(Button1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lstNames As ListBox
    Friend WithEvents lstLetters As ListBox
    Friend WithEvents txtLetter As TextBox
    Friend WithEvents Button2 As Button
End Class
