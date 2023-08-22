using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Inheretance_Assignment
{
    public class IPLTeam
    {
        protected int year;

        public IPLTeam(int year)
        {
            this.year = year;
        }

        public virtual string Play()
        {
            return $"IPL Team is playing{year}";
        }
    }

    public class CSK : IPLTeam
    {
        private int score, runrate, noofsentury;
        public CSK(int score,int runrate,int noofsentury,int year):base(year)
        {
           this.score = score;
            this.runrate = runrate;
            this.noofsentury = noofsentury;
        }
        public override string Play()
        {
            return$"Score of CSK{score}-runrate{runrate}-number of sentuary {noofsentury}-{year}";
        }
    }
    public class RCB : IPLTeam
    {
        private int score, runrate, noofsentury;
        public RCB(int score, int runrate, int noofsentury, int year) : base(year)
        {
            this.score = score;
            this.runrate = runrate;
            this.noofsentury = noofsentury;
        }
        public override string Play()
        {
            return $"Score of RCB{score}-runrate{runrate}-number of sentuary {noofsentury}-{year}";
        }
    }
}
