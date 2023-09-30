using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    internal class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; }=new TeamModel();
        public decimal Score { get; set; }

        public MatchUpModel ParentMatchup { get; set; }=new MatchUpModel();
    }
}
