using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prince_s_tomb
{
    class Program
    {
        static void Main()
        {
            global::MenuClass.Menu(true);
            global::MenuClass.MenuChoosing();
            //menu
            var map = Mapgen();
            var tomb = TombPoseGen();


            PathFinding();



            //grafika
            //pathfinding
            //cilkus movement
            //  arrows
            Console.ReadKey();

        }

        public static void PathFinding()
        {
            throw new NotImplementedException();
        }




        public static void SetWindowSettins()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(120, 30);
        }

        public static int[,] Mapgen()
        {
            Console.Clear();



            Random r = new Random();
            int[,] map = new int[25, 25];


            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = r.Next(0, 3);
                }
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                string temp = "";
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    temp += map[i, j] + " ";
                }
                Console.WriteLine(temp);

            }
            

            return map;
        }

        public static int[] TombPoseGen()
        {
            Console.Clear();
            int[] tombCord = new int[2];


            Random r = new Random();

            tombCord[0] = r.Next(15, 25);
            tombCord[1] = r.Next(15, 25);

            return tombCord;
        }
    }
}
