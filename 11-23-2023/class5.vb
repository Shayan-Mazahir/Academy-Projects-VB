' Grading criteria 90+ A*, 80 - 89 A, 70 - 79 B, 60-69 C, 50 - 59 D, 40-49 E, Below 40 U
' Input: Marks of Three different subjects
' Output: Average marks and Grade

Imports System.Console

Module Module1
    Sub Main()
        Dim subj1 As Integer
        Dim subj2 As Integer
        Dim subj3 As Integer

        Write("Enter Marks of subject 1: ")
        subj1 = Convert.ToInt32(ReadLine())

        Write("Enter marks of subject 2: ")
        subj2 = ReadLine()

        Write("Enter marks of subject 3: ")
        subj3 = ReadLine()

        Dim avg As Integer
        avg = (subj1 + subj2 + subj3) / 3

        WriteLine("The average is: " & avg)

        If avg >= 90 Then
            WriteLine("Grade: A*")
        ElseIf avg >= 80 Then
            WriteLine("Grade: A")
        ElseIf avg >= 70 Then
            WriteLine("Grade: B")
        ElseIf avg >= 60 Then
            WriteLine("Grade: C")
        ElseIf avg >= 50 Then
            WriteLine("Grade: D")
        ElseIf avg >= 40 Then
            WriteLine("Grade: E")
        Else
            WriteLine("Grade: U")
        End If
    End Sub
End Module
