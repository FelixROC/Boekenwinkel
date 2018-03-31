using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class Boek : Publicatie
    {
        #region Definitions
        private string titel;
        private string auteur;
        private Enum_Taal taal;
        private Afmeting afmetingen;
        private decimal gewicht;
        private string druk;
        private int iSBN;
        private int Miniumaantal;
        private int Voorraad;
        private int Maxiumaantal;
        #endregion

        #region Boeken
        Boek b1 = new Boek("Hercules", "Het oosten", 1, 3, 10);
        Boek b2 = new Boek("Sneeuw Witje", "Het oosten", 2, 3, 10);
        Boek b3 = new Boek("Hunger games", "Het oosten", 3, 3, 10);
        Boek b4 = new Boek("IT", "Het oosten", 4, 3, 10); 
        #endregion

        #region Methods
        public Boek(string titel, string druk, int iSBN, int miniumaantal, int maxiumaantal)
        {
            this.titel = titel;
            this.druk = druk;
            this.iSBN = iSBN;
            Miniumaantal = miniumaantal;
            Maxiumaantal = maxiumaantal;
        }

        public override void publicatie(string _titel, string _auteur, Enum_Taal _taal, Afmeting _afmetingen, int _gewicht, decimal _prijs)
        {
            this.titel = _titel;
            this.auteur = _auteur;
            this.taal = _taal;
            this.afmetingen = _afmetingen;
            this.gewicht = _gewicht;
            this.Prijs = _prijs;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}