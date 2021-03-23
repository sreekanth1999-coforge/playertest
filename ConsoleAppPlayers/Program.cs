using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayers
{
    class Program
    {
        public static List<Players> Plist()
        {
            List<Players> playlist = new List<Players>
            {
                new Players{PId=0,PName="Dhoni",PTeam="India"},
                new Players{PId=1,PName="Virat Kohli",PTeam="India"},
                new Players{PId=2,PName="Rohit Sharma",PTeam="India"}
                
            };
                        return playlist;
        }
        static void Main(string[] args)
        {

        }
    }
}
