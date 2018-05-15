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
            Console.WriteLine("Select Rock, Paper, or Scissors to start playing!: (Choose R/S/P)");
            string answer = Console.ReadLine().ToUpper();

            while (true)
            {
                if (answer != "R" && answer != "P" && answer != "S")
                {
                    Console.WriteLine("That was not a valid input, please try again");
                    answer = Console.ReadLine().ToUpper();
                }
                else if (answer == "R")
                {
                    return Roshambo.Rock;
                }
                else if (answer == "P")
                {
                    return Roshambo.Paper;
                }
                else if (answer == "S")
                {
                    return Roshambo.Scissors;
                } 
            }
                
        
            
            
            
        }

    }
}
