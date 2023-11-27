' Output: 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024
Imports System.Console
Module Module1

    Sub Main()
    Dim n As Integer
    n = 1

program:
    WriteLine(n)
    n = n * 2
    If n <= 1025 Then GoTo program

    End Sub
End Module