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
        components = New ComponentModel.Container()
        cmbFilter = New ComboBox()
        btnCreate = New Button()
        lstCalendar = New ListBox()
        lblfilter = New Label()
        btnDelete = New Button()
        BindingSource1 = New BindingSource(components)
        btnFilter = New Button()
        lstTime = New ListBox()
        DateTimePicker1 = New DateTimePicker()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbFilter
        ' 
        cmbFilter.BackColor = Color.PeachPuff
        cmbFilter.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        cmbFilter.FormattingEnabled = True
        cmbFilter.Location = New Point(500, 44)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(288, 39)
        cmbFilter.TabIndex = 0
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.PeachPuff
        btnCreate.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        btnCreate.Location = New Point(487, 339)
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
        lstCalendar.Size = New Size(325, 407)
        lstCalendar.TabIndex = 2
        ' 
        ' lblfilter
        ' 
        lblfilter.AutoSize = True
        lblfilter.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lblfilter.Location = New Point(716, 1)
        lblfilter.Name = "lblfilter"
        lblfilter.Size = New Size(72, 31)
        lblfilter.TabIndex = 3
        lblfilter.Text = "Filter"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.PeachPuff
        btnDelete.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        btnDelete.Location = New Point(487, 234)
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
        btnFilter.Location = New Point(500, 89)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(288, 99)
        btnFilter.TabIndex = 5
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' lstTime
        ' 
        lstTime.BackColor = Color.PeachPuff
        lstTime.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        lstTime.FormattingEnabled = True
        lstTime.ItemHeight = 31
        lstTime.Location = New Point(12, 42)
        lstTime.Name = "lstTime"
        lstTime.Size = New Size(120, 407)
        lstTime.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Vic Mod Cursive", 14.25F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(195, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(358, 38)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(800, 450)
        Controls.Add(DateTimePicker1)
        Controls.Add(lstTime)
        Controls.Add(btnFilter)
        Controls.Add(btnDelete)
        Controls.Add(lblfilter)
        Controls.Add(lstCalendar)
        Controls.Add(btnCreate)
        Controls.Add(cmbFilter)
        ForeColor = Color.Black
        Name = "Form1"
        Text = "Welcome, User"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents lstCalendar As ListBox
    Friend WithEvents lblfilter As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnFilter As Button
    Friend WithEvents lstTime As ListBox
    Friend WithEvents DateTimePicker1 As DateTimePicker

End Class
