Imports System.Data.OleDb
Module Module1

    Public c As OleDbConnection

    Public Sub Connect()

        c = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Abhis.accdb")

        c.Open()

    End Sub

End Module
