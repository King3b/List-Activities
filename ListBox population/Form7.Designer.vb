<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        lstNames = New ListBox()
        Button1 = New Button()
        txtName = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' lstNames
        ' 
        lstNames.FormattingEnabled = True
        lstNames.ItemHeight = 15
        lstNames.Location = New Point(114, 31)
        lstNames.Name = "lstNames"
        lstNames.Size = New Size(186, 334)
        lstNames.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(343, 31)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 23)
        Button1.TabIndex = 1
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(457, 31)
        txtName.Name = "txtName"
        txtName.Size = New Size(149, 23)
        txtName.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(343, 80)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 23)
        Button2.TabIndex = 3
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(txtName)
        Controls.Add(Button1)
        Controls.Add(lstNames)
        Name = "Form7"
        Text = "Form7"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstNames As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Button2 As Button
End Class
