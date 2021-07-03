using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleApplication
{
    public static class TriangleSolver
    {

        public static string analyze(int Side_a, int Side_b, int Side_c)
        {
            int a = Side_a, b = Side_b, c = Side_c;
            string result;
            if ((a + b <= c) && (b + c <= a) && (a + c <= b))
            {
                result = "Number's don't form a triangle";
                Console.WriteLine(result);
            }
            else
            {
                if (Side_a == Side_b && Side_b == Side_c)
                {
                    result = "Equilateral";
                    Console.WriteLine(result);
                }

                else if (Side_a == Side_b || Side_a == Side_c || Side_b == Side_c)
                {
                    result = "Isosceles";
                    Console.WriteLine(result);
                }

                else
                {
                    result = "Scalene";
                    Console.WriteLine(result);
                }
            }


            return result;
        }
    }
}
