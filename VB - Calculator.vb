Imports System

Module Program
    Sub Main(args As String())

        Dim prviBroj As Double
        Dim drugiBroj As Double

        Console.WriteLine("VISER Console Calculator")
        Console.Write("Unesite prvi broj: ")
        prviBroj = Val(Console.ReadLine())

        Console.Write("Unesite drugi broj: ")
        drugiBroj = Val(Console.ReadLine())

        Console.WriteLine()
        Console.WriteLine($"Zbir: {prviBroj + drugiBroj}")
        Console.WriteLine($"Razlika: {prviBroj - drugiBroj}")
        Console.WriteLine($"Proizvod: {prviBroj * drugiBroj}")

        ' Provera deljenja sa nulom
        If drugiBroj <> 0 Then
            Console.WriteLine($"Količnik: {prviBroj / drugiBroj}")
        Else
            Console.WriteLine("Količnik: Deljenje sa nulom nije dozvoljeno!")
        End If

        Console.WriteLine()
        Console.WriteLine("Pritisnite bilo koji taster za izlaz...")




    End Sub
End Module
