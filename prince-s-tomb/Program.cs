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
            menu();

            //mapgen();
            
            
            
            //grafika
            //pathfinding
            //cilkus movement
            //  arrows
            Console.ReadKey();

        }

        private static void menu()
        {
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("");
            Console.WriteLine("Start");
        }

        private static void setWindowSettins()
        {
            Console.SetWindowSize(120,30);
        }

        private static void mapgen()
        {
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
