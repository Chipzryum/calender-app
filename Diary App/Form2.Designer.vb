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
        txtTime = New TextBox()
        SaveFileDialog1 = New SaveFileDialog()
        lbltime = New Label()
        lblinput = New Label()
        lblpriority = New Label()
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
        txtinput.Location = New Point(715, 303)
        txtinput.Name = "txtinput"
        txtinput.Size = New Size(210, 38)
        txtinput.TabIndex = 1
        ' 
        ' cmbPriority
        ' 
        cmbPriority.BackColor = Color.PeachPuff
        cmbPriority.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        cmbPriority.FormattingEnabled = True
        cmbPriority.Location = New Point(715, 121)
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
        ' txtTime
        ' 
        txtTime.BackColor = Color.PeachPuff
        txtTime.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        txtTime.Location = New Point(471, 303)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(210, 38)
        txtTime.TabIndex = 10
        ' 
        ' lbltime
        ' 
        lbltime.AutoSize = True
        lbltime.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lbltime.Location = New Point(471, 269)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(67, 31)
        lbltime.TabIndex = 11
        lbltime.Text = "Time:"
        ' 
        ' lblinput
        ' 
        lblinput.AutoSize = True
        lblinput.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lblinput.Location = New Point(715, 269)
        lblinput.Name = "lblinput"
        lblinput.Size = New Size(63, 31)
        lblinput.TabIndex = 12
        lblinput.Text = "Text:"
        ' 
        ' lblpriority
        ' 
        lblpriority.AutoSize = True
        lblpriority.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lblpriority.Location = New Point(616, 124)
        lblpriority.Name = "lblpriority"
        lblpriority.Size = New Size(93, 31)
        lblpriority.TabIndex = 13
        lblpriority.Text = "Priority"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(979, 570)
        Controls.Add(lblpriority)
        Controls.Add(lblinput)
        Controls.Add(lbltime)
        Controls.Add(txtTime)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnAdd)
        Controls.Add(lstTime)
        Controls.Add(lblpreview)
        Controls.Add(btnBack)
        Controls.Add(cmbPriority)
        Controls.Add(txtinput)
        Controls.Add(lstCalendar)
        Name = "Form2"
        Text = "    "
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
    Friend WithEvents txtTime As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lbltime As Label
    Friend WithEvents lblinput As Label
    Friend WithEvents lblpriority As Label
End Class
