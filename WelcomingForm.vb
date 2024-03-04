Public Class WelcomingForm
    Private Sub ExitButton_Click(Sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoadObjectButton_Click(Sender As Object, e As EventArgs) Handles LoadObjectButton.Click
        Dim ObjectDemoForm As New ObjectDemoForm()
        ObjectDemoForm.Show()
    End Sub

    Private Sub WelcomingForm_Click(Sender As Object, e As EventArgs) Handles MyBase.Click
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub

    Private Sub WelcomingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
