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
            int number;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử (số nguyên dương): ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhâp lại!");
                Console.Write("Nhập số lượng phần tử (số nguyên dương): ");
            }

            List<int> listNumber = new List<int>();
            for (int i = 0; i < number; i++)
            {
                Console.Write($"\tA[{i}] = ");
                listNumber.Add(int.Parse(Console.ReadLine()!));
            }

            return listNumber;
        }
    }
}
