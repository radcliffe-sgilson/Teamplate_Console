namespace Teamplate_Console.ConsoleLibrary.MenuSystem
{
    public class Menu
    {
        private List<MenuItem> _options = new();
        private string _title = "New Menu";
        private string _prompt = "Make a selection: ";

        public Menu(string title, string prompt)
        {
            _title = title;
            _prompt = prompt;
        }

        public void Display() {
            Console.WriteLine(_title);
            for(int i = 0; i < _options.Count; i++)
            {
                Console.Write(i + 1);
                Console.Write(" : ");
                Console.WriteLine(_options[i].name);
            }
            Console.Write(_prompt);
            string? selection = Console.ReadLine();
            MakeSelection(selection);
        }

        public void AddItem(string name, Action action) {
            _options.Add(new MenuItem(name, action));
        }

        public void MakeSelection(string? input) {
            //Start a loop
            bool _invalidInput = true;
            while (_invalidInput)
            {
                //First do a check to see if the input is actually a number
                int selection = -1;
                if(int.TryParse(input, out selection)){
                    //Then do a range check to see if its a valid menu option
                    selection = selection - 1;
                    if(selection >= 0 && selection < _options.Count)
                    {
                        //if it is valid, trigger the action
                        _options[selection].Trigger();
                        _invalidInput = false;
                    }
                    else
                    {
                        //Error Message - options out of range
                        Console.WriteLine("Please select a valid option.");
                        Console.Write("Press Enter to Try Again");
                        Console.ReadLine();
                    }
                }
                else
                {
                    //Error Message - not a valid
                    Console.WriteLine("Please enter numbers only.");
                    Console.Write("Press Enter to Try Again");
                    Console.ReadLine();
                }

            }
        }
    }
}
