using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBoekenWinkel;

namespace ClassLibraryBoekenWinkel
{
    public abstract class Publicatie
    {

        #region Definitions
        private string titel;
        private string auteur;
        private int gewicht;
        private decimal prijs;
        private Enum_Taal taal;
        private Afmeting afmetingen;
        #endregion

        #region Publicaties
        Publicatie t1 = new Tijdschrift("Donald Duck", 5, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Publicatie t2 = new Tijdschrift("Top Gear", 6, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Publicatie t3 = new Tijdschrift("Quest", 7, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Publicatie t4 = new Tijdschrift("Discover", 8, 10, DayOfWeek.Monday, DayOfWeek.Friday);
        Publicatie b1 = new Boek("Hercules", "Het oosten", 1, 3, 10);
        Publicatie b2 = new Boek("Sneeuw Witje", "Het oosten", 2, 3, 10);
        Publicatie b3 = new Boek("Hunger games", "Het oosten", 3, 3, 10);
        Publicatie b4 = new Boek("IT", "Het oosten", 4, 3, 10);
        #endregion

        #region Getter and Setter for definitions
        public string Titel
        {
            get
            {
                return titel;
            }

            set
            {
                titel = value;
            }
        }

        public string Auteur
        {
            get
            {
                return auteur;
            }

            set
            {
                auteur = value;
            }
        }

        public int Gewicht
        {
            get
            {
                return gewicht;
            }

            set
            {
                gewicht = value;
            }
        }

        public decimal Prijs
        {
            get
            {
                return prijs;
            }

            set
            {
                prijs = value;
            }
        }

        public Enum_Taal Taal
        {
            get
            {
                return taal;
            }

            set
            {
                taal = value;
            }
        }

        public Afmeting Afmetingen
        {
            get
            {
                return afmetingen;
            }

            set
            {
                afmetingen = value;
            }
        }
        #endregion


        #region Methods
        /// <summary>
        /// Publicaties the specified titel.
        /// </summary>
        /// <param name="_titel">The titel.</param>
        /// <param name="_auteur">The auteur.</param>
        /// <param name="_taal">The taal.</param>
        /// <param name="_afmetingen">The afmetingen.</param>
        /// <param name="_gewicht">The gewicht.</param>
        /// <param name="_prijs">The prijs.</param>
        public abstract void publicatie(string _titel, string _auteur, Enum_Taal _taal, Afmeting _afmetingen, int _gewicht, decimal _prijs);

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}