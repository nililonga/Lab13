using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Player2: Player
    {

        public static Random Rnd = new Random();


        public override Roshambo generateRoshambo()
        {
            if (Rnd.Next(0,3) == 0)
            {
                return Roshambo.Rock;
            }
            else if (Rnd.Next(0,3) == 1)
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissors;
            }
        }
    }
}
