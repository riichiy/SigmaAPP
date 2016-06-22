Imports System.Web
Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Net.Mail
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class GlobalData
    Public Shared siteUrl As String = ""
    Public Shared connectionString As String = ""
    Public Shared con As OleDbConnection
    Public Shared Function GetDataReader(ByVal SQL As String) As OleDbDataReader
        Dim cmdD As OleDbCommand = New OleDbCommand()
        Try
            con = GetSQLConnection()
            cmdD.CommandText = SQL
            cmdD.CommandTimeout = 10000
            cmdD.Connection = con
            'Retrun the data reader
            Return (cmdD.ExecuteReader(CommandBehavior.CloseConnection))
        Catch ex As Exception
            Throw
        Finally
            If (Not cmdD Is Nothing) Then
                cmdD.Dispose()
            End If
        End Try
    End Function

    Public Shared Function ExecuteNonQuery(ByVal SQL As String) As Boolean
        Dim returnVal As Boolean = False
        Dim cmdD As OleDbCommand = New OleDbCommand()
        Try
            con = GetSQLConnection()
            cmdD.CommandText = SQL
            cmdD.CommandTimeout = 10000
            cmdD.Connection = con
            If (cmdD.ExecuteNonQuery() > 0) Then
                returnVal = True
            End If

        Catch ex As Exception
            Throw
        Finally

            If (Not con Is Nothing) Then
                con.Dispose()
            End If
            If (Not cmdD Is Nothing) Then
                cmdD.Dispose()
            End If
        End Try
        Return returnVal
    End Function
    Public Shared Function ExecuteNonQuery2(ByVal SQL As String) As Boolean
        Dim returnVal As Boolean = False
        Dim cmdD As OleDbCommand = New OleDbCommand()
        Try
            con = GetSQLConnection()
            cmdD.CommandText = SQL
            cmdD.CommandTimeout = 10000
            cmdD.Connection = con
            If (cmdD.ExecuteNonQuery() > 0) Then
                returnVal = True
            End If

        Catch ex As Exception
            Throw
        Finally

            If (Not con Is Nothing) Then
                con.Dispose()
            End If
            If (Not cmdD Is Nothing) Then
                cmdD.Dispose()
            End If
        End Try
        Return returnVal
    End Function
    Public Shared Function CheckRecordExists(ByVal SQL As String) As Boolean
        Dim returnVal As Boolean = False
        Dim cmdD As OleDbCommand = New OleDbCommand()
        Dim db_reader As OleDbDataReader
        Try
            con = GetSQLConnection()
            cmdD.CommandText = SQL
            cmdD.CommandTimeout = 10000
            cmdD.Connection = con
            db_reader = cmdD.ExecuteReader(CommandBehavior.Default)
            If db_reader.HasRows = True Then
                returnVal = True
            Else
                returnVal = False
            End If
        Catch ex As Exception
            Throw
        Finally

            If (Not con Is Nothing) Then
                con.Dispose()
            End If
            If (Not cmdD Is Nothing) Then
                cmdD.Dispose()
            End If
        End Try
        Return returnVal
    End Function
    Public Shared Function GetDataSet(ByVal SQL As String) As DataSet
        Dim cmdD As OleDbCommand = New OleDbCommand()
        Dim adp As New OleDbDataAdapter()
        Dim ds As New DataSet()
        Try
            con = GetSQLConnection()
            cmdD.CommandText = SQL
            cmdD.CommandTimeout = 20000
            cmdD.Connection = con
            adp.SelectCommand = cmdD
            adp.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw
        Finally

            If (Not con Is Nothing) Then
                con.Dispose()
            End If
            If (Not cmdD Is Nothing) Then
                cmdD.Dispose()
            End If
            If (Not adp Is Nothing) Then
                adp.Dispose()
            End If
        End Try
    End Function
    Public Shared Function GetSQLDataTable(ByVal SQL As String) As DataTable
        Dim cmdD As OleDbCommand = New OleDbCommand()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Try

            con = GetSQLConnection()
            cmdD.CommandText = SQL
            cmdD.CommandTimeout = 20000
            cmdD.Connection = con
            da.SelectCommand = cmdD
            da.Fill(dt)

            GetSQLDataTable = dt

        Catch ex As Exception
            Throw

        Finally
            If (Not con Is Nothing) Then
                con.Dispose()
            End If
            If (Not cmdD Is Nothing) Then
                cmdD.Dispose()
            End If
            If (Not da Is Nothing) Then
                da.Dispose()
            End If
            If (Not dt Is Nothing) Then
                dt.Dispose()
            End If
        End Try
    End Function
    Public Shared Function GetSQLConnection() As OleDbConnection
        If (String.IsNullOrEmpty(connectionString)) Then
            connectionString = DBString
        End If
        con = New OleDbConnection(connectionString)
        While (con.State <> ConnectionState.Open)
            con.Open()
        End While
        Return con
    End Function
    Public Shared Function GetDataScalar(ByVal SQL As String) As Object

        Dim dbCon As New OleDb.OleDbConnection
        Dim cmdD As New OleDb.OleDbCommand

        Try


            dbCon = GetSQLConnection()
            cmdD.CommandText = SQL
            cmdD.CommandTimeout = 10000
            cmdD.Connection = dbCon
            GetDataScalar = (cmdD.ExecuteScalar())


        Catch ex As Exception
            Throw

        Finally

            If Not cmdD Is Nothing Then cmdD.Dispose()
            If Not dbCon Is Nothing Then dbCon.Dispose()

        End Try

    End Function
    Public Shared Function InsertOrUpdateData(ByVal strSQL As String) As Integer
        Dim dbCon As New OleDb.OleDbConnection
        Dim cmdD As New OleDb.OleDbCommand
        Dim intRecordsAffected As Integer
        dbCon = GetSQLConnection()

        Try
            cmdD.CommandText = strSQL
            cmdD.Connection = dbCon
            cmdD.CommandTimeout = 10000
            intRecordsAffected = cmdD.ExecuteNonQuery
            cmdD.Dispose()
            dbCon.Close()
            dbCon.Dispose()


        Catch ex As Exception
            Throw

        Finally
            If Not cmdD Is Nothing Then cmdD.Dispose()
            If Not dbCon Is Nothing Then dbCon.Dispose()
        End Try
        Return intRecordsAffected
    End Function

    Public Shared Function CleanData(ByVal SQL As String, Optional ByVal IsBit As Boolean = False, Optional ByVal IsDate As Boolean = False) As String
        If IsBit Then
            If Convert.ToBoolean(SQL.ToLower()) Then
                SQL = "1"
            Else
                SQL = "0"
            End If
        Else
            SQL = SQL.Trim()
            SQL = SQL.Replace("'", "''")
            If SQL = "" Then
                SQL = "NULL"
            Else
                SQL = "'" & SQL & "'"
            End If
        End If

        Return SQL
    End Function
    Public Shared Function GetUniqueFileName(Optional ByVal Extension As String = Nothing) As String

        Try
            If Not Extension Is Nothing Then
                Return Left(Guid.NewGuid.ToString.Trim, 8) + "." & Extension.Trim
            Else
                Return Left(Guid.NewGuid.ToString.Trim, 8)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, "CommonFunctions->GetUniqueFileName", ex.Message)
            Return ""
        End Try
    End Function
End Class


