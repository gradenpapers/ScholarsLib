Imports System.Data.SqlClient

Public Class DataLayer
    Inherits DataAccess

#Region "Initialization Region"
    Dim TheCommand As New SqlCommand

    Public Sub New()
        TheCommand.CommandType = CommandType.StoredProcedure
    End Sub
#End Region

#Region "User Region"
    Public Function GetUserInfo(ByVal UserId As Integer) As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "get_user_info"
            .Parameters.AddWithValue("@user_id", UserId)
        End With

        Return GetTable(TheCommand)
    End Function

    Public Function UserLogin(ByVal Username As String, ByVal Password As String) As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "user_login"
            .Parameters.AddWithValue("@username", Username)
            .Parameters.AddWithValue("@password", Password)
        End With

        Return GetTable(TheCommand)
    End Function

    Public Function GetUsers(ByVal FirstName As String, ByVal MiddleName As String, ByVal LastName As String, ByVal Email As String) As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "get_users"
            .Parameters.AddWithValue("@first_name", FirstName)
            .Parameters.AddWithValue("@middle_name", MiddleName)
            .Parameters.AddWithValue("@last_name", LastName)
            .Parameters.AddWithValue("@email", Email)
        End With

        Return GetTable(TheCommand)
    End Function

    Public Function AddUser(ByVal Username As String, ByVal Password As String, ByVal FirstName As String, ByVal MiddleName As String, ByVal LastName As String, ByVal Email As String, ByVal Address As String, ByVal City As String, ByVal StateCd As String, ByVal Zip As String, ByVal HomePhone As String, ByVal OtherPhone As String, ByVal Administrator As Boolean) As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "add_user"
            .Parameters.AddWithValue("@username", Username)
            .Parameters.AddWithValue("@password", Password)
            .Parameters.AddWithValue("@first_name", FirstName)
            .Parameters.AddWithValue("@middle_name", MiddleName)
            .Parameters.AddWithValue("@last_name", LastName)
            .Parameters.AddWithValue("@email", Email)
            .Parameters.AddWithValue("@address", Address)
            .Parameters.AddWithValue("@city", City)
            .Parameters.AddWithValue("@state_cd", StateCd)
            .Parameters.AddWithValue("@zip", Zip)
            .Parameters.AddWithValue("@home_phone", HomePhone)
            .Parameters.AddWithValue("@other_phone", OtherPhone)
            .Parameters.AddWithValue("@administrator", Administrator)
        End With

        Return GetTable(TheCommand)
    End Function

    Public Function UpdateUser(ByVal UserId As Integer, ByVal Username As String, ByVal Password As String, ByVal FirstName As String, ByVal MiddleName As String, ByVal LastName As String, ByVal Email As String, ByVal Address As String, ByVal City As String, ByVal StateCd As String, ByVal Zip As String, ByVal HomePhone As String, ByVal OtherPhone As String, ByVal Administrator As Boolean) As String
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "update_user"
            .Parameters.AddWithValue("@user_id", UserId)
            .Parameters.AddWithValue("@username", Username)
            .Parameters.AddWithValue("@password", Password)
            .Parameters.AddWithValue("@first_name", FirstName)
            .Parameters.AddWithValue("@middle_name", MiddleName)
            .Parameters.AddWithValue("@last_name", LastName)
            .Parameters.AddWithValue("@email", Email)
            .Parameters.AddWithValue("@address", Address)
            .Parameters.AddWithValue("@city", City)
            .Parameters.AddWithValue("@state_cd", StateCd)
            .Parameters.AddWithValue("@zip", Zip)
            .Parameters.AddWithValue("@home_phone", HomePhone)
            .Parameters.AddWithValue("@other_phone", OtherPhone)
            .Parameters.AddWithValue("@administrator", Administrator)
        End With

        Return GetScalar(TheCommand)
    End Function

    Public Function DeleteUser(ByVal UserId As Integer) As String
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "delete_user"
            .Parameters.AddWithValue("@user_id", UserId)
        End With

        Return GetScalar(TheCommand)
    End Function

    Public Function GetStates() As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "get_state_dm"
        End With

        Return GetTable(TheCommand)
    End Function
#End Region

