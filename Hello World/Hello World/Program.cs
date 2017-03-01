using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    delegate Boolean moreOrlessDelgate(int item);
    class Program
    {
        static void Main(string[] args)
        {
            //// Console.WriteLine("Hello World！！！");
            //int[] ary = { 1, 2, 5, 4, 3, 9, 8, 7 };
            //var query1 = from q in ary
            //             select q;
            //foreach (var item in query1)
            //{
            //    System.Console.WriteLine("{0}",item);

            //}
            //System.Console.ReadLine();
            //string[] str = { "床前明月光疑是地上霜举头望明月低头思故乡" };
            var arr = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var d1 = new moreOrlessDelgate(More);
            Print(arr, d1);
            Console.WriteLine("OK");

            var d2 = new moreOrlessDelgate(Less);
            Print(arr, d2);
            Console.WriteLine("OK");
            Console.ReadKey();
        }
        static void Print(List<int> arr, moreOrlessDelgate dl)
        {
            foreach (var item in arr)
            {
                if (dl(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        static bool More(int item)
        {
            if (item > 3)
            {
                return true;
            }
            return false;
        }
        static bool Less(int item)
        {
            if (item < 3)
            {
                return true;   
            }
            return false;
        }
    }
}
