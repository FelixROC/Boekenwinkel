using System;
using ClassLibraryBoekenWinkel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class StringbuilderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ///Afmeting Toevoegen
            Afmeting af = new Afmeting(2, 2, 2);
            //Tijdschrift toevoegen
            Tijdschrift T1 = new Tijdschrift("Donald Duck", "auteur", Enum_Taal.Nederlands, af, 5, 10.50m, "00000005", 30, DayOfWeek.Monday, DayOfWeek.Friday);
            BoekenWinkel.NieuwTijdschrift(T1);
            //ToString() is veranderd naar een eigen ToString() Methode.
            //Deze staat in de ToString() method in Tijdschrift en Boeken
            //We doen object Boek naar een toString en deze tostring van base Object is naar Object boek gegaan
            foreach (Tijdschrift t in Publicatie.Tijdschriftenlijst)
            {
                Console.WriteLine(t);
            }
        } 
    }
}
