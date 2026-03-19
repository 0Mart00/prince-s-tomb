using System;


public class MenuClass
{

    public static void MenuChoosing()
    {
        bool menuLoop = true;
        bool menuOption = true;
        while (menuLoop)
        {
            ConsoleKey cK = Console.ReadKey().Key;

            if (cK == ConsoleKey.DownArrow)
            {
                Menu(false);
                menuOption = false;

            }
            else if (cK == ConsoleKey.UpArrow)
            {
                Menu(true);
                menuOption = true;

            }
            if (cK == ConsoleKey.Enter)
            {
                if (menuOption)
                {

                    global::prince_s_tomb.Program.Start();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

        }

    }

    public static void Menu(bool option)
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
}
