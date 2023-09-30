using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    internal class PrizeModel
    {
        public string PlaceName { get; set; } 
        public int PlaceNumber { get; set; }

        public decimal PriceAmount { get; set; }

        public decimal PrzePercentage { get; set; }
    }
}
