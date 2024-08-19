Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim form1 As Form1
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Form1 Then
                form1 = CType(frm, Form1)
                Exit For
            End If
        Next

        If form1 Is Nothing Then
            form1 = New Form1()
        End If

        form1.Text = "Welcome " & txtName.Text


        Me.Hide()
        form1.Show()
    End Sub
End Class
