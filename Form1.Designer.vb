<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lstOccuptation
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
        ButtonGo = New Button()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        lbllastName = New Label()
        txtLastName = New TextBox()
        lblGender = New Label()
        txtGender = New TextBox()
        SuspendLayout()
        ' 
        ' startButton
        ' 
        startButton.BackColor = SystemColors.ControlDark
        startButton.Location = New Point(12, 12)
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
        Button1.Location = New Point(12, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 48)
        Button1.TabIndex = 1
        Button1.Text = "Press Here2"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnDataTypes
        ' 
        btnDataTypes.Location = New Point(12, 120)
        btnDataTypes.Name = "btnDataTypes"
        btnDataTypes.Size = New Size(135, 48)
        btnDataTypes.TabIndex = 2
        btnDataTypes.Text = "DataTypes"
        btnDataTypes.UseVisualStyleBackColor = True
        ' 
        ' ButtonGo
        ' 
        ButtonGo.Location = New Point(314, 158)
        ButtonGo.Name = "ButtonGo"
        ButtonGo.Size = New Size(135, 48)
        ButtonGo.TabIndex = 3
        ButtonGo.Text = "ButtonGo"
        ButtonGo.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(314, 32)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(206, 23)
        txtFirstName.TabIndex = 4
        txtFirstName.Text = " "
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(245, 32)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(64, 15)
        lblFirstName.TabIndex = 5
        lblFirstName.Text = "First Name"
        ' 
        ' lbllastName
        ' 
        lbllastName.AutoSize = True
        lbllastName.Location = New Point(245, 66)
        lbllastName.Name = "lbllastName"
        lbllastName.Size = New Size(63, 15)
        lbllastName.TabIndex = 6
        lbllastName.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(314, 66)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(206, 23)
        txtLastName.TabIndex = 7
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(263, 99)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(45, 15)
        lblGender.TabIndex = 8
        lblGender.Text = "Gender"
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(314, 99)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(206, 23)
        txtGender.TabIndex = 9
        ' 
        ' lstOccuptation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1180, 636)
        Controls.Add(txtGender)
        Controls.Add(lblGender)
        Controls.Add(txtLastName)
        Controls.Add(lbllastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        Controls.Add(ButtonGo)
        Controls.Add(btnDataTypes)
        Controls.Add(Button1)
        Controls.Add(startButton)
        Name = "lstOccuptation"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents startButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDataTypes As Button
    Friend WithEvents ButtonGo As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lbllastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGender As TextBox

End Class
