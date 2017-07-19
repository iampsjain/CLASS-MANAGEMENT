Imports System.Data.OleDb
Public Class Search_By_Course
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '        APPTITUDE()
        '        c()
        'C++
        '        CORE JAVA
        'MBA/MCA CET
        '        ()
        '        
        '       
        '        ()
        '        ()
        '        
        '        ()
        '        ()
        '  ='" & ComboBox1.Text & "' and ='" & ComboBox1.Text & "' and other='" & ComboBox1.Text & "'
        If ComboBox1.Text = "C" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where c_lang='" & ComboBox1.Text & "' ", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "SPOKEN" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where spoken_english='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "ANDROID" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where other='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "c#" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where other='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "VB.NET" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where other='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "HTML, CSS, PHP" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where html_css_php='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "HTML, CSS" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where html_css='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "PHP" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where php='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "BANK PO" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where bank_po='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "C++" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where cpp='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "JAVA" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where core_java='" & ComboBox1.Text & "' and adv_java='" & ComboBox1.Text & "' ", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "MBA/MCA CET" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where mba_mca_cet='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "APPTITUDE" Then
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where apptitude='" & ComboBox1.Text & "'", c)
            da.Fill(ds, "Whole_Data")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        ElseIf ComboBox1.Text = "" Then
            DataGridView1.Hide()
        End If
    End Sub

    Private Sub Search_By_Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        ComboBox1.Text = ""
        DataGridView1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Hide()
        ComboBox1.Text = ""
        Me.Hide()
        HOME.Show()

    End Sub
End Class