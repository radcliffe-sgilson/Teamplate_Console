namespace Teamplate_Console.ConsoleLibrary.MenuSystem
{
    public class MenuItem
    {
        public string name { get { return _name; } }

        private string _name = "";
        private Action _action;

        public MenuItem(string n, Action a)
        {
            _name = n;
            _action = a;
        }

        public void Trigger()
        {
            _action.Invoke();
        }
    }
}
