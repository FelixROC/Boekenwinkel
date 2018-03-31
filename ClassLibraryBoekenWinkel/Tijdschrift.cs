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
        private Enum_Taal taal;
        private Afmeting afmetingen;
        private decimal gewicht;
        private int iSSN;
        private decimal prijs;
        private int bestelAantal;
        private DateTime bestelDag;
        #endregion

        Tijdschrift t1 = new Tijdschrift("Donald Duck",1, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Tijdschrift t2 = new Tijdschrift("Top Gear",2, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Tijdschrift t3 = new Tijdschrift("Quest",3, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Tijdschrift t4 = new Tijdschrift("Discover",4, 10, DayOfWeek.Monday, DayOfWeek.Friday);

        #region Methods
        public Tijdschrift(string Titel,int ISSN, int AantalTijdschriftenBestellen, DayOfWeek Besteldag, DayOfWeek Publicatiedag)
        {

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