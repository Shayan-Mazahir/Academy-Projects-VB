Imports System.Console

Module Module1
    Sub Main()
        ' Program 1
        WriteLine("Program 1 is running...")
        Dim n As Integer
        Write("Enter number: ")
        n = CInt(ReadLine())
        If n > 0 Then
            WriteLine("It's Positive")
        Else
            WriteLine("It's Negative")
        End If
        WriteLine()

        ' Program 2
        WriteLine("Program 2 is running...")
        Dim n1 As Integer
        Dim n2 As Integer
        Write("Enter first number: ")
        n1 = CInt(ReadLine())
        Write("Enter second number: ")
        n2 = CInt(ReadLine())
        If n1 > n2 Then
            WriteLine(n1 & " is greater")
        Else
            WriteLine(n2 & " is greater")
        End If
        WriteLine()

        ' Program 3
        WriteLine("Program 3 is running...")
        Dim marks As Integer
        Write("Enter marks of student: ")
        marks = CInt(ReadLine())
        Dim total As Integer = 50
        If marks >= total Then
            WriteLine("Pass")
        Else
            WriteLine("Fail")
        End If
        WriteLine()

        ' Program 4
        WriteLine("Program 4 is running...")
        Dim BS, tax, THS As Integer
        Write("Enter Salary: ")
        BS = CInt(ReadLine())
        If BS > 30000 Then
            tax = CInt(0.07 * BS)
        End If
        THS = BS - tax
        WriteLine("Tax is " & tax)
        WriteLine("Take-home salary is " & THS)
        WriteLine()

        ' Program 5
        WriteLine("Program 5 is running...")
        Dim num1, num2 As Integer
        Write("Enter number 1: ")
        num1 = CInt(ReadLine())
        Write("Enter number 2: ")
        num2 = CInt(ReadLine())
        If num1 > num2 Then
            WriteLine("Ascending order numbers: " & num1 & ", " & num2)
        Else
            WriteLine("Ascending order numbers: " & num2 & ", " & num1)
        End If
        WriteLine()

        ' Program 6
        WriteLine("Program 6 is running...")
        Dim n3 As Integer
        Write("Enter a number: ")
        n3 = CInt(ReadLine())
        If n3 Mod 2 = 0 Then
            WriteLine("Even")
        Else
            WriteLine("Odd")
        End If
    End Sub
End Module
