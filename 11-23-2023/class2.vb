' A 5%Tax is applicable on salary if it's exceed to 30000, 7% if it's more than 65000 and 10%
'  for a salary
' above 100000.
' Input: Basic Salary
' Output: Tax amount and Take Home Salary

Imports System.Console

Module Module1
    Sub Main()
        Dim BS, tax, THS As Integer
        Write("Enter Salary: ")
        BS = ReadLine()

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
    End Sub
End Module
