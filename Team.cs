using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballModels
{
    internal class Team
    {
        public Coach Coach { get; internal set; }    
         public List<FootballPlayer> Players { get; internal set; }

        public double AvarageAge
        {
            get
            {
                int totalAge =0;
                foreach (var player in Players)
                {
                    totalAge += player.Age;
                }
                return (double)totalAge/Players.Count;
            }
        }

    }
}
