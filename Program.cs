using System;

namespace SwapTwoNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a={0} b={1}",a,b);
            int c = a;
            a=b;
            b=c;
            Console.WriteLine("swaping done a={0} b={1}", a, b);
        }
    }
}
