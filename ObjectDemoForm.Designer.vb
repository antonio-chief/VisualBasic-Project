<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LoadPictureButton = New Button()
        ExitButton = New Button()
        PictureBox = New PictureBox()
        GroupBox1 = New GroupBox()
        BoldItalicCheckBox = New CheckBox()
        BoldCheckBox = New CheckBox()
        ItalicCheckBox = New CheckBox()
        GroupBox2 = New GroupBox()
        RedRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        GreenRadioButton = New RadioButton()
        GroupBox3 = New GroupBox()
        SampleTestBox = New TextBox()
        GroupBox4 = New GroupBox()
        TahomaRadioButton = New RadioButton()
        MagnetoRadioButton = New RadioButton()
        GaramondRadioButton = New RadioButton()
        CType(PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' LoadPictureButton
        ' 
        LoadPictureButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoadPictureButton.Location = New Point(71, 401)
        LoadPictureButton.Name = "LoadPictureButton"
        LoadPictureButton.Size = New Size(155, 34)
        LoadPictureButton.TabIndex = 0
        LoadPictureButton.Text = "L&oad Picture"
        LoadPictureButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitButton.Location = New Point(594, 401)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(130, 34)
        ExitButton.TabIndex = 1
        ExitButton.Text = "E&XIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox
        ' 
        PictureBox.Location = New Point(34, 131)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(264, 253)
        PictureBox.TabIndex = 2
        PictureBox.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BoldItalicCheckBox)
        GroupBox1.Controls.Add(BoldCheckBox)
        GroupBox1.Controls.Add(ItalicCheckBox)
        GroupBox1.Location = New Point(325, 118)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(193, 266)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Font Style"
        ' 
        ' BoldItalicCheckBox
        ' 
        BoldItalicCheckBox.AutoSize = True
        BoldItalicCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BoldItalicCheckBox.Location = New Point(34, 192)
        BoldItalicCheckBox.Name = "BoldItalicCheckBox"
        BoldItalicCheckBox.Size = New Size(126, 29)
        BoldItalicCheckBox.TabIndex = 2
        BoldItalicCheckBox.Text = "Bold Italic"
        BoldItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldCheckBox
        ' 
        BoldCheckBox.AutoSize = True
        BoldCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoldCheckBox.Location = New Point(34, 118)
        BoldCheckBox.Name = "BoldCheckBox"
        BoldCheckBox.Size = New Size(77, 29)
        BoldCheckBox.TabIndex = 1
        BoldCheckBox.Text = "Bold"
        BoldCheckBox.UseVisualStyleBackColor = True
        ' 
        ' ItalicCheckBox
        ' 
        ItalicCheckBox.AutoSize = True
        ItalicCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ItalicCheckBox.Location = New Point(34, 49)
        ItalicCheckBox.Name = "ItalicCheckBox"
        ItalicCheckBox.Size = New Size(77, 29)
        ItalicCheckBox.TabIndex = 0
        ItalicCheckBox.Text = "Italic"
        ItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RedRadioButton)
        GroupBox2.Controls.Add(BlueRadioButton)
        GroupBox2.Controls.Add(GreenRadioButton)
        GroupBox2.Location = New Point(551, 118)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(210, 266)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font Color"
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.Location = New Point(40, 187)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(67, 29)
        RedRadioButton.TabIndex = 2
        RedRadioButton.TabStop = True
        RedRadioButton.Text = "&Red"
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(43, 120)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(70, 29)
        BlueRadioButton.TabIndex = 1
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "&Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.Location = New Point(40, 52)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(83, 29)
        GreenRadioButton.TabIndex = 0
        GreenRadioButton.TabStop = True
        GreenRadioButton.Text = "&Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(SampleTestBox)
        GroupBox3.Location = New Point(34, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(227, 100)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Display Test"
        ' 
        ' SampleTestBox
        ' 
        SampleTestBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SampleTestBox.Location = New Point(16, 42)
        SampleTestBox.Name = "SampleTestBox"
        SampleTestBox.Size = New Size(150, 39)
        SampleTestBox.TabIndex = 0
        SampleTestBox.Text = "Sample Test"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(TahomaRadioButton)
        GroupBox4.Controls.Add(MagnetoRadioButton)
        GroupBox4.Controls.Add(GaramondRadioButton)
        GroupBox4.Location = New Point(289, 12)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(472, 100)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font"
        ' 
        ' TahomaRadioButton
        ' 
        TahomaRadioButton.AutoSize = True
        TahomaRadioButton.Location = New Point(336, 42)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(99, 29)
        TahomaRadioButton.TabIndex = 2
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MagnetoRadioButton
        ' 
        MagnetoRadioButton.AutoSize = True
        MagnetoRadioButton.Location = New Point(173, 42)
        MagnetoRadioButton.Name = "MagnetoRadioButton"
        MagnetoRadioButton.Size = New Size(109, 29)
        MagnetoRadioButton.TabIndex = 1
        MagnetoRadioButton.TabStop = True
        MagnetoRadioButton.Text = "Magneto"
        MagnetoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.Location = New Point(26, 42)
        GaramondRadioButton.Name = "GaramondRadioButton"
        GaramondRadioButton.Size = New Size(121, 29)
        GaramondRadioButton.TabIndex = 0
        GaramondRadioButton.TabStop = True
        GaramondRadioButton.Text = "Garamond"
        GaramondRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ObjectDemoForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox)
        Controls.Add(ExitButton)
        Controls.Add(LoadPictureButton)
        Name = "ObjectDemoForm"
        Text = "Object Demonstrations"
        CType(PictureBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadPictureButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BoldItalicCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
    Friend WithEvents ItalicCheckBox As CheckBox
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents SampleTestBox As TextBox
    Friend WithEvents TahomaRadioButton As RadioButton
End Class
