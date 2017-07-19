Imports System.Data.OleDb
Public Class ENQUIRY
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource



    Private Sub ENQUIRY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("select * from [Gen_Registration]", c)
        da.Fill(ds, "Gen_Registration")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        HOME.Show()
        Me.Hide()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("select * from [Gen_Registration]", c)
        da.Fill(ds, "Gen_Registration")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
    End Sub
End Class