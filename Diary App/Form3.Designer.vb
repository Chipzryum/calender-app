<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblTitle = New Label()
        txtName = New TextBox()
        lblName = New Label()
        btnGo = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Yu Gothic UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(303, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(329, 86)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Diary App"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.PeachPuff
        txtName.Location = New Point(407, 197)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(279, 191)
        lblName.Name = "lblName"
        lblName.Size = New Size(77, 31)
        lblName.TabIndex = 2
        lblName.Text = "Name:"
        ' 
        ' btnGo
        ' 
        btnGo.BackColor = Color.PeachPuff
        btnGo.Font = New Font("Vic Mod Cursive", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGo.Location = New Point(366, 308)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(199, 102)
        btnGo.TabIndex = 3
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(979, 570)
        Controls.Add(btnGo)
        Controls.Add(lblName)
        Controls.Add(txtName)
        Controls.Add(lblTitle)
        Name = "Form3"
        Text = "Home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnGo As Button
End Class
