namespace Teamplate_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1 - Add item");
                Console.WriteLine("2 - Edit item");
                Console.WriteLine("3 - Delete item");
                Console.WriteLine("4 - Cancel");

                Console.Write("Enter selection: ");
                string? selection = Console.ReadLine();

                if(selection == null)
                {
                    Console.WriteLine("Please make a selection!");
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                }
                else
                {
                    switch (selection)
                    {
                        case "1":
                            Console.WriteLine("You added something! Well Done!");
                            Console.WriteLine("Press Enter to Continue");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("You edited something! Well Done!");
                            Console.WriteLine("Press Enter to Continue");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("You deleted something! Well Done!");
                            Console.WriteLine("Press Enter to Continue");
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine("Bye Bye!");
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Please make a CORRECT selection!");
                            Console.WriteLine("Press Enter to Continue");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
