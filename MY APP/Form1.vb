Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lines() As String = File.ReadAllLines("C:\Users\SEN0018\Desktop\MY APP\MY APP\bin\Debug\net8.0-windows\priority.txt")

        cmbpriority.DataSource = lines
    End Sub

    Private Sub cbxpriority_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpriority.SelectedIndexChanged

    End Sub
End Class