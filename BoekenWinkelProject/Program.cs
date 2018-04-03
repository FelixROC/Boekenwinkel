using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBoekenWinkel;

namespace BoekenWinkelProject
{
    class Program

    {
        static void Main(string[] args)
        {

            Boek B1 = new Boek("Hercules", "Het oosten", Enum_Taal.Nederlands , af, 12, 25.50m, "de druk", "00000001", 20, 5);
            Boek B2 = new Boek("SneeuwWitje", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "00000002", 20, 5);
            Boek B3 = new Boek("Hunger games", "Het oosten", Enum_Taal.Engels, af, 12, 25.50m, "de druk", "00000003", 20, 5);
            Boek B4 = new Boek("IT", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "00000004", 20, 5);

            Tijdschrift T1 = new Tijdschrift("Donald Duck", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "5", 30, DayOfWeek.Monday, DayOfWeek.Friday);
            Tijdschrift T2 = new Tijdschrift("Top Gear", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "6", 30, DayOfWeek.Monday, DayOfWeek.Friday);
            Tijdschrift T3 = new Tijdschrift("Quest", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "7", 30, DayOfWeek.Monday, DayOfWeek.Friday);
            Tijdschrift T4 = new Tijdschrift("Discover", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "8", 30, DayOfWeek.Monday, DayOfWeek.Friday);

            BoekenWinkel.NieuwBoek(B1);
            BoekenWinkel.NieuwBoek(B2);
            BoekenWinkel.NieuwBoek(B3);
            BoekenWinkel.NieuwBoek(B4);

            BoekenWinkel.NieuwTijdschrift(T1);
            BoekenWinkel.NieuwTijdschrift(T2);
            BoekenWinkel.NieuwTijdschrift(T3);
            BoekenWinkel.NieuwTijdschrift(T4);

            foreach(Boek b in Publicatie.Boekenlijst)
            {
                Console.WriteLine(b);
            }

            foreach (Tijdschrift t in Publicatie.Tijdschriftenlijst)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("Hier een print van de boeken");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
