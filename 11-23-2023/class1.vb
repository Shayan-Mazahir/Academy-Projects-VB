' Input: A number
' Output: if it Positive, negative or zero
Imports System.Console
Module Module1

    Sub Main()
    Dim n As Integer
    Write("Enter the number: ")
    n = ReadLine()
    If n = 0 Then
        WriteLine("Number is Zero")
    Else
        If n > 0 Then
            WriteLine("Number is Positive")
        Else
            WriteLine("Number is Negative")
        End If
    End If

    End Sub
End Module