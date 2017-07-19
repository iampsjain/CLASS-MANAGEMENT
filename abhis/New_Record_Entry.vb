Imports System.Data.OleDb
Public Class New_Record_Entry
    Dim last_install As Integer
    Dim new_install As Integer
    Dim available As Integer
    Dim total As Integer
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
    Dim full_total, x As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub autoid()
        Try
            Dim s As String
            s = "select max(ID1) from Whole_Data"
            Dim cmd1 As New OleDbCommand(s, c)
            Dim dr As OleDbDataReader = cmd1.ExecuteReader
            If dr.Read = True Then
                TextBox6.Text = dr.Item(0) + 1
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub check_any_subject(i As Integer)
       
    End Sub

   

    Private Sub New_Record_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox5.Hide()
        Label16.Hide()
        Label7.Hide()
        TextBox14.Hide()
        TextBox12.Hide()
        TextBox13.Hide()
        Panel2.Enabled = False
        Connect()
        autoid()
        Panel1.Hide()
        GroupBox3.Hide()
        GroupBox2.Hide()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "INSTALLMENT" Then
            GroupBox3.Show()

            GroupBox2.Show()
            Panel1.Hide()
            Panel2.Enabled = True
            TextBox3.Enabled = False
        ElseIf ComboBox1.Text = "FULL FEE" Then
            Panel1.Show()

            TextBox3.Enabled = False
            Panel2.Enabled = True
            GroupBox3.Hide()
            GroupBox2.Hide()
        Else
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

        If TextBox9.Text = "" Then
            new_install = 0
        End If
        GroupBox2.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "C" Then
            TextBox3.Text = "1900"
            TextBox7.Text = "1900"
        ElseIf ComboBox2.Text = "C++" Then
            TextBox3.Text = "1999"
            TextBox7.Text = "1999"
        ElseIf ComboBox2.Text = "JAVA" Then
            TextBox3.Text = "2500"
            TextBox7.Text = "2500"
        ElseIf ComboBox2.Text = "APPTITUDE" Then
            TextBox3.Text = "6999"
            TextBox7.Text = "6999"
        ElseIf ComboBox2.Text = "" Then
            TextBox3.Text = ""
            TextBox7.Text = ""
        ElseIf ComboBox2.Text = "Mba" Then
            TextBox3.Text = "10000"
            TextBox7.Text = "10000"
        ElseIf ComboBox2.Text = "ANDROID" Then
            TextBox3.Text = "2500"
            TextBox7.Text = "2500"
        ElseIf ComboBox2.Text = "HTML, CSS, PHP" Then
            TextBox3.Text = "4500"
            TextBox7.Text = "4500"
        ElseIf ComboBox2.Text = "SPOKEN" Then
            TextBox3.Text = "4500"
            TextBox7.Text = "4500"
        ElseIf ComboBox2.Text = "c#" Then
            TextBox3.Text = "2000"
            TextBox7.Text = "2000"
        ElseIf ComboBox2.Text = "VB.NET" Then
            TextBox3.Text = "2500"
            TextBox7.Text = "2500"
        Else
            TextBox3.Enabled = True
            TextBox7.Enabled = True
            TextBox3.Text = ""
            TextBox3.Focus()
            TextBox7.Text = ""
            TextBox7.Focus()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = TextBox9.Text
        Dim j As Integer = TextBox7.Text
        If i > j Then
            MsgBox("invalid amount")
            Exit Sub
        End If
        autoid()
        insert_Record_Installment_fee()
    End Sub
    Public Sub insert_Record_Installment_fee()



        If TextBox1.Text = "" Then
            MsgBox("Enter Full Name")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Enter Surname")
            TextBox2.Focus()
            Exit Sub
        End If
        If MaskedTextBox1.Text = "" Then
            MsgBox("Enter Full Phone Number")
            MaskedTextBox1.Focus()
            Exit Sub
        End If
        If TextBox11.Text = "" Then
            MsgBox("Enter College Name")
            TextBox11.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            MsgBox("please Enter Email Address")
            TextBox4.Focus()
            Exit Sub
        End If
        If TextBox10.Text = "" Then
            MsgBox("please enter the fee first")
            TextBox10.Focus()
            Exit Sub

        End If
        If ComboBox1.Text = "" Then
            MsgBox("please Select Payment method first")
            ComboBox1.Focus()
            Exit Sub
            If TextBox9.Text = "" Then
                MsgBox("please Insert Fees First")
                TextBox9.Focus()
                Exit Sub
            End If
        Else

            checkbox()
            'Calculation
            Try

                last_install = TextBox10.Text
                TextBox10.Text = last_install + new_install

                available = TextBox3.Text - TextBox10.Text
                TextBox8.Text = available

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            If CheckBox1.CheckState = CheckState.Checked Then
                clang = "c "
            Else
                clang = ""
            End If
            If CheckBox2.CheckState = CheckState.Checked Then
                cpp = "C++"
            Else
                cpp = ""
            End If
            If CheckBox3.CheckState = CheckState.Checked Then
                cj = "CORE JAVA"
            Else
                cj = ""
            End If
            If CheckBox4.CheckState = CheckState.Checked Then
                aj = "Adv Java"
            Else
                aj = ""
            End If

            If CheckBox5.CheckState = CheckState.Checked Then
                hcp = "HTML, CSS, php"
            Else
                hcp = ""
            End If
            If CheckBox6.CheckState = CheckState.Checked Then
                hc = "HTML, CSS"
            Else
                hc = ""
            End If
            If CheckBox7.CheckState = CheckState.Checked Then
                php = "php"
            Else
                php = ""
            End If
            If CheckBox8.CheckState = CheckState.Checked Then
                mmc = "MBA/MCA CET"
            Else
                mmc = ""
            End If
            If CheckBox9.CheckState = CheckState.Checked Then
                appti = "APPTITUDE"
            Else
                appti = ""
            End If
            If CheckBox10.CheckState = CheckState.Checked Then
                bank = "bankPO"
            Else
                bank = ""
            End If
            If CheckBox11.CheckState = CheckState.Checked Then
                se = "SPOKEN"
            Else
                se = ""
            End If
            'Decleration and Insertion
            Call autoid()
            Dim phone_no As String = MaskedTextBox1.Text
            Dim i As Integer

            Dim payment As String = ComboBox1.Text
            '  Dim s1 As String = "insert into Whole_Data(ID1,Name1,Surname1,date1,Contact1,College1,Course1,Email1,PayProcess,Total_fee,time)values(" & TextBox6.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & Today.Year & "','" & phone_no & "','" & TextBox11.Text & "','" & course & "','" & TextBox4.Text & "','" & payment & "','" & TextBox7.Text & "','" & Today.Date & "')"
            Dim s1 As String = "insert into Whole_Data(ID1,Name1,Surname1,Contact1,College1,Email1,PayProcess,Last_Install,New_Install,Available,Total_fee,date1,c_lang,cpp,core_java,adv_java,html_css_php,html_css,php,mba_mca_cet,apptitude,bank_po,spoken_english,other)values(" & TextBox6.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & phone_no & "','" & TextBox11.Text & "','" & TextBox4.Text & "','" & payment & "','" & TextBox10.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "','" & TextBox7.Text & "','" & Today.Year & "','" & clang & "','" & cpp & "','" & cj & "','" & aj & "','" & hcp & "','" & hc & "','" & php & "','" & mmc & "','" & appti & "','" & bank & "','" & se & "','" & TextBox5.Text & "')"
            Dim s As String = "insert into Fee_Installment(ID1,Name1,Surname1,Contact1,College1,Email1,PayProcess,Last_Install,New_Install,Available,Total_fee,date1,c_lang,cpp,core_java,adv_java,html_css_php,html_css,php,mba_mca_cet,apptitude,bank_po,spoken_english,other)values(" & TextBox6.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & phone_no & "','" & TextBox11.Text & "','" & TextBox4.Text & "','" & payment & "','" & TextBox10.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "','" & TextBox7.Text & "','" & Today.Year & "','" & clang & "','" & cpp & "','" & cj & "','" & aj & "','" & hcp & "','" & hc & "','" & php & "','" & mmc & "','" & appti & "','" & bank & "','" & se & "','" & TextBox5.Text & "')"

            'Dim s As String = "insert into Fee_Installment(ID1,Name1,Surname1,Contact1,College1,Course1,Email1,PayProcess,Last_Install,New_Install,Available,Total_fee,date1)values(" & TextBox6.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & phone_no & "','" & TextBox11.Text & "','" & course & "','" & TextBox4.Text & "','" & payment & "','" & TextBox10.Text & "','" & TextBox9.Text & "','" & TextBox8.Text & "','" & TextBox7.Text & "','" & Today.Year & "')"

            Dim cmd As New OleDbCommand(s, c)
            Dim cmd1 As New OleDbCommand(s1, c)
            cmd1.ExecuteNonQuery()
            i = cmd.ExecuteNonQuery()
            If i = 1 Then
                MsgBox("done")
                TextBox9.Text = ""
                clear_data()

            Else
                MsgBox("Due to Some Technical Problem, data Insertion failed ")

            End If
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        insert_Record_Full_fee()

    End Sub

    Public Sub insert_Record_Full_fee()
        Try
            If TextBox1.Text = "" Then
                MsgBox("Enter Full Name")
                TextBox1.Focus()
                Exit Sub
            End If
            If TextBox3.Text = "" Then
                MsgBox("please enter fee of these subject")
                TextBox3.Focus()
                Exit Sub

            End If
            If TextBox2.Text = "" Then
                MsgBox("Enter Surname")
                TextBox2.Focus()
                Exit Sub
            End If
            If MaskedTextBox1.Text = "" Then
                MsgBox("Enter Full Phone Number")
                MaskedTextBox1.Focus()
                Exit Sub
            End If
            If TextBox11.Text = "" Then
                MsgBox("Enter College Name")
                TextBox11.Focus()
                Exit Sub
            End If
            'If ComboBox2.Text = "" Then
            '    MsgBox("Select Subject First")
            '    ComboBox2.Focus()
            '    Exit Sub

            'End If
            If TextBox4.Text = "" Then
                MsgBox("please Enter Email Address")
                TextBox4.Focus()
                Exit Sub
            End If
            If ComboBox1.Text = "" Then
                MsgBox("please Select Payment method first")
                ComboBox1.Focus()
                Exit Sub


            Else
                If CheckBox1.CheckState = CheckState.Checked Then
                    clang = "c "
                Else
                    clang = ""
                End If
                If CheckBox2.CheckState = CheckState.Checked Then
                    cpp = "C++"
                Else
                    cpp = ""
                End If
                If CheckBox3.CheckState = CheckState.Checked Then
                    cj = "CORE JAVA"
                Else
                    cj = ""
                End If
                If CheckBox4.CheckState = CheckState.Checked Then
                    aj = "Adv Java"
                Else
                    aj = ""
                End If

                If CheckBox5.CheckState = CheckState.Checked Then
                    hcp = "HTML, CSS, php"
                Else
                    hcp = ""
                End If
                If CheckBox6.CheckState = CheckState.Checked Then
                    hc = "HTML, CSS"
                Else
                    hc = ""
                End If
                If CheckBox7.CheckState = CheckState.Checked Then
                    php = "php"
                Else
                    php = ""
                End If
                If CheckBox8.CheckState = CheckState.Checked Then
                    mmc = "MBA/MCA CET"
                Else
                    mmc = ""
                End If
                If CheckBox9.CheckState = CheckState.Checked Then
                    appti = "APPTITUDE"
                Else
                    appti = ""
                End If
                If CheckBox10.CheckState = CheckState.Checked Then
                    bank = "bankPO"
                Else
                    bank = ""
                End If
                If CheckBox11.CheckState = CheckState.Checked Then
                    se = "SPOKEN"
                Else
                    se = ""
                End If


                checkbox()
                'check_checkbox()
                TextBox3.Enabled = True
                Dim phone_no As String = MaskedTextBox1.Text
                Dim i As Integer
                'Dim course As String = ComboBox2.Text
                Dim payment As String = ComboBox1.Text

                Dim s1 As String = "insert into Whole_Data(ID1,Name1,Surname1,date1,Contact1,College1,Email1,PayProcess,Total_fee,time1,c_lang,cpp,core_java,adv_java,html_css_php,html_css,php,mba_mca_cet,apptitude,bank_po,spoken_english,other)values(" & TextBox6.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & Today.Year & "','" & phone_no & "','" & TextBox11.Text & "','" & TextBox4.Text & "','" & payment & "','" & TextBox7.Text & "','" & Today.Date & "','" & clang & "','" & cpp & "','" & cj & "','" & aj & "','" & hcp & "','" & hc & "','" & php & "','" & mmc & "','" & appti & "','" & bank & "','" & se & "','" & TextBox5.Text & "')"
                Dim s As String = "insert into Fees(ID1,Name1,Surname1,date1,Contact1,College1,Email1,PayProcess,Total1,c_lang,cpp,core_java,adv_java,html_css_php,html_css,php,mba_mca_cet,apptitude,bank_po,spoken_english,other)values(" & TextBox6.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & Today.Year & "','" & phone_no & "','" & TextBox11.Text & "','" & TextBox4.Text & "','" & payment & "','" & TextBox7.Text & "','" & clang & "','" & cpp & "','" & cj & "','" & aj & "','" & hcp & "','" & hc & "','" & php & "','" & mmc & "','" & appti & "','" & bank & "','" & se & "','" & TextBox5.Text & "')"

                'Dim s As String = "insert into Fees(ID1,Name1,Surname1,Contact1,College1,Email1,PayProcess,Total1,date1)values(" & TextBox6.Text & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & phone_no & "','" & TextBox11.Text & "','" & TextBox4.Text & "','" & payment & "','" & TextBox3.Text & "','" & Today.Year & "')"
                Dim cmd As New OleDbCommand(s, c)
                Dim cmd1 As New OleDbCommand(s1, c)

                cmd1.ExecuteNonQuery()
                i = cmd.ExecuteNonQuery()
                If i = 1 Then
                    clear_data()
                    MsgBox("done")
                Else
                    MsgBox("Due to Some Technical Problem, data Insertion failed ")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
    Public Sub check_checkbox()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clear_data()
        Call autoid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear_data()
        Panel2.Enabled = False
        TextBox3.Enabled = False
        Panel1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        HOME.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub clear_data()
        TextBox3.Enabled = False
        TextBox7.Enabled = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        MaskedTextBox1.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
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
        CheckBox12.Checked = False
        TextBox13.Enabled = True
        TextBox13.Text = ""
        TextBox12.Text = ""
        TextBox12.Enabled = True
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox13.Hide()
        Call autoid()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        clear_data()
    End Sub



    Public Sub cal(value As Integer, sec_value As Integer)

        If value = 0 Then
            total = total - sec_value
        ElseIf value = 1 Then
            total = sec_value + total
        End If

        TextBox7.Text = total
        TextBox3.Text = total
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.CheckState = CheckState.Checked Then
            cal(1, 2000)
            check_any_subject(1)
        ElseIf CheckBox2.CheckState = CheckState.Unchecked Then
            cal(0, 2000)


        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.CheckState = CheckState.Checked Then
            cal(1, 2500)
            check_any_subject(1)
        ElseIf CheckBox4.CheckState = CheckState.Unchecked Then
            cal(0, 2500)


        End If
    End Sub



    Public Sub checkbox()

    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.CheckState = CheckState.Checked Then
            Label16.Show()
            Label7.Show()
            TextBox14.Show()
            TextBox5.Show()
            TextBox3.Enabled = False
            TextBox7.Enabled = False

            check_any_subject(1)
            If TextBox14.Text = "" Or TextBox14.Text = "0" Then
                TextBox14.Text = 0
                i = TextBox14.Text
                cal(0, i)
            Else
                i = TextBox14.Text
                cal(1, i)
            End If

        ElseIf CheckBox12.CheckState = CheckState.Unchecked Then
            cal(0, i)
            TextBox5.Hide()
            TextBox3.Enabled = False
            TextBox7.Enabled = False

            Label16.Hide()
            Label7.Hide()
            TextBox14.Hide()

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            cal(1, 1900)
            check_any_subject(1)
        ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
            cal(0, 1900)


        End If
        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.CheckState = CheckState.Checked Then
            cal(1, 2500)
            check_any_subject(1)
        ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
            cal(0, 2500)


        End If
        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.CheckState = CheckState.Checked Then
            cal(1, 4500)
            check_any_subject(1)
        ElseIf CheckBox8.CheckState = CheckState.Unchecked Then
            cal(0, 4500)


        End If
        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.CheckState = CheckState.Checked Then
            cal(1, 2500)
            check_any_subject(1)
        ElseIf CheckBox7.CheckState = CheckState.Unchecked Then
            cal(0, 2500)

        End If
        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub
    Public i As Integer
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

        If CheckBox6.CheckState = CheckState.Checked Then
            TextBox13.Show()
            If TextBox13.Text = "" Or TextBox13.Text = "0" Then
                TextBox13.Text = 0
                i = TextBox13.Text
                cal(0, i)
            Else
                TextBox13.Enabled = False
                i = TextBox13.Text
                cal(1, i)

            End If

        ElseIf CheckBox7.CheckState = CheckState.Unchecked Then
            cal(0, i)

            TextBox13.Hide()
        Else

        End If

        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.CheckState = CheckState.Checked Then
            cal(1, 10000)
            check_any_subject(1)
        ElseIf CheckBox5.CheckState = CheckState.Unchecked Then
            cal(0, 10000)


        End If
        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.CheckState = CheckState.Checked Then
            cal(1, 7000)
            check_any_subject(1)
        ElseIf CheckBox10.CheckState = CheckState.Unchecked Then
            cal(0, 7000)


        End If
        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.CheckState = CheckState.Checked Then
            cal(1, 10000)
            check_any_subject(1)
        ElseIf CheckBox9.CheckState = CheckState.Unchecked Then
            cal(0, 10000)


        End If
        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub
    Public j As Integer
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.CheckState = CheckState.Checked Then
            TextBox12.Show()
            If TextBox12.Text = "" Or TextBox12.Text = "0" Then
                TextBox12.Text = 0
                j = TextBox12.Text
                cal(0, j)
            Else
                TextBox12.Enabled = False
                j = TextBox12.Text
                cal(1, j)
                check_any_subject(1)
            End If

        ElseIf CheckBox11.CheckState = CheckState.Unchecked Then
            cal(0, j)

            TextBox12.Hide()

        End If
        TextBox3.Enabled = False
        TextBox7.Enabled = False

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub


    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub
End Class