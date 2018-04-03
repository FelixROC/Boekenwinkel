﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class BoekenWinkel
    {
        #region Defintions
        private string contactinformatie;
        private string openingstijden;
        private List<Publicatie> vooraad;
        private OrderItems objOrderItems;

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
        public BoekenWinkel(string _Contactinformatie, string _Openingstijden, List<Publicatie> _Voorraad, OrderItems _ObjOrderItems)
        {
            this.contactinformatie = _Contactinformatie;
            this.openingstijden = _Openingstijden;
            this.vooraad = _Voorraad;
            this.objOrderItems = _ObjOrderItems;
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
        public static void NieuwBoek()
        {
            throw new System.NotImplementedException();
        }
        public static void NieuwBoek(Boek _objBoek)
        {
            //Probeer een boek toe te voegen 
            try
            {
                Publicatie.Boekenlijst.Add(_objBoek);
            }
            catch (NullReferenceException)
            {
                //als het boek niks bevat moet je zeggen dat er niks in het boek zit
                Console.WriteLine("Boek doesnt contain any data");
            }
            

        }
        public void NieuwTijdschrift()
        {
            throw new System.NotImplementedException();
        }
        public static void NieuwTijdschrift(Tijdschrift _objTijdschrift)
        {
            //Probeer een Tijdschrift toe te voegen 
            try
            {
                Publicatie.Tijdschriften.Add(_objTijdschrift);
            }
            catch (NullReferenceException)
            {
                //als het Tijdschrift niks bevat moet je zeggen dat er niks in het boek zit
                Console.WriteLine("Boek doesnt contain any data");
            }
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