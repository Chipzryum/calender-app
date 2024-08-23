
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim priority() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\priority.txt")

        cmbPriority.DataSource = priority

        Dim lines() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\testxml.txt")

        lstCalendar.DataSource = lines
    End Sub


    Private Sub cbxpriority_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPriority.SelectedIndexChanged

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub lstCalendar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCalendar.SelectedIndexChanged

    End Sub
End Class