using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace homework11
{
   
    class Program
    {
        static void Main(string[] args)
        {
           foreach (var day in DateTime.Now.TakeData(10))
            {
                Console.WriteLine(day);
            }
            Console.ReadKey();
        }
    }
    static class TakeData1
    {
        public static IEnumerable<DateTime> TakeData(this DateTime date, int d)
        {
            //DateTime yesterday = DateTime.Now;
            //DateTime then = yesterday.AddDays(double.Parse(Console.ReadLine()));
            for (int i = 0; i < d; i++)
            {
                Thread.Sleep(100);
                yield return date.AddDays(i);
            }

        }
    }
}
