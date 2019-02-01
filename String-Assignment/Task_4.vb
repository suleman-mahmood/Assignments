Module Module1

    Sub Main()
        Dim Input_string_1 As String = ""
        Dim Input_string_2 As String = ""
        Dim two_char_string_1 As String = ""
        Dim two_char_string_2 As String = ""
        Dim Output_string As String = ""

        Console.Write("Enter String 1 : ")
        Input_string_1 = Console.ReadLine
        Console.Write("Enter String 2 : ")
        Input_string_2 = Console.ReadLine

        two_char_string_1 = Left(Input_string_1, 2)
        two_char_string_2 = Left(Input_string_2, 2)

        Output_string = two_char_string_2 & Mid(Input_string_1, 3, Len(Input_string_1)) & " " & two_char_string_1 & Mid(Input_string_2, 3, Len(Input_string_2))

        Console.Write("Output is : " & Output_string)
        Console.ReadKey()

    End Sub

End Module
