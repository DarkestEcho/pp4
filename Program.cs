using System;
using System.Linq;


namespace лб4
{
    class Parallel
    {
        static int[] mas;
        static void Main(string[] args)
        {
            mas = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var exp = mas.AsParallel().Select(x => Math.Exp(x));

            Console.WriteLine("Exp\n");

            exp.ForAll((e) => Console.WriteLine(e.ToString("0.000")));
            Console.ReadKey();
        }

    }
}
