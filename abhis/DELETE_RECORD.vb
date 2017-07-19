Imports System.Data.OleDb
Public Class DELETE_RECORD
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        '    DataGridView1.Show()
        '    ds = New DataSet
        '    tables = ds.Tables
        '    da = New OleDbDataAdapter("select * from [Whole_Data]", c)
        '    da.Fill(ds, "Whole_Data")
        '    Dim view As New DataView(tables(0))
        '    source1.DataSource = view
        '    DataGridView1.DataSource = view
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        'Dim s1 As String = "insert into Whole_Data(ID1,Name1,Surname1,date1,Contact1,College1,Course1,Email1,PayProcess,Total_fee,time)values()"
        Try
            If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("please select year and course first ...!!!")
                Exit Sub

            End If

            Dim year1 As String = ComboBox1.Text
            Dim course As String = ComboBox2.Text

            Dim s, s1 As String
            Dim i As Boolean
            s = "select * from Whole_Data where date1 = '" & year1 & "' "
            Dim cmd As New OleDbCommand(s, c)
            i = cmd.ExecuteScalar()
            If i = True Then
                Dim result As Integer = MessageBox.Show("Are u sure want to delete this batch", "to delete data press ok", MessageBoxButtons.OKCancel)
                If result = DialogResult.Cancel Then
                    MsgBox("process cancel")
                    Exit Sub

                ElseIf result = DialogResult.OK Then
                    Label2.Show()
                    Dim cmd1 As New OleDbCommand(s, c)
                    Dim fees As OleDbCommand
                    Dim install_fee As OleDbCommand
                    Dim dr As OleDbDataReader
                    dr = cmd1.ExecuteReader()
                    While dr.Read()
                        s1 = "insert into Old_Database(Name1,Surname1,date1,Contact1,College1,Course1,Email1,PayProcess,Last_Install,New_Install,Available,Total_fee,time1)values('" & dr(1) & "','" & dr(2) & "','" & dr(3) & "','" & dr(4) & "','" & dr(5) & "','" & dr(6) & "','" & dr(7) & "','" & dr(8) & "','" & dr(9) & "','" & dr(10) & "','" & dr(11) & "','" & dr(12) & "','" & dr(13) & "')"
                        Dim cmd2 As New OleDbCommand(s1, c)
                        cmd2.ExecuteNonQuery()
                        i = cmd2.ExecuteNonQuery()
                        If i = True Then
                            Dim del As String
                            Dim fee As String
                            Dim installfee As String
                            del = "delete from Whole_Data where ID1= " & dr(0) & ""
                            fee = "delete from Fees where ID1= " & dr(0) & ""
                            installfee = "delete from Fee_Installment where ID1= " & dr(0) & ""
                            cmd = New OleDbCommand(del, c)
                            fees = New OleDbCommand(fee, c)
                            install_fee = New OleDbCommand(installfee, c)
                            fees.ExecuteScalar()
                            install_fee.ExecuteScalar()
                            i = cmd.ExecuteScalar()
                            If i = False Then
                                Label2.Text = "done..!!!"
                            Else
                                MsgBox("sorry no data deleted")
                            End If
                        Else
                            MsgBox("problem to delete some date...please contact pushpak jain ")
                        End If
                    End While

                    Exit Sub
                Else
                    MsgBox("NO DATA FOUND !")
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
      
    End Sub

    Private Sub DELETE_RECORD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        Label2.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Dim from_ As Integer

    '    Dim to_ As Integer

    '    DataGridView1.Show()

    '    ds = New DataSet

    '    tables = ds.Tables

    '    from_ = TextBox1.Text
    '    to_ = TextBox2.Text


    '    If from_ > to_ Then
    '        MsgBox("Make sure you enter correct values ....")
    '        TextBox1.Focus()

    '        Exit Sub


    '    Else
    '        For i As Integer = from_ To to_

    '            da = New OleDbDataAdapter("select * from [Whole_Data] where ID1=" & from_ & "", c)
    '            da.Fill(ds, "Whole_Data")
    '            Dim view As New DataView(tables(0))
    '            source1.DataSource = view
    '            DataGridView1.DataSource = view
    '            from_ = from_ + 1

    '        Next
    '    End If

    '    Dim result As Integer = MessageBox.Show("Are u sure want to delete this batch", "to delete data press ok", MessageBoxButtons.OKCancel)
    '    If result = DialogResult.Cancel Then
    '        MsgBox("process cancel")
    '    ElseIf result = DialogResult.OK Then
    '        MsgBox("yor request is being processed")
    '    End If
    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("please select year and course first ...!!!")
            Exit Sub
        End If

        'DataGridView1.Show()
        'ds = New DataSet
        'tables = ds.Tables
        'da = New OleDbDataAdapter("select * from [Whole_Data] where date1='" & ComboBox1.Text & "' ='" & ComboBox2.Text & "'", c)
        'da.Fill(ds, "Whole_Data")
        'Dim view As New DataView(tables(0))
        'source1.DataSource = view
        'DataGridView1.DataSource = view

        If ComboBox2.Text = "C" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where c_lang='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "' ", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "SPOKEN" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where spoken_english='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "ANDROID" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where other='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "c#" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where other='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "VB.NET" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where other='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "HTML, CSS, PHP" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where html_css_php='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "HTML, CSS" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where html_css='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "PHP" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where php='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "BANK PO" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where bank_po='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "C++" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where cpp='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "JAVA" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where core_java='" & ComboBox2.Text & "' and adv_java='" & ComboBox1.Text & "' and date1='" & ComboBox1.Text & "' ", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "MBA/MCA CET" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where mba_mca_cet='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox2.Text = "APPTITUDE" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where apptitude='" & ComboBox2.Text & "' and date1='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        End If
    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    Dim year1 As String = ComboBox1.Text
    '    Dim course As String = ComboBox2.Text

    '    Dim s As String
    '    Dim i As Boolean
    '    s = "select * from Whole_Data where date1 = '" & year1 & "' and Course1 = '" & course & "'"
    '    Dim cmd As New OleDbCommand(s, c)
    '    i = cmd.ExecuteScalar()
    '    If i = False Then
    '        MsgBox(" no record")
    '    ElseIf i = True Then
    '        MsgBox("found !!!")
    '        Dim del As String
    '        del = "delete from Whole_Data where ID1= " & 2 & ""
    '        cmd = New OleDbCommand(del, c)
    '        i = cmd.ExecuteScalar()
    '    Else
    '        MsgBox("locha zala re ('-') " & i & " ", )
    '    End If
    'End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DataGridView1.DataSource = Nothing
        HOME.Show()
        Me.Hide()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class