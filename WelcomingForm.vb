Public Class WelcomingForm
    'Exit button that closes the application
    Private Sub ExitButton_Click(Sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Load button that opens the "Object Demonstration Form"
    Private Sub LoadObjectButton_Click(Sender As Object, e As EventArgs) Handles LoadObjectButton.Click
        Dim ObjectDemoForm As New ObjectDemoForm()
        ObjectDemoForm.Show()
    End Sub

    'To maximise the application window and change its colour to red
    Private Sub WelcomingForm_Click(Sender As Object, e As EventArgs) Handles MyBase.Click
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub

    Private Sub WelcomingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
