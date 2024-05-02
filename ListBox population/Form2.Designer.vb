<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        lstOdd = New ListBox()
        lstEven = New ListBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' lstOdd
        ' 
        lstOdd.FormattingEnabled = True
        lstOdd.ItemHeight = 15
        lstOdd.Location = New Point(204, 211)
        lstOdd.Name = "lstOdd"
        lstOdd.Size = New Size(120, 169)
        lstOdd.TabIndex = 0
        ' 
        ' lstEven
        ' 
        lstEven.FormattingEnabled = True
        lstEven.ItemHeight = 15
        lstEven.Location = New Point(468, 211)
        lstEven.Name = "lstEven"
        lstEven.Size = New Size(120, 184)
        lstEven.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(347, 47)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 35)
        Button1.TabIndex = 2
        Button1.Text = "Numbers"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(228, 175)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 3
        Label1.Text = "Odd"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(513, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 4
        Label2.Text = "Even"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(125, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 5
        Button2.Text = "Next "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(lstEven)
        Controls.Add(lstOdd)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lstOdd As ListBox
    Friend WithEvents lstEven As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
