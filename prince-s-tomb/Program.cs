using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prince_s_tomb
{
    class Program
    {
        public static int xEnd = 0, yEnd = 0;

        public static void Start()
        {

            int[,] map = Mapgen();
            int[,] pathedMap = PathFinding(map);


            
            string temp = "";
            for (int i = 0; i < pathedMap.GetLength(0); i++)
            {
                for (int j = 0; j < pathedMap.GetLength(1); j++)
                {
                    temp += $" {pathedMap[i, j]}";
                }
                Console.WriteLine(temp);
                temp = "";
            }

            Movement(pathedMap);


        }

        static void Main()
        {
            SetWindowSettins();
            global::MenuClass.Menu(true);
            global::MenuClass.MenuChoosing();



            Console.ReadKey();

        }

        private static void Movement(int[,] map)
        {
            Random random = new Random();
            bool gameEnd = true;
            int playerX = 1, playerY = 1;

            int[,] szekta = {
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
            };
            int[,] orok = {
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
            };
            int[,] pestis = {
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
                {random.Next(5,20),random.Next(5,20)},
            };
            while (gameEnd)
            {
                ConsoleKey cK = Console.ReadKey().Key;
                Console.WriteLine($"");
                #region Út
                if (playerY - 1 != 0 && map[playerX - 1 , playerY] == -1)
                {
                    Console.WriteLine("Út balra");
                }
                else if (playerX + 1 != 25 && map[playerX + 1, playerY] == -1)
                {
                    Console.WriteLine("Út jobbra");

                }
                else if (playerY + 1 != 25 && map[playerX, playerY + 1] == -1)
                {
                    Console.WriteLine("Út lent");

                }
                else if (playerY - 1 != 0 && map[playerX, playerY - 1] == -1)
                {
                    Console.WriteLine("Út fent");
                }
                #endregion
                #region pestis
                if (playerX - 1 == pestis[0, 0] && playerY == pestis[0, 1] ||
                    playerX - 1 == pestis[1, 0] && playerY == pestis[1, 1] ||
                    playerX - 1 == pestis[2, 0] && playerY == pestis[2, 1])
                {
                    Console.WriteLine("Pestis balra");
                }
                else if (playerX + 1 == pestis[0, 0] && playerY == pestis[0, 1] ||
                         playerX + 1 == pestis[1, 0] && playerY == pestis[1, 1] ||
                         playerX + 1 == pestis[2, 0] && playerY == pestis[2, 1])
                {
                    Console.WriteLine("Pestis jobbra");

                }
                else if (playerX == pestis[0, 0] && playerY + 1 == pestis[0, 1] ||
                         playerX == pestis[1, 0] && playerY + 1 == pestis[1, 1] ||
                         playerX == pestis[2, 0] && playerY + 1 == pestis[2, 1])
                {
                    Console.WriteLine("Pestis lent");

                }
                else if ((playerX == pestis[0, 0] && playerY - 1 == pestis[0, 1] ||
                         playerX == pestis[1, 0] && playerY - 1 == pestis[1, 1] ||
                         playerX == pestis[2, 0] && playerY - 1 == pestis[2, 1]))
                {
                    Console.WriteLine("Pestis fent");
                }
                #endregion
                #region szekta
                if (playerX - 1 == szekta[0, 0] && playerY == szekta[0, 1] ||
                    playerX - 1 == szekta[1, 0] && playerY == szekta[1, 1] ||
                    playerX - 1 == szekta[2, 0] && playerY == szekta[2, 1])
                {
                    Console.WriteLine("Szekta balra");
                }
                else if (playerX + 1 == szekta[0, 0] && playerY == szekta[0, 1] ||
                         playerX + 1 == szekta[1, 0] && playerY == szekta[1, 1] ||
                         playerX + 1 == szekta[2, 0] && playerY == szekta[2, 1])
                {
                    Console.WriteLine("Szekta jobbra");

                }
                else if (playerX == szekta[0, 0] && playerY + 1 == szekta[0, 1] ||
                         playerX == szekta[1, 0] && playerY + 1 == szekta[1, 1] ||
                         playerX == szekta[2, 0] && playerY + 1 == szekta[2, 1])
                {
                    Console.WriteLine("Szekta lent");

                }
                else if (playerX == szekta[0, 0] && playerY - 1 == szekta[0, 1] ||
                         playerX == szekta[1, 0] && playerY - 1 == szekta[1, 1] ||
                         playerX == szekta[2, 0] && playerY - 1 == szekta[2, 1])
                {
                    Console.WriteLine("Szekta fent");
                }
                #endregion
                #region orok
                if (playerX - 1 == orok[0, 0] && playerY == orok[0, 1] ||
                    playerX - 1 == orok[1, 0] && playerY == orok[1, 1] ||
                    playerX - 1 == orok[2, 0] && playerY == orok[2, 1])
                {
                    Console.WriteLine("Őr balra");
                }
                else if (playerX + 1 == orok[0, 0] && playerY == orok[0, 1] ||
                         playerX + 1 == orok[1, 0] && playerY == orok[1, 1] ||
                         playerX + 1 == orok[2, 0] && playerY == orok[2, 1])
                {
                    Console.WriteLine("Őr jobbra");

                }
                else if (playerX == orok[0, 0] && playerY + 1 == orok[0, 1] ||
                         playerX == orok[1, 0] && playerY + 1 == orok[1, 1] ||
                         playerX == orok[2, 0] && playerY + 1 == orok[2, 1])
                {
                    Console.WriteLine("Őr lent");

                }
                else if (playerX == orok[0, 0] && playerY - 1 == orok[0, 1] ||
                         playerX == orok[1, 0] && playerY - 1 == orok[1, 1] ||
                         playerX == orok[2, 0] && playerY - 1 == orok[2, 1])
                {
                    Console.WriteLine("Őr fent");
                }
                #endregion

                //position ranom dir
                int direction = -1;
                for (int i = 0; i < szekta.GetLength(0); i++)
                {
                    direction = random.Next(0,4);
                    if (szekta[i,0] > 5 && szekta[0,1] < 20 && szekta[i, 1] > 5 && szekta[0, 0] < 20)
                    {
                        //jobbra
                        if (direction == 0)
                        {
                            szekta[i, 0] += 1;
                        }
                        //ballra
                        else if (direction == 1)
                        {
                            szekta[i, 0] -= 1;
                        }
                        //le
                        else if (direction == 2)
                        {
                            szekta[i, 1] += 1;

                        }
                        //fel
                        else if (direction == 3)
                        {
                            szekta[i, 1] -= 1;

                        }
                    }
                }
                for (int i = 0; i < orok.GetLength(0); i++)
                {
                    if (direction == -1)
                    {
                        direction = random.Next(0, 4);
                    }
                    if (orok[i, 0] > 5 && orok[0, 1] < 20)
                    {
                        //jobbra
                        if (direction == 0)
                        {
                            orok[i, 0] += 1;
                        }
                        //ballra
                        else if (direction == 1)
                        {
                            orok[i, 0] -= 1;
                        }
                        //le
                        else if (direction == 2)
                        {
                            orok[i, 1] += 1;

                        }
                        //fel
                        else if (direction == 3)
                        {
                            orok[i, 1] -= 1;

                        }
                    }
                }
                for (int i = 0; i < pestis.GetLength(0); i++)
                {
                    if (direction == -1)
                    {
                        direction = random.Next(0, 4);
                    }
                    if (pestis[i, 0] > 5 && pestis[0, 1] < 20)
                    {
                        //jobbra
                        if (direction == 0)
                        {
                            pestis[i, 0] += 1;
                        }
                        //ballra
                        else if (direction == 1)
                        {
                            pestis[i, 0] -= 1;
                        }
                        //le
                        else if (direction == 2)
                        {
                            pestis[i, 1] += 1;

                        }
                        //fel
                        else if (direction == 3)
                        {
                            pestis[i, 1] -= 1;

                        }
                    }
                }


                if (cK == ConsoleKey.DownArrow && playerY < 24)
                {
                    playerY++;
                }
                else if (cK == ConsoleKey.UpArrow && playerY > 1)
                {
                    playerY--;
                }
                else if (cK == ConsoleKey.LeftArrow && playerX > 1)
                {
                    playerX--;
                }
                else if (cK == ConsoleKey.RightArrow && playerX < 24)
                {
                    playerX++;
                }

                if (playerX == xEnd && playerY == yEnd)
                {
                    Console.WriteLine("anyádat te geci");
                }
                Console.WriteLine($"X: {playerX} Y: {playerY} ? {xEnd} and {yEnd}");
            }
        }

        public static int[,] PathFinding(int[,] map)
        {
            Random random = new Random();
            int x = 1, y = 1;

            for (int j = 0; j < 25; j++)
            {
                xEnd = random.Next(x, 25);
                yEnd = random.Next(y, 25);

                for (int i = x; i < xEnd - 1; i++)
                {
                    map[i, y] = -1;
                    x = i;
                }

                for (int i = y; i <= yEnd -1; i++)
                {
                    map[x, i] = -1;
                    y = i;
                }
            }
            return map;
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

            }
            

            return map;
        }

    }
}
