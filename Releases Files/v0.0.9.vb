Imports System.Console

Module Module1
    Sub Main()
        ' Program 1
        WriteLine("Program 1 is running...")
        Dim n As Integer
        Write("Please enter a number: ")
        n = CInt(ReadLine())
        If n Mod 2 = 0 Then
            WriteLine("Even number")
        Else
            WriteLine("Odd Number")
        End If
        WriteLine()

        ' Program 2
        WriteLine("Program 2 is running...")
        Dim n2 As Integer
        n2 = 1
        Do
            WriteLine(n2)
            n2 = n2 + 1
        Loop While n2 <= 10
        WriteLine()

        ' Program 3
        WriteLine("Program 3 is running...")
        Dim n3 As Integer
        n3 = 35
        Do
            WriteLine(n3)
            n3 = n3 + 1
        Loop While n3 <= 50
        WriteLine()

        ' Program 4
        WriteLine("Program 4 is running...")
        Dim n4 As Integer
        n4 = 10
        Do
            WriteLine(n4)
            n4 = n4 - 1
        Loop While n4 >= 1
        WriteLine()

        ' Program 5
        WriteLine("Program 5 is running...")
        Dim n5 As Integer
        n5 = 1
        Do
            WriteLine(n5)
            n5 = n5 * 2
        Loop While n5 <= 1024
        WriteLine()

        ' Program 6
        WriteLine("Program 6 is running...")
        Dim n6, m As Integer
        Write("Please enter a number: ")
        n6 = CInt(ReadLine())
        m = 0
        Do
            WriteLine(m)
            m = m + 1
        Loop While m <= n6
        WriteLine()

        ' Program 7
        WriteLine("Program 7 is running...")
        Dim starting, ending, variable As Integer
        Write("Enter starting number: ")
        starting = CInt(ReadLine())
        Write("Enter ending number: ")
        ending = CInt(ReadLine())
        If ending < starting Then
            WriteLine("Ending number cannot be less than starting number")
        Else
            variable = starting
            Do
                WriteLine(variable)
                variable += 1
            Loop While variable <= ending
        End If
        WriteLine()

        ' Program 8
        WriteLine("Program 8 is running...")
        Dim number, multiple, counter As Integer
        WriteLine("Enter a number: ")
        number = CInt(ReadLine())
        counter = 1
        Do
            multiple = number * counter
            WriteLine(number & " x " & counter & " = " & multiple)
            counter += 1
        Loop While counter <= 10
    End Sub
End Module
