using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class Boek : Publicatie
    {
        #region Definitions
        private string titel;
        private string auteur;
        private Enum_Taal taal;
        private Afmeting afmetingen;
        private decimal gewicht;
        private string druk;
        private int iSBN;
        private int Miniumaantal;
        private int Voorraad;
        private int Maxiumaantal;
        #endregion

        #region Boeken
        Boek b1 = new Boek("Hercules", "Het oosten", 1, 3, 10);
        Boek b2 = new Boek("Sneeuw Witje", "Het oosten", 2, 3, 10);
        Boek b3 = new Boek("Hunger games", "Het oosten", 3, 3, 10);
        Boek b4 = new Boek("IT", "Het oosten", 4, 3, 10);
        #endregion

        #region Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="Boek"/> class.
        /// </summary>
        /// <param name="titel">The titel.</param>
        /// <param name="druk">The druk.</param>
        /// <param name="iSBN">The i SBN.</param>
        /// <param name="miniumaantal">The miniumaantal.</param>
        /// <param name="maxiumaantal">The maxiumaantal.</param>
        public Boek(string titel, string druk, int iSBN, int miniumaantal, int maxiumaantal)
        {
            this.titel = titel;
            this.druk = druk;
            this.iSBN = iSBN;
            Miniumaantal = miniumaantal;
            Maxiumaantal = maxiumaantal;
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