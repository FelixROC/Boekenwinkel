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

            Afmeting af = new Afmeting(2, 2, 2);

            Boek B1 = new Boek("Hercules", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "Drukkerij", "9789461013330", 20, 5);
            Boek B2 = new Boek("SneeuwWitje", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "9789464016730", 20, 5);
            Boek B3 = new Boek("Hunger games", "Het oosten", Enum_Taal.Engels, af, 12, 25.50m, "de druk", "9789464010032", 20, 5);
            Boek B4 = new Boek("IT", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "9787841213330", 20, 5);
            Boek B5 = new Boek("IT", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "9789673215530", 20, 5);

            Tijdschrift T1 = new Tijdschrift("Donald Duck", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "5123_7813", 30, DayOfWeek.Monday, DayOfWeek.Friday);
            Tijdschrift T2 = new Tijdschrift("Top Gear", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "5124_7843", 30, DayOfWeek.Monday, DayOfWeek.Friday);
            Tijdschrift T3 = new Tijdschrift("Quest", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "5125_7893", 30, DayOfWeek.Monday, DayOfWeek.Friday);
            Tijdschrift T4 = new Tijdschrift("Discover", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "5126_7921", 30, DayOfWeek.Monday, DayOfWeek.Friday);

            BoekenWinkel.NieuwBoek(B1);
            BoekenWinkel.NieuwBoek(B2);
            BoekenWinkel.NieuwBoek(B3);
            BoekenWinkel.NieuwBoek(B4);
            BoekenWinkel.NieuwBoek(B5);

            BoekenWinkel.NieuwTijdschrift(T1);
            BoekenWinkel.NieuwTijdschrift(T2);
            BoekenWinkel.NieuwTijdschrift(T3);
            BoekenWinkel.NieuwTijdschrift(T4);

            Console.WriteLine("Een Lijst van boeken de nu in het systeem zitten");
            Console.WriteLine("");
            foreach(Boek b in Publicatie.Boekenlijst)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Het 5de boek is dubbel dus deze verwijderen we door de methode te gebruiken verwijderBoek");
            Console.WriteLine("");
            BoekenWinkel.VerwijderBoek(B5);
            Console.WriteLine("Nu is het 5de boek weg");
            Console.WriteLine("");

            BoekenWinkel.ToonAlleBoeken();

            Console.WriteLine("");
            Console.WriteLine("Een Lijst van tijdschriften de nu in het systeem zitten");
            Console.WriteLine("");
            foreach (Tijdschrift t in Publicatie.Tijdschriftenlijst)
            {
                Console.WriteLine(t);
            }
            
            Console.ReadKey();



        }
    }
}
