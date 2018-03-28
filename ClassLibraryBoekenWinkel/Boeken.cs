using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class Boeken : Publicatie
    {
        #region Definitions
        private string titel;
        private string auteur;
        private DateTime dagVanUitifte;
        private string taal;
        private decimal afmetingenl;
        private decimal gewicht;
        private int iSSN;
        private decimal prijs;
        private int bestelAantal;
        private DateTime bestelDag; 
        #endregion

        public string Boeken(_druk:string, _ISBN:string, _maximumAantal:int, _minimumaantal:int)
        {

        }
    }
}
