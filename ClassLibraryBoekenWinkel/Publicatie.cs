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
        private Afmetingen afmetingen;
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

        public Afmetingen Afmetingen
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
    }
}
