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
        Dim Writing As String
        Writing = txtinput.Text
        Dim NumbersFile As System.IO.StreamWriter
        NumbersFile = My.Computer.FileSystem.OpenTextFileWriter("timetable.txt", True)
        NumbersFile.WriteLine(Writing)
        NumbersFile.Close()
        Dim timetable() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\timetable.txt")
        lstCalendar.DataSource = timetable
        MsgBox(“The details has been saved successfully”)
        txtinput.Text = ""

    End Sub
End Class