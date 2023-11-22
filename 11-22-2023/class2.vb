Imports System.Console
Module Module1

    Sub Main()
        Dim n1 As Integer
        Dim n2 As Integer
        write("Enter first number: ")
        n1 = ReadLine()
        write("Enter second number: ")
        n2 = ReadLine()
        If n1 > n2 Then
            WriteLine(n1 & " Is greator")
        Else
            WriteLine(n2 & " Is greator")
        End If

    End Sub
End Module