using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public abstract class Publicatie
    {
        private string titel;
        private string auteur;
        private string taal;

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

        public string Taal
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


    }
}
