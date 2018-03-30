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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
