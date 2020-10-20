using System;


namespace Day1_product
{
    class Program
    {
        public static byte product(byte a, byte b)
        {
            return (byte)(a * b);
        }
        static void Main(string[] args)
        {
            byte A;
            byte B;
            A = 3;
            B = 4;
            byte Result;
            Result=product(A, B);
            Console.Write("the result of Byte Multiplication is :" + Result);
            Console.Read();

        }
    }
}
