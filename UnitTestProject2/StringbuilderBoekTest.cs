using System;
using ClassLibraryBoekenWinkel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class StringbuilderBoekTest
    {
        [TestMethod]
        public void TestToevoegenUitlezenBoek()
        {
            //Afmeting Toevoegen
            Afmeting af = new Afmeting(2, 2, 2);

            //Tijdschrift toevoegen
            Boek B1 = new Boek("Hercules", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "Drukkerij", "00000001", 20, 5);
            BoekenWinkel.NieuwBoek(B1);
            //ToString() is veranderd naar een eigen ToString() Methode.
            //Deze staat in de ToString() method in Tijdschrift en Boeken
            //We doen object Boek naar een toString en deze tostring van base Object is naar Object boek gegaan
            foreach (Boek b in Publicatie.Boekenlijst)
            {
                Console.WriteLine(b);
            }
            //Hij laat correct alle waarden zien
            //Geslaagd

        }
    }
}
