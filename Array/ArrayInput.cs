using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayInput
    {
        public static List<int> GetList()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử: ");
            int number = int.Parse(Console.ReadLine()!);

            List<int> listNumber = new List<int>();
            for (int i = 0; i < number; i++)
            {
                Console.Write($"A[{i}] = ");
                listNumber.Add(int.Parse(Console.ReadLine()!));
            }

            return listNumber;
        }
    }
}
