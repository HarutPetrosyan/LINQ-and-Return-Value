using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRetValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> list = GetStringSubset();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var str=GetstringSubsetArray();
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static IEnumerable<string > GetStringSubset()
        {
            string[] result = { "BWM", "Mersedes Benz", "Audi", "Rolce Royce", "Aston Martin", "Uaguar" };
            IEnumerable<string> result2 = from i in result orderby i select i;
            return result2;
        }
        static string[] GetstringSubsetArray()
        {
            string[] result = { "BWM", "Mersedes Benz", "Audi", "Rolce Royce", "Aston Martin", "Uaguar" };
            var subset= from i in result orderby i select i;
            return subset.ToArray();
        }
    }
}
