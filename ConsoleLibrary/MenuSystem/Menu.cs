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

        public void MakeSelection(string? input) { }
    }
}
