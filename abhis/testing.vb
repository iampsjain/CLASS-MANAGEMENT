Public Class testing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text > TextBox2.Text Then
            MsgBox("1 is greater")
        ElseIf TextBox2.Text > TextBox1.Text Then
            MsgBox("2 is greater")
        Else
            MsgBox("wrong input")
        End If
    End Sub
End Class