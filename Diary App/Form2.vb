Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lines() As String = File.ReadAllLines("C:\Users\SEN0018\source\repos\Diary App\Diary App\bin\Debug\net8.0-windows\priority.txt")

        cmbPriority.DataSource = lines
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Writing As String
        Writing = txtinput.Text
        Dim NumbersFile As System.IO.StreamWriter
        NumbersFile = My.Computer.FileSystem.OpenTextFileWriter("testxml.txt", True)
        NumbersFile.WriteLine(Writing)
        NumbersFile.Close()
        lstTimeTable.Items.Add(Writing)
        MsgBox(“The details has been saved successfully”)
        txtinput.Text = ""

    End Sub
End Class