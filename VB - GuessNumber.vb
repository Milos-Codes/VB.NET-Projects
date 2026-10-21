Imports System

Module Program
    Sub Main(args As String())
        Dim rnd As New Random()
        Dim zamisljeniBroj As Integer = rnd.Next(1, 101)
        Dim unetiBroj As Integer = 0
        Dim brojPokusaja As Integer = 0

        Console.WriteLine("Igra: Pogodi broj od 1 do 100")
        Console.WriteLine()

        Do
            Console.Write("Unesite vas pokusaj: ")
            unetiBroj = Val(Console.ReadLine())
            brojPokusaja += 1

            If unetiBroj < zamisljeniBroj Then
                Console.WriteLine("Zamisljeni broj je VECI!")
            ElseIf unetiBroj > zamisljeniBroj Then
                Console.WriteLine("Zamisljeni broj je MANJI!")
            Else
                Console.WriteLine($"Cestitam! Pogodili ste iz {brojPokusaja}. pokusaja.")
            End If

            Console.WriteLine()
        Loop While unetiBroj <> zamisljeniBroj
    End Sub
End Module
