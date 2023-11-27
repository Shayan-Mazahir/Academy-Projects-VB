' Input a number and see if its even or odd

Imports System.Console
Module Module1

    Sub Main()
    Dim n As Integer
    Write("Please enter a number: ")
    n = ReadLine()
    If n MOD 2 = 0 Then
        WriteLine("Even number")
    Else
        WriteLine("Odd Number")
    End IF

    End Sub
End Module