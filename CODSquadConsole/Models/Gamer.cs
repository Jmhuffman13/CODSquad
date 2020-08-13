using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CODSquadConsole.Models
{
    public class Gamer
    {
        public Gamer()
        {
        }

        public string Name { get; set; }
        public double Wins { get; set; }
        public double TopTwentyFive { get; set; }
        public double TopTen { get; set; }
        public double TopFive { get; set; }
        public double Kills { get; set; }
        public double Deaths { get; set; }
        public double KDRatio { get; set; }
        public double Score { get; set; }
        public double ScorePerMinute { get; set; }
    }
}
