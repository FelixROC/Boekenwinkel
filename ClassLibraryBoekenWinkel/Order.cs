using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class Order
    {
        #region Definitions
        private DateTime orderDatum;
        private Boolean orderAfgehandeld;
        private List<string> orderList;
        #endregion


        #region Getter en Setters

        public DateTime OrderDatum { get; set; }
        public bool OrderAfgehandeld { get; set; }
        public List<string> OrderList { get; set; }
       #endregion


        #region Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        public Order()
        {

        }
        public void Toevoegen(string _order)
        {

        }
        public void Verwijderen(string _order)
        {

        }
        public void Verwijderen(int _index)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
