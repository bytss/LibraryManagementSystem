Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHashing
    Public Shared Function GenerateSalt() As String
        Dim saltSize As Integer = 16 ' You can adjust the salt size as needed (16 bytes = 128 bits)
        Dim saltBytes As Byte() = New Byte(saltSize - 1) {}
        Using rngCsp As New RNGCryptoServiceProvider()
            rngCsp.GetBytes(saltBytes)
        End Using
        Return Convert.ToBase64String(saltBytes)
    End Function

    Public Shared Function HashPassword(password As String, salt As String) As String
        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim saltBytes As Byte() = Convert.FromBase64String(salt)

        Using sha256 As New SHA256Managed()
            Dim saltedPassword As Byte() = New Byte(passwordBytes.Length + saltBytes.Length - 1) {}
            Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length)
            Buffer.BlockCopy(saltBytes, 0, saltedPassword, passwordBytes.Length, saltBytes.Length)

            Dim hashedBytes As Byte() = sha256.ComputeHash(saltedPassword)
            Return Convert.ToBase64String(hashedBytes)
        End Using
    End Function

    Public Shared Function VerifyPassword(password As String, hashedPassword As String, salt As String) As Boolean
        Dim newHashedPassword As String = HashPassword(password, salt)
        Return String.Equals(newHashedPassword, hashedPassword)
    End Function

End Class
