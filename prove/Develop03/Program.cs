/*
Exceeding Requirements:
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText1 = "And now, my beloved brethren, I would that ye should come unto Christ, who is the Holy One of Israel, and partake of his salvation, and the power of his redemption. Yea, come unto him, and offer your whole souls as an offering unto him, and continue in fasting and praying, and endure to the end; and as the Lord liveth ye will be saved.";
 
        Reference referenceObject1 = new Reference("Omni", "1", "26");
        string reference1 = referenceObject1.GetReference();
        
        Scripture scripture1 = new Scripture(reference1, scriptureText1);
        scripture1.DisplayScripture();
    }
}