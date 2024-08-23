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
        lstCalendar = New ListBox()
        txtinput = New TextBox()
        cmbPriority = New ComboBox()
        btnBack = New Button()
        lblpreview = New Label()
        lstTime = New ListBox()
        btnAdd = New Button()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' lstCalendar
        ' 
        lstCalendar.BackColor = Color.PeachPuff
        lstCalendar.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lstCalendar.FormattingEnabled = True
        lstCalendar.ItemHeight = 31
        lstCalendar.Location = New Point(138, 42)
        lstCalendar.Name = "lstCalendar"
        lstCalendar.Size = New Size(267, 500)
        lstCalendar.TabIndex = 0
        ' 
        ' txtinput
        ' 
        txtinput.BackColor = Color.PeachPuff
        txtinput.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        txtinput.Location = New Point(548, 303)
        txtinput.Name = "txtinput"
        txtinput.Size = New Size(377, 38)
        txtinput.TabIndex = 1
        ' 
        ' cmbPriority
        ' 
        cmbPriority.BackColor = Color.PeachPuff
        cmbPriority.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        cmbPriority.FormattingEnabled = True
        cmbPriority.Location = New Point(548, 84)
        cmbPriority.Name = "cmbPriority"
        cmbPriority.Size = New Size(121, 39)
        cmbPriority.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.PeachPuff
        btnBack.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        btnBack.Location = New Point(548, 383)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(149, 67)
        btnBack.TabIndex = 3
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblpreview
        ' 
        lblpreview.AutoSize = True
        lblpreview.BackColor = Color.DarkSalmon
        lblpreview.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lblpreview.Location = New Point(168, 1)
        lblpreview.Name = "lblpreview"
        lblpreview.Size = New Size(94, 31)
        lblpreview.TabIndex = 4
        lblpreview.Text = "Preview"
        ' 
        ' lstTime
        ' 
        lstTime.BackColor = Color.PeachPuff
        lstTime.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lstTime.FormattingEnabled = True
        lstTime.ItemHeight = 31
        lstTime.Items.AddRange(New Object() {"5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"})
        lstTime.Location = New Point(12, 42)
        lstTime.Name = "lstTime"
        lstTime.Size = New Size(120, 500)
        lstTime.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.PeachPuff
        btnAdd.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        btnAdd.Location = New Point(703, 383)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(145, 67)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(318, 1)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(351, 38)
        DateTimePicker1.TabIndex = 9
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(979, 570)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnAdd)
        Controls.Add(lstTime)
        Controls.Add(lblpreview)
        Controls.Add(btnBack)
        Controls.Add(cmbPriority)
        Controls.Add(txtinput)
        Controls.Add(lstCalendar)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstCalendar As ListBox
    Friend WithEvents txtinput As TextBox
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblpreview As Label
    Friend WithEvents lstTime As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
