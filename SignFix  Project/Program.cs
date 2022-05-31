using System;
namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sign length in mm: ");
            var signLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sign width in mm: ");
            var signWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Size is " + signLength + " x " + signWidth + "(Length x Height)");
            //ADD A CONFIRMATION PROMPT HERE
            string channelType = "";
            if (signWidth >= 900)
            {
                channelType = "medium channel";
            }
            else
            {
                channelType = "small channel";
            };
            int channelLength = signLength - 100;
            int channelAmount = signWidth % 100;
            Console.WriteLine("Sign requires " + channelAmount + "x length(s) of " + channelType + " at, " + channelLength + "mm long.");
        }
    }
}