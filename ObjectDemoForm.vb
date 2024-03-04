Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ObjectDemoForm
    Private Sub ExitButton_Click(Sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub


    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles LoadPictureButton.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            PictureBox.Image = Image.FromFile(imagePath)
        End If
    End Sub


    Private Sub CheckBoxFont_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged, BoldCheckBox.CheckedChanged, BoldItalicCheckBox.CheckedChanged
        Dim selectedCheckBox As CheckBox = DirectCast(sender, CheckBox)

        Dim fontStyle As FontStyle = FontStyle.Regular
        If ItalicCheckBox.Checked Then
            fontStyle = FontStyle.Italic
        ElseIf BoldCheckBox.Checked Then
            fontStyle = FontStyle.Bold
        ElseIf BoldItalicCheckBox.Checked Then
            fontStyle = FontStyle.Bold.Italic
        End If

        SampleTestBox.Font = New Font(SampleTestBox.Font.FontFamily, SampleTestBox.Font.Size, fontStyle)
    End Sub


    Private Sub RadioButtonFont_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged, MagnetoRadioButton.CheckedChanged, TahomaRadioButton.CheckedChanged
        Dim selectedRadioButton = DirectCast(sender, RadioButton)

        Dim fontFamily As String
        Select Case selectedRadioButton.Name
            Case "GaramondRadioButton"
                fontFamily = "Garamond"
            Case "MagnetoRadioButton"
                fontFamily = "Magneto"
            Case "TahomaRadioButton"
                fontFamily = "Tahoma"
        End Select

        Dim newSize = SampleTestBox.Font.Size
        Dim newStyle = SampleTestBox.Font.Style
        Dim newFont As New Font(fontFamily, newSize, newStyle)

        SampleTestBox.Font = newFont
    End Sub


    Private Sub GreenRadioButton_CheckedChanged(Sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged

        If GreenRadioButton.Checked Then
            SampleTestBox.ForeColor = Color.Green
        End If
    End Sub
    Private Sub BlueRadioButton_CheckedChanged(Sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        If BlueRadioButton.Checked Then
            SampleTestBox.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub RedRadioButton_CheckedChanged(Sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged

        If RedRadioButton.Checked Then
            SampleTestBox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ObjectDemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class