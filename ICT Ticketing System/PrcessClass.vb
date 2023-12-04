Imports System.Data.SqlClient
Imports MetroFramework
Imports System.Data

Public Class PrcessClass
    Dim strStatus As String = String.Empty

    Public Function SaveEmployeeRequest(strSaveType As String, strEmployeeName As String, strRequest As String, strRemarks As String)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim CurrentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt")
                Dim sqlcmd = New SqlCommand("SP_SaveEmployeeRequest", conn)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strTicketNo", "TempID1"))
                sqlcmd.Parameters.Add(New SqlParameter("@strEmployeeName", strEmployeeName))
                sqlcmd.Parameters.Add(New SqlParameter("@strRequest", strRequest))
                sqlcmd.Parameters.Add(New SqlParameter("@strRemarks", strRemarks))
                sqlcmd.Parameters.Add(New SqlParameter("@dateRequest", CurrentDateTime))

                conn.Open()
                sqlcmd.ExecuteNonQuery()
            End Using

            strStatus = "true"

        Catch ex As Exception
            strStatus = ex.Message.ToString()
        End Try

        Return strStatus

    End Function

    Public Function UpdateEmployeeRequest(strTicketNo As String, intStatus As Integer, intTechEngineer As Integer, strDateCompleted As DateTime)

        Try

            Using conn As New SqlConnection(connectionstring)
                Dim CurrentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt")
                Dim sqlcmd = New SqlCommand("SP_UpdateEmployeeRequest", conn)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strTicketNo", strTicketNo))
                sqlcmd.Parameters.Add(New SqlParameter("@intStatus", intStatus))
                sqlcmd.Parameters.Add(New SqlParameter("@intTechEngineer", intTechEngineer))
                sqlcmd.Parameters.Add(New SqlParameter("@strDateCompleted", CurrentDateTime))


                conn.Open()

                sqlcmd.ExecuteNonQuery()
            End Using

            strStatus = "true"

        Catch ex As Exception
            strStatus = ex.Message.ToString()
        End Try

        Return strStatus

    End Function

    Public Function UpdateRatingEmployeeRequest(strTicketNo As String, intRating As Integer)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand("SP_UpdateRating", conn)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strTicketNo", strTicketNo))
                sqlcmd.Parameters.Add(New SqlParameter("@rating", intRating))

                conn.Open()

                sqlcmd.ExecuteNonQuery()
            End Using

            strStatus = "true"
        Catch ex As Exception
            strStatus = ex.Message.ToString()
        End Try

        Return strStatus

    End Function

    Public Function DeleteEmployeeRequest(SP_Name As String, strTicketNo As String)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand(SP_Name, conn)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strTicketNo", strTicketNo))

                conn.Open()

                sqlcmd.ExecuteNonQuery()
            End Using

            strStatus = "true"

        Catch ex As Exception
            strStatus = ex.Message.ToString()
        End Try

        con.Close()
        con.Dispose()
        Return strStatus

    End Function

    Public Function GetUserRequest(SP_Value As String) As DataTable

        Dim SqlCmd As New SqlCommand
        Dim sqlAdapter As New SqlDataAdapter
        Dim DT As New DataTable

        Using conn As New SqlConnection(connectionstring)
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.CommandText = SP_Value
            conn.Open()
            SqlCmd.Connection = conn
            sqlAdapter.SelectCommand = SqlCmd
            sqlAdapter.Fill(DT)
            conn.Close()
        End Using

        Return DT

    End Function

    Public Function GetuserLevel(strUsername As String, strPassword As String)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand("SP_GetUseLevel", conn)
                Dim reader As SqlDataReader
                conn.Open()
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@U_name", strUsername))
                sqlcmd.Parameters.Add(New SqlParameter("@strPassword", strPassword))
                Dim intLevel As SqlParameter = New SqlParameter("@intLevel", SqlDbType.Int)
                intLevel.Direction = ParameterDirection.Output
                sqlcmd.Parameters.Add(intLevel)
                reader = sqlcmd.ExecuteReader()
                strStatus = intLevel.Value.ToString()
                reader.Close()
                cmd.Dispose()

            End Using

        Catch ex As Exception
            strStatus = ex.Message.ToString
        End Try
        Return strStatus

    End Function

    Public Function CheckUsername(strUname As String)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand("SP_CheckUserName", conn)
                Dim reader As SqlDataReader
                conn.Open()
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strUname", strUname))
                Dim intStatus As SqlParameter = New SqlParameter("@intStatus", SqlDbType.Int)
                intStatus.Direction = ParameterDirection.Output
                sqlcmd.Parameters.Add(intStatus)
                reader = sqlcmd.ExecuteReader()
                strStatus = intStatus.Value.ToString()
                reader.Close()
                cmd.Dispose()

            End Using

        Catch ex As Exception
            strStatus = ex.Message.ToString
        End Try
        Return strStatus

    End Function

    Public Function CheckTechname(strTechCheck As String)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand("SP_CheckTechName", conn)
                Dim reader As SqlDataReader
                conn.Open()
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strTechnicianName", strTechCheck))
                Dim intTech As SqlParameter = New SqlParameter("@intTech", SqlDbType.Int)
                intTech.Direction = ParameterDirection.Output
                sqlcmd.Parameters.Add(intTech)
                reader = sqlcmd.ExecuteReader()
                strStatus = intTech.Value.ToString
                reader.Close()
                cmd.Dispose()
            End Using
        Catch ex As Exception
            strStatus = ex.Message.ToString
        End Try
        Return strStatus
    End Function

    Public Function SaveUserlogin(Uname As String, Pword As String, Ulvl As Integer)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand("SP_SaveUserlogin", conn)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@Uname", Uname))
                sqlcmd.Parameters.Add(New SqlParameter("@Pword", Pword))
                sqlcmd.Parameters.Add(New SqlParameter("@Ulevelstr", Ulvl))

                conn.Open()
                sqlcmd.ExecuteNonQuery()

            End Using
            strStatus = "true"
        Catch ex As Exception
            strStatus = ex.Message.ToString()
        End Try
        Return strStatus
    End Function

    Public Function GetUser(SP_DgVal As String) As DataTable
        Dim SqlCmd As New SqlCommand
        Dim sqlAdapter As New SqlDataAdapter
        Dim DT As New DataTable

        Using conn As New SqlConnection(connectionstring)
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.CommandText = SP_DgVal
            conn.Open()
            SqlCmd.Connection = conn
            sqlAdapter.SelectCommand = SqlCmd
            sqlAdapter.Fill(DT)
            conn.Close()
        End Using
        Return DT
    End Function

    Public Function GetEmployeeRequest(SP_ValuePrint As String) As DataTable
        Dim sqlCmd As New SqlCommand
        Dim sqlAdapter As New SqlDataAdapter
        Dim DT As New DataTable

        Using conn As New SqlConnection(connectionstring)
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = SP_ValuePrint
            conn.Open()
            sqlCmd.Connection = conn
            sqlAdapter.SelectCommand = sqlCmd
            sqlAdapter.Fill(DT)
            conn.Close()
        End Using
        Return DT
    End Function

    Public Function FilterGetEmployeeRequest(SP_ValuePrint As String, DateFrom As DateTime, DateTo As DateTime, strEngr As String) As DataTable
        Dim sqlCmd As New SqlCommand
        Dim sqlAdapter As New SqlDataAdapter
        Dim DT As New DataTable

        Using conn As New SqlConnection(connectionstring)
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = SP_ValuePrint
            sqlCmd.Parameters.Add(New SqlParameter("@DateFrom", DateFrom))
            sqlCmd.Parameters.Add(New SqlParameter("@DateTo", DateTo))
            sqlCmd.Parameters.Add(New SqlParameter("@Engineer", strEngr))
            conn.Open()
            sqlCmd.Connection = conn
            sqlAdapter.SelectCommand = sqlCmd
            sqlAdapter.Fill(DT)
            conn.Close()
        End Using
        Return DT
    End Function

    Public Function GetEmployeeSummary(SP_GetSummaryPrint As String, DateFrom As DateTime, DateTo As DateTime) As DataTable
        Dim sqlCmd As New SqlCommand
        Dim sqlAdapter As New SqlDataAdapter
        Dim DT As New DataTable

        Using conn As New SqlConnection(connectionstring)
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = SP_GetSummaryPrint
            sqlCmd.Parameters.Add(New SqlParameter("@DateFrom", DateFrom))
            sqlCmd.Parameters.Add(New SqlParameter("@DateTo", DateTo))

            conn.Open()
            sqlCmd.Connection = conn
            sqlAdapter.SelectCommand = sqlCmd
            sqlAdapter.Fill(DT)
            conn.Close()
        End Using
        Return DT
    End Function

    Public Function GetTechnicianGrid(SP_ValueTechGrid As String) As DataTable
        Dim sqlCmd As New SqlCommand
        Dim sqlAdapter As New SqlDataAdapter
        Dim DT As New DataTable

        Using conn As New SqlConnection(connectionstring)
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = SP_ValueTechGrid
            conn.Open()
            sqlCmd.Connection = conn
            sqlAdapter.SelectCommand = sqlCmd
            sqlAdapter.Fill(DT)
            conn.Close()
        End Using
        Return DT
    End Function

    Public Function GetUserLog(SP_USERDgVal As String) As DataTable
        Dim SqlCmd As New SqlCommand
        Dim sqlAdapter As New SqlDataAdapter
        Dim DT As New DataTable

        Using conn As New SqlConnection(connectionstring)
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.CommandText = SP_USERDgVal
            conn.Open()
            SqlCmd.Connection = conn
            sqlAdapter.SelectCommand = SqlCmd
            sqlAdapter.Fill(DT)
            conn.Close()
        End Using
        Return DT
    End Function

    Public Function SP_DeleteTech(SP_Tech As String, strTech As String)
        Try

            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand(SP_Tech, conn)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strTech", strTech))

                conn.Open()

                sqlcmd.ExecuteNonQuery()
            End Using

            strStatus = "true"

        Catch ex As Exception
            strStatus = ex.Message.ToString()
        End Try

        con.Close()
        con.Dispose()
        Return strStatus
    End Function

    Public Function SaveTechnician(strTechengineer As String)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand("SP_SaveTechician", conn)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strTechname", strTechengineer))
                conn.Open()
                sqlcmd.ExecuteNonQuery()
            End Using

            strStatus = "True"

        Catch ex As Exception
            strStatus = ex.Message.ToString
        End Try
        Return strStatus
    End Function

    Public Function SP_DeleteUser(deleteUser As String, strdeleteuser As String)
        Try
            Using conn As New SqlConnection(connectionstring)
                Dim sqlcmd = New SqlCommand(deleteUser, conn)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add(New SqlParameter("@strUser", strdeleteuser))
                conn.Open()
                sqlcmd.ExecuteNonQuery()
            End Using

            strStatus = "true"
        Catch ex As Exception
            strStatus = ex.Message.ToString()
        End Try
        con.Close()
        con.Dispose()
        Return strStatus
    End Function

    Public Function GetstrTotal() As String

        Dim sqlCmd As New SqlCommand
        Dim intTotal As Int32

        Using conn As New SqlConnection(connectionstring)
            sqlCmd = New SqlCommand("SP_GetPendings", conn)
            sqlCmd.CommandType = CommandType.StoredProcedure

            Dim parRTValue As SqlParameter = New SqlParameter("@intTotal", SqlDbType.Int)

            parRTValue.Direction = ParameterDirection.Output

            sqlCmd.Parameters.Add(parRTValue)
            conn.Open()
            sqlCmd.ExecuteNonQuery()
            intTotal = sqlCmd.Parameters("@intTotal").Value
            conn.Close()
        End Using
        Return intTotal

    End Function


End Class
