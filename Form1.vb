Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This is a comment. It explains that MsgBox is acting like a constructor.
        MsgBox("This acts like a constructor")
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        ' This is another comment. It explains that a message is displayed after a click.
        MsgBox("message after a click.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' This is an empty event handler. You can add code here to handle Button1 click event.
        ' After cloning.
    End Sub
End Class
