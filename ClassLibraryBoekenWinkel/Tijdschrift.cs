﻿using System;
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
        private string iSSN;
        private decimal prijs;
        private int bestelAantal;
        private DayOfWeek bestelDag;
        #endregion

        #region Getter and Setter for definitions
        public string ISSN { get; set; }
        public int AantalTijdschriftenBestellen { get; set; }
        public DayOfWeek Besteldag { get; set; }
        public DayOfWeek Publicatiedag { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="Tijdschrift"/> class.
        /// </summary>
        /// <param name="_Titel">The titel.</param>
        /// <param name="_Auteur">The auteur.</param>
        /// <param name="_Taal">The taal.</param>
        /// <param name="_Afmeting">The afmeting.</param>
        /// <param name="_gewicht">The gewicht.</param>
        /// <param name="_prijs">The prijs.</param>
        /// <param name="_ISSN">The issn.</param>
        /// <param name="AantalTijdschriftenBestellen">The aantal tijdschriften bestellen.</param>
        /// <param name="Besteldag">The besteldag.</param>
        /// <param name="Publicatiedag">The publicatiedag.</param>
        public Tijdschrift(string _Titel, string _Auteur, Enum_Taal _Taal, Afmeting _Afmeting, int _gewicht, decimal _prijs , string _ISSN , int _AantalTijdschriftenBestellen, DayOfWeek Besteldag , DayOfWeek Publicatiedag) : base(_Titel, _Auteur, _Taal, _Afmeting, _gewicht, _prijs)
        {

            this.titel = _Titel;
            this.auteur = _Auteur;
            this.taal = _Taal;
            this.Afmetingen = _Afmeting;
            this.gewicht = _gewicht;
            this.prijs = _prijs;
            this.iSSN = _ISSN;
            this.afmetingen = _Afmeting;
            this.bestelAantal = _AantalTijdschriftenBestellen;

        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Titel: " + titel + " Auteur: " + auteur + " Taal: " + taal + " Afmetingen: " + afmetingen + " Gewicht: " + gewicht + " De prijs: " + prijs + " ISSN: " + iSSN + " BestelAantal: " + bestelAantal + " Besteldag: " + bestelDag + " Publicatiedag: " + Publicatiedag;
        }
        #endregion
    }
}