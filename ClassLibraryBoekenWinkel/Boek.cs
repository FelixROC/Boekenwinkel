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
        Boek b1 = new Boek("Hercules", "Het oosten", Enum_Taal.Nederlands,"afmetin",12,25.50m,"de druk","de isbn",20,5);
        Boek b2 = new Boek("Sneeuw Witje", "Het oosten", 2, 3, 10);
        Boek b3 = new Boek("Hunger games", "Het oosten", 3, 3, 10);
        Boek b4 = new Boek("IT", "Het oosten", 4, 3, 10);
        #endregion

        #region Methods

        public Boek(string _Titel, string _Auteur, Enum_Taal _Taal, Afmeting _Afmeting, int _gewicht, decimal _prijs , string _druk ,string _ISBN ,int _maximunAantal,int miniumAantal) :base (_Titel, _Auteur, _Taal, _Afmeting, _gewicht, _prijs)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}