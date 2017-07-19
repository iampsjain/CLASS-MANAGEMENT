Imports System.Data.OleDb
Public Class Welcome

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

            Dim s As String
            Dim i As Integer
            s = "select count(*) from User1 where Username1='" & TextBox2.Text & "' and Password1='" & TextBox1.Text & "'"
            Dim cmd1 As New OleDbCommand(s, c)
            i = cmd1.ExecuteScalar()
            If i >= 1 Then
                TextBox2.Text = ""
                TextBox1.Text = ""
                TextBox2.Focus()
                HOME.Show()
                Me.Hide()

            Else

            MessageBox.Show("Invalid username or password", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            With TextBox2
                .Focus()
                .SelectAll()
            End With
                TextBox2.Text = ""
                TextBox1.Text = ""
                TextBox2.Focus()
            End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Focus()
        LOGIN.Show()
        Me.Hide()
    End Sub

    
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    

   
End Class