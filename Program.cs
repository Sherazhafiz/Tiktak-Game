using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiktak_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            int p1;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\tWelecome to the game Tiktak");
                Console.WriteLine("\t\t***************************");
                Console.WriteLine("\t\t   {0}   |   {1}   |   {2} ", array[0], array[1], array[2]);
                Console.WriteLine("\t\t--------------------------");
                Console.WriteLine("\t\t   {0}   |   {1}   |   {2} ", array[3], array[4], array[5]);
                Console.WriteLine("\t\t--------------------------");
                Console.WriteLine("\t\t   {0}   |   {1}   |   {2} ", array[6], array[7], array[8]);
                Console.WriteLine("\t\t--------------------------");
                //arrr{x,o}
                if ((array[0] == "O" && array[1] == "O" && array[2] == "O") ||
                 (array[3] == "O" && array[4] == "O" && array[5] == "O") ||
                 (array[6] == "O" && array[7] == "O" && array[8] == "O") ||
                 (array[0] == "O" && array[3] == "O" && array[6] == "O") ||
                 (array[1] == "O" && array[4] == "O" && array[7] == "O") ||
                 (array[2] == "O" && array[5] == "O" && array[8] == "O") ||
                 (array[0] == "O" && array[4] == "O" && array[8] == "O") ||
                 (array[2] == "O" && array[4] == "O" && array[6] == "O") )
                {
                    Console.WriteLine("Second person wins");
                   
                    break;
                }
                 if((array[0] == "X" && array[1] == "X" && array[2] == "X") ||
                 (array[3] == "X" && array[4] == "X" && array[5] == "X") ||
                 (array[6] == "X" && array[7] == "X" && array[8] == "X") ||
                 (array[0] == "X" && array[3] == "X" && array[6] == "X") ||
                 (array[1] == "X" && array[4] == "X" && array[7] == "X") ||
                 (array[2] == "X" && array[5] == "X" && array[8] == "X") ||
                 (array[0] == "X" && array[4] == "X" && array[8] == "X") ||
                 (array[2] == "X" && array[4] == "X" && array[6] == "X"))
                {
                    Console.WriteLine("First person wins");
                    break;
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine("\tit's the turn of second person");
                    string p3;
                    int p4 = 0;
                    while (p4 == 0)
                    {
                        test:
                        p3 = Console.ReadLine();
                        if (int.TryParse(p3, out p4))
                        {
                            if (p4 >= 1 && p4 <= 9)
                            {
                                p1 = p4;
                                if (array[p1 - 1] == "O")
                                {
                                    Console.WriteLine("Enter correct place" );
                                    goto test;
                                }
                                  
                                array[p1 - 1] = "X";

                            }

                        }
                        else
                        {
                            p4 = 0;
                            Console.WriteLine("Enter correct number");
                        }              
                    }
                }
                if (i % 2 == 1)
                {
                    Console.WriteLine("\tit's the turn of first person");
                    string p5;
                    int p6 = 0;
                    while (p6 == 0)
                    {
                        test1:
                        p5 = Console.ReadLine();
                        if (int.TryParse(p5, out p6))
                        {
                            if (p6 >= 1 && p6 <= 9)
                            {
                                p1 = p6;
                                if (array[p1 - 1] == "X")
                                {
                                    Console.WriteLine("Enter correct place");
                                    goto test1;
                                }
                                array[p6 - 1] = "O";
                            }
                        }
                        else
                        {
                            p6 = 0;
                            Console.WriteLine("Enter correct number");
                        }
                           

                    }


                }

                Console.Clear();
            }
        }
    }
}

