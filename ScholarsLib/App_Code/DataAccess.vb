Imports System.Data.SqlClient

Public Class DataAccess
    Implements IDisposable

    Dim DbConn As New SqlConnection
    Dim da As New SqlDataAdapter

    Public Sub New()
        DbConn.ConnectionString = "Server=GRADEN2;Database=scholars_prod;Integrated Security=SSPI;Trusted_Connection=True;"
    End Sub

    Public Function GetTable(ByVal TheCommand As SqlCommand) As DataTable
        Dim dt As New DataTable

        TheCommand.Connection = DbConn
        da.SelectCommand = TheCommand

        Try
            DbConn.Open()

            da.Fill(dt)
        Finally
            DbConn.Close()
        End Try

        Return dt
    End Function

    Public Function GetScalar(ByVal TheCommand As SqlCommand) As Object
        Dim ret_val As New Object

        TheCommand.Connection = DbConn

        Try
            DbConn.Open()

            ret_val = TheCommand.ExecuteScalar()
        Finally
            DbConn.Close()
        End Try

        Return ret_val
    End Function

    Public Sub GetNothing(ByVal TheCommand As SqlCommand)
        TheCommand.Connection = DbConn

        Try
            DbConn.Open()

            TheCommand.ExecuteNonQuery()
        Finally
            DbConn.Close()
        End Try
    End Sub

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free managed resources when explicitly called
            End If

            ' TODO: free shared unmanaged resources
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class