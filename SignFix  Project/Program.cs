using System;
namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sign length in mm: ");
            var signLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sign height in mm: ");
            var signHeight = Convert.ToInt32(Console.ReadLine());
            if (signLength < 0)
            {
                Console.WriteLine("Error: Invalid length.");
            }
            else if (signHeight < 0)
            {
                Console.WriteLine("Error: Invalid width.");
            }

            Console.WriteLine("Size is " + signLength + " x " + signHeight + "(Length x Height)");
            //ADD A CONFIRMATION PROMPT HERE
            string channelType = "";
            if (signHeight >= 900)
            {
                channelType = "medium channel";
            }
            else
            {
                channelType = "small channel";
            };
            int channelLength = signLength - 100;
            int channelAmount = 0;
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


            Console.WriteLine("Sign requires " + channelAmount + "x length(s) of " + channelType + " at, " + channelLength + "mm long.");
        }
    }
}