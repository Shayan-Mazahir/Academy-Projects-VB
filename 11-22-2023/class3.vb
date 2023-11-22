Imports System.Console
Module Module1

    Sub Main()
        Dim n1 As Integer
        Dim total As Integer
        write("Enter marks of studen: ")
        n1 = ReadLine()
        total = 50
        If n1 >= total Then
            WriteLine("Pass")
        Else
            WriteLine("Fail")
        End If

    End Sub
End Module