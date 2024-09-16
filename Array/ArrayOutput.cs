using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayOutput
    {
        public static void PrintList(List<int> listNumber)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n\t---Danh sách (Mảng) đã nhập---\n");
            foreach (var number in listNumber)
            {
                Console.Write($"\t {number}");
            }
            Console.WriteLine();
        }

        public static void SortList(List<int> array)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n\n\t---Danh sách (Mảng) sau khi sắp xếp---\n");
            ArrayOption.SortArray(array);
        }

        public static void CheckSymmetry(List<int> array)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("\n\n\t---Kiểm tra Danh sách (Mảng) có đối xứng hay không?");
            ArrayOption.CheckSymmetry(array);
        }
    }
}
