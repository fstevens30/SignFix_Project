using System;
namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sign length in mm: "); //Prompts User to enter length
            var signLength = Convert.ToInt32(Console.ReadLine()); //Converts Input to signLength variable
            if (signLength < 0)
            {
                Console.WriteLine("Error: Invalid length."); //Returns an error if length is less than 0
            }
            else Console.WriteLine("Enter sign height in mm: "); //Prompts User to enter height
            var signHeight = Convert.ToInt32(Console.ReadLine()); //Converts Input to signHeight variable
            if (signHeight < 0)
            {
                Console.WriteLine("Error: Invalid width.");
                Environment.Exit(0);
            }
            else Console.WriteLine("Size is " + signLength + " x " + signHeight + "(Length x Height)");
            //ADD A CONFIRMATION PROMPT HERE

            string channelType = ""; //Sets a new variable with an empty string
            //The following if statement determines the amoung of channel
            if (signHeight >= 900)
            {
                channelType = "medium channel";
            }
            else
            {
                channelType = "small channel";
            };
            int channelLength = signLength - 100; //Sets a variable of channelLength
            int channelAmount = 0; //Sets an empty variable of channelAmount
            //The following if statement determines how many lengths are needed.
            if (signHeight >= 1000)
            {
                channelAmount = 4;
            }
            else if (signHeight <= 1000 & signHeight > 400)
            {
                channelAmount = 3;
            }
            else if (signHeight <= 400 & signHeight > 100)
            {
                channelAmount = 2;
            }
            else if (signHeight <= 100 & signHeight > 0)
            {
                channelAmount = 1;
            }
            //Lastly prints the following with each variable...
            Console.WriteLine("Sign requires " + channelAmount + "x length(s) of " + channelType + " at, " + channelLength + "mm long.");
        }
    }
}