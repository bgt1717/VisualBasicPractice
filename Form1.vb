Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("This acts like a constructor")
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        MsgBox("message after a click.")


    End Sub
End Class
