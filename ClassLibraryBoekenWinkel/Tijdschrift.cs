using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class Tijdschrift : Publicatie
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
        public Tijdschrift(string ISSN, int AantalTijdschriftenBestellen, DayOfWeek Besteldag, DayOfWeek Publicatiedag)
        {

        }
        public override void publicatie(string _titel, string _auteur, Enum_Taal _taal, Afmeting _afmetingen, int _gewicht, decimal _prijs)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
