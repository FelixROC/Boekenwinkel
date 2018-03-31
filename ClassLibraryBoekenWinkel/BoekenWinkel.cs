using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    class BoekenWinkel
    {
        #region Defintions
        private string contactinformatie;
        private string openingstijden;
        private List<Publicatie> vooraad;
        private Object objOrderItems;

        #endregion
        #region Getter and Setters
        public string Contactinformatie { get; set; }
        public string Openingstijden { get; set; }
        public List<Publicatie> Voorraad { get; set; }
        public object ObjOrderItems { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="BoekenWinkel"/> class.
        /// </summary>
        public BoekenWinkel()
        {
        }
        public string GenereerOrder()
        {
            throw new System.NotImplementedException();
        }

        public string VerkoopBoek(string _ISBN, int _aantal)
        {
            throw new System.NotImplementedException();
        }

        public string VerkoopTijdschrift(string _ISSN, int aantal)
        {
            throw new System.NotImplementedException();
        }

        public void NieuwBoek()
        {
            throw new System.NotImplementedException();
        }

        public void Niewboek(Boek _objBoek)
        {
            throw new System.NotImplementedException();
        }

        public void NieuwTijdschrift()
        {
            throw new System.NotImplementedException();
        }

        public void NieuwTijdschrift(Tijdschrift _objTijdschrift)
        {
            throw new System.NotImplementedException();
        }

        public void VerwijderBoek(Boek _objBoek)
        {
            throw new System.NotImplementedException();
        }

        public void VerwijderTijdschrift(Tijdschrift _objTijdschift)
        {
            throw new System.NotImplementedException();
        }

        public string ToonAlleTijdschriften()
        {
            throw new System.NotImplementedException();
        }

        public string ToonAlleBoeken()
        {
            throw new System.NotImplementedException();
        }

        public void LaasteBestellingAfhandelen()
        {
            throw new System.NotImplementedException();
        }

        public List<string> NietAfgehandeldeBestellingen()
        {
            throw new System.NotImplementedException();
        }

        public DateTime Bestellinginzien(DateTime _datum)
        {
            throw new System.NotImplementedException();
        }
    }
}
#endregion