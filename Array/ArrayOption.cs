using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayOption
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

        public static bool IsSymmetrical(List<int> array)
        {
            int number = array.Count;
            for (int i = 0; i < number / 2; i++)
            {
                if (array[i] != array[number - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void CheckSymmetry(List<int> array)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (IsSymmetrical(array)) Console.WriteLine("\n\t\t--> Mảng đối xứng.");
            else Console.WriteLine("\n\t\t--> Mảng không đối xứng.");
        }
    }
}
