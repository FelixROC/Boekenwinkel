﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    class OrderItems
    {
        #region Definitions
        private List<Order> orderLijst;
        private string printLastOrder;
        #endregion

        #region Getter and Setters
        public List<Order> OrderLijst
        {
            get
            {
                return orderLijst;
            }

            set
            {
                orderLijst = value;
            }
        }

        public string PrintLastOrder
        {
            get
            {
                return printLastOrder;
            }

            set
            {
                printLastOrder = value;
            }
        }
        #endregion

        #region Methods
        public OrderItems()
        {

        }

        public void Toevoegen(Order _order)
        {

        }

        public void Verwijderen(Order _order)
        {

        }

        public void Verwijderen( int _index)
        {

        }
        public string PrintOrderOpDatum(DateTime _datum)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
