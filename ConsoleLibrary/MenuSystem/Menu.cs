namespace Teamplate_Console.ConsoleLibrary.MenuSystem
{
    public class Menu
    {
        private List<MenuItem> _options = new();
        private string _title = "New Menu";
        private string _prompt = "Make a selection: ";

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

        public void AddItem() { }

        public void MakeSelection(string? input) {
            //Start a loop
            bool _invalidInput = true;
            while (_invalidInput)
            {
                //First do a check to see if the input is actually a number
                //Then do a range check to see if its a valid menu option
                //if it is valid, trigger the action
                //if not valid, show an error message
            }
        }
    }
}
