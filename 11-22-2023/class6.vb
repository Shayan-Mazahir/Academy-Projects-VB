' Write a program which input a number and output if its even or odd

Imports System.Console
Module Module1

    Sub Main()
        Dim n1 As Integer
        Dim even As Integer
        write("Enter n1: ")
        n1 = ReadLine()
        even = n1 Mod 2
        If even = 0 Then
            WriteLine("Even")
        Else
            WriteLine("Odd")
        End If

    End Sub
End Module