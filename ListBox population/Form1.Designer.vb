<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbName = New Label()
        txtFruits = New TextBox()
        lstFruits = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' lbName
        ' 
        lbName.AutoSize = True
        lbName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbName.Location = New Point(255, 58)
        lbName.Name = "lbName"
        lbName.Size = New Size(56, 21)
        lbName.TabIndex = 0
        lbName.Text = "Fruits "
        ' 
        ' txtFruits
        ' 
        txtFruits.Location = New Point(244, 109)
        txtFruits.Name = "txtFruits"
        txtFruits.Size = New Size(184, 23)
        txtFruits.TabIndex = 1
        ' 
        ' lstFruits
        ' 
        lstFruits.FormattingEnabled = True
        lstFruits.ItemHeight = 15
        lstFruits.Location = New Point(244, 153)
        lstFruits.Name = "lstFruits"
        lstFruits.Size = New Size(196, 244)
        lstFruits.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(475, 109)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 23)
        Button1.TabIndex = 3
        Button1.Text = "Add Fruits"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(482, 152)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 23)
        Button2.TabIndex = 4
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lstFruits)
        Controls.Add(txtFruits)
        Controls.Add(lbName)
        Name = "Form1"
        Text = "Fruit List"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbName As Label
    Friend WithEvents txtFruits As TextBox
    Friend WithEvents lstFruits As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
