﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class OrderItems
    {
        #region Definitions
        private List<Order> orderLijst;
        private string printLastOrder;
        #endregion

        #region Getter and Setters
        public List<Order> OrderLijst { get; set; }
        public string PrintLastOrder { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItems"/> class.
        /// </summary>
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
        public override string ToString()
        {
            return base.ToString();
        }
        public string PrintOrderOpDatum(DateTime _datum)
        {
            throw new System.NotImplementedException();
        } 
        #endregion
    }
}
