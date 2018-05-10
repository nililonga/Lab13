using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Player3 : Player
    {
        
        
        public override Roshambo generateRoshambo()
        {
            Console.WriteLine("Select Rock, Paper, or Scissors to start playing! (Choose R/S/P)");
            string answer = Console.ReadLine().ToUpper();

            while (answer != "R" || answer != "P" || answer != "S")
            {
                if (answer == "R")
                {
                    return Roshambo.Rock;
                }
                else if (answer == "P")
                {
                    return Roshambo.Paper;
                }
                else
                {
                    return Roshambo.Scissors;
                }
            

            
                Console.WriteLine("that was not a valid entry, try again");
                answer = Console.ReadLine().ToUpper();

            }
            
            
        }

    }
}
