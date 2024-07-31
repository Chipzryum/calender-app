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
        txtinput = New TextBox()
        cmbpriority = New ComboBox()
        btn = New Button()
        Button2 = New Button()
        lstcalendar = New ListBox()
        SuspendLayout()
        ' 
        ' txtinput
        ' 
        txtinput.Location = New Point(379, 199)
        txtinput.Name = "txtinput"
        txtinput.Size = New Size(156, 23)
        txtinput.TabIndex = 0
        ' 
        ' cmbpriority
        ' 
        cmbpriority.FormattingEnabled = True
        cmbpriority.Location = New Point(586, 199)
        cmbpriority.Name = "cmbpriority"
        cmbpriority.Size = New Size(121, 23)
        cmbpriority.TabIndex = 1
        ' 
        ' btn
        ' 
        btn.Location = New Point(414, 336)
        btn.Name = "btn"
        btn.Size = New Size(75, 23)
        btn.TabIndex = 2
        btn.Text = "Button1"
        btn.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(539, 323)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lstcalendar
        ' 
        lstcalendar.FormattingEnabled = True
        lstcalendar.ItemHeight = 15
        lstcalendar.Location = New Point(12, 12)
        lstcalendar.Name = "lstcalendar"
        lstcalendar.Size = New Size(344, 424)
        lstcalendar.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstcalendar)
        Controls.Add(Button2)
        Controls.Add(btn)
        Controls.Add(cmbpriority)
        Controls.Add(txtinput)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtinput As TextBox
    Friend WithEvents cmbpriority As ComboBox
    Friend WithEvents btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lstcalendar As ListBox

End Class
