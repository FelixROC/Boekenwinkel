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
        private DayOfWeek dagVanUitifte;
        private Enum_Taal taal;
        private Afmeting afmetingen;
        private decimal gewicht;
        private int iSSN;
        private decimal prijs;
        private int bestelAantal;
        private DayOfWeek bestelDag;

        public Tijdschrift(string titel , DayOfWeek dagVanUitifte, int iSSN, int bestelAantal, DayOfWeek bestelDag)
        {
            this.dagVanUitifte = dagVanUitifte;
            this.iSSN = iSSN;
            this.bestelAantal = bestelAantal;
            this.bestelDag = bestelDag;
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