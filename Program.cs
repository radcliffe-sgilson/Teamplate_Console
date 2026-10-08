using Teamplate_Console.ConsoleLibrary.MenuSystem;

namespace Teamplate_Console
{
    internal class Program
    {
        public static bool isRunning = true;
        static void Main(string[] args)
        {
            Menu menu = new Menu("Main Menu", "Please make a selection : ");
            menu.AddItem("Add", Add);
            menu.AddItem("Edit", Edit);
            menu.AddItem("Delete", Delete);
            menu.AddItem("Exit", Exit);
            while (isRunning)
            {
                Console.Clear();
                menu.Display();
            }
        }

        static void Add() {
            Console.WriteLine("You added something! Well Done!");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
        static void Edit()
        {
            Console.WriteLine("You edited something! Well Done!");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
        static void Delete()
        {
            Console.WriteLine("You deleted something! Well Done!");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
        static void Exit()
        {
            Console.WriteLine("Bye Bye!");
            isRunning = false;
        }

    }
}
