using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Player1 : Player
    {
        public override Roshambo generateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
