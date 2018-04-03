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
        public Tijdschrift(string _Titel, string _Auteur, Enum_Taal _Taal, Afmeting _Afmeting, int _gewicht, decimal _prijs , string _ISSN , int AantalTijdschriftenBestellen, DayOfWeek Besteldag , DayOfWeek Publicatiedag) : base(_Titel, _Auteur, _Taal, _Afmeting, _gewicht, _prijs)
        {

            this.titel = _Titel;
            this.auteur = _Auteur;
            this.taal = _Taal;
            this.Afmetingen = _Afmeting;
            this.gewicht = _prijs;
            this.prijs = _prijs;
            this.afmetingen = _Afmeting;

        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return titel + " " + auteur + " " + taal + " " + afmetingen + " " + gewicht + " " + prijs + " " + iSSN + " " + bestelAantal + " " + bestelDag + " " + Publicatiedag;
        }

        public string Afdrukken()
        {
            var stringbuilder = new StringBuilder()
                .Append("Titel: ")
                .Append(Titel)
                .Append("\n")
                .Append("Auteur: ")
                .Append(Auteur)
                .Append("\n")
                .Append("Taal: ")
                .Append(Taal)
                .Append("\n")
                .Append("De Afmeting: ")
                .Append(Afmetingen.Breedte)
                .Append("L " + Afmetingen.Lengte)
                .Append("H " + Afmetingen.Hoogte)
                .Append("\n")
                .Append("ISSN: ")
                .Append(iSSN)
                .Append("\n")
                .Append("Bestel Aantal: ")
                .Append("\n")
                .Append(bestelAantal)
                .Append("\n")
                .Append("Bestel Dag: ")
                .Append(bestelDag)
                .Append("Publicatie Dag")
                .Append(Publicatiedag);

            return stringbuilder.ToString();
        }
        #endregion
    }
}