Imports System.Data
Imports System.Data.SqlClient

Public Class cDataAccess
    Private mCN As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        mCN = ConnectionString
    End Sub

    Public Function OpenConnection() As SqlConnection
        Dim ret_conn As SqlConnection
        Try
            If mCN = String.Empty Then
                ret_conn = New SqlConnection(System.Configuration.ConfigurationSettings.AppSettings("ConnectionString"))
            Else
                ret_conn = New SqlConnection(mCN)
            End If
            ret_conn.Open()
        Catch exc As System.Exception
        End Try
        Return ret_conn
    End Function

    Public Sub CloseConnection(ByVal conn As SqlConnection)
        Try
            If (Not conn Is Nothing) AndAlso ((conn.State And ConnectionState.Open) = ConnectionState.Open) Then
                conn.Close()
                conn.Dispose()
            End If
        Catch exc As System.Exception
        Finally
            conn = Nothing
        End Try
    End Sub

    'overloaded Functions given below will allow you to pass a Stored Procedure Name with or without parameters and returns a DataReader
    Public Overloads Function RunSPReturnRS(ByVal strSP As String, ByVal ParamArray commandParameters() As SqlParameter) As SqlDataReader
        Dim cn As SqlConnection = OpenConnection()
        Dim rdr As SqlDataReader
        Dim cmd As New SqlCommand(strSP, cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 8000
        Dim p As SqlParameter
        For Each p In commandParameters
            p = cmd.Parameters.Add(p)
            p.Direction = ParameterDirection.Input
        Next
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Dispose()
        Return rdr
    End Function

    'For Multi Recorsets
    Public Overloads Function RunSPReturnMultiRS(ByVal strSP As String, ByVal ParamArray commandParameters() As SqlParameter) As SqlDataReader
        Dim cn As SqlConnection = OpenConnection()
        Dim rdr As SqlDataReader
        Dim cmd As New SqlCommand(strSP, cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 8000
        Dim p As SqlParameter
        For Each p In commandParameters
            p = cmd.Parameters.Add(p)
            p.Direction = ParameterDirection.Input
        Next
        rdr = cmd.ExecuteReader()
        cmd.Dispose()
        Return rdr
    End Function

    Public Overloads Function RunSPReturnMultiRS(ByVal strSP As String) As SqlDataReader
        Dim cn As SqlConnection = OpenConnection()
        Dim rdr As SqlDataReader
        Dim cmd As New SqlCommand(strSP, cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 8000
        rdr = cmd.ExecuteReader()
        cmd.Dispose()
        Return rdr
    End Function

    Public Overloads Function RunSPReturnRS(ByVal strSP As String) As SqlDataReader
        Dim cn As SqlConnection = OpenConnection()
        Dim rdr As SqlDataReader
        Dim cmd As New SqlCommand(strSP, cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 8000
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Dispose()
        Return rdr
    End Function

    'For Stored Procedures that return numeric values.
    Public Overloads Function RunSPReturnInteger(ByVal cn As SqlConnection, ByVal strSP As String, ByVal ParamArray commandParameters() As SqlParameter) As Integer
        Dim retVal As Integer
        Try
            Dim cmd As New SqlCommand(strSP, cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim p As SqlParameter
            For Each p In commandParameters
                p = cmd.Parameters.Add(p)
                p.Direction = ParameterDirection.Input
            Next
            p = cmd.Parameters.Add(New SqlParameter("@RetVal", SqlDbType.Int))
            p.Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery()
            retVal = cmd.Parameters("@RetVal").Value
            cmd.Dispose()
        Finally
        End Try
        Return retVal
    End Function

    'For Stored Procedures that return numeric values.
    Public Overloads Function RunSPReturnInteger(ByVal strSP As String, ByVal ParamArray commandParameters() As SqlParameter) As Integer
        Dim cn As SqlConnection = OpenConnection()
        Dim retVal As Integer
        Try
            Dim cmd As New SqlCommand(strSP, cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim p As SqlParameter
            For Each p In commandParameters
                p = cmd.Parameters.Add(p)
                p.Direction = ParameterDirection.Input
            Next
            p = cmd.Parameters.Add(New SqlParameter("@RetVal", SqlDbType.Int))
            p.Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery()
            retVal = cmd.Parameters("@RetVal").Value
            cmd.Dispose()
        Finally
            CloseConnection(cn)
        End Try
        Return retVal
    End Function

    'Below 2 Functions below simply let you run "Pass Through" SQL Queries and Action Queries. 
    Public Function RunPassSQL(ByVal strSQL As String) As SqlDataReader
        Dim cn As SqlConnection = OpenConnection()
        Dim rdr As SqlDataReader
        Dim cmd As New SqlCommand(strSQL, cn)
        cmd.CommandTimeout = 8000
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Dispose()
        Return rdr
    End Function

    Public Sub RunActionQuery(ByVal strSQL As String)
        Dim cn As SqlConnection = OpenConnection()
        Dim cmd As New SqlCommand(strSQL, cn)
        cmd.CommandTimeout = 8000
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Finally
            CloseConnection(cn)
        End Try
    End Sub

    Public Function RunSQLReturnDS(ByVal strSQL As String) As DataSet
        Dim cn As SqlConnection = OpenConnection()

        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter(strSQL, cn)
        da.SelectCommand.CommandTimeout = 8000
        da.Fill(ds, "dsIdentity")
        CloseConnection(cn)
        da.Dispose()
        Return ds
    End Function
    Public Function RunSQLReturnDataTable(ByVal strSQL As String) As DataTable

        Dim table As New DataTable
        Dim dreader As SqlDataReader = Nothing
        Dim i As Integer = 0
        Dim cn As SqlConnection
        Dim da As SqlDataAdapter
        Dim ds As New DataSet()
        Try
            cn = OpenConnection()
            da = New SqlDataAdapter(strSQL, cn)
            da.Fill(ds)

            da.Dispose()
            ds.Dispose()
            CloseConnection(cn)

            Return ds.Tables(0)
            'dreader = RunSQLReturnDR(strSQL)
            'Dim fieldCount As Integer = dreader.FieldCount
            'For i = 0 To fieldCount - 1

            '    table.Columns.Add(dreader.GetName(i), dreader.GetFieldType(i))

            'Next
            'table.BeginLoadData()
            'Dim values(fieldCount - 1) As Object
            'While (dreader.Read())
            '    dreader.GetValues(values)
            '    table.LoadDataRow(values, True)
            'End While
            'table.EndLoadData()
            'dreader.Close()


        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
            'dreader = Nothing
        End Try
        Return table
    End Function

    Public Function RunSPReturnDataSet(ByVal strSP As String, ByVal ParamArray commandParameters() As SqlParameter) As DataSet
        Dim cn As SqlConnection = OpenConnection()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(strSP, cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.CommandTimeout = 8000
        Dim p As SqlParameter
        For Each p In commandParameters
            da.SelectCommand.Parameters.Add(p)
            p.Direction = ParameterDirection.Input
        Next
        da.Fill(ds, "dsIdentity")
        CloseConnection(cn)
        da.Dispose()
        Return ds
    End Function

    'Two overloaded Functions given below will allow you to pass a Stored Procedure Name with or without parameters and returns a DataReader
    Public Overloads Function RunSPReturnDR(ByVal strSP As String, ByVal ParamArray commandParameters() As SqlParameter) As SqlDataReader
        Dim cn As SqlConnection = OpenConnection()
        Dim rdr As SqlDataReader
        Dim cmd As New SqlCommand(strSP, cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 8000
        Dim p As SqlParameter
        For Each p In commandParameters
            p = cmd.Parameters.Add(p)
            p.Direction = ParameterDirection.Input
        Next
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Dispose()
        Return rdr
    End Function

    Public Overloads Function RunSPReturnDR(ByVal strSP As String) As SqlDataReader
        Dim cn As SqlConnection = OpenConnection()
        Dim rdr As SqlDataReader
        Dim cmd As New SqlCommand(strSP, cn)
        cmd.CommandTimeout = 8000
        cmd.CommandType = CommandType.StoredProcedure
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Dispose()
        Return rdr
    End Function

    Public Overloads Function RunSP(ByVal strSP As String)
        Dim cn As SqlConnection = OpenConnection()
        Dim cmd As New SqlCommand(strSP, cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 8000
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        CloseConnection(cn)
    End Function

    'For Stored Stored procedures that dont return anything
    Public Overloads Function RunSP(ByVal strSP As String, ByVal ParamArray commandParameters() As SqlParameter)
        Dim cn As SqlConnection = OpenConnection()
        Dim cmd As New SqlCommand(strSP, cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 8000
        Dim p As SqlParameter
        For Each p In commandParameters
            p = cmd.Parameters.Add(p)
            p.Direction = ParameterDirection.Input
        Next
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        CloseConnection(cn)
    End Function

    Public Function RunSQLReturnDR(ByVal strSQL As String) As SqlDataReader
        Dim cn As SqlConnection = OpenConnection()
        Dim rdr As SqlDataReader
        Dim cmd As New SqlCommand(strSQL, cn)
        cmd.CommandTimeout = 8000
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Dispose()
        Return rdr
    End Function

    Public Sub RunSQL(ByVal strSQL As String)
        Dim cn As SqlConnection = OpenConnection()
        Dim cmd As New SqlCommand(strSQL, cn)
        cmd.CommandTimeout = 8000
        Try
            cmd.ExecuteNonQuery()
        Finally
            cmd.Dispose()
            CloseConnection(cn)
        End Try
    End Sub

    Public Function RunSQLReturnRecordCount(ByVal strSQL As String) As Integer
        Dim cn As SqlConnection = OpenConnection()
        Dim cmd As New SqlCommand(strSQL, cn)
        Dim rc As Integer = -1
        Try
            rc = cmd.ExecuteScalar()
        Finally
            cmd.Dispose()
            CloseConnection(cn)
        End Try
        Return rc
    End Function


    Public Function RunSPReturnDataTable(ByVal strSP As String, ByVal ParamArray commandParameters() As SqlParameter) As DataTable
        Dim cn As SqlConnection = OpenConnection()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(strSP, cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.CommandTimeout = 8000
        Dim p As SqlParameter
        For Each p In commandParameters
            da.SelectCommand.Parameters.Add(p)
            p.Direction = ParameterDirection.Input
        Next
        da.Fill(ds, "dsIdentity")
        CloseConnection(cn)
        da.Dispose()
        Return ds.Tables("dsIdentity")
    End Function

End Class
