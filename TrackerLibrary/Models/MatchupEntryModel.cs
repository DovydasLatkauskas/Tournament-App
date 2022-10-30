using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Representation of a team in a matchup.
        /// </summary>
        public int TeamCompetingId { get; set; }
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Representation of the score of this team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Representation of the previous matchup this team won.
        /// </summary>
        public int ParentMatchupId { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}
