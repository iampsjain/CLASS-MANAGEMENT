Imports System.Data.OleDb
Public Class Fee_Record
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub ViewAllDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllDetailsToolStripMenuItem.Click
        DataGridView1.Show()
    End Sub

    Private Sub NewRecordToolStripMenuItem_Click(sender As Object, e As EventArgs)
        New_Record_Entry.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateExistRecordToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Exist_Student_Reg.Show()
        Me.Hide()
    End Sub

    Private Sub Fee_Record_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        ds = New DataSet
        tables = ds.Tables

    End Sub

    Private Sub Fee_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        DataGridView1.Hide()
        Connect()
    End Sub

    Private Sub INSTALLMENTSSTUDENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSTALLMENTSSTUDENTSToolStripMenuItem.Click

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("select * from [Fee_Installment]", c)
        da.Fill(ds, "Fee_Installment")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub FULLPAIDSTUDENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FULLPAIDSTUDENTSToolStripMenuItem.Click

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("select * from [Fees]", c)
        da.Fill(ds, "Fees")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub SearchFeesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click

        DataGridView1.DataSource = Nothing
        HOME.Show()
        Me.Hide()
    End Sub

    Private Sub SearchByCourseToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub SearchByStudentNameToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AddNewRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewRecordToolStripMenuItem.Click

    End Sub

    Private Sub WholeDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WholeDataToolStripMenuItem.Click
        DataGridView1.Show()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("select * from [Whole_Data]", c)
        da.Fill(ds, "Whole_Data")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub OldDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OldDatabaseToolStripMenuItem.Click
        DataGridView1.Show()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("select * from [Old_Database]", c)
        da.Fill(ds, "Old_Database")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
    End Sub
End Class