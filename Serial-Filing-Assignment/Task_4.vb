Module Module1

    Sub Main()
        Dim Member_Name As String = ""
        Dim Member_ID As Integer = 0
        Dim MoreRecord As Char = "Y"

        FileOpen(1, "E:\StudentRecord\MembershipData.txt", OpenMode.Append)

        While MoreRecord = "Y" Or MoreRecord = "y"
            Console.Write("Enter Member Name : ")
            Member_Name = Console.ReadLine

            Console.Write("Enter Member ID : ")
            Member_ID = Console.ReadLine

            WriteLine(1, Member_Name)
            WriteLine(1, Member_ID)

            Console.Write("Do you want to enter more records? (Y/N) : ")
            MoreRecord = Console.ReadLine
        End While

        FileClose(1)

    End Sub

End Module
