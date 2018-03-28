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
        public DateTime OrderDatum
        {
            get
            {
                return orderDatum;
            }

            set
            {
                orderDatum = value;
            }
        }

        public bool OrderAfgehandeld
        {
            get
            {
                return orderAfgehandeld;
            }

            set
            {
                orderAfgehandeld = value;
            }
        }

        public List<string> OrderList
        {
            get
            {
                return orderList;
            }

            set
            {
                orderList = value;
            }
        }
        #endregion


        #region Methods
        public Order()
        {

        }

        public void Toevoegen(_order:string)
        {

        }

        public void Verwijderen(_order:string)
        {

        }

        public void Verwijderen(_index:string)
        {

        }

        public void Verwijderen(_index:int)
        {

        }

        public override string ToString()
        {

        } 
        #endregion
    }
}
