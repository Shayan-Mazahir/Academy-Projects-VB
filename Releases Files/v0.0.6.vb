Imports System.Console

Module Module1
    Sub Main()
        ' Program 1
        WriteLine("This program contains the compilation of the tasks from 11-21-2023")
        WriteLine(" ")
        WriteLine("Program 1 is running...")
        Dim n As Integer
        Write("Enter a number: ")
        n = CInt(ReadLine()) ' Convert input to integer
        WriteLine("Your number is " & n)
        WriteLine("Square of the number is " & n * n)
        WriteLine("Hello AS")
        WriteLine("Welcome to programming")
        WriteLine(" ")

        ' Program 2
        WriteLine("Program 2 is running...")
        Dim n1 As Integer
        Dim n2 As Integer
        Dim total As Integer
        Write("Enter first number: ")
        n1 = CInt(ReadLine())
        Write("Enter second number: ")
        n2 = CInt(ReadLine())
        total = n1 + n2
        WriteLine("Your total is " & total)
    End Sub
End Module
