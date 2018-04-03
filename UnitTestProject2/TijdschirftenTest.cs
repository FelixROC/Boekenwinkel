using System;
using ClassLibraryBoekenWinkel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Afmetingen toevoegen
            Afmeting af = new Afmeting(2, 2, 2);
            //Tijdschrift definieren
            Tijdschrift T1 = new Tijdschrift("Donald Duck", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "00000005", 30, DayOfWeek.Monday, DayOfWeek.Friday);
            //Tijdschrift toevoegen aan de lijst
            BoekenWinkel.NieuwTijdschrift(T1);

            //Nu het verwijderen van een Tijdschrift
            
            BoekenWinkel.VerwijderTijdschrift(T1);

        }
    }
}
