using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    internal class TournamentModel
    {
        
        public string TournamentName { get; set; }

       
        public decimal EntryFee { get; set; }

        public List<TeamModel> TeamEntered { get; set; }= new List<TeamModel>();

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// ith row means ith round and full row represent diff matches going to happen in each ith round
        /// </summary>
        public List<List<MatchUpModel>> Rounds { get; set; } =new List<List<MatchUpModel>>();
    }
}
