using System.Text;

namespace ClassLibraryBoekenWinkel
{
    public class Boek : Publicatie
    {
        #region Definitions
        private string titel;
        private string auteur;
        private Enum_Taal taal;
        private Afmeting afmeting;
        private decimal gewicht;
        private decimal prijs; 
        private string druk;
        private string iSBN;
        private int miniumaantal;
        private int voorraad;
        private int maximumaantal;
        #endregion

        #region Getter and Setter for definitions
        public string Druk { get; set; }
        public string ISBN { get; set; }
        public int MiniumVoorraad { get; set; }
        public int MaxiumVoorraad { get; set; }
        public int Voorraad { get; set; }
        public int BestelRegel { get;}
        #endregion

        #region Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="Boek"/> class.
        /// </summary>
        /// <param name="_Titel">The titel.</param>
        /// <param name="_Auteur">The auteur.</param>
        /// <param name="_Taal">The taal.</param>
        /// <param name="_Afmeting">The afmeting.</param>
        /// <param name="_gewicht">The gewicht.</param>
        /// <param name="_prijs">The prijs.</param>
        /// <param name="_druk">The druk.</param>
        /// <param name="_ISBN">The isbn.</param>
        /// <param name="_maximunAantal">The maximun aantal.</param>
        /// <param name="miniumAantal">The minium aantal.</param>
        public Boek(string _Titel, string _Auteur, Enum_Taal _Taal, Afmeting _Afmeting, int _gewicht, decimal _prijs , string _druk ,string _ISBN ,int _maximunAantal,int _miniumAantal) :base (_Titel, _Auteur, _Taal, _Afmeting, _gewicht,_prijs)
        {
            this.titel = _Titel;
            this.auteur = _Auteur;
            this.taal = _Taal;
            this.afmeting = _Afmeting;
            this.gewicht = _gewicht;
            this.druk = _druk;
            this.prijs = _prijs;
            this.iSBN = _ISBN;
            this.miniumaantal = _miniumAantal;
            this.maximumaantal = _maximunAantal;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>

        public override string ToString()
        {
            return "Titel: "+ titel+ " De Auter: " + auteur + " Taal: " + taal + " Afmetingen: " + afmeting + " Het Gewicht: " + gewicht + " De Prijs: " + prijs + " De Druk: " + druk + " De ISBN: " + iSBN + " minimumaantal: " + maximumaantal + " maximumaantal: " + miniumaantal;
        }

        public string Afdrukken()
        {
            return ToString();
        }
        #endregion
    }
}