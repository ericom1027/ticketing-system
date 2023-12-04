Imports System.Data.SqlClient
Module connection
    'Public connectionstring As String = "Data Source=MIS-PC;Initial Catalog=NPDCTS;Integrated Security=SSPI;User ID =local\local;Password=npdcadmin2018;"
    'Public connectionstring As String = "Data Source=192.168.1.248;Network Library=DBMSSOCN;Initial Catalog=NPDCTS;User ID=LOCAL;Password=npdcadmin2018;"
    Public connectionstring As String = "Data Source=AUGUSTA;Initial Catalog=NPDCTS;Integrated Security=SSPI;User ID =admin\admin;Password=sql_2014;"
    Public con As SqlConnection = New SqlConnection(connectionstring)
    Public cmd, cmd1 As New SqlCommand
    Public commstring As String
    Public gUserName As String
    Public gUsrLvl As String

End Module
