Module Module1

    Sub Main()
        Dim Input_string As String = ""
        Dim Output_string As String = ""
        Dim First_char As Char = ""
        Dim i As Integer = 0

        Console.Write("Enter String : ")
        Input_string = Console.ReadLine

        First_char = Left(Input_string, 1)
        Output_string = First_char

        For i = 1 To Len(Input_string) - 1
            If Mid(Input_string, i + 1, 1) = First_char Then
                Output_string = Output_string & "*"
            Else
                Output_string = Output_string & Mid(Input_string, i + 1, 1)
            End If
        Next

        Console.Write("Output is : " & Output_string)
        Console.ReadKey()

    End Sub

End Module
