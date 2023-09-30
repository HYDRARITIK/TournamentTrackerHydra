using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    internal class MatchUpModel
    {
        public List<MatchupEntryModel> Entries { get; set; }=new List<MatchupEntryModel>();

        public TeamModel Winner { get; set; } = new TeamModel();

        public int MatchUpRound { get; set; }
    }
}
