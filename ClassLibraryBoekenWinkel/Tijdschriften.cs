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
        private Enum_Taal taal;
        private Afmeting afmetingen;
        private decimal gewicht;
        private int iSSN;
        private decimal prijs;
        private int bestelAantal;
        private DateTime bestelDag;
        #endregion

        public Tijdschriften(string _titel, string _auteur, Enum_Taal _taal, Afmeting _afmetingen, int _gewicht, decimal _prijs) : base(_titel, _auteur, _taal, _afmetingen, _gewicht, _prijs)
        {
            this.titel = _titel;
            this.auteur = _auteur;
            this.taal = _taal;
            this.afmetingen = _afmetingen;
            this.gewicht = _gewicht;
            this.prijs = _prijs;
        }

        public void Tijdschrift(string ISSN, int AantalTijdschriftenBestellen, DayOfWeek Besteldag, DayOfWeek Publicatiedag)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
