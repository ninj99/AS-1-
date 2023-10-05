using System;

namespace Lern_BroCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x;
            Random fir = new Random();
            Random mi = new Random();

           double y = fir.NextDouble();
            x = fir.Next(1,4);
          int z = mi.Next(1,10);
            Console.WriteLine(z+x+y);
            int fer = Convert.ToInt32(z - x);
            Console.WriteLine(z);
            Console.WriteLine(x);
            Console.WriteLine(fer);

        }
    }
}