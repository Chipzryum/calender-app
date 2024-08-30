Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim priority() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\priority.txt")

        cmbPriority.Items.AddRange(priority)

        Dim timetable() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\timetable.txt")

        lstCalendar.Items.AddRange(timetable)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'getting writing from user input
        Dim Writing As String
        Writing = txtinput.Text
        Dim NumbersFile As System.IO.StreamWriter
        NumbersFile = My.Computer.FileSystem.OpenTextFileWriter("timetable.txt", True)
        ' writing to the listbox timetable
        NumbersFile.WriteLine(Writing)
        NumbersFile.Close()
        Dim timetable() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\timetable.txt")
        ' updating the listbox for next use by writing to file
        lstCalendar.Items.AddRange(timetable)

        'getting time from user input
        Dim Time As String
        Time = txtTime.Text
        Dim TimeFile As System.IO.StreamWriter
        TimeFile = My.Computer.FileSystem.OpenTextFileWriter("Time.txt", True)
        ' writing to the listbox timetable
        TimeFile.WriteLine(Writing)
        TimeFile.Close()
        Dim TimeValue() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\Time.txt")
        ' updating the listbox for next use by writing to file
        lstTime.Items.AddRange(TimeValue)




        ' cleaning up
        MsgBox(“The details has been saved successfully”)
        txtinput.Text = ""
        txtTime.Text = ""


    End Sub
End Class