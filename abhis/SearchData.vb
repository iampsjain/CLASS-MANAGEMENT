Imports System.Data.OleDb
Public Class SearchData
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub SearchData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        DataGridView1.Hide()
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            DataGridView1.Show()
            ds = New DataSet
            tables = ds.Tables
            da = New OleDbDataAdapter("select * from [Whole_Data] where Name1='" & TextBox1.Text & "'", c)
            da.Fill(ds, "Fee_Installment")
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
        End If
       
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Hide()
        TextBox1.Text = ""
        HOME.Show()
        Me.Hide()
    End Sub
End Class