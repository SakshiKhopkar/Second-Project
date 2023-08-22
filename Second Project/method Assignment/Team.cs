using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.method_Assignment
{
    //Write code to show static keyword with variable,class,method ,constructor
    public class Team
    {
        public static int TotalTeam = 0;
        private string teamname;
        private int numberofmembers;

        public Team(string teamname, int numberofmembers)
        {
            this.teamname = teamname;
            this.numberofmembers = numberofmembers;
            TotalTeam++;
        }
        public static void DisplayTotalteam()
        {
            Console.WriteLine("Total team="+TotalTeam);
        }
        public string DisplayTeam()
        {
            return $"{teamname}-{numberofmembers}";
        }
    }
}
