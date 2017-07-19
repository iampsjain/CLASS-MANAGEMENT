Public Class COPY_DB

    Public path As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("please enter path to copy database..!!")
            TextBox1.Focus()

        Else

            path = TextBox1.Text
            TextBox1.Enabled = False
            If My.Computer.FileSystem.DirectoryExists(path) = True Then
                My.Computer.FileSystem.DeleteFile(path)
                My.Computer.FileSystem.CopyFile("E:\Abhis.accdb", path)
                MsgBox("data copied")
            Else
                If My.Computer.FileSystem.FileExists(path) = True Then
                    MsgBox("file found..please do not close process is running...")
                    My.Computer.FileSystem.DeleteFile(path)
                    My.Computer.FileSystem.CopyFile("E:\Abhis.accdb", path)
                    MsgBox("data copied")
                Else
                    MsgBox("file not found....please do not close process is running...")
                    My.Computer.FileSystem.CopyFile("E:\Abhis.accdb", path)
                    MsgBox("data copied")

                End If

            End If
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Enabled = True
        If TextBox1.Text = "" Then
            MsgBox("please enter path first...")
            TextBox1.Focus()
        Else
            My.Computer.FileSystem.DeleteFile(path)
            MsgBox("done..!!")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        HOME.Show()
        TextBox1.Enabled = True
        TextBox1.Text = ""
    End Sub
End Class