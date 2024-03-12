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
        startButton = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' startButton
        ' 
        startButton.BackColor = SystemColors.ControlDark
        startButton.Location = New Point(38, 96)
        startButton.Name = "startButton"
        startButton.Size = New Size(305, 128)
        startButton.TabIndex = 0
        startButton.Text = "Press Here"
        startButton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDark
        Button1.Location = New Point(363, 96)
        Button1.Name = "Button1"
        Button1.Size = New Size(305, 128)
        Button1.TabIndex = 1
        Button1.Text = "Press Here"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(startButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents startButton As Button
    Friend WithEvents Button1 As Button

End Class
