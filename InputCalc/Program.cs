using System;
using System.Xml.Linq;

class InputCalc
{
    // Enkel metod som skriver ut ett meddelande
    static void Minimum(double[] yourNumbers)
    {
        Console.WriteLine("Minimum är " + yourNumbers.Min());
    }

    static void Average(double[] yourNumbers)
    {
        Console.WriteLine("Medel är " + yourNumbers.Average());
    }

    static void Maximum(double[] yourNumbers)
    {
        Console.WriteLine("Max är " + yourNumbers.Max());
    }

    static void Main()
    {
        // int test = Convert.ToInt32(Console.ReadLine());

        double[] yourNumbers = { 10, 20, 30, 40, 50, 100, 1 };

        for (int i = 0; i < yourNumbers.Length; i++)
        {
            Console.Write("Skriv en siffra: ");
            Console.ReadLine();
        }

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

/* Inte samma facit men det ser ungefär likadant ut som när jag fråga ChatGPT.
using System;

class Program
{
    // Metod för att beräkna medelvärdet av en lista med tal
    static double BeraknaMedelvarde(int[] tal)
    {
        int summa = 0;
        foreach (int t in tal)
        {
            summa += t;
        }
        return (double)summa / tal.Length;
    }

    static void Main(string[] args)
    {
        int[] tal = new int[5]; // Array för att lagra de fem talen
        int maxTal = int.MinValue; // Startvärde för det största talet
        int minTal = int.MaxValue; // Startvärde för det minsta talet

        // Loopa för att ta emot 5 tal från användaren
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ange ett heltal: ");
            tal[i] = int.Parse(Console.ReadLine());

            // Jämför och uppdatera max och min tal
            if (tal[i] > maxTal)
            {
                maxTal = tal[i];
            }
            if (tal[i] < minTal)
            {
                minTal = tal[i];
            }
        }

        // Beräkna medelvärdet genom att anropa metoden
        double medelvarde = BeraknaMedelvarde(tal);

        // Skriv ut resultaten
        Console.WriteLine($"Medelvärdet är: {medelvarde}");
        Console.WriteLine($"Största talet är: {maxTal}");
        Console.WriteLine($"Minsta talet är: {minTal}");
    }
}
*/