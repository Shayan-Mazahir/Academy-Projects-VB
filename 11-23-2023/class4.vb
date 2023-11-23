' Car are rated on their speed, Over speeding for speed above 100, Fast (80 - 99), Normal (50 - 79) and Slow
' below 50.
' Input: Speed
' Output: its rating
Imports System.Console

Module Module1
    Sub Main()
        Dim speed As Integer
        Write("Enter Car Speed: ")
        speed = ReadLine()

        If speed < 50 Then
            WriteLine("Slow")
        ElseIf speed >= 50 AndAlso speed <= 79 Then
            WriteLine("Normal")
        ElseIf speed >= 80 AndAlso speed <= 99 Then
            WriteLine("Fast")
        Else
            WriteLine("Over Speeding")
        End If
    End Sub
End Module