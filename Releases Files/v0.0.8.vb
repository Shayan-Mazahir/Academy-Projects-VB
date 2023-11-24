Imports System.Console

Module Module1
    Sub Main()
        ' Program 1
        WriteLine("Program 1 is running...")
        Dim n As Integer
        Write("Enter the number: ")
        n = CInt(ReadLine())
        If n = 0 Then
            WriteLine("Number is Zero")
        Else
            If n > 0 Then
                WriteLine("Number is Positive")
            Else
                WriteLine("Number is Negative")
            End If
        End If
        WriteLine()

        ' Program 2
        WriteLine("Program 2 is running...")
        Dim BS, tax, THS As Integer
        Write("Enter Salary: ")
        BS = CInt(ReadLine())

        If BS > 30000 Then
            tax = 0.05 * BS
        ElseIf BS > 65000 Then
            tax = 0.07 * BS
        ElseIf BS > 100000 Then
            tax = 0.1 * BS
        Else
            tax = 0
        End If

        THS = BS - tax
        WriteLine("Tax is " & tax)
        WriteLine("Take home salary is " & THS)
        WriteLine()

        ' Program 3
        WriteLine("Program 3 is running...")
        Dim v As Integer
        Write("Enter temperature: ")
        v = CInt(ReadLine())

        If v < 16 Then
            WriteLine("Cold")
        ElseIf v >= 16 AndAlso v <= 24 Then
            WriteLine("Normal")
        ElseIf v >= 25 AndAlso v <= 35 Then
            WriteLine("Hot")
        Else
            WriteLine("V. Hot")
        End If
        WriteLine()

        ' Program 4
        WriteLine("Program 4 is running...")
        Dim speed As Integer
        Write("Enter Car Speed: ")
        speed = CInt(ReadLine())

        If speed < 50 Then
            WriteLine("Slow")
        ElseIf speed >= 50 AndAlso speed <= 79 Then
            WriteLine("Normal")
        ElseIf speed >= 80 AndAlso speed <= 99 Then
            WriteLine("Fast")
        Else
            WriteLine("Over Speeding")
        End If
        WriteLine()

        ' Program 5
        WriteLine("Program 5 is running...")
        Dim subj1 As Integer
        Dim subj2 As Integer
        Dim subj3 As Integer

        Write("Enter Marks of subject 1: ")
        subj1 = CInt(ReadLine())

        Write("Enter marks of subject 2: ")
        subj2 = CInt(ReadLine())

        Write("Enter marks of subject 3: ")
        subj3 = CInt(ReadLine())

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
