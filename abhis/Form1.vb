Public Class Form1
    Dim count As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
      
        If count = 200 Then
            LOGIN.Show()
            Me.Hide()
        End If
        count = count + 1

    End Sub
End Class
