using System;
using System.Xml.Linq;

class InputCalc
{
    // Enkel metod som skriver ut ett meddelande
    static void Minimum(double[] yourNumbers)
    {
        Console.WriteLine("Minimum är: " + yourNumbers.Min());
    }

    static void Average(double[] yourNumbers)
    {
        Console.WriteLine("Medel är: " + yourNumbers.Average());
    }

    static void Maximum(double[] yourNumbers)
    {
        Console.WriteLine("Max är: " + yourNumbers.Max());
    }

    static void Main()
    {
        int test = Convert.ToInt32(Console.ReadLine());

        double[] yourNumbers = { 10, 20, 30, 40, 50, 100, 1 };

        for (int i = 0; i < yourNumbers.Length; i++)
        {
            Console.Write("Skriv en siffra: ");
            Console.ReadLine();
        }

        Console.WriteLine("");

        // Räknar ut minsta värdet
        Minimum(yourNumbers);
        // Räknar ut medel värdet
        Average(yourNumbers);
        // Räknar ut max värdet
        Maximum(yourNumbers);

        if (yourNumbers.Length > 0)
        {
            Console.WriteLine("Största");
        } else
        {
            Console.WriteLine("Minsta");
        }

        Console.ReadKey();
    }
}

/*
Här är en övning i C# för att träna på att använda grundläggande funktioner, if-satser, loopar och metoder. Den här övningen går ut på att skapa ett litet program som hanterar användarens inmatning och gör några beräkningar.
Uppgift: Kalkylator för att räkna ut medelvärde och jämföra tal

    Beskrivning av programmet:
        Användaren ska kunna skriva in fem tal (hela tal).
        Programmet ska beräkna medelvärdet av de inmatade texterna.
        Programmet ska också kunna jämföra de inmatade texterna för att hitta det största och minsta talet.
        Skriv ut medelvärdet, största talet och minsta talet.

    Steg-för-steg instruktioner:
        Skapa en metod som beräknar medelvärdet av de fem texterna.
        Använd en for-loop för att ta emot inmatning från användaren fem gånger.
        Använd if-satser för att hitta det största och minsta talet.
        Visa resultaten på skärmen.
 */