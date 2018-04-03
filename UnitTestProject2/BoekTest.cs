using System;
using ClassLibraryBoekenWinkel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class BoekTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Maken van een boek
            Boek B1 = new Boek("Hercules", "Het oosten", Enum_Taal.Nederlands, af, 12, 25.50m, "de druk", "00000001", 20, 5);
            //Test van het afdrukken van de huidige boeken
            BoekenWinkel.NieuwBoek(B1);
        }
    }
}
