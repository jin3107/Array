using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArraySorter
    {
        public static void SortArray(List<int> array)
        {
            array.Sort();

            foreach (var number in array)
            {
                Console.Write($"\t {number}");
            }

            Console.ReadLine();
        }
    }
}
