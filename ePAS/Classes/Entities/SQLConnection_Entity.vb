Imports System.Text
'Imports System.Collections.Specialized
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SQLConnection_Entity
    Public sConnString As String = ""
    Public sConnStringServer As String = ""

    Public Sub New()
        'Note: 09.23.2022 - Testing a case:
        '                   The default and primary database is the localdb.  server db will be updated by schedule

        'let sConnString be the active connection string, may either be the main or the local
        sConnString = GetSQLConnectionString() 'this may contain "firsttimesetup" value, the localdb, or the server db
        sConnStringServer = GetSQLConnectionString("ConnectionStringServer")
        'sConnString will be processed by DBSetup after this
    End Sub

    Public Function GetSQLConnectionString(Optional sConnStringName As String = "ConnectionString") As String
        Dim sConnString As String = ConfigurationManager.ConnectionStrings(sConnStringName).ConnectionString

        Dim sConnArray() As String
        sConnArray = sConnString.Split(";")

        sConnString = ""

        For i As Integer = 0 To sConnArray.Length - 1
            If sConnArray(i).StartsWith("User ID=") Then
                sConnArray(i) = "User ID=" + Decrypt(sConnArray(i).Substring(8))
            End If
            If sConnArray(i).StartsWith("Password=") Then
                sConnArray(i) = "Password=" + Decrypt(sConnArray(i).Substring(9))
            End If

            'reconstruct the connection string
            If sConnArray(i) <> "" Then sConnString = sConnString + sConnArray(i) + ";"
        Next

        sConnString = sConnString.Substring(0, sConnString.Length - 1)

        Return sConnString
    End Function

    Public Function Encrypt(ByVal sToEncrypt As String) As String

        Dim bytKeyArray() As Byte
        Dim bytToEncryptArray() As Byte = UTF8Encoding.UTF8.GetBytes(sToEncrypt)

        'Dim settingsReader As New System.Configuration.AppSettingsReader()

        Dim sKey As String = "SCT"
        Dim hashmd5 As New MD5CryptoServiceProvider()

        bytKeyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sKey))

        hashmd5.Clear()

        Dim tdes As New TripleDESCryptoServiceProvider()

        tdes.Key = bytKeyArray
        tdes.Mode = CipherMode.ECB
        tdes.Padding = PaddingMode.PKCS7

        Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()

        Dim bytResultArray() As Byte = cTransform.TransformFinalBlock(bytToEncryptArray, 0, _
              bytToEncryptArray.Length)

        tdes.Clear()

        Return Convert.ToBase64String(bytResultArray, 0, bytResultArray.Length)
    End Function

    Public Function Decrypt(ByVal sCipherString As String) As String
        Dim bytkeyArray() As Byte

        Dim bytToEncryptArray() As Byte = Convert.FromBase64String(sCipherString)
        'Dim settingsReader As New System.Configuration.AppSettingsReader()

        Dim sKey As String = "SCT"
        Dim hashmd5 As New MD5CryptoServiceProvider()
        bytkeyarray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sKey))
        hashmd5.Clear()
        Dim tdes As New TripleDESCryptoServiceProvider()

        tdes.Key = bytkeyArray
        tdes.Mode = CipherMode.ECB
        tdes.Padding = PaddingMode.PKCS7

        Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
        Dim bytResultArray() As Byte = cTransform.TransformFinalBlock(bytToEncryptArray, 0, bytToEncryptArray.Length)

        tdes.Clear()

        Return UTF8Encoding.UTF8.GetString(bytResultArray)
    End Function

    Public Function SaveConfig(ByVal iAuthenticationType As Integer) As Integer
        Dim sConnArray() As String
        sConnArray = sConnString.Split(";")

        sConnString = ""

        For i As Integer = 0 To sConnArray.Length - 1

            If sConnArray(i).StartsWith("Password=") Then
                sConnArray(i) = "Password=" + Encrypt(sConnArray(i).Substring(9))
            End If

            'reconstruct the connection string
            sConnString = sConnString + sConnArray(i) + ";"
        Next


        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        config.ConnectionStrings.ConnectionStrings.Item("ConnectionString").ConnectionString = sConnString
        config.Save()

    End Function

    Public Function UpdateConfig(ByVal sConnStr As String) As Integer
        Dim sConnArray() As String
        sConnArray = sConnStr.Split(";")

        sConnStr = ""

        For i As Integer = 0 To sConnArray.Length - 1

            If sConnArray(i).StartsWith("Password=") Then
                sConnArray(i) = "Password=" + sConnArray(i).Substring(9)
            End If

            'reconstruct the connection string
            sConnStr = sConnStr + sConnArray(i) + ";"
        Next

        'verify if database is the correct one
        Try
            SqlHelper.ExecuteDataset(sConnStr, CommandType.Text, "select * from tbl_Version")
        Catch ex As SqlException
            Return ex.Number
        End Try

        sConnStr = ""
        For i As Integer = 0 To sConnArray.Length - 1

            If sConnArray(i).StartsWith("Password=") Then
                sConnArray(i) = "Password=" + Encrypt(sConnArray(i).Substring(9))
            End If

            'reconstruct the connection string
            sConnStr = sConnStr + sConnArray(i) + ";"
        Next

        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.ConnectionStrings.ConnectionStrings.Item("ConnectionString").ConnectionString = sConnStr
        config.Save(System.Configuration.ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("connectionStrings")

        sConnString = GetSQLConnectionString()

        Return 0
    End Function

    Public Function CheckConnection() As Boolean
        Dim sqlConn As New SqlConnection()
        Dim ds As New DataSet()

        Try
            If sqlConn.State <> ConnectionState.Closed Then
                sqlConn.Close()
            End If
            sqlConn.ConnectionString = sConnString
            sqlConn.Open()
            sqlConn.Close()

            'Check if the database is the correct one
            ds = SqlHelper.ExecuteDataset(sConnString, CommandType.Text, "select * from tbl_Version")
            If ds.Tables.Count = 0 Then
                Return False
            End If
            Return True
        Catch ex As SqlException
            If ex.Number = 208 Then
                MessageBox.Show("Wrong database in configuration.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return False
        End Try
    End Function
End Class
