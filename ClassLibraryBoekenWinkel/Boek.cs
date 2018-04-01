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

        public Boek(string druk, int iSBN, int miniumaantal, int maxiumaantal)
        {
            this.druk = druk;
            this.iSBN = iSBN;
            Miniumaantal = miniumaantal;
            Maxiumaantal = maxiumaantal;
        }

        public Boek(string _titel, string _auteur, string _taal, Enum _Taal, Afmeting _afmeting, int _gewicht, decimal _prijs) : base(_titel, _auteur, _taal, _Taal, _afmeting, _gewicht, _prijs)
        {
        }
        
        #endregion

        #region Methods

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}