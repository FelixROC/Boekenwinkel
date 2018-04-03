using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBoekenWinkel;

namespace ClassLibraryBoekenWinkel
{

    public enum Enum_Taal
    {
        Nederlands,
        Engels,
        Deutsch
    }

    public abstract class Publicatie
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
        public static List<Boek> Boekenlijst;
        Public static List<Tijdschrijft> Tijdschriftenlijst;
        #endregion

        #region Getter and Setter for definitions
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public Enum_Taal Taal { get; set; }
        public Afmeting Afmetingen { get; set; }
        public int Gewicht { get; set; }
        public Decimal Prijs { get; set; }
        #endregion


        #region Methods

        public Publicatie(string _Titel, string _Auteur, Enum_Taal _Taal, Afmeting _Afmeting, int _gewicht, decimal _prijs)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}