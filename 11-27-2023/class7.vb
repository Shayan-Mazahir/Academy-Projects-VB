' Input: Starting number and ending number
' Output: Counting between starting and ending number

Imports System.Console
Module Module1

    Sub Main()
        Dim starting, ending, variable As Integer

        Write("Enter starting number: ")
        starting = ReadLine()

        Write("Enter ending number: ")
        ending = ReadLine()

        If ending < starting Then
            WriteLine("Ending number cannot be less than starting number")
        Else
            variable = starting

            program:
            WriteLine(variable)
            variable += 1

            If variable <= ending Then GoTo program
        End If
    End Sub
End Module
