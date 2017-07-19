Imports System.Data.OleDb
Public Class Exist_Student_Reg
    Dim last_install As Integer
    Dim new_install As Integer
    Dim available As Integer
    Dim total As Integer
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Public total_fee As Integer


    Private Sub Exist_Student_Reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        TextBox1.Focus()
        TextBox3.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        TextBox3.Enabled = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Sub autoid()
        Try
            Dim s As String
            s = "select max(ID1) from Fees"
            Dim cmd1 As New OleDbCommand(s, c)
            Dim dr As OleDbDataReader = cmd1.ExecuteReader
            If dr.Read = True Then
                Label16.Text = dr.Item(0) + 1
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub readonly_check1()
        TextBox6.ReadOnly = False
        TextBox9.ReadOnly = False
        TextBox8.ReadOnly = False
        MaskedTextBox1.ReadOnly = False
        TextBox11.ReadOnly = False

        TextBox7.ReadOnly = False

        TextBox2.ReadOnly = False

        TextBox1.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox4.ReadOnly = False
        PictureBox1.Enabled = True

    End Sub

    Public Sub readonly_check()
        TextBox6.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox8.ReadOnly = True
        MaskedTextBox1.ReadOnly = True
        TextBox11.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox1.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox4.ReadOnly = True
        PictureBox1.Enabled = False

    End Sub

    Public Sub insert_data()
        If TextBox5.Text = 0 Then
            autoid()
            readonly_check1()
            Dim s1 As String
            Dim pp As String = "Full Fee"
            Dim i1 As Integer
            Dim id As Integer = Label16.Text
            Dim phone_no As String = MaskedTextBox1.Text


            s1 = "insert into Fees(ID1,Name1,Surname1,Contact1,College1,Email1,PayProcess,Total1)values(" & id & ",'" & TextBox9.Text & "','" & TextBox8.Text & "','" & phone_no & "','" & TextBox11.Text & "','" & TextBox7.Text & "','" & pp & "','" & TextBox4.Text & "')"
            Dim s As String = "insert into Whole_Data(ID1,Name1,Surname1,Contact1,College1,Email1,PayProcess,Total_fee)values(" & id & ",'" & TextBox9.Text & "','" & TextBox8.Text & "','" & phone_no & "','" & TextBox11.Text & "','" & TextBox7.Text & "','" & pp & "','" & TextBox4.Text & "')"

            Dim cmd1 As New OleDbCommand(s1, c)
            Dim cmd As New OleDbCommand(s, c)
            i1 = cmd1.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            If i1 = 1 Then
                MsgBox("data Submitted Successfully.....Now the Student is paid full Fees...So the Whole Record of this student is changed(About Fees..!!)")
                delete_data()

            Else
                MsgBox("process failed")
            End If
        End If
    End Sub
    Public Sub delete_data()
        Dim s As String
        s = "delete from Fee_Installment where ID1=" & TextBox1.Text & ""
        Dim cmd As New OleDbCommand(s, c)
        Dim i As Integer
        i = cmd.ExecuteScalar()
        If i = 0 Then


            MsgBox("Data Transfer Process is done... The New id of this Student is " & Label16.Text & "")
            
        Else

            MsgBox("Sorry please try again...  Process failed.... !!!")

        End If

    End Sub


    Private Sub TextBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox3.MouseClick
        If TextBox3.Text = "" Then
            If TextBox1.Text = "" Then
                PictureBox1.Enabled = False
                TextBox1.Focus()
                Exit Sub
            End If
        Else
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox5.Text = "0" Then
            MsgBox("student has paid already full fees no need to pay again.....Please Click On TRANSFER button..!!")
            PictureBox1.Enabled = False
            PictureBox5.Focus()
        Else
            PictureBox1.Enabled = True
            TextBox3.Focus()
        End If
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        If TextBox1.Text = "" Then
            MsgBox("please enter Student id first")
            TextBox1.Focus()
            Exit Sub

        End If
    End Sub


    Public Sub clear_data()
        TextBox6.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        MaskedTextBox1.Text = ""
        TextBox11.Text = ""

        TextBox7.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""

        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        PictureBox1.Enabled = True
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        DataGridView1.DataSource = Nothing
        TextBox1.Focus()
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False

    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        HOME.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Public Sub data_grid_view()

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("select * from [Fee_Installment] where ID1=" & TextBox1.Text & "", c)
        da.Fill(ds, "Fee_Installment")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view


    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Sub Value_check()
        Dim val1 As Integer = TextBox3.Text
        Dim val2 As Integer = TextBox5.Text
        If val1 > val2 Then
            MsgBox("invalid value")

            Exit Sub

        Else
            Dim s, s1 As String
            Dim i As Integer

            If TextBox1.Text = "" Then
                MsgBox("please Enter Id first..And you have to select an option for update record")
                RadioButton1.Focus()

                TextBox1.Focus()

            End If


            If RadioButton2.Checked = True Then
                Dim s4 As String = TextBox3.Text
                If s4 > TextBox5.Text Then
                    MsgBox("sir please enter valid amount")
                    TextBox3.Focus()
                    TextBox3.Text = ""

                    Exit Sub
                Else
                    new_install = TextBox3.Text
                    last_install = TextBox2.Text + new_install
                    available = TextBox4.Text - last_install
                    TextBox5.Text = available
                    TextBox2.Text = last_install
                    TextBox3.Text = ""
                End If

                s = "update Whole_Data set  Last_Install='" & TextBox2.Text & "' , New_Install='" & TextBox3.Text & "', Available='" & TextBox5.Text & "' where ID1=" & TextBox1.Text & ""
                s1 = "update Fee_Installment set  Last_Install='" & TextBox2.Text & "' , New_Install='" & TextBox3.Text & "', Available='" & TextBox5.Text & "' where ID1=" & TextBox1.Text & ""
                Dim cmd As New OleDbCommand(s, c)
                Dim cmd1 As New OleDbCommand(s1, c)

                i = cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                If i = 1 Then
                    MsgBox("data Updated Successfully")
                    data_grid_view()
                    clear_data()
                Else
                    MsgBox("Sorry please try again...  Process failed.... !!!")
                End If
            End If
            If RadioButton1.Checked = True Then
                Dim s4 As String = TextBox3.Text
                If s4 > TextBox5.Text Then
                    MsgBox("sir please enter valid amount")
                    TextBox3.Text = ""
                    TextBox3.Focus()

                Else
                    new_install = TextBox3.Text
                    last_install = TextBox2.Text + new_install
                    available = TextBox4.Text - last_install
                    TextBox5.Text = available
                    TextBox2.Text = last_install
                    TextBox3.Text = ""
                End If
                s = "update Whole_Data set Name1='" & TextBox9.Text & "' ,Surname1='" & TextBox8.Text & "',Contact1='" & MaskedTextBox1.Text & "',College1='" & TextBox11.Text & "',Email1='" & TextBox7.Text & "',PayProcess='" & ComboBox1.Text & "', Last_Install='" & TextBox2.Text & "' , New_Install='" & TextBox3.Text & "', Available='" & TextBox5.Text & "' where ID1=" & TextBox1.Text & ""
                s1 = "update Fee_Installment set Name1='" & TextBox9.Text & "' ,Surname1='" & TextBox8.Text & "',Contact1='" & MaskedTextBox1.Text & "',College1='" & TextBox11.Text & "',Email1='" & TextBox7.Text & "',PayProcess='" & ComboBox1.Text & "', Last_Install='" & TextBox2.Text & "' , New_Install='" & TextBox3.Text & "', Available='" & TextBox5.Text & "' where ID1=" & TextBox1.Text & ""

                Dim cmd As New OleDbCommand(s, c)
                Dim cmd2 As New OleDbCommand(s1, c)
                cmd2.ExecuteNonQuery()
                i = cmd.ExecuteNonQuery()
                If i = 1 Then
                    MsgBox("data Updated Successfully")
                    data_grid_view()
                    clear_data()
                Else
                    MsgBox("Sorry please try again...  Process failed.... !!!")
                End If

            End If

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBox3.Text > TextBox5.Text Then
            MsgBox("invalid amount")
            Exit Sub
        Else
            Call Value_check()

        End If



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim str As String
        Dim i As Integer

        'If TextBox1.Enabled = False Then
        '    str1 = "select count(*) from Fee_Installment where Name1= '" & TextBox10.Text & "' and Surname1='" & TextBox12.Text & "'"
        '    Dim cmd2 As New OleDbCommand(str1, c)
        '    j = cmd2.ExecuteScalar()
        '    If j = 1 Then
        '        Dim cmd1 As New OleDbCommand("select * from Fee_Installment where Name1='" & TextBox10.Text & "' and Surname1='" & TextBox12.Text & "'", c)
        '        Dim dr As OleDbDataReader
        '        dr = cmd1.ExecuteReader()
        '        While dr.Read()

        '            TextBox6.Text = dr(0)
        '            TextBox9.Text = dr(1)
        '            TextBox8.Text = dr(2)
        '            MaskedTextBox1.Text = dr(3)
        '            TextBox11.Text = dr(4)
        '            ComboBox2.Text = dr(5)
        '            TextBox7.Text = dr(6)
        '            ComboBox1.Text = dr(7)
        '            TextBox2.Text = dr(8)

        '            TextBox5.Text = dr(10)
        '            TextBox4.Text = dr(11)
        '        End While
        '        data_grid_view()
        '    Else
        '        MsgBox("No record found")

        '    End If
        If TextBox1.Text = "" Then
            MsgBox("please enter id first...And please select update option first")
            TextBox1.Focus()


        Else

            RadioButton1.Checked = True
            str = "select count(*) from Fee_Installment where ID1=" & TextBox1.Text & ""
            Dim cmd As New OleDbCommand(str, c)
            i = cmd.ExecuteScalar()
            If i = 1 Then
                Dim cmd1 As New OleDbCommand("select * from Fee_Installment where ID1=" & TextBox1.Text & "", c)
                Dim dr As OleDbDataReader
                dr = cmd1.ExecuteReader()
                While dr.Read()

                    TextBox6.Text = dr(0)
                    TextBox9.Text = dr(1)
                    TextBox8.Text = dr(2)
                    MaskedTextBox1.Text = dr(4)
                    TextBox11.Text = dr(5)

                    TextBox7.Text = dr(6)
                    ComboBox1.Text = dr(7)
                    TextBox2.Text = dr(8)

                    TextBox5.Text = dr(10)
                    TextBox4.Text = dr(11)

                End While
                data_grid_view()
            Else
                MsgBox("Id is not Present ....")
            End If


        End If



    End Sub

    Private Sub PictureBox1_EnabledChanged(sender As Object, e As EventArgs) Handles PictureBox1.EnabledChanged

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.submit_false_1
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.submit_true_1
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBox6.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        MaskedTextBox1.Text = ""
        TextBox11.Text = ""

        TextBox7.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        PictureBox1.Enabled = True


        Me.Hide()
        HOME.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        clear_data()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        If TextBox5.Text = "0" Then
            insert_data()
            clear_data()
        Else
            MsgBox("Student has not paid full fees...")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If TextBox1.Text = "" Then
            MsgBox("please enter id first")
            TextBox1.Focus()
            Exit Sub
        End If
        TextBox9.ReadOnly = False
        TextBox8.ReadOnly = False
        MaskedTextBox1.ReadOnly = False
        TextBox11.ReadOnly = False
        TextBox7.ReadOnly = False
        ComboBox1.Enabled = True
        PictureBox1.Enabled = True
        TextBox3.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If TextBox1.Text = "" Then
            MsgBox("please enter id first")
            TextBox1.Focus()
            Exit Sub
        End If
        TextBox9.ReadOnly = True
        TextBox8.ReadOnly = True
        MaskedTextBox1.ReadOnly = True
        TextBox11.ReadOnly = True
        TextBox3.Enabled = True
        TextBox7.ReadOnly = True
        ComboBox1.Enabled = False
        PictureBox1.Enabled = False

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            TextBox3.Enabled = False
        Else
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            TextBox3.Enabled = True
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)
        TextBox1.Enabled = False

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class