using System;

namespace jednakostranicni_trougao_datog_obima
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, o, a1;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            o = a + b + c;
            a1 = o / 3;

            if ((o % 3) > 0)
            {
                Console.WriteLine("ne");
            }
            else
            {
                Console.WriteLine("da {0}",a1);
            }
        }
    }
}
