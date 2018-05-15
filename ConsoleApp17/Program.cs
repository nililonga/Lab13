﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //enter name
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();

           
                //select and opponent
                Console.WriteLine("select an opponent (Enter 'A' for player1, or 'B' for player2)");
                string answer = Console.ReadLine().ToUpper();


                Player answer2;
                Player user1 = new Player3();
                Roshambo A;
                Roshambo B;

                if (answer == "A")
                {
                    answer2 = new Player1();
                }
                else
                {
                    answer2 = new Player2();
                }
            string answer4;
            do
            {
                A = answer2.generateRoshambo();
                B = user1.generateRoshambo();
                Console.WriteLine(B);
                Console.WriteLine(A);

                if (A == B)
                {
                    Console.WriteLine("it's a tie!");
                }
                else if ((A == Roshambo.Rock && B == Roshambo.Scissors) || (A == Roshambo.Paper && B == Roshambo.Rock) || (A == Roshambo.Scissors && B == Roshambo.Paper))
                {
                    Console.WriteLine($" {name}, You lost!");
                }
                else
                {
                    Console.WriteLine($" {name}, You won the game!");
                }

                Console.WriteLine("would you like to play again? (Y/N)");
                answer4 = Console.ReadLine().ToUpper();
            } while (answer4 == "Y");














            }   
    }
}
