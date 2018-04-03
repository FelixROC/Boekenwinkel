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
        private object objOrderItems;

        #endregion
        #region Getter and Setters
        public string Contactinformatie { get; set; }
        public string Openingstijden { get; set; }
        public List<Publicatie> Voorraad { get; set; }
        public OrderItems ObjOrderItems { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="BoekenWinkel"/> class.
        /// </summary>
        public BoekenWinkel(string _Contactinformatie, string _Openingstijden, List<Publicatie> _Voorraad, object _ObjOrderItems)
        {
            this.contactinformatie = _Contactinformatie;
            this.openingstijden = _Openingstijden;
            this.vooraad = _Voorraad;
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
        }
        public void NieuwTijdschrift()
        {
            throw new System.NotImplementedException();
        }
        public void NieuwTijdschrift(Tijdschrift _objTijdschrift)
        {
            try
            {
                Publicatie.Tijdschriftenlijst.Add(_objtijdschrift);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(@"No data found in the object Tijdschrift.");
            }
        }
        public void VerwijderBoek(Boek _objBoek)
        {
            if (Publicatie.Boekenlijst.Contains(_objboek))
            {
                Publicatie.Boekenlijst.Remove(_objboek);
            }
            else
            {
                Console.WriteLine(@"No data found that is similiar to objboek");
            }
        }
        public void VerwijderTijdschrift(Tijdschrift _objTijdschift)
        {
            if (Publicatie.Tijdschriftenlijst.Contains(_objtijdschrijft))
            {
                Publicatie.Tijdschriftenlijst.Remove(_objtijdschrijft);
            }
            else
            {
                Console.WriteLine(@"No data found that is similiar to objboek");
            }
        }
    }
        public string ToonAlleTijdschriften()
        {
            {
                int lijst = 0;
                foreach (var _ in Publicatie.Tijdschriftenlijst)
                {
                    lijst++;
                }

                return lijst.ToString();
            }
        }
        public string ToonAlleBoeken()
        {
            int lijst = 0;
            foreach (var _ in Publicatie.Boekenlijst)
            {
                lijst++;
            }

            return lijst.ToString();

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
        #endregion
    }
}