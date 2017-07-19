Public Class checking

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "1008" Then
            TextBox1.Text = ""
            If TextBox2.Text = "1" Then
                COPY_DB.Show()
                Me.Hide()
                TextBox2.Text = ""
            Else
                DELETE_RECORD.Show()
                Me.Hide()
                TextBox2.Text = ""
            End If
           
        Else
            MsgBox("You don't have Authority to delete records ....!!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HOME.Show()
        Me.Hide()

    End Sub
End Class