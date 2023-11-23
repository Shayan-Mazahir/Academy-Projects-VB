' Weather is rate as V. Hot for temperature above 35, Hot (25 - 35), Normal (16–24) and
'  cold below 16.
' Input: Temperature
' Output: its rating.
Imports System.Console

Module Module1
    Sub Main()
        Dim v As Integer
        Write("Enter temperature: ")
        v = ReadLine()

        If v < 16 Then
            WriteLine("Cold")
        ElseIf v >= 16 AndAlso v <= 24 Then
            WriteLine("Normal")
        ElseIf v >= 25 AndAlso v <= 35 Then
            WriteLine("Hot")
        Else
            WriteLine("V. Hot")
        End If
    End Sub
End Module