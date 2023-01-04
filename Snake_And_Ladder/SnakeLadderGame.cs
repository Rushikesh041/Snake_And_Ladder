﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    public class SnakeLadderGame
    {
        public void SnakeLadder()
        {
            int Position1 = 0;
            int Num_Of_Players = 1;

            Console.Write("Enter s to Start to play : ");
            string start = Console.ReadLine();

            Console.WriteLine("Number of Players : " + Num_Of_Players);
            Console.WriteLine("Player 1 at position : " + Position1);

            Random random = new Random();
            while (Position1 != 100)
            {
                int DiceNumber1 = random.Next(1, 7);
                Console.WriteLine("Player rolled the Die ....");
                Console.WriteLine("Dies turns to : " + DiceNumber1);

                int Option1 = random.Next(1, 4);

                switch (Option1)
                {
                    case 1:
                        Console.WriteLine("you are at No Play option");
                        break;

                    case 2:
                        Console.WriteLine("you Get Move Ahead option");
                        Console.WriteLine("Great! You get to Move Ahead, By " + DiceNumber1);
                        Position1 = Position1 + DiceNumber1;
                        break;

                    case 3:
                        Console.WriteLine("But you get Move back option");
                        Console.WriteLine("Oops! you Need to Move Back, By" + DiceNumber1);
                        Position1 = Position1 + DiceNumber1;
                        break;
                }
                if (Position1 < 0)
                {
                    Console.WriteLine("Please Restart");
                    Position1 = 0;
                    continue;
                }
                if (Position1 == 100)
                {
                    Console.WriteLine("Player One wins");
                    break;
                }

            }
            
        }
    }
}
