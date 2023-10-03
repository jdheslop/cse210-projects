
/*
Class: PromptGenerator: 
Attributes:
    _prompts : List<string>
Methods:
    GeneratePrompt() : string
*/

using System;
using System.Collections.Generic;

public class PromptGenerator
    {
        public List<string> _prompts = new List<string>();

        public string GeneratePrompt()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _prompts.Count);
            string prompt = _prompts[randomIndex];
            return prompt;
        }
    }
