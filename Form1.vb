Public Class lstOccuptation

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

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        'Integer is a whole number. 
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        'Decimal is more Accurate than Single or Double.
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColor = "red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 19999.99
        'Hashes must be used for a date. Month/Date/Year. 
        dtDateRegistered = #11/2/2020#

        MsgBox("The make is " & stMake & Environment.NewLine &
               "the price is " & "$" & decPrice & ".")


    End Sub

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String

        'stFirstName = InputBox("please enter your first name")
        'MsgBox("hello " & stFirstName)

        'Get the text from the textBox and assign to the variable.  
        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        MsgBox("Hello " & stFirstName & " " & stLastName & " you are a " & stGender)

    End Sub
End Class
