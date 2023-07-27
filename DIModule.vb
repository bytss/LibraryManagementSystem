Imports System.Data.OleDb
Imports System.Globalization

Module DIModule

    Public connPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VSProjects\PUPBataanLibrarySystem\bin\Debug\Database\lmsdb.accdb"
    ' Public connPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Database\pup_lms_db.accdb"
    Public conn As OleDbConnection

    Public Sub initConnection()
        conn = New OleDbConnection()
        conn.ConnectionString = connPath
    End Sub

    Public Sub openConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub closeConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Function CapitalizeEachWord(input As String) As String
        Dim textInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo
        Return textInfo.ToTitleCase(input.ToLower())
    End Function

    Public Function isRowNull(col As String) As Boolean
        Return String.IsNullOrEmpty(col)
    End Function

    Public Function isNullOrEmpty(field As String) As Boolean
        Return String.IsNullOrEmpty(field)
    End Function

End Module
