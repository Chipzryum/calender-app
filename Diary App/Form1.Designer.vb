<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        cmbPriority = New ComboBox()
        btnCreate = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' cmbPriority
        ' 
        cmbPriority.FormattingEnabled = True
        cmbPriority.Location = New Point(500, 12)
        cmbPriority.Name = "cmbPriority"
        cmbPriority.Size = New Size(288, 23)
        cmbPriority.TabIndex = 0
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(664, 285)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(124, 153)
        btnCreate.TabIndex = 1
        btnCreate.Text = "New"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(469, 424)
        ListBox1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(btnCreate)
        Controls.Add(cmbPriority)
        Name = "Form1"
        Text = "Welcome, User"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents ListBox1 As ListBox

End Class
