﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBoekenWinkel
{
    public class Afmeting
    {

        public int lengte { get; set; }

        public int Breedte { get; set; }

        public int Hoogte { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Afmeting" /> class.
        /// </summary>
        /// <param name="_lengte">The lengte.</param>
        /// <param name="_breedte">The breedte.</param>
        /// <param name="_hoogte">The hoogte.</param>
        public Afmeting(int _lengte, int _breedte, int _hoogte)
        {
            _lengte = lengte;
            _breedte = Breedte;
            _hoogte = Hoogte;
        }   
        public Afmeting()
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
