using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class Tijdschriften : Publicatie
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
        public Tijdschriften(string ISSN, int AantalTijdschriftenBestellen, DayOfWeek Besteldag, DayOfWeek Publicatiedag)
        {

        }     

        public override string ToString()
        {
            
        }
}
}
