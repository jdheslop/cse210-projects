
/*
Class: UserInputAsString
Attributes:
    _inputPrompt : string
Methods:
    GetUserInputAsString() : string
*/

using System;

public class UserInputAsString
    {
        public string _inputPrompt;

        public string GetUserInputAsString()
        {
            Console.WriteLine(_inputPrompt);
            Console.Write("> ");
            string userInputAsString = Console.ReadLine();
            return userInputAsString;
        }
    }