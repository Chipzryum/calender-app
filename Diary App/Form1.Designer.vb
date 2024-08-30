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
        lstCalendar = New ListBox()
        lblfilter = New Label()
        btnDelete = New Button()
        btnFilter = New Button()
        DateTimePicker1 = New DateTimePicker()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' cmbPriority
        ' 
        cmbPriority.BackColor = Color.PeachPuff
        cmbPriority.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        cmbPriority.FormattingEnabled = True
        cmbPriority.Location = New Point(558, 44)
        cmbPriority.Name = "cmbPriority"
        cmbPriority.Size = New Size(288, 39)
        cmbPriority.TabIndex = 0
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.PeachPuff
        btnCreate.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        btnCreate.Location = New Point(498, 339)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(301, 99)
        btnCreate.TabIndex = 1
        btnCreate.Text = "New"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' lstCalendar
        ' 
        lstCalendar.BackColor = Color.PeachPuff
        lstCalendar.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lstCalendar.FormattingEnabled = True
        lstCalendar.ItemHeight = 31
        lstCalendar.Location = New Point(138, 44)
        lstCalendar.Name = "lstCalendar"
        lstCalendar.Size = New Size(325, 500)
        lstCalendar.TabIndex = 2
        ' 
        ' lblfilter
        ' 
        lblfilter.AutoSize = True
        lblfilter.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lblfilter.Location = New Point(480, 47)
        lblfilter.Name = "lblfilter"
        lblfilter.Size = New Size(72, 31)
        lblfilter.TabIndex = 3
        lblfilter.Text = "Filter"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.PeachPuff
        btnDelete.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        btnDelete.Location = New Point(583, 203)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(301, 99)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = Color.PeachPuff
        btnFilter.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        btnFilter.Location = New Point(558, 89)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(288, 99)
        btnFilter.TabIndex = 5
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(313, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(358, 38)
        DateTimePicker1.TabIndex = 10
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.PeachPuff
        ListBox1.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 31
        ListBox1.Items.AddRange(New Object() {"5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"})
        ListBox1.Location = New Point(12, 44)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 500)
        ListBox1.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(979, 570)
        Controls.Add(ListBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnFilter)
        Controls.Add(btnDelete)
        Controls.Add(lblfilter)
        Controls.Add(lstCalendar)
        Controls.Add(btnCreate)
        Controls.Add(cmbPriority)
        ForeColor = Color.Black
        Name = "Form1"
        Text = "Welcome, User"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents lstCalendar As ListBox
    Friend WithEvents lblfilter As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListBox1 As ListBox

End Class
