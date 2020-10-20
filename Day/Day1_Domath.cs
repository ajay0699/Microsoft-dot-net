using System;


namespace Day1_Domath
{
    class Program
    {
        static float sqaure(float a)
        {
            return (float)(a * a);
        }
        static float cube(float a)
        {
            return (float)(a * a * a);        
        }
        static void Main(string[] args)
        {
            float A;
            A = 5;
            float result;
            result = sqaure(A);
            float b = (float)Program.cube(A);
            Console.WriteLine("the result of Domath :"+result +b);
            Console.Read();
        }
    }
}
