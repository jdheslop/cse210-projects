
public class Menu
    {
        //Attributes
        private string _menuHeader;
        private string _menuItem1;
        private string _menuItem2;
        private string _menuItem3;
        private string _menuItem4;
        private string _menuItem5;
        private string _menuClosing;
        private int _userInput;

        //Constructors
        public Menu() 
        {
            _menuHeader = "Menu Options:";
            _menuItem1 = "    1. Start breathing activity";
            _menuItem2 = "    2. Start reflecting activity";
            _menuItem3 = "    3. Start listing activity";
            _menuItem4 = "    4. Display activity counters";
            _menuItem5 = "    5. Quit"; 
            _menuClosing = "Select choice from the menu: ";
        }

        //Methods
        public int DisplayMenu() 
        {
            Console.Clear();
            Console.WriteLine(_menuHeader);
            Console.WriteLine(_menuItem1);
            Console.WriteLine(_menuItem2);
            Console.WriteLine(_menuItem3);
            Console.WriteLine(_menuItem4);
            Console.WriteLine(_menuItem5);
            Console.Write(_menuClosing);
            _userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return _userInput;
        }
    }