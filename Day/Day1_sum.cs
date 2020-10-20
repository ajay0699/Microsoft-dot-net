using System;


namespace Day1_sum
{
 
    class Program
    {
        public static short sum(short a, short b)
        {
            return (short)(a + b);
        }
        static void Main(string[] args)
        {
            short A;
            short B;
            A=7;
            B=3;
            short result;
            result = sum(A, B);
            Console.Write("Addition of two short no result :" + result);
            Console.Read();
        }
    }
}
