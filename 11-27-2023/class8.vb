' Input: A number
' Output: its first 10 multiples
Imports System.Console

Module Module1
    Sub Main()
        Dim number, multiple, counter As Integer

        WriteLine("Enter a number: ")
        number = ReadLine()

        counter = 1

    program:
        multiple = number * counter
        WriteLine(number & " x " & counter & " = " & multiple)

        counter += 1
        If counter <= 10 Then GoTo program
    End Sub
End Module
