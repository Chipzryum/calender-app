
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Defining all the variables and reading them from files
        Dim priority() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\priority.txt")

        cmbPriority.Items.AddRange(priority)

        Dim lines() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\timetable.txt")

        lstCalendar.Items.AddRange(lines)
    End Sub


    Private Sub cbxpriority_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPriority.SelectedIndexChanged

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Changes to Create New Form
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub lstCalendar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCalendar.SelectedIndexChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        ' Check if there is a selected item in the ListBox
        If lstCalendar.SelectedIndex <> -1 Then
            ' Remove the selected item from the ListBox
            lstCalendar.Items.RemoveAt(lstCalendar.SelectedIndex)

            ' Update the file to reflect the current items in the ListBox
            SaveItems()
        Else
            ' Show a message if no item is selected
            MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Method to save ListBox items to the file
    Private Sub SaveItems()
        Dim filePath As String = "C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\timetable.txt"
        Try
            ' Create a list to hold the current items from the ListBox
            Dim items As New List(Of String)

            ' Loop through each item in the ListBox and add it to the list
            For Each item As String In lstCalendar.Items
                items.Add(item)
            Next

            ' Write the list of items to the file
            System.IO.File.WriteAllLines(filePath, items)

            ' Optionally, show a message to confirm saving
            ' MessageBox.Show("Items have been saved successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Show an error message if something goes wrong
            MessageBox.Show("An error occurred while saving the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class