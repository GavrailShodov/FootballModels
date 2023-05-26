using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballModels
{
    internal class Game
    {
        public Team Team1 { get; internal set; }
        public Team Team2 { get; internal set; }

        public Referee Referee { get; internal set; }

        public Referee[] AsistantReferees { get; internal set; }

        public string[] Goals { get; internal set; }
        public string Result { get; internal set; }
        public string Winner { get; internal set; }
    }
}
