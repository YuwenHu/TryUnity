using System;

namespace _02FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int k=i++;
            Console.WriteLine(k);
            int x = 1;
            int t = ++x;
            Console.WriteLine(t);
          
            Console.ReadKey();
     
        }
    }
}
