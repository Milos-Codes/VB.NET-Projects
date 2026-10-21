Imports System

Module Program
    Sub Main(args As String())
        Dim tacnoKorisnickoIme As String = "admin"
        Dim tacnaLozinka As String = "1234"

        Console.WriteLine("Sistem za prijavu")
        Console.Write("Unesite korisničko ime: ")
        Dim korisnickoIme As String = Console.ReadLine()

        Console.Write("Unesite lozinku: ")
        Dim lozinka As String = Console.ReadLine()

        ' Boolean promenljiva koja prati stanje prijave
        Dim uspesnaPrijava As Boolean = False

        ' Provera podataka
        If korisnickoIme = tacnoKorisnickoIme AndAlso lozinka = tacnaLozinka Then
            uspesnaPrijava = True
        End If

        Console.WriteLine()

        ' Reagovanje na osnovu Boolean vrednosti
        If uspesnaPrijava Then
            Console.WriteLine("Uspešno ste prijavljeni! Dobrodošli na sistem.")
        Else
            Console.WriteLine("Greška: Pogrešno korisničko ime ili lozinka!")
        End If
    End Sub
End Module
