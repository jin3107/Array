﻿using Array;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userNumbers = ArrayInput.GetList();

            ArrayOutput.PrintList(userNumbers);

            ArrayOutput.CheckSymmetry(userNumbers);

            ArrayOutput.SortList(userNumbers);
        }
    }
}