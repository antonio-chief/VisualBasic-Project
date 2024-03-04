<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomingForm
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
        LoadObjectButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' LoadObjectButton
        ' 
        LoadObjectButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoadObjectButton.Location = New Point(74, 173)
        LoadObjectButton.Name = "LoadObjectButton"
        LoadObjectButton.Size = New Size(235, 49)
        LoadObjectButton.TabIndex = 0
        LoadObjectButton.Text = "&Load Object Button"
        LoadObjectButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitButton.Location = New Point(438, 173)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(185, 49)
        ExitButton.TabIndex = 1
        ExitButton.Text = "E&XIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' WelcomingForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(LoadObjectButton)
        Name = "WelcomingForm"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadObjectButton As Button
    Friend WithEvents ExitButton As Button

End Class
