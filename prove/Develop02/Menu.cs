/*
Class: Menu
Displays the menu and then returns the user selection
Attributes:
    _menuIntro : string
    _menuItems : List<string>
    _menuQuit : string
    _menuClosing : string
Methods:
    DisplayMenu() : int
*/

using System;

public class Menu
    {
        public string _menuIntro;
        public List<string> _menuItems = new List<string>();
        public string _menuQuit;
        public string _menuClosing;

        public int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine(_menuIntro);

            foreach (string menuItem in _menuItems)
            {
                Console.WriteLine(menuItem);
            }

            Console.WriteLine(_menuQuit);
            Console.Write(_menuClosing);
            int userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            return userSelection; 
        }
    }