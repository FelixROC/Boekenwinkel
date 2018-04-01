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

        #region Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="Tijdschrift"/> class.
        /// </summary>
        /// <param name="Titel">The titel.</param>
        /// <param name="ISSN">The issn.</param>
        /// <param name="AantalTijdschriftenBestellen">The aantal tijdschriften bestellen.</param>
        /// <param name="Besteldag">The besteldag.</param>
        /// <param name="Publicatiedag">The publicatiedag.</param>
        public Tijdschrift(string Titel,int ISSN, int AantalTijdschriftenBestellen, DayOfWeek Besteldag, DayOfWeek Publicatiedag)
        {

        }
        /// <summary>
        /// Publicaties the specified titel.
        /// </summary>
        /// <param name="_titel">The titel.</param>
        /// <param name="_auteur">The auteur.</param>
        /// <param name="_taal">The taal.</param>
        /// <param name="_afmetingen">The afmetingen.</param>
        /// <param name="_gewicht">The gewicht.</param>
        /// <param name="_prijs">The prijs.</param>
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