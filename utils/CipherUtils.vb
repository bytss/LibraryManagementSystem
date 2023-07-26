
Imports System.Security.Cryptography
Imports System.Text

Public Class CipherUtils
    Public Shared Function EncryptPassword(password As String) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
    End Function

    Public Shared Function VerifyPassword(inputPassword As String, storedHashedPassword As String) As Boolean
        Dim hashedInputPassword As String = EncryptPassword(inputPassword)
        Return String.Equals(hashedInputPassword, storedHashedPassword)
    End Function

End Class
