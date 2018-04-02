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

        

        #region Tijdschriften
        Tijdschrift t1 = new Tijdschrift( "Donald Duck", "auteur" , Enum_Taal.Nederlands , "Afmeting",5,10.50m,"issn",30,DayOfWeek.Monday,DayOfWeek.Friday);
        Tijdschrift t2 = new Tijdschrift("Top Gear", 6, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Tijdschrift t3 = new Tijdschrift("Quest", 7, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Tijdschrift t4 = new Tijdschrift("Discover", 8, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        #endregion
        #region Methods
        public Tijdschrift(string _Titel, string _Auteur, Enum_Taal _Taal, Afmeting _Afmeting, int _gewicht, decimal _prijs , string _ISSN , int AantalTijdschriftenBestellen, DayOfWeek Besteldag , DayOfWeek Publicatiedag) : base(_Titel, _Auteur, _Taal, _Afmeting, _gewicht, _prijs)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        } 
        #endregion
    }
}