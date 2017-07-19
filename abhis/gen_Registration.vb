Imports System.Data.OleDb
Public Class gen_Registration
    Dim clang As String
    Dim cpp As String
    Dim cj As String
    Dim aj As String
    Dim hcp As String
    Dim hc As String
    Dim php As String
    Dim mmc As String
    Dim appti As String
    Dim bank As String
    Dim se As String
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
    Sub autoid()
        Try
            Dim s As String
            s = "select max(ID1) from Gen_Registration"
            Dim cmd1 As New OleDbCommand(s, c)
            Dim dr As OleDbDataReader = cmd1.ExecuteReader
            If dr.Read = True Then
                Label9.Text = dr.Item(0) + 1
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label4.Text = "call from home" Then
            Label4.Text = ""
            HOME.Show()
            Me.Hide()
        Else
            LOGIN.Show()
            Me.Hide()
        End If
            

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        autoid()
        check_textbox()

    End Sub


    Public Sub check_textbox()
        checkbox()
        If TextBox1.Text = "" Then
            MsgBox("Please Enter Full Name")
            TextBox1.Focus()
            Exit Sub


        ElseIf TextBox2.Text = "" Then
            MsgBox("please Enter Surname")
            TextBox2.Focus()
            Exit Sub

        ElseIf MaskedTextBox1.Text = "" Then
            MsgBox("please Enter phone number")
            MaskedTextBox1.Focus()
            Exit Sub

        ElseIf TextBox3.Text = "" Then
            MsgBox("please Enter College Name")

            TextBox3.Focus()
            Exit Sub
        Else


            Dim s As String
            Dim i As Integer
            s = "insert into Gen_Registration(ID1,Name1,Surname1,year1,Contact1,College1,c_lang,cpp,core_java,adv_java,html_css_php,html_css,php,mba_mca_cet,apptitude,bank_po,spoken_english,date1)values(" & Label9.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Text & "','" & MaskedTextBox1.Text & "','" & TextBox3.Text & "','" & clang & "','" & cpp & "','" & cj & "','" & aj & "','" & hcp & "','" & hc & "','" & php & "','" & mmc & "','" & appti & "','" & bank & "','" & se & "','" & Today.Year & "')"
            Dim cmd As New OleDbCommand(s, c)
            i = cmd.ExecuteNonQuery()
            If i = 1 Then
                MsgBox("done")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""

                MaskedTextBox1.Text = ""
                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox5.Checked = False
                CheckBox6.Checked = False
                CheckBox7.Checked = False
                CheckBox8.Checked = False
                CheckBox9.Checked = False
                CheckBox10.Checked = False
                CheckBox11.Checked = False
                TextBox1.Focus()
                autoid()
            Else
                MsgBox("Due To Some Technical Reasone Data insertion Process is Failed , Please Try Again")
            End If
        End If
    End Sub
    Public Sub checkbox()


        If CheckBox1.Checked = True Then
            clang = "C "
        Else
            clang = ""
        End If
        If CheckBox2.Checked = True Then
            cpp = "c++"
        Else
            cpp = ""
        End If
        If CheckBox3.Checked = True Then
            cj = "Core Java"
        Else
            cj = ""
        End If
        If CheckBox4.Checked = True Then
            aj = "Advance Java"
        Else
            aj = ""
        End If

        If CheckBox5.Checked = True Then
            hcp = "html css php"
        Else
            hcp = ""
        End If
        If CheckBox6.Checked = True Then
            hc = "Html css"
        Else
            hc = ""
        End If
        If CheckBox7.Checked = True Then
            php = "php"
        Else
            php = ""
        End If
        If CheckBox8.Checked = True Then
            mmc = "Mba cet"
        Else
            mmc = ""
        End If
        If CheckBox9.Checked = True Then
            appti = "appti"
        Else
            appti = ""
        End If
        If CheckBox10.Checked = True Then
            bank = "bank"
        Else
            bank = ""
        End If
        If CheckBox11.Checked = True Then
            se = "Spoken english"
        Else
            se = ""
        End If
    End Sub
    Private Sub gen_Registration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connect()
        autoid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        MaskedTextBox1.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        TextBox1.Focus()
        autoid()
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class