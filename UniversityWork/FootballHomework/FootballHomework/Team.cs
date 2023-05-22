using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FootballHomework.Models.PersonModels;

namespace FootballHomework
{
    public class Team
    {
        public Coach Coach { get; set; }

        public IList<FootballPlayer> footballPlayers { get; set; }

        public double Average { get; set; }

    }
}
