using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class ArrayInput
    {
        public static int GetPositiveInteger(string message)
        {
            int number;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("\nDữ liệu nhập không hợp lệ. Vui lòng nhập lại!\n");
                Console.Write(message);
            }
            return number;
        }

        public static int GetArrayElement(int index)
        {
            int element;
            Console.Write($"\tA[{index}] = ");
            while (!int.TryParse(Console.ReadLine(), out element))
            {
                Console.WriteLine("\nDữ liệu nhập không hợp lệ. Vui lòng nhập lại!\n");
                Console.Write($"\tA[{index}] = ");
            }
            return element;
        }

        public static List<int> GetList()
        {
            int number = GetPositiveInteger("Nhập số lượng phần tử (số nguyên dương): ");

            List<int> listNumber = new List<int>();
            for (int i = 0; i < number; i++)
            {
                listNumber.Add(GetArrayElement(i));
            }

            return listNumber;
        }
    }
}
