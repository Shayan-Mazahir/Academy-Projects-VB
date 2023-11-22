' Input: Two numbers
' Output: these numbers in ascending order.
Imports System.Console
Module Module1

    Sub Main()
        Dim n1 As Integer
        Dim n2 As Integer
        write("Enter number 1: ")
        n1 = ReadLine()
        write("Enter number 2: ")
        n2 = ReadLine()
        If n1 > n2 Then
            WriteLine("Ascending order number would be: " & n1 & n2)
        Else 
            WriteLine("Ascending order of the nummber would be: " & n2 & n1)
        End If

    End Sub
End Module
