using System;

namespace TriangleApplication
{
    class Program
    {

        static int ValidatemenuSelection()
        {
            string userinput = "";
            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {
                Console.WriteLine("Select the operation which you want to perform from below options.....\n");
                Console.WriteLine("1 = Enter Triangle Dimensions\n");
                Console.WriteLine("2 = Exit\n");
                userinput = (Console.ReadLine());
                if (userinput != "1" && userinput != "2")
                {
                    Console.WriteLine("Invalid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelection = true;
                }
            }

            return int.Parse(userinput);


        }

        static void Main(string[] args)
        {
            int selection;
            selection = ValidatemenuSelection();
            if (selection != 2)
            {
                Console.WriteLine("Enter 3 dimensions of Triangle");
                Console.WriteLine("Side a:");
                int Side_a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Side b:");
                int Side_b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Side c:");
                int Side_c = Convert.ToInt32(Console.ReadLine());
                TriangleSolver.analyze(Side_a, Side_b, Side_c);
            }

        }
    }
}
