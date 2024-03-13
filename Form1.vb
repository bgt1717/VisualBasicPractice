Public Class Form1

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        ' This is another comment. It explains that a message is displayed after a click.
        MsgBox("message after a click.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' This is an event handler. You can add code here to handle Button1 click event.

        ' Dim is dimension. Setting a size or dimension of variable. The size of the variable is dependent on the data type. 
        ' String = 1 byte of memory. Visual Basic will take care of memory. 
        ' Name convention is using Camal Case. It is a string variable so the name is starting with st. 
        Dim stFirstName As String

        'Since the name is 5 characters, the variable will take 5 bytes of memory. 
        stFirstName = "Bryce"

        'Concatenates the string and varaible contents in a message box.
        MsgBox("Hello, how are you " & stFirstName & "?")

        'Contents of variable are overriden. 
        stFirstName = "Not Bryce"
        MsgBox("Hello, how are you " & stFirstName & "?")

    End Sub
End Class
