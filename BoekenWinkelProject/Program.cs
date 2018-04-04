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


            Console.WriteLine("Wat wilt u Doen?");
            Console.WriteLine(" Optie 1: Toon Alle boeken");
            Console.WriteLine(" Optie 2: Toon Alle tijdschriften");
            Console.WriteLine(" Optie 3: Boek toevoegen");
            Console.WriteLine(" Optie 4: Tijdschrift toevoegen");
            string option = Console.ReadLine();

            if (option == "1")
            {
                BoekenWinkel.ToonAlleBoeken();
            }
            if (option == "2")
            {
                BoekenWinkel.ToonAlleTijdschriften();
            }
            if (option == "3")
            {
                Console.Clear();
                Console.WriteLine("Wat is het titel van het boek");
                string Titel = Console.ReadLine();
                Console.WriteLine("Wie is de Auteur?");
                string Auteur = Console.ReadLine();
                Console.WriteLine("Wat is de taal van het boek? Kies uit Nederlands, Engels of Duits");
                string Taal = Console.ReadLine();
                Console.WriteLine("Wat is het gewicht in gram?");
                string Gewicht = Console.ReadLine();
                Console.WriteLine("Wat is de prijs in Decimaal? (Met een ,)");
                string Prijs = Console.ReadLine();
                Console.WriteLine("Wat is de drukkerij");
                string Drukkerij = Console.ReadLine();
                Console.WriteLine("Wat is de ISBN (DIt moet een 13 getallig cijfer worden en moet beginnen met 978) Bijvoorbeeld: 9789461013330");
                string ISBN = Console.ReadLine();
                Console.WriteLine("Wat is het minimum aantal van de boeken die er nodig zijn?");
                string minimumAantal = Console.ReadLine();
                Console.WriteLine("Wat is het maximumaantal van de boeken?");
                string MaximumAantal = Console.ReadLine();

                int i = 6;
                int gewicht = Int32.TryParse(Gewicht);

                Boek B6 = new Boek(Titel, Auteur, Taal, af, Gewicht, Prijs, Drukkerij, ISBN, MaximumAantal, minimumAantal);

            }
            if (option == "4")
            {
                Console.Clear();
                Console.WriteLine("Wat is de titel van het tijdschrift");
                string Titel = Console.ReadLine();
                Console.WriteLine("Wie is de Auteur van het tijdschrift?");
                string Auteur = Console.ReadLine();
                Console.WriteLine("Wat is de taal van het tijdschrift?");
                string taal = Console.ReadLine();
                Console.WriteLine("Wat is de afmeting van het tijdschrift?");
                string afmeting = Console.ReadLine();
                Console.WriteLine("Wat is het gewicht van het tijdschrift?");
                string gewicht = Console.ReadLine();
                Console.WriteLine("Wat is de prijs van het tijdschrift?");
                string prijs = Console.ReadLine();
                Console.WriteLine("Wat is de ISSN code van het tijdschrift?");
                string ISSN = Console.ReadLine();
                Console.WriteLine("Hoeveel tijdschriften wil u bestellen");
                string bestellen = Console.ReadLine();
                Console.WriteLine("op welke dag wilt u de tijdschriften bestellen");
                string besteldag = Console.ReadLine();
                Console.WriteLine("op welke dag wilt u de tijdschriften publiceren");
                string publicatiedag = Console.ReadLine();
            }

            Console.ReadKey();

        }
    }
}
