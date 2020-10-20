using System;


namespace Day1_float
{
    class Program
    {
        public static float square(float a)
        {
            return (float)(a * a);
        }
        static void Main(string[] args)
        {
            float A;
            A = 6;
            float result;
            result = square(A);
            Console.WriteLine("the square of float no is:" + result);
            Console.Read();
        }
    }
}