#Region "Item Region"
    Public Function GetItemInfo(ByVal ItemId As Integer) As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "get_item_info"
            .Parameters.AddWithValue("@item_id", ItemId)
        End With

        Return GetTable(TheCommand)
    End Function

    Public Function GetItemTypes() As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "get_item_type_dm"
        End With

        Return GetTable(TheCommand)
    End Function

    Public Function GetItems(ByVal Author As String, ByVal Title As String, ByVal PublishedFrom As String, ByVal PublishedTo As String, ByVal Publisher As String) As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "get_items"
            .Parameters.AddWithValue("@author", Author)
            .Parameters.AddWithValue("@title", Title)
            If PublishedFrom <> "" Then
                .Parameters.AddWithValue("@published_from", PublishedFrom)
            End If
            If PublishedTo <> "" Then
                .Parameters.AddWithValue("@published_to", PublishedTo)
            End If
            .Parameters.AddWithValue("@publisher", Publisher)
        End With

        Return GetTable(TheCommand)
    End Function

    Public Function AddItem(ByVal ItemTypeCd As String, ByVal Author As String, ByVal Title As String, ByVal PublishDate As Date, ByVal Publisher As String, ByVal PageCount As Integer, ByVal Benefactor As String) As String
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "add_item"
            .Parameters.AddWithValue("@item_type_cd", ItemTypeCd)
            .Parameters.AddWithValue("@author", Author)
            .Parameters.AddWithValue("@title", Title)
            .Parameters.AddWithValue("@publish_date", PublishDate)
            .Parameters.AddWithValue("@publisher", Publisher)
            .Parameters.AddWithValue("@page_count", PageCount)
            .Parameters.AddWithValue("@benefactor", Benefactor)
        End With

        Return GetScalar(TheCommand)
    End Function

    Public Function UpdateItem(ByVal ItemId As Integer, ByVal ItemTypeCd As String, ByVal Author As String, ByVal Title As String, ByVal PublishDate As Date, ByVal Publisher As String, ByVal PageCount As Integer, ByVal Benefactor As String) As String
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "update_item"
            .Parameters.AddWithValue("@item_id", ItemId)
            .Parameters.AddWithValue("@item_type_cd", ItemTypeCd)
            .Parameters.AddWithValue("@author", Author)
            .Parameters.AddWithValue("@title", Title)
            .Parameters.AddWithValue("@publish_date", PublishDate)
            .Parameters.AddWithValue("@publisher", Publisher)
            .Parameters.AddWithValue("@page_count", PageCount)
            .Parameters.AddWithValue("@benefactor", Benefactor)
        End With

        Return GetScalar(TheCommand)
    End Function

    Public Function DeleteItem(ByVal ItemId As Integer, ByVal ItemTypeCd As String, ByVal Author As String, ByVal Title As String, ByVal PublishDate As Date, ByVal Publisher As String, ByVal PageCount As Integer, ByVal Benefactor As String) As String
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "delete_item"
            .Parameters.AddWithValue("@item_id", ItemId)
        End With

        Return GetScalar(TheCommand)
    End Function
#End Region

#Region "Checkin/Checkout Region"
    Public Function Checkout(ByVal ItemId As Integer, ByVal UserId As Integer, ByVal CheckoutUser As Integer) As String
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "checkout"
            .Parameters.AddWithValue("@item_id", ItemId)
            .Parameters.AddWithValue("@user_id", UserId)
            .Parameters.AddWithValue("@check_out_user", CheckoutUser)
        End With

        Return GetScalar(TheCommand)
    End Function

    Public Function Checkin(ByVal ItemId As Integer, ByVal UserId As Integer, ByVal CheckinUser As Integer) As String
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "checkin"
            .Parameters.AddWithValue("@item_id", ItemId)
            .Parameters.AddWithValue("@user_id", UserId)
            .Parameters.AddWithValue("@check_in_user", CheckinUser)
        End With

        Return GetScalar(TheCommand)
    End Function

    Public Function GetUserCheckouts(ByVal UserId As Integer) As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "get_user_checkouts"
            .Parameters.AddWithValue("@user_id", UserId)
        End With

        Return GetTable(TheCommand)
    End Function

    Public Function GetUserCheckoutHistory(ByVal UserId As Integer) As DataTable
        TheCommand.Parameters.Clear()

        With TheCommand
            .CommandText = "get_user_checkout_history"
            .Parameters.AddWithValue("@user_id", UserId)
        End With

        Return GetTable(TheCommand)
    End Function
#End Region

End Class
