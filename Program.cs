using System;
using System.IO;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //NEED TO RUN OTHER METHODS INSIDE OF THE MAIN METHOD/FUNCTION
            int num1 = 6;
            int num2 = 7;
            int sum;

            sum = Add_return_function(num1, num2);
            Console.WriteLine(sum);
        }

        //VOID FUNCTION
       static void subtract_numbers(int x, int y)
        {
            int sum = x - y;
            Console.WriteLine(sum);

        }
        // 2ND VOID FUNCTION / METHOD
        static void add(int x,int y)
        {
            int sum = x + y;
            Console.WriteLine(sum);
        
        }
        //RETURN FUNCTION/METHOD
        static int Add_return_function(int x , int y)
        {
            return x + y;
        }
    }
}
