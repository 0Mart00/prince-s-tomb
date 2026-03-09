using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prince_s_tomb
{
    class Program
    {
        static void Main(string[] args)
        {

            setWindowSettins();
            //menu
            menu(true);
            bool menuLoop = true;
            bool menuOption = true;
            while (menuLoop)
            {
                ConsoleKey cK = Console.ReadKey().Key;
               
                if (cK == ConsoleKey.DownArrow)
                {
                    menu(false);
                    menuOption = false;

                }
                else if (cK == ConsoleKey.UpArrow)
                {
                    menu(true);
                    menuOption = true;

                }
                if (cK == ConsoleKey.Enter)
                {
                    if (menuOption)
                    {
                       
                        mapgen();

                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            
            




            //grafika
            //pathfinding
            //cilkus movement
            //  arrows
            Console.ReadKey();

        }

        private static void menu(bool option)
        {
            if (option)
            {
                Console.BackgroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(56, 12);
                Console.WriteLine("____________");
                Console.SetCursorPosition(55, 13);
                Console.WriteLine("|  Start   |");
                Console.SetCursorPosition(54, 14);
                Console.WriteLine("____________");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(56, 15);
                Console.WriteLine("____________");
                Console.SetCursorPosition(55, 16);
                Console.WriteLine("|   Quit   |");
                Console.SetCursorPosition(54, 17);
                Console.WriteLine("____________");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(56, 12);
                Console.WriteLine("____________");
                Console.SetCursorPosition(55, 13);
                Console.WriteLine("|  Start   |");
                Console.SetCursorPosition(54, 14);
                Console.WriteLine("____________");

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(56, 15);
                Console.WriteLine("____________");
                Console.SetCursorPosition(55, 16);
                Console.WriteLine("|   Quit   |");
                Console.SetCursorPosition(54, 17);
                Console.WriteLine("____________");
                Console.BackgroundColor = ConsoleColor.Black;

            }

        }


        private static void setWindowSettins()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(120,30);
        }

        private static void mapgen()
        {
            Console.Clear();



            Random r = new Random();
            int[,] map = new int[25, 25];

            int[] tombCord = new int[2];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = r.Next(0, 3);
                }
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                string alma = "";
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    alma += map[i, j] + " ";
                }
                Console.WriteLine(alma);

            }
            tombCord[0] = r.Next(15, 25);
            tombCord[1] = r.Next(15, 25);
        }
    }
}
