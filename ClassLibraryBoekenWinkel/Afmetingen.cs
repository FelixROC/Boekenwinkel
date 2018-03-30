using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class Afmeting
    {
        #region Definitions
        private int lengte;
        private int breedte;
        private int hoogte;
        #endregion

        #region Getter and Setters
        public int Lengte { get; set; }

        public int Breedte { get; set; }

        public int Hoogte { get; set; }

        #endregion

        #region Methods

        public Afmeting()
        {
            throw new NotImplementedException();
        }
        public Afmeting(int lengte, int breedte, int hoogte)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion


    }
}
