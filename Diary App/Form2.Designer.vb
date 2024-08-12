<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        ListBox1 = New ListBox()
        TextBox1 = New TextBox()
        cmbPriority = New ComboBox()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(267, 424)
        ListBox1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(389, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(283, 23)
        TextBox1.TabIndex = 1
        ' 
        ' cmbPriority
        ' 
        cmbPriority.FormattingEnabled = True
        cmbPriority.Location = New Point(551, 141)
        cmbPriority.Name = "cmbPriority"
        cmbPriority.Size = New Size(121, 23)
        cmbPriority.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(408, 257)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(149, 67)
        btnBack.TabIndex = 3
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(cmbPriority)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents btnBack As Button
End Class
