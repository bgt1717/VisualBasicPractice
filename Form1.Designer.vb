﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        btnDataTypes = New Button()
        SuspendLayout()
        ' 
        ' startButton
        ' 
        startButton.BackColor = SystemColors.ControlDark
        startButton.Location = New Point(225, 46)
        startButton.Name = "startButton"
        startButton.Size = New Size(135, 48)
        startButton.TabIndex = 0
        startButton.Text = "Press Here"
        startButton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.YellowGreen
        Button1.ForeColor = Color.Crimson
        Button1.Location = New Point(366, 46)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 48)
        Button1.TabIndex = 1
        Button1.Text = "Press Here2"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnDataTypes
        ' 
        btnDataTypes.Location = New Point(225, 100)
        btnDataTypes.Name = "btnDataTypes"
        btnDataTypes.Size = New Size(135, 48)
        btnDataTypes.TabIndex = 2
        btnDataTypes.Text = "DataTypes"
        btnDataTypes.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1180, 636)
        Controls.Add(btnDataTypes)
        Controls.Add(Button1)
        Controls.Add(startButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents startButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDataTypes As Button

End Class
