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
        private int miniumaantal;
        private int voorraad;
        private int maxiumaantal;
        #endregion
        #region Getter and Setter for definitions
        public string Druk { get; set; }
        public string ISBN { get; set; }
        public int MiniumVoorraad { get; set; }
        public int MaxiumVoorraad { get; set; }
        public int Voorraad { get; set; }
        public int BestelRegel { get;}
        #endregion
        #region Boeken
        Boek b1 = new Boek("Hercules", "Het oosten", Enum_Taal.Nederlands,"afmetin",12,25.50m,"de druk","de isbn",20,5);
        Boek b2 = new Boek("Sneeuw Witje", "Het oosten", 2, 3, 10);
        Boek b3 = new Boek("Hunger games", "Het oosten", 3, 3, 10);
        Boek b4 = new Boek("IT", "Het oosten", 4, 3, 10);
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
        public Boek(string _Titel, string _Auteur, Enum_Taal _Taal, Afmeting _Afmeting, int _gewicht, decimal _prijs , string _druk ,string _ISBN ,int _maximunAantal,int miniumAantal) :base (_Titel, _Auteur, _Taal, _Afmeting, _gewicht, _prijs)
        {

        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}