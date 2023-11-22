' A 7%Tax is applicable on salary if its exceed to 30000
' Input: Basic Salary
' Output: Take Home Salary

Imports System.Console
Module Module1

    Sub Main()
        Dim BS, tax, THS As Integer
        Write("Enter Salary: ")
        BS = ReadLine()
        If BS > 3000 Then
            tax = 0.07 * BS
        End If
        THS = BS - tax
        WriteLine("Tax is " & tax)
        WriteLine("Tax homesalary is " & THS)
    End Sub
End Module